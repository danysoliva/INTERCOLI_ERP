using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_INTECOLI.Clases
{
    public class PuntoVentaEquipo
    {
        public int Id { get; set; }
        public string PcName { get; set; }
        public int IdPuntoVenta { get; set; }
        public bool Enable { get; set; }
        public int IdUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public int IdUserAsigned { get; set; }
        public string IpAddress { get; set; }
        public string Usuario_Asigno { get; set; }
        public string Usuario_Asignado { get; set; }
        public string RepuestaValidacion { get; set; }

        public bool Recuperado { get; set; }
        DataOperations dp;

        // Constructor vacío
        public PuntoVentaEquipo()
        {
            dp = new DataOperations();
        }

        // Constructor con parámetros
        public PuntoVentaEquipo(string pcName, int idPuntoVenta, bool enable, int idUsuario, DateTime fecha, string descripcion, int idUserAsigned, string ipAddress)
        {
            dp = new DataOperations();
            PcName = pcName;
            IdPuntoVenta = idPuntoVenta;
            Enable = enable;
            IdUsuario = idUsuario;
            Fecha = fecha;
            Descripcion = descripcion;
            IdUserAsigned = idUserAsigned;
            IpAddress = ipAddress;
        }

        // Método para cargar registros desde la base de datos
        public bool RecuperarRegistro(int id)
        {
            Recuperado = false;
            string connectionString = dp.ConnectionStringERP; // Reemplaza con tu cadena de conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"dbo.sp_get_equipo_punto_venta";
                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id_equipo", id);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    Id = (int)reader["id"];

                    if (!reader.IsDBNull(reader.GetOrdinal("pc_name")))
                        PcName = reader["pc_name"].ToString();

                    if (!reader.IsDBNull(reader.GetOrdinal("id_punto_venta")))
                        IdPuntoVenta = (int)reader["id_punto_venta"];

                    if (!reader.IsDBNull(reader.GetOrdinal("enable")))
                        Enable = (bool)reader["enable"];

                    if (!reader.IsDBNull(reader.GetOrdinal("id_usuario")))
                        IdUsuario = (int)reader["id_usuario"];

                    if (!reader.IsDBNull(reader.GetOrdinal("Usuario Asignó")))
                        Usuario_Asigno = reader["Usuario Asignó"].ToString();

                    if (!reader.IsDBNull(reader.GetOrdinal("fecha")))
                        Fecha = (DateTime)reader["fecha"];

                    if (!reader.IsDBNull(reader.GetOrdinal("descripcion")))
                        Descripcion = reader["descripcion"].ToString();

                    if (!reader.IsDBNull(reader.GetOrdinal("id_user_asigned")))
                        IdUserAsigned = (int)reader["id_user_asigned"];

                    if (!reader.IsDBNull(reader.GetOrdinal("Usuario Asignado")))
                        Usuario_Asignado = reader["Usuario Asignado"].ToString();

                    if (!reader.IsDBNull(reader.GetOrdinal("ip_address")))
                        IpAddress = reader["ip_address"].ToString();
                    Recuperado = true;
                }
                reader.Close();
            }
            return Recuperado;
        }

        // Método para insertar un nuevo registro en la base de datos
        public int InsertarNewRow()
        {
            int IdInserted = 0;
            string connectionString = dp.ConnectionStringERP; // Reemplaza con tu cadena de conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"INSERT INTO [dbo].[Facturacion_PuntoVenta_Equipos] 
                                            ([pc_name], [id_punto_venta], [enable], 
                                            [id_usuario], [fecha], [descripcion], 
                                            [id_user_asigned], [ip_address]) 
                                VALUES (@PcName, @IdPuntoVenta, @Enable, @IdUsuario, 
                                        @Fecha, @Descripcion, @IdUserAsigned, @IpAddress); SELECT SCOPE_IDENTITY();";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PcName", PcName);
                command.Parameters.AddWithValue("@IdPuntoVenta", IdPuntoVenta);
                command.Parameters.AddWithValue("@Enable", Enable);
                command.Parameters.AddWithValue("@IdUsuario", IdUsuario);
                command.Parameters.AddWithValue("@Fecha", Fecha);

                if (string.IsNullOrEmpty(Descripcion))
                    command.Parameters.AddWithValue("@Descripcion", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@Descripcion", Descripcion);


                command.Parameters.AddWithValue("@IdUserAsigned", IdUserAsigned);

                if (string.IsNullOrEmpty(IpAddress))
                    command.Parameters.AddWithValue("@IpAddress", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@IpAddress", IpAddress);

                this.Id = IdInserted = Convert.ToInt32(command.ExecuteScalar());
            }
            return IdInserted;
        }

        // Método para actualizar un registro en la base de datos
        public bool ActualizarRow()
        {
            bool updated = false;
            string connectionString = dp.ConnectionStringERP; // Reemplaza con tu cadena de conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE [dbo].[Facturacion_PuntoVenta_Equipos] " +
                               "       SET [pc_name] = @PcName, " +
                               "           [id_punto_venta] = @IdPuntoVenta, [enable] = @Enable, " +
                               "           [id_usuario] = @IdUsuario, [fecha] = @Fecha, " +
                               "           [descripcion] = @Descripcion, [id_user_asigned] = @IdUserAsigned, " +
                               "           [ip_address] = @IpAddress WHERE [id] = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", Id);
                command.Parameters.AddWithValue("@PcName", PcName);
                command.Parameters.AddWithValue("@IdPuntoVenta", IdPuntoVenta);
                command.Parameters.AddWithValue("@Enable", Enable);
                command.Parameters.AddWithValue("@IdUsuario", IdUsuario);
                command.Parameters.AddWithValue("@Fecha", Fecha);

                if (string.IsNullOrEmpty(Descripcion))
                    command.Parameters.AddWithValue("@Descripcion", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@Descripcion", Descripcion);

                if (IdUserAsigned == 0)
                    command.Parameters.AddWithValue("@IdUserAsigned", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@IdUserAsigned", IdUserAsigned);

                if (string.IsNullOrEmpty(IpAddress))
                    command.Parameters.AddWithValue("@IpAddress", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@IpAddress", IpAddress);

                command.ExecuteNonQuery();
                updated = true;
            }
            return updated;
        }

        public string validarEquipoEnOtroPDV(string pc_name)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP);
                bool validacion1 = false;
                bool validacion2 = false;
                RepuestaValidacion = "";



                cnx.Open();
                SqlCommand cmd = new SqlCommand("uspValidarEquipoEnVariosPDV", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@equipo", pc_name);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    validacion1 = Convert.ToBoolean(dr["validacion1"].ToString());
                    validacion2 = Convert.ToBoolean(dr["validacion2"].ToString());
                }
                cnx.Close();

                if (validacion1 == true)
                {
                    RepuestaValidacion = "Este equipo ya esta configurado para este punto de venta";
                }
                else
                if (validacion2 == true)
                {
                    RepuestaValidacion = "Este equipo ya esta configurado en otro punto de venta";
                }


                return RepuestaValidacion;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return "";
            }
        }
    }
}
