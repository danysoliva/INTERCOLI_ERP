using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_INTECOLI.Clases
{
    //internal class Factura_SolicitudAutorizacion
    //{
    //}

    public class Factura_SolicitudAutorizacion
    {
        public long Id { get; set; }
        public int UsuarioSolicita_Id { get; set; }
        public string UsuarioSolicita { get; set; }
        public long FacturaId { get; set; }
        public int ClienteId { get; set; }
        public string Cliente { get; set; }
        public string Cliente_RTN { get; set; }
        public string PuntoDeVenta { get; set; }
        public int PuntoDeVenta_Id { get; set; }
        public int TipoAutorizacionID { get; set; }
        public string TipoAutorizacion { get; set; }
        public string Justificacion { get; set; }
        public string NumeroDocumento { get; set; }
        public int UsuarioAutoriza_Id { get; set; }
        public int TipoNotaId { get; set; }
        public string TipoNota { get; set; }
        public string UsuarioAutoriza { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int EstadoId { get; set; }
        public string Estado { get; set; }
        public List<FacturasSeleccionada> Facturas_seleccionadas { get; set; }
        public List<int> Clientes_Seleccionados { get; set; }

        public bool Recuperado { get; set; }


        public bool RecuperaRegistro(long IdSolicitud)
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP);

                using (SqlCommand cmd = new SqlCommand("dbo.uspGetSolicitudAutorizacionById", cnx))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id_solicitud", System.Data.SqlDbType.BigInt).Value = IdSolicitud;

                    cnx.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        Id = Convert.ToInt64(dr["id"].ToString());
                        FacturaId = Convert.ToInt64(dr["factura_id_H"].ToString());
                        ClienteId = Convert.ToInt32(dr["cliente_id"].ToString());
                        NumeroDocumento = dr["numero_documento"].ToString();
                        Cliente = dr["cliente"].ToString();
                        Cliente_RTN = dr["rtn_cliente"].ToString();
                        TipoAutorizacionID = Convert.ToInt32(dr["id_tipoAutorizacion"].ToString());
                        TipoAutorizacion = dr["tipo_autorizacion"].ToString();
                        PuntoDeVenta_Id = Convert.ToInt32(dr["id_pdv"].ToString());
                        PuntoDeVenta = dr["punto_venta"].ToString();
                        UsuarioAutoriza_Id = Convert.ToInt32(dr["usuario_autoriza_id"].ToString());
                        UsuarioAutoriza = dr["usuario_autoriza"].ToString();
                        UsuarioSolicita_Id = Convert.ToInt32(dr["id_usuario_solicita"].ToString());
                        UsuarioSolicita = dr["usuario_solicita"].ToString();
                        Justificacion = dr["justificacion"].ToString();
                        FechaCreacion = Convert.ToDateTime(dr["created_date"].ToString());
                        EstadoId = Convert.ToInt32(dr["estado_id"].ToString());
                        Estado = dr["estado"].ToString();
                        TipoNotaId = Convert.ToInt32(dr["id_tipo_nota"].ToString());
                        TipoNota = dr["tipo_nota"].ToString();

                    }
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

        public bool RechazarSolicitud_NotaCredito_NotaDebito(long id_solicitud, int estado_id, int user_id)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP);

                using (SqlCommand cmd = new SqlCommand("dbo.RechazarSolicitudNotaCreditoDebito", cnx))
                {
                    cnx.Open();

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@estado", SqlDbType.Int).Value = estado_id;
                    cmd.Parameters.Add("@id_solicitud", SqlDbType.BigInt).Value = id_solicitud;
                    cmd.Parameters.Add("@id_user", SqlDbType.Int).Value = user_id;
                    cmd.Parameters.Add("@FechaProceso", SqlDbType.DateTime).Value = DateTime.Now;

                    cmd.ExecuteNonQuery();

                    CajaDialogo.Information("La solicitud ha sido Rechazada");
                    cnx.Close();
                    return true;
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return false;
            }
        }


    }
    public class FacturasSeleccionada
    {
        public long FacturaId { get; set; }
        public int PuntoVenda_Id { get; set; }
        public string PuntoVenta { get; set; }
        public string NumeroFactura { get; set; }
        public decimal Monto { get; set; }
    }
}
