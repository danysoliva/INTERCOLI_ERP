using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_INTECOLI.Clases
{
    //internal class ListaPrecioPuntoVenta
    //{
    //}

    public class ListaPrecioPuntoVenta
    {
        public long Id { get; set; }
        public int? IdPt { get; set; }

        public int? IdListaPrecio { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UsuarioId { get; set; }
        public bool? Enable { get; set; }
        public decimal Precio { get; set; }
        public int? IdPdv { get; set; }
        /// <summary>
        /// Foreign key de la tabla [JAGUAR_DB].[dbo].[ListaPrecios_ProductosAplica]
        /// </summary>
        public int? IdLPProductosAplica { get; set; }
        public bool Recuperado { get; set; }
        DataOperations dp;

        public ListaPrecioPuntoVenta()
        {
            dp = new DataOperations();
        }


        public bool RecuperarRegistro(long id)
        {
            Recuperado = false;
            using (SqlConnection connection = new SqlConnection(dp.ConnectionStringERP))
            {
                connection.Open();
                string query = "SELECT * FROM [dbo].[ListaPrecios_ProductosAplicaTienda] WHERE [id] = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Id = (long)reader["id"];
                            IdPt = reader["id_pt"] == DBNull.Value ? null : (int?)reader["id_pt"];
                            IdListaPrecio = reader["id_listaPrecio"] == DBNull.Value ? null : (int?)reader["id_listaPrecio"];
                            CreatedDate = reader["created_date"] == DBNull.Value ? null : (DateTime?)reader["created_date"];
                            UsuarioId = reader["usuario_id"] == DBNull.Value ? null : (int?)reader["usuario_id"];
                            Enable = reader["enable"] == DBNull.Value ? null : (bool?)reader["enable"];
                            Precio = (decimal)reader["precio"];
                            IdPdv = reader["id_pdv"] == DBNull.Value ? null : (int?)reader["id_pdv"];
                            IdLPProductosAplica = reader["id_LP_ProductosAplica"] == DBNull.Value ? null : (int?)reader["id_LP_ProductosAplica"];
                            Recuperado = true;
                        }
                    }
                }
            }
            return Recuperado;
        }

        public long InsertNewRow()
        {
            using (SqlConnection connection = new SqlConnection(dp.ConnectionStringERP))
            {
                connection.Open();
                string query = "INSERT INTO [dbo].[ListaPrecios_ProductosAplicaTienda] " +
                               "([id_pt], [id_listaPrecio], [created_date], [usuario_id], [enable], [precio], [id_pdv], [id_LP_ProductosAplica]) " +
                               "VALUES (@IdPt, @IdListaPrecio, @CreatedDate, @UsuarioId, @Enable, @Precio, @IdPdv, @IdLPProductosAplica);" +
                               "SELECT SCOPE_IDENTITY();";  // Get the newly inserted identity value

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdPt", IdPt ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@IdListaPrecio", IdListaPrecio ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@CreatedDate", CreatedDate ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@UsuarioId", UsuarioId ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Enable", Enable ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Precio", Precio);
                    command.Parameters.AddWithValue("@IdPdv", IdPdv ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@IdLPProductosAplica", IdLPProductosAplica ?? (object)DBNull.Value);

                    this.Id = Convert.ToInt64(command.ExecuteScalar());

                    command.CommandText = "dbo.sp_set_InsertarNuevoRegistroClientes_precio";
                    command.Parameters.Clear();
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@id_pt_lista_precio_detalle", this.Id);
                    command.Parameters.AddWithValue("@precio", Precio);
                    command.Parameters.AddWithValue("@id_cliente", DBNull.Value);
                    command.Parameters.AddWithValue("@enable", 1);
                    command.Parameters.AddWithValue("@date_writed", CreatedDate);
                    command.Parameters.AddWithValue("@id_user_writed", UsuarioId);
                    command.Parameters.AddWithValue("@id_user_updated", DBNull.Value);
                    command.Parameters.AddWithValue("@date_updated", DBNull.Value);
                    command.ExecuteNonQuery();


                    return this.Id;
                }
            }
        }

        public bool UpdateRecord()
        {
            bool Result = false;
            using (SqlConnection connection = new SqlConnection(dp.ConnectionStringERP))
            {
                connection.Open();
                string query = "UPDATE [dbo].[ListaPrecios_ProductosAplicaTienda] SET " +
                               "[id_pt] = @IdPt, " +
                               "[id_listaPrecio] = @IdListaPrecio, " +
                               "[created_date] = @CreatedDate, " +
                               "[usuario_id] = @UsuarioId, " +
                               "[enable] = @Enable, " +
                               "[precio] = @Precio, " +
                               "[id_pdv] = @IdPdv, " +
                               "[id_LP_ProductosAplica] = @IdLPProductosAplica " +
                               "WHERE [id] = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", Id);
                    command.Parameters.AddWithValue("@IdPt", IdPt ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@IdListaPrecio", IdListaPrecio ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@CreatedDate", CreatedDate ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@UsuarioId", UsuarioId ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Enable", Enable ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Precio", Precio);
                    command.Parameters.AddWithValue("@IdPdv", IdPdv ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@IdLPProductosAplica", IdLPProductosAplica ?? (object)DBNull.Value);

                    command.ExecuteNonQuery();
                    Result = true;
                }
            }
            return Result;
        }
    }
}
