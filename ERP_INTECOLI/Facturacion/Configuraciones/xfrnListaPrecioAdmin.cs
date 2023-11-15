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

namespace JAGUAR_APP.Facturacion.Configuraciones
{
    public partial class xfrnListaPrecioAdmin : DevExpress.XtraEditors.XtraForm
    {
        UserLogin userLog = new UserLogin();
        public xfrnListaPrecioAdmin(UserLogin pUserLogin)
        {
            InitializeComponent();
            userLog = pUserLogin;
            ObtenerListaPrecios();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            xfrmListaPreciosCRUD frm = new xfrmListaPreciosCRUD(userLog, xfrmListaPreciosCRUD.TipoTipoTransaccionActual.Nuevo, 0);

            if (frm.ShowDialog()== DialogResult.Retry)
            {
                //ObtenerListaPrecios();
                ListaPrecios listaPrecios1 = new ListaPrecios();
                if(frm.Lista_precioActual != null)
                {
                    if (listaPrecios1.RecuperaRegistro(frm.Lista_precioActual.ID))
                    {
                        //Agregar nuevo registro al data table
                        dsListaPrecios.ListaPrecioRow row = dsListaPrecios.ListaPrecio.NewListaPrecioRow();
                        row.id = listaPrecios1.ID;
                        row.descripcion = listaPrecios1.Descripcion;
                        row.created_date = listaPrecios1.CreatedDate;
                        row.usuario_id = listaPrecios1.UsuarioID;
                        row.usuario = listaPrecios1.Usuario;
                        row.mes = listaPrecios1.Mes;
                        row.anio = listaPrecios1.Anio;
                        row.codigo = listaPrecios1.Codigo;
                        row.desde = listaPrecios1.Desde;
                        row.hasta = listaPrecios1.Hasta;

                        dsListaPrecios.ListaPrecio.AddListaPrecioRow(row);
                        dsListaPrecios.AcceptChanges();
                    }
                }
                
                
            }
        }

        private void ObtenerListaPrecios()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP))
                {
                    cnx.Open();

                    dsListaPrecios.ListaPrecio.Clear();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.uspObtenerListaPrecios", cnx);
                    da.Fill(dsListaPrecios.ListaPrecio);

                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var row = (dsListaPrecios.ListaPrecioRow)gvListaPrecio.GetFocusedDataRow();

            xfrmListaPreciosCRUD frm = new xfrmListaPreciosCRUD(userLog, xfrmListaPreciosCRUD.TipoTipoTransaccionActual.Editar, row.id);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                ObtenerListaPrecios();
            }
        }

        private void btnView_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var row = (dsListaPrecios.ListaPrecioRow)gvListaPrecio.GetFocusedDataRow();

            xfrmListaPrecioView frm = new xfrmListaPrecioView(row.id,row.descripcion);

            frm.ShowDialog();
        }

        private void btnCopiar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsListaPrecios.ListaPrecioRow)gvListaPrecio.GetFocusedDataRow();

                xfrmCopiarListaPrecio frm = new xfrmCopiarListaPrecio(userLog, row.id);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ObtenerListaPrecios();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnDelete_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (XtraMessageBox.Show("DESEA ELIMINAR ESTE REGISTRO?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection dbConnection = new SqlConnection(dp.ConnectionStringERP);

                    var row = (dsListaPrecios.ListaPrecioRow)gvListaPrecio.GetFocusedDataRow();

                    using (SqlCommand command = new SqlCommand("dbo.uspAnularListaPrecio", dbConnection))
                    {
                        dbConnection.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@id", SqlDbType.Int).Value = row.id;

                        command.ExecuteNonQuery();
                        dbConnection.Close();

                        gvListaPrecio.DeleteRow(gvListaPrecio.FocusedRowHandle);
                    }
                    //ObtenerProductosById(lista_precios.ID);
                }

                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
            }
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            ObtenerListaPrecios();
        }
    }
}