
namespace ERP_INTECOLI.Mantenimiento.Productos
{
    partial class frmItemsCRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemsCRUD));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions4 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject13 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject14 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject15 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject16 = new DevExpress.Utils.SerializableAppearanceObject();
            this.grdProductos = new DevExpress.XtraGrid.GridControl();
            this.dsMantenimiento1 = new ERP_INTECOLI.Mantenimiento.Productos.dsMantenimiento();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhabilitado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ButtonEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ButtoPermisos = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tsHabilitados = new DevExpress.XtraEditors.ToggleSwitch();
            this.cmdNuevo = new System.Windows.Forms.Button();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimiento1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtoPermisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsHabilitados.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdProductos
            // 
            this.grdProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdProductos.DataMember = "Producto";
            this.grdProductos.DataSource = this.dsMantenimiento1;
            this.grdProductos.Location = new System.Drawing.Point(3, 60);
            this.grdProductos.MainView = this.gridView1;
            this.grdProductos.Name = "grdProductos";
            this.grdProductos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ButtonEditar,
            this.ButtoPermisos});
            this.grdProductos.Size = new System.Drawing.Size(903, 491);
            this.grdProductos.TabIndex = 17;
            this.grdProductos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.colid,
            this.colnombre,
            this.coldireccion,
            this.coltelefono,
            this.colhabilitado,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView1.GridControl = this.grdProductos;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.ReadOnly = true;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "ItemCode";
            this.colnombre.FieldName = "code";
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.ReadOnly = true;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 0;
            this.colnombre.Width = 95;
            // 
            // coldireccion
            // 
            this.coldireccion.Caption = "Descripcion";
            this.coldireccion.FieldName = "descripcion";
            this.coldireccion.Name = "coldireccion";
            this.coldireccion.OptionsColumn.ReadOnly = true;
            this.coldireccion.Visible = true;
            this.coldireccion.VisibleIndex = 1;
            this.coldireccion.Width = 231;
            // 
            // coltelefono
            // 
            this.coltelefono.Caption = "Fecha";
            this.coltelefono.FieldName = "fecha";
            this.coltelefono.Name = "coltelefono";
            this.coltelefono.OptionsColumn.ReadOnly = true;
            this.coltelefono.Visible = true;
            this.coltelefono.VisibleIndex = 3;
            this.coltelefono.Width = 84;
            // 
            // colhabilitado
            // 
            this.colhabilitado.FieldName = "habilitado";
            this.colhabilitado.Name = "colhabilitado";
            this.colhabilitado.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Editar";
            this.gridColumn1.ColumnEdit = this.ButtonEditar;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
            this.gridColumn1.Width = 117;
            // 
            // ButtonEditar
            // 
            this.ButtonEditar.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.ButtonEditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.ButtonEditar.Name = "ButtonEditar";
            this.ButtonEditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.ButtonEditar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ButtonEditar_ButtonClick);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Estado";
            this.gridColumn2.FieldName = "estado";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            this.gridColumn2.Width = 90;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Usuario Creador";
            this.gridColumn3.FieldName = "nombre";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 5;
            this.gridColumn3.Width = 94;
            // 
            // ButtoPermisos
            // 
            this.ButtoPermisos.AutoHeight = false;
            editorButtonImageOptions4.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions4.Image")));
            this.ButtoPermisos.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions4, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject13, serializableAppearanceObject14, serializableAppearanceObject15, serializableAppearanceObject16, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.ButtoPermisos.Name = "ButtoPermisos";
            this.ButtoPermisos.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(355, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(144, 25);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "Gestion de Items";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(541, 36);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 17);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Habilitados";
            // 
            // tsHabilitados
            // 
            this.tsHabilitados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tsHabilitados.EditValue = true;
            this.tsHabilitados.Location = new System.Drawing.Point(630, 34);
            this.tsHabilitados.Name = "tsHabilitados";
            this.tsHabilitados.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsHabilitados.Properties.Appearance.Options.UseFont = true;
            this.tsHabilitados.Properties.OffText = "No";
            this.tsHabilitados.Properties.OnText = "Si";
            this.tsHabilitados.Size = new System.Drawing.Size(113, 20);
            this.tsHabilitados.TabIndex = 20;
            this.tsHabilitados.Toggled += new System.EventHandler(this.tsHabilitados_Toggled);
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.BackColor = System.Drawing.Color.LightBlue;
            this.cmdNuevo.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.cmdNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNuevo.Image = global::ERP_INTECOLI.Properties.Resources.anadir;
            this.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdNuevo.Location = new System.Drawing.Point(34, 5);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(97, 44);
            this.cmdNuevo.TabIndex = 22;
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
            this.btnCancel.Location = new System.Drawing.Point(799, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 44);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cerrar";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Tipo Producto";
            this.gridColumn4.FieldName = "tipo_pt";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 139;
            // 
            // frmItemsCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 553);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cmdNuevo);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.tsHabilitados);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.grdProductos);
            this.IconOptions.ShowIcon = false;
            this.Name = "frmItemsCRUD";
            ((System.ComponentModel.ISupportInitialize)(this.grdProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimiento1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtoPermisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsHabilitados.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdProductos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn coldireccion;
        private DevExpress.XtraGrid.Columns.GridColumn coltelefono;
        private DevExpress.XtraGrid.Columns.GridColumn colhabilitado;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ButtonEditar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ButtoPermisos;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ToggleSwitch tsHabilitados;
        private System.Windows.Forms.Button cmdNuevo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private dsMantenimiento dsMantenimiento1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}