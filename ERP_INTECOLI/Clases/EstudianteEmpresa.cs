using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_INTECOLI.Clases
{
    //internal class EstudianteEmpresa
    //{
    //}
    public class EstudianteEmpresa
    {
        public EstudianteEmpresa() { }

        //public int Id { get; set; }
        public int IdEmpresa { get; set; }
        public Int64 IdEstudiante { get; set; }
        public string NombreLargo { get; set; }
        //public string NombreCorto { get; set; }
        //public string Codigo { get; set; }
        public string RTN { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public int UsuarioModificacion { get; set; }
        public int UsuarioCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Recuperado { get; set; }
        //public bool ENABLE { get; set; }

        public bool RecuperarRegistro(int pidEmpresa, Int64 pIdEstudiante)
        {
            Recuperado = false;
            DataOperations dp = new DataOperations();
            SqlConnection connection = new SqlConnection(dp.ConnectionStringERP);
            //Por la premura del cliente hare una excepcion de hacer un Store Procedure
            //Pero en la proxima modificacion de esta clase debe modificarse *** Danys Oliva ***
            string query = @"SELECT [id_empresa] as IdEmpresa
	                                  ,A.id_estudiante 
	                                  ,B.nombre as NombreLargo
	                                  ,isnull(B.direccion, 'N/D') as Direccion
                                      ,A.[rtn] as RTN
                              FROM [Success].[dbo].[detalle_rtn]A
		                            left join [Success].[dbo].[empresa]B
		                            on A.id_empresa = B.id
                              where A.enable = 1
		                            and A.id_estudiante = @id_estudiante
		                            and A.id_empresa = @IdEmpresa";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IdEmpresa", pidEmpresa);
            command.Parameters.AddWithValue("@id_estudiante", pIdEstudiante);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                if (reader.Read())
                {
                    IdEmpresa = (int)reader["IdEmpresa"];
                    //Id = (int)reader["IdCliente"];
                    //IdEstudiante = (Int64)reader["id_estudiante"];
                    IdEstudiante = pIdEstudiante;
                    NombreLargo = reader["NombreLargo"].ToString();
                    //if (!reader.IsDBNull(reader.GetOrdinal("NombreCorto")))
                    //    NombreCorto = reader["NombreCorto"].ToString();
                    if (!reader.IsDBNull(reader.GetOrdinal("Direccion")))
                        Direccion = reader["Direccion"].ToString();

                    if (!reader.IsDBNull(reader.GetOrdinal("RTN")))
                        RTN = reader["RTN"].ToString();

                    //if (!reader.IsDBNull(reader.GetOrdinal("ENABLE")))
                    //    ENABLE = (bool)reader["ENABLE"];
                    //if (!reader.IsDBNull(reader.GetOrdinal("FechaCreacion")))
                    //    FechaCreacion = (DateTime)reader["FechaCreacion"];
                    //if (!reader.IsDBNull(reader.GetOrdinal("UsuarioCreacion")))
                    //    UsuarioCreacion = (int)reader["UsuarioCreacion"];
                    //if (!reader.IsDBNull(reader.GetOrdinal("FechaModificacion")))
                    //    FechaModificacion = (DateTime)reader["FechaModificacion"];
                    //if (!reader.IsDBNull(reader.GetOrdinal("UsuarioModificacion")))
                    //    UsuarioModificacion = (int)reader["UsuarioModificacion"];
                    //if (!reader.IsDBNull(reader.GetOrdinal("telefono")))
                    //    Telefono = reader["telefono"].ToString();
                    //if (!reader.IsDBNull(reader.GetOrdinal("correo")))
                    //    Correo = reader["correo"].ToString();
                    //if (!reader.IsDBNull(reader.GetOrdinal("codigo")))
                    //    Codigo = reader["codigo"].ToString();
                    Recuperado = true;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error("Error en la clase: ClienteFacturacion, Error MSJ: " + ex.Message);
            }

            return Recuperado;
        }

    }
}
