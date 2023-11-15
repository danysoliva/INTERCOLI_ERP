using DevExpress.DashboardCommon.DataProcessing;
using DevExpress.DashboardCommon;
using DevExpress.DashboardWin.Design;
using DevExpress.DataAccess.Sql;
using DevExpress.Xpo;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.Design;
using JAGUAR_APP.Facturacion.Configuraciones.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Pdf.Native.BouncyCastle.Asn1.X509.Target;
using static DevExpress.XtraEditors.Mask.Design.MaskSettingsForm.DesignInfo.MaskManagerInfo;
using static DevExpress.XtraGrid.Views.Grid.DetailTip;
using static DevExpress.XtraPrinting.Native.ExportOptionsPropertiesNames;
using static DevExpress.Xpo.Logger.LogManager;
using JAGUAR_APP.Facturacion.CoreFacturas;
using LOSA.Calidad.LoteConfConsumo;
using ERP_INTECOLI.Clases;
using static ERP_INTECOLI.Clases.Conf_TablesID;

namespace JAGUAR_APP.Facturacion.Configuraciones
{
    public partial class xfrmListaPreciosCRUD : DevExpress.XtraEditors.XtraForm
    {
        UserLogin usuarioLogueado;

        public delegate void get_MP_inserted(int Id_MP_inserted);
        public event get_MP_inserted EventoPasarId_MP_inserted;
        Conf_TablesID tableID = new Conf_TablesID();
        public ListaPrecios Lista_precioActual = new ListaPrecios();
        DataOperations dp;
        public enum TipoTipoTransaccionActual
        {
            Nuevo = 1,
            Editar = 2,
            Copiar=3
        }

        TipoTipoTransaccionActual TipoTransaccionActual = new TipoTipoTransaccionActual();

        public xfrmListaPreciosCRUD(UserLogin userLog, TipoTipoTransaccionActual pTipoTransaccionActual, int id_listaPrecio)
        {
            InitializeComponent();
            usuarioLogueado = userLog;
            buildMonthListh();
            TipoTransaccionActual = pTipoTransaccionActual;
            dp = new DataOperations();

            ObtenerPDVs();

            Lista_precioActual.RecuperaRegistro(id_listaPrecio);
            switch (TipoTransaccionActual)
            {
                case TipoTipoTransaccionActual.Nuevo:
                    
                    GetIDTable();
                    //colTiendaAsignada.Visible = false;
                    deDesde.EditValueChanged -= new EventHandler(deDesde_EditValueChanged);
                    deDesde.EditValue = dp.NowSetDateTime();
                    deDesde.EditValueChanged += new EventHandler(deDesde_EditValueChanged);

                    deHasta.EditValueChanged -= new EventHandler(deHasta_EditValueChanged_1);
                    deHasta.EditValue = dp.NowSetDateTime().AddDays(30);
                    deHasta.EditValueChanged += new EventHandler(deHasta_EditValueChanged_1);

                    txtNombreListaPrecio.Focus();
                    break;

                case TipoTipoTransaccionActual.Editar:

                    txtCodigo.Text = Lista_precioActual.Codigo;
                    txtNombreListaPrecio.EditValueChanged -= new EventHandler(txtNombreListaPrecio_EditValueChanged);
                    txtNombreListaPrecio.Text = Lista_precioActual.Descripcion;
                    txtNombreListaPrecio.EditValueChanged += new EventHandler(txtNombreListaPrecio_EditValueChanged);

                    deDesde.EditValueChanged -= new EventHandler(deDesde_EditValueChanged); 
                    deDesde.EditValue = Lista_precioActual.Desde;
                    deDesde.EditValueChanged += new EventHandler(deDesde_EditValueChanged);

                    deHasta.EditValueChanged -= new EventHandler(deHasta_EditValueChanged_1); 
                    deHasta.EditValue = Lista_precioActual.Hasta;
                    deHasta.EditValueChanged += new EventHandler(deHasta_EditValueChanged_1);

                    //ObtenerClientesById(Lista_precioActual.ID);
                    //ObtenerProductosById(Lista_precioActual.ID);
                    ObtenerProductosForListaById(this.Lista_precioActual.ID);
                    break;

                case TipoTipoTransaccionActual.Copiar:
                    GetIDTable();
                    txtNombreListaPrecio.Text = Lista_precioActual.Descripcion;

                    deDesde.EditValueChanged -= new EventHandler(deDesde_EditValueChanged);
                    deDesde.EditValue = Lista_precioActual.Desde;
                    deDesde.EditValueChanged += new EventHandler(deDesde_EditValueChanged);

                    deHasta.EditValueChanged -= new EventHandler(deHasta_EditValueChanged_1);
                    deHasta.EditValue = Lista_precioActual.Hasta;
                    deHasta.EditValueChanged += new EventHandler(deHasta_EditValueChanged_1);

                    //ObtenerClientesById(Lista_precioActual.ID);
                    //ObtenerProductosById(Lista_precioActual.ID);
                    ObtenerProductosForListaById(this.Lista_precioActual.ID);
                    break;
            }

            
        }

        private void xfrmMasterMP_CRUD_Load(object sender, EventArgs e)
        {
            //if (TipoTransaccionActual == TipoTipoTransaccionActual.Editar)
            //{
            //    txtCodigo.Text = Lista_precioActual.Codigo;
            //    txtNombreListaPrecio.Text = Lista_precioActual.Descripcion;
            //    deFecha.EditValue = Convert.ToDateTime(Lista_precioActual.Anio + "-01-01");
            //    cbxMonth.EditValue = Lista_precioActual.Mes;
            //    deDesde.EditValue = Lista_precioActual.Desde;
            //    deHasta.EditValue = Lista_precioActual.Hasta;

            //    ObtenerClientesById(Lista_precioActual.ID);
            //    ObtenerProductosById(Lista_precioActual.ID);
            //}
            //else if (TipoTransaccionActual == TipoTipoTransaccionActual.Copiar)
            //{
            //        GetIDTable();
            //        //txtCodigo.Text = Lista_precioActual.Codigo;
            //        txtNombreListaPrecio.Text = Lista_precioActual.Descripcion;
            //        deFecha.EditValue = Convert.ToDateTime(Lista_precioActual.Anio + "-01-01");
            //        //cbxMonth.EditValue = Lista_precioActual.Mes;
       

            //        ObtenerClientesById(Lista_precioActual.ID);
            //        ObtenerProductosById(Lista_precioActual.ID);
                
            //}
            //else
            //{
            //    GetIDTable();
            //    //colTiendaAsignada.Visible = false;
            //    deDesde.EditValue = DateTime.Now;
            //    deHasta.EditValue = DateTime.Now;
            //}
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }

        SqlTransaction tran;
        private void cmdNew_Click(object sender, EventArgs e)
        {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP);
            cnx.Open();
            tran = cnx.BeginTransaction();
            try
            {

                int id_inserted = 0;

                if (string.IsNullOrEmpty(txtNombreListaPrecio.Text))
                {
                    CajaDialogo.Error("DEBE INGRESAR UNA DESCRIPCIÓN");
                    return;
                }

                if (string.IsNullOrEmpty(cbxMonth.Text))
                {
                    CajaDialogo.Error("DEBE SELECCIONAR UN MES");
                    return;
                }

                if (string.IsNullOrEmpty(deFecha.Text))
                {
                    CajaDialogo.Error("DEBE SELECCIONAR UN AÑO");
                    return;
                }

                if (string.IsNullOrEmpty(txtCodigo.Text))
                {
                    CajaDialogo.Error("DEBE INGRESAR UN CODIGO");
                    return;
                }

                //if (gvProductos.RowCount==0)
                //{
                //    CajaDialogo.Error("DEBE AGREGAR PRODUCTOS A ESTA LISTA DE PRECIOS");
                //    return;
                //}

                if (gvCliente.RowCount == 0)
                {
                    CajaDialogo.Error("DEBE AGREGAR CLIENTES A ESTA LISTA DE PRECIOS");
                    return;
                }

                if (string.IsNullOrEmpty(deDesde.Text))
                {
                    CajaDialogo.Error("DEBE SELECCIONAR UNA FECHA INICIAL");
                    return;
                }

                if (string.IsNullOrEmpty(deHasta.Text))
                {
                    CajaDialogo.Error("DEBE SELECCIONAR UNA FECHA FINAL");
                    return;
                }


                switch (TipoTransaccionActual)
                {
                    case TipoTipoTransaccionActual.Nuevo:

                        if (ValidarListaExistente(Convert.ToInt32(cbxMonth.EditValue), deFecha.DateTime.Year) == true)
                        {
                            CajaDialogo.Error("Ya existe una lista de Precios para el mes de " + cbxMonth.Text + " del " + deFecha.DateTime.Year);
                            return;
                        }

                        SqlCommand cmd = new SqlCommand("dbo.uspInsert_ListaPrecio_V2", tran.Connection);

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Transaction = tran;
                        cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = txtNombreListaPrecio.Text;
                        cmd.Parameters.Add("@anio", SqlDbType.Int).Value = deFecha.DateTime.Year;
                        cmd.Parameters.Add("@mes", SqlDbType.VarChar).Value = cbxMonth.EditValue;
                        cmd.Parameters.Add("@usuario_id", SqlDbType.Int).Value = usuarioLogueado.Id;
                        cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = txtCodigo.Text;
                        cmd.Parameters.Add("@fecha_creacion", SqlDbType.DateTime).Value = DateTime.Now;
                        cmd.Parameters.Add("@desde", SqlDbType.DateTime).Value = deDesde.EditValue;
                        cmd.Parameters.Add("@hasta", SqlDbType.DateTime).Value = deHasta.EditValue;

                        id_inserted = Convert.ToInt32(cmd.ExecuteScalar());

                        foreach (var item in dsListaPrecios.Clientes)
                        {
                            SqlCommand cmd2 = new SqlCommand("dbo.uspInsertListaPrecioClientesAplica", tran.Connection);
                            cmd2.CommandType = CommandType.StoredProcedure;
                            cmd2.Transaction = tran;

                            cmd2.Parameters.Add("@id_cliente", SqlDbType.Int).Value = item.IdCliente;
                            cmd2.Parameters.Add("@id_listaPrecio", SqlDbType.Int).Value = id_inserted;
                            cmd2.Parameters.Add("@fecha", SqlDbType.DateTime).Value = DateTime.Now;
                            cmd2.Parameters.Add("@usuario_id", SqlDbType.Int).Value = usuarioLogueado.Id;

                            cmd2.ExecuteNonQuery();

                        }

                        foreach (var item in dsListaPrecios.Productos)
                        {
                            SqlCommand cmd3 = new SqlCommand("dbo.uspInsertListaPrecioProductosAplica_V2", tran.Connection);
                            cmd3.CommandType = CommandType.StoredProcedure;
                            cmd3.Transaction = tran;

                            cmd3.Parameters.Add("@id_producto", SqlDbType.Int).Value = item.id_pt;
                            cmd3.Parameters.Add("@id_listaPrecio", SqlDbType.Int).Value = id_inserted;
                            cmd3.Parameters.Add("@fecha", SqlDbType.DateTime).Value = DateTime.Now;
                            cmd3.Parameters.Add("@usuario_id", SqlDbType.Int).Value = usuarioLogueado.Id;
                            cmd3.Parameters.Add("@id_pdv", SqlDbType.Int).Value = item.id_pdv;
                            cmd3.Parameters.Add("@precio", SqlDbType.Decimal).Value = item.precio;

                            cmd3.ExecuteNonQuery();
                        }

                        foreach (var item in lista)
                        {
                            SqlCommand cmd5 = new SqlCommand("dbo.uspInsertListaPrecioProductosAplicaTienda", tran.Connection);
                            cmd5.CommandType = CommandType.StoredProcedure;
                            cmd5.Transaction = tran;

                            cmd5.Parameters.Add("@id_producto", SqlDbType.Int).Value = item.PT_ID;
                            cmd5.Parameters.Add("@id_listaPrecio", SqlDbType.Int).Value = id_inserted;
                            cmd5.Parameters.Add("@fecha", SqlDbType.DateTime).Value = DateTime.Now;
                            cmd5.Parameters.Add("@usuario_id", SqlDbType.Int).Value = usuarioLogueado.Id;
                            cmd5.Parameters.Add("@id_pdv", SqlDbType.Int).Value = item.PDV_ID;
                            cmd5.Parameters.Add("@precio", SqlDbType.Decimal).Value = item.Precio;

                            cmd5.ExecuteNonQuery();
                        }

                        tran.Commit();
                        CajaDialogo.Information("DATOS GUARDADOS");
                        this.DialogResult = DialogResult.OK;
                        cnx.Close();

                        break;

                    case TipoTipoTransaccionActual.Editar:
                        DataOperations dp2 = new DataOperations();
                        //SqlConnection cnx2 = new SqlConnection(dp2.ConnectionStringERP)
                        using (SqlConnection cnx2 = new SqlConnection(dp2.ConnectionStringERP))
                        {
                            cnx2.Open();
                            SqlCommand cmd2 = new SqlCommand("dbo.uspUpdate_ListaPrecio_V2", cnx2);

                            cmd2.CommandType = CommandType.StoredProcedure;
                            cmd2.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = txtNombreListaPrecio.Text;
                            cmd2.Parameters.Add("@anio", SqlDbType.Int).Value = deFecha.DateTime.Year;
                            cmd2.Parameters.Add("@mes", SqlDbType.Int).Value = cbxMonth.EditValue;
                            cmd2.Parameters.Add("@desde", SqlDbType.DateTime).Value = deDesde.EditValue;
                            cmd2.Parameters.Add("@hasta", SqlDbType.DateTime).Value = deHasta.EditValue;
                            cmd2.Parameters.Add("@id", SqlDbType.Int).Value = Lista_precioActual.ID;

                            cmd2.ExecuteNonQuery();

                            CajaDialogo.Information("DATOS ACTUALIZADOS");
                            this.DialogResult = DialogResult.OK;
                            cnx2.Close();
                        }
                        break;

                    case TipoTipoTransaccionActual.Copiar:

                        if (ValidarListaExistente(Convert.ToInt32(cbxMonth.EditValue), deFecha.DateTime.Year) == true)
                        {
                            CajaDialogo.Error("Ya existe una lista de Precios para el mes de " + cbxMonth.Text + " del " + deFecha.DateTime.Year);
                            return;
                        }

                         SqlCommand cmd4 = new SqlCommand("dbo.uspInsert_ListaPrecio", tran.Connection);

                        cmd4.CommandType = CommandType.StoredProcedure;
                        cmd4.Transaction = tran;
                        cmd4.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = txtNombreListaPrecio.Text;
                        cmd4.Parameters.Add("@anio", SqlDbType.Int).Value = deFecha.DateTime.Year;
                        cmd4.Parameters.Add("@mes", SqlDbType.VarChar).Value = cbxMonth.EditValue;
                        cmd4.Parameters.Add("@usuario_id", SqlDbType.Int).Value = usuarioLogueado.Id;
                        cmd4.Parameters.Add("@codigo", SqlDbType.VarChar).Value = txtCodigo.Text;
                        cmd4.Parameters.Add("@fecha_creacion", SqlDbType.DateTime).Value = DateTime.Now;
                        //cmd4.Parameters.Add("@id_pdv", SqlDbType.Int).Value = sluePDV.EditValue;


                        id_inserted = Convert.ToInt32(cmd4.ExecuteScalar());

                        foreach (var item in dsListaPrecios.Clientes)
                        {
                            SqlCommand cmd5 = new SqlCommand("dbo.uspInsertListaPrecioClientesAplica", tran.Connection);
                            cmd5.CommandType = CommandType.StoredProcedure;
                            cmd5.Transaction = tran;

                            cmd5.Parameters.Add("@id_cliente", SqlDbType.Int).Value = item.IdCliente;
                            cmd5.Parameters.Add("@id_listaPrecio", SqlDbType.Int).Value = id_inserted;
                            cmd5.Parameters.Add("@fecha", SqlDbType.DateTime).Value = DateTime.Now;
                            cmd5.Parameters.Add("@usuario_id", SqlDbType.Int).Value = usuarioLogueado.Id;

                            cmd5.ExecuteNonQuery();

                        }

                        foreach (var item in dsListaPrecios.Productos)
                        {
                            SqlCommand cmd6 = new SqlCommand("dbo.uspInsertListaPrecioProductosAplica", tran.Connection);
                            cmd6.CommandType = CommandType.StoredProcedure;
                            cmd6.Transaction = tran;

                            cmd6.Parameters.Add("@id_producto", SqlDbType.Int).Value = item.id_pt;
                            cmd6.Parameters.Add("@id_listaPrecio", SqlDbType.Int).Value = id_inserted;
                            cmd6.Parameters.Add("@fecha", SqlDbType.DateTime).Value = DateTime.Now;
                            cmd6.Parameters.Add("@usuario_id", SqlDbType.Int).Value = usuarioLogueado.Id;

                            cmd6.ExecuteNonQuery();
                        }

                        tran.Commit();
                        CajaDialogo.Information("DATOS GUARDADOS");
                        this.DialogResult = DialogResult.OK;
                        cnx.Close();

                        break;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                tran.Rollback();
                cnx.Close();
            }
        }

        private void buildMonthListh()
        {

            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("Mes", typeof(string));

            string[] meses = new string[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            DataRow _row = dt.NewRow();

            for (int i = 0; i < meses.Length; i++)
            {

                _row = dt.NewRow();
                _row["id"] = i + 1;
                _row["Mes"] = meses[i];
                dt.Rows.Add(_row);
            }

            cbxMonth.Properties.DataSource = dt;

            cbxMonth.Properties.DisplayMember = "Mes";
            cbxMonth.Properties.ValueMember = "id";


        }

        private void GetIDTable()
        {
            try
            {
                if (tableID.ObtenerIDTable((int)TablesIDOptions.ListaPrecios, 4))
                {
                    txtCodigo.Text = tableID.Codigo;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }

        private void ObtenerProductosById(int id)
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP))
                {
                    cnx.Open();

                    dsListaPrecios.Productos.Clear();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.uspObtenerProductosListaPrecioById", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    da.Fill(dsListaPrecios.Productos);

                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void ObtenerProductosForListaById(int pIdListaPrecio)
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP))
                {
                    cnx.Open();

                    dsListaPrecios.productos_precio.Clear();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.sp_get_detalle_productos_lista_precio", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@id_listaPrecio", pIdListaPrecio);
                    da.Fill(dsListaPrecios.productos_precio);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void ObtenerClientesById(int pIdListadePrecio)
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP))
                {
                    cnx.Open();

                    dsListaPrecios.Clientes.Clear();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.uspObtenerClientesFacturacionFromListaPreciosById", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = pIdListadePrecio;
                    da.Fill(dsListaPrecios.Clientes);

                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            //switch (TipoTransaccionActual)
            //{
            //    case TipoTipoTransaccionActual.Nuevo:
            int id_inserted_ListaPrecio = 0;

            if (TipoTransaccionActual == TipoTipoTransaccionActual.Nuevo)
            {
                if (string.IsNullOrEmpty(txtNombreListaPrecio.Text))
                {
                    CajaDialogo.Error("DEBE INGRESAR UNA DESCRIPCIÓN");
                    return;
                }

                if (string.IsNullOrEmpty(txtCodigo.Text))
                {
                    CajaDialogo.Error("DEBE INGRESAR UN CODIGO");
                    return;
                }

                if (string.IsNullOrEmpty(deDesde.Text))
                {
                    CajaDialogo.Error("DEBE SELECCIONAR UNA FECHA INICIAL");
                    return;
                }

                if (string.IsNullOrEmpty(deHasta.Text))
                {
                    CajaDialogo.Error("DEBE SELECCIONAR UNA FECHA FINAL");
                    return;
                }
            }

            xfrmSelectProductos frm = new xfrmSelectProductos();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                DateTime FechaHoraActual = dp.NowSetDateTime();
                SqlTransaction transaction = null;

                //Guardar Cada Fila de Productos
                using (SqlConnection connection = new SqlConnection(dp.ConnectionStringERP))
                {
                    try
                    {
                        connection.Open();

                        SqlCommand command = connection.CreateCommand();
                        transaction = connection.BeginTransaction("SampleTransaction");
                        command.Connection = connection;
                        command.Transaction = transaction;

                        if(TipoTransaccionActual == TipoTipoTransaccionActual.Nuevo) 
                        {
                            //Insert el Header
                            if (id_inserted_ListaPrecio == 0)
                            {
                                command.CommandText = "dbo.uspInsert_ListaPrecio_V2";
                                command.CommandType = CommandType.StoredProcedure;

                                command.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = txtNombreListaPrecio.Text;
                                command.Parameters.AddWithValue("@anio", DBNull.Value);
                                command.Parameters.AddWithValue("@mes", DBNull.Value);
                                command.Parameters.Add("@usuario_id", SqlDbType.Int).Value = usuarioLogueado.Id;
                                command.Parameters.Add("@codigo", SqlDbType.VarChar).Value = txtCodigo.Text;
                                command.Parameters.Add("@fecha_creacion", SqlDbType.DateTime).Value = FechaHoraActual;
                                command.Parameters.Add("@desde", SqlDbType.DateTime).Value = deDesde.EditValue;
                                command.Parameters.Add("@hasta", SqlDbType.DateTime).Value = deHasta.EditValue;

                                id_inserted_ListaPrecio = Convert.ToInt32(command.ExecuteScalar());
                                if(Lista_precioActual==null)
                                    Lista_precioActual = new ListaPrecios();

                                Lista_precioActual.ID = id_inserted_ListaPrecio;
                            }

                            if (id_inserted_ListaPrecio <= 0)
                            {
                                throw new Exception("No se pudo guardar el dato Maestro de la Lista de Precio, no se pueden Agregar lineas! Contacte con soporte tecnico...");
                            }
                        }
                        else
                        {
                            id_inserted_ListaPrecio = this.Lista_precioActual.ID;
                        }

                        foreach (var item in frm.productos)
                        {
                            dsListaPrecios.productos_precioRow row1 = dsListaPrecios.productos_precio.Newproductos_precioRow();

                            var existe_pt = from rows in dsListaPrecios.productos_precio.AsEnumerable()
                                            group rows by new { ProductoID = rows["id_pt"] } into grp
                                            where Convert.ToInt32(grp.Key.ProductoID) == item.ID
                                            select new
                                            {
                                                Count = grp.Count()
                                            };

                            if (existe_pt.Count() == 0)
                            {
                                if (item.Precio > 0)
                                {

                                    int IdLineaProductoInserted = 0;

                                    command.CommandText = "dbo.sp_set_InsertarNuevoRegistro_productos_lista_precio";
                                    command.CommandType = CommandType.StoredProcedure;

                                    command.Parameters.Clear();
                                    command.Parameters.AddWithValue("@id_pt", item.ID);
                                    command.Parameters.AddWithValue("@id_listaPrecio", id_inserted_ListaPrecio);
                                    command.Parameters.AddWithValue("@created_date", FechaHoraActual);
                                    command.Parameters.AddWithValue("@usuario_id", this.usuarioLogueado.Id);
                                    command.Parameters.AddWithValue("@enable", 1);
                                    command.Parameters.AddWithValue("@precio", 0);
                                    command.Parameters.AddWithValue("@id_pdv", DBNull.Value);
                                    IdLineaProductoInserted = dp.ValidateNumberInt32(command.ExecuteScalar());

                                    row1.id_pt = item.ID;
                                    row1.itemcode = item.Codigo;
                                    row1.itemname = item.Producto;
                                    row1.id_detalle_lista = IdLineaProductoInserted;
                                    row1.id_lista_h = this.Lista_precioActual.ID;

                                    dsListaPrecios.productos_precio.Addproductos_precioRow(row1);

                                    //Guardamos la activacion de los puntos de venta activos
                                    foreach (dsListaPrecios.PDVRow rowP in dsListaPrecios.PDV)
                                    {
                                        command.CommandText = "dbo.sp_set_InsertarNuevoRegistroTienda_punto_venta";
                                        command.Parameters.Clear();
                                        command.CommandType = CommandType.StoredProcedure;

                                        command.Parameters.AddWithValue("@id_pt", row1.id_pt);
                                        command.Parameters.AddWithValue("@id_listaPrecio", id_inserted_ListaPrecio);
                                        command.Parameters.AddWithValue("@created_date", FechaHoraActual);
                                        command.Parameters.AddWithValue("@usuario_id", this.usuarioLogueado.Id);
                                        command.Parameters.AddWithValue("@enable", 1);
                                        command.Parameters.AddWithValue("@precio", 0);
                                        command.Parameters.AddWithValue("@id_pdv", rowP.id);
                                        command.Parameters.AddWithValue("@id_LP_ProductosAplica", IdLineaProductoInserted);

                                        Int64 id_lineaProducto_punto_venta_inserted = Convert.ToInt64(command.ExecuteScalar());

                                        //Insertar el precio por default para todos los clientes
                                        command.CommandText = "dbo.sp_set_InsertarNuevoRegistroClientes_precio";
                                        command.Parameters.Clear();
                                        command.CommandType = CommandType.StoredProcedure;

                                        command.Parameters.AddWithValue("@id_pt_lista_precio_detalle", id_lineaProducto_punto_venta_inserted);
                                        command.Parameters.AddWithValue("@precio", item.Precio);
                                        command.Parameters.AddWithValue("@id_cliente", DBNull.Value);
                                        command.Parameters.AddWithValue("@enable", 1);
                                        command.Parameters.AddWithValue("@date_writed", FechaHoraActual);
                                        command.Parameters.AddWithValue("@id_user_writed", this.usuarioLogueado.Id);
                                        command.Parameters.AddWithValue("@id_user_updated", DBNull.Value);
                                        command.Parameters.AddWithValue("@date_updated", DBNull.Value);
                                        command.ExecuteNonQuery();
                                    }

                                    //foreach (dsListaPrecios.PDVRow rowP in dsListaPrecios.PDV)
                                    //{
                                    //    dsListaPrecios.ListaPrecioPuntosDeVentaRow rowAdd = dsListaPrecios.ListaPrecioPuntosDeVenta.NewListaPrecioPuntosDeVentaRow();
                                    //    rowAdd.id_lista_h = 0;
                                    //    rowAdd.id_punto_venta = rowP.id;
                                    //    rowAdd.punto_venta_name = rowP.nombre_local;
                                    //    rowAdd.punto_venta_codigo = rowP.codigo;
                                    //    rowAdd.id_detalle_punto_venta = 0;
                                    //    dsListaPrecios.ListaPrecioPuntosDeVenta.AddListaPrecioPuntosDeVentaRow(rowAdd);

                                    //    //table clientes_punto_venta
                                    //    dsListaPrecios.clientes_punto_ventaRow rowPrecio = dsListaPrecios.clientes_punto_venta.Newclientes_punto_ventaRow();
                                    //    rowPrecio.id_detalle_punto_venta = 0;
                                    //    rowPrecio.id_detalle_punto_venta_clientes = 0;
                                    //    rowPrecio.precio = item.Precio;
                                    //    rowPrecio.id_cliente = 0;
                                    //    rowPrecio.enable = true;
                                    //    rowPrecio.cliente_codigo = "N/D";
                                    //    rowPrecio.cliente_nombre = "Todos";
                                    //    dsListaPrecios.clientes_punto_venta.Addclientes_punto_ventaRow(rowPrecio);
                                    //    dsListaPrecios.AcceptChanges();

                                    //}
                                }
                            }
                        }

                        transaction.Commit();
                        CajaDialogo.InformationAuto();
                    }
                    catch (Exception ec)
                    {   // Attempt to roll back the transaction.
                        try
                        {
                            transaction.Rollback();
                            CajaDialogo.Error(ec.Message);
                        }
                        catch (Exception ex2)
                        {
                            CajaDialogo.Error(ex2.Message);
                        }
                    }
                }

                dsListaPrecios.AcceptChanges();

            }






            //if (TipoTransaccionActual == TipoTipoTransaccionActual.Editar)
            //{
            //    DataOperations dp = new DataOperations();
            //    SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP);

            //    if (xtraTabControl1.SelectedTabPage == tpCliente)
            //    {
            //        xfrmSelectCliente frm = new xfrmSelectCliente();

            //        if (frm.ShowDialog() == DialogResult.OK)
            //        {
            //            foreach (var item in frm.clientes)
            //            {
            //                dsListaPrecios.ClientesRow row1 = dsListaPrecios.Clientes.NewClientesRow();

            //                var existe_pt = from rows in dsListaPrecios.Clientes.AsEnumerable()
            //                                group rows by new { ClienteID = rows["IdCliente"] } into grp
            //                                where Convert.ToInt32(grp.Key.ClienteID) == item.ID
            //                                select new { Count = grp.Count() };

            //                if (existe_pt.Count() == 0)
            //                {
            //                    cnx.Open();
            //                    SqlCommand cmd2 = new SqlCommand("dbo.uspInsertListaPrecioClientesAplica", cnx);
            //                    cmd2.CommandType = CommandType.StoredProcedure;
            //                    cmd2.Transaction = tran;

            //                    cmd2.Parameters.Add("@id_cliente", SqlDbType.Int).Value = item.ID;
            //                    cmd2.Parameters.Add("@id_listaPrecio", SqlDbType.Int).Value = Lista_precioActual.ID;
            //                    cmd2.Parameters.Add("@fecha", SqlDbType.DateTime).Value = DateTime.Now;
            //                    cmd2.Parameters.Add("@usuario_id", SqlDbType.Int).Value = usuarioLogueado.Id;

            //                    cmd2.ExecuteNonQuery();
            //                    cnx.Close();
            //                }
            //                else
            //                {
            //                    CajaDialogo.Error("Ya se agregó el Cliente:" + item.NombreCliente);
            //                }
            //            }
            //            //ObtenerClientesById(Lista_precioActual.ID);
            //            ObtenerProductosForListaById(Lista_precioActual.ID);
            //        }
            //    }
            //    else
            //    {
            //        xfrmSelectProductos frm = new xfrmSelectProductos();

            //        if (frm.ShowDialog() == DialogResult.OK)
            //        {

            //            foreach (var item in frm.productos)
            //            {
            //                dsListaPrecios.ProductosRow row1 = dsListaPrecios.Productos.NewProductosRow();

            //                var existe_pt = from rows in dsListaPrecios.Productos.AsEnumerable()
            //                                group rows by new { ProductoID = rows["id_pt"] } into grp
            //                                where Convert.ToInt32(grp.Key.ProductoID) == item.ID
            //                                select new { Count = grp.Count() };

            //                if (existe_pt.Count() == 0)
            //                {
            //                    if (item.Precio > 0)
            //                    {

            //                        cnx.Open();
            //                        SqlCommand cmd3 = new SqlCommand("dbo.uspInsertListaPrecioProductosAplica_V2", cnx);
            //                        cmd3.CommandType = CommandType.StoredProcedure;

            //                        cmd3.Parameters.Add("@id_producto", SqlDbType.Int).Value = item.ID;
            //                        cmd3.Parameters.Add("@id_listaPrecio", SqlDbType.Int).Value = Lista_precioActual.ID;
            //                        cmd3.Parameters.Add("@fecha", SqlDbType.DateTime).Value = DateTime.Now;
            //                        cmd3.Parameters.Add("@usuario_id", SqlDbType.Int).Value = usuarioLogueado.Id;
            //                        cmd3.Parameters.Add("@precio", SqlDbType.Decimal).Value = item.Precio;
            //                        cmd3.Parameters.Add("@id_pdv", SqlDbType.Int).Value = item.PDV_ID;

            //                        cmd3.ExecuteNonQuery();
            //                        cnx.Close();
            //                    }
            //                    else
            //                    {
            //                        CajaDialogo.Error("No se agregó el producto: \"" + item.Producto + "\" ya que el precio se dejó en L 0.00");
            //                        //return;
            //                    }
            //                }
            //                else
            //                {
            //                    CajaDialogo.Error("Ya se agregó el Producto:" + item.Producto + " a al punto de venta:" + item.PDV);
            //                }

            //            }
            //            //ObtenerProductosById(Lista_precioActual.ID);
            //            ObtenerProductosForListaById(Lista_precioActual.ID);
            //        }
            //    }
            //}
        }

        private void btnDeleteProducto_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //if (XtraMessageBox.Show("DESEA ELIMINAR ESTE REGISTRO?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.No)
            //{
            //    try
            //    {

            //        switch (TipoTransaccionActual)
            //        {
            //            case TipoTipoTransaccionActual.Nuevo:

            //                gvProductos.DeleteRow(gvProductos.FocusedRowHandle);
            //                break;
            //            case TipoTipoTransaccionActual.Editar:
            //                DataOperations dp = new DataOperations();
            //                SqlConnection dbConnection = new SqlConnection(dp.ConnectionStringERP);

            //                if (xtraTabControl1.SelectedTabPage == tpProductos)
            //                {

            //                    var row = (dsListaPrecios.ProductosRow)gvProductos.GetFocusedDataRow();

            //                    using (SqlCommand command = new SqlCommand("dbo.uspDisableListaPrecioProductos", dbConnection))
            //                    {
            //                        dbConnection.Open();
            //                        command.CommandType = CommandType.StoredProcedure;
            //                        command.Parameters.Add("@id", SqlDbType.Int).Value = row.listaPrecios_ProductosAplica_id;

            //                        command.ExecuteNonQuery();
            //                        dbConnection.Close();

            //                        gvProductos.DeleteRow(gvProductos.FocusedRowHandle);
            //                    }
            //                    ObtenerProductosById(Lista_precioActual.ID);
            //                }
            //                break;
            //        }

            //    }
            //    catch (Exception ex)
            //    {
            //        CajaDialogo.Error(ex.Message);
            //    }
            //}
        }

        private void btnDelete_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (XtraMessageBox.Show("DESEA ELIMINAR ESTE REGISTRO?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection dbConnection = new SqlConnection(dp.ConnectionStringERP);

                    if (xtraTabControl1.SelectedTabPage == tpCliente)
                    {

                        var row = (dsListaPrecios.ClientesRow)gvCliente.GetFocusedDataRow();

                        using (SqlCommand command = new SqlCommand("dbo.uspDisableListaPrecioCliente ", dbConnection))
                        {
                            dbConnection.Open();
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add("@id", SqlDbType.Int).Value = row.id_listaPrecioCliente;

                            command.ExecuteNonQuery();
                            dbConnection.Close();

                            gvCliente.DeleteRow(gvCliente.FocusedRowHandle);
                        }
                        ObtenerClientesById(Lista_precioActual.ID);
                    }
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
            }
        }

        private void gvProductos_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //try
            //{
            //    var row = (dsListaPrecios.ProductosRow)gvProductos.GetFocusedDataRow();

            //    if (row != null)
            //    {
            //        if (row.listaPrecios_ProductosAplica_id > 0)
            //        {
            //            if (e.Column.FieldName == "precio")
            //            {
            //                DataOperations dp = new DataOperations();
            //                SqlConnection dbConnection = new SqlConnection(dp.ConnectionStringERP);

            //                using (SqlCommand command = new SqlCommand("dbo.uspUpdatePrecioFromListaPrecioProductosAplica", dbConnection))
            //                {
            //                    dbConnection.Open();
            //                    command.CommandType = CommandType.StoredProcedure;
            //                    command.Parameters.Add("@id", SqlDbType.Int).Value = row.listaPrecios_ProductosAplica_id;
            //                    command.Parameters.Add("@precio", SqlDbType.Decimal).Value = row.precio;

            //                    command.ExecuteNonQuery();
            //                    dbConnection.Close();

            //                    gvCliente.DeleteRow(gvCliente.FocusedRowHandle);
            //                }
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}

        }

        private bool ValidarListaExistente(int mes,int anio)
        {
            try
            {

            DataOperations dp = new DataOperations();
            SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP);

            bool existeLista;

            cnx.Open();
            SqlCommand cmd = new SqlCommand("dbo.uspValidateListaPrecioExistente",cnx);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@mes",SqlDbType.Int).Value=mes;
            cmd.Parameters.Add("@anio",SqlDbType.Int).Value=anio;
            cmd.Parameters.Add("@fechaInicio",SqlDbType.DateTime).Value=deDesde.EditValue;
            cmd.Parameters.Add("@fechaFin",SqlDbType.DateTime).Value=deHasta.EditValue;

            existeLista = (bool)cmd.ExecuteScalar();
            cnx.Close();

            return existeLista;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return false;
            }

        }

        private void ObtenerPDVs()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP))
                {
                    cnx.Open();

                    dsListaPrecios.PDV.Clear();

                    SqlDataAdapter da = new SqlDataAdapter("[dbo].sp_get_lista_puntos_de_venta", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    //da.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    da.Fill(dsListaPrecios.PDV);

                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        List<ListaPrecioProductosAplicaPDV> lista = new List<ListaPrecioProductosAplicaPDV>();
        private void btnTiendas_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //try
            //{
            //    switch (TipoTransaccionActual)
            //    {
            //        case TipoTipoTransaccionActual.Nuevo:
            //            var row = (dsListaPrecios.ProductosRow)gvProductos.GetFocusedDataRow();
            //            var listaFiltrada = lista.Where(d => d.PT_ID == row.id_pt).ToList();
            //            xfrmSelectPDV frm = new xfrmSelectPDV(xfrmSelectPDV.TipoTipoTransaccionActual.Nuevo,row.precio,row.descripcion,row.id_pt, listaFiltrada);
            //            if (frm.ShowDialog()== DialogResult.OK)
            //            {
            //                lista.RemoveAll(note => note.PT_ID == row.id_pt);

            //                foreach (var item in frm.lista)
            //                {
            //                    lista.Add(new ListaPrecioProductosAplicaPDV(){ 
            //                        PDV_ID=item.PDV_ID,
            //                        Precio=item.Precio,
            //                        PT_ID=item.PT_ID
            //                    });
            //                }
            //            } 
            //            break;
            //        case TipoTipoTransaccionActual.Editar:
            //            var row2 = (dsListaPrecios.ProductosRow)gvProductos.GetFocusedDataRow();
            //            xfrmSelectPDV frm2 = new xfrmSelectPDV(xfrmSelectPDV.TipoTipoTransaccionActual.Editar,row2.id_pdv, row2.id_listaPrecio, row2.id_pt, usuarioLogueado, row2.precio, row2.descripcion);
            //            frm2.ShowDialog();
            //            break;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
           
        }

        private void btnView_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //var row = (dsListaPrecios.ProductosRow)gvProductos.GetFocusedDataRow();

            //xfrmPDVAsignadasView frm = new xfrmPDVAsignadasView(row.id_listaPrecio,txtDescripcion.Text,row.descripcion,row.id_pt);
            //frm.ShowDialog();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var gridView = (GridView)gridControlProductos.FocusedView;
            var row = (dsListaPrecios.productos_precioRow)gridView.GetFocusedDataRow();

            LoadPuntosVentaProductoConfig(row.id_lista_h, row.id_pt);


            //Focus al primer Row
            if (dsListaPrecios.ListaPrecioPuntosDeVenta.Count > 0)
                gridView2.FocusedRowHandle = 0;


            gridView2.FocusedColumn = colpunto_venta_name;
            gridView2.ShowEditor();


            if (dsListaPrecios.ListaPrecioPuntosDeVenta.Count > 0)
            {
                //Focus al primer row
                var gridView3 = (GridView)gridControlPuntosVenta.FocusedView;
                var row3 = (dsListaPrecios.ListaPrecioPuntosDeVentaRow)gridView2.GetDataRow(0);
                LoadClientesProductoConfig(row3.id, row3.id_punto_venta);

                //gridView3.FocusedRowHandle = 0;

                //gridView3.FocusedColumn = colpunto_venta_name;
                //gridView3.ShowEditor();
            }
        }

        private void LoadPuntosVentaProductoConfig(int pIdListaPrecio, int pIdPT)
        {
            try
            {
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();

                dsListaPrecios.ListaPrecioPuntosDeVenta.Clear();
                SqlCommand cmd = new SqlCommand("dbo.sp_get_detalle_puntos__venta_pt_config", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_listaPrecio", pIdListaPrecio);
                cmd.Parameters.AddWithValue("@id_pt", pIdPT);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsListaPrecios.ListaPrecioPuntosDeVenta);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void gridView2_RowClick(object sender, RowClickEventArgs e)
        {
            var gridView = (GridView)gridControlPuntosVenta.FocusedView;
            var row = (dsListaPrecios.ListaPrecioPuntosDeVentaRow)gridView.GetDataRow(e.RowHandle);
            //LoadClientesProductoConfig(row.id_detalle_punto_venta);
            LoadClientesProductoConfig(row.id, row.id_punto_venta);
        }

        private void LoadClientesProductoConfig(Int64 pid_punto_venta_config, int pIdPV)
        {
            try
            {
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();

                dsListaPrecios.clientes_punto_venta.Clear();
                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_detalle_punto_venta_pt_config_cliente_v2]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_punto_venta_config", pid_punto_venta_config);
                cmd.Parameters.AddWithValue("@id_pv", pIdPV);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsListaPrecios.clientes_punto_venta);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            //var gridView = (GridView)gridControlProductos.FocusedView;
            //var row = (dsListaPrecios.productos_precioRow)gridView.GetFocusedDataRow();

            //LoadPuntosVentaProductoConfig(row.id_lista_h, row.id_pt);
        }

        private void xfrmListaPreciosCRUD_Activated(object sender, EventArgs e)
        {
            //switch (this.TipoTransaccionActual)
            //{
            //    case TipoTipoTransaccionActual.Nuevo:
            //        txtNombreListaPrecio.Focus();
            //        break;
            //}
        }

        private void cmdBorrarCliente_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControlClientes.FocusedView;
            var row = (dsListaPrecios.clientes_punto_ventaRow)gridView.GetFocusedDataRow();

            try
            {
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_set_delete_row_detalle_punto_venta_cliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_detalle_punto_venta_clientes", row.id_detalle_punto_venta_clientes);
                cmd.ExecuteNonQuery();
                con.Close();


                try
                {
                    gridView3.DeleteRow(gridView3.FocusedRowHandle);
                    dsListaPrecios.AcceptChanges();
                }
                catch 
                {
                }
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdBorrar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Deshabilitar el registro de punto de venta.
            //var gridView = (GridView)gridControlPuntosVenta.FocusedView;
            var row = (dsListaPrecios.ListaPrecioPuntosDeVentaRow)gridView2.GetFocusedDataRow();
            try
            {
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_set_update_detalle_punto_venta_borrar", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_ListaPrecios_PuntoVenta", row.id);
                cmd.ExecuteNonQuery();
                con.Close();


                try
                {
                    gridView2.DeleteRow(gridView2.FocusedRowHandle);
                    dsListaPrecios.AcceptChanges();
                }
                catch
                {
                }

                //Deshabilitar todos los clientes de ese punto de venta y producto deshabilitado
                dsListaPrecios.clientes_punto_venta.Clear();


            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }


            
        }

        private void cmdBorrarProducto_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //var gridView = (GridView)gridControlPuntosVenta.FocusedView;
            var rowProducto = (dsListaPrecios.productos_precioRow)gridView1.GetFocusedDataRow();
            using (SqlConnection connection = new SqlConnection(dp.ConnectionStringERP))
            {

                SqlTransaction transaction = null;
                try
                {
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();

                    // Start a local transaction.
                    transaction = connection.BeginTransaction("SampleTransaction");

                    command.Connection = connection;
                    command.Transaction = transaction;

                    command.CommandText =  "dbo.sp_set_update_detalle_producto_lista_precio_borrar";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id_detalle_lista", rowProducto.id_detalle_lista);
                    command.ExecuteNonQuery();
                    // Attempt to commit the transaction.
                    transaction.Commit();

                    connection.Close();

                    try
                    {
                        gridView1.DeleteRow(gridView1.FocusedRowHandle);
                        dsListaPrecios.AcceptChanges();
                    }
                    catch
                    {
                    }

                    //Borramos el grid de puntos de ventas
                    dsListaPrecios.ListaPrecioPuntosDeVenta.Clear();

                    //Borramos el grid de clientes puntos de venta
                    dsListaPrecios.clientes_punto_venta.Clear();
                }
                catch (Exception ec)
                {
                    try
                    {
                        transaction.Rollback();
                        CajaDialogo.Error(ec.Message);
                    }
                    catch (Exception ex2)
                    {
                        CajaDialogo.Error("Error 1: "+ ec.Message + " Error 2: "+ex2.Message);
                    }
                }
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            //Agregar Cliente
            if (dsListaPrecios.ListaPrecioPuntosDeVenta.Count > 0)
            {
                var row = (dsListaPrecios.ListaPrecioPuntosDeVentaRow)gridView2.GetFocusedDataRow();
                int v_punto_venta = row.id_punto_venta;
                long v_id_detalle_punto_venta = row.id;

                if (v_id_detalle_punto_venta>0)
                {
                    frmSearchDefault frmS = new frmSearchDefault(frmSearchDefault.TipoBusqueda.Clientes);
                    if (frmS.ShowDialog() == DialogResult.OK)
                    {
                        bool ExistePreviamente = false;
                        foreach (dsListaPrecios.clientes_punto_ventaRow rowB in dsListaPrecios.clientes_punto_venta)
                        {
                            if (rowB.cliente_nombre.ToLower() != "todos")
                            {
                                if (rowB.id_cliente == frmS.ItemSeleccionado.id)
                                {
                                    ExistePreviamente = true;
                                    break;
                                }
                            }
                        }

                        if (ExistePreviamente)
                        {
                            CajaDialogo.Error("Este cliente ya esta definido en este listado!");
                            return;
                        }

                        dsListaPrecios.clientes_punto_ventaRow row1 = dsListaPrecios.clientes_punto_venta.Newclientes_punto_ventaRow();
                        ClientesPuntoVentaLP ClienteLP = new ClientesPuntoVentaLP();
                        
                        ClienteLP.Precio = 0;
                        row1.precio = 0;
                        row1.cliente_nombre = frmS.ItemSeleccionado.ItemCode +" - " + frmS.ItemSeleccionado.ItemName;
                        row1.id_cliente = frmS.ItemSeleccionado.id;
                        ClienteLP.IdCliente = frmS.ItemSeleccionado.id;
                        row1.enable = true;
                        ClienteLP.Enable = true;
                        ClienteLP.DateWrited = dp.NowSetDateTime();
                        ClienteLP.IdUserWrited = this.usuarioLogueado.Id;
                        row1.id_detalle_punto_venta = ClienteLP.IdPtListaPrecioDetalle = v_id_detalle_punto_venta;
                        row1.id_detalle_punto_venta_clientes = ClienteLP.Id = ClienteLP.InsertRow();

                        dsListaPrecios.clientes_punto_venta.Addclientes_punto_ventaRow(row1);
                        dsListaPrecios.AcceptChanges();

                    }
                }
                else
                {
                    CajaDialogo.Error("Para agregar un cliente debe seleccionar o agregar un punto de venta!");
                }
            }
            else
            {
                CajaDialogo.Error("Para agregar un cliente debe seleccionar o agregar un punto de venta!");
            }
        }

        private void gridView3_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            switch(e.Column.FieldName) 
            {
                case "precio":
                    var row = (dsListaPrecios.clientes_punto_ventaRow)gridView3.GetFocusedDataRow();
                    if(row != null )
                    {
                        if(row.id_detalle_punto_venta_clientes> 0)//Es el id de la tabla donde se definen los clientes y precios.
                                                                  //[JAGUAR_DB].[dbo].[ListaPrecios_ProductosPuntoVenta_Clientes]
                        {
                            ClientesPuntoVentaLP cliente = new ClientesPuntoVentaLP();
                            if(cliente.RecuperarRegistro(row.id_detalle_punto_venta_clientes) )
                            {
                                cliente.Precio = dp.ValidateNumberDecimal(e.Value);
                                if( cliente.Precio > 0)
                                {
                                    cliente.UpdateRecord();
                                }
                            }
                        }
                    }
                    break;
            }
        }

        private void cmdAddPuntoVenta_Click(object sender, EventArgs e)
        {
            //Agregar Punto de Venta
            if (dsListaPrecios.productos_precio.Count > 0)
            {
                var row = (dsListaPrecios.productos_precioRow)gridView1.GetFocusedDataRow();
                int v_idDetalleLista = row.id_detalle_lista;
                int v_idpt = row.id_pt;

                if (v_idDetalleLista > 0)//Id de la tabla [JAGUAR_DB].[dbo].[ListaPrecios_ProductosAplica]
                {
                    frmSearchDefault frmS = new frmSearchDefault(frmSearchDefault.TipoBusqueda.PuntosDeVenta);
                    if (frmS.ShowDialog() == DialogResult.OK)
                    {
                        bool ExistePreviamente = false;
                        foreach (dsListaPrecios.ListaPrecioPuntosDeVentaRow rowB in dsListaPrecios.ListaPrecioPuntosDeVenta)
                        {
                            if (rowB.id_punto_venta == frmS.ItemSeleccionado.id)
                            {
                                ExistePreviamente = true;
                                break;
                            }
                        }

                        if (ExistePreviamente)
                        {
                            CajaDialogo.Error("Este Punto de Venta ya esta definido en este listado!");
                            return;
                        }

                        dsListaPrecios.ListaPrecioPuntosDeVentaRow row1 = dsListaPrecios.ListaPrecioPuntosDeVenta.NewListaPrecioPuntosDeVentaRow();
                        ListaPrecioPuntoVenta LP_PuntoVenta = new ListaPrecioPuntoVenta();

                        LP_PuntoVenta.Precio = 0;
                        row1.id_punto_venta = frmS.ItemSeleccionado.id;
                        row1.punto_venta_codigo = frmS.ItemSeleccionado.ItemCode;
                        row1.id_detalle_punto_venta = v_idDetalleLista;
                        row1.id_lista_h = this.Lista_precioActual.ID;
                        row1.punto_venta_name = frmS.ItemSeleccionado.ItemName;
                        
                        LP_PuntoVenta.Enable = true;
                        LP_PuntoVenta.CreatedDate = dp.NowSetDateTime();
                        LP_PuntoVenta.UsuarioId = this.usuarioLogueado.Id;
                        LP_PuntoVenta.IdPt = v_idpt;
                        LP_PuntoVenta.IdPdv = frmS.ItemSeleccionado.id;
                        LP_PuntoVenta.IdListaPrecio = this.Lista_precioActual.ID;
                        LP_PuntoVenta.IdLPProductosAplica = v_idDetalleLista;

                        row1.id = LP_PuntoVenta.Id = LP_PuntoVenta.InsertNewRow();

                        dsListaPrecios.ListaPrecioPuntosDeVenta.AddListaPrecioPuntosDeVentaRow(row1);
                        dsListaPrecios.AcceptChanges();

                    }
                }
                else
                {
                    CajaDialogo.Error("Para agregar un Punto de Venta debe seleccionar o agregar un Producto!");
                }
            }
            else
            {
                CajaDialogo.Error("Para agregar un Punto de Venta debe seleccionar o agregar un Producto!");
            }
        }

        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

        }
        void ActualizarDatosHeader()
        {
            if (string.IsNullOrEmpty(txtNombreListaPrecio.Text))
            {
                return;
            }

            if (Lista_precioActual != null)
            {
                if (Lista_precioActual.Recuperado)
                {
                    if (Lista_precioActual.ID > 0)
                    {
                        Lista_precioActual.Desde = Convert.ToDateTime(deDesde.EditValue);
                        Lista_precioActual.Hasta = Convert.ToDateTime(deHasta.EditValue);

                        Lista_precioActual.Descripcion = txtNombreListaPrecio.Text;

                        Lista_precioActual.ActualizarListaPrecios(Lista_precioActual.ID,
                                                                  Lista_precioActual.Descripcion,
                                                                  Lista_precioActual.Desde,
                                                                  Lista_precioActual.Hasta);

                    }
                }
            }
        }

        private void txtNombreListaPrecio_EditValueChanged(object sender, EventArgs e)
        {
            ActualizarDatosHeader();
        }

        private void deDesde_EditValueChanged(object sender, EventArgs e)
        {
            ActualizarDatosHeader();
        }


        private void deHasta_EditValueChanged_1(object sender, EventArgs e)
        {
            ActualizarDatosHeader();
        }
    }
}