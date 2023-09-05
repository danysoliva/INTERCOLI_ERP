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
using DevExpress.XtraGrid.Views.Grid;
using ERP_INTECOLI.Administracion.Matricula;

namespace ERP_INTECOLI.Administracion.Matricula
{
    public partial class ctl_mover_estudiante1 : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogueado;
        DataOperations dp = new DataOperations();
        Estudiante est = new Estudiante();
        public int IdCursoOld;
        public int IdNivel;
        public int IdCurso;
        public int IdSeccion;
        public decimal Valor;
        public ctl_mover_estudiante1(UserLogin pUserLog, long pid_estudiante, string pdescripcion, string pseccion, decimal pvalor, int pid_curso)
        {
            InitializeComponent();
            UsuarioLogueado = pUserLog;
            est.RecuperarRegistro(pid_estudiante);
            IdCursoOld = pid_curso;
            CargarDatos();
            txtNivelOld.Text = pdescripcion;
            txtSeccion.Text = pseccion;
            txtValor.Text = pvalor.ToString();


        }

        public void CargarDatos()
        {
            try
            {
                //string sql = "select * from admon.ft_carga_niveles_disponibles();";
                string sql = @"[sp_matricula_cargar_niveles_disponibles]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsNuevoCursoMatricula1.niveles.Clear(); //dsMatricula1.niveles.Clear();
                adat.Fill(dsNuevoCursoMatricula1.niveles);
                txtEstudiante.Text = est.Nombres + " " + est.Apellidos;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        public void Clear()
        {
            txtEstudiante.Text = "";
            txtSeccion.Text = "";
            txtValor.Text = "";
            txtValorNew.Text = "";
            txtNivelOld.Text = "";
        }

        private void listBoxSeccion_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBoxSeccion.SelectedValue != null)
                IdSeccion = Convert.ToInt32(listBoxSeccion.SelectedValue);
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            DialogResult r = CajaDialogo.Pregunta("Confirme que desea mover a este Estudiante?");
            if (r != DialogResult.Yes)
                return;

            IdCurso = ObtenerCursoId();
            //string SQL = @" select * from admon.ft_insert_matricula_real (
            //                                                              :pid_estudiante,
            //                                                              :pvalor,
            //                                                              :pcurso_id)";

            //string xql = "select * from admon.ft_delete_curso_estudiante(:p_id_es, :p_id_cu)";
            string sql = @"sp_matricula_insert_and_delete_curso_estudiante";
            SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
            conn.Open();
            try
            {
                SqlCommand xmd = new SqlCommand(sql, conn);
                xmd.CommandType = CommandType.StoredProcedure;
                xmd.Parameters.AddWithValue("@id_es", est.IdEstudiante);
                xmd.Parameters.AddWithValue("@id_cu", IdCursoOld);
                xmd.Parameters.AddWithValue("@estudiante_id",  est.IdEstudiante);
                xmd.Parameters.AddWithValue("@valor", decimal.Parse(txtValorNew.Text));
                xmd.Parameters.AddWithValue("@curso_id", IdCurso);
                xmd.ExecuteScalar();

                CajaDialogo.Information("Operacion Existosa!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        public int ObtenerCursoId()
        {
            int varx = 0;
            try
            {
                //string sql = "select * from admon.ft_proc_recupera_curso_id(:p_id_nivel, :p_id_seccion);";
                string sql = @"sp_get_proc_recuperar_curso_id";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_nivel", IdNivel);
                cmd.Parameters.AddWithValue("@id_seccion", IdSeccion);
                varx = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return varx;
        }


        private void grNivelNew_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "[sp_matricula_recupera_secciones_for_id_nviel]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                if (!string.IsNullOrEmpty(grNivelNew.EditValue.ToString()))
                    cmd.Parameters.AddWithValue("@id_nivel",  grNivelNew.EditValue);
                else
                    cmd.Parameters.AddWithValue("@id_nivel", 0);

                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsNuevoCursoMatricula1.secciones.Clear(); //dsMatricula1.niveles.Clear();
                adat.Fill(dsNuevoCursoMatricula1.secciones);
                foreach (DataRow row in dsNuevoCursoMatricula1.niveles)
                {
                    if (Convert.ToInt32(row["id_nivel"]) == Convert.ToInt32(grNivelNew.EditValue))
                    {
                        txtValorNew.Text = row["valor"].ToString();
                        Valor = Convert.ToDecimal(txtValor.Text);
                        break;
                    }
                }
                if (grNivelNew.EditValue != null)
                    IdNivel = Convert.ToInt32(grNivelNew.EditValue);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}