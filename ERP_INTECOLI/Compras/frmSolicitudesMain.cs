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
using ERP_INTECOLI.Compras;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Calidad.LoteConfConsumo;

namespace ERP_INTECOLI.Compras
{
    public partial class frmSolicitudesMain : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogueado;
        DataOperations dp = new DataOperations();
        TipoOperacion tipooperacion;
        int IdSolicitudActual;
        int IdEstadoSolicitud;
        public frmSolicitudesMain(UserLogin pUserLog, TipoOperacion ptipo)
        {
            InitializeComponent();
            tipooperacion = ptipo;
            UsuarioLogueado = pUserLog;

            switch (tipooperacion)
            {
                case TipoOperacion.New:

                    txtUsuarioCreador.Text = UsuarioLogueado.Nombre;
                    GetSigID();
                    txtEstado.Text = "Nueva";
                    cmdNuevo.Enabled = false;
                    break;
                case TipoOperacion.Update:
                    break;
                default:
                    break;
            }

        }

        private void GetSigID()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_id_sig_operaciones", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@case", 1); //Solicitud de Compra
                txtId.Text = cmd.ExecuteScalar().ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public enum TipoOperacion
        {
            New = 1,
            Update = 2
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


            foreach (dsCompras.solicitud_compras_detalleRow item in dsCompras1.solicitud_compras_detalle.Rows)
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
                        cmd.CommandText = "sp_compras_solicitudes_insert";
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_user", UsuarioLogueado.Id);
                        cmd.Parameters.AddWithValue("@fecha_registro", dtFechaRegistro.Value);
                        cmd.Parameters.AddWithValue("@fecha_contabilizacion", dtFechaContabilizacion.Value); 
                        cmd.Parameters.AddWithValue("@comentario", txtComentarios.Text);

                        int id_header = Convert.ToInt32(cmd.ExecuteScalar());

                        foreach (dsCompras.solicitud_compras_detalleRow row in dsCompras1.solicitud_compras_detalle.Rows)
                        {
                            cmd.Parameters.Clear();
                            cmd.CommandText = "sp_compras_solicitudes_detalle_insert";
                            cmd.Connection = conn;
                            cmd.Transaction = transaction;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_h_solicitud", id_header);
                            cmd.Parameters.AddWithValue("@itemcode", row.itemcode);
                            cmd.Parameters.AddWithValue("@descripcion", row.descripcion);
                            cmd.Parameters.AddWithValue("@cantidad", row.cantidad);
                            cmd.Parameters.AddWithValue("@precio", row.precio);
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
                        CajaDialogo.Information("Solicitud Creada!");

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }

                    break;
                case TipoOperacion.Update:

                    SqlTransaction transaction2 = null;

                    SqlConnection conn2 = new SqlConnection(dp.ConnectionStringERP);
                    bool Guardar1 = false;

                    try
                    {
                        conn2.Open();
                        transaction2 = conn2.BeginTransaction("Transaction Order");

                        SqlCommand cmd = conn2.CreateCommand();
                        cmd.CommandText = "[sp_compras_solicitudes_update]";
                        cmd.Connection = conn2;
                        cmd.Transaction = transaction2;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@fecha_contabilizacion", dtFechaContabilizacion.Value);
                        cmd.Parameters.AddWithValue("@comentario", txtComentarios.Text);
                        cmd.Parameters.AddWithValue("@id_solicitud", IdSolicitudActual);
                        cmd.ExecuteNonQuery();

                        foreach (dsCompras.solicitud_compras_detalleRow row in dsCompras1.solicitud_compras_detalle.Rows)
                        {
                            cmd.Parameters.Clear();
                            cmd.CommandText = "sp_compras_solicitudes_detalle_insert";
                            cmd.Connection = conn2;
                            cmd.Transaction = transaction2;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_h_solicitud", IdSolicitudActual);
                            cmd.Parameters.AddWithValue("@itemcode", row.itemcode);
                            cmd.Parameters.AddWithValue("@descripcion", row.descripcion);
                            cmd.Parameters.AddWithValue("@cantidad", row.cantidad);
                            cmd.Parameters.AddWithValue("@precio", row.precio);
                            cmd.ExecuteNonQuery();
                        }

                        transaction2.Commit();
                        Guardar1 = true;



                    }
                    catch (Exception ec)
                    {
                        transaction2.Rollback();
                        CajaDialogo.Error(ec.Message);
                        Guardar1 = false;
                    }

                    if (Guardar1)
                    {
                        CajaDialogo.Information("Solicitud Creada!");

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }

                    break;
                default:
                    break;
            }


        }

        private void cmdAddDetalle_Click(object sender, EventArgs e)
        {
            frmSearchDefault frm = new frmSearchDefault(frmSearchDefault.TipoBusqueda.ProductoTerminado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                bool Agregar = true;
                
                foreach (dsCompras.solicitud_compras_detalleRow item in dsCompras1.solicitud_compras_detalle.Rows)
                {
                    if (item.itemcode == frm.ItemSeleccionado.ItemCode)
                    {
                        item.cantidad = item.cantidad + 1;
                        Agregar = false;
                    }
                }
                

                if (Agregar)
                {
                    DataRow dr = dsCompras1.solicitud_compras_detalle.NewRow();
                    dr[0] = frm.ItemSeleccionado.ItemCode;
                    dr[1] = frm.ItemSeleccionado.ItemName;
                    dr[2] = 1;
                    dr[3] = 0.00;
                    dr[4] = 0;
                    dr[5] = 0;
                    dr[6] = 0;
                    dsCompras1.solicitud_compras_detalle.Rows.Add(dr);
                }
                

                

            }
           


            //dsCompras1.solicitud_compras_detalle.AcceptChanges();
        }

        private void ButtonDeleteRow_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)grDetalle.FocusedView;
            var row = (dsCompras.solicitud_compras_detalleRow)gridView.GetFocusedDataRow();

            DialogResult r = CajaDialogo.Pregunta("Confirma que desea elminar este registro?");
            if (r != DialogResult.Yes)
                return;

            //if (row.id > 0)
            //{
            //    try
            //    {
            //        DataOperations dp = new DataOperations();
            //        SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
            //        con.Open();

            //        SqlCommand cmd = new SqlCommand("sp_delete_compras_solicitudes_detalle", con);
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.Parameters.AddWithValue("@id", row.id);
            //        cmd.ExecuteNonQuery();

            //        CargarSolicitud(IdSolicitudActual);

            //        con.Close();
            //    }
            //    catch (Exception ec)
            //    {
            //        CajaDialogo.Error(ec.Message);
            //    }
            //}
            //else
            //{
                try
                {
                    grdvDetalle.DeleteRow(grdvDetalle.FocusedRowHandle);
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            //}
        }

        private void CargarSolicitud(int pidSolicitudActual)
        {

            Solicitud soli = new Solicitud();
            if (soli.RecuperarRegistros(pidSolicitudActual))
            {
                txtUsuarioCreador.Text = soli.Usuario;
                txtId.Text = Convert.ToString(pidSolicitudActual);
                IdSolicitudActual = pidSolicitudActual;
                txtEstado.Text = soli.Estado;
                dtFechaRegistro.Value = soli.Fecha_registro;
                dtFechaContabilizacion.Value = soli.Fecha_contabilizacion;
                txtComentarios.Text = soli.Comentario;
                IdEstadoSolicitud = soli.Id_estado;
                loaddetalle(pidSolicitudActual);
                tipooperacion = TipoOperacion.Update;
            }

            switch (IdEstadoSolicitud)
            {
                case 1://Nueva
                    cmdNuevo.Enabled = true;
                    cmdAddDetalle.Enabled = true;
                    txtComentarios.Enabled = true;
                    grDetalle.Enabled = true;
                    dtFechaContabilizacion.Enabled = true;
                    btnEditar.Enabled = false;
                    break;

                case 2://Abierta
                    cmdNuevo.Enabled = true;
                    cmdAddDetalle.Enabled = true;
                    txtComentarios.Enabled = true;
                    grDetalle.Enabled = true;
                    dtFechaContabilizacion.Enabled = true;
                    btnEditar.Enabled = true;
                    break;

                case 3://Cerrada
                    cmdNuevo.Enabled = false;
                    cmdAddDetalle.Enabled = false;
                    txtComentarios.Enabled = false;
                    grDetalle.Enabled = false;
                    dtFechaContabilizacion.Enabled = false;
                    cmdGuardar.Enabled = false;
                    btnEditar.Enabled = false;
                    break;

                case 4://Cancelada
                    cmdNuevo.Enabled = false;
                    cmdAddDetalle.Enabled = false;
                    txtComentarios.Enabled = false;
                    grDetalle.Enabled = false;
                    dtFechaContabilizacion.Enabled = false;
                    cmdGuardar.Enabled = false;
                    btnEditar.Enabled = false;
                    break;

                default:
                    break;
            }

        }

        private void loaddetalle(int idSolicitudActual)
        {

            try
            {
                string query = @"sp_get_solicitud_detalle"; //Detalle Solicitud
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_solicitud_h", idSolicitudActual);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.solicitud_compras_detalle.Clear();
                adat.Fill(dsCompras1.solicitud_compras_detalle);
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

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gridView = (GridView)grDetalle.FocusedView;
            var row = (dsCompras.solicitud_compras_detalleRow)gridView.GetFocusedDataRow();

            try
            {
                if (e.Column.FieldName == "cantidad")
                {
                    row.total = row.cantidad * row.precio;
                }

                if (e.Column.FieldName == "precio")
                {
                    row.total = row.cantidad * row.precio;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            frmSearchSolicitud frm = new frmSearchSolicitud(frmSearchSolicitud.FiltroSolicitudes.Todas);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarSolicitud(frm.IdSolicitudSeleccionado);



            }

            cmdNuevo.Enabled = true;
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
            IdSolicitudActual = 0;
            txtComentarios.Clear();
            txtComentarios.Enabled = true;
            grDetalle.Enabled = true;
            dtFechaContabilizacion.Enabled = true;
            cmdGuardar.Enabled = true;
            cmdAddDetalle.Enabled = true;

            txtUsuarioCreador.Text = UsuarioLogueado.Nombre;
            dsCompras1.solicitud_compras_detalle.Clear();
            GetSigID();

        }

        private void barButtonCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult r = CajaDialogo.Pregunta("¿Confirma que desea Cancelar esta Solicitud?");
            if (r != DialogResult.Yes)
                return;

            switch (tipooperacion)
            {
                case TipoOperacion.New:
                    break;
                case TipoOperacion.Update:
                    CancelarSolicitud(IdSolicitudActual);
                    break;
                default:
                    break;
            }
            
        }

        private void CancelarSolicitud(int pidSolicitudActual)
        {
            if (pidSolicitudActual > 0)
            { 
                Solicitud soli = new Solicitud();
                soli.RecuperarRegistros(pidSolicitudActual);

            
                bool Proceder = false;
                string mensaje = "";
                switch (soli.Id_estado)
                {
                    case 1: //Nueva 
                        Proceder = true;
                        break;

                    case 2: //Abierta
                        Proceder = true;
                        break;

                    case 3: //Cerrada
                        Proceder = false;
                        mensaje = "La Solicitud se encuentra Cerrada!";
                        break;

                    case 4: //Cancelada
                        Proceder = false;
                        mensaje = "La Solicitud se encuentra Cancelada!";
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
                        SqlCommand cmd = new SqlCommand("sp_solicitud_compra_cancelar", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idSolicitudActual", pidSolicitudActual);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        CajaDialogo.Information("Soliciud Cancelada!");

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

        }

        private void frmSolicitudesMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (IdSolicitudActual > 0)
                {
                    popupMenu1.ShowPopup(Cursor.Position);
                }
            }
        }

        private void panelControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (IdSolicitudActual > 0)
                {
                    popupMenu1.ShowPopup(Cursor.Position);
                }
            }
        }

        private void grDetalle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (IdSolicitudActual > 0)
                {
                    popupMenu1.ShowPopup(Cursor.Position);
                }
            }
        }

        private void cmdAnterior_Click(object sender, EventArgs e)
        {
            tipooperacion = TipoOperacion.Update;

            if (IdSolicitudActual == 0)//vamos a mostrar el ultimo
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("[sp_get_last_or_first_solicitud_and_oc]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@case", 1);//Solicitudes de Compra
                    cmd.Parameters.AddWithValue("@PuntoVentaActual", 0);
                    IdSolicitudActual = Convert.ToInt32(cmd.ExecuteScalar());
                    CargarSolicitud(IdSolicitudActual);
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
                    cmd.Parameters.AddWithValue("@case", 1);
                    cmd.Parameters.AddWithValue("@idactual", IdSolicitudActual);
                    IdSolicitudActual = Convert.ToInt32(cmd.ExecuteScalar());

                    if (IdSolicitudActual == 0)
                    {
                        //Si es cero debemos cargar el primero
                        cmd = new SqlCommand("[sp_get_navigation_solicitudes]", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@case", 2);
                        cmd.Parameters.AddWithValue("@idactual", IdSolicitudActual);
                        IdSolicitudActual = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    CargarSolicitud(IdSolicitudActual);
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
            if (IdSolicitudActual == 0)//vamos a mostrar el primero
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("[sp_get_last_or_first_solicitud_and_oc]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@case", 2);
                    cmd.Parameters.AddWithValue("@PuntoVentaActual", 0);
                    IdSolicitudActual = Convert.ToInt32(cmd.ExecuteScalar());
                    CargarSolicitud(IdSolicitudActual);
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
                    cmd.Parameters.AddWithValue("@idactual", IdSolicitudActual);
                    IdSolicitudActual = Convert.ToInt32(cmd.ExecuteScalar());

                    if (IdSolicitudActual == 0)
                    {
                        //Si es cero debemos cargar el primero
                        cmd = new SqlCommand("[sp_get_navigation_solicitudes]", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@case", 4);
                        cmd.Parameters.AddWithValue("@idactual", IdSolicitudActual);
                        IdSolicitudActual = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    CargarSolicitud(IdSolicitudActual);
                    con.Close();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }
        }

        private void panelControl2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (IdSolicitudActual > 0)
                {
                    popupMenu1.ShowPopup(Cursor.Position);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            switch (tipooperacion)
            {
                case TipoOperacion.New:
                    break;
                case TipoOperacion.Update:
                    cmdGuardar.Enabled = true;
                    grDetalle.Enabled = true;
                    txtComentarios.Enabled = true;
                    dtFechaContabilizacion.Enabled = true;
                    cmdAddDetalle.Enabled = true;
                    break;
                default:
                    break;
            }
        }
    }
}