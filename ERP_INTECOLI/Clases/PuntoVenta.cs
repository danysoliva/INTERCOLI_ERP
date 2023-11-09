using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_INTECOLI.Clases
{
    //internal class PuntoVenta
    //{
    //}

    public class PuntoVenta
    {
        public int ID { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int DepartamentoID { get; set; }
        public string Departamento { get; set; }
        public int CiudadID { get; set; }
        public string Ciudad { get; set; }
        public DateTime FechaApertura { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int UsuarioID { get; set; }
        /// <summary>
        /// id	descripcion
        //1	Facturación Rápida
        //2	Facturación Normal
        /// </summary>
        public int TipoFacturacionID { get; set; }
        public string TipoFacturacion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string NombreLegal { get; set; }
        public bool BloqueoPorFaltaStock { get; set; }
        public bool PermiteAnulacionConAutorizacion { get; set; }
        public bool ConteoPrintFactura { get; set; }
        public bool PermiteReimpresionFacturaConAutorizacion { get; set; }
        public bool EmisionFacturaDosPasos { get; set; }
        public bool FacturaComidaBuffet { get; set; }
        public bool FacturaAlmacenPRD { get; set; }
        public string RTN { get; set; }
        public int IdFormatoFactura { get; set; }

        public bool Recuperado { get; set; }
        public bool EmiteFacturaFiscal { get; set; }
        public int CorrelativoRecibo { get; set; }


        public decimal RecuperarPrecioItem(int pId_PT, int pidPuntoVenta, int pIdCliente)
        {
            decimal valor = 0;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP);
                using (SqlCommand cmd = new SqlCommand("[dbo].[sp_get_precio_pt_from_lista_y_punto_venta_v2]", cnx))
                {
                    cnx.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id_pt", System.Data.SqlDbType.Int).Value = pId_PT;
                    cmd.Parameters.Add("@id_punto_venta", System.Data.SqlDbType.Int).Value = pidPuntoVenta;
                    cmd.Parameters.Add("@id_cliente", System.Data.SqlDbType.Int).Value = pIdCliente;

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        valor = dr.GetDecimal(0);
                    }
                    dr.Close();
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
            return valor;
        }

        public bool RecuperaRegistro(int pdv)
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP);

                using (SqlCommand cmd = new SqlCommand("dbo.[uspGetPDVById_V2]", cnx))
                {
                    cnx.Open();

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = pdv;

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        ID = pdv;
                        Codigo = dr.GetString(1);
                        Nombre = dr.GetString(2);
                        FechaApertura = dr.GetDateTime(3);
                        FechaCreacion = dr.GetDateTime(4);
                        Direccion = dr.GetString(5);
                        CiudadID = dr.GetInt32(6);
                        Ciudad = dr.GetString(7);
                        DepartamentoID = dr.GetInt32(8);
                        Departamento = dr.GetString(9);
                        UsuarioID = dr.GetInt32(10);
                        TipoFacturacionID = dr.GetInt32(11);
                        TipoFacturacion = dr.GetString(12);
                        BloqueoPorFaltaStock = dr.GetBoolean(13);
                        PermiteAnulacionConAutorizacion = dr.GetBoolean(14);
                        ConteoPrintFactura = dr.GetBoolean(15);
                        PermiteReimpresionFacturaConAutorizacion = dr.GetBoolean(16);
                        EmisionFacturaDosPasos = dr.GetBoolean(17);
                        FacturaComidaBuffet = dr.GetBoolean(18);
                        Correo = dr["correo"].ToString();
                        Telefono = dr["telefono"].ToString();
                        NombreLegal = dr["nombre_legal"].ToString();

                        if (!dr.IsDBNull(dr.GetOrdinal("rtn")))
                            RTN = dr["rtn"].ToString();

                        if (!dr.IsDBNull(dr.GetOrdinal("id_formato_facturas")))
                            IdFormatoFactura = Convert.ToInt32(dr["id_formato_facturas"]);

                        if (!dr.IsDBNull(dr.GetOrdinal("EmiteFacturaFiscal")))
                            EmiteFacturaFiscal = Convert.ToBoolean(dr["EmiteFacturaFiscal"]);

                        if (!dr.IsDBNull(dr.GetOrdinal("correlativo_recibo")))
                            CorrelativoRecibo = Convert.ToInt32(dr["correlativo_recibo"]);

                        FacturaAlmacenPRD = Convert.ToBoolean(dr["factura_almacen_produccion"]);

                        Recuperado = true;
                    }

                    cnx.Close();
                    return Recuperado;
                }

                //return true;

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return false;
            }

        }




    }
}
