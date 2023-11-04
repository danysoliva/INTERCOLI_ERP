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

        public Int64 BuscarMatriculaDetalle(Int64 pidEstudiante, int pIdNivel)
        {
            Int64 rIdMatriculaDetalle = 0;

            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand("dbo.sp_get_detalle_matricula_from_estudiante_and_nivel", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_estudiante", pidEstudiante);
                cmd.Parameters.AddWithValue("@id_nivel", pIdNivel);
                rIdMatriculaDetalle = Convert.ToInt64(cmd.ExecuteScalar()); 
            }
            catch (Exception ex)
            {
                rIdMatriculaDetalle = 0;
                CajaDialogo.Error(ex.Message);
            }
            return rIdMatriculaDetalle;
        }

        public bool RecuperarRegistro(Int64 pidEstudiante)
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

        public bool TieneMatricula(Int64 p_idEstudiante)
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


        public Int64 InsertEstudiante(UserLogin pUserLog)
        {
            bool a = true;
            Int64 id_student = 0;
            //PgSqlTransaction tran1 = psConnection.BeginTransaction();
            try
            {
                //string sql1 = @"SELECT id_siguiente
                //                  FROM tablas_id tb
                //                 where tb.nombre_tabla = 'estudiante';";
                
                //SqlCommand cmd1 = new SqlCommand(sql1, conn);
                //int vIdEstudiante = Convert.ToInt32(cmd1.ExecuteScalar());
                //id_student = vIdEstudiante;

                //string sql = @"INSERT INTO admon.estudiante(
                //                                            id_estudiante, 
                //                                            numero_identidad,
                //                                            nombres, 
                //                                            apellidos,
                //                                            direccion, 
                //                                            fecha_nacimiento, 
                //                                            fecha_ingreso, 
                //                                            nivel_id_ingreso, 
                //                                            sexo,
                //                                            correo, 
                //                                            id_usuario,
                //                                            id_zona,
                //                                            id_tarjeta,
                //                                            id_estudiante_recomendo,
                //                                            nombre_recomendo)
                //                                    VALUES (
                //                                            :id_estudiante, 
                //                                            :numero_identidad,
                //                                            :nombres, 
                //                                            :apellidos,
                //                                            :direccion, 
                //                                            :fecha_nacimiento, 
                //                                            :fecha_ingreso, 
                //                                            :nivel_id_ingreso, 
                //                                            :sexo,
                //                                            :correo, 
                //                                            :id_usuario,
                //                                            :id_zona,
                //                                            :id_tarjeta,
                //                                            :id_estudiante_recomendo,
                //                                            :nombre_recomendo);";
                string sql = @"sp_estudiante_insert_desde_clase";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd2 = new SqlCommand(sql, conn);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@numero_identidad",  identidad);
                cmd2.Parameters.AddWithValue("@nombres", Nombres);
                cmd2.Parameters.AddWithValue("@apellidos", Apellidos);
                cmd2.Parameters.AddWithValue("@direccion", Direccion);
                cmd2.Parameters.AddWithValue("@fecha_nacimiento", FechaNacimiento);
                cmd2.Parameters.AddWithValue("@fecha_ingreso", FechaIngreso);

                if (IdNivelIngreso > 0)
                    cmd2.Parameters.AddWithValue("@nivel_id_ingreso", IdNivelIngreso);
                else
                    cmd2.Parameters.AddWithValue("@nivel_id_ingreso",DBNull.Value);

                if (!string.IsNullOrEmpty(Sexo))
                    cmd2.Parameters.AddWithValue("@sexo", Sexo);
                else
                    cmd2.Parameters.AddWithValue("@sexo", null);

                cmd2.Parameters.AddWithValue("@correo", Correo);

                if (pUserLog.Id > 0)
                    cmd2.Parameters.AddWithValue("@id_usuario", pUserLog.Id);
                else
                    cmd2.Parameters.AddWithValue("@id_usuario", DBNull.Value);

                if (IdZona > 0)
                    cmd2.Parameters.AddWithValue("@id_zona", IdZona);
                else
                    cmd2.Parameters.AddWithValue("@id_zona", DBNull.Value);

                if (!string.IsNullOrEmpty(IdToken))
                    cmd2.Parameters.AddWithValue("@id_tarjeta", IdToken);
                else
                    cmd2.Parameters.AddWithValue("@id_tarjeta",DBNull.Value);

                if (IdEstudianteRecomendo == 0)
                    cmd2.Parameters.AddWithValue("@id_estudiante_recomendo", DBNull.Value);
                else
                    cmd2.Parameters.AddWithValue("@id_estudiante_recomendo", IdEstudianteRecomendo);

                cmd2.Parameters.AddWithValue("@nombre_recomendo", NameEstudianteRecomendo);

                id_student = Convert.ToInt64(cmd2.ExecuteScalar());

                CajaDialogo.Information("Guardado con exito!");
                a = true;
            }
            catch (Exception ec)
            {
                //tran1.Rollback();
                a = false;
                throw new Exception("No se pudo guardar el Estudiante!", ec);
            }
            return id_student;
        }
    }
}
