using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data.SqlClient;
using ERP_INTECOLI.Clases;

namespace JAGUAR_APP.Facturacion.Reportes
{
    public partial class rptNotasCD : DevExpress.XtraReports.UI.XtraReport
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

        public rptNotasCD(Notas_CreditoDebito nota, TipoCopia pTipoCopia)
        {
            InitializeComponent();
            TipoCopiaActual = pTipoCopia;

            lblmail.Text = nota.Correo;
            lblTelefono.Text = "Telefonos: " + nota.Telefono;
            lblDireccion.Text = nota.Direccion;
            lblCompanyName.Text = nota.PuntoDeVenta;
            lblLegalName.Text = nota.PuntoDeVenta_NombreLegal;
            lblCai.Text = "CAI: " + nota.CAI;
            lblRTN.Text = "R.T.N. " + nota.RTN;
            lblNumeroFactura.Text = nota.NumeroDocumento;
            //lblFechaEmision.Text = string.Format("{0:MM/dd/yyyy}", nota.FechaDocumento);
            lblFechaEmision.Text = string.Format("{0:dd/MM/yyyy}", nota.FechaDocumento);
            lblCliente.Text = nota.Cliente;
            lblClienteRTN.Text = nota.RTN;
            lblDireccionCliente.Text = nota.Direccion;
            lblValorLetras.Text = nota.ValorLetras;
            lblNota.Text = nota.TipoNota;
            lblRangoAutorizado.Text = nota.RangoAutorizado;
            lblFechaLimite.Text = string.Format("{0:dd/MM/yyyy}", nota.FechaLimite);
            //lblSubTotal.Text = string.Format("{0: ###,##0.00}", nota.subtotalFactura);
            //lblISV.Text = string.Format("{0: ###,##0.00}", nota.ISV1);
            //lblISV2.Text = string.Format("{0: ###,##0.00}", nota.ISV2);
            lblTotalPagar.Text = string.Format("{0: ###,##0.00}", nota.Credito+nota.Debito);


            CargarDetalle(nota.ID);
        }

        private void CargarDetalle(long pIdNota)
        {
            try
            {
                string sql = "dbo.uspRPTGetNotaCreditoDebitoDetailById";
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP);

                SqlDataAdapter da = new SqlDataAdapter(sql, cnx);
                da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                //PgSqlCommand cmd = new PgSqlCommand(sql, psConnection);
                da.SelectCommand.Parameters.Add("@id_nota", System.Data.SqlDbType.Int).Value = pIdNota;
                dsFacturasGestion1.NotaD.Clear();
                da.Fill(dsFacturasGestion1.NotaD);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void rptFacturaLetterSize_BeforePrint(object sender, CancelEventArgs e)
        {
        }
        private void rptFacturaLetterSize_DataSourceDemanded(object sender, EventArgs e)
        {
        }

    }
}
