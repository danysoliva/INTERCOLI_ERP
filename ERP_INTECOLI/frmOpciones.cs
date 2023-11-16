using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eatery.Ventas;
using ERP_INTECOLI.Accesos.AccesosUsuarios;
using ERP_INTECOLI.Accesos.GrupoLosa;
using ERP_INTECOLI.Administracion;
using ERP_INTECOLI.Administracion.Caja;
using ERP_INTECOLI.Administracion.Consultas;
using ERP_INTECOLI.Administracion.Cursos;
using ERP_INTECOLI.Administracion.Empresas;
using ERP_INTECOLI.Administracion.Estadisticas;
using ERP_INTECOLI.Administracion.Estudiantes;
using ERP_INTECOLI.Administracion.Instructores;
using ERP_INTECOLI.Administracion.Matricula;
using ERP_INTECOLI.Administracion.Niveles_Academicos;
using ERP_INTECOLI.Administracion.Planilla;
using ERP_INTECOLI.Clases;
using ERP_INTECOLI.Compras;
using ERP_INTECOLI.Consultas;
using ERP_INTECOLI.Consultas.ConsultaMiembros;
using ERP_INTECOLI.Consultas.ConsultaMovimientosSaldos;
using ERP_INTECOLI.Consultas.RangosPago;
using ERP_INTECOLI.Facturacion.FacturacionAutomatica;
using ERP_INTECOLI.Mantenimiento.Productos;
using ERP_INTECOLI.Mantenimiento.Proveedor;
using ERP_INTECOLI.Transacciones;
using ERP_INTECOLI.Usuarios;
using JAGUAR_APP;
using JAGUAR_APP.Facturacion.Configuraciones;
using JAGUAR_APP.Facturacion.CoreFacturas;
using JAGUAR_APP.Facturacion.Mantenimientos;
using JAGUAR_APP.Facturacion.Numeracion_Fiscal;
using JAGUAR_APP.Facturacion.Reportes;

namespace ERP_INTECOLI
{
    public partial class frmOpciones : Form
    {
        UserLogin UsuarioLogeado;

        DataOperations dp = new DataOperations();
        public frmOpciones(UserLogin pUser)
        {
            InitializeComponent();
            UsuarioLogeado = pUser;

            int i = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);

            switch (pUser.GrupoUsuario.GrupoUsuarioActivo)
            {
                case GrupoUser.GrupoUsuario.Manager:
                    
                    tabOpciones.TabPages[0].PageVisible = true;
                    tabOpciones.TabPages[1].PageVisible = true;
                    tabOpciones.TabPages[2].PageVisible = true;
                    tabOpciones.TabPages[3].PageVisible = true;
                    tabOpciones.TabPages[4].PageVisible = true;
                    tabOpciones.TabPages[5].PageVisible = true;
                    tabOpciones.SelectedTabPageIndex = 5;
                    break;
                case GrupoUser.GrupoUsuario.Facturacion:
                    break;
                case GrupoUser.GrupoUsuario.Atencion_al_cliente:
                    
                    tabOpciones.TabPages[0].PageVisible = true;
                    tabOpciones.TabPages[1].PageVisible = true;
                    tabOpciones.TabPages[3].PageVisible = true;
                    tabOpciones.SelectedTabPageIndex = 0;
                    break;
                case GrupoUser.GrupoUsuario.Cajero:
                    tabOpciones.TabPages[3].PageVisible = true;
                    tabOpciones.SelectedTabPageIndex = 3;
                    break;
                case GrupoUser.GrupoUsuario.Supervisor:
                    break;
                default:
                    break;
            }
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void navEstudiantes_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
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
                    frm1.MdiParent = this.MdiParent;
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
                    frm1.MdiParent = this.MdiParent;
                    frm1.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función!\nPermiso Requerido #9 (Gestion de Estudiantes)");
                }
            }
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
                    mtx.MdiParent = this.MdiParent;
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
                    mtx.MdiParent = this.MdiParent;
                    mtx.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función!\nPermiso Requerido #6 (Matricula de Alumno)");
                }
            }
        }

        private void navConsultarMatriculas_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
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
                    mtx.MdiParent = this.MdiParent;
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
                    mtx.MdiParent = this.MdiParent;
                    mtx.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función!\nPermiso Requerido #7 (Consulta y Edicion de Matricula)");
                }
            }

        }


        private void navNuevoRecordatorio_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmRecordatorio frx = new frmRecordatorio(this.UsuarioLogeado);
            if (frx != null)
            {
                frx.MdiParent = this.MdiParent;
                try
                {
                    frx.Show();
                }
                catch (Exception ec)
                {
                }
            }
        }

        private void navMatriculaRapida_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmFastMatricula mtx = new frmFastMatricula(this.UsuarioLogeado);
            if (mtx != null)
            {

                mtx.MdiParent = this.MdiParent;
                try
                {
                    mtx.Show();
                }
                catch { }

            }
        }

        private void navBarItem58_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmReservaCupoTransaction frm = new frmReservaCupoTransaction(this.UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void navEstadoCuentaOld_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmEstadoCuenta frm = new frmEstadoCuenta(this.UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void navGeneracionPlanilla_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            
        }

        private void navGeneracionPlanillas_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmGeneracionPlanilla mtx = new frmGeneracionPlanilla(this.UsuarioLogeado);
            if (mtx != null)
            {

                mtx.MdiParent = this.MdiParent;
                try
                {
                    mtx.Show();
                }
                catch { }

            }
        }

        private void navFacturacion_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
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

        private void navComprasSolicitudes_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
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
                    frmSolicitudesMain mtx = new frmSolicitudesMain(UsuarioLogeado, frmSolicitudesMain.TipoOperacion.New);
                    mtx.MdiParent = this.MdiParent;
                    mtx.Show();


                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(21))
                {
                    frmSolicitudesMain mtx = new frmSolicitudesMain(UsuarioLogeado, frmSolicitudesMain.TipoOperacion.New);
                    mtx.MdiParent = this.MdiParent;
                    mtx.Show();

                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función!\nPermiso Requerido #VT-21 (Solicitud de Compras)");
                }
            }
        }

        private void navComprasOrdenes_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
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
                    frmOrdenesCompraMain mtx = new frmOrdenesCompraMain(UsuarioLogeado, frmOrdenesCompraMain.TipoOperacion.New);
                    mtx.MdiParent = this.MdiParent;
                    mtx.Show();


                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(24))
                {
                    frmOrdenesCompraMain mtx = new frmOrdenesCompraMain(UsuarioLogeado, frmOrdenesCompraMain.TipoOperacion.New);
                    mtx.MdiParent = this.MdiParent;
                    mtx.Show();

                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función!\nPermiso Requerido #VT-24 (Ordenes de Compra)");
                }
            }
        }

        private void navProyCobros_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmSaldosAjustados frm = new frmSaldosAjustados(this.UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void nbMiembrosClase_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmConsultarMiembroCurso frx = new frmConsultarMiembroCurso(this.UsuarioLogeado);
            if (frx != null)
            {
                frx.MdiParent = this.MdiParent;
                try
                {
                    frx.Show();
                }
                catch (Exception ec)
                { }
            }
        }

        private void nbCumpleanieros_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmConsultaCumpleanieros frx = new frmConsultaCumpleanieros(this.UsuarioLogeado);
            if (frx != null)
            {
                frx.MdiParent = this.MdiParent;
                try
                {
                    frx.Show();
                }
                catch (Exception ec)
                {
                }
            }
        }

        private void bnDistribucionGeneros_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            frmRecuentoGeneros frx = new frmRecuentoGeneros(this.UsuarioLogeado);
            if (frx != null)
            {
                frx.MdiParent = this.MdiParent;
                try
                {
                    frx.Show();
                }
                catch (Exception ec)
                {
                }
            }
        }

        private void bnSeguiSalods_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmSeguimientoSaldos mtx = new frmSeguimientoSaldos(this.UsuarioLogeado);
            if (mtx != null)
            {

                mtx.MdiParent = this.MdiParent;
                try
                {
                    mtx.Show();
                }
                catch { }

            }
        }

        private void nbEstudiantesDesh_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmConsultaAnulados frm = new frmConsultaAnulados();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void navTiposPago_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmConsultaTipoPago mtx = new frmConsultaTipoPago();
            if (mtx != null)
            {
                mtx.MdiParent = this.MdiParent;
                mtx.Show();
            }
        }

        private void nbNuevosIngresos_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmNuevosIngresos mtx = new frmNuevosIngresos();
            if (mtx != null)
            {
                mtx.MdiParent = this.MdiParent;
                mtx.Show();
            }
        }

        private void navDeudores_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmConsultaEstSaldosCobrables mtx = new frmConsultaEstSaldosCobrables();
            if (mtx != null)
            {
                mtx.MdiParent = this.MdiParent;
                mtx.Show();
            }
        }

        private void navRangosPago_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.Id, 12);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar //12 = Success
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                case 3://Medium Autorization  
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmRangosPago mtx = new frmRangosPago();
                    mtx.MdiParent = this.MdiParent;
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
                    mtx.MdiParent = this.MdiParent;
                    mtx.Show();

                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función!\nPermiso Requerido #VT-17 (Rangos de pagos)");
                }
            }
        }

        private void navArqueoCaja_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Administracion.Caja.frmArqueoCaja frm = new Administracion.Caja.frmArqueoCaja(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void navDistribucionZona_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmEstadisticasPorResidencia frm = new frmEstadisticasPorResidencia();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void navCursos_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            frmCursos frm = new frmCursos(this.UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void nbPuntoVenta_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.Id, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                case 3://Medium Autorization
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

        private void nbDocFiscales_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.Id, 12);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar //12 = Success
            {
                case 1://Basic View
                    accesoprevio = false;
                    break;
                case 2://Basic No Autorization
                    accesoprevio = false;
                    break;
                case 3://Medium Autorization
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmNumeracionFiscal frm = new frmNumeracionFiscal(UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
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
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función!\nPermiso Requerido #VT-13 (Mantenimiento Docs Fiscales)");
                }
            }
        }

        private void bnNivelesAcademicos_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmNiveles_Academicos mtx = new frmNiveles_Academicos(this.UsuarioLogeado);
            if (mtx != null)
            {
                mtx.MdiParent = this.MdiParent;
                try
                {
                    mtx.Show();
                }
                catch { }

            }
        }

        private void bnInstructores_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmBuscarInstructores frx = new frmBuscarInstructores(UsuarioLogeado);
            if (frx != null)
            {
                frx.MdiParent = this.MdiParent;
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

        private void nbEmpresas_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
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
                    accesoprevio = true;
                    frmEmpresa mtx3 = new frmEmpresa(UsuarioLogeado);
                    mtx3.MdiParent = this.MdiParent;
                    mtx3.Show();
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmEmpresa mtx = new frmEmpresa(UsuarioLogeado);
                    mtx.MdiParent = this.MdiParent;
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
                    mtx.MdiParent = this.MdiParent;
                    mtx.Show();

                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función!\nPermiso Requerido #VT-20 (Gestion de Empresa)");
                }
            }
        }

        private void navProductos_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
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
                    frmItemsCRUD mtx = new frmItemsCRUD(UsuarioLogeado);
                    mtx.MdiParent = this.MdiParent;
                    mtx.Show();


                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(21))
                {
                    frmItemsCRUD mtx = new frmItemsCRUD(UsuarioLogeado);
                    mtx.MdiParent = this.MdiParent;
                    mtx.Show();

                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función!\nPermiso Requerido #VT-22 (Gestion de Items)");
                }
            }
        }

        private void nbProveedores_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
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
                    frmProveedorMain mtx = new frmProveedorMain(UsuarioLogeado);
                    mtx.MdiParent = this.MdiParent;
                    mtx.Show();


                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(23))
                {
                    frmProveedorMain mtx = new frmProveedorMain(UsuarioLogeado);
                    mtx.MdiParent = this.MdiParent;
                    mtx.Show();

                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función!\nPermiso Requerido #VT-23 (Gestion de Proveedores)");
                }
            }
        }

        private void navUsuarios_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.Id, 12);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar //12 = Success
            {
                case 1://Basic View
                    accesoprevio = false;
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
                    //msu.MdiParent = this;
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
                    //msu.MdiParent = this.MdiParent;
                    msu.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función!\nPermiso Requerido #1 (Gestion de Usuarios)");
                }
            }
        }

        private void navGestionPerm_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.Id, 12);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar //12 = Success
            {
                case 1://Basic View
                    accesoprevio = false;
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
                    frm.MdiParent = this.MdiParent;
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
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función!\nPermiso Requerido #VT-02 (Administracion de Niveles de acceso)");
                }
            }
        }

        private void navNivelesAccesos_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.Id, 12);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar //12 = Success
            {
                case 1://Basic View
                    accesoprevio = false;
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
                    frm.MdiParent = this.MdiParent;
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
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función!\nPermiso Requerido #VT-19 (Niveles de Acceso Usuarios)");
                }
            }

        }

        private void navGruposUser_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            PrincipalGrupoLosa frm = new PrincipalGrupoLosa();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void navFacturaEmitidas_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
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
                    accesoprevio = false;
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

                    frmHomeFacturasEmitidas frm = new frmHomeFacturasEmitidas(this.UsuarioLogeado, puntoVenta1, EquipoActual);
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
                    frmHomeFacturasEmitidas frm = new frmHomeFacturasEmitidas(this.UsuarioLogeado, puntoVenta1, EquipoActual);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función!\nPermiso Requerido #11 (Facturacion punto de venta)");
                }
            }
        }

        private void navFactEstadoCuente_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
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

                    HomeEstadoCuenta frm = new HomeEstadoCuenta(this.UsuarioLogeado, puntoVenta1, EquipoActual, 0);
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
                    HomeEstadoCuenta frm = new HomeEstadoCuenta(this.UsuarioLogeado, puntoVenta1, EquipoActual, 0);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función!\nPermiso Requerido #11 (Facturacion punto de venta)");
                }
            }
        }

        private void navBarItemListaPrecios_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
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

                    xfrnListaPrecioAdmin frm = new xfrnListaPrecioAdmin(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(26))
                {
                    xfrnListaPrecioAdmin frm = new xfrnListaPrecioAdmin(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función!\nPermiso Requerido #26 (Facturacion punto de venta)");
                }
            }
        }

        private void navSolicitudesAutori_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //frmHomeSolicitudesAutorizacion

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
                    accesoprevio = false;
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

                    frmHomeSolicitudesAutorizacion frm = new frmHomeSolicitudesAutorizacion(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(27))
                {
                    frmHomeSolicitudesAutorizacion frm = new frmHomeSolicitudesAutorizacion(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función!\nPermiso Requerido #27 (Facturacion punto de venta)");
                }
            }
        }

        private void navCierredeCaja_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //frmCierreDiaHome
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
                    accesoprevio = false;
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

                    frmCierreDiaHome frm = new frmCierreDiaHome(this.UsuarioLogeado, puntoVenta1);
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
                    frmCierreDiaHome frm = new frmCierreDiaHome(this.UsuarioLogeado, puntoVenta1);
                    frm.MdiParent = this.MdiParent;
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función!\nPermiso Requerido #11 (Facturacion punto de venta)");
                }
            }
        }

        private void navBarItemConfigFacturaAutomatica_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //frmConfigFacturaEstudianteAuto
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
                    accesoprevio = false;
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

                    frmConfigFacturaEstudianteAuto frm = new frmConfigFacturaEstudianteAuto(this.UsuarioLogeado, puntoVenta1);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(26))
                {
                    frmConfigFacturaEstudianteAuto frm = new frmConfigFacturaEstudianteAuto(this.UsuarioLogeado, puntoVenta1);
                    frm.MdiParent = this.MdiParent;
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función!\nPermiso Requerido #26 (Listas de Precio / Facturacion Automatica)");
                }
            }
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //Historial de facturas generadas por el automatico
            
            //frmConfigFacturaEstudianteAuto
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
                    accesoprevio = false;
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

                    frmFacturasAutomaticasHome frm = new frmFacturasAutomaticasHome(this.UsuarioLogeado, puntoVenta1);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(26))
                {
                    frmFacturasAutomaticasHome frm = new frmFacturasAutomaticasHome(this.UsuarioLogeado, puntoVenta1);
                    frm.MdiParent = this.MdiParent;
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función!\nPermiso Requerido #26 (Listas de Precio / Facturacion Automatica)");
                }
            }
        }

        private void navFacturasProvee_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.Id, 12);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar //12 = Success
            {
                case 1://Basic View
                    accesoprevio = false;
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

                    frmFacturasProveedoresMain frm = new frmFacturasProveedoresMain(this.UsuarioLogeado, frmFacturasProveedoresMain.TipoOperacion.Insert);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(26))
                {
                    frmFacturasProveedoresMain frm = new frmFacturasProveedoresMain(this.UsuarioLogeado, frmFacturasProveedoresMain.TipoOperacion.Insert);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función!\nPermiso Requerido #26 (Listas de Precio / Facturacion Automatica)");
                }
            }
        }
    }
}
