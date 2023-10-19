using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data.SqlClient;
using ERP_INTECOLI.Clases;

namespace JAGUAR_APP.Facturacion.Reportes
{
    public partial class rptFact_RecibosAbonosLetterSize : DevExpress.XtraReports.UI.XtraReport
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

        public rptFact_RecibosAbonosLetterSize(ReciboH ReciboH1, TipoCopia pTipoCopia)
        {
            InitializeComponent();
            TipoCopiaActual = pTipoCopia;

            //psConnection = pConnection;
            //ConfiguracionSuccess conf = new ConfiguracionSuccess(psConnection);
            PuntoVenta PuntoVenta1 = new PuntoVenta();
            if (PuntoVenta1.RecuperaRegistro(ReciboH1.IdPuntoVenta))
            {
                lblmail.Text = PuntoVenta1.Correo;
                lblTelefono.Text = "Telefonos: " + PuntoVenta1.Telefono;
                lblDireccion.Text = PuntoVenta1.Direccion;
                lblCompanyName.Text = PuntoVenta1.Nombre;
                lblLegalName.Text = PuntoVenta1.NombreLegal;
                lblReferenciaPago.Text = ReciboH1.Referencia;
                //lblRTN.Text = "R.T.N. " + ReciboH1.RTN_PDV;
                //lblCai.Text = "CAI: " + ReciboH1.CAI;

                lblNumeroFactura.Text = ReciboH1.NumeroDocumento;
                //lblFechaEmision.Text = string.Format("{0:MM/dd/yyyy}", ReciboH1.FechaDocumento);
                lblFechaEmision.Text = string.Format("{0:dd/MM/yyyy}", ReciboH1.FechaCreated);
                lblCliente.Text = ReciboH1.NombreCliente;
                //lblClienteRTN.Text = ReciboH1.RTN;
                //lblOrdenCompra.Text = ReciboH1.NumeroDocumento;
                //lblDireccionCliente.Text = ReciboH1.di;
                NumberToLetters valorEnLetras = new NumberToLetters();
                lblValorLetras.Text = valorEnLetras.Convertir(ReciboH1.Valor.ToString(), true); ;
                //lblRangoAutorizado.Text = ReciboH1.RangoAutorizado;
                //lblFechaLimite.Text = string.Format("{0:dd/MM/yyyy}", ReciboH1.FechaLimite);
                lblSubTotal.Text = string.Format("{0: ###,##0.00}", ReciboH1.Valor);
                //lblISV.Text = string.Format("{0: ###,##0.00}", ReciboH1.ISV1);
                //lblISV2.Text = string.Format("{0: ###,##0.00}", ReciboH1.ISV2);
                lblTotalPagar.Text = string.Format("{0: ###,##0.00}", ReciboH1.Valor);
            }
            //((Factura1.sub - Factura1.descuento) + Factura1.Recargo));
            //if (Factura1.Recargo > 0)
            //{
            //    lblRecargo.Text = string.Format("{0: ###,##0.00}", Factura1.Recargo);
            //    lblRecargoDescuentoDescrip.Text = "Recargo";
            //}
            //else
            //{
            //    lblRecargoDescuentoDescrip.Text = "Descuento";
            //    lblRecargo.Text = string.Format("{0: ###,##0.00}", Factura1.descuento);
            //}

            //idFact = Factura1.id;
            //decimal saldo_actual = Factura1.Saldo;
            //lblSaldoAnterior.Text = string.Format("{0: ###,##0.00}", ((saldo_actual- Factura1.descuento) + Factura1.Recargo));
            //lblAbono.Text = string.Format("{0: ###,##0.00}", (Factura1.sub - Factura1.descuento + Factura1.Recargo));
            //lblSaldoActual.Text = string.Format("{0: ###,##0.00}",
            //(((saldo_actual - Factura1.descuento) + Factura1.Recargo) - (Factura1.sub + Factura1.Recargo - Factura1.descuento)));

            CargarDetalle(ReciboH1.IdRecibo);
        }

        private void CargarDetalle(long IdRecibo)
        {
            try
            {
                string sql = "[dbo].[uspRptGetDetailReciboDetalle]";
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP);

                SqlDataAdapter da = new SqlDataAdapter(sql, cnx);
                da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                //PgSqlCommand cmd = new PgSqlCommand(sql, psConnection);
                da.SelectCommand.Parameters.AddWithValue("@id_recibo_h", IdRecibo);
                dsFacturasGestion1.RecibosD.Clear();
                da.Fill(dsFacturasGestion1.RecibosD);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void rptFact_RecibosAbonosLetterSize_BeforePrint(object sender, CancelEventArgs e)
        {
        }
        private void rptFact_RecibosAbonosLetterSize_DataSourceDemanded(object sender, EventArgs e)
        {
        }

    }
}
