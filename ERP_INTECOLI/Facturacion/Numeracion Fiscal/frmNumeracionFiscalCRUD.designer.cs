
namespace JAGUAR_APP.Facturacion.Numeracion_Fiscal
{
    partial class frmNumeracionFiscalCRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNumeracionFiscalCRUD));
            this.txtCAI = new DevExpress.XtraEditors.TextEdit();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.deFechaEmision = new DevExpress.XtraEditors.DateEdit();
            this.deFechaVence = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumIni = new DevExpress.XtraEditors.TextEdit();
            this.txtNumFin = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.luEstado = new DevExpress.XtraEditors.LookUpEdit();
            this.estadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNumeracionFiscal = new JAGUAR_APP.Facturacion.Numeracion_Fiscal.dsNumeracionFiscal();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.tsSecuencia = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.lueTypeDoc = new DevExpress.XtraEditors.LookUpEdit();
            this.typedocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.sluePDV = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.pDVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtCAI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaEmision.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaEmision.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaVence.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaVence.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumIni.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumFin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNumeracionFiscal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsSecuencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTypeDoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typedocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sluePDV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCAI
            // 
            this.txtCAI.Location = new System.Drawing.Point(186, 96);
            this.txtCAI.Name = "txtCAI";
            this.txtCAI.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCAI.Properties.Appearance.Options.UseFont = true;
            this.txtCAI.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCAI.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtCAI.Properties.MaskSettings.Set("allowBlankInput", true);
            this.txtCAI.Properties.MaskSettings.Set("mask", resources.GetString("txtCAI.Properties.MaskSettings"));
            this.txtCAI.Size = new System.Drawing.Size(398, 26);
            this.txtCAI.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.Appearance.Options.UseTextOptions = true;
            this.btnGuardar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnGuardar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnGuardar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGuardar.ImageOptions.SvgImage")));
            this.btnGuardar.Location = new System.Drawing.Point(195, 387);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 58);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(26, 101);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(217, 19);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "CAI:__________________";
            // 
            // deFechaEmision
            // 
            this.deFechaEmision.EditValue = null;
            this.deFechaEmision.Location = new System.Drawing.Point(186, 131);
            this.deFechaEmision.Name = "deFechaEmision";
            this.deFechaEmision.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deFechaEmision.Properties.Appearance.Options.UseFont = true;
            this.deFechaEmision.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaEmision.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaEmision.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent;
            this.deFechaEmision.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.deFechaEmision.Size = new System.Drawing.Size(157, 26);
            this.deFechaEmision.TabIndex = 2;
            // 
            // deFechaVence
            // 
            this.deFechaVence.EditValue = null;
            this.deFechaVence.Location = new System.Drawing.Point(186, 166);
            this.deFechaVence.Name = "deFechaVence";
            this.deFechaVence.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deFechaVence.Properties.Appearance.Options.UseFont = true;
            this.deFechaVence.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaVence.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaVence.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent;
            this.deFechaVence.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.deFechaVence.Size = new System.Drawing.Size(157, 26);
            this.deFechaVence.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(25, 169);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(208, 19);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Fecha Vence:__________";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(25, 135);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(202, 19);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Fecha Emisión:________";
            // 
            // txtNumIni
            // 
            this.txtNumIni.Location = new System.Drawing.Point(186, 201);
            this.txtNumIni.Name = "txtNumIni";
            this.txtNumIni.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumIni.Properties.Appearance.Options.UseFont = true;
            this.txtNumIni.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumIni.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.txtNumIni.Properties.MaskSettings.Set("mask", "000-000-00-00000000");
            this.txtNumIni.Size = new System.Drawing.Size(302, 26);
            this.txtNumIni.TabIndex = 4;
            // 
            // txtNumFin
            // 
            this.txtNumFin.Location = new System.Drawing.Point(186, 236);
            this.txtNumFin.Name = "txtNumFin";
            this.txtNumFin.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumFin.Properties.Appearance.Options.UseFont = true;
            this.txtNumFin.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumFin.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.txtNumFin.Properties.MaskSettings.Set("mask", "000-000-00-00000000");
            this.txtNumFin.Size = new System.Drawing.Size(302, 26);
            this.txtNumFin.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(25, 203);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(158, 19);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Numeración Inicial:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(25, 237);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(198, 19);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Numeración Final:_____";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.Appearance.Options.UseTextOptions = true;
            this.btnCancelar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnCancelar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnCancelar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancelar.ImageOptions.SvgImage")));
            this.btnCancelar.Location = new System.Drawing.Point(316, 387);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 58);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // luEstado
            // 
            this.luEstado.Location = new System.Drawing.Point(186, 271);
            this.luEstado.Name = "luEstado";
            this.luEstado.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.luEstado.Properties.Appearance.Options.UseFont = true;
            this.luEstado.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luEstado.Properties.AppearanceDropDown.Options.UseFont = true;
            this.luEstado.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luEstado.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.luEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luEstado.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_estado", "id_estado", 91, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "Descripción", 89, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.luEstado.Properties.DataSource = this.estadoBindingSource;
            this.luEstado.Properties.DisplayMember = "descripcion";
            this.luEstado.Properties.NullText = "";
            this.luEstado.Properties.ValueMember = "id_estado";
            this.luEstado.Size = new System.Drawing.Size(153, 26);
            this.luEstado.TabIndex = 6;
            this.luEstado.EditValueChanged += new System.EventHandler(this.luEstado_EditValueChanged);
            // 
            // estadoBindingSource
            // 
            this.estadoBindingSource.DataMember = "Estado";
            this.estadoBindingSource.DataSource = this.dsNumeracionFiscal;
            // 
            // dsNumeracionFiscal
            // 
            this.dsNumeracionFiscal.DataSetName = "dsNumeracionFiscal";
            this.dsNumeracionFiscal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(25, 271);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(222, 19);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "Estado:________________";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(25, 305);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(180, 19);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "Tipo Documento:____";
            // 
            // tsSecuencia
            // 
            this.tsSecuencia.Location = new System.Drawing.Point(186, 341);
            this.tsSecuencia.Name = "tsSecuencia";
            this.tsSecuencia.Properties.OffText = "No";
            this.tsSecuencia.Properties.OnText = "Si";
            this.tsSecuencia.Size = new System.Drawing.Size(95, 18);
            this.tsSecuencia.TabIndex = 8;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(25, 339);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(138, 19);
            this.labelControl8.TabIndex = 18;
            this.labelControl8.Text = "Tiene Secuencia:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(214, 12);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(175, 23);
            this.labelControl10.TabIndex = 21;
            this.labelControl10.Text = "Numeración Fiscal";
            // 
            // lueTypeDoc
            // 
            this.lueTypeDoc.Location = new System.Drawing.Point(186, 306);
            this.lueTypeDoc.Name = "lueTypeDoc";
            this.lueTypeDoc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lueTypeDoc.Properties.Appearance.Options.UseFont = true;
            this.lueTypeDoc.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueTypeDoc.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lueTypeDoc.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueTypeDoc.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lueTypeDoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTypeDoc.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "Tipo Doc.", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lueTypeDoc.Properties.DataSource = this.typedocBindingSource;
            this.lueTypeDoc.Properties.DisplayMember = "descripcion";
            this.lueTypeDoc.Properties.NullText = "";
            this.lueTypeDoc.Properties.ValueMember = "id";
            this.lueTypeDoc.Size = new System.Drawing.Size(153, 26);
            this.lueTypeDoc.TabIndex = 7;
            // 
            // typedocBindingSource
            // 
            this.typedocBindingSource.DataMember = "typedoc";
            this.typedocBindingSource.DataSource = this.dsNumeracionFiscal;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(25, 63);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(238, 19);
            this.labelControl9.TabIndex = 24;
            this.labelControl9.Text = "Punto de Venta:__________:";
            // 
            // sluePDV
            // 
            this.sluePDV.Location = new System.Drawing.Point(186, 64);
            this.sluePDV.Name = "sluePDV";
            this.sluePDV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.sluePDV.Properties.Appearance.Options.UseFont = true;
            this.sluePDV.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sluePDV.Properties.AppearanceDropDown.Options.UseFont = true;
            this.sluePDV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sluePDV.Properties.DataSource = this.pDVBindingSource;
            this.sluePDV.Properties.DisplayMember = "pdv";
            this.sluePDV.Properties.NullText = "";
            this.sluePDV.Properties.PopupView = this.searchLookUpEdit1View;
            this.sluePDV.Properties.ValueMember = "id";
            this.sluePDV.Size = new System.Drawing.Size(302, 26);
            this.sluePDV.TabIndex = 0;
            // 
            // pDVBindingSource
            // 
            this.pDVBindingSource.DataMember = "PDV";
            this.pDVBindingSource.DataSource = this.dsNumeracionFiscal;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Punto de Venta";
            this.gridColumn1.FieldName = "pdv";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // frmNumeracionFiscalCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 457);
            this.Controls.Add(this.sluePDV);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.lueTypeDoc);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.tsSecuencia);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.luEstado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtNumFin);
            this.Controls.Add(this.txtNumIni);
            this.Controls.Add(this.deFechaVence);
            this.Controls.Add(this.deFechaEmision);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtCAI);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNumeracionFiscalCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numeración Fiscal";
            this.Load += new System.EventHandler(this.frmNumeracionFiscalCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCAI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaEmision.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaEmision.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaVence.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaVence.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumIni.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumFin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNumeracionFiscal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsSecuencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTypeDoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typedocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sluePDV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtCAI;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit deFechaEmision;
        private DevExpress.XtraEditors.DateEdit deFechaVence;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtNumIni;
        private DevExpress.XtraEditors.TextEdit txtNumFin;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.LookUpEdit luEstado;
        private System.Windows.Forms.BindingSource estadoBindingSource;
        private dsNumeracionFiscal dsNumeracionFiscal;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.ToggleSwitch tsSecuencia;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LookUpEdit lueTypeDoc;
        private System.Windows.Forms.BindingSource typedocBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SearchLookUpEdit sluePDV;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.BindingSource pDVBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}