
namespace JAGUAR_APP.Facturacion.CoreFacturas
{
    partial class frmPTFromKardexFacturacion
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPTFromKardexFacturacion));
            this.gcPT = new DevExpress.XtraGrid.GridControl();
            this.gvPT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSeleccionar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colDescripcion_Tecnica = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dsFacturasGestion = new JAGUAR_APP.Facturacion.CoreFacturas.dsFacturasGestion();
            ((System.ComponentModel.ISupportInitialize)(this.gcPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturasGestion)).BeginInit();
            this.SuspendLayout();
            // 
            // gcPT
            // 
            this.gcPT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcPT.DataMember = "producto_terminado";
            this.gcPT.DataSource = this.dsFacturasGestion;
            this.gcPT.Location = new System.Drawing.Point(1, 69);
            this.gcPT.MainView = this.gvPT;
            this.gcPT.Name = "gcPT";
            this.gcPT.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnSeleccionar});
            this.gcPT.Size = new System.Drawing.Size(710, 543);
            this.gcPT.TabIndex = 7;
            this.gcPT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPT});
            // 
            // gvPT
            // 
            this.gvPT.Appearance.FocusedCell.BackColor = System.Drawing.Color.LightGreen;
            this.gvPT.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvPT.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightGreen;
            this.gvPT.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.LightGreen;
            this.gvPT.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvPT.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvPT.Appearance.FocusedRow.Options.UseFont = true;
            this.gvPT.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gvPT.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvPT.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightGreen;
            this.gvPT.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvPT.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvPT.Appearance.Row.Options.UseFont = true;
            this.gvPT.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvPT.Appearance.SelectedRow.Options.UseFont = true;
            this.gvPT.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvPT.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvPT.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colproducto,
            this.gridColumn1,
            this.colDescripcion_Tecnica,
            this.gridColumn2,
            this.gridColumn3});
            this.gvPT.GridControl = this.gcPT;
            this.gvPT.Name = "gvPT";
            this.gvPT.OptionsCustomization.AllowFilter = false;
            this.gvPT.OptionsFilter.AllowFilterEditor = false;
            this.gvPT.OptionsView.ShowAutoFilterRow = true;
            this.gvPT.OptionsView.ShowGroupPanel = false;
            this.gvPT.DoubleClick += new System.EventHandler(this.gvMP_DoubleClick);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // colproducto
            // 
            this.colproducto.Caption = "Producto";
            this.colproducto.FieldName = "pt";
            this.colproducto.Name = "colproducto";
            this.colproducto.OptionsColumn.AllowEdit = false;
            this.colproducto.OptionsColumn.ReadOnly = true;
            this.colproducto.Visible = true;
            this.colproducto.VisibleIndex = 1;
            this.colproducto.Width = 316;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Seleccionar";
            this.gridColumn1.ColumnEdit = this.btnSeleccionar;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 103;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.AutoHeight = false;
            //editorButtonImageOptions1.Image = global::JAGUAR_APP.Properties.Resources.tap;
            this.btnSeleccionar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnSeleccionar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnSeleccionar_ButtonClick);
            // 
            // colDescripcion_Tecnica
            // 
            this.colDescripcion_Tecnica.Caption = "Nombre Tecnico";
            this.colDescripcion_Tecnica.FieldName = "Descripcion_Tecnica";
            this.colDescripcion_Tecnica.Name = "colDescripcion_Tecnica";
            this.colDescripcion_Tecnica.OptionsColumn.AllowEdit = false;
            this.colDescripcion_Tecnica.Width = 179;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Codigo";
            this.gridColumn2.FieldName = "code";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 105;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Presentación";
            this.gridColumn3.FieldName = "presentacion";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 161;
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Appearance.Options.UseBackColor = true;
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(533, 7);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(166, 56);
            this.btnAtras.TabIndex = 8;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Producto Terminado";
            // 
            // dsFacturasGestion
            // 
            this.dsFacturasGestion.DataSetName = "dsFacturasGestion";
            this.dsFacturasGestion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmPTFromKardexFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 613);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.gcPT);
            this.IconOptions.ShowIcon = false;
            this.Name = "frmPTFromKardexFacturacion";
            this.Text = "Listado de Producto Terminado";
            ((System.ComponentModel.ISupportInitialize)(this.gcPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturasGestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraGrid.GridControl gcPT;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPT;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSeleccionar;

        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colproducto;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion_Tecnica;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private dsFacturasGestion dsFacturasGestion;
    }
}