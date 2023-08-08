
namespace ERP_INTECOLI.Administracion.Instructores
{
    partial class frmAgregarInstructores
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarInstructores));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.cmdUserWeb = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.dsInstructores1 = new ERP_INTECOLI.Administracion.Instructores.dsInstructores();
            this.label5 = new System.Windows.Forms.Label();
            this.dtIngreso = new System.Windows.Forms.DateTimePicker();
            this.cbkHabilitado = new System.Windows.Forms.CheckBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxSexo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.cmdAgregarTelefono = new System.Windows.Forms.Button();
            this.cmdNuevo = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.xtraTabControl2 = new DevExpress.XtraTab.XtraTabControl();
            this.tabTelefonos = new DevExpress.XtraTab.XtraTabPage();
            this.grdTelefonos = new DevExpress.XtraGrid.GridControl();
            this.grdvTelefonos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_estudiante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo_telefono_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdEditarCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposEditarTelefono = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposEliminar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInstructores1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).BeginInit();
            this.xtraTabControl2.SuspendLayout();
            this.tabTelefonos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTelefonos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvTelefonos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposEditarTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdUserWeb
            // 
            this.cmdUserWeb.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.cmdUserWeb.FlatAppearance.BorderColor = System.Drawing.Color.SlateBlue;
            this.cmdUserWeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdUserWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUserWeb.ForeColor = System.Drawing.Color.White;
            this.cmdUserWeb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdUserWeb.Location = new System.Drawing.Point(23, 242);
            this.cmdUserWeb.Name = "cmdUserWeb";
            this.cmdUserWeb.Size = new System.Drawing.Size(154, 45);
            this.cmdUserWeb.TabIndex = 50;
            this.cmdUserWeb.Text = "Acceso Web";
            this.cmdUserWeb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdUserWeb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdUserWeb.UseVisualStyleBackColor = false;
            this.cmdUserWeb.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(66, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 49;
            this.label7.Text = "Cedula:";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(127, 47);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(188, 21);
            this.txtCedula.TabIndex = 32;
            // 
            // dsInstructores1
            // 
            this.dsInstructores1.DataSetName = "dsInstructores";
            this.dsInstructores1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "Fecha Ingreso:";
            // 
            // dtIngreso
            // 
            this.dtIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtIngreso.Location = new System.Drawing.Point(127, 176);
            this.dtIngreso.Name = "dtIngreso";
            this.dtIngreso.Size = new System.Drawing.Size(97, 22);
            this.dtIngreso.TabIndex = 40;
            // 
            // cbkHabilitado
            // 
            this.cbkHabilitado.AutoSize = true;
            this.cbkHabilitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbkHabilitado.Location = new System.Drawing.Point(127, 206);
            this.cbkHabilitado.Name = "cbkHabilitado";
            this.cbkHabilitado.Size = new System.Drawing.Size(89, 20);
            this.cbkHabilitado.TabIndex = 41;
            this.cbkHabilitado.Text = "Habilitado";
            this.cbkHabilitado.UseVisualStyleBackColor = true;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(127, 149);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(187, 21);
            this.txtDireccion.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "Direccion:";
            // 
            // cbxSexo
            // 
            this.cbxSexo.FormattingEnabled = true;
            this.cbxSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbxSexo.Location = new System.Drawing.Point(127, 122);
            this.cbxSexo.Name = "cbxSexo";
            this.cbxSexo.Size = new System.Drawing.Size(50, 21);
            this.cbxSexo.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Sexo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Apellidos:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(127, 97);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(188, 21);
            this.txtApellidos.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Nombres:";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(127, 71);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(188, 21);
            this.txtNombres.TabIndex = 33;
            // 
            // cmdAgregarTelefono
            // 
            this.cmdAgregarTelefono.BackColor = System.Drawing.Color.PaleGreen;
            this.cmdAgregarTelefono.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.cmdAgregarTelefono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAgregarTelefono.Image = global::ERP_INTECOLI.Properties.Resources.anadir;
            this.cmdAgregarTelefono.Location = new System.Drawing.Point(636, 5);
            this.cmdAgregarTelefono.Name = "cmdAgregarTelefono";
            this.cmdAgregarTelefono.Size = new System.Drawing.Size(56, 47);
            this.cmdAgregarTelefono.TabIndex = 47;
            this.cmdAgregarTelefono.UseVisualStyleBackColor = false;
            this.cmdAgregarTelefono.Click += new System.EventHandler(this.cmdAgregarTelefono_Click);
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.cmdNuevo.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.cmdNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNuevo.Image = global::ERP_INTECOLI.Properties.Resources.edit;
            this.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdNuevo.Location = new System.Drawing.Point(243, 242);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(103, 45);
            this.cmdNuevo.TabIndex = 43;
            this.cmdNuevo.Text = "Nuevo";
            this.cmdNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdNuevo.UseVisualStyleBackColor = false;
            this.cmdNuevo.Visible = false;
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
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
            this.cmdCancelar.Location = new System.Drawing.Point(543, 242);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(111, 45);
            this.cmdCancelar.TabIndex = 45;
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
            this.cmdGuardar.Location = new System.Drawing.Point(385, 242);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(113, 45);
            this.cmdGuardar.TabIndex = 44;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdGuardar.UseVisualStyleBackColor = false;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // xtraTabControl2
            // 
            this.xtraTabControl2.Location = new System.Drawing.Point(332, 47);
            this.xtraTabControl2.Name = "xtraTabControl2";
            this.xtraTabControl2.SelectedTabPage = this.tabTelefonos;
            this.xtraTabControl2.Size = new System.Drawing.Size(379, 159);
            this.xtraTabControl2.TabIndex = 52;
            this.xtraTabControl2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabTelefonos});
            // 
            // tabTelefonos
            // 
            this.tabTelefonos.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTelefonos.Appearance.Header.Options.UseFont = true;
            this.tabTelefonos.Appearance.HeaderActive.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTelefonos.Appearance.HeaderActive.Options.UseFont = true;
            this.tabTelefonos.Controls.Add(this.grdTelefonos);
            this.tabTelefonos.Name = "tabTelefonos";
            this.tabTelefonos.Size = new System.Drawing.Size(377, 131);
            this.tabTelefonos.Text = "Telefonos";
            // 
            // grdTelefonos
            // 
            this.grdTelefonos.DataMember = "detalle_telefonos";
            this.grdTelefonos.DataSource = this.dsInstructores1;
            this.grdTelefonos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTelefonos.Location = new System.Drawing.Point(0, 0);
            this.grdTelefonos.MainView = this.grdvTelefonos;
            this.grdTelefonos.Name = "grdTelefonos";
            this.grdTelefonos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.reposEditarTelefono,
            this.reposEliminar});
            this.grdTelefonos.Size = new System.Drawing.Size(377, 131);
            this.grdTelefonos.TabIndex = 0;
            this.grdTelefonos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvTelefonos});
            // 
            // grdvTelefonos
            // 
            this.grdvTelefonos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_estudiante,
            this.coltelefono,
            this.coltipo_telefono_id,
            this.coltipo_descripcion,
            this.grdEditarCol,
            this.gridColumn2});
            this.grdvTelefonos.GridControl = this.grdTelefonos;
            this.grdvTelefonos.LevelIndent = 0;
            this.grdvTelefonos.Name = "grdvTelefonos";
            this.grdvTelefonos.OptionsEditForm.PopupEditFormWidth = 400;
            this.grdvTelefonos.OptionsView.ShowGroupPanel = false;
            this.grdvTelefonos.PreviewIndent = 0;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.ReadOnly = true;
            this.colid.Width = 53;
            // 
            // colid_estudiante
            // 
            this.colid_estudiante.FieldName = "id_instructor";
            this.colid_estudiante.Name = "colid_estudiante";
            this.colid_estudiante.OptionsColumn.ReadOnly = true;
            this.colid_estudiante.Width = 68;
            // 
            // coltelefono
            // 
            this.coltelefono.FieldName = "telefono";
            this.coltelefono.Name = "coltelefono";
            this.coltelefono.OptionsColumn.ReadOnly = true;
            this.coltelefono.Visible = true;
            this.coltelefono.VisibleIndex = 0;
            this.coltelefono.Width = 126;
            // 
            // coltipo_telefono_id
            // 
            this.coltipo_telefono_id.FieldName = "tipo_telefono_id";
            this.coltipo_telefono_id.Name = "coltipo_telefono_id";
            this.coltipo_telefono_id.OptionsColumn.ReadOnly = true;
            this.coltipo_telefono_id.Width = 67;
            // 
            // coltipo_descripcion
            // 
            this.coltipo_descripcion.FieldName = "tipo_descripcion";
            this.coltipo_descripcion.Name = "coltipo_descripcion";
            this.coltipo_descripcion.OptionsColumn.ReadOnly = true;
            this.coltipo_descripcion.Visible = true;
            this.coltipo_descripcion.VisibleIndex = 1;
            this.coltipo_descripcion.Width = 108;
            // 
            // grdEditarCol
            // 
            this.grdEditarCol.Caption = "Editar";
            this.grdEditarCol.ColumnEdit = this.reposEditarTelefono;
            this.grdEditarCol.FieldName = "editar";
            this.grdEditarCol.Name = "grdEditarCol";
            this.grdEditarCol.Visible = true;
            this.grdEditarCol.VisibleIndex = 2;
            this.grdEditarCol.Width = 66;
            // 
            // reposEditarTelefono
            // 
            this.reposEditarTelefono.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.reposEditarTelefono.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.reposEditarTelefono.Name = "reposEditarTelefono";
            this.reposEditarTelefono.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.reposEditarTelefono.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.reposEditarTelefono_ButtonClick);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Eliminar";
            this.gridColumn2.ColumnEdit = this.reposEliminar;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            // 
            // reposEliminar
            // 
            this.reposEliminar.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.reposEliminar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.reposEliminar.Name = "reposEliminar";
            this.reposEliminar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.reposEliminar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.reposEliminar_ButtonClick);
            // 
            // frmAgregarInstructores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 301);
            this.Controls.Add(this.xtraTabControl2);
            this.Controls.Add(this.cmdUserWeb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.cmdAgregarTelefono);
            this.Controls.Add(this.cmdNuevo);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtIngreso);
            this.Controls.Add(this.cbkHabilitado);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxSexo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombres);
            this.MaximizeBox = false;
            this.Name = "frmAgregarInstructores";
            this.Text = "Agregar Instructores";
            ((System.ComponentModel.ISupportInitialize)(this.dsInstructores1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).EndInit();
            this.xtraTabControl2.ResumeLayout(false);
            this.tabTelefonos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTelefonos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvTelefonos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposEditarTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposEliminar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdUserWeb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Button cmdAgregarTelefono;
        private System.Windows.Forms.Button cmdNuevo;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtIngreso;
        private System.Windows.Forms.CheckBox cbkHabilitado;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxSexo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombres;
        private dsInstructores dsInstructores1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl2;
        private DevExpress.XtraTab.XtraTabPage tabTelefonos;
        private DevExpress.XtraGrid.GridControl grdTelefonos;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvTelefonos;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_estudiante;
        private DevExpress.XtraGrid.Columns.GridColumn coltelefono;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo_telefono_id;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn grdEditarCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposEditarTelefono;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposEliminar;
    }
}