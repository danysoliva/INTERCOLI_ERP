
namespace JAGUAR_APP.Facturacion.CoreFacturas
{
    partial class frmNavigationPageAutorizacion
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNavigationPageAutorizacion));
            this.navigationFrame1 = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.npGestionSolicitud = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsFacturasGestion = new JAGUAR_APP.Facturacion.CoreFacturas.dsFacturasGestion();
            this.grd_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAutorizar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.npGestionSolicitudConfirmation = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.cdmCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.cdmConfirmar = new DevExpress.XtraEditors.SimpleButton();
            this.txtJustificacion = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.npNC_ND = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.cmdNext = new DevExpress.XtraEditors.SimpleButton();
            this.gcFactura = new DevExpress.XtraGrid.GridControl();
            this.gv_facturas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero_factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmonto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).BeginInit();
            this.navigationFrame1.SuspendLayout();
            this.npGestionSolicitud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturasGestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAutorizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.npGestionSolicitudConfirmation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtJustificacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            this.npNC_ND.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_facturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationFrame1
            // 
            this.navigationFrame1.Controls.Add(this.npGestionSolicitud);
            this.navigationFrame1.Controls.Add(this.npGestionSolicitudConfirmation);
            this.navigationFrame1.Controls.Add(this.npNC_ND);
            this.navigationFrame1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame1.Location = new System.Drawing.Point(0, 0);
            this.navigationFrame1.Name = "navigationFrame1";
            this.navigationFrame1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.npGestionSolicitud,
            this.npGestionSolicitudConfirmation,
            this.npNC_ND});
            this.navigationFrame1.SelectedPage = this.npGestionSolicitud;
            this.navigationFrame1.Size = new System.Drawing.Size(516, 294);
            this.navigationFrame1.TabIndex = 0;
            this.navigationFrame1.Text = "navigationFrame1";
            // 
            // npGestionSolicitud
            // 
            this.npGestionSolicitud.Controls.Add(this.gridControl1);
            this.npGestionSolicitud.Controls.Add(this.labelControl1);
            this.npGestionSolicitud.Controls.Add(this.pictureEdit1);
            this.npGestionSolicitud.Name = "npGestionSolicitud";
            this.npGestionSolicitud.Size = new System.Drawing.Size(516, 294);
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "TipoAutorizacion";
            this.gridControl1.DataSource = this.dsFacturasGestion;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 62);
            this.gridControl1.MainView = this.grd_data;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnAutorizar});
            this.gridControl1.Size = new System.Drawing.Size(516, 232);
            this.gridControl1.TabIndex = 5;
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
            this.grd_data.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grd_data.Appearance.HeaderPanel.Options.UseFont = true;
            this.grd_data.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grd_data.Appearance.Row.Options.UseFont = true;
            this.grd_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldescripcion,
            this.gridColumn1});
            this.grd_data.GridControl = this.gridControl1;
            this.grd_data.Name = "grd_data";
            this.grd_data.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Tipo Autorización";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.AllowMove = false;
            this.coldescripcion.OptionsColumn.ReadOnly = true;
            this.coldescripcion.OptionsFilter.AllowFilter = false;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            this.coldescripcion.Width = 367;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Autorizar";
            this.gridColumn1.ColumnEdit = this.btnAutorizar;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowMove = false;
            this.gridColumn1.OptionsFilter.AllowFilter = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // btnAutorizar
            // 
            this.btnAutorizar.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnAutorizar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnAutorizar.Name = "btnAutorizar";
            this.btnAutorizar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnAutorizar.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnAutorizar_ButtonPressed);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(80, 5);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(375, 49);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Seleccione el tipo de Autorización que desea solicitar";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(12, 5);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(62, 52);
            this.pictureEdit1.TabIndex = 3;
            // 
            // npGestionSolicitudConfirmation
            // 
            this.npGestionSolicitudConfirmation.Controls.Add(this.cdmCancelar);
            this.npGestionSolicitudConfirmation.Controls.Add(this.cdmConfirmar);
            this.npGestionSolicitudConfirmation.Controls.Add(this.txtJustificacion);
            this.npGestionSolicitudConfirmation.Controls.Add(this.labelControl2);
            this.npGestionSolicitudConfirmation.Controls.Add(this.pictureEdit2);
            this.npGestionSolicitudConfirmation.Name = "npGestionSolicitudConfirmation";
            this.npGestionSolicitudConfirmation.Size = new System.Drawing.Size(516, 294);
            // 
            // cdmCancelar
            // 
            this.cdmCancelar.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdmCancelar.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cdmCancelar.Appearance.Options.UseFont = true;
            this.cdmCancelar.Appearance.Options.UseForeColor = true;
            this.cdmCancelar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cdmCancelar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cdmCancelar.ImageOptions.SvgImage")));
            this.cdmCancelar.Location = new System.Drawing.Point(394, 135);
            this.cdmCancelar.Name = "cdmCancelar";
            this.cdmCancelar.Size = new System.Drawing.Size(110, 47);
            this.cdmCancelar.TabIndex = 9;
            this.cdmCancelar.Text = "Cancelar";
            this.cdmCancelar.Click += new System.EventHandler(this.cdmCancelar_Click);
            // 
            // cdmConfirmar
            // 
            this.cdmConfirmar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(130)))), ((int)(((byte)(195)))));
            this.cdmConfirmar.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdmConfirmar.Appearance.ForeColor = System.Drawing.Color.White;
            this.cdmConfirmar.Appearance.Options.UseBackColor = true;
            this.cdmConfirmar.Appearance.Options.UseFont = true;
            this.cdmConfirmar.Appearance.Options.UseForeColor = true;
            this.cdmConfirmar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cdmConfirmar.Location = new System.Drawing.Point(394, 82);
            this.cdmConfirmar.Name = "cdmConfirmar";
            this.cdmConfirmar.Size = new System.Drawing.Size(110, 47);
            this.cdmConfirmar.TabIndex = 8;
            this.cdmConfirmar.Text = "Confirmar";
            this.cdmConfirmar.Click += new System.EventHandler(this.cdmConfirmar_Click);
            // 
            // txtJustificacion
            // 
            this.txtJustificacion.Location = new System.Drawing.Point(11, 81);
            this.txtJustificacion.Name = "txtJustificacion";
            this.txtJustificacion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJustificacion.Properties.Appearance.Options.UseFont = true;
            this.txtJustificacion.Properties.MaxLength = 200;
            this.txtJustificacion.Size = new System.Drawing.Size(377, 201);
            this.txtJustificacion.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(79, 31);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(274, 20);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Ingrese una Justificación de esta Solicitud";
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(11, 12);
            this.pictureEdit2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit2.Size = new System.Drawing.Size(62, 52);
            this.pictureEdit2.TabIndex = 5;
            // 
            // npNC_ND
            // 
            this.npNC_ND.Caption = "npNC_ND";
            this.npNC_ND.Controls.Add(this.labelControl3);
            this.npNC_ND.Controls.Add(this.toggleSwitch1);
            this.npNC_ND.Controls.Add(this.btnAtras);
            this.npNC_ND.Controls.Add(this.cmdNext);
            this.npNC_ND.Controls.Add(this.gcFactura);
            this.npNC_ND.Name = "npNC_ND";
            this.npNC_ND.Size = new System.Drawing.Size(516, 294);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(22, 51);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(250, 20);
            this.labelControl3.TabIndex = 52;
            this.labelControl3.Text = "Puede cambiar los montos de la Nota";
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toggleSwitch1.EditValue = true;
            this.toggleSwitch1.Location = new System.Drawing.Point(22, 12);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleSwitch1.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitch1.Properties.OffText = "Débito";
            this.toggleSwitch1.Properties.OnText = "Crédito";
            this.toggleSwitch1.Size = new System.Drawing.Size(112, 20);
            this.toggleSwitch1.TabIndex = 51;
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(278, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(116, 47);
            this.btnAtras.TabIndex = 50;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // cmdNext
            // 
            this.cmdNext.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.cmdNext.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNext.Appearance.ForeColor = System.Drawing.Color.White;
            this.cmdNext.Appearance.Options.UseBackColor = true;
            this.cmdNext.Appearance.Options.UseFont = true;
            this.cmdNext.Appearance.Options.UseForeColor = true;
            this.cmdNext.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cmdNext.Location = new System.Drawing.Point(400, 12);
            this.cmdNext.Name = "cmdNext";
            this.cmdNext.Size = new System.Drawing.Size(113, 47);
            this.cmdNext.TabIndex = 9;
            this.cmdNext.Text = "Siguiente";
            this.cmdNext.Click += new System.EventHandler(this.cmdNext_Click);
            // 
            // gcFactura
            // 
            this.gcFactura.DataMember = "facturas_solicitud_NC_ND";
            this.gcFactura.DataSource = this.dsFacturasGestion;
            this.gcFactura.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcFactura.Location = new System.Drawing.Point(0, 77);
            this.gcFactura.MainView = this.gv_facturas;
            this.gcFactura.Name = "gcFactura";
            this.gcFactura.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.gcFactura.Size = new System.Drawing.Size(516, 217);
            this.gcFactura.TabIndex = 6;
            this.gcFactura.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_facturas});
            // 
            // gv_facturas
            // 
            this.gv_facturas.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gv_facturas.Appearance.HeaderPanel.Options.UseFont = true;
            this.gv_facturas.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gv_facturas.Appearance.Row.Options.UseFont = true;
            this.gv_facturas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_factura,
            this.colnumero_factura,
            this.colmonto,
            this.gridColumn2});
            this.gv_facturas.GridControl = this.gcFactura;
            this.gv_facturas.Name = "gv_facturas";
            this.gv_facturas.OptionsView.ShowGroupPanel = false;
            // 
            // colid_factura
            // 
            this.colid_factura.FieldName = "id_factura";
            this.colid_factura.Name = "colid_factura";
            this.colid_factura.Width = 96;
            // 
            // colnumero_factura
            // 
            this.colnumero_factura.Caption = "Numero Factura";
            this.colnumero_factura.FieldName = "numero_factura";
            this.colnumero_factura.Name = "colnumero_factura";
            this.colnumero_factura.OptionsColumn.ReadOnly = true;
            this.colnumero_factura.OptionsFilter.AllowFilter = false;
            this.colnumero_factura.Visible = true;
            this.colnumero_factura.VisibleIndex = 1;
            this.colnumero_factura.Width = 243;
            // 
            // colmonto
            // 
            this.colmonto.Caption = "Monto";
            this.colmonto.DisplayFormat.FormatString = "L {0:N}";
            this.colmonto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colmonto.FieldName = "monto";
            this.colmonto.Name = "colmonto";
            this.colmonto.OptionsFilter.AllowFilter = false;
            this.colmonto.Visible = true;
            this.colmonto.VisibleIndex = 2;
            this.colmonto.Width = 100;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Punto Venta";
            this.gridColumn2.FieldName = "pdv";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.OptionsFilter.AllowFilter = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 148;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // frmNavigationPageAutorizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 294);
            this.Controls.Add(this.navigationFrame1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNavigationPageAutorizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autorización";
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).EndInit();
            this.navigationFrame1.ResumeLayout(false);
            this.npGestionSolicitud.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturasGestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAutorizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.npGestionSolicitudConfirmation.ResumeLayout(false);
            this.npGestionSolicitudConfirmation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtJustificacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            this.npNC_ND.ResumeLayout(false);
            this.npNC_ND.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_facturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame1;
        private DevExpress.XtraBars.Navigation.NavigationPage npGestionSolicitud;
        private DevExpress.XtraBars.Navigation.NavigationPage npGestionSolicitudConfirmation;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView grd_data;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnAutorizar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private dsFacturasGestion dsFacturasGestion;
        private DevExpress.XtraEditors.SimpleButton cdmCancelar;
        private DevExpress.XtraEditors.SimpleButton cdmConfirmar;
        private DevExpress.XtraEditors.MemoEdit txtJustificacion;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraBars.Navigation.NavigationPage npNC_ND;
        private DevExpress.XtraGrid.GridControl gcFactura;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_facturas;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_factura;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_factura;
        private DevExpress.XtraGrid.Columns.GridColumn colmonto;
        private DevExpress.XtraEditors.SimpleButton cmdNext;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}