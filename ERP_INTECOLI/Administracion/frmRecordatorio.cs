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


namespace ERP_INTECOLI.Administracion
{
    public partial class frmRecordatorio : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin usuariologueado;
        public frmRecordatorio(UserLogin pUserLog)
        {
            InitializeComponent();
            usuariologueado = pUserLog;
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Desea postear este recordatorio?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r != System.Windows.Forms.DialogResult.Yes)
                return;

          
            try
            {
                string sql = @"sp_insert_recordatorio";//"select * from admon.ft_insert_recordatorio (:p_fecha_hora_recordar, :p_mensaje, :p_id_usuario);";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                DateTime date1 = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day,
                                              dateTimePicker2.Value.Hour, dateTimePicker2.Value.Minute, dateTimePicker2.Value.Second);
                cmd.Parameters.AddWithValue("@fecha_hora_recordar", date1);
                cmd.Parameters.AddWithValue("@mensaje", textBox1.Text);
                cmd.Parameters.AddWithValue("@id_usuario", this.usuariologueado.Id);
                cmd.ExecuteNonQuery();
                CajaDialogo.Information("Recordatorio Exitoso!");
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error("¡No se pudo postear el recordatorio! ", ec);
            }
        }
    }
}