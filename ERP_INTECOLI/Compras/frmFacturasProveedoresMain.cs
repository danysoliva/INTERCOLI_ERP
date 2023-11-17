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
using DevExpress.XtraGrid.Views.Grid;

namespace ERP_INTECOLI.Compras
{
    public partial class frmFacturasProveedoresMain : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogueado;
        public int Id_FacturaActual = 0;
        int Id_OrdenCompra = 0;
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
            Id_FacturaActual = fact.Id_Factura;
            Direccion = fact.Direccion;
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
            if (string.IsNullOrEmpty(txtCodProv.Text))
            {
                CajaDialogo.Error("Debe seleccionar un Proveedor!");
                return;
            }

            if (string.IsNullOrEmpty(txtCAI.Text))
            {
                CajaDialogo.Error("Debe seleccionar un CAI!");
                return;
            }

            if (string.IsNullOrEmpty(txtNumFactura.Text))
            {
                CajaDialogo.Error("Debe digital el Numero de Factura!");
                return;
            }

            if (string.IsNullOrEmpty(txtComentarios.Text))
            {
                CajaDialogo.Error("Debe escribir un Comentario!");
                return;
            }

            if (Convert.ToDecimal(txtSubtotal.EditValue) <= 0)
            {
                CajaDialogo.Error("No puede Registrar una Factura en 0!");
                return;
            }

            if (dtFechaVencimiento.Value <= dtFechaDocumento.Value || dtFechaVencimiento.Value <= dtFechaContabilizacion.Value)
            {
                CajaDialogo.Error("La Fecha de Vencimiento no puede ser menor que Fecha Contabilizacion y Fecha de Documento!");
                return;
            }

            if (grdvDetalle.DataRowCount == 0)
            {
                CajaDialogo.Error("Debe Agregar por lo menos 1 Articulo!");
                return;
            }

            switch (Operacion)
            {
                case TipoOperacion.Insert:

                    SqlTransaction transaction = null;

                    SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                    bool Guardar = false;

                    try
                    {
                        conn.Open();
                        transaction = conn.BeginTransaction("Transaction Order");

                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "sp_compras_insert_facturas_h";
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (Id_OrdenCompra == 0) 
                            cmd.Parameters.AddWithValue("@id_orden_compra", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@id_orden_compra", Id_OrdenCompra);
                        cmd.Parameters.AddWithValue("@code_prov",txtCodProv.Text.Trim());
                        cmd.Parameters.AddWithValue("@proveedor",txtProveedor.Text);
                        if (string.IsNullOrEmpty(txtPersonaContact.Text))
                            cmd.Parameters.AddWithValue("@persona_contacto", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@persona_contacto", txtPersonaContact.Text);
                        cmd.Parameters.AddWithValue("@direccion",Direccion);
                        cmd.Parameters.AddWithValue("@cai", txtCAI.Text);
                        cmd.Parameters.AddWithValue("@num_factura", txtNumFactura.Text);
                        cmd.Parameters.AddWithValue("@fecha_contabilizacion", dtFechaContabilizacion.Value);
                        cmd.Parameters.AddWithValue("@fecha_vencimiento", dtFechaVencimiento.Value);
                        cmd.Parameters.AddWithValue("@fecha_documento",dtFechaDocumento.Value);
                        cmd.Parameters.AddWithValue("@fecha_registro", dp.Now());
                        cmd.Parameters.AddWithValue("@id_estado", 2);
                        cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogueado.Id);
                        cmd.Parameters.AddWithValue("@comentario",txtComentarios.Text);
                        cmd.Parameters.AddWithValue("@punto_venta", 2); //No lo definido.
                        cmd.Parameters.AddWithValue("@subtotal", txtSubtotal.EditValue);
                        cmd.Parameters.AddWithValue("@impuesto", txtImpuesto.EditValue);
                        cmd.Parameters.AddWithValue("@total", txtTotal.EditValue);
                        
                        int id_header_factura = Convert.ToInt32(cmd.ExecuteScalar());

                        foreach (dsCompras.oc_detalleRow row in dsCompras1.oc_detalle.Rows)
                        {
                            cmd.Parameters.Clear();
                            cmd.CommandText = "sp_compras_inert_factura_d";
                            cmd.Connection = conn;
                            cmd.Transaction = transaction;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_factura", id_header_factura);
                            cmd.Parameters.AddWithValue("@itemcode", row.itemcode);
                            cmd.Parameters.AddWithValue("@descripcion", row.descripcion);
                            cmd.Parameters.AddWithValue("@cantidad",row.cantidad);
                            cmd.Parameters.AddWithValue("@precio",row.precio);
                            cmd.Parameters.AddWithValue("@fecha_registro", dp.Now());
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        Guardar = true;

                        this.DialogResult = DialogResult.OK;
                        this.Close();

                    }
                    catch (Exception ec)
                    {
                        transaction.Rollback();
                        CajaDialogo.Error(ec.Message);
                        Guardar = false;
                    }

                    if (Guardar)
                    {
                        CajaDialogo.Information("Factura Registrada Exitosamente!");
                        LimpiarControles();
                    }

                    break;


                case TipoOperacion.Update:
                    break;
                default:
                    break;
            }
        }

        private void txtSubtotal_EditValueChanged(object sender, EventArgs e)
        {
            decimal SubTotal = 0;
            decimal valor_impuesto = 0;
            double isv15 = 0.15;

            

            Impuesto isv = new Impuesto();
            if (isv.RecuperarRegistro(1))
            {
                valor_impuesto = isv.Valor;
            }
            else
                valor_impuesto = Convert.ToDecimal(isv15);

            txtSubtotal.EditValue = decimal.Round(SubTotal, 2, MidpointRounding.AwayFromZero);
            txtImpuesto.EditValue = decimal.Round(SubTotal * valor_impuesto, 2, MidpointRounding.AwayFromZero);
            txtTotal.EditValue = decimal.Round(SubTotal + Convert.ToDecimal(txtImpuesto.EditValue), 2, MidpointRounding.AwayFromZero);

        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            txtCodProv.Clear();
            txtProveedor.Clear();
            txtCAI.Clear();
            txtNumFactura.Clear();
            txtId.Clear();
            dtFechaContabilizacion.Value = dp.Now();
            dtFechaDocumento.Value = dp.Now();
            dtFechaVencimiento.Value = dp.Now();
            dsCompras1.oc_detalle.Clear();
            txtUsuarioCreador.Text = UsuarioLogueado.Nombre;
            txtComentarios.Clear();
            txtEstado.Text = "Nueva";
            btnShowPopu.Enabled = false;

            txtSubtotal.EditValue = 0.00;
            txtImpuesto.EditValue = 0.00;
            txtTotal.EditValue = 0.00;

            Id_FacturaActual = 0;
            Direccion = "";
            Id_Estado = 0;
        }
    }
}