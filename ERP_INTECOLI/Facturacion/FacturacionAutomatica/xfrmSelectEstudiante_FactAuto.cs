using DevExpress.XtraEditors;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid.Views.Grid;
using ERP_INTECOLI.Clases;
using ERP_INTECOLI.Facturacion.FacturacionAutomatica;
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
    public partial class xfrmSelectEstudiante_FactAuto : DevExpress.XtraEditors.XtraForm
    {
        decimal ValorCeldaOLD;
        DataOperations dp;
        PuntoVenta PuntoVentaActual;
        UserLogin UsuarioLogeado;
        public xfrmSelectEstudiante_FactAuto(UserLogin pUsuario, PuntoVenta pPuntoVenta)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuario;
            dp = new DataOperations();
            ObtenerProductos();

            gvCliente.FocusedColumn = colprecio;//PRECIO
            gvCliente.ShowEditor();
            
        }
        public List<ProductoListaPreciosAplicaLocal> productos = new List<ProductoListaPreciosAplicaLocal>();

        private void ObtenerProductos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP))
                {
                    cnx.Open();
                    dsConfigFacturaAutomatica1.busqueda_estudiante_cursos.Clear();
                    SqlDataAdapter da = new SqlDataAdapter("[dbo].[uspObtenerEstudiantes]", cnx);
                    da.Fill(dsConfigFacturaAutomatica1.busqueda_estudiante_cursos);
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
                    var row = (dsConfigFacturaAutomatica.busqueda_estudiante_cursosRow)gridView.GetFocusedDataRow();

                    row.seleccion = true;
                }
                else
                {
                    var gridView = (GridView)gcCliente.FocusedView;
                    var row = (dsConfigFacturaAutomatica.busqueda_estudiante_cursosRow)gridView.GetFocusedDataRow();

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
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        PuntoVenta pdv = new PuntoVenta();
        private void cmdNew_Click(object sender, EventArgs e)
        {
            productos = new List<ProductoListaPreciosAplicaLocal>();

            foreach (var item in dsConfigFacturaAutomatica1.busqueda_estudiante_cursos)
            {
                if (item.seleccion == true)
                {
                    ProductoListaPreciosAplicaLocal productosNew = new ProductoListaPreciosAplicaLocal()
                    {
                        ID_PT = item.id_pt,
                        ItemName_Pt_Facturacion = item.ItemNameFacturacion,
                        ItemCodePT_Facturacion = item.ItemCodeFacturacion,
                        ItemCodeEstudiante = item.Item_Code,
                        Precio = item.precio,
                        IdEstudiante = item.id_estudiante,
                        EstudianteName = item.nombre,
                        IdDetalleMatricula = item.id_detalle,
                        CursoID = item.id_curso,
                        Curso_Name = item.curso,
                        Punto_Venta_id = item.id_punto_venta,
                        Punto_venta_Name = item.sucursal_name,
                        min_dia_pago = item.min_dia_pago,
                        max_dia_pago = item.max_dia_pago,
                    };

                    productos.Add(productosNew);

                }
            }

            this.DialogResult = DialogResult.OK;
        }

        private void gvCliente_ShownEditor(object sender, EventArgs e)
        {
            if (gvCliente.FocusedColumn.FieldName == "precio")
            {
                ValorCeldaOLD = dp.ValidateNumberDecimal(gvCliente.FocusedValue);
                gvCliente.ActiveEditor.EditValue = null;
            }
        }

        private void checkSeleccionarTodos_CheckedChanged(object sender, EventArgs e)
        {
            var gridView = (GridView)gcCliente.FocusedView;
            int conta = dsConfigFacturaAutomatica1.busqueda_estudiante_cursos.Count;
            //int filtered = 0;
            //string ids = "";

            for (int i = 0; i < conta; i++)
            {
                dsConfigFacturaAutomatica.busqueda_estudiante_cursosRow row = (dsConfigFacturaAutomatica.busqueda_estudiante_cursosRow)gridView.GetDataRow(i);
                int r = gridView.GetVisibleRowHandle(i + 0);
                if (r >= 0)
                {
                    //filtered++;
                    if (row != null)
                    {
                        row.seleccion = checkSeleccionarTodos.Checked;
                        //ids+= ", "+ row.id;
                    }
                }
                else
                {
                    if (row != null)
                        row.seleccion = false;
                }
            }
        }
    }
}
public class ProductoListaPreciosAplicaLocal
{

    public string ItemCodeEstudiante { get; set; }
    public decimal Precio { get; set; }
    public Int64 IdEstudiante { get; set; }
    public Int64 IdDetalleMatricula { get; set; }
    public int CursoID { get; set; }
    public string ItemCodePT_Facturacion { get; set; }
    public  string Punto_venta_Name { get; set; }
    public int Punto_Venta_id { get; set; }
    public string Curso_Name { get; set; }
    public string EstudianteName { get; set; }
    public string ItemName_Pt_Facturacion { get; set; }
    public int ID_PT { get; set; }
    public int min_dia_pago { get; set; }
    public int max_dia_pago { get;set; }
}


