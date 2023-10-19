using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

namespace ERP_INTECOLI.Clases
{
    class DataOperations
    {
        #region Connection Credentials

        internal string ConnectionStringERP = @"Server=" + Globals.ERP_ServerAddress + @";
                                                Database= " + Globals.ERP_ActiveDB + @";
                                                User ID= " + Globals.ERP_DB_User + @";
                                                Password= " + Globals.ERP_DB_Pass + @";";

        #endregion


        public bool ValidateStringIsNullOrEmpty(object val)
        {
            bool IsNull = true;

            try
            {
                IsNull = string.IsNullOrEmpty(val.ToString());
            }
            catch 
            { }
            return IsNull;
        }

        public DateTime Now()
        {
            DateTime date;
            try
            {
                //string sql = "select CURRENT_TIMESTAMP";
                string sql = "[dbo].[sp_get_hour_server_cloud_adjust]";
                SqlConnection conn = new SqlConnection(ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                date = Convert.ToDateTime(cmd.ExecuteScalar());
            }
            catch (Exception ec)
            {
                date = DateTime.Today;
                CajaDialogo.Error(ec.Message);
            }
            return date;
        }

        #region Funciones
        public decimal ValidateNumberDecimal(object val)
        {
            decimal valor = 0;
            try
            {
                valor = Convert.ToDecimal(val);
            }
            catch { }
            return valor;
        }

        public int ValidateNumberInt32(object val)
        {
            int valor = 0;
            try
            {
                valor = Convert.ToInt32(val);
                //valor = (int)val;
            }
            catch
            {
                string vals;
                try
                {
                    vals = val.ToString();
                    decimal valDecimal = Convert.ToDecimal(val);
                    valor = Decimal.ToInt32(valDecimal);
                }
                catch
                {
                    valor = 0;
                }
            }
            return valor;
        }

        public string ValidateNumberString(object val)
        {
            string valor = "";
            try
            {
                valor = val.ToString();
            }
            catch { }
            return valor;
        }

        public DateTime NowSetDateTime()
        {
            DateTime val = DateTime.Now;
            try
            {
                SqlConnection con = new SqlConnection(ConnectionStringERP);
                con.Open();
                string sql = @"dbo.sp_get_hour_server_cloud_adjust";
                SqlCommand cmd = new SqlCommand(sql, con);
                //cmd.CommandType = CommandType.StoredProcedure;
                val = Convert.ToDateTime(cmd.ExecuteScalar());
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return val;
        }
        #endregion


        public enum TipoTransaccionesCRUD
        {
            Nuevo = 1,
            Editar = 2,
            Eliminar = 3
        }
    }
}
