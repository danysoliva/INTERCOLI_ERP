
namespace ERP_INTECOLI.Administracion.Caja
{
    partial class frmRePrintFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRePrintFactura));
            this.cmdSearchFacturas = new DevExpress.XtraEditors.SimpleButton();
            this.ListboxPrinters = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RadioVistaPrevia = new System.Windows.Forms.RadioButton();
            this.radioImpresionDirecta = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdPrintFact = new DevExpress.XtraEditors.SimpleButton();
            this.radioGroup2 = new DevExpress.XtraEditors.RadioGroup();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.txtNumero = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ListboxPrinters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdSearchFacturas
            // 
            this.cmdSearchFacturas.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdSearchFacturas.ImageOptions.SvgImage")));
            this.cmdSearchFacturas.Location = new System.Drawing.Point(310, 16);
            this.cmdSearchFacturas.Name = "cmdSearchFacturas";
            this.cmdSearchFacturas.Size = new System.Drawing.Size(40, 41);
            this.cmdSearchFacturas.TabIndex = 33;
            this.cmdSearchFacturas.Click += new System.EventHandler(this.cmdSearchFacturas_Click);
            // 
            // ListboxPrinters
            // 
            this.ListboxPrinters.Appearance.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.ListboxPrinters.Appearance.Options.UseFont = true;
            this.ListboxPrinters.CheckMode = DevExpress.XtraEditors.CheckMode.Single;
            this.ListboxPrinters.Location = new System.Drawing.Point(116, 182);
            this.ListboxPrinters.Name = "ListboxPrinters";
            this.ListboxPrinters.Size = new System.Drawing.Size(236, 134);
            this.ListboxPrinters.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F);
            this.label6.Location = new System.Drawing.Point(20, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 31;
            this.label6.Text = "Impresora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 30;
            this.label5.Text = "Formato";
            // 
            // RadioVistaPrevia
            // 
            this.RadioVistaPrevia.AutoSize = true;
            this.RadioVistaPrevia.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.RadioVistaPrevia.Location = new System.Drawing.Point(196, 65);
            this.RadioVistaPrevia.Name = "RadioVistaPrevia";
            this.RadioVistaPrevia.Size = new System.Drawing.Size(109, 19);
            this.RadioVistaPrevia.TabIndex = 28;
            this.RadioVistaPrevia.Text = "Vista Previa";
            this.RadioVistaPrevia.UseVisualStyleBackColor = true;
            // 
            // radioImpresionDirecta
            // 
            this.radioImpresionDirecta.AutoSize = true;
            this.radioImpresionDirecta.Checked = true;
            this.radioImpresionDirecta.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.radioImpresionDirecta.Location = new System.Drawing.Point(30, 65);
            this.radioImpresionDirecta.Name = "radioImpresionDirecta";
            this.radioImpresionDirecta.Size = new System.Drawing.Size(144, 19);
            this.radioImpresionDirecta.TabIndex = 27;
            this.radioImpresionDirecta.TabStop = true;
            this.radioImpresionDirecta.Text = "Impresion Directa";
            this.radioImpresionDirecta.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Numero Factura:";
            // 
            // cmdPrintFact
            // 
            this.cmdPrintFact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdPrintFact.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cmdPrintFact.Appearance.BorderColor = System.Drawing.Color.LightGray;
            this.cmdPrintFact.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cmdPrintFact.Appearance.Options.UseBackColor = true;
            this.cmdPrintFact.Appearance.Options.UseBorderColor = true;
            this.cmdPrintFact.Appearance.Options.UseFont = true;
            this.cmdPrintFact.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdPrintFact.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdPrintFact.ImageOptions.Image")));
            this.cmdPrintFact.Location = new System.Drawing.Point(53, 322);
            this.cmdPrintFact.Name = "cmdPrintFact";
            this.cmdPrintFact.Size = new System.Drawing.Size(111, 50);
            this.cmdPrintFact.TabIndex = 34;
            this.cmdPrintFact.Text = "Imprimir";
            this.cmdPrintFact.Click += new System.EventHandler(this.cmdPrintFact_Click);
            // 
            // radioGroup2
            // 
            this.radioGroup2.Location = new System.Drawing.Point(116, 110);
            this.radioGroup2.Name = "radioGroup2";
            this.radioGroup2.Properties.Appearance.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGroup2.Properties.Appearance.Options.UseFont = true;
            this.radioGroup2.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "3.5\" Cinta"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Carta 8.5x11\"")});
            this.radioGroup2.Size = new System.Drawing.Size(140, 61);
            this.radioGroup2.TabIndex = 29;
            // 
            // radioGroup1
            // 
            this.radioGroup1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioGroup1.Location = new System.Drawing.Point(18, 63);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.radioGroup1.Properties.Appearance.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.radioGroup1.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroup1.Properties.Appearance.Options.UseFont = true;
            this.radioGroup1.Size = new System.Drawing.Size(334, 25);
            this.radioGroup1.TabIndex = 26;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Image = global::ERP_INTECOLI.Properties.Resources.cerrar;
            this.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCancelar.Location = new System.Drawing.Point(196, 322);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(109, 50);
            this.cmdCancelar.TabIndex = 25;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(18, 35);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Properties.Appearance.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txtNumero.Properties.Appearance.Options.UseFont = true;
            this.txtNumero.Properties.EditFormat.FormatString = "###-###-##-########";
            this.txtNumero.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtNumero.Properties.MaskSettings.Set("mask", "###-###-##-########");
            this.txtNumero.Size = new System.Drawing.Size(287, 22);
            this.txtNumero.TabIndex = 23;
            // 
            // frmRePrintFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 384);
            this.Controls.Add(this.cmdPrintFact);
            this.Controls.Add(this.cmdSearchFacturas);
            this.Controls.Add(this.ListboxPrinters);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioGroup2);
            this.Controls.Add(this.RadioVistaPrevia);
            this.Controls.Add(this.radioImpresionDirecta);
            this.Controls.Add(this.radioGroup1);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Name = "frmRePrintFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reimprimir Factura";
            ((System.ComponentModel.ISupportInitialize)(this.ListboxPrinters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdSearchFacturas;
        private DevExpress.XtraEditors.CheckedListBoxControl ListboxPrinters;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.RadioGroup radioGroup2;
        private System.Windows.Forms.RadioButton RadioVistaPrevia;
        private System.Windows.Forms.RadioButton radioImpresionDirecta;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private System.Windows.Forms.Button cmdCancelar;
        private DevExpress.XtraEditors.TextEdit txtNumero;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton cmdPrintFact;
    }
}