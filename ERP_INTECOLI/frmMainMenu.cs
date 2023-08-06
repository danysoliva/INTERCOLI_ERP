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
using System.Data.SqlClient;

namespace ERP_INTECOLI
{
    public partial class frmMainMenu : DevExpress.XtraEditors.XtraForm
    {
        
        UserLogin UsuarioLogeado;

        public frmMainMenu(UserLogin pUserLogin)
        {
            InitializeComponent();
            UsuarioLogeado = pUserLogin;
            
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
    }
}