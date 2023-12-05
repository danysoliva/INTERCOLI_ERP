using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_INTECOLI.Clases
{
    public class FacturaProveedores
    {
        bool recuperado;
        int id_Factura;
        int id_orden_compra;
        string code_prov;
        string proveedor;
        string persona_contacto;
        string direccion;
        string cai;
        string num_Factura;
        DateTime fecha_Contabilizacion;
        DateTime fecha_Vencimiento;
        DateTime fecha_Documento;
        int id_Estado;
        string estado;
        int id_Usuario;
        string usuario_creador;
        string comentario;
        int punto_Venta;
        decimal subtotal;
        decimal impuesto;
        decimal total;
        string docNum;

        public bool Recuperado { get => recuperado; set => recuperado = value; }
        public int Id_Factura { get => id_Factura; set => id_Factura = value; }
        public int Id_orden_compra { get => id_orden_compra; set => id_orden_compra = value; }
        public string Code_prov { get => code_prov; set => code_prov = value; }
        public string Proveedor { get => proveedor; set => proveedor = value; }
        public string Persona_contacto { get => persona_contacto; set => persona_contacto = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Cai { get => cai; set => cai = value; }
        public string Num_Factura { get => num_Factura; set => num_Factura = value; }
        public DateTime Fecha_Contabilizacion { get => fecha_Contabilizacion; set => fecha_Contabilizacion = value; }
        public DateTime Fecha_Vencimiento { get => fecha_Vencimiento; set => fecha_Vencimiento = value; }
        public DateTime Fecha_Documento { get => fecha_Documento; set => fecha_Documento = value; }
        public int Id_Estado { get => id_Estado; set => id_Estado = value; }
        public string Estado { get => estado; set => estado = value; }
        public int Id_Usuario { get => id_Usuario; set => id_Usuario = value; }
        public string Usuario_creador { get => usuario_creador; set => usuario_creador = value; }
        public string Comentario { get => comentario; set => comentario = value; }
        public int Punto_Venta { get => punto_Venta; set => punto_Venta = value; }
        public decimal Subtotal { get => subtotal; set => subtotal = value; }
        public decimal Impuesto { get => impuesto; set => impuesto = value; }
        public decimal Total { get => total; set => total = value; }
        public string DocNum { get => docNum; set => docNum = value; }

        public bool Recuperar_FacturaProveedor(int id_fact)
        {
            Recuperado = false;
            try
            {//Recupera las caracteristicas 
                string sql = @"sp_compras_get_factura_class";
                DataOperations dp = new DataOperations();

                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_factura", id_fact);
                SqlDataReader dl = cmd.ExecuteReader();
                if (dl.Read())
                {

                    Id_Factura = dl.GetInt32(0);
                    Id_orden_compra = dl.GetInt32(1);
                    Code_prov = dl.GetString(2);
                    Proveedor = dl.GetString(3);
                    Persona_contacto = dl.GetString(4);
                    Direccion = dl.GetString(5);
                    Cai = dl.GetString(6);
                    Num_Factura = dl.GetString(7);
                    Fecha_Contabilizacion = dl.GetDateTime(8);
                    Fecha_Vencimiento = dl.GetDateTime(9);
                    fecha_Documento = dl.GetDateTime(10);
                    //fecha_registro = dl.IsDBNull(11) ? DBNull.Value : dl.GetDateTime(11);
                    Id_Estado = dl.IsDBNull(7) ? 0 : dl.GetInt32(12);
                    Estado = dl.GetString(13);
                    Id_Usuario = dl.IsDBNull(14) ? 0 : dl.GetInt32(14);
                    Usuario_creador = dl.IsDBNull(15) ? "" : dl.GetString(15);
                    Comentario = dl.IsDBNull(16) ? "" : dl.GetString(16);
                    Punto_Venta = dl.IsDBNull(17) ? 0 : dl.GetInt32(17);
                    Subtotal = dl.IsDBNull(18) ? 0 : dl.GetDecimal(18);
                    Impuesto = dl.IsDBNull(19) ? 0 : dl.GetDecimal(19);
                    Total = dl.IsDBNull(20) ? 0 : dl.GetDecimal(20);
                    DocNum = dl.IsDBNull(21) ? "0" : dl.GetString(21);
                    Recuperado = true;

                }
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
