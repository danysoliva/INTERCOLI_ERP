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
            LoadSucursales();
            PuntoVentaActual = pPuntoVentaActual;
            IDPuntoVenta = PuntoVentaActual.ID;
            grdSucursales.EditValue = IDPuntoVenta;
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

                    grdvDetalle.OptionsMenu.EnableColumnMenu = false;
                    //Habilita o deshabilita que el user pueda manipular el menu haciendo clic derecho sobre el header de una columna, para elegir columnas, ordenar, etc

                    grdvDetalle.Columns["delete"].Visible = false;
                    //Permite mostrar o ocultar una columna, se utiliza colocando el string de FieldName que se define desde el datasets
                    CargarInfoFactura();
                    
                    break;
                default:
                    break;
            }

            ValidarAccesoUsuarios();

            
        }
        private void LoadSucursales()
        {
            try
            {
                string query = @"[sp_get_lista_puntos_de_venta]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.sucursales.Clear();
                adat.Fill(dsCompras1.sucursales);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void ValidarAccesoUsuarios()
        {
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
            txtSubTotalLps.EditValue = fact.Subtotal;
            txtImpuesto.EditValue = fact.Impuesto;
            txtTotal.EditValue = fact.Total;
            grdSucursales.EditValue = fact.Punto_Venta;
            grdSucursales.Enabled = false;

            grdvDetalle.OptionsMenu.EnableColumnMenu = false;
            //Habilita o deshabilita que el user pueda manipular el menu haciendo clic derecho sobre el header de una columna, para elegir columnas, ordenar, etc

            grdvDetalle.Columns["delete"].Visible = false;
            //Permite mostrar o ocultar una columna, se utiliza colocando el string de FieldName que se define desde el datasets

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

                txtNumFactura.Enabled = true;
                dtFechaContabilizacion.Enabled = true;
                dtFechaDocumento.Enabled = true;
                dtFechaVencimiento.Enabled = true;
                grDetalle.Enabled = true;
                txtSubTotalLps.Enabled = true;
                txtImpuesto.Enabled = true;
                txtComentarios.Enabled = true;
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

            if (Convert.ToDecimal(txtSubTotalLps.EditValue) <= 0)
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
                        cmd.Parameters.AddWithValue("@id_estado", 3);
                        cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogueado.Id);
                        cmd.Parameters.AddWithValue("@comentario",txtComentarios.Text);
                        cmd.Parameters.AddWithValue("@punto_venta", IDPuntoVenta);
                        cmd.Parameters.AddWithValue("@subtotal", txtSubTotalLps.EditValue);
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

            txtSubTotalLps.EditValue = decimal.Round(SubTotal, 2, MidpointRounding.AwayFromZero);
            txtImpuesto.EditValue = decimal.Round(SubTotal * valor_impuesto, 2, MidpointRounding.AwayFromZero);
            txtTotal.EditValue = decimal.Round(SubTotal + Convert.ToDecimal(txtImpuesto.EditValue), 2, MidpointRounding.AwayFromZero);

        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            grdvDetalle.OptionsMenu.EnableColumnMenu = false;
            //Habilita o deshabilita que el user pueda manipular el menu haciendo clic derecho sobre el header de una columna, para elegir columnas, ordenar, etc

            grdvDetalle.Columns["delete"].Visible = true;
            //Permite mostrar o ocultar una columna, se utiliza colocando el string de FieldName que se define desde el datasets
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

            txtSubTotalLps.EditValue = 0.00;
            txtImpuesto.EditValue = 0.00;
            txtTotal.EditValue = 0.00;
            grdSucursales.Enabled = true;
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

                SubTotal += (Convert.ToDecimal(row["total"]));
            }

            txtSubTotalLps.EditValue = decimal.Round(SubTotal, 2, MidpointRounding.AwayFromZero);

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
            Operacion = TipoOperacion.Update;
            if (Id_FacturaActual == 0)//vamos a mostrar el ultimo
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("[sp_get_last_or_first_facturas_proveedores]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@case", 3);//Facturas
                    cmd.Parameters.AddWithValue("@PuntoVentaActual", IDPuntoVenta);
                    Id_FacturaActual = Convert.ToInt32(cmd.ExecuteScalar());
                    CargarInfoFactura();
                    con.Close();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }
            else//vamos a mostrar el anteior al actual
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("sp_get_navigation_factura", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@case", 3);
                    cmd.Parameters.AddWithValue("@idactual", Id_FacturaActual);
                    cmd.Parameters.AddWithValue("@PuntoVentaActual", IDPuntoVenta);
                    Id_FacturaActual = Convert.ToInt32(cmd.ExecuteScalar());

                    if (Id_FacturaActual == 0)
                    {
                        //Si es cero debemos cargar el primero
                        cmd = new SqlCommand("[sp_get_navigation_ordenes_compra]", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@case", 4);
                        cmd.Parameters.AddWithValue("@idactual", Id_FacturaActual);
                        cmd.Parameters.AddWithValue("@PuntoVentaActual", IDPuntoVenta);
                        Id_FacturaActual = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    CargarInfoFactura();
                    con.Close();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }
        }

        private void cmdSiguiente_Click(object sender, EventArgs e)
        {
            Operacion = TipoOperacion.Update;
            if (Id_FacturaActual == 0)//vamos a mostrar el primero
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("sp_get_last_or_first_facturas_proveedores", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@case", 4);
                    cmd.Parameters.AddWithValue("@PuntoVentaActual", IDPuntoVenta);
                    Id_FacturaActual = Convert.ToInt32(cmd.ExecuteScalar());
                    CargarInfoFactura();
                    con.Close();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }
            else//vamos a mostrar el posterior al actual
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("sp_get_navigation_factura", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@case", 3);
                    cmd.Parameters.AddWithValue("@idactual", Id_FacturaActual);
                    cmd.Parameters.AddWithValue("@PuntoVentaActual", IDPuntoVenta);
                    Id_FacturaActual = Convert.ToInt32(cmd.ExecuteScalar());

                    if (Id_FacturaActual == 0)
                    {
                        //Si es cero debemos cargar el primero
                        cmd = new SqlCommand("[sp_get_navigation_ordenes_compra]", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@case", 4);
                        cmd.Parameters.AddWithValue("@idactual", Id_FacturaActual);
                        cmd.Parameters.AddWithValue("@PuntoVentaActual", IDPuntoVenta);
                        Id_FacturaActual = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    CargarInfoFactura();
                    con.Close();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }

        }

        private void barbtnCancelOrden_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult r = CajaDialogo.Pregunta("¿Confirma que desea Cancelar esta Factura?\nSe creara un Registro de Cancelacion en los Productos.");
            if (r != DialogResult.Yes)
                return;

            switch (Operacion)
            {
                case TipoOperacion.Insert:
                    break;
                case TipoOperacion.Update:
                    CancelarFactura(Id_FacturaActual);
                    break;
                default:
                    break;
            }
        }

        private void CancelarFactura(int pid_FacturaActual)
        {
            
            FacturaProveedores fac = new FacturaProveedores();
            fac.Recuperar_FacturaProveedor(pid_FacturaActual);

            bool Proceder;
            string mensaje = "";

            switch (fac.Id_Estado)
            {
                case 1: //Nueva 
                    Proceder = true;
                    break;

                case 5://Pendiente Aprobacion
                    Proceder = true;
                    break;

                case 2: //Abierta
                    Proceder = true;
                    break;

                case 3: //Cerrada
                    Proceder = true;
                    //mensaje = "La Factura esta Cerrada, esta Ligada a una Factura Proveedor, debe Cancelar la Factura primero!";
                    break;

                case 4: //Cancelada
                    Proceder = false;
                    mensaje = "La Factura de Compra se encuentra Cancelada!";
                    break;

                default:
                    Proceder = false;
                    break;
            }

            popupMenu1.HidePopup();

            if (Proceder)
            {
                try
                {
                    SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_compras_factura_cancelar_factura", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_factura_proveedor", pid_FacturaActual);
                    cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogueado.Id);
                    cmd.Parameters.AddWithValue("@fecha_registro", dp.Now());
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    CajaDialogo.Information("Factura de Compra Cancelada!");

                    cmdNuevo.Enabled = false;
                    cmdAddDetalle.Enabled = false;
                    txtComentarios.Enabled = false;
                    grDetalle.Enabled = false;
                    dtFechaContabilizacion.Enabled = false;
                    txtComentarios.Text = "Cancelada";

                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
            }
            else
            {
                CajaDialogo.Error(mensaje);
                return;
            }
        }

        private void panelControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (Id_FacturaActual > 0)
                {
                    popupMenu1.ShowPopup(Cursor.Position);
                }
            }
        }

        private void grDetalle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (Id_FacturaActual > 0)
                {
                    popupMenu1.ShowPopup(Cursor.Position);
                }
            }
        }

        private void panelControl2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (Id_FacturaActual > 0)
                {
                    popupMenu1.ShowPopup(Cursor.Position);
                }
            }
        }

        private void ButtonDeleteRow_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            DialogResult r = CajaDialogo.Pregunta("Confirma que desea elminar este registro?");
            if (r != DialogResult.Yes)
            {
                return;
            }

            var grdvDetalle = (GridView)grDetalle.FocusedView;
            var row = (dsCompras.oc_detalleRow)grdvDetalle.GetFocusedDataRow();

            try
            {
                grdvDetalle.DeleteRow(grdvDetalle.FocusedRowHandle);
                dsCompras1.AcceptChanges();
                CalcularTotal();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}