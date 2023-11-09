using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_INTECOLI.Clases
{
    public class Conf_TablesID
    {
        public enum TablesIDOptions
        {
            PT_ProductoTerminado = 1,
            FormulaH = 2,
            MateriaPrima = 3,
            Proveedores = 4,
            NumDocRecepcionFactura = 5,
            NumeroPedido = 6,
            Clientes = 7,
            RequisicionesMP = 8,
            Material_De_Empaque = 9,
            OrdenFabricacion = 11,
            Panaderos = 12,
            ClienteFacturacion = 13,
            Empresa = 14,
            PuntoDeVenta = 15,
            Despacho = 17,
            ListaPrecios = 18,
            Traslados = 19
        }

        public int ID { get; set; }
        public string Tabla { get; set; }
        public string Prefijo { get; set; }
        public string Codigo { get; set; }
        public int IDSiguiente { get; set; }
        public bool RegistroEncontrado { get; set; }


        public bool ObtenerIDTable(int IDTabla)
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP))
                {
                    cnx.Open();

                    SqlCommand cmd = new SqlCommand("dbo.usp_GetCodigoTabaleID", cnx);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = IDTabla;

                    Codigo = (string)cmd.ExecuteScalar();
                    RegistroEncontrado = true;
                    cnx.Close();

                    return RegistroEncontrado;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return false;

            }
        }

        public bool ObtenerIDTable(int IDTabla, int CantidadCaracteres)
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP))
                {
                    cnx.Open();

                    SqlCommand cmd = new SqlCommand("dbo.[usp_GetCodigoTabaleID]", cnx);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = IDTabla;
                    cmd.Parameters.Add("@cantidadCaracteres", System.Data.SqlDbType.Int).Value = CantidadCaracteres;

                    Codigo = (string)cmd.ExecuteScalar();
                    RegistroEncontrado = true;
                    cnx.Close();

                    return RegistroEncontrado;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return false;

            }
        }

        public string GetFormatCode(int consecutivo, int tableID)
        {
            string[] prefijo = { "PT", "FML", "MP", "PV", "RFAC", "PED", "CLI", "REQ", "ME", "OP", "PAN" };
            string code;

            if ((int)TablesIDOptions.RequisicionesMP == tableID)
            {
                code = prefijo[(int)TablesIDOptions.RequisicionesMP - 1] + consecutivo.ToString().PadLeft(5, '0');

            }
            else code = null;

            return code;
        }


        public string GetFormatCode(int consecutivo, int tableID, int CantCaracteres)
        {
            string[] prefijo = { "PT", "FML", "MP", "PV", "RFAC", "PED", "CLI", "REQ", "ME", "OP", "PAN" };
            string code;

            if ((int)TablesIDOptions.RequisicionesMP == tableID)
            {
                code = prefijo[(int)TablesIDOptions.RequisicionesMP - 1] + consecutivo.ToString().PadLeft(CantCaracteres, '0');

            }
            else code = null;

            return code;
        }
    }
}
