
namespace ERP_INTECOLI.Consultas.ConsultaMovimientosSaldos
{
    partial class frmConsultaEstSaldosCobrables
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsEstSaldosCobrables1 = new ERP_INTECOLI.Consultas.ConsultaMovimientosSaldos.dsEstSaldosCobrables();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCargarDatos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstSaldosCobrables1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "deudores";
            this.gridControl1.DataSource = this.dsEstSaldosCobrables1;
            this.gridControl1.Location = new System.Drawing.Point(2, 74);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(542, 629);
            this.gridControl1.TabIndex = 28;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsEstSaldosCobrables1
            // 
            this.dsEstSaldosCobrables1.DataSetName = "dsEstSaldosCobrables";
            this.dsEstSaldosCobrables1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnum,
            this.colnombre,
            this.colcant});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colnum
            // 
            this.colnum.Caption = "#";
            this.colnum.FieldName = "num";
            this.colnum.Name = "colnum";
            this.colnum.OptionsColumn.AllowEdit = false;
            this.colnum.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "num", "{0}")});
            this.colnum.Visible = true;
            this.colnum.VisibleIndex = 0;
            this.colnum.Width = 44;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.AllowEdit = false;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            this.colnombre.Width = 403;
            // 
            // colcant
            // 
            this.colcant.Caption = "Cantidad";
            this.colcant.FieldName = "cant";
            this.colcant.Name = "colcant";
            this.colcant.OptionsColumn.AllowEdit = false;
            this.colcant.Visible = true;
            this.colcant.VisibleIndex = 2;
            this.colcant.Width = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Saldos Cobrables";
            // 
            // cmbCargarDatos
            // 
            this.cmbCargarDatos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbCargarDatos.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbCargarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCargarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCargarDatos.Image = global::ERP_INTECOLI.Properties.Resources.actualizar_32;
            this.cmbCargarDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmbCargarDatos.Location = new System.Drawing.Point(238, 12);
            this.cmbCargarDatos.Name = "cmbCargarDatos";
            this.cmbCargarDatos.Size = new System.Drawing.Size(141, 50);
            this.cmbCargarDatos.TabIndex = 26;
            this.cmbCargarDatos.Text = "Cargar Datos";
            this.cmbCargarDatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmbCargarDatos.UseVisualStyleBackColor = false;
            this.cmbCargarDatos.Click += new System.EventHandler(this.cmbCargarDatos_Click);
            // 
            // frmConsultaEstSaldosCobrables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 707);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCargarDatos);
            this.Name = "frmConsultaEstSaldosCobrables";
            this.Text = "Deudores Saldo Acumulado";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstSaldosCobrables1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colnum;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colcant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmbCargarDatos;
        private dsEstSaldosCobrables dsEstSaldosCobrables1;
    }
}