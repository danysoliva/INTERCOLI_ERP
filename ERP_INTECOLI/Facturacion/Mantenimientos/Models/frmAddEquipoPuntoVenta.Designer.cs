namespace JAGUAR_APP.Facturacion.Mantenimientos.Models
{
    partial class frmAddEquipoPuntoVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEquipoPuntoVenta));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblTitulo = new DevExpress.XtraEditors.LabelControl();
            this.txtNombreEquipo = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cmdNew = new DevExpress.XtraEditors.SimpleButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.glePuntoVenta = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bindingSourcePuntosVenta = new System.Windows.Forms.BindingSource(this.components);
            this.dsCRUDS_Facturacion1 = new JAGUAR_APP.Facturacion.Mantenimientos.dsCRUDS_Facturacion();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bindingSourceUsuarios = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.tggEnable = new DevExpress.XtraEditors.ToggleSwitch();
            this.txtDescripcionEquipo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.gleUsuarioAsignado = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreEquipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glePuntoVenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePuntosVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCRUDS_Facturacion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggEnable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcionEquipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleUsuarioAsignado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 68);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(119, 15);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nombre Equipo_______";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Appearance.Options.UseFont = true;
            this.lblTitulo.Location = new System.Drawing.Point(114, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(195, 25);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Agregar Nuevo Equipo";
            // 
            // txtNombreEquipo
            // 
            this.txtNombreEquipo.Location = new System.Drawing.Point(127, 61);
            this.txtNombreEquipo.Name = "txtNombreEquipo";
            this.txtNombreEquipo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombreEquipo.Properties.Appearance.Options.UseFont = true;
            this.txtNombreEquipo.Size = new System.Drawing.Size(225, 22);
            this.txtNombreEquipo.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(224, 226);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(119, 47);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Cancelar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cmdNew
            // 
            this.cmdNew.Appearance.BackColor = System.Drawing.Color.PowderBlue;
            this.cmdNew.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNew.Appearance.Options.UseBackColor = true;
            this.cmdNew.Appearance.Options.UseFont = true;
            this.cmdNew.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            //this.cmdNew.ImageOptions.Image = global::JAGUAR_APP.Properties.Resources.save_32x32;
            this.cmdNew.Location = new System.Drawing.Point(86, 226);
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(119, 47);
            this.cmdNew.TabIndex = 5;
            this.cmdNew.Text = "Guardar";
            this.cmdNew.Click += new System.EventHandler(this.cmdNew_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 128);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(116, 15);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "Punto de Venta_______";
            // 
            // glePuntoVenta
            // 
            this.glePuntoVenta.Location = new System.Drawing.Point(127, 121);
            this.glePuntoVenta.Name = "glePuntoVenta";
            this.glePuntoVenta.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.glePuntoVenta.Properties.Appearance.Options.UseFont = true;
            this.glePuntoVenta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glePuntoVenta.Properties.DataSource = this.bindingSourcePuntosVenta;
            this.glePuntoVenta.Properties.DisplayMember = "descripcion";
            this.glePuntoVenta.Properties.NullText = "";
            this.glePuntoVenta.Properties.PopupView = this.gridLookUpEdit1View;
            this.glePuntoVenta.Properties.ReadOnly = true;
            this.glePuntoVenta.Properties.ValueMember = "id";
            this.glePuntoVenta.Size = new System.Drawing.Size(225, 22);
            this.glePuntoVenta.TabIndex = 2;
            // 
            // bindingSourcePuntosVenta
            // 
            this.bindingSourcePuntosVenta.DataMember = "punto_venta";
            this.bindingSourcePuntosVenta.DataSource = this.dsCRUDS_Facturacion1;
            // 
            // dsCRUDS_Facturacion1
            // 
            this.dsCRUDS_Facturacion1.DataSetName = "dsCRUDS_Facturacion";
            this.dsCRUDS_Facturacion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldescripcion});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // coldescripcion
            // 
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.ReadOnly = true;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            // 
            // bindingSourceUsuarios
            // 
            this.bindingSourceUsuarios.DataMember = "usuarios_asignados";
            this.bindingSourceUsuarios.DataSource = this.dsCRUDS_Facturacion1;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 159);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(129, 15);
            this.labelControl4.TabIndex = 23;
            this.labelControl4.Text = "Equipo Activo___________";
            // 
            // tggEnable
            // 
            this.tggEnable.EditValue = true;
            this.tggEnable.Location = new System.Drawing.Point(127, 158);
            this.tggEnable.Name = "tggEnable";
            this.tggEnable.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tggEnable.Properties.Appearance.Options.UseFont = true;
            this.tggEnable.Properties.OffText = "No";
            this.tggEnable.Properties.OnText = "Si";
            this.tggEnable.Size = new System.Drawing.Size(95, 20);
            this.tggEnable.TabIndex = 3;
            // 
            // txtDescripcionEquipo
            // 
            this.txtDescripcionEquipo.Location = new System.Drawing.Point(127, 89);
            this.txtDescripcionEquipo.Name = "txtDescripcionEquipo";
            this.txtDescripcionEquipo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescripcionEquipo.Properties.Appearance.Options.UseFont = true;
            this.txtDescripcionEquipo.Size = new System.Drawing.Size(225, 22);
            this.txtDescripcionEquipo.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(12, 97);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(137, 15);
            this.labelControl5.TabIndex = 25;
            this.labelControl5.Text = "Descripción Equipo_______";
            // 
            // gleUsuarioAsignado
            // 
            this.gleUsuarioAsignado.Location = new System.Drawing.Point(127, 184);
            this.gleUsuarioAsignado.Name = "gleUsuarioAsignado";
            this.gleUsuarioAsignado.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gleUsuarioAsignado.Properties.Appearance.Options.UseFont = true;
            this.gleUsuarioAsignado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gleUsuarioAsignado.Properties.DataSource = this.bindingSourceUsuarios;
            this.gleUsuarioAsignado.Properties.DisplayMember = "user_name";
            this.gleUsuarioAsignado.Properties.NullText = "";
            this.gleUsuarioAsignado.Properties.PopupView = this.gridView1;
            this.gleUsuarioAsignado.Properties.ValueMember = "id";
            this.gleUsuarioAsignado.Size = new System.Drawing.Size(225, 22);
            this.gleUsuarioAsignado.TabIndex = 4;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.coluser_name,
            this.coluser});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            // 
            // coluser_name
            // 
            this.coluser_name.Caption = "Nombre Usuario";
            this.coluser_name.FieldName = "user_name";
            this.coluser_name.Name = "coluser_name";
            this.coluser_name.OptionsColumn.ReadOnly = true;
            this.coluser_name.Visible = true;
            this.coluser_name.VisibleIndex = 0;
            // 
            // coluser
            // 
            this.coluser.Caption = "Usuario";
            this.coluser.FieldName = "user";
            this.coluser.Name = "coluser";
            this.coluser.OptionsColumn.ReadOnly = true;
            this.coluser.Visible = true;
            this.coluser.VisibleIndex = 1;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(12, 191);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(128, 15);
            this.labelControl6.TabIndex = 27;
            this.labelControl6.Text = "Usuario Asignado_______";
            // 
            // frmAddEquipoPuntoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 291);
            this.Controls.Add(this.gleUsuarioAsignado);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtDescripcionEquipo);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.tggEnable);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.glePuntoVenta);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.cmdNew);
            this.Controls.Add(this.txtNombreEquipo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEquipoPuntoVenta";
            this.Text = "Agregar Equipo";
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreEquipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glePuntoVenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePuntosVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCRUDS_Facturacion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggEnable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcionEquipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleUsuarioAsignado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsCRUDS_Facturacion dsCRUDS_Facturacion1;
        private System.Windows.Forms.BindingSource bindingSourceUsuarios;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblTitulo;
        private DevExpress.XtraEditors.TextEdit txtNombreEquipo;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton cmdNew;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.GridLookUpEdit glePuntoVenta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.BindingSource bindingSourcePuntosVenta;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraEditors.ToggleSwitch tggEnable;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtDescripcionEquipo;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.GridLookUpEdit gleUsuarioAsignado;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_name;
        private DevExpress.XtraGrid.Columns.GridColumn coluser;
    }
}