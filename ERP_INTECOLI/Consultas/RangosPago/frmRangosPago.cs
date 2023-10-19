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
using ERP_INTECOLI.Consultas.RangosPago;
using ERP_INTECOLI.Clases;
using System.Data.SqlClient;

namespace ERP_INTECOLI.Consultas.RangosPago
{
    public partial class frmRangosPago : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public frmRangosPago()
        {
            InitializeComponent();
        }

        private void frmRangosPago_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                //string sql = "select * from admon.ft_recupera_rangos_pago ();";
                string sql = @"sp_recupera_rangos_pago";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsRangosPagos1.rangos);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}