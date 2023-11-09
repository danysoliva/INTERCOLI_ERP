using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_INTECOLI.Clases
{
    //internal class Factura
    //{
    //}
    public class Factura
    {
        public long Id { get; set; }
        public string NumeroDocumento { get; set; }
        public bool Enable { get; set; }
        public int IdEstado { get; set; }
        public int CantidadImpresionesFactura { get; set; }
        public int IdUser { get; set; }
        public DateTime FechaRow { get; set; }
        public DateTime FechaDocumento { get; set; }
        public int IdCliente { get; set; }
        public long IdEstudiante { get; set; }
        public string RTN { get; set; }
        public string NumOrdenCompra { get; set; }
        public int IdPuntoVenta { get; set; }
        public int IdNumeracionFiscal { get; set; }
        public string ClienteNombre { get; set; }
        public string ValorLetras { get; set; }
        public string CAI { get; set; }
        public string FechaLimite { get; set; }
        public string RangoAutorizado { get; set; }
        public string direccion_cliente { get; set; }
        public decimal subtotalFactura { get; set; }
        public decimal TotalFactura { get; set; }
        public decimal descuentoTotalFactura { get; set; }
        public decimal ISV1 { get; set; }
        public decimal ISV2 { get; set; }
        public int idFormatoFactura { get; set; }
        public string ReferenciaRecibo { get; set; }
        public int IdPuntoVentaDestino { get; set; }
        public int IdTerminoPago { get; set; }
        public string TerminoPagoName { get; set; }
        public int id_tipo_pago_electronico { get; set; }
        public string TipoPagoElectronicoName { get; set; }
        public bool Recuperado { get; set; }


        #region DatosPDV
        public int PDV_ID { get; set; }
        public string NombreComercial_PDV { get; set; }
        public string DireccionPDV { get; set; }
        public string RTN_PDV { get; set; }
        public string Correo_PDV { get; set; }
        public string Telefono_PDV { get; set; }
        public string NombreLegal_PDV { get; set; }
        #endregion

        DataOperations dp;
        ArrayList LineasFactura;

        public Factura()
        {
            dp = new DataOperations();
            LineasFactura = new ArrayList();
        }

        //public bool RecuperarRegistro(int pIdFactura)
        //{
        //    return Recuperado;
        //}

        public bool RecuperarRegistro(long pIdFactura)
        {
            string connectionString = dp.ConnectionStringERP;
            NumberToLetters valorEnLetras = new NumberToLetters();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "dbo.sp_get_factura_header_for_class_main";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id_factura", pIdFactura);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        Id = (long)reader["id"];
                        NumeroDocumento = reader["numero_documento"].ToString();
                        Enable = (bool)reader["enable"];
                        IdEstado = (int)reader["id_estado"];
                        CantidadImpresionesFactura = (int)reader["cant_print"];
                        IdUser = (int)reader["id_user"];
                        FechaRow = (DateTime)reader["fecha_row"];
                        FechaDocumento = (DateTime)reader["fecha_documento"];
                        IdCliente = (int)reader["id_cliente"];
                        RTN = reader["RTN"].ToString();
                        NumOrdenCompra = reader["num_orden_compra"].ToString();
                        IdPuntoVenta = (int)reader["id_punto_venta"];
                        IdNumeracionFiscal = (int)reader["id_numeracion_fiscal"];

                        if (!reader.IsDBNull(reader.GetOrdinal("cliente_nombre")))
                            ClienteNombre = reader["cliente_nombre"].ToString();

                        if (!reader.IsDBNull(reader.GetOrdinal("CAI")))
                            CAI = reader["CAI"].ToString();

                        if (!reader.IsDBNull(reader.GetOrdinal("fecha_limite")))
                            FechaLimite = reader["fecha_limite"].ToString();

                        if (!reader.IsDBNull(reader.GetOrdinal("rango_autorizado")))
                            RangoAutorizado = reader["rango_autorizado"].ToString();

                        if (!reader.IsDBNull(reader.GetOrdinal("direccion_cliente")))
                            direccion_cliente = reader["direccion_cliente"].ToString();

                        subtotalFactura = Convert.ToDecimal(reader["subtotal"]);
                        TotalFactura = Convert.ToDecimal(reader["total_factura"]);
                        descuentoTotalFactura = Convert.ToDecimal(reader["descuento"]);
                        ISV1 = Convert.ToDecimal(reader["isv1"]);
                        ISV2 = Convert.ToDecimal(reader["isv2"]);

                        if (!reader.IsDBNull(reader.GetOrdinal("id_formato_impresion")))
                            idFormatoFactura = Convert.ToInt32(reader["id_formato_impresion"]);

                        IdPuntoVentaDestino = Convert.ToInt32(reader["id_punto_venta_destino"]);

                        IdTerminoPago = Convert.ToInt32(reader["id_termino_pago"]);
                        TerminoPagoName = reader["termino_pago_name"].ToString();

                        if (!reader.IsDBNull(reader.GetOrdinal("id_tipo_pago_electronico")))
                            id_tipo_pago_electronico = Convert.ToInt32(reader["id_tipo_pago_electronico"]);

                        if (!reader.IsDBNull(reader.GetOrdinal("TipoPagoElectronicoName")))
                            TipoPagoElectronicoName = reader["TipoPagoElectronicoName"].ToString();

                        ValorLetras = valorEnLetras.Convertir((subtotalFactura - descuentoTotalFactura + ISV1 + ISV2).ToString(), true);
                        RecuperaDatosPDVFromFactura(IdPuntoVenta);
                        Recuperado = true;
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Handle exceptions here
                    //Console.WriteLine("Error: " + ex.Message);
                    Recuperado = false;
                    CajaDialogo.Error("Error al cargar la clase de FacturaH. Msg: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return Recuperado;
        }

        public bool UpdatePrintCount(Int64 pIdFactura)
        {
            bool ret = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_set_increment_count_printer", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_factura", pIdFactura);
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


        public decimal GetSaldoFacturaH(Int64 pIdFactura)
        {
            decimal res = 0;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_get_saldo_facturaH", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_factura", pIdFactura);
                res = Convert.ToDecimal(cmd.ExecuteScalar());
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return res;
        }




        public bool UpdateFacturaStatus(Int64 pIdFactura, int pIdStatus, int pIdTipoPago)
        {
            bool ret = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_set_update_estado_factura_h]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_factura", pIdFactura);
                cmd.Parameters.AddWithValue("@id_estado", pIdStatus);
                cmd.Parameters.AddWithValue("@id_tipo_pago", pIdTipoPago);

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





        public bool RecuperarRegistro(string pNumFactura)
        {
            string connectionString = dp.ConnectionStringERP;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "dbo.sp_get_factura_header_for_class_main_from_num_documento";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@NumFactura", pNumFactura);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        Id = (long)reader["id"];
                        NumeroDocumento = reader["numero_documento"].ToString();
                        Enable = (bool)reader["enable"];
                        IdEstado = (int)reader["id_estado"];
                        CantidadImpresionesFactura = (int)reader["cant_print"];
                        IdUser = (int)reader["id_user"];
                        FechaRow = (DateTime)reader["fecha_row"];
                        FechaDocumento = (DateTime)reader["fecha_documento"];
                        IdCliente = (int)reader["id_cliente"];
                        RTN = reader["RTN"].ToString();
                        NumOrdenCompra = reader["num_orden_compra"].ToString();
                        IdPuntoVenta = (int)reader["id_punto_venta"];
                        IdNumeracionFiscal = (int)reader["id_numeracion_fiscal"];
                        ClienteNombre = reader["cliente_nombre"].ToString();
                        if (!reader.IsDBNull(reader.GetOrdinal("CAI")))
                            CAI = reader["CAI"].ToString();

                        if (!reader.IsDBNull(reader.GetOrdinal("fecha_limite")))
                            FechaLimite = reader["fecha_limite"].ToString();

                        if (!reader.IsDBNull(reader.GetOrdinal("rango_autorizado")))
                            RangoAutorizado = reader["rango_autorizado"].ToString();

                        if (!reader.IsDBNull(reader.GetOrdinal("direccion_cliente")))
                            direccion_cliente = reader["direccion_cliente"].ToString();

                        subtotalFactura = Convert.ToDecimal(reader["subtotal"]);
                        descuentoTotalFactura = Convert.ToDecimal(reader["descuento"]);
                        ISV1 = Convert.ToDecimal(reader["isv1"]);
                        ISV2 = Convert.ToDecimal(reader["isv2"]);

                        if (!reader.IsDBNull(reader.GetOrdinal("id_formato_impresion")))
                            idFormatoFactura = Convert.ToInt32(reader["id_formato_impresion"]);

                        IdPuntoVentaDestino = Convert.ToInt32("id_punto_venta_destino");

                        IdTerminoPago = Convert.ToInt32(reader["id_termino_pago"]);
                        TerminoPagoName = reader["termino_pago_name"].ToString();


                        Recuperado = true;
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Handle exceptions here
                    //Console.WriteLine("Error: " + ex.Message);
                    Recuperado = false;
                    CajaDialogo.Error("Error al cargar la clase de FacturaH. Msg: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return Recuperado;
        }


        /// <summary>
        /// Para llamar esta funcion deben llenarse las propiedades de la clase antes.
        /// Para las lineas es necesario llenar la propiedad de tipo List->LineasFactura con objetos de clase FacturaDetalle
        /// La funcion cuenta con un control de commit y rollback para efectuar el posteo completo de la transaccion o revertirlo en caso de error.
        /// </summary>
        /// <returns>Int64 Id de Factura H</returns>
        public Int64 InsertFactura()
        {
            Int64 rowsAffected = 0;
            string connectionString = dp.ConnectionStringERP;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;
                transaction = connection.BeginTransaction("SampleTransaction");

                command.CommandType = CommandType.Text;
                command.CommandText = "dbo.[sp_fact_InsertFacturaH_v3]";

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@numero_documento", NumeroDocumento);
                command.Parameters.AddWithValue("@id_estado", IdEstado);
                command.Parameters.AddWithValue("@id_user", IdUser);
                command.Parameters.AddWithValue("@fecha_documento", FechaDocumento);
                command.Parameters.AddWithValue("@id_cliente", IdCliente);
                command.Parameters.AddWithValue("@RTN", RTN);
                command.Parameters.AddWithValue("@num_orden_compra", NumOrdenCompra);
                command.Parameters.AddWithValue("@id_punto_venta", IdPuntoVenta);
                command.Parameters.AddWithValue("@id_numeracion_fiscal", IdNumeracionFiscal);
                command.Parameters.AddWithValue("@cliente_nombre", ClienteNombre);
                command.Parameters.AddWithValue("@id_formato_impresion", idFormatoFactura);

                if (IdPuntoVentaDestino == 0)
                    command.Parameters.AddWithValue("@id_punto_venta_destino", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@id_punto_venta_destino", IdPuntoVentaDestino);

                try
                {
                    connection.Open();
                    rowsAffected = Convert.ToInt64(command.ExecuteScalar());

                    //Vamos a guardar las lineas de detalle en la misma transaccion
                    command.CommandText = "dbo.sp_fact_insert_linea_factura_detalle";
                    command.CommandType = CommandType.StoredProcedure;

                    foreach (FacturaDetalle FactDetalle in LineasFactura)
                    {
                        command.Parameters.Clear();
                        //command.Parameters.AddWithValue("@pIdFacturaH", FactDetalle.IdFacturaH);
                        command.Parameters.AddWithValue("@pIdFacturaH", rowsAffected);
                        command.Parameters.AddWithValue("@pIdPt", FactDetalle.IdPt);
                        command.Parameters.AddWithValue("@pItemCode", FactDetalle.ItemCode);
                        command.Parameters.AddWithValue("@pDescripcion", FactDetalle.Descripcion);
                        command.Parameters.AddWithValue("@pCantidad", FactDetalle.Cantidad);
                        command.Parameters.AddWithValue("@pPrecio", FactDetalle.Precio);
                        command.Parameters.AddWithValue("@pDescuento", FactDetalle.Descuento);
                        command.Parameters.AddWithValue("@pImpuesto1", FactDetalle.Impuesto1);
                        command.Parameters.AddWithValue("@pImpuesto2", FactDetalle.Impuesto2);
                        command.Parameters.AddWithValue("@pImpuesto3", FactDetalle.Impuesto3);
                        command.Parameters.AddWithValue("@pTotalLinea", FactDetalle.TotalLinea);

                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return rowsAffected;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine("Error: " + ex.Message);
                    return rowsAffected;
                }

            }
        }

        private void RecuperaDatosPDVFromFactura(Int64 id_pdv)
        {
            string connectionString = dp.ConnectionStringERP;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "dbo.uspGetPDVFromFacturaClass";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id_pdv", id_pdv);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        PDV_ID = (Int32)reader["id"];
                        NombreComercial_PDV = reader["nombre_local"].ToString();
                        DireccionPDV = reader["direccion"].ToString();
                        Correo_PDV = reader["correo"].ToString();
                        Telefono_PDV = reader["telefono"].ToString();
                        NombreLegal_PDV = reader["nombre_legal"].ToString();
                        RTN_PDV = reader["rtn"].ToString();
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Handle exceptions here
                    //Console.WriteLine("Error: " + ex.Message);
                    Recuperado = false;
                    CajaDialogo.Error("Error al cargar la clase de FacturaH. Msg: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }







    }
}
