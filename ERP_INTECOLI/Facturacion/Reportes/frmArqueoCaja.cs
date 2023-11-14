using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using ERP_INTECOLI.Clases;
using ERP_INTECOLI.Facturacion.CoreFacturas;
using JAGUAR_APP.Facturacion.CoreFacturas;
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

namespace JAGUAR_APP.Facturacion.Reportes
{
    public partial class frmArqueoCaja : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        PuntoVenta PuntoVentaActual;
        DateTime fechaDesde;
        DateTime fechaHasta;
        DataOperations dp;
        public FacturacionCierreDiaPuntoVenta CierreDiaActual;

        public enum TipoTransaccion
        {
            Insert = 1,
            Update = 2, 
            Delete = 3
        }

        TipoTransaccion TipoTransaccionActual { get; set; }
        public frmArqueoCaja(UserLogin pUser, PuntoVenta pPuntoVenta, Int64 pIdCierreDia, TipoTransaccion ptipoTransaccion, bool PermitirAutorizarCierre)
        {
            InitializeComponent();
            TipoTransaccionActual = ptipoTransaccion;
            CierreDiaActual = new FacturacionCierreDiaPuntoVenta();
            UsuarioLogeado = pUser;
            dp = new DataOperations();
            DateTime fechaActual = dp.NowSetDateTime();
            
            PuntoVentaActual = pPuntoVenta;

            txtPuntoVenta.Text = PuntoVentaActual.Nombre;
            txtResponsable.Text = this.UsuarioLogeado.Nombre;

            switch (TipoTransaccionActual)
            {
                case TipoTransaccion.Insert:
                    lblCodigoCierre.Visible = txtCodigoCierre.Visible = false;
                    txtEstado.Text = "Borrador";
                    
                    dtHasta.EditValueChanged -= new EventHandler(dtHasta_EditValueChanged);
                    dtHasta.EditValue = fechaActual;
                    dtHasta.EditValueChanged += new EventHandler(dtHasta_EditValueChanged);

                    CierreDiaActual.id_estado = 1;
                    fechaDesde = new DateTime(fechaActual.Year, fechaActual.Month, fechaActual.Day, 0, 0, 0);
                    fechaHasta = new DateTime(fechaActual.Year, fechaActual.Month, fechaActual.Day, 23, 59, 59);
                    dtHasta.ReadOnly = false;
                    cmdRefresh.Visible = true;
                    break;
                case TipoTransaccion.Update:
                    lblCodigoCierre.Visible = txtCodigoCierre.Visible = true;
                    if (CierreDiaActual.RecuperarRegistro(pIdCierreDia))
                    {
                        txtCodigoCierre.Text = CierreDiaActual.codigo;
                        txtEstado.Text = CierreDiaActual.estado_descripcion;
                        fechaHasta = fechaDesde = CierreDiaActual.fecha;
                        txtResponsable.Text = CierreDiaActual.usuario_responsable_nombre;
                        dtHasta.EditValueChanged -= new EventHandler(dtHasta_EditValueChanged);
                        dtHasta.EditValue = fechaHasta;
                        dtHasta.EditValueChanged += new EventHandler(dtHasta_EditValueChanged);

                        dtHasta.ReadOnly = true;
                        cmdRefresh.Visible = false;
                        cmdImprimir.Visible = true;

                        txtAutorizadoPor.Text = this.CierreDiaActual.usuario_validacion_nombre;
                    }
                    break;
                    default: break;
            }

            if (PermitirAutorizarCierre)
            {
                if (CierreDiaActual.Recuperado)
                {
                    if (CierreDiaActual.id_estado == 2)
                        cmdAutorizarCierre.Visible = false;
                    else
                        cmdAutorizarCierre.Visible = true;
                }
                
            }
            else
            {
                cmdAutorizarCierre.Visible = false;
            }

            LoadDatosResumen(CierreDiaActual.id);
            LoadDetalleFacturas();
        }

        private void LoadDatosResumen(Int64 pIdCierreH)
        {
            //sp_get_datos_resumen_cierre_caja
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();
                SqlCommand cmd;

                if (pIdCierreH == 0)
                {
                    cmd = new SqlCommand("dbo.sp_get_datos_resumen_cierre_caja", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@fechadesde", fechaDesde);
                    cmd.Parameters.AddWithValue("@fechahasta", fechaHasta);
                    cmd.Parameters.AddWithValue("@id_punto_venta", PuntoVentaActual.ID);
                }
                else
                {
                    cmd = new SqlCommand("[dbo].[sp_get_datos_resumen_cierre_caja_by_id_v2]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idCierreH", pIdCierreH);
                    //cmd.Parameters.AddWithValue("@fechahasta", fechaHasta);
                    //cmd.Parameters.AddWithValue("@id_punto_venta", PuntoVentaActual.ID);
                }

                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsContabilidad1.resumen_cobros.Clear();
                adat.Fill(dsContabilidad1.resumen_cobros);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dtHasta.Text))
                return;

            DateTime fechaActual = dtHasta.DateTime;
            fechaDesde = new DateTime(fechaActual.Year, fechaActual.Month, fechaActual.Day, 0, 0, 0);
            fechaHasta = new DateTime(fechaActual.Year, fechaActual.Month, fechaActual.Day, 23, 59, 59);
            LoadDatosResumen(CierreDiaActual.id);
            LoadDetalleFacturas();
        }

        private void LoadDetalleFacturas()
        {
           
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();

                SqlCommand cmd;
                if (this.CierreDiaActual.id == 0)
                {
                    cmd = new SqlCommand("[dbo].[sp_get_home_facturacion_punto_venta_v3]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_punto_venta", this.PuntoVentaActual.ID);
                    cmd.Parameters.AddWithValue("@desde", fechaDesde);
                    cmd.Parameters.AddWithValue("@hasta", fechaHasta);
                }
                else
                {
                    cmd = new SqlCommand("[dbo].[sp_get_home_facturacion_punto_venta_v4]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idCierreDia", this.CierreDiaActual.id);
                }

                

                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsContabilidad1.HomeFacturas.Clear();
                adat.Fill(dsContabilidad1.HomeFacturas);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            int count = dsContabilidad1.HomeFacturas.Count;
            if(count <=0)
            {
                CajaDialogo.Error("Es necesario que hayan facturas emitidas para poder generar un cierre!");
                return;
            }

            Int64 IdInserted = 0;
            dp = new DataOperations();
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
                    if (TipoTransaccionActual == TipoTransaccion.Insert)
                    {
                        command.CommandText = "dbo.sp_set_insert_header_cierre_dia";
                        command.CommandType = CommandType.StoredProcedure;

                        // Parámetros de entrada
                        command.Parameters.AddWithValue("@id_punto_venta", this.PuntoVentaActual.ID);
                        command.Parameters.AddWithValue("@fecha", fechaHasta);
                        command.Parameters.AddWithValue("@id_user_responsable", this.UsuarioLogeado.Id);

                        //// Parámetro de salida
                        //SqlParameter outputParameter = new SqlParameter("@value", SqlDbType.Int);
                        //outputParameter.Direction = ParameterDirection.Output;
                        //command.Parameters.Add(outputParameter);
                        //command.ExecuteNonQuery();

                        //// Obtener el valor de retorno
                        //if (outputParameter.Value != DBNull.Value)
                        //    IdInserted = (int)outputParameter.Value;
                        IdInserted = Convert.ToInt64(command.ExecuteScalar());
                        if (IdInserted > 0)
                        {
                            foreach (dsContabilidad.HomeFacturasRow row in dsContabilidad1.HomeFacturas)
                            {
                                command.CommandText = "dbo.sp_set_cierre_dia_punto_venta";
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@id_cierre_h", IdInserted);
                                command.Parameters.AddWithValue("@num_doc", row.numero_documento);
                                command.ExecuteNonQuery();
                            }


                            foreach (dsContabilidad.resumen_cobrosRow row in dsContabilidad1.resumen_cobros)
                            {
                                if (row.id_tipo_pago != 5)
                                {
                                    command.CommandText = "[dbo].[sp_set_cierre_dia_punto_venta_resumen]";
                                    command.CommandType = CommandType.StoredProcedure;
                                    command.Parameters.Clear();
                                    command.Parameters.AddWithValue("@id_cierre_h", IdInserted);
                                    command.Parameters.AddWithValue("@valor_contado", row.valor_contado);
                                    command.Parameters.AddWithValue("@id_tipo_pago", row.id_tipo_pago);
                                    command.Parameters.AddWithValue("@tipo_pago_name", row.tipo_pago_name);
                                    command.Parameters.AddWithValue("@total", row.total);
                                    command.ExecuteNonQuery();
                                }
                            }
                            // Attempt to commit the transaction.
                            transaction.Commit();
                            CajaDialogo.InformationAuto();
                            //this.DialogResult = DialogResult.OK;
                            //this.Close();
                            CierreDiaActual = new FacturacionCierreDiaPuntoVenta();
                            if (CierreDiaActual.RecuperarRegistro(IdInserted))
                            {
                                txtCodigoCierre.Text = CierreDiaActual.codigo;
                                if(!txtCodigoCierre.Visible)
                                    txtCodigoCierre.Visible = true;

                                txtEstado.Text = CierreDiaActual.estado_descripcion;
                                cmdImprimir.Visible = true;
                                txtAutorizadoPor.Text = CierreDiaActual.usuario_validacion_nombre;
                            }
                        }
                        else
                        {
                            transaction.Rollback();
                        }
                    }
                    else
                    {
                        if (CierreDiaActual.id > 0)
                        {
                            foreach (dsContabilidad.resumen_cobrosRow row in dsContabilidad1.resumen_cobros)
                            {
                                if (row.id_tipo_pago != 4)
                                {
                                    command.CommandText = "[dbo].[sp_set_cierre_dia_punto_venta_resumen_update]";
                                    command.CommandType = CommandType.StoredProcedure;
                                    command.Parameters.Clear();
                                    command.Parameters.AddWithValue("@id_cierre_h", this.CierreDiaActual.id);
                                    command.Parameters.AddWithValue("@valor_contado", row.valor_contado);
                                    command.Parameters.AddWithValue("@id_tipo_pago", row.id_tipo_pago);
                                    command.Parameters.AddWithValue("@tipo_pago_name", row.tipo_pago_name);
                                    command.Parameters.AddWithValue("@total", row.total);
                                    command.Parameters.AddWithValue("@id", row.id);
                                    command.ExecuteNonQuery();
                                }
                            }
                            // Attempt to commit the transaction.
                            transaction.Commit();
                            CajaDialogo.InformationAuto();
                            //this.DialogResult = DialogResult.OK;
                            //this.Close();

                            if (CierreDiaActual.RecuperarRegistro(this.CierreDiaActual.id))
                            {
                                txtCodigoCierre.Text = CierreDiaActual.codigo;
                                if (!txtCodigoCierre.Visible)
                                    txtCodigoCierre.Visible = true;

                                txtEstado.Text = CierreDiaActual.estado_descripcion;
                                cmdImprimir.Visible = true;
                                txtAutorizadoPor.Text = CierreDiaActual.usuario_validacion_nombre;
                            }
                        }
                        else
                        {
                            transaction.Rollback();
                        }
                    }
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

        private void dtHasta_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dtHasta.Text))
                return;

            DateTime fechaActual = dtHasta.DateTime;
            fechaDesde = new DateTime(fechaActual.Year, fechaActual.Month, fechaActual.Day, 0, 0, 0);
            fechaHasta = new DateTime(fechaActual.Year, fechaActual.Month, fechaActual.Day, 23, 59, 59);
            LoadDatosResumen(this.CierreDiaActual.id);
            LoadDetalleFacturas();
        }

        private void cmdAutorizarCierre_Click(object sender, EventArgs e)
        {
            DialogResult r = CajaDialogo.Pregunta("Esta seguro de Autorizar este cierre dia?");
            if (r != DialogResult.Yes)
                return;

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_set_update_cierre_dia_status", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCierre", this.CierreDiaActual.id);
                cmd.Parameters.AddWithValue("@id_estado", 2);//Confirmado
                cmd.Parameters.AddWithValue("@id_user_validacion", this.UsuarioLogeado.Id);
                cmd.Parameters.AddWithValue("@fecha_autorizado", dp.NowSetDateTime());
                cmd.ExecuteNonQuery();
                con.Close();
                this.CierreDiaActual.RecuperarRegistro(this.CierreDiaActual.id);
                CajaDialogo.InformationAuto();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }


        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //Calcular el total del valor contado
            decimal valor = 0;
            //var row = (dsContabilidad.resumen_cobrosRow)gridView1.GetFocusedDataRow();

            foreach (dsContabilidad.resumen_cobrosRow rowi in dsContabilidad1.resumen_cobros)
            {
                try
                {
                    if(rowi.id_tipo_pago<5)
                        valor += rowi.valor_contado;
                    else
                        rowi.valor_contado = valor;

                }catch { }
            }

        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            //Imprimir
            if (CierreDiaActual.Recuperado)
            {
                rpt_cierre_dia_complete report = new rpt_cierre_dia_complete(CierreDiaActual) { ShowPrintMarginsWarning = false };
                //RPT_OrdenCompra report = new RPT_OrdenCompra(num) { DataSource = dsCompras1, ShowPrintMarginsWarning = false };
                report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                ReportPrintTool printReport = new ReportPrintTool(report);
                printReport.ShowPreviewDialog();
            }
        }
    }
}