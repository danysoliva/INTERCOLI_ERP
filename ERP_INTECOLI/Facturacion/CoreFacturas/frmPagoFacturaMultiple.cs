using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using DevExpress.XtraRichEdit.Import.Html;
using ERP_INTECOLI.Clases;
using JAGUAR_APP.Facturacion.Reportes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAGUAR_APP.Facturacion.CoreFacturas
{
    public partial class frmPagoFacturaMultiple : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp;
        public enum TipoPago
        {
            Efectivo = 1,
            Tarjeta = 2,
            DepositoBancario = 3
        }

        public TipoPago TipoPagoSeleccionadoActual;
        public decimal ValorA_Pagar;
        public decimal varPago;

        public int IdFormato;
        public string PrinterName;
        public string ReferenciaReciboPago;

        PuntoVenta PuntoVentaActual;
        ArrayList ListaFacturas;
        public ArrayList ListaFacturasAbono;

        public decimal TotalAbono;

        public frmPagoFacturaMultiple(UserLogin pUsuarioLogeado, decimal pValorA_Pagar, PuntoVenta pPuntoVentaActual, ArrayList pListaFacturas)
        {
            InitializeComponent();
            dp = new DataOperations();
            ListaFacturas = pListaFacturas;
            PuntoVentaActual = pPuntoVentaActual;

            this.UsuarioLogeado = pUsuarioLogeado;
            ValorA_Pagar = pValorA_Pagar;
            txtValorEfectivo.Text = txtValorTC.Text = txtValorPagarTransferencia.Text = string.Format("{0:###,##0.00}", pValorA_Pagar);

            TipoPagoSeleccionadoActual = TipoPago.Efectivo;
            SetButtonPago();
            
            SetRadioButtonFormatt();
            GetPrintersNames();
            SetFacturasFromList();
        }

        private void SetFacturasFromList()
        {
            int linea = 1;
            foreach(FacturasPagoMultiple fact in ListaFacturas)
            {
                dsFacturasGestion.facturas_pago_multipleRow row = dsFacturasGestion1.facturas_pago_multiple.Newfacturas_pago_multipleRow();
                row.id = fact.IdFactura;
                row.num_doc = fact.NumeroFactura;
                row.saldo = fact.Saldo;
                row.num_linea = linea++;

                dsFacturasGestion1.facturas_pago_multiple.Addfacturas_pago_multipleRow(row);
                dsFacturasGestion1.AcceptChanges();
            }
        }

        private void SetFacturasFromWithAbonoList()
        {
            TotalAbono = 0;
            if (ListaFacturasAbono == null)
                ListaFacturasAbono = new ArrayList();

            foreach (dsFacturasGestion.facturas_pago_multipleRow row in dsFacturasGestion1.facturas_pago_multiple)
            {
                FacturasPagoMultiple fact = new FacturasPagoMultiple();
                fact.IdFactura = row.id;
                fact.NumeroFactura = row.num_doc;
                fact.Saldo = row.saldo;
                fact.Abono = row.saldo_pagar;
                ListaFacturasAbono.Add(fact);
                TotalAbono += row.saldo_pagar;
            }
        }

        private void SetRadioButtonFormatt()
        {
            switch (PuntoVentaActual.IdFormatoFactura)
            {
                case 1:
                    radioGroup1.EditValue = 1;
                    radioGroup2.EditValue = 1;
                    radioGroup3.EditValue = 1;
                    radioGroup1.ReadOnly = true;
                    radioGroup2.ReadOnly = true;
                    radioGroup3.ReadOnly = true;
                    break;
                case 2:
                    radioGroup1.EditValue = 2;
                    radioGroup2.EditValue = 2;
                    radioGroup3.EditValue = 2;
                    radioGroup1.ReadOnly = true;
                    radioGroup2.ReadOnly = true;
                    radioGroup3.ReadOnly = true;
                    break;
            }
            
        }

        private void GetPrintersNames()
        {
            //PrintersConfig conf = new PrintersConfig(PsConnection);
            //int id = conf.getIdPrinterDefault();
            //if (id > 0)
            //{
            //    radioGroup1.EditValue = id;
            //}

            //if (PuntoVentaActual.Recuperado)
            //{

                ListboxPrintersEfectivo.Items.Clear();
                foreach (string printname in PrinterSettings.InstalledPrinters)
                {
                    //Console.WriteLine(printname);

                    //if (conf.Key == printname)
                    //{
                    //    ListboxPrinters.Items.Add(printname, true);
                    //}
                    //else
                    //{
                    //    ListboxPrinters.Items.Add(printname, false);
                    //}
                    ListboxPrintersEfectivo.Items.Add(printname, false);
                }

                ListboxPrintersTransferencia.Items.Clear();
                foreach (string printname in PrinterSettings.InstalledPrinters)
                {
                    //Console.WriteLine(printname);

                    //if (conf.Key == printname)
                    //{
                    //    ListboxPrinters.Items.Add(printname, true);
                    //}
                    //else
                    //{
                    //    ListboxPrinters.Items.Add(printname, false);
                    //}
                    ListboxPrintersTransferencia.Items.Add(printname, false);
                }

                ListboxPrintersTarjeta.Items.Clear();
                foreach (string printname in PrinterSettings.InstalledPrinters)
                {
                    //Console.WriteLine(printname);

                    //if (conf.Key == printname)
                    //{
                    //    ListboxPrinters.Items.Add(printname, true);
                    //}
                    //else
                    //{
                    //    ListboxPrinters.Items.Add(printname, false);
                    //}
                    ListboxPrintersTarjeta.Items.Add(printname, false);
                }

            
        }

        private void SetButtonPago()
        {
            switch(this.TipoPagoSeleccionadoActual)
            {
                case TipoPago.Efectivo: //1
                    cmdEfectivo.Appearance.BackColor = Color.LightSkyBlue;
                    cmdTarjeta.Appearance.BackColor = Color.White;
                    cmdDepositoBancario.Appearance.BackColor = Color.White;
                    xtraTabPage1.PageVisible = true;
                    xtraTabPage2.PageVisible = 
                    xtraTabPage3.PageVisible = false;
                    break;
                case TipoPago.Tarjeta: //2
                    cmdEfectivo.Appearance.BackColor = Color.White;
                    cmdTarjeta.Appearance.BackColor = Color.LightSkyBlue;
                    cmdDepositoBancario.Appearance.BackColor = Color.White;
                    xtraTabPage1.PageVisible = false;
                    xtraTabPage2.PageVisible = true;
                    xtraTabPage3.PageVisible = false;
                    break;
                case TipoPago.DepositoBancario: //3
                    cmdEfectivo.Appearance.BackColor = Color.White;
                    cmdTarjeta.Appearance.BackColor = Color.White;
                    cmdDepositoBancario.Appearance.BackColor = Color.LightSkyBlue;
                    xtraTabPage1.PageVisible = 
                    xtraTabPage2.PageVisible = false;
                    xtraTabPage3.PageVisible = true;
                    break;
            }
        }

        private void cmdEfectivo_Click(object sender, EventArgs e)
        {
            tabPagos.SelectedTabPage = xtraTabPage1;
            TipoPagoSeleccionadoActual = TipoPago.Efectivo;
            SetButtonPago();
            txtEntregado.Focus();
        }

        private void cmdTarjeta_Click(object sender, EventArgs e)
        {
            tabPagos.SelectedTabPage = xtraTabPage2;
            TipoPagoSeleccionadoActual = TipoPago.Tarjeta;
            SetButtonPago();
        }

        private void cmdDepositoBancario_Click(object sender, EventArgs e)
        {
            tabPagos.SelectedTabPage = xtraTabPage3;
            TipoPagoSeleccionadoActual = TipoPago.DepositoBancario;
            SetButtonPago();
        }
        void calcularCambio()
        {
            if (!string.IsNullOrEmpty(txtEntregado.Text))
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
                decimal cambio = varPago - ValorA_Pagar;
                txtCambio.Text = string.Format("{0:###,##0.00}", cambio);
            }
        }

        private void txtEntregado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calcularCambio();
                cmdPagar.Focus();
            }
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdFormato = Convert.ToInt32(radioGroup1.EditValue);
        }

        private void cmdPagar_Click(object sender, EventArgs e)
        {
            calcularCambio();


            //if (ValorA_Pagar > varPago)
            //{
            //    CajaDialogo.Error("No se puede realizar la transaccion, el valor entregado debe ser mayor o igual al de la factura.");
            //    return;
            //}

            if (!ValidarDetallePago())
            {
                CajaDialogo.Error("No se puede realizar la transaccion, debe definir al menos un valor en las lineas de factura!");
                return;
            }

            decimal valorEntregado = dp.ValidateNumberDecimal(txtEntregado.Text);
            if (valorEntregado <= 0)
            {
                CajaDialogo.Error("No se puede realizar la transaccion, debe definir el valor recibido con un monto mayor a cero!");
                return;
            }

            varPago = (valorEntregado - dp.ValidateNumberDecimal(txtCambio.Text));

            decimal TotalAbonoValidation = 0;
            foreach (dsFacturasGestion.facturas_pago_multipleRow row in dsFacturasGestion1.facturas_pago_multiple)
            {
                decimal vsaldo_pagar = 0;
                try
                {
                    vsaldo_pagar = row.saldo_pagar;
                }
                catch { }

                TotalAbonoValidation += vsaldo_pagar;

                if (row.saldo < vsaldo_pagar)
                {
                    CajaDialogo.Error("No puede pagar una cantidad mayor al saldo pendiente de cada factura! Revise el detalle de lineas de factura!");
                    return;
                }
            }
            if (varPago != TotalAbonoValidation)
            {
                CajaDialogo.Error("No se puede realizar la transaccion, el valor en efectivo recibido neto, debe ser igual a la suma de abonos de las lineas de factura.");
                return;
            }

            if (string.IsNullOrEmpty(PrinterName))
            {
                foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem item in ListboxPrintersEfectivo.Items)
                {
                    if (item.CheckState == CheckState.Checked)
                        PrinterName = item.Value.ToString();
                }
            }

            SetFacturasFromWithAbonoList();

            if (IdFormato == 0)
            {
                IdFormato = Convert.ToInt32(radioGroup1.EditValue);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool ValidarDetallePago()
        {
            bool PuedeContinuar = true;
            decimal valorAcumulado = 0;

            foreach (dsFacturasGestion.facturas_pago_multipleRow row in dsFacturasGestion1.facturas_pago_multiple)
            {
                decimal vsaldo_pagar = 0;
                try
                {
                    vsaldo_pagar = row.saldo_pagar;
                }
                catch { }

                valorAcumulado += vsaldo_pagar;
            }

            if (valorAcumulado <=0)
                PuedeContinuar = false;

            return PuedeContinuar;
        }

        private void ListboxPrinters_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem item in ListboxPrintersEfectivo.Items)
            {
                if (item.CheckState == CheckState.Checked)
                    PrinterName = item.Value.ToString();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calcularCambioTC();
                cmdPagar.Focus();
            }
        }

        private void calcularCambioTC()
        {
            if (!string.IsNullOrEmpty(txtEntregadoTC.Text))
            {
                try
                {
                    varPago = Convert.ToDecimal(txtEntregadoTC.Text);
                }
                catch
                {
                    CajaDialogo.Error("Debe ingresar un valor Decimal Valido!");
                    return;
                }
                decimal cambio = varPago - ValorA_Pagar;
                //txtCambio.Text = string.Format("{0:###,##0.00}", cambio);
            }
        }

        private void radioGroup2_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdFormato = Convert.ToInt32(radioGroup1.EditValue);
        }

        private void checkedListBoxControl1_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem item in ListboxPrintersEfectivo.Items)
            {
                if (item.CheckState == CheckState.Checked)
                    PrinterName = item.Value.ToString();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            calcularCambioTC();
            varPago = dp.ValidateNumberDecimal(txtEntregadoTC.Text);

            //if (ValorA_Pagar > varPago)
            //{
            //    CajaDialogo.Error("No se puede realizar la transaccion, el valor entregado debe ser mayor o igual al de la factura.");
            //    return;
            //}

            if (!ValidarDetallePago())
            {
                CajaDialogo.Error("No se puede realizar la transaccion, debe definir al menos un valor en las lineas de factura!");
                return;
            }



            decimal TotalAbonoValidation = 0;
            foreach (dsFacturasGestion.facturas_pago_multipleRow row in dsFacturasGestion1.facturas_pago_multiple)
            {
                decimal vsaldo_pagar = 0;
                try
                {
                    vsaldo_pagar = row.saldo_pagar;
                }
                catch { }

                TotalAbonoValidation += vsaldo_pagar;

                if (row.saldo < vsaldo_pagar)
                {
                    CajaDialogo.Error("No puede pagar una cantidad mayor al saldo pendiente de cada factura! Revise el detalle de lineas de factura!");
                    return;
                }
            }
            if (varPago > TotalAbonoValidation)
            {
                CajaDialogo.Error("No se puede realizar la transaccion, el valor cobrado debe coincidir con el detalle de pagos o abonos en las lineas de factura!");
                return;
            }



            if (varPago <= 0)
            {
                CajaDialogo.Error("No se puede realizar la transaccion, debe definir el valor recibido con un monto mayor a cero!");
                return;
            }


            if (string.IsNullOrEmpty(PrinterName))
            {
                foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem item in ListboxPrintersEfectivo.Items)
                {
                    if (item.CheckState == CheckState.Checked)
                        PrinterName = item.Value.ToString();
                }
            }

            SetFacturasFromWithAbonoList();

            if (IdFormato == 0)
            {
                IdFormato = Convert.ToInt32(radioGroup1.EditValue);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void spinEdit1_EditValueChanged(object sender, EventArgs e)
        {
            varPago = spinEdit1.Value;
        }

        private void radioGroup3_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdFormato = Convert.ToInt32(radioGroup1.EditValue);
        }

        private void checkedListBoxControl2_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem item in ListboxPrintersEfectivo.Items)
            {
                if (item.CheckState == CheckState.Checked)
                    PrinterName = item.Value.ToString();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            varPago = dp.ValidateNumberDecimal(spinEdit1.Value);
            
            if (!ValidarDetallePago())
            {
                CajaDialogo.Error("No se puede realizar la transaccion, debe definir al menos un valor en las lineas de factura!");
                return;
            }

            decimal TotalAbonoValidation = 0;
            foreach (dsFacturasGestion.facturas_pago_multipleRow row in dsFacturasGestion1.facturas_pago_multiple)
            {
                decimal vsaldo_pagar = 0;
                try
                {
                    vsaldo_pagar = row.saldo_pagar;
                }
                catch { }

                TotalAbonoValidation += vsaldo_pagar;
                
                if (row.saldo < vsaldo_pagar)
                {
                    CajaDialogo.Error("No puede pagar una cantidad mayor al saldo pendiente de cada factura! Revise el detalle de lineas de factura!");
                    return;
                }
            }

            if (varPago != TotalAbonoValidation)
            {
                CajaDialogo.Error("No se puede realizar la transaccion, el valor transferido debe ser igual a la suma de pagos o abonos de las lineas de las facturas!");
                return;
            }


            if (varPago <= 0)
            {
                CajaDialogo.Error("No se puede realizar la transaccion, debe definir el valor recibido con un monto mayor a cero!");
                return;
            }

            if (string.IsNullOrEmpty(PrinterName))
            {
                foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem item in ListboxPrintersEfectivo.Items)
                {
                    if (item.CheckState == CheckState.Checked)
                        PrinterName = item.Value.ToString();
                }
            }

            if (!string.IsNullOrEmpty(txtReferencia.Text))
            {
                ReferenciaReciboPago = txtReferencia.Text;
            }

            SetFacturasFromWithAbonoList();

            if (IdFormato == 0)
            {
                IdFormato = Convert.ToInt32(radioGroup1.EditValue);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtEntregado_TextChanged(object sender, EventArgs e)
        {
            //calcularCambio();
            //cmdPagar.Focus();
        }

        private void txtEntregado_Validated(object sender, EventArgs e)
        {
            calcularCambio();
            cmdPagar.Focus();
        }

        private void txtEntregadoTC_Validated(object sender, EventArgs e)
        {
            calcularCambioTC();
            cmdPagar.Focus();
        }

        private void txtEntregado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtEntregadoTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtReferencia_Validated(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtReferencia.Text)) 
            {
                ReferenciaReciboPago = txtReferencia.Text;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void cmdAplicarTodoElSaldo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var row = (dsFacturasGestion.facturas_pago_multipleRow)gridView1.GetFocusedDataRow();
            row.saldo_pagar = row.saldo;
        }
    }
}