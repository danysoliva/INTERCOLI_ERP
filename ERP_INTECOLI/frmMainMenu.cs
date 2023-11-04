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
using ERP_INTECOLI.Compras;
using ERP_INTECOLI.Mantenimiento.Productos;
using ERP_INTECOLI.Mantenimiento.Proveedor;

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
            lblServerName.Text = "Server Name: " + Globals.ERP_ServerName + "  DB: " + Globals.ERP_ActiveDB;
            frm = new frmMain();

            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Normal;
            frm.Show();
            UsuarioLogeado = frm.user1;
            this.Text = "ERP - Success English Academy System.  Equipo Actual: " + Dns.GetHostName();
        }


        public frmMainMenu()
        {
            InitializeComponent();
            UsuarioLogeado = new UserLogin();
            lblServerName.Text = "Server Name: " + Globals.ERP_ServerAddress + "  DB: " + Globals.ERP_ActiveDB;
            frm = new frmMain();

            
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Normal;
            frm.Show();
            this.Text = "ERP - Success English Academy System.  Equipo Actual: " + Dns.GetHostName();
        }




        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm1 in this.MdiChildren)
            {
                frm1.Dispose();
            }

            frm = new frmMain();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Normal;
            frm.Show();
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


    }
    
}