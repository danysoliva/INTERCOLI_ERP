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
        }

        private void navBarEstudiantes_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmEstudiantesGroup frm1 = new frmEstudiantesGroup(this.UsuarioLogeado);
            if (frm1 != null)
            {
                frm1.MdiParent = this;
                try
                {
                    frm1.Show();
                }
                catch 
                {
                }
            }
        }

        private void navBarInstructor_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
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

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
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

        private void navMatricula_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //FALTA PERMISO DE ACCESO 
            frmMatriculaReal mtx = new frmMatriculaReal(this.UsuarioLogeado);
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

        private void navDesconectar_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            DialogResult r = CajaDialogo.Pregunta("Esta seguro que desea salir del Sistema?");
            if (r != System.Windows.Forms.DialogResult.Yes)
                return;

            Application.Exit();
        }

        private void navCRUDPermisos_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (UsuarioLogeado.Super_user)
            {
                frmMantVentanas frm = new frmMantVentanas();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                CajaDialogo.Error("No tiene Autorizacion\nSolo los Super Usuarios pueden Acceder a esta Ventana.");
            }
        }

        private void navConsultaMatriculado_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmConsultarMatriculados mtx = new frmConsultarMatriculados(this.UsuarioLogeado);
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

        private void navNotificacionesManuales_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

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

        private void NavBarProyeccionCobros_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //aqui van permisos
            frmSaldosAjustados frm = new frmSaldosAjustados(this.UsuarioLogeado);
            frm.MdiParent = this;
            frm.Show();
        }

        private void navBarMiemborsClases_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
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

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
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

        private void navGeneros_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
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

        private void navSeguimientoSaldos_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
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

        private void navEstudiantesDeshabilitados_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmConsultaAnulados frm = new frmConsultaAnulados();
            frm.MdiParent = this;
            frm.Show();
        }

        private void navTiposPagoEstudiane_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmConsultaTipoPago mtx = new frmConsultaTipoPago();
            if (mtx != null)
            {
                mtx.MdiParent = this;
                mtx.Show();
            }
        }
    }
}