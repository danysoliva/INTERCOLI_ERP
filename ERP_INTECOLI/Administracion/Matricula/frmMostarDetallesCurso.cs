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
using ERP_INTECOLI.Administracion.Cursos;
using ERP_INTECOLI.Clases;

namespace ERP_INTECOLI.Administracion.Matricula
{
    public partial class frmMostarDetallesCurso : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogueado;
        int curso_id = 0;
        DataOperations dp = new DataOperations();
        CheckBox[] cbDias = new CheckBox[7];

        public frmMostarDetallesCurso(UserLogin pUserLog, int IdCurso)
        {
            InitializeComponent();

            UsuarioLogueado = pUserLog;
            curso_id = IdCurso;

            //asigna los valores de los checkbox al arreglo de checkbox
            cbDias[0] = lunes;
            cbDias[1] = Martes;
            cbDias[2] = Miercoles;
            cbDias[3] = Jueves;
            cbDias[4] = Viernes;
            cbDias[5] = Sabado;
            cbDias[6] = Domingo;

            CargarCursos();
            CargarDias(cbDias);
        }

        private void CargarDias(CheckBox[] cbDias)
        {
            try
            {
                dsCursos_1.DiasCursos.Clear();
                string Query = @"select dia from curso_dias where id_curso=" + curso_id;
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsCursos_1.DiasCursos);

                SetDiasClases(dsCursos_1.DiasCursos);
            }

            catch (Exception error)
            {

                CajaDialogo.Error("Ocurrio un error ", error);
            }
        }

        private void SetDiasClases(DataTable dtDias)
        {
            for (int i = 1; i <= cbDias.Length; i++)
            {
                for (int u = 0; u < dtDias.Rows.Count; u++)
                {
                    int fila = Convert.ToInt32(dtDias.Rows[u][0].ToString());

                    if (i == fila)
                        cbDias[fila - 1].Checked = true;

                }
            }
        }

        private void CargarCursos()
        {
            try
            {
                dsCursos_1.Cursos.Clear();
                string sql = @"select 	t1.id,
		                                t1.id_nivel,
                                        t2.descripcion,
                                        t1.seccion,
                                        t1.id_instructor,
		                                (COALESCE(t3.nombres,'') + ' ' + COALESCE(t3.apellidos,'')) as nombres,
                                        t1.hora_inicio,
                                        t1.hora_fin,
                                        t1.fecha_posteo,
                                        t1.fecha_inicio,
                                        t1.fecha_fin,
                                        t1.curso_finalizado
                                from cursos t1 inner join niveles t2 
									on t1.id_nivel=t2.id_nivel
	                            INNER JOIN instructores t3 
									on t1.id_instructor=t3.id_instructor
                                where t1.curso_finalizado= 0 and t1.id=" + curso_id;
                //string sql @"";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsCursos_1.Cursos);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error("No se pudo cargar el set de cursos! ", ec);
            }
        }
    }
}