
namespace ERP_INTECOLI.Compras
{
    partial class frmSearchOrdenesC
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchOrdenesC));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.dsCompras1 = new ERP_INTECOLI.Compras.dsCompras();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_solicitud = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_user = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_estado_solicitud = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_registro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_contabilizacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcomentario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposSelected = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.grdSolicitudes = new DevExpress.XtraGrid.GridControl();
            this.grdSucursales = new DevExpress.XtraEditors.GridLookUpEdit();
            this.sucursalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpdv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompras1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSolicitudes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSucursales.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // dsCompras1
            // 
            this.dsCompras1.DataSetName = "dsCompras";
            this.dsCompras1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_solicitud,
            this.colid_user,
            this.colusuario,
            this.colid_estado_solicitud,
            this.colestado,
            this.colfecha_registro,
            this.colfecha_contabilizacion,
            this.colcomentario,
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.grdSolicitudes;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colid_solicitud
            // 
            this.colid_solicitud.Caption = "id";
            this.colid_solicitud.FieldName = "id";
            this.colid_solicitud.Name = "colid_solicitud";
            this.colid_solicitud.OptionsColumn.AllowEdit = false;
            this.colid_solicitud.Width = 84;
            // 
            // colid_user
            // 
            this.colid_user.FieldName = "id_user";
            this.colid_user.Name = "colid_user";
            this.colid_user.OptionsColumn.AllowEdit = false;
            // 
            // colusuario
            // 
            this.colusuario.Caption = "Usuario Creador";
            this.colusuario.FieldName = "usuario";
            this.colusuario.Name = "colusuario";
            this.colusuario.OptionsColumn.AllowEdit = false;
            this.colusuario.Visible = true;
            this.colusuario.VisibleIndex = 1;
            this.colusuario.Width = 177;
            // 
            // colid_estado_solicitud
            // 
            this.colid_estado_solicitud.FieldName = "id_estado_solicitud";
            this.colid_estado_solicitud.Name = "colid_estado_solicitud";
            this.colid_estado_solicitud.OptionsColumn.AllowEdit = false;
            // 
            // colestado
            // 
            this.colestado.Caption = "Estado Solicitud";
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            this.colestado.OptionsColumn.AllowEdit = false;
            this.colestado.Visible = true;
            this.colestado.VisibleIndex = 2;
            this.colestado.Width = 157;
            // 
            // colfecha_registro
            // 
            this.colfecha_registro.FieldName = "fecha_registro";
            this.colfecha_registro.Name = "colfecha_registro";
            this.colfecha_registro.OptionsColumn.AllowEdit = false;
            // 
            // colfecha_contabilizacion
            // 
            this.colfecha_contabilizacion.Caption = "Fecha";
            this.colfecha_contabilizacion.FieldName = "fecha_contabilizacion";
            this.colfecha_contabilizacion.Name = "colfecha_contabilizacion";
            this.colfecha_contabilizacion.OptionsColumn.AllowEdit = false;
            this.colfecha_contabilizacion.Visible = true;
            this.colfecha_contabilizacion.VisibleIndex = 3;
            this.colfecha_contabilizacion.Width = 107;
            // 
            // colcomentario
            // 
            this.colcomentario.Caption = "Comentario";
            this.colcomentario.FieldName = "comentario";
            this.colcomentario.Name = "colcomentario";
            this.colcomentario.OptionsColumn.AllowEdit = false;
            this.colcomentario.Visible = true;
            this.colcomentario.VisibleIndex = 4;
            this.colcomentario.Width = 385;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Seleccionar";
            this.gridColumn1.ColumnEdit = this.reposSelected;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            this.gridColumn1.Width = 128;
            // 
            // reposSelected
            // 
            this.reposSelected.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.reposSelected.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.reposSelected.Name = "reposSelected";
            this.reposSelected.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.reposSelected.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.reposSelected_ButtonClick);
            // 
            // grdSolicitudes
            // 
            this.grdSolicitudes.DataMember = "orden_compra";
            this.grdSolicitudes.DataSource = this.dsCompras1;
            this.grdSolicitudes.Location = new System.Drawing.Point(0, 38);
            this.grdSolicitudes.MainView = this.gridView1;
            this.grdSolicitudes.Name = "grdSolicitudes";
            this.grdSolicitudes.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.reposSelected});
            this.grdSolicitudes.Size = new System.Drawing.Size(1109, 384);
            this.grdSolicitudes.TabIndex = 1;
            this.grdSolicitudes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // grdSucursales
            // 
            this.grdSucursales.Enabled = false;
            this.grdSucursales.Location = new System.Drawing.Point(96, 8);
            this.grdSucursales.Name = "grdSucursales";
            this.grdSucursales.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdSucursales.Properties.Appearance.Options.UseFont = true;
            this.grdSucursales.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdSucursales.Properties.DataSource = this.sucursalesBindingSource;
            this.grdSucursales.Properties.DisplayMember = "pdv";
            this.grdSucursales.Properties.PopupView = this.gridLookUpEdit1View;
            this.grdSucursales.Properties.ValueMember = "id";
            this.grdSucursales.Size = new System.Drawing.Size(306, 24);
            this.grdSucursales.TabIndex = 2;
            this.grdSucursales.EditValueChanged += new System.EventHandler(this.grdSucursales_EditValueChanged);
            // 
            // sucursalesBindingSource
            // 
            this.sucursalesBindingSource.DataMember = "sucursales";
            this.sucursalesBindingSource.DataSource = this.dsCompras1;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colpdv});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // colpdv
            // 
            this.colpdv.Caption = "Sucursal";
            this.colpdv.FieldName = "pdv";
            this.colpdv.Name = "colpdv";
            this.colpdv.OptionsColumn.AllowEdit = false;
            this.colpdv.Visible = true;
            this.colpdv.VisibleIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(39, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 17);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Sucursal:";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "# Orden Compra";
            this.gridColumn2.FieldName = "docnum";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 130;
            // 
            // frmSearchOrdenesC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 422);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.grdSucursales);
            this.Controls.Add(this.grdSolicitudes);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmSearchOrdenesC.IconOptions.SvgImage")));
            this.Name = "frmSearchOrdenesC";
            this.Text = "Seleccionar Orden de Compra";
            ((System.ComponentModel.ISupportInitialize)(this.dsCompras1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSolicitudes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSucursales.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private dsCompras dsCompras1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_solicitud;
        private DevExpress.XtraGrid.Columns.GridColumn colid_user;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario;
        private DevExpress.XtraGrid.Columns.GridColumn colid_estado_solicitud;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_registro;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_contabilizacion;
        private DevExpress.XtraGrid.Columns.GridColumn colcomentario;
        private DevExpress.XtraGrid.GridControl grdSolicitudes;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposSelected;
        private DevExpress.XtraEditors.GridLookUpEdit grdSucursales;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource sucursalesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colpdv;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}