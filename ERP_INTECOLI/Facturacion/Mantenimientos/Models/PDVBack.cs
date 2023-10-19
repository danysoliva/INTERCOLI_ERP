using ERP_INTECOLI.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_APP.Facturacion.Mantenimientos.Models
{
   public class PDVBack
    {
        public int ID { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int DepartamentoID { get; set; }
        public string Departamento { get; set; }
        public int CiudadID { get; set; }
        public string    Ciudad { get; set; }
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
        public bool BloqueoPorFaltaStock { get; set; }
        public bool PermiteAnulacionConAutorizacion { get; set; }
        public bool ConteoPrintFactura { get; set; }
        public bool PermiteReimpresionFacturaConAutorizacion { get; set; }
        public bool EmisionFacturaDosPasos { get; set; }
        public bool FacturaComidaBuffet { get; set; }
        public bool Recuperado { get; set; }
        


        public bool RecuperaRegistro(int pdv)
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP);

                using (SqlCommand cmd = new SqlCommand("dbo.uspGetPDVById",cnx))
                {
                    cnx.Open();

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = pdv;

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
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
