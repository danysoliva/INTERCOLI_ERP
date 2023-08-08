﻿using DevExpress.XtraEditors;
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

using System.Data.SqlClient;
using JAGUAR_APP;

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
    }
}