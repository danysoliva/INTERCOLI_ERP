using DevExpress.XtraEditors;
using ERP_INTECOLI.Clases;
using JAGUAR_APP.Facturacion.Mantenimientos.Models;
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

namespace JAGUAR_APP.Facturacion.CoreFacturas
{
    public partial class frmNotaCRUD : DevExpress.XtraEditors.XtraForm
    {
        NumeracionFiscal NumDocumentoFiscal = new NumeracionFiscal();
        PuntoVenta punto_venta = new PuntoVenta();

        public enum SourceSolicitud
        {
            FacturaEmitida=1
        }

        public enum TipoNota
        {
            Credito=1,
            Debito=2
        }

        public enum EstadoSolicitud
        {
            Pendiente = 1,
            Aprobada = 2,
            Rechazada = 3
        }

        SourceSolicitud solicitudActual;
        long factura_id;
        //Factura factura1 = new Factura();
        Factura_SolicitudAutorizacion solicitud = new Factura_SolicitudAutorizacion();
        long solicitud_id = 0;
        UserLogin userLog = new UserLogin();
        public frmNotaCRUD(SourceSolicitud request,long p_solicitud_id,UserLogin pUser)
        {
            InitializeComponent();
            solicitudActual = request;
            //factura_id = factura_id_p;
            solicitud_id = p_solicitud_id;
            userLog = pUser;
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {

            Factura_SolicitudAutorizacion solicitud = new Factura_SolicitudAutorizacion();

            DialogResult res = MessageBox.Show("Desea Rechazar la solicitud?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                if (solicitud.RechazarSolicitud_NotaCredito_NotaDebito(solicitud_id,(int)EstadoSolicitud.Rechazada,userLog.Id))
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
            if (res == DialogResult.No)
            {
            this.Close();
            }
        }

        SqlTransaction transaccion;
        private void cmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                var id_numeracion = NumDocumentoFiscal.ID;
                var correlativoSiguiente = NumDocumentoFiscal.Correlative;
                string doc_num="";
                decimal Monto = Convert.ToDecimal( coltotal_line.SummaryItem.SummaryValue);

                if (NumDocumentoFiscal.RecuperarRegistro(NumDocumentoFiscal.ID))
                {
                    string sCorrelativo = correlativoSiguiente.ToString();

                    //Rellenar ceros a la izquierda
                    while (sCorrelativo.Length < 8)
                    {
                        sCorrelativo = "0" + sCorrelativo;
                    }

                    doc_num = NumDocumentoFiscal.Leyenda + sCorrelativo;
                }




                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP);

                cnx.Open();
                transaccion = cnx.BeginTransaction();

                SqlCommand cmd = new SqlCommand("dbo.uspInsertNotaH", cnx);
                cmd.Transaction = transaccion;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id_tipo_nota", solicitud.TipoNotaId);
                cmd.Parameters.Add("@created_date",DateTime.Now);
                cmd.Parameters.Add("@cai",txtCAI.Text);
                cmd.Parameters.Add("@id_cliente",solicitud.ClienteId);
                cmd.Parameters.Add("@credito", solicitud.TipoNotaId == (int)TipoNota.Credito ? Monto : 0);
                cmd.Parameters.Add("@debito", solicitud.TipoNotaId == (int)TipoNota.Debito ? Monto : 0);
                cmd.Parameters.Add("@id_punto_venta",solicitud.PuntoDeVenta_Id);
                cmd.Parameters.Add("@num_documento", doc_num);
                cmd.Parameters.Add("@rtn",txtClienteRTN.Text);
                cmd.Parameters.Add("@fecha_documento",deFecha.EditValue);
                cmd.Parameters.Add("@id_doc_fiscal",NumDocumentoFiscal.ID);
                //cmd.Parameters.Add("@factura_id",factura1.Id);
                cmd.Parameters.Add("@solicitud_id",solicitud_id);
                //cmd.Parameters.Add("@due_date",);
                cmd.Parameters.Add("@concepto",txtConcepto.Text);

               long id_inserted= Convert.ToInt64( cmd.ExecuteScalar());

                //Detalle

                foreach (var item in dsFacturasGestion.NotaD)
                {
                    SqlCommand cmd2 = new SqlCommand("dbo.uspInsertNotaD", cnx);
                    cmd2.Transaction = transaccion;
                    cmd2.CommandType = CommandType.StoredProcedure;

                    cmd2.Parameters.Add("@id_nota", id_inserted);
                    cmd2.Parameters.Add("@id_factura", item.id_factura);
                    cmd2.Parameters.Add("@cuenta","");
                    //cmd2.Parameters.Add("@price",item.price);
                    cmd2.Parameters.Add("@total_line",item.total_line);
                    cmd2.Parameters.Add("@descripcion",item.descripcion);
                    cmd2.Parameters.Add("@num_doc",item.num_doc);

                    cmd2.ExecuteNonQuery();

                }


                transaccion.Commit();

                CajaDialogo.Information("Datos Guardados");
                this.DialogResult = DialogResult.OK;
                cnx.Close();


            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                transaccion.Rollback();
            }
        }

        private void frmNotaCRUD_Load(object sender, EventArgs e)
        {
            try
            {
                deFecha.EditValue = DateTime.Now;
                switch (solicitudActual)
                {
                    case SourceSolicitud.FacturaEmitida:
                        

                        DataOperations dp = new DataOperations();
                        SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP);
                        solicitud.RecuperaRegistro(solicitud_id);
                        punto_venta.RecuperaRegistro(solicitud.PuntoDeVenta_Id);
                
                        txtCliente.Text = solicitud.Cliente;
                        txtClienteRTN.Text = solicitud.Cliente_RTN;
                        deFecha.EditValue = DateTime.Now;
                        txtPDV.Text = punto_venta.NombreLegal;
                        txtRTN.Text = punto_venta.RTN;
                        txtConcepto.Text = solicitud.Justificacion;

                        //Cargar las lineas de la facturas para crear la nota de credito o debito
                        SqlDataAdapter da = new SqlDataAdapter("uspGetLineasToCreate_NC_ND", cnx);

                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.Add("@id_autorizacion_h", solicitud_id);

                        dsFacturasGestion.NotaD.Clear();
                        da.Fill(dsFacturasGestion.NotaD);

                        NumDocumentoFiscal = new NumeracionFiscal();

                        

                        if (solicitud.TipoNotaId == (int)TipoNota.Credito)
                        {
                            if (NumDocumentoFiscal.GetIdNumeracionFiscalFromPuntoVentaId(solicitud.PuntoDeVenta_Id, NumeracionFiscal.TipoDocumentoFiscal.Nota_de_Credito))
                            {
                                if (NumDocumentoFiscal.ValidaVencimientoNumeracionFiscal(NumDocumentoFiscal.ID))
                                {
                                    CajaDialogo.Error("La numeración fiscal de las "+NumDocumentoFiscal.TipoDoc+" para este punto de venta se ha vencido.");
                                    this.Close();
                                }

                                txtCAI.Text = NumDocumentoFiscal.CAI;
                                lblNota.Text = "Nota de Crédito";
                            }

                        }

                        if (solicitud.TipoNotaId == (int)TipoNota.Debito)
                        {
                            if (NumDocumentoFiscal.GetIdNumeracionFiscalFromPuntoVentaId(solicitud.PuntoDeVenta_Id, NumeracionFiscal.TipoDocumentoFiscal.Nota_de_Debito))
                            {
                                if (NumDocumentoFiscal.ValidaVencimientoNumeracionFiscal(NumDocumentoFiscal.ID))
                                {
                                    CajaDialogo.Error("La numeración fiscal de las " + NumDocumentoFiscal.TipoDoc + "para este punto de venta se ha vencido.");
                                    return;
                                }
                                txtCAI.Text = NumDocumentoFiscal.CAI;
                                lblNota.Text = "Nota de Débito";
                            }
                        }

                        break;

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            try
            {
                NumDocumentoFiscal = new NumeracionFiscal();

                if (solicitud.TipoNotaId==(int)TipoNota.Credito)
                {

                    if (NumDocumentoFiscal.GetIdNumeracionFiscalFromPuntoVentaId(solicitud.PuntoDeVenta_Id, NumeracionFiscal.TipoDocumentoFiscal.Nota_de_Credito))
                        txtCAI.Text = NumDocumentoFiscal.CAI;
                    lblNota.Text = "Nota de Crédito";
                }

                if (solicitud.TipoNotaId == (int)TipoNota.Debito)
                {
                    if(NumDocumentoFiscal.GetIdNumeracionFiscalFromPuntoVentaId(solicitud.PuntoDeVenta_Id, NumeracionFiscal.TipoDocumentoFiscal.Nota_de_Debito))
                        txtCAI.Text = NumDocumentoFiscal.CAI;
                    lblNota.Text = "Nota de Débito";
                }




            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}