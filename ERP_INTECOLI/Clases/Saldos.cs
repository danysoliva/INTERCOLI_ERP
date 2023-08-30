using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ERP_INTECOLI.Clases;

namespace ERP_INTECOLI.Clases
{
    public class Saldos
    {
        public Saldos()
        { 
            
        }

        public decimal ConsultarSaldo(long id_student)
        {
            DataOperations dp = new DataOperations();
            decimal val = 0;
            try
            {
                string sql = @"sp_consultar_saldo";
                SqlConnection connection = new SqlConnection(dp.ConnectionStringERP);
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.Parameters.Add("estudiante", PgSqlType.Int).Value = id_student;
                cmd.Parameters.AddWithValue("@estudiante", id_student);
                val = Convert.ToDecimal(cmd.ExecuteScalar());
                connection.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error("No se pudo cargar el saldo del estudiante! \n" + ec.Message);
            }
            return val;
        }
    }
}
