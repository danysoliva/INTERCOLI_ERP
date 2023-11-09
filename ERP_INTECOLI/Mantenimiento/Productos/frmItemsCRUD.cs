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

namespace ERP_INTECOLI.Mantenimiento.Productos
{
    public partial class frmItemsCRUD : DevExpress.XtraEditors.XtraForm
    {
        private UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();



        public frmItemsCRUD(UserLogin pUserLogin)
        {
            InitializeComponent();
            UsuarioLogeado = pUserLogin;
            tsHabilitados.IsOn = true;

            CargarItems();
        }

        private void CargarItems()
        {
            string sql = @"sp_get_load_items";
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@habilitado", tsHabilitados.IsOn);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsMantenimiento1.Producto.Clear();
                adat.Fill(dsMantenimiento1.Producto);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void tsHabilitados_Toggled(object sender, EventArgs e)
        {
            CargarItems();
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            frmItemsOP frm = new frmItemsOP(UsuarioLogeado, frmItemsOP.TipoOperacion.Nuevo, 0);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarItems();
            }
        }

        private void ButtonEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grdProductos.FocusedView;
            var row = (dsMantenimiento.ProductoRow)gridview.GetFocusedDataRow();

            frmItemsOP frm = new frmItemsOP(UsuarioLogeado, frmItemsOP.TipoOperacion.Editar, row.id);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarItems();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}