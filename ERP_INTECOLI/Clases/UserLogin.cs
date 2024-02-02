using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using JAGUAR_APP;
using static DevExpress.XtraEditors.Mask.MaskSettings;
using System.Windows.Forms;

namespace ERP_INTECOLI.Clases
{
    public class UserLogin
    {
        public GrupoUser GrupoUsuario;
        public SqlConnection conn;

        DataOperations dp = new DataOperations();

        private bool habilitado;
        private TimeSpan tiempo_inactividad;
        private int id;
        private int idnivel;
        private string tipo;
        private bool super_user;
        private string password;
        private string nombre;
        private string userdb;
        private string passdb;
        private int _id_grupo;
        private bool _recuperado;
        private string apellido;
        private string primer_nombre;

        public int Idnivel { get => idnivel; set => idnivel = value; }
        public string Tipo { get => tipo; set => tipo = value; }


        public string Password { get => password; set => password = value; }
        public bool Super_user { get => super_user; set => super_user = value; }
        public TimeSpan Tiempo_inactividad { get => tiempo_inactividad; set => tiempo_inactividad = value; }

        private bool utiliza_bloqueo;

        public int Id { get => id; set => id = value; }
        public string ADuser { get => aduser; set => aduser = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public bool Utiliza_bloqueo { get => utiliza_bloqueo; set => utiliza_bloqueo = value; }
        public string UserDb { get => userdb; set => userdb = value; }
        public string PassDb { get => passdb; set => passdb = value; }
        public bool Habilitado { get => habilitado; set => habilitado = value; }
        public bool Recuperado { get => _recuperado; set => _recuperado = value; }
        public int IdGrupo { get => _id_grupo; set => _id_grupo = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Primer_nombre { get => primer_nombre; set => primer_nombre = value; }
        public bool UsuarioOculto { get; set; }

        private string aduser;

        public UserLogin()
        {
            GrupoUsuario = new GrupoUser();
        }

        public string EncrypPassword(string pass)
        {
            try
            {
                byte[] enbyte = GetBytes(pass);
                string cadena_base64 = Convert.ToBase64String(enbyte);
                return cadena_base64;
            }
            catch (Exception)
            {
                return " ";
            }
        }

        public bool RecuperarRegistroUsuario(string pAlias)
        {
            bool x = false;
            try
            {
                string query  = "[dbo].[sp_get_users_admin_class]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@alias", pAlias);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    ADuser = dr.GetString(1);
                    Password = dr.GetString(2);
                    Habilitado = dr.GetBoolean(3);
                    Nombre = dr.GetString(4);
                    Super_user = dr.GetBoolean(5);
                    TimeSpan tm = new TimeSpan(0, dr.GetInt32(6),0);
                    Tiempo_inactividad = tm;
                    //DateTime myDateTime = DateTime.Now;
                    //string sqlFormattedDate = myDateTime.dr.GetInt32(6);
                    Utiliza_bloqueo = dr.GetBoolean(7);
                    UserDb = dr.GetString(8);
                    PassDb = dr.GetString(9);
                    Primer_nombre = dr.GetString(10);
                    Apellido = dr.GetString(11);
                    IdGrupo = dr.GetInt32(12);
                    UsuarioOculto = dr.GetBoolean(13);
                    x = true;
                }
                dr.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error("No se pudo recuperar el objeto de usuario\nError: " + ec.Message);
            }
            return x;
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

        internal bool ValidarNivelPermisos(int pIdVentana)
        {
            bool r = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection Conn = new SqlConnection(dp.ConnectionStringERP);
                Conn.Open();
                string sql = @"SELECT count(*)
                                FROM conf_usuario_ventanas vv 
                                where vv.id_ventana = "
                + pIdVentana.ToString() +
                                      "and vv.id_usuario = " + Id.ToString();
                SqlCommand cmd = new SqlCommand(sql, Conn);
                int v = Convert.ToInt32(cmd.ExecuteScalar());
                if (v > 0)
                    r = true;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return r;
        }

        public int idNivelAcceso(int Iduser, int idSistema)
        {
            int id = 0;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();
                string sql = "[sp_get_nivel_acceso_for_user]";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_sistema", idSistema);
                cmd.Parameters.AddWithValue("@id_user", Iduser);
                id = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
            }
            catch (Exception ec)
            {
                //recuperado = false;
                CajaDialogo.Error(ec.Message);
            }
            return id;
        }

        public string DecryptPassword(string pass)
        {
            try
            {
                byte[] b = Convert.FromBase64String(pass);
                string cadena = GetString(b);
                return cadena;
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

        private static string GetString(byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }
        public bool RecuperarRegistro(int pId)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();
                string sql = @"dbo.sp_get_usuario_by_id_from_validate_login";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pId);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    Nombre = dr.GetString(1);
                    if (!dr.IsDBNull(dr.GetOrdinal("id_grupo")))
                        IdGrupo = dr.GetInt32(2);
                    Super_user = dr.GetBoolean(3);
                    _recuperado = true;
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ec)
            {
                _recuperado = false;
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;
        }

        public bool IsSudo(int userId)
        {
            bool x = false;
            try
            {
                string sql = "sp_user_is_sudo";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@user_id", userId);
                x = Convert.ToBoolean(cmd.ExecuteScalar());
            }
            catch (Exception ec)
            {
                x = false;
                CajaDialogo.Error("¡No se pudo consultar si el nivel del usuario es Sudo!");
            }
            return x;
        }

    }
}