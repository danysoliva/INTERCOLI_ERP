using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_INTECOLI.Clases
{

    public class FacturacionCierreDiaPuntoVenta
    {
        public Int64 id { get; set; }
        public string codigo { get; set; }
        public int id_punto_venta { get; set; }
        public string punto_venta_descripcion { get; set; }
        public DateTime fecha { get; set; }
        public bool enable { get; set; }
        public int id_estado { get; set; }
        public string estado_descripcion { get; set; }
        public int id_user_responsable { get; set; }
        public string usuario_responsable_nombre { get; set; }
        public int id_user_validacion { get; set; }
        public string usuario_validacion_nombre { get; set; }
        public DateTime fecha_row { get; set; }
        public bool Recuperado { get; set; }
        DataOperations dp;

        public FacturacionCierreDiaPuntoVenta()
        {
            dp = new DataOperations();
        }

        public int InsertHeaderCierreDia(int idPuntoVenta, DateTime fecha, int idUserResponsable)
        {
            int idCierreDia = 0;

            using (SqlConnection connection = new SqlConnection(dp.ConnectionStringERP))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("dbo.sp_set_insert_header_cierre_dia", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Parámetros de entrada
                    //command.Parameters.AddWithValue("@codigo", codigo);
                    command.Parameters.AddWithValue("@id_punto_venta", idPuntoVenta);
                    command.Parameters.AddWithValue("@fecha", fecha);
                    command.Parameters.AddWithValue("@id_user_responsable", idUserResponsable);

                    // Parámetro de salida
                    SqlParameter outputParameter = new SqlParameter("@value", SqlDbType.Int);
                    outputParameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(outputParameter);

                    command.ExecuteNonQuery();

                    // Obtener el valor de retorno
                    if (outputParameter.Value != DBNull.Value)
                    {
                        idCierreDia = (int)outputParameter.Value;
                    }
                }
            }

            return idCierreDia;
        }

        public bool RecuperarRegistro(Int64 pIdCierre)
        {
            Recuperado = false;

            using (SqlConnection connection = new SqlConnection(dp.ConnectionStringERP))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("usp_GetFacturacionCierreDiaPuntoVenta", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id_cierre_dia", pIdCierre);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            id = (Int64)reader["id"];
                            codigo = reader["codigo"].ToString();
                            id_punto_venta = (int)reader["id_punto_venta"];

                            if (!reader.IsDBNull(reader.GetOrdinal("punto_venta_descripcion")))
                                punto_venta_descripcion = reader["punto_venta_descripcion"].ToString();

                            fecha = (DateTime)reader["fecha"];
                            enable = (bool)reader["enable"];
                            id_estado = (int)reader["id_estado"];

                            if (!reader.IsDBNull(reader.GetOrdinal("estado_descripcion")))
                                estado_descripcion = reader["estado_descripcion"].ToString();

                            if (!reader.IsDBNull(reader.GetOrdinal("id_user_responsable")))
                                id_user_responsable = (int)reader["id_user_responsable"];

                            if (!reader.IsDBNull(reader.GetOrdinal("usuario_responsable_nombre")))
                                usuario_responsable_nombre = reader["usuario_responsable_nombre"].ToString();

                            if (!reader.IsDBNull(reader.GetOrdinal("id_user_validacion")))
                                id_user_validacion = (int)reader["id_user_validacion"];

                            if (!reader.IsDBNull(reader.GetOrdinal("usuario_validacion_nombre")))
                                usuario_validacion_nombre = reader["usuario_validacion_nombre"].ToString();

                            fecha_row = (DateTime)reader["fecha_row"];
                            Recuperado = true; // Seteamos la propiedad Recuperado a true
                        }
                    }
                }
            }

            return Recuperado;
        }

    }




}
