namespace ERP_INTECOLI.Facturacion.CoreFacturas
{
    partial class frmAjusteSaldoEstadoCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjusteSaldoEstadoCuenta));
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCredito = new DevExpress.XtraEditors.SimpleButton();
            this.cmdDebito = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMonto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.lblNombre = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsVentaSuccess1 = new ERP_INTECOLI.Facturacion.CoreFacturas.dsVentaSuccess();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_detalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcurso_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhorario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_inicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_fin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcompletado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseleccionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVentaSuccess1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCerrar.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdCerrar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Appearance.Options.UseBackColor = true;
            this.cmdCerrar.Appearance.Options.UseFont = true;
            this.cmdCerrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCerrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCerrar.ImageOptions.Image")));
            this.cmdCerrar.Location = new System.Drawing.Point(523, 2);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(145, 39);
            this.cmdCerrar.TabIndex = 8;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // cmdCredito
            // 
            this.cmdCredito.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cmdCredito.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCredito.Appearance.Options.UseBackColor = true;
            this.cmdCredito.Appearance.Options.UseFont = true;
            this.cmdCredito.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCredito.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCredito.ImageOptions.Image")));
            this.cmdCredito.Location = new System.Drawing.Point(120, 246);
            this.cmdCredito.Name = "cmdCredito";
            this.cmdCredito.Size = new System.Drawing.Size(184, 42);
            this.cmdCredito.TabIndex = 0;
            this.cmdCredito.Text = "Crédito";
            this.cmdCredito.Click += new System.EventHandler(this.cmdCredito_Click);
            // 
            // cmdDebito
            // 
            this.cmdDebito.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cmdDebito.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDebito.Appearance.Options.UseBackColor = true;
            this.cmdDebito.Appearance.Options.UseFont = true;
            this.cmdDebito.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdDebito.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdDebito.ImageOptions.Image")));
            this.cmdDebito.Location = new System.Drawing.Point(343, 246);
            this.cmdDebito.Name = "cmdDebito";
            this.cmdDebito.Size = new System.Drawing.Size(184, 42);
            this.cmdDebito.TabIndex = 1;
            this.cmdDebito.Text = "Débito";
            this.cmdDebito.Click += new System.EventHandler(this.cmdDebito_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(219, 304);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 20);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Monto:";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(272, 300);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Properties.Appearance.Options.UseFont = true;
            this.txtMonto.Properties.DisplayFormat.FormatString = "n2";
            this.txtMonto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMonto.Properties.EditFormat.FormatString = "n2";
            this.txtMonto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMonto.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtMonto.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtMonto.Properties.MaskSettings.Set("mask", "n2");
            this.txtMonto.Size = new System.Drawing.Size(130, 28);
            this.txtMonto.TabIndex = 2;
            this.txtMonto.EditValueChanged += new System.EventHandler(this.txtMonto_EditValueChanged);
            this.txtMonto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonto_KeyDown);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(120, 223);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(200, 20);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Indique el tipo de Transacción";
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdGuardar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Appearance.Options.UseBackColor = true;
            this.cmdGuardar.Appearance.Options.UseFont = true;
            this.cmdGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.ImageOptions.Image")));
            this.cmdGuardar.Location = new System.Drawing.Point(236, 412);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(184, 42);
            this.cmdGuardar.TabIndex = 4;
            this.cmdGuardar.Text = "Aplicar";
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Appearance.Options.UseFont = true;
            this.lblNombre.Location = new System.Drawing.Point(11, 38);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(142, 20);
            this.lblNombre.TabIndex = 16;
            this.lblNombre.Text = "[Nombre Estudiante]";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(230, 12);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(114, 21);
            this.labelControl5.TabIndex = 17;
            this.labelControl5.Text = "Ajuste de Saldo";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(120, 335);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(81, 20);
            this.labelControl4.TabIndex = 18;
            this.labelControl4.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDescripcion.Location = new System.Drawing.Point(207, 337);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(320, 69);
            this.txtDescripcion.TabIndex = 3;
            this.txtDescripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescripcion_KeyDown);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "detalle_cursos_estudiante";
            this.gridControl1.DataSource = this.dsVentaSuccess1;
            this.gridControl1.Location = new System.Drawing.Point(11, 99);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(646, 118);
            this.gridControl1.TabIndex = 20;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsVentaSuccess1
            // 
            this.dsVentaSuccess1.DataSetName = "dsVentaSuccess";
            this.dsVentaSuccess1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_detalle,
            this.colcurso_id,
            this.coldescripcion,
            this.colseccion,
            this.colhorario,
            this.colEstado,
            this.colvalor,
            this.colfecha_inicio,
            this.colfecha_fin,
            this.colcompletado,
            this.colseleccionado});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // colid_detalle
            // 
            this.colid_detalle.FieldName = "id_detalle";
            this.colid_detalle.Name = "colid_detalle";
            // 
            // colcurso_id
            // 
            this.colcurso_id.FieldName = "curso_id";
            this.colcurso_id.Name = "colcurso_id";
            // 
            // coldescripcion
            // 
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.ReadOnly = true;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            this.coldescripcion.Width = 97;
            // 
            // colseccion
            // 
            this.colseccion.FieldName = "seccion";
            this.colseccion.Name = "colseccion";
            this.colseccion.OptionsColumn.ReadOnly = true;
            this.colseccion.Visible = true;
            this.colseccion.VisibleIndex = 1;
            this.colseccion.Width = 66;
            // 
            // colhorario
            // 
            this.colhorario.FieldName = "horario";
            this.colhorario.Name = "colhorario";
            this.colhorario.OptionsColumn.ReadOnly = true;
            this.colhorario.Visible = true;
            this.colhorario.VisibleIndex = 2;
            this.colhorario.Width = 92;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            // 
            // colvalor
            // 
            this.colvalor.FieldName = "valor";
            this.colvalor.Name = "colvalor";
            this.colvalor.OptionsColumn.ReadOnly = true;
            this.colvalor.Visible = true;
            this.colvalor.VisibleIndex = 3;
            this.colvalor.Width = 64;
            // 
            // colfecha_inicio
            // 
            this.colfecha_inicio.FieldName = "fecha_inicio";
            this.colfecha_inicio.Name = "colfecha_inicio";
            this.colfecha_inicio.OptionsColumn.ReadOnly = true;
            this.colfecha_inicio.Visible = true;
            this.colfecha_inicio.VisibleIndex = 5;
            this.colfecha_inicio.Width = 89;
            // 
            // colfecha_fin
            // 
            this.colfecha_fin.FieldName = "fecha_fin";
            this.colfecha_fin.Name = "colfecha_fin";
            this.colfecha_fin.OptionsColumn.ReadOnly = true;
            this.colfecha_fin.Visible = true;
            this.colfecha_fin.VisibleIndex = 6;
            // 
            // colcompletado
            // 
            this.colcompletado.FieldName = "completado";
            this.colcompletado.Name = "colcompletado";
            this.colcompletado.OptionsColumn.ReadOnly = true;
            this.colcompletado.Visible = true;
            this.colcompletado.VisibleIndex = 4;
            this.colcompletado.Width = 70;
            // 
            // colseleccionado
            // 
            this.colseleccionado.Caption = "Seleccionado";
            this.colseleccionado.FieldName = "seleccionado";
            this.colseleccionado.Name = "colseleccionado";
            this.colseleccionado.Visible = true;
            this.colseleccionado.VisibleIndex = 7;
            this.colseleccionado.Width = 68;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(11, 73);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(256, 20);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "Indique al curso al que aplica el ajuste:";
            // 
            // frmAjusteSaldoEstadoCuenta
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 455);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmdDebito);
            this.Controls.Add(this.cmdCredito);
            this.Controls.Add(this.cmdCerrar);
            this.Name = "frmAjusteSaldoEstadoCuenta";
            this.Text = "Ajuste de Saldo Estado Cuenta";
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVentaSuccess1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private DevExpress.XtraEditors.SimpleButton cmdCredito;
        private DevExpress.XtraEditors.SimpleButton cmdDebito;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMonto;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
        private DevExpress.XtraEditors.LabelControl lblNombre;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsVentaSuccess dsVentaSuccess1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_detalle;
        private DevExpress.XtraGrid.Columns.GridColumn colcurso_id;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colseccion;
        private DevExpress.XtraGrid.Columns.GridColumn colhorario;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_inicio;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_fin;
        private DevExpress.XtraGrid.Columns.GridColumn colcompletado;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccionado;
    }
}