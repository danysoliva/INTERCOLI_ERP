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
    public partial class frmConsultarMatriculados : DevExpress.XtraEditors.XtraForm
    {
        private UserLogin UsuarioLogueado;
        DataOperations dp = new DataOperations();

        public frmConsultarMatriculados(UserLogin pUserLog)
        {
            InitializeComponent();
            UsuarioLogueado = pUserLog;
            dtDesde.Value = dtDesde.Value.AddDays(-30);
            CargarMatriculados();

        }

        private void CargarMatriculados()
        {
            try
            {
                string query = @"[sp_matricula_get_lista_matriculados]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dtdesde",dtDesde.Value);
                cmd.Parameters.AddWithValue("@dthasta",dtHasta.Value);
                if (tsSoloHabilitadas.IsOn)
                    cmd.Parameters.AddWithValue("@habilitados", 1);
                else
                    cmd.Parameters.AddWithValue("@habilitados", 0);
                if (chOcultarNulas.Checked)
                    cmd.Parameters.AddWithValue("@VerNulas", 1);
                else
                    cmd.Parameters.AddWithValue("VerNulas",0);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsMatriculado1.ListaMatriculados.Clear();
                adat.Fill(dsMatriculado1.ListaMatriculados);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarMatriculados();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}