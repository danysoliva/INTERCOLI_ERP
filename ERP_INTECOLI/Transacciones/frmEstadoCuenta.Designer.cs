
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_row = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_student = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_estudiante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_documento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_doc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconcepto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcargos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colabonos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsaldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbCargarDatos = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEstudiante = new DevExpress.XtraEditors.TextEdit();
            this.cmdF2 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
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
            this.gridControl1.DataMember = "estado_cuenta";
            this.gridControl1.Location = new System.Drawing.Point(1, 78);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1012, 510);
            this.gridControl1.TabIndex = 18;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_row,
            this.colid_student,
            this.colid_estudiante,
            this.colid_documento,
            this.coltipo,
            this.coltipon,
            this.colfecha,
            this.colnum_doc,
            this.colconcepto,
            this.colnulo,
            this.colcargos,
            this.colabonos,
            this.colsaldo});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colid_row
            // 
            this.colid_row.FieldName = "id_row";
            this.colid_row.Name = "colid_row";
            // 
            // colid_student
            // 
            this.colid_student.FieldName = "id_student";
            this.colid_student.Name = "colid_student";
            this.colid_student.OptionsColumn.AllowEdit = false;
            // 
            // colid_estudiante
            // 
            this.colid_estudiante.FieldName = "id_estudiante";
            this.colid_estudiante.Name = "colid_estudiante";
            this.colid_estudiante.OptionsColumn.AllowEdit = false;
            // 
            // colid_documento
            // 
            this.colid_documento.FieldName = "id_documento";
            this.colid_documento.Name = "colid_documento";
            this.colid_documento.OptionsColumn.AllowEdit = false;
            // 
            // coltipo
            // 
            this.coltipo.FieldName = "tipo";
            this.coltipo.Name = "coltipo";
            this.coltipo.OptionsColumn.AllowEdit = false;
            // 
            // coltipon
            // 
            this.coltipon.Caption = "Tipo";
            this.coltipon.FieldName = "tipon";
            this.coltipon.Name = "coltipon";
            this.coltipon.OptionsColumn.AllowEdit = false;
            this.coltipon.Visible = true;
            this.coltipon.VisibleIndex = 0;
            this.coltipon.Width = 101;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.DisplayFormat.FormatString = "d";
            this.colfecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.AllowEdit = false;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 1;
            // 
            // colnum_doc
            // 
            this.colnum_doc.Caption = "Número Documento";
            this.colnum_doc.FieldName = "num_doc";
            this.colnum_doc.Name = "colnum_doc";
            this.colnum_doc.OptionsColumn.AllowEdit = false;
            this.colnum_doc.Visible = true;
            this.colnum_doc.VisibleIndex = 2;
            this.colnum_doc.Width = 124;
            // 
            // colconcepto
            // 
            this.colconcepto.Caption = "Concepto";
            this.colconcepto.FieldName = "concepto";
            this.colconcepto.Name = "colconcepto";
            this.colconcepto.OptionsColumn.AllowEdit = false;
            this.colconcepto.Visible = true;
            this.colconcepto.VisibleIndex = 3;
            this.colconcepto.Width = 254;
            // 
            // colnulo
            // 
            this.colnulo.Caption = "Anulado";
            this.colnulo.FieldName = "nulo";
            this.colnulo.Name = "colnulo";
            this.colnulo.OptionsColumn.AllowEdit = false;
            this.colnulo.Visible = true;
            this.colnulo.VisibleIndex = 4;
            this.colnulo.Width = 58;
            // 
            // colcargos
            // 
            this.colcargos.Caption = "Cargos";
            this.colcargos.DisplayFormat.FormatString = "n2";
            this.colcargos.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcargos.FieldName = "cargos";
            this.colcargos.Name = "colcargos";
            this.colcargos.OptionsColumn.AllowEdit = false;
            this.colcargos.Visible = true;
            this.colcargos.VisibleIndex = 5;
            this.colcargos.Width = 72;
            // 
            // colabonos
            // 
            this.colabonos.Caption = "Abonos";
            this.colabonos.DisplayFormat.FormatString = "n2";
            this.colabonos.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colabonos.FieldName = "abonos";
            this.colabonos.Name = "colabonos";
            this.colabonos.OptionsColumn.AllowEdit = false;
            this.colabonos.Visible = true;
            this.colabonos.VisibleIndex = 6;
            this.colabonos.Width = 62;
            // 
            // colsaldo
            // 
            this.colsaldo.Caption = "Saldo";
            this.colsaldo.DisplayFormat.FormatString = "n2";
            this.colsaldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colsaldo.FieldName = "saldo";
            this.colsaldo.Name = "colsaldo";
            this.colsaldo.OptionsColumn.AllowEdit = false;
            this.colsaldo.Visible = true;
            this.colsaldo.VisibleIndex = 7;
            this.colsaldo.Width = 60;
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
            // 
            // cmbCargarDatos
            // 
            this.cmbCargarDatos.BackColor = System.Drawing.Color.LightGreen;
            this.cmbCargarDatos.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbCargarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCargarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCargarDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmbCargarDatos.Location = new System.Drawing.Point(478, 26);
            this.cmbCargarDatos.Name = "cmbCargarDatos";
            this.cmbCargarDatos.Size = new System.Drawing.Size(105, 46);
            this.cmbCargarDatos.TabIndex = 20;
            this.cmbCargarDatos.Text = "Cargar";
            this.cmbCargarDatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmbCargarDatos.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
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
        private DevExpress.XtraGrid.Columns.GridColumn colid_row;
        private DevExpress.XtraGrid.Columns.GridColumn colid_student;
        private DevExpress.XtraGrid.Columns.GridColumn colid_estudiante;
        private DevExpress.XtraGrid.Columns.GridColumn colid_documento;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo;
        private DevExpress.XtraGrid.Columns.GridColumn coltipon;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_doc;
        private DevExpress.XtraGrid.Columns.GridColumn colconcepto;
        private DevExpress.XtraGrid.Columns.GridColumn colnulo;
        private DevExpress.XtraGrid.Columns.GridColumn colcargos;
        private DevExpress.XtraGrid.Columns.GridColumn colabonos;
        private DevExpress.XtraGrid.Columns.GridColumn colsaldo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmbCargarDatos;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtEstudiante;
        private DevExpress.XtraEditors.SimpleButton cmdF2;
    }
}