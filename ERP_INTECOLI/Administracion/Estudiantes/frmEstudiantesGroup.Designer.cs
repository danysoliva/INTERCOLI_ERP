
namespace ERP_INTECOLI.Administracion.Estudiantes
{
    partial class frmEstudiantesGroup
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
            this.cmdNuevo = new System.Windows.Forms.Button();
            this.txtParametro = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.tsVerTodos = new DevExpress.XtraEditors.ToggleSwitch();
            this.dsEstudiantes1 = new ERP_INTECOLI.Administracion.Estudiantes.dsEstudiantes();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.gridEstudiantes = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_estudiante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero_identidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colapellidos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_nacimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_ingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhabilitado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsexo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcorreo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconcatenacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposAntiguedad = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.txtParametroBusqueda = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParametro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsVerTodos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstudiantes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposAntiguedad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParametroBusqueda.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.BackColor = System.Drawing.Color.PaleGreen;
            this.cmdNuevo.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.cmdNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdNuevo.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cmdNuevo.Image = global::ERP_INTECOLI.Properties.Resources.anadir;
            this.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdNuevo.Location = new System.Drawing.Point(472, 22);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(180, 43);
            this.cmdNuevo.TabIndex = 9;
            this.cmdNuevo.Text = "Agregar Estudiante";
            this.cmdNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdNuevo.UseVisualStyleBackColor = false;
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
            // 
            // txtParametro
            // 
            this.txtParametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParametro.Location = new System.Drawing.Point(191, 34);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(270, 26);
            this.txtParametro.TabIndex = 7;
            this.txtParametro.ValueChanged += new System.EventHandler(this.txtParametro_ValueChanged);
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel1.Location = new System.Drawing.Point(50, 38);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(158, 18);
            this.ultraLabel1.TabIndex = 6;
            this.ultraLabel1.Text = "Buscar por Nombre:";
            // 
            // tsVerTodos
            // 
            this.tsVerTodos.EditValue = true;
            this.tsVerTodos.Location = new System.Drawing.Point(711, 31);
            this.tsVerTodos.Name = "tsVerTodos";
            this.tsVerTodos.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.tsVerTodos.Properties.Appearance.Options.UseFont = true;
            this.tsVerTodos.Properties.OffText = "Deshabilitados";
            this.tsVerTodos.Properties.OnText = "Habilitados";
            this.tsVerTodos.Size = new System.Drawing.Size(168, 24);
            this.tsVerTodos.TabIndex = 10;
            this.tsVerTodos.Toggled += new System.EventHandler(this.tsVerTodos_Toggled);
            // 
            // dsEstudiantes1
            // 
            this.dsEstudiantes1.DataSetName = "dsEstudiantes";
            this.dsEstudiantes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Appearance.BackColor = System.Drawing.Color.Salmon;
            this.btnClose.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Appearance.Options.UseBackColor = true;
            this.btnClose.Appearance.Options.UseForeColor = true;
            this.btnClose.ImageOptions.Image = global::ERP_INTECOLI.Properties.Resources.cerrar;
            this.btnClose.Location = new System.Drawing.Point(1331, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(78, 50);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Cerrar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancelar.BackColor = System.Drawing.Color.LightSalmon;
            this.cmdCancelar.FlatAppearance.BorderColor = System.Drawing.Color.LightSalmon;
            this.cmdCancelar.FlatAppearance.BorderSize = 2;
            this.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Image = global::ERP_INTECOLI.Properties.Resources.cerrar;
            this.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCancelar.Location = new System.Drawing.Point(980, 22);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(110, 43);
            this.cmdCancelar.TabIndex = 44;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdCancelar.UseVisualStyleBackColor = false;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // gridEstudiantes
            // 
            this.gridEstudiantes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridEstudiantes.DataMember = "estudiantes";
            this.gridEstudiantes.DataSource = this.dsEstudiantes1;
            this.gridEstudiantes.Location = new System.Drawing.Point(4, 81);
            this.gridEstudiantes.MainView = this.gridView1;
            this.gridEstudiantes.Name = "gridEstudiantes";
            this.gridEstudiantes.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.reposEditar,
            this.reposAntiguedad});
            this.gridEstudiantes.Size = new System.Drawing.Size(1127, 471);
            this.gridEstudiantes.TabIndex = 45;
            this.gridEstudiantes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_estudiante,
            this.colnumero_identidad,
            this.colnombres,
            this.colapellidos,
            this.coldireccion,
            this.colfecha_nacimiento,
            this.colfecha_ingreso,
            this.colhabilitado,
            this.colsexo,
            this.colcorreo,
            this.colconcatenacion,
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.gridEstudiantes;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid_estudiante
            // 
            this.colid_estudiante.Caption = "ID";
            this.colid_estudiante.FieldName = "id_estudiante";
            this.colid_estudiante.Name = "colid_estudiante";
            this.colid_estudiante.OptionsColumn.ReadOnly = true;
            this.colid_estudiante.Visible = true;
            this.colid_estudiante.VisibleIndex = 0;
            // 
            // colnumero_identidad
            // 
            this.colnumero_identidad.Caption = "Identidad";
            this.colnumero_identidad.FieldName = "numero_identidad";
            this.colnumero_identidad.Name = "colnumero_identidad";
            this.colnumero_identidad.OptionsColumn.ReadOnly = true;
            this.colnumero_identidad.Visible = true;
            this.colnumero_identidad.VisibleIndex = 1;
            // 
            // colnombres
            // 
            this.colnombres.Caption = "Nombres";
            this.colnombres.FieldName = "nombres";
            this.colnombres.Name = "colnombres";
            this.colnombres.OptionsColumn.ReadOnly = true;
            this.colnombres.Visible = true;
            this.colnombres.VisibleIndex = 2;
            // 
            // colapellidos
            // 
            this.colapellidos.Caption = "Apellidos";
            this.colapellidos.FieldName = "apellidos";
            this.colapellidos.Name = "colapellidos";
            this.colapellidos.OptionsColumn.ReadOnly = true;
            this.colapellidos.Visible = true;
            this.colapellidos.VisibleIndex = 3;
            // 
            // coldireccion
            // 
            this.coldireccion.Caption = "Direccion";
            this.coldireccion.FieldName = "direccion";
            this.coldireccion.Name = "coldireccion";
            this.coldireccion.OptionsColumn.ReadOnly = true;
            this.coldireccion.Visible = true;
            this.coldireccion.VisibleIndex = 4;
            // 
            // colfecha_nacimiento
            // 
            this.colfecha_nacimiento.Caption = "Fecha Nac";
            this.colfecha_nacimiento.FieldName = "fecha_nacimiento";
            this.colfecha_nacimiento.Name = "colfecha_nacimiento";
            this.colfecha_nacimiento.OptionsColumn.ReadOnly = true;
            this.colfecha_nacimiento.Visible = true;
            this.colfecha_nacimiento.VisibleIndex = 5;
            // 
            // colfecha_ingreso
            // 
            this.colfecha_ingreso.Caption = "Fecha Ingreso";
            this.colfecha_ingreso.FieldName = "fecha_ingreso";
            this.colfecha_ingreso.Name = "colfecha_ingreso";
            this.colfecha_ingreso.OptionsColumn.ReadOnly = true;
            this.colfecha_ingreso.Visible = true;
            this.colfecha_ingreso.VisibleIndex = 6;
            // 
            // colhabilitado
            // 
            this.colhabilitado.Caption = "Habilitado";
            this.colhabilitado.FieldName = "habilitado";
            this.colhabilitado.Name = "colhabilitado";
            this.colhabilitado.OptionsColumn.ReadOnly = true;
            this.colhabilitado.Visible = true;
            this.colhabilitado.VisibleIndex = 7;
            // 
            // colsexo
            // 
            this.colsexo.Caption = "Sexo";
            this.colsexo.FieldName = "sexo";
            this.colsexo.Name = "colsexo";
            this.colsexo.OptionsColumn.ReadOnly = true;
            this.colsexo.Visible = true;
            this.colsexo.VisibleIndex = 8;
            // 
            // colcorreo
            // 
            this.colcorreo.Caption = "Correo";
            this.colcorreo.FieldName = "correo";
            this.colcorreo.Name = "colcorreo";
            this.colcorreo.OptionsColumn.ReadOnly = true;
            this.colcorreo.Visible = true;
            this.colcorreo.VisibleIndex = 9;
            // 
            // colconcatenacion
            // 
            this.colconcatenacion.FieldName = "concatenacion";
            this.colconcatenacion.Name = "colconcatenacion";
            this.colconcatenacion.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Editar";
            this.gridColumn1.ColumnEdit = this.reposEditar;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 10;
            // 
            // reposEditar
            // 
            this.reposEditar.Name = "reposEditar";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Antiguedad";
            this.gridColumn2.ColumnEdit = this.reposAntiguedad;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 11;
            // 
            // reposAntiguedad
            // 
            this.reposAntiguedad.Name = "reposAntiguedad";
            // 
            // txtParametroBusqueda
            // 
            this.txtParametroBusqueda.Location = new System.Drawing.Point(197, 35);
            this.txtParametroBusqueda.Name = "txtParametroBusqueda";
            this.txtParametroBusqueda.Size = new System.Drawing.Size(100, 20);
            this.txtParametroBusqueda.TabIndex = 0;
            // 
            // frmEstudiantesGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 555);
            this.ControlBox = false;
            this.Controls.Add(this.txtParametroBusqueda);
            this.Controls.Add(this.gridEstudiantes);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tsVerTodos);
            this.Controls.Add(this.cmdNuevo);
            this.Controls.Add(this.txtParametro);
            this.Controls.Add(this.ultraLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEstudiantesGroup";
            this.Text = "Estudiantes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.txtParametro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsVerTodos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstudiantes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposAntiguedad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParametroBusqueda.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdNuevo;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtParametro;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private DevExpress.XtraEditors.ToggleSwitch tsVerTodos;
        private dsEstudiantes dsEstudiantes1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.Button cmdCancelar;
        private DevExpress.XtraGrid.GridControl gridEstudiantes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_estudiante;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_identidad;
        private DevExpress.XtraGrid.Columns.GridColumn colnombres;
        private DevExpress.XtraGrid.Columns.GridColumn colapellidos;
        private DevExpress.XtraGrid.Columns.GridColumn coldireccion;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_nacimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_ingreso;
        private DevExpress.XtraGrid.Columns.GridColumn colhabilitado;
        private DevExpress.XtraGrid.Columns.GridColumn colsexo;
        private DevExpress.XtraGrid.Columns.GridColumn colcorreo;
        private DevExpress.XtraGrid.Columns.GridColumn colconcatenacion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.TextEdit txtParametroBusqueda;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposEditar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposAntiguedad;
    }
}