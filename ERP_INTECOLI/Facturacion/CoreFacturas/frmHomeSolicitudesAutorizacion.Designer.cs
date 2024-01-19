
namespace JAGUAR_APP.Facturacion.CoreFacturas
{
    partial class frmHomeSolicitudesAutorizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomeSolicitudesAutorizacion));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsFacturasGestion = new JAGUAR_APP.Facturacion.CoreFacturas.dsFacturasGestion();
            this.grd_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfactura_id_H = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero_documento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_tipoAutorizacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo_autorizacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_pdv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpunto_venta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario_autoriza_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario_autoriza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coljustificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcreated_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_usuario_solicita = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario_solicita = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnGestionar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tsFiltro = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.cmdRefresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturasGestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGestionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsFiltro.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "SolicitudAutorizacion";
            this.gridControl1.DataSource = this.dsFacturasGestion;
            this.gridControl1.Location = new System.Drawing.Point(-2, 84);
            this.gridControl1.MainView = this.grd_data;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnGestionar});
            this.gridControl1.Size = new System.Drawing.Size(1130, 428);
            this.gridControl1.TabIndex = 0;
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
            this.grd_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colfactura_id_H,
            this.colnumero_documento,
            this.colid_tipoAutorizacion,
            this.coltipo_autorizacion,
            this.colid_pdv,
            this.colpunto_venta,
            this.colusuario_autoriza_id,
            this.colusuario_autoriza,
            this.coljustificacion,
            this.colcreated_date,
            this.colid_usuario_solicita,
            this.colusuario_solicita,
            this.colestado_id,
            this.colestado,
            this.gridColumn1,
            this.gridColumn2});
            this.grd_data.GridControl = this.gridControl1;
            this.grd_data.Name = "grd_data";
            this.grd_data.OptionsView.ShowAutoFilterRow = true;
            this.grd_data.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colfactura_id_H
            // 
            this.colfactura_id_H.FieldName = "factura_id_H";
            this.colfactura_id_H.Name = "colfactura_id_H";
            // 
            // colnumero_documento
            // 
            this.colnumero_documento.Caption = "# Factura";
            this.colnumero_documento.FieldName = "numero_documento";
            this.colnumero_documento.Name = "colnumero_documento";
            this.colnumero_documento.OptionsColumn.ReadOnly = true;
            this.colnumero_documento.OptionsFilter.AllowFilter = false;
            this.colnumero_documento.Visible = true;
            this.colnumero_documento.VisibleIndex = 2;
            this.colnumero_documento.Width = 113;
            // 
            // colid_tipoAutorizacion
            // 
            this.colid_tipoAutorizacion.FieldName = "id_tipoAutorizacion";
            this.colid_tipoAutorizacion.Name = "colid_tipoAutorizacion";
            // 
            // coltipo_autorizacion
            // 
            this.coltipo_autorizacion.Caption = "Tipo Autorización";
            this.coltipo_autorizacion.FieldName = "tipo_autorizacion";
            this.coltipo_autorizacion.Name = "coltipo_autorizacion";
            this.coltipo_autorizacion.OptionsColumn.ReadOnly = true;
            this.coltipo_autorizacion.OptionsFilter.AllowFilter = false;
            this.coltipo_autorizacion.Visible = true;
            this.coltipo_autorizacion.VisibleIndex = 3;
            this.coltipo_autorizacion.Width = 142;
            // 
            // colid_pdv
            // 
            this.colid_pdv.FieldName = "id_pdv";
            this.colid_pdv.Name = "colid_pdv";
            this.colid_pdv.Width = 72;
            // 
            // colpunto_venta
            // 
            this.colpunto_venta.Caption = "Punto de Venta";
            this.colpunto_venta.FieldName = "punto_venta";
            this.colpunto_venta.Name = "colpunto_venta";
            this.colpunto_venta.OptionsColumn.ReadOnly = true;
            this.colpunto_venta.OptionsFilter.AllowFilter = false;
            this.colpunto_venta.Visible = true;
            this.colpunto_venta.VisibleIndex = 4;
            this.colpunto_venta.Width = 139;
            // 
            // colusuario_autoriza_id
            // 
            this.colusuario_autoriza_id.FieldName = "usuario_autoriza_id";
            this.colusuario_autoriza_id.Name = "colusuario_autoriza_id";
            this.colusuario_autoriza_id.Width = 73;
            // 
            // colusuario_autoriza
            // 
            this.colusuario_autoriza.Caption = "Responsable";
            this.colusuario_autoriza.FieldName = "usuario_autoriza";
            this.colusuario_autoriza.Name = "colusuario_autoriza";
            this.colusuario_autoriza.OptionsColumn.ReadOnly = true;
            this.colusuario_autoriza.OptionsFilter.AllowFilter = false;
            this.colusuario_autoriza.Visible = true;
            this.colusuario_autoriza.VisibleIndex = 6;
            this.colusuario_autoriza.Width = 137;
            // 
            // coljustificacion
            // 
            this.coljustificacion.Caption = "Justificación";
            this.coljustificacion.FieldName = "justificacion";
            this.coljustificacion.Name = "coljustificacion";
            this.coljustificacion.OptionsColumn.ReadOnly = true;
            this.coljustificacion.OptionsFilter.AllowFilter = false;
            this.coljustificacion.Visible = true;
            this.coljustificacion.VisibleIndex = 7;
            this.coljustificacion.Width = 129;
            // 
            // colcreated_date
            // 
            this.colcreated_date.Caption = "Fecha Creación";
            this.colcreated_date.FieldName = "created_date";
            this.colcreated_date.Name = "colcreated_date";
            this.colcreated_date.OptionsColumn.ReadOnly = true;
            this.colcreated_date.OptionsFilter.AllowFilter = false;
            this.colcreated_date.Visible = true;
            this.colcreated_date.VisibleIndex = 0;
            this.colcreated_date.Width = 84;
            // 
            // colid_usuario_solicita
            // 
            this.colid_usuario_solicita.FieldName = "id_usuario_solicita";
            this.colid_usuario_solicita.Name = "colid_usuario_solicita";
            this.colid_usuario_solicita.Width = 57;
            // 
            // colusuario_solicita
            // 
            this.colusuario_solicita.Caption = "Usuario Solicita";
            this.colusuario_solicita.FieldName = "usuario_solicita";
            this.colusuario_solicita.Name = "colusuario_solicita";
            this.colusuario_solicita.OptionsColumn.ReadOnly = true;
            this.colusuario_solicita.OptionsFilter.AllowFilter = false;
            this.colusuario_solicita.Visible = true;
            this.colusuario_solicita.VisibleIndex = 5;
            this.colusuario_solicita.Width = 91;
            // 
            // colestado_id
            // 
            this.colestado_id.FieldName = "estado_id";
            this.colestado_id.Name = "colestado_id";
            this.colestado_id.Width = 57;
            // 
            // colestado
            // 
            this.colestado.Caption = "Estado";
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            this.colestado.OptionsColumn.ReadOnly = true;
            this.colestado.OptionsFilter.AllowFilter = false;
            this.colestado.Visible = true;
            this.colestado.VisibleIndex = 8;
            this.colestado.Width = 81;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Gestionar";
            this.gridColumn1.ColumnEdit = this.btnGestionar;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsFilter.AllowFilter = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 9;
            this.gridColumn1.Width = 82;
            // 
            // btnGestionar
            // 
            this.btnGestionar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnGestionar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnGestionar.Name = "btnGestionar";
            this.btnGestionar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnGestionar.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnGestionar_ButtonPressed);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "# Solicitud";
            this.gridColumn2.FieldName = "barcode";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.OptionsFilter.AllowFilter = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 107;
            // 
            // tsFiltro
            // 
            this.tsFiltro.Location = new System.Drawing.Point(107, 39);
            this.tsFiltro.Name = "tsFiltro";
            this.tsFiltro.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsFiltro.Properties.Appearance.Options.UseFont = true;
            this.tsFiltro.Properties.OffText = "No";
            this.tsFiltro.Properties.OnText = "Si";
            this.tsFiltro.Size = new System.Drawing.Size(107, 22);
            this.tsFiltro.TabIndex = 1;
            this.tsFiltro.Toggled += new System.EventHandler(this.tsFiltro_Toggled);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(14, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(87, 17);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Mostrar Todas";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(-2, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(1130, 21);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Solicitudes de Autorizaciones";
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(969, 17);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(118, 44);
            this.btnAtras.TabIndex = 51;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRefresh.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdRefresh.Appearance.Options.UseFont = true;
            this.cmdRefresh.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdRefresh.ImageOptions.Image")));
            this.cmdRefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdRefresh.Location = new System.Drawing.Point(822, 17);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(118, 44);
            this.cmdRefresh.TabIndex = 52;
            this.cmdRefresh.Text = "Refresh";
            this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
            // 
            // frmHomeSolicitudesAutorizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 510);
            this.Controls.Add(this.cmdRefresh);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.tsFiltro);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmHomeSolicitudesAutorizacion";
            this.Text = "Solicitudes de Aurizaciones";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturasGestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGestionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsFiltro.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView grd_data;
        private DevExpress.XtraEditors.ToggleSwitch tsFiltro;
        private dsFacturasGestion dsFacturasGestion;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colfactura_id_H;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_documento;
        private DevExpress.XtraGrid.Columns.GridColumn colid_tipoAutorizacion;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo_autorizacion;
        private DevExpress.XtraGrid.Columns.GridColumn colid_pdv;
        private DevExpress.XtraGrid.Columns.GridColumn colpunto_venta;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario_autoriza_id;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario_autoriza;
        private DevExpress.XtraGrid.Columns.GridColumn coljustificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colcreated_date;
        private DevExpress.XtraGrid.Columns.GridColumn colid_usuario_solicita;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario_solicita;
        private DevExpress.XtraGrid.Columns.GridColumn colestado_id;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnGestionar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.SimpleButton cmdRefresh;
    }
}