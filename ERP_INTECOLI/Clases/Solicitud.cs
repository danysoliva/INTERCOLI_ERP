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



        public bool RecuperarRegistros(int pidH)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();

                SqlCommand cmd = new SqlCommand("", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idh", pidH);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    //IdH_Solicitud = dr.GetInt32(0);
                    //DocEntry = dr.GetInt32(1);
                    //DocNum = dr.GetInt32(2);
                    //Canceled = Convert.ToChar(dr.GetString(3));
                    //DocStatus = Convert.ToChar(dr.GetString(4));
                    //DocDate = dr.GetDateTime(5);
                    //TaxDate = dr.GetDateTime(6);
                    //iTipoOrdenAMS = dr.GetInt32(7);
                    //DescripcionTipoOrdenAMS = dr.GetString(8);
                    //U_TipoOrden = Convert.ToInt32(dr.GetString(9));
                    //DocStatusDescripcion = dr.GetString(10);
                    //ReqName = dr.GetString(11);
                    //RequesterUser = dr.GetString(12);
                    //Tracking = dr.GetBoolean(13);
                    //Pproyecto = dr.IsDBNull(14) ? "" : dr.GetString(14);
                    //coment = dr.IsDBNull(15) ? "" : dr.GetString(15);
                    //IdOrdenTrabajo = dr.IsDBNull(16) ? 0 : dr.GetInt64(16);
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
