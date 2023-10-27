using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERP_INTECOLI.Clases;
using ERP_INTECOLI.Administracion.Estudiantes;
using ERP_INTECOLI.Administracion.Instructores;
using ERP_INTECOLI.Administracion.Niveles_Academicos;
using ERP_INTECOLI.Administracion.Matricula;
using ERP_INTECOLI.Usuarios;
using ERP_INTECOLI.Transacciones;
using ERP_INTECOLI.Administracion.Movimientos;
using ERP_INTECOLI.Administracion.Planilla;
using ERP_INTECOLI.Administracion.Caja;
using System.Data.SqlClient;
using JAGUAR_APP;
using ERP_INTECOLI.Administracion.Consultas;
using ERP_INTECOLI.Consultas.ConsultaMiembros;
using ERP_INTECOLI.Consultas;
using ERP_INTECOLI.Consultas.ConsultaMovimientosSaldos;
using ERP_INTECOLI.Consultas.RangosPago;
using ERP_INTECOLI.Administracion.Estadisticas;
using ERP_INTECOLI.Administracion;
using ERP_INTECOLI.Administracion.Cursos;
using static DevExpress.XtraPrinting.Native.ExportOptionsPropertiesNames;
using System.Net;
using ERP_INTECOLI.Facturacion;
using Eatery.Ventas;
using JAGUAR_APP.Facturacion.Mantenimientos;
using ERP_INTECOLI.Accesos.AccesosUsuarios;
using JAGUAR_APP.Facturacion.Numeracion_Fiscal;
using ERP_INTECOLI.Accesos.GrupoLosa;
using ERP_INTECOLI.Administracion.Empresas;

namespace ERP_INTECOLI
{
    public partial class frmMainMenu : DevExpress.XtraEditors.XtraForm
    {
        
        UserLogin UsuarioLogeado;
        frmMain frm;
        
        public frmMainMenu(UserLogin pUserLogin)
        {
            InitializeComponent();
            UsuarioLogeado = pUserLogin;
            xtraTabControlMenu.Visible = false;
            lblServerName.Text = "Server Name: " + Globals.ERP_ServerName + "  DB: " + Globals.ERP_ActiveDB;
            frm = new frmMain();

            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Normal;
            frm.Show();
            UsuarioLogeado = frm.user1;
            this.Text = "ERP - Success English Academy System.  Equipo Actual: " + Dns.GetHostName();
        }

        public void ejecutar(int id)
        {
            if (id > 0)
            {
                UsuarioLogeado.Id = id;
                if (UsuarioLogeado.RecuperarRegistro(id))
                    xtraTabControlMenu.Visible = true;
            }
            else
            {
                xtraTabControlMenu.Visible = false;
            }
        }

        public frmMainMenu()
        {
            InitializeComponent();
            UsuarioLogeado = new UserLogin();
            xtraTabControlMenu.Visible = false;
            lblServerName.Text = "Server Name: " + Globals.ERP_ServerAddress + "  DB: " + Globals.ERP_ActiveDB;
            frm = new frmMain();
            frm.LogeadoComplete += new frmMain.LogeadoEvent(ejecutar);

            
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Normal;
            frm.Show();
            this.Text = "ERP - Success English Academy System.  Equipo Actual: " + Dns.GetHostName();
        }

        private void navBarEstudiantes_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.Id, 12);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar //12 = Success
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = false;
                    break;
                case 3://Medium Autorization
                    accesoprevio = false;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmEstudiantesGroup frm1 = new frmEstudiantesGroup(this.UsuarioLogeado);
                    frm1.MdiParent = this;
                    frm1.Show();

                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(9))
                {
                    frmEstudiantesGroup frm1 = new frmEstudiantesGroup(this.UsuarioLogeado);
                    frm1.MdiParent = this;
                    frm1.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función!\nPermiso Requerido #9 (Gestion de Estudiantes)");
                }
            }
        }

        
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm1 in this.MdiChildren)
            {
                frm1.Dispose();
            }

            frm = new frmMain();
            frm.LogeadoComplete += new frmMain.LogeadoEvent(ejecutar);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Normal;
            frm.Show();
        }



        private void navMatricula_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.Id, 12);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar //12 = Success
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = false;
                    break;
                case 3://Medium Autorization
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmMatriculaReal mtx = new frmMatriculaReal(this.UsuarioLogeado);
                    mtx.MdiParent = this;
                    mtx.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(6)) //Matricula de Alumno
                {
                    frmMatriculaReal mtx = new frmMatriculaReal(this.UsuarioLogeado);
                    mtx.MdiParent = this;
                    mtx.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función!\nPermiso Requerido #6 (Matricula de Alumno)");
                }
            }
        }

        private void navDesconectar_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            DialogResult r = CajaDialogo.Pregunta("Esta seguro que desea salir del Sistema?");
            if (r != System.Windows.Forms.DialogResult.Yes)
                return;

            Application.Exit();
        }



        private void navConsultaMatriculado_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.Id, 12);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar //12 = Success
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = false;
                    break;
                case 3://Medium Autorization
                    accesoprevio = false;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmConsultarMatriculados mtx = new frmConsultarMatriculados(this.UsuarioLogeado);
                    mtx.MdiParent = this;
                    mtx.Show();

                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(7))
                {
                    frmConsultarMatriculados mtx = new frmConsultarMatriculados(this.UsuarioLogeado);
                    mtx.MdiParent = this;
                    mtx.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función!\nPermiso Requerido #7 (Consulta y Edicion de Matricula)");
                }
            }



        }

        private void navPostearMensualidad_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmPostearMensualidad mtx = new frmPostearMensualidad(UsuarioLogeado);
            if (mtx != null)
            {
                //mtx.MdiParent = this;
                try
                {
                    mtx.Show();
                }
                catch { }
                
            }
        }

        private void navMovimientoSaldos_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmMovimientosSaldos frx = new frmMovimientosSaldos(this.UsuarioLogeado);
            if (frx != null)
            {
                frx.MdiParent = this;
                try
                {
                    frx.Show();
                }
                catch (Exception ec)
                { }
            }
        }

        private void navGeneracionPlanilla_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmGeneracionPlanilla mtx = new frmGeneracionPlanilla(this.UsuarioLogeado);
            if (mtx != null)
            {
                
                mtx.MdiParent = this;
                try
                {
                    mtx.Show();
                }
                catch { }
                
            }
        }

   

        private void navCaja_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmCaja mtx = new frmCaja(this.UsuarioLogeado);
            if (mtx != null)
            {
                
                mtx.MdiParent = this;
                try
                {
                    mtx.Show();
                }
                catch { }
                
            }
        }

        private void navFastMatricula_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmFastMatricula mtx = new frmFastMatricula(this.UsuarioLogeado);
            if (mtx != null)
            {

                mtx.MdiParent = this;
                try
                {
                    mtx.Show();
                }
                catch { }

            }
        }

        private void navBarAsistenciaManual_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmAsistenciaManual frm = new frmAsistenciaManual(this.UsuarioLogeado);
            frm.MdiParent = this;
            frm.Show();
        }

        private void navBarEstadoCuenta_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //aqui van permisos
            frmEstadoCuenta frm = new frmEstadoCuenta(this.UsuarioLogeado);
            frm.MdiParent = this;
            frm.Show();
        }

        private void navBarReservaCupo_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmReservaCupoTransaction frm = new frmReservaCupoTransaction(this.UsuarioLogeado);
            frm.MdiParent = this;
            frm.Show();
        }

        private void navNuevoRecordatorio_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmRecordatorio frx = new frmRecordatorio(this.UsuarioLogeado);
            if (frx != null)
            {
                frx.MdiParent = this;
                try
                {
                    frx.Show();
                }
                catch (Exception ec)
                {
                }
            }
        }


        private void nb_FacturaCore_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string HostName = Dns.GetHostName();
            FacturacionEquipo EquipoActual = new FacturacionEquipo();
            PuntoVenta puntoVenta1 = new PuntoVenta();

            if (EquipoActual.RecuperarRegistro(HostName))
            {
                if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
                {
                    CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                return;
            }

            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.Id, 12);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar //12 = Success
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = false;
                    break;
                case 3://Medium Autorization
                    accesoprevio = false;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;

                    frmFactura frm = new frmFactura(this.UsuarioLogeado, puntoVenta1, EquipoActual);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(11))
                {
                    frmFactura frm = new frmFactura(this.UsuarioLogeado, puntoVenta1, EquipoActual);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función!\nPermiso Requerido #11 (Facturacion punto de venta)");
                }
            }
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void nbConfig_PuntoVenta_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            
        }

        private void navBarUsuarios_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            

        }

        private void navBarAcessosUsuario_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            
        }

        private void navAdminUsuarios_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
           



            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.Id, 12);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar //12 = Success
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = false;
                    break;
                case 3://Medium Autorization
                    accesoprevio = false;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmMantenimientoUsuarios msu = new frmMantenimientoUsuarios(this.UsuarioLogeado);
                    msu.MdiParent = this;
                    msu.Show();

                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(1))
                {
                    frmMantenimientoUsuarios msu = new frmMantenimientoUsuarios(this.UsuarioLogeado);
                    msu.MdiParent = this;
                    msu.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función!\nPermiso Requerido #1 (Gestion de Usuarios)");
                }
            }

        }

        private void navPermisosUsuarios_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.Id, 12);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar //12 = Success
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = false;
                    break;
                case 3://Medium Autorization
                    accesoprevio = false;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmMantVentanas frm = new frmMantVentanas();
                    frm.MdiParent = this;
                    frm.Show();

                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(2))
                {
                    frmMantVentanas frm = new frmMantVentanas();
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función!\nPermiso Requerido #VT-02 (Administracion de Niveles de acceso)");
                }
            }


            //if (UsuarioLogeado.Super_user)
            //{
                
            //}
            //else
            //{
            //    CajaDialogo.Error("No tiene Autorizacion\nSolo los Super Usuarios pueden Acceder a esta Ventana.");
            //}
        }

        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.Id, 12);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar //12 = Success
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = false;
                    break;
                case 3://Medium Autorization
                    accesoprevio = false;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    AccesoUsuario frm = new AccesoUsuario(UsuarioLogeado);
                    frm.MdiParent = this;
                    frm.Show();

                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(19))
                {
                    AccesoUsuario frm = new AccesoUsuario(UsuarioLogeado);
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función!\nPermiso Requerido #VT-19 (Niveles de Acceso Usuarios)");
                }
            }


        }

        private void navCrudCursos_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmCursos frm = new frmCursos(this.UsuarioLogeado);
            frm.MdiParent = this;
            frm.Show();
        }

        private void nbConfig_PuntoVenta2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.Id, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = false;
                    break;
                case 3://Medium Autorization
                    accesoprevio = false;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    xfrm_PDV frm = new xfrm_PDV(UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(16))
                {
                    xfrm_PDV frm = new xfrm_PDV(UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función!\nPermiso Requerido #16 (Configuraciones de Facturacion)");
                }
            }
        }

        private void navDocFiscales_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            

            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.Id, 12);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar //12 = Success
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = false;
                    break;
                case 3://Medium Autorization
                    accesoprevio = false;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmNumeracionFiscal frm = new frmNumeracionFiscal(UsuarioLogeado);
                    frm.MdiParent = this;
                    frm.Show();

                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(13))
                {
                    frmNumeracionFiscal frm = new frmNumeracionFiscal(UsuarioLogeado);
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función!\nPermiso Requerido #VT-13 (Mantenimiento Docs Fiscales)");
                }
            }

        }

        private void navNivelesAcademicos_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //FALTA PERMISO DE ACCESO 
            frmNiveles_Academicos mtx = new frmNiveles_Academicos(this.UsuarioLogeado);
            if (mtx != null)
            {
                mtx.MdiParent = this;
                try
                {
                    mtx.Show();
                }
                catch { }

            }
        }

        private void navInstructores_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmBuscarInstructores frx = new frmBuscarInstructores(UsuarioLogeado);
            if (frx != null)
            {
                frx.MdiParent = this;
                try
                {
                    frx.Show();
                }
                catch (Exception ec)
                {
                    Console.WriteLine(ec.Message);
                }
            }
        }

        private void navProyeccionCobros_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //aqui van permisos
            frmSaldosAjustados frm = new frmSaldosAjustados(this.UsuarioLogeado);
            frm.MdiParent = this;
            frm.Show();
        }

        private void navMiembrosClase_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmConsultarMiembroCurso frx = new frmConsultarMiembroCurso(this.UsuarioLogeado);
            if (frx != null)
            {
                frx.MdiParent = this;
                try
                {
                    frx.Show();
                }
                catch (Exception ec)
                { }
            }
        }

        private void navCumpleanios_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmConsultaCumpleanieros frx = new frmConsultaCumpleanieros(this.UsuarioLogeado);
            if (frx != null)
            {
                frx.MdiParent = this;
                try
                {
                    frx.Show();
                }
                catch (Exception ec)
                {
                }
            }
        }

        private void navDistGeneros_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            frmRecuentoGeneros frx = new frmRecuentoGeneros(this.UsuarioLogeado);
            if (frx != null)
            {
                frx.MdiParent = this;
                try
                {
                    frx.Show();
                }
                catch (Exception ec)
                {
                }
            }
        }

        private void navSeguiSaldos_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //aqui van permisos
            frmSeguimientoSaldos mtx = new frmSeguimientoSaldos(this.UsuarioLogeado);
            if (mtx != null)
            {

                mtx.MdiParent = this;
                try
                {
                    mtx.Show();
                }
                catch { }

            }
        }

        private void navEstudiantesDeshabi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmConsultaAnulados frm = new frmConsultaAnulados();
            frm.MdiParent = this;
            frm.Show();
        }

        private void navTipoPagos_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmConsultaTipoPago mtx = new frmConsultaTipoPago();
            if (mtx != null)
            {
                mtx.MdiParent = this;
                mtx.Show();
            }
        }

        private void navNuevosIngresos_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmNuevosIngresos mtx = new frmNuevosIngresos();
            if (mtx != null)
            {
                mtx.MdiParent = this;
                mtx.Show();
            }
        }

        private void navDeudores_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmConsultaEstSaldosCobrables mtx = new frmConsultaEstSaldosCobrables();
            if (mtx != null)
            {
                mtx.MdiParent = this;
                mtx.Show();
            }
        }

        private void navRangosPagos_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.Id, 12);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar //12 = Success
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = false;
                    break;
                case 3://Medium Autorization
                    accesoprevio = false;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmRangosPago mtx = new frmRangosPago();
                    mtx.MdiParent = this;
                    mtx.Show();


                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(17))
                {
                    frmRangosPago mtx = new frmRangosPago();
                    mtx.MdiParent = this;
                    mtx.Show();

                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función!\nPermiso Requerido #VT-17 (Rangos de pagos)");
                }
            }

        }

        private void navArqueoCajas_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmArqueoCaja frm = new frmArqueoCaja(UsuarioLogeado);
            frm.MdiParent = this;
            frm.Show();
        }

        private void navDistribucioZonaResidencial_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmEstadisticasPorResidencia frm = new frmEstadisticasPorResidencia();
            frm.MdiParent = this;
            frm.Show();
        }

       
        private void navGruposUsuarios_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            PrincipalGrupoLosa frm = new PrincipalGrupoLosa();
            frm.MdiParent = this;
            frm.Show();
        }

        private void navCRUDEmpresa_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.Id, 12);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar //12 = Success
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    accesoprevio = false;
                    break;
                case 3://Medium Autorization
                    accesoprevio = false;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmEmpresa mtx = new frmEmpresa(UsuarioLogeado);
                    mtx.MdiParent = this;
                    mtx.Show();


                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(20))
                {
                    frmEmpresa mtx = new frmEmpresa(UsuarioLogeado);
                    mtx.MdiParent = this;
                    mtx.Show();

                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función!\nPermiso Requerido #VT-20 (Gestion de Empresa)");
                }
            }
        }
    }
    
}