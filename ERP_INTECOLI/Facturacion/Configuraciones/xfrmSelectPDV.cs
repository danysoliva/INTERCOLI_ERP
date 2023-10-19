using DevExpress.XtraEditors;
using ERP_INTECOLI.Clases;
using JAGUAR_APP.Facturacion.Configuraciones.Models;
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
    public partial class xfrmSelectPDV : DevExpress.XtraEditors.XtraForm
    {
       public int id_pdv = 0;
       public int id_pt = 0;
       public int id_ListaPrecio = 0;
        UserLogin usuarioLog = new UserLogin();
        decimal precio = 0;
        List<ListaPrecioProductosAplicaPDV> listaPDVSeleccionada = new List<ListaPrecioProductosAplicaPDV>();

       public enum TipoTransaccion
        {
            Nuevo=1,
            Editar = 2
        }

        TipoTransaccion currentTransaction;
        //public string pdv = "";
        public xfrmSelectPDV(TipoTransaccion pTransaccion,int id_pdvP, int idListaPrecioP, int id_ptP, UserLogin pUser, decimal precioP, string producto)
        {
            InitializeComponent();
            id_ListaPrecio = idListaPrecioP;
            id_pdv = id_pdvP;
            id_pt = id_ptP;
            usuarioLog = pUser;
            precio = precioP;
            lblProducto.Text = "Producto: " + producto;
            currentTransaction = pTransaccion;
        }

        public xfrmSelectPDV(TipoTransaccion pTransaccion, decimal precioP, string producto, int id_ptP, List<ListaPrecioProductosAplicaPDV> listaP)
        {
            InitializeComponent();
            //id_ListaPrecio = idListaPrecioP;
            //id_pdv = id_pdvP;
            id_pt = id_ptP;
            //usuarioLog = pUser;
            precio = precioP;
            lblProducto.Text = "Producto: " + producto;
            currentTransaction = pTransaccion;
            listaPDVSeleccionada = listaP;
        }

        private void ObtenerPDVs()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP))
                {
                    cnx.Open();

                    dsListaPrecios.PDV.Clear();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.usp_GetPDV", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    //da.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    da.Fill(dsListaPrecios.PDV);

                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

               public  List<ListaPrecioProductosAplicaPDV> lista = new List<ListaPrecioProductosAplicaPDV>();
        private void cmdApply_Click(object sender, EventArgs e)
        {

            try
            {

                switch (currentTransaction)
                {
                    case TipoTransaccion.Nuevo:
                        lista = new List<ListaPrecioProductosAplicaPDV>();

                        ListaPrecioProductosAplicaPDV listaPrecioProducto = new ListaPrecioProductosAplicaPDV();

                        foreach (var item in dsListaPrecios.PDV)
                        {
                            if (item.seleccion == true)
                            {
                                listaPrecioProducto = new ListaPrecioProductosAplicaPDV();
                                listaPrecioProducto.PT_ID = id_pt;
                                listaPrecioProducto.Precio = item.precio;
                                listaPrecioProducto.PDV_ID = item.id;
                                lista.Add(listaPrecioProducto);
                            }
                        }

                        this.DialogResult = DialogResult.OK;
                        break;
                    case TipoTransaccion.Editar:
                        DataOperations dp = new DataOperations();
                        SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP);

                        foreach (var item in dsListaPrecios.PDV)
                        {
                            if (item.seleccion == true)
                            {

                                SqlCommand cmd = new SqlCommand("uspInsertListaPrecioProductosAplicaTienda", cnx);
                                cmd.CommandType = CommandType.StoredProcedure;

                                cmd.Parameters.Add("@id_producto", SqlDbType.Int).Value = id_pt;
                                cmd.Parameters.Add("@id_listaPrecio", SqlDbType.Int).Value = id_ListaPrecio;
                                cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = DateTime.Now;
                                cmd.Parameters.Add("@usuario_id", SqlDbType.Int).Value = usuarioLog.Id;
                                cmd.Parameters.Add("@precio", SqlDbType.Decimal).Value = item.precio;
                                cmd.Parameters.Add("@id_pdv", SqlDbType.Int).Value = item.id;

                                cnx.Open();
                                cmd.ExecuteNonQuery();
                                cnx.Close();
                            }
                        }
                        CajaDialogo.Information("Datos Guardados");
                        this.DialogResult = DialogResult.OK;
                        break;

                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
            //this.id_pdv = Convert.ToInt32(sluePDV.EditValue);
            //this.pdv = sluePDV.Text;
        }

        private void xfrmSelectPDV_Load(object sender, EventArgs e)
        {
            ObtenerPDVs();

            foreach (var item in dsListaPrecios.PDV)
            {
                item.precio = precio;
                item.seleccion = true;
                dsListaPrecios.AcceptChanges();
            }

            if (currentTransaction==TipoTransaccion.Nuevo)
            {
                foreach (var item in listaPDVSeleccionada)
                {
                    foreach (var item2 in dsListaPrecios.PDV)
                    {
                        if (item2.id==item.PDV_ID)
                        {
                            item2.seleccion = true;
                        }
                    }
                }
            }
        }
    }
}