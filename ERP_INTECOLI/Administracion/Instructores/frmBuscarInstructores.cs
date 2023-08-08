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
using System.Data.SqlClient;
using ERP_INTECOLI.Administracion.Instructores;
using ERP_INTECOLI.Clases;
using DevExpress.XtraGrid.Views.Grid;

namespace ERP_INTECOLI.Administracion.Instructores
{
    public partial class frmBuscarInstructores : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();
        DataView dv;
        private int Id_instructor = 0;

        public frmBuscarInstructores(UserLogin pUserLogin)
        {
            InitializeComponent();
            UsuarioLogeado = pUserLogin;

            cargar_instructores();

        }

        private void cargar_instructores()
        {
            try
            {
                string query = @"sp_instructores_get_all";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@habilitado", tsHabilitados.IsOn);
                dsInstructores1.Instructores_Datos.Clear();
                adat.Fill(dsInstructores1.Instructores_Datos);

                dv = new DataView(dsInstructores1.Instructores_Datos);
                conn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void txtParametro_EditValueChanged(object sender, EventArgs e)
        {
            dv.RowFilter = @"concatenacion like '%" + txtParametro.Text + "%'";
            grdInstructores.DataSource = dv;
            
        }

        private void tsHabilitados_Toggled(object sender, EventArgs e)
        {
            cargar_instructores();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            frmAgregarInstructores frmAbrirInst = new frmAgregarInstructores(UsuarioLogeado, Id_instructor, frmAgregarInstructores.TipoTransaccion.Insert);

            // frmAbrirInst.MdiParent = this.MdiParent;
            if (frmAbrirInst.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Llamar funcion CargarDatos
                cargar_instructores();
            }
        }

        private void reposEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grdInstructores.FocusedView;
            var row = (dsInstructores.instructoresRow)gridview.GetFocusedDataRow();

            frmAgregarInstructores frm = new frmAgregarInstructores(UsuarioLogeado, row.id_instructor, frmAgregarInstructores.TipoTransaccion.Update);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                cargar_instructores();
            }
        }

        private void repost_edit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grdInstructores.FocusedView;
            var row = (dsInstructores.Instructores_DatosRow)gridview.GetFocusedDataRow();

            frmAgregarInstructores frm = new frmAgregarInstructores(UsuarioLogeado, row.id_instructor, frmAgregarInstructores.TipoTransaccion.Update);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                cargar_instructores();
            }
        }
    }
}