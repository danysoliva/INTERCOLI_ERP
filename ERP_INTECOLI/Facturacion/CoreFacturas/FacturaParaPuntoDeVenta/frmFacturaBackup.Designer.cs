using JAGUAR_APP.Facturacion.CoreFacturas;

namespace Eatery.Ventas
{
    partial class frmFacturaBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturaBackup));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinScrollBar.ScrollBarLook scrollBarLook1 = new Infragistics.Win.UltraWinScrollBar.ScrollBarLook();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.txtNombreCliente = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdAbrirBusqueda = new DevExpress.XtraEditors.SimpleButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmdFacturar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdSalir = new DevExpress.XtraEditors.SimpleButton();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cmdNew = new DevExpress.XtraEditors.SimpleButton();
            this.panelNotificacion = new System.Windows.Forms.Panel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.timerLimpiarMensaje = new System.Windows.Forms.Timer(this.components);
            this.lblfecha = new System.Windows.Forms.Label();
            this.dsVentas1 = new JAGUAR_APP.Facturacion.CoreFacturas.dsVentas();
            this.radioGroupVentaComidaBuffet = new DevExpress.XtraEditors.RadioGroup();
            this.lblOpcionesBuffetRadioButtonGroup = new System.Windows.Forms.Label();
            this.navigationFrame1 = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.txtDireccion = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdConsumidorFinal = new DevExpress.XtraEditors.SimpleButton();
            this.txtRTN = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtScanProducto = new DevExpress.XtraEditors.TextEdit();
            this.cmdTodosLosProductos = new DevExpress.XtraEditors.SimpleButton();
            this.cmdLoMasVendido = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_pt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitem_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddToCart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdAddToCart = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.ultraTilePanel1 = new Infragistics.Win.Misc.UltraTilePanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_pt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisv1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisv2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisv3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal_linea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdDeleteRowFactura = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colinventario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dsVentaSuccess1 = new ERP_INTECOLI.Facturacion.CoreFacturas.dsVentaSuccess();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreCliente.Properties)).BeginInit();
            this.panelNotificacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsVentas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupVentaComidaBuffet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).BeginInit();
            this.navigationFrame1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRTN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtScanProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdAddToCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTilePanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDeleteRowFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVentaSuccess1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(99, 29);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.txtNombreCliente.Properties.Appearance.Options.UseFont = true;
            this.txtNombreCliente.Properties.NullValuePrompt = "Nombre del Cliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(495, 26);
            this.txtNombreCliente.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cliente";
            // 
            // cmdAbrirBusqueda
            // 
            this.cmdAbrirBusqueda.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            this.cmdAbrirBusqueda.Appearance.Options.UseFont = true;
            this.cmdAbrirBusqueda.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdAbrirBusqueda.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdAbrirBusqueda.ImageOptions.Image")));
            this.cmdAbrirBusqueda.Location = new System.Drawing.Point(597, 78);
            this.cmdAbrirBusqueda.Name = "cmdAbrirBusqueda";
            this.cmdAbrirBusqueda.Size = new System.Drawing.Size(161, 34);
            this.cmdAbrirBusqueda.TabIndex = 3;
            this.cmdAbrirBusqueda.Text = "&Buscar Cliente";
            this.cmdAbrirBusqueda.Click += new System.EventHandler(this.cmdAbrirBusqueda_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(8, 3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(689, 23);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Ventas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdFacturar
            // 
            this.cmdFacturar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdFacturar.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFacturar.Appearance.Options.UseFont = true;
            this.cmdFacturar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdFacturar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdFacturar.ImageOptions.Image")));
            this.cmdFacturar.Location = new System.Drawing.Point(859, 597);
            this.cmdFacturar.Name = "cmdFacturar";
            this.cmdFacturar.Size = new System.Drawing.Size(246, 38);
            this.cmdFacturar.TabIndex = 7;
            this.cmdFacturar.Text = "&Facturar";
            this.cmdFacturar.Click += new System.EventHandler(this.cmdFacturar_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdSalir.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Appearance.Options.UseFont = true;
            this.cmdSalir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdSalir.ImageOptions.Image")));
            this.cmdSalir.Location = new System.Drawing.Point(255, 597);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(246, 38);
            this.cmdSalir.TabIndex = 6;
            this.cmdSalir.Text = "&Salir";
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(986, 562);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(119, 29);
            this.txtTotal.TabIndex = 11;
            this.txtTotal.Text = "0.00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmdNew
            // 
            this.cmdNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdNew.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNew.Appearance.Options.UseFont = true;
            this.cmdNew.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdNew.ImageOptions.Image")));
            this.cmdNew.Location = new System.Drawing.Point(3, 597);
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(246, 38);
            this.cmdNew.TabIndex = 14;
            this.cmdNew.Text = "&Nuevo";
            this.cmdNew.Click += new System.EventHandler(this.cmdNew_Click);
            // 
            // panelNotificacion
            // 
            this.panelNotificacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNotificacion.BackColor = System.Drawing.Color.White;
            this.panelNotificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNotificacion.Controls.Add(this.lblMensaje);
            this.panelNotificacion.Location = new System.Drawing.Point(3, 641);
            this.panelNotificacion.Name = "panelNotificacion";
            this.panelNotificacion.Size = new System.Drawing.Size(1102, 31);
            this.panelNotificacion.TabIndex = 15;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(6, 6);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(1081, 17);
            this.lblMensaje.TabIndex = 0;
            // 
            // timerLimpiarMensaje
            // 
            this.timerLimpiarMensaje.Interval = 4000;
            this.timerLimpiarMensaje.Tick += new System.EventHandler(this.timerLimpiarMensaje_Tick);
            // 
            // lblfecha
            // 
            this.lblfecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(1337, 22);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(121, 24);
            this.lblfecha.TabIndex = 16;
            this.lblfecha.Text = "Fecha Actual";
            // 
            // dsVentas1
            // 
            this.dsVentas1.DataSetName = "dsVentas";
            this.dsVentas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radioGroupVentaComidaBuffet
            // 
            this.radioGroupVentaComidaBuffet.EditValue = true;
            this.radioGroupVentaComidaBuffet.Location = new System.Drawing.Point(251, 123);
            this.radioGroupVentaComidaBuffet.Margin = new System.Windows.Forms.Padding(2);
            this.radioGroupVentaComidaBuffet.Name = "radioGroupVentaComidaBuffet";
            this.radioGroupVentaComidaBuffet.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.radioGroupVentaComidaBuffet.Properties.Appearance.Options.UseFont = true;
            this.radioGroupVentaComidaBuffet.Properties.Appearance.Options.UseTextOptions = true;
            this.radioGroupVentaComidaBuffet.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.radioGroupVentaComidaBuffet.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.radioGroupVentaComidaBuffet.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Desayuno"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Almuerzo"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Cena")});
            this.radioGroupVentaComidaBuffet.Properties.ItemVertAlignment = DevExpress.XtraEditors.RadioItemVertAlignment.Top;
            this.radioGroupVentaComidaBuffet.Size = new System.Drawing.Size(342, 33);
            this.radioGroupVentaComidaBuffet.TabIndex = 17;
            this.radioGroupVentaComidaBuffet.SelectedIndexChanged += new System.EventHandler(this.radioGroupVentaComidaBuffet_SelectedIndexChanged);
            // 
            // lblOpcionesBuffetRadioButtonGroup
            // 
            this.lblOpcionesBuffetRadioButtonGroup.AutoSize = true;
            this.lblOpcionesBuffetRadioButtonGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcionesBuffetRadioButtonGroup.Location = new System.Drawing.Point(3, 134);
            this.lblOpcionesBuffetRadioButtonGroup.Name = "lblOpcionesBuffetRadioButtonGroup";
            this.lblOpcionesBuffetRadioButtonGroup.Size = new System.Drawing.Size(180, 24);
            this.lblOpcionesBuffetRadioButtonGroup.TabIndex = 18;
            this.lblOpcionesBuffetRadioButtonGroup.Text = "Preferir opciones de";
            // 
            // navigationFrame1
            // 
            this.navigationFrame1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navigationFrame1.Controls.Add(this.navigationPage1);
            this.navigationFrame1.Location = new System.Drawing.Point(0, 2);
            this.navigationFrame1.Margin = new System.Windows.Forms.Padding(2);
            this.navigationFrame1.Name = "navigationFrame1";
            this.navigationFrame1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1});
            this.navigationFrame1.SelectedPage = this.navigationPage1;
            this.navigationFrame1.Size = new System.Drawing.Size(1108, 675);
            this.navigationFrame1.TabIndex = 19;
            this.navigationFrame1.Text = "navigationFrame1";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "navigationPage1";
            this.navigationPage1.Controls.Add(this.txtDireccion);
            this.navigationPage1.Controls.Add(this.label3);
            this.navigationPage1.Controls.Add(this.panelNotificacion);
            this.navigationPage1.Controls.Add(this.cmdConsumidorFinal);
            this.navigationPage1.Controls.Add(this.txtRTN);
            this.navigationPage1.Controls.Add(this.label2);
            this.navigationPage1.Controls.Add(this.simpleButton1);
            this.navigationPage1.Controls.Add(this.cmdSalir);
            this.navigationPage1.Controls.Add(this.cmdNew);
            this.navigationPage1.Controls.Add(this.txtScanProducto);
            this.navigationPage1.Controls.Add(this.cmdFacturar);
            this.navigationPage1.Controls.Add(this.cmdTodosLosProductos);
            this.navigationPage1.Controls.Add(this.cmdLoMasVendido);
            this.navigationPage1.Controls.Add(this.gridControl2);
            this.navigationPage1.Controls.Add(this.ultraTilePanel1);
            this.navigationPage1.Controls.Add(this.gridControl1);
            this.navigationPage1.Controls.Add(this.lblOpcionesBuffetRadioButtonGroup);
            this.navigationPage1.Controls.Add(this.txtTotal);
            this.navigationPage1.Controls.Add(this.radioGroupVentaComidaBuffet);
            this.navigationPage1.Controls.Add(this.lblfecha);
            this.navigationPage1.Controls.Add(this.cmdAbrirBusqueda);
            this.navigationPage1.Controls.Add(this.label1);
            this.navigationPage1.Controls.Add(this.lblTitulo);
            this.navigationPage1.Controls.Add(this.txtNombreCliente);
            this.navigationPage1.Margin = new System.Windows.Forms.Padding(2);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(1108, 675);
            this.navigationPage1.Paint += new System.Windows.Forms.PaintEventHandler(this.navigationPage1_Paint);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(99, 86);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.txtDireccion.Properties.Appearance.Options.UseFont = true;
            this.txtDireccion.Properties.NullValuePrompt = "Direcci del Cliente";
            this.txtDireccion.Size = new System.Drawing.Size(495, 26);
            this.txtDireccion.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Dirección";
            // 
            // cmdConsumidorFinal
            // 
            this.cmdConsumidorFinal.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            this.cmdConsumidorFinal.Appearance.Options.UseFont = true;
            this.cmdConsumidorFinal.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdConsumidorFinal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdConsumidorFinal.ImageOptions.Image")));
            this.cmdConsumidorFinal.Location = new System.Drawing.Point(763, 78);
            this.cmdConsumidorFinal.Name = "cmdConsumidorFinal";
            this.cmdConsumidorFinal.Size = new System.Drawing.Size(172, 34);
            this.cmdConsumidorFinal.TabIndex = 34;
            this.cmdConsumidorFinal.Text = "Consumidor Final";
            this.cmdConsumidorFinal.Click += new System.EventHandler(this.cmdConsumidorFinal_Click);
            // 
            // txtRTN
            // 
            this.txtRTN.Location = new System.Drawing.Point(99, 57);
            this.txtRTN.Name = "txtRTN";
            this.txtRTN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.txtRTN.Properties.Appearance.Options.UseFont = true;
            this.txtRTN.Properties.NullValuePrompt = "Nombre del Cliente";
            this.txtRTN.Size = new System.Drawing.Size(495, 26);
            this.txtRTN.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "RTN";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(850, 123);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(159, 33);
            this.simpleButton1.TabIndex = 31;
            this.simpleButton1.Text = "&Buscar Producto";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_2);
            // 
            // txtScanProducto
            // 
            this.txtScanProducto.Location = new System.Drawing.Point(597, 126);
            this.txtScanProducto.Name = "txtScanProducto";
            this.txtScanProducto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtScanProducto.Properties.Appearance.Options.UseFont = true;
            this.txtScanProducto.Properties.NullValuePrompt = "Leer código de Producto";
            this.txtScanProducto.Size = new System.Drawing.Size(247, 30);
            this.txtScanProducto.TabIndex = 30;
            this.txtScanProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtScanProducto_KeyDown);
            // 
            // cmdTodosLosProductos
            // 
            this.cmdTodosLosProductos.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdTodosLosProductos.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmdTodosLosProductos.Appearance.Options.UseBackColor = true;
            this.cmdTodosLosProductos.Appearance.Options.UseFont = true;
            this.cmdTodosLosProductos.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdTodosLosProductos.Location = new System.Drawing.Point(430, 162);
            this.cmdTodosLosProductos.Name = "cmdTodosLosProductos";
            this.cmdTodosLosProductos.Size = new System.Drawing.Size(164, 34);
            this.cmdTodosLosProductos.TabIndex = 29;
            this.cmdTodosLosProductos.Text = "&Todos";
            this.cmdTodosLosProductos.Click += new System.EventHandler(this.cmdTodosLosProductos_Click);
            // 
            // cmdLoMasVendido
            // 
            this.cmdLoMasVendido.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdLoMasVendido.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmdLoMasVendido.Appearance.Options.UseBackColor = true;
            this.cmdLoMasVendido.Appearance.Options.UseFont = true;
            this.cmdLoMasVendido.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdLoMasVendido.Location = new System.Drawing.Point(251, 162);
            this.cmdLoMasVendido.Name = "cmdLoMasVendido";
            this.cmdLoMasVendido.Size = new System.Drawing.Size(164, 34);
            this.cmdLoMasVendido.TabIndex = 28;
            this.cmdLoMasVendido.Text = "Lo &más vendido";
            this.cmdLoMasVendido.Click += new System.EventHandler(this.cmdLoMasVendido_Click);
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridControl2.DataMember = "mas_vendidos";
            this.gridControl2.DataSource = this.dsVentas1;
            this.gridControl2.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl2.Location = new System.Drawing.Point(251, 201);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdAddToCart});
            this.gridControl2.Size = new System.Drawing.Size(342, 356);
            this.gridControl2.TabIndex = 27;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_pt,
            this.colitem_code,
            this.coldescripcion,
            this.colAddToCart});
            this.gridView2.DetailHeight = 182;
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.LevelIndent = 0;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsEditForm.PopupEditFormWidth = 400;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.PreviewIndent = 0;
            // 
            // colid_pt
            // 
            this.colid_pt.FieldName = "id_pt";
            this.colid_pt.Name = "colid_pt";
            // 
            // colitem_code
            // 
            this.colitem_code.FieldName = "item_code";
            this.colitem_code.Name = "colitem_code";
            this.colitem_code.OptionsColumn.ReadOnly = true;
            this.colitem_code.Visible = true;
            this.colitem_code.VisibleIndex = 0;
            this.colitem_code.Width = 58;
            // 
            // coldescripcion
            // 
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.ReadOnly = true;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 1;
            this.coldescripcion.Width = 204;
            // 
            // colAddToCart
            // 
            this.colAddToCart.Caption = "Agregar";
            this.colAddToCart.ColumnEdit = this.cmdAddToCart;
            this.colAddToCart.Name = "colAddToCart";
            this.colAddToCart.Visible = true;
            this.colAddToCart.VisibleIndex = 2;
            this.colAddToCart.Width = 59;
            // 
            // cmdAddToCart
            // 
            this.cmdAddToCart.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.cmdAddToCart.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdAddToCart.Name = "cmdAddToCart";
            this.cmdAddToCart.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdAddToCart.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdAddToCart_ButtonClick);
            // 
            // ultraTilePanel1
            // 
            this.ultraTilePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            appearance1.BorderColor = System.Drawing.Color.Silver;
            appearance1.BorderColor2 = System.Drawing.Color.Silver;
            this.ultraTilePanel1.Appearance = appearance1;
            this.ultraTilePanel1.Location = new System.Drawing.Point(3, 162);
            this.ultraTilePanel1.Margin = new System.Windows.Forms.Padding(0);
            this.ultraTilePanel1.MaximumColumns = 1;
            this.ultraTilePanel1.MaximumRows = 5;
            this.ultraTilePanel1.MaximumVisibleLargeTiles = 1;
            this.ultraTilePanel1.MinimumColumns = 1;
            this.ultraTilePanel1.MinimumRows = 5;
            this.ultraTilePanel1.Name = "ultraTilePanel1";
            this.ultraTilePanel1.NormalModeDimensions = new System.Drawing.Size(0, 0);
            appearance2.AlphaLevel = ((short)(1));
            scrollBarLook1.Appearance = appearance2;
            scrollBarLook1.HorizontalScrollBarArrowWidth = 1;
            scrollBarLook1.HorizontalScrollBarHeight = 1;
            scrollBarLook1.MinimumThumbHeight = 1;
            scrollBarLook1.MinimumThumbWidth = 1;
            scrollBarLook1.ScrollBarArrowStyle = Infragistics.Win.UltraWinScrollBar.ScrollBarArrowStyle.None;
            scrollBarLook1.ShowMinMaxButtons = Infragistics.Win.DefaultableBoolean.False;
            this.ultraTilePanel1.ScrollBarLook = scrollBarLook1;
            this.ultraTilePanel1.Size = new System.Drawing.Size(246, 395);
            this.ultraTilePanel1.SupportsZooming = false;
            this.ultraTilePanel1.TabIndex = 22;
            this.ultraTilePanel1.TileSettings.HeaderPosition = Infragistics.Win.Misc.TileHeaderPosition.Top;
            this.ultraTilePanel1.UseFlatMode = Infragistics.Win.DefaultableBoolean.True;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "detalle_factura_transaction";
            this.gridControl1.DataSource = this.dsVentas1;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Location = new System.Drawing.Point(597, 162);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdDeleteRowFactura});
            this.gridControl1.Size = new System.Drawing.Size(508, 395);
            this.gridControl1.TabIndex = 20;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_pt1,
            this.colitemcode,
            this.colitemname,
            this.colcantidad,
            this.colprecio,
            this.coldescuento,
            this.colisv1,
            this.colisv2,
            this.colisv3,
            this.coltotal_linea,
            this.colDelete,
            this.colinventario});
            this.gridView1.DetailHeight = 182;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.LevelIndent = 0;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 400;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.PreviewIndent = 0;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // colid_pt1
            // 
            this.colid_pt1.FieldName = "id_pt";
            this.colid_pt1.Name = "colid_pt1";
            // 
            // colitemcode
            // 
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.Name = "colitemcode";
            this.colitemcode.OptionsColumn.ReadOnly = true;
            this.colitemcode.Visible = true;
            this.colitemcode.VisibleIndex = 0;
            this.colitemcode.Width = 47;
            // 
            // colitemname
            // 
            this.colitemname.FieldName = "itemname";
            this.colitemname.Name = "colitemname";
            this.colitemname.OptionsColumn.ReadOnly = true;
            this.colitemname.Visible = true;
            this.colitemname.VisibleIndex = 1;
            this.colitemname.Width = 109;
            // 
            // colcantidad
            // 
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 3;
            this.colcantidad.Width = 45;
            // 
            // colprecio
            // 
            this.colprecio.DisplayFormat.FormatString = "n2";
            this.colprecio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colprecio.FieldName = "precio";
            this.colprecio.Name = "colprecio";
            this.colprecio.OptionsColumn.ReadOnly = true;
            this.colprecio.Visible = true;
            this.colprecio.VisibleIndex = 4;
            this.colprecio.Width = 63;
            // 
            // coldescuento
            // 
            this.coldescuento.FieldName = "descuento";
            this.coldescuento.Name = "coldescuento";
            this.coldescuento.Width = 47;
            // 
            // colisv1
            // 
            this.colisv1.Caption = "ISV";
            this.colisv1.DisplayFormat.FormatString = "n2";
            this.colisv1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colisv1.FieldName = "isv1";
            this.colisv1.Name = "colisv1";
            this.colisv1.OptionsColumn.ReadOnly = true;
            this.colisv1.Visible = true;
            this.colisv1.VisibleIndex = 5;
            this.colisv1.Width = 46;
            // 
            // colisv2
            // 
            this.colisv2.FieldName = "isv2";
            this.colisv2.Name = "colisv2";
            // 
            // colisv3
            // 
            this.colisv3.FieldName = "isv3";
            this.colisv3.Name = "colisv3";
            // 
            // coltotal_linea
            // 
            this.coltotal_linea.DisplayFormat.FormatString = "n2";
            this.coltotal_linea.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltotal_linea.FieldName = "total_linea";
            this.coltotal_linea.Name = "coltotal_linea";
            this.coltotal_linea.OptionsColumn.ReadOnly = true;
            this.coltotal_linea.Visible = true;
            this.coltotal_linea.VisibleIndex = 6;
            this.coltotal_linea.Width = 76;
            // 
            // colDelete
            // 
            this.colDelete.Caption = "Elminar";
            this.colDelete.ColumnEdit = this.cmdDeleteRowFactura;
            this.colDelete.Name = "colDelete";
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 7;
            this.colDelete.Width = 53;
            // 
            // cmdDeleteRowFactura
            // 
            this.cmdDeleteRowFactura.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.cmdDeleteRowFactura.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdDeleteRowFactura.Name = "cmdDeleteRowFactura";
            this.cmdDeleteRowFactura.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdDeleteRowFactura.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdDeleteRowFactura_ButtonClick);
            // 
            // colinventario
            // 
            this.colinventario.Caption = "Inventario";
            this.colinventario.DisplayFormat.FormatString = "n2";
            this.colinventario.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colinventario.FieldName = "inventario";
            this.colinventario.Name = "colinventario";
            this.colinventario.OptionsColumn.ReadOnly = true;
            this.colinventario.Visible = true;
            this.colinventario.VisibleIndex = 2;
            this.colinventario.Width = 48;
            // 
            // dsVentaSuccess1
            // 
            this.dsVentaSuccess1.DataSetName = "dsVentaSuccess";
            this.dsVentaSuccess1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmFacturaBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1108, 678);
            this.Controls.Add(this.navigationFrame1);
            this.Name = "frmFacturaBackup";
            this.Text = "Factura";
            this.Activated += new System.EventHandler(this.frmFacturaBackup_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFacturaBackup_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreCliente.Properties)).EndInit();
            this.panelNotificacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsVentas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupVentaComidaBuffet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).EndInit();
            this.navigationFrame1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            this.navigationPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRTN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtScanProducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdAddToCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTilePanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDeleteRowFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVentaSuccess1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtNombreCliente;
        private DevExpress.XtraEditors.SimpleButton cmdAbrirBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitulo;
        private DevExpress.XtraEditors.SimpleButton cmdFacturar;
        private DevExpress.XtraEditors.SimpleButton cmdSalir;
        private System.Windows.Forms.TextBox txtTotal;
        private DevExpress.XtraEditors.SimpleButton cmdNew;
        private System.Windows.Forms.Panel panelNotificacion;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Timer timerLimpiarMensaje;
        private System.Windows.Forms.Label lblfecha;
        private dsVentas dsVentas1;
        private DevExpress.XtraEditors.RadioGroup radioGroupVentaComidaBuffet;
        private System.Windows.Forms.Label lblOpcionesBuffetRadioButtonGroup;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Infragistics.Win.Misc.UltraTilePanel ultraTilePanel1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton cmdTodosLosProductos;
        private DevExpress.XtraEditors.SimpleButton cmdLoMasVendido;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit txtScanProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colid_pt;
        private DevExpress.XtraGrid.Columns.GridColumn colitem_code;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colAddToCart;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdAddToCart;
        private DevExpress.XtraGrid.Columns.GridColumn colid_pt1;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
        private DevExpress.XtraGrid.Columns.GridColumn colitemname;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colprecio;
        private DevExpress.XtraGrid.Columns.GridColumn coldescuento;
        private DevExpress.XtraGrid.Columns.GridColumn colisv1;
        private DevExpress.XtraGrid.Columns.GridColumn colisv2;
        private DevExpress.XtraGrid.Columns.GridColumn colisv3;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal_linea;
        private DevExpress.XtraEditors.TextEdit txtRTN;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton cmdConsumidorFinal;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdDeleteRowFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colinventario;
        private DevExpress.XtraEditors.TextEdit txtDireccion;
        private System.Windows.Forms.Label label3;
        private ERP_INTECOLI.Facturacion.CoreFacturas.dsVentaSuccess dsVentaSuccess1;
    }
}