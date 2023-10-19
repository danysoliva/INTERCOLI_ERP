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

namespace ERP_INTECOLI.Usuarios
{
    public partial class frmUser : DevExpress.XtraEditors.XtraForm
    {
        public enum TipoEdicion
        {
            Nuevo = 1,
            Editar = 2
        }

        private bool ValidoContrasenia;
        private TipoEdicion vTipoEdition;
        private UserLogin UserParametro;
        public frmUser(TipoEdicion pTipo, UserLogin pUser, string palias)
        {
            InitializeComponent();
            vTipoEdition = pTipo;
            UserParametro = pUser;
            switch (vTipoEdition)
            {
                case TipoEdicion.Nuevo:
                    txtAlias.Text = "";
                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    cbxNivel.Text = "Basic";
                    chkUtilizaBloqueo.Checked = true;
                    Nminutes.Value = 10;
                    chkUsuarioHabilitado.Checked = true;
                    chkSuperUsuario.Checked = false;
                    ValidoContrasenia = false;
                    txtPass.Text = "";
                    txtConfirmar.Text = "";
                    break;
                case TipoEdicion.Editar:

                    UserParametro.RecuperarRegistroUsuario(palias);

                    txtAlias.Text = UserParametro.ADuser;
                    txtNombre.Text = UserParametro.Nombre;
                    txtApellido.Text = UserParametro.Apellido;
                    cbxNivel.Text = UserParametro.UserDb;
                    chkUtilizaBloqueo.Checked = UserParametro.Utiliza_bloqueo;
                    Nminutes.Value = UserParametro.Tiempo_inactividad.Minutes;
                    chkUsuarioHabilitado.Checked = UserParametro.Habilitado;
                    chkSuperUsuario.Checked = UserParametro.Super_user;
                    txtPass.Text = UserParametro.DecryptPassword(UserParametro.Password);
                    txtConfirmar.Text = UserParametro.DecryptPassword(UserParametro.Password);
                    ValidoContrasenia = true;
                    break;
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}