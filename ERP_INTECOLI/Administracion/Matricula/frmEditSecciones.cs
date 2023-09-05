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

namespace ERP_INTECOLI.Administracion.Matricula
{
    public partial class frmEditSecciones : DevExpress.XtraEditors.XtraForm
    {
        dsNuevoCursoMatricula.seccionesDataTable TablaSecciones;
        DataOperations dp = new DataOperations();

        public frmEditSecciones(dsNuevoCursoMatricula.seccionesDataTable tabla)
        {
            InitializeComponent();
            TablaSecciones = tabla;
            gridControl1.DataSource = TablaSecciones;
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @"sp_matricula_update_seccion";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                foreach (dsNuevoCursoMatricula.seccionesRow row in TablaSecciones.Rows)
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@descripcion", row.secciones);
                    cmd.Parameters.AddWithValue("@id", row.id_seccion);
                    cmd.ExecuteNonQuery();
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}