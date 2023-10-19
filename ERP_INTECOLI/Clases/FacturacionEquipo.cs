using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_INTECOLI.Clases
{
    public class FacturacionEquipo
    {
        public FacturacionEquipo() { }

        public int Id { get; set; }
        public string pc_name { get; set; }
        public int id_punto_venta { get; set; }
        public bool enable { get; set; }
        public int id_usuario { get; set; }
        public DateTime fecha { get; set; }
        public string descripcion { get; set; }
        public bool Recuperado { get; set; }


        public bool RecuperarRegistro(string pPC_Name)
        {
            Recuperado = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_equipo_punto_venta_from_services_tag_or_name", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name_pc", pPC_Name);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    pc_name = dr.GetString(1);
                    id_punto_venta = dr.GetInt32(2);
                    enable = dr.GetBoolean(3);
                    id_usuario = dr.GetInt32(4);
                    fecha = dr.GetDateTime(5);
                    descripcion = dr.GetString(6);
                    Recuperado = true;
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;
        }

    }
}
