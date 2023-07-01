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
using ERP_INTECOLI.Administracion.Estudiantes;

namespace ERP_INTECOLI.Administracion.Estudiantes
{
    public partial class frmEstudiantesGroup : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();
        public frmEstudiantesGroup(UserLogin pUserLogin)
        {
            InitializeComponent();
            UsuarioLogeado = pUserLogin;
            load_data();
        }

        private void load_data()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand("", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ver_todos", tsVerTodos.IsOn);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsEstudiantes1.estudiantes.Clear();
                adat.Fill(dsEstudiantes1.estudiantes);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void tsVerTodos_Toggled(object sender, EventArgs e)
        {
            load_data();
        }

        private void cmbBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}