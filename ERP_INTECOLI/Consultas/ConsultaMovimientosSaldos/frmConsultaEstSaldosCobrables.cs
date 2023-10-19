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
using ERP_INTECOLI.Clases;
using System.Data.SqlClient;
using ERP_INTECOLI.Consultas.ConsultaMovimientosSaldos;

namespace ERP_INTECOLI.Consultas.ConsultaMovimientosSaldos
{
    public partial class frmConsultaEstSaldosCobrables : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public frmConsultaEstSaldosCobrables()
        {
            InitializeComponent();
        }

        private void cmbCargarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                //string sql = "select * from admon.ft_recupera_saldos_cobrables();";
                string sql = @"sp_recupera_saldos_cobrables";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsEstSaldosCobrables1.deudores.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsEstSaldosCobrables1.deudores);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}