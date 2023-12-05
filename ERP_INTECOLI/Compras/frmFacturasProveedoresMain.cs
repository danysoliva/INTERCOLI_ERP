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
        PuntoVenta PuntoVentaActual;
        public int Id_FacturaActual = 0;
        int Id_OrdenCompra = 0;
        int Id_Estado;
        string Direccion;
        int IDPuntoVenta = 0;
        public enum TipoOperacion
        {
            Insert = 1,
            Update = 2
        }

        TipoOperacion Operacion;
        public frmFacturasProveedoresMain(UserLogin pUserLog, TipoOperacion pTipo, PuntoVenta pPuntoVentaActual)
        {
            InitializeComponent();
            UsuarioLogueado = pUserLog;
            PuntoVentaActual = pPuntoVentaActual;
            IDPuntoVenta = PuntoVentaActual.ID;
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

            int i = Convert.ToInt32(UsuarioLogueado.GrupoUsuario.GrupoUsuarioActivo);

            switch (UsuarioLogueado.GrupoUsuario.GrupoUsuarioActivo)
            {
                case GrupoUser.GrupoUsuario.Manager:
                    grdSucursales.Visible = true;
                    lblSucursal.Visible = true;
                    break;
                case GrupoUser.GrupoUsuario.Facturacion:
                    break;
                case GrupoUser.GrupoUsuario.Atencion_al_cliente:
                    break;
                case GrupoUser.GrupoUsuario.Cajero:
                    break;
                case GrupoUser.GrupoUsuario.Supervisor:
                    grdSucursales.Visible = true;
                    lblSucursal.Visible = true;
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
            txtDocNum.Text = fact.DocNum;
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
                cmd.Parameters.AddWithValue("@id_Factura", Id_FacturaActual);
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
                txtPersonaContact.Text = prov.Contacto;
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

            foreach (dsCompras.factura_detalleRow item in dsCompras1.factura_detalle.Rows)
            {
                if (item.cantidad <= 0)
                {
                    CajaDialogo.Error("Cantidad debe ser Mayor que (0)!");
                    return;
                }

                if (item.precio <= 0)
                {
                    CajaDialogo.Error("Precio debe ser Mayor que (0)!");
                    return;
                }
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
                        cmd.Parameters.AddWithValue("@punto_venta", IDPuntoVenta);
                        cmd.Parameters.AddWithValue("@subtotal", txtSubtotal.EditValue);
                        cmd.Parameters.AddWithValue("@impuesto", txtImpuesto.EditValue);
                        cmd.Parameters.AddWithValue("@total", txtTotal.EditValue);
                        
                        int id_header_factura = Convert.ToInt32(cmd.ExecuteScalar());

                        foreach (dsCompras.factura_detalleRow row in dsCompras1.factura_detalle.Rows)
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
                            cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogueado.Id);
                            cmd.Parameters.AddWithValue("@id_punto_facturacion", IDPuntoVenta); //DEFINIR COMO SELECCIONARA EL PUNTO DE VENTA(COMPRA)

                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        Guardar = true;

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
            txtDocNum.Clear();
            dtFechaContabilizacion.Value = dp.Now();
            dtFechaDocumento.Value = dp.Now();
            dtFechaVencimiento.Value = dp.Now();
            dsCompras1.factura_detalle.Clear();
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

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            frmSearchFacturasProveedor frm = new frmSearchFacturasProveedor(frmSearchFacturasProveedor.FiltroFacturas.Todas, PuntoVentaActual, UsuarioLogueado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Id_FacturaActual = frm.IdFacturaSeleccionado;

                CargarInfoFactura();
            }
        }

        private void cmdAddDetalle_Click(object sender, EventArgs e)
        {
            frmSearchDefault frm = new frmSearchDefault(frmSearchDefault.TipoBusqueda.ProductoTerminado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                switch (Operacion)
                {
                    case TipoOperacion.Insert:
                        bool Agregar = true;

                        foreach (dsCompras.factura_detalleRow item in dsCompras1.factura_detalle.Rows)
                        {
                            if (item.itemcode == frm.ItemSeleccionado.ItemCode)
                            {
                                item.cantidad = item.cantidad + 1;
                                Agregar = false;

                            }
                        }

                        if (Agregar)
                        {
                            DataRow dr = dsCompras1.factura_detalle.NewRow();
                            dr[0] = 0;
                            dr[1] = frm.ItemSeleccionado.ItemName;
                            dr[2] = frm.ItemSeleccionado.ItemCode;
                            dr[3] = 1;
                            dr[4] = 0;
                            dr[5] = 0;
                            //dr[6] = 0;
                            dsCompras1.factura_detalle.Rows.Add(dr);
                        }
                        break;
                    case TipoOperacion.Update:



                        break;
                    default:
                        break;
                }

            }
        }

        private void grdvDetalle_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gridView = (GridView)grDetalle.FocusedView;
            var row = (dsCompras.factura_detalleRow)gridView.GetFocusedDataRow();

            try
            {
                if (e.Column.FieldName == "cantidad")
                {
                    row.total = row.cantidad * row.precio;
                    CalcularTotal();
                }

                if (e.Column.FieldName == "precio")
                {
                    row.total = row.cantidad * row.precio;
                    CalcularTotal();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void CalcularTotal()
        {
            decimal SubTotal = 0;
            decimal valor_impuesto = 0;
            double isv15 = 0.15;

            var gridview = (GridView)grDetalle.FocusedView;
            for (int i = 0; i < gridview.DataRowCount; i++)
            {
                DataRow row = gridview.GetDataRow(i);

                SubTotal = SubTotal + (Convert.ToDecimal(row["total"]));
            }

            txtSubtotal.EditValue = decimal.Round(SubTotal, 2, MidpointRounding.AwayFromZero);

            Impuesto isv = new Impuesto();
            if (isv.RecuperarRegistro(1))
            {
                valor_impuesto = isv.Valor;
            }
            else
                valor_impuesto = Convert.ToDecimal(isv15);
            txtImpuesto.EditValue = decimal.Round(SubTotal * valor_impuesto, 2, MidpointRounding.AwayFromZero);
            txtTotal.EditValue = decimal.Round(SubTotal + Convert.ToDecimal(txtImpuesto.EditValue), 2, MidpointRounding.AwayFromZero);

        }

        private void btnShowPopu_Click(object sender, EventArgs e)
        {
            switch (Operacion)
            {
                case TipoOperacion.Insert:

                    frmSearchOrdenesC frm = new frmSearchOrdenesC(frmSearchOrdenesC.FiltroOrdenesCompra.Abiertas, PuntoVentaActual, UsuarioLogueado);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        Id_OrdenCompra = frm.IdOrdenesSeleccionado;
                        OrdenesCompra oc = new OrdenesCompra();
                        oc.RecuperarRegistos(Id_OrdenCompra);
                        txtComentarios.Text = oc.Comentario;

                        CargarDetalleFacturaFromOrdenCompra(frm.IdOrdenesSeleccionado);

                    }

                    cmdNuevo.Enabled = true;

                    break;
                case TipoOperacion.Update:
                    break;
                default:
                    break;
            }
        }

        private void CargarDetalleFacturaFromOrdenCompra(int idOCSeleccionado)
        {
            try
            {
                string query = @"[sp_get_compras_ordenes_detalle]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_header_orden", idOCSeleccionado);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.factura_detalle.Clear();
                adat.Fill(dsCompras1.factura_detalle);
                conn.Close();

                CalcularTotal();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdAnterior_Click(object sender, EventArgs e)
        {

        }

        private void cmdSiguiente_Click(object sender, EventArgs e)
        {

        }
    }
}