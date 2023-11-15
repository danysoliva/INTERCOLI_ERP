namespace ERP_INTECOLI.Facturacion.FacturacionAutomatica
{
    partial class frmConfigFacturaEstudianteAuto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfigFacturaEstudianteAuto));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsConfigFacturaAutomatica1 = new ERP_INTECOLI.Facturacion.FacturacionAutomatica.dsConfigFacturaAutomatica();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_estudiante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_registrado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_usuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_matricula_detalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcurso_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcurso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUltimaEjecucion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrango_pago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmin_dia_pago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmax_dia_pago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridColumnEliminar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdEliminarLinea = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConfigFacturaAutomatica1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEliminarLinea)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "detalle_cursos_estudiantes_config";
            this.gridControl1.DataSource = this.dsConfigFacturaAutomatica1;
            this.gridControl1.Location = new System.Drawing.Point(2, 55);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdEliminarLinea});
            this.gridControl1.Size = new System.Drawing.Size(954, 447);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsConfigFacturaAutomatica1
            // 
            this.dsConfigFacturaAutomatica1.DataSetName = "dsConfigFacturaAutomatica";
            this.dsConfigFacturaAutomatica1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_estudiante,
            this.colnombre,
            this.colenable,
            this.colfecha_registrado,
            this.colvalor,
            this.colid_usuario,
            this.colUsuarioNombre,
            this.colid_matricula_detalle,
            this.colcurso_id,
            this.colcurso,
            this.colItemCode,
            this.colUltimaEjecucion,
            this.colrango_pago,
            this.colmin_dia_pago,
            this.colmax_dia_pago,
            this.gridColumnEliminar});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colid_estudiante
            // 
            this.colid_estudiante.FieldName = "id_estudiante";
            this.colid_estudiante.Name = "colid_estudiante";
            // 
            // colnombre
            // 
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.ReadOnly = true;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            this.colnombre.Width = 218;
            // 
            // colenable
            // 
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            // 
            // colfecha_registrado
            // 
            this.colfecha_registrado.FieldName = "fecha_registrado";
            this.colfecha_registrado.Name = "colfecha_registrado";
            // 
            // colvalor
            // 
            this.colvalor.DisplayFormat.FormatString = "N2";
            this.colvalor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colvalor.FieldName = "valor";
            this.colvalor.Name = "colvalor";
            this.colvalor.Visible = true;
            this.colvalor.VisibleIndex = 3;
            this.colvalor.Width = 177;
            // 
            // colid_usuario
            // 
            this.colid_usuario.FieldName = "id_usuario";
            this.colid_usuario.Name = "colid_usuario";
            // 
            // colUsuarioNombre
            // 
            this.colUsuarioNombre.FieldName = "Usuario Nombre";
            this.colUsuarioNombre.Name = "colUsuarioNombre";
            this.colUsuarioNombre.Width = 140;
            // 
            // colid_matricula_detalle
            // 
            this.colid_matricula_detalle.FieldName = "id_matricula_detalle";
            this.colid_matricula_detalle.Name = "colid_matricula_detalle";
            // 
            // colcurso_id
            // 
            this.colcurso_id.FieldName = "curso_id";
            this.colcurso_id.Name = "colcurso_id";
            // 
            // colcurso
            // 
            this.colcurso.FieldName = "curso";
            this.colcurso.Name = "colcurso";
            this.colcurso.OptionsColumn.ReadOnly = true;
            this.colcurso.Visible = true;
            this.colcurso.VisibleIndex = 2;
            this.colcurso.Width = 230;
            // 
            // colItemCode
            // 
            this.colItemCode.Caption = "Code";
            this.colItemCode.FieldName = "Item Code";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.OptionsColumn.ReadOnly = true;
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 0;
            this.colItemCode.Width = 95;
            // 
            // colUltimaEjecucion
            // 
            this.colUltimaEjecucion.FieldName = "Ultima Ejecucion";
            this.colUltimaEjecucion.Name = "colUltimaEjecucion";
            this.colUltimaEjecucion.OptionsColumn.ReadOnly = true;
            this.colUltimaEjecucion.Visible = true;
            this.colUltimaEjecucion.VisibleIndex = 5;
            this.colUltimaEjecucion.Width = 107;
            // 
            // colrango_pago
            // 
            this.colrango_pago.FieldName = "rango_pago";
            this.colrango_pago.Name = "colrango_pago";
            this.colrango_pago.OptionsColumn.ReadOnly = true;
            this.colrango_pago.Visible = true;
            this.colrango_pago.VisibleIndex = 4;
            this.colrango_pago.Width = 102;
            // 
            // colmin_dia_pago
            // 
            this.colmin_dia_pago.FieldName = "min_dia_pago";
            this.colmin_dia_pago.Name = "colmin_dia_pago";
            // 
            // colmax_dia_pago
            // 
            this.colmax_dia_pago.FieldName = "max_dia_pago";
            this.colmax_dia_pago.Name = "colmax_dia_pago";
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAgregar.Appearance.Options.UseFont = true;
            this.cmdAgregar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdAgregar.ImageOptions.SvgImage")));
            this.cmdAgregar.Location = new System.Drawing.Point(2, 12);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(99, 37);
            this.cmdAgregar.TabIndex = 1;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRefresh.Appearance.Options.UseFont = true;
            this.cmdRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdRefresh.ImageOptions.SvgImage")));
            this.cmdRefresh.Location = new System.Drawing.Point(107, 12);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(99, 37);
            this.cmdRefresh.TabIndex = 2;
            this.cmdRefresh.Text = "Refrescar";
            this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCerrar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Appearance.Options.UseFont = true;
            this.cmdCerrar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdCerrar.ImageOptions.SvgImage")));
            this.cmdCerrar.Location = new System.Drawing.Point(857, 12);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(99, 37);
            this.cmdCerrar.TabIndex = 3;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(293, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(360, 20);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Configuracion para Facturacion Automatica Mensual";
            // 
            // gridColumnEliminar
            // 
            this.gridColumnEliminar.Caption = "Eliminar";
            this.gridColumnEliminar.ColumnEdit = this.cmdEliminarLinea;
            this.gridColumnEliminar.Name = "gridColumnEliminar";
            this.gridColumnEliminar.Visible = true;
            this.gridColumnEliminar.VisibleIndex = 6;
            // 
            // cmdEliminarLinea
            // 
            this.cmdEliminarLinea.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.cmdEliminarLinea.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdEliminarLinea.Name = "cmdEliminarLinea";
            this.cmdEliminarLinea.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdEliminarLinea.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdEliminarLinea_ButtonClick);
            // 
            // frmConfigFacturaEstudianteAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 512);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.cmdRefresh);
            this.Controls.Add(this.cmdAgregar);
            this.Name = "frmConfigFacturaEstudianteAuto";
            this.Text = "Configuracion Factura Estudiante";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConfigFacturaAutomatica1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEliminarLinea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton cmdAgregar;
        private DevExpress.XtraEditors.SimpleButton cmdRefresh;
        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_estudiante;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_registrado;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor;
        private DevExpress.XtraGrid.Columns.GridColumn colid_usuario;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colid_matricula_detalle;
        private DevExpress.XtraGrid.Columns.GridColumn colcurso_id;
        private DevExpress.XtraGrid.Columns.GridColumn colcurso;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private dsConfigFacturaAutomatica dsConfigFacturaAutomatica1;
        private DevExpress.XtraGrid.Columns.GridColumn colUltimaEjecucion;
        private DevExpress.XtraGrid.Columns.GridColumn colrango_pago;
        private DevExpress.XtraGrid.Columns.GridColumn colmin_dia_pago;
        private DevExpress.XtraGrid.Columns.GridColumn colmax_dia_pago;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnEliminar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdEliminarLinea;
    }
}