namespace JAGUAR_APP.Facturacion.CoreFacturas
{
    partial class frmPagoFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPagoFactura));
            this.tabPagos = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.ListboxPrintersEfectivo = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdPagar = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEntregado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorEfectivo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.ListboxPrintersTarjeta = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.radioGroup2 = new DevExpress.XtraEditors.RadioGroup();
            this.txtValorTC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEntregadoTC = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.ListboxPrintersTransferencia = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.label16 = new System.Windows.Forms.Label();
            this.txtValorPagarTransferencia = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.radioGroup3 = new DevExpress.XtraEditors.RadioGroup();
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmdEfectivo = new DevExpress.XtraEditors.SimpleButton();
            this.cmdTarjeta = new DevExpress.XtraEditors.SimpleButton();
            this.cmdDepositoBancario = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tabPagos)).BeginInit();
            this.tabPagos.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListboxPrintersEfectivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListboxPrintersTarjeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup2.Properties)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListboxPrintersTransferencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPagos
            // 
            this.tabPagos.Appearance.BackColor = System.Drawing.Color.White;
            this.tabPagos.Appearance.Options.UseBackColor = true;
            this.tabPagos.Location = new System.Drawing.Point(321, 24);
            this.tabPagos.Name = "tabPagos";
            this.tabPagos.SelectedTabPage = this.xtraTabPage1;
            this.tabPagos.Size = new System.Drawing.Size(377, 378);
            this.tabPagos.TabIndex = 0;
            this.tabPagos.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Appearance.PageClient.BackColor = System.Drawing.Color.White;
            this.xtraTabPage1.Appearance.PageClient.Options.UseBackColor = true;
            this.xtraTabPage1.Controls.Add(this.ListboxPrintersEfectivo);
            this.xtraTabPage1.Controls.Add(this.label6);
            this.xtraTabPage1.Controls.Add(this.cmdPagar);
            this.xtraTabPage1.Controls.Add(this.label5);
            this.xtraTabPage1.Controls.Add(this.radioGroup1);
            this.xtraTabPage1.Controls.Add(this.txtCambio);
            this.xtraTabPage1.Controls.Add(this.label4);
            this.xtraTabPage1.Controls.Add(this.txtEntregado);
            this.xtraTabPage1.Controls.Add(this.label3);
            this.xtraTabPage1.Controls.Add(this.txtValorEfectivo);
            this.xtraTabPage1.Controls.Add(this.label2);
            this.xtraTabPage1.Controls.Add(this.label1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(375, 353);
            this.xtraTabPage1.Text = "Detalles del Pago";
            // 
            // ListboxPrintersEfectivo
            // 
            this.ListboxPrintersEfectivo.CheckMode = DevExpress.XtraEditors.CheckMode.Single;
            this.ListboxPrintersEfectivo.Location = new System.Drawing.Point(119, 203);
            this.ListboxPrintersEfectivo.Name = "ListboxPrintersEfectivo";
            this.ListboxPrintersEfectivo.Size = new System.Drawing.Size(236, 96);
            this.ListboxPrintersEfectivo.TabIndex = 33;
            this.ListboxPrintersEfectivo.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.ListboxPrinters_ItemCheck);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 24);
            this.label6.TabIndex = 32;
            this.label6.Text = "Impresora";
            // 
            // cmdPagar
            // 
            this.cmdPagar.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPagar.Appearance.Options.UseFont = true;
            this.cmdPagar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdPagar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdPagar.ImageOptions.Image")));
            this.cmdPagar.Location = new System.Drawing.Point(85, 305);
            this.cmdPagar.Name = "cmdPagar";
            this.cmdPagar.Size = new System.Drawing.Size(212, 45);
            this.cmdPagar.TabIndex = 31;
            this.cmdPagar.Text = "Procesar Pago";
            this.cmdPagar.Click += new System.EventHandler(this.cmdPagar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "Formato";
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(119, 136);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Appearance.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGroup1.Properties.Appearance.Options.UseFont = true;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "3.5 pulg. cinta"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "8x11.5 pulg. Carta")});
            this.radioGroup1.Size = new System.Drawing.Size(178, 61);
            this.radioGroup1.TabIndex = 29;
            this.radioGroup1.SelectedIndexChanged += new System.EventHandler(this.radioGroup1_SelectedIndexChanged);
            // 
            // txtCambio
            // 
            this.txtCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambio.Location = new System.Drawing.Point(119, 101);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.ReadOnly = true;
            this.txtCambio.Size = new System.Drawing.Size(178, 29);
            this.txtCambio.TabIndex = 28;
            this.txtCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "Cambio";
            // 
            // txtEntregado
            // 
            this.txtEntregado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntregado.Location = new System.Drawing.Point(119, 66);
            this.txtEntregado.Name = "txtEntregado";
            this.txtEntregado.Size = new System.Drawing.Size(178, 29);
            this.txtEntregado.TabIndex = 26;
            this.txtEntregado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEntregado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEntregado_KeyDown);
            this.txtEntregado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntregado_KeyPress);
            this.txtEntregado.Validated += new System.EventHandler(this.txtEntregado_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Entregado";
            // 
            // txtValorEfectivo
            // 
            this.txtValorEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorEfectivo.Location = new System.Drawing.Point(119, 31);
            this.txtValorEfectivo.Name = "txtValorEfectivo";
            this.txtValorEfectivo.ReadOnly = true;
            this.txtValorEfectivo.Size = new System.Drawing.Size(178, 29);
            this.txtValorEfectivo.TabIndex = 24;
            this.txtValorEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Pago en Efectivo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Valor";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Appearance.PageClient.BackColor = System.Drawing.Color.White;
            this.xtraTabPage2.Appearance.PageClient.Options.UseBackColor = true;
            this.xtraTabPage2.Controls.Add(this.simpleButton1);
            this.xtraTabPage2.Controls.Add(this.ListboxPrintersTarjeta);
            this.xtraTabPage2.Controls.Add(this.label7);
            this.xtraTabPage2.Controls.Add(this.label8);
            this.xtraTabPage2.Controls.Add(this.radioGroup2);
            this.xtraTabPage2.Controls.Add(this.txtValorTC);
            this.xtraTabPage2.Controls.Add(this.label9);
            this.xtraTabPage2.Controls.Add(this.txtEntregadoTC);
            this.xtraTabPage2.Controls.Add(this.label10);
            this.xtraTabPage2.Controls.Add(this.label11);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(375, 353);
            this.xtraTabPage2.Text = "Detalles del Pago";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(85, 300);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(212, 45);
            this.simpleButton1.TabIndex = 25;
            this.simpleButton1.Text = "Procesar Pago";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // ListboxPrintersTarjeta
            // 
            this.ListboxPrintersTarjeta.CheckMode = DevExpress.XtraEditors.CheckMode.Single;
            this.ListboxPrintersTarjeta.Location = new System.Drawing.Point(117, 172);
            this.ListboxPrintersTarjeta.Name = "ListboxPrintersTarjeta";
            this.ListboxPrintersTarjeta.Size = new System.Drawing.Size(236, 122);
            this.ListboxPrintersTarjeta.TabIndex = 24;
            this.ListboxPrintersTarjeta.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.checkedListBoxControl1_ItemCheck);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 24);
            this.label7.TabIndex = 23;
            this.label7.Text = "Impresora";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 24);
            this.label8.TabIndex = 22;
            this.label8.Text = "Formato";
            // 
            // radioGroup2
            // 
            this.radioGroup2.Location = new System.Drawing.Point(117, 105);
            this.radioGroup2.Name = "radioGroup2";
            this.radioGroup2.Properties.Appearance.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGroup2.Properties.Appearance.Options.UseFont = true;
            this.radioGroup2.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "3.5 pulg. cinta"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "8x11.5 pulg. Carta")});
            this.radioGroup2.Size = new System.Drawing.Size(180, 61);
            this.radioGroup2.TabIndex = 21;
            this.radioGroup2.SelectedIndexChanged += new System.EventHandler(this.radioGroup2_SelectedIndexChanged);
            // 
            // txtValorTC
            // 
            this.txtValorTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTC.Location = new System.Drawing.Point(117, 32);
            this.txtValorTC.Name = "txtValorTC";
            this.txtValorTC.ReadOnly = true;
            this.txtValorTC.Size = new System.Drawing.Size(180, 29);
            this.txtValorTC.TabIndex = 20;
            this.txtValorTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(57, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 24);
            this.label9.TabIndex = 19;
            this.label9.Text = "Valor";
            // 
            // txtEntregadoTC
            // 
            this.txtEntregadoTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntregadoTC.Location = new System.Drawing.Point(117, 67);
            this.txtEntregadoTC.Name = "txtEntregadoTC";
            this.txtEntregadoTC.Size = new System.Drawing.Size(180, 29);
            this.txtEntregadoTC.TabIndex = 18;
            this.txtEntregadoTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEntregadoTC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            this.txtEntregadoTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntregadoTC_KeyPress);
            this.txtEntregadoTC.Validated += new System.EventHandler(this.txtEntregadoTC_Validated);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(44, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 24);
            this.label10.TabIndex = 17;
            this.label10.Text = "Tarjeta";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(113, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 24);
            this.label11.TabIndex = 16;
            this.label11.Text = "Pago con Tarjeta";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Appearance.PageClient.BackColor = System.Drawing.Color.White;
            this.xtraTabPage3.Appearance.PageClient.Options.UseBackColor = true;
            this.xtraTabPage3.Controls.Add(this.txtReferencia);
            this.xtraTabPage3.Controls.Add(this.label17);
            this.xtraTabPage3.Controls.Add(this.simpleButton2);
            this.xtraTabPage3.Controls.Add(this.ListboxPrintersTransferencia);
            this.xtraTabPage3.Controls.Add(this.label16);
            this.xtraTabPage3.Controls.Add(this.txtValorPagarTransferencia);
            this.xtraTabPage3.Controls.Add(this.label12);
            this.xtraTabPage3.Controls.Add(this.radioGroup3);
            this.xtraTabPage3.Controls.Add(this.spinEdit1);
            this.xtraTabPage3.Controls.Add(this.label13);
            this.xtraTabPage3.Controls.Add(this.label14);
            this.xtraTabPage3.Controls.Add(this.label15);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(375, 353);
            this.xtraTabPage3.Text = "Detalles del Pago";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferencia.Location = new System.Drawing.Point(209, 110);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(163, 29);
            this.txtReferencia.TabIndex = 40;
            this.txtReferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtReferencia.Validated += new System.EventHandler(this.txtReferencia_Validated);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(6, 112);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 25);
            this.label17.TabIndex = 39;
            this.label17.Text = "Referencia";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton2.Appearance.BorderColor = System.Drawing.Color.LightGray;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseBorderColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton2.Location = new System.Drawing.Point(113, 305);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(145, 46);
            this.simpleButton2.TabIndex = 38;
            this.simpleButton2.Text = "Pagar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // ListboxPrintersTransferencia
            // 
            this.ListboxPrintersTransferencia.CheckMode = DevExpress.XtraEditors.CheckMode.Single;
            this.ListboxPrintersTransferencia.Location = new System.Drawing.Point(113, 212);
            this.ListboxPrintersTransferencia.Name = "ListboxPrintersTransferencia";
            this.ListboxPrintersTransferencia.Size = new System.Drawing.Size(259, 87);
            this.ListboxPrintersTransferencia.TabIndex = 37;
            this.ListboxPrintersTransferencia.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.checkedListBoxControl2_ItemCheck);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(13, 212);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 24);
            this.label16.TabIndex = 36;
            this.label16.Text = "Impresora";
            // 
            // txtValorPagarTransferencia
            // 
            this.txtValorPagarTransferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPagarTransferencia.Location = new System.Drawing.Point(209, 37);
            this.txtValorPagarTransferencia.Name = "txtValorPagarTransferencia";
            this.txtValorPagarTransferencia.ReadOnly = true;
            this.txtValorPagarTransferencia.Size = new System.Drawing.Size(163, 29);
            this.txtValorPagarTransferencia.TabIndex = 35;
            this.txtValorPagarTransferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(128, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 24);
            this.label12.TabIndex = 34;
            this.label12.Text = "Formato";
            // 
            // radioGroup3
            // 
            this.radioGroup3.Location = new System.Drawing.Point(209, 145);
            this.radioGroup3.Name = "radioGroup3";
            this.radioGroup3.Properties.Appearance.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGroup3.Properties.Appearance.Options.UseFont = true;
            this.radioGroup3.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "3.5 pulg. cinta"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "8x11.5 pulg. Carta")});
            this.radioGroup3.Size = new System.Drawing.Size(163, 61);
            this.radioGroup3.TabIndex = 33;
            this.radioGroup3.SelectedIndexChanged += new System.EventHandler(this.radioGroup3_SelectedIndexChanged);
            // 
            // spinEdit1
            // 
            this.spinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(209, 72);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.spinEdit1.Properties.Appearance.Options.UseFont = true;
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit1.Size = new System.Drawing.Size(163, 32);
            this.spinEdit1.TabIndex = 32;
            this.spinEdit1.EditValueChanged += new System.EventHandler(this.spinEdit1_EditValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(3, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(200, 25);
            this.label13.TabIndex = 31;
            this.label13.Text = "Valor de Transferencia";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(3, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 25);
            this.label14.TabIndex = 30;
            this.label14.Text = "Valor a Pagar";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(93, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(220, 25);
            this.label15.TabIndex = 29;
            this.label15.Text = "Pago con Transferencia";
            // 
            // cmdEfectivo
            // 
            this.cmdEfectivo.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEfectivo.Appearance.Options.UseFont = true;
            this.cmdEfectivo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdEfectivo.ImageOptions.Image")));
            this.cmdEfectivo.Location = new System.Drawing.Point(31, 24);
            this.cmdEfectivo.Name = "cmdEfectivo";
            this.cmdEfectivo.Size = new System.Drawing.Size(284, 92);
            this.cmdEfectivo.TabIndex = 1;
            this.cmdEfectivo.Text = "Efectivo";
            this.cmdEfectivo.Click += new System.EventHandler(this.cmdEfectivo_Click);
            // 
            // cmdTarjeta
            // 
            this.cmdTarjeta.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdTarjeta.Appearance.Options.UseFont = true;
            this.cmdTarjeta.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdTarjeta.ImageOptions.Image")));
            this.cmdTarjeta.Location = new System.Drawing.Point(31, 171);
            this.cmdTarjeta.Name = "cmdTarjeta";
            this.cmdTarjeta.Size = new System.Drawing.Size(284, 92);
            this.cmdTarjeta.TabIndex = 2;
            this.cmdTarjeta.Text = "Tarjeta";
            this.cmdTarjeta.Click += new System.EventHandler(this.cmdTarjeta_Click);
            // 
            // cmdDepositoBancario
            // 
            this.cmdDepositoBancario.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDepositoBancario.Appearance.Options.UseFont = true;
            this.cmdDepositoBancario.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdDepositoBancario.ImageOptions.Image")));
            this.cmdDepositoBancario.Location = new System.Drawing.Point(31, 309);
            this.cmdDepositoBancario.Name = "cmdDepositoBancario";
            this.cmdDepositoBancario.Size = new System.Drawing.Size(284, 92);
            this.cmdDepositoBancario.TabIndex = 3;
            this.cmdDepositoBancario.Text = "Depósito Bancario";
            this.cmdDepositoBancario.Click += new System.EventHandler(this.cmdDepositoBancario_Click);
            // 
            // frmPagoFactura
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 405);
            this.Controls.Add(this.cmdDepositoBancario);
            this.Controls.Add(this.cmdTarjeta);
            this.Controls.Add(this.cmdEfectivo);
            this.Controls.Add(this.tabPagos);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmPagoFactura.IconOptions.Image")));
            this.Name = "frmPagoFactura";
            this.Text = "Pago Factura";
            ((System.ComponentModel.ISupportInitialize)(this.tabPagos)).EndInit();
            this.tabPagos.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListboxPrintersEfectivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListboxPrintersTarjeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup2.Properties)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListboxPrintersTransferencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabPagos;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraEditors.SimpleButton cmdEfectivo;
        private DevExpress.XtraEditors.SimpleButton cmdTarjeta;
        private DevExpress.XtraEditors.SimpleButton cmdDepositoBancario;
        private DevExpress.XtraEditors.CheckedListBoxControl ListboxPrintersEfectivo;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton cmdPagar;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEntregado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorEfectivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.CheckedListBoxControl ListboxPrintersTarjeta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.RadioGroup radioGroup2;
        private System.Windows.Forms.TextBox txtValorTC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEntregadoTC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraEditors.RadioGroup radioGroup3;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtValorPagarTransferencia;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.CheckedListBoxControl ListboxPrintersTransferencia;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label label17;
    }
}