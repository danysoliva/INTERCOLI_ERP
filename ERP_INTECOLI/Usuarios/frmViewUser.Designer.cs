
namespace ERP_INTECOLI.Usuarios
{
    partial class frmViewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewUser));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.cmdAdd = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_ventana = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhabilitada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_vinculo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Eliminar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button_eliminar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.ButtonEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.ButtonFunciones = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.button_funciones = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombreUsuario = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.txtUsuarioAD = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dsUsuarios1 = new ERP_INTECOLI.Usuarios.dsUsuarios();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_eliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonFunciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_funciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuarioAD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUsuarios1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdAdd
            // 
            this.cmdAdd.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.cmdAdd.Appearance.Options.UseBackColor = true;
            this.cmdAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdAdd.ImageOptions.Image")));
            this.cmdAdd.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdAdd.Location = new System.Drawing.Point(12, 1);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(47, 41);
            this.cmdAdd.TabIndex = 13;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "view_user";
            this.gridControl1.DataSource = this.dsUsuarios1;
            this.gridControl1.Location = new System.Drawing.Point(2, 117);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ButtonEditar,
            this.ButtonFunciones,
            this.button_funciones,
            this.button_eliminar});
            this.gridControl1.Size = new System.Drawing.Size(829, 364);
            this.gridControl1.TabIndex = 14;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_ventana,
            this.colnombre,
            this.colcodigo,
            this.coldescripcion,
            this.colhabilitada,
            this.colfecha_vinculo,
            this.Eliminar});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid_ventana
            // 
            this.colid_ventana.Caption = "ID Ventana";
            this.colid_ventana.FieldName = "id_ventana";
            this.colid_ventana.MinWidth = 15;
            this.colid_ventana.Name = "colid_ventana";
            this.colid_ventana.OptionsColumn.AllowEdit = false;
            this.colid_ventana.Visible = true;
            this.colid_ventana.VisibleIndex = 0;
            this.colid_ventana.Width = 78;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre";
            this.colnombre.FieldName = "nombre";
            this.colnombre.MinWidth = 15;
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.AllowEdit = false;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            this.colnombre.Width = 191;
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "Codigo";
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.MinWidth = 15;
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.OptionsColumn.AllowEdit = false;
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 2;
            this.colcodigo.Width = 112;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripcion";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.MinWidth = 15;
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.AllowEdit = false;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 3;
            this.coldescripcion.Width = 174;
            // 
            // colhabilitada
            // 
            this.colhabilitada.Caption = "Habilitada";
            this.colhabilitada.FieldName = "habilitada";
            this.colhabilitada.MinWidth = 15;
            this.colhabilitada.Name = "colhabilitada";
            this.colhabilitada.OptionsColumn.AllowEdit = false;
            this.colhabilitada.Visible = true;
            this.colhabilitada.VisibleIndex = 4;
            this.colhabilitada.Width = 56;
            // 
            // colfecha_vinculo
            // 
            this.colfecha_vinculo.Caption = "Fecha Creado";
            this.colfecha_vinculo.FieldName = "fecha_vinculo";
            this.colfecha_vinculo.MinWidth = 15;
            this.colfecha_vinculo.Name = "colfecha_vinculo";
            this.colfecha_vinculo.OptionsColumn.AllowEdit = false;
            this.colfecha_vinculo.Visible = true;
            this.colfecha_vinculo.VisibleIndex = 5;
            this.colfecha_vinculo.Width = 90;
            // 
            // Eliminar
            // 
            this.Eliminar.Caption = "Quitar Acceso";
            this.Eliminar.ColumnEdit = this.button_eliminar;
            this.Eliminar.MinWidth = 15;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Visible = true;
            this.Eliminar.VisibleIndex = 6;
            this.Eliminar.Width = 103;
            // 
            // button_eliminar
            // 
            this.button_eliminar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.button_eliminar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.button_eliminar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.button_eliminar_ButtonClick);
            // 
            // ButtonEditar
            // 
            this.ButtonEditar.AutoHeight = false;
            this.ButtonEditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.ButtonEditar.Name = "ButtonEditar";
            this.ButtonEditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // ButtonFunciones
            // 
            this.ButtonFunciones.AutoHeight = false;
            this.ButtonFunciones.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.ButtonFunciones.Name = "ButtonFunciones";
            this.ButtonFunciones.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // button_funciones
            // 
            this.button_funciones.AutoHeight = false;
            this.button_funciones.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.button_funciones.Name = "button_funciones";
            this.button_funciones.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Enabled = false;
            this.labelControl1.Location = new System.Drawing.Point(36, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 17);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Nombre";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Enabled = false;
            this.txtNombreUsuario.Location = new System.Drawing.Point(100, 46);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombreUsuario.Properties.Appearance.Options.UseFont = true;
            this.txtNombreUsuario.Size = new System.Drawing.Size(202, 24);
            this.txtNombreUsuario.TabIndex = 15;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(305, 1);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(175, 30);
            this.labelControl4.TabIndex = 17;
            this.labelControl4.Text = "Detalles de Acceso";
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Enabled = false;
            this.chkActivo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkActivo.Location = new System.Drawing.Point(704, 45);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(117, 23);
            this.chkActivo.TabIndex = 21;
            this.chkActivo.Text = "Usuario Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // txtUsuarioAD
            // 
            this.txtUsuarioAD.Enabled = false;
            this.txtUsuarioAD.Location = new System.Drawing.Point(619, 80);
            this.txtUsuarioAD.Name = "txtUsuarioAD";
            this.txtUsuarioAD.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsuarioAD.Properties.Appearance.Options.UseFont = true;
            this.txtUsuarioAD.Size = new System.Drawing.Size(202, 24);
            this.txtUsuarioAD.TabIndex = 20;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Enabled = false;
            this.labelControl2.Location = new System.Drawing.Point(601, 49);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(12, 17);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(619, 46);
            this.txtId.Name = "txtId";
            this.txtId.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtId.Properties.Appearance.Options.UseFont = true;
            this.txtId.Size = new System.Drawing.Size(67, 24);
            this.txtId.TabIndex = 18;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Enabled = false;
            this.labelControl3.Location = new System.Drawing.Point(546, 83);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 17);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "Usuario AD";
            // 
            // dsUsuarios1
            // 
            this.dsUsuarios1.DataSetName = "dsUsuarios";
            this.dsUsuarios1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmViewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 484);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.txtUsuarioAD);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.cmdAdd);
            this.Name = "frmViewUser";
            this.Text = "Accesos de Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_eliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonFunciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_funciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuarioAD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUsuarios1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdAdd;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_ventana;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colhabilitada;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_vinculo;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit button_funciones;
        private DevExpress.XtraGrid.Columns.GridColumn Eliminar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit button_eliminar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ButtonEditar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ButtonFunciones;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtNombreUsuario;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.CheckBox chkActivo;
        private DevExpress.XtraEditors.TextEdit txtUsuarioAD;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private dsUsuarios dsUsuarios1;
    }
}