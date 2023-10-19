namespace JAGUAR_APP.Facturacion.CoreFacturas
{
    partial class frmHomePagoMultipleSimple
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomePagoMultipleSimple));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions4 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject13 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject14 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject15 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject16 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsFacturasGestion1 = new JAGUAR_APP.Facturacion.CoreFacturas.dsFacturasGestion();
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
            this.colid_tipo_pago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gleTipoPagoGrid = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.bindingS_TipoPagoGrid = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstadoName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsarioCreateName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPuntoVentaName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoPagoName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnImprimir = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colPagar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdPagarFactura = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAutorizar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colseleccionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsaldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colabono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdExportToExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.TabFacturas = new DevExpress.XtraTab.XtraTabPage();
            this.gleTipoPago = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bindingSourceTipoPago = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gleCliente = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bindingSourceClientes = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtReferencia = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblSaldo = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.TabRecibos = new DevExpress.XtraTab.XtraTabPage();
            this.dtHasta = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.dtDesde = new DevExpress.XtraEditors.DateEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.cmdRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlRecibos = new DevExpress.XtraGrid.GridControl();
            this.gridViewRecibos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_recibo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_doc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_usuario_created = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario_creador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_usuario_updated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario_ultima_modificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconcepto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_cliente1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_created = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_updated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_punto_venta1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_tipo_pago1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo_pago_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_formato_impresion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo_formato_impresion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimprimir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdImprimirRecibo = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cmdPagoMultiple = new DevExpress.XtraEditors.SimpleButton();
            this.colid_termino_pago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltermino_pago_name = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturasGestion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleTipoPagoGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingS_TipoPagoGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdPagarFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAutorizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.TabFacturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gleTipoPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipoPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            this.TabRecibos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRecibos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRecibos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdImprimirRecibo)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "HomeFacturas";
            this.gridControl1.DataSource = this.dsFacturasGestion1;
            this.gridControl1.Location = new System.Drawing.Point(0, 72);
            this.gridControl1.MainView = this.gvFacturas;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnImprimir,
            this.cmdPagarFactura,
            this.btnAutorizar,
            this.gleTipoPagoGrid});
            this.gridControl1.Size = new System.Drawing.Size(923, 374);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFacturas});
            // 
            // dsFacturasGestion1
            // 
            this.dsFacturasGestion1.DataSetName = "dsFacturasGestion";
            this.dsFacturasGestion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.colid_tipo_pago,
            this.colTotalFactura,
            this.colEstadoName,
            this.colUsarioCreateName,
            this.colPuntoVentaName,
            this.colTipoPagoName,
            this.gridColumn1,
            this.colPagar,
            this.gridColumn2,
            this.colseleccionado,
            this.colsaldo,
            this.colabono,
            this.colid_termino_pago,
            this.coltermino_pago_name});
            this.gvFacturas.GridControl = this.gridControl1;
            this.gvFacturas.Name = "gvFacturas";
            this.gvFacturas.OptionsView.ShowAutoFilterRow = true;
            this.gvFacturas.OptionsView.ShowFooter = true;
            this.gvFacturas.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvFacturas_CellValueChanged);
            this.gvFacturas.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvFacturas_CellValueChanging);
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
            this.colnumero_documento.Width = 169;
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
            this.colfecha_documento.VisibleIndex = 2;
            this.colfecha_documento.Width = 92;
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
            this.colRTN.Width = 58;
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
            this.colcliente_nombre.Width = 105;
            // 
            // colid_tipo_pago
            // 
            this.colid_tipo_pago.Caption = "Tipo Pago";
            this.colid_tipo_pago.ColumnEdit = this.gleTipoPagoGrid;
            this.colid_tipo_pago.FieldName = "id_tipo_pago";
            this.colid_tipo_pago.Name = "colid_tipo_pago";
            this.colid_tipo_pago.Visible = true;
            this.colid_tipo_pago.VisibleIndex = 7;
            this.colid_tipo_pago.Width = 109;
            // 
            // gleTipoPagoGrid
            // 
            this.gleTipoPagoGrid.AutoHeight = false;
            this.gleTipoPagoGrid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gleTipoPagoGrid.DataSource = this.bindingS_TipoPagoGrid;
            this.gleTipoPagoGrid.DisplayMember = "descripcion";
            this.gleTipoPagoGrid.Name = "gleTipoPagoGrid";
            this.gleTipoPagoGrid.PopupView = this.repositoryItemGridLookUpEdit1View;
            this.gleTipoPagoGrid.SearchMode = DevExpress.XtraEditors.Repository.GridLookUpSearchMode.AutoSearch;
            this.gleTipoPagoGrid.ValueMember = "id";
            // 
            // bindingS_TipoPagoGrid
            // 
            this.bindingS_TipoPagoGrid.DataMember = "tipo_pago_factura";
            this.bindingS_TipoPagoGrid.DataSource = this.dsFacturasGestion1;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid3,
            this.coldescripcion1});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid3
            // 
            this.colid3.FieldName = "id";
            this.colid3.Name = "colid3";
            // 
            // coldescripcion1
            // 
            this.coldescripcion1.FieldName = "descripcion";
            this.coldescripcion1.Name = "coldescripcion1";
            this.coldescripcion1.Visible = true;
            this.coldescripcion1.VisibleIndex = 0;
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
            this.colTotalFactura.Width = 109;
            // 
            // colEstadoName
            // 
            this.colEstadoName.FieldName = "EstadoName";
            this.colEstadoName.Name = "colEstadoName";
            this.colEstadoName.OptionsColumn.ReadOnly = true;
            this.colEstadoName.Width = 53;
            // 
            // colUsarioCreateName
            // 
            this.colUsarioCreateName.FieldName = "UsarioCreateName";
            this.colUsarioCreateName.Name = "colUsarioCreateName";
            this.colUsarioCreateName.OptionsColumn.ReadOnly = true;
            this.colUsarioCreateName.Width = 49;
            // 
            // colPuntoVentaName
            // 
            this.colPuntoVentaName.FieldName = "PuntoVentaName";
            this.colPuntoVentaName.Name = "colPuntoVentaName";
            this.colPuntoVentaName.OptionsColumn.ReadOnly = true;
            this.colPuntoVentaName.Width = 55;
            // 
            // colTipoPagoName
            // 
            this.colTipoPagoName.FieldName = "TipoPagoName";
            this.colTipoPagoName.Name = "colTipoPagoName";
            this.colTipoPagoName.OptionsColumn.ReadOnly = true;
            this.colTipoPagoName.Width = 80;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Imprimir";
            this.gridColumn1.ColumnEdit = this.btnImprimir;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 8;
            this.gridColumn1.Width = 78;
            // 
            // btnImprimir
            // 
            this.btnImprimir.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnImprimir.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnImprimir.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnImprimir_ButtonClick);
            // 
            // colPagar
            // 
            this.colPagar.Caption = "Pagar";
            this.colPagar.ColumnEdit = this.cmdPagarFactura;
            this.colPagar.Name = "colPagar";
            this.colPagar.Visible = true;
            this.colPagar.VisibleIndex = 9;
            this.colPagar.Width = 76;
            // 
            // cmdPagarFactura
            // 
            this.cmdPagarFactura.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.cmdPagarFactura.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdPagarFactura.Name = "cmdPagarFactura";
            this.cmdPagarFactura.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdPagarFactura.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdPagarFactura_ButtonClick);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Solicitar Autorizacion";
            this.gridColumn2.ColumnEdit = this.btnAutorizar;
            this.gridColumn2.FieldName = "autorizacion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Width = 53;
            // 
            // btnAutorizar
            // 
            this.btnAutorizar.AutoHeight = false;
            //editorButtonImageOptions3.Image = global::JAGUAR_APP.Properties.Resources.shield_16X16;
            this.btnAutorizar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnAutorizar.Name = "btnAutorizar";
            this.btnAutorizar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnAutorizar.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnAutorizar_ButtonPressed);
            // 
            // colseleccionado
            // 
            this.colseleccionado.FieldName = "seleccionado";
            this.colseleccionado.Name = "colseleccionado";
            this.colseleccionado.Visible = true;
            this.colseleccionado.VisibleIndex = 6;
            this.colseleccionado.Width = 79;
            // 
            // colsaldo
            // 
            this.colsaldo.DisplayFormat.FormatString = "n2";
            this.colsaldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colsaldo.FieldName = "saldo";
            this.colsaldo.Name = "colsaldo";
            this.colsaldo.OptionsColumn.ReadOnly = true;
            this.colsaldo.Visible = true;
            this.colsaldo.VisibleIndex = 4;
            this.colsaldo.Width = 104;
            // 
            // colabono
            // 
            this.colabono.DisplayFormat.FormatString = "n2";
            this.colabono.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colabono.FieldName = "abono";
            this.colabono.Name = "colabono";
            this.colabono.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "abono", "SUM={0:n2}")});
            this.colabono.Visible = true;
            this.colabono.VisibleIndex = 5;
            this.colabono.Width = 82;
            // 
            // cmdExportToExcel
            // 
            this.cmdExportToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExportToExcel.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdExportToExcel.Appearance.Options.UseFont = true;
            this.cmdExportToExcel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            //this.cmdExportToExcel.ImageOptions.Image = global::JAGUAR_APP.Properties.Resources.excel32px;
            this.cmdExportToExcel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdExportToExcel.Location = new System.Drawing.Point(728, 3);
            this.cmdExportToExcel.Name = "cmdExportToExcel";
            this.cmdExportToExcel.Size = new System.Drawing.Size(95, 36);
            this.cmdExportToExcel.TabIndex = 1;
            this.cmdExportToExcel.Text = "Excel";
            this.cmdExportToExcel.Click += new System.EventHandler(this.cmdExportToExcel_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(829, 3);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(95, 36);
            this.btnAtras.TabIndex = 2;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(2, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(311, 23);
            this.labelControl1.TabIndex = 52;
            this.labelControl1.Text = "Pago de multiples documentos";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(2, 42);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.TabFacturas;
            this.xtraTabControl1.Size = new System.Drawing.Size(925, 474);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabFacturas,
            this.TabRecibos});
            // 
            // TabFacturas
            // 
            this.TabFacturas.Controls.Add(this.gleTipoPago);
            this.TabFacturas.Controls.Add(this.gleCliente);
            this.TabFacturas.Controls.Add(this.labelControl4);
            this.TabFacturas.Controls.Add(this.txtReferencia);
            this.TabFacturas.Controls.Add(this.labelControl5);
            this.TabFacturas.Controls.Add(this.lblSaldo);
            this.TabFacturas.Controls.Add(this.labelControl7);
            this.TabFacturas.Controls.Add(this.labelControl3);
            this.TabFacturas.Controls.Add(this.labelControl2);
            this.TabFacturas.Controls.Add(this.txtCodigo);
            this.TabFacturas.Controls.Add(this.gridControl1);
            this.TabFacturas.Name = "TabFacturas";
            this.TabFacturas.Size = new System.Drawing.Size(923, 449);
            this.TabFacturas.Text = "Facturas";
            // 
            // gleTipoPago
            // 
            this.gleTipoPago.Location = new System.Drawing.Point(75, 39);
            this.gleTipoPago.Name = "gleTipoPago";
            this.gleTipoPago.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gleTipoPago.Properties.Appearance.Options.UseFont = true;
            this.gleTipoPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gleTipoPago.Properties.DataSource = this.bindingSourceTipoPago;
            this.gleTipoPago.Properties.DisplayMember = "descripcion";
            this.gleTipoPago.Properties.NullText = "";
            this.gleTipoPago.Properties.PopupView = this.gridView1;
            this.gleTipoPago.Properties.SearchMode = DevExpress.XtraEditors.Repository.GridLookUpSearchMode.AutoSearch;
            this.gleTipoPago.Properties.ValueMember = "id";
            this.gleTipoPago.Size = new System.Drawing.Size(133, 24);
            this.gleTipoPago.TabIndex = 1;
            this.gleTipoPago.EditValueChanged += new System.EventHandler(this.gleTipoPago_EditValueChanged);
            this.gleTipoPago.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gleTipoPago_KeyDown);
            // 
            // bindingSourceTipoPago
            // 
            this.bindingSourceTipoPago.DataMember = "tipo_pago_factura";
            this.bindingSourceTipoPago.DataSource = this.dsFacturasGestion1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.coldescripcion});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFilter.InHeaderSearchMode = DevExpress.XtraGrid.Views.Grid.GridInHeaderSearchMode.TextFilter;
            this.gridView1.OptionsFilter.ShowInHeaderSearchTextMode = DevExpress.XtraGrid.Views.Grid.ShowInHeaderSearchTextMode.Text;
            this.gridView1.OptionsFind.SearchInPreview = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            // 
            // coldescripcion
            // 
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            // 
            // gleCliente
            // 
            this.gleCliente.Location = new System.Drawing.Point(286, 12);
            this.gleCliente.Name = "gleCliente";
            this.gleCliente.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gleCliente.Properties.Appearance.Options.UseFont = true;
            this.gleCliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gleCliente.Properties.DataSource = this.bindingSourceClientes;
            this.gleCliente.Properties.DisplayMember = "Nombre";
            this.gleCliente.Properties.NullText = "";
            this.gleCliente.Properties.PopupView = this.gridLookUpEdit1View;
            this.gleCliente.Properties.SearchMode = DevExpress.XtraEditors.Repository.GridLookUpSearchMode.AutoSearch;
            this.gleCliente.Properties.ValueMember = "id";
            this.gleCliente.Size = new System.Drawing.Size(344, 24);
            this.gleCliente.TabIndex = 0;
            this.gleCliente.EditValueChanged += new System.EventHandler(this.gleCliente_EditValueChanged);
            this.gleCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gleCliente_KeyDown);
            // 
            // bindingSourceClientes
            // 
            this.bindingSourceClientes.DataMember = "clientes_factura";
            this.bindingSourceClientes.DataSource = this.dsFacturasGestion1;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid2,
            this.colNombre});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsFilter.ShowInHeaderSearchTextMode = DevExpress.XtraGrid.Views.Grid.ShowInHeaderSearchTextMode.Text;
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid2
            // 
            this.colid2.FieldName = "id";
            this.colid2.Name = "colid2";
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(214, 42);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(68, 17);
            this.labelControl4.TabIndex = 70;
            this.labelControl4.Text = "Referencia:";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(286, 39);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferencia.Properties.Appearance.Options.UseFont = true;
            this.txtReferencia.Size = new System.Drawing.Size(344, 24);
            this.txtReferencia.TabIndex = 2;
            this.txtReferencia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReferencia_KeyDown);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(2, 42);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(67, 17);
            this.labelControl5.TabIndex = 68;
            this.labelControl5.Text = "Tipo Pago:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaldo.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Appearance.Options.UseFont = true;
            this.lblSaldo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblSaldo.Location = new System.Drawing.Point(778, 13);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(146, 19);
            this.lblSaldo.TabIndex = 66;
            this.lblSaldo.Text = "0.00";
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseTextOptions = true;
            this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.Location = new System.Drawing.Point(660, 13);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(112, 19);
            this.labelControl7.TabIndex = 65;
            this.labelControl7.Text = "Saldo Actual:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(214, 15);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 17);
            this.labelControl3.TabIndex = 64;
            this.labelControl3.Text = "Cliente:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(2, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 17);
            this.labelControl2.TabIndex = 62;
            this.labelControl2.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(75, 12);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Properties.Appearance.Options.UseFont = true;
            this.txtCodigo.Properties.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(133, 24);
            this.txtCodigo.TabIndex = 61;
            // 
            // TabRecibos
            // 
            this.TabRecibos.Controls.Add(this.dtHasta);
            this.TabRecibos.Controls.Add(this.labelControl6);
            this.TabRecibos.Controls.Add(this.dtDesde);
            this.TabRecibos.Controls.Add(this.labelControl8);
            this.TabRecibos.Controls.Add(this.cmdRefresh);
            this.TabRecibos.Controls.Add(this.gridControlRecibos);
            this.TabRecibos.Name = "TabRecibos";
            this.TabRecibos.Size = new System.Drawing.Size(923, 449);
            this.TabRecibos.Text = "Recibos de Pagos Efectuados";
            // 
            // dtHasta
            // 
            this.dtHasta.EditValue = null;
            this.dtHasta.Location = new System.Drawing.Point(89, 36);
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
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(7, 41);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(73, 17);
            this.labelControl6.TabIndex = 73;
            this.labelControl6.Text = "Fecha Hasta:";
            // 
            // dtDesde
            // 
            this.dtDesde.EditValue = null;
            this.dtDesde.Location = new System.Drawing.Point(89, 6);
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
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(7, 11);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(77, 17);
            this.labelControl8.TabIndex = 71;
            this.labelControl8.Text = "Fecha Desde:";
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdRefresh.Appearance.Options.UseFont = true;
            this.cmdRefresh.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdRefresh.ImageOptions.Image")));
            this.cmdRefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdRefresh.Location = new System.Drawing.Point(222, 6);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(95, 56);
            this.cmdRefresh.TabIndex = 70;
            this.cmdRefresh.Text = "Refresh";
            this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click_1);
            // 
            // gridControlRecibos
            // 
            this.gridControlRecibos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlRecibos.DataMember = "RecibosH";
            this.gridControlRecibos.DataSource = this.dsFacturasGestion1;
            this.gridControlRecibos.Location = new System.Drawing.Point(0, 66);
            this.gridControlRecibos.MainView = this.gridViewRecibos;
            this.gridControlRecibos.Name = "gridControlRecibos";
            this.gridControlRecibos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdImprimirRecibo});
            this.gridControlRecibos.Size = new System.Drawing.Size(923, 383);
            this.gridControlRecibos.TabIndex = 0;
            this.gridControlRecibos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRecibos});
            // 
            // gridViewRecibos
            // 
            this.gridViewRecibos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_recibo,
            this.colnum_doc,
            this.colenable1,
            this.colid_usuario_created,
            this.colusuario_creador,
            this.colid_usuario_updated,
            this.colusuario_ultima_modificacion,
            this.colconcepto,
            this.colid_cliente1,
            this.colNombreCliente,
            this.colfecha_created,
            this.colfecha_updated,
            this.colid_punto_venta1,
            this.colvalor,
            this.colid_tipo_pago1,
            this.coltipo_pago_descripcion,
            this.colid_formato_impresion,
            this.coltipo_formato_impresion,
            this.colimprimir});
            this.gridViewRecibos.GridControl = this.gridControlRecibos;
            this.gridViewRecibos.Name = "gridViewRecibos";
            // 
            // colid_recibo
            // 
            this.colid_recibo.FieldName = "id_recibo";
            this.colid_recibo.Name = "colid_recibo";
            this.colid_recibo.OptionsColumn.ReadOnly = true;
            // 
            // colnum_doc
            // 
            this.colnum_doc.FieldName = "num_doc";
            this.colnum_doc.Name = "colnum_doc";
            this.colnum_doc.OptionsColumn.ReadOnly = true;
            this.colnum_doc.Visible = true;
            this.colnum_doc.VisibleIndex = 0;
            this.colnum_doc.Width = 90;
            // 
            // colenable1
            // 
            this.colenable1.FieldName = "enable";
            this.colenable1.Name = "colenable1";
            this.colenable1.OptionsColumn.ReadOnly = true;
            // 
            // colid_usuario_created
            // 
            this.colid_usuario_created.FieldName = "id_usuario_created";
            this.colid_usuario_created.Name = "colid_usuario_created";
            this.colid_usuario_created.OptionsColumn.ReadOnly = true;
            // 
            // colusuario_creador
            // 
            this.colusuario_creador.FieldName = "usuario_creador";
            this.colusuario_creador.Name = "colusuario_creador";
            this.colusuario_creador.OptionsColumn.ReadOnly = true;
            this.colusuario_creador.Visible = true;
            this.colusuario_creador.VisibleIndex = 1;
            this.colusuario_creador.Width = 83;
            // 
            // colid_usuario_updated
            // 
            this.colid_usuario_updated.FieldName = "id_usuario_updated";
            this.colid_usuario_updated.Name = "colid_usuario_updated";
            this.colid_usuario_updated.OptionsColumn.ReadOnly = true;
            // 
            // colusuario_ultima_modificacion
            // 
            this.colusuario_ultima_modificacion.FieldName = "usuario_ultima_modificacion";
            this.colusuario_ultima_modificacion.Name = "colusuario_ultima_modificacion";
            this.colusuario_ultima_modificacion.OptionsColumn.ReadOnly = true;
            this.colusuario_ultima_modificacion.Width = 79;
            // 
            // colconcepto
            // 
            this.colconcepto.FieldName = "concepto";
            this.colconcepto.Name = "colconcepto";
            this.colconcepto.OptionsColumn.ReadOnly = true;
            this.colconcepto.Visible = true;
            this.colconcepto.VisibleIndex = 2;
            this.colconcepto.Width = 186;
            // 
            // colid_cliente1
            // 
            this.colid_cliente1.FieldName = "id_cliente";
            this.colid_cliente1.Name = "colid_cliente1";
            this.colid_cliente1.OptionsColumn.ReadOnly = true;
            // 
            // colNombreCliente
            // 
            this.colNombreCliente.FieldName = "NombreCliente";
            this.colNombreCliente.Name = "colNombreCliente";
            this.colNombreCliente.OptionsColumn.ReadOnly = true;
            this.colNombreCliente.Visible = true;
            this.colNombreCliente.VisibleIndex = 3;
            this.colNombreCliente.Width = 112;
            // 
            // colfecha_created
            // 
            this.colfecha_created.FieldName = "fecha_created";
            this.colfecha_created.Name = "colfecha_created";
            this.colfecha_created.OptionsColumn.ReadOnly = true;
            this.colfecha_created.Visible = true;
            this.colfecha_created.VisibleIndex = 4;
            this.colfecha_created.Width = 72;
            // 
            // colfecha_updated
            // 
            this.colfecha_updated.FieldName = "fecha_updated";
            this.colfecha_updated.Name = "colfecha_updated";
            this.colfecha_updated.OptionsColumn.ReadOnly = true;
            // 
            // colid_punto_venta1
            // 
            this.colid_punto_venta1.FieldName = "id_punto_venta";
            this.colid_punto_venta1.Name = "colid_punto_venta1";
            this.colid_punto_venta1.OptionsColumn.ReadOnly = true;
            // 
            // colvalor
            // 
            this.colvalor.FieldName = "valor";
            this.colvalor.Name = "colvalor";
            this.colvalor.OptionsColumn.ReadOnly = true;
            this.colvalor.Visible = true;
            this.colvalor.VisibleIndex = 5;
            this.colvalor.Width = 67;
            // 
            // colid_tipo_pago1
            // 
            this.colid_tipo_pago1.FieldName = "id_tipo_pago";
            this.colid_tipo_pago1.Name = "colid_tipo_pago1";
            this.colid_tipo_pago1.OptionsColumn.ReadOnly = true;
            // 
            // coltipo_pago_descripcion
            // 
            this.coltipo_pago_descripcion.FieldName = "tipo_pago_descripcion";
            this.coltipo_pago_descripcion.Name = "coltipo_pago_descripcion";
            this.coltipo_pago_descripcion.OptionsColumn.ReadOnly = true;
            this.coltipo_pago_descripcion.Visible = true;
            this.coltipo_pago_descripcion.VisibleIndex = 6;
            this.coltipo_pago_descripcion.Width = 93;
            // 
            // colid_formato_impresion
            // 
            this.colid_formato_impresion.FieldName = "id_formato_impresion";
            this.colid_formato_impresion.Name = "colid_formato_impresion";
            this.colid_formato_impresion.OptionsColumn.ReadOnly = true;
            // 
            // coltipo_formato_impresion
            // 
            this.coltipo_formato_impresion.FieldName = "tipo_formato_impresion";
            this.coltipo_formato_impresion.Name = "coltipo_formato_impresion";
            this.coltipo_formato_impresion.OptionsColumn.ReadOnly = true;
            this.coltipo_formato_impresion.Visible = true;
            this.coltipo_formato_impresion.VisibleIndex = 7;
            this.coltipo_formato_impresion.Width = 116;
            // 
            // colimprimir
            // 
            this.colimprimir.ColumnEdit = this.cmdImprimirRecibo;
            this.colimprimir.FieldName = "imprimir";
            this.colimprimir.Name = "colimprimir";
            this.colimprimir.Visible = true;
            this.colimprimir.VisibleIndex = 8;
            // 
            // cmdImprimirRecibo
            // 
            this.cmdImprimirRecibo.AutoHeight = false;
            editorButtonImageOptions4.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions4.Image")));
            this.cmdImprimirRecibo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions4, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject13, serializableAppearanceObject14, serializableAppearanceObject15, serializableAppearanceObject16, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdImprimirRecibo.Name = "cmdImprimirRecibo";
            this.cmdImprimirRecibo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdImprimirRecibo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdImprimirRecibo_ButtonClick);
            // 
            // cmdPagoMultiple
            // 
            this.cmdPagoMultiple.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdPagoMultiple.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cmdPagoMultiple.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdPagoMultiple.Appearance.Options.UseBackColor = true;
            this.cmdPagoMultiple.Appearance.Options.UseFont = true;
            this.cmdPagoMultiple.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdPagoMultiple.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdPagoMultiple.ImageOptions.Image")));
            this.cmdPagoMultiple.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdPagoMultiple.Location = new System.Drawing.Point(546, 3);
            this.cmdPagoMultiple.Name = "cmdPagoMultiple";
            this.cmdPagoMultiple.Size = new System.Drawing.Size(176, 36);
            this.cmdPagoMultiple.TabIndex = 4;
            this.cmdPagoMultiple.Text = "Pagar / Imprimir";
            this.cmdPagoMultiple.Click += new System.EventHandler(this.cmdPagoMultiple_Click_1);
            // 
            // colid_termino_pago
            // 
            this.colid_termino_pago.FieldName = "id_termino_pago";
            this.colid_termino_pago.Name = "colid_termino_pago";
            // 
            // coltermino_pago_name
            // 
            this.coltermino_pago_name.FieldName = "termino_pago_name";
            this.coltermino_pago_name.Name = "coltermino_pago_name";
            this.coltermino_pago_name.OptionsColumn.ReadOnly = true;
            this.coltermino_pago_name.Visible = true;
            this.coltermino_pago_name.VisibleIndex = 1;
            // 
            // frmHomePagoMultipleSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 518);
            this.Controls.Add(this.cmdPagoMultiple);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmdExportToExcel);
            this.Controls.Add(this.btnAtras);
            this.Name = "frmHomePagoMultipleSimple";
            this.Text = "Home Pago Multiple";
            this.Activated += new System.EventHandler(this.frmHomePagoMultipleSimple_Activated);
            this.Load += new System.EventHandler(this.frmHomePagoMultipleSimple_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturasGestion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleTipoPagoGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingS_TipoPagoGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdPagarFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAutorizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.TabFacturas.ResumeLayout(false);
            this.TabFacturas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gleTipoPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipoPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            this.TabRecibos.ResumeLayout(false);
            this.TabRecibos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRecibos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRecibos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdImprimirRecibo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvFacturas;
        private dsFacturasGestion dsFacturasGestion1;
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
        private DevExpress.XtraGrid.Columns.GridColumn colid_tipo_pago;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colEstadoName;
        private DevExpress.XtraGrid.Columns.GridColumn colUsarioCreateName;
        private DevExpress.XtraGrid.Columns.GridColumn colPuntoVentaName;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoPagoName;
        private DevExpress.XtraEditors.SimpleButton cmdExportToExcel;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnImprimir;
        private DevExpress.XtraGrid.Columns.GridColumn colPagar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdPagarFactura;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnAutorizar;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage TabFacturas;
        private DevExpress.XtraTab.XtraTabPage TabRecibos;
        private DevExpress.XtraGrid.GridControl gridControlRecibos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRecibos;
        private DevExpress.XtraGrid.Columns.GridColumn colid_recibo;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_doc;
        private DevExpress.XtraGrid.Columns.GridColumn colenable1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_usuario_created;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario_creador;
        private DevExpress.XtraGrid.Columns.GridColumn colid_usuario_updated;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario_ultima_modificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colconcepto;
        private DevExpress.XtraGrid.Columns.GridColumn colid_cliente1;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_created;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_updated;
        private DevExpress.XtraGrid.Columns.GridColumn colid_punto_venta1;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor;
        private DevExpress.XtraGrid.Columns.GridColumn colid_tipo_pago1;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo_pago_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colid_formato_impresion;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo_formato_impresion;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccionado;
        private DevExpress.XtraGrid.Columns.GridColumn colsaldo;
        private DevExpress.XtraGrid.Columns.GridColumn colimprimir;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdImprimirRecibo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblSaldo;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.SimpleButton cmdPagoMultiple;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtReferencia;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.GridLookUpEdit gleTipoPago;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GridLookUpEdit gleCliente;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.BindingSource bindingSourceTipoPago;
        private System.Windows.Forms.BindingSource bindingSourceClientes;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colid2;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraEditors.DateEdit dtHasta;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.DateEdit dtDesde;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton cmdRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn colabono;
        private System.Windows.Forms.BindingSource bindingS_TipoPagoGrid;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit gleTipoPagoGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colid3;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_termino_pago;
        private DevExpress.XtraGrid.Columns.GridColumn coltermino_pago_name;
    }
}