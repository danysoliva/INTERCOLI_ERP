using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using ERP_INTECOLI.Clases;
using LOSA.Calidad.LoteConfConsumo;
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

namespace ERP_INTECOLI.Compras
{
    public partial class frmOrdenesCompraMain : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogueado;
        DataOperations dp = new DataOperations();
        PuntoVenta PuntoDeVentaActual;
        TipoOperacion tipooperacion;
        int IdOrdenCompraActual;
        int IdEstadoOrdenCompra;
        int IdSolicitud = 0;
        string direccion;
        int PuntoVentaID;
        public enum TipoOperacion
        {
            New = 1,
            Update = 2
        }

        public frmOrdenesCompraMain(UserLogin pUserLog, TipoOperacion ptipo, PuntoVenta pPuntoDeVentaActual)
        {
            InitializeComponent();
            UsuarioLogueado = pUserLog;
            this.PuntoDeVentaActual = pPuntoDeVentaActual;
            PuntoVentaID = PuntoDeVentaActual.ID;
            LoadSucursales();
            grdSucursales.EditValue = PuntoVentaID;
            tipooperacion = ptipo;
            switch (tipooperacion)
            {
                case TipoOperacion.New:

                    txtUsuarioCreador.Text = UsuarioLogueado.Nombre;
                    //GetSigID();
                    txtEstado.Text = "Nueva";
                    cmdNuevo.Enabled = false;
                    break;
                case TipoOperacion.Update:
                    break;
                default:
                    break;
            }

            ValidarAccesosSegunUsuario();

           
        }

        private void ValidarAccesosSegunUsuario()
        {
            int i = Convert.ToInt32(UsuarioLogueado.GrupoUsuario.GrupoUsuarioActivo);

            switch (UsuarioLogueado.GrupoUsuario.GrupoUsuarioActivo)
            {
                case GrupoUser.GrupoUsuario.Manager:
                    grdSucursales.Visible = true;
                    lblSucursal.Visible = true;
                    grdSucursales.Enabled = true;
                    lblSucursal.Enabled = true;
                    break;
                case GrupoUser.GrupoUsuario.Facturacion:
                    grdSucursales.Visible = false;
                    lblSucursal.Visible = false;
                    break;
                case GrupoUser.GrupoUsuario.Atencion_al_cliente:
                    grdSucursales.Visible = false;
                    lblSucursal.Visible = false;
                    break;
                case GrupoUser.GrupoUsuario.Cajero:
                    grdSucursales.Visible = false;
                    lblSucursal.Visible = false;
                    break;
                case GrupoUser.GrupoUsuario.Supervisor:
                    grdSucursales.Visible = true;
                    lblSucursal.Visible = true;
                    break;
                default:
                    break;
            }

            grdSucursales.EditValue = PuntoVentaID;
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

        private void txtCodProv_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmSearchDefault frm = new frmSearchDefault(frmSearchDefault.TipoBusqueda.Proveedores);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtCodProv.Text = frm.ItemSeleccionado.ItemCode;
                txtProveedor.Text = frm.ItemSeleccionado.ItemName;
                Proveedor prov = new Proveedor();
                prov.RecuperarRegistroFromItemCode(frm.ItemSeleccionado.ItemCode);
                direccion = prov._direccion;
                cmdNuevo.Enabled = true;
            }
        }

        private void barButtonSolcitudCompra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnShowPopu_Click(object sender, EventArgs e)
        {
            switch (tipooperacion)
            {
                case TipoOperacion.New:

                    frmSearchSolicitud frm = new frmSearchSolicitud(frmSearchSolicitud.FiltroSolicitudes.Abiertas);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        IdSolicitud = frm.IdSolicitudSeleccionado;
                        Solicitud soli = new Solicitud();
                        soli.RecuperarRegistros(IdSolicitud);
                        txtComentarios.Text = soli.Comentario;
                        
                        CargarDetalleOrdenCompraFromSolicitud(frm.IdSolicitudSeleccionado);

                    }

                    cmdNuevo.Enabled = true;

                    break;
                case TipoOperacion.Update:
                    break;
                default:
                    break;
            }
        }

        private void CargarDetalleOrdenCompraFromSolicitud(int idSolicitudSeleccionado)
        {
            try
            {
                string query = @"sp_get_solicitud_detalle_for_oc";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_solicitud_h", idSolicitudSeleccionado);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.oc_detalle.Clear();
                adat.Fill(dsCompras1.oc_detalle);
                conn.Close();

                CalcularTotal();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void CargarDetalleOrdenCompra(int idSolicitudSeleccionado)
        {
            
            try
            {
                string query = @"[sp_get_compras_ordenes_detalle]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_header_orden", idSolicitudSeleccionado);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.oc_detalle.Clear();
                adat.Fill(dsCompras1.oc_detalle);
                conn.Close();

                CalcularTotal();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void grdvDetalle_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gridView = (GridView)grDetalle.FocusedView;
            var row = (dsCompras.oc_detalleRow)gridView.GetFocusedDataRow();

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

        private void cmdAddDetalle_Click(object sender, EventArgs e)
        {
            frmSearchDefault frm = new frmSearchDefault(frmSearchDefault.TipoBusqueda.ProductoTerminado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                switch (tipooperacion)
                {
                    case TipoOperacion.New:
                        bool Agregar = true;

                        foreach (dsCompras.oc_detalleRow item in dsCompras1.oc_detalle)
                        {
                            
                            if (item.itemcode == frm.ItemSeleccionado.ItemCode)
                            {
                                item.cantidad = item.cantidad + 1;
                                Agregar = false;

                            }
                            
                            
                        }

                        if (Agregar)
                        {
                            DataRow dr = dsCompras1.oc_detalle.NewRow();
                            dr[0] = 0;
                            dr[1] = frm.ItemSeleccionado.ItemName;
                            dr[2] = frm.ItemSeleccionado.ItemCode; ;
                            dr[3] = 1;
                            dr[4] = 0;
                            dr[5] = 0;
                            //dr[6] = 0;
                            dsCompras1.oc_detalle.Rows.Add(dr);
                        }
                        break;
                    case TipoOperacion.Update:



                        break;
                    default:
                        break;
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

            
            if (row.id_detalle > 0)
            {
                try
                {
                    string a = @"sp_compras_orden_delete_detalle";
                    SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(a, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_detalle", row.id_detalle);
                    cmd.ExecuteNonQuery();

                    CargarDetalleOrdenCompra(IdOrdenCompraActual);
                    CalcularTotal();
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
            }
            else
            {
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

            //foreach (dsCompras.oc_detalleRow item in dsCompras1.oc_detalle.Rows)
            //{
                
            //    SubTotal += item.total;
            //}

            txtSubtotal.EditValue = decimal.Round(SubTotal, 2,MidpointRounding.AwayFromZero);

            Impuesto isv = new Impuesto();
            if (isv.RecuperarRegistro(1))
            {
                valor_impuesto = isv.Valor;
            }
            else
                valor_impuesto = Convert.ToDecimal(isv15);
            txtImpuesto.EditValue = decimal.Round(SubTotal * valor_impuesto, 2,MidpointRounding.AwayFromZero);
            txtTotal.EditValue = decimal.Round(SubTotal + Convert.ToDecimal(txtImpuesto.EditValue),2,MidpointRounding.AwayFromZero);
            
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            ValidarAccesosSegunUsuario();
        }

        private void LimpiarControles()
        {
            tipooperacion = TipoOperacion.New;
            dtFechaContabilizacion.Value = dp.Now();
            dtFechaRegistro.Value = dp.Now();
            txtEstado.Text = "Nueva";
            IdSolicitud = 0;
            IdOrdenCompraActual = 0;
            txtComentarios.Clear();
            txtComentarios.Enabled = true;
            grDetalle.Enabled = true;
            dtFechaContabilizacion.Enabled = true;
            cmdGuardar.Enabled = true;
            cmdAddDetalle.Enabled = true;
            txtCodProv.Enabled = true;
            txtUsuarioCreador.Text = UsuarioLogueado.Nombre;
            dsCompras1.oc_detalle.Clear();
            txtCodProv.Clear();
            txtProveedor.Clear();
            txtDocNum.Clear();
            btnPrint.Enabled = false;
            //GetSigID();

        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            frmSearchOrdenesC frm = new frmSearchOrdenesC(frmSearchOrdenesC.FiltroOrdenesCompra.Todas, PuntoDeVentaActual, UsuarioLogueado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //CargarSolicitud(frm.IdSolicitudSeleccionado);
                CargarInfoOrden(frm.IdOrdenesSeleccionado);
            }

            cmdNuevo.Enabled = true;
        }

        private void CargarInfoOrden(int pidOrdenesSeleccionado)
        {
            OrdenesCompra oc = new OrdenesCompra();
            if (oc.RecuperarRegistos(pidOrdenesSeleccionado))
            {
                txtUsuarioCreador.Text = oc.Usuario_Cre;
                txtDocNum.Text = oc.DocNum1;
                IdOrdenCompraActual = oc.Id_OrdenCompra;
                txtEstado.Text = oc.Estado;
                dtFechaRegistro.Value = oc.Fecha_Registro;
                dtFechaContabilizacion.Value = oc.Fecha_Contabilizacion;
                txtComentarios.Text = oc.Comentario;
                IdEstadoOrdenCompra = oc.Id_Estado;
                IdSolicitud = oc.Id_Solicitud;
                txtCodProv.Text = oc.Itemcode_Prov;
                txtProveedor.Text = oc.Nombre_Prov;
                direccion = oc.Direccion;
                txtSubtotal.EditValue = oc.Subtotal;
                txtImpuesto.EditValue = oc.Impuesto;
                txtTotal.EditValue = oc.Total;
                grdSucursales.EditValue = oc.Id_PuntoVenta;
                grdSucursales.Enabled = false;
                CargarDetalleOrdenCompra(oc.Id_OrdenCompra);
                tipooperacion = TipoOperacion.Update;

                switch (IdEstadoOrdenCompra)
                {
                    case 1://Nueva
                        cmdNuevo.Enabled = true;
                        cmdAddDetalle.Enabled = true;
                        txtComentarios.Enabled = true;
                        grDetalle.Enabled = true;
                        dtFechaContabilizacion.Enabled = true;
                        btnPrint.Enabled = false;
                        break;

                    case 2://Abierta
                        cmdNuevo.Enabled = true;
                        cmdAddDetalle.Enabled = true;
                        txtComentarios.Enabled = true;
                        grDetalle.Enabled = true;
                        dtFechaContabilizacion.Enabled = true;
                        btnPrint.Enabled = true;
                        break;

                    case 3://Cerrada
                        cmdNuevo.Enabled = false;
                        cmdAddDetalle.Enabled = false;
                        txtComentarios.Enabled = false;
                        grDetalle.Enabled = false;
                        dtFechaContabilizacion.Enabled = false;
                        cmdGuardar.Enabled = false;
                        txtCodProv.Enabled = false;
                        btnPrint.Enabled = true;
                        break;

                    case 4://Cancelada
                        cmdNuevo.Enabled = false;
                        cmdAddDetalle.Enabled = false;
                        txtComentarios.Enabled = false;
                        grDetalle.Enabled = false;
                        dtFechaContabilizacion.Enabled = false;
                        cmdGuardar.Enabled = false;
                        txtCodProv.Enabled = false;
                        break;

                    default:
                        break;
                }

            }
        }

        private void txtCodProv_Click(object sender, EventArgs e)
        {
            frmSearchDefault frm = new frmSearchDefault(frmSearchDefault.TipoBusqueda.Proveedores);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtCodProv.Text = frm.ItemSeleccionado.ItemCode;
                txtProveedor.Text = frm.ItemSeleccionado.ItemName;
                Proveedor prov = new Proveedor();
                prov.RecuperarRegistroFromItemCode(frm.ItemSeleccionado.ItemCode);
                direccion = prov._direccion;
                cmdNuevo.Enabled = true;
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdAnterior_Click(object sender, EventArgs e)
        {
            tipooperacion = TipoOperacion.Update;
            if (IdOrdenCompraActual == 0)//vamos a mostrar el ultimo
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("[sp_get_last_or_first_solicitud_and_oc]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@case", 3);//Ordenes de Compra
                    cmd.Parameters.AddWithValue("@PuntoVentaActual", PuntoDeVentaActual.ID);
                    IdOrdenCompraActual = Convert.ToInt32(cmd.ExecuteScalar());
                    CargarInfoOrden(IdOrdenCompraActual);
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

                    SqlCommand cmd = new SqlCommand("[sp_get_navigation_ordenes_compra]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@case", 3);
                    cmd.Parameters.AddWithValue("@idactual", IdOrdenCompraActual);
                    cmd.Parameters.AddWithValue("@PuntoVentaActual", PuntoDeVentaActual.ID);
                    IdOrdenCompraActual = Convert.ToInt32(cmd.ExecuteScalar());

                    if (IdOrdenCompraActual == 0)
                    {
                        //Si es cero debemos cargar el primero
                        cmd = new SqlCommand("[sp_get_navigation_ordenes_compra]", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@case", 4);
                        cmd.Parameters.AddWithValue("@idactual", IdOrdenCompraActual);
                        cmd.Parameters.AddWithValue("@PuntoVentaActual", PuntoDeVentaActual.ID);
                        IdOrdenCompraActual = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    CargarInfoOrden(IdOrdenCompraActual);
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
            tipooperacion = TipoOperacion.Update;
            if (IdOrdenCompraActual == 0)//vamos a mostrar el primero
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("[sp_get_last_or_first_solicitud_and_oc]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@case", 4);
                    cmd.Parameters.AddWithValue("@PuntoVentaActual", PuntoDeVentaActual.ID);
                    IdOrdenCompraActual = Convert.ToInt32(cmd.ExecuteScalar());
                    CargarInfoOrden(IdOrdenCompraActual);
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

                    SqlCommand cmd = new SqlCommand("sp_get_navigation_ordenes_compra", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@case", 3);
                    cmd.Parameters.AddWithValue("@idactual", IdOrdenCompraActual);
                    cmd.Parameters.AddWithValue("@PuntoVentaActual", PuntoDeVentaActual.ID);
                    IdOrdenCompraActual = Convert.ToInt32(cmd.ExecuteScalar());

                    if (IdOrdenCompraActual == 0)
                    {
                        //Si es cero debemos cargar el primero
                        cmd = new SqlCommand("[sp_get_navigation_ordenes_compra]", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@case", 4);
                        cmd.Parameters.AddWithValue("@idactual", IdOrdenCompraActual);
                        cmd.Parameters.AddWithValue("@PuntoVentaActual", PuntoDeVentaActual.ID);
                        IdOrdenCompraActual = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    CargarInfoOrden(IdOrdenCompraActual);
                    con.Close();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }


        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodProv.Text))
            {
                CajaDialogo.Error("Debe Agregar un Proveedor!");
                return;
            }

            if (string.IsNullOrEmpty(txtComentarios.Text))
            {
                CajaDialogo.Error("Debe agregar un comentario!");
                return;
            }

            if (grdvDetalle.RowCount == 0)
            {
                CajaDialogo.Error("Debe seleccionar 1 Producto!");
                return;
            }

            foreach (dsCompras.oc_detalleRow item in dsCompras1.oc_detalle.Rows)
            {
                if (item.cantidad <= 0)
                {
                    CajaDialogo.Error("Cantidad debe ser Mayor que (0)!");
                    return;
                }
            }
           
            switch (tipooperacion)
            { 
                

                case TipoOperacion.New:
                    bool Guardar = false;
                    SqlTransaction transaction = null;

                    SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);

                    try
                    {
                        conn.Open();
                        transaction = conn.BeginTransaction("Transaction Order");

                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "sp_compras_ordenes_insert";
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (IdSolicitud == 0)
                            cmd.Parameters.AddWithValue("@id_solicitud", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@id_solicitud", IdSolicitud);
                        cmd.Parameters.AddWithValue("@code_prov",txtCodProv.Text.Trim());
                        cmd.Parameters.AddWithValue("@proveedor",txtProveedor.Text);
                        //cmd.Parameters.AddWithValue("@id_estado", 2);
                        cmd.Parameters.AddWithValue("@fecha_registro", dtFechaRegistro.Value);
                        cmd.Parameters.AddWithValue("@fecha_contabilizacion",dtFechaContabilizacion.Value);
                        cmd.Parameters.AddWithValue("@direccion",direccion);
                        cmd.Parameters.AddWithValue("@comentario", txtComentarios.Text);
                        cmd.Parameters.AddWithValue("@impuesto",txtImpuesto.EditValue);
                        cmd.Parameters.AddWithValue("@subtotal",txtSubtotal.EditValue);
                        cmd.Parameters.AddWithValue("@total",txtTotal.EditValue);
                        cmd.Parameters.AddWithValue("@id_user_cre", UsuarioLogueado.Id);
                        cmd.Parameters.AddWithValue("@id_punto_venta", PuntoVentaID);
                        int id_header = Convert.ToInt32(cmd.ExecuteScalar());

                        foreach (dsCompras.oc_detalleRow row in dsCompras1.oc_detalle.Rows)
                        {
                            cmd.Parameters.Clear();
                            cmd.CommandText = "sp_compras_ordenes_detalle_insert";
                            cmd.Connection = conn;
                            cmd.Transaction = transaction;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_header_orden", id_header);
                            //cmd.Parameters.AddWithValue("@id_pt", row.);
                            cmd.Parameters.AddWithValue("@itemcode", row.itemcode);
                            cmd.Parameters.AddWithValue("@descripcion", row.descripcion);
                            cmd.Parameters.AddWithValue("@cantidad", row.cantidad);
                            cmd.Parameters.AddWithValue("@precio", row.precio);
                            cmd.Parameters.AddWithValue("@total_linea", Convert.ToDecimal(row.cantidad*row.precio));
                            cmd.Parameters.AddWithValue("@fecha_creacion", dp.Now());
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
                        CajaDialogo.Information("Orden de Compra Creada!");

                        LimpiarControles();
                        //this.DialogResult = DialogResult.OK;
                        //this.Close();
                    }

                  
                    break;
                case TipoOperacion.Update:


                    SqlTransaction transactionUpdate = null;

                    SqlConnection connUpdate = new SqlConnection(dp.ConnectionStringERP);
                    bool GuardarUpdate = false;

                    try
                    {
                        connUpdate.Open();
                        transactionUpdate = connUpdate.BeginTransaction("Transaction Order");
                        SqlCommand cmdUpdate = connUpdate.CreateCommand();
                        cmdUpdate.CommandText = "sp_compras_ordenes_update";
                        cmdUpdate.Connection = connUpdate;
                        cmdUpdate.Transaction = transactionUpdate;
                        cmdUpdate.CommandType = CommandType.StoredProcedure;
                        cmdUpdate.Parameters.AddWithValue("@id_orden",IdOrdenCompraActual);
                        cmdUpdate.Parameters.AddWithValue("@code_prov",txtCodProv.Text.Trim());
                        cmdUpdate.Parameters.AddWithValue("@proveedor",txtProveedor.Text);
                        cmdUpdate.Parameters.AddWithValue("@fecha_contabilizacion",dtFechaContabilizacion.Value);
                        cmdUpdate.Parameters.AddWithValue("@direccion",direccion);
                        cmdUpdate.Parameters.AddWithValue("@comentario",txtComentarios.Text);
                        cmdUpdate.Parameters.AddWithValue("@impuesto",txtImpuesto.EditValue);
                        cmdUpdate.Parameters.AddWithValue("@subtotal",txtSubtotal.EditValue);
                        cmdUpdate.Parameters.AddWithValue("@total",txtTotal.EditValue);
                        cmdUpdate.Parameters.AddWithValue("@id_user_modi",UsuarioLogueado.Id);
                        cmdUpdate.Parameters.AddWithValue("@fecha_modi",dp.Now());
                        cmdUpdate.ExecuteNonQuery();

                        foreach (dsCompras.oc_detalleRow row in dsCompras1.oc_detalle.Rows)
                        {
                            cmdUpdate.Parameters.Clear();
                            cmdUpdate.CommandText = "sp_compras_ordenes_detalle_insert";
                            cmdUpdate.Connection = connUpdate;
                            cmdUpdate.Transaction = transactionUpdate;
                            cmdUpdate.CommandType = CommandType.StoredProcedure;
                            cmdUpdate.Parameters.AddWithValue("@id_header_orden", IdOrdenCompraActual);
                            //cmd.Parameters.AddWithValue("@id_pt", row.);
                            cmdUpdate.Parameters.AddWithValue("@itemcode", row.itemcode);
                            cmdUpdate.Parameters.AddWithValue("@descripcion", row.descripcion);
                            cmdUpdate.Parameters.AddWithValue("@cantidad", row.cantidad);
                            cmdUpdate.Parameters.AddWithValue("@precio", row.precio);
                            cmdUpdate.Parameters.AddWithValue("@total_linea", Convert.ToDecimal(row.cantidad * row.precio));
                            cmdUpdate.Parameters.AddWithValue("@fecha_creacion", dp.Now());
                            cmdUpdate.ExecuteNonQuery();
                        }


                        GuardarUpdate = true;
                        transactionUpdate.Commit();
                        GuardarUpdate = true;

                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                        GuardarUpdate = false;
                    }

                    if (GuardarUpdate)
                    {
                        CajaDialogo.Information("Orden de Compra Modificada!");

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }

                    break;
                default:
                    CajaDialogo.Error("No se pudo definir una Operacion de Tipo(INSERT-UPDATE)");
                    break;
            }
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtFechaContabilizacion_ValueChanged(object sender, EventArgs e)
        {
            //if (dtFechaRegistro.Value > dtFechaContabilizacion.Value)
            //{
            //    CajaDialogo.Error("La Fecha de Contabilizacion no puede ser menor a la de Registro!");
            //    dtFechaContabilizacion.Value = dtFechaRegistro.Value;
            //    return;
            //}
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (IdOrdenCompraActual > 0)
            {
                rptOrdenCompra report = new rptOrdenCompra(IdOrdenCompraActual) { DataSource = dsCompras1, DataMember = "oc_detalle", ShowPrintMarginsWarning = false };
                report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                ReportPrintTool reportPrint = new ReportPrintTool(report);
                reportPrint.ShowPreview();
            }
            else
            {
                CajaDialogo.Error("Debe seleccionar una Orden de Compra!");
                return;
            }
        }

        private void panelControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (IdOrdenCompraActual > 0)
                {
                    popupMenu1.ShowPopup(Cursor.Position);
                }
            }
        }

        private void grDetalle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (IdOrdenCompraActual > 0)
                {
                    popupMenu1.ShowPopup(Cursor.Position);
                }
            }
        }

        private void panelControl2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (IdOrdenCompraActual > 0)
                {
                    popupMenu1.ShowPopup(Cursor.Position);
                }
            }
        }

        private void barbtnCancelOrden_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult r = CajaDialogo.Pregunta("¿Confirma que desea Cancelar esta Orden de Compra?");
            if (r != DialogResult.Yes)
                return;

            switch (tipooperacion)
            {
                case TipoOperacion.New:
                    break;
                case TipoOperacion.Update:
                    CancelarOrdenCompra(IdOrdenCompraActual);
                    break;
                default:
                    break;
            }
        }

        private void CancelarOrdenCompra(int pidOrdenCompraActual)
        {
            OrdenesCompra oc = new OrdenesCompra();
            oc.RecuperarRegistos(pidOrdenCompraActual);

            bool Proceder;
            string mensaje = "";

            switch (oc.Id_Estado)
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
                    Proceder = false;
                    mensaje = "La Orden de Compra esta Cerrada, esta Ligada a una Factura Proveedor, debe Cancelar la Factura primero!";
                    break;

                case 4: //Cancelada
                    Proceder = false;
                    mensaje = "La Orden de Conpra se encuentra Cancelada!";
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
                    SqlCommand cmd = new SqlCommand("sp_compras_cancelar_orden", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_OrdenCompra", pidOrdenCompraActual);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    CajaDialogo.Information("Orden de Compra Cancelada!");

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

        private void grdSucursales_EditValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(grdSucursales.EditValue) > 0)
            {
                PuntoVentaID = Convert.ToInt32(grdSucursales.EditValue);
            }
        }
    }
}