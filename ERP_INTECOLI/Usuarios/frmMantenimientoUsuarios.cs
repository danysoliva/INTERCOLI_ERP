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

namespace ERP_INTECOLI.Usuarios
{
    public partial class frmMantenimientoUsuarios : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogueado;
        public frmMantenimientoUsuarios(UserLogin pUserLog)
        {
            InitializeComponent();
            UsuarioLogueado = pUserLog;

            CargarUsuarios(false);
        }

        private void CargarUsuarios(bool pMostrarOcultos)
        {
            try
            {
                dsUsuarios1.Usuarios.Clear();
                string sql = @"[sp_carga_usuarios_para_mantenimiento_v2]";//"select * from admon.ft_carga_usuarios_para_mantenimiento();";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mostrar_ocultos", pMostrarOcultos);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsUsuarios1.Usuarios);
            }
            catch (Exception ec)
            {
                MessageBox.Show("No se pudo cargar la lista de usuarios!" + ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            //Users usx = new Users(psConnection);
            frmUser fx = new frmUser(frmUser.TipoEdicion.Nuevo, UsuarioLogueado, "");
            if (fx.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CargarUsuarios(toggleSwitch1.IsOn);
            }
        }

        private void ButtonEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grdUsuario.FocusedView;
            var row = (dsUsuarios.UsuariosRow)gridview.GetFocusedDataRow();

            frmUser frm = new frmUser(frmUser.TipoEdicion.Editar, UsuarioLogueado, row.alias);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarUsuarios(toggleSwitch1.IsOn);
            }
        }

        private void ButtoPermisos_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            var gridView = (GridView)grdUsuario.FocusedView;
            var row = (dsUsuarios.UsuariosRow)gridView.GetFocusedDataRow();

            frmViewUser frm = new frmViewUser(row.id_usuario, row.nombre, row.habilitado, row.alias);
            frm.Show();
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            CargarUsuarios(toggleSwitch1.IsOn);
        }
    }
}