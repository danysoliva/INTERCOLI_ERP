using DevExpress.XtraEditors;
using ERP_INTECOLI.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_INTECOLI.Administracion.Caja
{
    public partial class frmPagoTransferencia : DevExpress.XtraEditors.XtraForm
    {

        decimal varValor;
        decimal varPago;
        public int IdFormato;
        public string PrinterName;

        public frmPagoTransferencia(decimal valor)
        {
            InitializeComponent();
            varValor = valor;
            txtValor.Text = string.Format("{0: ###,##0.00}", valor);
            GetPrintersNames();
            spinEdit1.Focus();
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

        private void spinEdit1_EditValueChanged(object sender, EventArgs e)
        {
            varPago = spinEdit1.Value;
        }

        private void spinEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButton1.Focus();
            }
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (varValor > varPago)
            {
                CajaDialogo.Error("No se puede realizar la transaccion, el valor transferido debe ser mayor o igual al de la factura.");
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