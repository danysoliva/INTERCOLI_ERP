using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data.SqlClient;
using ERP_INTECOLI.Clases;
using JAGUAR_APP.Facturacion.Mantenimientos.Models;

namespace JAGUAR_APP.Facturacion.Reportes 
{
    public partial class rptFactura : DevExpress.XtraReports.UI.XtraReport
    {
        //PgSqlConnection psConnection;
        int idFact;
        public enum TipoCopia
        {
            Blanco = 0,//White
            Verde = 10,//SeaGreen
            Azul = 11,//CadetBlue
            Rosa = 12//LightPink
        }

        public TipoCopia TipoCopiaActual = TipoCopia.Blanco;

        public rptFactura(Factura Factura1, TipoCopia pTipoCopia)
        {
            InitializeComponent();
            TipoCopiaActual = pTipoCopia;

            //psConnection = pConnection;
            //ConfiguracionSuccess conf = new ConfiguracionSuccess(psConnection);

            NumeracionFiscal NumFiscal1 = new NumeracionFiscal();
            if (NumFiscal1.RecuperarRegistro(Factura1.IdNumeracionFiscal))
            {
                lblCai.Text = "CAI: " + NumFiscal1.CAI;
                lblRangoAutorizado.Text = "desde: " + NumFiscal1.Numeracion_Inicial + " hasta: " + NumFiscal1.Numeracion_Final;
                lblFechaLimite.Text = string.Format("{0:MM/dd/yyyy}", NumFiscal1.FechaVence);
            }

            lblNombreLega.Text = "Nombre Legal:"+ Factura1.NombreLegal_PDV;
            lblRTN.Text = "R.T.N. " + Factura1.RTN_PDV;
            lblCorreo.Text = Factura1.Correo_PDV;
            lblDireccion.Text = Factura1.DireccionPDV;
            lblTelefono.Text = "Teléfonos: " + Factura1.Telefono_PDV;
            lblFechaEmision.Text = string.Format("{0:MM/dd/yyyy}", Factura1.FechaDocumento);
            lblNumeroFactura.Text = Factura1.NumeroDocumento;
            lblNombreComercial.Text = Factura1.NombreComercial_PDV;
            lblCliente.Text = Factura1.ClienteNombre;
            lblClienteRTN.Text = Factura1.RTN;
            lblOrdenCompra.Text = Factura1.NumOrdenCompra;
            
            if(!string.IsNullOrEmpty(Factura1.direccion_cliente))
                lblDireccionCliente.Text = Factura1.direccion_cliente;

            lblValorLetras.Text = Factura1.ValorLetras;

            lblSubTotal.Text = string.Format("{0: ###,##0.00}", Factura1.subtotalFactura);
            lblISV15.Text = string.Format("{0: ###,##0.00}", Factura1.ISV1);
            lblISV18.Text = string.Format("{0: ###,##0.00}", Factura1.ISV2);
            //lblISV.Text = string.Format("{0: ###,##0.00}", Factura1.ISV1+Factura1.ISV2);
            lblTotalPagar.Text = string.Format("{0: ###,##0.00}", Factura1.subtotalFactura-Factura1.descuentoTotalFactura+Factura1.ISV1 + Factura1.ISV2);
            lblTerminoPago.Text = Factura1.TerminoPagoName;
            //idFact = Factura1.id;
            //decimal saldo_actual = Factura1.Saldo;
            //lblSaldoAnterior.Text = string.Format("{0: ###,##0.00}", ((saldo_actual- Factura1.descuento) + Factura1.Recargo));
            //lblAbono.Text = string.Format("{0: ###,##0.00}", (Factura1.sub - Factura1.descuento + Factura1.Recargo));
            //lblSaldoActual.Text = string.Format("{0: ###,##0.00}",
            //(((saldo_actual - Factura1.descuento) + Factura1.Recargo) - (Factura1.sub + Factura1.Recargo - Factura1.descuento)));

            CargarDetalle(Factura1.Id);
        }

        private void CargarDetalle(long pIdFactura)
        {
            try
            {
                string sql = "uspRptGetDetailInvoice";
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP);

                SqlDataAdapter da = new SqlDataAdapter(sql,cnx);
                da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                //PgSqlCommand cmd = new PgSqlCommand(sql, psConnection);
                da.SelectCommand.Parameters.Add("@id_factura", System.Data.SqlDbType.Int).Value = pIdFactura;
                dsFacturasGestion1.Factura_Detalle.Clear();
                da.Fill(dsFacturasGestion1.Factura_Detalle);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void rptFactura_BeforePrint(object sender, CancelEventArgs e)
        {
        }
        private void rptFactura_DataSourceDemanded(object sender, EventArgs e)
        {
        }

    }
}
