using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_INTECOLI.Clases
{
    public class Solicitud
    {

        //Properties
        private DateTime fecha_registro;
        private DateTime fecha_contabilizacion;
        private string itemcode;
        private string descripcion;
        private Decimal cantidad;
        private Decimal precio;
        private int id_estado;
        private string estado;
        private bool recueprado;
        private int id_solicitud;
        private int id_user_crea;
        private string comentario;
        private string usuario;

        public DateTime Fecha_registro { get => fecha_registro; set => fecha_registro = value; }
        public DateTime Fecha_contabilizacion { get => fecha_contabilizacion; set => fecha_contabilizacion = value; }
        public string Itemcode { get => itemcode; set => itemcode = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public decimal Cantidad { get => cantidad; set => cantidad = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public int Id_estado { get => id_estado; set => id_estado = value; }
        public string Estado { get => estado; set => estado = value; }
        public bool Recueprado { get => recueprado; set => recueprado = value; }
        public int Id_solicitud { get => id_solicitud; set => id_solicitud = value; }
        public int Id_user_crea { get => id_user_crea; set => id_user_crea = value; }
        public string Comentario { get => comentario; set => comentario = value; }
        public string Usuario { get => usuario; set => usuario = value; }

        public bool RecuperarRegistros(int pidH)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_solicitudes_clase", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idh", pidH);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id_solicitud = dr.GetInt32(0);
                    Id_user_crea = dr.GetInt32(1);
                    Usuario = dr.GetString(2);
                    Id_estado = dr.GetInt32(3);
                    Estado = dr.GetString(4);
                    Fecha_registro = dr.GetDateTime(5);
                    Fecha_contabilizacion = dr.GetDateTime(6);
                    Comentario = dr.GetString(7);

                    dr.Close();

                    Recueprado = true;
                }

                dr.Close();
                con.Close();
            }
            catch (Exception eec)
            {
                CajaDialogo.Error(eec.Message);
            }
            return Recueprado;
        
        }
    }
}
