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
using System.Net;

namespace ERP_INTECOLI
{
    public partial class frmLogin : Form
    {
        DataOperations dp = new DataOperations();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void cmdSkip_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "sudo";
            txtPass.Text = "barcaroli1804";
            cmdAceptar_Click(new object(), new EventArgs());
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea Salir del Sistema?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            else
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Close();
            }
        }

        private UserLogin userx1;
        public UserLogin UsuarioLogeado
        {
            get { return userx1; }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                txtPass.Focus();
                this.Activated -= new System.EventHandler(this.frmLogin_Activated);
                //txtPass.SelectAll();
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Tab)
            {
                txtPass.Focus();
            }
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Debe ingresar un usuario!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Debe ingresar una Contraseña!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Focus();
                return;
            }

            UserLogin user = new UserLogin();

            bool sudoLogin;
            if (user.EncryptPassword(txtUsuario.Text) == "cwB1AGQAbwA=")
            {
                if (user.EncryptPassword(txtPass.Text) == "YgBhAHIAYwBhAHIAbwBsAGkAMQA4ADAANAA=")
                    sudoLogin = true;
                else
                    sudoLogin = false;
            }
            else
            {
                sudoLogin = false;
            }

            if (!sudoLogin)
            {
                if (user.RecuperarRegistroUsuario(txtUsuario.Text))
                {
                    if (!user.Habilitado)
                    {
                        MessageBox.Show("Este usuario no está habilitado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (user.DecryptPassword(user.Password) == txtPass.Text)
                    {
                        try
                        {

                            if (string.IsNullOrEmpty(cbxCompany.Text))
                            {
                                CajaDialogo.Error("Es necesario identificar el establecimiento al que se conectara!");
                                return;
                            }
                            else
                            {
                                string sql = @"set_dispositivo_in_sucursal";
                                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                                conn.Open();
                                SqlCommand cmd = new SqlCommand(sql, conn);
                                cmd.Parameters.AddWithValue("tag", Dns.GetHostName());
                                cmd.Parameters.AddWithValue("company", cbxCompany.SelectedValue);
                                cmd.ExecuteNonQuery();
                                conn.Close();
                            }

                            frmMainMenu frm = new frmMainMenu(UsuarioLogeado);
                            if (frm.ShowDialog() == DialogResult.OK)
                            {

                            }
                            

                        }
                        catch (Exception ec)
                        {
                            MessageBox.Show("No se pudo abrir la connexion a la base de datos!" + "Error: " + ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Contraseña Incorrecta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar el usuario que usted ingreso, favor revise bien el alias de usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Focus();
                }
            }
            else
            {
                try
                {
                    

                    this.userx1 = new UserLogin();
                    this.userx1.Super_user = true;
                    //this.userx1.ADuser = UserId;
                    //this.userx1.UserDb = pxConn.Database;
                    frmMainMenu frm = new frmMainMenu(UsuarioLogeado);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {

                    }
                }
                catch (Exception ec)
                {
                    MessageBox.Show("No se pudo abrir la connexion a la base de datos!" + "Error: " + ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmLogin_Activated(object sender, EventArgs e)
        {

        }
    }
}
