using DevExpress.CodeParser;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using ERP_INTECOLI.Clases;
using ERP_INTECOLI.Facturacion.CoreFacturas;
using Infragistics.Win.Misc;
using JAGUAR_APP.Facturacion.CoreFacturas;
using JAGUAR_APP.Facturacion.Mantenimientos.Models;
using JAGUAR_APP.Facturacion.Numeracion_Fiscal;
using JAGUAR_APP.Facturacion.Reportes;
using JAGUAR_APP.Mantenimientos;
using LOSA.Calidad.LoteConfConsumo;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Data.Filtering.Helpers.SubExprHelper.ThreadHoppingFiltering;
using static DevExpress.DataProcessing.InMemoryDataProcessor.AddSurrogateOperationAlgorithm;
using static DevExpress.XtraPrinting.Native.ExportOptionsPropertiesNames;


namespace Eatery.Ventas
{
    public partial class frmFacturaBackup : Form
    {
        DataOperations dp = new DataOperations();
        PuntoVenta PuntoDeVentaActual;
        FacturacionEquipo EquipoActual;
        Int64 ProIdCliente;
        ClienteFacturacion ClienteFactura;

        UserLogin UsuarioLogeado;
        public enum Busqueda
        {
            LoMasVendido = 1,
            Todos = 2
        }

        Busqueda BusquedaSet;

        public frmFacturaBackup(UserLogin pUser, PuntoVenta pPuntoDeVentaActual, FacturacionEquipo pEquipoActual)
        {
            InitializeComponent();
            ClienteFactura = new ClienteFacturacion();

            PuntoDeVentaActual = pPuntoDeVentaActual;
            EquipoActual = pEquipoActual;

            BusquedaSet = Busqueda.LoMasVendido;
            SetBusqueda();
            txtNombreCliente.Text = "Consumidor Final";
            txtRTN.Text = string.Empty;
            txtRTN.Properties.NullValuePrompt =
            txtDireccion.Properties.NullValuePrompt = "No Aplica";

            UsuarioLogeado = pUser;
            lblfecha.Text = Convert.ToString(dp.NowSetDateTime());
            string.Format("{0:MM/dd/yyyy}", lblfecha.Text);

            string HostName = Dns.GetHostName();
            
            FacturacionEquipo Equipo1 = new FacturacionEquipo();
            if (Equipo1.RecuperarRegistro(HostName))
            {
                if (PuntoDeVentaActual.RecuperaRegistro(Equipo1.id_punto_venta))
                {
                    if (PuntoDeVentaActual.FacturaComidaBuffet)//Mostramos todas las opciones
                    {
                        lblOpcionesBuffetRadioButtonGroup.Visible =
                        radioGroupVentaComidaBuffet.Visible = true;
                        LoadDefaultOptionRadioButtos();
                    }
                    else
                    {
                        lblOpcionesBuffetRadioButtonGroup.Visible = 
                        radioGroupVentaComidaBuffet.Visible = false;
                        LoadDefaultOptionRadioButtos();
                    }
                }
            }
            //if (HostName == "7L12TV3" || HostName == "F3DYSQ2" /*Danys Oliva*/ ||
            //    HostName == "9SSCBV2" || HostName == "9PG91W2" /*Ruben Garcia */ ||
            //    HostName == "F9Q11Q2" /*PC Soporte La 50*/||
            //    HostName == "EUCEDA-PC" /*Euceda*/)
            //{
            //    cmdIngresarAdmin.Visible = SaltarLogin.Visible = simpleButton2.Visible = SaltarLoginPRD.Visible = true;
            //}
        }

        private void LoadDefaultOptionRadioButtos()
        {
            int HoraActualInt = DateTime.Now.Hour;
            if (HoraActualInt <= 10)
            {
                radioGroupVentaComidaBuffet.SelectedIndexChanged -= new EventHandler(radioGroupVentaComidaBuffet_SelectedIndexChanged);
                radioGroupVentaComidaBuffet.SelectedIndex = 0;//Desayuno
                radioGroupVentaComidaBuffet.SelectedIndexChanged += new EventHandler(radioGroupVentaComidaBuffet_SelectedIndexChanged);

                LoadOpcionesRapidas(1);
            }

            if (HoraActualInt > 10 && HoraActualInt <= 15)
            {
                radioGroupVentaComidaBuffet.SelectedIndexChanged -= new EventHandler(radioGroupVentaComidaBuffet_SelectedIndexChanged);
                radioGroupVentaComidaBuffet.SelectedIndex = 1;//Almuerzos
                radioGroupVentaComidaBuffet.SelectedIndexChanged += new EventHandler(radioGroupVentaComidaBuffet_SelectedIndexChanged);
                LoadOpcionesRapidas(1);
            }

            if (HoraActualInt > 15)
            {

                radioGroupVentaComidaBuffet.SelectedIndexChanged -= new EventHandler(radioGroupVentaComidaBuffet_SelectedIndexChanged);
                radioGroupVentaComidaBuffet.SelectedIndex = 2;//cenas
                radioGroupVentaComidaBuffet.SelectedIndexChanged += new EventHandler(radioGroupVentaComidaBuffet_SelectedIndexChanged);
                LoadOpcionesRapidas(1);
            }
        }

        private void pictAquafeed_Click(object sender, EventArgs e)
        {
            //Busqueda filtrando solo empleados de aquafeed
            //El parametro es el id de la compañia.
            //cuatro (4) es aquafeed
            BuscarCliente(4);
        }

        private void cmdAbrirBusqueda_Click(object sender, EventArgs e)
        {
            //Busqueda General
            //El parametro es el id de la compañia.
            //Cero (0) es todas
            BuscarCliente(0);
        }


        void BuscarCliente(int pParametro)
        {
            frmSearch frm = new frmSearch(frmSearch.TipoBusqueda.Clientes);
            if(frm.ShowDialog()== DialogResult.OK)
            {
                ProIdCliente = frm.ItemSeleccionado.id;
                if (ClienteFactura == null)
                    ClienteFactura = new ClienteFacturacion();

                if (ClienteFactura.RecuperarRegistro(frm.ItemSeleccionado.id))
                {
                    //txtNombreCliente.Text = ClienteFactura.Nombre;
                    //txtRTN.Text = ClienteFactura.rtn
                    ClienteEmpresa clienteEmpresa1 = new ClienteEmpresa();
                    if (clienteEmpresa1.RecuperarRegistro(frm.EmpresaID, ClienteFactura.Id))
                    {
                        txtNombreCliente.Text = clienteEmpresa1.NombreLargo;
                        txtRTN.Text = clienteEmpresa1.RTN;
                        txtDireccion.Text = clienteEmpresa1.Direccion;
                    }
                    else
                    {
                        txtNombreCliente.Text = ClienteFactura.NombreCliente;
                        txtDireccion.Text = ClienteFactura.Direccion;
                        txtRTN.Text = "";
                    }

                    if (dsVentas1.detalle_factura_transaction.Count > 0)
                    {
                        decimal AcumuladoTotalFactura = 0;
                        foreach (dsVentas.detalle_factura_transactionRow row1 in dsVentas1.detalle_factura_transaction)
                        {
                            ProductoTerminado pt1 = new ProductoTerminado();
                            if (pt1.Recuperar_producto(row1.id_pt))
                            {
                                row1.precio = PuntoDeVentaActual.RecuperarPrecioItem(row1.id_pt, PuntoDeVentaActual.ID, this.ClienteFactura.Id);

                                if (row1.precio == 0)
                                {
                                    SetErrorBarra("Este producto no tiene definido un precio. Por favor valide Lista de Precios!");
                                }

                                row1.descuento = 0;
                                row1.inventario = pt1.Recuperar_Cant_Inv_Actual_PT_for_facturacion(pt1.Id, this.PuntoDeVentaActual.ID);

                                row1.isv1 = row1.isv2 = row1.isv3 = 0;
                                Impuesto impuesto = new Impuesto();
                                decimal tasaISV = 0;

                                if (impuesto.RecuperarRegistro(pt1.Id_isv_aplicable))
                                {
                                    tasaISV = impuesto.Valor / 100;
                                    row1.isv1 = ((row1.precio - row1.descuento) / 100) * impuesto.Valor;
                                    row1.precio = (row1.precio - row1.descuento) - row1.isv1;

                                    row1.tasa_isv = tasaISV;
                                    row1.id_isv_aplicable = impuesto.Id;
                                }
                                else
                                {
                                    row1.tasa_isv = 0;
                                    row1.id_isv_aplicable = 0;
                                    row1.precio = (row1.precio - row1.descuento);
                                }

                                row1.total_linea = (row1.cantidad * row1.precio) + (row1.cantidad * row1.isv1) + (row1.cantidad * row1.isv2) + (row1.cantidad * row1.isv3);
                                AcumuladoTotalFactura += row1.total_linea;
                            }
                        }
                        txtTotal.Text = string.Format("{0:#,###,##0.00}", Math.Round(AcumuladoTotalFactura, 2));
                    }
                }
            }
        }

        private void cmdPlusAQ_Click(object sender, EventArgs e)
        {
            //txtCodigo.Focus();
            //txtCodigo.Text = "AQ";
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter) && (e.KeyChar != '.'))
            {
                CajaDialogo.Error("Solo se permiten numeros");
                e.Handled = true;
                return;
            }
        }

        private void cmdMas_Click(object sender, EventArgs e)
        {
            try
            {
                //int val = Convert.ToInt32(txtCantidad.Text);
                //val = val + 1;
                //txtCantidad.Text = val.ToString();
            }
            catch {}
        }

        private void cmdMenos_Click(object sender, EventArgs e)
        {
            try
            {
                //int val = Convert.ToInt32(txtCantidad.Text);
                //if (val >= 2)
                //    val = val - 1;
                //txtCantidad.Text = val.ToString();
            }
            catch { }
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string code = "";
                try
                {
                    //code = Convert.ToInt32(txtCodigo.Text).ToString();
                    code = "AQ" + code;
                }
                catch 
                {
                    //code = txtCodigo.Text;
                }

                Cliente Cliente1 = new Cliente();
                if (Cliente1.RecuperarRegistro(0))
                {
                    txtNombreCliente.Text = Cliente1.Nombre;
                    //txtCodigo.Text = code;
                    //txtCodigoProducto.Focus();
                    ProIdCliente = Cliente1.Id;
                    //ProId_company = Cliente1.Id_compania;
                    //ProApplySubsidio = Cliente1.ApplySubsidio;
                    //toggleTipoVenta.IsOn = false;
              
                }
                else
                {
                    txtNombreCliente.Text = "";
                    //txtCodigo.Text = "";
                    ProIdCliente = 0;
                }
            }
        }

        private void txtCodigo_Enter(object sender, EventArgs e)
        {
            //txtCodigo.Focus();
            //txtCodigo.SelectAll();
        }

        private void cmdBuscarProducto_Click(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void cmdAddWithValue_Click(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(txtCodigo.Text))
            //{
            //    try
            //    {
            //        AddWithValueProducto(Convert.ToInt32(txtCodigo.Text));
            //    }
            //    catch
            //    {
            //    }
            //}
        }

        private void AddWithValueProducto(int pIdProducto)
        {
            int id_producto = pIdProducto;
            bool existe = false;
            foreach (dsVentas.factura_detalleRow row in dsVentas1.factura_detalle.Rows)
            {
                if (id_producto == row.id_producto)
                {
                    existe = true;
                    if (!row.apply_subsidio)
                    {
                        row.cantidad = row.cantidad + 1;

                        //Validar inventario


                        //txtCodigoProducto.Text = "";
                        //txtCodigoProducto.Focus();
                    }
                    break;
                }
            }

            if (existe)
            {
                //Aumentó la cantidad
                CalcularTotal();
                //txtCodigoProducto.Text = "";
                //txtCodigoProducto.Focus();
            }
            else
            {
                //dsOrdenes.ordenes_dRow row1 = dsOrdenes1.ordenes_d.Newordenes_dRow();
                dsVentas.factura_detalleRow row1 = dsVentas1.factura_detalle.Newfactura_detalleRow();

                row1.id_producto = id_producto;
                ProductoTerminado Pro = new ProductoTerminado();
                if (Pro.Recuperar_producto(id_producto))
                {
                    row1.nombre = Pro.Descripcion;
                    row1.cantidad = 1;
                    //row1.apply_subsidio = Pro.ApplySubsidio;
                    //if (Pro.ApplySubsidio)
                    //{
                    //    Subsidio sub1 = new Subsidio();
                    //    row1.precio = (sub1.GetPrecioAsociadoFromSubsidio(ProId_company) + sub1.GetPrecioEmpresaFromSubsidio(ProId_company));
                    //    row1.subsidio = (-1 * sub1.GetPrecioEmpresaFromSubsidio(ProId_company));
                    //    //CalcularTotal();
                    //}
                    //else
                    //{
                    //    row1.precio = Pro.GetPrecioProducto(id_producto, ProId_company);
                    //    row1.subsidio = 0;
                    //}
                    row1.total_fila = row1.cantidad * row1.precio;

                    //dsOrdenes1.ordenes_d.AddWithValueordenes_dRow(row1);
                    //dsVentas1.factura_detalle.AddWithValuefactura_detalleRow(row1);
                    CalcularTotal();
                    //txtCodigoProducto.Text = "";
                    //txtCodigoProducto.Focus();
                }
            }
        }

        private void btnAddWithValue_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Sumar en cantidad
            //var gridView = (GridView)grMain.FocusedView;
            //var row = (dsVentas.factura_detalleRow)gridView.GetFocusedDataRow();
            ////int cant = row.cantidad;
            //if(!row.apply_subsidio)
            //    row.cantidad += 1;

            CalcularTotal();
        }

        private void btnRestar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Restar en cantidad
            //var gridView = (GridView)grMain.FocusedView;
            //var row = (dsVentas.factura_detalleRow)gridView.GetFocusedDataRow();
            //if (!row.apply_subsidio)
            //    if (row.cantidad > 1)
            //        row.cantidad -= 1;

            CalcularTotal();
        }

        public void SetErrorBarra(string msj)
        {
            lblMensaje.Text = msj;
            panelNotificacion.BackColor = Color.Red;
            timerLimpiarMensaje.Enabled = true;
            timerLimpiarMensaje.Start();
        }

        public void SetInformationBarra(string msj)
        {
            lblMensaje.Text = msj;
            lblMensaje.Visible = true;
            panelNotificacion.Visible = true;
            panelNotificacion.BackColor = Color.LightGreen;
            timerLimpiarMensaje.Enabled = true;
            timerLimpiarMensaje.Start();
        }

        private void cmdFacturar_Click(object sender, EventArgs e)
        {
            //txtNombreCliente
            //txtRTN
            DataOperations dp = new DataOperations();
            if (dp.ValidateStringIsNullOrEmpty(txtNombreCliente.Text))
            {
                SetErrorBarra("No se puede Facturar sin definir el nombre de cliente!");
                return;
            }

            if(ClienteFactura.Recuperado)
            //Vamos a verificar que el cliente tenga RTN
            {
                //if (dp.ValidateStringIsNullOrEmpty(txtRTN.Text))
                //{
                //    SetErrorBarra("Se ha seleccionado un cliente, pero se dejo vacio el campo RTN!");
                //    return;
                //}
                //if (dp.ValidateStringIsNullOrEmpty(txtNombreCliente.Text))
                //{
                //    SetErrorBarra("Se ha seleccionado un cliente, pero se dejo vacio el Nombre de cliente de forma manual, es un campo obligatorio!");
                //    return;
                //}
            }

            if (dp.ValidateNumberDecimal(txtTotal.Text)<=0)
            {
                SetErrorBarra("No se permite generar facturas con valor total cero(0)!");
                return;
            }

            //Validar disponibilidad de Inventario si el punto de venta lo tiene configurado
            if (PuntoDeVentaActual.BloqueoPorFaltaStock)
            {
                foreach (dsVentas.detalle_factura_transactionRow row in dsVentas1.detalle_factura_transaction.Rows)
                {
                    if(row.inventario < row.cantidad)
                    {
                        SetErrorBarra("Esta intentando facturar producto con menor existencia en Inventario!");
                        return;
                    }
                }
            }

            bool ImprimirFactura = false;
            Factura facturaGenerada = null;

            //Efectuar que se haga la facturacion en dos pasos, primero la factura y luego el pago
            if (PuntoDeVentaActual.EmisionFacturaDosPasos)
            {
                //Primero postear el pago
                frmConfirmationFactura frm2 = new frmConfirmationFactura(txtNombreCliente.Text, txtRTN.Text, txtDireccion.Text, dsVentaSuccess1.detalle_factura_transaction);
                if (frm2.ShowDialog() == DialogResult.OK)
                {
                    Factura factura = new Factura();
                    factura.RTN = frm2.RTN;
                    factura.ClienteNombre = frm2.NombreCliente;
                    factura.direccion_cliente = frm2.Direccion;
                    
                    if(ClienteFactura != null)
                        if(ClienteFactura.Id>0)
                            factura.IdCliente = ClienteFactura.Id;

                    factura.FechaDocumento = dp.NowSetDateTime();
                    //1   Emitida
                    //2   Pagada
                    //3   Anulada
                    factura.IdEstado = 1;
                    factura.CantidadImpresionesFactura = 0;
                    factura.IdUser = this.UsuarioLogeado.Id;
                    factura.IdPuntoVenta = this.PuntoDeVentaActual.ID;
                    factura.Enable = true;
                    factura.NumOrdenCompra = "";
                    int correlativoSiguiente = 0;
                    int id_numeracion = 0;

                    factura.descuentoTotalFactura = factura.subtotalFactura = 
                    factura.ISV1 = factura.ISV2 = 0;

                    foreach (dsVentas.detalle_factura_transactionRow row in dsVentas1.detalle_factura_transaction)
                    {
                        factura.subtotalFactura += dp.ValidateNumberDecimal((row.cantidad * row.precio));
                        factura.descuentoTotalFactura += dp.ValidateNumberDecimal(row.descuento);
                        factura.ISV1 += dp.ValidateNumberDecimal(row.isv1);
                        factura.ISV2 += dp.ValidateNumberDecimal(row.isv2);
                    }

                    //Generacion de numero de documento fiscal para la factura
                    NumeracionFiscal NumDocumentoFiscal = new NumeracionFiscal();

                    if (PuntoDeVentaActual.EmiteFacturaFiscal)
                    {
                        if (NumDocumentoFiscal.GetIdNumeracionFiscalFromPuntoVentaId(this.PuntoDeVentaActual.ID, NumeracionFiscal.TipoDocumentoFiscal.Factura))
                        {
                            id_numeracion = NumDocumentoFiscal.ID;
                            correlativoSiguiente = NumDocumentoFiscal.Correlative;

                            if (NumDocumentoFiscal.RecuperarRegistro(id_numeracion))
                            {
                                string sCorrelativo = correlativoSiguiente.ToString();

                                //Rellenar ceros a la izquierda
                                while (sCorrelativo.Length < 8)
                                {
                                    sCorrelativo = "0" + sCorrelativo;
                                }

                                factura.NumeroDocumento = NumDocumentoFiscal.Leyenda + sCorrelativo;
                                
                                //Guardamos el id del cual se genero el numero fiscal, por un tema de reporteria
                                factura.IdNumeracionFiscal = id_numeracion;
                            }
                        }
                    }
                    else
                    {
                        //Haremos un recibo de entrega 
                        string NumRecibo = PuntoDeVentaActual.CorrelativoRecibo.ToString();
                        while( NumRecibo.Length < 4)
                        {
                            NumRecibo = "0" + NumRecibo;
                        }

                        NumRecibo = this.PuntoDeVentaActual.Codigo + "_" + NumRecibo;
                        factura.NumeroDocumento = NumRecibo;
                        
                        //Guardamos el id del cual se genero el numero fiscal, por un tema de reporteria
                        factura.IdNumeracionFiscal = 0;
                    }

                    

                    //Vamos por el detalle de lineas para la factura y la transaccion
                    using (SqlConnection connection = new SqlConnection(dp.ConnectionStringERP))
                    {
                        connection.Open();

                        SqlCommand command = connection.CreateCommand();
                        SqlTransaction transaction;

                        // Start a local transaction.
                        transaction = connection.BeginTransaction("SampleTransaction");

                        // Must assign both transaction object and connection
                        // to Command object for a pending local transaction
                        command.Connection = connection;
                        command.Transaction = transaction;

                        try
                        {
                            //Guardamos el Header de la factura 
                            command.CommandText = "[dbo].[sp_set_insert_factura_header_punto_venta]";
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@numero_documento", factura.NumeroDocumento);
                            command.Parameters.AddWithValue("@enable", 1);
                            command.Parameters.AddWithValue("@id_estado", factura.IdEstado);
                            command.Parameters.AddWithValue("@cant_print", factura.CantidadImpresionesFactura);
                            command.Parameters.AddWithValue("@id_user", factura.IdUser);
                            command.Parameters.AddWithValue("@fecha_row", factura.FechaDocumento);
                            command.Parameters.AddWithValue("@fecha_documento", factura.FechaDocumento);
                            
                            if(factura.IdCliente==0)
                                command.Parameters.AddWithValue("@id_cliente", DBNull.Value);
                            else
                                command.Parameters.AddWithValue("@id_cliente", factura.IdCliente);

                            command.Parameters.AddWithValue("@RTN", factura.RTN);
                            command.Parameters.AddWithValue("@num_orden_compra", factura.NumOrdenCompra);
                            command.Parameters.AddWithValue("@id_punto_venta", this.PuntoDeVentaActual.ID);
                            
                            if(factura.IdNumeracionFiscal == 0)
                                command.Parameters.AddWithValue("@id_numeracion_fiscal", DBNull.Value);
                            else
                                command.Parameters.AddWithValue("@id_numeracion_fiscal", id_numeracion);

                            command.Parameters.AddWithValue("@cliente_nombre", factura.ClienteNombre);
                            command.Parameters.AddWithValue("@id_tipo_pago", DBNull.Value);

                            if (factura.IdNumeracionFiscal == 0)
                                command.Parameters.AddWithValue("@CAI", "N/D");
                            else
                                command.Parameters.AddWithValue("@CAI", NumDocumentoFiscal.CAI);

                            string FechaLimite = null;
                            if (factura.IdNumeracionFiscal == 0)
                                FechaLimite = string.Format("{0:dd/MM/yyyy}", factura.FechaDocumento);
                            else
                                FechaLimite = string.Format("{0:dd/MM/yyyy}", NumDocumentoFiscal.FechaVence);

                            command.Parameters.AddWithValue("@fecha_limite", FechaLimite);

                            if (factura.IdNumeracionFiscal == 0)
                                command.Parameters.AddWithValue("@rango_autorizado", "N/D");
                            else
                                command.Parameters.AddWithValue("@rango_autorizado", "desde: " + NumDocumentoFiscal.Numeracion_Inicial
                                                                                  + " hasta: " + NumDocumentoFiscal.Numeracion_Final);

                            command.Parameters.AddWithValue("@direccion_cliente", factura.direccion_cliente);
                            command.Parameters.AddWithValue("@subtotal", factura.subtotalFactura);
                            command.Parameters.AddWithValue("@descuento", factura.descuentoTotalFactura);
                            command.Parameters.AddWithValue("@isv1", factura.ISV1);
                            command.Parameters.AddWithValue("@isv2", factura.ISV2);
                            command.Parameters.AddWithValue("@id_formato_impresion", PuntoDeVentaActual.IdFormatoFactura);
                            command.Parameters.AddWithValue("@id_termino_pago", DBNull.Value);

                            if (factura.IdEstudiante == 0)
                                command.Parameters.AddWithValue("@id_estudiante", DBNull.Value);
                            else
                                command.Parameters.AddWithValue("@id_estudiante", factura.IdEstudiante);

                            if (factura.id_tipo_pago_electronico == 0)
                                command.Parameters.AddWithValue("@id_tipo_pago_electronico", DBNull.Value);
                            else
                                command.Parameters.AddWithValue("@id_tipo_pago_electronico", factura.id_tipo_pago_electronico);

                            Int64 IdFacturaH = Convert.ToInt64(command.ExecuteScalar());
                            decimal TotalFactura = 0;
                            factura.Id = IdFacturaH;

                            //Posteamos lineas de factura y Transaccion en Kardex
                            foreach(dsVentas.detalle_factura_transactionRow row in dsVentas1.detalle_factura_transaction)
                            {
                                command.CommandText = "dbo.sp_set_insert_factura__lineas__punto_venta_dos_pasos";
                                command.Parameters.Clear();
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@id_facturaH", IdFacturaH);
                                command.Parameters.AddWithValue("@id_pt", row.id_pt);
                                command.Parameters.AddWithValue("@item_code", row.itemcode);
                                command.Parameters.AddWithValue("@descripcion", row.itemname);
                                command.Parameters.AddWithValue("@cantidad", row.cantidad);
                                command.Parameters.AddWithValue("@precio", row.precio);
                                command.Parameters.AddWithValue("@descuento", row.descuento);
                                command.Parameters.AddWithValue("@impuesto1", row.isv1);
                                command.Parameters.AddWithValue("@impuesto2", row.isv2);
                                command.Parameters.AddWithValue("@impuesto3", row.isv3);
                                command.Parameters.AddWithValue("@total_linea", row.total_linea);
                                command.Parameters.AddWithValue("@id_punto_venta", this.PuntoDeVentaActual.ID);
                                command.Parameters.AddWithValue("@fecha_hora_row", factura.FechaDocumento);
                                command.Parameters.AddWithValue("@id_user", this.UsuarioLogeado.Id);

                                if(row.id_isv_aplicable>0)
                                    command.Parameters.AddWithValue("@id_isv_aplicado", row.id_isv_aplicable);
                                else
                                    command.Parameters.AddWithValue("@id_isv_aplicado", DBNull.Value);
                                TotalFactura += row.total_linea;
                                command.ExecuteNonQuery();
                            }

                            //Vamos a postear transaccion en estado de cuenta de cliente
                            if (factura.IdCliente > 0)
                            {
                                command.CommandText = "dbo.sp_set_insert_estado_cuenta_cliente";
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@num_doc", factura.NumeroDocumento);
                                command.Parameters.AddWithValue("@enable", 1);
                                command.Parameters.AddWithValue("@credito", 0);//Abonos
                                command.Parameters.AddWithValue("@debito", TotalFactura);//cargos
                                command.Parameters.AddWithValue("@concepto",string.Concat("Por Factura #",factura.NumeroDocumento));
                                command.Parameters.AddWithValue("@doc_date", factura.FechaDocumento);
                                command.Parameters.AddWithValue("@date_created", factura.FechaDocumento);
                                command.Parameters.AddWithValue("@id_user_created", this.UsuarioLogeado.Id);
                                command.Parameters.AddWithValue("@id_cliente", factura.IdCliente);
                                command.ExecuteNonQuery();
                            }

                            // Attempt to commit the transaction.
                            transaction.Commit();
                            //CajaDialogo.InformationAuto();

                            SetInformationBarra("Factura Generada con Exito!");

                            //Limpiar Datos
                            dsVentas1.detalle_factura_transaction.Clear();
                            ClienteFactura = new ClienteFacturacion();
                            cmdConsumidorFinal_Click(sender, e);
                        }
                        catch (Exception ex)
                        {
                            // Attempt to roll back the transaction.
                            try
                            {
                                transaction.Rollback();
                                CajaDialogo.Error(ex.Message);
                            }
                            catch (Exception ex2)
                            {
                                CajaDialogo.Error(ex2.Message);
                            }
                        }
                    }
                }
            }
            else
            {



                //PRIMERO EL PAGO LUEGO LA FACTURA


                //Sino, significa que primero el pago y despues la factura.
                frmConfirmationFactura frm2 = new frmConfirmationFactura(txtNombreCliente.Text, txtRTN.Text, txtDireccion.Text, dsVentaSuccess1.detalle_factura_transaction);
                if (frm2.ShowDialog() == DialogResult.OK)
                {
                    decimal ValorTotalFactura = dp.ValidateNumberDecimal(txtTotal.Text);

                    frmPagoFactura frm = new frmPagoFactura(this.UsuarioLogeado, ValorTotalFactura, this.PuntoDeVentaActual);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        Factura factura = new Factura();
                        factura.RTN = frm2.RTN;
                        factura.ClienteNombre = frm2.NombreCliente;
                        factura.direccion_cliente = frm2.Direccion;
                        factura.id_tipo_pago_electronico = frm.IdMetodoPagoElectronico;

                        if (ClienteFactura != null)
                            if (ClienteFactura.Id > 0)
                                factura.IdCliente = ClienteFactura.Id;

                        factura.FechaDocumento = dp.NowSetDateTime();
                        
                        //1   Emitida
                        //2   Pagada
                        //3   Anulada
                        factura.IdEstado = 2;

                        factura.CantidadImpresionesFactura = 0;
                        factura.IdUser = this.UsuarioLogeado.Id;
                        factura.IdPuntoVenta = this.PuntoDeVentaActual.ID;
                        factura.Enable = true;
                        factura.NumOrdenCompra = "";
                        factura.idFormatoFactura = this.PuntoDeVentaActual.IdFormatoFactura;

                        int correlativoSiguiente = 0;
                        int id_numeracion = 0;

                        //Generacion de numero de documento fiscal para la factura
                        NumeracionFiscal NumDocumentoFiscal = new NumeracionFiscal();

                        if (PuntoDeVentaActual.EmiteFacturaFiscal)
                        {
                            if (NumDocumentoFiscal.GetIdNumeracionFiscalFromPuntoVentaId(this.PuntoDeVentaActual.ID, NumeracionFiscal.TipoDocumentoFiscal.Factura))
                            {
                                id_numeracion = NumDocumentoFiscal.ID;
                                correlativoSiguiente = NumDocumentoFiscal.Correlative;

                                if (NumDocumentoFiscal.RecuperarRegistro(id_numeracion))
                                {
                                    string sCorrelativo = correlativoSiguiente.ToString();

                                    //Rellenar ceros a la izquierda
                                    while (sCorrelativo.Length < 8)
                                    {
                                        sCorrelativo = "0" + sCorrelativo;
                                    }

                                    factura.NumeroDocumento = NumDocumentoFiscal.Leyenda + sCorrelativo;
                                    //Guardamos el id del cual se genero el numero fiscal, por un tema de reporteria
                                    factura.IdNumeracionFiscal = id_numeracion;
                                }
                            }
                        }
                        else
                        {
                            //Haremos un recibo de entrega 
                            string NumRecibo = PuntoDeVentaActual.CorrelativoRecibo.ToString();
                            while (NumRecibo.Length < 4)
                            {
                                NumRecibo = "0" + NumRecibo;
                            }

                            NumRecibo = this.PuntoDeVentaActual.Codigo + "_" + NumRecibo;
                            factura.NumeroDocumento = NumRecibo;

                            //Guardamos el id del cual se genero el numero fiscal, por un tema de reporteria
                            factura.IdNumeracionFiscal = 0;
                        }

                        factura.descuentoTotalFactura = factura.subtotalFactura =
                        factura.ISV1 = factura.ISV2 = 0;

                        foreach (dsVentas.detalle_factura_transactionRow row in dsVentas1.detalle_factura_transaction)
                        {
                            factura.subtotalFactura += dp.ValidateNumberDecimal((row.cantidad * row.precio));
                            factura.descuentoTotalFactura += dp.ValidateNumberDecimal(row.descuento);
                            factura.ISV1 += dp.ValidateNumberDecimal(row.isv1);
                            factura.ISV2 += dp.ValidateNumberDecimal(row.isv2);
                        }


                        //Vamos por el detalle de lineas para la factura y la transaccion
                        using (SqlConnection connection = new SqlConnection(dp.ConnectionStringERP))
                        {
                            connection.Open();

                            SqlCommand command = connection.CreateCommand();
                            SqlTransaction transaction;

                            // Start a local transaction.
                            transaction = connection.BeginTransaction("SampleTransaction");

                            // Must assign both transaction object and connection
                            // to Command object for a pending local transaction
                            command.Connection = connection;
                            command.Transaction = transaction;

                            try
                            {
                                //Guardamos el Header de la factura 
                                command.CommandText = "[dbo].[sp_set_insert_factura_header_punto_venta]";
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@numero_documento", factura.NumeroDocumento);
                                command.Parameters.AddWithValue("@enable", 1);
                                command.Parameters.AddWithValue("@id_estado", factura.IdEstado);
                                command.Parameters.AddWithValue("@cant_print", factura.CantidadImpresionesFactura);
                                command.Parameters.AddWithValue("@id_user", factura.IdUser);
                                command.Parameters.AddWithValue("@fecha_row", factura.FechaDocumento);
                                command.Parameters.AddWithValue("@fecha_documento", factura.FechaDocumento);

                                if (factura.IdCliente == 0)
                                    command.Parameters.AddWithValue("@id_cliente", DBNull.Value);
                                else
                                    command.Parameters.AddWithValue("@id_cliente", factura.IdCliente);

                                command.Parameters.AddWithValue("@RTN", factura.RTN);
                                command.Parameters.AddWithValue("@num_orden_compra", factura.NumOrdenCompra);
                                command.Parameters.AddWithValue("@id_punto_venta", this.PuntoDeVentaActual.ID);

                                if (factura.IdNumeracionFiscal == 0)
                                    command.Parameters.AddWithValue("@id_numeracion_fiscal", DBNull.Value);
                                else
                                    command.Parameters.AddWithValue("@id_numeracion_fiscal", id_numeracion);

                                command.Parameters.AddWithValue("@cliente_nombre", factura.ClienteNombre);
                                command.Parameters.AddWithValue("@id_tipo_pago", (int)frm.TipoPagoSeleccionadoActual);

                                //command.Parameters.AddWithValue("@CAI", NumDocumentoFiscal.CAI);
                                if (factura.IdNumeracionFiscal == 0)
                                    command.Parameters.AddWithValue("@CAI", "N/D");
                                else
                                    command.Parameters.AddWithValue("@CAI", NumDocumentoFiscal.CAI);

                                //string FechaLimite = string.Format("{0:dd/MM/yyyy}", NumDocumentoFiscal.FechaVence);
                                string FechaLimite = null;
                                if (factura.IdNumeracionFiscal == 0)
                                    FechaLimite = string.Format("{0:dd/MM/yyyy}", factura.FechaDocumento);
                                else
                                    FechaLimite = string.Format("{0:dd/MM/yyyy}", NumDocumentoFiscal.FechaVence);

                                command.Parameters.AddWithValue("@fecha_limite", FechaLimite);
                                //command.Parameters.AddWithValue("@rango_autorizado", "desde: " + NumDocumentoFiscal.Numeracion_Inicial
                                //                                                  + " hasta: " + NumDocumentoFiscal.Numeracion_Final);
                                if (factura.IdNumeracionFiscal == 0)
                                    command.Parameters.AddWithValue("@rango_autorizado", "N/D");
                                else
                                    command.Parameters.AddWithValue("@rango_autorizado", "desde: " + NumDocumentoFiscal.Numeracion_Inicial
                                                                                      + " hasta: " + NumDocumentoFiscal.Numeracion_Final);

                                command.Parameters.AddWithValue("@direccion_cliente", factura.direccion_cliente);
                                command.Parameters.AddWithValue("@subtotal", factura.subtotalFactura);
                                command.Parameters.AddWithValue("@descuento", factura.descuentoTotalFactura);
                                command.Parameters.AddWithValue("@isv1", factura.ISV1);
                                command.Parameters.AddWithValue("@isv2", factura.ISV2);
                                command.Parameters.AddWithValue("@id_formato_impresion", PuntoDeVentaActual.IdFormatoFactura);
                                command.Parameters.AddWithValue("@id_termino_pago", DBNull.Value);

                                if (factura.IdEstudiante == 0)
                                    command.Parameters.AddWithValue("@id_estudiante", DBNull.Value);
                                else
                                    command.Parameters.AddWithValue("@id_estudiante", factura.IdEstudiante);

                                if (factura.id_tipo_pago_electronico == 0)
                                    command.Parameters.AddWithValue("@id_tipo_pago_electronico", DBNull.Value);
                                else
                                    command.Parameters.AddWithValue("@id_tipo_pago_electronico", factura.id_tipo_pago_electronico);


                                Int64 IdFacturaH = Convert.ToInt64(command.ExecuteScalar());
                                decimal TotalFactura = 0;
                                factura.Id = IdFacturaH;


                                //Posteamos lineas de factura y Transaccion en Kardex
                                foreach (dsVentas.detalle_factura_transactionRow row in dsVentas1.detalle_factura_transaction)
                                {
                                    command.CommandText = "dbo.sp_set_insert_factura__lineas__punto_venta_dos_pasos";
                                    command.Parameters.Clear();
                                    command.CommandType = CommandType.StoredProcedure;
                                    command.Parameters.AddWithValue("@id_facturaH", IdFacturaH);
                                    command.Parameters.AddWithValue("@id_pt", row.id_pt);
                                    command.Parameters.AddWithValue("@item_code", row.itemcode);
                                    command.Parameters.AddWithValue("@descripcion", row.itemname);
                                    command.Parameters.AddWithValue("@cantidad", row.cantidad);
                                    command.Parameters.AddWithValue("@precio", row.precio);
                                    command.Parameters.AddWithValue("@descuento", row.descuento);
                                    command.Parameters.AddWithValue("@impuesto1", row.isv1);
                                    command.Parameters.AddWithValue("@impuesto2", row.isv2);
                                    command.Parameters.AddWithValue("@impuesto3", row.isv3);
                                    command.Parameters.AddWithValue("@total_linea", row.total_linea);
                                    command.Parameters.AddWithValue("@id_punto_venta", this.PuntoDeVentaActual.ID);
                                    command.Parameters.AddWithValue("@fecha_hora_row", factura.FechaDocumento);
                                    command.Parameters.AddWithValue("@id_user", this.UsuarioLogeado.Id);
                                    if (row.id_isv_aplicable > 0)
                                        command.Parameters.AddWithValue("@id_isv_aplicado", row.id_isv_aplicable);
                                    else
                                        command.Parameters.AddWithValue("@id_isv_aplicado", DBNull.Value);

                                    TotalFactura += row.total_linea;
                                    command.ExecuteNonQuery();
                                }


                                //Vamos a postear transaccion en estado de cuenta de cliente
                                //if (factura.IdCliente > 0)
                                //{
                                //El cargo por la factura
                                command.CommandText = "dbo.sp_set_insert_estado_cuenta_cliente_v2";
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@num_doc", factura.NumeroDocumento);
                                command.Parameters.AddWithValue("@enable", 1);
                                command.Parameters.AddWithValue("@credito", 0);//Abonos
                                command.Parameters.AddWithValue("@debito", TotalFactura);//cargos
                                command.Parameters.AddWithValue("@concepto", string.Concat("Por Factura #", factura.NumeroDocumento));
                                command.Parameters.AddWithValue("@doc_date", factura.FechaDocumento);
                                command.Parameters.AddWithValue("@date_created", factura.FechaDocumento);
                                command.Parameters.AddWithValue("@id_user_created", this.UsuarioLogeado.Id);

                                //Cliente
                                if (factura.IdCliente == 0)
                                    command.Parameters.AddWithValue("@id_cliente", DBNull.Value);
                                else
                                    command.Parameters.AddWithValue("@id_cliente", factura.IdCliente);

                                command.Parameters.AddWithValue("@referencia", DBNull.Value);
                                command.ExecuteNonQuery();




                                //El pago de la misma ***********************************************
                                command.CommandText = "dbo.[sp_set_insert_estado_cuenta_cliente_v2]";
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@num_doc", factura.NumeroDocumento);
                                command.Parameters.AddWithValue("@enable", 1);
                                command.Parameters.AddWithValue("@credito", TotalFactura);//Abonos
                                command.Parameters.AddWithValue("@debito", 0);//cargos
                                command.Parameters.AddWithValue("@concepto", string.Concat("Pago de Factura #", factura.NumeroDocumento));
                                command.Parameters.AddWithValue("@doc_date", factura.FechaDocumento);
                                command.Parameters.AddWithValue("@date_created", factura.FechaDocumento);
                                command.Parameters.AddWithValue("@id_user_created", this.UsuarioLogeado.Id);

                                //Cliente
                                if (factura.IdCliente == 0)
                                    command.Parameters.AddWithValue("@id_cliente", DBNull.Value);
                                else
                                    command.Parameters.AddWithValue("@id_cliente", factura.IdCliente);

                                //Referencia
                                if (string.IsNullOrEmpty(frm.ReferenciaReciboPago))
                                    command.Parameters.AddWithValue("@referencia", DBNull.Value);
                                else
                                    command.Parameters.AddWithValue("@referencia", frm.ReferenciaReciboPago);

                                command.ExecuteNonQuery();
                                //}end  if (factura.IdCliente > 0)

                                // Attempt to commit the transaction.
                                transaction.Commit();
                                //CajaDialogo.InformationAuto();
                                SetInformationBarra("Factura Generada con Exito!");
                                ImprimirFactura = true;
                                facturaGenerada = factura;


                                //Limpiar Datos
                                dsVentas1.detalle_factura_transaction.Clear();
                                ClienteFactura = new ClienteFacturacion();
                                cmdConsumidorFinal_Click(sender, e);
                            }
                            catch (Exception ex)
                            {
                                // Attempt to roll back the transaction.
                                try
                                {
                                    transaction.Rollback();
                                    CajaDialogo.Error(ex.Message);
                                }
                                catch (Exception ex2)
                                {
                                    CajaDialogo.Error(ex2.Message);
                                }
                            }
                        }
                    }
                }
            }



            if (ImprimirFactura)
            {
                //rptFactura
                if (facturaGenerada != null)
                {
                    if (!string.IsNullOrEmpty(facturaGenerada.NumeroDocumento))
                    {
                        if (facturaGenerada.Id > 0)
                        {
                            rptFactura report = new rptFactura(facturaGenerada, rptFactura.TipoCopia.Blanco) { ShowPrintMarginsWarning = false };
                            report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                            ReportPrintTool printReport = new ReportPrintTool(report);
                            //printReport.ShowPreviewDialog();
                            printReport.Print();
                            facturaGenerada.UpdatePrintCount(facturaGenerada.Id);
                        }
                    }
                }
            }



            #region Codigo Original de Factura Base
            //SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
            //conn.Open();
            //SqlTransaction tran = conn.BeginTransaction();
            //try
            //{
            //    //Guardar encabezado de factura
            //    string sqlEnc = @"INSERT INTO  public.ventas
            //                                    (
            //                                      id_Cliente,
            //                                      fecha,
            //                                      id_usuario,
            //                                      tipo,
            //                                      contabilizado,
            //                                      totaltaxes,
            //                                      subtotal,
            //                                      print_count
            //                                    )
            //                                    VALUES (
            //                                      :id_Cliente,
            //                                      CURRENT_TIMESTAMP,
            //                                      :id_usuario,
            //                                      :tipo,
            //                                      false,
            //                                      :totaltaxes,
            //                                      :subtotal,
            //                                      :print_count
            //                                    ) returning id;";
            //    SqlCommand cmdE = new SqlCommand(sqlEnc, conn);
            //    cmdE.Parameters.AddWithValue("id_Cliente", 0);
            //    cmdE.Parameters.AddWithValue("id_usuario", 1);

            //    int tipoFactura = 2;//credito
            //    //if (toggleTipoVenta.IsOn)
            //    //    tipoFactura = 1;//contado

            //    cmdE.Parameters.AddWithValue("tipo", tipoFactura);
            //    cmdE.Parameters.AddWithValue("totaltaxes", 0);
            //    cmdE.Parameters.AddWithValue("subtotal", Convert.ToDecimal(txtTotal.Text));
            //    int print_recibo = 0;
            //    //if (toggleImprimeRecibo.IsOn)
            //    //    print_recibo = 1;
            //    cmdE.Parameters.AddWithValue("print_count", print_recibo);

            //    if (print_recibo >= 1)
            //        imprimirTicket = true;

            //    idFact = Convert.ToInt32(cmdE.ExecuteScalar());

            //    //Guardar detalle de Factura
            //    foreach(dsVentas.factura_detalleRow rowD in dsVentas1.factura_detalle)
            //    {
            //        string sqlD = @"INSERT INTO public.ventas_d
            //                                                (
            //                                                  id_venta,
            //                                                  cantidad,
            //                                                  precio_unit,
            //                                                  taxtotal,
            //                                                  subsidio,
            //                                                  id_producto,
            //                                                  linetotal,
            //                                                  id_receta
            //                                                )
            //                                                VALUES (
            //                                                  :id_venta,
            //                                                  :cantidad,
            //                                                  :precio_unit,
            //                                                  0,
            //                                                  :subsidio,
            //                                                  :id_producto,
            //                                                  :linetotal,
            //                                                  :id_receta
            //                                                );";
            //        SqlCommand cmdD = new SqlCommand(sqlD, conn);
            //        cmdD.Parameters.AddWithValue("id_venta",idFact);
            //        cmdD.Parameters.AddWithValue("cantidad",  rowD.cantidad);
            //        cmdD.Parameters.AddWithValue("precio_unit",  rowD.precio);
            //        cmdD.Parameters.AddWithValue("subsidio",  rowD.subsidio);
            //        cmdD.Parameters.AddWithValue("id_producto", rowD.id_producto);
            //        cmdD.Parameters.AddWithValue("linetotal",  rowD.total_fila);



            //        cmdD.ExecuteNonQuery();


            //        //Rebaja en el kardex de lo facturado
            //        string sqlK = @"INSERT INTO public.kardex
            //                                                (
            //                                                  id_producto,
            //                                                  entrada,
            //                                                  salida,
            //                                                  fecha_hora,
            //                                                  id_usuario,
            //                                                  id_venta,
            //                                                  id_lotetrans,
            //                                                  unit_price,
            //                                                  cantidad
            //                                                )
            //                                                VALUES (
            //                                                  :id_producto,
            //                                                  false,
            //                                                  true,
            //                                                  CURRENT_TIMESTAMP,
            //                                                  :id_usuario,
            //                                                  :id_venta,
            //                                                  :id_lotetrans,
            //                                                  :unit_price,
            //                                                  :cantidad
            //                                                );";
            //        SqlCommand cmdK = new SqlCommand(sqlK, conn);
            //        cmdK.Parameters.AddWithValue("id_producto",  rowD.id_producto);
            //        cmdK.Parameters.AddWithValue("id_usuario",  UsuarioLogeado.Id);
            //        cmdK.Parameters.AddWithValue("id_lotetrans",  DBNull.Value);
            //        cmdK.Parameters.AddWithValue("unit_price",  rowD.precio);
            //        cmdK.Parameters.AddWithValue("cantidad",  rowD.cantidad);
            //        cmdK.Parameters.AddWithValue("id_venta",  idFact);

            //        cmdK.ExecuteNonQuery();
            //    }


            //    tran.Commit();

            //    cmdNew_Click(new object(),new EventArgs());
            //    lblMensaje.Text = "Transacción Exitosa!";
            //    panelNotificacion.BackColor = Color.MediumSeaGreen;
            //    conn.Close();
            //    timerLimpiarMensaje.Enabled = true;
            //    timerLimpiarMensaje.Start();
            //}
            //catch (Exception ec)
            //{
            //    tran.Rollback();
            //    conn.Close();
            //    lblMensaje.Text = ec.Message;
            //    panelNotificacion.BackColor = Color.Red;
            //    timerLimpiarMensaje.Enabled = true;
            //    timerLimpiarMensaje.Start();
            //    CajaDialogo.Error(ec.Message);
            //}

            ////Impresion del ticket
            //if (imprimirTicket)
            //{
            //    Factura fact1 = new Factura();
            //    //dsReportesX factR = new dsReportesX();

            //    if (fact1.RecuperarRegistro(idFact))
            //    {
            //        //Recuperar el detalle de factura
            //        try
            //        {
            //            if(conn.State == ConnectionState.Closed)
            //            {
            //                conn.ConnectionString = dp.ConnectionStringERP;
            //                conn.Open();
            //            }


            //            string sql1 = @"SELECT 
            //                                 cantidad, 
            //                                 precio_unit as precio, 
            //                                 case when vv.subsidio>0 then vv.subsidio else vv.taxtotal end subsidio, 
            //                                 (SELECT case when LENGTH(nombre)>30 then substring(pp.nombre from 2 for 3) else pp.nombre end as name_
            //                                 FROM public.productos pp
            //                                 where pp.id = vv.id_producto) as descripcion, 
            //                                 (cantidad * precio_unit) as total
            //                            FROM public.ventas_d vv
            //                            where id_venta = :id_fact;";

            //            SqlCommand cmd1 = new SqlCommand(sql1, conn);
            //            cmd1.Parameters.AddWithValue("id_fact",  idFact);
            //            SqlDataAdapter adat = new SqlDataAdapter(cmd1);
            //            //factR.detalle_venta.Clear();
            //            //adat.Fill(factR.detalle_venta);

            //            //Cliente Cliente1 = new Cliente();
            //            //if (Cliente1.RecuperarRegistro(fact1.id_Cliente))
            //            //{
            //            //    POS_Ticket rpt = new POS_Ticket(DateTime.Now,
            //            //                                    Cliente1.codigo,
            //            //                                    Cliente1.nombre,
            //            //                                    fact1.GetValorSubtotal(idFact),
            //            //                                    fact1.GetValorSubsidio(idFact),
            //            //                                    fact1.subtotal)
            //            //    { DataSource = factR, DataMember = "detalle_venta", ShowPrintMarginsWarning = false };

            //            //    rpt.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            //            //    ReportPrintTool printReport = new ReportPrintTool(rpt);

            //            //    DBOps db = new DBOps();
            //            //    printReport.PrinterSettings.PrinterName = db.GetPrinterNameTicketsVenta();
            //            //    printReport.Print();
            //            //    //printReport.ShowPreview();
            //            //}
            //            conn.Close();
            //        }
            //        catch (Exception ec)
            //        {
            //            CajaDialogo.Error(ec.Message);
            //        }
            //    }
            //}
            #endregion

        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void toggleImprimeRecibo_Toggled(object sender, EventArgs e)
        {
        }

        private void CalcularTotal()
        {
            decimal total = 0;
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);

                if (Convert.ToBoolean(row["apply_subsidio"]))
                {
                    row["total_fila"] = (Convert.ToDecimal(row["cantidad"]) * Convert.ToDecimal(row["precio"]) - Math.Abs(Convert.ToDecimal(row["subsidio"]))  );
                }
                else
                {
                    row["total_fila"] = (Convert.ToDecimal(row["cantidad"]) * Convert.ToDecimal(row["precio"]));
                }
                
                //decimal Totfila = 
                total += Convert.ToDecimal(row["total_fila"]); ;
            }
            txtTotal.Text = string.Format("{0:#,##0.00}", Math.Round(total,2));
        }

        private void txtCodigoProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                //int ptipoVenta = Convert.ToInt32(ProTipoVentaActual);
                //frmBuscarProducto frm1 = new frmBuscarProducto(Connection, (frmBuscarProducto.TipoVenta)ptipoVenta);
                //if (frm1.ShowDialog() == DialogResult.OK)
                //{
                    //ProductoTerminado pro1 = new ProductoTerminado();
                    //if (pro1.Recuperar_productoByBarCode(txtCodigoProducto.Text))
                    //{
                    //    //Recuperado con exito
                    //    //txtCodigoProducto.Text = pro1.BarCode;
                    //    //txtNombreProducto.Text = pro1.Nombre;
                    //    //AddWithValueProducto(pro1.Id_p);
                    //}
                    //else
                    //{
                    //    //producto no existente o error
                    //    CajaDialogo.Error("No se pudo recuperar el registro del producto seleccionado!");
                    //}
                //}    
                CalcularTotal();
            }
        }

        private void btnEliminarFila_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //var gridView1 = (GridView)grMain.FocusedView;
            //var row = (dsVentas.factura_detalleRow)gridView1.GetFocusedDataRow();

            //try
            //{
            //    gridView1.DeleteRow(gridView1.FocusedRowHandle);
            //    CalcularTotal();
            //}
            //catch (Exception ec)
            //{
            //    CajaDialogo.Error(ec.Message);
            //}
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            panelNotificacion.BackColor = Color.White;
            txtRTN.Text = txtNombreCliente.Text = lblMensaje.Text = "";
            txtTotal.Text = "0.00";
            dsVentas1.detalle_factura_transaction.Clear();
            ClienteFactura = new ClienteFacturacion();
            CalcularTotalFactura();
        }

        private void timerLimpiarMensaje_Tick(object sender, EventArgs e)
        {
            timerLimpiarMensaje.Stop();
            timerLimpiarMensaje.Enabled = false;
            panelNotificacion.BackColor = Color.White;
            lblMensaje.Text = "";
            
            //cmdNew_Click(sender, e);
        }

        private void frmFacturaBackup_Activated(object sender, EventArgs e)
        {
            txtScanProducto.Focus();
        }

        private void toggleTipoVenta_Toggled(object sender, EventArgs e){}

        private void frmFacturaBackup_FormClosing(object sender, FormClosingEventArgs e){ }

        private void gridView2_RowStyle(object sender, RowStyleEventArgs e)
        {
        }

        private void LoadOpcionesRapidas(int pIdTipoVentanaFacturacion)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_get_lista_rapida_segun_tipo_ventana_facturacion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_tipo_facturacion", pIdTipoVentanaFacturacion);
                cmd.Parameters.AddWithValue("@id_tipo_buffet", radioGroupVentaComidaBuffet.SelectedIndex);
                
                dsVentas1.Buffet_TopProductos.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsVentas1.Buffet_TopProductos);
                con.Close();
                ultraTilePanel1.Tiles.Clear();

                int i = 1;
                foreach (dsVentas.Buffet_TopProductosRow row in dsVentas1.Buffet_TopProductos)
                {
                    //AddTilePanel(row.descripcion, i);
                    AddTilePanel(row.descripcion, row.id);
                    i++;
                }
                
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void AddTilePanel(string descripcion, int p_button)
        {
            UltraTile tile2 = new Infragistics.Win.Misc.UltraTile();

            //tile2.Settings.Appearance.BackColor = Color.Olive;
            //SimpleButton button2 = new SimpleButton();
            Font fuent1 = new Font("Microsoft Sans Serif", 14);

            //Estos botones son de cajon para ambas opciones
            SimpleButton simpleButton1 = new SimpleButton();
            SimpleButton simpleButton5 = new SimpleButton();
            SimpleButton simpleButton6 = new SimpleButton();

            if (!PuntoDeVentaActual.EmisionFacturaDosPasos) 
            {
                //Punto de venta de facturacion rapida y buffett
                //Estos botones solo son para 
                SimpleButton simpleButton2 = new SimpleButton();
                SimpleButton simpleButton3 = new SimpleButton();
                SimpleButton simpleButton4 = new SimpleButton();

                switch (p_button)
                {
                    case 1:
                        simpleButton1.Text = descripcion;
                        simpleButton1.Font = fuent1;
                        tile2.Control = simpleButton1;
                        break;
                    case 2:
                        simpleButton2.Text = descripcion;
                        simpleButton2.Font = fuent1;
                        tile2.Control = simpleButton2;
                        break;
                    case 3:
                        simpleButton3.Font = fuent1;
                        simpleButton3.Text = descripcion;
                        tile2.Control = simpleButton3;
                        break;
                    case 4:
                        simpleButton4.Font = fuent1;
                        simpleButton4.Text = descripcion;
                        tile2.Control = simpleButton4;
                        break;
                    case 5:
                        simpleButton5.Font = fuent1;
                        simpleButton5.Text = descripcion;
                        tile2.Control = simpleButton5;
                        break;
                    case 6:
                        simpleButton6.Font = fuent1;
                        simpleButton6.Text = descripcion;
                        tile2.Control = simpleButton6;
                        break;
                }

                simpleButton1.Click += new EventHandler(simpleButton1_Click_1);
                simpleButton2.Click += new EventHandler(simpleButton2_Click);
                simpleButton3.Click += new EventHandler(simpleButton3_Click);
                simpleButton4.Click += new EventHandler(simpleButton4_Click);
                simpleButton5.Click += new EventHandler(simpleButton5_Click);
                simpleButton6.Click += new EventHandler(simpleButton6_Click);
            }
            else
            {
                //Punto de Venta Normal sin comidas rapidas
                switch (p_button)
                {
                    case 1:
                        simpleButton1.Text = descripcion;
                        simpleButton1.Font = fuent1;
                        tile2.Control = simpleButton1;
                        break;
                    case 5:
                        simpleButton5.Font = fuent1;
                        simpleButton5.Text = descripcion;
                        tile2.Control = simpleButton5;
                        break;
                    case 6:
                        simpleButton6.Font = fuent1;
                        simpleButton6.Text = descripcion;
                        tile2.Control = simpleButton6;
                        break;
                }

                simpleButton1.Click += new EventHandler(simpleButton1_Click_1);
                simpleButton5.Click += new EventHandler(simpleButton5_Click);
                simpleButton6.Click += new EventHandler(simpleButton6_Click);

                //Ocultamos Radio Buttons box
                radioGroupVentaComidaBuffet.Visible = false;
            }



            #region Codigo Original de los tiles basicos
            //switch (p_button)
            //{
            //    case 1:
            //        simpleButton1.Text = descripcion;
            //        simpleButton1.Font = fuent1;
            //        tile2.Control = simpleButton1;
            //        break;
            //    case 2:
            //        simpleButton2.Text = descripcion;
            //        simpleButton2.Font = fuent1;
            //        tile2.Control = simpleButton2;
            //        break;
            //    case 3:
            //        simpleButton3.Font = fuent1;
            //        simpleButton3.Text = descripcion;
            //        tile2.Control = simpleButton3;
            //        break;
            //    case 4:
            //        simpleButton4.Font = fuent1;
            //        simpleButton4.Text = descripcion;
            //        tile2.Control = simpleButton4;
            //        break;
            //    case 5:
            //        simpleButton5.Font = fuent1;
            //        simpleButton5.Text = descripcion;
            //        tile2.Control = simpleButton5;
            //        break;
            //    case 6:
            //        simpleButton6.Font = fuent1;
            //        simpleButton6.Text = descripcion;
            //        tile2.Control = simpleButton6;
            //        break;
            //}

            //simpleButton1.Click += new EventHandler(simpleButton1_Click_1);
            //simpleButton2.Click += new EventHandler(simpleButton2_Click);
            //simpleButton3.Click += new EventHandler(simpleButton3_Click);
            //simpleButton4.Click += new EventHandler(simpleButton4_Click);
            //simpleButton5.Click += new EventHandler(simpleButton5_Click);
            //simpleButton6.Click += new EventHandler(simpleButton6_Click);
            #endregion


            //button2.Dock = DockStyle.Fill;
            tile2.State = TileState.Normal;
            tile2.Settings.ShowStateChangeButton = Infragistics.Win.DefaultableBoolean.False;
            
            //tile2.UseAppStyling = true;
            ultraTilePanel1.Tiles.Add(tile2);
            //ultraTilePanel1.Margin =pad1;

            ultraTilePanel1.TileSettings.MaximumSize = new Size(362, 100);
        }

        private void radioGroupVentaComidaBuffet_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadOpcionesRapidas(1);
            CargarOpcionesMasVendidas(2);
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //var gridView = (GridView)gridControlTop_ProductosBuffet.FocusedView;
            //var row = (dsVentas.Buffet_TopProductosRow)gridView.GetFocusedDataRow();

            //CajaDialogo.Information(row.descripcion);
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            //1=Lo mas vendido
            //2=Comida(s)
            //3=Bebidas Frias
            //4=Bebidas Calientes
            //5=PAN
            //6=Reposteria

            CargarOpcionesMasVendidasLeftPriority(1);
            txtScanProducto.Focus();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //Comidas
            CargarOpcionesMasVendidasLeftPriority(2);//1=Lo mas Vendido, 2=Comida(s), 3=Bebidas Frias, 4=Bebidas Calientes, 5=PAN, 6=Reposteria
            txtScanProducto.Focus();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            //Bebidas Frias
            CargarOpcionesMasVendidasLeftPriority(3);//1=Lo mas Vendido, 2=Comida(s), 3=Bebidas Frias, 4=Bebidas Calientes, 5=PAN, 6=Reposteria
            txtScanProducto.Focus();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            //Bebidas Calientes
            CargarOpcionesMasVendidasLeftPriority(4);//1=Lo mas Vendido, 2=Comida(s), 3=Bebidas Frias, 4=Bebidas Calientes, 5=PAN, 6=Reposteria
            txtScanProducto.Focus();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            //PAN
            CargarOpcionesMasVendidasLeftPriority(5);//1=Lo mas Vendido, 2=Comida(s), 3=Bebidas Frias, 4=Bebidas Calientes, 5=PAN, 6=Reposteria
            txtScanProducto.Focus();
        }
        private void simpleButton6_Click(object sender, EventArgs e)
        {
            //Reposteria
            CargarOpcionesMasVendidasLeftPriority(6);//1=Lo mas Vendido, 2=Comida(s), 3=Bebidas Frias, 4=Bebidas Calientes, 5=PAN, 6=Reposteria
            txtScanProducto.Focus();
        }

        private void CargarOpcionesMasVendidas(int pidClase)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();
                SqlCommand cmd;
                if (this.PuntoDeVentaActual.FacturaComidaBuffet)
                {
                    cmd = new SqlCommand("dbo.sp_get_productos_mas_vendidos_para_buffet", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@tipo_buffet", radioGroupVentaComidaBuffet.SelectedIndex + 1);
                    cmd.Parameters.AddWithValue("@id_clase", pidClase);
                    cmd.Parameters.AddWithValue("@ver_lo_mas_vendido", (Int32)BusquedaSet);
                }
                else
                {
                    cmd = new SqlCommand("[dbo].[sp_get_productos_mas_vendidos_para_factura_normal]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.AddWithValue("@tipo_buffet", radioGroupVentaComidaBuffet.SelectedIndex + 1);
                    //cmd.Parameters.AddWithValue("@id_clase", pidClase);
                    cmd.Parameters.AddWithValue("@ver_lo_mas_vendido", (Int32)BusquedaSet);
                }

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                dsVentas1.mas_vendidos.Clear();
                sqlDataAdapter.Fill(dsVentas1.mas_vendidos);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void CargarOpcionesMasVendidasLeftPriority(int pidClase)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.[sp_get_productos_mas_vendidos_para_buffet_class_priority]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@tipo_buffet", radioGroupVentaComidaBuffet.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@id_clase", pidClase);
                cmd.Parameters.AddWithValue("@ver_lo_mas_vendido", (Int32)BusquedaSet);
                cmd.Parameters.AddWithValue("@id_facturacion_dos_pasos", this.PuntoDeVentaActual.EmisionFacturaDosPasos);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                dsVentas1.mas_vendidos.Clear();
                sqlDataAdapter.Fill(dsVentas1.mas_vendidos);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdLoMasVendido_Click(object sender, EventArgs e)
        {
            BusquedaSet = Busqueda.LoMasVendido;
            SetBusqueda();
            CargarOpcionesMasVendidas(2);
            txtScanProducto.Focus();
        }

        private void SetBusqueda()
        {
            switch (BusquedaSet)
            {
                case Busqueda.LoMasVendido:
                    cmdTodosLosProductos.Appearance.BackColor = Color.White;
                    cmdLoMasVendido.Appearance.BackColor = Color.LightGreen;
                    break;
                case Busqueda.Todos:
                    cmdTodosLosProductos.Appearance.BackColor = Color.LightGreen;
                    cmdLoMasVendido.Appearance.BackColor = Color.White;
                    break;
            }
        }

        private void cmdTodosLosProductos_Click(object sender, EventArgs e)
        {
            BusquedaSet = Busqueda.Todos;
            SetBusqueda();
            txtScanProducto.Focus();
            CargarOpcionesMasVendidas(2);
        }

        private void cmdAddToCart_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //agregar al carrito para facturar 
            var gridView = (GridView)gridControl2.FocusedView;
            var row = (dsVentas.mas_vendidosRow)gridView.GetFocusedDataRow();

            decimal valor_total = 0;

            bool AgregarNuevo = true;
            foreach (dsVentas.detalle_factura_transactionRow rowF in dsVentas1.detalle_factura_transaction) 
            {
                if(rowF.id_pt == row.id_pt)
                {
                    //Sumar cantidad nada mas
                    rowF.cantidad = rowF.cantidad + 1;
                    rowF.isv1 = rowF.isv2 = rowF.isv3 = 0;
                    rowF.isv1 = ((rowF.cantidad * rowF.precio) - rowF.descuento) * rowF.tasa_isv;
                    rowF.total_linea = (rowF.cantidad * rowF.precio) - rowF.descuento + rowF.isv1 + rowF.isv2 + rowF.isv3;
                    AgregarNuevo = false;
                }
                valor_total += (rowF.total_linea + rowF.isv1);
                txtTotal.Text = string.Format("{0:#,###,##0.00}", Math.Round(valor_total,2));
            }

            if (AgregarNuevo)
            {
                dsVentas.detalle_factura_transactionRow row1 = dsVentas1.detalle_factura_transaction.Newdetalle_factura_transactionRow();
                //dsCompras.oc_d_normalRow row1 = dsCompras1.oc_d_normal.Newoc_d_normalRow();
                row1.id_pt = row.id_pt;
                row1.cantidad = 1;
                //row1.precio = 50;
                row1.precio = PuntoDeVentaActual.RecuperarPrecioItem(row1.id_pt, this.PuntoDeVentaActual.ID, this.ClienteFactura.Id);

                if (row1.precio == 0)
                {
                    SetErrorBarra("Este producto no tiene definido un precio. Por favor valide Lista de Precios!");
                }

                row1.descuento = 0;
                row1.itemcode = row.item_code;
                row1.itemname = row.descripcion;
                ProductoTerminado pt1= new ProductoTerminado();
                row1.inventario = pt1.Recuperar_Cant_Inv_Actual_PT_for_facturacion(row.id_pt, this.PuntoDeVentaActual.ID);

                row1.isv1 = row1.isv2 = row1.isv3 = 0;
                Impuesto impuesto = new Impuesto();
                decimal tasaISV = 0;

                if (impuesto.RecuperarRegistro(row.id_isv_aplicable))
                {
                    tasaISV = impuesto.Valor / 100;
                    row1.isv1 = ((row1.cantidad * row1.precio) - row1.descuento) * tasaISV;
                    row1.tasa_isv = tasaISV;
                    row1.id_isv_aplicable = impuesto.Id;
                }
                else
                {
                    row1.tasa_isv = 0;
                    row1.id_isv_aplicable = 0;
                }

                row1.total_linea = (row1.cantidad * row1.precio) - row1.descuento + row1.isv1 + row1.isv2 + row1.isv3;
                
                //dsCompras.oc_d_normal.Addoc_d_normalRow(row1);
                dsVentas1.detalle_factura_transaction.Adddetalle_factura_transactionRow(row1);
                valor_total += (row1.total_linea + row1.isv1);
                txtTotal.Text= string.Format("{0:#,###,##0.00}", Math.Round(valor_total,2));
            }
        }

        private void simpleButton1_Click_2(object sender, EventArgs e)
        {
            //frmSearch frm = new frmSearch(frmSearch.TipoBusqueda.ProductoTerminado);
            frmSearchDefault frm = new frmSearchDefault(frmSearchDefault.TipoBusqueda.ProductoTerminado, this.PuntoDeVentaActual);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //txtNombreCliente.Text = frm.ItemSeleccionado.ItemName;
                //ProIdCliente = frm.ItemSeleccionado.id;
                ProductoTerminado pt1 = new ProductoTerminado();
                if (pt1.Recuperar_producto(frm.ItemSeleccionado.id))
                {

                    decimal valor_total = 0;

                    bool AgregarNuevo = true;
                    foreach (dsVentas.detalle_factura_transactionRow rowF in dsVentas1.detalle_factura_transaction)
                    {
                        if (rowF.id_pt == frm.ItemSeleccionado.id)
                        {
                            //Sumar cantidad nada mas
                            rowF.inventario = pt1.Recuperar_Cant_Inv_Actual_PT_for_facturacion(pt1.Id, this.PuntoDeVentaActual.ID);
                            rowF.cantidad = rowF.cantidad + 1;
                            rowF.isv1 = rowF.isv2 = rowF.isv3 = 0;
                            rowF.isv1 = ((rowF.cantidad * rowF.precio) - rowF.descuento) * rowF.tasa_isv;
                            rowF.total_linea = (rowF.cantidad * rowF.precio) - rowF.descuento + rowF.isv1 + rowF.isv2 + rowF.isv3;
                            AgregarNuevo = false;
                        }
                        valor_total += (rowF.total_linea + rowF.isv1);
                        txtTotal.Text = string.Format("{0:#,###,##0.00}", Math.Round(valor_total,2));
                    }

                    if (AgregarNuevo)
                    {
                        dsVentas.detalle_factura_transactionRow row1 = dsVentas1.detalle_factura_transaction.Newdetalle_factura_transactionRow();
                        //dsCompras.oc_d_normalRow row1 = dsCompras1.oc_d_normal.Newoc_d_normalRow();
                        row1.id_pt = frm.ItemSeleccionado.id;
                        row1.cantidad = 1;
                        

                        row1.precio = PuntoDeVentaActual.RecuperarPrecioItem(row1.id_pt, PuntoDeVentaActual.ID, this.ClienteFactura.Id);

                        #region Calculo del precio base mas ISV
                        //if (row1.precio == 0)
                        //{
                        //    SetErrorBarra("Este producto no tiene definido un precio. Por favor valide Lista de Precios!");
                        //}

                        //row1.descuento = 0;
                        //row1.itemcode = frm.ItemSeleccionado.ItemCode;
                        //row1.itemname = frm.ItemSeleccionado.ItemName;
                        //row1.inventario = pt1.Recuperar_Cant_Inv_Actual_PT_for_facturacion(pt1.Id);

                        //row1.isv1 = row1.isv2 = row1.isv3 = 0;
                        //Impuesto impuesto = new Impuesto();
                        //decimal tasaISV = 0;

                        //if (impuesto.RecuperarRegistro(pt1.Id_isv_aplicable))
                        //{
                        //    tasaISV = impuesto.Valor / 100;
                        //    row1.isv1 = ((row1.cantidad * row1.precio) - row1.descuento) * tasaISV;
                        //    row1.tasa_isv = tasaISV;
                        //    row1.id_isv_aplicable = impuesto.Id;
                        //}
                        //else
                        //{
                        //    row1.tasa_isv = 0;
                        //    row1.id_isv_aplicable = 0;
                        //}

                        //row1.total_linea = (row1.cantidad * row1.precio) - row1.descuento + row1.isv1 + row1.isv2 + row1.isv3;
                        #endregion

                        if (row1.precio == 0)
                        {
                            SetErrorBarra("Este producto no tiene definido un precio. Por favor valide Lista de Precios!");
                        }

                        row1.descuento = 0;
                        row1.itemcode = frm.ItemSeleccionado.ItemCode;
                        row1.itemname = frm.ItemSeleccionado.ItemName;
                        row1.inventario = pt1.Recuperar_Cant_Inv_Actual_PT_for_facturacion(pt1.Id, this.PuntoDeVentaActual.ID);

                        row1.isv1 = row1.isv2 = row1.isv3 = 0;
                        Impuesto impuesto = new Impuesto();
                        decimal tasaISV = 0;

                        if (impuesto.RecuperarRegistro(pt1.Id_isv_aplicable))
                        {
                            tasaISV = impuesto.Valor / 100;
                            row1.isv1 = ((row1.precio - row1.descuento) / 100) * impuesto.Valor;
                            row1.precio = (row1.precio - row1.descuento) - row1.isv1;

                            row1.tasa_isv = tasaISV;
                            row1.id_isv_aplicable = impuesto.Id;
                        }
                        else
                        {
                            row1.tasa_isv = 0;
                            row1.id_isv_aplicable = 0;
                            row1.precio = (row1.precio - row1.descuento);
                        }

                        row1.total_linea = (row1.cantidad * row1.precio) + (row1.cantidad * row1.isv1) + (row1.cantidad * row1.isv2) + (row1.cantidad * row1.isv3);


                        //dsCompras.oc_d_normal.Addoc_d_normalRow(row1);
                        dsVentas1.detalle_factura_transaction.Adddetalle_factura_transactionRow(row1);
                        valor_total += (row1.total_linea + row1.isv1);
                        txtTotal.Text = string.Format("{0:#,###,##0.00}", Math.Round(valor_total,2));

                        if(dsVentas1.detalle_factura_transaction.Count>0)
                            gridView1.FocusedRowHandle = dsVentas1.detalle_factura_transaction.Count - 1;
                        else
                            gridView1.FocusedRowHandle = 0;

                        gridView1.FocusedColumn = colcantidad;
                        gridView1.ShowEditor();
                    }
                }
            }
        }

        private void cmdConsumidorFinal_Click(object sender, EventArgs e)
        {
            txtNombreCliente.Text = "Consumidor Final";
            txtRTN.Text =  
            txtDireccion.Text = string.Empty;

            txtDireccion.Properties.NullText = 
            txtRTN.Properties.NullText = "No Aplica";

            ClienteFactura = new ClienteFacturacion();
            ClienteFactura.Recuperado = false;
            ClienteFactura.ClearClass();
        }

        private void cmdDeleteRowFactura_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Button Click delete row in factura.
            DialogResult r = MessageBox.Show("¿Desea Eliminar esta linea?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r != DialogResult.Yes)
            {
                return;
            }

            var gridView1 = (GridView)gridControl1.FocusedView;
            var row = (dsVentas.detalle_factura_transactionRow)gridView1.GetFocusedDataRow();

            try
            {
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
                CalcularTotalFactura();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void navigationPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            CalcularTotalFactura();
        }

        decimal CalcularTotalFactura()
        {
            decimal total = 0;  
            foreach(dsVentas.detalle_factura_transactionRow row in dsVentas1.detalle_factura_transaction)
            {
                row.total_linea = (row.cantidad * row.precio) + (row.cantidad * row.isv1) + (row.cantidad * row.isv2) + (row.cantidad * row.isv3);
                total += row.total_linea;    
            }

            txtTotal.Text = string.Format("{0:#,###,##0.00}", Math.Round(total,2));
            return total;
        }

        private void txtScanProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if(string.IsNullOrEmpty(txtScanProducto.Text)) return;

            ProductoTerminado pt1 = new ProductoTerminado();
            if (pt1.Recuperar_productoByBarCode(txtScanProducto.Text))
            {
                decimal valor_total = 0;

                bool AgregarNuevo = true;
                foreach (dsVentas.detalle_factura_transactionRow rowF in dsVentas1.detalle_factura_transaction)
                {
                    if (rowF.id_pt == pt1.Id)
                    {
                        //Sumar cantidad nada mas
                        rowF.inventario = pt1.Recuperar_Cant_Inv_Actual_PT_for_facturacion(pt1.Id, this.PuntoDeVentaActual.ID);
                        rowF.cantidad = rowF.cantidad + 1;
                        rowF.isv1 = rowF.isv2 = rowF.isv3 = 0;
                        rowF.isv1 = ((rowF.cantidad * rowF.precio) - rowF.descuento) * rowF.tasa_isv;
                        rowF.total_linea = (rowF.cantidad * rowF.precio) - rowF.descuento + rowF.isv1 + rowF.isv2 + rowF.isv3;
                        AgregarNuevo = false;
                    }
                    valor_total += (rowF.total_linea + rowF.isv1);
                    txtTotal.Text = string.Format("{0:#,###,##0.00}", Math.Round(valor_total, 2));
                }

                if (AgregarNuevo)
                {
                    dsVentas.detalle_factura_transactionRow row1 = dsVentas1.detalle_factura_transaction.Newdetalle_factura_transactionRow();
                    //dsCompras.oc_d_normalRow row1 = dsCompras1.oc_d_normal.Newoc_d_normalRow();
                    row1.id_pt = pt1.Id;
                    row1.cantidad = 1;


                    row1.precio = PuntoDeVentaActual.RecuperarPrecioItem(row1.id_pt, PuntoDeVentaActual.ID, this.ClienteFactura.Id);

                    if (row1.precio == 0)
                    {
                        SetErrorBarra("Este producto no tiene definido un precio. Por favor valide Lista de Precios!");
                    }

                    row1.descuento = 0;
                    row1.itemcode = pt1.Code;
                    row1.itemname = pt1.Descripcion;
                    row1.inventario = pt1.Recuperar_Cant_Inv_Actual_PT_for_facturacion(pt1.Id, this.PuntoDeVentaActual.ID);

                    row1.isv1 = row1.isv2 = row1.isv3 = 0;
                    Impuesto impuesto = new Impuesto();
                    decimal tasaISV = 0;

                    if (impuesto.RecuperarRegistro(pt1.Id_isv_aplicable))
                    {
                        tasaISV = impuesto.Valor / 100;
                        row1.isv1 = ((row1.precio - row1.descuento) / 100) * impuesto.Valor;
                        row1.precio = (row1.precio - row1.descuento) - row1.isv1;

                        row1.tasa_isv = tasaISV;
                        row1.id_isv_aplicable = impuesto.Id;
                    }
                    else
                    {
                        row1.tasa_isv = 0;
                        row1.id_isv_aplicable = 0;
                        row1.precio = (row1.precio - row1.descuento);
                    }

                    row1.total_linea = (row1.cantidad * row1.precio) + (row1.cantidad * row1.isv1) + (row1.cantidad * row1.isv2) + (row1.cantidad * row1.isv3);


                    //dsCompras.oc_d_normal.Addoc_d_normalRow(row1);
                    dsVentas1.detalle_factura_transaction.Adddetalle_factura_transactionRow(row1);
                    valor_total += (row1.total_linea + row1.isv1);
                    txtTotal.Text = string.Format("{0:#,###,##0.00}", Math.Round(valor_total, 2));

                    if (dsVentas1.detalle_factura_transaction.Count > 0)
                        gridView1.FocusedRowHandle = dsVentas1.detalle_factura_transaction.Count - 1;
                    else
                        gridView1.FocusedRowHandle = 0;

                    txtScanProducto.Text = "";
                    gridView1.FocusedColumn = colcantidad;
                    gridView1.ShowEditor();
                }
            }
        }
    }
}