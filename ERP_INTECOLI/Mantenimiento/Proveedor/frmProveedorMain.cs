using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERP_INTECOLI.Clases;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using ERP_INTECOLI.Mantenimiento.Productos;

namespace ERP_INTECOLI.Mantenimiento.Proveedor
{
    public partial class frmProveedorMain : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogueado;
        DataOperations dp = new DataOperations();
        public frmProveedorMain(UserLogin pUserLog)
        {
            InitializeComponent();

            UsuarioLogueado = pUserLog;
            tsHabilitados.IsOn = true;

            CargarProveedores();
        }

        private void CargarProveedores()
        {
            try
            {
                dsMantenimiento1.Proveedor.Clear();
                string sql = @"sp_get_all_proveedores";//"select * from admon.ft_carga_usuarios_para_mantenimiento();";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@habilitado", tsHabilitados.IsOn);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMantenimiento1.Proveedor);
            }
            catch (Exception ec)
            {
                MessageBox.Show("No se pudo cargar la lista de Proveedores!" + ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grdUsuario.FocusedView;
            var row = (dsMantenimiento.ProveedorRow)gridview.GetFocusedDataRow();

            frmProveedorCRUD frm = new frmProveedorCRUD(UsuarioLogueado, frmProveedorCRUD.TipoOperacion.Editar, row.id_prov);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarProveedores();
            }
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            frmProveedorCRUD frm = new frmProveedorCRUD(UsuarioLogueado, frmProveedorCRUD.TipoOperacion.Nuevo, 0);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarProveedores();
            }
        }

        private void tsHabilitados_Toggled(object sender, EventArgs e)
        {
            CargarProveedores();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}