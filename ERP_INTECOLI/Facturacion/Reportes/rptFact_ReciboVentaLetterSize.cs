using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data.SqlClient;
using ERP_INTECOLI.Clases;

namespace JAGUAR_APP.Facturacion.Reportes
{
    public partial class rptFact_ReciboVentaLetterSize : DevExpress.XtraReports.UI.XtraReport
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

        

        public rptFact_ReciboVentaLetterSize(Factura Factura1, TipoCopia pTipoCopia)
        {
            InitializeComponent();
            TipoCopiaActual = pTipoCopia;

            //psConnection = pConnection;
            //ConfiguracionSuccess conf = new ConfiguracionSuccess(psConnection);

            lblmail.Text = Factura1.Correo_PDV;
            lblTelefono.Text = "Telefonos: " + Factura1.Telefono_PDV;
            lblDireccion.Text = Factura1.DireccionPDV;
            lblCompanyName.Text = Factura1.NombreComercial_PDV;
            //lblLegalName.Text = Factura1.NombreLegal_PDV;
            //lblCai.Text = "CAI: " + Factura1.CAI;
            lblRTN.Text = "R.T.N. " + Factura1.RTN_PDV;
            lblNumeroFactura.Text = Factura1.NumeroDocumento;
            //lblFechaEmision.Text = string.Format("{0:MM/dd/yyyy}", Factura1.FechaDocumento);
            lblFechaEmision.Text = string.Format("{0:dd/MM/yyyy}", Factura1.FechaDocumento);
            lblCliente.Text = Factura1.ClienteNombre;
            lblClienteRTN.Text = Factura1.RTN;
            lblOrdenCompra.Text = Factura1.NumOrdenCompra;
            lblDireccionCliente.Text = Factura1.direccion_cliente;
            lblValorLetras.Text = Factura1.ValorLetras;
            //lblRangoAutorizado.Text = Factura1.RangoAutorizado;
            //lblFechaLimite.Text = string.Format("{0:dd/MM/yyyy}", Factura1.FechaLimite);
            lblSubTotal.Text = string.Format("{0: ###,##0.00}", Factura1.subtotalFactura);
            //lblISV.Text = string.Format("{0: ###,##0.00}", Factura1.ISV1);
            //lblISV2.Text = string.Format("{0: ###,##0.00}", Factura1.ISV2);
            lblTotalPagar.Text = string.Format("{0: ###,##0.00}", Factura1.TotalFactura);

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

            CargarDetalle(Factura1.Id);
        }

        private void CargarDetalle(long pIdFactura)
        {
            try
            {
                string sql = "uspRptGetDetailInvoice";
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP);

                SqlDataAdapter da = new SqlDataAdapter(sql, cnx);
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

        private void rptFact_ReciboVentaLetterSize_BeforePrint(object sender, CancelEventArgs e)
        {
        }
        private void rptFact_ReciboVentaLetterSize_DataSourceDemanded(object sender, EventArgs e)
        {
        }

    }
}
