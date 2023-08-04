
namespace ERP_INTECOLI.Administracion.Estudiantes
{
    partial class frmagregar_rtn
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtRTN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdEmpresa = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.dsEstudiantes1 = new ERP_INTECOLI.Administracion.Estudiantes.dsEstudiantes();
            this.detalleempresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colrtn_empresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colempresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_empresa = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstudiantes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleempresaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 37);
            this.label2.TabIndex = 33;
            this.label2.Text = "Empresa:";
            // 
            // txtRTN
            // 
            this.txtRTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRTN.Location = new System.Drawing.Point(211, 45);
            this.txtRTN.Margin = new System.Windows.Forms.Padding(6);
            this.txtRTN.Name = "txtRTN";
            this.txtRTN.Size = new System.Drawing.Size(410, 44);
            this.txtRTN.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 37);
            this.label1.TabIndex = 31;
            this.label1.Text = "RTN:";
            // 
            // grdEmpresa
            // 
            this.grdEmpresa.Location = new System.Drawing.Point(211, 129);
            this.grdEmpresa.Margin = new System.Windows.Forms.Padding(6);
            this.grdEmpresa.Name = "grdEmpresa";
            this.grdEmpresa.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grdEmpresa.Properties.Appearance.Options.UseFont = true;
            this.grdEmpresa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdEmpresa.Properties.DataSource = this.detalleempresaBindingSource;
            this.grdEmpresa.Properties.DisplayMember = "empresa";
            this.grdEmpresa.Properties.NullText = "";
            this.grdEmpresa.Properties.PopupView = this.gridLookUpEdit1View;
            this.grdEmpresa.Properties.ValueMember = "id_empresa";
            this.grdEmpresa.Size = new System.Drawing.Size(414, 52);
            this.grdEmpresa.TabIndex = 36;
            this.grdEmpresa.EditValueChanged += new System.EventHandler(this.grdEmpresa_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colrtn_empresa,
            this.colempresa,
            this.colid_empresa});
            this.gridLookUpEdit1View.DetailHeight = 673;
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
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
            this.cmdCancelar.Location = new System.Drawing.Point(362, 228);
            this.cmdCancelar.Margin = new System.Windows.Forms.Padding(6);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(222, 90);
            this.cmdCancelar.TabIndex = 35;
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
            this.cmdGuardar.Location = new System.Drawing.Point(113, 228);
            this.cmdGuardar.Margin = new System.Windows.Forms.Padding(6);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(206, 90);
            this.cmdGuardar.TabIndex = 34;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdGuardar.UseVisualStyleBackColor = false;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // dsEstudiantes1
            // 
            this.dsEstudiantes1.DataSetName = "dsEstudiantes";
            this.dsEstudiantes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detalleempresaBindingSource
            // 
            this.detalleempresaBindingSource.DataMember = "detalle_empresa";
            this.detalleempresaBindingSource.DataSource = this.dsEstudiantes1;
            // 
            // colrtn_empresa
            // 
            this.colrtn_empresa.FieldName = "rtn_empresa";
            this.colrtn_empresa.Name = "colrtn_empresa";
            this.colrtn_empresa.OptionsColumn.AllowEdit = false;
            // 
            // colempresa
            // 
            this.colempresa.Caption = "Empresa";
            this.colempresa.FieldName = "empresa";
            this.colempresa.Name = "colempresa";
            this.colempresa.OptionsColumn.AllowEdit = false;
            this.colempresa.Visible = true;
            this.colempresa.VisibleIndex = 0;
            // 
            // colid_empresa
            // 
            this.colid_empresa.FieldName = "id_empresa";
            this.colid_empresa.Name = "colid_empresa";
            this.colid_empresa.OptionsColumn.AllowEdit = false;
            // 
            // frmagregar_rtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 344);
            this.Controls.Add(this.grdEmpresa);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRTN);
            this.Controls.Add(this.label1);
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.Name = "frmagregar_rtn";
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstudiantes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleempresaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GridLookUpEdit grdEmpresa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtRTN;
        private System.Windows.Forms.Label label1;
        private dsEstudiantes dsEstudiantes1;
        private System.Windows.Forms.BindingSource detalleempresaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colrtn_empresa;
        private DevExpress.XtraGrid.Columns.GridColumn colempresa;
        private DevExpress.XtraGrid.Columns.GridColumn colid_empresa;
    }
}