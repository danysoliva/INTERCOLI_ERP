using DevExpress.XtraEditors;
using ERP_INTECOLI.Clases;
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


namespace ERP_INTECOLI.Usuarios
{
    public partial class frmManVentanasOP : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public frmManVentanasOP(int pidVentana)
        {
            InitializeComponent();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                CajaDialogo.Error("No puede dejar vacio este campo!");
                txtDescripcion.Focus();
                return;
            }

            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_usuarios_insert_ventana", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text.Trim());
                //cmd.Parameters.AddWithValue("@codigo", txtDescripcion.Text.Trim());
                //cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text.Trim());

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception EX)
            {
                CajaDialogo.Error(EX.Message);
            }

            CajaDialogo.Information("Permiso Creado con Exito");
            this.DialogResult = DialogResult.OK;
            this.Close();


        }
    }
}