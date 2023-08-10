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
    public partial class frmConsultaMatricula : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogueado;
        public frmConsultaMatricula(UserLogin pUserLog)
        {
            InitializeComponent();
            UsuarioLogueado = pUserLog;
            dtDesde.Value = dtDesde.Value.AddDays(-30);
            tsHabilitados.IsOn = true;
            chkNulas.Checked = true;
            CargarMatriculados();
        }

        private void CargarMatriculados()
        {
            try
            {
                string query = @"sp_matricula_get_lista_matriculados";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dtdesde",dtDesde.Value);
                cmd.Parameters.AddWithValue("@dthasta",dtHasta.Value);
                if (tsHabilitados.IsOn)
                    cmd.Parameters.AddWithValue("@habilitados", 1);
                else
                    cmd.Parameters.AddWithValue("@habilitados", 0);
                if (chkNulas.Checked == true)
                    cmd.Parameters.AddWithValue("@VerNulas", 0);
                else
                    cmd.Parameters.AddWithValue("@VerNulas",1);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsMatricula1.ListaMatriculados.Clear();
                adat.Fill(dsMatricula1.ListaMatriculados);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            CargarMatriculados();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}