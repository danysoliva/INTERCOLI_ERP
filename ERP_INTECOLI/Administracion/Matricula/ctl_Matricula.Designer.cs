
namespace ERP_INTECOLI.Administracion.Matricula
{
    partial class ctl_Matricula
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

        #region Component Designer generated code

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctl_Matricula));
            this.label2 = new System.Windows.Forms.Label();
            this.lblNuevoNombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNuevoNombre = new DevExpress.XtraEditors.TextEdit();
            this.grNivel = new DevExpress.XtraEditors.GridLookUpEdit();
            this.grNivelView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_nivel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtEstudiante = new DevExpress.XtraEditors.TextEdit();
            this.cmdEditNivel = new DevExpress.XtraEditors.SimpleButton();
            this.cmdGuardarNuevoNombre = new DevExpress.XtraEditors.SimpleButton();
            this.cmdEditSecciones = new DevExpress.XtraEditors.SimpleButton();
            this.listBoxSeccion = new DevExpress.XtraEditors.ListBoxControl();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValor = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.dsNuevoCursoMatricula1 = new ERP_INTECOLI.Administracion.Matricula.dsNuevoCursoMatricula();
            this.dsMatriculado = new ERP_INTECOLI.Administracion.Matricula.dsMatriculado();
            this.nivelesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtNuevoNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grNivel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grNivelView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstudiante.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxSeccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNuevoCursoMatricula1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMatriculado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivelesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Curso a Matricular";
            // 
            // lblNuevoNombre
            // 
            this.lblNuevoNombre.AutoSize = true;
            this.lblNuevoNombre.Enabled = false;
            this.lblNuevoNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoNombre.Location = new System.Drawing.Point(44, 167);
            this.lblNuevoNombre.Name = "lblNuevoNombre";
            this.lblNuevoNombre.Size = new System.Drawing.Size(118, 21);
            this.lblNuevoNombre.TabIndex = 50;
            this.lblNuevoNombre.Text = "Nuevo Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.TabIndex = 48;
            this.label3.Text = "Nivel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 47;
            this.label1.Text = "Estudiante";
            // 
            // txtNuevoNombre
            // 
            this.txtNuevoNombre.Enabled = false;
            this.txtNuevoNombre.Location = new System.Drawing.Point(172, 164);
            this.txtNuevoNombre.Name = "txtNuevoNombre";
            this.txtNuevoNombre.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevoNombre.Properties.Appearance.Options.UseFont = true;
            this.txtNuevoNombre.Size = new System.Drawing.Size(199, 28);
            this.txtNuevoNombre.TabIndex = 49;
            // 
            // grNivel
            // 
            this.grNivel.EditValue = "";
            this.grNivel.Location = new System.Drawing.Point(172, 122);
            this.grNivel.Name = "grNivel";
            this.grNivel.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grNivel.Properties.Appearance.Options.UseFont = true;
            this.grNivel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, false, false, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.grNivel.Properties.DataSource = this.nivelesBindingSource;
            this.grNivel.Properties.DisplayMember = "descripcion";
            this.grNivel.Properties.NullText = "";
            this.grNivel.Properties.PopupView = this.grNivelView;
            this.grNivel.Properties.ValueMember = "id_nivel";
            this.grNivel.Properties.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView;
            this.grNivel.Size = new System.Drawing.Size(199, 28);
            this.grNivel.TabIndex = 46;
            // 
            // grNivelView
            // 
            this.grNivelView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grNivelView.Appearance.HeaderPanel.Options.UseFont = true;
            this.grNivelView.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grNivelView.Appearance.Row.Options.UseFont = true;
            this.grNivelView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_nivel,
            this.coldescripcion,
            this.colvalor});
            this.grNivelView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.grNivelView.Name = "grNivelView";
            this.grNivelView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grNivelView.OptionsView.ShowGroupPanel = false;
            // 
            // colid_nivel
            // 
            this.colid_nivel.FieldName = "id_nivel";
            this.colid_nivel.Name = "colid_nivel";
            // 
            // coldescripcion
            // 
            this.coldescripcion.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coldescripcion.AppearanceCell.Options.UseFont = true;
            this.coldescripcion.Caption = "Nivel";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            // 
            // colvalor
            // 
            this.colvalor.FieldName = "valor";
            this.colvalor.Name = "colvalor";
            // 
            // txtEstudiante
            // 
            this.txtEstudiante.Location = new System.Drawing.Point(172, 81);
            this.txtEstudiante.Name = "txtEstudiante";
            this.txtEstudiante.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstudiante.Properties.Appearance.Options.UseFont = true;
            this.txtEstudiante.Size = new System.Drawing.Size(199, 28);
            this.txtEstudiante.TabIndex = 45;
            // 
            // cmdEditNivel
            // 
            this.cmdEditNivel.Appearance.BackColor = System.Drawing.Color.PaleGreen;
            this.cmdEditNivel.Appearance.Options.UseBackColor = true;
            this.cmdEditNivel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdEditNivel.ImageOptions.Image")));
            this.cmdEditNivel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdEditNivel.Location = new System.Drawing.Point(377, 121);
            this.cmdEditNivel.Name = "cmdEditNivel";
            this.cmdEditNivel.Size = new System.Drawing.Size(40, 30);
            this.cmdEditNivel.TabIndex = 51;
            // 
            // cmdGuardarNuevoNombre
            // 
            this.cmdGuardarNuevoNombre.Appearance.BackColor = System.Drawing.Color.PaleGreen;
            this.cmdGuardarNuevoNombre.Appearance.Options.UseBackColor = true;
            this.cmdGuardarNuevoNombre.Enabled = false;
            this.cmdGuardarNuevoNombre.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardarNuevoNombre.ImageOptions.Image")));
            this.cmdGuardarNuevoNombre.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdGuardarNuevoNombre.Location = new System.Drawing.Point(377, 163);
            this.cmdGuardarNuevoNombre.Name = "cmdGuardarNuevoNombre";
            this.cmdGuardarNuevoNombre.Size = new System.Drawing.Size(40, 30);
            this.cmdGuardarNuevoNombre.TabIndex = 52;
            // 
            // cmdEditSecciones
            // 
            this.cmdEditSecciones.Appearance.BackColor = System.Drawing.Color.PaleGreen;
            this.cmdEditSecciones.Appearance.Options.UseBackColor = true;
            this.cmdEditSecciones.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdEditSecciones.ImageOptions.Image")));
            this.cmdEditSecciones.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdEditSecciones.Location = new System.Drawing.Point(377, 212);
            this.cmdEditSecciones.Name = "cmdEditSecciones";
            this.cmdEditSecciones.Size = new System.Drawing.Size(40, 30);
            this.cmdEditSecciones.TabIndex = 55;
            // 
            // listBoxSeccion
            // 
            this.listBoxSeccion.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSeccion.Appearance.Options.UseFont = true;
            this.listBoxSeccion.DataSource = this.dsNuevoCursoMatricula1;
            this.listBoxSeccion.DisplayMember = "secciones.secciones";
            this.listBoxSeccion.ItemPadding = new System.Windows.Forms.Padding(2);
            this.listBoxSeccion.Location = new System.Drawing.Point(172, 212);
            this.listBoxSeccion.Name = "listBoxSeccion";
            this.listBoxSeccion.Size = new System.Drawing.Size(199, 114);
            this.listBoxSeccion.TabIndex = 54;
            this.listBoxSeccion.ValueMember = "id_seccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 53;
            this.label4.Text = "Seccion";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(172, 343);
            this.txtValor.Name = "txtValor";
            this.txtValor.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Properties.Appearance.Options.UseFont = true;
            this.txtValor.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtValor.Properties.MaskSettings.Set("mask", "#,##0.00");
            this.txtValor.Size = new System.Drawing.Size(199, 28);
            this.txtValor.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 21);
            this.label5.TabIndex = 57;
            this.label5.Text = "Valor a Pagar";
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
            this.cmdCancelar.Location = new System.Drawing.Point(233, 391);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(116, 40);
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
            this.cmdGuardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Image = global::ERP_INTECOLI.Properties.Resources.save;
            this.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdGuardar.Location = new System.Drawing.Point(100, 392);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(115, 40);
            this.cmdGuardar.TabIndex = 58;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdGuardar.UseVisualStyleBackColor = false;
            // 
            // dsNuevoCursoMatricula1
            // 
            this.dsNuevoCursoMatricula1.DataSetName = "dsNuevoCursoMatricula";
            this.dsNuevoCursoMatricula1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsMatriculado
            // 
            this.dsMatriculado.DataSetName = "dsMatriculado";
            this.dsMatriculado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nivelesBindingSource
            // 
            this.nivelesBindingSource.DataMember = "niveles";
            this.nivelesBindingSource.DataSource = this.dsMatriculado;
            // 
            // ctl_Matricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmdEditSecciones);
            this.Controls.Add(this.listBoxSeccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdGuardarNuevoNombre);
            this.Controls.Add(this.cmdEditNivel);
            this.Controls.Add(this.lblNuevoNombre);
            this.Controls.Add(this.txtNuevoNombre);
            this.Controls.Add(this.grNivel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEstudiante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "ctl_Matricula";
            this.Size = new System.Drawing.Size(464, 437);
            ((System.ComponentModel.ISupportInitialize)(this.txtNuevoNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grNivel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grNivelView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstudiante.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxSeccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNuevoCursoMatricula1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMatriculado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivelesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNuevoNombre;
        private DevExpress.XtraEditors.TextEdit txtNuevoNombre;
        private DevExpress.XtraEditors.GridLookUpEdit grNivel;
        private DevExpress.XtraGrid.Views.Grid.GridView grNivelView;
        private DevExpress.XtraGrid.Columns.GridColumn colid_nivel;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtEstudiante;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton cmdEditNivel;
        private DevExpress.XtraEditors.SimpleButton cmdGuardarNuevoNombre;
        private DevExpress.XtraEditors.SimpleButton cmdEditSecciones;
        private DevExpress.XtraEditors.ListBoxControl listBoxSeccion;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdGuardar;
        private dsNuevoCursoMatricula dsNuevoCursoMatricula1;
        private System.Windows.Forms.BindingSource nivelesBindingSource;
        private dsMatriculado dsMatriculado;
    }
}
