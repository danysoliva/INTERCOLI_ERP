
namespace ERP_INTECOLI.Accesos.NivelAccesoSistema
{
    partial class NivelAccesoSistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NivelAccesoSistema));
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelControlComboSistemas = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEditSistemas = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControlDetalleAccesos = new DevExpress.XtraGrid.GridControl();
            this.gridViewDetalleAccesos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nivel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Asignado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.botonCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.BotonGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditSistemas.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetalleAccesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetalleAccesos)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelControlComboSistemas);
            this.panel2.Controls.Add(this.comboBoxEditSistemas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(23, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(437, 117);
            this.panel2.TabIndex = 2;
            // 
            // labelControlComboSistemas
            // 
            this.labelControlComboSistemas.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControlComboSistemas.Location = new System.Drawing.Point(3, 71);
            this.labelControlComboSistemas.Name = "labelControlComboSistemas";
            this.labelControlComboSistemas.Size = new System.Drawing.Size(63, 13);
            this.labelControlComboSistemas.TabIndex = 7;
            this.labelControlComboSistemas.Text = "Sistema";
            // 
            // comboBoxEditSistemas
            // 
            this.comboBoxEditSistemas.Location = new System.Drawing.Point(3, 90);
            this.comboBoxEditSistemas.Name = "comboBoxEditSistemas";
            this.comboBoxEditSistemas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditSistemas.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditSistemas.Size = new System.Drawing.Size(198, 20);
            this.comboBoxEditSistemas.TabIndex = 6;
            this.comboBoxEditSistemas.SelectedValueChanged += new System.EventHandler(this.comboBoxEditSistemas_SelectedValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControlDetalleAccesos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(23, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 131);
            this.panel1.TabIndex = 1;
            // 
            // gridControlDetalleAccesos
            // 
            this.gridControlDetalleAccesos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDetalleAccesos.Location = new System.Drawing.Point(0, 0);
            this.gridControlDetalleAccesos.MainView = this.gridViewDetalleAccesos;
            this.gridControlDetalleAccesos.Name = "gridControlDetalleAccesos";
            this.gridControlDetalleAccesos.Size = new System.Drawing.Size(437, 131);
            this.gridControlDetalleAccesos.TabIndex = 2;
            this.gridControlDetalleAccesos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDetalleAccesos});
            this.gridControlDetalleAccesos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridControlDetalleAccesos_MouseClick);
            // 
            // gridViewDetalleAccesos
            // 
            this.gridViewDetalleAccesos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.Nivel,
            this.Asignado});
            this.gridViewDetalleAccesos.GridControl = this.gridControlDetalleAccesos;
            this.gridViewDetalleAccesos.Name = "gridViewDetalleAccesos";
            this.gridViewDetalleAccesos.OptionsBehavior.Editable = false;
            this.gridViewDetalleAccesos.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gridViewDetalleAccesos.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem;
            this.gridViewDetalleAccesos.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewDetalleAccesos.OptionsView.ShowAutoFilterRow = true;
            this.gridViewDetalleAccesos.OptionsView.ShowGroupPanel = false;
            this.gridViewDetalleAccesos.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Indicator;
            this.gridViewDetalleAccesos.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewDetalleAccesos_RowCellClick);
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "IdAcceso";
            this.Id.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Id.ImageOptions.Image")));
            this.Id.MinWidth = 10;
            this.Id.Name = "Id";
            this.Id.Visible = true;
            this.Id.VisibleIndex = 0;
            this.Id.Width = 60;
            // 
            // Nivel
            // 
            this.Nivel.Caption = "Nivel";
            this.Nivel.FieldName = "NombreAcceso";
            this.Nivel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Nivel.ImageOptions.Image")));
            this.Nivel.Name = "Nivel";
            this.Nivel.Visible = true;
            this.Nivel.VisibleIndex = 1;
            this.Nivel.Width = 103;
            // 
            // Asignado
            // 
            this.Asignado.Caption = "Asignado";
            this.Asignado.FieldName = "Enable";
            this.Asignado.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Asignado.ImageOptions.Image")));
            this.Asignado.Name = "Asignado";
            this.Asignado.Visible = true;
            this.Asignado.VisibleIndex = 2;
            this.Asignado.Width = 109;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(483, 326);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.botonCancelar);
            this.panel3.Controls.Add(this.BotonGuardar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(23, 263);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(437, 40);
            this.panel3.TabIndex = 3;
            // 
            // botonCancelar
            // 
            this.botonCancelar.Appearance.BackColor = System.Drawing.Color.Red;
            this.botonCancelar.Appearance.Options.UseBackColor = true;
            this.botonCancelar.Location = new System.Drawing.Point(84, 17);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 1;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // BotonGuardar
            // 
            this.BotonGuardar.Location = new System.Drawing.Point(3, 17);
            this.BotonGuardar.Name = "BotonGuardar";
            this.BotonGuardar.Size = new System.Drawing.Size(75, 23);
            this.BotonGuardar.TabIndex = 0;
            this.BotonGuardar.Text = "Guardar";
            this.BotonGuardar.Click += new System.EventHandler(this.BotonGuardar_Click);
            // 
            // NivelAccesoSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 326);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NivelAccesoSistema";
            this.Text = "Nivel de Acceso por Sistema";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditSistemas.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetalleAccesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetalleAccesos)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl labelControlComboSistemas;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditSistemas;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControlDetalleAccesos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDetalleAccesos;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn Nivel;
        private DevExpress.XtraGrid.Columns.GridColumn Asignado;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton botonCancelar;
        private DevExpress.XtraEditors.SimpleButton BotonGuardar;
    }
}