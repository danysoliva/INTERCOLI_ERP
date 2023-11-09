
namespace ERP_INTECOLI.Mantenimiento.Productos
{
    partial class frmItemsOP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemsOP));
            this.lblOperacion = new System.Windows.Forms.Label();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.lblTS = new DevExpress.XtraEditors.LabelControl();
            this.tsHabilitado = new DevExpress.XtraEditors.ToggleSwitch();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.txtItemCode = new DevExpress.XtraEditors.TextEdit();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.grdTipoProducto = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dsMantenimiento1 = new ERP_INTECOLI.Mantenimiento.Productos.dsMantenimiento();
            this.tipoProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tsHabilitado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimiento1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProductoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOperacion
            // 
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacion.Location = new System.Drawing.Point(94, 9);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(137, 24);
            this.lblOperacion.TabIndex = 5;
            this.lblOperacion.Text = "Crear Producto";
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.BackColor = System.Drawing.Color.LightSalmon;
            this.cmdCancelar.FlatAppearance.BorderColor = System.Drawing.Color.LightSalmon;
            this.cmdCancelar.FlatAppearance.BorderSize = 2;
            this.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Image = global::ERP_INTECOLI.Properties.Resources.cerrar;
            this.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCancelar.Location = new System.Drawing.Point(180, 189);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(110, 44);
            this.cmdCancelar.TabIndex = 58;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdCancelar.UseVisualStyleBackColor = false;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.BackColor = System.Drawing.Color.LightBlue;
            this.cmdGuardar.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.cmdGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Image = global::ERP_INTECOLI.Properties.Resources.save;
            this.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdGuardar.Location = new System.Drawing.Point(52, 189);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(102, 44);
            this.cmdGuardar.TabIndex = 57;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdGuardar.UseVisualStyleBackColor = false;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // lblTS
            // 
            this.lblTS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTS.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblTS.Appearance.Options.UseFont = true;
            this.lblTS.Location = new System.Drawing.Point(101, 150);
            this.lblTS.Name = "lblTS";
            this.lblTS.Size = new System.Drawing.Size(60, 17);
            this.lblTS.TabIndex = 60;
            this.lblTS.Text = "Habilitado";
            this.lblTS.Visible = false;
            // 
            // tsHabilitado
            // 
            this.tsHabilitado.EditValue = true;
            this.tsHabilitado.Location = new System.Drawing.Point(180, 148);
            this.tsHabilitado.Name = "tsHabilitado";
            this.tsHabilitado.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tsHabilitado.Properties.Appearance.Options.UseFont = true;
            this.tsHabilitado.Properties.OffText = "No";
            this.tsHabilitado.Properties.OnText = "Si";
            this.tsHabilitado.Size = new System.Drawing.Size(95, 22);
            this.tsHabilitado.TabIndex = 59;
            this.tsHabilitado.Visible = false;
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblItemCode.Location = new System.Drawing.Point(38, 54);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(54, 17);
            this.lblItemCode.TabIndex = 66;
            this.lblItemCode.Text = "Codigo:";
            this.lblItemCode.Visible = false;
            // 
            // txtItemCode
            // 
            this.txtItemCode.Enabled = false;
            this.txtItemCode.Location = new System.Drawing.Point(134, 51);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtItemCode.Properties.Appearance.Options.UseFont = true;
            this.txtItemCode.Properties.MaxLength = 100;
            this.txtItemCode.Size = new System.Drawing.Size(107, 24);
            this.txtItemCode.TabIndex = 65;
            this.txtItemCode.Visible = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(134, 120);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDescripcion.Properties.Appearance.Options.UseFont = true;
            this.txtDescripcion.Properties.MaxLength = 100;
            this.txtDescripcion.Size = new System.Drawing.Size(156, 24);
            this.txtDescripcion.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label3.Location = new System.Drawing.Point(38, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 63;
            this.label3.Text = "Descripcion:";
            // 
            // grdTipoProducto
            // 
            this.grdTipoProducto.Location = new System.Drawing.Point(134, 86);
            this.grdTipoProducto.Name = "grdTipoProducto";
            this.grdTipoProducto.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdTipoProducto.Properties.Appearance.Options.UseFont = true;
            this.grdTipoProducto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdTipoProducto.Properties.DataSource = this.tipoProductoBindingSource;
            this.grdTipoProducto.Properties.DisplayMember = "descripcion";
            this.grdTipoProducto.Properties.NullText = "";
            this.grdTipoProducto.Properties.PopupView = this.gridLookUpEdit1View;
            this.grdTipoProducto.Properties.ValueMember = "id";
            this.grdTipoProducto.Size = new System.Drawing.Size(156, 24);
            this.grdTipoProducto.TabIndex = 67;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldescripcion});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.Location = new System.Drawing.Point(38, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 68;
            this.label1.Text = "Tipo Producto:";
            // 
            // dsMantenimiento1
            // 
            this.dsMantenimiento1.DataSetName = "dsMantenimiento";
            this.dsMantenimiento1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoProductoBindingSource
            // 
            this.tipoProductoBindingSource.DataMember = "Tipo_Producto";
            this.tipoProductoBindingSource.DataSource = this.dsMantenimiento1;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Tipo Producto";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.AllowEdit = false;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            // 
            // frmItemsOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 252);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdTipoProducto);
            this.Controls.Add(this.lblItemCode);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTS);
            this.Controls.Add(this.tsHabilitado);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.lblOperacion);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmItemsOP.IconOptions.Image")));
            this.Name = "frmItemsOP";
            ((System.ComponentModel.ISupportInitialize)(this.tsHabilitado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoProducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimiento1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProductoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOperacion;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdGuardar;
        private DevExpress.XtraEditors.LabelControl lblTS;
        private DevExpress.XtraEditors.ToggleSwitch tsHabilitado;
        private System.Windows.Forms.Label lblItemCode;
        private DevExpress.XtraEditors.TextEdit txtItemCode;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.GridLookUpEdit grdTipoProducto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource tipoProductoBindingSource;
        private dsMantenimiento dsMantenimiento1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
    }
}