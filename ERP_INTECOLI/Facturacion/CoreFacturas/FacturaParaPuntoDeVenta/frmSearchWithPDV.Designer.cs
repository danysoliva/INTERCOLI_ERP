
using JAGUAR_APP.Facturacion.CoreFacturas;

namespace LOSA.Calidad.LoteConfConsumo
{
    partial class frmSearchWithPDV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchWithPDV));
            this.txtParametroBusqueda = new DevExpress.XtraEditors.TextEdit();
            this.cmdAplicar = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlDetalleMP = new DevExpress.XtraGrid.GridControl();
            this.dsConfigLoteConsumo1 = new dsConfigLoteConsumo();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeleccionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconcat_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.navigationFrameSearch = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.cmdSiguiente = new DevExpress.XtraEditors.SimpleButton();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.cmdAplicarSinRTN = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmdBackPage = new DevExpress.XtraEditors.SimpleButton();
            this.cmdAplicarRTN = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCerrar2 = new DevExpress.XtraEditors.SimpleButton();
            this.textSearchRTN = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsSearchWindow1 = new JAGUAR_APP.Facturacion.CoreFacturas.dsSearchWindow();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreLargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCorto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRTN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeleccionado1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dsBusquedas1 = new JAGUAR_APP.Facturacion.CoreFacturas.FacturaParaPuntoDeVenta.dsBusquedas();
            ((System.ComponentModel.ISupportInitialize)(this.txtParametroBusqueda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetalleMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConfigLoteConsumo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrameSearch)).BeginInit();
            this.navigationFrameSearch.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            this.navigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textSearchRTN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSearchWindow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusquedas1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtParametroBusqueda
            // 
            this.txtParametroBusqueda.Location = new System.Drawing.Point(3, 69);
            this.txtParametroBusqueda.Name = "txtParametroBusqueda";
            this.txtParametroBusqueda.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParametroBusqueda.Properties.Appearance.Options.UseFont = true;
            this.txtParametroBusqueda.Size = new System.Drawing.Size(427, 24);
            this.txtParametroBusqueda.TabIndex = 0;
            this.txtParametroBusqueda.EditValueChanged += new System.EventHandler(this.txtParametroBusqueda_EditValueChanged);
            this.txtParametroBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtParametroBusqueda_KeyDown);
            // 
            // cmdAplicar
            // 
            this.cmdAplicar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAplicar.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAplicar.Appearance.Options.UseFont = true;
            this.cmdAplicar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdAplicar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdAplicar.ImageOptions.SvgImage")));
            this.cmdAplicar.Location = new System.Drawing.Point(221, 10);
            this.cmdAplicar.Name = "cmdAplicar";
            this.cmdAplicar.Size = new System.Drawing.Size(104, 47);
            this.cmdAplicar.TabIndex = 9;
            this.cmdAplicar.Text = "Aplicar";
            this.cmdAplicar.Visible = false;
            this.cmdAplicar.Click += new System.EventHandler(this.cmdAplicar_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(521, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 38);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Cerrar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gridControlDetalleMP
            // 
            this.gridControlDetalleMP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlDetalleMP.DataMember = "search_mp";
            this.gridControlDetalleMP.DataSource = this.dsBusquedas1;
            this.gridControlDetalleMP.Location = new System.Drawing.Point(3, 99);
            this.gridControlDetalleMP.MainView = this.gridView1;
            this.gridControlDetalleMP.Name = "gridControlDetalleMP";
            this.gridControlDetalleMP.Size = new System.Drawing.Size(640, 310);
            this.gridControlDetalleMP.TabIndex = 10;
            this.gridControlDetalleMP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsConfigLoteConsumo1
            // 
            this.dsConfigLoteConsumo1.DataSetName = "dsConfigLoteConsumo";
            this.dsConfigLoteConsumo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemCode,
            this.colName,
            this.colSeleccionado,
            this.colconcat_});
            this.gridView1.GridControl = this.gridControlDetalleMP;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanging);
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colItemCode
            // 
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.OptionsColumn.AllowEdit = false;
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 0;
            this.colItemCode.Width = 78;
            // 
            // colName
            // 
            this.colName.Caption = "Item Name";
            this.colName.FieldName = "Name_";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 441;
            // 
            // colSeleccionado
            // 
            this.colSeleccionado.FieldName = "Seleccionado";
            this.colSeleccionado.Name = "colSeleccionado";
            this.colSeleccionado.Visible = true;
            this.colSeleccionado.VisibleIndex = 2;
            this.colSeleccionado.Width = 105;
            // 
            // colconcat_
            // 
            this.colconcat_.FieldName = "concat_";
            this.colconcat_.Name = "colconcat_";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(3, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(261, 17);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Seleccione o escriba el nombre de un cliente";
            // 
            // navigationFrameSearch
            // 
            this.navigationFrameSearch.Controls.Add(this.navigationPage1);
            this.navigationFrameSearch.Controls.Add(this.navigationPage2);
            this.navigationFrameSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrameSearch.Location = new System.Drawing.Point(0, 0);
            this.navigationFrameSearch.Name = "navigationFrameSearch";
            this.navigationFrameSearch.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1,
            this.navigationPage2});
            this.navigationFrameSearch.SelectedPage = this.navigationPage1;
            this.navigationFrameSearch.Size = new System.Drawing.Size(646, 412);
            this.navigationFrameSearch.TabIndex = 12;
            this.navigationFrameSearch.Text = "navigationFrame1";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Controls.Add(this.cmdSiguiente);
            this.navigationPage1.Controls.Add(this.labelControl1);
            this.navigationPage1.Controls.Add(this.cmdAplicar);
            this.navigationPage1.Controls.Add(this.gridControlDetalleMP);
            this.navigationPage1.Controls.Add(this.btnClose);
            this.navigationPage1.Controls.Add(this.txtParametroBusqueda);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(646, 412);
            // 
            // cmdSiguiente
            // 
            this.cmdSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSiguiente.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSiguiente.Appearance.Options.UseFont = true;
            this.cmdSiguiente.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdSiguiente.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdSiguiente.ImageOptions.Image")));
            this.cmdSiguiente.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.cmdSiguiente.Location = new System.Drawing.Point(521, 55);
            this.cmdSiguiente.Name = "cmdSiguiente";
            this.cmdSiguiente.Size = new System.Drawing.Size(122, 38);
            this.cmdSiguiente.TabIndex = 12;
            this.cmdSiguiente.Text = "Siguiente";
            this.cmdSiguiente.Click += new System.EventHandler(this.cmdSiguiente_Click);
            // 
            // navigationPage2
            // 
            this.navigationPage2.Controls.Add(this.cmdAplicarSinRTN);
            this.navigationPage2.Controls.Add(this.labelControl2);
            this.navigationPage2.Controls.Add(this.cmdBackPage);
            this.navigationPage2.Controls.Add(this.cmdAplicarRTN);
            this.navigationPage2.Controls.Add(this.cmdCerrar2);
            this.navigationPage2.Controls.Add(this.textSearchRTN);
            this.navigationPage2.Controls.Add(this.gridControl1);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(646, 412);
            // 
            // cmdAplicarSinRTN
            // 
            this.cmdAplicarSinRTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAplicarSinRTN.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAplicarSinRTN.Appearance.Options.UseFont = true;
            this.cmdAplicarSinRTN.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdAplicarSinRTN.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdAplicarSinRTN.ImageOptions.SvgImage")));
            this.cmdAplicarSinRTN.Location = new System.Drawing.Point(281, 12);
            this.cmdAplicarSinRTN.Name = "cmdAplicarSinRTN";
            this.cmdAplicarSinRTN.Size = new System.Drawing.Size(147, 47);
            this.cmdAplicarSinRTN.TabIndex = 15;
            this.cmdAplicarSinRTN.Text = "Aplicar Sin RTN";
            this.cmdAplicarSinRTN.Click += new System.EventHandler(this.cmdAplicarSinRTN_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(3, 65);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(302, 17);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Seleccione o escriba el nombre o RTN de un cliente";
            // 
            // cmdBackPage
            // 
            this.cmdBackPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdBackPage.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBackPage.Appearance.Options.UseFont = true;
            this.cmdBackPage.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdBackPage.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdBackPage.ImageOptions.Image")));
            this.cmdBackPage.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.cmdBackPage.Location = new System.Drawing.Point(3, 12);
            this.cmdBackPage.Name = "cmdBackPage";
            this.cmdBackPage.Size = new System.Drawing.Size(150, 47);
            this.cmdBackPage.TabIndex = 13;
            this.cmdBackPage.Text = "Buscar Cliente";
            this.cmdBackPage.Click += new System.EventHandler(this.cmdBackPage_Click);
            // 
            // cmdAplicarRTN
            // 
            this.cmdAplicarRTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAplicarRTN.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAplicarRTN.Appearance.Options.UseFont = true;
            this.cmdAplicarRTN.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdAplicarRTN.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdAplicarRTN.ImageOptions.SvgImage")));
            this.cmdAplicarRTN.Location = new System.Drawing.Point(434, 12);
            this.cmdAplicarRTN.Name = "cmdAplicarRTN";
            this.cmdAplicarRTN.Size = new System.Drawing.Size(104, 47);
            this.cmdAplicarRTN.TabIndex = 12;
            this.cmdAplicarRTN.Text = "Aplicar";
            this.cmdAplicarRTN.Click += new System.EventHandler(this.cmdAplicarRTN_Click);
            // 
            // cmdCerrar2
            // 
            this.cmdCerrar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCerrar2.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar2.Appearance.Options.UseFont = true;
            this.cmdCerrar2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCerrar2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCerrar2.ImageOptions.Image")));
            this.cmdCerrar2.Location = new System.Drawing.Point(544, 12);
            this.cmdCerrar2.Name = "cmdCerrar2";
            this.cmdCerrar2.Size = new System.Drawing.Size(99, 47);
            this.cmdCerrar2.TabIndex = 11;
            this.cmdCerrar2.Text = "Cerrar";
            this.cmdCerrar2.Click += new System.EventHandler(this.cmdCerrar2_Click);
            // 
            // textSearchRTN
            // 
            this.textSearchRTN.Location = new System.Drawing.Point(3, 84);
            this.textSearchRTN.Name = "textSearchRTN";
            this.textSearchRTN.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearchRTN.Properties.Appearance.Options.UseFont = true;
            this.textSearchRTN.Size = new System.Drawing.Size(427, 24);
            this.textSearchRTN.TabIndex = 10;
            this.textSearchRTN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textSearchRTN_KeyDown);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "RTN_Cliente";
            this.gridControl1.DataSource = this.dsBusquedas1;
            this.gridControl1.Location = new System.Drawing.Point(3, 114);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(640, 295);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // dsSearchWindow1
            // 
            this.dsSearchWindow1.DataSetName = "dsSearchWindow";
            this.dsSearchWindow1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdCliente,
            this.colNombreLargo,
            this.colNombreCorto,
            this.colDireccion,
            this.colRTN,
            this.colFechaCreacion,
            this.colSeleccionado1});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView2_CellValueChanging);
            this.gridView2.DoubleClick += new System.EventHandler(this.gridView2_DoubleClick);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdCliente
            // 
            this.colIdCliente.FieldName = "IdCliente";
            this.colIdCliente.Name = "colIdCliente";
            // 
            // colNombreLargo
            // 
            this.colNombreLargo.FieldName = "NombreLargo";
            this.colNombreLargo.Name = "colNombreLargo";
            this.colNombreLargo.OptionsColumn.ReadOnly = true;
            this.colNombreLargo.Visible = true;
            this.colNombreLargo.VisibleIndex = 0;
            // 
            // colNombreCorto
            // 
            this.colNombreCorto.FieldName = "NombreCorto";
            this.colNombreCorto.Name = "colNombreCorto";
            this.colNombreCorto.OptionsColumn.ReadOnly = true;
            // 
            // colDireccion
            // 
            this.colDireccion.FieldName = "Direccion";
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.OptionsColumn.ReadOnly = true;
            this.colDireccion.Visible = true;
            this.colDireccion.VisibleIndex = 1;
            // 
            // colRTN
            // 
            this.colRTN.FieldName = "RTN";
            this.colRTN.Name = "colRTN";
            this.colRTN.OptionsColumn.ReadOnly = true;
            this.colRTN.Visible = true;
            this.colRTN.VisibleIndex = 2;
            // 
            // colFechaCreacion
            // 
            this.colFechaCreacion.FieldName = "FechaCreacion";
            this.colFechaCreacion.Name = "colFechaCreacion";
            this.colFechaCreacion.OptionsColumn.ReadOnly = true;
            // 
            // colSeleccionado1
            // 
            this.colSeleccionado1.FieldName = "Seleccionado";
            this.colSeleccionado1.Name = "colSeleccionado1";
            this.colSeleccionado1.Visible = true;
            this.colSeleccionado1.VisibleIndex = 3;
            // 
            // dsBusquedas1
            // 
            this.dsBusquedas1.DataSetName = "dsBusquedas";
            this.dsBusquedas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmSearchWithPDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 412);
            this.Controls.Add(this.navigationFrameSearch);
            this.IconOptions.ShowIcon = false;
            this.Name = "frmSearchWithPDV";
            this.Activated += new System.EventHandler(this.frmSearchWithPDV_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.txtParametroBusqueda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetalleMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConfigLoteConsumo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrameSearch)).EndInit();
            this.navigationFrameSearch.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            this.navigationPage1.PerformLayout();
            this.navigationPage2.ResumeLayout(false);
            this.navigationPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textSearchRTN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSearchWindow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusquedas1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private dsConfigLoteConsumo dsConfigLoteConsumo1;
        private DevExpress.XtraEditors.TextEdit txtParametroBusqueda;
        private DevExpress.XtraEditors.SimpleButton cmdAplicar;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraGrid.GridControl gridControlDetalleMP;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colSeleccionado;
        private DevExpress.XtraGrid.Columns.GridColumn colconcat_;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrameSearch;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton cmdSiguiente;
        private DevExpress.XtraEditors.SimpleButton cmdAplicarRTN;
        private DevExpress.XtraEditors.SimpleButton cmdCerrar2;
        private DevExpress.XtraEditors.TextEdit textSearchRTN;
        private DevExpress.XtraEditors.SimpleButton cmdBackPage;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private JAGUAR_APP.Facturacion.CoreFacturas.dsSearchWindow dsSearchWindow1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreLargo;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCorto;
        private DevExpress.XtraGrid.Columns.GridColumn colDireccion;
        private DevExpress.XtraGrid.Columns.GridColumn colRTN;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaCreacion;
        private DevExpress.XtraGrid.Columns.GridColumn colSeleccionado1;
        private DevExpress.XtraEditors.SimpleButton cmdAplicarSinRTN;
        private JAGUAR_APP.Facturacion.CoreFacturas.FacturaParaPuntoDeVenta.dsBusquedas dsBusquedas1;
    }
}