using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERP_INTECOLI.Clases;

namespace ERP_INTECOLI.Consultas
{
    public partial class frmConsultaAnulados : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public frmConsultaAnulados()
        {
            InitializeComponent();
        }

        private void cmbBuscar_Click(object sender, EventArgs e)
        {
            
            try
            {
                //string sql = "select * from admon.ft_return_lista_anulados_v2(:p_desde, :p_hasta);";
                string sql = @"sp_return_lista_anulados_v2";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtFechaDesde.Value);
                cmd.Parameters.AddWithValue("@hasta", dtHastaF.Value);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsEstudiantes1.detalle_proximos_pagos1.Clear();
                adat.Fill(dsEstudiantes1.detalle_proximos_pagos1);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            
        }
    }
}