using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ERP_INTECOLI.Clases;
using System.Drawing.Printing;

namespace ERP_INTECOLI.Administracion.Caja
{
    public partial class frmPagoEfectivo : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        decimal varValor;
        decimal varPago;
        bool Boleta;
        public int IdFormato;
        public string PrinterName;

        public frmPagoEfectivo(decimal valor)
        {
            InitializeComponent();
            varValor = valor;
            txtValor.Text = string.Format("{0:###,##0.00}", valor);
            GetPrintersNames();
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


        void calcularCambio()
        {
            try
            {
                varPago = Convert.ToDecimal(txtEntregado.Text);
            }
            catch
            {
                CajaDialogo.Error("Debe ingresar un valor Decimal Valido!");
                return;
            }
            decimal cambio = varPago - varValor;
            txtCambio.Text = string.Format("{0:###,##0.00}", cambio);
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdFormato = Convert.ToInt32(radioGroup1.EditValue);
        }

        private void ListboxPrinters_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem item in ListboxPrinters.Items)
            {
                if (item.CheckState == CheckState.Checked)
                    PrinterName = item.Value.ToString();
            }
        }

        private void cmdPagar_Click(object sender, EventArgs e)
        {
            calcularCambio();
            if (varValor > varPago)
            {
                CajaDialogo.Error("No se puede realizar la transaccion, el valor entregado debe ser mayor o igual al de la factura.");
                return;
            }
            if (string.IsNullOrEmpty(PrinterName))
            {
                foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem item in ListboxPrinters.Items)
                {
                    if (item.CheckState == CheckState.Checked)
                        PrinterName = item.Value.ToString();
                }
            }

            if (IdFormato == 0)
            {
                IdFormato = Convert.ToInt32(radioGroup1.EditValue);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}