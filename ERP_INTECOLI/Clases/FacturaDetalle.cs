using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_INTECOLI.Clases
{
    //internal class FacturaDetalle
    //{
    //}
    public class FacturaDetalle
    {
        public long Id { get; set; }
        public long IdFacturaH { get; set; }
        public int IdPt { get; set; }
        public string ItemCode { get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Descuento { get; set; }
        public decimal Impuesto1 { get; set; }
        public decimal Impuesto2 { get; set; }
        public decimal Impuesto3 { get; set; }
        public decimal TotalLinea { get; set; }
        public bool Enable { get; set; }
        public bool Recuperado { get; set; }
        DataOperations Dp;

        public FacturaDetalle()
        {
            Dp = new DataOperations();
        }


        public bool RecuperarRegistro(Int64 pIdDetalle)
        {
            bool success = false;

            string connectionString = Dp.ConnectionStringERP;
            string query = "dbo.sp_get_factura_detalle_class_from_id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@pIdDetalle", pIdDetalle);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            Id = reader.GetInt64(reader.GetOrdinal("id"));
                            IdFacturaH = (long)(reader.IsDBNull(reader.GetOrdinal("id_facturaH")) ? 0 : (long?)reader.GetInt64(reader.GetOrdinal("id_facturaH")));
                            IdPt = (int)(reader.IsDBNull(reader.GetOrdinal("id_pt")) ? 0 : (int?)reader.GetInt32(reader.GetOrdinal("id_pt")));
                            ItemCode = reader.IsDBNull(reader.GetOrdinal("item_code")) ? "N/D" : reader.GetString(reader.GetOrdinal("item_code"));
                            Descripcion = reader.IsDBNull(reader.GetOrdinal("descripcion")) ? "N/D" : reader.GetString(reader.GetOrdinal("descripcion"));
                            Cantidad = (decimal)(reader.IsDBNull(reader.GetOrdinal("cantidad")) ? 0 : (decimal?)reader.GetDecimal(reader.GetOrdinal("cantidad")));
                            Precio = (decimal)(reader.IsDBNull(reader.GetOrdinal("precio")) ? 0 : (decimal?)reader.GetDecimal(reader.GetOrdinal("precio")));
                            Descuento = (decimal)(reader.IsDBNull(reader.GetOrdinal("descuento")) ? 0 : (decimal?)reader.GetDecimal(reader.GetOrdinal("descuento")));
                            Impuesto1 = (decimal)(reader.IsDBNull(reader.GetOrdinal("impuesto1")) ? 0 : (decimal?)reader.GetDecimal(reader.GetOrdinal("impuesto1")));
                            Impuesto2 = (decimal)(reader.IsDBNull(reader.GetOrdinal("impuesto2")) ? 0 : (decimal?)reader.GetDecimal(reader.GetOrdinal("impuesto2")));
                            Impuesto3 = (decimal)(reader.IsDBNull(reader.GetOrdinal("impuesto3")) ? 0 : (decimal?)reader.GetDecimal(reader.GetOrdinal("impuesto3")));
                            TotalLinea = (decimal)(reader.IsDBNull(reader.GetOrdinal("total_linea")) ? 0 : (decimal?)reader.GetDecimal(reader.GetOrdinal("total_linea")));
                            Enable = (bool)(reader.IsDBNull(reader.GetOrdinal("enable")) ? false : (bool?)reader.GetBoolean(reader.GetOrdinal("enable")));

                            success = true;
                        }
                        reader.Close();
                    }
                }
            }
            Recuperado = success;
            return success;
        }
    }


}
