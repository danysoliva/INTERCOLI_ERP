
using ERP_INTECOLI.Facturacion.CoreFacturas;

namespace JAGUAR_APP.Facturacion.CoreFacturas
{
    partial class HomeEstadoCuenta
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeEstadoCuenta));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsContabilidad = new ERP_INTECOLI.Facturacion.CoreFacturas.dsContabilidad();
            this.gvEstadoCuenta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_doc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcredito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldebito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconcepto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldoc_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_created = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colreferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnPrint = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtCliente = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTelefono = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtCorreo = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtDireccion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lblSaldo = new DevExpress.XtraEditors.LabelControl();
            this.cmdAjusteSaldo = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContabilidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEstadoCuenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "EstadoCuenta";
            this.gridControl1.DataSource = this.dsContabilidad;
            this.gridControl1.Location = new System.Drawing.Point(1, 122);
            this.gridControl1.MainView = this.gvEstadoCuenta;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnPrint});
            this.gridControl1.Size = new System.Drawing.Size(1216, 413);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEstadoCuenta});
            // 
            // dsContabilidad
            // 
            this.dsContabilidad.DataSetName = "dsContabilidad";
            this.dsContabilidad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvEstadoCuenta
            // 
            this.gvEstadoCuenta.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gvEstadoCuenta.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvEstadoCuenta.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gvEstadoCuenta.Appearance.Row.Options.UseFont = true;
            this.gvEstadoCuenta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colnum_doc,
            this.colcredito,
            this.coldebito,
            this.colconcepto,
            this.coldoc_date,
            this.coldate_created,
            this.colreferencia,
            this.gridColumn1,
            this.gridColumn2});
            this.gvEstadoCuenta.GridControl = this.gridControl1;
            this.gvEstadoCuenta.Name = "gvEstadoCuenta";
            this.gvEstadoCuenta.OptionsView.ShowAutoFilterRow = true;
            this.gvEstadoCuenta.OptionsView.ShowFooter = true;
            this.gvEstadoCuenta.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colnum_doc
            // 
            this.colnum_doc.Caption = "# Transacción";
            this.colnum_doc.FieldName = "num_doc";
            this.colnum_doc.Name = "colnum_doc";
            this.colnum_doc.OptionsColumn.AllowMove = false;
            this.colnum_doc.OptionsColumn.ReadOnly = true;
            this.colnum_doc.OptionsFilter.AllowFilter = false;
            this.colnum_doc.Visible = true;
            this.colnum_doc.VisibleIndex = 0;
            this.colnum_doc.Width = 210;
            // 
            // colcredito
            // 
            this.colcredito.Caption = "Crédito";
            this.colcredito.DisplayFormat.FormatString = "L {0:N2}";
            this.colcredito.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colcredito.FieldName = "credito";
            this.colcredito.Name = "colcredito";
            this.colcredito.OptionsColumn.AllowMove = false;
            this.colcredito.OptionsColumn.ReadOnly = true;
            this.colcredito.OptionsFilter.AllowFilter = false;
            this.colcredito.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "credito", "L {0:0.##}")});
            this.colcredito.Visible = true;
            this.colcredito.VisibleIndex = 5;
            this.colcredito.Width = 111;
            // 
            // coldebito
            // 
            this.coldebito.Caption = "Débito";
            this.coldebito.DisplayFormat.FormatString = "L {0:N2}";
            this.coldebito.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldebito.FieldName = "debito";
            this.coldebito.Name = "coldebito";
            this.coldebito.OptionsColumn.AllowMove = false;
            this.coldebito.OptionsColumn.ReadOnly = true;
            this.coldebito.OptionsFilter.AllowFilter = false;
            this.coldebito.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "debito", "L. {0:0.##}")});
            this.coldebito.Visible = true;
            this.coldebito.VisibleIndex = 6;
            this.coldebito.Width = 95;
            // 
            // colconcepto
            // 
            this.colconcepto.Caption = "Concepto";
            this.colconcepto.FieldName = "concepto";
            this.colconcepto.Name = "colconcepto";
            this.colconcepto.OptionsColumn.AllowMove = false;
            this.colconcepto.OptionsColumn.ReadOnly = true;
            this.colconcepto.OptionsFilter.AllowFilter = false;
            this.colconcepto.Visible = true;
            this.colconcepto.VisibleIndex = 1;
            this.colconcepto.Width = 234;
            // 
            // coldoc_date
            // 
            this.coldoc_date.Caption = "Fecha Documento";
            this.coldoc_date.FieldName = "doc_date";
            this.coldoc_date.Name = "coldoc_date";
            this.coldoc_date.OptionsColumn.AllowMove = false;
            this.coldoc_date.OptionsColumn.ReadOnly = true;
            this.coldoc_date.OptionsFilter.AllowFilter = false;
            this.coldoc_date.Visible = true;
            this.coldoc_date.VisibleIndex = 2;
            this.coldoc_date.Width = 131;
            // 
            // coldate_created
            // 
            this.coldate_created.Caption = "Fecha Creado";
            this.coldate_created.FieldName = "date_created";
            this.coldate_created.Name = "coldate_created";
            this.coldate_created.OptionsColumn.AllowMove = false;
            this.coldate_created.OptionsColumn.ReadOnly = true;
            this.coldate_created.OptionsFilter.AllowFilter = false;
            this.coldate_created.Visible = true;
            this.coldate_created.VisibleIndex = 3;
            this.coldate_created.Width = 116;
            // 
            // colreferencia
            // 
            this.colreferencia.Caption = "# Referencia";
            this.colreferencia.FieldName = "referencia";
            this.colreferencia.Name = "colreferencia";
            this.colreferencia.OptionsColumn.AllowMove = false;
            this.colreferencia.OptionsColumn.ReadOnly = true;
            this.colreferencia.OptionsFilter.AllowFilter = false;
            this.colreferencia.Visible = true;
            this.colreferencia.VisibleIndex = 4;
            this.colreferencia.Width = 210;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Imprimir";
            this.gridColumn1.ColumnEdit = this.btnPrint;
            this.gridColumn1.Name = "gridColumn1";
            // 
            // btnPrint
            // 
            this.btnPrint.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnPrint.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Saldo";
            this.gridColumn2.DisplayFormat.FormatString = "L {0:N2}";
            this.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn2.FieldName = "saldo";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowMove = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.OptionsFilter.AllowFilter = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 7;
            this.gridColumn2.Width = 87;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(237, -4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(765, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Estado de Cuenta";
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(1060, 1);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(145, 44);
            this.btnAtras.TabIndex = 50;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(83, 32);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Properties.Appearance.Options.UseFont = true;
            this.txtCodigo.Properties.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(133, 24);
            this.txtCodigo.TabIndex = 51;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(30, 35);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 17);
            this.labelControl2.TabIndex = 52;
            this.labelControl2.Text = "Código:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(30, 65);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 17);
            this.labelControl3.TabIndex = 54;
            this.labelControl3.Text = "Cliente:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(83, 62);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Properties.Appearance.Options.UseFont = true;
            this.txtCliente.Properties.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(338, 24);
            this.txtCliente.TabIndex = 53;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(484, 35);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(59, 17);
            this.labelControl4.TabIndex = 56;
            this.labelControl4.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(549, 32);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Properties.Appearance.Options.UseFont = true;
            this.txtTelefono.Properties.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(172, 24);
            this.txtTelefono.TabIndex = 55;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(498, 65);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(45, 17);
            this.labelControl5.TabIndex = 58;
            this.labelControl5.Text = "Correo:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(549, 62);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Properties.Appearance.Options.UseFont = true;
            this.txtCorreo.Properties.ReadOnly = true;
            this.txtCorreo.Size = new System.Drawing.Size(172, 24);
            this.txtCorreo.TabIndex = 57;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(1060, 67);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(145, 47);
            this.simpleButton1.TabIndex = 59;
            this.simpleButton1.Text = "Imprimir";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Appearance.Options.UseFont = true;
            this.btnBuscar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBuscar.ImageOptions.SvgImage")));
            this.btnBuscar.Location = new System.Drawing.Point(222, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(103, 33);
            this.btnBuscar.TabIndex = 60;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(15, 95);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(62, 17);
            this.labelControl6.TabIndex = 62;
            this.labelControl6.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(83, 92);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Properties.Appearance.Options.UseFont = true;
            this.txtDireccion.Properties.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(338, 24);
            this.txtDireccion.TabIndex = 61;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseTextOptions = true;
            this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.Location = new System.Drawing.Point(431, 95);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(112, 19);
            this.labelControl7.TabIndex = 63;
            this.labelControl7.Text = "Saldo Actual:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Appearance.Options.UseFont = true;
            this.lblSaldo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblSaldo.Location = new System.Drawing.Point(549, 95);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(231, 19);
            this.lblSaldo.TabIndex = 64;
            this.lblSaldo.Text = "0.00";
            // 
            // cmdAjusteSaldo
            // 
            this.cmdAjusteSaldo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAjusteSaldo.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAjusteSaldo.Appearance.Options.UseFont = true;
            this.cmdAjusteSaldo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdAjusteSaldo.ImageOptions.Image")));
            this.cmdAjusteSaldo.Location = new System.Drawing.Point(909, 67);
            this.cmdAjusteSaldo.Name = "cmdAjusteSaldo";
            this.cmdAjusteSaldo.Size = new System.Drawing.Size(145, 47);
            this.cmdAjusteSaldo.TabIndex = 65;
            this.cmdAjusteSaldo.Text = "Ajustar Saldo";
            this.cmdAjusteSaldo.Click += new System.EventHandler(this.cmdAjusteSaldo_Click);
            // 
            // HomeEstadoCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 535);
            this.Controls.Add(this.cmdAjusteSaldo);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "HomeEstadoCuenta";
            this.Text = "Estado de Cuenta";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContabilidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEstadoCuenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEstadoCuenta;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_doc;
        private DevExpress.XtraGrid.Columns.GridColumn colcredito;
        private DevExpress.XtraGrid.Columns.GridColumn coldebito;
        private DevExpress.XtraGrid.Columns.GridColumn colconcepto;
        private DevExpress.XtraGrid.Columns.GridColumn coldoc_date;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_created;
        private DevExpress.XtraGrid.Columns.GridColumn colreferencia;
        private dsContabilidad dsContabilidad;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnPrint;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtCliente;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtTelefono;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtCorreo;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtDireccion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl lblSaldo;
        private DevExpress.XtraEditors.SimpleButton cmdAjusteSaldo;
    }
}