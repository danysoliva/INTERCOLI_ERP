
namespace ERP_INTECOLI.Administracion.Caja
{
    partial class frmReprintBoleta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReprintBoleta));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_m = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_es = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_us = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnul = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colval = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfech = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnReimprimir = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colest = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dsCaja1 = new ERP_INTECOLI.Administracion.Caja.dsCaja();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReimprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCaja1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(477, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(84, 26);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "10";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(336, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cargar las ultimas";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "boletas_reprint";
            this.gridControl1.DataSource = this.dsCaja1;
            this.gridControl1.Location = new System.Drawing.Point(5, 50);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnReimprimir});
            this.gridControl1.Size = new System.Drawing.Size(899, 403);
            this.gridControl1.TabIndex = 12;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_m,
            this.colid_es,
            this.colid_us,
            this.colus,
            this.colnul,
            this.colval,
            this.colfech,
            this.colprint,
            this.colest});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colid_m
            // 
            this.colid_m.Caption = "Id Matricula";
            this.colid_m.FieldName = "id_m";
            this.colid_m.Name = "colid_m";
            this.colid_m.Visible = true;
            this.colid_m.VisibleIndex = 0;
            this.colid_m.Width = 76;
            // 
            // colid_es
            // 
            this.colid_es.Caption = "Id Estudiante";
            this.colid_es.FieldName = "id_es";
            this.colid_es.Name = "colid_es";
            this.colid_es.Visible = true;
            this.colid_es.VisibleIndex = 1;
            this.colid_es.Width = 81;
            // 
            // colid_us
            // 
            this.colid_us.FieldName = "id_us";
            this.colid_us.Name = "colid_us";
            // 
            // colus
            // 
            this.colus.Caption = "Usuario";
            this.colus.FieldName = "us";
            this.colus.Name = "colus";
            this.colus.Visible = true;
            this.colus.VisibleIndex = 3;
            this.colus.Width = 91;
            // 
            // colnul
            // 
            this.colnul.Caption = "Nula";
            this.colnul.FieldName = "nul";
            this.colnul.Name = "colnul";
            this.colnul.Visible = true;
            this.colnul.VisibleIndex = 4;
            this.colnul.Width = 54;
            // 
            // colval
            // 
            this.colval.Caption = "Valor";
            this.colval.FieldName = "val";
            this.colval.Name = "colval";
            this.colval.Visible = true;
            this.colval.VisibleIndex = 5;
            this.colval.Width = 82;
            // 
            // colfech
            // 
            this.colfech.Caption = "Fecha";
            this.colfech.FieldName = "fech";
            this.colfech.Name = "colfech";
            this.colfech.Visible = true;
            this.colfech.VisibleIndex = 6;
            this.colfech.Width = 89;
            // 
            // colprint
            // 
            this.colprint.Caption = "Imprimir";
            this.colprint.ColumnEdit = this.btnReimprimir;
            this.colprint.FieldName = "print";
            this.colprint.Name = "colprint";
            this.colprint.Visible = true;
            this.colprint.VisibleIndex = 7;
            this.colprint.Width = 85;
            // 
            // btnReimprimir
            // 
            this.btnReimprimir.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnReimprimir.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnReimprimir.Name = "btnReimprimir";
            this.btnReimprimir.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnReimprimir.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnReimprimir_ButtonClick);
            // 
            // colest
            // 
            this.colest.Caption = "Estudiante";
            this.colest.FieldName = "est";
            this.colest.Name = "colest";
            this.colest.Visible = true;
            this.colest.VisibleIndex = 2;
            this.colest.Width = 221;
            // 
            // dsCaja1
            // 
            this.dsCaja1.DataSetName = "dsCaja";
            this.dsCaja1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmReprintBoleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 457);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.IconOptions.ShowIcon = false;
            this.Name = "frmReprintBoleta";
            this.Text = "Reimprimir Boleta";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReimprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCaja1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_m;
        private DevExpress.XtraGrid.Columns.GridColumn colid_es;
        private DevExpress.XtraGrid.Columns.GridColumn colid_us;
        private DevExpress.XtraGrid.Columns.GridColumn colus;
        private DevExpress.XtraGrid.Columns.GridColumn colnul;
        private DevExpress.XtraGrid.Columns.GridColumn colval;
        private DevExpress.XtraGrid.Columns.GridColumn colfech;
        private DevExpress.XtraGrid.Columns.GridColumn colprint;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnReimprimir;
        private DevExpress.XtraGrid.Columns.GridColumn colest;
        private dsCaja dsCaja1;
    }
}