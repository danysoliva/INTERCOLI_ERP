using DevExpress.Charts.Native;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraEditors;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using ERP_INTECOLI.Clases;
using JAGUAR_APP.Facturacion.Mantenimientos;
using JAGUAR_APP.Facturacion.Mantenimientos.Models;
using JAGUAR_APP.Facturacion.Reportes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Data.Filtering.Helpers.SubExprHelper.ThreadHoppingFiltering;
using static DevExpress.DataProcessing.InMemoryDataProcessor.AddSurrogateOperationAlgorithm;

namespace JAGUAR_APP.Facturacion.CoreFacturas
{
    public partial class frmHomePagoMultipleSimple : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        PuntoVenta PuntoDeVentaActual;
        FacturacionEquipo EquipoActual;
        DataOperations dp;
        Cliente ClienteActual;
        public frmHomePagoMultipleSimple(UserLogin pUsuarioLogeado, PuntoVenta pPuntoDeVentaActual, FacturacionEquipo pEquipoActual)
        {
            InitializeComponent();
            dp = new DataOperations();
            this.UsuarioLogeado = pUsuarioLogeado;
            this.EquipoActual = pEquipoActual;
            this.PuntoDeVentaActual = pPuntoDeVentaActual;

            DateTime NowDate = dp.NowSetDateTime();
            dtDesde.EditValueChanged -= new EventHandler(dtDesde_EditValueChanged);
            dtDesde.EditValue = new DateTime(NowDate.Year, NowDate.Month, NowDate.Day, 0, 0, 0);
            dtDesde.EditValueChanged += new EventHandler(dtDesde_EditValueChanged);

            dtHasta.EditValueChanged -= new EventHandler(dtHasta_EditValueChanged);
            NowDate = NowDate.AddDays(1);
            dtHasta.EditValue = new DateTime(NowDate.Year, NowDate.Month, NowDate.Day, 0, 0, 0);
            dtHasta.EditValueChanged += new EventHandler(dtHasta_EditValueChanged);

            LoadRecibos();
            LoadTipoPagos();
            ObtenerClientes();

            //Habilita o deshabilita que el user pueda manipular el menu haciendo clic derecho sobre el header de una columna, para elegir columnas, ordenar, etc
            gvFacturas.OptionsMenu.EnableColumnMenu = false;
            gleCliente.Focus();
        }
        private void ObtenerClientes()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP))
                {
                    cnx.Open();

                    dsFacturasGestion1.clientes_factura.Clear();

                    SqlDataAdapter da = new SqlDataAdapter("[dbo].[uspObtenerClientesFacturacionV2]", cnx);
                    da.Fill(dsFacturasGestion1.clientes_factura);

                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadTipoPagos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_tipo_pago_facturas]", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsFacturasGestion1.tipo_pago_factura.Clear();
                adat.Fill(dsFacturasGestion1.tipo_pago_factura);

                con.Close();

                if(dsFacturasGestion1.tipo_pago_factura.Count > 0)
                {
                    try
                    {
                        gleTipoPago.EditValueChanged -= new EventHandler(gleTipoPago_EditValueChanged);
                        gleTipoPago.EditValue = 1;
                        gleTipoPago.EditValueChanged += new EventHandler(gleTipoPago_EditValueChanged);
                    }
                    catch { }
                }
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void Loadfacturas()
        {
            if (ClienteActual == null) return;

            if (!ClienteActual.Recuperado) return;

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();

                //SqlCommand cmd = new SqlCommand("[dbo].[sp_get_home_facturacion_punto_venta_v2]", con);
                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_home_facturacion_punto_venta_by_cliente]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_cliente", this.ClienteActual.Id);
                //cmd.Parameters.AddWithValue("@desde", dtDesde.EditValue);
                //cmd.Parameters.AddWithValue("@hasta", dtHasta.EditValue);

                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsFacturasGestion1.HomeFacturas.Clear();
                adat.Fill(dsFacturasGestion1.HomeFacturas);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadRecibos()
        {
            //if (string.IsNullOrEmpty(dtDesde.Text))
            //    return;

            //if (string.IsNullOrEmpty(dtHasta.Text))
            //    return;

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_header_recibosH_all]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_punto_venta", this.PuntoDeVentaActual.ID);
                cmd.Parameters.AddWithValue("@desde", dtDesde.EditValue);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.EditValue);

                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsFacturasGestion1.RecibosH.Clear();
                adat.Fill(dsFacturasGestion1.RecibosH);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            Loadfacturas();
            LoadRecibos();
        }

        private void cmdExportToExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                gridControl1.ExportToXlsx(dialog.FileName);
        }

        private void dtDesde_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dtHasta_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnImprimir_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                //var row = (dsFacturasGestion.HomeFacturasRow)gridView1.GetFocusedDataRow();

                //var gridView = (GridView)gvFacturas.FocusedView;
                var row = (dsFacturasGestion.HomeFacturasRow)gvFacturas.GetFocusedDataRow();

                Factura factura = new Factura();

                xfrmDialogFormatoFactura frm = new xfrmDialogFormatoFactura(row.id);

                frm.ShowDialog();

                //if (factura.RecuperarRegistro(row.id))
                //{
                //    if (factura.CantPrint == 0)
                //    {
                //        rptFactura report = new rptFactura(factura, rptFactura.TipoCopia.Blanco);

                //        using (ReportPrintTool printTool = new ReportPrintTool(report))
                //        {
                //            // Send the report to the default printer.
                //            factura.UpdatePrintCount(row.id);
                //            printTool.ShowPreviewDialog();
                //        }
                //    }
                //    else
                //    {
                //        CajaDialogo.Error("Esta factura ya se imprimió! Para una reimpresión debe solicitar una autorización!");
                //    }
                //}
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdPagarFactura_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var row = (dsFacturasGestion.HomeFacturasRow)gvFacturas.GetFocusedDataRow();
            //Estados de Factura
            //1=Emitida
            //2=Pagada
            //3=Anulada

            bool ActivarReturn = false;
            switch (row.id_estado)
            {
                //case 1:
                //    break; 
                case 2://2=Pagada
                    ActivarReturn = true;
                    CajaDialogo.Error("Esta Factura ya fue pagada, No se puede pagar nuevamente!");

                    break; 
                case 3://3=Anulada
                    ActivarReturn = true;
                    CajaDialogo.Error("Esta factura ya fue Anulada, No se puede efectuar el pago!");
                    break;
            }

            if (ActivarReturn)
                return;
            PuntoVenta puntoVentaFactura = new PuntoVenta();
            if (puntoVentaFactura.RecuperaRegistro(row.id_punto_venta))
            {
                Factura factura = new Factura();
                if (factura.RecuperarRegistro(row.id))
                {
                    //frmPagoFactura frm = new frmPagoFactura(this.UsuarioLogeado, row.TotalFactura, puntoVentaFactura);
                    frmPagoFactura frm = new frmPagoFactura(this.UsuarioLogeado, row.saldo, puntoVentaFactura);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        bool TransaccionExitosa = false;
                        int IdTipoPago = 0;
                        Int64 IdReciboH_Inserted=0;

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
                                //Vamos a postear transaccion en estado de cuenta de cliente
                                if (factura.IdCliente > 0)
                                {
                                    //El pago de la misma
                                    command.CommandText = "dbo.[sp_set_insert_estado_cuenta_cliente_v2]";
                                    command.CommandType = CommandType.StoredProcedure;
                                    command.Parameters.Clear();
                                    command.Parameters.AddWithValue("@num_doc", factura.NumeroDocumento);
                                    command.Parameters.AddWithValue("@enable", 1);
                                    command.Parameters.AddWithValue("@credito", frm.varPago);//Abonos
                                    command.Parameters.AddWithValue("@debito", 0);//cargos
                                    command.Parameters.AddWithValue("@concepto", string.Concat("Pago de Factura #", factura.NumeroDocumento));
                                    command.Parameters.AddWithValue("@doc_date", factura.FechaDocumento);
                                    command.Parameters.AddWithValue("@date_created", factura.FechaDocumento);
                                    command.Parameters.AddWithValue("@id_user_created", this.UsuarioLogeado.Id);
                                    command.Parameters.AddWithValue("@id_cliente", factura.IdCliente);

                                    if(string.IsNullOrEmpty(frm.ReferenciaReciboPago))
                                        command.Parameters.AddWithValue("@referencia", DBNull.Value);
                                    else
                                        command.Parameters.AddWithValue("@referencia", frm.ReferenciaReciboPago);

                                    command.ExecuteNonQuery();

                                }

                                command.CommandText = "[dbo].[sp_set_update_estado_factura_h]";
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@id_factura", factura.Id);
                                command.Parameters.AddWithValue("@id_estado", 2);//Pagada
                                IdTipoPago = (int)frm.TipoPagoSeleccionadoActual;
                                command.Parameters.AddWithValue("@id_tipo_pago", IdTipoPago);
                                command.ExecuteNonQuery();





                                //Postear el recibo para homologar toda la recepcion de valores
                                command.CommandText = "dbo.sp_set_insert_new_recibo_pago_h";
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@id_usuario_created", this.UsuarioLogeado.Id);
                                command.Parameters.AddWithValue("@concepto", "Pago a Facturas");

                                if (factura.IdCliente == 0)
                                    command.Parameters.AddWithValue("@id_cliente", DBNull.Value);
                                else
                                    command.Parameters.AddWithValue("@id_cliente", factura.IdCliente);

                                command.Parameters.AddWithValue("@fecha_created", dp.NowSetDateTime());
                                command.Parameters.AddWithValue("@id_punto_venta", this.PuntoDeVentaActual.ID);
                                command.Parameters.AddWithValue("@valor", frm.varPago);
                                command.Parameters.AddWithValue("@id_tipo_pago", (int)frm.TipoPagoSeleccionadoActual);
                                command.Parameters.AddWithValue("@id_formato_impresion", this.PuntoDeVentaActual.IdFormatoFactura);
                                
                                if (string.IsNullOrEmpty(frm.ReferenciaReciboPago))
                                    command.Parameters.AddWithValue("@referencia", DBNull.Value);
                                else
                                    command.Parameters.AddWithValue("@referencia", frm.ReferenciaReciboPago);

                                IdReciboH_Inserted = Convert.ToInt64(command.ExecuteScalar());

                                //Posteamos la linea del recibo.
                                command.CommandText = "dbo.sp_set_insert_recibo_pago_detalle";
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@num_doc", factura.NumeroDocumento);
                                command.Parameters.AddWithValue("@valor", frm.varPago);
                                command.Parameters.AddWithValue("@date_created", dp.NowSetDateTime());
                                command.Parameters.AddWithValue("@id_recibo_h", IdReciboH_Inserted);
                                command.Parameters.AddWithValue("@id_usuario", this.UsuarioLogeado.Id);

                                if (factura.IdCliente == 0)
                                    command.Parameters.AddWithValue("@id_cliente", DBNull.Value);
                                else
                                    command.Parameters.AddWithValue("@id_cliente", factura.IdCliente);

                                if (string.IsNullOrEmpty(frm.ReferenciaReciboPago))
                                    command.Parameters.AddWithValue("@referencia", DBNull.Value);
                                else
                                    command.Parameters.AddWithValue("@referencia", frm.ReferenciaReciboPago);
                                command.ExecuteNonQuery();
                                







                                TransaccionExitosa = true;

                                // Attempt to commit the transaction.
                                transaction.Commit();
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
                        }//En Using Connection

                        //Vamos a notificar de la factura efectuada y actualizar el row Status
                        if (TransaccionExitosa)
                        {
                            row.id_estado = 1;
                            row.EstadoName = "Pagada";

                            //Tabla [JAGUAR_DB].[dbo].[Facturacion_Tipo_Pago]
                            //1   Efectivo
                            //2   Tarjeta
                            //3   Depósito Bancario
                            
                            row.id_tipo_pago = IdTipoPago;

                            switch (IdTipoPago)
                            {
                                case 1:
                                    row.TipoPagoName = "Efectivo";
                                    break;
                                case 2:
                                    row.TipoPagoName = "Tarjeta";
                                    break;
                                case 3:
                                    row.TipoPagoName = "Depósito Bancario";
                                    break;
                            }


                            if (IdReciboH_Inserted > 0)
                            {
                                ReciboH rec1 = new ReciboH();
                                if (rec1.RecuperarRegistro(IdReciboH_Inserted))
                                {
                                    dsFacturasGestion.RecibosHRow row1 = dsFacturasGestion1.RecibosH.NewRecibosHRow();
                                    row1.id_recibo = IdReciboH_Inserted;
                                    row1.num_doc = rec1.NumeroDocumento;
                                    row1.enable = rec1.Enable;
                                    row1.id_usuario_created = rec1.IdUsuarioCreated;
                                    row1.usuario_creador = row1.usuario_ultima_modificacion = rec1.UsuarioCreador;
                                    row1.concepto = rec1.Concepto;
                                    row1.id_cliente = rec1.IdCliente;
                                    row1.NombreCliente = rec1.NombreCliente;
                                    row1.fecha_created = rec1.FechaCreated;
                                    row1.id_punto_venta = rec1.IdPuntoVenta;
                                    row1.valor = rec1.Valor;
                                    row1.id_tipo_pago = rec1.IdTipoPago;
                                    row1.tipo_pago_descripcion = rec1.TipoPagoDescripcion;
                                    row1.id_formato_impresion = rec1.IdFormatoImpresion;
                                    row1.tipo_formato_impresion = rec1.TipoFormatoImpresion;
                                    row1.punto_venta_code = rec1.punto_venta_code;
                                    row1.punto_venta_nombre = rec1.punto_venta_nombre;

                                    dsFacturasGestion1.RecibosH.AddRecibosHRow(row1);

                                    //Vamos a modificar el saldo del registro que llevamos para pago multiple y el estado
                                    //Posteamos las lineas del recibo.

                                    foreach (dsFacturasGestion.HomeFacturasRow rowF in dsFacturasGestion1.HomeFacturas)
                                    {
                                        if (rowF.seleccionado)
                                        {

                                            if (rowF.numero_documento == row.numero_documento)
                                            {
                                                rowF.saldo = rowF.saldo - frm.varPago;
                                                Factura factx = new Factura();
                                                if (factx.RecuperarRegistro(rowF.id))
                                                {
                                                    FacturaEstado estado1 = new FacturaEstado();
                                                    //Para el update de estado en la factura
                                                    if (rowF.saldo == 0) //Pagada Completamente
                                                    {
                                                        rowF.id_estado = 0;
                                                        //Actualizamos a factura pagada.
                                                        factx.UpdateFacturaStatus(rowF.id, 2, rec1.IdTipoPago);
                                                        rowF.id_estado = 2;

                                                        if (estado1.RecuperarRegistro(2))
                                                            rowF.EstadoName = estado1.Descripcion;
                                                    }
                                                    else
                                                    {
                                                        if (rowF.saldo <= rowF.TotalFactura)//Factura con abonos
                                                        {
                                                            //Actualizamos a que es una factura con abonos
                                                            factx.UpdateFacturaStatus(rowF.id, 4, rec1.IdTipoPago);
                                                            if (estado1.RecuperarRegistro(4))
                                                                rowF.EstadoName = estado1.Descripcion;
                                                        }
                                                    }
                                                }
                                            }
                                            
                                        }
                                    }

                                    dsFacturasGestion1.AcceptChanges();
                                }

                            }


                            CajaDialogo.InformationAuto();
                        }
                    }
                }//End If recuperar Factura
            }//End If recuperar Punto de Venta Factura



        }

        private void btnAutorizar_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsFacturasGestion.HomeFacturasRow)gvFacturas.GetFocusedDataRow();
                Factura_SolicitudAutorizacion solicitud = new Factura_SolicitudAutorizacion();

 
                solicitud.UsuarioSolicita_Id = UsuarioLogeado.Id;
                solicitud.FacturaId = row.id;
                solicitud.PuntoDeVenta_Id = row.id_punto_venta;


                xfrmDialogAutorizacion authorize = new xfrmDialogAutorizacion(solicitud, this.PuntoDeVentaActual);

                if (authorize.ShowDialog()== DialogResult.OK)
                {

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void gvFacturas_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //switch (e.Column.FieldName)
            //{
            //    case "seleccionado":
                    
            //        //Forzamos el valor en el row actual
            //        var rowS = (dsFacturasGestion.HomeFacturasRow)gvFacturas.GetFocusedDataRow();
            //        if (!rowS.seleccionado)
            //            rowS.ClearErrors();
            //        break;
            //    default: break;
            //}
        }

        private void cmdPagoMultiple_Click(object sender, EventArgs e)
        {
            ArrayList FacturasList = new ArrayList();
            decimal TotalA_pagar = 0;
            int IdCliente =0;

            foreach (dsFacturasGestion.HomeFacturasRow row in dsFacturasGestion1.HomeFacturas)
            {
                if (row.seleccionado)
                {
                    if (row.id_estado != 2 && row.id_estado != 3 && row.saldo > 0)
                    {
                        FacturasPagoMultiple FactPagoMultiple1 = new FacturasPagoMultiple();
                        FactPagoMultiple1.IdFactura = row.id;
                        FactPagoMultiple1.ValorFactura = row.TotalFactura;
                        FactPagoMultiple1.Saldo = row.saldo;
                        TotalA_pagar += row.saldo;
                        FactPagoMultiple1.NumeroFactura = row.numero_documento;
                        FacturasList.Add(FactPagoMultiple1);
                        IdCliente = dp.ValidateNumberInt32(row.id_cliente);
                    }
                }
            }

            frmPagoFacturaMultiple frm = new frmPagoFacturaMultiple(this.UsuarioLogeado, TotalA_pagar, this.PuntoDeVentaActual, FacturasList);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                //Postear el  recibo y sus lineas
                Int64 IdReciboH_Inserted = 0;
                DataOperations dp = new DataOperations();
                using (SqlConnection connection = new SqlConnection(dp.ConnectionStringERP))
                {
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    SqlTransaction transaction;

                    // Start a local transaction.
                    transaction = connection.BeginTransaction("SampleTransaction");

                    command.Connection = connection;
                    command.Transaction = transaction;

                    try
                    {
                        command.CommandText = "dbo.sp_set_insert_new_recibo_pago_h";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@id_usuario_created", this.UsuarioLogeado.Id);
                        command.Parameters.AddWithValue("@concepto", "Pago a Facturas");
                        
                        if(IdCliente==0)
                            command.Parameters.AddWithValue("@id_cliente", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@id_cliente", IdCliente);

                        command.Parameters.AddWithValue("@fecha_created", dp.NowSetDateTime());
                        command.Parameters.AddWithValue("@id_punto_venta", this.PuntoDeVentaActual.ID);
                        command.Parameters.AddWithValue("@valor", frm.TotalAbono);
                        command.Parameters.AddWithValue("@id_tipo_pago", (int)frm.TipoPagoSeleccionadoActual);
                        command.Parameters.AddWithValue("@id_formato_impresion", this.PuntoDeVentaActual.IdFormatoFactura);
                        
                        if (string.IsNullOrEmpty(frm.ReferenciaReciboPago))
                            command.Parameters.AddWithValue("@referencia", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@referencia", frm.ReferenciaReciboPago);

                        IdReciboH_Inserted = Convert.ToInt64(command.ExecuteScalar());
                        
                        //Posteamos las lineas del recibo.
                        foreach (FacturasPagoMultiple FactPagoMultiple1 in frm.ListaFacturasAbono) 
                        {
                            command.CommandText = "dbo.sp_set_insert_recibo_pago_detalle";
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@num_doc", FactPagoMultiple1.NumeroFactura);
                            command.Parameters.AddWithValue("@valor", FactPagoMultiple1.Abono);
                            command.Parameters.AddWithValue("@date_created", dp.NowSetDateTime());
                            command.Parameters.AddWithValue("@id_recibo_h", IdReciboH_Inserted);
                            command.Parameters.AddWithValue("@id_usuario", this.UsuarioLogeado.Id);

                            if (IdCliente == 0)
                                command.Parameters.AddWithValue("@id_cliente", DBNull.Value);
                            else
                                command.Parameters.AddWithValue("@id_cliente", IdCliente);

                            if (string.IsNullOrEmpty(frm.ReferenciaReciboPago))
                                command.Parameters.AddWithValue("@referencia", DBNull.Value);
                            else
                                command.Parameters.AddWithValue("@referencia", frm.ReferenciaReciboPago);
                            command.ExecuteNonQuery();
                        }
                        // Attempt to commit the transaction.
                        transaction.Commit();
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

                if (IdReciboH_Inserted > 0)
                {
                    ReciboH rec1 = new ReciboH();
                    if (rec1.RecuperarRegistro(IdReciboH_Inserted))
                    {
                        dsFacturasGestion.RecibosHRow row1 = dsFacturasGestion1.RecibosH.NewRecibosHRow();
                        row1.id_recibo = IdReciboH_Inserted;
                        row1.num_doc = rec1.NumeroDocumento;
                        row1.enable= rec1.Enable;
                        row1.id_usuario_created = rec1.IdUsuarioCreated;
                        row1.usuario_creador = row1.usuario_ultima_modificacion = rec1.UsuarioCreador;
                        row1.concepto = rec1.Concepto;
                        row1.id_cliente = rec1.IdCliente;
                        row1.NombreCliente = rec1.NombreCliente;
                        row1.fecha_created = rec1.FechaCreated;
                        row1.id_punto_venta = rec1.IdPuntoVenta;
                        row1.valor = rec1.Valor;
                        row1.id_tipo_pago = rec1.IdTipoPago;
                        row1.tipo_pago_descripcion = rec1.TipoPagoDescripcion;
                        row1.id_formato_impresion = rec1.IdFormatoImpresion;
                        row1.tipo_formato_impresion = rec1.TipoFormatoImpresion;
                        row1.punto_venta_code = rec1.punto_venta_code;
                        row1.punto_venta_nombre = rec1.punto_venta_nombre;

                        dsFacturasGestion1.RecibosH.AddRecibosHRow(row1);

                        //Vamos a modificar el saldo del registro que llevamos para pago multiple y el estado
                        //Posteamos las lineas del recibo.

                        foreach (dsFacturasGestion.HomeFacturasRow rowF in dsFacturasGestion1.HomeFacturas)
                        {
                            if (rowF.seleccionado)
                            {
                                foreach (FacturasPagoMultiple FactPagoMultiple1 in frm.ListaFacturasAbono)
                                {
                                    if (rowF.numero_documento == FactPagoMultiple1.NumeroFactura)
                                    { 
                                        rowF.saldo = rowF.saldo - FactPagoMultiple1.Abono;
                                        Factura factx = new Factura();
                                        if (factx.RecuperarRegistro(rowF.id))
                                        {
                                            FacturaEstado estado1 = new FacturaEstado();
                                            //Para el update de estado en la factura
                                            if (rowF.saldo == 0) //Pagada Completamente
                                            {
                                                rowF.id_estado = 0;
                                                //Actualizamos a factura pagada.
                                                factx.UpdateFacturaStatus(rowF.id, 2, rec1.IdTipoPago);
                                                rowF.id_estado = 2;
                                                
                                                if (estado1.RecuperarRegistro(2))
                                                    rowF.EstadoName = estado1.Descripcion;
                                            }
                                            else
                                            {
                                                if (rowF.saldo <= rowF.TotalFactura)//Factura con abonos
                                                {
                                                    //Actualizamos a que es una factura con abonos
                                                    factx.UpdateFacturaStatus(rowF.id, 4, rec1.IdTipoPago);
                                                    if (estado1.RecuperarRegistro(4))
                                                        rowF.EstadoName = estado1.Descripcion;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        
                        dsFacturasGestion1.AcceptChanges();
                    }

                }

            }
        }

        private void gvFacturas_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            switch (e.Column.FieldName)
            {
                case "seleccionado":
                    int conta = 0;

                    //Forzamos el valor en el row actual
                    var rowS = (dsFacturasGestion.HomeFacturasRow)gvFacturas.GetFocusedDataRow();
                    rowS.seleccionado = Convert.ToBoolean(e.Value);
                    if (rowS.seleccionado)
                    {
                        rowS.abono = rowS.saldo;

                        int tipoPagoActual = 0;
                        try
                        {
                            tipoPagoActual = Convert.ToInt32(gleTipoPago.EditValue);
                        }
                        catch { }

                        if (tipoPagoActual > 0)
                        {
                            rowS.id_tipo_pago = tipoPagoActual;
                        }

                    }
                    break;
                case "abono":
                    decimal valorDigitado = 0;
                    try
                    {
                        valorDigitado = Convert.ToDecimal(e.Value);
                    }
                    catch { }
                    if(valorDigitado > 0)
                    {
                        var rowA = (dsFacturasGestion.HomeFacturasRow)gvFacturas.GetFocusedDataRow();
                        rowA.seleccionado = true;

                        int tipoPagoActual = 0;
                        try
                        {
                            tipoPagoActual = Convert.ToInt32(gleTipoPago.EditValue);
                        }
                        catch { }

                        if (tipoPagoActual > 0)
                        {
                            rowA.id_tipo_pago = tipoPagoActual;
                        }
                    }

                    break;
                default: break;
            }
        }

        private void cmdImprimirRecibo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var row = (dsFacturasGestion.RecibosHRow)gridViewRecibos.GetFocusedDataRow();
            ReciboH ReciboH1 = new ReciboH();
            if (ReciboH1.RecuperarRegistro(row.id_recibo))
            {
                if (ReciboH1.CantidadImpresionesFactura == 0)
                {

                    rptFact_RecibosAbonosLetterSize report = new rptFact_RecibosAbonosLetterSize(ReciboH1, rptFact_RecibosAbonosLetterSize.TipoCopia.Blanco);
                    using (ReportPrintTool printTool = new ReportPrintTool(report))
                    {
                        // Send the report to the default printer.
                        ReciboH1.UpdatePrintCount(row.id_recibo);
                        printTool.ShowPreviewDialog();
                    }
                }
                else
                {
                    CajaDialogo.Error("Esta factura ya se imprimió! Para una reimpresión debe solicitar una autorización!");
                }
            }
        }

        private void cmdPagoMultiple_Click_1(object sender, EventArgs e)
        {
            ImprimirY_Pagar();
        }

        private void ImprimirY_Pagar()
        {
            //Postear el  recibo y sus lineas

            if (ClienteActual == null)
            {
                CajaDialogo.Error("Es necesario especificar un cliente!");
                return;
            }

            if (!ClienteActual.Recuperado)
            {
                CajaDialogo.Error("Es necesario especificar un cliente!");
                return;
            }

            decimal valorTotalAbonos = 0;
            foreach(dsFacturasGestion.HomeFacturasRow row in dsFacturasGestion1.HomeFacturas)
            {
                try
                {
                    valorTotalAbonos += row.abono;
                }
                catch { }
            }

            if(valorTotalAbonos<=0)
            {
                CajaDialogo.Error("Se requiere detalar un abono/pago mayor a cero!");
                return;
            }


            Int64 IdReciboH_Inserted = 0;
            DataOperations dp = new DataOperations();
            using (SqlConnection connection = new SqlConnection(dp.ConnectionStringERP))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;

                // Start a local transaction.
                transaction = connection.BeginTransaction("SampleTransaction");

                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    command.CommandText = "dbo.sp_set_insert_new_recibo_pago_h";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@id_usuario_created", this.UsuarioLogeado.Id);
                    command.Parameters.AddWithValue("@concepto", "Pago a Facturas");

                    if (ClienteActual.Id == 0)
                        command.Parameters.AddWithValue("@id_cliente", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@id_cliente", ClienteActual.Id);

                    command.Parameters.AddWithValue("@fecha_created", dp.NowSetDateTime());
                    command.Parameters.AddWithValue("@id_punto_venta", this.PuntoDeVentaActual.ID);
                    command.Parameters.AddWithValue("@valor", valorTotalAbonos);
                    command.Parameters.AddWithValue("@id_tipo_pago", (int)gleTipoPago.EditValue);
                    command.Parameters.AddWithValue("@id_formato_impresion", this.PuntoDeVentaActual.IdFormatoFactura);

                    if (string.IsNullOrEmpty(txtReferencia.Text))
                        command.Parameters.AddWithValue("@referencia", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@referencia", txtReferencia.Text);

                    IdReciboH_Inserted = Convert.ToInt64(command.ExecuteScalar());



                    //Posteamos las lineas del recibo.
                    //foreach (FacturasPagoMultiple FactPagoMultiple1 in frm.ListaFacturasAbono)
                    foreach (dsFacturasGestion.HomeFacturasRow row in dsFacturasGestion1.HomeFacturas)
                    {
                        command.CommandText = "dbo.sp_set_insert_recibo_pago_detalle";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@num_doc", row.numero_documento);
                        command.Parameters.AddWithValue("@valor", row.abono);
                        command.Parameters.AddWithValue("@date_created", dp.NowSetDateTime());
                        command.Parameters.AddWithValue("@id_recibo_h", IdReciboH_Inserted);
                        command.Parameters.AddWithValue("@id_usuario", this.UsuarioLogeado.Id);

                        if (ClienteActual.Id == 0)
                            command.Parameters.AddWithValue("@id_cliente", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@id_cliente", ClienteActual.Id);

                        if (string.IsNullOrEmpty(txtReferencia.Text))
                            command.Parameters.AddWithValue("@referencia", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@referencia", txtReferencia.Text);
                        command.ExecuteNonQuery();
                    }
                    // Attempt to commit the transaction.
                    transaction.Commit();
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

            if (IdReciboH_Inserted > 0)
            {
                ReciboH rec1 = new ReciboH();
                if (rec1.RecuperarRegistro(IdReciboH_Inserted))
                {
                    dsFacturasGestion.RecibosHRow row1 = dsFacturasGestion1.RecibosH.NewRecibosHRow();
                    row1.id_recibo = IdReciboH_Inserted;
                    row1.num_doc = rec1.NumeroDocumento;
                    row1.enable = rec1.Enable;
                    row1.id_usuario_created = rec1.IdUsuarioCreated;
                    row1.usuario_creador = row1.usuario_ultima_modificacion = rec1.UsuarioCreador;
                    row1.concepto = rec1.Concepto;
                    row1.id_cliente = rec1.IdCliente;
                    row1.NombreCliente = rec1.NombreCliente;
                    row1.fecha_created = rec1.FechaCreated;
                    row1.id_punto_venta = rec1.IdPuntoVenta;
                    row1.valor = rec1.Valor;
                    row1.id_tipo_pago = rec1.IdTipoPago;
                    row1.tipo_pago_descripcion = rec1.TipoPagoDescripcion;
                    row1.id_formato_impresion = rec1.IdFormatoImpresion;
                    row1.tipo_formato_impresion = rec1.TipoFormatoImpresion;
                    row1.punto_venta_code = rec1.punto_venta_code;
                    row1.punto_venta_nombre = rec1.punto_venta_nombre;

                    dsFacturasGestion1.RecibosH.AddRecibosHRow(row1);

                    //Vamos a modificar el saldo del registro que llevamos para pago multiple y el estado
                    //Posteamos las lineas del recibo.

                    foreach (dsFacturasGestion.HomeFacturasRow rowF in dsFacturasGestion1.HomeFacturas)
                    {
                        if (rowF.seleccionado)
                        {
                            //foreach (FacturasPagoMultiple FactPagoMultiple1 in frm.ListaFacturasAbono)
                            foreach (dsFacturasGestion.HomeFacturasRow row in dsFacturasGestion1.HomeFacturas)
                            {
                                if (rowF.numero_documento == row.numero_documento)
                                {
                                    decimal varAbono = 0;
                                    try
                                    {
                                        varAbono = Convert.ToDecimal(row.abono);
                                    }
                                    catch { }

                                    //rowF.saldo = rowF.saldo - row.abono;
                                    rowF.saldo = rowF.saldo - varAbono;
                                    Factura factx = new Factura();
                                    if (factx.RecuperarRegistro(rowF.id))
                                    {
                                        FacturaEstado estado1 = new FacturaEstado();
                                        //Para el update de estado en la factura
                                        if (rowF.saldo == 0) //Pagada Completamente
                                        {
                                            rowF.id_estado = 0;
                                            //Actualizamos a factura pagada.
                                            factx.UpdateFacturaStatus(rowF.id, 2, rec1.IdTipoPago);
                                            rowF.id_estado = 2;

                                            if (estado1.RecuperarRegistro(2))
                                                rowF.EstadoName = estado1.Descripcion;
                                        }
                                        else
                                        {
                                            if (rowF.saldo <= rowF.TotalFactura)//Factura con abonos
                                            {
                                                //Actualizamos a que es una factura con abonos
                                                factx.UpdateFacturaStatus(rowF.id, 4, rec1.IdTipoPago);
                                                if (estado1.RecuperarRegistro(4))
                                                    rowF.EstadoName = estado1.Descripcion;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                    dsFacturasGestion1.AcceptChanges();
                    Loadfacturas();

                    ReciboH ReciboH1 = new ReciboH();
                    if (ReciboH1.RecuperarRegistro(IdReciboH_Inserted))
                    {
                        if (ReciboH1.CantidadImpresionesFactura == 0)
                        {
                            rptFact_RecibosAbonosLetterSize report = new rptFact_RecibosAbonosLetterSize(ReciboH1, rptFact_RecibosAbonosLetterSize.TipoCopia.Blanco);
                            using (ReportPrintTool printTool = new ReportPrintTool(report))
                            {
                                // Send the report to the default printer.
                                ReciboH1.UpdatePrintCount(IdReciboH_Inserted);
                                printTool.ShowPreviewDialog();
                            }
                        }
                        else
                        {
                            CajaDialogo.Error("Esta factura ya se imprimió! Para una reimpresión debe solicitar una autorización!");
                        }
                    }



                }

            }

        }

        private void cmdRefresh_Click_1(object sender, EventArgs e)
        {
            LoadRecibos();
        }

        private void gleCliente_EditValueChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(gleCliente.Text))
            {
                int pIdCliente = 0;
                try
                {
                    pIdCliente = Convert.ToInt32(gleCliente.EditValue);
                }
                catch {}

                if (pIdCliente > 0)
                {
                    ClienteActual = new Cliente();
                    if (ClienteActual.RecuperarRegistro(pIdCliente))
                    {
                        txtCodigo.Text = ClienteActual.Codigo;
                        Loadfacturas();
                    }
                }
            }
        }

        private void gleTipoPago_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(gleTipoPago.Text))
            {
                if (dsFacturasGestion1.HomeFacturas.Count > 0)
                {
                    int tipoPagoActual = 0;
                    try
                    {
                        tipoPagoActual = Convert.ToInt32(gleTipoPago.EditValue);
                    }
                    catch { }

                    foreach (dsFacturasGestion.HomeFacturasRow row in dsFacturasGestion1.HomeFacturas)
                    {
                        if (tipoPagoActual > 0)
                        {
                            if (row.seleccionado)
                                row.id_tipo_pago = tipoPagoActual;
                        }
                    }
                }
            }
        }

        private void gleCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) 
            {
                gleTipoPago.Focus();
            }

        }

        private void gleTipoPago_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtReferencia.Focus();
            }
        }

        private void txtReferencia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                if (dsFacturasGestion1.HomeFacturas.Count > 0)
                {
                    gridView1.FocusedRowHandle = gvFacturas.GetVisibleRowHandle(0);
                    SendKeys.Send("{tab}");
                }
            }
        }

        private void frmHomePagoMultipleSimple_Load(object sender, EventArgs e)
        {
            gleCliente.Focus();
        }

        private void frmHomePagoMultipleSimple_Activated(object sender, EventArgs e)
        {
            gleCliente.Focus();
        }
    }
}