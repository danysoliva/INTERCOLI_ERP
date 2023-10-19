using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_INTECOLI.Clases
{
    //internal class FacturaEstado
    //{
    //}
    public class FacturaEstado
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public bool Enable { get; set; }
        public bool Recuperado { get; set; }
        DataOperations dp;

        public FacturaEstado()
        {
            dp = new DataOperations();
        }

        public bool RecuperarRegistro(int id)
        {
            Recuperado = false;
            string connectionString = dp.ConnectionStringERP; // Reemplaza con la cadena de conexión correcta
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT [id], isnull([descripcion],'N/D') as descripcion, isnull([enable],1) as enable FROM [dbo].[Facturacion_EstadosFactura] WHERE [id] = @id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Id = Convert.ToInt32(reader["id"]);
                            Descripcion = reader["descripcion"].ToString();
                            Enable = Convert.ToBoolean(reader["enable"]);
                            Recuperado = true;
                        }
                        else
                        {
                            // Manejar el caso en el que no se encontró ningún registro con el ID especificado.
                            // Puedes lanzar una excepción u realizar otra acción adecuada.
                        }
                    }
                }
            }
            return Recuperado;
        }
    }

}
