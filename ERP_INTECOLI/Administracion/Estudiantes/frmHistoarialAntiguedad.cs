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

namespace ERP_INTECOLI.Administracion.Estudiantes
{
    public partial class frmHistoarialAntiguedad : DevExpress.XtraEditors.XtraForm
    {
        int Id_estudiante = 0;
        DataOperations dp = new DataOperations();
        public frmHistoarialAntiguedad(int pid_estudiante)
        {
            InitializeComponent();
            Id_estudiante = pid_estudiante;

            Estudiante est = new Estudiante();
            if (est.RecuperarRegistro(Id_estudiante))
                txtParametro.Text = est.Nombres + " " + est.Apellidos;

            CargarDatos(Id_estudiante);



        }

        private void CargarDatos(object pIdEstudiante)
        {
            try
            {
                string sql = "sp_get_detalle_antiguedad";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@estudiante", pIdEstudiante);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsAntiguedad1.intervalos.Clear();
                adat.Fill(dsAntiguedad1.intervalos);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}