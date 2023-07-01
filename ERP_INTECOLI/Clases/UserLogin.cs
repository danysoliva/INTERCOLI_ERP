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
        public GrupoUser GrupoUsuario;
        private bool recuperado;
        private int id;
        private int idGrupo;
        private string nombreUser;
        private string ADuser;
        private string pass;
        private int idnivel;
        private string tipo;

        public bool Recuperado { get => recuperado; set => recuperado = value; }
        public int Id { get => id; set => id = value; }
        public int IdGrupo { get => idGrupo; set => idGrupo = value; }
        public string NombreUser { get => nombreUser; set => nombreUser = value; }
        public string ADuser1 { get => ADuser; set => ADuser = value; }
        public string Pass { get => pass; set => pass = value; }
        public int Idnivel { get => idnivel; set => idnivel = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        #region Members
        int vUserid;
        string vNombre;
        string vAlias;
        bool vRecuperado;
        DataOperations dp;
        bool vSuperUser;
        string vPassword;
        #endregion

        #region Properties
        //public bool Recuperado
        //{
        //    get { return vRecuperado; }
        //    set { vRecuperado = value; }
        //}
        public int UserId
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return vNombre; }
            set { vNombre = value; }
        }
        public string AD_User
        {
            get { return vAlias; }
            set { vAlias = value; }
        }
        /// <summary>
        /// Set or Get bool if the user login is Super User
        /// </summary>
        public bool IsSuperUser
        {
            get { return vSuperUser; }
            set { vSuperUser = value; }
        }

        public string Password { get => vPassword; set => vPassword = value; }
        #endregion

        public UserLogin()
        {
            //GrupoUsuario = new GrupoUser();
        }

        public bool RecuperarRegistrosFromUser(string pUser)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection connection = new SqlConnection(dp.ConnectionStringERP);
                connection.Close();
                SqlCommand cmd = new SqlCommand("", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    NombreUser = dr.GetString(1);
                    IdGrupo = dr.GetInt32(2);
                    ADuser = dr.GetString(3);
                    recuperado = true;
                }
                dr.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                recuperado = false;
                CajaDialogo.Error(ex.Message);
            }
            return Recuperado;

        }

        public bool RecuperarRegistro(int pId)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();
                SqlCommand cmd = new SqlCommand("", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    nombreUser = dr.GetString(1);
                    idGrupo = dr.GetInt32(2);
                    Tipo = dr.GetString(3);
                    recuperado = true;
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ec)
            {
                recuperado = false;
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;
        }

        internal bool ValidarNivelPermisos(int pIdVentana)
        {
            bool r = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection Conn = new SqlConnection(dp.ConnectionStringERP);
                Conn.Open();
                //string sql = @"SELECT count(*)
                //                FROM [dbo].conf_usuario_ventanas vv 
                //                where vv.id_ventana = " + pIdVentana.ToString() +
                //                      "and vv.id_usuario = " + UserId.ToString();
                SqlCommand cmd = new SqlCommand("", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_ventana", pIdVentana.ToString());
                cmd.Parameters.AddWithValue("@id_usuario",UserId.ToString());
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

    }
}