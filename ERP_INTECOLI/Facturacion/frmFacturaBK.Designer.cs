
namespace ERP_INTECOLI.Facturacion
{
    partial class frmFacturaBK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturaBK));
            DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.txtRecargo = new System.Windows.Forms.TextBox();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.dtFechaVenc = new System.Windows.Forms.DateTimePicker();
            this.lblFechaVencimiento = new DevExpress.XtraEditors.LabelControl();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtOrdenCompra = new System.Windows.Forms.TextBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtRTNCLiente = new System.Windows.Forms.TextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmdGenerar = new DevExpress.XtraEditors.SimpleButton();
            this.toggleTipoFactura = new DevExpress.XtraEditors.ToggleSwitch();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcurso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconcepto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseleccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_limite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colabono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.descuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.drop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcurso_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.recargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemCheckEditSeleccion = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.button_delete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.dsMensualidades1 = new ERP_INTECOLI.Transacciones.dsMensualidades();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleTipoFactura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemButtonEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemCheckEditSeleccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMensualidades1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRecargo
            // 
            this.txtRecargo.Enabled = false;
            this.txtRecargo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecargo.Location = new System.Drawing.Point(521, 339);
            this.txtRecargo.Name = "txtRecargo";
            this.txtRecargo.Size = new System.Drawing.Size(124, 25);
            this.txtRecargo.TabIndex = 93;
            this.txtRecargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(456, 341);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(60, 21);
            this.labelControl10.TabIndex = 92;
            this.labelControl10.Text = "Recargo:";
            // 
            // dtFechaVenc
            // 
            this.dtFechaVenc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaVenc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaVenc.Location = new System.Drawing.Point(470, 112);
            this.dtFechaVenc.Name = "dtFechaVenc";
            this.dtFechaVenc.Size = new System.Drawing.Size(169, 25);
            this.dtFechaVenc.TabIndex = 90;
            this.dtFechaVenc.Visible = false;
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVencimiento.Appearance.Options.UseFont = true;
            this.lblFechaVencimiento.Location = new System.Drawing.Point(386, 115);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(81, 21);
            this.lblFechaVencimiento.TabIndex = 89;
            this.lblFechaVencimiento.Text = "Fecha Venc.";
            this.lblFechaVencimiento.Visible = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(88, 77);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(242, 25);
            this.txtTelefono.TabIndex = 87;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(14, 81);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(63, 21);
            this.labelControl9.TabIndex = 86;
            this.labelControl9.Text = "Telefono:";
            // 
            // txtOrdenCompra
            // 
            this.txtOrdenCompra.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrdenCompra.Location = new System.Drawing.Point(470, 77);
            this.txtOrdenCompra.Name = "txtOrdenCompra";
            this.txtOrdenCompra.Size = new System.Drawing.Size(169, 25);
            this.txtOrdenCompra.TabIndex = 85;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(339, 77);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(128, 21);
            this.labelControl8.TabIndex = 84;
            this.labelControl8.Text = "Orden de Compra:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(88, 43);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(242, 25);
            this.txtDireccion.TabIndex = 83;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(14, 47);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(68, 21);
            this.labelControl7.TabIndex = 82;
            this.labelControl7.Text = "Dirección:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(521, 393);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(124, 25);
            this.txtTotal.TabIndex = 81;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(479, 397);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(37, 21);
            this.labelControl5.TabIndex = 80;
            this.labelControl5.Text = "Total:";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Enabled = false;
            this.txtDescuento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuento.Location = new System.Drawing.Point(521, 366);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(124, 25);
            this.txtDescuento.TabIndex = 79;
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(440, 369);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(76, 21);
            this.labelControl3.TabIndex = 78;
            this.labelControl3.Text = "Descuento:";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(521, 312);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(124, 25);
            this.txtSubTotal.TabIndex = 77;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(448, 314);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 21);
            this.labelControl2.TabIndex = 76;
            this.labelControl2.Text = "Sub Total:";
            // 
            // dtFechaEmision
            // 
            this.dtFechaEmision.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaEmision.Location = new System.Drawing.Point(470, 43);
            this.dtFechaEmision.Name = "dtFechaEmision";
            this.dtFechaEmision.Size = new System.Drawing.Size(169, 25);
            this.dtFechaEmision.TabIndex = 75;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(365, 47);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(102, 21);
            this.labelControl1.TabIndex = 74;
            this.labelControl1.Text = "Fecha Emisión:";
            // 
            // txtRTNCLiente
            // 
            this.txtRTNCLiente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRTNCLiente.Location = new System.Drawing.Point(470, 12);
            this.txtRTNCLiente.Name = "txtRTNCLiente";
            this.txtRTNCLiente.Size = new System.Drawing.Size(169, 25);
            this.txtRTNCLiente.TabIndex = 73;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(385, 13);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(82, 21);
            this.labelControl6.TabIndex = 72;
            this.labelControl6.Text = "RTN Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(88, 11);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(242, 25);
            this.txtCliente.TabIndex = 71;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(14, 13);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(51, 21);
            this.labelControl4.TabIndex = 70;
            this.labelControl4.Text = "Cliente:";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "mensualidades";
            this.gridControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl1.Location = new System.Drawing.Point(3, 141);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ItemCheckEditSeleccion,
            this.button_delete});
            this.gridControl1.Size = new System.Drawing.Size(642, 168);
            this.gridControl1.TabIndex = 69;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colmes,
            this.colcurso,
            this.colvalor,
            this.colconcepto,
            this.colseleccion,
            this.colfecha_limite,
            this.colabono,
            this.descuento,
            this.drop,
            this.colcurso_id,
            this.cantidad,
            this.recargo,
            this.total});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // cmdGenerar
            // 
            this.cmdGenerar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGenerar.Appearance.Options.UseFont = true;
            this.cmdGenerar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdGenerar.ImageOptions.Image")));
            this.cmdGenerar.Location = new System.Drawing.Point(14, 383);
            this.cmdGenerar.Name = "cmdGenerar";
            this.cmdGenerar.Size = new System.Drawing.Size(115, 35);
            this.cmdGenerar.TabIndex = 91;
            this.cmdGenerar.Text = "Guardar";
            this.cmdGenerar.Click += new System.EventHandler(this.cmdGenerar_Click);
            // 
            // toggleTipoFactura
            // 
            this.toggleTipoFactura.EditValue = true;
            this.toggleTipoFactura.Location = new System.Drawing.Point(88, 108);
            this.toggleTipoFactura.Name = "toggleTipoFactura";
            this.toggleTipoFactura.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleTipoFactura.Properties.Appearance.Options.UseFont = true;
            this.toggleTipoFactura.Properties.OffText = "Crédito";
            this.toggleTipoFactura.Properties.OnText = "Contado";
            this.toggleTipoFactura.Size = new System.Drawing.Size(166, 24);
            this.toggleTipoFactura.TabIndex = 88;
            this.toggleTipoFactura.Toggled += new System.EventHandler(this.toggleTipoFactura_Toggled);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colmes
            // 
            this.colmes.Caption = "Mes";
            this.colmes.FieldName = "mes";
            this.colmes.Name = "colmes";
            this.colmes.OptionsColumn.AllowEdit = false;
            this.colmes.Visible = true;
            this.colmes.VisibleIndex = 1;
            this.colmes.Width = 146;
            // 
            // colcurso
            // 
            this.colcurso.Caption = "Curso";
            this.colcurso.FieldName = "curso";
            this.colcurso.Name = "colcurso";
            this.colcurso.Visible = true;
            this.colcurso.VisibleIndex = 2;
            this.colcurso.Width = 108;
            // 
            // colvalor
            // 
            this.colvalor.AppearanceCell.Options.UseTextOptions = true;
            this.colvalor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colvalor.Caption = "Valor";
            this.colvalor.DisplayFormat.FormatString = "#,##0.00";
            this.colvalor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colvalor.FieldName = "valor";
            this.colvalor.Name = "colvalor";
            this.colvalor.OptionsColumn.AllowEdit = false;
            this.colvalor.Width = 82;
            // 
            // colconcepto
            // 
            this.colconcepto.FieldName = "concepto";
            this.colconcepto.Name = "colconcepto";
            // 
            // colseleccion
            // 
            this.colseleccion.Caption = "Selección";
            this.colseleccion.FieldName = "seleccion";
            this.colseleccion.Name = "colseleccion";
            this.colseleccion.Width = 55;
            // 
            // colfecha_limite
            // 
            this.colfecha_limite.Caption = "Fecha Límite";
            this.colfecha_limite.FieldName = "fecha_limite";
            this.colfecha_limite.Name = "colfecha_limite";
            this.colfecha_limite.OptionsColumn.AllowEdit = false;
            this.colfecha_limite.Width = 77;
            // 
            // colabono
            // 
            this.colabono.AppearanceCell.Options.UseTextOptions = true;
            this.colabono.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colabono.Caption = "Abono";
            this.colabono.DisplayFormat.FormatString = "#,##0.00";
            this.colabono.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colabono.FieldName = "abono";
            this.colabono.Name = "colabono";
            this.colabono.Visible = true;
            this.colabono.VisibleIndex = 5;
            this.colabono.Width = 100;
            // 
            // descuento
            // 
            this.descuento.AppearanceCell.Options.UseTextOptions = true;
            this.descuento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.descuento.Caption = "Descuento";
            this.descuento.DisplayFormat.FormatString = "#,##0.00";
            this.descuento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.descuento.FieldName = "descuento";
            this.descuento.Name = "descuento";
            this.descuento.Visible = true;
            this.descuento.VisibleIndex = 3;
            this.descuento.Width = 88;
            // 
            // drop
            // 
            this.drop.Caption = "Eliminar";
            repositoryItemButtonEdit2.AutoHeight = false;
            repositoryItemButtonEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            repositoryItemButtonEdit2.Name = "button_delete";
            repositoryItemButtonEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.drop.ColumnEdit = repositoryItemButtonEdit2;
            this.drop.Name = "drop";
            this.drop.Width = 36;
            // 
            // colcurso_id
            // 
            this.colcurso_id.FieldName = "curso_id";
            this.colcurso_id.Name = "colcurso_id";
            // 
            // cantidad
            // 
            this.cantidad.AppearanceCell.Options.UseTextOptions = true;
            this.cantidad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.cantidad.Caption = "Cant.";
            this.cantidad.DisplayFormat.FormatString = "###";
            this.cantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cantidad.FieldName = "cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.Visible = true;
            this.cantidad.VisibleIndex = 0;
            this.cantidad.Width = 37;
            // 
            // recargo
            // 
            this.recargo.AppearanceCell.Options.UseTextOptions = true;
            this.recargo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.recargo.Caption = "Recargo";
            this.recargo.DisplayFormat.FormatString = "#,##0.00";
            this.recargo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.recargo.FieldName = "recargo";
            this.recargo.Name = "recargo";
            this.recargo.Visible = true;
            this.recargo.VisibleIndex = 4;
            this.recargo.Width = 78;
            // 
            // total
            // 
            this.total.AppearanceCell.Options.UseTextOptions = true;
            this.total.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.total.Caption = "Total Fila";
            this.total.DisplayFormat.FormatString = "#,##0.00";
            this.total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.total.FieldName = "total";
            this.total.Name = "total";
            this.total.Visible = true;
            this.total.VisibleIndex = 6;
            this.total.Width = 70;
            // 
            // ItemCheckEditSeleccion
            // 
            this.ItemCheckEditSeleccion.AutoHeight = false;
            this.ItemCheckEditSeleccion.Caption = "Check";
            this.ItemCheckEditSeleccion.Name = "ItemCheckEditSeleccion";
            // 
            // button_delete
            // 
            this.button_delete.AutoHeight = false;
            this.button_delete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.button_delete.Name = "button_delete";
            this.button_delete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // dsMensualidades1
            // 
            this.dsMensualidades1.DataSetName = "dsMensualidades";
            this.dsMensualidades1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 428);
            this.Controls.Add(this.txtRecargo);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.cmdGenerar);
            this.Controls.Add(this.dtFechaVenc);
            this.Controls.Add(this.lblFechaVencimiento);
            this.Controls.Add(this.toggleTipoFactura);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.txtOrdenCompra);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.dtFechaEmision);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtRTNCLiente);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.gridControl1);
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.Name = "frmFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleTipoFactura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemButtonEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemCheckEditSeleccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMensualidades1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtRecargo;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton cmdGenerar;
        public System.Windows.Forms.DateTimePicker dtFechaVenc;
        private DevExpress.XtraEditors.LabelControl lblFechaVencimiento;
        public DevExpress.XtraEditors.ToggleSwitch toggleTipoFactura;
        public System.Windows.Forms.TextBox txtTelefono;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        public System.Windows.Forms.TextBox txtOrdenCompra;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        public System.Windows.Forms.TextBox txtDireccion;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        public System.Windows.Forms.TextBox txtTotal;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        public System.Windows.Forms.TextBox txtDescuento;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        public System.Windows.Forms.TextBox txtSubTotal;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        public System.Windows.Forms.DateTimePicker dtFechaEmision;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public System.Windows.Forms.TextBox txtRTNCLiente;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        public System.Windows.Forms.TextBox txtCliente;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        public DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colmes;
        private DevExpress.XtraGrid.Columns.GridColumn colcurso;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor;
        private DevExpress.XtraGrid.Columns.GridColumn colconcepto;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccion;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_limite;
        private DevExpress.XtraGrid.Columns.GridColumn colabono;
        private DevExpress.XtraGrid.Columns.GridColumn descuento;
        private DevExpress.XtraGrid.Columns.GridColumn drop;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit button_delete;
        private DevExpress.XtraGrid.Columns.GridColumn colcurso_id;
        private DevExpress.XtraGrid.Columns.GridColumn cantidad;
        private DevExpress.XtraGrid.Columns.GridColumn recargo;
        private DevExpress.XtraGrid.Columns.GridColumn total;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit ItemCheckEditSeleccion;
        private Transacciones.dsMensualidades dsMensualidades1;
    }
}