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
                if(vEstudiante == null)
                    vEstudiante = new Estudiante();

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

        private void CargarDatos(Int64 estudianteSeleccionadoId)
        {
            try
            {
                string sql = @"[dbo].[sp_get_estado_cuenta_estudiante_v2]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_estudiante", estudianteSeleccionadoId);
                //if(vEstudiante.IdStudent == null) 
                //    cmd.Parameters.AddWithValue("@id_student", DBNull.Value);
                //else
                //    cmd.Parameters.AddWithValue("@id_student", vEstudiante.IdStudent);

                cmd.Parameters.AddWithValue("@ver_nulos", rdTodos.Checked);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsMovimientosSaldos1.estado_cuenta_lines.Clear();
                adat.Fill(dsMovimientosSaldos1.estado_cuenta_lines);

            }
            catch (Exception ec)
            {
                CajaDialogo.Error("No se pudo cargar el detalle de Movimientos del Estudiante!", ec);
            }
        }

        private void cmbCargarDatos_Click(object sender, EventArgs e)
        {
            if (vEstudiante != null)
                CargarDatos(vEstudiante.IdEstudiante);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}