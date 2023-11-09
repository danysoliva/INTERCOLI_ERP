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

namespace ERP_INTECOLI.Administracion.Empresas
{
    public partial class frmEmpresa : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogueado;
        DataOperations dp = new DataOperations();
        public frmEmpresa(UserLogin pUserLog)
        {
            InitializeComponent();
            UsuarioLogueado = pUserLog;
            tsHabilitados.IsOn = true;

            CargarEmpresas();
        }

        private void CargarEmpresas()
        {
            try
            {
                dsEmpresa1.empresa_load.Clear();
                string sql = @"sp_get_empresa_load";//"select * from admon.ft_carga_usuarios_para_mantenimiento();";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VerTodos",tsHabilitados.IsOn);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsEmpresa1.empresa_load);
            }
            catch (Exception ec)
            {
                MessageBox.Show("No se pudo cargar la lista de Empresas!" + ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grdUsuario.FocusedView;
            var row = (dsEmpresa.empresa_loadRow)gridview.GetFocusedDataRow();

            if (row.id == 1)
            {
                CajaDialogo.Information("Este Registro no se puede Editar!");
                return;
            }

            frmCRUDEmpresa frm = new frmCRUDEmpresa(UsuarioLogueado, frmCRUDEmpresa.TipoOperacion.Editar, row.id);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarEmpresas();
            }
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            frmCRUDEmpresa frm = new frmCRUDEmpresa(UsuarioLogueado, frmCRUDEmpresa.TipoOperacion.Nuevo, 0);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarEmpresas();
            }
        }

        private void tsHabilitados_Toggled(object sender, EventArgs e)
        {
            CargarEmpresas();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}