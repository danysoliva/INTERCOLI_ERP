using ERP_INTECOLI.Facturacion.CoreFacturas;

namespace JAGUAR_APP.Facturacion.Reportes
{
    partial class frmCierreDiaHome
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions4 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCierreDiaHome));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject13 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject14 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject15 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject16 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions5 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject17 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject18 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject19 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject20 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions6 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject21 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject22 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject23 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject24 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsContabilidad1 = new dsContabilidad();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_punto_venta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpunto_venta_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_user_responsable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario_responsable_nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_user_validacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario_validacion_nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_row = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colver_detalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdVerDetalleCierre = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colimprimir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdImprimirCierres = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.coleditar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdEditarCierre = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.cmdAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdrefresh = new DevExpress.XtraEditors.SimpleButton();
            this.lblSeleccionarPuntoVenta = new System.Windows.Forms.Label();
            this.glePuntoVenta = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bsPuntosVenta = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContabilidad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVerDetalleCierre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdImprimirCierres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditarCierre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glePuntoVenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPuntosVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "cierre_dia_home";
            this.gridControl1.DataSource = this.dsContabilidad1;
            this.gridControl1.Location = new System.Drawing.Point(2, 60);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdEditarCierre,
            this.cmdImprimirCierres,
            this.cmdVerDetalleCierre});
            this.gridControl1.Size = new System.Drawing.Size(868, 444);
            this.gridControl1.TabIndex = 0;
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
            this.colid,
            this.colcodigo,
            this.colid_punto_venta,
            this.colpunto_venta_descripcion,
            this.colfecha,
            this.colenable,
            this.colid_estado,
            this.colestado_descripcion,
            this.colid_user_responsable,
            this.colusuario_responsable_nombre,
            this.colid_user_validacion,
            this.colusuario_validacion_nombre,
            this.colfecha_row,
            this.colver_detalle,
            this.colimprimir,
            this.coleditar});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colcodigo
            // 
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.OptionsColumn.ReadOnly = true;
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 0;
            // 
            // colid_punto_venta
            // 
            this.colid_punto_venta.FieldName = "id_punto_venta";
            this.colid_punto_venta.Name = "colid_punto_venta";
            // 
            // colpunto_venta_descripcion
            // 
            this.colpunto_venta_descripcion.FieldName = "punto_venta_descripcion";
            this.colpunto_venta_descripcion.Name = "colpunto_venta_descripcion";
            this.colpunto_venta_descripcion.OptionsColumn.ReadOnly = true;
            this.colpunto_venta_descripcion.Visible = true;
            this.colpunto_venta_descripcion.VisibleIndex = 1;
            // 
            // colfecha
            // 
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.ReadOnly = true;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 2;
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
            // colestado_descripcion
            // 
            this.colestado_descripcion.FieldName = "estado_descripcion";
            this.colestado_descripcion.Name = "colestado_descripcion";
            this.colestado_descripcion.OptionsColumn.ReadOnly = true;
            this.colestado_descripcion.Visible = true;
            this.colestado_descripcion.VisibleIndex = 3;
            // 
            // colid_user_responsable
            // 
            this.colid_user_responsable.FieldName = "id_user_responsable";
            this.colid_user_responsable.Name = "colid_user_responsable";
            // 
            // colusuario_responsable_nombre
            // 
            this.colusuario_responsable_nombre.FieldName = "usuario_responsable_nombre";
            this.colusuario_responsable_nombre.Name = "colusuario_responsable_nombre";
            this.colusuario_responsable_nombre.OptionsColumn.ReadOnly = true;
            this.colusuario_responsable_nombre.Visible = true;
            this.colusuario_responsable_nombre.VisibleIndex = 4;
            // 
            // colid_user_validacion
            // 
            this.colid_user_validacion.FieldName = "id_user_validacion";
            this.colid_user_validacion.Name = "colid_user_validacion";
            // 
            // colusuario_validacion_nombre
            // 
            this.colusuario_validacion_nombre.FieldName = "usuario_validacion_nombre";
            this.colusuario_validacion_nombre.Name = "colusuario_validacion_nombre";
            this.colusuario_validacion_nombre.OptionsColumn.ReadOnly = true;
            this.colusuario_validacion_nombre.Visible = true;
            this.colusuario_validacion_nombre.VisibleIndex = 5;
            // 
            // colfecha_row
            // 
            this.colfecha_row.FieldName = "fecha_row";
            this.colfecha_row.Name = "colfecha_row";
            // 
            // colver_detalle
            // 
            this.colver_detalle.ColumnEdit = this.cmdVerDetalleCierre;
            this.colver_detalle.FieldName = "ver_detalle";
            this.colver_detalle.Name = "colver_detalle";
            this.colver_detalle.Visible = true;
            this.colver_detalle.VisibleIndex = 6;
            // 
            // cmdVerDetalleCierre
            // 
            this.cmdVerDetalleCierre.AutoHeight = false;
            editorButtonImageOptions4.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions4.Image")));
            this.cmdVerDetalleCierre.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions4, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject13, serializableAppearanceObject14, serializableAppearanceObject15, serializableAppearanceObject16, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdVerDetalleCierre.Name = "cmdVerDetalleCierre";
            this.cmdVerDetalleCierre.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdVerDetalleCierre.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdVerDetalleCierre_ButtonClick);
            // 
            // colimprimir
            // 
            this.colimprimir.ColumnEdit = this.cmdImprimirCierres;
            this.colimprimir.FieldName = "imprimir";
            this.colimprimir.Name = "colimprimir";
            this.colimprimir.Visible = true;
            this.colimprimir.VisibleIndex = 7;
            // 
            // cmdImprimirCierres
            // 
            this.cmdImprimirCierres.AutoHeight = false;
            editorButtonImageOptions5.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions5.Image")));
            this.cmdImprimirCierres.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions5, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject17, serializableAppearanceObject18, serializableAppearanceObject19, serializableAppearanceObject20, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdImprimirCierres.Name = "cmdImprimirCierres";
            this.cmdImprimirCierres.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdImprimirCierres.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdImprimirCierres_ButtonClick);
            // 
            // coleditar
            // 
            this.coleditar.ColumnEdit = this.cmdEditarCierre;
            this.coleditar.FieldName = "editar";
            this.coleditar.Name = "coleditar";
            this.coleditar.Visible = true;
            this.coleditar.VisibleIndex = 8;
            // 
            // cmdEditarCierre
            // 
            this.cmdEditarCierre.AutoHeight = false;
            editorButtonImageOptions6.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions6.Image")));
            this.cmdEditarCierre.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions6, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject21, serializableAppearanceObject22, serializableAppearanceObject23, serializableAppearanceObject24, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdEditarCierre.Name = "cmdEditarCierre";
            this.cmdEditarCierre.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdEditarCierre.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdEditarCierre_ButtonClick);
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(754, 18);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(116, 36);
            this.btnAtras.TabIndex = 50;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.cmdAgregar.Appearance.Options.UseFont = true;
            this.cmdAgregar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdAgregar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdAgregar.ImageOptions.Image")));
            this.cmdAgregar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdAgregar.Location = new System.Drawing.Point(2, 18);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(116, 36);
            this.cmdAgregar.TabIndex = 51;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(346, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(126, 25);
            this.labelControl1.TabIndex = 52;
            this.labelControl1.Text = "Cierres diarios";
            // 
            // cmdrefresh
            // 
            this.cmdrefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdrefresh.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.cmdrefresh.Appearance.Options.UseFont = true;
            this.cmdrefresh.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdrefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdrefresh.ImageOptions.Image")));
            this.cmdrefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdrefresh.Location = new System.Drawing.Point(632, 18);
            this.cmdrefresh.Name = "cmdrefresh";
            this.cmdrefresh.Size = new System.Drawing.Size(116, 36);
            this.cmdrefresh.TabIndex = 53;
            this.cmdrefresh.Text = "Recargar";
            this.cmdrefresh.Click += new System.EventHandler(this.cmdrefresh_Click);
            // 
            // lblSeleccionarPuntoVenta
            // 
            this.lblSeleccionarPuntoVenta.AutoSize = true;
            this.lblSeleccionarPuntoVenta.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionarPuntoVenta.Location = new System.Drawing.Point(122, 16);
            this.lblSeleccionarPuntoVenta.Name = "lblSeleccionarPuntoVenta";
            this.lblSeleccionarPuntoVenta.Size = new System.Drawing.Size(161, 13);
            this.lblSeleccionarPuntoVenta.TabIndex = 55;
            this.lblSeleccionarPuntoVenta.Text = "Seleccione un punto de Venta";
            // 
            // glePuntoVenta
            // 
            this.glePuntoVenta.Location = new System.Drawing.Point(124, 32);
            this.glePuntoVenta.Name = "glePuntoVenta";
            this.glePuntoVenta.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glePuntoVenta.Properties.Appearance.Options.UseFont = true;
            this.glePuntoVenta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glePuntoVenta.Properties.DataSource = this.bsPuntosVenta;
            this.glePuntoVenta.Properties.DisplayMember = "descripcion";
            this.glePuntoVenta.Properties.PopupView = this.gridLookUpEdit1View;
            this.glePuntoVenta.Properties.SearchMode = DevExpress.XtraEditors.Repository.GridLookUpSearchMode.AutoSearch;
            this.glePuntoVenta.Properties.ValueMember = "id";
            this.glePuntoVenta.Size = new System.Drawing.Size(203, 24);
            this.glePuntoVenta.TabIndex = 54;
            this.glePuntoVenta.EditValueChanged += new System.EventHandler(this.glePuntoVenta_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.coldescripcion});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "id";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // coldescripcion
            // 
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.ReadOnly = true;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            // 
            // bsPuntosVenta
            // 
            this.bsPuntosVenta.DataMember = "punto_venta";
            this.bsPuntosVenta.DataSource = this.dsContabilidad1;
            // 
            // frmCierreDiaHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 507);
            this.Controls.Add(this.lblSeleccionarPuntoVenta);
            this.Controls.Add(this.glePuntoVenta);
            this.Controls.Add(this.cmdrefresh);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmdAgregar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmCierreDiaHome";
            this.Text = "Cierre Dia";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContabilidad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVerDetalleCierre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdImprimirCierres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditarCierre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glePuntoVenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPuntosVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsContabilidad dsContabilidad1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colid_punto_venta;
        private DevExpress.XtraGrid.Columns.GridColumn colpunto_venta_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn colid_estado;
        private DevExpress.XtraGrid.Columns.GridColumn colestado_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colid_user_responsable;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario_responsable_nombre;
        private DevExpress.XtraGrid.Columns.GridColumn colid_user_validacion;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario_validacion_nombre;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_row;
        private DevExpress.XtraGrid.Columns.GridColumn colver_detalle;
        private DevExpress.XtraGrid.Columns.GridColumn colimprimir;
        private DevExpress.XtraGrid.Columns.GridColumn coleditar;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraEditors.SimpleButton cmdAgregar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdEditarCierre;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdImprimirCierres;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdVerDetalleCierre;
        private DevExpress.XtraEditors.SimpleButton cmdrefresh;
        private System.Windows.Forms.Label lblSeleccionarPuntoVenta;
        private DevExpress.XtraEditors.GridLookUpEdit glePuntoVenta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private System.Windows.Forms.BindingSource bsPuntosVenta;
    }
}