
using DevExpress.XtraTab;

namespace ERP_INTECOLI
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.xtraTabControlMenu = new DevExpress.XtraTab.XtraTabControl();
            this.TabAdministracion = new DevExpress.XtraTab.XtraTabPage();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navDesconectar = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarUsuarios = new DevExpress.XtraNavBar.NavBarItem();
            this.navCRUDPermisos = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarSeparatorItem1 = new DevExpress.XtraNavBar.NavBarSeparatorItem();
            this.navBarEstudiantes = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarInstructor = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarSeparatorItem2 = new DevExpress.XtraNavBar.NavBarSeparatorItem();
            this.navMatricula = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarSeparatorItem3 = new DevExpress.XtraNavBar.NavBarSeparatorItem();
            this.navConsultaMatriculado = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navPostearMensualidad = new DevExpress.XtraNavBar.NavBarItem();
            this.navMovimientoSaldos = new DevExpress.XtraNavBar.NavBarItem();
            this.navGeneracionPlanilla = new DevExpress.XtraNavBar.NavBarItem();
            this.navCaja = new DevExpress.XtraNavBar.NavBarItem();
            this.navFastMatricula = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarAsistenciaManual = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarEstadoCuenta = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarReservaCupo = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.NavBarProyeccionCobros = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarMiemborsClases = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblServerName = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMenu)).BeginInit();
            this.xtraTabControlMenu.SuspendLayout();
            this.TabAdministracion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabControlMenu
            // 
            this.xtraTabControlMenu.Appearance.BackColor = System.Drawing.Color.White;
            this.xtraTabControlMenu.Appearance.Options.UseBackColor = true;
            this.xtraTabControlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.xtraTabControlMenu.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControlMenu.Name = "xtraTabControlMenu";
            this.xtraTabControlMenu.SelectedTabPage = this.TabAdministracion;
            this.xtraTabControlMenu.Size = new System.Drawing.Size(209, 759);
            this.xtraTabControlMenu.TabIndex = 0;
            this.xtraTabControlMenu.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabAdministracion});
            this.xtraTabControlMenu.Visible = false;
            // 
            // TabAdministracion
            // 
            this.TabAdministracion.Appearance.PageClient.BackColor = System.Drawing.Color.White;
            this.TabAdministracion.Appearance.PageClient.Options.UseBackColor = true;
            this.TabAdministracion.Controls.Add(this.navBarControl1);
            this.TabAdministracion.Name = "TabAdministracion";
            this.TabAdministracion.Size = new System.Drawing.Size(207, 734);
            this.TabAdministracion.Text = "Menu Principal";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navBarControl1.BackColor = System.Drawing.Color.White;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navDesconectar,
            this.navBarUsuarios,
            this.navBarSeparatorItem1,
            this.navBarEstudiantes,
            this.navBarItem4,
            this.navBarInstructor,
            this.navBarSeparatorItem2,
            this.navMatricula,
            this.navBarSeparatorItem3,
            this.navCRUDPermisos,
            this.navConsultaMatriculado,
            this.navPostearMensualidad,
            this.navMovimientoSaldos,
            this.navGeneracionPlanilla,
            this.navCaja,
            this.navFastMatricula,
            this.navBarAsistenciaManual,
            this.navBarEstadoCuenta,
            this.navBarReservaCupo,
            this.NavBarProyeccionCobros,
            this.navBarMiemborsClases,
            this.navBarItem3});
            this.navBarControl1.Location = new System.Drawing.Point(3, 3);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 205;
            this.navBarControl1.Size = new System.Drawing.Size(205, 728);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Acciones";
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navDesconectar),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarUsuarios),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navCRUDPermisos),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarSeparatorItem1),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarEstudiantes),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem4),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarInstructor),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarSeparatorItem2),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navMatricula),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarSeparatorItem3),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navConsultaMatriculado)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navDesconectar
            // 
            this.navDesconectar.Caption = "Desconectar";
            this.navDesconectar.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navDesconectar.ImageOptions.SmallImage")));
            this.navDesconectar.Name = "navDesconectar";
            this.navDesconectar.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navDesconectar_LinkClicked);
            // 
            // navBarUsuarios
            // 
            this.navBarUsuarios.Caption = "Usuarios y Permisos";
            this.navBarUsuarios.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarUsuarios.ImageOptions.SvgImage")));
            this.navBarUsuarios.Name = "navBarUsuarios";
            // 
            // navCRUDPermisos
            // 
            this.navCRUDPermisos.Caption = "Gestion de Permisos";
            this.navCRUDPermisos.ImageOptions.SmallImage = global::ERP_INTECOLI.Properties.Resources.control_de_accessox32;
            this.navCRUDPermisos.Name = "navCRUDPermisos";
            this.navCRUDPermisos.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navCRUDPermisos_LinkClicked);
            // 
            // navBarSeparatorItem1
            // 
            this.navBarSeparatorItem1.CanDrag = false;
            this.navBarSeparatorItem1.Enabled = false;
            this.navBarSeparatorItem1.Hint = null;
            this.navBarSeparatorItem1.Name = "navBarSeparatorItem1";
            // 
            // navBarEstudiantes
            // 
            this.navBarEstudiantes.Caption = "Estudiantes";
            this.navBarEstudiantes.ImageOptions.SmallImage = global::ERP_INTECOLI.Properties.Resources.Estudiantex32;
            this.navBarEstudiantes.Name = "navBarEstudiantes";
            this.navBarEstudiantes.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarEstudiantes_LinkClicked);
            // 
            // navBarItem4
            // 
            this.navBarItem4.Caption = "Niveles Academicos";
            this.navBarItem4.ImageOptions.SmallImage = global::ERP_INTECOLI.Properties.Resources.Niveles_x32;
            this.navBarItem4.Name = "navBarItem4";
            this.navBarItem4.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem4_LinkClicked);
            // 
            // navBarInstructor
            // 
            this.navBarInstructor.Caption = "Instructores";
            this.navBarInstructor.ImageOptions.SmallImage = global::ERP_INTECOLI.Properties.Resources.maestro_x32;
            this.navBarInstructor.Name = "navBarInstructor";
            this.navBarInstructor.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarInstructor_LinkClicked);
            // 
            // navBarSeparatorItem2
            // 
            this.navBarSeparatorItem2.CanDrag = false;
            this.navBarSeparatorItem2.Enabled = false;
            this.navBarSeparatorItem2.Hint = null;
            this.navBarSeparatorItem2.Name = "navBarSeparatorItem2";
            // 
            // navMatricula
            // 
            this.navMatricula.Caption = "Matricula";
            this.navMatricula.ImageOptions.SmallImage = global::ERP_INTECOLI.Properties.Resources.matriculax32;
            this.navMatricula.Name = "navMatricula";
            this.navMatricula.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navMatricula_LinkClicked);
            // 
            // navBarSeparatorItem3
            // 
            this.navBarSeparatorItem3.CanDrag = false;
            this.navBarSeparatorItem3.Enabled = false;
            this.navBarSeparatorItem3.Hint = null;
            this.navBarSeparatorItem3.Name = "navBarSeparatorItem3";
            // 
            // navConsultaMatriculado
            // 
            this.navConsultaMatriculado.Caption = "Consultar Matriculados";
            this.navConsultaMatriculado.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navConsultaMatriculado.ImageOptions.SvgImage")));
            this.navConsultaMatriculado.Name = "navConsultaMatriculado";
            this.navConsultaMatriculado.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navConsultaMatriculado_LinkClicked);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Transacciones";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navPostearMensualidad),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navMovimientoSaldos),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navGeneracionPlanilla),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navCaja),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navFastMatricula),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarAsistenciaManual),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarEstadoCuenta),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarReservaCupo)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navPostearMensualidad
            // 
            this.navPostearMensualidad.Caption = "Posteo de Pagos - Recibos";
            this.navPostearMensualidad.ImageOptions.SmallImage = global::ERP_INTECOLI.Properties.Resources.cash_icon24px;
            this.navPostearMensualidad.Name = "navPostearMensualidad";
            this.navPostearMensualidad.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navPostearMensualidad_LinkClicked);
            // 
            // navMovimientoSaldos
            // 
            this.navMovimientoSaldos.Caption = "Movimientos Cobros Estudiantes";
            this.navMovimientoSaldos.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navMovimientoSaldos.ImageOptions.SvgImage")));
            this.navMovimientoSaldos.Name = "navMovimientoSaldos";
            this.navMovimientoSaldos.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navMovimientoSaldos_LinkClicked);
            // 
            // navGeneracionPlanilla
            // 
            this.navGeneracionPlanilla.Caption = "Planilla";
            this.navGeneracionPlanilla.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navGeneracionPlanilla.ImageOptions.SmallImage")));
            this.navGeneracionPlanilla.Name = "navGeneracionPlanilla";
            this.navGeneracionPlanilla.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navGeneracionPlanilla_LinkClicked);
            // 
            // navCaja
            // 
            this.navCaja.Caption = "Caja";
            this.navCaja.ImageOptions.SmallImage = global::ERP_INTECOLI.Properties.Resources.caja_registradorax32;
            this.navCaja.Name = "navCaja";
            this.navCaja.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navCaja_LinkClicked);
            // 
            // navFastMatricula
            // 
            this.navFastMatricula.Caption = "Matricula Rapida";
            this.navFastMatricula.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navFastMatricula.ImageOptions.SvgImage")));
            this.navFastMatricula.Name = "navFastMatricula";
            this.navFastMatricula.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navFastMatricula_LinkClicked);
            // 
            // navBarAsistenciaManual
            // 
            this.navBarAsistenciaManual.Caption = "Marca Asistencia Manual";
            this.navBarAsistenciaManual.ImageOptions.SmallImage = global::ERP_INTECOLI.Properties.Resources.seguro_32x;
            this.navBarAsistenciaManual.Name = "navBarAsistenciaManual";
            this.navBarAsistenciaManual.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarAsistenciaManual_LinkClicked);
            // 
            // navBarEstadoCuenta
            // 
            this.navBarEstadoCuenta.Caption = "Estado de Cuenta";
            this.navBarEstadoCuenta.ImageOptions.SmallImage = global::ERP_INTECOLI.Properties.Resources.presupuestox32;
            this.navBarEstadoCuenta.Name = "navBarEstadoCuenta";
            this.navBarEstadoCuenta.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarEstadoCuenta_LinkClicked);
            // 
            // navBarReservaCupo
            // 
            this.navBarReservaCupo.Caption = "Reserva de Cupo";
            this.navBarReservaCupo.ImageOptions.SmallImage = global::ERP_INTECOLI.Properties.Resources.reservadox32;
            this.navBarReservaCupo.Name = "navBarReservaCupo";
            this.navBarReservaCupo.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarReservaCupo_LinkClicked);
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "Consultas";
            this.navBarGroup3.Expanded = true;
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.NavBarProyeccionCobros),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarMiemborsClases),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem3)});
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // NavBarProyeccionCobros
            // 
            this.NavBarProyeccionCobros.Caption = "Consulta Tipos Pago Estudiane";
            this.NavBarProyeccionCobros.ImageOptions.SmallImage = global::ERP_INTECOLI.Properties.Resources.proyeccion_32;
            this.NavBarProyeccionCobros.Name = "NavBarProyeccionCobros";
            this.NavBarProyeccionCobros.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavBarProyeccionCobros_LinkClicked);
            // 
            // navBarMiemborsClases
            // 
            this.navBarMiemborsClases.Caption = "Miembros de Clase";
            this.navBarMiemborsClases.Name = "navBarMiemborsClases";
            this.navBarMiemborsClases.Visible = false;
            this.navBarMiemborsClases.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarMiemborsClases_LinkClicked);
            // 
            // navBarItem3
            // 
            this.navBarItem3.Caption = "Cumpleañeros";
            this.navBarItem3.Name = "navBarItem3";
            this.navBarItem3.Visible = false;
            this.navBarItem3.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem3_LinkClicked);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.lblServerName});
            this.statusStrip1.Location = new System.Drawing.Point(209, 737);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(705, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 20);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // lblServerName
            // 
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(0, 17);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 759);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.xtraTabControlMenu);
            this.IsMdiContainer = true;
            this.Name = "frmMainMenu";
            this.Text = "ERP - Success English Academy System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMenu)).EndInit();
            this.xtraTabControlMenu.ResumeLayout(false);
            this.TabAdministracion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XtraTabControl xtraTabControlMenu;
        private XtraTabPage TabAdministracion;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navDesconectar;
        private DevExpress.XtraNavBar.NavBarItem navBarUsuarios;
        private DevExpress.XtraNavBar.NavBarSeparatorItem navBarSeparatorItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarEstudiantes;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.XtraNavBar.NavBarItem navBarInstructor;
        private DevExpress.XtraNavBar.NavBarSeparatorItem navBarSeparatorItem2;
        private DevExpress.XtraNavBar.NavBarItem navMatricula;
        private DevExpress.XtraNavBar.NavBarSeparatorItem navBarSeparatorItem3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblServerName;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private DevExpress.XtraNavBar.NavBarItem navCRUDPermisos;
        private DevExpress.XtraNavBar.NavBarItem navConsultaMatriculado;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem navPostearMensualidad;
        private DevExpress.XtraNavBar.NavBarItem navMovimientoSaldos;
        private DevExpress.XtraNavBar.NavBarItem navGeneracionPlanilla;
        private DevExpress.XtraNavBar.NavBarItem navCaja;
        private DevExpress.XtraNavBar.NavBarItem navFastMatricula;
        private DevExpress.XtraNavBar.NavBarItem navBarAsistenciaManual;
        private DevExpress.XtraNavBar.NavBarItem navBarEstadoCuenta;
        private DevExpress.XtraNavBar.NavBarItem navBarReservaCupo;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarItem NavBarProyeccionCobros;
        private DevExpress.XtraNavBar.NavBarItem navBarMiemborsClases;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
    }
}