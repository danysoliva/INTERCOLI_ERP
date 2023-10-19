
namespace JAGUAR_APP.Facturacion.Configuraciones
{
    partial class xfrmPDVAsignadasView
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmPDVAsignadasView));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsListaPreciosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsListaPrecios = new JAGUAR_APP.Facturacion.Configuraciones.dsListaPrecios();
            this.gvLP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_listaPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_pt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcreated_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_pdv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpdv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAnular = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.lblProducto = new DevExpress.XtraEditors.LabelControl();
            this.lblListaPrecios = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListaPreciosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListaPrecios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnular)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "ListaPreciosProductosAplicaPDV";
            this.gridControl1.DataSource = this.dsListaPreciosBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(2, 56);
            this.gridControl1.MainView = this.gvLP;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEditar,
            this.btnAnular});
            this.gridControl1.Size = new System.Drawing.Size(817, 283);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLP});
            // 
            // dsListaPreciosBindingSource
            // 
            this.dsListaPreciosBindingSource.DataSource = this.dsListaPrecios;
            this.dsListaPreciosBindingSource.Position = 0;
            // 
            // dsListaPrecios
            // 
            this.dsListaPrecios.DataSetName = "dsListaPrecios";
            this.dsListaPrecios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvLP
            // 
            this.gvLP.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gvLP.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvLP.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gvLP.Appearance.Row.Options.UseFont = true;
            this.gvLP.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_listaPrecio,
            this.colid_pt,
            this.colpt,
            this.colprecio,
            this.colcreated_date,
            this.colid_pdv,
            this.colpdv,
            this.gridColumn1,
            this.gridColumn2});
            this.gvLP.GridControl = this.gridControl1;
            this.gvLP.Name = "gvLP";
            this.gvLP.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colid_listaPrecio
            // 
            this.colid_listaPrecio.FieldName = "id_listaPrecio";
            this.colid_listaPrecio.Name = "colid_listaPrecio";
            // 
            // colid_pt
            // 
            this.colid_pt.FieldName = "id_pt";
            this.colid_pt.Name = "colid_pt";
            // 
            // colpt
            // 
            this.colpt.Caption = "Producto";
            this.colpt.FieldName = "pt";
            this.colpt.Name = "colpt";
            this.colpt.OptionsColumn.ReadOnly = true;
            this.colpt.OptionsFilter.AllowFilter = false;
            this.colpt.Visible = true;
            this.colpt.VisibleIndex = 1;
            this.colpt.Width = 178;
            // 
            // colprecio
            // 
            this.colprecio.Caption = "Precio";
            this.colprecio.FieldName = "precio";
            this.colprecio.Name = "colprecio";
            this.colprecio.OptionsColumn.ReadOnly = true;
            this.colprecio.OptionsFilter.AllowFilter = false;
            this.colprecio.Visible = true;
            this.colprecio.VisibleIndex = 2;
            this.colprecio.Width = 109;
            // 
            // colcreated_date
            // 
            this.colcreated_date.Caption = "Fecha Creación";
            this.colcreated_date.FieldName = "created_date";
            this.colcreated_date.Name = "colcreated_date";
            this.colcreated_date.OptionsColumn.ReadOnly = true;
            this.colcreated_date.OptionsFilter.AllowFilter = false;
            this.colcreated_date.Width = 115;
            // 
            // colid_pdv
            // 
            this.colid_pdv.FieldName = "id_pdv";
            this.colid_pdv.Name = "colid_pdv";
            // 
            // colpdv
            // 
            this.colpdv.Caption = "Punto de Venta";
            this.colpdv.FieldName = "pdv";
            this.colpdv.Name = "colpdv";
            this.colpdv.OptionsColumn.ReadOnly = true;
            this.colpdv.OptionsFilter.AllowFilter = false;
            this.colpdv.Visible = true;
            this.colpdv.VisibleIndex = 0;
            this.colpdv.Width = 425;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Editar";
            this.gridColumn1.ColumnEdit = this.btnEditar;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            // 
            // btnEditar
            // 
            this.btnEditar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnEditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnEditar.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnEditar_ButtonPressed);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Anular";
            this.gridColumn2.ColumnEdit = this.btnAnular;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            // 
            // btnAnular
            // 
            this.btnAnular.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnAnular.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnAnular.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnAnular_ButtonPressed);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.PowderBlue;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(691, 5);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(116, 45);
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "Home";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // lblProducto
            // 
            this.lblProducto.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Appearance.Options.UseFont = true;
            this.lblProducto.Appearance.Options.UseTextOptions = true;
            this.lblProducto.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblProducto.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblProducto.Location = new System.Drawing.Point(2, 5);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(737, 20);
            this.lblProducto.TabIndex = 11;
            this.lblProducto.Text = "Producto";
            // 
            // lblListaPrecios
            // 
            this.lblListaPrecios.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaPrecios.Appearance.Options.UseFont = true;
            this.lblListaPrecios.Appearance.Options.UseTextOptions = true;
            this.lblListaPrecios.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblListaPrecios.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblListaPrecios.Location = new System.Drawing.Point(2, 30);
            this.lblListaPrecios.Name = "lblListaPrecios";
            this.lblListaPrecios.Size = new System.Drawing.Size(737, 20);
            this.lblListaPrecios.TabIndex = 12;
            this.lblListaPrecios.Text = "Lista de Precios";
            // 
            // xfrmPDVAsignadasView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 337);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblListaPrecios);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "xfrmPDVAsignadasView";
            this.Text = "Precio Aplicado a Tiendass";
            this.Load += new System.EventHandler(this.xfrmPDVAsignadasView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListaPreciosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListaPrecios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLP;
        private System.Windows.Forms.BindingSource dsListaPreciosBindingSource;
        private dsListaPrecios dsListaPrecios;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_listaPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn colid_pt;
        private DevExpress.XtraGrid.Columns.GridColumn colpt;
        private DevExpress.XtraGrid.Columns.GridColumn colprecio;
        private DevExpress.XtraGrid.Columns.GridColumn colcreated_date;
        private DevExpress.XtraGrid.Columns.GridColumn colid_pdv;
        private DevExpress.XtraGrid.Columns.GridColumn colpdv;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl lblProducto;
        private DevExpress.XtraEditors.LabelControl lblListaPrecios;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEditar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnAnular;
    }
}