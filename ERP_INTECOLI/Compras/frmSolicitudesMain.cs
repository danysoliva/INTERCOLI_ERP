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




            switch (tipooperacion)
            {
                case TipoOperacion.New:


                    break;
                case TipoOperacion.Update:



                    break;
                default:
                    break;
            }


        }

        private void cmdAddDetalle_Click(object sender, EventArgs e)
        {
            DataRow dr = dsCompras1.solicitud_compras_detalle.NewRow();
            dr[0] = "";
            dr[1] = "";
            dr[2] = 0;
            dr[3] = 0.00;
            dr[4] = 0;
            dr[5] = 0;
            dsCompras1.solicitud_compras_detalle.Rows.Add(dr);
            dsCompras1.solicitud_compras_detalle.AcceptChanges();
        }

        private void ButtonDeleteRow_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)grDetalle.FocusedView;
            var row = (dsCompras.solicitud_compras_detalleRow)gridView.GetFocusedDataRow();

            DialogResult r = CajaDialogo.Pregunta("Confirma que desea elminar este registro?");
            if (r != DialogResult.Yes)
                return;

            switch (tipooperacion)
            {
                case TipoOperacion.New:

                    try
                    {
                        gridView1.DeleteRow(gridView1.FocusedRowHandle);
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }

                    break;
                case TipoOperacion.Update:

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


                    break;
                default:
                    break;
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
                string query = @""; //Detalle Solicitud
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("", idSolicitudActual);
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


        }
    }
}