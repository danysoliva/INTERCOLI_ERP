
namespace ERP_INTECOLI.Administracion.Cursos
{
    partial class frmCursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCursos));
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
            this.dsCursos_1 = new ERP_INTECOLI.Administracion.Cursos.dsCursos_();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_nivel1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_instructor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhora_inicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhora_fin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_posteo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_inicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_fin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcurso_finalizado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEditar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colEliminar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryEliminar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.ucbNiveles = new DevExpress.XtraEditors.GridLookUpEdit();
            this.nivelesacademicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_nivel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdEliminarTodos = new System.Windows.Forms.Button();
            this.chkFinalizados = new System.Windows.Forms.CheckBox();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCursos_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucbNiveles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivelesacademicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "Cursos";
            this.gridControl1.DataSource = this.dsCursos_1;
            this.gridControl1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridControl1.Location = new System.Drawing.Point(2, 61);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryEditar,
            this.repositoryEliminar});
            this.gridControl1.Size = new System.Drawing.Size(1020, 635);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsCursos_1
            // 
            this.dsCursos_1.DataSetName = "dsCursos_";
            this.dsCursos_1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_nivel1,
            this.colDescripcion1,
            this.colid_instructor,
            this.colnombres,
            this.colseccion,
            this.colhora_inicio,
            this.colhora_fin,
            this.colfecha_posteo,
            this.colfecha_inicio,
            this.colfecha_fin,
            this.colcurso_finalizado,
            this.colEditar,
            this.colEliminar});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colid_nivel1
            // 
            this.colid_nivel1.FieldName = "id_nivel";
            this.colid_nivel1.Name = "colid_nivel1";
            this.colid_nivel1.OptionsColumn.ReadOnly = true;
            // 
            // colDescripcion1
            // 
            this.colDescripcion1.Caption = "Curso";
            this.colDescripcion1.FieldName = "Descripcion";
            this.colDescripcion1.Name = "colDescripcion1";
            this.colDescripcion1.OptionsColumn.ReadOnly = true;
            this.colDescripcion1.Visible = true;
            this.colDescripcion1.VisibleIndex = 0;
            // 
            // colid_instructor
            // 
            this.colid_instructor.FieldName = "id_instructor";
            this.colid_instructor.Name = "colid_instructor";
            this.colid_instructor.OptionsColumn.ReadOnly = true;
            // 
            // colnombres
            // 
            this.colnombres.Caption = "Instructor";
            this.colnombres.FieldName = "nombres";
            this.colnombres.Name = "colnombres";
            this.colnombres.OptionsColumn.ReadOnly = true;
            this.colnombres.Visible = true;
            this.colnombres.VisibleIndex = 1;
            // 
            // colseccion
            // 
            this.colseccion.Caption = "Seccion";
            this.colseccion.FieldName = "seccion";
            this.colseccion.Name = "colseccion";
            this.colseccion.OptionsColumn.ReadOnly = true;
            this.colseccion.Visible = true;
            this.colseccion.VisibleIndex = 2;
            // 
            // colhora_inicio
            // 
            this.colhora_inicio.Caption = "H. Inicio";
            this.colhora_inicio.FieldName = "hora_inicio";
            this.colhora_inicio.Name = "colhora_inicio";
            this.colhora_inicio.OptionsColumn.ReadOnly = true;
            this.colhora_inicio.Visible = true;
            this.colhora_inicio.VisibleIndex = 3;
            // 
            // colhora_fin
            // 
            this.colhora_fin.Caption = "H. Fin";
            this.colhora_fin.FieldName = "hora_fin";
            this.colhora_fin.Name = "colhora_fin";
            this.colhora_fin.OptionsColumn.ReadOnly = true;
            this.colhora_fin.Visible = true;
            this.colhora_fin.VisibleIndex = 4;
            // 
            // colfecha_posteo
            // 
            this.colfecha_posteo.Caption = "F. Posteo";
            this.colfecha_posteo.FieldName = "fecha_posteo";
            this.colfecha_posteo.Name = "colfecha_posteo";
            this.colfecha_posteo.OptionsColumn.ReadOnly = true;
            this.colfecha_posteo.Visible = true;
            this.colfecha_posteo.VisibleIndex = 5;
            // 
            // colfecha_inicio
            // 
            this.colfecha_inicio.Caption = "F. Inicio";
            this.colfecha_inicio.FieldName = "fecha_inicio";
            this.colfecha_inicio.Name = "colfecha_inicio";
            this.colfecha_inicio.OptionsColumn.ReadOnly = true;
            this.colfecha_inicio.Visible = true;
            this.colfecha_inicio.VisibleIndex = 6;
            // 
            // colfecha_fin
            // 
            this.colfecha_fin.Caption = "F. Fin";
            this.colfecha_fin.FieldName = "fecha_fin";
            this.colfecha_fin.Name = "colfecha_fin";
            this.colfecha_fin.OptionsColumn.ReadOnly = true;
            this.colfecha_fin.Visible = true;
            this.colfecha_fin.VisibleIndex = 7;
            // 
            // colcurso_finalizado
            // 
            this.colcurso_finalizado.Caption = "Finalizado";
            this.colcurso_finalizado.FieldName = "curso_finalizado";
            this.colcurso_finalizado.Name = "colcurso_finalizado";
            this.colcurso_finalizado.OptionsColumn.AllowEdit = false;
            this.colcurso_finalizado.Visible = true;
            this.colcurso_finalizado.VisibleIndex = 8;
            // 
            // colEditar
            // 
            this.colEditar.Caption = "Editar";
            this.colEditar.ColumnEdit = this.repositoryEditar;
            this.colEditar.FieldName = "Editar";
            this.colEditar.Name = "colEditar";
            this.colEditar.Visible = true;
            this.colEditar.VisibleIndex = 9;
            // 
            // repositoryEditar
            // 
            this.repositoryEditar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.repositoryEditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryEditar.Name = "repositoryEditar";
            this.repositoryEditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryEditar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryEditar_ButtonClick);
            // 
            // colEliminar
            // 
            this.colEliminar.Caption = "Eliminar";
            this.colEliminar.ColumnEdit = this.repositoryEliminar;
            this.colEliminar.FieldName = "Eliminar";
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.Visible = true;
            this.colEliminar.VisibleIndex = 10;
            // 
            // repositoryEliminar
            // 
            this.repositoryEliminar.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.repositoryEliminar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryEliminar.Name = "repositoryEliminar";
            this.repositoryEliminar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryEliminar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryEliminar_ButtonClick);
            // 
            // ucbNiveles
            // 
            this.ucbNiveles.Location = new System.Drawing.Point(89, 15);
            this.ucbNiveles.Name = "ucbNiveles";
            this.ucbNiveles.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucbNiveles.Properties.Appearance.Options.UseFont = true;
            this.ucbNiveles.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ucbNiveles.Properties.DataSource = this.nivelesacademicosBindingSource;
            this.ucbNiveles.Properties.DisplayMember = "Descripcion";
            this.ucbNiveles.Properties.NullText = "";
            this.ucbNiveles.Properties.PopupView = this.gridLookUpEdit1View;
            this.ucbNiveles.Properties.SearchMode = DevExpress.XtraEditors.Repository.GridLookUpSearchMode.AutoSearch;
            this.ucbNiveles.Properties.ValueMember = "id_nivel";
            this.ucbNiveles.Size = new System.Drawing.Size(265, 24);
            this.ucbNiveles.TabIndex = 1;
            this.ucbNiveles.Visible = false;
            this.ucbNiveles.EditValueChanged += new System.EventHandler(this.gridLookUpEdit1_EditValueChanged);
            // 
            // nivelesacademicosBindingSource
            // 
            this.nivelesacademicosBindingSource.DataMember = "Niveles_academicos";
            this.nivelesacademicosBindingSource.DataSource = this.dsCursos_1;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_nivel,
            this.colDescripcion});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid_nivel
            // 
            this.colid_nivel.FieldName = "id_nivel";
            this.colid_nivel.Name = "colid_nivel";
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripcion";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(40, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 17);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Cursos:";
            this.labelControl1.Visible = false;
            // 
            // cmdEliminarTodos
            // 
            this.cmdEliminarTodos.BackColor = System.Drawing.Color.LightSalmon;
            this.cmdEliminarTodos.FlatAppearance.BorderColor = System.Drawing.Color.LightSalmon;
            this.cmdEliminarTodos.FlatAppearance.BorderSize = 2;
            this.cmdEliminarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdEliminarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEliminarTodos.Image = global::ERP_INTECOLI.Properties.Resources.cerrar;
            this.cmdEliminarTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdEliminarTodos.Location = new System.Drawing.Point(369, 12);
            this.cmdEliminarTodos.Name = "cmdEliminarTodos";
            this.cmdEliminarTodos.Size = new System.Drawing.Size(149, 43);
            this.cmdEliminarTodos.TabIndex = 20;
            this.cmdEliminarTodos.Text = "Eliminar Todos";
            this.cmdEliminarTodos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdEliminarTodos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdEliminarTodos.UseVisualStyleBackColor = false;
            this.cmdEliminarTodos.Click += new System.EventHandler(this.cmdEliminarTodos_Click);
            // 
            // chkFinalizados
            // 
            this.chkFinalizados.AutoSize = true;
            this.chkFinalizados.Location = new System.Drawing.Point(544, 26);
            this.chkFinalizados.Name = "chkFinalizados";
            this.chkFinalizados.Size = new System.Drawing.Size(97, 17);
            this.chkFinalizados.TabIndex = 21;
            this.chkFinalizados.Text = "Ver Finalizados";
            this.chkFinalizados.UseVisualStyleBackColor = true;
            this.chkFinalizados.CheckedChanged += new System.EventHandler(this.chkFinalizados_CheckedChanged);
            // 
            // cmdCargar
            // 
            this.cmdCargar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cmdCargar.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.cmdCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargar.Image = global::ERP_INTECOLI.Properties.Resources.actualizar_32;
            this.cmdCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCargar.Location = new System.Drawing.Point(647, 12);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(103, 43);
            this.cmdCargar.TabIndex = 24;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdCargar.UseVisualStyleBackColor = false;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.BackColor = System.Drawing.Color.LightSalmon;
            this.cmdCancelar.FlatAppearance.BorderColor = System.Drawing.Color.LightSalmon;
            this.cmdCancelar.FlatAppearance.BorderSize = 2;
            this.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Image = ((System.Drawing.Image)(resources.GetObject("cmdCancelar.Image")));
            this.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCancelar.Location = new System.Drawing.Point(880, 12);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(112, 43);
            this.cmdCancelar.TabIndex = 23;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdCancelar.UseVisualStyleBackColor = false;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cmdNuevo.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.cmdNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNuevo.Image = global::ERP_INTECOLI.Properties.Resources.anadir;
            this.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdNuevo.Location = new System.Drawing.Point(766, 12);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(92, 43);
            this.cmdNuevo.TabIndex = 22;
            this.cmdNuevo.Text = "Nuevo";
            this.cmdNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdNuevo.UseVisualStyleBackColor = false;
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
            // 
            // frmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 698);
            this.Controls.Add(this.cmdCargar);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdNuevo);
            this.Controls.Add(this.chkFinalizados);
            this.Controls.Add(this.cmdEliminarTodos);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ucbNiveles);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmCursos";
            this.Text = "Cursos";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCursos_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucbNiveles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivelesacademicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsCursos_ dsCursos_1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_nivel1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_instructor;
        private DevExpress.XtraGrid.Columns.GridColumn colnombres;
        private DevExpress.XtraGrid.Columns.GridColumn colseccion;
        private DevExpress.XtraGrid.Columns.GridColumn colhora_inicio;
        private DevExpress.XtraGrid.Columns.GridColumn colhora_fin;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_posteo;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_inicio;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_fin;
        private DevExpress.XtraGrid.Columns.GridColumn colcurso_finalizado;
        private DevExpress.XtraGrid.Columns.GridColumn colEditar;
        private DevExpress.XtraGrid.Columns.GridColumn colEliminar;
        private DevExpress.XtraEditors.GridLookUpEdit ucbNiveles;
        private System.Windows.Forms.BindingSource nivelesacademicosBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colid_nivel;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button cmdEliminarTodos;
        private System.Windows.Forms.CheckBox chkFinalizados;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdNuevo;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryEditar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryEliminar;
    }
}