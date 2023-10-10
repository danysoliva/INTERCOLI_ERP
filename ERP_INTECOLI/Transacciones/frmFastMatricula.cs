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

namespace ERP_INTECOLI.Transacciones
{
    public partial class frmFastMatricula : DevExpress.XtraEditors.XtraForm
    {
        private int IdEstudiante;
        Estudiante vEstudiante;
        private UserLogin UsuarioLogueado;
        DataOperations dp = new DataOperations();

        public frmFastMatricula(UserLogin pUser)
        {
            InitializeComponent();
            UsuarioLogueado = pUser;
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtApellido.Focus();
        }

        private void txtApellido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtValor.Focus();
        }

        private void txtValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cmdGuardar.Focus();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                CajaDialogo.Error("No puede dejar el nombre en blanco!");
                txtNombre.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtIdentidad.Text))
            {
                CajaDialogo.Error("No puede dejar el numero de identidad en blanco!");
                txtIdentidad.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                CajaDialogo.Error("No puede dejar el Apellido en blanco!");
                txtApellido.Focus();
                return;
            }

            decimal valor = 0;
            try
            {
                valor = Convert.ToDecimal(txtValor.Text);
            }
            catch
            {

            }

            bool Continue = true;
            if (valor == 0)
            {
                DialogResult r = CajaDialogo.Pregunta("Realmente desea guardar la matricula en Valor Cero (0)");
                if (r != System.Windows.Forms.DialogResult.Yes)
                    Continue = false;
            }

            //if (Continue)
            //{
            //    vEstudiante = new Estudiante();
            //    if (!vEstudiante.ValidarIdDisponible(txtIdentidad.Text))
            //    {
            //        CajaDialogo.Error("Este Numero de Identidad ya Existe!");
            //        return;
            //    }

            //    //ConfiguracionSuccess conf = new ConfiguracionSuccess(psConnection);
            //    vEstudiante.Nombres = txtNombre.Text;
            //    vEstudiante.Apellidos = txtApellido.Text;
            //    vEstudiante.FechaIngreso = dp.Now();
            //    vEstudiante.IdEstudiante = vEstudiante.InsertEstudiante(this.UsuarioLogueado);

            //    if (InsertMatricula(this.UsuarioLogueado, vEstudiante.IdEstudiante, Convert.ToDecimal(txtValor.Text)))
            //    {
            //        //CajaDialogo.Information("Guardada con exito!");
            //        this.DialogResult = System.Windows.Forms.DialogResult.OK;
            //        this.Close();
            //    }

            //}
        }
    }
}