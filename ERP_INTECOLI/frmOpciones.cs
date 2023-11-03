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
using ERP_INTECOLI.Administracion.Estudiantes;
using ERP_INTECOLI.Administracion.Matricula;
using ERP_INTECOLI.Administracion.Planilla;
using ERP_INTECOLI.Clases;
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
    }
}
