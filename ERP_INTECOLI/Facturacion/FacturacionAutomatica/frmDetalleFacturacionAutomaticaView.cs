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
    public partial class frmDetalleFacturacionAutomaticaView : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        PuntoVenta PuntoVentaActual;
        DataOperations dp;
        Int64 Id_H;
        public frmDetalleFacturacionAutomaticaView(UserLogin pUsuarioLogeado, Int64 pIdH)
        {
            InitializeComponent(); 
            dp = new DataOperations();
            UsuarioLogeado = pUsuarioLogeado;
            Id_H = pIdH;
            LoadDatos();
        }
        private void LoadDatos()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand("dbo.sp_get_detalle_transacciones_cargos_generados_for_auto_factura", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsConfigFacturaAutomatica1.detalle_transaccion_h.Clear();
                cmd.Parameters.AddWithValue("@id_h", Id_H);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsConfigFacturaAutomatica1.detalle_transaccion_h);
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