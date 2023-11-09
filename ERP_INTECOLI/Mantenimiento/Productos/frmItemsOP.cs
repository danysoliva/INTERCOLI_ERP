using DevExpress.XtraEditors;
using ERP_INTECOLI.Clases;
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

namespace ERP_INTECOLI.Mantenimiento.Productos
{
    public partial class frmItemsOP : DevExpress.XtraEditors.XtraForm
    {
        private UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();
        private TipoOperacion TipoEdit;
        private int IdItems = 0;

        public enum TipoOperacion
        {
            Nuevo = 1,
            Editar = 2
        }


        public frmItemsOP(UserLogin pUserLogin, TipoOperacion pTipo, int pIdITEMS)
        {
            InitializeComponent();
            UsuarioLogeado = pUserLogin;
            TipoEdit = pTipo;
            IdItems = pIdITEMS;

            Load_Tipos_Productos();

            switch (TipoEdit)
            {
                case TipoOperacion.Nuevo:

                    lblTS.Visible = false;
                    tsHabilitado.Visible = false;

                    break;

                case TipoOperacion.Editar:
                    lblOperacion.Text = "Editar Producto";
                    lblItemCode.Visible = true;
                    lblTS.Visible = true;
                    txtItemCode.Visible = true;
                    tsHabilitado.Visible = true;

                    ProductoTerminado pt = new ProductoTerminado();
                    pt.Recuperar_producto(IdItems);
                    txtItemCode.Text = pt.Code;
                    txtDescripcion.Text = pt.Descripcion;
                    grdTipoProducto.EditValue = pt.Tipo_id;
                    if (pt.Id_estado == 1)
                        tsHabilitado.IsOn = true;
                    else
                        tsHabilitado.IsOn = false;
                    

                    break;

                default:

                    break;
            }
        }

        private void Load_Tipos_Productos()
        {

       
            try
            {
                string query = @"sp_get_tipos_productos";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("",);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsMantenimiento1.Tipo_Producto.Clear();
                adat.Fill(dsMantenimiento1.Tipo_Producto);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void CargarInfo(int idItems)
        {
           
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                CajaDialogo.Error("No puede dejar vacio este campo!");
                txtDescripcion.Focus();
                return;
            }

            if (string.IsNullOrEmpty(grdTipoProducto.Text))
            {
                CajaDialogo.Error("Debe seleccionar un Tipo de Procuto!");
                return;
            }

            switch (TipoEdit)
            {
                case TipoOperacion.Nuevo:
                    try
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("sp_productos_insert", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_user_created",UsuarioLogeado.Id);
                        cmd.Parameters.AddWithValue("@id_estado",1);
                        cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                        cmd.Parameters.AddWithValue("@fecha",dp.Now());
                        cmd.Parameters.AddWithValue("@id_tipo_pt", grdTipoProducto.EditValue);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception EX)
                    {
                        CajaDialogo.Error(EX.Message);
                    }

                    CajaDialogo.Information("Producto creado Exitosamente!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    //txtDescripcion.Clear();

                    break;
                case TipoOperacion.Editar:
                    try
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("sp_productos_update", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_items", IdItems);
                        if (tsHabilitado.IsOn)
                            cmd.Parameters.AddWithValue("@id_estado", 1);
                        else
                            cmd.Parameters.AddWithValue("@id_estado", 2);
                        cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                        cmd.Parameters.AddWithValue("@id_tipo_pt", grdTipoProducto.EditValue);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception EX)
                    {
                        CajaDialogo.Error(EX.Message);
                    }

                    CajaDialogo.Information("Producto creado Exitosamente!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                    break;
                default:
                    break;
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}