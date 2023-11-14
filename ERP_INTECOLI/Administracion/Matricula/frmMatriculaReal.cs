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
    public partial class frmMatriculaReal : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogueado;
        public long IdEstudiante;
        Estudiante vEstudiante;

        public frmMatriculaReal(UserLogin pUserLogin)
        {
            InitializeComponent();
            UsuarioLogueado = pUserLogin;
            verificarFechaFinCurso();

            Estudiante vEstudiante = new Estudiante();
            
        }

        public frmMatriculaReal(UserLogin pUserLogin, int pIdEstudiante)
        {
            InitializeComponent();
            UsuarioLogueado = pUserLogin;
        }

        private void verificarFechaFinCurso()
        {
            SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
            conn.Open();
            try
            {
                string sql = "sp_cursos_finalizados";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            catch (Exception error)
            {
                CajaDialogo.Error("Ocurrio un error", error);
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdF2_Click(object sender, EventArgs e)
        {
            BuscarEstudiantes();
        }

        private void BuscarEstudiantes()
        {
            frmBuscarEstudiantes frm = new frmBuscarEstudiantes();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (vEstudiante == null)
                {
                    vEstudiante = new Estudiante();
                }

                if (vEstudiante.RecuperarRegistro(frm.ItemSeleccionado.id_estudiantes))
                {
                    txtEstudiante.Text = vEstudiante.Nombres + " " + vEstudiante.Apellidos;
                    CargarDatos(vEstudiante.IdEstudiante);
                    IdEstudiante = vEstudiante.IdEstudiante;
                }
            }
        }

        private void CargarDatos(long idEstudiante)
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                dsMatriculado1.matricula_detalle_real.Clear();
                //string sql = "select * from admon.v3_ft_carga_datos_detalle_matricula (:p_estudiante_id, :p_nulas, :p_finalizados);";
                string sql = @"sp_get_datos_detalle_matricula";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@estudiante_id", idEstudiante);
                cmd.Parameters.AddWithValue("@vernulas", chNulas.Checked);
                cmd.Parameters.AddWithValue("@finalizados", chMostrarFinalizados.Checked);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMatriculado1.matricula_detalle_real);
                conn.Close();
                CargarTotal();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void CargarTotal()
        {
            decimal valor = 0;
            foreach (dsMatriculado.matricula_detalle_realRow row in dsMatriculado1.matricula_detalle_real)
            {
                if (!row.cursofinalizado)
                {
                    if (!row.nulo)
                        valor += row.valor;
                }
            }
            if (valor > 0)
                txtMensualidad.Text = valor.ToString("###,###.00");
            else
                txtMensualidad.Text = "0.00";
        }

        private void txtEstudiante_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                BuscarEstudiantes();
            }
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            if (vEstudiante != null)
                if (vEstudiante.Recuperado)
                    CargarDatos(vEstudiante.IdEstudiante);
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            if(IdEstudiante > 0)
            {
                vEstudiante = new Estudiante();
                vEstudiante.RecuperarRegistro(IdEstudiante);
            }

            if (vEstudiante != null)
            {
                if (vEstudiante.IdEstudiante > 0)
                {
                    //frmMatricula frm = new frmMatricula(psConnection, this.UsuarioLogueado,vEstudiante.IdEstudiante);
                    //if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    //{
                    //    CargarDatos(vEstudiante.IdEstudiante);
                    //}

                    ctl_Matricula frm = new ctl_Matricula(UsuarioLogueado, vEstudiante.IdEstudiante);
                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        CargarDatos(vEstudiante.IdEstudiante);
                    }

                    //ctl_Matricula1.UsuarioLogueado = this.UsuarioLogueado;
                    //ctl_Matricula1.vEstudiante = vEstudiante;
                    //ctl_Matricula1.editar = false;
                    //ctl_Matricula1.CargarDatos();
                    //ctl_Matricula1.ShowPopup();

                }
                else
                {
                    CajaDialogo.Error("Presion F2 y busque un estudiante para poder matricularlo en un Curso!");
                }
            }
            else
            {
                CajaDialogo.Error("Presion F2 y busque un estudiante para poder matricularlo en un Curso!");
            }
        }

        private void chNulas_CheckedChanged(object sender, EventArgs e)
        {
            if(vEstudiante!= null)
                CargarDatos(vEstudiante.IdEstudiante);
        }

        private void chMostrarFinalizados_CheckedChanged(object sender, EventArgs e)
        {
            CargarDatos(vEstudiante.IdEstudiante);
        }

        private void txtMensualidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                txtEstudiante_KeyDown(sender, e);
        }

        private void reposEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gridControl1.FocusedView;
            var row = (dsMatriculado.matricula_detalle_realRow)gridview.GetFocusedDataRow();

            if (vEstudiante != null)
            {
                frmMatricula frm = new frmMatricula(UsuarioLogueado, vEstudiante.IdEstudiante, row.nulo, row.id_curso, row.id_detalle_matricula, row.valor);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarDatos(vEstudiante.IdEstudiante);
                }
            }
        }

        private void reposMove_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gridControl1.FocusedView;
            var row = (dsMatriculado.matricula_detalle_realRow)gridview.GetFocusedDataRow();

            if (vEstudiante != null)
            {
                ctl_mover_estudiante1 frm = new ctl_mover_estudiante1(UsuarioLogueado, row.id_estudiante, row.descripcion, row.seccion, row.valor, row.id_curso);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarDatos(vEstudiante.IdEstudiante);
                }
            }
        }
    }
}