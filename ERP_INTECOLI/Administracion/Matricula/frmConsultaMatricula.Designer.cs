
namespace ERP_INTECOLI.Administracion.Matricula
{
    partial class frmConsultaMatricula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaMatricula));
            this.grDetalleMatricula = new DevExpress.XtraGrid.GridControl();
            this.dsMatricula1 = new ERP_INTECOLI.Administracion.Matricula.dsMatricula();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_matricula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_posteo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_detalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprofe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnivel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdCargar = new DevExpress.XtraEditors.SimpleButton();
            this.dtHasta = new System.Windows.Forms.DateTimePicker();
            this.dtDesde = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tsHabilitados = new DevExpress.XtraEditors.ToggleSwitch();
            this.chkNulas = new DevExpress.XtraEditors.CheckEdit();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grDetalleMatricula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMatricula1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsHabilitados.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNulas.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grDetalleMatricula
            // 
            this.grDetalleMatricula.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grDetalleMatricula.DataMember = "ListaMatriculados";
            this.grDetalleMatricula.DataSource = this.dsMatricula1;
            this.grDetalleMatricula.Location = new System.Drawing.Point(3, 94);
            this.grDetalleMatricula.MainView = this.gridView1;
            this.grDetalleMatricula.Name = "grDetalleMatricula";
            this.grDetalleMatricula.Size = new System.Drawing.Size(755, 375);
            this.grDetalleMatricula.TabIndex = 0;
            this.grDetalleMatricula.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsMatricula1
            // 
            this.dsMatricula1.DataSetName = "dsMatricula";
            this.dsMatricula1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_matricula,
            this.colnombre,
            this.colnula,
            this.colvalor,
            this.colfecha_posteo,
            this.colid_detalle,
            this.colprofe,
            this.colnivel});
            this.gridView1.GridControl = this.grDetalleMatricula;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid_matricula
            // 
            this.colid_matricula.FieldName = "id_matricula";
            this.colid_matricula.Name = "colid_matricula";
            this.colid_matricula.OptionsColumn.ReadOnly = true;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.ReadOnly = true;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 0;
            // 
            // colnula
            // 
            this.colnula.Caption = "Anulada";
            this.colnula.FieldName = "nula";
            this.colnula.Name = "colnula";
            this.colnula.OptionsColumn.ReadOnly = true;
            this.colnula.Visible = true;
            this.colnula.VisibleIndex = 1;
            // 
            // colvalor
            // 
            this.colvalor.Caption = "Valor";
            this.colvalor.FieldName = "valor";
            this.colvalor.Name = "colvalor";
            this.colvalor.OptionsColumn.ReadOnly = true;
            this.colvalor.Visible = true;
            this.colvalor.VisibleIndex = 2;
            // 
            // colfecha_posteo
            // 
            this.colfecha_posteo.Caption = "Fecha";
            this.colfecha_posteo.FieldName = "fecha_posteo";
            this.colfecha_posteo.Name = "colfecha_posteo";
            this.colfecha_posteo.OptionsColumn.ReadOnly = true;
            this.colfecha_posteo.Visible = true;
            this.colfecha_posteo.VisibleIndex = 3;
            // 
            // colid_detalle
            // 
            this.colid_detalle.FieldName = "id_detalle";
            this.colid_detalle.Name = "colid_detalle";
            this.colid_detalle.OptionsColumn.ReadOnly = true;
            // 
            // colprofe
            // 
            this.colprofe.Caption = "Profesor";
            this.colprofe.FieldName = "profe";
            this.colprofe.Name = "colprofe";
            this.colprofe.OptionsColumn.ReadOnly = true;
            this.colprofe.Visible = true;
            this.colprofe.VisibleIndex = 4;
            // 
            // colnivel
            // 
            this.colnivel.Caption = "Nivel";
            this.colnivel.FieldName = "nivel";
            this.colnivel.Name = "colnivel";
            this.colnivel.OptionsColumn.ReadOnly = true;
            this.colnivel.Visible = true;
            this.colnivel.VisibleIndex = 5;
            // 
            // cmdCargar
            // 
            this.cmdCargar.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdCargar.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargar.Appearance.Options.UseBackColor = true;
            this.cmdCargar.Appearance.Options.UseFont = true;
            this.cmdCargar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdCargar.ImageOptions.SvgImage")));
            this.cmdCargar.Location = new System.Drawing.Point(184, 12);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(99, 48);
            this.cmdCargar.TabIndex = 7;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // dtHasta
            // 
            this.dtHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtHasta.Location = new System.Drawing.Point(67, 40);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Size = new System.Drawing.Size(97, 21);
            this.dtHasta.TabIndex = 11;
            // 
            // dtDesde
            // 
            this.dtDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDesde.Location = new System.Drawing.Point(67, 12);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Size = new System.Drawing.Size(97, 21);
            this.dtDesde.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Desde:";
            // 
            // tsHabilitados
            // 
            this.tsHabilitados.EditValue = true;
            this.tsHabilitados.Location = new System.Drawing.Point(415, 40);
            this.tsHabilitados.Name = "tsHabilitados";
            this.tsHabilitados.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsHabilitados.Properties.Appearance.Options.UseFont = true;
            this.tsHabilitados.Properties.OffText = "Todos";
            this.tsHabilitados.Properties.OnText = "Solo Habilitados";
            this.tsHabilitados.Size = new System.Drawing.Size(168, 20);
            this.tsHabilitados.TabIndex = 12;
            // 
            // chkNulas
            // 
            this.chkNulas.EditValue = true;
            this.chkNulas.Location = new System.Drawing.Point(415, 12);
            this.chkNulas.Name = "chkNulas";
            this.chkNulas.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.chkNulas.Properties.Appearance.Options.UseFont = true;
            this.chkNulas.Properties.Caption = "Ocultar Nulas";
            this.chkNulas.Size = new System.Drawing.Size(151, 20);
            this.chkNulas.TabIndex = 13;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(636, 11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 49);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Cerrar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmConsultaMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 472);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.chkNulas);
            this.Controls.Add(this.tsHabilitados);
            this.Controls.Add(this.dtHasta);
            this.Controls.Add(this.dtDesde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdCargar);
            this.Controls.Add(this.grDetalleMatricula);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaMatricula";
            this.Text = "frmConsultaMatricula";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grDetalleMatricula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMatricula1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsHabilitados.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNulas.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grDetalleMatricula;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton cmdCargar;
        private System.Windows.Forms.DateTimePicker dtHasta;
        private System.Windows.Forms.DateTimePicker dtDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private dsMatricula dsMatricula1;
        private DevExpress.XtraEditors.ToggleSwitch tsHabilitados;
        private DevExpress.XtraEditors.CheckEdit chkNulas;
        private DevExpress.XtraGrid.Columns.GridColumn colid_matricula;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colnula;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_posteo;
        private DevExpress.XtraGrid.Columns.GridColumn colid_detalle;
        private DevExpress.XtraGrid.Columns.GridColumn colprofe;
        private DevExpress.XtraGrid.Columns.GridColumn colnivel;
        private DevExpress.XtraEditors.SimpleButton btnClose;
    }
}