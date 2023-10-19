using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data.SqlClient;
using ERP_INTECOLI.Clases;

namespace JAGUAR_APP.Facturacion.Reportes
{
    public partial class RPT_ND_NC_Local : DevExpress.XtraReports.UI.XtraReport
    {
        public RPT_ND_NC_Local(Notas_CreditoDebito nota)
        {
            InitializeComponent();
            lblCAI.Text = nota.CAI;
            lblNumeroDoc.Text = nota.NumeroDocumento;
            lblFecha.Text = string.Format("{0:dd/MM/yyyy}", nota.FechaDocumento);
            lblTituloDocumento.Text = "Nota de " + nota.TipoNota;
            lblMonto.Text = string.Format("{0:###,##0.00}", nota.Debito + nota.Credito);
            //lblTasaCambio.Text = string.Format("{0:###,##0.0000}", pTasa);
            //lblCodigoCliente.Text = nota.ClienteCod;
            lblNombreCLiente.Text = nota.ClienteCod+" - "+ nota.Cliente;
            lblRTN.Text = nota.RTN;
            txtConcepto.Text = nota.Concepto;
            //lblLeyenda.Text = leyenda;
            //ConversorNumALetrasDolares conver = new ConversorNumALetrasDolares(pNum);
            lblValorLetras.Text = nota.ValorLetras;
            lblFechaLimite.Text = string.Format("{0:dd/MM/yyyy}", nota.FechaLimite);
            lblNumeroInicial.Text = nota.NumeroInicial;
            lblNumeroFinal.Text = nota.NumeroFinal;
            //lblCaiComp.Text = caicomp;
            //lblCorrelativo.Text = caicorre;
            //lblOtras.Text = otrasfac;
            //if (!enable)
            //    lblAnulada.Visible = true;
            lblPDV.Text = nota.PuntoDeVenta;
            lblCorreo.Text = "E-MAIL: " + nota.Correo;
            lblTelefono.Text = "TELÉFONO: " + nota.Telefono;
            lblDireccion.Text =  nota.Direccion;
            lblRTN_PDV.Text = nota.RTN_PDV;

            LoadDetail(nota.ID);
        }

        public void LoadDetail(long id_nota_h)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP);

                SqlDataAdapter da = new SqlDataAdapter("[dbo].[uspGetLineas_NC_ND_by_id]", cnx);
                cnx.Open();
                da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@id_nota_h", id_nota_h);
                dsFacturasGestion1.NotaD.Clear();
                da.Fill(dsFacturasGestion1.NotaD);
                cnx.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    

    }
}
