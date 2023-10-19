using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ERP_INTECOLI.Clases;

namespace ERP_INTECOLI.Clases
{
    public class FacturaBK
    {
        SqlConnection conn;
        DataOperations dp = new DataOperations();
        public int id;
        public string numero;
        public string cai;
        public string cliente;
        public DateTime fecha_emision;
        public DateTime fecha_p;
        public Decimal sub;
        public Decimal descuento;
        public Decimal Recargo;
        public Decimal Saldo;
        public Decimal Impuesto;
        public bool nula;
        public bool Recuperado;
        public string rtn_cliente;
        public string oc;
        public string direccion_c;
        public string telefono_c;
        public int tipo;
        public string rango_a;
        public DateTime fecha_limite;
        public string valor_letras;
        public long id_estudiante;

        public FacturaBK()
        { 
            
        }

        public bool GuardarRegistro()
        {
            try
            {
                //string sql = @"INSERT INTO admon.factura(
                //                                          numero,
                //                                          cai,
                //                                          cliente,
                //                                          fecha_emision,
                //                                          fecha_p,
                //                                          sub,
                //                                          descuento,
                //                                          recargo,
                //                                          saldo,
                //                                          rtn_cliente,
                //                                          oc,
                //                                          direccion_c,
                //                                          telefono_c,
                //                                          tipo,
                //                                          rango_a,
                //                                          fecha_limite,
                //                                          valor_letras
                //                                        )
                //                                        VALUES (
                //                                          :numero,
                //                                          :cai,
                //                                          :cliente,
                //                                          :fecha_emision,
                //                                          :fecha_p,
                //                                          :sub,
                //                                          :descuento,
                //                                          :recargo,
                //                                          :saldo,
                //                                          :rtn_cliente,
                //                                          :oc,
                //                                          :direccion_c,
                //                                          :telefono_c,
                //                                          :tipo,
                //                                          :rango_a,
                //                                          :fecha_limite,
                //                                          :valor_letras
                //                                        )RETURNING id;";
                string sql = @"sp_factura_insert";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numero", numero);
                cmd.Parameters.AddWithValue("@cai", cai);
                cmd.Parameters.AddWithValue("@cliente", cliente);
                cmd.Parameters.AddWithValue("@fecha_emision", fecha_emision);
                cmd.Parameters.AddWithValue("@fecha_p", fecha_p);
                cmd.Parameters.AddWithValue("@sub", sub);
                cmd.Parameters.AddWithValue("@descuento", descuento);
                cmd.Parameters.AddWithValue("@recargo", Recargo);
                cmd.Parameters.AddWithValue("@saldo", Saldo);
                cmd.Parameters.AddWithValue("@rtn_cliente", rtn_cliente);
                cmd.Parameters.AddWithValue("@oc", oc);
                cmd.Parameters.AddWithValue("@direccion_c", direccion_c);
                cmd.Parameters.AddWithValue("@telefono_c", telefono_c);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@rango_a", rango_a);
                cmd.Parameters.AddWithValue("@fecha_limite", fecha_limite);
                cmd.Parameters.AddWithValue("@valor_letras", valor_letras);
                id = Convert.ToInt32(cmd.ExecuteScalar());
                //CajaDialogo.CajaDialogo.Information("Fecha guardada con Exito!");
                Recuperado = true;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
                Recuperado = false;
            }
            return Recuperado;
        }


        public bool RecuperarRegistro(int pIdFactura)
        {
            try
            {
                //string sql = @"SELECT 
                //                      id,
                //                      numero,
                //                      cai,
                //                      cliente,
                //                      fecha_emision,
                //                      fecha_p,
                //                      sub,
                //                      descuento,
                //                      nula,
                //                      rtn_cliente,
                //                      oc,
                //                      direccion_c,
                //                      telefono_c,
                //                      tipo,
                //                      rango_a,
                //                      fecha_limite,
                //                      valor_letras,
                //                      saldo,
                //                      recargo
                //                    FROM admon.factura ff
                //                where ff.id = :p_id;";
                string dql = @"sp_get_factura_for_id_factura";
                conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(dql, conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pIdFactura);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    id = dr.GetInt32(0);
                    numero = dr.GetString(1);
                    cai = dr.GetString(2);
                    cliente = dr.GetString(3);
                    fecha_emision = dr.GetDateTime(4);
                    fecha_p = dr.GetDateTime(5);
                    sub = dr.GetDecimal(6);
                    descuento = dr.GetDecimal(7);
                    nula = dr.GetBoolean(8);
                    rtn_cliente = dr.GetString(9);
                    oc = dr.GetString(10);
                    direccion_c = dr.GetString(11);
                    telefono_c = dr.GetString(12);
                    tipo = dr.GetInt32(13);
                    rango_a = dr.GetString(14);
                    fecha_limite = dr.GetDateTime(15);
                    valor_letras = dr.GetString(16);
                    Saldo = dr.GetDecimal(17);
                    Recargo = dr.GetDecimal(18);
                    Recuperado = true;
                    dr.Close();
                }
            }
            catch (Exception ec)
            {
                Recuperado = false;
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;
        }

        public bool RecuperarRegistro(string pNumFactura)
        {
            try
            {
                //string sql = @"SELECT 
                //                      id,
                //                      numero,
                //                      cai,
                //                      cliente,
                //                      fecha_emision,
                //                      fecha_p,
                //                      sub,
                //                      descuento,
                //                      nula,
                //                      rtn_cliente,
                //                      oc,
                //                      direccion_c,
                //                      telefono_c,
                //                      tipo,
                //                      rango_a,
                //                      fecha_limite,
                //                      valor_letras,
                //                      saldo,
                //                      recargo
                //                    FROM admon.factura ff
                //                where ff.numero = :p_num;";
                string sql = @"sp_get_factura_for_num_factura";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@num_factura", pNumFactura);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    id = dr.GetInt32(0);
                    numero = dr.GetString(1);
                    cai = dr.GetString(2);
                    cliente = dr.GetString(3);
                    fecha_emision = dr.GetDateTime(4);
                    fecha_p = dr.GetDateTime(5);
                    sub = dr.GetDecimal(6);
                    descuento = dr.GetDecimal(7);
                    nula = dr.GetBoolean(8);
                    rtn_cliente = dr.GetString(9);
                    oc = dr.GetString(10);
                    direccion_c = dr.GetString(11);
                    telefono_c = dr.GetString(12);
                    tipo = dr.GetInt32(13);
                    rango_a = dr.GetString(14);
                    fecha_limite = dr.GetDateTime(15);
                    valor_letras = dr.GetString(16);
                    Saldo = dr.GetDecimal(17);
                    Recargo = dr.GetDecimal(18);
                    Recuperado = true;
                    dr.Close();
                }
            }
            catch (Exception ec)
            {
                Recuperado = false;
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;
        }
    }
}
