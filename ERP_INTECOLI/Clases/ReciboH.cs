using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_INTECOLI.Clases
{
    //internal class ReciboH
    //{
    //}

    public class ReciboH
    {
        public int IdRecibo { get; set; }
        public string NumeroDocumento { get; set; }
        public bool Enable { get; set; }
        public int IdUsuarioCreated { get; set; }
        public string UsuarioCreador { get; set; }
        public int IdUsuarioUpdated { get; set; }
        public string UsuarioUltimaModificacion { get; set; }
        public string Concepto { get; set; }
        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public DateTime FechaCreated { get; set; }
        public DateTime FechaUpdated { get; set; }
        public int IdPuntoVenta { get; set; }
        public decimal Valor { get; set; }
        public int IdTipoPago { get; set; }
        public string TipoPagoDescripcion { get; set; }
        public int IdFormatoImpresion { get; set; }
        public string TipoFormatoImpresion { get; set; }
        public string punto_venta_code { get; set; }
        public string punto_venta_nombre { get; set; }
        public bool Recuperado { get; set; }
        public int CantidadImpresionesFactura { get; set; }
        public string Referencia { get; set; }


        public Int64 InsertarRecibo(string numDoc, bool enable, int idUsuarioCreated, int idUsuarioUpdated, string concepto, int idCliente, DateTime fechaCreated, DateTime fechaUpdated, int idPuntoVenta, decimal valor, int idTipoPago, int idFormatoImpresion)
        {
            Int64 IdReciboInserted = 0;
            DataOperations dp = new DataOperations();
            using (SqlConnection connection = new SqlConnection(dp.ConnectionStringERP))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("InsertarRecibo", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Parámetros de entrada
                    command.Parameters.AddWithValue("@num_doc", numDoc);
                    command.Parameters.AddWithValue("@id_usuario_created", idUsuarioCreated);
                    command.Parameters.AddWithValue("@concepto", concepto);
                    command.Parameters.AddWithValue("@id_cliente", idCliente);
                    command.Parameters.AddWithValue("@fecha_created", fechaCreated);
                    command.Parameters.AddWithValue("@id_punto_venta", idPuntoVenta);
                    command.Parameters.AddWithValue("@valor", valor);
                    command.Parameters.AddWithValue("@id_tipo_pago", idTipoPago);
                    command.Parameters.AddWithValue("@id_formato_impresion", idFormatoImpresion);

                    // Parámetro de salida
                    SqlParameter idReciboParameter = new SqlParameter("@id_recibo_insertado", SqlDbType.BigInt);
                    idReciboParameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(idReciboParameter);

                    command.ExecuteNonQuery();

                    // Obtener el valor del parámetro de salida (id_recibo_insertado)
                    long idReciboInsertado = (long)idReciboParameter.Value;
                    return idReciboInsertado;
                }
            }
        }

        public bool UpdatePrintCount(Int64 pIdRecibo)
        {
            bool ret = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.[sp_set_increment_count_printer_reciboAbonos]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_recibo", pIdRecibo);
                cmd.ExecuteNonQuery();

                ret = true;
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return ret;
        }

        public bool RecuperarRegistro(Int64 idRecibo)
        {
            Recuperado = false;
            DataOperations dp = new DataOperations();
            string connectionString = dp.ConnectionStringERP; // Reemplaza con la cadena de conexión correcta
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"dbo.sp_get_header_recibosH";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id_recibo", idRecibo);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            IdRecibo = Convert.ToInt32(reader["id_recibo"]);
                            NumeroDocumento = reader["num_doc"].ToString();
                            Enable = Convert.ToBoolean(reader["enable"]);
                            IdUsuarioCreated = Convert.ToInt32(reader["id_usuario_created"]);
                            UsuarioCreador = reader["usuario_creador"].ToString();
                            IdUsuarioUpdated = Convert.ToInt32(reader["id_usuario_updated"]);
                            UsuarioUltimaModificacion = reader["usuario_ultima_modificacion"].ToString();
                            Concepto = reader["concepto"].ToString();
                            IdCliente = Convert.ToInt32(reader["id_cliente"]);
                            NombreCliente = reader["NombreCliente"].ToString();

                            if (!reader.IsDBNull(reader.GetOrdinal("fecha_created")))
                                FechaCreated = Convert.ToDateTime(reader["fecha_created"]);

                            if (!reader.IsDBNull(reader.GetOrdinal("fecha_updated")))
                                FechaUpdated = Convert.ToDateTime(reader["fecha_updated"]);

                            IdPuntoVenta = Convert.ToInt32(reader["id_punto_venta"]);
                            punto_venta_code = reader["punto_venta_code"].ToString();
                            punto_venta_nombre = reader["punto_venta_nombre"].ToString();
                            Valor = Convert.ToDecimal(reader["valor"]);
                            IdTipoPago = Convert.ToInt32(reader["id_tipo_pago"]);
                            TipoPagoDescripcion = reader["tipo_pago_descripcion"].ToString();
                            IdFormatoImpresion = Convert.ToInt32(reader["id_formato_impresion"]);
                            TipoFormatoImpresion = reader["tipo_formato_impresion"].ToString();
                            Referencia = reader["referencia"].ToString();
                            Recuperado = true;
                        }
                    }
                }
            }
            return Recuperado;
        }//End RecuperarRegistro



    }
}
