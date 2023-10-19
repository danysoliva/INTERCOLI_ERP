
namespace ERP_INTECOLI.Administracion.Caja
{
    partial class frmArqueoCaja
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtTotalTarjeta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalEfectivo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.grTarjetas = new DevExpress.XtraGrid.GridControl();
            this.dsCaja1 = new ERP_INTECOLI.Administracion.Caja.dsCaja();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcliente1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmonto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dtFechaFacturas = new DevExpress.XtraEditors.DateEdit();
            this.grEfectivo = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmonto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtTotalNulas = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFechaNulas = new DevExpress.XtraEditors.DateEdit();
            this.grNulas = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcliente2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmonto2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtTotalBoleta = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmdRefreshBoletas = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dtFechaBoletas = new DevExpress.XtraEditors.DateEdit();
            this.grBoletas = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcliente3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmonto3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grTarjetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCaja1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaFacturas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaFacturas.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grEfectivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaNulas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaNulas.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grNulas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaBoletas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaBoletas.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grBoletas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(689, 529);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtTotalTarjeta);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtTotalEfectivo);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.grTarjetas);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.simpleButton2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.dtFechaFacturas);
            this.tabPage1.Controls.Add(this.grEfectivo);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(681, 503);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Facturas Validas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtTotalTarjeta
            // 
            this.txtTotalTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalTarjeta.Location = new System.Drawing.Point(485, 464);
            this.txtTotalTarjeta.Name = "txtTotalTarjeta";
            this.txtTotalTarjeta.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalTarjeta.Size = new System.Drawing.Size(174, 24);
            this.txtTotalTarjeta.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(426, 464);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 24);
            this.label9.TabIndex = 26;
            this.label9.Text = "Total:";
            // 
            // txtTotalEfectivo
            // 
            this.txtTotalEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalEfectivo.Location = new System.Drawing.Point(485, 227);
            this.txtTotalEfectivo.Name = "txtTotalEfectivo";
            this.txtTotalEfectivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalEfectivo.Size = new System.Drawing.Size(174, 24);
            this.txtTotalEfectivo.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(426, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 24);
            this.label8.TabIndex = 24;
            this.label8.Text = "Total:";
            // 
            // grTarjetas
            // 
            this.grTarjetas.DataMember = "tarjeta";
            this.grTarjetas.DataSource = this.dsCaja1;
            this.grTarjetas.Location = new System.Drawing.Point(11, 265);
            this.grTarjetas.MainView = this.gridView2;
            this.grTarjetas.Name = "grTarjetas";
            this.grTarjetas.Size = new System.Drawing.Size(650, 198);
            this.grTarjetas.TabIndex = 23;
            this.grTarjetas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // dsCaja1
            // 
            this.dsCaja1.DataSetName = "dsCaja";
            this.dsCaja1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.colnumero1,
            this.colcliente1,
            this.colmonto1});
            this.gridView2.GridControl = this.grTarjetas;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            this.colid1.OptionsColumn.ReadOnly = true;
            // 
            // colnumero1
            // 
            this.colnumero1.Caption = "Numero Doc";
            this.colnumero1.FieldName = "numero";
            this.colnumero1.Name = "colnumero1";
            this.colnumero1.OptionsColumn.ReadOnly = true;
            this.colnumero1.Visible = true;
            this.colnumero1.VisibleIndex = 0;
            // 
            // colcliente1
            // 
            this.colcliente1.Caption = "Cliente";
            this.colcliente1.FieldName = "cliente";
            this.colcliente1.Name = "colcliente1";
            this.colcliente1.OptionsColumn.ReadOnly = true;
            this.colcliente1.Visible = true;
            this.colcliente1.VisibleIndex = 1;
            // 
            // colmonto1
            // 
            this.colmonto1.Caption = "Monto";
            this.colmonto1.DisplayFormat.FormatString = "###,##0.00";
            this.colmonto1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colmonto1.FieldName = "monto";
            this.colmonto1.Name = "colmonto1";
            this.colmonto1.OptionsColumn.ReadOnly = true;
            this.colmonto1.Visible = true;
            this.colmonto1.VisibleIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tarjeta";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.Location = new System.Drawing.Point(598, 2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 21;
            this.simpleButton2.Text = "Refresh";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(334, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Fecha ";
            // 
            // dtFechaFacturas
            // 
            this.dtFechaFacturas.EditValue = null;
            this.dtFechaFacturas.Location = new System.Drawing.Point(386, 3);
            this.dtFechaFacturas.Name = "dtFechaFacturas";
            this.dtFechaFacturas.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaFacturas.Properties.Appearance.Options.UseFont = true;
            this.dtFechaFacturas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaFacturas.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaFacturas.Size = new System.Drawing.Size(128, 22);
            this.dtFechaFacturas.TabIndex = 19;
            // 
            // grEfectivo
            // 
            this.grEfectivo.DataMember = "efectivo";
            this.grEfectivo.DataSource = this.dsCaja1;
            this.grEfectivo.Location = new System.Drawing.Point(9, 26);
            this.grEfectivo.MainView = this.gridView1;
            this.grEfectivo.Name = "grEfectivo";
            this.grEfectivo.Size = new System.Drawing.Size(650, 198);
            this.grEfectivo.TabIndex = 17;
            this.grEfectivo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colnumero,
            this.colcliente,
            this.colmonto});
            this.gridView1.GridControl = this.grEfectivo;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.ReadOnly = true;
            // 
            // colnumero
            // 
            this.colnumero.Caption = "Numero Doc";
            this.colnumero.FieldName = "numero";
            this.colnumero.Name = "colnumero";
            this.colnumero.OptionsColumn.ReadOnly = true;
            this.colnumero.Visible = true;
            this.colnumero.VisibleIndex = 0;
            // 
            // colcliente
            // 
            this.colcliente.Caption = "Cliente";
            this.colcliente.FieldName = "cliente";
            this.colcliente.Name = "colcliente";
            this.colcliente.OptionsColumn.ReadOnly = true;
            this.colcliente.Visible = true;
            this.colcliente.VisibleIndex = 1;
            // 
            // colmonto
            // 
            this.colmonto.Caption = "Monto";
            this.colmonto.DisplayFormat.FormatString = "###,##0.00";
            this.colmonto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colmonto.FieldName = "monto";
            this.colmonto.Name = "colmonto";
            this.colmonto.OptionsColumn.ReadOnly = true;
            this.colmonto.Visible = true;
            this.colmonto.VisibleIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Efectivo";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtTotalNulas);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.simpleButton1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dtFechaNulas);
            this.tabPage2.Controls.Add(this.grNulas);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(681, 503);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Facturas Nulas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtTotalNulas
            // 
            this.txtTotalNulas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalNulas.Location = new System.Drawing.Point(485, 464);
            this.txtTotalNulas.Name = "txtTotalNulas";
            this.txtTotalNulas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalNulas.Size = new System.Drawing.Size(174, 24);
            this.txtTotalNulas.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(426, 464);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 24);
            this.label10.TabIndex = 28;
            this.label10.Text = "Total:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Location = new System.Drawing.Point(584, 9);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 26;
            this.simpleButton1.Text = "Refresh";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(334, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Fecha ";
            // 
            // dtFechaNulas
            // 
            this.dtFechaNulas.EditValue = null;
            this.dtFechaNulas.Location = new System.Drawing.Point(386, 10);
            this.dtFechaNulas.Name = "dtFechaNulas";
            this.dtFechaNulas.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaNulas.Properties.Appearance.Options.UseFont = true;
            this.dtFechaNulas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaNulas.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaNulas.Size = new System.Drawing.Size(128, 22);
            this.dtFechaNulas.TabIndex = 24;
            // 
            // grNulas
            // 
            this.grNulas.DataMember = "nulas";
            this.grNulas.DataSource = this.dsCaja1;
            this.grNulas.Location = new System.Drawing.Point(9, 33);
            this.grNulas.MainView = this.gridView3;
            this.grNulas.Name = "grNulas";
            this.grNulas.Size = new System.Drawing.Size(650, 425);
            this.grNulas.TabIndex = 23;
            this.grNulas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid2,
            this.colnumero2,
            this.colcliente2,
            this.colmonto2});
            this.gridView3.GridControl = this.grNulas;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colid2
            // 
            this.colid2.FieldName = "id";
            this.colid2.Name = "colid2";
            this.colid2.OptionsColumn.ReadOnly = true;
            // 
            // colnumero2
            // 
            this.colnumero2.Caption = "Numero Doc";
            this.colnumero2.FieldName = "numero";
            this.colnumero2.Name = "colnumero2";
            this.colnumero2.OptionsColumn.ReadOnly = true;
            this.colnumero2.Visible = true;
            this.colnumero2.VisibleIndex = 0;
            // 
            // colcliente2
            // 
            this.colcliente2.Caption = "Cliente";
            this.colcliente2.FieldName = "cliente";
            this.colcliente2.Name = "colcliente2";
            this.colcliente2.OptionsColumn.ReadOnly = true;
            this.colcliente2.Visible = true;
            this.colcliente2.VisibleIndex = 1;
            // 
            // colmonto2
            // 
            this.colmonto2.Caption = "Monto";
            this.colmonto2.DisplayFormat.FormatString = "###,##0.00";
            this.colmonto2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colmonto2.FieldName = "monto";
            this.colmonto2.Name = "colmonto2";
            this.colmonto2.OptionsColumn.ReadOnly = true;
            this.colmonto2.Visible = true;
            this.colmonto2.VisibleIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Facturas Nulas";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtTotalBoleta);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.cmdRefreshBoletas);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.dtFechaBoletas);
            this.tabPage3.Controls.Add(this.grBoletas);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(681, 503);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Boletas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtTotalBoleta
            // 
            this.txtTotalBoleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalBoleta.Location = new System.Drawing.Point(484, 237);
            this.txtTotalBoleta.Name = "txtTotalBoleta";
            this.txtTotalBoleta.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalBoleta.Size = new System.Drawing.Size(174, 24);
            this.txtTotalBoleta.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(425, 237);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 24);
            this.label11.TabIndex = 30;
            this.label11.Text = "Total:";
            // 
            // cmdRefreshBoletas
            // 
            this.cmdRefreshBoletas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRefreshBoletas.Location = new System.Drawing.Point(583, 8);
            this.cmdRefreshBoletas.Name = "cmdRefreshBoletas";
            this.cmdRefreshBoletas.Size = new System.Drawing.Size(75, 23);
            this.cmdRefreshBoletas.TabIndex = 26;
            this.cmdRefreshBoletas.Text = "Refresh";
            this.cmdRefreshBoletas.Click += new System.EventHandler(this.cmdRefreshBoletas_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(333, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Fecha ";
            // 
            // dtFechaBoletas
            // 
            this.dtFechaBoletas.EditValue = null;
            this.dtFechaBoletas.Location = new System.Drawing.Point(385, 9);
            this.dtFechaBoletas.Name = "dtFechaBoletas";
            this.dtFechaBoletas.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaBoletas.Properties.Appearance.Options.UseFont = true;
            this.dtFechaBoletas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaBoletas.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaBoletas.Size = new System.Drawing.Size(128, 22);
            this.dtFechaBoletas.TabIndex = 24;
            // 
            // grBoletas
            // 
            this.grBoletas.DataMember = "boletas";
            this.grBoletas.DataSource = this.dsCaja1;
            this.grBoletas.Location = new System.Drawing.Point(8, 32);
            this.grBoletas.MainView = this.gridView4;
            this.grBoletas.Name = "grBoletas";
            this.grBoletas.Size = new System.Drawing.Size(650, 199);
            this.grBoletas.TabIndex = 23;
            this.grBoletas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid3,
            this.colnumero3,
            this.colcliente3,
            this.colmonto3});
            this.gridView4.GridControl = this.grBoletas;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // colid3
            // 
            this.colid3.Caption = "Numero Docsds";
            this.colid3.FieldName = "id";
            this.colid3.Name = "colid3";
            this.colid3.OptionsColumn.ReadOnly = true;
            // 
            // colnumero3
            // 
            this.colnumero3.Caption = "Numero Doc";
            this.colnumero3.FieldName = "numero";
            this.colnumero3.Name = "colnumero3";
            this.colnumero3.OptionsColumn.ReadOnly = true;
            this.colnumero3.Visible = true;
            this.colnumero3.VisibleIndex = 0;
            // 
            // colcliente3
            // 
            this.colcliente3.Caption = "Cliente";
            this.colcliente3.FieldName = "cliente";
            this.colcliente3.Name = "colcliente3";
            this.colcliente3.OptionsColumn.ReadOnly = true;
            this.colcliente3.Visible = true;
            this.colcliente3.VisibleIndex = 1;
            // 
            // colmonto3
            // 
            this.colmonto3.Caption = "Monto";
            this.colmonto3.DisplayFormat.FormatString = "###,##0.00";
            this.colmonto3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colmonto3.FieldName = "monto";
            this.colmonto3.Name = "colmonto3";
            this.colmonto3.OptionsColumn.ReadOnly = true;
            this.colmonto3.Visible = true;
            this.colmonto3.VisibleIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 24);
            this.label7.TabIndex = 22;
            this.label7.Text = "Boletas";
            // 
            // frmArqueoCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 529);
            this.Controls.Add(this.tabControl1);
            this.IconOptions.ShowIcon = false;
            this.Name = "frmArqueoCaja";
            this.Text = "Arqueo Caja";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grTarjetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCaja1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaFacturas.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaFacturas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grEfectivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaNulas.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaNulas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grNulas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaBoletas.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaBoletas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grBoletas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtTotalTarjeta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotalEfectivo;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraGrid.GridControl grTarjetas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero1;
        private DevExpress.XtraGrid.Columns.GridColumn colcliente1;
        private DevExpress.XtraGrid.Columns.GridColumn colmonto1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.DateEdit dtFechaFacturas;
        private DevExpress.XtraGrid.GridControl grEfectivo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero;
        private DevExpress.XtraGrid.Columns.GridColumn colcliente;
        private DevExpress.XtraGrid.Columns.GridColumn colmonto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtTotalNulas;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit dtFechaNulas;
        private DevExpress.XtraGrid.GridControl grNulas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colid2;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero2;
        private DevExpress.XtraGrid.Columns.GridColumn colcliente2;
        private DevExpress.XtraGrid.Columns.GridColumn colmonto2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtTotalBoleta;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.SimpleButton cmdRefreshBoletas;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.DateEdit dtFechaBoletas;
        private DevExpress.XtraGrid.GridControl grBoletas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colid3;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero3;
        private DevExpress.XtraGrid.Columns.GridColumn colcliente3;
        private DevExpress.XtraGrid.Columns.GridColumn colmonto3;
        private System.Windows.Forms.Label label7;
        private dsCaja dsCaja1;
    }
}