using DevExpress.XtraEditors;
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
using static DevExpress.Xpo.Logger.LogManager;

namespace LOSA.Calidad.LoteConfConsumo
{
    public partial class frmSearchDefault : DevExpress.XtraEditors.XtraForm
    {
        //public MateriaPrima MateriaPrimaSelected;
        DataOperations dp = new DataOperations();
        public ItemBusquedaFactura ItemSeleccionado;
        PuntoVenta PuntoVentaActual;
        DataView dv;// = new DataView(dsConfigLoteConsumo1.search_mp);
        //string StoreProcedureConfigActual = "";
        public enum TipoBusqueda
        {
            MateriaPrima = 1,
            ProductoTerminado = 2,
            Empleados = 3,
            PresentacionEmpaqueALOSY = 4,
            BodegasALOSY = 5,
            MaterialEmpaque = 6,
            Reproceso = 7,
            Clientes = 8,
            PuntosDeVenta = 9,
            Proveedores = 10
        }

        public enum TipoFacturacion
        {
            FacturacionRapida = 1,
            FacturacionNormal = 2
        }

        TipoBusqueda TipoBusquedaActual;
        TipoFacturacion TipoFacturacionActual;
        public frmSearchDefault(TipoBusqueda pTipo)
        {
            InitializeComponent();
            TipoBusquedaActual = pTipo;
            PuntoVentaActual = new PuntoVenta();
            //StoreProcedureConfigActual = "sp_get_lista_materias_primas";

            //MateriaPrimaSelected = new MateriaPrima();
            switch (TipoBusquedaActual)
            {
                case TipoBusqueda.MateriaPrima:
                    //LoadData();
                    break;
                case TipoBusqueda.ProductoTerminado:
                    LoadData();
                    break;
                case TipoBusqueda.Empleados:
                    break;
                case TipoBusqueda.PresentacionEmpaqueALOSY:
                    break;
                case TipoBusqueda.BodegasALOSY:
                    break;
                case TipoBusqueda.MaterialEmpaque:
                    //LoadData();
                    break;
                case TipoBusqueda.Reproceso:
                    //LoadData();
                    break;
                case TipoBusqueda.Clientes:
                    LoadData();
                    break;
                case TipoBusqueda.PuntosDeVenta:
                    LoadData();
                    break;
                case TipoBusqueda.Proveedores:
                    LoadData();
                    break;
                default:
                    break;
            }
            ItemSeleccionado = new ItemBusquedaFactura();
            
        }

        public frmSearchDefault(TipoBusqueda pTipo, PuntoVenta pPuntoVenta)
        {
            InitializeComponent();
            TipoBusquedaActual = pTipo;
            PuntoVentaActual = pPuntoVenta;
            //StoreProcedureConfigActual = "sp_get_lista_materias_primas";
            
            //MateriaPrimaSelected = new MateriaPrima();
            switch (TipoBusquedaActual)
            {
                case TipoBusqueda.MateriaPrima:
                    //LoadData();
                    gridView1.Columns["inv"].Visible = false;
                    break;
                case TipoBusqueda.ProductoTerminado:
                    LoadDataTipoFacturacion();
                    //gridView1.Columns["inv"].Visible = true;
                    break;
                case TipoBusqueda.Empleados:
                    gridView1.Columns["inv"].Visible = false;
                    break;
                case TipoBusqueda.PresentacionEmpaqueALOSY:
                    gridView1.Columns["inv"].Visible = false;
                    break;
                case TipoBusqueda.BodegasALOSY:
                    gridView1.Columns["inv"].Visible = false;
                    break;
                case TipoBusqueda.MaterialEmpaque:
                    gridView1.Columns["inv"].Visible = false;
                    //LoadData();
                    break;
                case TipoBusqueda.Reproceso:
                    gridView1.Columns["inv"].Visible = false;
                    //LoadData();
                    break;
                case TipoBusqueda.Clientes:
                    gridView1.Columns["inv"].Visible = false;
                    LoadData();
                    break;
                case TipoBusqueda.PuntosDeVenta:
                    gridView1.Columns["inv"].Visible = false;
                    LoadData();
                    break;
                default:
                    break;
            }
            ItemSeleccionado = new ItemBusquedaFactura();

        }

        private void LoadDataTipoFacturacion()
        {
            try
            {
                SqlConnection con;
                con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();

                //SqlCommand cmd = new SqlCommand("[dbo].[sp_get_lista_items_for_facturacion]", con);
                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_lista_items_for_facturacion_by_punto_venta]", con);
                
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@parametro_busqueda", Convert.ToInt32(TipoBusquedaActual));
                //cmd.Parameters.AddWithValue("@tipo_facturacion", this.PuntoVentaActual.FacturaComidaBuffet);
                cmd.Parameters.AddWithValue("@id_punto_venta", this.PuntoVentaActual.ID);

                dsConfigLoteConsumo1.search_mp.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsConfigLoteConsumo1.search_mp);

                dv = new DataView(dsConfigLoteConsumo1.search_mp);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        public frmSearchDefault(TipoBusqueda pTipo, TipoFacturacion pTipoFacturacion)
        {
            InitializeComponent();
            TipoBusquedaActual = pTipo;
            TipoFacturacionActual = pTipoFacturacion;
            //StoreProcedureConfigActual = "sp_get_lista_materias_primas";

            //MateriaPrimaSelected = new MateriaPrima();
            switch (TipoBusquedaActual)
            {
                case TipoBusqueda.MateriaPrima:
                    //LoadData();
                    break;
                case TipoBusqueda.ProductoTerminado:
                    LoadData(TipoFacturacionActual);
                    break;
                case TipoBusqueda.Empleados:
                    break;
                case TipoBusqueda.PresentacionEmpaqueALOSY:
                    break;
                case TipoBusqueda.BodegasALOSY:
                    break;
                case TipoBusqueda.MaterialEmpaque:
                    //LoadData();
                    break;
                case TipoBusqueda.Reproceso:
                    //LoadData();
                    break;
                case TipoBusqueda.Clientes:
                    LoadData();
                    break;
                default:
                    break;
            }
            ItemSeleccionado = new ItemBusquedaFactura();

        }

        private void load_data_material_empaque()
        {
            string sql = @"sp_get_lista_materias_primas";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringERP);
                cn.Open();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@parametro_busqueda", Convert.ToInt32(TipoBusquedaActual));

                dsConfigLoteConsumo1.search_mp.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsConfigLoteConsumo1.search_mp);
                dv = new DataView(dsConfigLoteConsumo1.search_mp);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadData()
        {
            try
            {
                SqlConnection con;
                con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_lista_items]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@parametro_busqueda", Convert.ToInt32(TipoBusquedaActual));

                dsConfigLoteConsumo1.search_mp.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsConfigLoteConsumo1.search_mp);

                dv = new DataView(dsConfigLoteConsumo1.search_mp);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadData(TipoFacturacion pTipoFacturacion)
        {
            try
            {
                SqlConnection con;
                con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_lista_items_for_facturacion]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@parametro_busqueda", Convert.ToInt32(TipoBusquedaActual));
                cmd.Parameters.AddWithValue("@tipo_facturacion", Convert.ToInt32(pTipoFacturacion));

                dsConfigLoteConsumo1.search_mp.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsConfigLoteConsumo1.search_mp);

                dv = new DataView(dsConfigLoteConsumo1.search_mp);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Seleccionado")
            {
                var gridView = (GridView)gridControlDetalleMP.FocusedView;
                var row = (dsConfigLoteConsumo.search_mpRow)gridView.GetFocusedDataRow();
                if (Convert.ToBoolean(e.Value))
                {
                    ItemSeleccionado.id = row.id;
                    ItemSeleccionado.ItemCode = row.ItemCode;
                    ItemSeleccionado.ItemName = row.Name_;
                    row.Seleccionado = true;
                }

                foreach (dsConfigLoteConsumo.search_mpRow row1 in dsConfigLoteConsumo1.search_mp)
                {
                    if (row1.id != ItemSeleccionado.id)
                        row1.Seleccionado = false;
                }
            }
        }

        private void frmSearchDefault_Activated(object sender, EventArgs e)
        {
            txtParametroBusqueda.Focus();
        }

        private void cmdAplicar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtParametroBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down)
            {
                if (dsConfigLoteConsumo1.search_mp.Count > 0)
                {
                    var gridView = (GridView)gridControlDetalleMP.FocusedView;
                    //var row = (dsMensualidades.mensualidadesRow)gridView.GetFocusedDataRow();
                    //gridView.FocusedRowHandle = gridView.GetVisibleRowHandle(0);
                    gridView1.FocusedRowHandle = gridView1.GetVisibleRowHandle(0);
                    SendKeys.Send("{tab}");
                    // Focus a specific cell.
                    //gridView1.FocusedRowHandle = 1;
                    //gridView1.FocusedColumn = colSeleccionado;

                }
            }

            if(e.KeyCode == Keys.Enter)
            {
                if(dv.Count == 1)
                {
                    var gridView = (GridView)gridControlDetalleMP.FocusedView;
                    var row = (dsConfigLoteConsumo.search_mpRow)gridView.GetDataRow(0);

                    ItemSeleccionado.id = row.id;
                    ItemSeleccionado.ItemCode = row.ItemCode;
                    ItemSeleccionado.ItemName = row.Name_;
                    row.Seleccionado = true;
                    cmdAplicar_Click(new object(), new EventArgs());
                }
            }
        }

        private void txtParametroBusqueda_EditValueChanged(object sender, EventArgs e)
        {
            dv.RowFilter = @"[concat_] like '%" + txtParametroBusqueda.Text + "%'";
            gridControlDetalleMP.DataSource = dv;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var gridView = (GridView)gridControlDetalleMP.FocusedView;
            var row = (dsConfigLoteConsumo.search_mpRow)gridView.GetFocusedDataRow();

            ItemSeleccionado.id = row.id;
            ItemSeleccionado.ItemCode = row.ItemCode;
            ItemSeleccionado.ItemName = row.Name_;
            row.Seleccionado = true;
            cmdAplicar_Click(new object(), new EventArgs());

            foreach (dsConfigLoteConsumo.search_mpRow row1 in dsConfigLoteConsumo1.search_mp)
            {
                if (row1.id != ItemSeleccionado.id)
                    row1.Seleccionado = false;
            }
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                var gridView = (GridView)gridControlDetalleMP.FocusedView;
                var row = (dsConfigLoteConsumo.search_mpRow)gridView.GetFocusedDataRow();

                //row.Seleccionado = true;
                ItemSeleccionado.id = row.id;
                ItemSeleccionado.ItemCode = row.ItemCode;
                ItemSeleccionado.ItemName = row.Name_;
                //row.Seleccionado = true;
                cmdAplicar_Click(sender, new EventArgs());
            }
        }
    }
}