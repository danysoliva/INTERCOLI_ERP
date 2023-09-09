
namespace ERP_INTECOLI.Administracion.Matricula
{
    partial class frmConsultarMatriculados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarMatriculados));
            this.dtHasta = new System.Windows.Forms.DateTimePicker();
            this.dtDesde = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCargar = new DevExpress.XtraEditors.SimpleButton();
            this.chOcultarNulas = new System.Windows.Forms.CheckBox();
            this.grdMatriculado = new DevExpress.XtraGrid.GridControl();
            this.dsMatriculado1 = new ERP_INTECOLI.Administracion.Matricula.dsMatriculado();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_matricula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_posteo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coleditar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_detalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprofe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnivel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tsSoloHabilitadas = new DevExpress.XtraEditors.ToggleSwitch();
            this.cmdCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdMatriculado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMatriculado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsSoloHabilitadas.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dtHasta
            // 
            this.dtHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dtHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtHasta.Location = new System.Drawing.Point(93, 37);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Size = new System.Drawing.Size(97, 24);
            this.dtHasta.TabIndex = 8;
            // 
            // dtDesde
            // 
            this.dtDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dtDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDesde.Location = new System.Drawing.Point(93, 9);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Size = new System.Drawing.Size(97, 24);
            this.dtDesde.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Desde:";
            // 
            // btnCargar
            // 
            this.btnCargar.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCargar.Appearance.Options.UseBackColor = true;
            this.btnCargar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCargar.ImageOptions.SvgImage")));
            this.btnCargar.Location = new System.Drawing.Point(206, 18);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(106, 43);
            this.btnCargar.TabIndex = 10;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // chOcultarNulas
            // 
            this.chOcultarNulas.AutoSize = true;
            this.chOcultarNulas.Checked = true;
            this.chOcultarNulas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chOcultarNulas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.chOcultarNulas.Location = new System.Drawing.Point(381, 11);
            this.chOcultarNulas.Name = "chOcultarNulas";
            this.chOcultarNulas.Size = new System.Drawing.Size(117, 22);
            this.chOcultarNulas.TabIndex = 11;
            this.chOcultarNulas.Text = "Ocultar Nulas";
            this.chOcultarNulas.UseVisualStyleBackColor = true;
            // 
            // grdMatriculado
            // 
            this.grdMatriculado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdMatriculado.DataMember = "ListaMatriculados";
            this.grdMatriculado.DataSource = this.dsMatriculado1;
            this.grdMatriculado.Location = new System.Drawing.Point(3, 75);
            this.grdMatriculado.MainView = this.gridView1;
            this.grdMatriculado.Name = "grdMatriculado";
            this.grdMatriculado.Size = new System.Drawing.Size(757, 394);
            this.grdMatriculado.TabIndex = 12;
            this.grdMatriculado.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsMatriculado1
            // 
            this.dsMatriculado1.DataSetName = "dsMatriculado";
            this.dsMatriculado1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_matricula,
            this.colnombre,
            this.colnula,
            this.colvalor,
            this.colfecha_posteo,
            this.coleditar,
            this.colid_detalle,
            this.colprofe,
            this.colnivel});
            this.gridView1.GridControl = this.grdMatriculado;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid_matricula
            // 
            this.colid_matricula.FieldName = "id_matricula";
            this.colid_matricula.Name = "colid_matricula";
            this.colid_matricula.OptionsColumn.ReadOnly = true;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.ReadOnly = true;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 0;
            // 
            // colnula
            // 
            this.colnula.Caption = "Anulada";
            this.colnula.FieldName = "nula";
            this.colnula.Name = "colnula";
            this.colnula.OptionsColumn.ReadOnly = true;
            this.colnula.Visible = true;
            this.colnula.VisibleIndex = 1;
            // 
            // colvalor
            // 
            this.colvalor.Caption = "Valor";
            this.colvalor.FieldName = "valor";
            this.colvalor.Name = "colvalor";
            this.colvalor.OptionsColumn.ReadOnly = true;
            this.colvalor.Visible = true;
            this.colvalor.VisibleIndex = 2;
            // 
            // colfecha_posteo
            // 
            this.colfecha_posteo.Caption = "Fecha";
            this.colfecha_posteo.FieldName = "fecha_posteo";
            this.colfecha_posteo.Name = "colfecha_posteo";
            this.colfecha_posteo.OptionsColumn.ReadOnly = true;
            this.colfecha_posteo.Visible = true;
            this.colfecha_posteo.VisibleIndex = 3;
            // 
            // coleditar
            // 
            this.coleditar.FieldName = "editar";
            this.coleditar.Name = "coleditar";
            this.coleditar.OptionsColumn.ReadOnly = true;
            // 
            // colid_detalle
            // 
            this.colid_detalle.FieldName = "id_detalle";
            this.colid_detalle.Name = "colid_detalle";
            this.colid_detalle.OptionsColumn.ReadOnly = true;
            // 
            // colprofe
            // 
            this.colprofe.Caption = "Profesor";
            this.colprofe.FieldName = "profe";
            this.colprofe.Name = "colprofe";
            this.colprofe.OptionsColumn.ReadOnly = true;
            this.colprofe.Visible = true;
            this.colprofe.VisibleIndex = 4;
            // 
            // colnivel
            // 
            this.colnivel.Caption = "Nivel";
            this.colnivel.FieldName = "nivel";
            this.colnivel.Name = "colnivel";
            this.colnivel.OptionsColumn.ReadOnly = true;
            this.colnivel.Visible = true;
            this.colnivel.VisibleIndex = 5;
            // 
            // tsSoloHabilitadas
            // 
            this.tsSoloHabilitadas.EditValue = true;
            this.tsSoloHabilitadas.Location = new System.Drawing.Point(381, 37);
            this.tsSoloHabilitadas.Name = "tsSoloHabilitadas";
            this.tsSoloHabilitadas.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.tsSoloHabilitadas.Properties.Appearance.Options.UseFont = true;
            this.tsSoloHabilitadas.Properties.OffText = "Todas";
            this.tsSoloHabilitadas.Properties.OnText = "Solo Habilitados";
            this.tsSoloHabilitadas.Size = new System.Drawing.Size(177, 22);
            this.tsSoloHabilitadas.TabIndex = 13;
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
            this.cmdCancelar.Location = new System.Drawing.Point(639, 18);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(110, 43);
            this.cmdCancelar.TabIndex = 46;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdCancelar.UseVisualStyleBackColor = false;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // frmConsultarMatriculados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 472);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.tsSoloHabilitadas);
            this.Controls.Add(this.grdMatriculado);
            this.Controls.Add(this.chOcultarNulas);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.dtHasta);
            this.Controls.Add(this.dtDesde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.IconOptions.ShowIcon = false;
            this.Name = "frmConsultarMatriculados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grdMatriculado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMatriculado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsSoloHabilitadas.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtHasta;
        private System.Windows.Forms.DateTimePicker dtDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnCargar;
        private System.Windows.Forms.CheckBox chOcultarNulas;
        private DevExpress.XtraGrid.GridControl grdMatriculado;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsMatriculado dsMatriculado1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_matricula;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colnula;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_posteo;
        private DevExpress.XtraGrid.Columns.GridColumn coleditar;
        private DevExpress.XtraGrid.Columns.GridColumn colid_detalle;
        private DevExpress.XtraGrid.Columns.GridColumn colprofe;
        private DevExpress.XtraGrid.Columns.GridColumn colnivel;
        private DevExpress.XtraEditors.ToggleSwitch tsSoloHabilitadas;
        private System.Windows.Forms.Button cmdCancelar;
    }
}