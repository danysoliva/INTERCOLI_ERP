using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_INTECOLI.Facturacion;
using System.Windows.Forms;
using ERP_INTECOLI.Administracion.Facturacion;
using ERP_INTECOLI.Clases;
using System.Drawing.Printing;
using DevExpress.XtraReports.UI;

namespace ERP_INTECOLI.Administracion.Caja
{
    public partial class frmRePrintFactura : DevExpress.XtraEditors.XtraForm
    {
        public frmRePrintFactura()
        {
            InitializeComponent();

            GetPrintersNames();
        }

        private void cmdSearchFacturas_Click(object sender, EventArgs e)
        {
            frmList_Invoices frm = new frmList_Invoices();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtNumero.Text = frm.NumFactura;
                //cmdPrint_Click(sender, e);
                radioGroup2.Focus();
            }
        }

        private void GetPrintersNames()
        {
            PrintersConfig conf = new PrintersConfig();
            int id = conf.getIdPrinterDefault();
            if (id > 0)
            {
                radioGroup1.EditValue = id;
            }

            ListboxPrinters.Items.Clear();
            foreach (string printname in PrinterSettings.InstalledPrinters)
            {
                //Console.WriteLine(printname);

                if (conf.Key == printname)
                {
                    ListboxPrinters.Items.Add(printname, true);
                }
                else
                {
                    ListboxPrinters.Items.Add(printname, false);
                }

            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdPrintFact_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNumero.Text))
            {
                FacturaBK fact1 = new FacturaBK();
                if (fact1.RecuperarRegistro(txtNumero.Text))
                {
                    rptFactura fac = new rptFactura(fact1, rptFactura.TipoCopia.Azul);
                    fac.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                    ReportPrintTool printReport = new ReportPrintTool(fac);
                    int idFormato = Convert.ToInt32(radioGroup2.EditValue);
                    switch (idFormato)
                    {
                        case 1://3.5"
                            //rptFactura fac = new rptFactura(fact1, psConnection, rptFactura.TipoCopia.Azul);
                            //fac.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                            //ReportPrintTool printReport = new ReportPrintTool(fac);
                            ////printReport.ShowPreview();
                            ////printReport.Print("EPSON TM-U220 Receipt");
                            ////printReport.PrinterSettings.PrinterName = "EPSON TM-U220 Receipt";
                            //printReport.PrinterSettings.PrinterName = frm1.PrinterName;
                            string PrinterName = "";
                            foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem item in ListboxPrinters.Items)
                            {
                                if (item.CheckState == CheckState.Checked)
                                    PrinterName = item.Value.ToString();
                            }
                            printReport.PrinterSettings.PrinterName = PrinterName;

                            if (radioImpresionDirecta.Checked)
                            {
                                printReport.Print();
                            }
                            else
                            {
                                //Vista Previa
                                printReport.ShowPreview();
                            }

                            break;
                        case 2:
                            rptFacturaLetterSize FactLetter1 = new rptFacturaLetterSize(fact1, rptFacturaLetterSize.TipoCopia.Azul);
                            FactLetter1.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                            ReportPrintTool printReport2 = new ReportPrintTool(FactLetter1);
                            string PrinterNameLetter = "";
                            foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem item in ListboxPrinters.Items)
                            {
                                if (item.CheckState == CheckState.Checked)
                                    PrinterNameLetter = item.Value.ToString();
                            }
                            printReport2.PrinterSettings.PrinterName = PrinterNameLetter;

                            if (radioImpresionDirecta.Checked)
                            {
                                printReport2.Print();
                            }
                            else
                            {
                                //Vista Previa
                                printReport2.ShowPreview();
                            }



                            break;
                        default:
                            CajaDialogo.Error("Es necesario indicar el formato a utilizar!");
                            break;
                    }


                }
                else
                {
                    CajaDialogo.Error("No se encontró el número de factura, por favor verifique!");
                }
            }
            else
            {
                CajaDialogo.Error("Debe ingresar un numero de factura!");
                txtNumero.Focus();
            }
        }
    }
}