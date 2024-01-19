
namespace ERP_INTECOLI.Compras
{
    partial class frmFacturasProveedoresMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturasProveedoresMain));
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdSiguiente = new DevExpress.XtraEditors.SimpleButton();
            this.cmdBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.grdSucursales = new DevExpress.XtraEditors.GridLookUpEdit();
            this.sucursalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCompras1 = new ERP_INTECOLI.Compras.dsCompras();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpdv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblSucursal = new DevExpress.XtraEditors.LabelControl();
            this.dtFechaDocumento = new System.Windows.Forms.DateTimePicker();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumFactura = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.txtCAI = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtPersonaContact = new DevExpress.XtraEditors.TextEdit();
            this.txtCodProv = new DevExpress.XtraEditors.ButtonEdit();
            this.txtProveedor = new DevExpress.XtraEditors.TextEdit();
            this.cmdAddDetalle = new DevExpress.XtraEditors.SimpleButton();
            this.dtFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dtFechaContabilizacion = new System.Windows.Forms.DateTimePicker();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDocNum = new System.Windows.Forms.TextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cmdClose = new DevExpress.XtraEditors.SimpleButton();
            this.cmdAnterior = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtUsuarioCreador = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grDetalle = new DevExpress.XtraGrid.GridControl();
            this.grdvDetalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDscription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ButtonDeleteRow = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colid_status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ButtonGridEstadoEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemGrdItem = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtSubTotalLps = new DevExpress.XtraEditors.TextEdit();
            this.txtComentarios = new DevExpress.XtraEditors.MemoEdit();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.txtImpuesto = new DevExpress.XtraEditors.TextEdit();
            this.btnShowPopu = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barbtnCancelOrden = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSucursales.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompras1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumFactura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCAI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonaContact.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodProv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonDeleteRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonGridEstadoEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGrdItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotalLps.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComentarios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImpuesto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.cmdGuardar);
            this.panelControl1.Controls.Add(this.cmdSiguiente);
            this.panelControl1.Controls.Add(this.cmdBuscar);
            this.panelControl1.Controls.Add(this.cmdNuevo);
            this.panelControl1.Controls.Add(this.grdSucursales);
            this.panelControl1.Controls.Add(this.lblSucursal);
            this.panelControl1.Controls.Add(this.dtFechaDocumento);
            this.panelControl1.Controls.Add(this.labelControl15);
            this.panelControl1.Controls.Add(this.txtNumFactura);
            this.panelControl1.Controls.Add(this.labelControl14);
            this.panelControl1.Controls.Add(this.txtCAI);
            this.panelControl1.Controls.Add(this.labelControl13);
            this.panelControl1.Controls.Add(this.txtPersonaContact);
            this.panelControl1.Controls.Add(this.txtCodProv);
            this.panelControl1.Controls.Add(this.txtProveedor);
            this.panelControl1.Controls.Add(this.cmdAddDetalle);
            this.panelControl1.Controls.Add(this.dtFechaVencimiento);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.dtFechaContabilizacion);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.txtEstado);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.txtDocNum);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.cmdClose);
            this.panelControl1.Controls.Add(this.cmdAnterior);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.labelControl12);
            this.panelControl1.Location = new System.Drawing.Point(3, -1);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1122, 259);
            this.panelControl1.TabIndex = 52;
            this.panelControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControl1_MouseDown);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.ImageOptions.Image")));
            this.cmdGuardar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdGuardar.Location = new System.Drawing.Point(237, 12);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(47, 33);
            this.cmdGuardar.TabIndex = 51;
            this.cmdGuardar.ToolTip = "Guardar";
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdSiguiente
            // 
            this.cmdSiguiente.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdSiguiente.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdSiguiente.ImageOptions.SvgImage")));
            this.cmdSiguiente.Location = new System.Drawing.Point(78, 12);
            this.cmdSiguiente.Name = "cmdSiguiente";
            this.cmdSiguiente.Size = new System.Drawing.Size(47, 33);
            this.cmdSiguiente.TabIndex = 48;
            this.cmdSiguiente.ToolTip = "Siguiente";
            this.cmdSiguiente.Click += new System.EventHandler(this.cmdSiguiente_Click);
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdBuscar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdBuscar.ImageOptions.SvgImage")));
            this.cmdBuscar.Location = new System.Drawing.Point(131, 12);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(47, 33);
            this.cmdBuscar.TabIndex = 49;
            this.cmdBuscar.ToolTip = "Buscar";
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdNuevo.ImageOptions.Image")));
            this.cmdNuevo.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdNuevo.Location = new System.Drawing.Point(184, 12);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(47, 33);
            this.cmdNuevo.TabIndex = 50;
            this.cmdNuevo.ToolTip = "Nuevo";
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
            // 
            // grdSucursales
            // 
            this.grdSucursales.Location = new System.Drawing.Point(818, 214);
            this.grdSucursales.Name = "grdSucursales";
            this.grdSucursales.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdSucursales.Properties.Appearance.Options.UseFont = true;
            this.grdSucursales.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdSucursales.Properties.DataSource = this.sucursalesBindingSource;
            this.grdSucursales.Properties.DisplayMember = "pdv";
            this.grdSucursales.Properties.PopupView = this.gridLookUpEdit1View;
            this.grdSucursales.Properties.ValueMember = "id";
            this.grdSucursales.Size = new System.Drawing.Size(277, 24);
            this.grdSucursales.TabIndex = 81;
            this.grdSucursales.Visible = false;
            // 
            // sucursalesBindingSource
            // 
            this.sucursalesBindingSource.DataMember = "sucursales";
            this.sucursalesBindingSource.DataSource = this.dsCompras1;
            // 
            // dsCompras1
            // 
            this.dsCompras1.DataSetName = "dsCompras";
            this.dsCompras1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colpdv});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            // 
            // colpdv
            // 
            this.colpdv.Caption = "Sucursal";
            this.colpdv.FieldName = "pdv";
            this.colpdv.Name = "colpdv";
            this.colpdv.OptionsColumn.AllowEdit = false;
            this.colpdv.Visible = true;
            this.colpdv.VisibleIndex = 0;
            // 
            // lblSucursal
            // 
            this.lblSucursal.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblSucursal.Appearance.Options.UseFont = true;
            this.lblSucursal.Location = new System.Drawing.Point(624, 217);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(246, 18);
            this.lblSucursal.TabIndex = 82;
            this.lblSucursal.Text = "Sucursal__________________";
            this.lblSucursal.Visible = false;
            // 
            // dtFechaDocumento
            // 
            this.dtFechaDocumento.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.dtFechaDocumento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaDocumento.Location = new System.Drawing.Point(818, 151);
            this.dtFechaDocumento.Name = "dtFechaDocumento";
            this.dtFechaDocumento.Size = new System.Drawing.Size(175, 26);
            this.dtFechaDocumento.TabIndex = 80;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(624, 157);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(269, 18);
            this.labelControl15.TabIndex = 79;
            this.labelControl15.Text = "Fecha del Documento___________";
            // 
            // txtNumFactura
            // 
            this.txtNumFactura.Enabled = false;
            this.txtNumFactura.Location = new System.Drawing.Point(215, 177);
            this.txtNumFactura.Name = "txtNumFactura";
            this.txtNumFactura.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtNumFactura.Properties.Appearance.Options.UseFont = true;
            this.txtNumFactura.Size = new System.Drawing.Size(227, 24);
            this.txtNumFactura.TabIndex = 78;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(48, 179);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(196, 18);
            this.labelControl14.TabIndex = 77;
            this.labelControl14.Text = "N# Factura___________";
            // 
            // txtCAI
            // 
            this.txtCAI.Location = new System.Drawing.Point(215, 147);
            this.txtCAI.Name = "txtCAI";
            this.txtCAI.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtCAI.Properties.Appearance.Options.UseFont = true;
            this.txtCAI.Size = new System.Drawing.Size(227, 24);
            this.txtCAI.TabIndex = 75;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(48, 150);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(198, 18);
            this.labelControl13.TabIndex = 76;
            this.labelControl13.Text = "CAI_________________";
            // 
            // txtPersonaContact
            // 
            this.txtPersonaContact.Enabled = false;
            this.txtPersonaContact.Location = new System.Drawing.Point(215, 116);
            this.txtPersonaContact.Name = "txtPersonaContact";
            this.txtPersonaContact.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtPersonaContact.Properties.Appearance.Options.UseFont = true;
            this.txtPersonaContact.Size = new System.Drawing.Size(227, 24);
            this.txtPersonaContact.TabIndex = 73;
            // 
            // txtCodProv
            // 
            this.txtCodProv.Location = new System.Drawing.Point(215, 56);
            this.txtCodProv.Name = "txtCodProv";
            this.txtCodProv.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtCodProv.Properties.Appearance.Options.UseFont = true;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.txtCodProv.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.txtCodProv.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtCodProv.Properties.ReadOnly = true;
            this.txtCodProv.Size = new System.Drawing.Size(227, 24);
            this.txtCodProv.TabIndex = 69;
            this.txtCodProv.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtCodProv_ButtonClick);
            this.txtCodProv.Click += new System.EventHandler(this.txtCodProv_Click);
            // 
            // txtProveedor
            // 
            this.txtProveedor.Enabled = false;
            this.txtProveedor.Location = new System.Drawing.Point(215, 87);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtProveedor.Properties.Appearance.Options.UseFont = true;
            this.txtProveedor.Size = new System.Drawing.Size(227, 24);
            this.txtProveedor.TabIndex = 70;
            // 
            // cmdAddDetalle
            // 
            this.cmdAddDetalle.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdAddDetalle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdAddDetalle.ImageOptions.SvgImage")));
            this.cmdAddDetalle.Location = new System.Drawing.Point(11, 217);
            this.cmdAddDetalle.Name = "cmdAddDetalle";
            this.cmdAddDetalle.Size = new System.Drawing.Size(47, 33);
            this.cmdAddDetalle.TabIndex = 67;
            this.cmdAddDetalle.Tag = "Agregar Item o Servicio";
            this.cmdAddDetalle.ToolTip = "Guardar";
            this.cmdAddDetalle.Click += new System.EventHandler(this.cmdAddDetalle_Click);
            // 
            // dtFechaVencimiento
            // 
            this.dtFechaVencimiento.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.dtFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaVencimiento.Location = new System.Drawing.Point(818, 119);
            this.dtFechaVencimiento.Name = "dtFechaVencimiento";
            this.dtFechaVencimiento.Size = new System.Drawing.Size(175, 26);
            this.dtFechaVencimiento.TabIndex = 65;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(624, 125);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(273, 18);
            this.labelControl4.TabIndex = 64;
            this.labelControl4.Text = "Fecha de Vencimiento___________";
            // 
            // dtFechaContabilizacion
            // 
            this.dtFechaContabilizacion.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.dtFechaContabilizacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaContabilizacion.Location = new System.Drawing.Point(818, 87);
            this.dtFechaContabilizacion.Name = "dtFechaContabilizacion";
            this.dtFechaContabilizacion.Size = new System.Drawing.Size(175, 26);
            this.dtFechaContabilizacion.TabIndex = 63;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(624, 93);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(296, 18);
            this.labelControl3.TabIndex = 62;
            this.labelControl3.Text = "Fecha de Contabilizacion___________";
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.Color.White;
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEstado.Enabled = false;
            this.txtEstado.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtEstado.Location = new System.Drawing.Point(818, 185);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(175, 19);
            this.txtEstado.TabIndex = 61;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(624, 186);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(261, 18);
            this.labelControl2.TabIndex = 60;
            this.labelControl2.Text = "Estado_____________________";
            // 
            // txtDocNum
            // 
            this.txtDocNum.BackColor = System.Drawing.Color.White;
            this.txtDocNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDocNum.Enabled = false;
            this.txtDocNum.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtDocNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtDocNum.Location = new System.Drawing.Point(818, 60);
            this.txtDocNum.Name = "txtDocNum";
            this.txtDocNum.Size = new System.Drawing.Size(175, 19);
            this.txtDocNum.TabIndex = 57;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(624, 60);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(217, 18);
            this.labelControl7.TabIndex = 56;
            this.labelControl7.Text = "Num Doc_______________";
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdClose.ImageOptions.Image")));
            this.cmdClose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdClose.Location = new System.Drawing.Point(1068, 12);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(47, 33);
            this.cmdClose.TabIndex = 52;
            this.cmdClose.ToolTip = "Cerrar Ventana";
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdAnterior
            // 
            this.cmdAnterior.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdAnterior.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdAnterior.ImageOptions.SvgImage")));
            this.cmdAnterior.Location = new System.Drawing.Point(25, 12);
            this.cmdAnterior.Name = "cmdAnterior";
            this.cmdAnterior.Size = new System.Drawing.Size(47, 33);
            this.cmdAnterior.TabIndex = 47;
            this.cmdAnterior.ToolTip = "Anterior";
            this.cmdAnterior.Click += new System.EventHandler(this.cmdAnterior_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(48, 60);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(189, 18);
            this.labelControl5.TabIndex = 71;
            this.labelControl5.Text = "Proveedor___________";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(48, 90);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(170, 18);
            this.labelControl6.TabIndex = 72;
            this.labelControl6.Text = "Nombre___________";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(48, 119);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(264, 18);
            this.labelControl12.TabIndex = 74;
            this.labelControl12.Text = "Persona de Contacto___________";
            // 
            // txtUsuarioCreador
            // 
            this.txtUsuarioCreador.BackColor = System.Drawing.Color.White;
            this.txtUsuarioCreador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuarioCreador.Enabled = false;
            this.txtUsuarioCreador.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtUsuarioCreador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtUsuarioCreador.Location = new System.Drawing.Point(154, 11);
            this.txtUsuarioCreador.Name = "txtUsuarioCreador";
            this.txtUsuarioCreador.Size = new System.Drawing.Size(204, 19);
            this.txtUsuarioCreador.TabIndex = 59;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(6, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(169, 18);
            this.labelControl1.TabIndex = 58;
            this.labelControl1.Text = "Usuario___________";
            // 
            // grDetalle
            // 
            this.grDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grDetalle.DataMember = "factura_detalle";
            this.grDetalle.DataSource = this.dsCompras1;
            this.grDetalle.Location = new System.Drawing.Point(3, 254);
            this.grDetalle.MainView = this.grdvDetalle;
            this.grDetalle.Name = "grDetalle";
            this.grDetalle.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ButtonDeleteRow,
            this.ButtonGridEstadoEdit,
            this.repositoryItemGrdItem});
            this.grDetalle.Size = new System.Drawing.Size(1122, 267);
            this.grDetalle.TabIndex = 53;
            this.grDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvDetalle});
            this.grDetalle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grDetalle_MouseDown);
            // 
            // grdvDetalle
            // 
            this.grdvDetalle.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdvDetalle.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdvDetalle.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdvDetalle.Appearance.Row.Options.UseFont = true;
            this.grdvDetalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemCode,
            this.colDscription,
            this.colQuantity,
            this.colPrice,
            this.colid,
            this.coltotal,
            this.coldelete,
            this.colid_status});
            this.grdvDetalle.CustomizationFormBounds = new System.Drawing.Rectangle(774, 457, 260, 282);
            this.grdvDetalle.GridControl = this.grDetalle;
            this.grdvDetalle.Name = "grdvDetalle";
            this.grdvDetalle.OptionsView.ShowAutoFilterRow = true;
            this.grdvDetalle.OptionsView.ShowFooter = true;
            this.grdvDetalle.OptionsView.ShowGroupPanel = false;
            this.grdvDetalle.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grdvDetalle_CellValueChanging);
            // 
            // colItemCode
            // 
            this.colItemCode.Caption = "Código Item";
            this.colItemCode.FieldName = "itemcode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.OptionsColumn.AllowEdit = false;
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 0;
            // 
            // colDscription
            // 
            this.colDscription.Caption = "Descripción";
            this.colDscription.FieldName = "descripcion";
            this.colDscription.Name = "colDscription";
            this.colDscription.OptionsColumn.AllowEdit = false;
            this.colDscription.Visible = true;
            this.colDscription.VisibleIndex = 1;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Cantidad";
            this.colQuantity.FieldName = "cantidad";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.OptionsColumn.AllowEdit = false;
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 2;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Precio";
            this.colPrice.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrice.FieldName = "precio";
            this.colPrice.Name = "colPrice";
            this.colPrice.OptionsColumn.AllowEdit = false;
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 3;
            // 
            // colid
            // 
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // coltotal
            // 
            this.coltotal.Caption = "Total";
            this.coltotal.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.coltotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltotal.FieldName = "total";
            this.coltotal.Name = "coltotal";
            this.coltotal.OptionsColumn.AllowEdit = false;
            this.coltotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total", "SUM={0:###,##0.00}")});
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 4;
            // 
            // coldelete
            // 
            this.coldelete.Caption = "Eliminar";
            this.coldelete.ColumnEdit = this.ButtonDeleteRow;
            this.coldelete.FieldName = "delete";
            this.coldelete.Name = "coldelete";
            this.coldelete.Visible = true;
            this.coldelete.VisibleIndex = 5;
            // 
            // ButtonDeleteRow
            // 
            this.ButtonDeleteRow.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.ButtonDeleteRow.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.ButtonDeleteRow.Name = "ButtonDeleteRow";
            this.ButtonDeleteRow.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.ButtonDeleteRow.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ButtonDeleteRow_ButtonClick);
            // 
            // colid_status
            // 
            this.colid_status.FieldName = "id_estado";
            this.colid_status.Name = "colid_status";
            this.colid_status.OptionsColumn.AllowEdit = false;
            // 
            // ButtonGridEstadoEdit
            // 
            this.ButtonGridEstadoEdit.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            editorButtonImageOptions3.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonGridEstadoEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.ButtonGridEstadoEdit.Name = "ButtonGridEstadoEdit";
            // 
            // repositoryItemGrdItem
            // 
            this.repositoryItemGrdItem.AutoHeight = false;
            this.repositoryItemGrdItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGrdItem.Name = "repositoryItemGrdItem";
            this.repositoryItemGrdItem.PopupView = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.txtSubTotalLps);
            this.panelControl2.Controls.Add(this.txtComentarios);
            this.panelControl2.Controls.Add(this.txtTotal);
            this.panelControl2.Controls.Add(this.txtImpuesto);
            this.panelControl2.Controls.Add(this.btnShowPopu);
            this.panelControl2.Controls.Add(this.labelControl11);
            this.panelControl2.Controls.Add(this.labelControl10);
            this.panelControl2.Controls.Add(this.labelControl8);
            this.panelControl2.Controls.Add(this.labelControl9);
            this.panelControl2.Controls.Add(this.txtUsuarioCreador);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Location = new System.Drawing.Point(3, 517);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1122, 185);
            this.panelControl2.TabIndex = 54;
            this.panelControl2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControl2_MouseDown);
            // 
            // txtSubTotalLps
            // 
            this.txtSubTotalLps.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSubTotalLps.EditValue = "0.00";
            this.txtSubTotalLps.Location = new System.Drawing.Point(800, 10);
            this.txtSubTotalLps.Name = "txtSubTotalLps";
            this.txtSubTotalLps.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotalLps.Properties.Appearance.Options.UseFont = true;
            this.txtSubTotalLps.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSubTotalLps.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtSubTotalLps.Properties.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.txtSubTotalLps.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSubTotalLps.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtSubTotalLps.Properties.MaskSettings.Set("mask", "c");
            this.txtSubTotalLps.Properties.NullText = "0.00";
            this.txtSubTotalLps.Size = new System.Drawing.Size(130, 24);
            this.txtSubTotalLps.TabIndex = 86;
            // 
            // txtComentarios
            // 
            this.txtComentarios.Location = new System.Drawing.Point(154, 63);
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtComentarios.Properties.Appearance.Options.UseFont = true;
            this.txtComentarios.Size = new System.Drawing.Size(408, 96);
            this.txtComentarios.TabIndex = 85;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTotal.EditValue = "0.00";
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(800, 69);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtTotal.Properties.Appearance.Options.UseFont = true;
            this.txtTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTotal.Properties.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.txtTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotal.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtTotal.Properties.MaskSettings.Set("mask", "c");
            this.txtTotal.Properties.NullText = "0.00";
            this.txtTotal.Properties.NullValuePrompt = "0.00";
            this.txtTotal.Size = new System.Drawing.Size(130, 24);
            this.txtTotal.TabIndex = 81;
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtImpuesto.EditValue = "0.00";
            this.txtImpuesto.Enabled = false;
            this.txtImpuesto.Location = new System.Drawing.Point(800, 40);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtImpuesto.Properties.Appearance.Options.UseFont = true;
            this.txtImpuesto.Properties.Appearance.Options.UseTextOptions = true;
            this.txtImpuesto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtImpuesto.Properties.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.txtImpuesto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtImpuesto.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtImpuesto.Properties.MaskSettings.Set("mask", "c");
            this.txtImpuesto.Properties.NullText = "0.00";
            this.txtImpuesto.Size = new System.Drawing.Size(130, 24);
            this.txtImpuesto.TabIndex = 80;
            // 
            // btnShowPopu
            // 
            this.btnShowPopu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnShowPopu.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPopu.Appearance.Options.UseFont = true;
            this.btnShowPopu.Enabled = false;
            this.btnShowPopu.Location = new System.Drawing.Point(698, 130);
            this.btnShowPopu.Name = "btnShowPopu";
            this.btnShowPopu.Size = new System.Drawing.Size(232, 29);
            this.btnShowPopu.TabIndex = 78;
            this.btnShowPopu.Text = "Copiar de Orden de Compra";
            this.btnShowPopu.ToolTip = "Seleccione un Proveedor para Copia de una Orden de Compra";
            this.btnShowPopu.Click += new System.EventHandler(this.btnShowPopu_Click);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(5, 64);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(165, 18);
            this.labelControl11.TabIndex = 77;
            this.labelControl11.Text = "Comentarios_______";
            // 
            // labelControl10
            // 
            this.labelControl10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(698, 16);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(137, 18);
            this.labelControl10.TabIndex = 84;
            this.labelControl10.Text = "SubTotal_______";
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(698, 74);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(189, 18);
            this.labelControl8.TabIndex = 82;
            this.labelControl8.Text = "Total_______________";
            // 
            // labelControl9
            // 
            this.labelControl9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(698, 46);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(141, 18);
            this.labelControl9.TabIndex = 83;
            this.labelControl9.Text = "Impuesto_______";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barbtnCancelOrden});
            this.barManager1.MaxItemId = 1;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1129, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 691);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1129, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 671);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1129, 20);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 671);
            // 
            // barbtnCancelOrden
            // 
            this.barbtnCancelOrden.Caption = "Cancelar";
            this.barbtnCancelOrden.Id = 0;
            this.barbtnCancelOrden.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnCancelOrden.ImageOptions.Image")));
            this.barbtnCancelOrden.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtnCancelOrden.ImageOptions.LargeImage")));
            this.barbtnCancelOrden.Name = "barbtnCancelOrden";
            this.barbtnCancelOrden.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnCancelOrden_ItemClick);
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barbtnCancelOrden)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // frmFacturasProveedoresMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 711);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.grDetalle);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmFacturasProveedoresMain.IconOptions.Image")));
            this.Name = "frmFacturasProveedoresMain";
            this.Text = "Facturas Proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSucursales.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompras1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumFactura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCAI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonaContact.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodProv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonDeleteRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonGridEstadoEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGrdItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotalLps.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComentarios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImpuesto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.ButtonEdit txtCodProv;
        private DevExpress.XtraEditors.TextEdit txtProveedor;
        private DevExpress.XtraEditors.SimpleButton cmdAddDetalle;
        private System.Windows.Forms.DateTimePicker dtFechaVencimiento;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.DateTimePicker dtFechaContabilizacion;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox txtEstado;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtUsuarioCreador;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtDocNum;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton cmdClose;
        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
        private DevExpress.XtraEditors.SimpleButton cmdNuevo;
        private DevExpress.XtraEditors.SimpleButton cmdBuscar;
        private DevExpress.XtraEditors.SimpleButton cmdSiguiente;
        private DevExpress.XtraEditors.SimpleButton cmdAnterior;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraGrid.GridControl grDetalle;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDscription;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal;
        private DevExpress.XtraGrid.Columns.GridColumn coldelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ButtonDeleteRow;
        private DevExpress.XtraGrid.Columns.GridColumn colid_status;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ButtonGridEstadoEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGrdItem;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.MemoEdit txtComentarios;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private DevExpress.XtraEditors.TextEdit txtImpuesto;
        private DevExpress.XtraEditors.SimpleButton btnShowPopu;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.DateTimePicker dtFechaDocumento;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.TextEdit txtNumFactura;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.TextEdit txtCAI;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit txtPersonaContact;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private dsCompras dsCompras1;
        private DevExpress.XtraEditors.GridLookUpEdit grdSucursales;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colpdv;
        private DevExpress.XtraEditors.LabelControl lblSucursal;
        private System.Windows.Forms.BindingSource sucursalesBindingSource;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barbtnCancelOrden;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraEditors.TextEdit txtSubTotalLps;
    }
}