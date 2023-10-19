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
    public partial class xfrmPDVAsignadasView : DevExpress.XtraEditors.XtraForm
    {
        int idListaPrecio;
        int id_pt;
        public xfrmPDVAsignadasView(int idListaPrecioP,string listaPrecioNameP,string producto,int id_ptP)
        {
            InitializeComponent();
            ObtenerTiendasProductosById(idListaPrecioP, id_ptP);
            lblListaPrecios.Text = "Lista de Precio: " + listaPrecioNameP;
            lblProducto.Text = "Producto: " + producto;
            idListaPrecio = idListaPrecioP;
            id_pt = id_ptP;
            //id_listaPrecioProductoAplicaTienda = id_listaPrecioProductoAplicaTiendaP;
        }

        private void ObtenerTiendasProductosById(int id,int id_pt)
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP))
                {
                    cnx.Open();

                    dsListaPrecios.ListaPreciosProductosAplicaPDV.Clear();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.uspGetListaPreciosProductosAplicaTiendasById", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    da.SelectCommand.Parameters.Add("@id_pt", SqlDbType.Int).Value = id_pt;
                    da.Fill(dsListaPrecios.ListaPreciosProductosAplicaPDV);

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
            try
            {
                var row = (dsListaPrecios.ListaPreciosProductosAplicaPDVRow)gvLP.GetFocusedDataRow();

                xfrmEditPriceFromListaPrecio frm = new xfrmEditPriceFromListaPrecio(row.id,row.id_pt,row.pt);

                if (frm.ShowDialog()== DialogResult.OK)
                {
                    ObtenerTiendasProductosById(idListaPrecio,id_pt);
                } 
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void xfrmPDVAsignadasView_Load(object sender, EventArgs e)
        {

        }

        private void btnAnular_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (XtraMessageBox.Show("DESEA ELIMINAR ESTE REGISTRO?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection dbConnection = new SqlConnection(dp.ConnectionStringERP);



                    var row = (dsListaPrecios.ListaPreciosProductosAplicaPDVRow)gvLP.GetFocusedDataRow();

                    using (SqlCommand command = new SqlCommand("dbo.uspAnularListaPrecioProductoAplicaTienda ", dbConnection))
                    {
                        dbConnection.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@id_listaPrecioProductoAplicaTienda", SqlDbType.Int).Value = row.id;

                        command.ExecuteNonQuery();
                        dbConnection.Close();

                        gvLP.DeleteRow(gvLP.FocusedRowHandle);
                    }
                    //ObtenerClientesById(lista_precios.ID);
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
              }
            }
    }
}