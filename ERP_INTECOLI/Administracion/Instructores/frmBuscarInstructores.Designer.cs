
namespace ERP_INTECOLI.Administracion.Instructores
{
    partial class frmBuscarInstructores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarInstructores));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.cmdNuevo = new System.Windows.Forms.Button();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.grdInstructores = new DevExpress.XtraGrid.GridControl();
            this.dsInstructores1 = new ERP_INTECOLI.Administracion.Instructores.dsInstructores();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_instructor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero_cedula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colapellidos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsexo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhabilitado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_ingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_usuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconcatenacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coleditar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repost_edit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.txtParametro = new DevExpress.XtraEditors.TextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tsHabilitados = new DevExpress.XtraEditors.ToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.grdInstructores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInstructores1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repost_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParametro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tsHabilitados.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.BackColor = System.Drawing.Color.PaleGreen;
            this.cmdNuevo.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.cmdNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNuevo.Image = global::ERP_INTECOLI.Properties.Resources.anadir;
            this.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdNuevo.Location = new System.Drawing.Point(455, 22);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(169, 43);
            this.cmdNuevo.TabIndex = 13;
            this.cmdNuevo.Text = "Agregar Instructor";
            this.cmdNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdNuevo.UseVisualStyleBackColor = false;
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel1.Location = new System.Drawing.Point(5, 37);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(147, 18);
            this.ultraLabel1.TabIndex = 11;
            this.ultraLabel1.Text = "Buscar por Nombre:";
            // 
            // grdInstructores
            // 
            this.grdInstructores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdInstructores.DataMember = "Instructores_Datos";
            this.grdInstructores.DataSource = this.dsInstructores1;
            this.grdInstructores.Location = new System.Drawing.Point(3, 88);
            this.grdInstructores.MainView = this.gridView1;
            this.grdInstructores.Name = "grdInstructores";
            this.grdInstructores.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repost_edit});
            this.grdInstructores.Size = new System.Drawing.Size(942, 435);
            this.grdInstructores.TabIndex = 14;
            this.grdInstructores.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsInstructores1
            // 
            this.dsInstructores1.DataSetName = "dsInstructores";
            this.dsInstructores1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_instructor,
            this.colnumero_cedula,
            this.colnombres,
            this.colapellidos,
            this.colsexo,
            this.coldireccion,
            this.colhabilitado,
            this.colfecha_ingreso,
            this.colid_usuario,
            this.colconcatenacion,
            this.coleditar});
            this.gridView1.GridControl = this.grdInstructores;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid_instructor
            // 
            this.colid_instructor.FieldName = "id_instructor";
            this.colid_instructor.Name = "colid_instructor";
            this.colid_instructor.OptionsColumn.ReadOnly = true;
            // 
            // colnumero_cedula
            // 
            this.colnumero_cedula.Caption = "Num. Cedula";
            this.colnumero_cedula.FieldName = "numero_cedula";
            this.colnumero_cedula.Name = "colnumero_cedula";
            this.colnumero_cedula.OptionsColumn.ReadOnly = true;
            this.colnumero_cedula.Visible = true;
            this.colnumero_cedula.VisibleIndex = 0;
            // 
            // colnombres
            // 
            this.colnombres.Caption = "Nombres";
            this.colnombres.FieldName = "nombres";
            this.colnombres.Name = "colnombres";
            this.colnombres.OptionsColumn.ReadOnly = true;
            this.colnombres.Visible = true;
            this.colnombres.VisibleIndex = 1;
            // 
            // colapellidos
            // 
            this.colapellidos.Caption = "Apellidos";
            this.colapellidos.FieldName = "apellidos";
            this.colapellidos.Name = "colapellidos";
            this.colapellidos.OptionsColumn.ReadOnly = true;
            this.colapellidos.Visible = true;
            this.colapellidos.VisibleIndex = 2;
            // 
            // colsexo
            // 
            this.colsexo.Caption = "Sexo";
            this.colsexo.FieldName = "sexo";
            this.colsexo.Name = "colsexo";
            this.colsexo.OptionsColumn.ReadOnly = true;
            this.colsexo.Visible = true;
            this.colsexo.VisibleIndex = 3;
            // 
            // coldireccion
            // 
            this.coldireccion.Caption = "Direccion";
            this.coldireccion.FieldName = "direccion";
            this.coldireccion.Name = "coldireccion";
            this.coldireccion.OptionsColumn.ReadOnly = true;
            this.coldireccion.Visible = true;
            this.coldireccion.VisibleIndex = 4;
            // 
            // colhabilitado
            // 
            this.colhabilitado.Caption = "Habilitado";
            this.colhabilitado.FieldName = "habilitado";
            this.colhabilitado.Name = "colhabilitado";
            this.colhabilitado.OptionsColumn.ReadOnly = true;
            this.colhabilitado.Visible = true;
            this.colhabilitado.VisibleIndex = 5;
            // 
            // colfecha_ingreso
            // 
            this.colfecha_ingreso.Caption = "Fecha Ingreso";
            this.colfecha_ingreso.FieldName = "fecha_ingreso";
            this.colfecha_ingreso.Name = "colfecha_ingreso";
            this.colfecha_ingreso.OptionsColumn.ReadOnly = true;
            this.colfecha_ingreso.Visible = true;
            this.colfecha_ingreso.VisibleIndex = 6;
            // 
            // colid_usuario
            // 
            this.colid_usuario.FieldName = "id_usuario";
            this.colid_usuario.Name = "colid_usuario";
            this.colid_usuario.OptionsColumn.ReadOnly = true;
            // 
            // colconcatenacion
            // 
            this.colconcatenacion.FieldName = "concatenacion";
            this.colconcatenacion.Name = "colconcatenacion";
            this.colconcatenacion.OptionsColumn.ReadOnly = true;
            // 
            // coleditar
            // 
            this.coleditar.Caption = "Editar";
            this.coleditar.ColumnEdit = this.repost_edit;
            this.coleditar.FieldName = "editar";
            this.coleditar.Name = "coleditar";
            this.coleditar.Visible = true;
            this.coleditar.VisibleIndex = 7;
            // 
            // repost_edit
            // 
            this.repost_edit.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.repost_edit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repost_edit.Name = "repost_edit";
            this.repost_edit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repost_edit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repost_edit_ButtonClick);
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
            this.cmdCancelar.Location = new System.Drawing.Point(823, 22);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(110, 43);
            this.cmdCancelar.TabIndex = 43;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdCancelar.UseVisualStyleBackColor = false;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // txtParametro
            // 
            this.txtParametro.Location = new System.Drawing.Point(145, 31);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtParametro.Properties.Appearance.Options.UseFont = true;
            this.txtParametro.Size = new System.Drawing.Size(286, 24);
            this.txtParametro.TabIndex = 44;
            this.txtParametro.EditValueChanged += new System.EventHandler(this.txtParametro_EditValueChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.tsHabilitados);
            this.panelControl1.Controls.Add(this.cmdNuevo);
            this.panelControl1.Controls.Add(this.txtParametro);
            this.panelControl1.Controls.Add(this.ultraLabel1);
            this.panelControl1.Controls.Add(this.cmdCancelar);
            this.panelControl1.Location = new System.Drawing.Point(3, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(942, 82);
            this.panelControl1.TabIndex = 45;
            // 
            // tsHabilitados
            // 
            this.tsHabilitados.EditValue = true;
            this.tsHabilitados.Location = new System.Drawing.Point(651, 37);
            this.tsHabilitados.Name = "tsHabilitados";
            this.tsHabilitados.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tsHabilitados.Properties.Appearance.Options.UseFont = true;
            this.tsHabilitados.Properties.OffText = "Deshabilitados";
            this.tsHabilitados.Properties.OnText = "Habilitados";
            this.tsHabilitados.Size = new System.Drawing.Size(154, 20);
            this.tsHabilitados.TabIndex = 45;
            this.tsHabilitados.Toggled += new System.EventHandler(this.tsHabilitados_Toggled);
            // 
            // frmBuscarInstructores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 525);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.grdInstructores);
            this.MaximizeBox = false;
            this.Name = "frmBuscarInstructores";
            this.Text = "Buscar Instructores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grdInstructores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInstructores1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repost_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParametro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tsHabilitados.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdNuevo;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private DevExpress.XtraGrid.GridControl grdInstructores;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsInstructores dsInstructores1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_instructor;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_cedula;
        private DevExpress.XtraGrid.Columns.GridColumn colnombres;
        private DevExpress.XtraGrid.Columns.GridColumn colapellidos;
        private DevExpress.XtraGrid.Columns.GridColumn colsexo;
        private DevExpress.XtraGrid.Columns.GridColumn coldireccion;
        private DevExpress.XtraGrid.Columns.GridColumn colhabilitado;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_ingreso;
        private DevExpress.XtraGrid.Columns.GridColumn colid_usuario;
        private DevExpress.XtraGrid.Columns.GridColumn colconcatenacion;
        private DevExpress.XtraGrid.Columns.GridColumn coleditar;
        private System.Windows.Forms.Button cmdCancelar;
        private DevExpress.XtraEditors.TextEdit txtParametro;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.ToggleSwitch tsHabilitados;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repost_edit;
    }
}