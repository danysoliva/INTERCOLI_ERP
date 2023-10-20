
namespace ERP_INTECOLI.Usuarios
{
    partial class frmMantenimientoUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoUsuarios));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grdUsuario = new DevExpress.XtraGrid.GridControl();
            this.dsUsuarios1 = new ERP_INTECOLI.Usuarios.dsUsuarios();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_usuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colalias = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhabilitado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colapellidos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsuper_user = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltiempo_inactividad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colutiliza_bloqueo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_db = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ButtonEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.ButtonFunciones = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cmdNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUsuarios1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonFunciones)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(348, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(237, 25);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Mantenimiento de Usuarios";
            // 
            // grdUsuario
            // 
            this.grdUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdUsuario.DataMember = "Usuarios";
            this.grdUsuario.DataSource = this.dsUsuarios1;
            this.grdUsuario.Location = new System.Drawing.Point(4, 70);
            this.grdUsuario.MainView = this.gridView1;
            this.grdUsuario.Name = "grdUsuario";
            this.grdUsuario.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ButtonEditar,
            this.ButtonFunciones});
            this.grdUsuario.Size = new System.Drawing.Size(1031, 548);
            this.grdUsuario.TabIndex = 8;
            this.grdUsuario.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsUsuarios1
            // 
            this.dsUsuarios1.DataSetName = "dsUsuarios";
            this.dsUsuarios1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_usuario,
            this.colalias,
            this.colpassword,
            this.colhabilitado,
            this.colnombre,
            this.colapellidos,
            this.colsuper_user,
            this.coltiempo_inactividad,
            this.colutiliza_bloqueo,
            this.coluser_db,
            this.gridColumn1});
            this.gridView1.GridControl = this.grdUsuario;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colid_usuario
            // 
            this.colid_usuario.Caption = "ID";
            this.colid_usuario.FieldName = "id_usuario";
            this.colid_usuario.Name = "colid_usuario";
            this.colid_usuario.OptionsColumn.AllowEdit = false;
            this.colid_usuario.Visible = true;
            this.colid_usuario.VisibleIndex = 0;
            this.colid_usuario.Width = 62;
            // 
            // colalias
            // 
            this.colalias.FieldName = "alias";
            this.colalias.Name = "colalias";
            this.colalias.OptionsColumn.AllowEdit = false;
            this.colalias.Visible = true;
            this.colalias.VisibleIndex = 1;
            this.colalias.Width = 93;
            // 
            // colpassword
            // 
            this.colpassword.FieldName = "password";
            this.colpassword.Name = "colpassword";
            this.colpassword.OptionsColumn.AllowEdit = false;
            this.colpassword.Visible = true;
            this.colpassword.VisibleIndex = 2;
            this.colpassword.Width = 102;
            // 
            // colhabilitado
            // 
            this.colhabilitado.FieldName = "habilitado";
            this.colhabilitado.Name = "colhabilitado";
            this.colhabilitado.OptionsColumn.AllowEdit = false;
            this.colhabilitado.Visible = true;
            this.colhabilitado.VisibleIndex = 3;
            this.colhabilitado.Width = 108;
            // 
            // colnombre
            // 
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.AllowEdit = false;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 4;
            this.colnombre.Width = 87;
            // 
            // colapellidos
            // 
            this.colapellidos.FieldName = "apellidos";
            this.colapellidos.Name = "colapellidos";
            this.colapellidos.OptionsColumn.AllowEdit = false;
            this.colapellidos.Visible = true;
            this.colapellidos.VisibleIndex = 5;
            this.colapellidos.Width = 100;
            // 
            // colsuper_user
            // 
            this.colsuper_user.FieldName = "super_user";
            this.colsuper_user.Name = "colsuper_user";
            this.colsuper_user.OptionsColumn.AllowEdit = false;
            this.colsuper_user.Visible = true;
            this.colsuper_user.VisibleIndex = 6;
            this.colsuper_user.Width = 104;
            // 
            // coltiempo_inactividad
            // 
            this.coltiempo_inactividad.FieldName = "tiempo_inactividad";
            this.coltiempo_inactividad.Name = "coltiempo_inactividad";
            this.coltiempo_inactividad.OptionsColumn.AllowEdit = false;
            this.coltiempo_inactividad.Visible = true;
            this.coltiempo_inactividad.VisibleIndex = 7;
            this.coltiempo_inactividad.Width = 109;
            // 
            // colutiliza_bloqueo
            // 
            this.colutiliza_bloqueo.FieldName = "utiliza_bloqueo";
            this.colutiliza_bloqueo.Name = "colutiliza_bloqueo";
            this.colutiliza_bloqueo.OptionsColumn.AllowEdit = false;
            this.colutiliza_bloqueo.Visible = true;
            this.colutiliza_bloqueo.VisibleIndex = 8;
            this.colutiliza_bloqueo.Width = 69;
            // 
            // coluser_db
            // 
            this.coluser_db.FieldName = "user_db";
            this.coluser_db.Name = "coluser_db";
            this.coluser_db.OptionsColumn.AllowEdit = false;
            this.coluser_db.Visible = true;
            this.coluser_db.VisibleIndex = 9;
            this.coluser_db.Width = 85;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Editar";
            this.gridColumn1.ColumnEdit = this.ButtonEditar;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 10;
            this.gridColumn1.Width = 87;
            // 
            // ButtonEditar
            // 
            this.ButtonEditar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.ButtonEditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.ButtonEditar.Name = "ButtonEditar";
            this.ButtonEditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.ButtonEditar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ButtonEditar_ButtonClick);
            // 
            // ButtonFunciones
            // 
            this.ButtonFunciones.AutoHeight = false;
            this.ButtonFunciones.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.ButtonFunciones.Name = "ButtonFunciones";
            this.ButtonFunciones.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.BackColor = System.Drawing.Color.LightBlue;
            this.cmdNuevo.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.cmdNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNuevo.Image = global::ERP_INTECOLI.Properties.Resources.anadir;
            this.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdNuevo.Location = new System.Drawing.Point(22, 5);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(109, 44);
            this.cmdNuevo.TabIndex = 14;
            this.cmdNuevo.Text = "Guardar";
            this.cmdNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdNuevo.UseVisualStyleBackColor = false;
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
            // 
            // frmMantenimientoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 619);
            this.Controls.Add(this.cmdNuevo);
            this.Controls.Add(this.grdUsuario);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmMantenimientoUsuarios";
            this.Text = "Mantenimiento de Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUsuarios1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonFunciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl grdUsuario;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ButtonEditar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ButtonFunciones;
        private System.Windows.Forms.Button cmdNuevo;
        private dsUsuarios dsUsuarios1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_usuario;
        private DevExpress.XtraGrid.Columns.GridColumn colalias;
        private DevExpress.XtraGrid.Columns.GridColumn colpassword;
        private DevExpress.XtraGrid.Columns.GridColumn colhabilitado;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colapellidos;
        private DevExpress.XtraGrid.Columns.GridColumn colsuper_user;
        private DevExpress.XtraGrid.Columns.GridColumn coltiempo_inactividad;
        private DevExpress.XtraGrid.Columns.GridColumn colutiliza_bloqueo;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_db;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}