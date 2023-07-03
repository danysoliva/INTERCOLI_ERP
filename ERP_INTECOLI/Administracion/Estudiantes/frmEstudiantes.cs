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
using System.Collections;

namespace ERP_INTECOLI.Administracion.Estudiantes
{
    public partial class frmEstudiantes : DevExpress.XtraEditors.XtraForm
    {
        private int Idestudiante;
        Estudiante vEstudiante;
        ArrayList ListaTelefonos;
        private int IdEstudianteRecomendo;

        public enum TipoEdicion
        { 
            Nuevo = 1,
            Editar = 2
        }

        private UserLogin UsuarioLogeado;
        private TipoEdicion pTipoEdit;

        public frmEstudiantes(UserLogin pUserLogin, TipoEdicion pTipo)
        {
            InitializeComponent();
            UsuarioLogeado = pUserLogin;
            CargarNiveles();
            CargarZonas();

            ListaTelefonos = new ArrayList();



        }

        public frmEstudiantes(UserLogin pUserLogin, TipoEdicion pTipo, int pid_estudiante)
        {
            InitializeComponent();
            UsuarioLogeado = pUserLogin;

            Idestudiante = pid_estudiante;

            Estudiante est = new Estudiante();
            est.RecuperarRegistro(Idestudiante);

        }

        private void CargarZonas()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_get_zonas", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsEstudiantes.niveles_academicos.Clear();
                adat.Fill(dsEstudiantes.niveles_academicos);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void CargarNiveles()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_load_niveles_", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsEstudiantes.niveles_academicos.Clear();
                adat.Fill(dsEstudiantes.niveles_academicos);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}