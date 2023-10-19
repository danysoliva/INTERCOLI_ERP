using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_INTECOLI.Clases
{
    public class ListaPrecios
    {
        public int ID { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
        public bool Enable { get; set; }
        public int UsuarioID { get; set; }
        public string Usuario { get; set; }
        public int Anio { get; set; }
        public int Mes { get; set; }
        public bool Recuperado { get; set; }
        public string PDV { get; set; }
        public int PDV_ID { get; set; }



        public bool ActualizarListaPrecios(int id, string nuevaDescripcion, DateTime nuevoDesde, DateTime nuevoHasta)
        {
            DataOperations dp = new DataOperations();
            bool SuccessFull = false;
            using (SqlConnection connection = new SqlConnection(dp.ConnectionStringERP))
            {
                connection.Open();

                string updateQuery = "UPDATE [dbo].[ListaPrecios] SET [descripcion] = @descripcion, [desde] = @desde, [hasta] = @hasta WHERE [id] = @id";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@descripcion", nuevaDescripcion);
                    command.Parameters.AddWithValue("@desde", nuevoDesde);
                    command.Parameters.AddWithValue("@hasta", nuevoHasta);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        SuccessFull = true;
                        Console.WriteLine("Actualización exitosa.");
                    }
                    else
                    {
                        Console.WriteLine("No se encontró la fila con el ID especificado.");
                    }
                }
            }
            return SuccessFull;
        }



        public bool RecuperaRegistro(int id)
        {
            try
            {

                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP))
                {
                    cnx.Open();

                    SqlCommand cmd = new SqlCommand("dbo.uspGetListaPrecioById", cnx);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        ID = id;
                        Descripcion = dr.GetString(1);
                        CreatedDate = dr.GetDateTime(2);
                        UsuarioID = dr.GetInt32(3);
                        Usuario = dr.GetString(4);
                        Mes = dr.GetInt32(5);
                        Anio = dr.GetInt32(6);
                        Codigo = dr.GetString(8);
                        PDV_ID = dr.GetInt32(9);
                        PDV = dr.GetString(10);
                        Desde = dr.GetDateTime(11);
                        Hasta = dr.GetDateTime(12);
                        Recuperado = true;
                    }
                    dr.Close();
                    cnx.Close();
                }
                return Recuperado;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return false;
            }
        }
    }
}
