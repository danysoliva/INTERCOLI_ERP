﻿using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
        TipoOperacion tipooperacion;
        int IdOrdenCompraActual;
        int IdEstadoOrdenCompra;
        int IdSolicitud = 0;
        string direccion;
        public enum TipoOperacion
        {
            New = 1,
            Update = 2
        }

        public frmOrdenesCompraMain(UserLogin pUserLog, TipoOperacion ptipo)
        {
            InitializeComponent();
            UsuarioLogueado = pUserLog;
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
                        
                        CargarDetalleOrdenCompra(frm.IdSolicitudSeleccionado);

                    }

                    cmdNuevo.Enabled = true;

                    break;
                case TipoOperacion.Update:
                    break;
                default:
                    break;
            }
        }

        private void CargarDetalleOrdenCompra(int idSolicitudSeleccionado)
        {
            
            try
            {
                string query = @"sp_get_solicitud_detalle";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_solicitud_h", idSolicitudSeleccionado);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.oc_detalle.Clear();
                adat.Fill(dsCompras1.oc_detalle);
                conn.Close();
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

                        foreach (dsCompras.oc_detalleRow item in dsCompras1.oc_detalle.Rows)
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
            var gridView = (GridView)grDetalle.FocusedView;
            var row = (dsCompras.oc_detalleRow)gridView.GetFocusedDataRow();

            DialogResult r = CajaDialogo.Pregunta("Confirma que desea elminar este registro?");
            if (r != DialogResult.Yes)
                return;
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
            foreach (dsCompras.oc_detalleRow item in dsCompras1.oc_detalle)
            {
                SubTotal += item.total;
            }

            txtSubtotal.EditValue = SubTotal;

            Impuesto isv = new Impuesto();
            if (isv.RecuperarRegistro(1))
            {
                valor_impuesto = isv.Valor;
            }
            else
                valor_impuesto = Convert.ToDecimal(isv15);
            txtImpuesto.EditValue = SubTotal * valor_impuesto;
            txtTotal.EditValue = SubTotal + Convert.ToDecimal(txtImpuesto.EditValue);
            
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            tipooperacion = TipoOperacion.New;
            dtFechaContabilizacion.Value = dp.Now();
            dtFechaRegistro.Value = dp.Now();
            txtEstado.Text = "Nueva";
            IdSolicitud = 0;
            txtComentarios.Clear();
            txtComentarios.Enabled = true;
            grDetalle.Enabled = true;
            dtFechaContabilizacion.Enabled = true;
            cmdGuardar.Enabled = true;
            cmdAddDetalle.Enabled = true;
            txtCodProv.Enabled = true;
            txtUsuarioCreador.Text = UsuarioLogueado.Nombre;
            dsCompras1.solicitud_compras_detalle.Clear();
            //GetSigID();

        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            frmSearchOrdenesC frm = new frmSearchOrdenesC(frmSearchOrdenesC.FiltroOrdenesCompra.Todas);
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
                txtId.Text = Convert.ToString(oc.Id_OrdenCompra);
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
                        break;

                    case 2://Abierta
                        cmdNuevo.Enabled = true;
                        cmdAddDetalle.Enabled = true;
                        txtComentarios.Enabled = true;
                        grDetalle.Enabled = true;
                        dtFechaContabilizacion.Enabled = true;
                        break;

                    case 3://Cerrada
                        cmdNuevo.Enabled = false;
                        cmdAddDetalle.Enabled = false;
                        txtComentarios.Enabled = false;
                        grDetalle.Enabled = false;
                        dtFechaContabilizacion.Enabled = false;
                        cmdGuardar.Enabled = false;
                        txtCodProv.Enabled = false;
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

                    SqlCommand cmd = new SqlCommand("[sp_get_navigation_solicitudes]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@case", 3);
                    cmd.Parameters.AddWithValue("@idactual", IdOrdenCompraActual);
                    IdOrdenCompraActual = Convert.ToInt32(cmd.ExecuteScalar());

                    if (IdOrdenCompraActual == 0)
                    {
                        //Si es cero debemos cargar el primero
                        cmd = new SqlCommand("[sp_get_navigation_solicitudes]", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@case", 4);
                        cmd.Parameters.AddWithValue("@idactual", IdOrdenCompraActual);
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

                    SqlCommand cmd = new SqlCommand("[sp_get_navigation_solicitudes]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@case", 3);
                    cmd.Parameters.AddWithValue("@idactual", IdOrdenCompraActual);
                    IdOrdenCompraActual = Convert.ToInt32(cmd.ExecuteScalar());

                    if (IdOrdenCompraActual == 0)
                    {
                        //Si es cero debemos cargar el primero
                        cmd = new SqlCommand("[sp_get_navigation_solicitudes]", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@case", 4);
                        cmd.Parameters.AddWithValue("@idactual", IdOrdenCompraActual);
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

                    SqlTransaction transaction = null;

                    SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                    bool Guardar = false;

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

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }

                  
                    break;
                case TipoOperacion.Update:

                    try
                    {
                        SqlConnection connUP = new SqlConnection(dp.ConnectionStringERP);
                        connUP.Open();
                        SqlCommand cmdUP = new SqlCommand("sp_compras_ordenes_update", connUP);
                        cmdUP.CommandType = CommandType.StoredProcedure;
                        cmdUP.Parameters.AddWithValue("@id_orden",IdOrdenCompraActual);
                        cmdUP.Parameters.AddWithValue("@code_prov",txtCodProv.Text.Trim());
                        cmdUP.Parameters.AddWithValue("@proveedor",txtProveedor.Text); 
                        cmdUP.Parameters.AddWithValue("@fecha_contabilizacion",dtFechaContabilizacion.Value);
                        cmdUP.Parameters.AddWithValue("@direccion",direccion);
                        cmdUP.Parameters.AddWithValue("@comentario",txtComentarios.Text);
                        cmdUP.Parameters.AddWithValue("@impuesto",txtImpuesto.EditValue);
                        cmdUP.Parameters.AddWithValue("@subtotal",txtSubtotal.EditValue);
                        cmdUP.Parameters.AddWithValue("@total",txtTotal.EditValue);
                        cmdUP.Parameters.AddWithValue("@id_user_modi",UsuarioLogueado.Id);
                        cmdUP.Parameters.AddWithValue("@fecha_modi",dp.Now());
                        cmdUP.ExecuteNonQuery();
                        Guardar = true;
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                        Guardar = false;
                    }

                    if (Guardar)
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
            if (dtFechaRegistro.Value >= dtFechaContabilizacion.Value)
            {
                CajaDialogo.Error("La Fecha de Contabilizacion no puede ser menor a la de Registro!");
                dtFechaContabilizacion.Value = dtFechaRegistro.Value;
                return;
            }
        }
    }
}