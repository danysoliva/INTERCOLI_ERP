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

namespace ERP_INTECOLI.Administracion.Matricula
{
    public partial class frmMatricula : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();
        SqlConnection conn;
        Estudiante vEstudiante;
        //int Matricula_detalleID;
        int MatriculaID;
        bool editar;
        int idDetMatricula;
        int Curso;
        int MatriculaEncabezadoId;
        long idEstudiante;
        TipoMatricula tipoMatricula;
        AccionDB_Matricula AccionActualDB;

        public enum AccionDB_Matricula
        {
            Insert = 1,
            Update = 2
        }

        public enum TipoMatricula
        {
            Encabezado = 1,
            Detalle = 2
        }

        public frmMatricula(UserLogin pUserLogin, long pidEstudiante, bool pnulo, int pid_curso, int pid_detalle_matricula, decimal pvalor)
        {
            InitializeComponent();
            UsuarioLogeado = pUserLogin;

            editar = true;

            vEstudiante = new Estudiante();
            idEstudiante = pidEstudiante;
            if (vEstudiante.RecuperarRegistro(pidEstudiante))
            {
                txtEstudiante.Text = vEstudiante.Nombres + ' ' + vEstudiante.Apellidos;
            }

            CargarCursos();

            idDetMatricula = pid_detalle_matricula;

            gridLookUpEdit1.EditValue = pid_curso;
            gridLookUpEdit1.Enabled = false;

            chkNula.Visible = true;
            chkNula.Checked = pnulo;
            txtMensualidad.Text = pvalor.ToString("###,###.00");
        }

        private void CargarCursos()
        {
            try
            {
                conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                dsMatriculado1.Cursos.Clear();
                //string sql = @"select t1.id,t2.descripcion||' ('||t1.seccion||')' as Curso 
                //            from admon.cursos t1 
                //            inner join admon.niveles t2 on t1.id_nivel=t2.id_nivel
                //            where t1.curso_finalizado=false";
                string sql = @"sp_get_cursos_for_matricula";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMatriculado1.Cursos);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error("No se pudieron cargar los niveles academicos para el ultracombobox! \n", ec);
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btnDetalleCurso_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gridLookUpEdit1.Text))
            {
                CajaDialogo.Information("Debe seleccionar un curso");
                return;
            }
            else
            {
                frmMostarDetallesCurso frm = new frmMostarDetallesCurso(UsuarioLogeado, Convert.ToInt32(gridLookUpEdit1.EditValue));
                frm.ShowDialog();
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            errorAlumno.Clear();
            errorNivel.Clear();
            errorInstructor.Clear();

            if (string.IsNullOrEmpty(gridLookUpEdit1.Text))
            {
                CajaDialogo.Error("Debe seleccionar un curso");
                return;

                gridLookUpEdit1.Focus();
            }

            if (editar == false)
            {
                if (PerteneceACurso() == true)
                {
                    CajaDialogo.Error("Estudiante ya esta matriculado en este curso");
                    return;
                }
            }

            if (editar)
            {
                try
                {
                    string sql = @"sp_matricula_update_";

                    decimal valor1;

                    try
                    {
                        valor1 = Convert.ToDecimal(txtMensualidad.Text);
                    }
                    catch 
                    {
                        CajaDialogo.Error("Ingrese una Cantidad Valida");
                        txtMensualidad.Focus();
                        return;
                    }
                    SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nula",chkNula.Checked);
                    cmd.Parameters.AddWithValue("@valor", valor1);
                    cmd.Parameters.AddWithValue("@iddetalle", idDetMatricula);
                    cmd.ExecuteScalar();

                    CajaDialogo.Information("GUARDADO EXITOSAMENTE!");
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }

            }
            else
            {
                try
                {
                    //string SQL = @" select * from admon.ft_insert_matricula_real (
                    //                                                              :pid_estudiante,
                    //                                                              :pvalor,
                    //                                                              :pcurso_id)";
                    string sql = @"sp_matricula_insert_matricula_real";
                    decimal valor;
                    try
                    {
                        valor = Convert.ToDecimal(txtMensualidad.Text);
                    }
                    catch
                    {
                        CajaDialogo.Error("Ingrese una cantidad validad!");
                        txtMensualidad.Focus();
                        return;
                    }
                    SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@estudiante_id",vEstudiante.IdEstudiante);
                    cmd.Parameters.AddWithValue("@valor",  valor);
                    cmd.Parameters.AddWithValue("@curso_id", Convert.ToInt32(gridLookUpEdit1.EditValue));
                    cmd.ExecuteScalar();

                    CajaDialogo.Information("GUARDADO EXITOSAMENTE!");
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception err)
                {
                    CajaDialogo.Error(err.Message);
                }
            }

        }

        private Boolean PerteneceACurso()
        {

            try
            {
                //string SQL = @"select t1.curso_id
                //                from admon.matricula_detalle t1
                //                where t1.id_estudiante=230 and t1.curso_id=" + Convert.ToInt32(gridLookUpEdit1.EditValue);
                string SQL = @"sp_get_validar_pertenecer_a_curso";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(SQL, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_estudiante", idEstudiante);
                cmd.Parameters.AddWithValue("@id_curso", Convert.ToInt32(gridLookUpEdit1.EditValue));
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    return true;
                }
                else
                    return false;

                conn.Close();
            }
            catch (Exception error)
            {
                return true;
                conn.Close();
                CajaDialogo.Error(error.Message);
            }

        }

        private void txtEstudiante_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                frmBuscarEstudiantes fx1 = new frmBuscarEstudiantes();
                if (fx1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    if (vEstudiante.RecuperarRegistro(fx1.ItemSeleccionado.id_estudiantes))
                    {
                        txtEstudiante.Text = vEstudiante.Nombres + " " + vEstudiante.Apellidos;
                    }
                }
                else
                {
                    txtEstudiante.Text = "";
                }
            }
        }

        private void frmMatricula_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.DialogResult = DialogResult.Cancel;
        }
    }
}