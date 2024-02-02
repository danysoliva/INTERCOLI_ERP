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
using ERP_INTECOLI.Consultas.ConsultaMiembros;
using System.Data.SqlClient;

namespace ERP_INTECOLI.Consultas
{
    public partial class frmConsultaCumpleanieros : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogueado;
        DataOperations dp = new DataOperations();

        public frmConsultaCumpleanieros(UserLogin pUserLogin)
        {
            InitializeComponent();
            UsuarioLogueado = pUserLogin;
        }

        private void cmdExportarExcel_Click(object sender, EventArgs e)
        {

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gridMain.ExportToXlsx(dialog.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtDesde.Value == dtHasta.Value)
                {
                    dtHasta.Value = dtHasta.Value.AddDays(1);
                }
                /*string sql = @"select (es.nombres ||' '||es.apellidos) as nombre,
                                        es.fecha_nacimiento as fecha,
                                        null as dia
                                from admon.estudiante es
                                where EXTRACT(MONTH FROM es.fecha_nacimiento) >=  EXTRACT(MONTH FROM timestamp '" + dtDesde.Value.ToShortDateString() + "'::timestamp) and " +
                                      "EXTRACT(MONTH FROM es.fecha_nacimiento) <= EXTRACT(MONTH FROM timestamp '" + dtHasta.Value.ToShortDateString() + "'::timestamp) and " +
                                      "EXTRACT(DAY FROM es.fecha_nacimiento) BETWEEN EXTRACT(DAY FROM timestamp '" + dtDesde.Value.ToShortDateString() + "'::timestamp) AND " +
                                      "EXTRACT(DAY FROM timestamp '" + dtHasta.Value.ToShortDateString() + "'::timestamp);";*/
                //string sql = "select * from admon.ft_carga_cumpleaneros (:p_desde, :p_hasta);";
                string sql = "sp_get_cumpleanieros_for_fecha";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@desde", dtDesde.Value);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.Value);
                dsMiembrosClase1.personas.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMiembrosClase1.personas);


                foreach (dsMiembrosClase.personasRow row in dsMiembrosClase1.personas)
                {
                    DateTime Fechax = Convert.ToDateTime(row.fecha);
                    Fechax = new DateTime(dtDesde.Value.Year, Fechax.Month, Fechax.Day);
                    if (dtDesde.Value > Fechax)
                        Fechax = new DateTime(dtHasta.Value.Year, Fechax.Month, Fechax.Day);

                    row.fecha = Fechax;
                    row.dia = Fechax.DayOfWeek.ToString();
                }
            }
            catch (Exception ec)
            {
                CajaDialogo.Error("No se pudo cargar la lista de cumpleañeros!", ec);
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;    
            this.Close();
        }
    }
}