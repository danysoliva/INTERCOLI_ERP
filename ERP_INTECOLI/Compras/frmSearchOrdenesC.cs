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
    public partial class frmSearchOrdenesC : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        PuntoVenta PuntoVentaActual;
        public int IdOrdenesSeleccionado = 0;

        public enum FiltroOrdenesCompra
        {
            Todas = 1,
            Abiertas = 2
        }

        FiltroOrdenesCompra Filtro;

        public frmSearchOrdenesC(frmSearchOrdenesC.FiltroOrdenesCompra pfiltro, PuntoVenta pPuntoVentaActual)
        {
            InitializeComponent();
            Filtro = pfiltro;
            this.PuntoVentaActual = pPuntoVentaActual;
            LoadData();
        }

        private void LoadData()
        {

            try
            {
                string query = @"sp_get_ordenes_compra_open";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                switch (Filtro)
                {
                    case FiltroOrdenesCompra.Todas:
                        cmd.Parameters.AddWithValue("@filtro", 1);
                        break;

                    case FiltroOrdenesCompra.Abiertas:
                        cmd.Parameters.AddWithValue("@filtro", 2);
                        break;

                    default:
                        break;
                }
                cmd.Parameters.AddWithValue("@PuntoVentaActual", PuntoVentaActual.ID);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.orden_compra.Clear();
                adat.Fill(dsCompras1.orden_compra);
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
            var row = (dsCompras.orden_compraRow)gridview.GetFocusedDataRow();

            if (row.id > 0)
            {
                IdOrdenesSeleccionado = row.id;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void reposSelected_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grdSolicitudes.FocusedView;
            var row = (dsCompras.orden_compraRow)gridview.GetFocusedDataRow();

            if (row.id > 0)
            {
                IdOrdenesSeleccionado = row.id;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}