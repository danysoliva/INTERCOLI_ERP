using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DevExpress.XtraRichEdit.Import.Html;
using ERP_INTECOLI.Clases;
using JAGUAR_APP.Facturacion.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAGUAR_APP.Facturacion.CoreFacturas
{
    public partial class frmPagoFactura : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp;
        public enum TipoPago
        {
            Efectivo = 1,
            Tarjeta = 2,
            DepositoBancario = 3,
            Otros = 4
        }

        public TipoPago TipoPagoSeleccionadoActual;
        public decimal ValorA_Pagar;
        public decimal varPago;

        public int IdFormato;
        public int IdMetodoPagoElectronico;
        public string PrinterName;
        public string ReferenciaReciboPago;

        PuntoVenta PuntoVentaActual;

        public frmPagoFactura(UserLogin pUsuarioLogeado, decimal pValorA_Pagar, PuntoVenta pPuntoVentaActual)
        {
            InitializeComponent();
            dp = new DataOperations();
            PuntoVentaActual = pPuntoVentaActual;

            this.UsuarioLogeado = pUsuarioLogeado;
            ValorA_Pagar = pValorA_Pagar;
            txtValorEfectivo.Text = txtValorTC.Text = txtValorPagarTransferencia.Text = string.Format("{0:###,##0.00}", pValorA_Pagar);

            TipoPagoSeleccionadoActual = TipoPago.Efectivo;
            SetButtonPago();
            
            SetRadioButtonFormatt();
            GetPrintersNames();
            LoadBancosList();
            LoadTipoPagoList();
        }

        private void LoadBancosList()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand("dbo.sp_get_lista_bancos", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("", 0);
                dsVentaSuccess1.lista_bancos.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsVentaSuccess1.lista_bancos);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception EX)
            {
                CajaDialogo.Error(EX.Message);
            }
        }

        private void LoadDetallePago(int pIdPago)
        {
            try
            {

                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_detalle_pago_from_id]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_pago_electronico", pIdPago);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                DataTable Table_ = new DataTable();
                adat.Fill(Table_);
                this.vGridControl1.DataSource = Table_;
                con.Close();
                this.vGridControl1.BestFit();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void LoadTipoPagoList()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_lista_pagos]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("", 0);
                dsVentaSuccess1.tipos_pagos.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsVentaSuccess1.tipos_pagos);

                //cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception EX)
            {
                CajaDialogo.Error(EX.Message);
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


            //Otros metodos de pago, compra click o tigo money
            ListboxPrintersTarjeta.Items.Clear();
            foreach (string printname in PrinterSettings.InstalledPrinters)
            {
                ListboxPrintersOtros.Items.Add(printname, false);
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
                    cmdOtrosPagos.Appearance.BackColor = Color.White;   
                    xtraTabPage1.PageVisible = true;
                    xtraTabPage2.PageVisible = 
                    xtraTabPage3.PageVisible =
                    xtraTabPage4.PageVisible = false;
                    break;
                case TipoPago.Tarjeta: //2
                    cmdEfectivo.Appearance.BackColor = Color.White;
                    cmdTarjeta.Appearance.BackColor = Color.LightSkyBlue;
                    cmdDepositoBancario.Appearance.BackColor = Color.White;
                    cmdOtrosPagos.Appearance.BackColor = Color.White;
                    xtraTabPage1.PageVisible = false;
                    xtraTabPage2.PageVisible = true;
                    xtraTabPage3.PageVisible = 
                    xtraTabPage4.PageVisible = false;
                    break;
                case TipoPago.DepositoBancario: //3
                    cmdEfectivo.Appearance.BackColor = Color.White;
                    cmdTarjeta.Appearance.BackColor = Color.White;
                    cmdDepositoBancario.Appearance.BackColor = Color.LightSkyBlue;
                    cmdOtrosPagos.Appearance.BackColor = Color.White;
                    xtraTabPage1.PageVisible = 
                    xtraTabPage2.PageVisible = false;
                    xtraTabPage4.PageVisible = false;
                    xtraTabPage3.PageVisible = true;
                    break;
                case TipoPago.Otros: //4
                    cmdEfectivo.Appearance.BackColor = Color.White;
                    cmdTarjeta.Appearance.BackColor = Color.White;
                    cmdDepositoBancario.Appearance.BackColor = Color.White;
                    cmdOtrosPagos.Appearance.BackColor = Color.LightSkyBlue;
                    xtraTabPage1.PageVisible =
                    xtraTabPage2.PageVisible =
                    xtraTabPage3.PageVisible = false;
                    xtraTabPage4.PageVisible = true;
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


            if (ValorA_Pagar > varPago)
            {
                CajaDialogo.Error("No se puede realizar la transaccion, el valor entregado debe ser mayor o igual al de la factura.");
                return;
            }

            varPago = (dp.ValidateNumberDecimal(txtEntregado.Text) - dp.ValidateNumberDecimal(txtCambio.Text));

            if (string.IsNullOrEmpty(PrinterName))
            {
                foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem item in ListboxPrintersEfectivo.Items)
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

            if (ValorA_Pagar > varPago)
            {
                CajaDialogo.Error("No se puede realizar la transaccion, el valor entregado debe ser mayor o igual al de la factura.");
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
            if (ValorA_Pagar > varPago)
            {
                CajaDialogo.Error("No se puede realizar la transaccion, el valor transferido debe ser mayor o igual al de la factura.");
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

            if (string.IsNullOrEmpty(gridLookUpEditBancos.Text))
            {
                CajaDialogo.Error("Es necesario indicar el Banco y No. de Cuenta!");
                return; 
            }

            IdMetodoPagoElectronico = dp.ValidateNumberInt32(gridLookUpEditBancos.EditValue);

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

        private void cmdOtrosPagos_Click(object sender, EventArgs e)
        {
            tabPagos.SelectedTabPage = xtraTabPage4;
            TipoPagoSeleccionadoActual = TipoPago.Otros;
            SetButtonPago();
            gleTiposPagosElectronicos.Focus();
        }

        private void gleTiposPagosElectronicos_EditValueChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(gleTiposPagosElectronicos.Text))
            {
                IdMetodoPagoElectronico = dp.ValidateNumberInt32(gleTiposPagosElectronicos.EditValue);
                LoadDetallePago(IdMetodoPagoElectronico);
            }
           
        }

        private void gleTiposPagosElectronicos_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                seMontoOtros.Focus();
            }
        }

        private void seMontoOtros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtReferenciaOtros.Focus();
        }

        private void txtReferenciaOtros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                rgFormatoOtros.Focus();
        }

        private void rgFormatoOtros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
                ListboxPrintersOtros.Focus();
        }

        private void ListboxPrintersOtros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cmdPagarOtros.Focus();
        }

        private void cmdPagarOtros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cmdPagarOtros_Click(sender, new EventArgs());
        }

        private void cmdPagarOtros_Click(object sender, EventArgs e)
        {
            varPago = dp.ValidateNumberDecimal(seMontoOtros.Value);
            if (ValorA_Pagar > varPago)
            {
                CajaDialogo.Error("No se puede realizar la transaccion, el valor transferido debe ser mayor o igual al de la factura.");
                return;
            }

            if (string.IsNullOrEmpty(PrinterName))
            {
                foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem item in ListboxPrintersOtros.Items)
                {
                    if (item.CheckState == CheckState.Checked)
                        PrinterName = item.Value.ToString();
                }
            }

            if (!string.IsNullOrEmpty(txtReferenciaOtros.Text))
            {
                ReferenciaReciboPago = txtReferenciaOtros.Text;
            }

            //if (string.IsNullOrEmpty(gridLookUpEditBancos.Text))
            if (string.IsNullOrEmpty(gleTiposPagosElectronicos.Text))
            {
                CajaDialogo.Error("Es necesario indicar el Banco y No. de Cuenta!");
                return;
            }

            IdMetodoPagoElectronico = dp.ValidateNumberInt32(gleTiposPagosElectronicos.EditValue);

            if (IdFormato == 0)
            {
                IdFormato = Convert.ToInt32(radioGroup1.EditValue);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void gridLookUpEditBancos_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(gridLookUpEditBancos.Text))
            {
                IdMetodoPagoElectronico = dp.ValidateNumberInt32(gridLookUpEditBancos.EditValue);
                //LoadDetallePago(IdMetodoPagoElectronico);
            }
        }
    }
}