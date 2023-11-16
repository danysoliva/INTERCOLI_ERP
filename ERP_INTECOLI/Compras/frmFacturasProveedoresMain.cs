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
using LOSA.Calidad.LoteConfConsumo;
using System.Data.SqlClient;

namespace ERP_INTECOLI.Compras
{
    public partial class frmFacturasProveedoresMain : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogueado;
        public int Id_FacturaActual = 0;
        int Id_Estado;
        string Direccion;
        public enum TipoOperacion
        {
            Insert = 1,
            Update = 2
        }

        TipoOperacion Operacion;
        public frmFacturasProveedoresMain(UserLogin pUserLog, TipoOperacion pTipo)
        {
            InitializeComponent();
            UsuarioLogueado = pUserLog;
            Operacion = pTipo;

            switch (Operacion)
            {
                case TipoOperacion.Insert:
                    txtUsuarioCreador.Text = UsuarioLogueado.Nombre;
                    dtFechaContabilizacion.Value = dp.Now();
                    dtFechaVencimiento.Value = dp.Now().AddDays(30);
                    dtFechaDocumento.Value = dp.Now();
                    txtEstado.Text = "Nueva";
                    break;
                case TipoOperacion.Update:

                    CargarInfoFactura();
                    
                    break;
                default:
                    break;
            }
        }

        private void CargarInfoFactura()
        {
            FacturaProveedores fact = new FacturaProveedores();
            fact.Recuperar_FacturaProveedor(Id_FacturaActual);
            txtCodProv.Text = fact.Code_prov;
            txtProveedor.Text = fact.Proveedor;
            txtCAI.Text = fact.Cai;
            txtNumFactura.Text = fact.Num_Factura;
            txtId.Text = fact.Id_Factura.ToString();
            dtFechaContabilizacion.Value = fact.Fecha_Contabilizacion;
            dtFechaVencimiento.Value = fact.Fecha_Vencimiento;
            dtFechaDocumento.Value = fact.Fecha_Documento;
            txtEstado.Text = fact.Estado;
            Id_Estado = fact.Id_Estado;
            txtUsuarioCreador.Text = fact.Usuario_creador;
            txtComentarios.Text = fact.Comentario;
            txtSubtotal.EditValue = fact.Subtotal;
            txtImpuesto.EditValue = fact.Impuesto;
            txtTotal.EditValue = fact.Total;

            CargarDetalleFactura();

        }

        private void CargarDetalleFactura()
        {
            try
            {
                string query = @"sp_compras_get_detalle_factura";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("",);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.factura_detalle.Clear();
                adat.Fill(dsCompras1.factura_detalle);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodProv_Click(object sender, EventArgs e)
        {
            BuscarProveedor();
        }

        private void BuscarProveedor()
        {
            frmSearchDefault frm = new frmSearchDefault(frmSearchDefault.TipoBusqueda.Proveedores);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtCodProv.Text = frm.ItemSeleccionado.ItemCode;
                txtProveedor.Text = frm.ItemSeleccionado.ItemName;
                Proveedor prov = new Proveedor();
                prov.RecuperarRegistroFromItemCode(frm.ItemSeleccionado.ItemCode);
                Direccion = prov._direccion;
                cmdNuevo.Enabled = true;
                btnShowPopu.Enabled = true;
            }
        }

        private void txtCodProv_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            BuscarProveedor();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}