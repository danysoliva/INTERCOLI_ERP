
namespace ERP_INTECOLI.Accesos.AccesosUsuarios
{
    partial class xfrmAccesosTemporalesCRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmAccesosTemporalesCRUD));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.lueUsuario = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource();
            this.dsAccesosBindingSource = new System.Windows.Forms.BindingSource();
            this.dsAccesos = new ERP_INTECOLI.Accesos.dsAccesos();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ventanaBindingSource = new System.Windows.Forms.BindingSource();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gvVentana = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_ventana = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueVentana = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.ventanaBindingSource1 = new System.Windows.Forms.BindingSource();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cmdCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdNew = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.lueUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAccesosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAccesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventanaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventanaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // lueUsuario
            // 
            this.lueUsuario.Location = new System.Drawing.Point(110, 40);
            this.lueUsuario.Name = "lueUsuario";
            this.lueUsuario.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueUsuario.Properties.Appearance.Options.UseFont = true;
            this.lueUsuario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueUsuario.Properties.DataSource = this.usuariosBindingSource;
            this.lueUsuario.Properties.DisplayMember = "nombre";
            this.lueUsuario.Properties.PopupView = this.searchLookUpEdit1View;
            this.lueUsuario.Properties.ValueMember = "id";
            this.lueUsuario.Size = new System.Drawing.Size(406, 32);
            this.lueUsuario.TabIndex = 0;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.dsAccesosBindingSource;
            // 
            // dsAccesosBindingSource
            // 
            this.dsAccesosBindingSource.DataSource = this.dsAccesos;
            this.dsAccesosBindingSource.Position = 0;
            // 
            // dsAccesos
            // 
            this.dsAccesos.DataSetName = "dsAccesos";
            this.dsAccesos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // ventanaBindingSource
            // 
            this.ventanaBindingSource.DataMember = "Ventana";
            this.ventanaBindingSource.DataSource = this.dsAccesos;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(53, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 17);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Usuario:";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "Window";
            this.gridControl1.DataSource = this.dsAccesosBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 90);
            this.gridControl1.MainView = this.gvVentana;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lueVentana,
            this.btnDelete});
            this.gridControl1.Size = new System.Drawing.Size(890, 368);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVentana});
            // 
            // gvVentana
            // 
            this.gvVentana.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvVentana.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvVentana.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvVentana.Appearance.Row.Options.UseFont = true;
            this.gvVentana.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_ventana,
            this.colnombre,
            this.colcodigo,
            this.coldescripcion,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gvVentana.GridControl = this.gridControl1;
            this.gvVentana.Name = "gvVentana";
            this.gvVentana.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvVentana.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gvVentana.OptionsView.ShowGroupPanel = false;
            this.gvVentana.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvVentana_CellValueChanged);
            // 
            // colid_ventana
            // 
            this.colid_ventana.FieldName = "id_ventana";
            this.colid_ventana.Name = "colid_ventana";
            this.colid_ventana.OptionsEditForm.StartNewRow = true;
            this.colid_ventana.Width = 90;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Ventana";
            this.colnombre.ColumnEdit = this.lueVentana;
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 0;
            this.colnombre.Width = 359;
            // 
            // lueVentana
            // 
            this.lueVentana.AppearanceDropDown.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueVentana.AppearanceDropDown.Options.UseFont = true;
            this.lueVentana.AppearanceFocused.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueVentana.AppearanceFocused.Options.UseFont = true;
            this.lueVentana.AutoHeight = false;
            this.lueVentana.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueVentana.DataSource = this.ventanaBindingSource1;
            this.lueVentana.DisplayMember = "nombre";
            this.lueVentana.Name = "lueVentana";
            this.lueVentana.PopupView = this.repositoryItemSearchLookUpEdit1View;
            this.lueVentana.ValueMember = "id_ventana";
            this.lueVentana.EditValueChanged += new System.EventHandler(this.lueVentana_EditValueChanged);
            // 
            // ventanaBindingSource1
            // 
            this.ventanaBindingSource1.DataMember = "Ventana";
            this.ventanaBindingSource1.DataSource = this.dsAccesosBindingSource;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colcodigo
            // 
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            // 
            // coldescripcion
            // 
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Descartar";
            this.gridColumn1.ColumnEdit = this.btnDelete;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            this.gridColumn1.Width = 76;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnDelete_ButtonClick);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Fecha Vinculo";
            this.gridColumn2.DisplayFormat.FormatString = "d";
            this.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn2.FieldName = "fecha_vinculo";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 97;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Fecha Inicio";
            this.gridColumn3.DisplayFormat.FormatString = "d";
            this.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn3.FieldName = "fecha_inicio";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 108;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Fecha Fin";
            this.gridColumn4.DisplayFormat.FormatString = "d";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn4.FieldName = "fecha_fin";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 89;
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "id";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(0, 6);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(890, 25);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Acceso Temporal";
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancelar.Appearance.BackColor = System.Drawing.Color.IndianRed;
            this.cmdCancelar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Appearance.ForeColor = System.Drawing.Color.White;
            this.cmdCancelar.Appearance.Options.UseBackColor = true;
            this.cmdCancelar.Appearance.Options.UseFont = true;
            this.cmdCancelar.Appearance.Options.UseForeColor = true;
            this.cmdCancelar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCancelar.ImageOptions.Image")));
            this.cmdCancelar.Location = new System.Drawing.Point(778, 28);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(103, 43);
            this.cmdCancelar.TabIndex = 14;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdNew
            // 
            this.cmdNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdNew.Appearance.BackColor = System.Drawing.Color.MediumAquamarine;
            this.cmdNew.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNew.Appearance.ForeColor = System.Drawing.Color.White;
            this.cmdNew.Appearance.Options.UseBackColor = true;
            this.cmdNew.Appearance.Options.UseFont = true;
            this.cmdNew.Appearance.Options.UseForeColor = true;
            this.cmdNew.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdNew.ImageOptions.Image")));
            this.cmdNew.Location = new System.Drawing.Point(665, 28);
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(103, 43);
            this.cmdNew.TabIndex = 13;
            this.cmdNew.Text = "Guardar";
            this.cmdNew.Click += new System.EventHandler(this.cmdNew_Click);
            // 
            // xfrmAccesosTemporalesCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 457);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdNew);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lueUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "xfrmAccesosTemporalesCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accesos Temporales";
            this.Load += new System.EventHandler(this.xfrmAccesosTemporalesCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lueUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAccesosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAccesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventanaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventanaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit lueUsuario;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource ventanaBindingSource;
        private dsAccesos dsAccesos;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVentana;
        private DevExpress.XtraGrid.Columns.GridColumn colid_ventana;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit lueVentana;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private System.Windows.Forms.BindingSource dsAccesosBindingSource;
        private System.Windows.Forms.BindingSource ventanaBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton cmdCancelar;
        private DevExpress.XtraEditors.SimpleButton cmdNew;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}