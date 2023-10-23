
namespace ERP_INTECOLI.Usuarios
{
    partial class frmAddWindowToUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddWindowToUser));
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsUsuarios1 = new ERP_INTECOLI.Usuarios.dsUsuarios();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_ventana = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhabilitada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_vinculo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colselect_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colupdate_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colinsert_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldelete_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Eliminar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.seleccionar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.funciones_button_n = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cmdCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUsuarios1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funciones_button_n)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(289, 12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(221, 30);
            this.labelControl4.TabIndex = 17;
            this.labelControl4.Text = "Seleccione las Ventanas";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "view_user";
            this.gridControl1.DataSource = this.dsUsuarios1;
            this.gridControl1.Location = new System.Drawing.Point(5, 48);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.funciones_button_n});
            this.gridControl1.Size = new System.Drawing.Size(811, 330);
            this.gridControl1.TabIndex = 16;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsUsuarios1
            // 
            this.dsUsuarios1.DataSetName = "dsUsuarios";
            this.dsUsuarios1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_ventana,
            this.colnombre,
            this.colcodigo,
            this.coldescripcion,
            this.colhabilitada,
            this.colfecha_vinculo,
            this.colselect_,
            this.colupdate_,
            this.colinsert_,
            this.coldelete_,
            this.Eliminar,
            this.seleccionar});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid_ventana
            // 
            this.colid_ventana.FieldName = "id_ventana";
            this.colid_ventana.Name = "colid_ventana";
            this.colid_ventana.OptionsColumn.AllowEdit = false;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.AllowEdit = false;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 0;
            this.colnombre.Width = 265;
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "Codigo";
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.OptionsColumn.AllowEdit = false;
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 1;
            this.colcodigo.Width = 91;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripcion";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.AllowEdit = false;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 2;
            this.coldescripcion.Width = 294;
            // 
            // colhabilitada
            // 
            this.colhabilitada.Caption = "Habilitada";
            this.colhabilitada.FieldName = "habilitada";
            this.colhabilitada.Name = "colhabilitada";
            this.colhabilitada.OptionsColumn.AllowEdit = false;
            this.colhabilitada.Width = 38;
            // 
            // colfecha_vinculo
            // 
            this.colfecha_vinculo.Caption = "Fecha Creado";
            this.colfecha_vinculo.FieldName = "fecha_vinculo";
            this.colfecha_vinculo.Name = "colfecha_vinculo";
            this.colfecha_vinculo.OptionsColumn.AllowEdit = false;
            this.colfecha_vinculo.Width = 68;
            // 
            // colselect_
            // 
            this.colselect_.Caption = "Ver";
            this.colselect_.FieldName = "select_";
            this.colselect_.Name = "colselect_";
            this.colselect_.OptionsColumn.AllowEdit = false;
            this.colselect_.Width = 30;
            // 
            // colupdate_
            // 
            this.colupdate_.Caption = "Editar";
            this.colupdate_.FieldName = "update_";
            this.colupdate_.Name = "colupdate_";
            this.colupdate_.OptionsColumn.AllowEdit = false;
            this.colupdate_.Width = 38;
            // 
            // colinsert_
            // 
            this.colinsert_.Caption = "Agregar";
            this.colinsert_.FieldName = "insert_";
            this.colinsert_.Name = "colinsert_";
            this.colinsert_.OptionsColumn.AllowEdit = false;
            this.colinsert_.Width = 44;
            // 
            // coldelete_
            // 
            this.coldelete_.Caption = "Eliminar";
            this.coldelete_.FieldName = "delete_";
            this.coldelete_.Name = "coldelete_";
            this.coldelete_.OptionsColumn.AllowEdit = false;
            this.coldelete_.Width = 56;
            // 
            // Eliminar
            // 
            this.Eliminar.Caption = "Quitar Acceso";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 79;
            // 
            // seleccionar
            // 
            this.seleccionar.Caption = "Seleccionar";
            this.seleccionar.FieldName = "seleccionar";
            this.seleccionar.Name = "seleccionar";
            this.seleccionar.Visible = true;
            this.seleccionar.VisibleIndex = 3;
            this.seleccionar.Width = 136;
            // 
            // funciones_button_n
            // 
            this.funciones_button_n.AutoHeight = false;
            this.funciones_button_n.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.funciones_button_n.Name = "funciones_button_n";
            this.funciones_button_n.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdCancelar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Appearance.Options.UseBackColor = true;
            this.cmdCancelar.Appearance.Options.UseFont = true;
            this.cmdCancelar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCancelar.ImageOptions.Image")));
            this.cmdCancelar.Location = new System.Drawing.Point(397, 384);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(156, 39);
            this.cmdCancelar.TabIndex = 19;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmdGuardar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Appearance.Options.UseBackColor = true;
            this.cmdGuardar.Appearance.Options.UseFont = true;
            this.cmdGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.ImageOptions.Image")));
            this.cmdGuardar.Location = new System.Drawing.Point(235, 384);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(156, 39);
            this.cmdGuardar.TabIndex = 18;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // frmAddWindowToUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 435);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.gridControl1);
            this.MaximizeBox = false;
            this.Name = "frmAddWindowToUser";
            this.Text = "Conceder Acceso a Ventana";
            this.Load += new System.EventHandler(this.frmAddWindowToUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUsuarios1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funciones_button_n)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdCancelar;
        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_ventana;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colhabilitada;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_vinculo;
        private DevExpress.XtraGrid.Columns.GridColumn colselect_;
        private DevExpress.XtraGrid.Columns.GridColumn colupdate_;
        private DevExpress.XtraGrid.Columns.GridColumn colinsert_;
        private DevExpress.XtraGrid.Columns.GridColumn coldelete_;
        private DevExpress.XtraGrid.Columns.GridColumn Eliminar;
        private DevExpress.XtraGrid.Columns.GridColumn seleccionar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit funciones_button_n;
        private dsUsuarios dsUsuarios1;
    }
}