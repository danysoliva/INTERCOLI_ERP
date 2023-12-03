
namespace ERP_INTECOLI.Compras
{
    partial class frmSolicitudesMain
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSolicitudesMain));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions4 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject13 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject14 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject15 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject16 = new DevExpress.Utils.SerializableAppearanceObject();
            this.grDetalle = new DevExpress.XtraGrid.GridControl();
            this.dsCompras1 = new ERP_INTECOLI.Compras.dsCompras();
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmdAddDetalle = new DevExpress.XtraEditors.SimpleButton();
            this.dtFechaContabilizacion = new System.Windows.Forms.DateTimePicker();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dtFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtUsuarioCreador = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtId = new System.Windows.Forms.TextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cmdClose = new DevExpress.XtraEditors.SimpleButton();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.cmdBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdSiguiente = new DevExpress.XtraEditors.SimpleButton();
            this.cmdAnterior = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnEditar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompras1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonDeleteRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonGridEstadoEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGrdItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // grDetalle
            // 
            this.grDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grDetalle.DataMember = "solicitud_compras_detalle";
            this.grDetalle.DataSource = this.dsCompras1;
            this.grDetalle.Location = new System.Drawing.Point(2, 178);
            this.grDetalle.MainView = this.grdvDetalle;
            this.grDetalle.Name = "grDetalle";
            this.grDetalle.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ButtonDeleteRow,
            this.ButtonGridEstadoEdit,
            this.repositoryItemGrdItem});
            this.grDetalle.Size = new System.Drawing.Size(1122, 351);
            this.grDetalle.TabIndex = 49;
            this.grDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvDetalle});
            this.grDetalle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grDetalle_MouseDown);
            // 
            // dsCompras1
            // 
            this.dsCompras1.DataSetName = "dsCompras";
            this.dsCompras1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.grdvDetalle.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
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
            this.colDscription.OptionsColumn.ReadOnly = true;
            this.colDscription.Visible = true;
            this.colDscription.VisibleIndex = 1;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Cantidad";
            this.colQuantity.FieldName = "cantidad";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 2;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Precio";
            this.colPrice.FieldName = "precio";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 3;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // coltotal
            // 
            this.coltotal.Caption = "Total";
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
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.ButtonDeleteRow.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.ButtonDeleteRow.Name = "ButtonDeleteRow";
            this.ButtonDeleteRow.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.ButtonDeleteRow.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ButtonDeleteRow_ButtonClick);
            // 
            // colid_status
            // 
            this.colid_status.FieldName = "id_estado";
            this.colid_status.Name = "colid_status";
            // 
            // ButtonGridEstadoEdit
            // 
            this.ButtonGridEstadoEdit.AutoHeight = false;
            editorButtonImageOptions4.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions4.Image")));
            editorButtonImageOptions4.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonGridEstadoEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions4, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject13, serializableAppearanceObject14, serializableAppearanceObject15, serializableAppearanceObject16, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
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
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.btnEditar);
            this.panelControl1.Controls.Add(this.cmdAddDetalle);
            this.panelControl1.Controls.Add(this.dtFechaContabilizacion);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.dtFechaRegistro);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.txtEstado);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.txtUsuarioCreador);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txtId);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.cmdClose);
            this.panelControl1.Controls.Add(this.cmdGuardar);
            this.panelControl1.Controls.Add(this.cmdNuevo);
            this.panelControl1.Controls.Add(this.cmdBuscar);
            this.panelControl1.Controls.Add(this.cmdSiguiente);
            this.panelControl1.Controls.Add(this.cmdAnterior);
            this.panelControl1.Location = new System.Drawing.Point(2, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1122, 172);
            this.panelControl1.TabIndex = 50;
            this.panelControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControl1_MouseDown);
            // 
            // cmdAddDetalle
            // 
            this.cmdAddDetalle.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdAddDetalle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdAddDetalle.ImageOptions.SvgImage")));
            this.cmdAddDetalle.Location = new System.Drawing.Point(5, 134);
            this.cmdAddDetalle.Name = "cmdAddDetalle";
            this.cmdAddDetalle.Size = new System.Drawing.Size(47, 33);
            this.cmdAddDetalle.TabIndex = 66;
            this.cmdAddDetalle.Tag = "Agregar Item o Servicio";
            this.cmdAddDetalle.ToolTip = "Guardar";
            this.cmdAddDetalle.Click += new System.EventHandler(this.cmdAddDetalle_Click);
            // 
            // dtFechaContabilizacion
            // 
            this.dtFechaContabilizacion.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.dtFechaContabilizacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaContabilizacion.Location = new System.Drawing.Point(800, 80);
            this.dtFechaContabilizacion.Name = "dtFechaContabilizacion";
            this.dtFechaContabilizacion.Size = new System.Drawing.Size(175, 26);
            this.dtFechaContabilizacion.TabIndex = 65;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(612, 88);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(274, 18);
            this.labelControl4.TabIndex = 64;
            this.labelControl4.Text = "Fecha Contabilizacion___________";
            // 
            // dtFechaRegistro
            // 
            this.dtFechaRegistro.Enabled = false;
            this.dtFechaRegistro.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.dtFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaRegistro.Location = new System.Drawing.Point(800, 51);
            this.dtFechaRegistro.Name = "dtFechaRegistro";
            this.dtFechaRegistro.Size = new System.Drawing.Size(175, 26);
            this.dtFechaRegistro.TabIndex = 63;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(612, 60);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(223, 18);
            this.labelControl3.TabIndex = 62;
            this.labelControl3.Text = "Fecha Registro___________";
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.Color.White;
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEstado.Enabled = false;
            this.txtEstado.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtEstado.Location = new System.Drawing.Point(138, 109);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(206, 19);
            this.txtEstado.TabIndex = 61;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(32, 109);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(161, 18);
            this.labelControl2.TabIndex = 60;
            this.labelControl2.Text = "Estado___________";
            // 
            // txtUsuarioCreador
            // 
            this.txtUsuarioCreador.BackColor = System.Drawing.Color.White;
            this.txtUsuarioCreador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuarioCreador.Enabled = false;
            this.txtUsuarioCreador.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtUsuarioCreador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtUsuarioCreador.Location = new System.Drawing.Point(138, 84);
            this.txtUsuarioCreador.Name = "txtUsuarioCreador";
            this.txtUsuarioCreador.Size = new System.Drawing.Size(206, 19);
            this.txtUsuarioCreador.TabIndex = 59;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(32, 86);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(169, 18);
            this.labelControl1.TabIndex = 58;
            this.labelControl1.Text = "Usuario___________";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.White;
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtId.Location = new System.Drawing.Point(137, 58);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(206, 19);
            this.txtId.TabIndex = 57;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(32, 60);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(177, 18);
            this.labelControl7.TabIndex = 56;
            this.labelControl7.Text = "Num Doc___________";
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
            // cmdGuardar
            // 
            this.cmdGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.ImageOptions.Image")));
            this.cmdGuardar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdGuardar.Location = new System.Drawing.Point(222, 12);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(47, 33);
            this.cmdGuardar.TabIndex = 51;
            this.cmdGuardar.ToolTip = "Guardar";
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdNuevo.ImageOptions.Image")));
            this.cmdNuevo.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdNuevo.Location = new System.Drawing.Point(169, 12);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(47, 33);
            this.cmdNuevo.TabIndex = 50;
            this.cmdNuevo.ToolTip = "Nuevo";
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdBuscar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdBuscar.ImageOptions.SvgImage")));
            this.cmdBuscar.Location = new System.Drawing.Point(116, 12);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(47, 33);
            this.cmdBuscar.TabIndex = 49;
            this.cmdBuscar.ToolTip = "Buscar";
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // cmdSiguiente
            // 
            this.cmdSiguiente.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdSiguiente.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdSiguiente.ImageOptions.SvgImage")));
            this.cmdSiguiente.Location = new System.Drawing.Point(63, 12);
            this.cmdSiguiente.Name = "cmdSiguiente";
            this.cmdSiguiente.Size = new System.Drawing.Size(47, 33);
            this.cmdSiguiente.TabIndex = 48;
            this.cmdSiguiente.ToolTip = "Siguiente";
            this.cmdSiguiente.Click += new System.EventHandler(this.cmdSiguiente_Click);
            // 
            // cmdAnterior
            // 
            this.cmdAnterior.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdAnterior.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdAnterior.ImageOptions.SvgImage")));
            this.cmdAnterior.Location = new System.Drawing.Point(10, 12);
            this.cmdAnterior.Name = "cmdAnterior";
            this.cmdAnterior.Size = new System.Drawing.Size(47, 33);
            this.cmdAnterior.TabIndex = 47;
            this.cmdAnterior.ToolTip = "Anterior";
            this.cmdAnterior.Click += new System.EventHandler(this.cmdAnterior_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.txtComentarios);
            this.panelControl2.Controls.Add(this.labelControl11);
            this.panelControl2.Location = new System.Drawing.Point(2, 535);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1122, 126);
            this.panelControl2.TabIndex = 51;
            this.panelControl2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControl2_MouseDown);
            // 
            // txtComentarios
            // 
            this.txtComentarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComentarios.BackColor = System.Drawing.Color.White;
            this.txtComentarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComentarios.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtComentarios.ForeColor = System.Drawing.Color.Black;
            this.txtComentarios.Location = new System.Drawing.Point(132, 17);
            this.txtComentarios.Multiline = true;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(525, 88);
            this.txtComentarios.TabIndex = 76;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(5, 17);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(165, 18);
            this.labelControl11.TabIndex = 77;
            this.labelControl11.Text = "Comentarios_______";
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonCancelar)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // barButtonCancelar
            // 
            this.barButtonCancelar.Caption = "Cancelar";
            this.barButtonCancelar.Id = 0;
            this.barButtonCancelar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonCancelar.ImageOptions.SvgImage")));
            this.barButtonCancelar.Name = "barButtonCancelar";
            this.barButtonCancelar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonCancelar_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonCancelar});
            this.barManager1.MaxItemId = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1129, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 664);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1129, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 664);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1129, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 664);
            // 
            // btnEditar
            // 
            this.btnEditar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnEditar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnEditar.Location = new System.Drawing.Point(275, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(47, 33);
            this.btnEditar.TabIndex = 67;
            this.btnEditar.ToolTip = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // frmSolicitudesMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 664);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.grDetalle);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = global::ERP_INTECOLI.Properties.Resources.solicitud_compra_x32;
            this.Name = "frmSolicitudesMain";
            this.Text = "Solicitudes de Compra";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmSolicitudesMain_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.grDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompras1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonDeleteRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonGridEstadoEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGrdItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ButtonGridEstadoEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colid_status;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
        private DevExpress.XtraEditors.SimpleButton cmdNuevo;
        private DevExpress.XtraEditors.SimpleButton cmdBuscar;
        private DevExpress.XtraEditors.SimpleButton cmdSiguiente;
        private DevExpress.XtraEditors.SimpleButton cmdAnterior;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.TextBox txtUsuarioCreador;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtId;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton cmdClose;
        private System.Windows.Forms.TextBox txtComentarios;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.DateTimePicker dtFechaContabilizacion;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.DateTimePicker dtFechaRegistro;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox txtEstado;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private dsCompras dsCompras1;
        private DevExpress.XtraEditors.SimpleButton cmdAddDetalle;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGrdItem;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem barButtonCancelar;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.SimpleButton btnEditar;
    }
}