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
using System.Data.SqlClient;
using ERP_INTECOLI.Clases;
using System.Collections;
using ERP_INTECOLI.Administracion.Empresas;
using DevExpress.XtraGrid.Views.Grid;

namespace ERP_INTECOLI.Administracion.Empresas
{
    public partial class frmCRUDEmpresa : DevExpress.XtraEditors.XtraForm
    {
        private UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();
        private TipoOperacion TipoEdit;
        private int IdEmpresa = 0;

        public enum TipoOperacion
        {
            Nuevo = 1,
            Editar = 2
        }
        

        public frmCRUDEmpresa(UserLogin pUserLogin, TipoOperacion pTipo, int Pid_empresa)
        {
            InitializeComponent();
            UsuarioLogeado = pUserLogin;
            TipoEdit = pTipo;
            IdEmpresa = Pid_empresa;

            switch (TipoEdit)
            {
                case TipoOperacion.Nuevo:

                    lblTS.Visible = false;
                    tsHabilitado.Visible = false;

                    break;

                case TipoOperacion.Editar:
                    lblOperacion.Text = "Editar Empresa";

                    CargarInfo(IdEmpresa);


                    break;
    
                default:

                    break;
            }

        }

        private void CargarInfo(int pidempresa)
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_empresa_for_id", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_empresa", pidempresa);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtEmpresa.Text = dr.GetString(0);
                    txtRTN.Text = dr.GetString(1);
                    txtDireccion.Text = dr.GetString(2);
                    txtTelefono.Text = dr.GetString(3);
                    tsHabilitado.IsOn = dr.GetBoolean(4);
                    dr.Close();
                }
                conn.Close();
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

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmpresa.Text))
            {
                CajaDialogo.Error("No puede dejar vacio este campo!");
                txtEmpresa.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtRTN.Text))
            {
                CajaDialogo.Error("No puede dejar vacio este campo!");
                txtRTN.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtTelefono.Text) )
            {
                CajaDialogo.Error("No puede dejar vacio este campo!");
                txtTelefono.Focus();
                return;
            }

            switch (TipoEdit)
            {
                case TipoOperacion.Nuevo:

                    try
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("sp_get_empresa_insert", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nombre",txtEmpresa.Text);
                        cmd.Parameters.AddWithValue("@rtn",txtRTN.Text);
                        cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                        cmd.Parameters.AddWithValue("@telefono",txtTelefono.Text);
                        cmd.Parameters.AddWithValue("@enable", 1);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception EX)
                    {
                        CajaDialogo.Error(EX.Message);
                    }

                    break;
                case TipoOperacion.Editar:

                    try
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("sp_get_empresa_update", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_empresa", IdEmpresa);
                        cmd.Parameters.AddWithValue("@nombre", txtEmpresa.Text);
                        cmd.Parameters.AddWithValue("@rtn", txtRTN.Text);
                        cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                        cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                        if (tsHabilitado.IsOn)
                            cmd.Parameters.AddWithValue("@enable", 1);
                        else
                            cmd.Parameters.AddWithValue("@enable", 0);

                        cmd.ExecuteNonQuery();

                        conn.Close();

                        this.DialogResult = DialogResult.OK;
                        this.Close();

                    }
                    catch (Exception EX)
                    {
                        CajaDialogo.Error(EX.Message);
                    }

                    break;
                default:
                    break;

                    
            }
        }
    }
}