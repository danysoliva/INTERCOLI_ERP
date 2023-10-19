using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_INTECOLI.Clases;

namespace JAGUAR_APP.Facturacion.Mantenimientos.Models
{
   public class ClienteFacturacion
    {
        public int Id { get; set; }
        public string NombreCliente { get; set; }
        public string NombreCorto { get; set; }
        public string Codigo { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public int UsuarioModificacion { get; set; }
        public int UsuarioCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool ENABLE { get; set; }
        public bool Recuperado { get; set; }



        public ClienteFacturacion()
        {

        }


        public void ClearClass()
        {
            Id = 0;
            this.NombreCliente = "";
            this.NombreCorto = "";
            this.Codigo = "";
            this.Direccion = "";
            this.Correo = "";
            this.Telefono = "";
            this.UsuarioModificacion = 0;
            this.UsuarioCreacion = 0;
            this.FechaModificacion = DateTime.Now;
            this.FechaCreacion = DateTime.Now;
            this.ENABLE = false;
        }

        public bool RecuperarRegistro(int pIDCliente)
        {
            Recuperado = false;
            DataOperations dp = new DataOperations();
            SqlConnection connection = new SqlConnection(dp.ConnectionStringERP);

            //Por la premura del cliente hare una excepcion de hacer un Store Procedure
            //Pero en la proxima modificacion de esta clase debe modificarse *** Danys Oliva ***
            string query = "SELECT * FROM [dbo].[Facturacion_Cliente] WHERE IdCliente = @IdCliente";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IdCliente", pIDCliente);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                if (reader.Read())
                {
                    Id = (int)reader["IdCliente"];
                    NombreCliente = reader["NombreCliente"].ToString();

                    if (!reader.IsDBNull(reader.GetOrdinal("NombreCorto")))
                        NombreCorto = reader["NombreCorto"].ToString();
                    if (!reader.IsDBNull(reader.GetOrdinal("Direccion")))
                        Direccion = reader["Direccion"].ToString();
                    if (!reader.IsDBNull(reader.GetOrdinal("ENABLE")))
                        ENABLE = (bool)reader["ENABLE"];
                    if (!reader.IsDBNull(reader.GetOrdinal("FechaCreacion")))
                        FechaCreacion = (DateTime)reader["FechaCreacion"];
                    if (!reader.IsDBNull(reader.GetOrdinal("UsuarioCreacion")))
                        UsuarioCreacion = (int)reader["UsuarioCreacion"];
                    if (!reader.IsDBNull(reader.GetOrdinal("FechaModificacion")))
                        FechaModificacion = (DateTime)reader["FechaModificacion"];
                    if (!reader.IsDBNull(reader.GetOrdinal("UsuarioModificacion")))
                        UsuarioModificacion = (int)reader["UsuarioModificacion"];
                    Codigo = reader["codigo"].ToString();
                    if (!reader.IsDBNull(reader.GetOrdinal("Telefono")))
                        Telefono = reader["Telefono"].ToString();
                    if (!reader.IsDBNull(reader.GetOrdinal("Correo")))
                        Correo = reader["Correo"].ToString();

                    Recuperado = true;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error("Error en la clase: ClienteEmpresa, Error MSJ: " + ex.Message);
            }
            return Recuperado;
        }

       
    }
}
