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
using ERP_INTECOLI.Clases;
using ERP_INTECOLI.Administracion.Matricula;
using System.Data.SqlClient;

namespace ERP_INTECOLI.Administracion.Matricula
{
    public partial class ctl_Matricula : DevExpress.XtraEditors.XtraUserControl
    {
        public ctl_Matricula()
        {
            InitializeComponent();
        }

        public Estudiante vEstudiante;
        DataOperations dp = new DataOperations();
        public decimal Valor;
        public bool editar;
        public UserLogin UsuarioLogueado;
        public int IdCurso;
        public int IdSeccion;
        public int IdNivel;
        public event EventHandler OnCancelar;
        public event EventHandler OnGuardarClick;

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            OnCancelar.Invoke(sender, e);
        }


        public void CargarDatos()
        {
            try
            {
                string sql = "select * from admon.ft_carga_niveles_disponibles();";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsNuevoCursoMatricula1.niveles.Clear(); //dsMatricula1.niveles.Clear();
                adat.Fill(dsNuevoCursoMatricula1.niveles);
                //txtEstudiante.Text = vEstudiante.Nombres + " " + vEstudiante.Apellidos;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}
