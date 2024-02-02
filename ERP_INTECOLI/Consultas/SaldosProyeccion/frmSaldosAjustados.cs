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
using ERP_INTECOLI.Clases;
using ERP_INTECOLI.Consultas;
using ERP_INTECOLI.Consultas.SaldosProyeccion;

namespace ERP_INTECOLI.Administracion.Consultas
{
    public partial class frmSaldosAjustados : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogueado;

        public frmSaldosAjustados(UserLogin pUserLogin)
        {
            InitializeComponent();
            UsuarioLogueado = pUserLogin;
            dtFechaHasta.Value = dp.Now();
            dtFechaDesde.Value = dp.Now().AddDays(-30);

            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                dsProyeccionSaldos1.detalle_proximos_pagos.Clear();
                //string sql = @"select * from admon.ft_recupera_proyeccion (:fecha_desde, :fecha_hasta);";
                string sql = @"sp_get_recupera_proyeccion";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha_desde", dtFechaDesde.Value);
                cmd.Parameters.AddWithValue("@fecha_hasta", dtFechaHasta.Value);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsProyeccionSaldos1.detalle_proximos_pagos);
                decimal total = 0;
                //foreach (UltraGridRow row in grDetalle.Rows)
                //{
                //    total += Convert.ToDecimal(row.Cells["valor"].Value);
                //}

                foreach (dsProyeccionSaldos.detalle_proximos_pagosRow item in dsProyeccionSaldos1.detalle_proximos_pagos.Rows)
                {
                    total += item.valor;
                }

                if (total == 0)
                    txtValorProyeccion.Text = "0";
                else
                    if (total > 1000)
                    txtValorProyeccion.Text = String.Format("{0:0,000.00}", total);
                else
                    txtValorProyeccion.Text = String.Format("{0:00.00}", total);
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

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}