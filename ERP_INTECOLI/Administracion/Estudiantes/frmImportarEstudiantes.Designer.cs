
namespace ERP_INTECOLI.Administracion.Estudiantes
{
    partial class frmImportarEstudiantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportarEstudiantes));
            this.grdEstudiantes = new DevExpress.XtraGrid.GridControl();
            this.dsEstudiantes1 = new ERP_INTECOLI.Administracion.Estudiantes.dsEstudiantes();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridapellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcorreo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_nacimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_identidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnImportar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.label16 = new System.Windows.Forms.Label();
            this.gridPuntoVenta = new DevExpress.XtraEditors.GridLookUpEdit();
            this.puntoventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpdv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstudiantes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPuntoVenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntoventaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // grdEstudiantes
            // 
            this.grdEstudiantes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdEstudiantes.DataMember = "prev_estudiantes";
            this.grdEstudiantes.DataSource = this.dsEstudiantes1;
            this.grdEstudiantes.Location = new System.Drawing.Point(3, 65);
            this.grdEstudiantes.MainView = this.gridView1;
            this.grdEstudiantes.Name = "grdEstudiantes";
            this.grdEstudiantes.Size = new System.Drawing.Size(1349, 506);
            this.grdEstudiantes.TabIndex = 0;
            this.grdEstudiantes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsEstudiantes1
            // 
            this.dsEstudiantes1.DataSetName = "dsEstudiantes";
            this.dsEstudiantes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnombre,
            this.gridapellido,
            this.colcorreo,
            this.colfecha_nacimiento,
            this.colnum_identidad,
            this.coltelefono,
            this.coldireccion,
            this.gridColumn1});
            this.gridView1.GridControl = this.grdEstudiantes;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "nombre";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.ReadOnly = true;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 0;
            // 
            // gridapellido
            // 
            this.gridapellido.Caption = "apellido";
            this.gridapellido.FieldName = "apellido";
            this.gridapellido.Name = "gridapellido";
            this.gridapellido.OptionsColumn.ReadOnly = true;
            this.gridapellido.Visible = true;
            this.gridapellido.VisibleIndex = 1;
            // 
            // colcorreo
            // 
            this.colcorreo.Caption = "correo";
            this.colcorreo.FieldName = "correo";
            this.colcorreo.Name = "colcorreo";
            this.colcorreo.OptionsColumn.ReadOnly = true;
            this.colcorreo.Visible = true;
            this.colcorreo.VisibleIndex = 2;
            // 
            // colfecha_nacimiento
            // 
            this.colfecha_nacimiento.Caption = "fecha_nacimiento";
            this.colfecha_nacimiento.FieldName = "fecha_nacimiento";
            this.colfecha_nacimiento.Name = "colfecha_nacimiento";
            this.colfecha_nacimiento.OptionsColumn.ReadOnly = true;
            this.colfecha_nacimiento.Visible = true;
            this.colfecha_nacimiento.VisibleIndex = 3;
            // 
            // colnum_identidad
            // 
            this.colnum_identidad.Caption = "num_identidad";
            this.colnum_identidad.FieldName = "num_identidad";
            this.colnum_identidad.Name = "colnum_identidad";
            this.colnum_identidad.OptionsColumn.ReadOnly = true;
            this.colnum_identidad.Visible = true;
            this.colnum_identidad.VisibleIndex = 4;
            // 
            // coltelefono
            // 
            this.coltelefono.Caption = "Telefono";
            this.coltelefono.FieldName = "telefono";
            this.coltelefono.Name = "coltelefono";
            this.coltelefono.OptionsColumn.ReadOnly = true;
            this.coltelefono.Visible = true;
            this.coltelefono.VisibleIndex = 5;
            // 
            // coldireccion
            // 
            this.coldireccion.Caption = "Direccion";
            this.coldireccion.FieldName = "direccion";
            this.coldireccion.Name = "coldireccion";
            this.coldireccion.OptionsColumn.ReadOnly = true;
            this.coldireccion.Visible = true;
            this.coldireccion.VisibleIndex = 6;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Existe Num de Identidad";
            this.gridColumn1.FieldName = "ya_existe";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 7;
            // 
            // btnImportar
            // 
            this.btnImportar.Appearance.BackColor = System.Drawing.Color.PaleGreen;
            this.btnImportar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnImportar.Appearance.Options.UseBackColor = true;
            this.btnImportar.Appearance.Options.UseFont = true;
            this.btnImportar.ImageOptions.Image = global::ERP_INTECOLI.Properties.Resources.ms_excel_icon;
            this.btnImportar.Location = new System.Drawing.Point(362, 11);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(153, 44);
            this.btnImportar.TabIndex = 50;
            this.btnImportar.Text = "Importar";
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.BackColor = System.Drawing.Color.LightBlue;
            this.cmdGuardar.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.cmdGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Image = global::ERP_INTECOLI.Properties.Resources.save;
            this.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdGuardar.Location = new System.Drawing.Point(24, 11);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(106, 44);
            this.cmdGuardar.TabIndex = 54;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdGuardar.UseVisualStyleBackColor = false;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Appearance.BackColor = System.Drawing.Color.LightSalmon;
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnClose.Appearance.Options.UseBackColor = true;
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClose.ImageOptions.SvgImage")));
            this.btnClose.Location = new System.Drawing.Point(1225, 11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 43);
            this.btnClose.TabIndex = 57;
            this.btnClose.Text = "Atras";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label16.Location = new System.Drawing.Point(532, 33);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 17);
            this.label16.TabIndex = 66;
            this.label16.Text = "Sucursal:";
            // 
            // gridPuntoVenta
            // 
            this.gridPuntoVenta.Location = new System.Drawing.Point(597, 30);
            this.gridPuntoVenta.Name = "gridPuntoVenta";
            this.gridPuntoVenta.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridPuntoVenta.Properties.Appearance.Options.UseFont = true;
            this.gridPuntoVenta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridPuntoVenta.Properties.DataSource = this.puntoventaBindingSource;
            this.gridPuntoVenta.Properties.DisplayMember = "pdv";
            this.gridPuntoVenta.Properties.NullText = "";
            this.gridPuntoVenta.Properties.PopupView = this.gridView2;
            this.gridPuntoVenta.Properties.ValueMember = "id";
            this.gridPuntoVenta.Size = new System.Drawing.Size(242, 24);
            this.gridPuntoVenta.TabIndex = 65;
            // 
            // puntoventaBindingSource
            // 
            this.puntoventaBindingSource.DataMember = "punto_venta";
            this.puntoventaBindingSource.DataSource = this.dsEstudiantes1;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid3,
            this.colpdv});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colid3
            // 
            this.colid3.FieldName = "id";
            this.colid3.Name = "colid3";
            // 
            // colpdv
            // 
            this.colpdv.Caption = "Sucursal";
            this.colpdv.FieldName = "pdv";
            this.colpdv.Name = "colpdv";
            this.colpdv.Visible = true;
            this.colpdv.VisibleIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.PaleGreen;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(180, 11);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(153, 44);
            this.simpleButton1.TabIndex = 67;
            this.simpleButton1.Text = "Descargar Plantilla";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frmImportarEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 575);
            this.Controls.Add(this.grdEstudiantes);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.gridPuntoVenta);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.btnImportar);
            this.Name = "frmImportarEstudiantes";
            ((System.ComponentModel.ISupportInitialize)(this.grdEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstudiantes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPuntoVenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntoventaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdEstudiantes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnImportar;
        private System.Windows.Forms.Button cmdGuardar;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private dsEstudiantes dsEstudiantes1;
        private System.Windows.Forms.Label label16;
        private DevExpress.XtraEditors.GridLookUpEdit gridPuntoVenta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colid3;
        private DevExpress.XtraGrid.Columns.GridColumn colpdv;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colcorreo;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_nacimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_identidad;
        private DevExpress.XtraGrid.Columns.GridColumn coltelefono;
        private DevExpress.XtraGrid.Columns.GridColumn coldireccion;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.BindingSource puntoventaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridapellido;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}