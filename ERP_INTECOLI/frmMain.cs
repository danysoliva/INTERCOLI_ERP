using Core.Clases.Herramientas;
using DevExpress.Utils.TouchHelpers;
using DevExpress.XtraReports.UI;
using ERP_INTECOLI;
using ERP_INTECOLI.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAGUAR_APP
{
    public partial class frmMain : Form
    {
        public UserLogin user1;
        public delegate void LogeadoEvent(int id_usuario);
        public event LogeadoEvent LogeadoComplete;

        //int IdUser;
        public frmMain()
        {
            InitializeComponent();
            //TouchKeyboardSupport.EnableTouchKeyboard = true ;
            //TouchKeyboardSupport.CheckEnableTouchSupport(this);


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //LogeadoComplete(0);
            this.Close();
        }

        private void cmdButtonSaltarLogin_Click(object sender, EventArgs e)
        {
            Teclado.cerrarTeclado();
            UserLogin Log1 = new UserLogin();
            if (Log1.RecuperarRegistro(1067))
            {
                Log1.GrupoUsuario.GrupoUsuarioActivo = (GrupoUser.GrupoUsuario)Log1.IdGrupo;
            }
            else
            {
                Log1.Id = 1067;
                //Log1.GrupoUsuario.GrupoUsuarioActivo = GrupoUser.GrupoUsuario.Produccion;
            }
            
            //frmOpciones frm = new frmOpciones(Log1);
            //frm.MdiParent = this.MdiParent;
            //frm.WindowState = FormWindowState.Maximized;
            //frm.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            #region Codigo ALOSY
            ////login
            //string user;
            //string pass;
            //string domian;
            //if (txtUsuario.Text != "")
            //{
            //    user = txtUsuario.Text;
            //}
            //else
            //{
            //    // MessageBox.Show("Usuario Vacio.");
            //    frmMensaje frm = new frmMensaje( frmMensaje.TipoMsj.error, "No puede dejar el usuario vacio!");
            //    frm.StartPosition = FormStartPosition.CenterScreen;
            //    frm.ShowDialog();
            //    return;
            //}
            //if (txtClave.Text != "")
            //{
            //    pass = txtClave.Text;
            //}
            //else
            //{
            //    //MessageBox.Show("Contraseña Vacia.");
            //    frmMensaje frm = new frmMensaje(frmMensaje.TipoMsj.error, "No puede dejar la contraseña vacia!");
            //    frm.StartPosition = FormStartPosition.CenterScreen;
            //    frm.MdiParent = this;
            //    frm.ShowDialog();
            //    return;
            //}

            //Security sc = new Security();
            //domian = "AQUAFEEDHN";
            //if (sc.Validate_Account(domian, user, pass))
            //{

            //    //MessageBox.Show("Exito");
            //    DataOperations dp = new DataOperations();
            //    SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);

            //    int TiempoP = 300;
            //    //administracion.Huellas.frmProcesando frmProceso = new administracion.Huellas.frmProcesando();
            //    SplashForm frmProceso = new SplashForm();
            //    try
            //    {
            //        con.Open();
            //    }
            //    catch (Exception ec)
            //    {
            //        MessageBox.Show(ec.Message);
            //    }

            //    frmProceso.ShowDialog();
            //    Thread.Sleep(TiempoP);
            //    frmProceso.Close();

            //    //Teclado.cerrarTeclado();
            //    UserLogin Log1 = new UserLogin();
            //    if (Log1.RecuperarRegistroFromUser(user))
            //    {
            //        Log1.Pass = txtClave.Text;
            //        Log1.GrupoUsuario.GrupoUsuarioActivo = (GrupoUser.GrupoUsuario)Log1.IdGrupo;
            //        frmOpciones frm = new frmOpciones(Log1);
            //        if (this.MdiParent != null)
            //            frm.MdiParent = this.MdiParent;

            //        frm.Show();

            //        this.DialogResult = System.Windows.Forms.DialogResult.OK;
            //    }
            //    else
            //    {
            //        CajaDialogo.Error("Usuario No encontrado en AQFSVR003!");
            //    }
            //}
            //else
            //{
            //    //MessageBox.Show("Datos de login incorrectos!");
            //    frmMensaje frm = new frmMensaje(frmMensaje.TipoMsj.error, "Usuario y contraseña son invalidos!");
            //    frm.StartPosition = FormStartPosition.CenterScreen;
            //    frm.ShowDialog();
            //}
            ////Select del grupo al que pertenece el usuario
            ////Iniciar la variable de sesion con el grupo activo.
            
            #endregion
            ValidateUserInfo();
        }

        

        private void ValidateUserInfo()
        {
            UserLogin user = new UserLogin();
            string usuario = user.EncrypPassword("01ultra_instinct_2023");//Users.EncrypPassword("Nutreco"); 
            if (user.RecuperarRegistroUsuario(txtUsuario.Text))
            {
                if (!user.Habilitado)
                {
                    CajaDialogo.Information("Este usuario no esta habilitado o no existe!");
                    return;
                }


                if (user.DecryptPassword(user.Password) == txtClave.Text)
                {
                    try
                    {
                        SqlConnection xconn = new SqlConnection();
                        DataOperations dp = new DataOperations();
                        xconn.ConnectionString = dp.ConnectionStringERP;
                        xconn.Open();

                        user.conn = xconn;
                        user1 = user;


                        frmOpciones frm = new frmOpciones(user1);
                        //if (this.MdiParent != null)
                        frm.MdiParent = this.MdiParent;
                        //frm.WindowState = FormWindowState.Maximized;
                        frm.Show();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                        //LogeadoComplete(user.Id);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error("No se pudo abrir la connexion a la base de datos!\nError: " + ex.Message);
                    }
                }
                else
                {
                    CajaDialogo.Error("Contraseña Incorrecta!");
                    txtClave.Text = "";
                    txtClave.Focus();
                }
            }
            else
            {
                CajaDialogo.Error("No se pudo encontrar el usuario que usted ingreso, favor revise bien el alias de usuario.");
                txtUsuario.Focus();
            }
        }


        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            //Teclado.abrirTeclado();
        }

        private void frmMain_Click(object sender, EventArgs e)
        {
            //Teclado.cerrarTeclado();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Teclado.cerrarTeclado();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {
            //Teclado.cerrarTeclado();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {
            //Teclado.cerrarTeclado();
        }

        private void txtClave_Enter(object sender, EventArgs e)
        {
            Teclado.abrirTeclado();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblVersion.Text = AssemblyVersion;
            string HostName = Dns.GetHostName();
            if (HostName == "7L12TV3" || HostName == "F3DYSQ2" /*Danys Oliva*/ || 
                HostName == "9SSCBV2" || HostName == "6G1SST3" /*Ruben Garcia */ || 
                HostName == "F9Q11Q2" /*PC Soporte La 50*/|| 
                HostName == "DESKTOP-U63MQ6A" || //Maquina virtual 
                HostName == "EUCEDA-PC" /*Euceda*/)
            {
                cmdIngresarAdmin.Visible = SaltarLogin.Visible = simpleButton2.Visible = SaltarLoginPRD.Visible = true;
            }
            else
            {
                cmdIngresarAdmin.Visible = SaltarLogin.Visible = simpleButton2.Visible = SaltarLoginPRD.Visible = false;
            }
        }
        public string AssemblyVersion
        {
            get
            {
                //return ApplicationDeployment.CurrentDeployment.CurrentVersion;
                //return Application.ProductVersion;
                //System.Version version2 = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
                //return version2;
                if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
                {
                    Version ver = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion;
                    //return string.Format("Product Name: {4}, Version: {0}.{1}.{2}.{3}", ver.Major, ver.Minor, ver.Build, ver.Revision, Assembly.GetEntryAssembly().GetName().Name);
                    return string.Format("Product Name: {4}, Version: {0}.{1}.{2}.{3}", ver.Major, ver.Minor, ver.Build, ver.Revision, "ERP SUCCESS ACADEMY ENGLISH");
                }
                else
                {
                    var ver = Assembly.GetExecutingAssembly().GetName().Version;
                    //return string.Format("Product Name: {4}, Version: {0}.{1}.{2}.{3}", ver.Major, ver.Minor, ver.Build, ver.Revision, Assembly.GetEntryAssembly().GetName().Name);
                    return string.Format("Product Name: {4}, Version: {0}.{1}.{2}.{3}", ver.Major, ver.Minor, ver.Build, ver.Revision, "ERP SUCCESS ACADEMY ENGLISH");
                }
            }
        }
        private void txtClave_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                simpleButton2_Click(new object(), new EventArgs());
            }
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            Teclado.cerrarTeclado();
            UserLogin Log1 = new UserLogin();
            if (Log1.RecuperarRegistro(1069))
            {
                Log1.GrupoUsuario.GrupoUsuarioActivo = (GrupoUser.GrupoUsuario)Log1.IdGrupo;
            }
            //else
            //{
            //    Log1.Id = 1069;
            //    Log1.GrupoUsuario.GrupoUsuarioActivo = GrupoUser.GrupoUsuario.Produccion;
            //}                                                                
            //frmOpciones frm = new frmOpciones(Log1);
            //frm.MdiParent = this.MdiParent;
            //frm.WindowState = FormWindowState.Maximized;
            //frm.Show();
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtClave.Focus();
            }
        }

        private void SaltarLogin_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "rgarcia";
            txtClave.Text = "Marathones00";
            simpleButton2_Click(sender, e);
            //Teclado.cerrarTeclado();
            //UserLogin Log1 = new UserLogin();
            //if (Log1.RecuperarRegistro(1035))
            //{
            //    //Log1.GrupoUsuario.GrupoUsuarioActivo = (GrupoUser.GrupoUsuario)Log1.IdGrupo;
            //    //Log1.GrupoUsuario.GrupoUsuarioActivo = (GrupoUser.GrupoUsuario)1;
            //    Log1.GrupoUsuario.GrupoUsuarioActivo = GrupoUser.GrupoUsuario.Logistica;
            //}
            //else
            //{
            //    Log1.Id = 1069;
            //    Log1.GrupoUsuario.GrupoUsuarioActivo = GrupoUser.GrupoUsuario.Calidad;
            //}
            //frmOpciones frm = new frmOpciones(Log1);
            //frm.MdiParent = this.MdiParent;
            //frm.WindowState = FormWindowState.Maximized;
            //frm.Show();
        }

        private void cmdMicros_Click(object sender, EventArgs e)
        {
            //frmOpcionesMicro frm = new frmOpcionesMicro();
            //frm.MdiParent = this.MdiParent;
            //frm.WindowState = FormWindowState.Maximized;
            //frm.Show();
            //UserLogin Log1 = new UserLogin();
            //if (Log1.RecuperarRegistro(1067))
            //{
            //    Log1.GrupoUsuario.GrupoUsuarioActivo = (GrupoUser.GrupoUsuario)Log1.IdGrupo;
            //}
            //else
            //{
            //    Log1.Id = 1067;
            //    Log1.GrupoUsuario.GrupoUsuarioActivo = GrupoUser.GrupoUsuario.Produccion;
            //}

            //xfrmMenuMicros menu = new xfrmMenuMicros(Log1);
            //menu.MdiParent = this.MdiParent;
            //menu.Show();

            //this.DialogResult = DialogResult.Cancel; 
            //this.Close();
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            //Teclado.cerrarTeclado();
            //UserLogin Log1 = new UserLogin();
            //if (Log1.RecuperarRegistro(1035))
            //{
            //    Log1.GrupoUsuario.GrupoUsuarioActivo = GrupoUser.GrupoUsuario.Calidad;
            //    Log1.ADuser = "op_tablet";
            //    Log1.Password = "Tempo1234";
            //}
            //else
            //{
            //    Log1.Id = 1067;
            //    Log1.GrupoUsuario.GrupoUsuarioActivo = GrupoUser.GrupoUsuario.Calidad;
            //    Log1.ADuser = "op_tablet";
            //    Log1.Password = "Tempo1234";
            //}

            //frmOpciones frm = new frmOpciones(Log1);
            //frm.MdiParent = this.MdiParent;
            //frm.WindowState = FormWindowState.Maximized;
            //frm.Show();
            //this.Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }

        private void SaltarLoginPRD_Click(object sender, EventArgs e)
        {
            Teclado.cerrarTeclado();
            UserLogin Log1 = new UserLogin();
            if (Log1.RecuperarRegistro(1035))
            {
                //Log1.GrupoUsuario.GrupoUsuarioActivo = (GrupoUser.GrupoUsuario)Log1.IdGrupo;
                //Log1.GrupoUsuario.GrupoUsuarioActivo = (GrupoUser.GrupoUsuario)1;
                //Log1.GrupoUsuario.GrupoUsuarioActivo = GrupoUser.GrupoUsuario.ProduccionV2;
            }
            else
            {
                Log1.Id = 1069;
                //Log1.GrupoUsuario.GrupoUsuarioActivo = GrupoUser.GrupoUsuario.Calidad;
            }
            //frmOpciones frm = new frmOpciones(Log1);
            //frm.MdiParent = this.MdiParent;
            //frm.WindowState = FormWindowState.Maximized;
            //frm.Show();
        }

        private void cmdAbrirTeclado_Click(object sender, EventArgs e)
        {
            Teclado.abrirTeclado();
        }

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
            txtUsuario.Text = "doliva";
            txtClave.Text = "Gto1804";
            ValidateUserInfo();

        }
    }
}
