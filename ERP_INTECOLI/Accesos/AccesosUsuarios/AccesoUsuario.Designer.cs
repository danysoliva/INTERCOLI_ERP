
namespace ERP_INTECOLI.Accesos.AccesosUsuarios
{
    partial class AccesoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccesoUsuario));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControlDetalleSistemas = new DevExpress.XtraGrid.GridControl();
            this.gridViewDetalleSistemas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nivel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdEditarUsuario = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.comboUsuarios = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.usuarioColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nombreColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdNuevoUser = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gridControlAccesos = new DevExpress.XtraGrid.GridControl();
            this.gridViewAccesos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetalleSistemas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetalleSistemas)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboUsuarios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAccesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAccesos)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 322F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(812, 493);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControlDetalleSistemas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(23, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 298);
            this.panel1.TabIndex = 1;
            // 
            // gridControlDetalleSistemas
            // 
            this.gridControlDetalleSistemas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDetalleSistemas.Location = new System.Drawing.Point(0, 0);
            this.gridControlDetalleSistemas.MainView = this.gridViewDetalleSistemas;
            this.gridControlDetalleSistemas.Name = "gridControlDetalleSistemas";
            this.gridControlDetalleSistemas.Size = new System.Drawing.Size(444, 298);
            this.gridControlDetalleSistemas.TabIndex = 2;
            this.gridControlDetalleSistemas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDetalleSistemas});
            // 
            // gridViewDetalleSistemas
            // 
            this.gridViewDetalleSistemas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.Nivel,
            this.Codigo});
            this.gridViewDetalleSistemas.GridControl = this.gridControlDetalleSistemas;
            this.gridViewDetalleSistemas.Name = "gridViewDetalleSistemas";
            this.gridViewDetalleSistemas.OptionsBehavior.Editable = false;
            this.gridViewDetalleSistemas.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gridViewDetalleSistemas.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem;
            this.gridViewDetalleSistemas.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewDetalleSistemas.OptionsView.ShowAutoFilterRow = true;
            this.gridViewDetalleSistemas.OptionsView.ShowGroupPanel = false;
            this.gridViewDetalleSistemas.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Indicator;
            this.gridViewDetalleSistemas.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewDetalleSistemas_FocusedRowChanged);
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Id.ImageOptions.Image")));
            this.Id.MinWidth = 10;
            this.Id.Name = "Id";
            this.Id.OptionsColumn.AllowEdit = false;
            this.Id.OptionsColumn.AllowFocus = false;
            this.Id.Visible = true;
            this.Id.VisibleIndex = 0;
            this.Id.Width = 60;
            // 
            // Nivel
            // 
            this.Nivel.Caption = "Sistema";
            this.Nivel.FieldName = "Nombre";
            this.Nivel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Nivel.ImageOptions.Image")));
            this.Nivel.Name = "Nivel";
            this.Nivel.OptionsColumn.AllowEdit = false;
            this.Nivel.OptionsColumn.AllowFocus = false;
            this.Nivel.Visible = true;
            this.Nivel.VisibleIndex = 1;
            this.Nivel.Width = 103;
            // 
            // Codigo
            // 
            this.Codigo.Caption = "Codigo";
            this.Codigo.FieldName = "Codigo";
            this.Codigo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Codigo.ImageOptions.Image")));
            this.Codigo.Name = "Codigo";
            this.Codigo.OptionsColumn.AllowEdit = false;
            this.Codigo.OptionsColumn.AllowFocus = false;
            this.Codigo.Visible = true;
            this.Codigo.VisibleIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmdEditarUsuario);
            this.panel2.Controls.Add(this.labelControl1);
            this.panel2.Controls.Add(this.comboUsuarios);
            this.panel2.Controls.Add(this.cmdNuevoUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(23, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 117);
            this.panel2.TabIndex = 2;
            // 
            // cmdEditarUsuario
            // 
            this.cmdEditarUsuario.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEditarUsuario.Appearance.Options.UseFont = true;
            this.cmdEditarUsuario.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdEditarUsuario.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdEditarUsuario.ImageOptions.Image")));
            this.cmdEditarUsuario.Location = new System.Drawing.Point(316, 5);
            this.cmdEditarUsuario.Name = "cmdEditarUsuario";
            this.cmdEditarUsuario.Size = new System.Drawing.Size(123, 32);
            this.cmdEditarUsuario.TabIndex = 8;
            this.cmdEditarUsuario.Text = "Editar Usuario";
            this.cmdEditarUsuario.Click += new System.EventHandler(this.cmdEditarUsuario_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl1.Location = new System.Drawing.Point(3, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Usuario";
            // 
            // comboUsuarios
            // 
            this.comboUsuarios.Location = new System.Drawing.Point(3, 43);
            this.comboUsuarios.Name = "comboUsuarios";
            this.comboUsuarios.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboUsuarios.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.comboUsuarios.Properties.DisplayMember = "FullName";
            this.comboUsuarios.Properties.NullText = "";
            this.comboUsuarios.Properties.PopupSizeable = false;
            this.comboUsuarios.Properties.PopupView = this.searchLookUpEdit1View;
            this.comboUsuarios.Size = new System.Drawing.Size(260, 20);
            this.comboUsuarios.TabIndex = 6;
            this.comboUsuarios.EditValueChanged += new System.EventHandler(this.comboSistemas_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idColumn,
            this.usuarioColumn,
            this.nombreColumn});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsFind.ClearFindOnClose = false;
            this.searchLookUpEdit1View.OptionsFind.ShowSearchNavButtons = false;
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // idColumn
            // 
            this.idColumn.Caption = "Id";
            this.idColumn.FieldName = "Id";
            this.idColumn.Name = "idColumn";
            this.idColumn.OptionsColumn.AllowEdit = false;
            this.idColumn.OptionsColumn.AllowFocus = false;
            this.idColumn.Visible = true;
            this.idColumn.VisibleIndex = 0;
            this.idColumn.Width = 112;
            // 
            // usuarioColumn
            // 
            this.usuarioColumn.Caption = "Usuario";
            this.usuarioColumn.FieldName = "Usuario";
            this.usuarioColumn.Name = "usuarioColumn";
            this.usuarioColumn.OptionsColumn.AllowEdit = false;
            this.usuarioColumn.OptionsColumn.AllowFocus = false;
            this.usuarioColumn.Visible = true;
            this.usuarioColumn.VisibleIndex = 1;
            this.usuarioColumn.Width = 252;
            // 
            // nombreColumn
            // 
            this.nombreColumn.Caption = "Nombre";
            this.nombreColumn.FieldName = "Nombre";
            this.nombreColumn.Name = "nombreColumn";
            this.nombreColumn.OptionsColumn.AllowEdit = false;
            this.nombreColumn.OptionsColumn.AllowFocus = false;
            this.nombreColumn.Visible = true;
            this.nombreColumn.VisibleIndex = 2;
            this.nombreColumn.Width = 356;
            // 
            // cmdNuevoUser
            // 
            this.cmdNuevoUser.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNuevoUser.Appearance.Options.UseFont = true;
            this.cmdNuevoUser.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdNuevoUser.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdNuevoUser.ImageOptions.SvgImage")));
            this.cmdNuevoUser.Location = new System.Drawing.Point(187, 5);
            this.cmdNuevoUser.Name = "cmdNuevoUser";
            this.cmdNuevoUser.Size = new System.Drawing.Size(123, 32);
            this.cmdNuevoUser.TabIndex = 5;
            this.cmdNuevoUser.Text = "Nuevo Usuario";
            this.cmdNuevoUser.Click += new System.EventHandler(this.cmdNuevoUser_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.simpleButton2);
            this.panel3.Controls.Add(this.simpleButton1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(23, 430);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(444, 40);
            this.panel3.TabIndex = 3;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.Red;
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Location = new System.Drawing.Point(84, 17);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Cancelar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(3, 17);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Guardar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gridControlAccesos);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(473, 126);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(316, 298);
            this.panel4.TabIndex = 4;
            // 
            // gridControlAccesos
            // 
            this.gridControlAccesos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlAccesos.Location = new System.Drawing.Point(0, 0);
            this.gridControlAccesos.MainView = this.gridViewAccesos;
            this.gridControlAccesos.Name = "gridControlAccesos";
            this.gridControlAccesos.Size = new System.Drawing.Size(316, 298);
            this.gridControlAccesos.TabIndex = 0;
            this.gridControlAccesos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAccesos});
            // 
            // gridViewAccesos
            // 
            this.gridViewAccesos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridViewAccesos.GridControl = this.gridControlAccesos;
            this.gridViewAccesos.Name = "gridViewAccesos";
            this.gridViewAccesos.OptionsView.AllowHtmlDrawGroups = false;
            this.gridViewAccesos.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden;
            this.gridViewAccesos.OptionsView.ShowAutoFilterRow = true;
            this.gridViewAccesos.OptionsView.ShowGroupPanel = false;
            this.gridViewAccesos.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewAccesos_RowCellClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Id";
            this.gridColumn1.FieldName = "Id";
            this.gridColumn1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn1.ImageOptions.Image")));
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Acceso";
            this.gridColumn2.FieldName = "Nombre";
            this.gridColumn2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn2.ImageOptions.Image")));
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Asignado";
            this.gridColumn3.FieldName = "Enable";
            this.gridColumn3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn3.ImageOptions.Image")));
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "IdNivel";
            this.gridColumn4.FieldName = "IdNivel";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // AccesoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 493);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AccesoUsuario";
            this.Text = "Asignacion de acceso a usuarios";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetalleSistemas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetalleSistemas)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboUsuarios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAccesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAccesos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControlDetalleSistemas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDetalleSistemas;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn Nivel;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SearchLookUpEdit comboUsuarios;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn idColumn;
        private DevExpress.XtraGrid.Columns.GridColumn usuarioColumn;
        private DevExpress.XtraGrid.Columns.GridColumn nombreColumn;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraGrid.GridControl gridControlAccesos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAccesos;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn Codigo;
        private DevExpress.XtraEditors.SimpleButton cmdNuevoUser;
        private DevExpress.XtraEditors.SimpleButton cmdEditarUsuario;
    }
}