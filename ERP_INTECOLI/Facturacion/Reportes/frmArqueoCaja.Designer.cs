using ERP_INTECOLI.Facturacion.CoreFacturas;

namespace JAGUAR_APP.Facturacion.Reportes
{
    partial class frmArqueoCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArqueoCaja));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.dtHasta = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dtDesde = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cmdRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsContabilidad1 = new ERP_INTECOLI.Facturacion.CoreFacturas.dsContabilidad();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_tipo_pago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo_pago_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collinea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor_contado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtPuntoVenta = new DevExpress.XtraEditors.TextEdit();
            this.txtResponsable = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtEstado = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gvFacturas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero_documento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcant_print = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_user = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_row = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_documento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRTN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_orden_compra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_punto_venta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_numeracion_fiscal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcliente_nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstadoName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsarioCreateName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPuntoVentaName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoPagoName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnImprimir = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colPagar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdPagarFactura = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAutorizar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colvalor_pagado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsaldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtCodigoCierre = new DevExpress.XtraEditors.TextEdit();
            this.lblCodigoCierre = new DevExpress.XtraEditors.LabelControl();
            this.txtAutorizadoPor = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cmdAutorizarCierre = new DevExpress.XtraEditors.SimpleButton();
            this.cmdImprimir = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContabilidad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPuntoVenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResponsable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdPagarFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAutorizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoCierre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAutorizadoPor.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dtHasta
            // 
            this.dtHasta.EditValue = null;
            this.dtHasta.Location = new System.Drawing.Point(213, 30);
            this.dtHasta.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHasta.Properties.Appearance.Options.UseFont = true;
            this.dtHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.dtHasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtHasta.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtHasta.Size = new System.Drawing.Size(128, 26);
            this.dtHasta.TabIndex = 74;
            this.dtHasta.EditValueChanged += new System.EventHandler(this.dtHasta_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(131, 35);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(73, 17);
            this.labelControl3.TabIndex = 73;
            this.labelControl3.Text = "Fecha Hasta:";
            // 
            // dtDesde
            // 
            this.dtDesde.EditValue = null;
            this.dtDesde.Location = new System.Drawing.Point(213, 0);
            this.dtDesde.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDesde.Properties.Appearance.Options.UseFont = true;
            this.dtDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.dtDesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtDesde.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtDesde.Size = new System.Drawing.Size(128, 26);
            this.dtDesde.TabIndex = 72;
            this.dtDesde.Visible = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(131, 5);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(77, 17);
            this.labelControl5.TabIndex = 71;
            this.labelControl5.Text = "Fecha Desde:";
            this.labelControl5.Visible = false;
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdRefresh.Appearance.Options.UseFont = true;
            this.cmdRefresh.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdRefresh.ImageOptions.Image")));
            this.cmdRefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdRefresh.Location = new System.Drawing.Point(346, 20);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(95, 36);
            this.cmdRefresh.TabIndex = 70;
            this.cmdRefresh.Text = "Refresh";
            this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "resumen_cobros";
            this.gridControl1.DataSource = this.dsContabilidad1;
            this.gridControl1.Location = new System.Drawing.Point(12, 63);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(429, 127);
            this.gridControl1.TabIndex = 75;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsContabilidad1
            // 
            this.dsContabilidad1.DataSetName = "dsContabilidad";
            this.dsContabilidad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_tipo_pago,
            this.coltipo_pago_name,
            this.coltotal,
            this.collinea,
            this.colvalor_contado,
            this.colid1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // colid_tipo_pago
            // 
            this.colid_tipo_pago.FieldName = "id_tipo_pago";
            this.colid_tipo_pago.Name = "colid_tipo_pago";
            this.colid_tipo_pago.OptionsColumn.ReadOnly = true;
            // 
            // coltipo_pago_name
            // 
            this.coltipo_pago_name.FieldName = "tipo_pago_name";
            this.coltipo_pago_name.Name = "coltipo_pago_name";
            this.coltipo_pago_name.OptionsColumn.ReadOnly = true;
            this.coltipo_pago_name.Visible = true;
            this.coltipo_pago_name.VisibleIndex = 1;
            this.coltipo_pago_name.Width = 165;
            // 
            // coltotal
            // 
            this.coltotal.DisplayFormat.FormatString = "n2";
            this.coltotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltotal.FieldName = "total";
            this.coltotal.Name = "coltotal";
            this.coltotal.OptionsColumn.ReadOnly = true;
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 2;
            this.coltotal.Width = 100;
            // 
            // collinea
            // 
            this.collinea.FieldName = "linea";
            this.collinea.Name = "collinea";
            this.collinea.OptionsColumn.ReadOnly = true;
            this.collinea.Visible = true;
            this.collinea.VisibleIndex = 0;
            this.collinea.Width = 41;
            // 
            // colvalor_contado
            // 
            this.colvalor_contado.DisplayFormat.FormatString = "n2";
            this.colvalor_contado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colvalor_contado.FieldName = "valor_contado";
            this.colvalor_contado.Name = "colvalor_contado";
            this.colvalor_contado.Visible = true;
            this.colvalor_contado.VisibleIndex = 3;
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(466, 91);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(92, 17);
            this.labelControl1.TabIndex = 76;
            this.labelControl1.Text = "Punto de Venta:";
            // 
            // txtPuntoVenta
            // 
            this.txtPuntoVenta.Location = new System.Drawing.Point(561, 88);
            this.txtPuntoVenta.Name = "txtPuntoVenta";
            this.txtPuntoVenta.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.txtPuntoVenta.Properties.Appearance.Options.UseFont = true;
            this.txtPuntoVenta.Properties.ReadOnly = true;
            this.txtPuntoVenta.Size = new System.Drawing.Size(171, 22);
            this.txtPuntoVenta.TabIndex = 77;
            // 
            // txtResponsable
            // 
            this.txtResponsable.Location = new System.Drawing.Point(561, 116);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.txtResponsable.Properties.Appearance.Options.UseFont = true;
            this.txtResponsable.Properties.ReadOnly = true;
            this.txtResponsable.Size = new System.Drawing.Size(171, 22);
            this.txtResponsable.TabIndex = 79;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(466, 117);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 17);
            this.labelControl2.TabIndex = 78;
            this.labelControl2.Text = "Responsable:";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(561, 142);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.txtEstado.Properties.Appearance.Options.UseFont = true;
            this.txtEstado.Properties.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(171, 22);
            this.txtEstado.TabIndex = 81;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(466, 143);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(43, 17);
            this.labelControl4.TabIndex = 80;
            this.labelControl4.Text = "Estado:";
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdGuardar.Appearance.Options.UseFont = true;
            this.cmdGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.ImageOptions.Image")));
            this.cmdGuardar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdGuardar.Location = new System.Drawing.Point(12, 20);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(95, 36);
            this.cmdGuardar.TabIndex = 82;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton2.Location = new System.Drawing.Point(753, 12);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(134, 36);
            this.simpleButton2.TabIndex = 83;
            this.simpleButton2.Text = "Cerrar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.DataMember = "HomeFacturas";
            this.gridControl2.DataSource = this.dsContabilidad1;
            this.gridControl2.Location = new System.Drawing.Point(12, 196);
            this.gridControl2.MainView = this.gvFacturas;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnImprimir,
            this.cmdPagarFactura,
            this.btnAutorizar});
            this.gridControl2.Size = new System.Drawing.Size(875, 273);
            this.gridControl2.TabIndex = 84;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFacturas});
            // 
            // gvFacturas
            // 
            this.gvFacturas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colnumero_documento,
            this.colenable,
            this.colid_estado,
            this.colcant_print,
            this.colid_user,
            this.colfecha_row,
            this.colfecha_documento,
            this.colid_cliente,
            this.colRTN,
            this.colnum_orden_compra,
            this.colid_punto_venta,
            this.colid_numeracion_fiscal,
            this.colcliente_nombre,
            this.gridColumn1,
            this.colTotalFactura,
            this.colEstadoName,
            this.colUsarioCreateName,
            this.colPuntoVentaName,
            this.colTipoPagoName,
            this.gridColumn2,
            this.colPagar,
            this.gridColumn3,
            this.colvalor_pagado,
            this.colsaldo});
            this.gvFacturas.GridControl = this.gridControl2;
            this.gvFacturas.Name = "gvFacturas";
            this.gvFacturas.OptionsView.ShowAutoFilterRow = true;
            this.gvFacturas.OptionsView.ShowFooter = true;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colnumero_documento
            // 
            this.colnumero_documento.FieldName = "numero_documento";
            this.colnumero_documento.Name = "colnumero_documento";
            this.colnumero_documento.OptionsColumn.ReadOnly = true;
            this.colnumero_documento.Visible = true;
            this.colnumero_documento.VisibleIndex = 0;
            this.colnumero_documento.Width = 71;
            // 
            // colenable
            // 
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            // 
            // colid_estado
            // 
            this.colid_estado.FieldName = "id_estado";
            this.colid_estado.Name = "colid_estado";
            // 
            // colcant_print
            // 
            this.colcant_print.FieldName = "cant_print";
            this.colcant_print.Name = "colcant_print";
            // 
            // colid_user
            // 
            this.colid_user.FieldName = "id_user";
            this.colid_user.Name = "colid_user";
            // 
            // colfecha_row
            // 
            this.colfecha_row.FieldName = "fecha_row";
            this.colfecha_row.Name = "colfecha_row";
            // 
            // colfecha_documento
            // 
            this.colfecha_documento.FieldName = "fecha_documento";
            this.colfecha_documento.Name = "colfecha_documento";
            this.colfecha_documento.OptionsColumn.ReadOnly = true;
            this.colfecha_documento.Visible = true;
            this.colfecha_documento.VisibleIndex = 1;
            this.colfecha_documento.Width = 71;
            // 
            // colid_cliente
            // 
            this.colid_cliente.FieldName = "id_cliente";
            this.colid_cliente.Name = "colid_cliente";
            // 
            // colRTN
            // 
            this.colRTN.FieldName = "RTN";
            this.colRTN.Name = "colRTN";
            this.colRTN.OptionsColumn.ReadOnly = true;
            this.colRTN.Width = 71;
            // 
            // colnum_orden_compra
            // 
            this.colnum_orden_compra.FieldName = "num_orden_compra";
            this.colnum_orden_compra.Name = "colnum_orden_compra";
            // 
            // colid_punto_venta
            // 
            this.colid_punto_venta.FieldName = "id_punto_venta";
            this.colid_punto_venta.Name = "colid_punto_venta";
            // 
            // colid_numeracion_fiscal
            // 
            this.colid_numeracion_fiscal.FieldName = "id_numeracion_fiscal";
            this.colid_numeracion_fiscal.Name = "colid_numeracion_fiscal";
            // 
            // colcliente_nombre
            // 
            this.colcliente_nombre.FieldName = "cliente_nombre";
            this.colcliente_nombre.Name = "colcliente_nombre";
            this.colcliente_nombre.OptionsColumn.ReadOnly = true;
            this.colcliente_nombre.Visible = true;
            this.colcliente_nombre.VisibleIndex = 2;
            this.colcliente_nombre.Width = 71;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "id_tipo_pago";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // colTotalFactura
            // 
            this.colTotalFactura.DisplayFormat.FormatString = "n2";
            this.colTotalFactura.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalFactura.FieldName = "TotalFactura";
            this.colTotalFactura.Name = "colTotalFactura";
            this.colTotalFactura.OptionsColumn.ReadOnly = true;
            this.colTotalFactura.Visible = true;
            this.colTotalFactura.VisibleIndex = 3;
            this.colTotalFactura.Width = 71;
            // 
            // colEstadoName
            // 
            this.colEstadoName.FieldName = "EstadoName";
            this.colEstadoName.Name = "colEstadoName";
            this.colEstadoName.OptionsColumn.ReadOnly = true;
            this.colEstadoName.Visible = true;
            this.colEstadoName.VisibleIndex = 6;
            this.colEstadoName.Width = 71;
            // 
            // colUsarioCreateName
            // 
            this.colUsarioCreateName.FieldName = "UsarioCreateName";
            this.colUsarioCreateName.Name = "colUsarioCreateName";
            this.colUsarioCreateName.OptionsColumn.ReadOnly = true;
            this.colUsarioCreateName.Visible = true;
            this.colUsarioCreateName.VisibleIndex = 7;
            this.colUsarioCreateName.Width = 71;
            // 
            // colPuntoVentaName
            // 
            this.colPuntoVentaName.FieldName = "PuntoVentaName";
            this.colPuntoVentaName.Name = "colPuntoVentaName";
            this.colPuntoVentaName.OptionsColumn.ReadOnly = true;
            this.colPuntoVentaName.Width = 71;
            // 
            // colTipoPagoName
            // 
            this.colTipoPagoName.FieldName = "TipoPagoName";
            this.colTipoPagoName.Name = "colTipoPagoName";
            this.colTipoPagoName.OptionsColumn.ReadOnly = true;
            this.colTipoPagoName.Visible = true;
            this.colTipoPagoName.VisibleIndex = 8;
            this.colTipoPagoName.Width = 71;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Imprimir";
            this.gridColumn2.ColumnEdit = this.btnImprimir;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Width = 56;
            // 
            // btnImprimir
            // 
            this.btnImprimir.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnImprimir.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // colPagar
            // 
            this.colPagar.Caption = "Pagar";
            this.colPagar.ColumnEdit = this.cmdPagarFactura;
            this.colPagar.Name = "colPagar";
            this.colPagar.Width = 60;
            // 
            // cmdPagarFactura
            // 
            this.cmdPagarFactura.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.cmdPagarFactura.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdPagarFactura.Name = "cmdPagarFactura";
            this.cmdPagarFactura.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Solicitar Autorizacion";
            this.gridColumn3.ColumnEdit = this.btnAutorizar;
            this.gridColumn3.FieldName = "autorizacion";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Width = 106;
            // 
            // btnAutorizar
            // 
            this.btnAutorizar.AutoHeight = false;
            this.btnAutorizar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.btnAutorizar.Name = "btnAutorizar";
            this.btnAutorizar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // colvalor_pagado
            // 
            this.colvalor_pagado.DisplayFormat.FormatString = "n2";
            this.colvalor_pagado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colvalor_pagado.FieldName = "valor_pagado";
            this.colvalor_pagado.Name = "colvalor_pagado";
            this.colvalor_pagado.OptionsColumn.ReadOnly = true;
            this.colvalor_pagado.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "valor_pagado", "SUM={0:n2}")});
            this.colvalor_pagado.Visible = true;
            this.colvalor_pagado.VisibleIndex = 4;
            // 
            // colsaldo
            // 
            this.colsaldo.DisplayFormat.FormatString = "n2";
            this.colsaldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colsaldo.FieldName = "saldo";
            this.colsaldo.Name = "colsaldo";
            this.colsaldo.OptionsColumn.ReadOnly = true;
            this.colsaldo.Visible = true;
            this.colsaldo.VisibleIndex = 5;
            // 
            // txtCodigoCierre
            // 
            this.txtCodigoCierre.Location = new System.Drawing.Point(561, 60);
            this.txtCodigoCierre.Name = "txtCodigoCierre";
            this.txtCodigoCierre.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.txtCodigoCierre.Properties.Appearance.Options.UseFont = true;
            this.txtCodigoCierre.Properties.ReadOnly = true;
            this.txtCodigoCierre.Size = new System.Drawing.Size(171, 22);
            this.txtCodigoCierre.TabIndex = 86;
            // 
            // lblCodigoCierre
            // 
            this.lblCodigoCierre.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCierre.Appearance.Options.UseFont = true;
            this.lblCodigoCierre.Location = new System.Drawing.Point(466, 63);
            this.lblCodigoCierre.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lblCodigoCierre.Name = "lblCodigoCierre";
            this.lblCodigoCierre.Size = new System.Drawing.Size(85, 17);
            this.lblCodigoCierre.TabIndex = 85;
            this.lblCodigoCierre.Text = "Codigo Cierre:";
            // 
            // txtAutorizadoPor
            // 
            this.txtAutorizadoPor.Location = new System.Drawing.Point(561, 168);
            this.txtAutorizadoPor.Name = "txtAutorizadoPor";
            this.txtAutorizadoPor.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.txtAutorizadoPor.Properties.Appearance.Options.UseFont = true;
            this.txtAutorizadoPor.Properties.ReadOnly = true;
            this.txtAutorizadoPor.Size = new System.Drawing.Size(171, 22);
            this.txtAutorizadoPor.TabIndex = 88;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(466, 169);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(92, 17);
            this.labelControl6.TabIndex = 87;
            this.labelControl6.Text = "Autorizado por:";
            // 
            // cmdAutorizarCierre
            // 
            this.cmdAutorizarCierre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAutorizarCierre.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdAutorizarCierre.Appearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmdAutorizarCierre.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdAutorizarCierre.Appearance.Options.UseBackColor = true;
            this.cmdAutorizarCierre.Appearance.Options.UseBorderColor = true;
            this.cmdAutorizarCierre.Appearance.Options.UseFont = true;
            this.cmdAutorizarCierre.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdAutorizarCierre.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdAutorizarCierre.ImageOptions.Image")));
            this.cmdAutorizarCierre.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdAutorizarCierre.Location = new System.Drawing.Point(613, 12);
            this.cmdAutorizarCierre.Name = "cmdAutorizarCierre";
            this.cmdAutorizarCierre.Size = new System.Drawing.Size(134, 36);
            this.cmdAutorizarCierre.TabIndex = 89;
            this.cmdAutorizarCierre.Text = "Autorizar Cierre";
            this.cmdAutorizarCierre.Click += new System.EventHandler(this.cmdAutorizarCierre_Click);
            // 
            // cmdImprimir
            // 
            this.cmdImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdImprimir.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdImprimir.Appearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmdImprimir.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdImprimir.Appearance.Options.UseBackColor = true;
            this.cmdImprimir.Appearance.Options.UseBorderColor = true;
            this.cmdImprimir.Appearance.Options.UseFont = true;
            this.cmdImprimir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdImprimir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdImprimir.ImageOptions.Image")));
            this.cmdImprimir.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdImprimir.Location = new System.Drawing.Point(473, 12);
            this.cmdImprimir.Name = "cmdImprimir";
            this.cmdImprimir.Size = new System.Drawing.Size(134, 36);
            this.cmdImprimir.TabIndex = 90;
            this.cmdImprimir.Text = "Imprimir";
            this.cmdImprimir.Visible = false;
            this.cmdImprimir.Click += new System.EventHandler(this.cmdImprimir_Click);
            // 
            // frmArqueoCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 472);
            this.Controls.Add(this.cmdImprimir);
            this.Controls.Add(this.cmdAutorizarCierre);
            this.Controls.Add(this.txtAutorizadoPor);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtCodigoCierre);
            this.Controls.Add(this.lblCodigoCierre);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtResponsable);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtPuntoVenta);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.dtHasta);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.dtDesde);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.cmdRefresh);
            this.Name = "frmArqueoCaja";
            this.Text = "Resumen de Documentos Cobrados";
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContabilidad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPuntoVenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResponsable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdPagarFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAutorizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoCierre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAutorizadoPor.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dtHasta;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit dtDesde;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton cmdRefresh;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsContabilidad dsContabilidad1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_tipo_pago;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo_pago_name;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal;
        private DevExpress.XtraGrid.Columns.GridColumn collinea;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtPuntoVenta;
        private DevExpress.XtraEditors.TextEdit txtResponsable;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtEstado;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gvFacturas;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_documento;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn colid_estado;
        private DevExpress.XtraGrid.Columns.GridColumn colcant_print;
        private DevExpress.XtraGrid.Columns.GridColumn colid_user;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_row;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_documento;
        private DevExpress.XtraGrid.Columns.GridColumn colid_cliente;
        private DevExpress.XtraGrid.Columns.GridColumn colRTN;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_orden_compra;
        private DevExpress.XtraGrid.Columns.GridColumn colid_punto_venta;
        private DevExpress.XtraGrid.Columns.GridColumn colid_numeracion_fiscal;
        private DevExpress.XtraGrid.Columns.GridColumn colcliente_nombre;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colEstadoName;
        private DevExpress.XtraGrid.Columns.GridColumn colUsarioCreateName;
        private DevExpress.XtraGrid.Columns.GridColumn colPuntoVentaName;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoPagoName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnImprimir;
        private DevExpress.XtraGrid.Columns.GridColumn colPagar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdPagarFactura;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnAutorizar;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor_pagado;
        private DevExpress.XtraGrid.Columns.GridColumn colsaldo;
        private DevExpress.XtraEditors.TextEdit txtCodigoCierre;
        private DevExpress.XtraEditors.LabelControl lblCodigoCierre;
        private DevExpress.XtraEditors.TextEdit txtAutorizadoPor;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton cmdAutorizarCierre;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor_contado;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraEditors.SimpleButton cmdImprimir;
    }
}