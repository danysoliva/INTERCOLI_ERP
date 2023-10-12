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
using ERP_INTECOLI.Administracion.Estudiantes;
using System.Data.SqlClient;

namespace ERP_INTECOLI.Transacciones
{
    public partial class frmEstadoCuenta : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogueado;
        Estudiante vEstudiante;
        DataOperations dp = new DataOperations();
        public frmEstadoCuenta(UserLogin pUser)
        {
            InitializeComponent();
        }

        private void cmdF2_Click(object sender, EventArgs e)
        {
            frmBuscarEstudiantes fx1 = new frmBuscarEstudiantes();
            if (fx1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                if (vEstudiante.RecuperarRegistro(fx1.ItemSeleccionado.id_estudiantes))
                {
                    txtEstudiante.Text = vEstudiante.Nombres + " " + vEstudiante.Apellidos;
                    CargarDatos(fx1.ItemSeleccionado.id_estudiantes);
                }
            }
            else
            {
                txtEstudiante.Text = "";
            }
        }

        private void CargarDatos(int estudianteSeleccionadoId)
        {
            try
            {
                //string sql = @"ft_get_estado_cuenta_estudiante";
                //SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                //conn.Open();
                //PgSqlCommand cmd = new PgSqlCommand(sql, psConnection);
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("pid_estudiante", estudianteSeleccionadoId);
                //cmd.Parameters.AddWithValue("pid_student", vEstudiante.IdStudent);
                //cmd.Parameters.AddWithValue("pver_nulos", rdTodos.Checked);
                //PgSqlDataAdapter adat = new PgSqlDataAdapter(cmd);
                //dsMovimientosSaldos1.estado_cuenta.Clear();
                //adat.Fill(dsMovimientosSaldos1.estado_cuenta);

            }
            catch (Exception ec)
            {
                CajaDialogo.Error("No se pudo cargar el detalle de Movimientos del Estudiante!", ec);
            }
        }
    }
}