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
        public int IdUsuario;
        public enum TipoEdicion
        {
            Nuevo = 1,
            Editar = 2
        }
        DataOperations dp = new DataOperations();
        private bool ValidoContrasenia;
        private TipoEdicion vTipoEdition;
        private UserLogin UserParametro;
        public frmUser(TipoEdicion pTipo, UserLogin pUser, string palias)
        {
            InitializeComponent();
            vTipoEdition = pTipo;
            UserParametro = pUser;
            cargar_grupos();
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
                    chkUsuarioOculto.Checked = false;
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
                    IdUsuario = UserParametro.Id;
                    if (UserParametro.IdGrupo == 0)
                        grdGrupo.EditValue = null;
                    else
                        grdGrupo.EditValue = UserParametro.IdGrupo;
                    ValidoContrasenia = true;

                    chkUsuarioOculto.Checked = UserParametro.UsuarioOculto;
                    break;
            }
        }

        private void cargar_grupos()
        {
            try
            {
                string query = @"SELECT [id]
                                  ,[grupo]
                              FROM [dbo].[conf_grupos]
                              where enable = 1";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                dsUsuarios1.grupos.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsUsuarios1.grupos);
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAlias.Text) || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Los campos: Alias, Nombre y Apellidos no pueden quedar en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(grdGrupo.Text))
            {
                CajaDialogo.Error("Debe agregar el usuario a un Grupo!");
                return;
            }

            if (txtConfirmar.Text != txtPass.Text)
            {
                ValidoContrasenia = false;
            }
            else
            {
                ValidoContrasenia = true;
            }

            if (ValidoContrasenia)
            {
                switch (vTipoEdition)
                {
                    case TipoEdicion.Nuevo:
                        //UserParametro = new Users(psConnection);
                        UserParametro.ADuser = txtAlias.Text.Trim();
                        UserParametro.Nombre = txtNombre.Text.Trim();
                        UserParametro.Apellido = txtApellido.Text.Trim();
                        UserParametro.UserDb = cbxNivel.Text.Trim().ToLower();
                        UserParametro.Utiliza_bloqueo = chkUtilizaBloqueo.Checked;
                        TimeSpan tm = new TimeSpan(0, Convert.ToInt32(Nminutes.Value), 0);
                        UserParametro.Tiempo_inactividad = tm;
                        UserParametro.Habilitado = chkUsuarioHabilitado.Checked;
                        UserParametro.Super_user = chkSuperUsuario.Checked;
                        UserParametro.Password = txtPass.Text;
                        UserParametro.UsuarioOculto = chkUsuarioOculto.Checked;

                        string sql1 = @"[sp_insert_nuevo_usuario_v2]";
                        try
                        {
                            SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                            conn.Open();
                            SqlCommand cmd = new SqlCommand(sql1, conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@alias", txtAlias.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", EncryptPassword(txtPass.Text));
                            cmd.Parameters.AddWithValue("@habilitado", chkUsuarioHabilitado.Checked);
                            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim());
                            cmd.Parameters.AddWithValue("@apellidos", txtApellido.Text.Trim());
                            cmd.Parameters.AddWithValue("@super_user", chkSuperUsuario.Checked);
                            cmd.Parameters.AddWithValue("@tiempo_inactividad", Nminutes.Value);
                            cmd.Parameters.AddWithValue("@utiliza_bloqueo", chkUtilizaBloqueo.Checked);
                            cmd.Parameters.AddWithValue("@user_db", cbxNivel.Text.Trim().ToLower());
                            cmd.Parameters.AddWithValue("@id_grupo", grdGrupo.EditValue);
                            cmd.Parameters.AddWithValue("@usuario_oculto", chkUsuarioOculto.Checked);
                            
                            cmd.ExecuteNonQuery();

                            CajaDialogo.Information("Guardado con Exito!");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        catch (Exception ec)
                        {
                            CajaDialogo.Error("¡No se pudo guardar el usuario!\n" + ec.Message);
                        }


                        break;
                    case TipoEdicion.Editar:
                        try
                        {
                            string sql = @"[sp_update_usuario_v2]";
                            SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                            conn.Open();
                            SqlCommand cmd = new SqlCommand(sql, conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@alias", txtAlias.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", EncryptPassword(this.txtPass.Text.Trim()));
                            string a = EncryptPassword(this.txtPass.Text.Trim());
                            cmd.Parameters.AddWithValue("@habilitado", chkUsuarioHabilitado.Checked);
                            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim());
                            cmd.Parameters.AddWithValue("@apellidos", txtApellido.Text.Trim());
                            cmd.Parameters.AddWithValue("@super_user", chkSuperUsuario.Checked);
                            cmd.Parameters.AddWithValue("@tiempo_inactividad", Nminutes.Value);
                            cmd.Parameters.AddWithValue("@utiliza_bloqueo", chkUtilizaBloqueo.Checked);
                            cmd.Parameters.AddWithValue("@user_db", cbxNivel.Text.Trim());
                            cmd.Parameters.AddWithValue("@user_id", IdUsuario);
                            cmd.Parameters.AddWithValue("@id_grupo", grdGrupo.EditValue);
                            cmd.Parameters.AddWithValue("@usuario_oculto", chkUsuarioOculto.Checked);
                            cmd.ExecuteNonQuery();

                            CajaDialogo.Information("Guardado con Exito!");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        catch (Exception ec)
                        {
                            CajaDialogo.Error(ec.Message);
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string EncryptPassword(string pass)
        {
            try
            {
                byte[] enbyte = GetBytes(pass);
                string cadena_base64 = Convert.ToBase64String(enbyte);
                return cadena_base64;
            }
            catch
            {
                return " ";
            }
        }

        private static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        private string EncryptPassword(object password)
        {
            throw new NotImplementedException();
        }
    }
}