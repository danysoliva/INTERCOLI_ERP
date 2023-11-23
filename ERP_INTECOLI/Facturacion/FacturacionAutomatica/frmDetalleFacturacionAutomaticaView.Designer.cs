namespace ERP_INTECOLI.Facturacion.FacturacionAutomatica
{
    partial class frmDetalleFacturacionAutomaticaView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalleFacturacionAutomaticaView));
            this.dsConfigFacturaAutomatica1 = new ERP_INTECOLI.Facturacion.FacturacionAutomatica.dsConfigFacturaAutomatica();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_estudiante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_estudiante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMesNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_pago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_registro_creado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_registro_posteado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_usuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuario_Nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_matricula_detalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcurso_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcurso_nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero_factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collinea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_student = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dsConfigFacturaAutomatica1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dsConfigFacturaAutomatica1
            // 
            this.dsConfigFacturaAutomatica1.DataSetName = "dsConfigFacturaAutomatica";
            this.dsConfigFacturaAutomatica1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "detalle_transaccion_h";
            this.gridControl1.DataSource = this.dsConfigFacturaAutomatica1;
            this.gridControl1.Location = new System.Drawing.Point(2, 47);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(898, 499);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colidh,
            this.colid_estudiante,
            this.colnombre_estudiante,
            this.colMesNombre,
            this.colfecha_pago,
            this.colenable,
            this.colfecha_registro_creado,
            this.colvalor,
            this.colfecha_registro_posteado,
            this.colid_usuario,
            this.colUsuario_Nombre,
            this.colid_matricula_detalle,
            this.colcurso_id,
            this.colcurso_nombre,
            this.colid_factura,
            this.colnumero_factura,
            this.collinea,
            this.colid_student});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.ReadOnly = true;
            // 
            // colidh
            // 
            this.colidh.FieldName = "idh";
            this.colidh.Name = "colidh";
            this.colidh.OptionsColumn.ReadOnly = true;
            // 
            // colid_estudiante
            // 
            this.colid_estudiante.FieldName = "id_estudiante";
            this.colid_estudiante.Name = "colid_estudiante";
            this.colid_estudiante.OptionsColumn.ReadOnly = true;
            // 
            // colnombre_estudiante
            // 
            this.colnombre_estudiante.FieldName = "nombre_estudiante";
            this.colnombre_estudiante.Name = "colnombre_estudiante";
            this.colnombre_estudiante.OptionsColumn.ReadOnly = true;
            this.colnombre_estudiante.Visible = true;
            this.colnombre_estudiante.VisibleIndex = 2;
            this.colnombre_estudiante.Width = 180;
            // 
            // colMesNombre
            // 
            this.colMesNombre.FieldName = "Mes Nombre";
            this.colMesNombre.Name = "colMesNombre";
            this.colMesNombre.OptionsColumn.ReadOnly = true;
            this.colMesNombre.Visible = true;
            this.colMesNombre.VisibleIndex = 4;
            this.colMesNombre.Width = 92;
            // 
            // colfecha_pago
            // 
            this.colfecha_pago.FieldName = "fecha_pago";
            this.colfecha_pago.Name = "colfecha_pago";
            this.colfecha_pago.OptionsColumn.ReadOnly = true;
            this.colfecha_pago.Visible = true;
            this.colfecha_pago.VisibleIndex = 5;
            this.colfecha_pago.Width = 110;
            // 
            // colenable
            // 
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            this.colenable.OptionsColumn.ReadOnly = true;
            // 
            // colfecha_registro_creado
            // 
            this.colfecha_registro_creado.FieldName = "fecha_registro_creado";
            this.colfecha_registro_creado.Name = "colfecha_registro_creado";
            this.colfecha_registro_creado.OptionsColumn.ReadOnly = true;
            // 
            // colvalor
            // 
            this.colvalor.FieldName = "valor";
            this.colvalor.Name = "colvalor";
            this.colvalor.OptionsColumn.ReadOnly = true;
            this.colvalor.Visible = true;
            this.colvalor.VisibleIndex = 6;
            this.colvalor.Width = 110;
            // 
            // colfecha_registro_posteado
            // 
            this.colfecha_registro_posteado.FieldName = "fecha_registro_posteado";
            this.colfecha_registro_posteado.Name = "colfecha_registro_posteado";
            this.colfecha_registro_posteado.OptionsColumn.ReadOnly = true;
            this.colfecha_registro_posteado.Visible = true;
            this.colfecha_registro_posteado.VisibleIndex = 7;
            this.colfecha_registro_posteado.Width = 113;
            // 
            // colid_usuario
            // 
            this.colid_usuario.FieldName = "id_usuario";
            this.colid_usuario.Name = "colid_usuario";
            this.colid_usuario.OptionsColumn.ReadOnly = true;
            // 
            // colUsuario_Nombre
            // 
            this.colUsuario_Nombre.FieldName = "Usuario_Nombre";
            this.colUsuario_Nombre.Name = "colUsuario_Nombre";
            this.colUsuario_Nombre.OptionsColumn.ReadOnly = true;
            // 
            // colid_matricula_detalle
            // 
            this.colid_matricula_detalle.FieldName = "id_matricula_detalle";
            this.colid_matricula_detalle.Name = "colid_matricula_detalle";
            this.colid_matricula_detalle.OptionsColumn.ReadOnly = true;
            // 
            // colcurso_id
            // 
            this.colcurso_id.FieldName = "curso_id";
            this.colcurso_id.Name = "colcurso_id";
            this.colcurso_id.OptionsColumn.ReadOnly = true;
            // 
            // colcurso_nombre
            // 
            this.colcurso_nombre.FieldName = "curso_nombre";
            this.colcurso_nombre.Name = "colcurso_nombre";
            this.colcurso_nombre.OptionsColumn.ReadOnly = true;
            this.colcurso_nombre.Visible = true;
            this.colcurso_nombre.VisibleIndex = 3;
            this.colcurso_nombre.Width = 140;
            // 
            // colid_factura
            // 
            this.colid_factura.FieldName = "id_factura";
            this.colid_factura.Name = "colid_factura";
            this.colid_factura.OptionsColumn.ReadOnly = true;
            // 
            // colnumero_factura
            // 
            this.colnumero_factura.FieldName = "numero_factura";
            this.colnumero_factura.Name = "colnumero_factura";
            this.colnumero_factura.OptionsColumn.ReadOnly = true;
            // 
            // collinea
            // 
            this.collinea.FieldName = "linea";
            this.collinea.Name = "collinea";
            this.collinea.OptionsColumn.ReadOnly = true;
            this.collinea.Visible = true;
            this.collinea.VisibleIndex = 0;
            this.collinea.Width = 43;
            // 
            // colid_student
            // 
            this.colid_student.FieldName = "id_student";
            this.colid_student.Name = "colid_student";
            this.colid_student.OptionsColumn.ReadOnly = true;
            this.colid_student.Visible = true;
            this.colid_student.VisibleIndex = 1;
            this.colid_student.Width = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Detalle de Generacion de Cargos para Facturacion Automatica";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.PowderBlue;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(787, -4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(113, 45);
            this.simpleButton1.TabIndex = 12;
            this.simpleButton1.Text = "Cerrar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frmDetalleFacturacionAutomaticaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 547);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmDetalleFacturacionAutomaticaView";
            this.Text = "Detalle Facturacion Automatica";
            ((System.ComponentModel.ISupportInitialize)(this.dsConfigFacturaAutomatica1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsConfigFacturaAutomatica dsConfigFacturaAutomatica1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colidh;
        private DevExpress.XtraGrid.Columns.GridColumn colid_estudiante;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_estudiante;
        private DevExpress.XtraGrid.Columns.GridColumn colMesNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_pago;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_registro_creado;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_registro_posteado;
        private DevExpress.XtraGrid.Columns.GridColumn colid_usuario;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuario_Nombre;
        private DevExpress.XtraGrid.Columns.GridColumn colid_matricula_detalle;
        private DevExpress.XtraGrid.Columns.GridColumn colcurso_id;
        private DevExpress.XtraGrid.Columns.GridColumn colcurso_nombre;
        private DevExpress.XtraGrid.Columns.GridColumn colid_factura;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_factura;
        private DevExpress.XtraGrid.Columns.GridColumn collinea;
        private DevExpress.XtraGrid.Columns.GridColumn colid_student;
    }
}