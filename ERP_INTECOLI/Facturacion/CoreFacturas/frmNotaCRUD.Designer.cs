
namespace JAGUAR_APP.Facturacion.CoreFacturas
{
    partial class frmNotaCRUD
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCliente = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.deFecha = new DevExpress.XtraEditors.DateEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsFacturasGestion = new JAGUAR_APP.Facturacion.CoreFacturas.dsFacturasGestion();
            this.grd_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_pt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_linea_factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal_line = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_doc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtConcepto = new DevExpress.XtraEditors.MemoEdit();
            this.cmdSave = new DevExpress.XtraEditors.SimpleButton();
            this.cmdClose = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtCAI = new DevExpress.XtraEditors.TextEdit();
            this.lblNota = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtRTN = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtPDV = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtClienteRTN = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturasGestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConcepto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCAI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRTN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPDV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClienteRTN.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(14, 23);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 15);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Cliente:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(62, 20);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Properties.Appearance.Options.UseFont = true;
            this.txtCliente.Properties.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(293, 22);
            this.txtCliente.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(21, 79);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 15);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Fecha:";
            // 
            // deFecha
            // 
            this.deFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deFecha.EditValue = null;
            this.deFecha.Location = new System.Drawing.Point(62, 76);
            this.deFecha.Name = "deFecha";
            this.deFecha.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deFecha.Properties.Appearance.Options.UseFont = true;
            this.deFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFecha.Properties.DisplayFormat.FormatString = "";
            this.deFecha.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deFecha.Properties.EditFormat.FormatString = "";
            this.deFecha.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deFecha.Properties.MaskSettings.Set("mask", "");
            this.deFecha.Size = new System.Drawing.Size(126, 22);
            this.deFecha.TabIndex = 5;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "NotaD";
            this.gridControl1.DataSource = this.dsFacturasGestion;
            this.gridControl1.Location = new System.Drawing.Point(-2, 226);
            this.gridControl1.MainView = this.grd_data;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1071, 248);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grd_data});
            // 
            // dsFacturasGestion
            // 
            this.dsFacturasGestion.DataSetName = "dsFacturasGestion";
            this.dsFacturasGestion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grd_data
            // 
            this.grd_data.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grd_data.Appearance.FooterPanel.Options.UseFont = true;
            this.grd_data.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grd_data.Appearance.HeaderPanel.Options.UseFont = true;
            this.grd_data.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grd_data.Appearance.Row.Options.UseFont = true;
            this.grd_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_pt,
            this.colid_linea_factura,
            this.colcuenta,
            this.coltotal_line,
            this.colnum_doc});
            this.grd_data.GridControl = this.gridControl1;
            this.grd_data.Name = "grd_data";
            this.grd_data.OptionsView.ShowFooter = true;
            this.grd_data.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colid_pt
            // 
            this.colid_pt.FieldName = "id_pt";
            this.colid_pt.Name = "colid_pt";
            // 
            // colid_linea_factura
            // 
            this.colid_linea_factura.FieldName = "id_factura";
            this.colid_linea_factura.Name = "colid_linea_factura";
            // 
            // colcuenta
            // 
            this.colcuenta.Caption = "Cuenta";
            this.colcuenta.FieldName = "cuenta";
            this.colcuenta.Name = "colcuenta";
            this.colcuenta.OptionsColumn.AllowMove = false;
            this.colcuenta.OptionsColumn.ReadOnly = true;
            this.colcuenta.OptionsFilter.AllowFilter = false;
            this.colcuenta.Width = 149;
            // 
            // coltotal_line
            // 
            this.coltotal_line.Caption = "Total Línea";
            this.coltotal_line.DisplayFormat.FormatString = "{0:C2}";
            this.coltotal_line.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltotal_line.FieldName = "total_line";
            this.coltotal_line.Name = "coltotal_line";
            this.coltotal_line.OptionsColumn.AllowMove = false;
            this.coltotal_line.OptionsFilter.AllowFilter = false;
            this.coltotal_line.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total_line", "Total ={0:C2}")});
            this.coltotal_line.Visible = true;
            this.coltotal_line.VisibleIndex = 1;
            this.coltotal_line.Width = 169;
            // 
            // colnum_doc
            // 
            this.colnum_doc.Caption = "# Factura";
            this.colnum_doc.FieldName = "num_doc";
            this.colnum_doc.Name = "colnum_doc";
            this.colnum_doc.OptionsColumn.AllowMove = false;
            this.colnum_doc.OptionsColumn.ReadOnly = true;
            this.colnum_doc.OptionsFilter.AllowFilter = false;
            this.colnum_doc.Visible = true;
            this.colnum_doc.VisibleIndex = 0;
            this.colnum_doc.Width = 877;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(32, 139);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(56, 15);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Concepto:";
            // 
            // txtConcepto
            // 
            this.txtConcepto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConcepto.Location = new System.Drawing.Point(101, 138);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConcepto.Properties.Appearance.Options.UseFont = true;
            this.txtConcepto.Properties.ReadOnly = true;
            this.txtConcepto.Size = new System.Drawing.Size(344, 82);
            this.txtConcepto.TabIndex = 10;
            // 
            // cmdSave
            // 
            this.cmdSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSave.Appearance.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.cmdSave.Appearance.Options.UseBackColor = true;
            //this.cmdSave.ImageOptions.Image = global::JAGUAR_APP.Properties.Resources.save_32x32;
            this.cmdSave.Location = new System.Drawing.Point(817, 139);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(103, 47);
            this.cmdSave.TabIndex = 60;
            this.cmdSave.Text = "Guardar";
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdClose.Appearance.BackColor = System.Drawing.Color.IndianRed;
            this.cmdClose.Appearance.Options.UseBackColor = true;
            //this.cmdClose.ImageOptions.Image = global::JAGUAR_APP.Properties.Resources.cancel2_32;
            this.cmdClose.Location = new System.Drawing.Point(926, 139);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(103, 47);
            this.cmdClose.TabIndex = 61;
            this.cmdClose.Text = "Cancelar";
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(74, 84);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(22, 15);
            this.labelControl6.TabIndex = 63;
            this.labelControl6.Text = "CAI:";
            // 
            // txtCAI
            // 
            this.txtCAI.Location = new System.Drawing.Point(102, 75);
            this.txtCAI.Name = "txtCAI";
            this.txtCAI.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCAI.Properties.Appearance.Options.UseFont = true;
            this.txtCAI.Properties.ReadOnly = true;
            this.txtCAI.Size = new System.Drawing.Size(293, 22);
            this.txtCAI.TabIndex = 62;
            // 
            // lblNota
            // 
            this.lblNota.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNota.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota.Appearance.Options.UseFont = true;
            this.lblNota.Appearance.Options.UseTextOptions = true;
            this.lblNota.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblNota.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblNota.Location = new System.Drawing.Point(-2, 0);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(1071, 25);
            this.lblNota.TabIndex = 64;
            this.lblNota.Text = "Nota";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(74, 56);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 15);
            this.labelControl1.TabIndex = 66;
            this.labelControl1.Text = "RTN:";
            // 
            // txtRTN
            // 
            this.txtRTN.Location = new System.Drawing.Point(102, 50);
            this.txtRTN.Name = "txtRTN";
            this.txtRTN.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRTN.Properties.Appearance.Options.UseFont = true;
            this.txtRTN.Properties.ReadOnly = true;
            this.txtRTN.Size = new System.Drawing.Size(293, 22);
            this.txtRTN.TabIndex = 65;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 28);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(89, 15);
            this.labelControl4.TabIndex = 68;
            this.labelControl4.Text = "Punto de Venta:";
            // 
            // txtPDV
            // 
            this.txtPDV.Location = new System.Drawing.Point(102, 25);
            this.txtPDV.Name = "txtPDV";
            this.txtPDV.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPDV.Properties.Appearance.Options.UseFont = true;
            this.txtPDV.Properties.ReadOnly = true;
            this.txtPDV.Size = new System.Drawing.Size(293, 22);
            this.txtPDV.TabIndex = 67;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(29, 51);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(27, 15);
            this.labelControl7.TabIndex = 70;
            this.labelControl7.Text = "RTN:";
            // 
            // txtClienteRTN
            // 
            this.txtClienteRTN.Location = new System.Drawing.Point(62, 48);
            this.txtClienteRTN.Name = "txtClienteRTN";
            this.txtClienteRTN.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteRTN.Properties.Appearance.Options.UseFont = true;
            this.txtClienteRTN.Properties.ReadOnly = true;
            this.txtClienteRTN.Size = new System.Drawing.Size(293, 22);
            this.txtClienteRTN.TabIndex = 69;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPDV);
            this.groupBox1.Controls.Add(this.txtCAI);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.txtRTN);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 107);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Punto de Venta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCliente);
            this.groupBox2.Controls.Add(this.deFecha);
            this.groupBox2.Controls.Add(this.labelControl7);
            this.groupBox2.Controls.Add(this.labelControl2);
            this.groupBox2.Controls.Add(this.txtClienteRTN);
            this.groupBox2.Controls.Add(this.labelControl3);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox2.Location = new System.Drawing.Point(611, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 104);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Cliente";
            // 
            // frmNotaCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 473);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.txtConcepto);
            this.Name = "frmNotaCRUD";
            this.Text = "Nota de Crédito/Débito";
            this.Load += new System.EventHandler(this.frmNotaCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturasGestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConcepto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCAI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRTN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPDV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClienteRTN.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtCliente;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit deFecha;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView grd_data;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.MemoEdit txtConcepto;
        private DevExpress.XtraEditors.SimpleButton cmdSave;
        private DevExpress.XtraEditors.SimpleButton cmdClose;
        private dsFacturasGestion dsFacturasGestion;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_pt;
        private DevExpress.XtraGrid.Columns.GridColumn colid_linea_factura;
        private DevExpress.XtraGrid.Columns.GridColumn colcuenta;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal_line;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_doc;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtCAI;
        private DevExpress.XtraEditors.LabelControl lblNota;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtRTN;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtPDV;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtClienteRTN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}