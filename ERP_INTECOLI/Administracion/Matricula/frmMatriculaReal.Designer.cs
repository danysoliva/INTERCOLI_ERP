
namespace ERP_INTECOLI.Administracion.Matricula
{
    partial class frmMatriculaReal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMatriculaReal));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsMatriculado1 = new ERP_INTECOLI.Administracion.Matricula.dsMatriculado();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_estudiante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_curso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhorainicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhorafin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collunes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmartes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmiercoles = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coljueves = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colviernes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsabado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldomingo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechamatricula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechainicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechafin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcursofinalizado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEditar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colid_detalle_matricula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmover = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposMove = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cmdNuevo = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdF2 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtEstudiante = new DevExpress.XtraEditors.TextEdit();
            this.txtMensualidad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.chNulas = new System.Windows.Forms.CheckBox();
            this.chMostrarFinalizados = new System.Windows.Forms.CheckBox();
            this.flyoutPanel1 = new DevExpress.Utils.FlyoutPanel();
            this.flyoutPanelControl1 = new DevExpress.Utils.FlyoutPanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMatriculado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstudiante.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMensualidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).BeginInit();
            this.flyoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "matricula_detalle_real";
            this.gridControl1.DataSource = this.dsMatriculado1;
            this.gridControl1.Location = new System.Drawing.Point(3, 104);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.reposEditar,
            this.reposMove});
            this.gridControl1.Size = new System.Drawing.Size(1229, 608);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsMatriculado1
            // 
            this.dsMatriculado1.DataSetName = "dsMatriculado";
            this.dsMatriculado1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_estudiante,
            this.colid_curso,
            this.coldescripcion,
            this.colseccion,
            this.colhorainicio,
            this.colhorafin,
            this.collunes,
            this.colmartes,
            this.colmiercoles,
            this.coljueves,
            this.colviernes,
            this.colsabado,
            this.coldomingo,
            this.colnulo,
            this.colfechamatricula,
            this.colvalor,
            this.colfechainicio,
            this.colfechafin,
            this.colcursofinalizado,
            this.colEditar,
            this.colid_detalle_matricula,
            this.colmover});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid_estudiante
            // 
            this.colid_estudiante.FieldName = "id_estudiante";
            this.colid_estudiante.Name = "colid_estudiante";
            this.colid_estudiante.OptionsColumn.ReadOnly = true;
            // 
            // colid_curso
            // 
            this.colid_curso.FieldName = "id_curso";
            this.colid_curso.Name = "colid_curso";
            this.colid_curso.OptionsColumn.ReadOnly = true;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripcion";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.ReadOnly = true;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            this.coldescripcion.Width = 104;
            // 
            // colseccion
            // 
            this.colseccion.Caption = "Seccion";
            this.colseccion.FieldName = "seccion";
            this.colseccion.Name = "colseccion";
            this.colseccion.OptionsColumn.ReadOnly = true;
            this.colseccion.Visible = true;
            this.colseccion.VisibleIndex = 1;
            this.colseccion.Width = 63;
            // 
            // colhorainicio
            // 
            this.colhorainicio.Caption = "H. Inicio";
            this.colhorainicio.FieldName = "horainicio";
            this.colhorainicio.Name = "colhorainicio";
            this.colhorainicio.OptionsColumn.ReadOnly = true;
            this.colhorainicio.Visible = true;
            this.colhorainicio.VisibleIndex = 3;
            this.colhorainicio.Width = 63;
            // 
            // colhorafin
            // 
            this.colhorafin.Caption = "H. Fin";
            this.colhorafin.FieldName = "horafin";
            this.colhorafin.Name = "colhorafin";
            this.colhorafin.OptionsColumn.ReadOnly = true;
            this.colhorafin.Visible = true;
            this.colhorafin.VisibleIndex = 4;
            this.colhorafin.Width = 63;
            // 
            // collunes
            // 
            this.collunes.Caption = "Lu";
            this.collunes.FieldName = "lunes";
            this.collunes.Name = "collunes";
            this.collunes.OptionsColumn.ReadOnly = true;
            this.collunes.Visible = true;
            this.collunes.VisibleIndex = 5;
            this.collunes.Width = 63;
            // 
            // colmartes
            // 
            this.colmartes.Caption = "Ma";
            this.colmartes.FieldName = "martes";
            this.colmartes.Name = "colmartes";
            this.colmartes.OptionsColumn.ReadOnly = true;
            this.colmartes.Visible = true;
            this.colmartes.VisibleIndex = 6;
            this.colmartes.Width = 63;
            // 
            // colmiercoles
            // 
            this.colmiercoles.Caption = "Mie";
            this.colmiercoles.FieldName = "miercoles";
            this.colmiercoles.Name = "colmiercoles";
            this.colmiercoles.OptionsColumn.ReadOnly = true;
            this.colmiercoles.Visible = true;
            this.colmiercoles.VisibleIndex = 7;
            this.colmiercoles.Width = 63;
            // 
            // coljueves
            // 
            this.coljueves.Caption = "Ju";
            this.coljueves.FieldName = "jueves";
            this.coljueves.Name = "coljueves";
            this.coljueves.OptionsColumn.ReadOnly = true;
            this.coljueves.Visible = true;
            this.coljueves.VisibleIndex = 8;
            this.coljueves.Width = 63;
            // 
            // colviernes
            // 
            this.colviernes.Caption = "Vi";
            this.colviernes.FieldName = "viernes";
            this.colviernes.Name = "colviernes";
            this.colviernes.OptionsColumn.ReadOnly = true;
            this.colviernes.Visible = true;
            this.colviernes.VisibleIndex = 9;
            this.colviernes.Width = 63;
            // 
            // colsabado
            // 
            this.colsabado.Caption = "Sab";
            this.colsabado.FieldName = "sabado";
            this.colsabado.Name = "colsabado";
            this.colsabado.OptionsColumn.ReadOnly = true;
            this.colsabado.Visible = true;
            this.colsabado.VisibleIndex = 10;
            this.colsabado.Width = 63;
            // 
            // coldomingo
            // 
            this.coldomingo.Caption = "Do";
            this.coldomingo.FieldName = "domingo";
            this.coldomingo.Name = "coldomingo";
            this.coldomingo.OptionsColumn.ReadOnly = true;
            this.coldomingo.Visible = true;
            this.coldomingo.VisibleIndex = 11;
            this.coldomingo.Width = 63;
            // 
            // colnulo
            // 
            this.colnulo.Caption = "nulo";
            this.colnulo.FieldName = "nulo";
            this.colnulo.Name = "colnulo";
            this.colnulo.OptionsColumn.ReadOnly = true;
            this.colnulo.Visible = true;
            this.colnulo.VisibleIndex = 12;
            this.colnulo.Width = 63;
            // 
            // colfechamatricula
            // 
            this.colfechamatricula.FieldName = "fechamatricula";
            this.colfechamatricula.Name = "colfechamatricula";
            this.colfechamatricula.OptionsColumn.ReadOnly = true;
            // 
            // colvalor
            // 
            this.colvalor.Caption = "Valor";
            this.colvalor.FieldName = "valor";
            this.colvalor.Name = "colvalor";
            this.colvalor.OptionsColumn.ReadOnly = true;
            this.colvalor.Visible = true;
            this.colvalor.VisibleIndex = 2;
            this.colvalor.Width = 63;
            // 
            // colfechainicio
            // 
            this.colfechainicio.Caption = "F. Inicio";
            this.colfechainicio.FieldName = "fechainicio";
            this.colfechainicio.Name = "colfechainicio";
            this.colfechainicio.OptionsColumn.ReadOnly = true;
            this.colfechainicio.Visible = true;
            this.colfechainicio.VisibleIndex = 13;
            this.colfechainicio.Width = 63;
            // 
            // colfechafin
            // 
            this.colfechafin.Caption = "F. Fin";
            this.colfechafin.FieldName = "fechafin";
            this.colfechafin.Name = "colfechafin";
            this.colfechafin.OptionsColumn.ReadOnly = true;
            this.colfechafin.Visible = true;
            this.colfechafin.VisibleIndex = 14;
            this.colfechafin.Width = 63;
            // 
            // colcursofinalizado
            // 
            this.colcursofinalizado.Caption = "Finalizado";
            this.colcursofinalizado.FieldName = "cursofinalizado";
            this.colcursofinalizado.Name = "colcursofinalizado";
            this.colcursofinalizado.OptionsColumn.ReadOnly = true;
            this.colcursofinalizado.Visible = true;
            this.colcursofinalizado.VisibleIndex = 15;
            this.colcursofinalizado.Width = 81;
            // 
            // colEditar
            // 
            this.colEditar.Caption = "Editar";
            this.colEditar.ColumnEdit = this.reposEditar;
            this.colEditar.FieldName = "Editar";
            this.colEditar.Name = "colEditar";
            this.colEditar.Visible = true;
            this.colEditar.VisibleIndex = 16;
            this.colEditar.Width = 64;
            // 
            // reposEditar
            // 
            this.reposEditar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.reposEditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.reposEditar.Name = "reposEditar";
            this.reposEditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.reposEditar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.reposEditar_ButtonClick);
            // 
            // colid_detalle_matricula
            // 
            this.colid_detalle_matricula.FieldName = "id_detalle_matricula";
            this.colid_detalle_matricula.Name = "colid_detalle_matricula";
            this.colid_detalle_matricula.OptionsColumn.ReadOnly = true;
            // 
            // colmover
            // 
            this.colmover.Caption = "Mover";
            this.colmover.ColumnEdit = this.reposMove;
            this.colmover.FieldName = "mover";
            this.colmover.Name = "colmover";
            this.colmover.Visible = true;
            this.colmover.VisibleIndex = 17;
            this.colmover.Width = 73;
            // 
            // reposMove
            // 
            this.reposMove.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.reposMove.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.reposMove.Name = "reposMove";
            this.reposMove.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.BackColor = System.Drawing.Color.PaleGreen;
            this.cmdNuevo.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.cmdNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdNuevo.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cmdNuevo.Image = global::ERP_INTECOLI.Properties.Resources.anadir;
            this.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdNuevo.Location = new System.Drawing.Point(517, 24);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(149, 43);
            this.cmdNuevo.TabIndex = 10;
            this.cmdNuevo.Text = "Agregar Cursos";
            this.cmdNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdNuevo.UseVisualStyleBackColor = false;
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
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
            this.cmdCancelar.Location = new System.Drawing.Point(1112, 40);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(110, 43);
            this.cmdCancelar.TabIndex = 45;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdCancelar.UseVisualStyleBackColor = false;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdBuscar.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cmdBuscar.Appearance.Options.UseBackColor = true;
            this.cmdBuscar.Appearance.Options.UseFont = true;
            this.cmdBuscar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdBuscar.ImageOptions.SvgImage")));
            this.cmdBuscar.Location = new System.Drawing.Point(354, 23);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(138, 43);
            this.cmdBuscar.TabIndex = 46;
            this.cmdBuscar.Text = "Cargar Cursos";
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // cmdF2
            // 
            this.cmdF2.Appearance.BackColor = System.Drawing.Color.PaleGreen;
            this.cmdF2.Appearance.Options.UseBackColor = true;
            this.cmdF2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.cmdF2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdF2.ImageOptions.SvgImage")));
            this.cmdF2.Location = new System.Drawing.Point(287, 22);
            this.cmdF2.Name = "cmdF2";
            this.cmdF2.Size = new System.Drawing.Size(48, 44);
            this.cmdF2.TabIndex = 47;
            this.cmdF2.Click += new System.EventHandler(this.cmdF2_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 20);
            this.labelControl1.TabIndex = 48;
            this.labelControl1.Text = "Estudiante";
            // 
            // txtEstudiante
            // 
            this.txtEstudiante.EditValue = "F2 Buscar";
            this.txtEstudiante.Enabled = false;
            this.txtEstudiante.Location = new System.Drawing.Point(112, 34);
            this.txtEstudiante.Name = "txtEstudiante";
            this.txtEstudiante.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtEstudiante.Properties.Appearance.Options.UseFont = true;
            this.txtEstudiante.Size = new System.Drawing.Size(169, 26);
            this.txtEstudiante.TabIndex = 49;
            this.txtEstudiante.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEstudiante_KeyDown);
            // 
            // txtMensualidad
            // 
            this.txtMensualidad.EditValue = "0.00";
            this.txtMensualidad.Location = new System.Drawing.Point(112, 72);
            this.txtMensualidad.Name = "txtMensualidad";
            this.txtMensualidad.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtMensualidad.Properties.Appearance.Options.UseFont = true;
            this.txtMensualidad.Size = new System.Drawing.Size(143, 26);
            this.txtMensualidad.TabIndex = 50;
            this.txtMensualidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMensualidad_KeyDown);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 76);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(94, 20);
            this.labelControl2.TabIndex = 51;
            this.labelControl2.Text = "Valor Mensual";
            // 
            // chNulas
            // 
            this.chNulas.AutoSize = true;
            this.chNulas.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chNulas.Location = new System.Drawing.Point(354, 79);
            this.chNulas.Name = "chNulas";
            this.chNulas.Size = new System.Drawing.Size(98, 18);
            this.chNulas.TabIndex = 52;
            this.chNulas.Text = "Mostrar Nulas";
            this.chNulas.UseVisualStyleBackColor = true;
            this.chNulas.CheckedChanged += new System.EventHandler(this.chNulas_CheckedChanged);
            // 
            // chMostrarFinalizados
            // 
            this.chMostrarFinalizados.AutoSize = true;
            this.chMostrarFinalizados.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chMostrarFinalizados.Location = new System.Drawing.Point(487, 79);
            this.chMostrarFinalizados.Name = "chMostrarFinalizados";
            this.chMostrarFinalizados.Size = new System.Drawing.Size(125, 18);
            this.chMostrarFinalizados.TabIndex = 53;
            this.chMostrarFinalizados.Text = "Mostrar Finalizados";
            this.chMostrarFinalizados.UseVisualStyleBackColor = true;
            this.chMostrarFinalizados.CheckedChanged += new System.EventHandler(this.chMostrarFinalizados_CheckedChanged);
            // 
            // flyoutPanel1
            // 
            this.flyoutPanel1.Appearance.BackColor = System.Drawing.Color.White;
            this.flyoutPanel1.Appearance.Options.UseBackColor = true;
            this.flyoutPanel1.Controls.Add(this.flyoutPanelControl1);
            this.flyoutPanel1.Location = new System.Drawing.Point(458, 316);
            this.flyoutPanel1.Name = "flyoutPanel1";
            this.flyoutPanel1.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Center;
            this.flyoutPanel1.OptionsBeakPanel.BackColor = System.Drawing.Color.White;
            this.flyoutPanel1.OwnerControl = this;
            this.flyoutPanel1.Size = new System.Drawing.Size(150, 150);
            this.flyoutPanel1.TabIndex = 54;
            // 
            // flyoutPanelControl1
            // 
            this.flyoutPanelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flyoutPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flyoutPanelControl1.FlyoutPanel = this.flyoutPanel1;
            this.flyoutPanelControl1.Location = new System.Drawing.Point(0, 0);
            this.flyoutPanelControl1.Name = "flyoutPanelControl1";
            this.flyoutPanelControl1.Size = new System.Drawing.Size(150, 150);
            this.flyoutPanelControl1.TabIndex = 0;
            // 
            // frmMatriculaReal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 713);
            this.Controls.Add(this.flyoutPanel1);
            this.Controls.Add(this.chMostrarFinalizados);
            this.Controls.Add(this.chNulas);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtMensualidad);
            this.Controls.Add(this.txtEstudiante);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmdF2);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdNuevo);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmMatriculaReal";
            this.Text = "frmMatriculaReal";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMatriculado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstudiante.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMensualidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).EndInit();
            this.flyoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsMatriculado dsMatriculado1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_estudiante;
        private DevExpress.XtraGrid.Columns.GridColumn colid_curso;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colseccion;
        private DevExpress.XtraGrid.Columns.GridColumn colhorainicio;
        private DevExpress.XtraGrid.Columns.GridColumn colhorafin;
        private DevExpress.XtraGrid.Columns.GridColumn collunes;
        private DevExpress.XtraGrid.Columns.GridColumn colmartes;
        private DevExpress.XtraGrid.Columns.GridColumn colmiercoles;
        private DevExpress.XtraGrid.Columns.GridColumn coljueves;
        private DevExpress.XtraGrid.Columns.GridColumn colviernes;
        private DevExpress.XtraGrid.Columns.GridColumn colsabado;
        private DevExpress.XtraGrid.Columns.GridColumn coldomingo;
        private DevExpress.XtraGrid.Columns.GridColumn colnulo;
        private DevExpress.XtraGrid.Columns.GridColumn colfechamatricula;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor;
        private DevExpress.XtraGrid.Columns.GridColumn colfechainicio;
        private DevExpress.XtraGrid.Columns.GridColumn colfechafin;
        private DevExpress.XtraGrid.Columns.GridColumn colcursofinalizado;
        private DevExpress.XtraGrid.Columns.GridColumn colEditar;
        private DevExpress.XtraGrid.Columns.GridColumn colid_detalle_matricula;
        private DevExpress.XtraGrid.Columns.GridColumn colmover;
        private System.Windows.Forms.Button cmdNuevo;
        private System.Windows.Forms.Button cmdCancelar;
        private DevExpress.XtraEditors.SimpleButton cmdBuscar;
        private DevExpress.XtraEditors.SimpleButton cmdF2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtEstudiante;
        private DevExpress.XtraEditors.TextEdit txtMensualidad;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.CheckBox chNulas;
        private System.Windows.Forms.CheckBox chMostrarFinalizados;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposEditar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposMove;
        private DevExpress.Utils.FlyoutPanel flyoutPanel1;
        private DevExpress.Utils.FlyoutPanelControl flyoutPanelControl1;
    }
}