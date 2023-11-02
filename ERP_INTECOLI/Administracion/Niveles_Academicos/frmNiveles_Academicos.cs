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
using ERP_INTECOLI.Clases;
using DevExpress.XtraGrid.Views.Grid;
using ERP_INTECOLI.Administracion.Instructores;

namespace ERP_INTECOLI.Administracion.Niveles_Academicos
{

    public partial class frmNiveles_Academicos : DevExpress.XtraEditors.XtraForm
    {
        private UserLogin UsuarioLogueado;
        public bool PermisoDenegado =  true;
        DataOperations dp = new DataOperations();

        public frmNiveles_Academicos(UserLogin pUserLogin)
        {
            InitializeComponent();
            UsuarioLogueado = pUserLogin;
            
            CargarNiveles();

        }

        private void CargarNiveles()
        {
            try
            {
                string query = @"sp_get_niveles_academicos";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@habilitado",tsHabilitados.IsOn);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsInstructores1.niveles_cursos.Clear();
                adat.Fill(dsInstructores1.niveles_cursos);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void tsHabilitados_Toggled(object sender, EventArgs e)
        {
            CargarNiveles();
        }

        private void repost_edit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grdNiveles.FocusedView;
            var row = (dsInstructores.niveles_cursosRow)gridview.GetFocusedDataRow();

            frmNivelesOP frm = new frmNivelesOP(frmNivelesOP.TipoOperacion.Update, UsuarioLogueado, row.id_nivel, row.descripcion, row.valor, row.habilitado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarNiveles();
            }

        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            frmNivelesOP frm = new frmNivelesOP(frmNivelesOP.TipoOperacion.Insert, UsuarioLogueado, 0, "", 0, false);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarNiveles();
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}