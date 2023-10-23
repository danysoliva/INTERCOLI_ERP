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
using DevExpress.XtraGrid.Views.Grid;
using System.Data.SqlClient;

namespace ERP_INTECOLI.Usuarios
{
    public partial class frmViewUser : DevExpress.XtraEditors.XtraForm
    {
        int IdUsuarioSeleccionado;
        string Nombre;
        bool Activo;
        string ADuser;

        public frmViewUser(int pidUsuario, string pNombre, bool pActivo, string pADuser)
        {
            InitializeComponent();
            IdUsuarioSeleccionado = pidUsuario;
            txtId.Text = IdUsuarioSeleccionado.ToString();
            txtNombreUsuario.Text = Nombre = pNombre;
            chkActivo.Checked = Activo = pActivo;
            txtUsuarioAD.Text = ADuser = pADuser;
            CargarVentanasUsuario(pidUsuario);
        }

        private void CargarVentanasUsuario(int pidUsuario)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();

                string sql = @"SELECT vv.[id_ventana]
		                                ,[nombre]
		                                ,[codigo]
		                                ,[descripcion]
		                                ,[habilitada]
		                                ,[fecha_vinculo]
                                FROM [dbo].[conf_ventanas] vv join
	                                 [dbo].[conf_usuario_ventanas] uu 
	                                 on vv.id_ventana = uu.id_ventana
                                where uu.id_usuario = " + pidUsuario.ToString();
                SqlCommand cmd = new SqlCommand(sql, conn);
                dsUsuarios1.view_user.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsUsuarios1.view_user);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void button_eliminar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            DialogResult r = CajaDialogo.Pregunta("Realmente desea eliminar este permiso?");
            if (r != System.Windows.Forms.DialogResult.Yes)
                return;

            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsUsuarios.view_userRow)gridView.GetFocusedDataRow();

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                //string sql = @"DELETE FROM [dbo].[conf_usuario_ventana_funciones]
                //                WHERE id_usuario = " + IdUsuarioSeleccionado.ToString() +
                //                    " and id_ventana = " + row.id_ventana.ToString();
                //SqlCommand cmd = new SqlCommand(sql, conn);
                //cmd.ExecuteNonQuery();

                string sql2 = @"DELETE FROM [dbo].[conf_usuario_ventanas]
                                  WHERE [id_ventana] = " + row.id_ventana.ToString() +
                              " and id_usuario = " + IdUsuarioSeleccionado.ToString();
                SqlCommand cmd2 = new SqlCommand(sql2, conn);
                cmd2.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            CargarVentanasUsuario(IdUsuarioSeleccionado);
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            frmAddWindowToUser frm = new frmAddWindowToUser(IdUsuarioSeleccionado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarVentanasUsuario(IdUsuarioSeleccionado);
            }
        }
    }
}