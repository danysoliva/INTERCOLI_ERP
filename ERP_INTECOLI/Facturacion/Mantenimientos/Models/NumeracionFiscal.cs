using ERP_INTECOLI.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_APP.Facturacion.Mantenimientos.Models
{
    //public class NumeracionFiscal
    // {
    //     public int Id { get; set; }
    //     public int PDV_ID { get; set; }
    //     public string   PDV { get; set; }
    //     public string CAI { get; set; }
    //     public DateTime FechaEmision { get; set; }
    //     public DateTime FechaVence { get; set; }
    //     public string NumeracionInicial { get; set; }
    //     public string NumeracionFinal { get; set; }
    //     public int EstadoId { get; set; }
    //     public string Estado { get; set; }
    //     public DateTime FechaCreacion { get; set; }
    //     public int CreadoPorId { get; set; }
    //     public string  CreadoPor { get; set; }
    //     public int TipoDocumentoId { get; set; }
    //     public string TipoDocumento { get; set; }
    //     public bool GenCorr { get; set; }
    //     public int Correlativo { get; set; }
    //     public string Leyenda { get; set; }

    //     public bool Recuperado { get; set; }

    //     public bool RecuperarRegistro(int id) {
    //         try
    //         {
    //             DataOperations dp = new DataOperations();

    //             SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP);

    //             using (SqlCommand cmd = new SqlCommand("dbo.uspGetNumeracionFiscalById", cnx))
    //             {
    //                 cnx.Open();

    //                 cmd.CommandType = System.Data.CommandType.StoredProcedure;

    //                 cmd.Parameters.Add("@id",System.Data.SqlDbType.Int).Value=id;

    //                 SqlDataReader dr = cmd.ExecuteReader();

    //                 while (dr.Read())
    //                 {
    //                     Id = id;
    //                     PDV_ID = dr.GetInt32(1);
    //                     PDV = dr.GetString(2);
    //                     CAI = dr.GetString(3);
    //                     FechaEmision = dr.GetDateTime(4);
    //                     FechaVence = dr.GetDateTime(5);
    //                     NumeracionInicial = dr.GetString(6);
    //                     NumeracionFinal = dr.GetString(7);
    //                     EstadoId = dr.GetInt32(8);
    //                     Estado = dr.GetString(9);
    //                     FechaCreacion = dr.GetDateTime(10);
    //                     CreadoPorId = dr.GetInt32(11);
    //                     CreadoPor = dr.GetString(12);
    //                     TipoDocumentoId = dr.GetInt32(13);
    //                     TipoDocumento = dr.GetString(14);
    //                     GenCorr = dr.GetBoolean(15);
    //                     Correlativo = dr.GetInt32(16);
    //                     Leyenda = dr.GetString(17);
    //                     Recuperado = true;
    //                 }

    //                 cnx.Close();

    //                 return Recuperado;
    //             }

    //         }
    //         catch (Exception e)
    //         {
    //             CajaDialogo.Error(e.Message);
    //             return false;
    //         }


    //     }
    // }


    public class NumeracionFiscal
    {
        public enum TipoDocumentoFiscal
        {
            Factura = 1,
            Nota_de_Debito = 2,
            Nota_de_Credito = 3,
            Retención = 4
        }

        public int ID { get; set; }
        public int PDV_ID { get; set; }
        public string PDV { get; set; }
        public string CAI { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaVence { get; set; }
        public string Numeracion_Inicial { get; set; }
        public string Numeracion_Final { get; set; }
        public string Estado { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy_ID { get; set; }
        public string CreatedBy { get; set; }
        public bool GenCorr { get; set; }
        public int Correlative { get; set; }
        public string Leyenda { get; set; }
        public int TipoDocID { get; set; }
        public string TipoDoc { get; set; }
        public int EstadoID { get; set; }
        public int PuntoVentaID { get; set; }
        public string PuntoVenta { get; set; }

        public bool Recuperado { get; set; }

        public bool GetIdNumeracionFiscalFromPuntoVentaId(int pidPuntoVenta, TipoDocumentoFiscal pTipoDocumentoActual)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP);

                cnx.Open();
                SqlCommand cmd = new SqlCommand("dbo.sp_get_numeracion_fiscal_from_punto_venta_tipo_doc_V3", cnx);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("@id_punto_venta", System.Data.SqlDbType.Int).Value = pidPuntoVenta;
                cmd.Parameters.Add("@id_tipo_doc", System.Data.SqlDbType.Int).Value = (int)pTipoDocumentoActual;

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    ID = dr.GetInt32(0);
                    Correlative = dr.GetInt32(1);
                    CAI = dr["CAI"].ToString();
                    TipoDocID = Convert.ToInt32(dr["tipo_doc_id"].ToString());
                    TipoDoc = dr["tipo_doc"].ToString();
                }
                cnx.Close();

                return true;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return false;
            }
        }

        public bool RecuperarRegistro(int id)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP);

                cnx.Open();
                SqlCommand cmd = new SqlCommand("uspGetNumeracionFiscalById", cnx);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    ID = id;
                    PDV_ID = dr.GetInt32(1);
                    PDV = dr.GetString(2);
                    CAI = dr.GetString(3);
                    FechaEmision = dr.GetDateTime(4);
                    FechaVence = dr.GetDateTime(5);
                    Numeracion_Inicial = dr.GetString(6);
                    Numeracion_Final = dr.GetString(7);
                    EstadoID = dr.GetInt32(8);
                    Estado = dr.GetString(9);
                    CreatedDate = dr.GetDateTime(10);
                    CreatedBy_ID = dr.GetInt32(11);
                    CreatedBy = dr.GetString(12);
                    TipoDocID = dr.GetInt32(13);
                    TipoDoc = dr.GetString(14);
                    GenCorr = dr.GetBoolean(15);
                    Correlative = dr.GetInt32(16);
                    Leyenda = dr.GetString(17);
                }
                cnx.Close();
                Recuperado = true;

                return true;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return false;
            }
        }

        public bool ValidaVencimientoNumeracionFiscal(int id_doc_fiscal)
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP);
                bool numeracion_fiscal_vencido = false;

                using (SqlCommand cmd = new SqlCommand("[dbo].[uspValidarVencimientoNumeracionFiscal]", cnx))
                {
                    cnx.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id_doc_fiscal", id_doc_fiscal);
                    //cmd.Parameters.Add("", tipo_documento_id);

                    numeracion_fiscal_vencido = Convert.ToBoolean(cmd.ExecuteScalar());

                    cnx.Close();

                }

                return numeracion_fiscal_vencido;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return false;
            }

        }
    }
}
