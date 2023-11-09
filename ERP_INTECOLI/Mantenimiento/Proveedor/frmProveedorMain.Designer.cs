
namespace ERP_INTECOLI.Mantenimiento.Proveedor
{
    partial class frmProveedorMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedorMain));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tsHabilitados = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grdUsuario = new DevExpress.XtraGrid.GridControl();
            this.dsMantenimiento1 = new ERP_INTECOLI.Mantenimiento.Productos.dsMantenimiento();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_prov = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRTN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcreado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario_modificacion_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmodificado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ButtonEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.ButtoPermisos = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cmdNuevo = new System.Windows.Forms.Button();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tsHabilitados.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimiento1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtoPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(869, 31);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 17);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "Habilitados";
            // 
            // tsHabilitados
            // 
            this.tsHabilitados.EditValue = true;
            this.tsHabilitados.Location = new System.Drawing.Point(941, 28);
            this.tsHabilitados.Name = "tsHabilitados";
            this.tsHabilitados.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsHabilitados.Properties.Appearance.Options.UseFont = true;
            this.tsHabilitados.Properties.OffText = "No";
            this.tsHabilitados.Properties.OnText = "Si";
            this.tsHabilitados.Size = new System.Drawing.Size(113, 20);
            this.tsHabilitados.TabIndex = 23;
            this.tsHabilitados.Toggled += new System.EventHandler(this.tsHabilitados_Toggled);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(505, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(202, 25);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "Gestion de Proveedores";
            // 
            // grdUsuario
            // 
            this.grdUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdUsuario.DataMember = "Proveedor";
            this.grdUsuario.DataSource = this.dsMantenimiento1;
            this.grdUsuario.Location = new System.Drawing.Point(3, 61);
            this.grdUsuario.MainView = this.gridView1;
            this.grdUsuario.Name = "grdUsuario";
            this.grdUsuario.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ButtonEditar,
            this.ButtoPermisos});
            this.grdUsuario.Size = new System.Drawing.Size(1255, 573);
            this.grdUsuario.TabIndex = 21;
            this.grdUsuario.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsMantenimiento1
            // 
            this.dsMantenimiento1.DataSetName = "dsMantenimiento";
            this.dsMantenimiento1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_prov,
            this.colcodigo,
            this.colnombre,
            this.colRTN,
            this.coldireccion,
            this.colFechaCreacion,
            this.colusuario_id,
            this.colcreado,
            this.colusuario_modificacion_id,
            this.colmodificado,
            this.colFechaModificacion,
            this.gridColumn1});
            this.gridView1.GridControl = this.grdUsuario;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid_prov
            // 
            this.colid_prov.FieldName = "id_prov";
            this.colid_prov.Name = "colid_prov";
            this.colid_prov.OptionsColumn.AllowEdit = false;
            this.colid_prov.Width = 83;
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "Codigo";
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.OptionsColumn.AllowEdit = false;
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 0;
            this.colcodigo.Width = 77;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.AllowEdit = false;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            this.colnombre.Width = 138;
            // 
            // colRTN
            // 
            this.colRTN.Caption = "RTN";
            this.colRTN.FieldName = "RTN";
            this.colRTN.Name = "colRTN";
            this.colRTN.OptionsColumn.AllowEdit = false;
            this.colRTN.Visible = true;
            this.colRTN.VisibleIndex = 2;
            this.colRTN.Width = 110;
            // 
            // coldireccion
            // 
            this.coldireccion.Caption = "Direccion";
            this.coldireccion.FieldName = "direccion";
            this.coldireccion.Name = "coldireccion";
            this.coldireccion.OptionsColumn.AllowEdit = false;
            this.coldireccion.Visible = true;
            this.coldireccion.VisibleIndex = 3;
            this.coldireccion.Width = 182;
            // 
            // colFechaCreacion
            // 
            this.colFechaCreacion.FieldName = "FechaCreacion";
            this.colFechaCreacion.Name = "colFechaCreacion";
            this.colFechaCreacion.OptionsColumn.AllowEdit = false;
            this.colFechaCreacion.Visible = true;
            this.colFechaCreacion.VisibleIndex = 4;
            this.colFechaCreacion.Width = 119;
            // 
            // colusuario_id
            // 
            this.colusuario_id.FieldName = "usuario_id";
            this.colusuario_id.Name = "colusuario_id";
            this.colusuario_id.OptionsColumn.AllowEdit = false;
            this.colusuario_id.Width = 83;
            // 
            // colcreado
            // 
            this.colcreado.Caption = "Creador por:";
            this.colcreado.FieldName = "creado";
            this.colcreado.Name = "colcreado";
            this.colcreado.OptionsColumn.AllowEdit = false;
            this.colcreado.Visible = true;
            this.colcreado.VisibleIndex = 5;
            this.colcreado.Width = 118;
            // 
            // colusuario_modificacion_id
            // 
            this.colusuario_modificacion_id.FieldName = "usuario_modificacion_id";
            this.colusuario_modificacion_id.Name = "colusuario_modificacion_id";
            this.colusuario_modificacion_id.OptionsColumn.AllowEdit = false;
            this.colusuario_modificacion_id.Width = 83;
            // 
            // colmodificado
            // 
            this.colmodificado.Caption = "Modificado por:";
            this.colmodificado.FieldName = "modificado";
            this.colmodificado.Name = "colmodificado";
            this.colmodificado.OptionsColumn.AllowEdit = false;
            this.colmodificado.Visible = true;
            this.colmodificado.VisibleIndex = 6;
            this.colmodificado.Width = 138;
            // 
            // colFechaModificacion
            // 
            this.colFechaModificacion.Caption = "F. Modificacion";
            this.colFechaModificacion.FieldName = "FechaModificacion";
            this.colFechaModificacion.Name = "colFechaModificacion";
            this.colFechaModificacion.OptionsColumn.AllowEdit = false;
            this.colFechaModificacion.Visible = true;
            this.colFechaModificacion.VisibleIndex = 7;
            this.colFechaModificacion.Width = 142;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Editar";
            this.gridColumn1.ColumnEdit = this.ButtonEditar;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 8;
            this.gridColumn1.Width = 103;
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
            // ButtoPermisos
            // 
            this.ButtoPermisos.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.ButtoPermisos.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.ButtoPermisos.Name = "ButtoPermisos";
            this.ButtoPermisos.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.BackColor = System.Drawing.Color.LightBlue;
            this.cmdNuevo.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.cmdNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNuevo.Image = global::ERP_INTECOLI.Properties.Resources.anadir;
            this.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdNuevo.Location = new System.Drawing.Point(30, 4);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(97, 44);
            this.cmdNuevo.TabIndex = 20;
            this.cmdNuevo.Text = "Crear";
            this.cmdNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdNuevo.UseVisualStyleBackColor = false;
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancel.ImageOptions.SvgImage")));
            this.btnCancel.Location = new System.Drawing.Point(1129, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 44);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cerrar";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmProveedorMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 639);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.tsHabilitados);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.grdUsuario);
            this.Controls.Add(this.cmdNuevo);
            this.Name = "frmProveedorMain";
            ((System.ComponentModel.ISupportInitialize)(this.tsHabilitados.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimiento1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtoPermisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ToggleSwitch tsHabilitados;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl grdUsuario;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ButtonEditar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ButtoPermisos;
        private System.Windows.Forms.Button cmdNuevo;
        private Productos.dsMantenimiento dsMantenimiento1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_prov;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colRTN;
        private DevExpress.XtraGrid.Columns.GridColumn coldireccion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaCreacion;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario_id;
        private DevExpress.XtraGrid.Columns.GridColumn colcreado;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario_modificacion_id;
        private DevExpress.XtraGrid.Columns.GridColumn colmodificado;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaModificacion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}