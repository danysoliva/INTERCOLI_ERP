
namespace ERP_INTECOLI.Transacciones
{
    partial class frmEstadoCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstadoCuenta));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdTodos = new System.Windows.Forms.RadioButton();
            this.rdSoloHabilitados = new System.Windows.Forms.RadioButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsMovimientosSaldos1 = new ERP_INTECOLI.Administracion.Movimientos.dsMovimientosSaldos();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_doc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcredito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldebito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldoc_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_created = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_user_created = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_estudiante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_detalle_matricula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNivel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconcepto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsaldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbCargarDatos = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEstudiante = new DevExpress.XtraEditors.TextEdit();
            this.cmdF2 = new DevExpress.XtraEditors.SimpleButton();
            this.colestado_transaccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMovimientosSaldos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstudiante.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdTodos);
            this.groupBox2.Controls.Add(this.rdSoloHabilitados);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(846, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 60);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones de Visualización";
            // 
            // rdTodos
            // 
            this.rdTodos.AutoSize = true;
            this.rdTodos.Location = new System.Drawing.Point(6, 35);
            this.rdTodos.Name = "rdTodos";
            this.rdTodos.Size = new System.Drawing.Size(56, 19);
            this.rdTodos.TabIndex = 1;
            this.rdTodos.Text = "Todos";
            this.rdTodos.UseVisualStyleBackColor = true;
            // 
            // rdSoloHabilitados
            // 
            this.rdSoloHabilitados.AutoSize = true;
            this.rdSoloHabilitados.Checked = true;
            this.rdSoloHabilitados.Location = new System.Drawing.Point(6, 14);
            this.rdSoloHabilitados.Name = "rdSoloHabilitados";
            this.rdSoloHabilitados.Size = new System.Drawing.Size(111, 19);
            this.rdSoloHabilitados.TabIndex = 0;
            this.rdSoloHabilitados.TabStop = true;
            this.rdSoloHabilitados.Text = "Solo Habilitados";
            this.rdSoloHabilitados.UseVisualStyleBackColor = true;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "estado_cuenta_lines";
            this.gridControl1.DataSource = this.dsMovimientosSaldos1;
            this.gridControl1.Location = new System.Drawing.Point(1, 78);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1012, 510);
            this.gridControl1.TabIndex = 18;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsMovimientosSaldos1
            // 
            this.dsMovimientosSaldos1.DataSetName = "dsMovimientosSaldos";
            this.dsMovimientosSaldos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colnum_doc,
            this.colcredito,
            this.coldebito,
            this.coldoc_date,
            this.coldate_created,
            this.colid_user_created,
            this.colusuario_name,
            this.colid_estudiante,
            this.colid_detalle_matricula,
            this.colNivel,
            this.colseccion,
            this.colconcepto,
            this.colsaldo,
            this.colestado_transaccion});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colnum_doc
            // 
            this.colnum_doc.FieldName = "num_doc";
            this.colnum_doc.Name = "colnum_doc";
            this.colnum_doc.OptionsColumn.ReadOnly = true;
            this.colnum_doc.Visible = true;
            this.colnum_doc.VisibleIndex = 0;
            this.colnum_doc.Width = 137;
            // 
            // colcredito
            // 
            this.colcredito.DisplayFormat.FormatString = "n2";
            this.colcredito.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcredito.FieldName = "credito";
            this.colcredito.Name = "colcredito";
            this.colcredito.OptionsColumn.ReadOnly = true;
            this.colcredito.Visible = true;
            this.colcredito.VisibleIndex = 8;
            this.colcredito.Width = 90;
            // 
            // coldebito
            // 
            this.coldebito.DisplayFormat.FormatString = "n2";
            this.coldebito.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldebito.FieldName = "debito";
            this.coldebito.Name = "coldebito";
            this.coldebito.OptionsColumn.ReadOnly = true;
            this.coldebito.Visible = true;
            this.coldebito.VisibleIndex = 7;
            this.coldebito.Width = 103;
            // 
            // coldoc_date
            // 
            this.coldoc_date.DisplayFormat.FormatString = "d";
            this.coldoc_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.coldoc_date.FieldName = "doc_date";
            this.coldoc_date.Name = "coldoc_date";
            this.coldoc_date.OptionsColumn.ReadOnly = true;
            this.coldoc_date.Visible = true;
            this.coldoc_date.VisibleIndex = 2;
            this.coldoc_date.Width = 86;
            // 
            // coldate_created
            // 
            this.coldate_created.DisplayFormat.FormatString = "g";
            this.coldate_created.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.coldate_created.FieldName = "date_created";
            this.coldate_created.Name = "coldate_created";
            // 
            // colid_user_created
            // 
            this.colid_user_created.FieldName = "id_user_created";
            this.colid_user_created.Name = "colid_user_created";
            // 
            // colusuario_name
            // 
            this.colusuario_name.FieldName = "usuario_name";
            this.colusuario_name.Name = "colusuario_name";
            this.colusuario_name.OptionsColumn.ReadOnly = true;
            this.colusuario_name.Visible = true;
            this.colusuario_name.VisibleIndex = 3;
            this.colusuario_name.Width = 65;
            // 
            // colid_estudiante
            // 
            this.colid_estudiante.FieldName = "id_estudiante";
            this.colid_estudiante.Name = "colid_estudiante";
            // 
            // colid_detalle_matricula
            // 
            this.colid_detalle_matricula.FieldName = "id_detalle_matricula";
            this.colid_detalle_matricula.Name = "colid_detalle_matricula";
            // 
            // colNivel
            // 
            this.colNivel.FieldName = "Nivel";
            this.colNivel.Name = "colNivel";
            this.colNivel.OptionsColumn.ReadOnly = true;
            this.colNivel.Visible = true;
            this.colNivel.VisibleIndex = 4;
            this.colNivel.Width = 123;
            // 
            // colseccion
            // 
            this.colseccion.FieldName = "seccion";
            this.colseccion.Name = "colseccion";
            this.colseccion.OptionsColumn.ReadOnly = true;
            this.colseccion.Visible = true;
            this.colseccion.VisibleIndex = 5;
            this.colseccion.Width = 82;
            // 
            // colconcepto
            // 
            this.colconcepto.FieldName = "concepto";
            this.colconcepto.Name = "colconcepto";
            this.colconcepto.OptionsColumn.ReadOnly = true;
            this.colconcepto.Visible = true;
            this.colconcepto.VisibleIndex = 1;
            this.colconcepto.Width = 144;
            // 
            // colsaldo
            // 
            this.colsaldo.DisplayFormat.FormatString = "n2";
            this.colsaldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colsaldo.FieldName = "saldo";
            this.colsaldo.Name = "colsaldo";
            this.colsaldo.OptionsColumn.ReadOnly = true;
            this.colsaldo.Visible = true;
            this.colsaldo.VisibleIndex = 9;
            this.colsaldo.Width = 85;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(601, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 46);
            this.button1.TabIndex = 19;
            this.button1.Text = "Agregar Ajuste";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbCargarDatos
            // 
            this.cmbCargarDatos.BackColor = System.Drawing.Color.LightGreen;
            this.cmbCargarDatos.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbCargarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCargarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCargarDatos.Image = global::ERP_INTECOLI.Properties.Resources.actualizar_32;
            this.cmbCargarDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmbCargarDatos.Location = new System.Drawing.Point(478, 26);
            this.cmbCargarDatos.Name = "cmbCargarDatos";
            this.cmbCargarDatos.Size = new System.Drawing.Size(105, 46);
            this.cmbCargarDatos.TabIndex = 20;
            this.cmbCargarDatos.Text = "Cargar";
            this.cmbCargarDatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmbCargarDatos.UseVisualStyleBackColor = false;
            this.cmbCargarDatos.Click += new System.EventHandler(this.cmbCargarDatos_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Estudiante:";
            // 
            // txtEstudiante
            // 
            this.txtEstudiante.EditValue = "F2 Buscar";
            this.txtEstudiante.Enabled = false;
            this.txtEstudiante.Location = new System.Drawing.Point(103, 36);
            this.txtEstudiante.Name = "txtEstudiante";
            this.txtEstudiante.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtEstudiante.Properties.Appearance.Options.UseFont = true;
            this.txtEstudiante.Size = new System.Drawing.Size(290, 26);
            this.txtEstudiante.TabIndex = 51;
            // 
            // cmdF2
            // 
            this.cmdF2.Appearance.BackColor = System.Drawing.Color.PaleGreen;
            this.cmdF2.Appearance.Options.UseBackColor = true;
            this.cmdF2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.cmdF2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdF2.ImageOptions.SvgImage")));
            this.cmdF2.Location = new System.Drawing.Point(399, 26);
            this.cmdF2.Name = "cmdF2";
            this.cmdF2.Size = new System.Drawing.Size(48, 44);
            this.cmdF2.TabIndex = 50;
            this.cmdF2.Click += new System.EventHandler(this.cmdF2_Click);
            // 
            // colestado_transaccion
            // 
            this.colestado_transaccion.FieldName = "estado_transaccion";
            this.colestado_transaccion.Name = "colestado_transaccion";
            this.colestado_transaccion.OptionsColumn.ReadOnly = true;
            this.colestado_transaccion.Visible = true;
            this.colestado_transaccion.VisibleIndex = 6;
            this.colestado_transaccion.Width = 72;
            // 
            // frmEstadoCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 590);
            this.Controls.Add(this.txtEstudiante);
            this.Controls.Add(this.cmdF2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbCargarDatos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmEstadoCuenta";
            this.Text = "Estado de Cuenta";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMovimientosSaldos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstudiante.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdTodos;
        private System.Windows.Forms.RadioButton rdSoloHabilitados;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmbCargarDatos;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtEstudiante;
        private DevExpress.XtraEditors.SimpleButton cmdF2;
        private Administracion.Movimientos.dsMovimientosSaldos dsMovimientosSaldos1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_doc;
        private DevExpress.XtraGrid.Columns.GridColumn colcredito;
        private DevExpress.XtraGrid.Columns.GridColumn coldebito;
        private DevExpress.XtraGrid.Columns.GridColumn coldoc_date;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_created;
        private DevExpress.XtraGrid.Columns.GridColumn colid_user_created;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario_name;
        private DevExpress.XtraGrid.Columns.GridColumn colid_estudiante;
        private DevExpress.XtraGrid.Columns.GridColumn colid_detalle_matricula;
        private DevExpress.XtraGrid.Columns.GridColumn colNivel;
        private DevExpress.XtraGrid.Columns.GridColumn colseccion;
        private DevExpress.XtraGrid.Columns.GridColumn colconcepto;
        private DevExpress.XtraGrid.Columns.GridColumn colsaldo;
        private DevExpress.XtraGrid.Columns.GridColumn colestado_transaccion;
    }
}