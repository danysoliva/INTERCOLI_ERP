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
using ERP_INTECOLI.Mantenimiento;
using DevExpress.XtraGrid.Views.Grid;
using ERP_INTECOLI.Clases;
using System.Data.SqlClient;

namespace ERP_INTECOLI.Mantenimiento.Proveedor
{
    public partial class frmProveedorCRUD : DevExpress.XtraEditors.XtraForm
    {
        private UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();
        private TipoOperacion TipoEdit;
        private int IdProveedor = 0;
        public enum TipoOperacion
        {
            Nuevo = 1,
            Editar = 2
        }

        public frmProveedorCRUD(UserLogin pUserLogin, TipoOperacion pTipo, int Pid_proveedor)
        {
            InitializeComponent();
            UsuarioLogeado = pUserLogin;
            TipoEdit = pTipo;
            IdProveedor = Pid_proveedor;

            switch (TipoEdit)
            {
                case TipoOperacion.Nuevo:

                    lblTS.Visible = false;
                    tsHabilitado.Visible = false;

                    break;

                case TipoOperacion.Editar:
                    lblOperacion.Text = "Editar Proveedor";

                    ERP_INTECOLI.Clases.Proveedor prov = new Clases.Proveedor();
                    prov.RecuperarRegistro(IdProveedor);
                    IdProveedor = prov.ID;
                    txtCodigo.Text = prov._codigo;
                    txtDescripcion.Text = prov._nombre;
                    txtRTN.Text = prov._RTN;
                    txtDireccion.Text = prov._direccion;
                    txtContacto.Text = prov.Contacto;
                    txtTelefono.Text = prov.Telefono1;
                    if (prov._enable)
                        tsHabilitado.IsOn = true;
                    else
                        tsHabilitado.IsOn = false;



                    break;

                default:

                    break;
            }
        }

     

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                CajaDialogo.Error("No puede dejar este campo vacio!");
                txtDescripcion.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtRTN.Text))
            {
                CajaDialogo.Error("No puede dejar este campo vacio!");
                txtRTN.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                CajaDialogo.Error("No puede dejar este campo vacio!");
                txtDireccion.Focus();
                return;
            }

            switch (TipoEdit)
            {
                case TipoOperacion.Nuevo:
                 

                    try
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("[sp_proveedor_insert]", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nombre",txtDescripcion.Text);
                        cmd.Parameters.AddWithValue("@RTN",txtRTN.Text.Trim());
                        cmd.Parameters.AddWithValue("@direccion",txtDireccion.Text);
                        cmd.Parameters.AddWithValue("@FechaCreacion", dp.Now());
                        if (string.IsNullOrEmpty(txtContacto.Text))
                            cmd.Parameters.AddWithValue("@contacto", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@contacto", txtContacto.Text);
                        if(string.IsNullOrEmpty(txtTelefono.Text))
                            cmd.Parameters.AddWithValue("@telefono", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        CajaDialogo.Information("Transaccion Exitosa!");
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
                        SqlCommand cmd = new SqlCommand("[sp_proveedor_update]", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_prov", IdProveedor);
                        cmd.Parameters.AddWithValue("@nombre", txtDescripcion.Text);
                        cmd.Parameters.AddWithValue("@RTN", txtRTN.Text.Trim());
                        cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                        cmd.Parameters.AddWithValue("@habilitado", tsHabilitado.IsOn);
                        cmd.Parameters.AddWithValue("@FechaModi", dp.Now());
                        cmd.Parameters.AddWithValue("@usuario_id_modi", UsuarioLogeado.Id);
                        if (string.IsNullOrEmpty(txtContacto.Text))
                            cmd.Parameters.AddWithValue("@contacto", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@contacto", txtContacto.Text);
                        if (string.IsNullOrEmpty(txtTelefono.Text))
                            cmd.Parameters.AddWithValue("@telefono", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        CajaDialogo.Information("Transaccion Exitosa!");
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