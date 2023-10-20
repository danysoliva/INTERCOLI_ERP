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


namespace ERP_INTECOLI.Usuarios
{
    public partial class frmManVentanasOP : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        int id_ventana;
        int IdSiguiente;
        public enum TipoAccion
        {
            nuevo = 0,
            editar = 1
        }

        TipoAccion Tipo = new TipoAccion();

        public frmManVentanasOP(TipoAccion pTipo,int pidVentana)
        {
            InitializeComponent();

            Tipo = pTipo;

            switch (Tipo)
            {
                case TipoAccion.nuevo:
                    Cargar_Datos();

                    break;
                case TipoAccion.editar:
                    labelControl1.Visible = true;
                    tsHabilitado.Visible = true;
                    id_ventana = pidVentana;
                    CargarDatosVentanaFromID(id_ventana);


                    break;
                default:
                    break;
            }

        }

        private void Cargar_Datos()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                string sql = "sp_cargar_codigo_siguiente_ventana";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    IdSiguiente = dr.GetInt32(0);
                    txtCodigo.Text = dr.GetString(1);
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void CargarDatosVentanaFromID(int pIdVentana)
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                string sql = @"SELECT      [nombre]
                                          ,[codigo]
                                          ,[descripcion]
                                          ,[habilitada]
                                      FROM [dbo].[conf_ventanas] vv
                                      where vv.id_ventana = " + pIdVentana.ToString();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtNombre.Text = dr.GetString(0);
                    txtCodigo.Text = dr.GetString(1);
                    txtDescripcion.Text = dr.GetString(2);
                    tsHabilitado.IsOn = dr.GetBoolean(3);
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                CajaDialogo.Error("No puede dejar vacio este campo!");
                txtNombre.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                CajaDialogo.Error("No puede dejar vacio este campo!");
                txtCodigo.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                CajaDialogo.Error("No puede dejar vacio este campo!");
                txtDescripcion.Focus();
                return;
            }

            switch (Tipo)
            {
                case TipoAccion.nuevo:

                    try
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("sp_usuarios_insert_ventana", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim());
                        cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text.Trim());
                        cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text.Trim());
                        cmd.Parameters.AddWithValue("@id_siguiente", IdSiguiente);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception EX)
                    {
                        CajaDialogo.Error(EX.Message);
                    }

                    CajaDialogo.Information("Permiso Creado con Exito");
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                    break;
                case TipoAccion.editar:

                    try
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("sp_usuarios_update_ventana", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim());
                        cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text.Trim());
                        cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text.Trim());
                        if (tsHabilitado.IsOn == true)
                            cmd.Parameters.AddWithValue("@habilitado", 1);
                        else
                            cmd.Parameters.AddWithValue("@habilitado", 0);
                        cmd.Parameters.AddWithValue("@id_ventana", id_ventana);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception EX)
                    {
                        CajaDialogo.Error(EX.Message);
                    }

                    CajaDialogo.Information("Permiso Creado con Exito");
                    this.DialogResult = DialogResult.OK;
                    this.Close();


                    break;
                default:
                    break;
            }

            

            


        }
    }
}