using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_INTECOLI.Clases
{
    public class Impuesto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Codigo { get; set; }
        public decimal Valor { get; set; }
        public bool Enable { get; set; }
        public bool Recuperado { get; set; }
        DataOperations dp;

        public Impuesto()
        {
            dp = new DataOperations();
        }

        public bool RecuperarRegistro(int pid)
        {
            Recuperado = false;
            string connectionString = dp.ConnectionStringERP;
            string query = "dbo.sp_get_clase_maestro_impuesto";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", pid);//Id impuesto
                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                Id = Convert.ToInt32(reader["id"]);
                                Descripcion = reader["descripcion"].ToString();

                                if (!reader.IsDBNull(reader.GetOrdinal("codigo")))
                                    Codigo = reader["codigo"].ToString();

                                if (!reader.IsDBNull(reader.GetOrdinal("valor")))
                                    Valor = Convert.ToDecimal(reader["valor"]);

                                Enable = Convert.ToBoolean(reader["enable"]);
                                Recuperado = true;
                            }
                            reader.Close();
                            connection.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message, ex);
                    }
                }
            }

            return Recuperado;
        }

    }
}
