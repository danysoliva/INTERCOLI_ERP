
namespace ERP_INTECOLI.Administracion.Matricula
{
    partial class frmMatricula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMatricula));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMatriculado1 = new ERP_INTECOLI.Administracion.Matricula.dsMatriculado();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.chkNula = new System.Windows.Forms.CheckBox();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.txtMensualidad = new DevExpress.XtraEditors.TextEdit();
            this.btnDetalleCurso = new DevExpress.XtraEditors.SimpleButton();
            this.gridLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtEstudiante = new DevExpress.XtraEditors.TextEdit();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorAlumno = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNivel = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorInstructor = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMatriculado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMensualidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstudiante.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNivel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorInstructor)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(152, -2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(99, 32);
            this.labelControl1.TabIndex = 49;
            this.labelControl1.Text = "Matricula";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(57, 39);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 20);
            this.labelControl2.TabIndex = 50;
            this.labelControl2.Text = "Estudiante";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(57, 81);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 20);
            this.labelControl3.TabIndex = 52;
            this.labelControl3.Text = "Nivel:";
            // 
            // cursosBindingSource
            // 
            this.cursosBindingSource.DataMember = "Cursos";
            this.cursosBindingSource.DataSource = this.dsMatriculado1;
            // 
            // dsMatriculado1
            // 
            this.dsMatriculado1.DataSetName = "dsMatriculado";
            this.dsMatriculado1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(57, 126);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(94, 20);
            this.labelControl4.TabIndex = 56;
            this.labelControl4.Text = "Valor Mensual";
            // 
            // chkNula
            // 
            this.chkNula.AutoSize = true;
            this.chkNula.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNula.Location = new System.Drawing.Point(57, 152);
            this.chkNula.Name = "chkNula";
            this.chkNula.Size = new System.Drawing.Size(52, 20);
            this.chkNula.TabIndex = 57;
            this.chkNula.Text = "Nula";
            this.chkNula.UseVisualStyleBackColor = true;
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
            this.cmdCancelar.Location = new System.Drawing.Point(223, 181);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(110, 44);
            this.cmdCancelar.TabIndex = 59;
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
            this.cmdGuardar.Location = new System.Drawing.Point(97, 181);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(102, 44);
            this.cmdGuardar.TabIndex = 58;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdGuardar.UseVisualStyleBackColor = false;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // txtMensualidad
            // 
            this.txtMensualidad.EditValue = "0.00";
            this.txtMensualidad.Location = new System.Drawing.Point(166, 123);
            this.txtMensualidad.Name = "txtMensualidad";
            this.txtMensualidad.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtMensualidad.Properties.Appearance.Options.UseFont = true;
            this.txtMensualidad.Size = new System.Drawing.Size(169, 26);
            this.txtMensualidad.TabIndex = 55;
            // 
            // btnDetalleCurso
            // 
            this.btnDetalleCurso.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDetalleCurso.ImageOptions.Image")));
            this.btnDetalleCurso.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnDetalleCurso.Location = new System.Drawing.Point(341, 68);
            this.btnDetalleCurso.Name = "btnDetalleCurso";
            this.btnDetalleCurso.Size = new System.Drawing.Size(39, 44);
            this.btnDetalleCurso.TabIndex = 54;
            this.btnDetalleCurso.Click += new System.EventHandler(this.btnDetalleCurso_Click);
            // 
            // gridLookUpEdit1
            // 
            this.gridLookUpEdit1.Location = new System.Drawing.Point(166, 78);
            this.gridLookUpEdit1.Name = "gridLookUpEdit1";
            this.gridLookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.gridLookUpEdit1.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit1.Properties.DataSource = this.cursosBindingSource;
            this.gridLookUpEdit1.Properties.DisplayMember = "Curso";
            this.gridLookUpEdit1.Properties.NullText = "";
            this.gridLookUpEdit1.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridLookUpEdit1.Properties.ValueMember = "id";
            this.gridLookUpEdit1.Size = new System.Drawing.Size(169, 26);
            this.gridLookUpEdit1.TabIndex = 53;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colCurso});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // colCurso
            // 
            this.colCurso.FieldName = "Curso";
            this.colCurso.Name = "colCurso";
            this.colCurso.Visible = true;
            this.colCurso.VisibleIndex = 1;
            // 
            // txtEstudiante
            // 
            this.txtEstudiante.EditValue = "";
            this.txtEstudiante.Enabled = false;
            this.txtEstudiante.Location = new System.Drawing.Point(166, 36);
            this.txtEstudiante.Name = "txtEstudiante";
            this.txtEstudiante.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtEstudiante.Properties.Appearance.Options.UseFont = true;
            this.txtEstudiante.Size = new System.Drawing.Size(169, 26);
            this.txtEstudiante.TabIndex = 51;
            this.txtEstudiante.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEstudiante_KeyDown);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorAlumno
            // 
            this.errorAlumno.ContainerControl = this;
            // 
            // errorNivel
            // 
            this.errorNivel.ContainerControl = this;
            // 
            // errorInstructor
            // 
            this.errorInstructor.ContainerControl = this;
            // 
            // frmMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 242);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.chkNula);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtMensualidad);
            this.Controls.Add(this.btnDetalleCurso);
            this.Controls.Add(this.gridLookUpEdit1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtEstudiante);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMatricula";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMatricula_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMatriculado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMensualidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstudiante.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNivel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorInstructor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtEstudiante;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.SimpleButton btnDetalleCurso;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtMensualidad;
        private System.Windows.Forms.CheckBox chkNula;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.BindingSource cursosBindingSource;
        private dsMatriculado dsMatriculado1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colCurso;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorAlumno;
        private System.Windows.Forms.ErrorProvider errorNivel;
        private System.Windows.Forms.ErrorProvider errorInstructor;
    }
}