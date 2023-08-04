using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ERP_INTECOLI.Clases;
using System.Data;

namespace ERP_INTECOLI.Clases
{
    class Estudiante
    {
        public Int64 IdEstudiante;
        public string identidad;
        public string Nombres;
        public string Apellidos;
        public string Direccion;
        public DateTime FechaNacimiento;
        public DateTime FechaIngreso;
        public bool Habilitado;
        public bool Reingreso_Retiro;
        public bool Graduado;
        public bool Desertor;
        public int id_tipo_retiro;
        public int IdNivelIngreso;
        public string Sexo;
        public string Correo;
        public bool Recuperado;
        public DateTime FechaProximoPago;
        public bool SeguimientoSaldo;
        public TipoPago TipoPagoEstudiante;
        public int IdZona;
        public string IdToken;
        public int IdEstudianteRecomendo = 0;
        public string NameEstudianteRecomendo;
        public string IdStudent;
        DataOperations dp = new DataOperations();

        public enum TipoPago
        {
            Anterior = 1,
            Posterior = 2
        }

        public bool RecuperarRegistro(int pidEstudiante)
        {
            bool Recuperado = false;

            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_load_estudiantes_clase", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEstudiante", pidEstudiante);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    IdEstudiante = dr.GetInt64(0);
                    identidad = dr.GetString(1);
                    Nombres = dr.GetString(2);
                    Apellidos = dr.GetString(3);
                    Direccion = dr.GetString(4);
                    FechaNacimiento = dr.GetDateTime(5);
                    FechaIngreso = dr.GetDateTime(6);
                    Habilitado = dr.GetBoolean(7);
                    IdNivelIngreso = dr.GetInt32(8);
                    Sexo = dr.GetString(9);
                    Correo = dr.GetString(10);
                    object fecha = dr.GetDateTime(11);
                    if (fecha.ToString() == "1/1/0001 12:00:00 AM")
                        FechaProximoPago = DateTime.Now;
                    else
                        FechaProximoPago = Convert.ToDateTime(dr.GetDateTime(11));
                    SeguimientoSaldo = dr.GetBoolean(12);
                    TipoPagoEstudiante = (TipoPago)dr.GetInt32(13);
                    IdZona = dr.GetInt32(14);
                    id_tipo_retiro = dr.GetInt32(15);
                    if (!dr.IsDBNull(dr.GetOrdinal("id_estudiante_recomendo")))
                        IdEstudianteRecomendo = dr.GetInt32(16);
                    if (!dr.IsDBNull(dr.GetOrdinal("nombre_recomendo")))
                        NameEstudianteRecomendo = dr.GetString(17);
                    Recuperado = true;
                }
                dr.Close();

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
