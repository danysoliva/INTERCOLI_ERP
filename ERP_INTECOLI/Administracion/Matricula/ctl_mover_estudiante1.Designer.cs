
namespace ERP_INTECOLI.Administracion.Matricula
{
    partial class ctl_mover_estudiante1
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
            this.listBoxSeccion = new DevExpress.XtraEditors.ListBoxControl();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNivelOld = new DevExpress.XtraEditors.TextEdit();
            this.txtSeccion = new DevExpress.XtraEditors.TextEdit();
            this.txtValorNew = new DevExpress.XtraEditors.TextEdit();
            this.grNivelNew = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtValor = new DevExpress.XtraEditors.TextEdit();
            this.txtEstudiante = new DevExpress.XtraEditors.TextEdit();
            this.dsNuevoCursoMatricula1 = new ERP_INTECOLI.Administracion.Matricula.dsNuevoCursoMatricula();
            this.nivelesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxSeccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNivelOld.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorNew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grNivelNew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstudiante.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNuevoCursoMatricula1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivelesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxSeccion
            // 
            this.listBoxSeccion.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSeccion.Appearance.Options.UseFont = true;
            this.listBoxSeccion.DataSource = this.dsNuevoCursoMatricula1;
            this.listBoxSeccion.DisplayMember = "secciones.secciones";
            this.listBoxSeccion.Location = new System.Drawing.Point(552, 108);
            this.listBoxSeccion.Name = "listBoxSeccion";
            this.listBoxSeccion.Size = new System.Drawing.Size(199, 114);
            this.listBoxSeccion.TabIndex = 51;
            this.listBoxSeccion.ValueMember = "id_seccion";
            this.listBoxSeccion.SelectedValueChanged += new System.EventHandler(this.listBoxSeccion_SelectedValueChanged);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.BackColor = System.Drawing.Color.LightSalmon;
            this.cmdCancelar.FlatAppearance.BorderColor = System.Drawing.Color.LightSalmon;
            this.cmdCancelar.FlatAppearance.BorderSize = 2;
            this.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Image = global::ERP_INTECOLI.Properties.Resources.cerrar;
            this.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCancelar.Location = new System.Drawing.Point(632, 262);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(119, 47);
            this.cmdCancelar.TabIndex = 46;
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
            this.cmdGuardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Image = global::ERP_INTECOLI.Properties.Resources.save;
            this.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdGuardar.Location = new System.Drawing.Point(498, 262);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(109, 47);
            this.cmdGuardar.TabIndex = 45;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdGuardar.UseVisualStyleBackColor = false;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(443, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 21);
            this.label6.TabIndex = 50;
            this.label6.Text = "Valor a Pagar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(443, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 21);
            this.label7.TabIndex = 49;
            this.label7.Text = "Seccion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(443, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 21);
            this.label8.TabIndex = 48;
            this.label8.Text = "Nivel";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(539, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(233, 37);
            this.label10.TabIndex = 47;
            this.label10.Text = "Curso a Matricular";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 21);
            this.label5.TabIndex = 42;
            this.label5.Text = "Valor a Pagar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 41;
            this.label4.Text = "Seccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.TabIndex = 40;
            this.label3.Text = "Nivel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 39;
            this.label1.Text = "Estudiante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 37);
            this.label2.TabIndex = 38;
            this.label2.Text = "Curso Actual";
            // 
            // txtNivelOld
            // 
            this.txtNivelOld.Enabled = false;
            this.txtNivelOld.Location = new System.Drawing.Point(121, 132);
            this.txtNivelOld.Name = "txtNivelOld";
            this.txtNivelOld.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNivelOld.Properties.Appearance.Options.UseFont = true;
            this.txtNivelOld.Size = new System.Drawing.Size(261, 28);
            this.txtNivelOld.TabIndex = 53;
            // 
            // txtSeccion
            // 
            this.txtSeccion.Enabled = false;
            this.txtSeccion.Location = new System.Drawing.Point(121, 178);
            this.txtSeccion.Name = "txtSeccion";
            this.txtSeccion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeccion.Properties.Appearance.Options.UseFont = true;
            this.txtSeccion.Size = new System.Drawing.Size(261, 28);
            this.txtSeccion.TabIndex = 52;
            // 
            // txtValorNew
            // 
            this.txtValorNew.Location = new System.Drawing.Point(552, 228);
            this.txtValorNew.Name = "txtValorNew";
            this.txtValorNew.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorNew.Properties.Appearance.Options.UseFont = true;
            this.txtValorNew.Size = new System.Drawing.Size(199, 28);
            this.txtValorNew.TabIndex = 44;
            // 
            // grNivelNew
            // 
            this.grNivelNew.EditValue = "";
            this.grNivelNew.Location = new System.Drawing.Point(552, 71);
            this.grNivelNew.Name = "grNivelNew";
            this.grNivelNew.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grNivelNew.Properties.Appearance.Options.UseFont = true;
            this.grNivelNew.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, false, false, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.grNivelNew.Properties.DataSource = this.nivelesBindingSource;
            this.grNivelNew.Properties.DisplayMember = "descripcion";
            this.grNivelNew.Properties.NullText = "";
            this.grNivelNew.Properties.PopupView = this.gridView2;
            this.grNivelNew.Properties.ValueMember = "id_nivel";
            this.grNivelNew.Properties.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView;
            this.grNivelNew.Size = new System.Drawing.Size(199, 28);
            this.grNivelNew.TabIndex = 43;
            this.grNivelNew.EditValueChanged += new System.EventHandler(this.grNivelNew_EditValueChanged);
            // 
            // gridView2
            // 
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.Row.Options.UseFont = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "id_nivel";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn5.AppearanceCell.Options.UseFont = true;
            this.gridColumn5.Caption = "Nivel";
            this.gridColumn5.FieldName = "descripcion";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            // 
            // gridColumn6
            // 
            this.gridColumn6.FieldName = "valor";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(121, 223);
            this.txtValor.Name = "txtValor";
            this.txtValor.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Properties.Appearance.Options.UseFont = true;
            this.txtValor.Size = new System.Drawing.Size(261, 28);
            this.txtValor.TabIndex = 37;
            // 
            // txtEstudiante
            // 
            this.txtEstudiante.Location = new System.Drawing.Point(121, 86);
            this.txtEstudiante.Name = "txtEstudiante";
            this.txtEstudiante.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstudiante.Properties.Appearance.Options.UseFont = true;
            this.txtEstudiante.Size = new System.Drawing.Size(261, 28);
            this.txtEstudiante.TabIndex = 36;
            // 
            // dsNuevoCursoMatricula1
            // 
            this.dsNuevoCursoMatricula1.DataSetName = "dsNuevoCursoMatricula";
            this.dsNuevoCursoMatricula1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nivelesBindingSource
            // 
            this.nivelesBindingSource.DataMember = "niveles";
            this.nivelesBindingSource.DataSource = this.dsNuevoCursoMatricula1;
            // 
            // ctl_mover_estudiante1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 317);
            this.Controls.Add(this.txtNivelOld);
            this.Controls.Add(this.txtSeccion);
            this.Controls.Add(this.listBoxSeccion);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.txtValorNew);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grNivelNew);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEstudiante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "ctl_mover_estudiante1";
            ((System.ComponentModel.ISupportInitialize)(this.listBoxSeccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNivelOld.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorNew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grNivelNew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstudiante.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNuevoCursoMatricula1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivelesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.TextEdit txtNivelOld;
        public DevExpress.XtraEditors.TextEdit txtSeccion;
        private DevExpress.XtraEditors.ListBoxControl listBoxSeccion;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdGuardar;
        private DevExpress.XtraEditors.TextEdit txtValorNew;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.GridLookUpEdit grNivelNew;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        public DevExpress.XtraEditors.TextEdit txtValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public DevExpress.XtraEditors.TextEdit txtEstudiante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private dsNuevoCursoMatricula dsNuevoCursoMatricula1;
        private System.Windows.Forms.BindingSource nivelesBindingSource;
    }
}