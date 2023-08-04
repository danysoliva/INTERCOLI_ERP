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
        private int Idestudiante = 0;
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

            switch (pTipoEdit)
            {
                case TipoEdicion.Nuevo:
                    chkReingreso.Visible = false;
                    rdGraduado.Visible = rdDesertor.Visible = false;
                    break;

                case TipoEdicion.Editar:
                    chkReingreso.Visible = true;
                    rdGraduado.Visible = rdDesertor.Visible = true;
                    break;

                default:
                    break;
            }

        }

        public frmEstudiantes(UserLogin pUserLogin, TipoEdicion pTipo, int pid_estudiante)
        {
            InitializeComponent();
            UsuarioLogeado = pUserLogin;

            Idestudiante = pid_estudiante;
            CargarNiveles();
            CargarZonas();

            Estudiante est = new Estudiante();
            est.RecuperarRegistro(Idestudiante);
            txtIdentidad.Text = est.identidad;
            txtNombre.Text = est.Nombres;
            txtApellido.Text = est.Apellidos;
            dtFechaNac.EditValue = est.FechaNacimiento;
            dtFechaIngreso.EditValue = est.FechaIngreso;
            cbxSexo.Text = est.Sexo;
            txtDireccion.Text = est.Direccion;

            if (est.TipoPagoEstudiante == Estudiante.TipoPago.Anterior)
                tsTipoPago.IsOn = false;
            else
                tsTipoPago.IsOn = true;

            gridZonas.EditValue = est.IdZona;

            if (est.IdEstudianteRecomendo == 0)
            {
                radioGroup1.EditValue = 0;
            }
            else
            {
                radioGroup1.EditValue = 1;
                txtRecomendo.Text = est.NameEstudianteRecomendo;
            }

            cbxNivelIngreso.Value = est.IdNivelIngreso;
            txtEmail.Text = est.Correo;

            chkReingreso.Checked = est.Reingreso_Retiro;
            chkSeguimientoSaldo.Checked = est.SeguimientoSaldo;

            if (est.Desertor)
                rdDesertor.Checked = true;
            else
                rdDesertor.Checked = false;
            if (est.Graduado)
                rdGraduado.Checked = true;
            else
                rdGraduado.Checked = false;

            if (est.Habilitado)
                tsEstado.IsOn = true;
            else
                tsEstado.IsOn = false;

            cargar_telefonos(Idestudiante);
            cargar_rtn(Idestudiante);

            switch (pTipoEdit)
            {
                case TipoEdicion.Nuevo:
                    chkReingreso.Visible = false;
                    rdGraduado.Visible = rdDesertor.Visible = false;
                    break;

                case TipoEdicion.Editar:
                    chkReingreso.Visible = true;
                    rdGraduado.Visible = rdDesertor.Visible = true;
                    break;

                default:
                    break;
            }
        }

        private void cargar_rtn(int idestudiante)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();

                SqlCommand cmd = new SqlCommand("", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("", 1);
                dsEstudiantes1.detalle_telefonos.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                //adat.Fill(dsRecepcionMPx.pasillos);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cargar_telefonos(int idestudiante)
        {
            throw new NotImplementedException();
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
                dsEstudiantes1.niveles_academicos.Clear();
                adat.Fill(dsEstudiantes1.niveles_academicos);
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
                dsEstudiantes1.niveles_academicos.Clear();
                adat.Fill(dsEstudiantes1.niveles_academicos);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(radioGroup1.EditValue) == 0)
                cmdBuscarEstudiante.Visible = false;
            else
                cmdBuscarEstudiante.Visible = true;
        }

        private void btnTelefono_Rtn_Click(object sender, EventArgs e)
        {

        }
    }
}