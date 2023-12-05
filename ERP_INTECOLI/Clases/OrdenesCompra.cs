using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_INTECOLI.Clases
{
    public class OrdenesCompra
    {
        bool recuperado;
        int id_OrdenCompra;
        int id_Solicitud;
        string itemcode_Prov;
        string nombre_Prov;
        int id_Estado;
        string estado;
        DateTime fecha_Registro;
        DateTime fecha_Contabilizacion;
        string direccion;
        string comentario;
        decimal impuesto;
        decimal subtotal;
        decimal total;
        int id_UserCrea;
        string usuario_Cre;
        int id_UserModi;
        string usuario_Modi;
        DateTime fecha_Modi;
        int id_PuntoVenta;
        string DocNum;

        public bool Recuperado { get => recuperado; set => recuperado = value; }
        public int Id_OrdenCompra { get => id_OrdenCompra; set => id_OrdenCompra = value; }
        public int Id_Solicitud { get => id_Solicitud; set => id_Solicitud = value; }
        public string Itemcode_Prov { get => itemcode_Prov; set => itemcode_Prov = value; }
        public string Nombre_Prov { get => nombre_Prov; set => nombre_Prov = value; }
        public int Id_Estado { get => id_Estado; set => id_Estado = value; }
        public string Estado { get => estado; set => estado = value; }
        public DateTime Fecha_Registro { get => fecha_Registro; set => fecha_Registro = value; }
        public DateTime Fecha_Contabilizacion { get => fecha_Contabilizacion; set => fecha_Contabilizacion = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Comentario { get => comentario; set => comentario = value; }
        public decimal Impuesto { get => impuesto; set => impuesto = value; }
        public decimal Subtotal { get => subtotal; set => subtotal = value; }
        public decimal Total { get => total; set => total = value; }
        public int Id_UserCrea { get => id_UserCrea; set => id_UserCrea = value; }
        public string Usuario_Cre { get => usuario_Cre; set => usuario_Cre = value; }
        public int Id_UserModi { get => id_UserModi; set => id_UserModi = value; }
        public string Usuario_Modi { get => usuario_Modi; set => usuario_Modi = value; }
        public DateTime Fecha_Modi { get => fecha_Modi; set => fecha_Modi = value; }
        public int Id_PuntoVenta { get => id_PuntoVenta; set => id_PuntoVenta = value; }
        public string DocNum1 { get => DocNum; set => DocNum = value; }

        public bool RecuperarRegistos(int pIdOrdenCompra) 
        {
            Recuperado = false;
            try
            {
                DataOperations dp = new DataOperations();
                string query = @"sp_get_orden_compra_class";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringERP);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_ordencompra", pIdOrdenCompra);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id_OrdenCompra = (int)(dr.IsDBNull(dr.GetOrdinal("id")) ? 0 : (int)dr.GetInt32(dr.GetOrdinal("id")));
                    Id_Solicitud = (int)(dr.IsDBNull(dr.GetOrdinal("id_solicitud")) ? 0 : (int)dr.GetInt32(dr.GetOrdinal("id_solicitud")));
                    Itemcode_Prov = dr.IsDBNull(dr.GetOrdinal("code_prov")) ? "N/D" : dr.GetString(dr.GetOrdinal("code_prov"));
                    Nombre_Prov = dr.IsDBNull(dr.GetOrdinal("proveedor")) ? "N/D" : dr.GetString(dr.GetOrdinal("proveedor"));
                    Id_Estado = (int)(dr.IsDBNull(dr.GetOrdinal("id_estado")) ? 0 : (int)dr.GetInt32(dr.GetOrdinal("id_estado")));
                    Estado = dr.IsDBNull(dr.GetOrdinal("estado")) ? "" : dr.GetString(dr.GetOrdinal("estado"));
                    Fecha_Registro = dr.GetDateTime(6);
                    Fecha_Contabilizacion = dr.GetDateTime(7);
                    Direccion = dr.IsDBNull(dr.GetOrdinal("direccion")) ? "" : dr.GetString(dr.GetOrdinal("direccion"));
                    Comentario = dr.IsDBNull(dr.GetOrdinal("comentario")) ? "" : dr.GetString(dr.GetOrdinal("comentario"));
                    Impuesto = (decimal)(dr.IsDBNull(dr.GetOrdinal("impuesto")) ? 0 : (decimal?)dr.GetDecimal(dr.GetOrdinal("impuesto")));
                    Subtotal = (decimal)(dr.IsDBNull(dr.GetOrdinal("subtotal")) ? 0 : (decimal?)dr.GetDecimal(dr.GetOrdinal("subtotal")));
                    Total = (decimal)(dr.IsDBNull(dr.GetOrdinal("total")) ? 0 : (decimal?)dr.GetDecimal(dr.GetOrdinal("total")));
                    Id_UserCrea = dr.GetOrdinal("id_user_cre");
                    Usuario_Cre = dr.GetOrdinal("usuario_cre").ToString();
                    Id_UserModi = (int)(dr.IsDBNull(dr.GetOrdinal("id_user_modi")) ? 0 : (int)dr.GetInt32(dr.GetOrdinal("id_user_modi")));
                    Usuario_Modi = dr.IsDBNull(dr.GetOrdinal("usuario_Modi")) ? "" : dr.GetString(dr.GetOrdinal("usuario_Modi"));
                    if (!dr.IsDBNull(dr.GetOrdinal("fecha_modi")))
                        Fecha_Modi = dr.GetDateTime(17);
                    Id_PuntoVenta = dr.GetInt32(18);
                    DocNum1 = dr.GetString(19);
                    Recuperado = true;
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                Recuperado = false;
                CajaDialogo.Error(ex.Message);
            }

            return Recuperado;
        }
    }
}
