using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ERP_INTECOLI.Clases
{
    public class PrintersConfig
    {

        public int Id;
        public string Key;

        public PrintersConfig( )
        {
            
        }

        public int getIdPrinterDefault()
        {
            int val = 0;
            try
            {
                string sql = @"SELECT id, printer_key
                               FROM config_printers
                               where enable = 1
		                             and is_default = 1
                                     and id_tipo = 1";
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id = val = dr.GetInt32(0);
                    Key = dr.GetString(1);
                }
                dr.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return val;
        }
    }
}
