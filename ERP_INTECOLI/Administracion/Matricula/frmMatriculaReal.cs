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


namespace ERP_INTECOLI.Administracion.Matricula
{
    public partial class frmMatriculaReal : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogueado;
        public int IdEstudiante;
        Estudiante vEstudiante;

        public frmMatriculaReal(UserLogin pUserLogin)
        {
            InitializeComponent();
            UsuarioLogueado = pUserLogin;
            verificarFechaFinCurso();

            Estudiante vEstudiante = new Estudiante();

        }

        private void verificarFechaFinCurso()
        {
            SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
            conn.Open();
            try
            {
                string sql = "update admon.cursos set curso_finalizado=TRUE where fecha_fin<now()";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }

            catch (Exception error)
            {
                CajaDialogo.Error("Ocurrio un error", error);
            }
        }
    }
}