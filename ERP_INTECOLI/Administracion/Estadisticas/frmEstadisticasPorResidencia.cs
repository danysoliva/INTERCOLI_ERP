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

namespace ERP_INTECOLI.Administracion.Estadisticas
{
    public partial class frmEstadisticasPorResidencia : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();

        public frmEstadisticasPorResidencia()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                string sql = @"select zz.descripcion as zona,
                                       (SELECT count(*)
		                                FROM estudiante
		                                where id_zona = zz.id) as cantidad
                                from zonas zz 
                                where zz.nulo = 0";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                DataTable tablita = new DataTable();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(tablita);
                this.gridControl1.DataSource = tablita;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}