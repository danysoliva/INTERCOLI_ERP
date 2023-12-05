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
        UserLogin UsuarioLogueado;
        public int IdOrdenesSeleccionado = 0;
        int PuntoVentaID;

        public enum FiltroOrdenesCompra
        {
            Todas = 1,
            Abiertas = 2
        }

        FiltroOrdenesCompra Filtro;

        public frmSearchOrdenesC(frmSearchOrdenesC.FiltroOrdenesCompra pfiltro, PuntoVenta pPuntoVentaActual, UserLogin pUserLogin)
        {
            InitializeComponent();
            Filtro = pfiltro;
            UsuarioLogueado = pUserLogin;
            this.PuntoVentaActual = pPuntoVentaActual;
            LoadData();
            PuntoVentaID = PuntoVentaActual.ID;
            LoadSucursales();
            grdSucursales.EditValue = PuntoVentaID;

            int i = Convert.ToInt32(UsuarioLogueado.GrupoUsuario.GrupoUsuarioActivo);

            switch (UsuarioLogueado.GrupoUsuario.GrupoUsuarioActivo)
            {
                case GrupoUser.GrupoUsuario.Manager:
                    grdSucursales.Enabled = true;
                    break;
                case GrupoUser.GrupoUsuario.Facturacion:
                    break;
                case GrupoUser.GrupoUsuario.Atencion_al_cliente:
                    break;
                case GrupoUser.GrupoUsuario.Cajero:
                    break;
                case GrupoUser.GrupoUsuario.Supervisor:
                    grdSucursales.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void LoadSucursales()
        {
            try
            {
                string query = @"[sp_get_lista_puntos_de_venta]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.sucursales.Clear();
                adat.Fill(dsCompras1.sucursales);
                conn.Close();
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
                cmd.Parameters.AddWithValue("@PuntoVentaActual", PuntoVentaID);
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

        private void grdSucursales_EditValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(grdSucursales.EditValue) > 0)
            {
                PuntoVentaID = Convert.ToInt32(grdSucursales.EditValue);
                LoadData();
            }
        }
    }
}