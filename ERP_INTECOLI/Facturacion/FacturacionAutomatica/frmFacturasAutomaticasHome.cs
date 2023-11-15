using DevExpress.XtraEditors;
using ERP_INTECOLI.Clases;
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

namespace ERP_INTECOLI.Facturacion.FacturacionAutomatica
{
    public partial class frmFacturasAutomaticasHome : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        PuntoVenta PuntoVentaActual;
        DataOperations dp;
        public frmFacturasAutomaticasHome(UserLogin pUsuarioLogeado, PuntoVenta pPuntoVenta)
        {
            InitializeComponent();
            dp = new DataOperations();
            UsuarioLogeado = pUsuarioLogeado;
            PuntoVentaActual = pPuntoVenta;
            LoadDatos();
        }

        private void LoadDatos()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand("dbo.sp_get_generacion_automatica_facturas_h", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsConfigFacturaAutomatica1.lista_generacion_h.Clear();
                //cmd.Parameters.AddWithValue("", 0);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsConfigFacturaAutomatica1.lista_generacion_h);
                conn.Close();
            }
            catch (Exception EX)
            {
                CajaDialogo.Error(EX.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}