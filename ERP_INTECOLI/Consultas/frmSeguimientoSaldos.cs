using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ERP_INTECOLI.Consultas;
using ERP_INTECOLI.Clases;
using DevExpress.XtraGrid.Views.Grid;
using ERP_INTECOLI.Consultas.SaldosProyeccion;

namespace ERP_INTECOLI.Consultas
{
    public partial class frmSeguimientoSaldos : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogueado;
        DataOperations dp = new DataOperations();

        public frmSeguimientoSaldos(UserLogin pUserLogin)
        {
            InitializeComponent();
            UsuarioLogueado = pUserLogin;
            dtFechaDesde.Value = dp.Now().AddDays(-30);
            dtFechaHasta.Value = dp.Now();
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                dsProyeccionSaldos1.detalle_proximos_pagos1.Clear();
                //string sql = @"select * from admon.ft_recupera_detalle_deudores_inhabilitados_v2(:p_desde,:p_hasta);";
                string sql = @"sp_consultas_recupera_detalle_deudores_inhabilitados_v2";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtFechaDesde.Value);
                cmd.Parameters.AddWithValue("@hasta", dtFechaHasta.Value);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsProyeccionSaldos1.detalle_proximos_pagos1);
                //decimal total = 0;
                //foreach (UltraGridRow row in grDetalle.Rows)
                //{
                //    total += Convert.ToDecimal(row.Cells["valor"].Value);
                //}

                //if (total == 0)
                //    txtValorProyeccion.Text = "0";
                //else
                //    if (total > 1000)
                //    txtValorProyeccion.Text = String.Format("{0:0,000.00}", total);
                //else
                //    txtValorProyeccion.Text = String.Format("{0:00.00}", total);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error("No se pudo cargar los datos!", ec);
            }
        }

        private void cmbBuscar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void txtBusquedaRapida_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void reposEliminar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gridControl1.FocusedView;
            var row = (dsProyeccionSaldos.detalle_proximos_pagos1Row)gridview.GetFocusedDataRow();

            try
            {
                string sql = @"UPDATE estudiante 
                                SET seguimiento_saldo = 0
                                WHERE id_estudiante = " + row.id_estudiante;
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                //cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                conn.Close();
                cmbBuscar_Click(sender, new EventArgs());
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}