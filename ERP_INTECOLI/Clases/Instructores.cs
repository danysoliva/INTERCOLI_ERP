using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ERP_INTECOLI.Clases
{
    class Instructores
    {
        DataOperations dp = new DataOperations();
        private bool recuperado;
        private int id_instructor;
        private string num_cedula;
        private string nombres;
        private string apellidos;
        private string sexo;
        private string direccion;
        private bool habilitado;
        private DateTime fecha_ingreso;


        public int Id_instructor { get => id_instructor; set => id_instructor = value; }
        public string Num_cedula { get => num_cedula; set => num_cedula = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public bool Habilitado { get => habilitado; set => habilitado = value; }
        public DateTime Fecha_ingreso { get => fecha_ingreso; set => fecha_ingreso = value; }
        public bool Recuperado { get => recuperado; set => recuperado = value; }

        public bool RecuperarRegistros(int pid_instructor)
        {
            recuperado = false;
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_instructores_class", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_instructor", pid_instructor);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id_instructor = dr.GetInt32(0);
                    Num_cedula = dr.GetString(1);
                    Nombres = dr.GetString(2);
                    Apellidos = dr.GetString(3);
                    sexo = dr.GetString(4);
                    Direccion = dr.IsDBNull(5) ? "" : dr.GetString(5);
                    Habilitado = dr.GetBoolean(6);
                    Fecha_ingreso = dr.GetDateTime(7);

                    Recuperado = true;
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                Recuperado = false;
                CajaDialogo.Error(ex.Message);
            }
            return Recuperado;
        }

    }
}
