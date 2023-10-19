using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data.SqlClient;
using ERP_INTECOLI.Clases;

namespace ERP_INTECOLI.Administracion.Facturacion
{
    public partial class rptFactura : DevExpress.XtraReports.UI.XtraReport
    {
        int idFact;
        DataOperations dp = new DataOperations();

        public enum TipoCopia
        {
            Blanco = 0,//White
            Verde = 10,//SeaGreen
            Azul = 11,//CadetBlue
            Rosa = 12//LightPink
        }

        public TipoCopia TipoCopiaActual = TipoCopia.Blanco;

        public rptFactura(FacturaBK Factura1, TipoCopia pTipoCopia)
        {
            InitializeComponent();

            TipoCopiaActual = pTipoCopia;

            //ConfiguracionSuccess conf = new ConfiguracionSuccess(psConnection);
            

            lblCai.Text = "CAI: " + Factura1.cai;
            lblNumeroFactura.Text = Factura1.numero;
            lblFechaEmision.Text = string.Format("{0:MM/dd/yyyy}", Factura1.fecha_emision);
            lblCliente.Text = Factura1.cliente;
            lblClienteRTN.Text = Factura1.rtn_cliente;
            lblOrdenCompra.Text = Factura1.oc;
            lblDireccionCliente.Text = Factura1.direccion_c;
            lblValorLetras.Text = Factura1.valor_letras;
            lblRangoAutorizado.Text = Factura1.rango_a;
            lblFechaLimite.Text = string.Format("{0:MM/dd/yyyy}", Factura1.fecha_limite);
            lblSubTotal.Text = string.Format("{0: ###,##0.00}", Factura1.sub);
            lblISV.Text = string.Format("{0: ###,##0.00}", Factura1.Impuesto);
            lblTotalPagar.Text = string.Format("{0: ###,##0.00}",
            ((Factura1.sub - Factura1.descuento) + Factura1.Recargo));
            if (Factura1.Recargo > 0)
            {
                lblRecargo.Text = string.Format("{0: ###,##0.00}", Factura1.Recargo);
                lblRecargoDescuentoDescrip.Text = "Recargo";
            }
            else
            {
                lblRecargoDescuentoDescrip.Text = "Descuento";
                lblRecargo.Text = string.Format("{0: ###,##0.00}", Factura1.descuento);
            }

            idFact = Factura1.id;
            decimal saldo_actual = Factura1.Saldo;
            lblSaldoAnterior.Text = string.Format("{0: ###,##0.00}", ((saldo_actual - Factura1.descuento) + Factura1.Recargo));
            lblAbono.Text = string.Format("{0: ###,##0.00}", (Factura1.sub - Factura1.descuento + Factura1.Recargo));
            lblSaldoActual.Text = string.Format("{0: ###,##0.00}",
            (((saldo_actual - Factura1.descuento) + Factura1.Recargo) - (Factura1.sub + Factura1.Recargo - Factura1.descuento)));

            CargarDetalle(idFact);

        }

        private void CargarDetalle(int pIdFactura)
        {
            try
            {
                //string sql = "select * from admon.ft_recupera_detalle_factura (:p_id_factura);";
                string sql = @"sp_get_recupera_detalle_factura";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_factura", pIdFactura);
                dsFactura1.detalle_fact.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsFactura1.detalle_fact);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }


    }
}
