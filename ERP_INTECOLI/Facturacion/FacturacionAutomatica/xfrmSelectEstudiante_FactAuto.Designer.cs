
namespace JAGUAR_APP.Facturacion.Configuraciones
{
    partial class xfrmSelectEstudiante_FactAuto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmSelectEstudiante_FactAuto));
            this.gcCliente = new DevExpress.XtraGrid.GridControl();
            this.dsConfigFacturaAutomatica1 = new ERP_INTECOLI.Facturacion.FacturacionAutomatica.dsConfigFacturaAutomatica();
            this.gvCliente = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_estudiante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcurso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_punto_venta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsucursal_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_detalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_pt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemNameFacturacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_curso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseleccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sluePDV = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cmdNew = new DevExpress.XtraEditors.SimpleButton();
            this.checkSeleccionarTodos = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gcCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConfigFacturaAutomatica1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sluePDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // gcCliente
            // 
            this.gcCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcCliente.DataMember = "busqueda_estudiante_cursos";
            this.gcCliente.DataSource = this.dsConfigFacturaAutomatica1;
            this.gcCliente.Location = new System.Drawing.Point(0, 76);
            this.gcCliente.MainView = this.gvCliente;
            this.gcCliente.Name = "gcCliente";
            this.gcCliente.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.sluePDV});
            this.gcCliente.Size = new System.Drawing.Size(955, 369);
            this.gcCliente.TabIndex = 0;
            this.gcCliente.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCliente});
            // 
            // dsConfigFacturaAutomatica1
            // 
            this.dsConfigFacturaAutomatica1.DataSetName = "dsConfigFacturaAutomatica";
            this.dsConfigFacturaAutomatica1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvCliente
            // 
            this.gvCliente.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvCliente.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvCliente.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvCliente.Appearance.Row.Options.UseFont = true;
            this.gvCliente.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_estudiante,
            this.colItemCode,
            this.colnombre,
            this.colcurso,
            this.colid_punto_venta,
            this.colsucursal_name,
            this.colprecio,
            this.colid_detalle,
            this.colid_pt,
            this.colItemNameFacturacion,
            this.colid_curso,
            this.colseleccion});
            this.gvCliente.GridControl = this.gcCliente;
            this.gvCliente.Name = "gvCliente";
            this.gvCliente.OptionsView.ShowAutoFilterRow = true;
            this.gvCliente.OptionsView.ShowGroupPanel = false;
            this.gvCliente.ShownEditor += new System.EventHandler(this.gvCliente_ShownEditor);
            this.gvCliente.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvCliente_CellValueChanged);
            // 
            // colid_estudiante
            // 
            this.colid_estudiante.FieldName = "id_estudiante";
            this.colid_estudiante.Name = "colid_estudiante";
            // 
            // colItemCode
            // 
            this.colItemCode.FieldName = "Item Code";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.OptionsColumn.ReadOnly = true;
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 0;
            this.colItemCode.Width = 87;
            // 
            // colnombre
            // 
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.ReadOnly = true;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            this.colnombre.Width = 245;
            // 
            // colcurso
            // 
            this.colcurso.FieldName = "curso";
            this.colcurso.Name = "colcurso";
            this.colcurso.OptionsColumn.ReadOnly = true;
            this.colcurso.Visible = true;
            this.colcurso.VisibleIndex = 2;
            this.colcurso.Width = 171;
            // 
            // colid_punto_venta
            // 
            this.colid_punto_venta.FieldName = "id_punto_venta";
            this.colid_punto_venta.Name = "colid_punto_venta";
            // 
            // colsucursal_name
            // 
            this.colsucursal_name.FieldName = "sucursal_name";
            this.colsucursal_name.Name = "colsucursal_name";
            this.colsucursal_name.OptionsColumn.ReadOnly = true;
            this.colsucursal_name.Visible = true;
            this.colsucursal_name.VisibleIndex = 3;
            this.colsucursal_name.Width = 128;
            // 
            // colprecio
            // 
            this.colprecio.Caption = "Valor Curso";
            this.colprecio.DisplayFormat.FormatString = "n2";
            this.colprecio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colprecio.FieldName = "precio";
            this.colprecio.Name = "colprecio";
            this.colprecio.Visible = true;
            this.colprecio.VisibleIndex = 4;
            this.colprecio.Width = 167;
            // 
            // colid_detalle
            // 
            this.colid_detalle.FieldName = "id_detalle";
            this.colid_detalle.Name = "colid_detalle";
            // 
            // colid_pt
            // 
            this.colid_pt.FieldName = "id_pt";
            this.colid_pt.Name = "colid_pt";
            // 
            // colItemNameFacturacion
            // 
            this.colItemNameFacturacion.FieldName = "ItemNameFacturacion";
            this.colItemNameFacturacion.Name = "colItemNameFacturacion";
            this.colItemNameFacturacion.OptionsColumn.ReadOnly = true;
            this.colItemNameFacturacion.Visible = true;
            this.colItemNameFacturacion.VisibleIndex = 5;
            this.colItemNameFacturacion.Width = 132;
            // 
            // colid_curso
            // 
            this.colid_curso.FieldName = "id_curso";
            this.colid_curso.Name = "colid_curso";
            // 
            // colseleccion
            // 
            this.colseleccion.FieldName = "seleccion";
            this.colseleccion.Name = "colseleccion";
            this.colseleccion.Visible = true;
            this.colseleccion.VisibleIndex = 6;
            // 
            // sluePDV
            // 
            this.sluePDV.AutoHeight = false;
            this.sluePDV.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sluePDV.DisplayMember = "pdv";
            this.sluePDV.KeyMember = "id";
            this.sluePDV.Name = "sluePDV";
            this.sluePDV.NullText = "Seleccione un PDV";
            this.sluePDV.PopupView = this.repositoryItemSearchLookUpEdit1View;
            this.sluePDV.ValueMember = "id";
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Código";
            this.gridColumn5.FieldName = "codigo";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Punto de Venta";
            this.gridColumn6.FieldName = "nombre_local";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
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
            this.simpleButton1.Location = new System.Drawing.Point(842, -3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(113, 45);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "Cerrar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cmdNew
            // 
            this.cmdNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdNew.Appearance.BackColor = System.Drawing.Color.PowderBlue;
            this.cmdNew.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNew.Appearance.Options.UseBackColor = true;
            this.cmdNew.Appearance.Options.UseFont = true;
            this.cmdNew.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cmdNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdNew.ImageOptions.SvgImage")));
            this.cmdNew.Location = new System.Drawing.Point(712, -3);
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(124, 45);
            this.cmdNew.TabIndex = 7;
            this.cmdNew.Text = "Seleccionar";
            this.cmdNew.Click += new System.EventHandler(this.cmdNew_Click);
            // 
            // checkSeleccionarTodos
            // 
            this.checkSeleccionarTodos.AutoSize = true;
            this.checkSeleccionarTodos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSeleccionarTodos.Location = new System.Drawing.Point(835, 51);
            this.checkSeleccionarTodos.Name = "checkSeleccionarTodos";
            this.checkSeleccionarTodos.Size = new System.Drawing.Size(120, 19);
            this.checkSeleccionarTodos.TabIndex = 9;
            this.checkSeleccionarTodos.Text = "Seleccionar Todos";
            this.checkSeleccionarTodos.UseVisualStyleBackColor = true;
            this.checkSeleccionarTodos.CheckedChanged += new System.EventHandler(this.checkSeleccionarTodos_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Seleccione los estudiantes para configuracion Automatica";
            // 
            // xfrmSelectEstudiante_FactAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 445);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkSeleccionarTodos);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.cmdNew);
            this.Controls.Add(this.gcCliente);
            this.Name = "xfrmSelectEstudiante_FactAuto";
            this.Text = "Seleccionar Estudiante";
            ((System.ComponentModel.ISupportInitialize)(this.gcCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConfigFacturaAutomatica1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sluePDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcCliente;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCliente;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton cmdNew;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit sluePDV;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private ERP_INTECOLI.Facturacion.FacturacionAutomatica.dsConfigFacturaAutomatica dsConfigFacturaAutomatica1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_estudiante;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colcurso;
        private DevExpress.XtraGrid.Columns.GridColumn colid_punto_venta;
        private DevExpress.XtraGrid.Columns.GridColumn colsucursal_name;
        private DevExpress.XtraGrid.Columns.GridColumn colprecio;
        private DevExpress.XtraGrid.Columns.GridColumn colid_detalle;
        private DevExpress.XtraGrid.Columns.GridColumn colid_pt;
        private DevExpress.XtraGrid.Columns.GridColumn colItemNameFacturacion;
        private DevExpress.XtraGrid.Columns.GridColumn colid_curso;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccion;
        private System.Windows.Forms.CheckBox checkSeleccionarTodos;
        private System.Windows.Forms.Label label1;
    }
}