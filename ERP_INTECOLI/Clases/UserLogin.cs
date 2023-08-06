using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ERP_INTECOLI.Clases
{
    public class UserLogin
    {
        //public GrupoUser GrupoUsuario;
        private bool recuperado;
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

        private string aduser;

        public UserLogin()
        {
            //GrupoUsuario = new GrupoUser();
        }

        public bool RecuperarRegistroUsuario(string pAlias)
        {
            bool x = false;
            try
            {
                string query  = "[sp_get_users_admin_class]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
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
                    Tiempo_inactividad = dr.GetTimeSpan(6);
                    Utiliza_bloqueo = dr.GetBoolean(7);
                    UserDb = dr.GetString(8);
                    PassDb = dr.GetString(9);
                    x = true;
                }
            }
            catch (Exception ec)
            {
                CajaDialogo.Error("No se pudo recuperar el objeto de usuario" + ec.Message);
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

       

        //internal bool ValidarNivelPermisos(int pIdVentana)
        //{
        //    bool r = false;
        //    try
        //    {
        //        DataOperations dp = new DataOperations();
        //        SqlConnection Conn = new SqlConnection(dp.ConnectionStringERP);
        //        Conn.Open();
        //        //string sql = @"SELECT count(*)
        //        //                FROM [dbo].conf_usuario_ventanas vv 
        //        //                where vv.id_ventana = " + pIdVentana.ToString() +
        //        //                      "and vv.id_usuario = " + UserId.ToString();
        //        SqlCommand cmd = new SqlCommand("", Conn);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@id_ventana", pIdVentana.ToString());
        //        cmd.Parameters.AddWithValue("@id_usuario",UserId.ToString());
        //        int v = Convert.ToInt32(cmd.ExecuteScalar());
        //        if (v > 0)
        //            r = true;
        //    }
        //    catch (Exception ec)
        //    {
        //        CajaDialogo.Error(ec.Message);
        //    }
        //    return r;
        //}

    }
}