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

namespace ERP_INTECOLI.Consultas.ConsultaMiembros
{
    public partial class frmConsultarMiembroCurso : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UserLogueado;
        DateTime FechaActual;
        DataOperations dp = new DataOperations();

        public frmConsultarMiembroCurso(UserLogin userLogin)
        {
            InitializeComponent();
            UserLogueado = userLogin;
            FechaActual = dp.Now();
            switch (FechaActual.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    cbxDia.Text = "Lunes";
                    break;
                case DayOfWeek.Tuesday:
                    cbxDia.Text = "Martes";
                    break;
                case DayOfWeek.Wednesday:
                    cbxDia.Text = "Miercoles";
                    break;
                case DayOfWeek.Thursday:
                    cbxDia.Text = "Jueves";
                    break;
                case DayOfWeek.Friday:
                    cbxDia.Text = "Viernes";
                    break;
                case DayOfWeek.Saturday:
                    cbxDia.Text = "Sabado";
                    break;
                case DayOfWeek.Sunday:
                    cbxDia.Text = "Domingo";
                    break;
            }
            cargarCursos();
        }

        private void cargarCursos()
        {
            try
            {
                //string sql = "select * from admon.ft_cargar_cursos (:p_dia, :p_hora);";
                string sql = @"sp_cargar_cursos_for_dia";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                int dia = 0;
                switch (cbxDia.Text)
                {
                    case "Lunes":
                        dia = 1;
                        break;
                    case "Martes":
                        dia = 2;
                        break;
                    case "Miercoles":
                        dia = 3;
                        break;
                    case "Jueves":
                        dia = 4;
                        break;
                    case "Viernes":
                        dia = 5;
                        break;
                    case "Sabado":
                        dia = 6;
                        break;
                    case "Domingo":
                        dia = 7;
                        break;
                }
                cmd.Parameters.AddWithValue("@dia", dia);
                cmd.Parameters.AddWithValue("@hora", numericUpDown1.Value);
                dsMiembrosClase1.cursos.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMiembrosClase1.cursos);
                if (dsMiembrosClase1.cursos.Rows.Count == 0)
                    cbxCurso.EditValue = DBNull.Value;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            cargarCursos();
        }

        private void cbxCurso_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cbxDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cargarCursos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxDia.Text))
            {
                CajaDialogo.Error("¡Debe seleccionar el dia!");
                cbxDia.Focus();
            }
            try
            {
                //string sql = @"select * from admon.v7_ft_asistencia (
                //                                              :pdia,
                //                                              :phora,
                //                                              :pcurso
                //                 )";
                string sql = @"v7_ft_asistencia"; //falta el query
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                int dia = 0;
                switch (cbxDia.Text)
                {
                    case "Lunes":
                        dia = 1;
                        break;
                    case "Martes":
                        dia = 2;
                        break;
                    case "Miercoles":
                        dia = 3;
                        break;
                    case "Jueves":
                        dia = 4;
                        break;
                    case "Viernes":
                        dia = 5;
                        break;
                    case "Sabado":
                        dia = 6;
                        break;
                    case "Domingo":
                        dia = 7;
                        break;
                }
                cmd.Parameters.AddWithValue("@dia", dia);
                cmd.Parameters.AddWithValue("@hora", numericUpDown1.Value);
                cmd.Parameters.AddWithValue("@curso", cbxCurso.EditValue);

                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsMiembrosClase1.miembros.Clear();
                adat.Fill(dsMiembrosClase1.miembros);
                decimal total_c = 0;
                decimal total_S = 0;

                //foreach (UltraGridRow row in ultraGrid1.Rows)
                //{
                //    total_c += Convert.ToDecimal(row.Cells["valor_curso"].Value);
                //    total_S += Convert.ToDecimal(row.Cells["saldo"].Value);
                //}
                //lblTotalCurso.Text = string.Format("{0:#,##0.00}", total_c);
                //lblTotalSaldo.Text = string.Format("{0:#,##0.00}", total_S);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error("No se pudo cargar la información!", ec);
            }
        }

        private void numericUpDown1_EditValueChanged(object sender, EventArgs e)
        {
            cargarCursos();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}