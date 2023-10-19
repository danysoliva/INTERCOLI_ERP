using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ERP_INTECOLI.Administracion.Facturacion
{
    public partial class rptBoleta : DevExpress.XtraReports.UI.XtraReport
    {
        //int idFact;
        public enum TipoCopia
        {
            Blanco = 0,//White
            Verde = 10,//SeaGreen
            Azul = 11,//CadetBlue
            Rosa = 12//LightPink
        }

        public TipoCopia TipoCopiaActual = TipoCopia.Blanco;

        public rptBoleta(string pNum, string pCliente, decimal pvalor, DateTime pFecha)
        {
            InitializeComponent();

            lblNumeroBoleta.Text = "# " + pNum;
            lblFechaEmision.Text = string.Format("{0:MM/dd/yyyy}", pFecha);
            lblCliente.Text = pCliente;
            lblTotalPagar.Text = string.Format("{0: ###,##0.00}", pvalor);
            //CargarDetalle(idFact);
        }

    }
}
