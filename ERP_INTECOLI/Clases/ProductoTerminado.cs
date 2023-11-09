using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_INTECOLI.Clases
{
    public class ProductoTerminado
    {
        string ConnectionString;
        private int id;
        private bool enable;
        int id_user_created;
        int id_presentacion;
        string presentacion_name;
        int id_estado;
        string _EstadoDescripcion;
        string descripcion;
        string code;
        DateTime fecha;
        int tipo_id;
        string _TipoDescripcion;
        bool pRecuperado;
        string usuario_nombre;
        decimal _CantLatasByArroba;
        decimal _CantBolsasByLata;
        decimal _CantInventarioKardex;
        decimal _cantInventarioKardexFor_Facturacion;
        bool _manoObraPorArroba_bit;
        decimal _manoObraCostoPorArrobaDecimal;
        int _IdTipoFacturacion;
        int _IdTipoBuffet;
        int _id_tipo_facturacion_prd;
        string _TipoFacturacion_prd_name;
        int _id_clase;
        int _id_isv_aplicable;

        public int Id { get => id; set => id = value; }
        public bool Enable { get => enable; set => enable = value; }
        public int Id_user_created { get => id_user_created; set => id_user_created = value; }
        public int Id_presentacion { get => id_presentacion; set => id_presentacion = value; }
        public int Id_estado { get => id_estado; set => id_estado = value; }
        /// <summary>
        /// Nombre del producto.
        /// </summary>
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Code { get => code; set => code = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Tipo_id { get => tipo_id; set => tipo_id = value; }
        public bool Recuperado { get => pRecuperado; set => pRecuperado = value; }
        public string Usuario_nombre { get => usuario_nombre; set => usuario_nombre = value; }
        public string Presentacion_name { get => presentacion_name; set => presentacion_name = value; }
        public string EstadoDescripcion { get => _EstadoDescripcion; set => _EstadoDescripcion = value; }
        public string TipoDescripcion { get => _TipoDescripcion; set => _TipoDescripcion = value; }
        public decimal CantLatasByArroba { get => _CantLatasByArroba; set => _CantLatasByArroba = value; }
        public decimal CantBolsasByLata { get => _CantBolsasByLata; set => _CantBolsasByLata = value; }
        public decimal CantInventarioKardex { get => _CantInventarioKardex; set => _CantInventarioKardex = value; }
        public bool CostoDeMO_porArrobaBit { get => _manoObraPorArroba_bit; set => _manoObraPorArroba_bit = value; }
        public decimal CostoPorArroba { get => _manoObraCostoPorArrobaDecimal; set => _manoObraCostoPorArrobaDecimal = value; }
        public int tipo_facturacion_id { get => _IdTipoFacturacion; set => _IdTipoFacturacion = value; }
        public int tipo_buffet_id { get => _IdTipoBuffet; set => _IdTipoBuffet = value; }

        /// <summary>
        /// id_tipo_facturacion_prd, tambien conocido como destino del producto terminado.
        /// </summary>
        public int id_tipo_facturacion_prd { get => _id_tipo_facturacion_prd; set => _id_tipo_facturacion_prd = value; }

        /// <summary>
        /// Facturacion_prd_name, o tambien nombre del destino del producto terminado.
        /// </summary>
        public string TipoFacturacion_prd_name { get => _TipoFacturacion_prd_name; set => _TipoFacturacion_prd_name = value; }
        public int Id_clase { get => _id_clase; set => _id_clase = value; }
        public int Id_isv_aplicable { get => _id_isv_aplicable; set => _id_isv_aplicable = value; }
        public decimal CantInventarioKardexFor_Facturacion { get => _cantInventarioKardexFor_Facturacion; set => _cantInventarioKardexFor_Facturacion = value; }

        public ProductoTerminado(string pConnectionString, DateTime fecha = default)
        {
            ConnectionString = pConnectionString;
            this.Fecha = fecha;
        }
        public ProductoTerminado()
        {
            //ConnectionString = pConnectionString;
            //this.Fecha = fecha;
        }

        public bool Recuperar_productoByBarCode(string pBarCode)
        {
            try
            {//Recupera las caracteristicas 
                string sql = @"[codesahn].[sp_get_datos_maestros_pt_v6]";
                DataOperations dp = new DataOperations();

                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", pBarCode);
                SqlDataReader dl = cmd.ExecuteReader();
                if (dl.Read())
                {

                    Id = dl.GetInt32(0);
                    enable = dl.GetBoolean(1);
                    id_user_created = dl.GetInt32(2);
                    usuario_nombre = dl.GetString(3);
                    id_presentacion = dl.GetInt32(4);
                    Presentacion_name = dl.GetString(5);
                    id_estado = dl.GetInt32(6);
                    Descripcion = dl.GetString(7);
                    code = dl.GetString(8);
                    fecha = dl.GetDateTime(9);
                    tipo_id = dl.GetInt32(10);
                    TipoDescripcion = dl.GetString(11);
                    EstadoDescripcion = dl.GetString(12);
                    CostoDeMO_porArrobaBit = dl.GetBoolean(13);
                    CostoPorArroba = dl.GetDecimal(14);

                    if (!dl.IsDBNull(dl.GetOrdinal("id_tipo_facturacion")))
                        tipo_facturacion_id = dl.GetInt32(15);

                    if (!dl.IsDBNull(dl.GetOrdinal("id_tipo_buffet")))
                        tipo_buffet_id = dl.GetInt32(16);

                    if (!dl.IsDBNull(dl.GetOrdinal("id_tipo_facturacion_prd")))
                        id_tipo_facturacion_prd = dl.GetInt32(17);

                    if (!dl.IsDBNull(dl.GetOrdinal("tipo_facturacion_prd")))
                        TipoFacturacion_prd_name = dl.GetString(18);

                    if (!dl.IsDBNull(dl.GetOrdinal("id_clase")))
                        _id_clase = dl.GetInt32(19);
                    else
                        _id_clase = 0;

                    if (!dl.IsDBNull(dl.GetOrdinal("id_isv_aplicable")))
                        _id_isv_aplicable = dl.GetInt32(20);
                    else
                        _id_isv_aplicable = 0;

                    Recuperado = true;
                    Recuperar_Latas_and_bolsas(Id);

                    CantInventarioKardex = Recuperar_Cant_Inv_Actual_by_PT(Id);
                }
            }
            catch (Exception ex)
            {

                Recuperado = false;
                MessageBox.Show(ex.Message);
            }
            return Recuperado;
        }

        public bool Recuperar_producto(int IdProd)
        {
            try
            {//Recupera las caracteristicas 
                string sql = @"[dbo].[sp_get_datos_maestros_pt]";
                DataOperations dp = new DataOperations();

                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", IdProd);
                SqlDataReader dl = cmd.ExecuteReader();
                if (dl.Read())
                {

                    Id = dl.GetInt32(0);
                    Enable = dl.GetBoolean(1);
                    Id_user_created = dl.GetInt32(2);
                    Usuario_nombre = dl.GetString(3);
                    //id_presentacion = dl.GetInt32(4);
                    //Presentacion_name = dl.GetString(5);
                    Id_estado = dl.GetInt32(4);
                    Descripcion = dl.GetString(5);
                    Code = dl.GetString(6);
                    Tipo_id = dl.IsDBNull(7) ? 0 : dl.GetInt32(7); //dl.GetInt32(7);
                    //fecha = dl.GetDateTime(9);
                    //tipo_id = dl.GetInt32(10);
                    //TipoDescripcion = dl.GetString(11);
                    //EstadoDescripcion = dl.GetString(12);
                    //CostoDeMO_porArrobaBit = dl.GetBoolean(13);
                    //CostoPorArroba = dl.GetDecimal(14);

                    //if (!dl.IsDBNull(dl.GetOrdinal("id_tipo_facturacion")))
                    //    tipo_facturacion_id = dl.GetInt32(15);

                    //if (!dl.IsDBNull(dl.GetOrdinal("id_tipo_buffet")))
                    //    tipo_buffet_id = dl.GetInt32(16);

                    ////if (!dl.IsDBNull(dl.GetOrdinal("id_tipo_facturacion_prd")))
                    ////    id_tipo_facturacion_prd = dl.GetInt32(17);

                    ////if (!dl.IsDBNull(dl.GetOrdinal("tipo_facturacion_prd")))
                    ////    TipoFacturacion_prd_name = dl.GetString(18);

                    //if (!dl.IsDBNull(dl.GetOrdinal("id_clase")))
                    //    _id_clase = dl.GetInt32(19);
                    //else
                    //    _id_clase = 0;

                    //if (!dl.IsDBNull(dl.GetOrdinal("id_isv_aplicable")))
                    //    _id_isv_aplicable = dl.GetInt32(20);
                    //else
                    //    _id_isv_aplicable = 0;

                    Recuperado = true;
                    //Recuperar_Latas_and_bolsas(IdProd);

                    //CantInventarioKardex = Recuperar_Cant_Inv_Actual_by_PT(IdProd);
                    //CantInventarioKardexFor_Facturacion = Recuperar_Cant_Inv_Actual_PT_for_facturacion(IdProd);    
                }
            }
            catch (Exception ex)
            {

                Recuperado = false;
                MessageBox.Show(ex.Message);
            }
            return Recuperado;
        }

        public void Recuperar_Latas_and_bolsas(int IdProd)
        {
            try
            {//Recupera las caracteristicas 
                string sql = @"[codesahn].[jaguar_sp_get_lista_formulas_id_pt]";
                DataOperations dp = new DataOperations();

                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_pt", IdProd);
                SqlDataReader dl = cmd.ExecuteReader();
                if (dl.Read())
                {
                    CantLatasByArroba = dl.GetDecimal(0);
                    CantBolsasByLata = dl.GetDecimal(1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public decimal Recuperar_Cant_Inv_Actual_by_PT(int IdProd)
        {
            decimal val = 0;
            try
            {//Recupera las caracteristicas 
                string sql = @"codesahn.jaguar_sp_get_cantidad_inv_kardex_pt";
                DataOperations dp = new DataOperations();

                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_pt", IdProd);
                SqlDataReader dl = cmd.ExecuteReader();
                if (dl.Read())
                {
                    val = dl.GetDecimal(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return val;
        }


        public decimal Recuperar_Cant_Inv_Actual_PT_for_facturacion(int IdProd, int pIdPuntoVenta)
        {
            decimal val = 0;
            try
            {//Recupera las caracteristicas 
                string sql = @"dbo.[jaguar_sp_get_cantidad_inv_kardex_pt_for_facturacion]";
                DataOperations dp = new DataOperations();

                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_pt", IdProd);
                cmd.Parameters.AddWithValue("@id_punto_facturacion", pIdPuntoVenta);
                SqlDataReader dl = cmd.ExecuteReader();
                if (dl.Read())
                {
                    val = dl.GetDecimal(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return val;
        }


        public string GenerarSiguienteCodigoPT()
        {
            string codigo_var = "N/D";
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();

                SqlCommand cmd = new SqlCommand("codesahn.sp_get_siguiente_codigo_pt", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@ver_todos", 0);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    codigo_var = dr.GetString(0);
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return codigo_var;
        }

        public int Recuperaridmpgroup(int PidGrup)
        {
            int varidconf = 0;
            if (PidGrup == 1)
            {
                varidconf = 7;

            }
            if (PidGrup == 2)
            {
                varidconf = 8;
            }
            if (PidGrup == 3)
            {
                varidconf = 9;
            }
            if (PidGrup == 4)
            {
                varidconf = 10;
            }
            if (PidGrup == 5)
            {
                varidconf = 11;
            }
            if (PidGrup == 6)
            {
                varidconf = 12;
            }
            return varidconf;
        }
        public string GenerarSiguienteCodigo(int pIdSiguiente)
        {
            string cod = "";
            string val = "";
            string pref = "";
            try
            {
                string sql = @"SELECT prefijo, siguiente
                               FROM conf_tables_id
                               WHERE id = " + pIdSiguiente.ToString();
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    pref = dr.GetString(0);
                    val = dr.GetInt32(1).ToString();
                    while (val.Length < 4)
                    {
                        val = "0" + val;
                    }
                    cod = pref + val;

                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return cod;
        }
    }
}
