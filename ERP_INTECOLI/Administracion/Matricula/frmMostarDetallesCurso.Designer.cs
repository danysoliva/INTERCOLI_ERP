
namespace ERP_INTECOLI.Administracion.Matricula
{
    partial class frmMostarDetallesCurso
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsCursos_1 = new ERP_INTECOLI.Administracion.Cursos.dsCursos_();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_nivel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_instructor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhora_inicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhora_fin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_posteo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_inicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_fin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcurso_finalizado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEditar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEliminar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Domingo = new System.Windows.Forms.CheckBox();
            this.Sabado = new System.Windows.Forms.CheckBox();
            this.Viernes = new System.Windows.Forms.CheckBox();
            this.Jueves = new System.Windows.Forms.CheckBox();
            this.Miercoles = new System.Windows.Forms.CheckBox();
            this.Martes = new System.Windows.Forms.CheckBox();
            this.lunes = new System.Windows.Forms.CheckBox();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemButtonEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCursos_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "Cursos";
            this.gridControl1.DataSource = this.dsCursos_1;
            this.gridControl1.Location = new System.Drawing.Point(0, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repositoryItemButtonEdit2});
            this.gridControl1.Size = new System.Drawing.Size(851, 161);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsCursos_1
            // 
            this.dsCursos_1.DataSetName = "dsCursos_";
            this.dsCursos_1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_nivel,
            this.colDescripcion,
            this.colid_instructor,
            this.colnombres,
            this.colseccion,
            this.colhora_inicio,
            this.colhora_fin,
            this.colfecha_posteo,
            this.colfecha_inicio,
            this.colfecha_fin,
            this.colcurso_finalizado,
            this.colEditar,
            this.colEliminar});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.ReadOnly = true;
            // 
            // colid_nivel
            // 
            this.colid_nivel.FieldName = "id_nivel";
            this.colid_nivel.Name = "colid_nivel";
            this.colid_nivel.OptionsColumn.ReadOnly = true;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripcion";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.OptionsColumn.ReadOnly = true;
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 0;
            // 
            // colid_instructor
            // 
            this.colid_instructor.FieldName = "id_instructor";
            this.colid_instructor.Name = "colid_instructor";
            this.colid_instructor.OptionsColumn.ReadOnly = true;
            // 
            // colnombres
            // 
            this.colnombres.Caption = "Instructor";
            this.colnombres.FieldName = "nombres";
            this.colnombres.Name = "colnombres";
            this.colnombres.OptionsColumn.ReadOnly = true;
            this.colnombres.Visible = true;
            this.colnombres.VisibleIndex = 1;
            // 
            // colseccion
            // 
            this.colseccion.Caption = "Seccion";
            this.colseccion.FieldName = "seccion";
            this.colseccion.Name = "colseccion";
            this.colseccion.OptionsColumn.ReadOnly = true;
            this.colseccion.Visible = true;
            this.colseccion.VisibleIndex = 2;
            // 
            // colhora_inicio
            // 
            this.colhora_inicio.Caption = "Hora Inicio";
            this.colhora_inicio.FieldName = "hora_inicio";
            this.colhora_inicio.Name = "colhora_inicio";
            this.colhora_inicio.OptionsColumn.ReadOnly = true;
            this.colhora_inicio.Visible = true;
            this.colhora_inicio.VisibleIndex = 3;
            // 
            // colhora_fin
            // 
            this.colhora_fin.Caption = "Hora Fin";
            this.colhora_fin.FieldName = "hora_fin";
            this.colhora_fin.Name = "colhora_fin";
            this.colhora_fin.OptionsColumn.ReadOnly = true;
            this.colhora_fin.Visible = true;
            this.colhora_fin.VisibleIndex = 4;
            // 
            // colfecha_posteo
            // 
            this.colfecha_posteo.Caption = "Fecha Posteo";
            this.colfecha_posteo.FieldName = "fecha_posteo";
            this.colfecha_posteo.Name = "colfecha_posteo";
            this.colfecha_posteo.OptionsColumn.ReadOnly = true;
            this.colfecha_posteo.Visible = true;
            this.colfecha_posteo.VisibleIndex = 5;
            // 
            // colfecha_inicio
            // 
            this.colfecha_inicio.Caption = "Fecha Inicio";
            this.colfecha_inicio.FieldName = "fecha_inicio";
            this.colfecha_inicio.Name = "colfecha_inicio";
            this.colfecha_inicio.OptionsColumn.ReadOnly = true;
            this.colfecha_inicio.Visible = true;
            this.colfecha_inicio.VisibleIndex = 6;
            // 
            // colfecha_fin
            // 
            this.colfecha_fin.Caption = "Fecha Fin";
            this.colfecha_fin.FieldName = "fecha_fin";
            this.colfecha_fin.Name = "colfecha_fin";
            this.colfecha_fin.OptionsColumn.ReadOnly = true;
            this.colfecha_fin.Visible = true;
            this.colfecha_fin.VisibleIndex = 7;
            // 
            // colcurso_finalizado
            // 
            this.colcurso_finalizado.Caption = "Curso Finalizado";
            this.colcurso_finalizado.FieldName = "curso_finalizado";
            this.colcurso_finalizado.Name = "colcurso_finalizado";
            this.colcurso_finalizado.OptionsColumn.ReadOnly = true;
            this.colcurso_finalizado.Visible = true;
            this.colcurso_finalizado.VisibleIndex = 8;
            // 
            // colEditar
            // 
            this.colEditar.Caption = "Editar";
            this.colEditar.FieldName = "Editar";
            this.colEditar.Name = "colEditar";
            // 
            // colEliminar
            // 
            this.colEliminar.Caption = "Eliminar";
            this.colEliminar.FieldName = "Eliminar";
            this.colEliminar.Name = "colEliminar";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 87);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Domingo);
            this.groupBox1.Controls.Add(this.Sabado);
            this.groupBox1.Controls.Add(this.Viernes);
            this.groupBox1.Controls.Add(this.Jueves);
            this.groupBox1.Controls.Add(this.Miercoles);
            this.groupBox1.Controls.Add(this.Martes);
            this.groupBox1.Controls.Add(this.lunes);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 69);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dias Recibe Clase";
            // 
            // Domingo
            // 
            this.Domingo.AutoSize = true;
            this.Domingo.Enabled = false;
            this.Domingo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Domingo.Location = new System.Drawing.Point(150, 42);
            this.Domingo.Name = "Domingo";
            this.Domingo.Size = new System.Drawing.Size(85, 21);
            this.Domingo.TabIndex = 6;
            this.Domingo.Text = "Domingo";
            this.Domingo.UseVisualStyleBackColor = true;
            // 
            // Sabado
            // 
            this.Sabado.AutoSize = true;
            this.Sabado.Enabled = false;
            this.Sabado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Sabado.Location = new System.Drawing.Point(77, 42);
            this.Sabado.Name = "Sabado";
            this.Sabado.Size = new System.Drawing.Size(72, 21);
            this.Sabado.TabIndex = 5;
            this.Sabado.Text = "Sabado";
            this.Sabado.UseVisualStyleBackColor = true;
            // 
            // Viernes
            // 
            this.Viernes.AutoSize = true;
            this.Viernes.Enabled = false;
            this.Viernes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Viernes.Location = new System.Drawing.Point(9, 42);
            this.Viernes.Name = "Viernes";
            this.Viernes.Size = new System.Drawing.Size(73, 21);
            this.Viernes.TabIndex = 4;
            this.Viernes.Text = "Viernes";
            this.Viernes.UseVisualStyleBackColor = true;
            // 
            // Jueves
            // 
            this.Jueves.AutoSize = true;
            this.Jueves.Enabled = false;
            this.Jueves.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Jueves.Location = new System.Drawing.Point(236, 19);
            this.Jueves.Name = "Jueves";
            this.Jueves.Size = new System.Drawing.Size(68, 21);
            this.Jueves.TabIndex = 3;
            this.Jueves.Text = "Jueves";
            this.Jueves.UseVisualStyleBackColor = true;
            // 
            // Miercoles
            // 
            this.Miercoles.AutoSize = true;
            this.Miercoles.Enabled = false;
            this.Miercoles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Miercoles.Location = new System.Drawing.Point(149, 19);
            this.Miercoles.Name = "Miercoles";
            this.Miercoles.Size = new System.Drawing.Size(86, 21);
            this.Miercoles.TabIndex = 2;
            this.Miercoles.Text = "Miercoles";
            this.Miercoles.UseVisualStyleBackColor = true;
            // 
            // Martes
            // 
            this.Martes.AutoSize = true;
            this.Martes.Enabled = false;
            this.Martes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Martes.Location = new System.Drawing.Point(77, 19);
            this.Martes.Name = "Martes";
            this.Martes.Size = new System.Drawing.Size(69, 21);
            this.Martes.TabIndex = 1;
            this.Martes.Text = "Martes";
            this.Martes.UseVisualStyleBackColor = true;
            // 
            // lunes
            // 
            this.lunes.AutoSize = true;
            this.lunes.Enabled = false;
            this.lunes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lunes.Location = new System.Drawing.Point(9, 19);
            this.lunes.Name = "lunes";
            this.lunes.Size = new System.Drawing.Size(63, 21);
            this.lunes.TabIndex = 0;
            this.lunes.Text = "Lunes";
            this.lunes.UseVisualStyleBackColor = true;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // repositoryItemButtonEdit2
            // 
            this.repositoryItemButtonEdit2.AutoHeight = false;
            this.repositoryItemButtonEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit2.Name = "repositoryItemButtonEdit2";
            // 
            // frmMostarDetallesCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 257);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridControl1);
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMostarDetallesCurso";
            this.Text = "Detalles del Curso";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCursos_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Domingo;
        private System.Windows.Forms.CheckBox Sabado;
        private System.Windows.Forms.CheckBox Viernes;
        private System.Windows.Forms.CheckBox Jueves;
        private System.Windows.Forms.CheckBox Miercoles;
        private System.Windows.Forms.CheckBox Martes;
        private System.Windows.Forms.CheckBox lunes;
        private Cursos.dsCursos_ dsCursos_1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_nivel;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colid_instructor;
        private DevExpress.XtraGrid.Columns.GridColumn colnombres;
        private DevExpress.XtraGrid.Columns.GridColumn colseccion;
        private DevExpress.XtraGrid.Columns.GridColumn colhora_inicio;
        private DevExpress.XtraGrid.Columns.GridColumn colhora_fin;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_posteo;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_inicio;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_fin;
        private DevExpress.XtraGrid.Columns.GridColumn colcurso_finalizado;
        private DevExpress.XtraGrid.Columns.GridColumn colEditar;
        private DevExpress.XtraGrid.Columns.GridColumn colEliminar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit2;
    }
}