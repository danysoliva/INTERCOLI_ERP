using ERP_INTECOLI.Clases;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static JAGUAR_APP.Accesos.AccesosUsuarios.xfrmAccesosTemporalesCRUD;

namespace ERP_INTECOLI.Accesos.AccesosUsuarios
{
    public partial class xfrmAccesosTemporalesAdmin : DevExpress.XtraEditors.XtraForm
    {
        UserLogin usuarioLogin;
        public xfrmAccesosTemporalesAdmin(UserLogin pUser)
        {
            InitializeComponent();
            usuarioLogin = pUser;
            LoadAccesos();
            LoadUsers();
        }

        void LoadAccesos()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP))
                {
                    cnx.Open();

                    SqlDataAdapter da = new SqlDataAdapter("ACS.sp_getAccessosTemporales",cnx);

                    //dsAccesos.Accesos_Temporales.Clear();
                    //da.Fill(dsAccesos.Accesos_Temporales);

                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
               
            }
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            try
            {
                //xfrmAccesosTemporalesCRUD form = new xfrmAccesosTemporalesCRUD(usuarioLogin,(int)formCRUD.Nuevo);

                //if (form.ShowDialog()== DialogResult.OK)
                //{
                //    LoadAccesos();
                //}
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xfrmAccesosTemporalesAdmin_Load(object sender, EventArgs e)
        {
            //colusuario.GroupIndex = 1;
        }

        private void btnEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                //var row = (dsAccesos.Accesos_TemporalesRow)gridView1.GetFocusedDataRow();
                //AccesoTemporal acceso = new AccesoTemporal();

                //acceso.UserID = row.id_usuario;
                //acceso.FechaFin = row.fecha_fin;
                //acceso.FechaInicio = row.fecha_inicio;
                //acceso.FechaVinculo = row.fecha_vinculo;

                //xfrmAccesosTemporalesCRUD frm = new xfrmAccesosTemporalesCRUD(Convert.ToInt32(formCRUD.Editar),acceso,usuarioLogin);

                //if (frm.ShowDialog()== DialogResult.OK )
                //{
                //    LoadAccesos();
                //}
                //else
                //{
                //    LoadAccesos();
                //}
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadUsers()
        {
            try
            {
                //DataOperations dp = new DataOperations();

                //using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                //{
                //    cnx.Open();

                //    SqlDataAdapter da = new SqlDataAdapter("ACS.sp_load_user", cnx);
                //    dsAccesos.Usuarios.Clear();

                //    da.Fill(dsAccesos.Usuarios);
                //    cnx.Close();
                //}
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);

            }
        }

        private void gridLookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            //gridView1.ActiveFilterString = "[id_usuario] LIKE '%" + txtNombre.Text + "%'"; //FiltroNombre("DirectorioMedicos.Nombre");
            //gridView1.ActiveFilterString = "[id_usuario] =" + gridLookUpEdit2.EditValue; 
        }
    }
}