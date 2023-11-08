using DevExpress.XtraEditors;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid.Views.Grid;
using ERP_INTECOLI.Clases;
using JAGUAR_APP.Facturacion.CoreFacturas;
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
    public partial class xfrmSelectProductos : DevExpress.XtraEditors.XtraForm
    {
        decimal ValorCeldaOLD;
        DataOperations dp;
        PuntoVenta PuntoVentaActual; 
        public xfrmSelectProductos()
        {
            InitializeComponent();
            dp = new DataOperations();
            //PuntoVentaActual = pPuntoVenta;
            ObtenerProductos();
            ObtenerPDVs();
            if (dsListaPrecios.Productos.Count > 0)
                gvCliente.FocusedRowHandle = 0;

            gvCliente.FocusedColumn = gridColumn3;//PRECIO
            gvCliente.ShowEditor();
            
        }
        public List<ProductoListaPreciosAplica> productos = new List<ProductoListaPreciosAplica>();

        private void ObtenerProductos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP))
                {
                    cnx.Open();
                    dsListaPrecios.Productos.Clear();
                    SqlDataAdapter da = new SqlDataAdapter("dbo.uspObtenerProductosByListaPrecio", cnx);
                    da.Fill(dsListaPrecios.Productos);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }


        private void gvCliente_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "precio")
            {
                DataOperations dp = new DataOperations();
                decimal valor_celda = 0;
                
                //Validamos si puso cero o vacio
                decimal valor = - 1;
                try
                {
                    valor = Convert.ToDecimal(e.Value);
                }
                catch { }

                //Vacio
                if(valor == -1)
                    valor_celda = -1;
                else
                    valor_celda = valor;


                if (valor_celda > 0)
                {

                    var gridView = (GridView)gcCliente.FocusedView;
                    var row = (dsListaPrecios.ProductosRow)gridView.GetFocusedDataRow();

                    row.seleccion = true;
                }
                else
                {
                    var gridView = (GridView)gcCliente.FocusedView;
                    var row = (dsListaPrecios.ProductosRow)gridView.GetFocusedDataRow();

                    if (valor_celda == 0)
                    {
                        row.precio = 0;
                        row.seleccion = false;
                    }
                    else
                    {
                        //if (valor_celda == -1)
                        row.precio = ValorCeldaOLD;
                        if (ValorCeldaOLD > 0)
                            row.seleccion = true;
                        else
                            row.seleccion = false;
                    }
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        PuntoVenta pdv = new PuntoVenta();
        private void cmdNew_Click(object sender, EventArgs e)
        {
            productos = new List<ProductoListaPreciosAplica>();

            foreach (var item in dsListaPrecios.Productos)
            {
                if (item.seleccion == true)
                {
                    //pdv = new PuntoVenta();
                    //if (pdv.RecuperaRegistro(punto))
                    //{
                        ProductoListaPreciosAplica productosNew = new ProductoListaPreciosAplica()
                        {
                            ID = item.id_pt,
                            Producto = item.descripcion,
                            Codigo = item.codigo,
                            Precio = item.precio,
                            PresentacionID = dp.ValidateNumberInt32(item.id_presentacion),
                            Presentacion = item.presentacion,
                            //PDV_ID = PuntoVentaActual.ID,
                            //PDV = PuntoVentaActual.Nombre
                        };

                        productos.Add(productosNew);
                    
                }
            }

            this.DialogResult = DialogResult.OK;
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

                    SqlDataAdapter da = new SqlDataAdapter("dbo.[sp_get_lista_puntos_de_venta]", cnx);
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

        private void gvCliente_ShownEditor(object sender, EventArgs e)
        {
            if (gvCliente.FocusedColumn.FieldName == "precio")
            {
                ValorCeldaOLD = dp.ValidateNumberDecimal(gvCliente.FocusedValue);
                gvCliente.ActiveEditor.EditValue = null;
            }
        }
    }
}
public class ProductoListaPreciosAplica
{

    public int ID { get; set; }
    public string Producto { get; set; }
    public string Codigo { get; set; }
    public int PresentacionID { get; set; }
    public string Presentacion { get; set; }
    public decimal Precio { get; set; }
    public int PDV_ID { get; set; }
    public string PDV { get; set; }
}

