
namespace ERP_INTECOLI.Administracion.Movimientos
{
    partial class frmMovimientosSaldos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovimientosSaldos));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdTodos = new System.Windows.Forms.RadioButton();
            this.rdSoloHabilitados = new System.Windows.Forms.RadioButton();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.cmdF2 = new DevExpress.XtraEditors.SimpleButton();
            this.cmbCargarDatos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtFechaDesde = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(3, 136);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1116, 436);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.cmbCargarDatos);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.dtFechaHasta);
            this.panelControl1.Controls.Add(this.dtFechaDesde);
            this.panelControl1.Controls.Add(this.cmdF2);
            this.panelControl1.Controls.Add(this.textEdit1);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.cmdCancelar);
            this.panelControl1.Controls.Add(this.groupBox2);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Location = new System.Drawing.Point(3, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1116, 127);
            this.panelControl1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(436, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Movimientos de Saldos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdTodos);
            this.groupBox2.Controls.Add(this.rdSoloHabilitados);
            this.groupBox2.Location = new System.Drawing.Point(831, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 54);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones de Visualización";
            // 
            // rdTodos
            // 
            this.rdTodos.AutoSize = true;
            this.rdTodos.Location = new System.Drawing.Point(6, 30);
            this.rdTodos.Name = "rdTodos";
            this.rdTodos.Size = new System.Drawing.Size(54, 17);
            this.rdTodos.TabIndex = 1;
            this.rdTodos.Text = "Todos";
            this.rdTodos.UseVisualStyleBackColor = true;
            // 
            // rdSoloHabilitados
            // 
            this.rdSoloHabilitados.AutoSize = true;
            this.rdSoloHabilitados.Checked = true;
            this.rdSoloHabilitados.Location = new System.Drawing.Point(6, 14);
            this.rdSoloHabilitados.Name = "rdSoloHabilitados";
            this.rdSoloHabilitados.Size = new System.Drawing.Size(100, 17);
            this.rdSoloHabilitados.TabIndex = 0;
            this.rdSoloHabilitados.TabStop = true;
            this.rdSoloHabilitados.Text = "Solo Habilitados";
            this.rdSoloHabilitados.UseVisualStyleBackColor = true;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancelar.BackColor = System.Drawing.Color.LightSalmon;
            this.cmdCancelar.FlatAppearance.BorderColor = System.Drawing.Color.LightSalmon;
            this.cmdCancelar.FlatAppearance.BorderSize = 2;
            this.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Image = global::ERP_INTECOLI.Properties.Resources.cerrar;
            this.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCancelar.Location = new System.Drawing.Point(999, 9);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(106, 49);
            this.cmdCancelar.TabIndex = 45;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdCancelar.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "Estudiante";
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "F2 Buscar";
            this.textEdit1.Enabled = false;
            this.textEdit1.Location = new System.Drawing.Point(101, 84);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Size = new System.Drawing.Size(248, 26);
            this.textEdit1.TabIndex = 47;
            // 
            // cmdF2
            // 
            this.cmdF2.Appearance.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmdF2.Appearance.ForeColor = System.Drawing.Color.White;
            this.cmdF2.Appearance.Options.UseBackColor = true;
            this.cmdF2.Appearance.Options.UseForeColor = true;
            this.cmdF2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.cmdF2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdF2.ImageOptions.Image")));
            this.cmdF2.Location = new System.Drawing.Point(355, 79);
            this.cmdF2.Name = "cmdF2";
            this.cmdF2.Size = new System.Drawing.Size(45, 39);
            this.cmdF2.TabIndex = 48;
            // 
            // cmbCargarDatos
            // 
            this.cmbCargarDatos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbCargarDatos.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbCargarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCargarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbCargarDatos.Image = ((System.Drawing.Image)(resources.GetObject("cmbCargarDatos.Image")));
            this.cmbCargarDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmbCargarDatos.Location = new System.Drawing.Point(661, 64);
            this.cmbCargarDatos.Name = "cmbCargarDatos";
            this.cmbCargarDatos.Size = new System.Drawing.Size(144, 54);
            this.cmbCargarDatos.TabIndex = 53;
            this.cmbCargarDatos.Text = "Cargar Datos";
            this.cmbCargarDatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmbCargarDatos.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(426, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Fecha Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(422, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Fecha Desde:";
            // 
            // dtFechaHasta
            // 
            this.dtFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaHasta.Location = new System.Drawing.Point(537, 93);
            this.dtFechaHasta.Name = "dtFechaHasta";
            this.dtFechaHasta.Size = new System.Drawing.Size(104, 26);
            this.dtFechaHasta.TabIndex = 50;
            // 
            // dtFechaDesde
            // 
            this.dtFechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaDesde.Location = new System.Drawing.Point(537, 64);
            this.dtFechaDesde.Name = "dtFechaDesde";
            this.dtFechaDesde.Size = new System.Drawing.Size(104, 26);
            this.dtFechaDesde.TabIndex = 49;
            // 
            // frmMovimientosSaldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 576);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmMovimientosSaldos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdTodos;
        private System.Windows.Forms.RadioButton rdSoloHabilitados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmbCargarDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFechaHasta;
        private System.Windows.Forms.DateTimePicker dtFechaDesde;
        private DevExpress.XtraEditors.SimpleButton cmdF2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
    }
}