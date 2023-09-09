
namespace ERP_INTECOLI.Administracion.Movimientos
{
    partial class frmMovimientosSaldos
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovimientosSaldos));
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdTodos = new System.Windows.Forms.RadioButton();
            this.rdSoloHabilitados = new System.Windows.Forms.RadioButton();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEstudiante = new DevExpress.XtraEditors.TextEdit();
            this.cmdF2 = new DevExpress.XtraEditors.SimpleButton();
            this.cmbCargarDatos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dsMovimientosSaldos1 = new ERP_INTECOLI.Administracion.Movimientos.dsMovimientosSaldos();
            this.colid_estudiante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconcepto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colanular = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimprimir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcredito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposAnular = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.reposImprimir = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstudiante.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMovimientosSaldos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposAnular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposImprimir)).BeginInit();
            this.SuspendLayout();
            // 
            // grDetalle
            // 
            this.grDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grDetalle.DataMember = "movimientos";
            this.grDetalle.DataSource = this.dsMovimientosSaldos1;
            this.grDetalle.Location = new System.Drawing.Point(3, 136);
            this.grDetalle.MainView = this.gridView1;
            this.grDetalle.Name = "grDetalle";
            this.grDetalle.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.reposAnular,
            this.reposImprimir});
            this.grDetalle.Size = new System.Drawing.Size(1116, 436);
            this.grDetalle.TabIndex = 0;
            this.grDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_estudiante,
            this.colnombre,
            this.colid,
            this.colfecha,
            this.colnulo,
            this.coltipo,
            this.colconcepto,
            this.colanular,
            this.colimprimir,
            this.colcredito,
            this.colcargo});
            this.gridView1.GridControl = this.grDetalle;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.cmbCargarDatos);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.dtFechaHasta);
            this.panelControl1.Controls.Add(this.dtFechaDesde);
            this.panelControl1.Controls.Add(this.cmdF2);
            this.panelControl1.Controls.Add(this.txtEstudiante);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.cmdCancelar);
            this.panelControl1.Controls.Add(this.groupBox2);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Location = new System.Drawing.Point(3, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1116, 127);
            this.panelControl1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(436, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Movimientos de Saldos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdTodos);
            this.groupBox2.Controls.Add(this.rdSoloHabilitados);
            this.groupBox2.Location = new System.Drawing.Point(831, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 54);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones de Visualización";
            // 
            // rdTodos
            // 
            this.rdTodos.AutoSize = true;
            this.rdTodos.Location = new System.Drawing.Point(6, 30);
            this.rdTodos.Name = "rdTodos";
            this.rdTodos.Size = new System.Drawing.Size(54, 17);
            this.rdTodos.TabIndex = 1;
            this.rdTodos.Text = "Todos";
            this.rdTodos.UseVisualStyleBackColor = true;
            // 
            // rdSoloHabilitados
            // 
            this.rdSoloHabilitados.AutoSize = true;
            this.rdSoloHabilitados.Checked = true;
            this.rdSoloHabilitados.Location = new System.Drawing.Point(6, 14);
            this.rdSoloHabilitados.Name = "rdSoloHabilitados";
            this.rdSoloHabilitados.Size = new System.Drawing.Size(100, 17);
            this.rdSoloHabilitados.TabIndex = 0;
            this.rdSoloHabilitados.TabStop = true;
            this.rdSoloHabilitados.Text = "Solo Habilitados";
            this.rdSoloHabilitados.UseVisualStyleBackColor = true;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancelar.BackColor = System.Drawing.Color.LightSalmon;
            this.cmdCancelar.FlatAppearance.BorderColor = System.Drawing.Color.LightSalmon;
            this.cmdCancelar.FlatAppearance.BorderSize = 2;
            this.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Image = global::ERP_INTECOLI.Properties.Resources.cerrar;
            this.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCancelar.Location = new System.Drawing.Point(999, 9);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(106, 49);
            this.cmdCancelar.TabIndex = 45;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdCancelar.UseVisualStyleBackColor = false;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "Estudiante";
            // 
            // txtEstudiante
            // 
            this.txtEstudiante.EditValue = "F2 Buscar";
            this.txtEstudiante.Enabled = false;
            this.txtEstudiante.Location = new System.Drawing.Point(101, 84);
            this.txtEstudiante.Name = "txtEstudiante";
            this.txtEstudiante.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEstudiante.Properties.Appearance.Options.UseFont = true;
            this.txtEstudiante.Size = new System.Drawing.Size(248, 26);
            this.txtEstudiante.TabIndex = 47;
            this.txtEstudiante.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEstudiante_KeyDown);
            // 
            // cmdF2
            // 
            this.cmdF2.Appearance.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmdF2.Appearance.ForeColor = System.Drawing.Color.White;
            this.cmdF2.Appearance.Options.UseBackColor = true;
            this.cmdF2.Appearance.Options.UseForeColor = true;
            this.cmdF2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.cmdF2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdF2.ImageOptions.Image")));
            this.cmdF2.Location = new System.Drawing.Point(355, 79);
            this.cmdF2.Name = "cmdF2";
            this.cmdF2.Size = new System.Drawing.Size(45, 39);
            this.cmdF2.TabIndex = 48;
            this.cmdF2.Click += new System.EventHandler(this.cmdF2_Click);
            // 
            // cmbCargarDatos
            // 
            this.cmbCargarDatos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbCargarDatos.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbCargarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCargarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbCargarDatos.Image = ((System.Drawing.Image)(resources.GetObject("cmbCargarDatos.Image")));
            this.cmbCargarDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmbCargarDatos.Location = new System.Drawing.Point(661, 64);
            this.cmbCargarDatos.Name = "cmbCargarDatos";
            this.cmbCargarDatos.Size = new System.Drawing.Size(144, 54);
            this.cmbCargarDatos.TabIndex = 53;
            this.cmbCargarDatos.Text = "Cargar Datos";
            this.cmbCargarDatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmbCargarDatos.UseVisualStyleBackColor = false;
            this.cmbCargarDatos.Click += new System.EventHandler(this.cmbCargarDatos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(426, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Fecha Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(422, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Fecha Desde:";
            // 
            // dtFechaHasta
            // 
            this.dtFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaHasta.Location = new System.Drawing.Point(537, 93);
            this.dtFechaHasta.Name = "dtFechaHasta";
            this.dtFechaHasta.Size = new System.Drawing.Size(104, 26);
            this.dtFechaHasta.TabIndex = 50;
            // 
            // dtFechaDesde
            // 
            this.dtFechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaDesde.Location = new System.Drawing.Point(537, 64);
            this.dtFechaDesde.Name = "dtFechaDesde";
            this.dtFechaDesde.Size = new System.Drawing.Size(104, 26);
            this.dtFechaDesde.TabIndex = 49;
            // 
            // dsMovimientosSaldos1
            // 
            this.dsMovimientosSaldos1.DataSetName = "dsMovimientosSaldos";
            this.dsMovimientosSaldos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colid_estudiante
            // 
            this.colid_estudiante.FieldName = "id_estudiante";
            this.colid_estudiante.Name = "colid_estudiante";
            this.colid_estudiante.OptionsColumn.ReadOnly = true;
            // 
            // colnombre
            // 
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.ReadOnly = true;
            // 
            // colid
            // 
            this.colid.Caption = "#Doc";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.ReadOnly = true;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 2;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.ReadOnly = true;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 0;
            // 
            // colnulo
            // 
            this.colnulo.Caption = "Nulo";
            this.colnulo.FieldName = "nulo";
            this.colnulo.Name = "colnulo";
            this.colnulo.OptionsColumn.ReadOnly = true;
            this.colnulo.Visible = true;
            this.colnulo.VisibleIndex = 1;
            // 
            // coltipo
            // 
            this.coltipo.FieldName = "tipo";
            this.coltipo.Name = "coltipo";
            this.coltipo.OptionsColumn.ReadOnly = true;
            // 
            // colconcepto
            // 
            this.colconcepto.FieldName = "concepto";
            this.colconcepto.Name = "colconcepto";
            this.colconcepto.OptionsColumn.ReadOnly = true;
            this.colconcepto.Visible = true;
            this.colconcepto.VisibleIndex = 3;
            // 
            // colanular
            // 
            this.colanular.Caption = "Anular";
            this.colanular.ColumnEdit = this.reposAnular;
            this.colanular.FieldName = "anular";
            this.colanular.Name = "colanular";
            this.colanular.Visible = true;
            this.colanular.VisibleIndex = 4;
            // 
            // colimprimir
            // 
            this.colimprimir.Caption = "Imprimir";
            this.colimprimir.ColumnEdit = this.reposImprimir;
            this.colimprimir.FieldName = "imprimir";
            this.colimprimir.Name = "colimprimir";
            this.colimprimir.Visible = true;
            this.colimprimir.VisibleIndex = 5;
            // 
            // colcredito
            // 
            this.colcredito.FieldName = "credito";
            this.colcredito.Name = "colcredito";
            this.colcredito.OptionsColumn.ReadOnly = true;
            this.colcredito.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "credito", "SUM={0:0.##}")});
            this.colcredito.Visible = true;
            this.colcredito.VisibleIndex = 6;
            // 
            // colcargo
            // 
            this.colcargo.FieldName = "cargo";
            this.colcargo.Name = "colcargo";
            this.colcargo.OptionsColumn.ReadOnly = true;
            this.colcargo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cargo", "SUM={0:0.##.##}")});
            this.colcargo.Visible = true;
            this.colcargo.VisibleIndex = 7;
            // 
            // reposAnular
            // 
            this.reposAnular.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.reposAnular.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.reposAnular.Name = "reposAnular";
            this.reposAnular.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.reposAnular.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.reposAnular_ButtonClick);
            // 
            // reposImprimir
            // 
            this.reposImprimir.AutoHeight = false;
            editorButtonImageOptions4.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions4.Image")));
            this.reposImprimir.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions4, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject13, serializableAppearanceObject14, serializableAppearanceObject15, serializableAppearanceObject16, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.reposImprimir.Name = "reposImprimir";
            this.reposImprimir.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.reposImprimir.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.reposImprimir_ButtonClick);
            // 
            // frmMovimientosSaldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 576);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.grDetalle);
            this.Name = "frmMovimientosSaldos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstudiante.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMovimientosSaldos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposAnular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposImprimir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grDetalle;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdTodos;
        private System.Windows.Forms.RadioButton rdSoloHabilitados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmbCargarDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFechaHasta;
        private System.Windows.Forms.DateTimePicker dtFechaDesde;
        private DevExpress.XtraEditors.SimpleButton cmdF2;
        private DevExpress.XtraEditors.TextEdit txtEstudiante;
        private dsMovimientosSaldos dsMovimientosSaldos1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_estudiante;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colnulo;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo;
        private DevExpress.XtraGrid.Columns.GridColumn colconcepto;
        private DevExpress.XtraGrid.Columns.GridColumn colanular;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposAnular;
        private DevExpress.XtraGrid.Columns.GridColumn colimprimir;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposImprimir;
        private DevExpress.XtraGrid.Columns.GridColumn colcredito;
        private DevExpress.XtraGrid.Columns.GridColumn colcargo;
    }
}