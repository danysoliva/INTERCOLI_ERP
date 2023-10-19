using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_INTECOLI.Clases
{
    //internal class Notas_CreditoDebito
    //{
    //}


    public class Notas_CreditoDebito
    {
        public long ID { get; set; }
        public int PuntoDeVenta_ID { get; set; }
        public string PuntoDeVenta { get; set; }
        public string PuntoDeVenta_NombreLegal { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaDocumento { get; set; }
        public DateTime FechaLimite { get; set; }
        public string NumeroDocumento { get; set; }
        public int TipoNotaId { get; set; }
        public string TipoNota { get; set; }
        public string CAI { get; set; }
        public int ClienteId { get; set; }
        public string Cliente { get; set; }
        public string ClienteCod { get; set; }
        public string Concepto { get; set; }
        public string RTN { get; set; }
        public string RTN_PDV { get; set; }
        public string RangoAutorizado { get; set; }
        public string NumeroInicial { get; set; }
        public string NumeroFinal { get; set; }
        public string Observacion { get; set; }
        public string ValorLetras { get; set; }
        public long FacturaId { get; set; }
        public Decimal Credito { get; set; }
        public Decimal Debito { get; set; }

        public bool Recuperado { get; set; }

        public bool RecuperarRegistro(long id_nota)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP);
                NumberToLetters valorEnLetras = new NumberToLetters();
                cnx.Open();

                SqlCommand cmd = new SqlCommand("uspGetNotasById", cnx);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("@id_nota", id_nota);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    ID = Convert.ToInt64(dr["id"].ToString());
                    PuntoDeVenta_ID = Convert.ToInt32(dr["id_punto_venta"].ToString());
                    PuntoDeVenta = dr["nombre_local"].ToString();
                    PuntoDeVenta_NombreLegal = dr["nombre_legal"].ToString();
                    Telefono = dr["telefono"].ToString();
                    Correo = dr["correo"].ToString();
                    Direccion = dr["direccion"].ToString();
                    FechaDocumento = Convert.ToDateTime(dr["fecha_documento"].ToString());
                    NumeroDocumento = dr["num_documento"].ToString();
                    TipoNotaId = Convert.ToInt32(dr["id_tipo_nota"].ToString());
                    TipoNota = dr["tipo_nota"].ToString();
                    CAI = dr["cai"].ToString();
                    ClienteId = Convert.ToInt32(dr["id_cliente"].ToString());
                    Cliente = dr["cliente"].ToString();
                    ClienteCod = dr["codigo_cliente"].ToString();
                    Credito = Convert.ToDecimal(dr["credito"].ToString());
                    Debito = Convert.ToDecimal(dr["debito"].ToString());
                    FechaLimite = Convert.ToDateTime(dr["fecha_limite"].ToString());
                    Concepto = dr["concepto"].ToString();
                    RTN = dr["rtn"].ToString();
                    RTN_PDV = dr["rtn_pdv"].ToString();
                    //FacturaId = Convert.ToInt64(dr["factura_id"].ToString());
                    RangoAutorizado = dr["rango_autorizado"].ToString();
                    NumeroInicial = dr["numero_inicial"].ToString();
                    NumeroFinal = dr["numero_final"].ToString();
                    Observacion = dr["obs"].ToString();
                    ValorLetras = valorEnLetras.Convertir((Credito + Debito).ToString(), true);

                    Recuperado = true;
                }
                cnx.Close();

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
