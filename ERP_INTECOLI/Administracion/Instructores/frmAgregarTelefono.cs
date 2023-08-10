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
using ERP_INTECOLI.Administracion.Estudiantes;
using System.Data.SqlClient;

namespace ERP_INTECOLI.Administracion.Instructores
{
    public partial class frmAgregarTelefono : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public int id_tipo_telefono;
        public string num_telefono, tipo_Telefono;
        public int id_detalle_telefono = 0;

        private TipoEdicion TipoEdit;

        public enum TipoEdicion
        {
            Nuevo = 1,
            Editar = 2
        }

        public frmAgregarTelefono(TipoEdicion pTipoEdicion, int pid_instructor, int pid_detalle, string ptelefono, int ptipo_telefono)
        {
            InitializeComponent();
            TipoEdit = pTipoEdicion;
            cargar_tipo_telefono();
            switch (TipoEdit)
            {
                case TipoEdicion.Nuevo:


                    break;
                case TipoEdicion.Editar:
                    txtTelefono.Text = ptelefono.ToString();
                    cbxTipo.Value = ptipo_telefono;
                    id_detalle_telefono = pid_detalle;

                    break;
                default:
                    break;
            }
        }

        private void cargar_tipo_telefono()
        {
            try
            {
                string sql = "sp_estudiantes_tipo_telefono";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsEstudiantes1.tipo_telefono.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsEstudiantes1.tipo_telefono);
                conn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                CajaDialogo.Error("No puede dejar Vacio el Campo de Telefono");
                return;
            }

            if (txtTelefono.Text.Length < 7)
            {
                CajaDialogo.Error("Agrege un numero de Telefono Valido");
                return;
            }

            if (string.IsNullOrEmpty(cbxTipo.Text))
            {
                CajaDialogo.Error("Seleccione el Tipo de Telefono!");
                return;
            }

            num_telefono = txtTelefono.Text.Trim();
            id_tipo_telefono = Convert.ToInt32(cbxTipo.Value);
            tipo_Telefono = cbxTipo.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();


        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}