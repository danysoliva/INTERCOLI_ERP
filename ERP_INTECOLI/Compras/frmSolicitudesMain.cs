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
                    txtEstado.Text = "Creada";
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
                DataRow dr = dsCompras1.solicitud_compras_detalle.NewRow();
                dr[0] = frm.ItemSeleccionado.ItemCode;
                dr[1] = frm.ItemSeleccionado.ItemName;
                dr[2] = 0;
                dr[3] = 0.00;
                dr[4] = 0;
                dr[5] = 0;
                dr[6] = 0;
                dsCompras1.solicitud_compras_detalle.Rows.Add(dr);
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

            if (row.id > 0)
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", row.id);
                    cmd.ExecuteNonQuery();

                    CargarSolicitud(IdSolicitudActual);

                    con.Close();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
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

        private void CargarSolicitud(int idSolicitudActual)
        {
            Solicitud solic = new Solicitud();
            if (solic.RecuperarRegistros(idSolicitudActual))
            {


                loaddetalle(idSolicitudActual);
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
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            frmSearchSolicitud frm = new frmSearchSolicitud();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Solicitud soli = new Solicitud();
                if (soli.RecuperarRegistros(frm.IdSolicitudSeleccionado))
                {
                    txtUsuarioCreador.Text = soli.Usuario;
                    txtId.Text = Convert.ToString(frm.IdSolicitudSeleccionado);
                    IdSolicitudActual = frm.IdSolicitudSeleccionado;
                    txtEstado.Text = soli.Estado;
                    dtFechaRegistro.Value = soli.Fecha_registro;
                    dtFechaContabilizacion.Value = soli.Fecha_contabilizacion;
                    txtComentarios.Text = soli.Comentario;

                    loaddetalle(frm.IdSolicitudSeleccionado);
                    tipooperacion = TipoOperacion.Update;
                }
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
            txtEstado.Text = "Creado";

            txtUsuarioCreador.Text = UsuarioLogueado.Nombre;
            dsCompras1.solicitud_compras_detalle.Clear();
            GetSigID();

        }
    }
}