
namespace ERP_INTECOLI.Administracion.Estudiantes
{
    partial class frmBuscarEstudiantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarEstudiantes));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControlDetalleEstudiantes = new DevExpress.XtraGrid.GridControl();
            this.dsEstudiantes1 = new ERP_INTECOLI.Administracion.Estudiantes.dsEstudiantes();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_estudiante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colapellidos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero_identidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeleccionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconcat_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdAplicar = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.txtParametroBusqueda = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetalleEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstudiantes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParametroBusqueda.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 78);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(143, 17);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Seleccione un Estudiante";
            // 
            // gridControlDetalleEstudiantes
            // 
            this.gridControlDetalleEstudiantes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlDetalleEstudiantes.DataMember = "serach_estudiantes";
            this.gridControlDetalleEstudiantes.DataSource = this.dsEstudiantes1;
            this.gridControlDetalleEstudiantes.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6);
            this.gridControlDetalleEstudiantes.Location = new System.Drawing.Point(5, 145);
            this.gridControlDetalleEstudiantes.MainView = this.gridView1;
            this.gridControlDetalleEstudiantes.Margin = new System.Windows.Forms.Padding(6);
            this.gridControlDetalleEstudiantes.Name = "gridControlDetalleEstudiantes";
            this.gridControlDetalleEstudiantes.Size = new System.Drawing.Size(759, 332);
            this.gridControlDetalleEstudiantes.TabIndex = 15;
            this.gridControlDetalleEstudiantes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.colid_estudiante,
            this.colnombres,
            this.colapellidos,
            this.colnumero_identidad,
            this.colSeleccionado,
            this.colconcat_});
            this.gridView1.DetailHeight = 673;
            this.gridView1.GridControl = this.gridControlDetalleEstudiantes;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanging);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colid_estudiante
            // 
            this.colid_estudiante.Caption = "ID";
            this.colid_estudiante.FieldName = "id_estudiante";
            this.colid_estudiante.Name = "colid_estudiante";
            this.colid_estudiante.OptionsColumn.AllowEdit = false;
            this.colid_estudiante.Visible = true;
            this.colid_estudiante.VisibleIndex = 0;
            // 
            // colnombres
            // 
            this.colnombres.Caption = "Nombres";
            this.colnombres.FieldName = "nombres";
            this.colnombres.Name = "colnombres";
            this.colnombres.OptionsColumn.AllowEdit = false;
            this.colnombres.Visible = true;
            this.colnombres.VisibleIndex = 1;
            // 
            // colapellidos
            // 
            this.colapellidos.Caption = "Apellidos";
            this.colapellidos.FieldName = "apellidos";
            this.colapellidos.Name = "colapellidos";
            this.colapellidos.OptionsColumn.AllowEdit = false;
            this.colapellidos.Visible = true;
            this.colapellidos.VisibleIndex = 2;
            // 
            // colnumero_identidad
            // 
            this.colnumero_identidad.Caption = "Identidad";
            this.colnumero_identidad.FieldName = "numero_identidad";
            this.colnumero_identidad.Name = "colnumero_identidad";
            this.colnumero_identidad.OptionsColumn.AllowEdit = false;
            this.colnumero_identidad.Visible = true;
            this.colnumero_identidad.VisibleIndex = 3;
            // 
            // colSeleccionado
            // 
            this.colSeleccionado.Caption = "Seleccionar";
            this.colSeleccionado.FieldName = "Seleccionado";
            this.colSeleccionado.Name = "colSeleccionado";
            this.colSeleccionado.Visible = true;
            this.colSeleccionado.VisibleIndex = 4;
            // 
            // colconcat_
            // 
            this.colconcat_.FieldName = "concat_";
            this.colconcat_.Name = "colconcat_";
            this.colconcat_.OptionsColumn.AllowEdit = false;
            // 
            // cmdAplicar
            // 
            this.cmdAplicar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAplicar.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAplicar.Appearance.Options.UseFont = true;
            this.cmdAplicar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdAplicar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdAplicar.ImageOptions.SvgImage")));
            this.cmdAplicar.Location = new System.Drawing.Point(447, 20);
            this.cmdAplicar.Margin = new System.Windows.Forms.Padding(6);
            this.cmdAplicar.Name = "cmdAplicar";
            this.cmdAplicar.Size = new System.Drawing.Size(154, 43);
            this.cmdAplicar.TabIndex = 14;
            this.cmdAplicar.Text = "Aplicar";
            this.cmdAplicar.Click += new System.EventHandler(this.cmdAplicar_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(626, 20);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 43);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Cerrar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtParametroBusqueda
            // 
            this.txtParametroBusqueda.Location = new System.Drawing.Point(5, 109);
            this.txtParametroBusqueda.Margin = new System.Windows.Forms.Padding(6);
            this.txtParametroBusqueda.Name = "txtParametroBusqueda";
            this.txtParametroBusqueda.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParametroBusqueda.Properties.Appearance.Options.UseFont = true;
            this.txtParametroBusqueda.Size = new System.Drawing.Size(434, 24);
            this.txtParametroBusqueda.TabIndex = 12;
            this.txtParametroBusqueda.EditValueChanged += new System.EventHandler(this.txtParametroBusqueda_EditValueChanged);
            this.txtParametroBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtParametroBusqueda_KeyDown);
            // 
            // frmBuscarEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 483);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControlDetalleEstudiantes);
            this.Controls.Add(this.cmdAplicar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtParametroBusqueda);
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscarEstudiantes";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetalleEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstudiantes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParametroBusqueda.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControlDetalleEstudiantes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton cmdAplicar;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.TextEdit txtParametroBusqueda;
        private dsEstudiantes dsEstudiantes1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_estudiante;
        private DevExpress.XtraGrid.Columns.GridColumn colnombres;
        private DevExpress.XtraGrid.Columns.GridColumn colapellidos;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_identidad;
        private DevExpress.XtraGrid.Columns.GridColumn colSeleccionado;
        private DevExpress.XtraGrid.Columns.GridColumn colconcat_;
    }
}