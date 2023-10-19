using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERP_INTECOLI.Clases;

namespace ERP_INTECOLI.Consultas.ConsultaMiembros
{
    public partial class frmNuevosIngresos : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public frmNuevosIngresos()
        {
            InitializeComponent();
        }

        private void cmbCargarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "sp_get_nuevos_ingresos";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtFechaDesde.Value);
                cmd.Parameters.AddWithValue("@hasta", dtFechaHasta.Value);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsMiembrosClase1.nuevos_ingresos.Clear();
                adat.Fill(dsMiembrosClase1.nuevos_ingresos);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}