using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using ERP_INTECOLI.Clases;
using JAGUAR_APP.Facturacion.CoreFacturas;
using JAGUAR_APP.Facturacion.CoreFacturas.FacturaParaPuntoDeVenta;
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

namespace LOSA.Calidad.LoteConfConsumo
{
    public partial class frmSearchWithPDV : DevExpress.XtraEditors.XtraForm
    {
        //public MateriaPrima MateriaPrimaSelected;
        DataOperations dp = new DataOperations();
        public ItemBusquedaFactura ItemSeleccionado;
        public string EmpresaName;
        public string EmpresaRTN;
        public int EmpresaID;

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
            PuntoVenta = 9,
            PuntosDeVentaAND_Cliente = 10
        }

        TipoBusqueda TipoBusquedaActual;
        public frmSearchWithPDV(TipoBusqueda pTipo)
        {
            InitializeComponent();
            TipoBusquedaActual = pTipo;
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
                case TipoBusqueda.PuntoVenta:
                    LoadData();
                    break;
                case TipoBusqueda.PuntosDeVentaAND_Cliente:
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

                dsBusquedas1.search_mp.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsBusquedas1.search_mp);
                dv = new DataView(dsBusquedas1.search_mp);
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

                dsBusquedas1.search_mp.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsBusquedas1.search_mp);

                dv = new DataView(dsBusquedas1.search_mp);
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
                var row = (dsBusquedas.search_mpRow)gridView.GetFocusedDataRow();
                if (Convert.ToBoolean(e.Value))
                {
                    ItemSeleccionado.id = row.id;
                    ItemSeleccionado.ItemCode = row.ItemCode;
                    ItemSeleccionado.ItemName = row.Name_;
                    ItemSeleccionado.tipo = row.tipo;
                    row.Seleccionado = true;
                }

                foreach (dsBusquedas.search_mpRow row1 in dsBusquedas1.search_mp)
                {
                    if (row1.id != ItemSeleccionado.id)
                        row1.Seleccionado = false;
                }
            }
        }

        private void frmSearchWithPDV_Activated(object sender, EventArgs e)
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
            if(e.KeyCode == Keys.Enter)
            {
                if(dv.Count == 1)
                {
                    var gridView = (GridView)gridControlDetalleMP.FocusedView;
                    var row = (dsBusquedas.search_mpRow)gridView.GetDataRow(0);

                    ItemSeleccionado.id = row.id;
                    ItemSeleccionado.ItemCode = row.ItemCode;
                    ItemSeleccionado.ItemName = row.Name_;
                    ItemSeleccionado.tipo = row.tipo;
                    row.Seleccionado = true;
                    //cmdAplicar_Click(new object(), new EventArgs());
                    cmdSiguiente_Click(sender, new EventArgs());
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                if (dsConfigLoteConsumo1.search_mp.Count > 0)
                {
                    var gridView = (GridView)gridControlDetalleMP.FocusedView;
                    gridView1.FocusedRowHandle = gridView1.GetVisibleRowHandle(0);
                    SendKeys.Send("{tab}");
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
            var row = (dsBusquedas.search_mpRow)gridView.GetFocusedDataRow();

            ItemSeleccionado.id = row.id;
            ItemSeleccionado.ItemCode = row.ItemCode;
            ItemSeleccionado.ItemName = row.Name_;
            ItemSeleccionado.tipo = row.tipo;
            row.Seleccionado = true;
            cmdAplicar_Click(new object(), new EventArgs());

            foreach (dsBusquedas.search_mpRow row1 in dsBusquedas1.search_mp)
            {
                if (row1.id != ItemSeleccionado.id)
                    row1.Seleccionado = false;
            }
            cmdSiguiente_Click(sender, e);
        }

        private void cmdSiguiente_Click(object sender, EventArgs e)
        {
            if (ItemSeleccionado.id > 0)
            {
                //Next
                navigationFrameSearch.SelectedPage = navigationPage2;
                LoadRTN_EmpresasClietne();
            }
            else
            {
                CajaDialogo.Error("Es necesario seleccionar un cliente!");
            }

        }

        private void LoadRTN_EmpresasClietne()
        {
            try
            {
                SqlConnection con;
                con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_empresas_rtn_cliente]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_cliente", ItemSeleccionado.id);

                dsSearchWindow1.RTN_Cliente.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsSearchWindow1.RTN_Cliente);

                dv = new DataView(dsSearchWindow1.RTN_Cliente);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdBackPage_Click(object sender, EventArgs e)
        {
            //Back
            navigationFrameSearch.SelectedPage = navigationPage1;
            txtParametroBusqueda.Focus();
        }

        private void gridView2_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Seleccionado")
            {
                var gridView = (GridView)gridControl1.FocusedView;
                var row = (dsSearchWindow.RTN_ClienteRow)gridView.GetFocusedDataRow();
                if (Convert.ToBoolean(e.Value))
                {
                    EmpresaName = row.NombreLargo;
                    EmpresaRTN = row.RTN;
                    EmpresaID = row.IdEmpresa;
                    row.Seleccionado = true;
                }

                foreach (dsSearchWindow.RTN_ClienteRow row1 in dsSearchWindow1.RTN_Cliente)
                {
                    if (row1.IdEmpresa != EmpresaID)
                        row1.Seleccionado = false;
                }
            }
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsSearchWindow.RTN_ClienteRow)gridView.GetFocusedDataRow();

            EmpresaRTN = row.RTN;
            EmpresaName = row.NombreLargo;
            EmpresaID = row.IdEmpresa;
            row.Seleccionado = true;
            //cmdAplicar_Click(new object(), new EventArgs());

            //foreach (dsSearchWindow.RTN_ClienteRow row1 in dsSearchWindow1.RTN_Cliente)
            //{
            //    if (row1.IdEmpresa != EmpresaID)
            //        row1.Seleccionado = false;
            //}
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cmdCerrar2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();   
        }

        private void cmdAplicarRTN_Click(object sender, EventArgs e)
        {
            if(EmpresaID>0)
            {
                this.DialogResult = DialogResult.OK;    
                this.Close();
            }
            else
            {
                CajaDialogo.Error("Es necesario seleccionar el RTN");
            }
        }

        private void textSearchRTN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dv.Count == 1)
                {
                    var gridView = (GridView)gridControl1.FocusedView;
                    var row = (dsSearchWindow.RTN_ClienteRow)gridView.GetDataRow(0);

                    EmpresaRTN = row.RTN;
                    EmpresaName = row.NombreLargo;
                    EmpresaID = row.IdEmpresa;
                    row.Seleccionado = true;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            //Vamos a validar el enter en el row seleccionado
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    //dsConfigLoteConsumo.search_mpRow
                    var row = (dsBusquedas.search_mpRow)gridView1.GetFocusedDataRow();

                    ItemSeleccionado.id = row.id;
                    ItemSeleccionado.ItemCode = row.ItemCode;
                    ItemSeleccionado.ItemName = row.Name_;
                    ItemSeleccionado.tipo = row.tipo;
                    row.Seleccionado = true;
                    //cmdAplicar_Click(new object(), new EventArgs());
                    cmdSiguiente_Click(sender, new EventArgs());
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void cmdAplicarSinRTN_Click(object sender, EventArgs e)
        {

            //ItemSeleccionado.id;
            //EmpresaName = row.NombreLargo;
            //EmpresaRTN = row.RTN;
            //EmpresaID = row.IdEmpresa;
            if (ItemSeleccionado.id > 0)
            {
                this.DialogResult= DialogResult.OK;
                this.Close();
            }
            
        }
    }
}