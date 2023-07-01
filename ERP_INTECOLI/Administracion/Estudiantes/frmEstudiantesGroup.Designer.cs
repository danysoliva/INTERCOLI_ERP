
namespace ERP_INTECOLI.Administracion.Estudiantes
{
    partial class frmEstudiantesGroup
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("estudiantes", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("id_estudiante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("numero_identidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("nombres");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("apellidos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("direccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("fecha_nacimiento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("fecha_ingreso", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("habilitado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("sexo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("correo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("editar");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("concatenacion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn13 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("antiguiedad", 0);
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            this.cmdNuevo = new System.Windows.Forms.Button();
            this.cmbBuscar = new System.Windows.Forms.Button();
            this.txtParametro = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.tsVerTodos = new DevExpress.XtraEditors.ToggleSwitch();
            this.grDetalle = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.dsEstudiantes1 = new ERP_INTECOLI.Administracion.Estudiantes.dsEstudiantes();
            ((System.ComponentModel.ISupportInitialize)(this.txtParametro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsVerTodos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstudiantes1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.BackColor = System.Drawing.Color.PaleGreen;
            this.cmdNuevo.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.cmdNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdNuevo.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdNuevo.Location = new System.Drawing.Point(572, 22);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(169, 43);
            this.cmdNuevo.TabIndex = 9;
            this.cmdNuevo.Text = "Agregar Estudiante";
            this.cmdNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdNuevo.UseVisualStyleBackColor = false;
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBuscar.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cmbBuscar.Image = global::ERP_INTECOLI.Properties.Resources.anadir;
            this.cmbBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmbBuscar.Location = new System.Drawing.Point(467, 22);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(99, 43);
            this.cmbBuscar.TabIndex = 8;
            this.cmbBuscar.Text = "Buscar";
            this.cmbBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmbBuscar.UseVisualStyleBackColor = false;
            this.cmbBuscar.Click += new System.EventHandler(this.cmbBuscar_Click);
            // 
            // txtParametro
            // 
            this.txtParametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParametro.Location = new System.Drawing.Point(191, 34);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(270, 26);
            this.txtParametro.TabIndex = 7;
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel1.Location = new System.Drawing.Point(50, 38);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(158, 18);
            this.ultraLabel1.TabIndex = 6;
            this.ultraLabel1.Text = "Buscar por Nombre:";
            // 
            // tsVerTodos
            // 
            this.tsVerTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tsVerTodos.EditValue = true;
            this.tsVerTodos.Location = new System.Drawing.Point(876, 35);
            this.tsVerTodos.Name = "tsVerTodos";
            this.tsVerTodos.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.tsVerTodos.Properties.Appearance.Options.UseFont = true;
            this.tsVerTodos.Properties.OffText = "Ver Todos";
            this.tsVerTodos.Properties.OnText = "Habilitados";
            this.tsVerTodos.Size = new System.Drawing.Size(168, 24);
            this.tsVerTodos.TabIndex = 10;
            this.tsVerTodos.Toggled += new System.EventHandler(this.tsVerTodos_Toggled);
            // 
            // grDetalle
            // 
            this.grDetalle.DataMember = "estudiantes";
            this.grDetalle.DataSource = this.dsEstudiantes1;
            appearance1.BackColor = System.Drawing.SystemColors.Window;
            appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.grDetalle.DisplayLayout.Appearance = appearance1;
            this.grDetalle.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn1.Header.Caption = "Id";
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Width = 60;
            ultraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Width = 116;
            ultraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.Width = 222;
            ultraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridColumn4.Width = 173;
            ultraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn5.Header.VisiblePosition = 4;
            ultraGridColumn5.Width = 88;
            ultraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn6.Header.VisiblePosition = 5;
            ultraGridColumn6.Width = 110;
            ultraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn7.Header.VisiblePosition = 6;
            ultraGridColumn7.Width = 118;
            ultraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn8.Header.VisiblePosition = 7;
            ultraGridColumn8.Width = 69;
            ultraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn9.Header.VisiblePosition = 8;
            ultraGridColumn9.Width = 59;
            ultraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn10.Header.VisiblePosition = 9;
            ultraGridColumn10.Width = 77;
            appearance2.ImageHAlign = Infragistics.Win.HAlign.Center;
            appearance2.ImageVAlign = Infragistics.Win.VAlign.Middle;
            ultraGridColumn11.CellAppearance = appearance2;
            appearance3.ImageHAlign = Infragistics.Win.HAlign.Center;
            appearance3.ImageVAlign = Infragistics.Win.VAlign.Middle;
            ultraGridColumn11.CellButtonAppearance = appearance3;
            ultraGridColumn11.Header.VisiblePosition = 10;
            ultraGridColumn11.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
            ultraGridColumn11.Width = 84;
            ultraGridColumn12.Header.VisiblePosition = 11;
            ultraGridColumn12.Hidden = true;
            ultraGridColumn12.Width = 102;
            appearance4.ImageHAlign = Infragistics.Win.HAlign.Center;
            appearance4.ImageVAlign = Infragistics.Win.VAlign.Middle;
            ultraGridColumn13.CellAppearance = appearance4;
            appearance5.ImageHAlign = Infragistics.Win.HAlign.Center;
            appearance5.ImageVAlign = Infragistics.Win.VAlign.Middle;
            ultraGridColumn13.CellButtonAppearance = appearance5;
            ultraGridColumn13.Header.Caption = "Antigüedad";
            ultraGridColumn13.Header.VisiblePosition = 12;
            ultraGridColumn13.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
            ultraGridColumn13.Width = 95;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5,
            ultraGridColumn6,
            ultraGridColumn7,
            ultraGridColumn8,
            ultraGridColumn9,
            ultraGridColumn10,
            ultraGridColumn11,
            ultraGridColumn12,
            ultraGridColumn13});
            ultraGridBand1.Header.FixOnRight = Infragistics.Win.DefaultableBoolean.True;
            this.grDetalle.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.grDetalle.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.grDetalle.DisplayLayout.BorderStyleCaption = Infragistics.Win.UIElementBorderStyle.Solid;
            this.grDetalle.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance6.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance6.BorderColor = System.Drawing.SystemColors.Window;
            this.grDetalle.DisplayLayout.GroupByBox.Appearance = appearance6;
            appearance7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.grDetalle.DisplayLayout.GroupByBox.BandLabelAppearance = appearance7;
            this.grDetalle.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Raised;
            appearance8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance8.BackColor2 = System.Drawing.SystemColors.Control;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.HorizontalBump;
            appearance8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.grDetalle.DisplayLayout.GroupByBox.PromptAppearance = appearance8;
            this.grDetalle.DisplayLayout.LoadStyle = Infragistics.Win.UltraWinGrid.LoadStyle.LoadOnDemand;
            this.grDetalle.DisplayLayout.MaxColScrollRegions = 1;
            this.grDetalle.DisplayLayout.MaxRowScrollRegions = 1;
            appearance9.BackColor = System.Drawing.SystemColors.Window;
            appearance9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grDetalle.DisplayLayout.Override.ActiveCellAppearance = appearance9;
            appearance10.BackColor = System.Drawing.SystemColors.Highlight;
            appearance10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.grDetalle.DisplayLayout.Override.ActiveRowAppearance = appearance10;
            this.grDetalle.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.grDetalle.DisplayLayout.Override.BorderStyleFilterRow = Infragistics.Win.UIElementBorderStyle.Dashed;
            this.grDetalle.DisplayLayout.Override.BorderStyleHeader = Infragistics.Win.UIElementBorderStyle.Dashed;
            this.grDetalle.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance11.BackColor = System.Drawing.SystemColors.Window;
            this.grDetalle.DisplayLayout.Override.CardAreaAppearance = appearance11;
            appearance12.BorderColor = System.Drawing.Color.Silver;
            appearance12.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.grDetalle.DisplayLayout.Override.CellAppearance = appearance12;
            this.grDetalle.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.grDetalle.DisplayLayout.Override.CellPadding = 0;
            appearance13.BackHatchStyle = Infragistics.Win.BackHatchStyle.LargeGrid;
            this.grDetalle.DisplayLayout.Override.FixedHeaderAppearance = appearance13;
            appearance14.BackColor = System.Drawing.SystemColors.Control;
            appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance14.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance14.BorderColor = System.Drawing.SystemColors.Window;
            this.grDetalle.DisplayLayout.Override.GroupByRowAppearance = appearance14;
            appearance15.TextHAlignAsString = "Left";
            this.grDetalle.DisplayLayout.Override.HeaderAppearance = appearance15;
            this.grDetalle.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.grDetalle.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard;
            appearance16.BackColor = System.Drawing.SystemColors.Window;
            appearance16.BorderColor = System.Drawing.Color.Silver;
            this.grDetalle.DisplayLayout.Override.RowAppearance = appearance16;
            this.grDetalle.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance17.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grDetalle.DisplayLayout.Override.TemplateAddRowAppearance = appearance17;
            this.grDetalle.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.grDetalle.DisplayLayout.UseFixedHeaders = true;
            this.grDetalle.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand;
            this.grDetalle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grDetalle.Location = new System.Drawing.Point(0, 91);
            this.grDetalle.Name = "grDetalle";
            this.grDetalle.Size = new System.Drawing.Size(1273, 683);
            this.grDetalle.TabIndex = 11;
            // 
            // dsEstudiantes1
            // 
            this.dsEstudiantes1.DataSetName = "dsEstudiantes";
            this.dsEstudiantes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmEstudiantesGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 774);
            this.Controls.Add(this.grDetalle);
            this.Controls.Add(this.tsVerTodos);
            this.Controls.Add(this.cmdNuevo);
            this.Controls.Add(this.cmbBuscar);
            this.Controls.Add(this.txtParametro);
            this.Controls.Add(this.ultraLabel1);
            this.Name = "frmEstudiantesGroup";
            this.Text = "Estudiantes";
            ((System.ComponentModel.ISupportInitialize)(this.txtParametro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsVerTodos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstudiantes1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdNuevo;
        private System.Windows.Forms.Button cmbBuscar;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtParametro;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private DevExpress.XtraEditors.ToggleSwitch tsVerTodos;
        private Infragistics.Win.UltraWinGrid.UltraGrid grDetalle;
        private dsEstudiantes dsEstudiantes1;
    }
}