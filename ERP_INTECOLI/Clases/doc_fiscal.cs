using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_INTECOLI.Clases
{
    public class doc_fiscal
    {
        SqlConnection conn;
        DataOperations dp = new DataOperations();
        public int IdSecActiva { get; set; }
        public bool Recuperado { get; set; }
        public string rango_inicial { get; set; }
        public string rango_final { get; set; }
        public DateTime fecha_limite_aut { get; set; }
        public DateTime fecha_creado { get; set; }
        public DateTime fecha_autorizado { get; set; }
        public string cai { get; set; }
        public bool habilitado { get; set; }
        public string leyenda { get; set; }
        public int id_sig { get; set; }
        public string NumeroFactura { get; set; }

        public doc_fiscal()
        {
            
        }

        public bool CargarDatosFacturaSiguiente()
        {
            try
            {
                //Comentarios
                //string sql = @"	SELECT  rango_inicial,
                //                        rango_final,
                //                        fecha_limite_aut,
                //                        fecha_creado,
                //                        fecha_autorizado,
                //                        cai,
                //                        habilitado,
                //                        leyenda,
                //                        id_sig,
                //                        id
                //                FROM admon.documentos_config cc
                //                where habilitado and 
                //cc.id_tipo_doc = 1;";
                string sql = @"sp_get_datos_facturas_siguientes";

                conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    rango_inicial = dr.GetString(0);
                    rango_final = dr.GetString(1);
                    fecha_limite_aut = dr.GetDateTime(2);
                    fecha_creado = dr.GetDateTime(3);
                    fecha_autorizado = dr.GetDateTime(4);
                    cai = dr.GetString(5);
                    habilitado = dr.GetBoolean(6);
                    leyenda = dr.GetString(7);
                    id_sig = dr.GetInt32(8);
                    IdSecActiva = dr.GetInt32(9);
                    NumeroFactura = id_sig.ToString();
                    while (NumeroFactura.Length < 8)
                    {
                        NumeroFactura = "0" + NumeroFactura;
                    }
                    NumeroFactura = leyenda + NumeroFactura.Trim();
                    Recuperado = true;
                    dr.Close();
                }
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;
        }

        public bool UpdateSecuencia()
        {
            bool val = false;
            try
            {
                //string sql = @"UPDATE admon.documentos_config 
                //                SET id_sig = id_sig + 1 
                //                WHERE id = " + IdSecActiva;
                string sql = @"sp_update_secuencia_factura";
                conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdSecActiva", IdSecActiva);
                cmd.ExecuteNonQuery();
                val = true;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return val;
        }


    }
}
