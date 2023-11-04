using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_INTECOLI.Clases
{
    public class Niveles
    {
        public int id_nivel { get; set; }
        public bool habilitado { get; set; }
        public int id_usuario { get; set; }
        public bool sinc { get; set; }
        public string descripcion { get; set; }
        public decimal valor { get; set; }
        public int id_pt { get; set; }
        public bool Recuperado { get; set; }




        public Niveles() { }


        public bool CargarDatosPorId(int idNivel)
        {
            DataOperations dp = new DataOperations();
            Recuperado = false;
            string connectionString = dp.ConnectionStringERP; // Reemplaza con la cadena de conexión a tu base de datos SQL Server

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT [id_nivel], [habilitado], [id_usuario], [sinc], [descripcion], [valor], [id_pt] " +
                               "FROM [dbo].[niveles] " +
                               "WHERE [id_nivel] = @idNivel";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idNivel", idNivel);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            id_nivel = (int)reader["id_nivel"];

                            if (!reader.IsDBNull(reader.GetOrdinal("habilitado")))
                                habilitado = (bool)reader["habilitado"];

                            if (!reader.IsDBNull(reader.GetOrdinal("id_usuario")))
                                id_usuario = (int)reader["id_usuario"];

                            if (!reader.IsDBNull(reader.GetOrdinal("sinc")))
                                sinc = (bool)reader["sinc"];

                            if (!reader.IsDBNull(reader.GetOrdinal("descripcion")))
                                descripcion = reader["descripcion"].ToString();

                            if (!reader.IsDBNull(reader.GetOrdinal("valor")))
                                valor = (decimal)reader["valor"];

                            if (!reader.IsDBNull(reader.GetOrdinal("id_pt")))
                                id_pt = (int)reader["id_pt"];
                            Recuperado = true;
                        }
                    }
                }
            }
            return Recuperado;
        }


        public bool CargarDatosPorId_PT(int pIdPT)
        {
            DataOperations dp = new DataOperations();
            Recuperado = false;
            string connectionString = dp.ConnectionStringERP; // Reemplaza con la cadena de conexión a tu base de datos SQL Server

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT top 1 [id_nivel], [habilitado], [id_usuario], [sinc], [descripcion], [valor], [id_pt] " +
                               "FROM [dbo].[niveles] " +
                               "WHERE [id_pt] = @idpt";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idpt", pIdPT);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            id_nivel = (int)reader["id_nivel"];

                            if (!reader.IsDBNull(reader.GetOrdinal("habilitado")))
                                habilitado = (bool)reader["habilitado"];

                            if (!reader.IsDBNull(reader.GetOrdinal("id_usuario")))
                                id_usuario = (int)reader["id_usuario"];

                            if (!reader.IsDBNull(reader.GetOrdinal("sinc")))
                                sinc = (bool)reader["sinc"];

                            if (!reader.IsDBNull(reader.GetOrdinal("descripcion")))
                                descripcion = reader["descripcion"].ToString();

                            if (!reader.IsDBNull(reader.GetOrdinal("valor")))
                                valor = (decimal)reader["valor"];

                            if (!reader.IsDBNull(reader.GetOrdinal("id_pt")))
                                id_pt = (int)reader["id_pt"];
                            Recuperado = true;
                        }
                    }
                }
            }
            return Recuperado;
        }


    }
}
