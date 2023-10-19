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

namespace ERP_INTECOLI.Administracion.Estudiantes
{
    public partial class frmRecuentoGeneros : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogueado;
        DataOperations dp = new DataOperations();

        public frmRecuentoGeneros(UserLogin pUserLog)
        {
            InitializeComponent();
            UsuarioLogueado = pUserLog;
        }

        private void CargarDatos()
        {
            try
            {
                string SQL = @"select coalesce( count(es.sexo) , 0)
                                from estudiante es
                                where es.habilitado = 1 and
                                      es.sexo = 'F'";

                string sql1 = @"select coalesce( count(es.sexo) , 0)
                                from estudiante es
                                where es.habilitado = 1 and
                                      es.sexo = 'M'";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(SQL, conn);                
                //PgSqlDataAdapter da = new PgSqlDataAdapter(cmd);
                //dsEstudiantes1.RecuentoGenero.Clear();
                //da.Fill(dsEstudiantes1.RecuentoGenero);
                lblMujeres.Text = cmd.ExecuteScalar().ToString();

                SqlCommand cmdHombres = new SqlCommand(sql1, conn);
                lblHombres.Text = cmdHombres.ExecuteScalar().ToString();

                lblTotal.Text = (Convert.ToInt32(lblMujeres.Text) + Convert.ToInt32(lblHombres.Text)).ToString();

            }
            catch (Exception error)
            {
                CajaDialogo.Error(error.Message);
            }

        }

        private void frmRecuentoGeneros_Load(object sender, EventArgs e)
        {
            int ContHombres = 0;
            int ContMujeres = 0;
            CargarDatos();

            //verifica si cantidad de hombres es numero
            bool result1 = int.TryParse(lblHombres.Text, out ContHombres);

            //verifica si cantidad de mujeres es numero
            bool result2 = int.TryParse(lblMujeres.Text, out ContMujeres);

            lblTotal.Text = "TOTAL: " + (ContHombres + ContMujeres).ToString();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}