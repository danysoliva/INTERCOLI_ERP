using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_INTECOLI.Clases
{

    public class ClientesPuntoVentaLP
    {
        public long Id { get; set; }
        /// <summary>
        /// Llave foranea al id de la tabla [JAGUAR_DB].[dbo].[ListaPrecios_ProductosAplicaTienda]
        /// </summary>
        public long IdPtListaPrecioDetalle { get; set; }
        public decimal? Precio { get; set; }
        public int? IdCliente { get; set; }
        public bool? Enable { get; set; }
        public DateTime? DateWrited { get; set; }
        public int? IdUserWrited { get; set; }
        public int? IdUserUpdated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public bool Recuperado { get; set; }
        DataOperations dp;

        public ClientesPuntoVentaLP()
        {
            dp = new DataOperations();

        }


        public bool RecuperarRegistro(long id)
        {
            Recuperado = false;
            using (SqlConnection connection = new SqlConnection(dp.ConnectionStringERP))
            {
                connection.Open();
                string query = "SELECT * FROM [dbo].[ListaPrecios_ProductosPuntoVenta_Clientes] WHERE [id] = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    Recuperado = false;
                    command.Parameters.AddWithValue("@Id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Id = (long)reader["id"];
                            IdPtListaPrecioDetalle = (long)reader["id_pt_lista_precio_detalle"];
                            Precio = reader["precio"] == DBNull.Value ? null : (decimal?)reader["precio"];
                            IdCliente = reader["id_cliente"] == DBNull.Value ? null : (int?)reader["id_cliente"];
                            Enable = reader["enable"] == DBNull.Value ? null : (bool?)reader["enable"];
                            DateWrited = reader["date_writed"] == DBNull.Value ? null : (DateTime?)reader["date_writed"];
                            IdUserWrited = reader["id_user_writed"] == DBNull.Value ? null : (int?)reader["id_user_writed"];
                            IdUserUpdated = reader["id_user_updated"] == DBNull.Value ? null : (int?)reader["id_user_updated"];
                            DateUpdated = reader["date_updated"] == DBNull.Value ? null : (DateTime?)reader["date_updated"];
                            Recuperado = true;
                        }
                    }
                }
            }
            return Recuperado;
        }

        public bool UpdateRecord()
        {
            bool Result = false;
            using (SqlConnection connection = new SqlConnection(dp.ConnectionStringERP))
            {
                connection.Open();
                string query = "UPDATE [dbo].[ListaPrecios_ProductosPuntoVenta_Clientes] SET " +
                               "[id_pt_lista_precio_detalle] = @IdPtListaPrecioDetalle, " +
                               "[precio] = @Precio, " +
                               "[id_cliente] = @IdCliente, " +
                               "[enable] = @Enable, " +
                               "[date_writed] = @DateWrited, " +
                               "[id_user_writed] = @IdUserWrited, " +
                               "[id_user_updated] = @IdUserUpdated, " +
                               "[date_updated] = @DateUpdated " +
                               "WHERE [id] = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", Id);
                    command.Parameters.AddWithValue("@IdPtListaPrecioDetalle", IdPtListaPrecioDetalle);
                    command.Parameters.AddWithValue("@Precio", Precio ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@IdCliente", IdCliente ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Enable", Enable ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@DateWrited", DateWrited ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@IdUserWrited", IdUserWrited ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@IdUserUpdated", IdUserUpdated ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@DateUpdated", DateUpdated ?? (object)DBNull.Value);

                    command.ExecuteNonQuery();
                    Result = true;
                }
            }
            return Result;
        }

        public long InsertRow()
        {
            using (SqlConnection connection = new SqlConnection(dp.ConnectionStringERP))
            {
                connection.Open();
                string query = "INSERT INTO [dbo].[ListaPrecios_ProductosPuntoVenta_Clientes] ([id_pt_lista_precio_detalle], [precio], [id_cliente], [enable], [date_writed], [id_user_writed], [id_user_updated], [date_updated]) " +
                               "VALUES (@IdPtListaPrecioDetalle, @Precio, @IdCliente, @Enable, @DateWrited, @IdUserWrited, @IdUserUpdated, @DateUpdated);" +
                               "SELECT SCOPE_IDENTITY();";  // Get the newly inserted identity value

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdPtListaPrecioDetalle", IdPtListaPrecioDetalle);
                    command.Parameters.AddWithValue("@Precio", Precio ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@IdCliente", IdCliente ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Enable", Enable ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@DateWrited", DateWrited ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@IdUserWrited", IdUserWrited ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@IdUserUpdated", IdUserUpdated ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@DateUpdated", DateUpdated ?? (object)DBNull.Value);

                    return Convert.ToInt64(command.ExecuteScalar());
                }
            }
        }
    }
}
