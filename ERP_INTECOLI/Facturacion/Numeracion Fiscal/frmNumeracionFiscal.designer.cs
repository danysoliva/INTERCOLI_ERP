
namespace JAGUAR_APP.Facturacion.Numeracion_Fiscal
{
    partial class frmNumeracionFiscal
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleContains formatConditionRuleContains1 = new DevExpress.XtraEditors.FormatConditionRuleContains();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNumeracionFiscal));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.colEstado_desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.numeracionFiscalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNumeracionFiscal = new JAGUAR_APP.Facturacion.Numeracion_Fiscal.dsNumeracionFiscal();
            this.gvNumeracionFiscal = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_emision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_vence = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_ini = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_fin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcreated_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcreated_by = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcreated_from = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkind = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgen_corr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcorrelative = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colleyenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypeDoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdRefresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeracionFiscalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNumeracionFiscal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNumeracionFiscal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            this.SuspendLayout();
            // 
            // colEstado_desc
            // 
            this.colEstado_desc.Caption = "Estado";
            this.colEstado_desc.FieldName = "estado";
            this.colEstado_desc.Name = "colEstado_desc";
            this.colEstado_desc.OptionsColumn.AllowEdit = false;
            this.colEstado_desc.OptionsColumn.ReadOnly = true;
            this.colEstado_desc.OptionsFilter.AllowFilter = false;
            this.colEstado_desc.Visible = true;
            this.colEstado_desc.VisibleIndex = 7;
            this.colEstado_desc.Width = 74;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.numeracionFiscalBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(-1, 84);
            this.gridControl1.MainView = this.gvNumeracionFiscal;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEditar});
            this.gridControl1.Size = new System.Drawing.Size(1526, 535);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNumeracionFiscal});
            // 
            // numeracionFiscalBindingSource
            // 
            this.numeracionFiscalBindingSource.DataMember = "Numeracion_Fiscal";
            this.numeracionFiscalBindingSource.DataSource = this.dsNumeracionFiscal;
            // 
            // dsNumeracionFiscal
            // 
            this.dsNumeracionFiscal.DataSetName = "dsNumeracionFiscal";
            this.dsNumeracionFiscal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvNumeracionFiscal
            // 
            this.gvNumeracionFiscal.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvNumeracionFiscal.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvNumeracionFiscal.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.gvNumeracionFiscal.Appearance.Row.Options.UseFont = true;
            this.gvNumeracionFiscal.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colcai,
            this.colfecha_emision,
            this.colfecha_vence,
            this.colnum_ini,
            this.colnum_fin,
            this.colestado,
            this.colcreated_date,
            this.colcreated_by,
            this.colcreated_from,
            this.colkind,
            this.colgen_corr,
            this.colcorrelative,
            this.colleyenda,
            this.colTypeDoc,
            this.gridColumn1,
            this.colEstado_desc,
            this.gridColumn2});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.colEstado_desc;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleContains1.PredefinedName = "Green Fill, Green Text";
            formatConditionRuleContains1.Values = ((System.Collections.IList)(resources.GetObject("formatConditionRuleContains1.Values")));
            gridFormatRule1.Rule = formatConditionRuleContains1;
            this.gvNumeracionFiscal.FormatRules.Add(gridFormatRule1);
            this.gvNumeracionFiscal.GridControl = this.gridControl1;
            this.gvNumeracionFiscal.Name = "gvNumeracionFiscal";
            this.gvNumeracionFiscal.OptionsView.ShowAutoFilterRow = true;
            this.gvNumeracionFiscal.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colcai
            // 
            this.colcai.Caption = "CAI";
            this.colcai.FieldName = "cai";
            this.colcai.Name = "colcai";
            this.colcai.OptionsColumn.ReadOnly = true;
            this.colcai.OptionsFilter.AllowFilter = false;
            this.colcai.Visible = true;
            this.colcai.VisibleIndex = 2;
            this.colcai.Width = 309;
            // 
            // colfecha_emision
            // 
            this.colfecha_emision.Caption = "Fecha Emisión";
            this.colfecha_emision.FieldName = "fecha_emision";
            this.colfecha_emision.Name = "colfecha_emision";
            this.colfecha_emision.OptionsColumn.ReadOnly = true;
            this.colfecha_emision.OptionsFilter.AllowFilter = false;
            this.colfecha_emision.Visible = true;
            this.colfecha_emision.VisibleIndex = 3;
            this.colfecha_emision.Width = 144;
            // 
            // colfecha_vence
            // 
            this.colfecha_vence.Caption = "Fecha Vence";
            this.colfecha_vence.FieldName = "fecha_vence";
            this.colfecha_vence.Name = "colfecha_vence";
            this.colfecha_vence.OptionsColumn.ReadOnly = true;
            this.colfecha_vence.OptionsFilter.AllowFilter = false;
            this.colfecha_vence.Visible = true;
            this.colfecha_vence.VisibleIndex = 4;
            this.colfecha_vence.Width = 123;
            // 
            // colnum_ini
            // 
            this.colnum_ini.Caption = "Num. Inicial";
            this.colnum_ini.FieldName = "num_ini";
            this.colnum_ini.Name = "colnum_ini";
            this.colnum_ini.OptionsColumn.ReadOnly = true;
            this.colnum_ini.OptionsFilter.AllowFilter = false;
            this.colnum_ini.Visible = true;
            this.colnum_ini.VisibleIndex = 5;
            this.colnum_ini.Width = 164;
            // 
            // colnum_fin
            // 
            this.colnum_fin.Caption = "Num. Fin";
            this.colnum_fin.FieldName = "num_fin";
            this.colnum_fin.Name = "colnum_fin";
            this.colnum_fin.OptionsColumn.ReadOnly = true;
            this.colnum_fin.OptionsFilter.AllowFilter = false;
            this.colnum_fin.Visible = true;
            this.colnum_fin.VisibleIndex = 6;
            this.colnum_fin.Width = 151;
            // 
            // colestado
            // 
            this.colestado.Caption = "Estado";
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            this.colestado.OptionsColumn.AllowEdit = false;
            this.colestado.OptionsFilter.AllowFilter = false;
            this.colestado.Width = 89;
            // 
            // colcreated_date
            // 
            this.colcreated_date.FieldName = "created_date";
            this.colcreated_date.Name = "colcreated_date";
            this.colcreated_date.Width = 123;
            // 
            // colcreated_by
            // 
            this.colcreated_by.FieldName = "created_by";
            this.colcreated_by.Name = "colcreated_by";
            this.colcreated_by.Width = 85;
            // 
            // colcreated_from
            // 
            this.colcreated_from.FieldName = "created_from";
            this.colcreated_from.Name = "colcreated_from";
            this.colcreated_from.Width = 96;
            // 
            // colkind
            // 
            this.colkind.Caption = "Kind";
            this.colkind.FieldName = "kind";
            this.colkind.Name = "colkind";
            this.colkind.Width = 46;
            // 
            // colgen_corr
            // 
            this.colgen_corr.FieldName = "gen_corr";
            this.colgen_corr.Name = "colgen_corr";
            this.colgen_corr.Width = 79;
            // 
            // colcorrelative
            // 
            this.colcorrelative.Caption = "Correlative";
            this.colcorrelative.FieldName = "correlative";
            this.colcorrelative.Name = "colcorrelative";
            this.colcorrelative.OptionsColumn.ReadOnly = true;
            this.colcorrelative.OptionsFilter.AllowFilter = false;
            this.colcorrelative.Visible = true;
            this.colcorrelative.VisibleIndex = 8;
            this.colcorrelative.Width = 94;
            // 
            // colleyenda
            // 
            this.colleyenda.FieldName = "leyenda";
            this.colleyenda.Name = "colleyenda";
            // 
            // colTypeDoc
            // 
            this.colTypeDoc.Caption = "Tipo Doc.";
            this.colTypeDoc.FieldName = "tipo_documento";
            this.colTypeDoc.Name = "colTypeDoc";
            this.colTypeDoc.OptionsColumn.ReadOnly = true;
            this.colTypeDoc.OptionsFilter.AllowFilter = false;
            this.colTypeDoc.Visible = true;
            this.colTypeDoc.VisibleIndex = 1;
            this.colTypeDoc.Width = 95;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Editar";
            this.gridColumn1.ColumnEdit = this.btnEditar;
            this.gridColumn1.MaxWidth = 100;
            this.gridColumn1.MinWidth = 100;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 9;
            this.gridColumn1.Width = 100;
            // 
            // btnEditar
            // 
            this.btnEditar.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            this.btnEditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnEditar.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnEditar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnEditar_ButtonClick);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Punto de Venta";
            this.gridColumn2.FieldName = "pdv";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.OptionsFilter.AllowFilter = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 247;
            // 
            // btnAdd
            // 
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnAdd.Location = new System.Drawing.Point(28, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 55);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancel.ImageOptions.SvgImage")));
            this.btnCancel.Location = new System.Drawing.Point(1442, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(57, 55);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(-1, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(1526, 23);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Numeración Fiscal";
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRefresh.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdRefresh.Appearance.Options.UseFont = true;
            this.cmdRefresh.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdRefresh.ImageOptions.Image")));
            this.cmdRefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdRefresh.Location = new System.Drawing.Point(1322, 12);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(99, 55);
            this.cmdRefresh.TabIndex = 72;
            this.cmdRefresh.Text = "Refresh";
            this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
            // 
            // frmNumeracionFiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1525, 620);
            this.Controls.Add(this.cmdRefresh);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNumeracionFiscal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numeración Fiscal";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeracionFiscalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNumeracionFiscal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNumeracionFiscal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNumeracionFiscal;
        private System.Windows.Forms.BindingSource numeracionFiscalBindingSource;
        private dsNumeracionFiscal dsNumeracionFiscal;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcai;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_emision;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_vence;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_ini;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_fin;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraGrid.Columns.GridColumn colcreated_date;
        private DevExpress.XtraGrid.Columns.GridColumn colcreated_by;
        private DevExpress.XtraGrid.Columns.GridColumn colcreated_from;
        private DevExpress.XtraGrid.Columns.GridColumn colkind;
        private DevExpress.XtraGrid.Columns.GridColumn colgen_corr;
        private DevExpress.XtraGrid.Columns.GridColumn colcorrelative;
        private DevExpress.XtraGrid.Columns.GridColumn colleyenda;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeDoc;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEditar;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado_desc;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.SimpleButton cmdRefresh;
    }
}