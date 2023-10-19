
//using JAGUAR_APP.TransaccionesMP;

namespace JAGUAR_APP.Facturacion.CoreFacturas
{
    partial class frmAjusteKardexFactura
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjusteKardexFactura));
            this.dtFechaDocumento = new DevExpress.XtraEditors.DateEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtPT_Name = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tsTipoTransaccion = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCantidadUnidades = new DevExpress.XtraEditors.TextEdit();
            this.txtPresentacion = new DevExpress.XtraEditors.TextEdit();
            this.sluePDV = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.pDVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMantenimientosFacturacion = new JAGUAR_APP.Facturacion.Mantenimientos.dsMantenimientosFacturacion();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDocumento.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPT_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsTipoTransaccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadUnidades.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPresentacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sluePDV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimientosFacturacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // dtFechaDocumento
            // 
            this.dtFechaDocumento.EditValue = null;
            this.dtFechaDocumento.Location = new System.Drawing.Point(221, 238);
            this.dtFechaDocumento.Name = "dtFechaDocumento";
            this.dtFechaDocumento.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dtFechaDocumento.Properties.Appearance.Options.UseFont = true;
            this.dtFechaDocumento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaDocumento.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaDocumento.Properties.CalendarTimeProperties.EditFormat.FormatString = "d";
            this.dtFechaDocumento.Properties.CalendarTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtFechaDocumento.Size = new System.Drawing.Size(355, 26);
            this.dtFechaDocumento.TabIndex = 3;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(23, 237);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(293, 24);
            this.labelControl12.TabIndex = 2;
            this.labelControl12.Text = "Fecha Documento:_____________";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(23, 154);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(174, 24);
            this.labelControl3.TabIndex = 128;
            this.labelControl3.Text = "Tipo de Transacción";
            // 
            // txtPT_Name
            // 
            this.txtPT_Name.Location = new System.Drawing.Point(222, 201);
            this.txtPT_Name.Name = "txtPT_Name";
            this.txtPT_Name.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtPT_Name.Properties.Appearance.Options.UseFont = true;
            //editorButtonImageOptions1.Image = global::JAGUAR_APP.Properties.Resources.ProdT_26X26;
            serializableAppearanceObject1.BackColor = System.Drawing.Color.Transparent;
            serializableAppearanceObject1.Options.UseBackColor = true;
            serializableAppearanceObject2.BackColor = System.Drawing.Color.LightBlue;
            serializableAppearanceObject2.Options.UseBackColor = true;
            serializableAppearanceObject3.BackColor = System.Drawing.Color.LightBlue;
            serializableAppearanceObject3.Options.UseBackColor = true;
            serializableAppearanceObject4.BackColor = System.Drawing.Color.LightBlue;
            serializableAppearanceObject4.Options.UseBackColor = true;
            this.txtPT_Name.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.txtPT_Name.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.txtPT_Name.Properties.Name = "txtPT_Name";
            this.txtPT_Name.Properties.ReadOnly = true;
            this.txtPT_Name.Size = new System.Drawing.Size(355, 30);
            this.txtPT_Name.TabIndex = 1;
            this.txtPT_Name.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtPT_Name_ButtonClick);
            this.txtPT_Name.EditValueChanged += new System.EventHandler(this.txtPT_Name_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(23, 203);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(259, 24);
            this.labelControl2.TabIndex = 127;
            this.labelControl2.Text = "Producto Terminado:________";
            // 
            // tsTipoTransaccion
            // 
            this.tsTipoTransaccion.EditValue = true;
            this.tsTipoTransaccion.Location = new System.Drawing.Point(222, 150);
            this.tsTipoTransaccion.Name = "tsTipoTransaccion";
            this.tsTipoTransaccion.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tsTipoTransaccion.Properties.Appearance.Options.UseFont = true;
            this.tsTipoTransaccion.Properties.OffText = "Salida";
            this.tsTipoTransaccion.Properties.OnText = "Entrada";
            this.tsTipoTransaccion.Size = new System.Drawing.Size(355, 28);
            this.tsTipoTransaccion.TabIndex = 0;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(23, 305);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(226, 24);
            this.labelControl5.TabIndex = 137;
            this.labelControl5.Text = "Punto de Venta:_________";
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cmdGuardar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Appearance.Options.UseBackColor = true;
            this.cmdGuardar.Appearance.Options.UseFont = true;
            this.cmdGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            //this.cmdGuardar.ImageOptions.Image = global::JAGUAR_APP.Properties.Resources.save_24x24;
            this.cmdGuardar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdGuardar.Location = new System.Drawing.Point(22, 29);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(167, 49);
            this.cmdGuardar.TabIndex = 7;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
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
            this.btnAtras.Location = new System.Drawing.Point(411, 29);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(167, 49);
            this.btnAtras.TabIndex = 8;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(22, 271);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(336, 24);
            this.labelControl11.TabIndex = 140;
            this.labelControl11.Text = "Presentación:______________________";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(23, 339);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(336, 24);
            this.labelControl1.TabIndex = 142;
            this.labelControl1.Text = "Unidades:_________________________";
            // 
            // txtCantidadUnidades
            // 
            this.txtCantidadUnidades.EditValue = "0";
            this.txtCantidadUnidades.Location = new System.Drawing.Point(222, 337);
            this.txtCantidadUnidades.Name = "txtCantidadUnidades";
            this.txtCantidadUnidades.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtCantidadUnidades.Properties.Appearance.Options.UseFont = true;
            this.txtCantidadUnidades.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCantidadUnidades.Properties.Mask.EditMask = "n";
            this.txtCantidadUnidades.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCantidadUnidades.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCantidadUnidades.Size = new System.Drawing.Size(355, 26);
            this.txtCantidadUnidades.TabIndex = 6;
            this.txtCantidadUnidades.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidadUnidades_KeyDown);
            this.txtCantidadUnidades.Leave += new System.EventHandler(this.txtCantidadUnidades_Leave);
            // 
            // txtPresentacion
            // 
            this.txtPresentacion.EditValue = "";
            this.txtPresentacion.Location = new System.Drawing.Point(221, 271);
            this.txtPresentacion.Name = "txtPresentacion";
            this.txtPresentacion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtPresentacion.Properties.Appearance.Options.UseFont = true;
            this.txtPresentacion.Properties.NullText = "[EditValue is null]";
            this.txtPresentacion.Size = new System.Drawing.Size(355, 26);
            this.txtPresentacion.TabIndex = 4;
            this.txtPresentacion.EditValueChanged += new System.EventHandler(this.gridLookUpEditPresentacion_EditValueChanged);
            // 
            // sluePDV
            // 
            this.sluePDV.Location = new System.Drawing.Point(221, 304);
            this.sluePDV.Name = "sluePDV";
            this.sluePDV.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.sluePDV.Properties.Appearance.Options.UseFont = true;
            this.sluePDV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sluePDV.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.sluePDV.Properties.DataSource = this.pDVBindingSource;
            this.sluePDV.Properties.DisplayMember = "nombre_local";
            this.sluePDV.Properties.NullText = "";
            this.sluePDV.Properties.PopupView = this.searchLookUpEdit1View;
            this.sluePDV.Properties.ValueMember = "id";
            this.sluePDV.Size = new System.Drawing.Size(355, 26);
            this.sluePDV.TabIndex = 5;
            this.sluePDV.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtNumLote_ButtonClick);
            // 
            // pDVBindingSource
            // 
            this.pDVBindingSource.DataMember = "PDV";
            this.pDVBindingSource.DataSource = this.dsMantenimientosFacturacion;
            // 
            // dsMantenimientosFacturacion
            // 
            this.dsMantenimientosFacturacion.DataSetName = "dsMantenimientosFacturacion";
            this.dsMantenimientosFacturacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Código";
            this.gridColumn1.FieldName = "codigo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Punto de Venta";
            this.gridColumn2.FieldName = "nombre_local";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(123, 94);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(356, 30);
            this.labelControl4.TabIndex = 143;
            this.labelControl4.Text = "Ajuste de Kardex de Punto de Venta";
            // 
            // frmAjusteKardexFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 414);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtPresentacion);
            this.Controls.Add(this.txtCantidadUnidades);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.dtFechaDocumento);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtPT_Name);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.tsTipoTransaccion);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.sluePDV);
            this.Controls.Add(this.labelControl5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAjusteKardexFactura";
            this.Text = "Ajuste Kardex de Facturación";
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDocumento.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPT_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsTipoTransaccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadUnidades.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPresentacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sluePDV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimientosFacturacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dtFechaDocumento;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ButtonEdit txtPT_Name;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ToggleSwitch tsTipoTransaccion;
        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtCantidadUnidades;
        private DevExpress.XtraEditors.TextEdit txtPresentacion;
        private DevExpress.XtraEditors.SearchLookUpEdit sluePDV;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.BindingSource pDVBindingSource;
        private Mantenimientos.dsMantenimientosFacturacion dsMantenimientosFacturacion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}