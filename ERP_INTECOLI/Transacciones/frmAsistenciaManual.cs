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
using ERP_INTECOLI.Administracion.Estudiantes;
using ERP_INTECOLI.Clases;
using System.Data.SqlClient;

namespace ERP_INTECOLI.Transacciones
{
    public partial class frmAsistenciaManual : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogueado;
        DataOperations dp = new DataOperations();
        Estudiante vEstudiante;

        public frmAsistenciaManual(UserLogin PuserLogin)
        {
            InitializeComponent();
            UsuarioLogueado = PuserLogin;

            vEstudiante = new Estudiante();
        }

        private void cmdF2_Click(object sender, EventArgs e)
        {
            BuscarEstudiante();
        }

        private void BuscarEstudiante()
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

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (vEstudiante != null)
            {
                if (vEstudiante.IdEstudiante > 0)
                {
                    if (!string.IsNullOrEmpty(dateEdit1.Text))
                    {
                        //Postear asistencia
                        try
                        {
                            SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                            conn.Open();
                            SqlCommand cmd = new SqlCommand(@"sp_insert_marca_manual_asistencia", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_estudiante", vEstudiante.IdEstudiante);
                            cmd.Parameters.AddWithValue("@phora_marcada", dateEdit1.EditValue);
                            cmd.ExecuteScalar();
                            CajaDialogo.Information("Transacción exitosa!");
                            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                            this.Close();
                        }
                        catch (Exception ec)
                        {
                            CajaDialogo.Error(ec.Message);
                        }
                    }
                    else
                    {
                        CajaDialogo.Error("No se puede guardar una hora manual sin la fecha y hora!");
                        return;
                    }
                }
                else
                {
                    CajaDialogo.Error("Debe definir el estudiante al cual poner asistencia.");
                    return;
                }
            }
        }
    }
}