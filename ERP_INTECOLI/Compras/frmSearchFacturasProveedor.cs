using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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

namespace ERP_INTECOLI.Compras
{
    public partial class frmSearchFacturasProveedor : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public int IdFacturaSeleccionado = 0;
        public enum FiltroFacturas
        {
            Todas = 1,
            Abiertas = 2
        }
        FiltroFacturas Filtro;

        public frmSearchFacturasProveedor(FiltroFacturas pfiltro)
        {
            InitializeComponent();
            Filtro = pfiltro;
            LoadData();
        }

        private void LoadData()
        {

            try
            {
                string query = @"sp_compras_get_facturas";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                switch (Filtro)
                {
                    case FiltroFacturas.Todas:
                        cmd.Parameters.AddWithValue("@filtro", 1);
                        break;

                    case FiltroFacturas.Abiertas:
                        cmd.Parameters.AddWithValue("@filtro", 2);
                        break;

                    default:
                        break;
                }

                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.search_facturas.Clear();
                adat.Fill(dsCompras1.search_facturas);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var gridview = (GridView)grdSolicitudes.FocusedView;
            var row = (dsCompras.search_facturasRow)gridview.GetFocusedDataRow();

            if (row.id_factura > 0)
            {
                IdFacturaSeleccionado = row.id_factura;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void reposSelected_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grdSolicitudes.FocusedView;
            var row = (dsCompras.search_facturasRow)gridview.GetFocusedDataRow();

            if (row.id_factura > 0)
            {
                IdFacturaSeleccionado = row.id_factura;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}