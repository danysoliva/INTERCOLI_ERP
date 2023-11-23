
namespace ERP_INTECOLI.Compras
{
    partial class frmSearchFacturasProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchFacturasProveedor));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.grdSolicitudes = new DevExpress.XtraGrid.GridControl();
            this.dsCompras1 = new ERP_INTECOLI.Compras.dsCompras();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_contabilizacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_vencimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposSelected = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdSolicitudes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompras1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // grdSolicitudes
            // 
            this.grdSolicitudes.DataMember = "search_facturas";
            this.grdSolicitudes.DataSource = this.dsCompras1;
            this.grdSolicitudes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSolicitudes.Location = new System.Drawing.Point(0, 0);
            this.grdSolicitudes.MainView = this.gridView1;
            this.grdSolicitudes.Name = "grdSolicitudes";
            this.grdSolicitudes.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.reposSelected});
            this.grdSolicitudes.Size = new System.Drawing.Size(1109, 422);
            this.grdSolicitudes.TabIndex = 2;
            this.grdSolicitudes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            this.colid_factura,
            this.colnum_factura,
            this.colfecha_contabilizacion,
            this.colfecha_vencimiento,
            this.coltotal,
            this.colestado,
            this.colusuario,
            this.gridColumn1});
            this.gridView1.GridControl = this.grdSolicitudes;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colid_factura
            // 
            this.colid_factura.FieldName = "id_factura";
            this.colid_factura.Name = "colid_factura";
            this.colid_factura.OptionsColumn.AllowEdit = false;
            // 
            // colnum_factura
            // 
            this.colnum_factura.Caption = "Num. Factura";
            this.colnum_factura.FieldName = "num_factura";
            this.colnum_factura.Name = "colnum_factura";
            this.colnum_factura.OptionsColumn.AllowEdit = false;
            this.colnum_factura.Visible = true;
            this.colnum_factura.VisibleIndex = 0;
            // 
            // colfecha_contabilizacion
            // 
            this.colfecha_contabilizacion.Caption = "F. Contabilizacion";
            this.colfecha_contabilizacion.FieldName = "fecha_contabilizacion";
            this.colfecha_contabilizacion.Name = "colfecha_contabilizacion";
            this.colfecha_contabilizacion.OptionsColumn.AllowEdit = false;
            this.colfecha_contabilizacion.Visible = true;
            this.colfecha_contabilizacion.VisibleIndex = 1;
            // 
            // colfecha_vencimiento
            // 
            this.colfecha_vencimiento.Caption = "F. Vencimiento";
            this.colfecha_vencimiento.FieldName = "fecha_vencimiento";
            this.colfecha_vencimiento.Name = "colfecha_vencimiento";
            this.colfecha_vencimiento.OptionsColumn.AllowEdit = false;
            this.colfecha_vencimiento.Visible = true;
            this.colfecha_vencimiento.VisibleIndex = 2;
            // 
            // coltotal
            // 
            this.coltotal.Caption = "Total";
            this.coltotal.FieldName = "total";
            this.coltotal.Name = "coltotal";
            this.coltotal.OptionsColumn.AllowEdit = false;
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 5;
            // 
            // colestado
            // 
            this.colestado.Caption = "Estado";
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            this.colestado.OptionsColumn.AllowEdit = false;
            this.colestado.Visible = true;
            this.colestado.VisibleIndex = 3;
            // 
            // colusuario
            // 
            this.colusuario.Caption = "Usuario Cre";
            this.colusuario.FieldName = "usuario";
            this.colusuario.Name = "colusuario";
            this.colusuario.OptionsColumn.AllowEdit = false;
            this.colusuario.Visible = true;
            this.colusuario.VisibleIndex = 4;
            // 
            // reposSelected
            // 
            this.reposSelected.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.reposSelected.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.reposSelected.Name = "reposSelected";
            this.reposSelected.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.reposSelected.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.reposSelected_ButtonClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Seleccionar";
            this.gridColumn1.ColumnEdit = this.reposSelected;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
            // 
            // frmSearchFacturasProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 422);
            this.Controls.Add(this.grdSolicitudes);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmSearchFacturasProveedor.IconOptions.Image")));
            this.Name = "frmSearchFacturasProveedor";
            this.Text = "Facturas Proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.grdSolicitudes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompras1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposSelected)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdSolicitudes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposSelected;
        private dsCompras dsCompras1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_factura;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_factura;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_contabilizacion;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_vencimiento;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}