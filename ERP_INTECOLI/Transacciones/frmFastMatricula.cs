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
using System.Data.SqlClient;

namespace ERP_INTECOLI.Transacciones
{
    public partial class frmFastMatricula : DevExpress.XtraEditors.XtraForm
    {
        private Int64 IdEstudiante;
        Estudiante vEstudiante;
        private UserLogin UsuarioLogueado;
        DataOperations dp = new DataOperations();

        public frmFastMatricula(UserLogin pUser)
        {
            InitializeComponent();
            UsuarioLogueado = pUser;
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtApellido.Focus();
        }

        private void txtApellido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtValor.Focus();
        }

        private void txtValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cmdGuardar.Focus();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                CajaDialogo.Error("No puede dejar el nombre en blanco!");
                txtNombre.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtIdentidad.Text))
            {
                CajaDialogo.Error("No puede dejar el numero de identidad en blanco!");
                txtIdentidad.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                CajaDialogo.Error("No puede dejar el Apellido en blanco!");
                txtApellido.Focus();
                return;
            }

            decimal valor = 0;
            try
            {
                valor = Convert.ToDecimal(txtValor.Text);
            }
            catch
            {

            }

            bool Continue = true;
            if (valor == 0)
            {
                DialogResult r = CajaDialogo.Pregunta("Realmente desea guardar la matricula en Valor Cero (0)");
                if (r != System.Windows.Forms.DialogResult.Yes)
                    Continue = false;
            }

            if (Continue)
            {
                vEstudiante = new Estudiante();
                if (vEstudiante.ValidarIdDisponible(txtIdentidad.Text))
                {
                    CajaDialogo.Error("Este Numero de Identidad ya Existe!");
                    return;
                }

                //ConfiguracionSuccess conf = new ConfiguracionSuccess(psConnection);
                vEstudiante.Nombres = txtNombre.Text;
                vEstudiante.Apellidos = txtApellido.Text;
                vEstudiante.FechaIngreso = dp.Now();
                vEstudiante.IdEstudiante = vEstudiante.InsertEstudiante(this.UsuarioLogueado);

                if (InsertMatricula(this.UsuarioLogueado, IdEstudiante, Convert.ToDecimal(txtValor.Text)))
                {
                    //CajaDialogo.Information("Guardada con exito!");
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }

            }
        }

        private bool InsertMatricula(UserLogin pUserLog, Int64 pIdEstudiante, decimal valor)
        {
            bool a = false;
            int id_matricula = 0;
            //PgSqlTransaction tran1 = psConnection.BeginTransaction();
            try
            {
                //string sql1 = @"SELECT id_siguiente
                //                  FROM admon.tablas_id tb
                //                 where tb.nombre_tabla = 'matricula';";

                //PgSqlCommand cmd1 = new PgSqlCommand(sql1, psConnection);
                //int vid_matricula = Convert.ToInt32(cmd1.ExecuteScalar());
                //id_matricula = vid_matricula;

                string sql = @"sp_matricula_insert_fast_matricula";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd2 = new SqlCommand(sql, conn);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@id_estudiante",  pIdEstudiante);
                cmd2.Parameters.AddWithValue("@valor", valor);
                cmd2.Parameters.AddWithValue("@is_fast", 1);


                if (pUserLog.Id > 0)
                    cmd2.Parameters.AddWithValue("@id_usuario", pUserLog.Id);
                else
                    cmd2.Parameters.AddWithValue("@id_usuario",  DBNull.Value);

                cmd2.ExecuteScalar();

                //string sql3 = @"UPDATE admon.tablas_id
                //                   SET id_siguiente = :id
                //                WHERE nombre_tabla = 'matricula';";

                //PgSqlCommand cmd3 = new PgSqlCommand(sql3, psConnection);
                //cmd3.Parameters.Add("id", PgSqlType.Int).Value = vid_matricula + 1;
                //cmd3.ExecuteScalar();
                //tran1.Commit();
                //CajaDialogo.Information("Guardado con exito!");
                a = true;
            }
            catch (Exception ec)
            {
                //tran1.Rollback();
                a = false;
                throw new Exception("No se pudo guardar el Estudiante!", ec);
            }
            return a;
        }
    }
}