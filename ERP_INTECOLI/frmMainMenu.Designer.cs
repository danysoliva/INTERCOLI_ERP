
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
            this.navBarSeparatorItem4 = new DevExpress.XtraNavBar.NavBarSeparatorItem();
            this.navBarSeparatorItem5 = new DevExpress.XtraNavBar.NavBarSeparatorItem();
            this.nb_FacturaCore = new DevExpress.XtraNavBar.NavBarItem();
            this.nb_facturasEmitidas = new DevExpress.XtraNavBar.NavBarItem();
            this.nbEstadoCuenta = new DevExpress.XtraNavBar.NavBarItem();
            this.nbCrearAutorizacionesSolicitudes = new DevExpress.XtraNavBar.NavBarItem();
            this.nbPagoMultiple = new DevExpress.XtraNavBar.NavBarItem();
            this.nbNotasCredito = new DevExpress.XtraNavBar.NavBarItem();
            this.nbCierreCaja = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.NavBarProyeccionCobros = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarMiemborsClases = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.navGeneros = new DevExpress.XtraNavBar.NavBarItem();
            this.navSeguimientoSaldos = new DevExpress.XtraNavBar.NavBarItem();
            this.navEstudiantesDeshabilitados = new DevExpress.XtraNavBar.NavBarItem();
            this.navTiposPagoEstudiane = new DevExpress.XtraNavBar.NavBarItem();
            this.navIngresosTool = new DevExpress.XtraNavBar.NavBarItem();
            this.navSaldoAcumulado = new DevExpress.XtraNavBar.NavBarItem();
            this.navRangosPago = new DevExpress.XtraNavBar.NavBarItem();
            this.navArqueoCaja = new DevExpress.XtraNavBar.NavBarItem();
            this.navDistribucionResidencial = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup4 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navNuevoRecordatorio = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup5 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBfrmCursos = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.nbConfig_PuntoVenta = new DevExpress.XtraNavBar.NavBarItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblServerName = new System.Windows.Forms.ToolStripStatusLabel();
            this.navBarAcessosUsuario = new DevExpress.XtraNavBar.NavBarItem();
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
            this.xtraTabControlMenu.Size = new System.Drawing.Size(221, 759);
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
            this.TabAdministracion.Size = new System.Drawing.Size(219, 734);
            this.TabAdministracion.Text = "Menu Principal";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.navBarControl1.BackColor = System.Drawing.Color.White;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3,
            this.navBarGroup4,
            this.navBarGroup5});
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
            this.navBarItem3,
            this.navGeneros,
            this.navSeguimientoSaldos,
            this.navEstudiantesDeshabilitados,
            this.navTiposPagoEstudiane,
            this.navIngresosTool,
            this.navSaldoAcumulado,
            this.navRangosPago,
            this.navArqueoCaja,
            this.navDistribucionResidencial,
            this.navNuevoRecordatorio,
            this.navBfrmCursos,
            this.navBarItem2,
            this.navBarSeparatorItem4,
            this.navBarSeparatorItem5,
            this.nb_FacturaCore,
            this.nb_facturasEmitidas,
            this.nbEstadoCuenta,
            this.nbCrearAutorizacionesSolicitudes,
            this.nbPagoMultiple,
            this.nbNotasCredito,
            this.nbCierreCaja,
            this.nbConfig_PuntoVenta,
            this.navBarAcessosUsuario});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 216;
            this.navBarControl1.Size = new System.Drawing.Size(216, 712);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Acciones";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navDesconectar),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarUsuarios),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navCRUDPermisos),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarAcessosUsuario),
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
            this.navBarUsuarios.Caption = "Usuarios";
            this.navBarUsuarios.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarUsuarios.ImageOptions.SvgImage")));
            this.navBarUsuarios.Name = "navBarUsuarios";
            this.navBarUsuarios.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarUsuarios_LinkClicked);
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
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navPostearMensualidad),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navMovimientoSaldos),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navGeneracionPlanilla),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navCaja),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navFastMatricula),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarAsistenciaManual),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarEstadoCuenta),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarReservaCupo),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarSeparatorItem4),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarSeparatorItem5),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nb_FacturaCore),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nb_facturasEmitidas),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbEstadoCuenta),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbCrearAutorizacionesSolicitudes),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbPagoMultiple),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbNotasCredito),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbCierreCaja)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navPostearMensualidad
            // 
            this.navPostearMensualidad.Appearance.Options.UseTextOptions = true;
            this.navPostearMensualidad.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.navPostearMensualidad.Caption = "Posteo de Pagos - Recibos";
            this.navPostearMensualidad.ImageOptions.SmallImage = global::ERP_INTECOLI.Properties.Resources.cash_icon24px;
            this.navPostearMensualidad.Name = "navPostearMensualidad";
            this.navPostearMensualidad.Visible = false;
            this.navPostearMensualidad.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navPostearMensualidad_LinkClicked);
            // 
            // navMovimientoSaldos
            // 
            this.navMovimientoSaldos.Appearance.Options.UseTextOptions = true;
            this.navMovimientoSaldos.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.navMovimientoSaldos.Caption = "Movimientos Cobros Estudiantes";
            this.navMovimientoSaldos.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navMovimientoSaldos.ImageOptions.SvgImage")));
            this.navMovimientoSaldos.Name = "navMovimientoSaldos";
            this.navMovimientoSaldos.Visible = false;
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
            this.navCaja.Visible = false;
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
            this.navBarAsistenciaManual.Visible = false;
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
            // navBarSeparatorItem4
            // 
            this.navBarSeparatorItem4.CanDrag = false;
            this.navBarSeparatorItem4.Enabled = false;
            this.navBarSeparatorItem4.Hint = null;
            this.navBarSeparatorItem4.Name = "navBarSeparatorItem4";
            // 
            // navBarSeparatorItem5
            // 
            this.navBarSeparatorItem5.CanDrag = false;
            this.navBarSeparatorItem5.Enabled = false;
            this.navBarSeparatorItem5.Hint = null;
            this.navBarSeparatorItem5.Name = "navBarSeparatorItem5";
            // 
            // nb_FacturaCore
            // 
            this.nb_FacturaCore.Caption = "Facturación";
            this.nb_FacturaCore.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("nb_FacturaCore.ImageOptions.SvgImage")));
            this.nb_FacturaCore.Name = "nb_FacturaCore";
            this.nb_FacturaCore.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nb_FacturaCore_LinkClicked);
            // 
            // nb_facturasEmitidas
            // 
            this.nb_facturasEmitidas.Caption = "Facturas Emitidas";
            this.nb_facturasEmitidas.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("nb_facturasEmitidas.ImageOptions.SvgImage")));
            this.nb_facturasEmitidas.Name = "nb_facturasEmitidas";
            // 
            // nbEstadoCuenta
            // 
            this.nbEstadoCuenta.Caption = "Estado de Cuenta";
            this.nbEstadoCuenta.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("nbEstadoCuenta.ImageOptions.SvgImage")));
            this.nbEstadoCuenta.Name = "nbEstadoCuenta";
            // 
            // nbCrearAutorizacionesSolicitudes
            // 
            this.nbCrearAutorizacionesSolicitudes.Caption = "Solicitudes de Autorizaciones";
            this.nbCrearAutorizacionesSolicitudes.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbCrearAutorizacionesSolicitudes.ImageOptions.SmallImage")));
            this.nbCrearAutorizacionesSolicitudes.Name = "nbCrearAutorizacionesSolicitudes";
            // 
            // nbPagoMultiple
            // 
            this.nbPagoMultiple.Caption = "Pago Múltiple";
            this.nbPagoMultiple.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbPagoMultiple.ImageOptions.SmallImage")));
            this.nbPagoMultiple.Name = "nbPagoMultiple";
            // 
            // nbNotasCredito
            // 
            this.nbNotasCredito.Caption = "Notas Crédito/Débito";
            this.nbNotasCredito.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbNotasCredito.ImageOptions.SmallImage")));
            this.nbNotasCredito.Name = "nbNotasCredito";
            // 
            // nbCierreCaja
            // 
            this.nbCierreCaja.Caption = "Cierre de Caja";
            this.nbCierreCaja.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbCierreCaja.ImageOptions.SmallImage")));
            this.nbCierreCaja.Name = "nbCierreCaja";
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "Consultas";
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.NavBarProyeccionCobros),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarMiemborsClases),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem3),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navGeneros),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navSeguimientoSaldos),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navEstudiantesDeshabilitados),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navTiposPagoEstudiane),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navIngresosTool),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navSaldoAcumulado),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navRangosPago),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navArqueoCaja),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navDistribucionResidencial)});
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // NavBarProyeccionCobros
            // 
            this.NavBarProyeccionCobros.Caption = "Proyeccion Cobros";
            this.NavBarProyeccionCobros.ImageOptions.SmallImage = global::ERP_INTECOLI.Properties.Resources.proyeccion_32;
            this.NavBarProyeccionCobros.Name = "NavBarProyeccionCobros";
            this.NavBarProyeccionCobros.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavBarProyeccionCobros_LinkClicked);
            // 
            // navBarMiemborsClases
            // 
            this.navBarMiemborsClases.Caption = "Miembros de Clase";
            this.navBarMiemborsClases.ImageOptions.SmallImage = global::ERP_INTECOLI.Properties.Resources.equipo_x32;
            this.navBarMiemborsClases.Name = "navBarMiemborsClases";
            this.navBarMiemborsClases.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarMiemborsClases_LinkClicked);
            // 
            // navBarItem3
            // 
            this.navBarItem3.Caption = "Cumpleañeros";
            this.navBarItem3.ImageOptions.SmallImage = global::ERP_INTECOLI.Properties.Resources.presente_x32;
            this.navBarItem3.Name = "navBarItem3";
            this.navBarItem3.Visible = false;
            this.navBarItem3.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem3_LinkClicked);
            // 
            // navGeneros
            // 
            this.navGeneros.Caption = "Distribucion de Generos";
            this.navGeneros.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navGeneros.ImageOptions.SmallImage")));
            this.navGeneros.Name = "navGeneros";
            this.navGeneros.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navGeneros_LinkClicked);
            // 
            // navSeguimientoSaldos
            // 
            this.navSeguimientoSaldos.Caption = "Seguimiento Saldos";
            this.navSeguimientoSaldos.ImageOptions.SmallImage = global::ERP_INTECOLI.Properties.Resources.saldar_x32;
            this.navSeguimientoSaldos.Name = "navSeguimientoSaldos";
            this.navSeguimientoSaldos.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navSeguimientoSaldos_LinkClicked);
            // 
            // navEstudiantesDeshabilitados
            // 
            this.navEstudiantesDeshabilitados.Appearance.Options.UseTextOptions = true;
            this.navEstudiantesDeshabilitados.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.navEstudiantesDeshabilitados.Caption = "Estudiantes Deshabilitados";
            this.navEstudiantesDeshabilitados.ImageOptions.SmallImage = global::ERP_INTECOLI.Properties.Resources.bloquear_x32;
            this.navEstudiantesDeshabilitados.Name = "navEstudiantesDeshabilitados";
            this.navEstudiantesDeshabilitados.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navEstudiantesDeshabilitados_LinkClicked);
            // 
            // navTiposPagoEstudiane
            // 
            this.navTiposPagoEstudiane.Caption = "Tipos Pago Estudiane";
            this.navTiposPagoEstudiane.ImageOptions.SmallImage = global::ERP_INTECOLI.Properties.Resources.metodo_de_pago_x32;
            this.navTiposPagoEstudiane.Name = "navTiposPagoEstudiane";
            this.navTiposPagoEstudiane.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navTiposPagoEstudiane_LinkClicked);
            // 
            // navIngresosTool
            // 
            this.navIngresosTool.Caption = "Nuevos Ingresos";
            this.navIngresosTool.ImageOptions.SmallImage = global::ERP_INTECOLI.Properties.Resources.agregar_x32;
            this.navIngresosTool.Name = "navIngresosTool";
            this.navIngresosTool.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navIngresosTool_LinkClicked);
            // 
            // navSaldoAcumulado
            // 
            this.navSaldoAcumulado.Appearance.Options.UseTextOptions = true;
            this.navSaldoAcumulado.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.navSaldoAcumulado.Caption = "Deudores Saldo Acumulado";
            this.navSaldoAcumulado.ImageOptions.SmallImage = global::ERP_INTECOLI.Properties.Resources.dinero_x32;
            this.navSaldoAcumulado.Name = "navSaldoAcumulado";
            this.navSaldoAcumulado.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navSaldoAcumulado_LinkClicked);
            // 
            // navRangosPago
            // 
            this.navRangosPago.Caption = "Rangos de Pago";
            this.navRangosPago.ImageOptions.SmallImage = global::ERP_INTECOLI.Properties.Resources.credito_x32;
            this.navRangosPago.Name = "navRangosPago";
            this.navRangosPago.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navRangosPago_LinkClicked);
            // 
            // navArqueoCaja
            // 
            this.navArqueoCaja.Caption = "Arqueo de Caja";
            this.navArqueoCaja.ImageOptions.SmallImage = global::ERP_INTECOLI.Properties.Resources.caja_registradora_x32;
            this.navArqueoCaja.Name = "navArqueoCaja";
            this.navArqueoCaja.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navArqueoCaja_LinkClicked);
            // 
            // navDistribucionResidencial
            // 
            this.navDistribucionResidencial.Appearance.Options.UseTextOptions = true;
            this.navDistribucionResidencial.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.navDistribucionResidencial.Caption = "Distribucion por Zona Residencial";
            this.navDistribucionResidencial.ImageOptions.SmallImage = global::ERP_INTECOLI.Properties.Resources.ruptura_x32;
            this.navDistribucionResidencial.Name = "navDistribucionResidencial";
            this.navDistribucionResidencial.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navDistribucionResidencial_LinkClicked);
            // 
            // navBarGroup4
            // 
            this.navBarGroup4.Caption = "Recordatorios";
            this.navBarGroup4.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navNuevoRecordatorio)});
            this.navBarGroup4.Name = "navBarGroup4";
            // 
            // navNuevoRecordatorio
            // 
            this.navNuevoRecordatorio.Caption = "Nuevo Recordatorio";
            this.navNuevoRecordatorio.ImageOptions.SmallImage = global::ERP_INTECOLI.Properties.Resources.recordatorio_x32;
            this.navNuevoRecordatorio.Name = "navNuevoRecordatorio";
            this.navNuevoRecordatorio.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navNuevoRecordatorio_LinkClicked);
            // 
            // navBarGroup5
            // 
            this.navBarGroup5.Caption = "Matenimientos";
            this.navBarGroup5.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBfrmCursos),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbConfig_PuntoVenta)});
            this.navBarGroup5.Name = "navBarGroup5";
            // 
            // navBfrmCursos
            // 
            this.navBfrmCursos.Caption = "Cursos";
            this.navBfrmCursos.ImageOptions.SmallImage = global::ERP_INTECOLI.Properties.Resources.ensenando_x32;
            this.navBfrmCursos.Name = "navBfrmCursos";
            this.navBfrmCursos.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBfrmCursos_LinkClicked);
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "Documentos Fiscales";
            this.navBarItem2.Name = "navBarItem2";
            this.navBarItem2.Visible = false;
            // 
            // nbConfig_PuntoVenta
            // 
            this.nbConfig_PuntoVenta.Caption = "Punto de Venta Config";
            this.nbConfig_PuntoVenta.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbConfig_PuntoVenta.ImageOptions.SmallImage")));
            this.nbConfig_PuntoVenta.Name = "nbConfig_PuntoVenta";
            this.nbConfig_PuntoVenta.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbConfig_PuntoVenta_LinkClicked);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.lblServerName});
            this.statusStrip1.Location = new System.Drawing.Point(221, 737);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(693, 22);
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
            // navBarAcessosUsuario
            // 
            this.navBarAcessosUsuario.Caption = "Acceso de Usuarios";
            this.navBarAcessosUsuario.Name = "navBarAcessosUsuario";
            this.navBarAcessosUsuario.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarAcessosUsuario_LinkClicked);
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
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
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
        private DevExpress.XtraNavBar.NavBarItem navGeneros;
        private DevExpress.XtraNavBar.NavBarItem navSeguimientoSaldos;
        private DevExpress.XtraNavBar.NavBarItem navEstudiantesDeshabilitados;
        private DevExpress.XtraNavBar.NavBarItem navTiposPagoEstudiane;
        private DevExpress.XtraNavBar.NavBarItem navIngresosTool;
        private DevExpress.XtraNavBar.NavBarItem navSaldoAcumulado;
        private DevExpress.XtraNavBar.NavBarItem navRangosPago;
        private DevExpress.XtraNavBar.NavBarItem navArqueoCaja;
        private DevExpress.XtraNavBar.NavBarItem navDistribucionResidencial;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup4;
        private DevExpress.XtraNavBar.NavBarItem navNuevoRecordatorio;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup5;
        private DevExpress.XtraNavBar.NavBarItem navBfrmCursos;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarSeparatorItem navBarSeparatorItem4;
        private DevExpress.XtraNavBar.NavBarSeparatorItem navBarSeparatorItem5;
        private DevExpress.XtraNavBar.NavBarItem nb_FacturaCore;
        private DevExpress.XtraNavBar.NavBarItem nb_facturasEmitidas;
        private DevExpress.XtraNavBar.NavBarItem nbEstadoCuenta;
        private DevExpress.XtraNavBar.NavBarItem nbCrearAutorizacionesSolicitudes;
        private DevExpress.XtraNavBar.NavBarItem nbPagoMultiple;
        private DevExpress.XtraNavBar.NavBarItem nbNotasCredito;
        private DevExpress.XtraNavBar.NavBarItem nbCierreCaja;
        private DevExpress.XtraNavBar.NavBarItem nbConfig_PuntoVenta;
        private DevExpress.XtraNavBar.NavBarItem navBarAcessosUsuario;
    }
}