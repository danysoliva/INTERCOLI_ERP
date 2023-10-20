
namespace ERP_INTECOLI.Administracion.Estudiantes
{
    partial class frmHistoarialAntiguedad
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
            this.txtParametro = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsAntiguedad1 = new ERP_INTECOLI.Administracion.Estudiantes.dsAntiguedad();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_inicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_fin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coledad = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtParametro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAntiguedad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtParametro
            // 
            this.txtParametro.Enabled = false;
            this.txtParametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParametro.Location = new System.Drawing.Point(81, 28);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(270, 26);
            this.txtParametro.TabIndex = 5;
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel1.Location = new System.Drawing.Point(17, 32);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(73, 18);
            this.ultraLabel1.TabIndex = 4;
            this.ultraLabel1.Text = "Nombre:";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "intervalos";
            this.gridControl1.DataSource = this.dsAntiguedad1;
            this.gridControl1.Location = new System.Drawing.Point(3, 60);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(545, 314);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsAntiguedad1
            // 
            this.dsAntiguedad1.DataSetName = "dsAntiguedad";
            this.dsAntiguedad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colfecha_inicio,
            this.colfecha_fin,
            this.coledad});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // colfecha_inicio
            // 
            this.colfecha_inicio.Caption = "Desde";
            this.colfecha_inicio.FieldName = "fecha_inicio";
            this.colfecha_inicio.Name = "colfecha_inicio";
            this.colfecha_inicio.OptionsColumn.AllowEdit = false;
            this.colfecha_inicio.Visible = true;
            this.colfecha_inicio.VisibleIndex = 0;
            this.colfecha_inicio.Width = 89;
            // 
            // colfecha_fin
            // 
            this.colfecha_fin.Caption = "Hasta";
            this.colfecha_fin.FieldName = "fecha_fin";
            this.colfecha_fin.Name = "colfecha_fin";
            this.colfecha_fin.OptionsColumn.AllowEdit = false;
            this.colfecha_fin.Visible = true;
            this.colfecha_fin.VisibleIndex = 1;
            this.colfecha_fin.Width = 102;
            // 
            // coledad
            // 
            this.coledad.Caption = "Periodo";
            this.coledad.FieldName = "edad";
            this.coledad.Name = "coledad";
            this.coledad.OptionsColumn.AllowEdit = false;
            this.coledad.Visible = true;
            this.coledad.VisibleIndex = 2;
            this.coledad.Width = 324;
            // 
            // frmHistoarialAntiguedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 378);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.txtParametro);
            this.Controls.Add(this.ultraLabel1);
            this.MaximizeBox = false;
            this.Name = "frmHistoarialAntiguedad";
            this.Text = "Historial Antiguedad";
            ((System.ComponentModel.ISupportInitialize)(this.txtParametro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAntiguedad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtParametro;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_inicio;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_fin;
        private DevExpress.XtraGrid.Columns.GridColumn coledad;
        private dsAntiguedad dsAntiguedad1;
    }
}