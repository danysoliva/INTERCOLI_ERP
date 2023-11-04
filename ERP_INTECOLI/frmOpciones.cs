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
using ERP_INTECOLI.Administracion;
using ERP_INTECOLI.Administracion.Consultas;
using ERP_INTECOLI.Administracion.Estudiantes;
using ERP_INTECOLI.Administracion.Matricula;
using ERP_INTECOLI.Administracion.Planilla;
using ERP_INTECOLI.Clases;
using ERP_INTECOLI.Compras;
using ERP_INTECOLI.Consultas.ConsultaMiembros;
using ERP_INTECOLI.Transacciones;

namespace ERP_INTECOLI
{
    public partial class frmOpciones : Form
    {
        UserLogin UsuarioLogeado;

        DataOperations dp = new DataOperations();
        public frmOpciones(UserLogin pUserLogin)
        {
            InitializeComponent();
            UsuarioLogeado = pUserLogin;
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

        private void navMatriculaRapida_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
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

        private void navBarItem58_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmReservaCupoTransaction frm = new frmReservaCupoTransaction(this.UsuarioLogeado);
            frm.MdiParent = this;
            frm.Show();
        }

        private void navEstadoCuentaOld_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmEstadoCuenta frm = new frmEstadoCuenta(this.UsuarioLogeado);
            frm.MdiParent = this;
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

                mtx.MdiParent = this;
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
                    mtx.MdiParent = this;
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
                    mtx.MdiParent = this;
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
                    mtx.MdiParent = this;
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
                    mtx.MdiParent = this;
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
            frm.MdiParent = this;
            frm.Show();
        }

        private void nbMiembrosClase_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
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

        private void nbCumpleanieros_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
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

        private void bnDistribucionGeneros_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
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

        private void bnSeguiSalods_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
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

        private void nbEstudiantesDesh_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmConsultaAnulados frm = new frmConsultaAnulados();
            frm.MdiParent = this;
            frm.Show();
        }

        private void navTiposPago_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmConsultaTipoPago mtx = new frmConsultaTipoPago();
            if (mtx != null)
            {
                mtx.MdiParent = this;
                mtx.Show();
            }
        }

        private void nbNuevosIngresos_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmNuevosIngresos mtx = new frmNuevosIngresos();
            if (mtx != null)
            {
                mtx.MdiParent = this;
                mtx.Show();
            }
        }
    }
}
