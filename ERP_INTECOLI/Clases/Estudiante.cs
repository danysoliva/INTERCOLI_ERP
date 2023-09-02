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
                    //if (!dr.IsDBNull(dr.GetOrdinal("id_tipo_retiro")))
                    //    id_tipo_retiro = dr.GetInt32(15);
                    //if (!dr.IsDBNull(dr.GetOrdinal("id_estudiante_recomendo")))
                    IdEstudianteRecomendo = (int)dr.GetInt64(16);
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

        public bool ValidarIdDisponible(string p)
        {
            bool r = false;
            try
            {
                //string sql = @"SELECT case when count(*)>0 then false else true end 
                //                FROM admon.estudiante ee
                //                where replace(trim(ee.numero_identidad), '-', '') =  replace(trim(:par), '-', '')";
                string sql = "sp_estudiantes_validar_existencia_identidad";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@identidad", p);
                r = Convert.ToBoolean(cmd.ExecuteScalar());
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return r;
        }

        public bool TieneMatricula(long p_idEstudiante)
        {
            try
            {
                string sql2 = @"sp_mensualidad_validar_matricula";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd2 = new SqlCommand(sql2, conn);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@estudiante", p_idEstudiante);
                int x2 = Convert.ToInt32(cmd2.ExecuteScalar());

                return (x2 > 0);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error("No se pudo cargar los datos de matricula!", ec);
                return false;
            }
        }


        public string RecuperaTelefonosConcatenadosEstudiante()
        {
            string phones = "";
            try
            {
                string sql = "select * from admon.ft_recupera_telefonos_estudiante_concatenados (:p_id_estudiante);";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_estudiante", this.IdEstudiante);
                phones = cmd.ExecuteScalar().ToString();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return phones;
        }
    }
}
