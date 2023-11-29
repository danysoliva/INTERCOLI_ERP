using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_INTECOLI.Clases
{
    //internal class Proveedor
    //{
    //}

    public class Proveedor
    {
        public string Codigo;
        public string Nombre;
        public string NombreF;
        public string RTN;
        public string Contacto;
        public string Telefono1;
        public string Telefono2;
        public string Telefono3;
        public string Direccion;
        public string Correo;
        public bool Recuperado;
        public int IdRiesgo;
        public bool Auditoria;
        public int IdAprobacion;
        

        private int id;
        public string _codigo;
        public string _nombre;
        public string _RTN;
        public string _direccion;
        public bool _enable;

        public int ID { get => id; set => id = value; }

        public Proveedor()
        {
            id = 0;
        }


        public bool RecuperarRegistro(int pidProveedor)
        {
            Recuperado = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_proveedor_by_id", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_proveedor", pidProveedor);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    ID = dr.GetInt32(0);
                    _codigo = dr.GetString(1);
                    _nombre = dr.GetString(2);

                    if (!dr.IsDBNull(dr.GetOrdinal("RTN")))
                        _RTN = dr.GetString(3);

                    if (!dr.IsDBNull(dr.GetOrdinal("direccion")))
                        _direccion = dr.GetString(4);

                    if (!dr.IsDBNull(dr.GetOrdinal("enable")))
                        _enable = dr.GetBoolean(5);
                    if (!dr.IsDBNull(dr.GetOrdinal("contacto")))
                        Contacto = dr.GetString(6);
                    if (!dr.IsDBNull(dr.GetOrdinal("telefono")))
                        Telefono1 = dr.GetString(7);
                    Recuperado = true;
                }
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

            return Recuperado;
        }

        public bool RecuperarRegistroFromItemCode(string pItemCode)
        {
            Recuperado = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_get_proveedor_by_ItemCode]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ItemCode", pItemCode.Trim());
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    ID = dr.GetInt32(0);
                    _codigo = dr.GetString(1);
                    _nombre = dr.GetString(2);

                    if (!dr.IsDBNull(dr.GetOrdinal("RTN")))
                        _RTN = dr.GetString(3);

                    if (!dr.IsDBNull(dr.GetOrdinal("direccion")))
                        _direccion = dr.GetString(4);

                    if (!dr.IsDBNull(dr.GetOrdinal("enable")))
                        _enable = dr.GetBoolean(5);
                    if (!dr.IsDBNull(dr.GetOrdinal("contacto")))
                        Contacto = dr.GetString(6);
                    if (!dr.IsDBNull(dr.GetOrdinal("telefono")))
                        Telefono1 = dr.GetString(7);

                    Recuperado = true;
                }
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
