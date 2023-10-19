using DevExpress.XtraEditors;
using ERP_INTECOLI.Clases;
using JAGUAR_APP.Facturacion.Mantenimientos.Models;
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
using static ERP_INTECOLI.Clases.DataOperations;

namespace JAGUAR_APP.Facturacion.Mantenimientos
{
    public partial class xfrmClienteEmpresas : DevExpress.XtraEditors.XtraForm
    {
        int countRecords = 0;
        int tipoTransaccion = 0;
        ClienteEmpresa empresa2 = new ClienteEmpresa();
        public xfrmClienteEmpresas(int pCountRecords,int pTipoTransaccion)
        {
            InitializeComponent();
            CargaTipoContacto();
            countRecords = pCountRecords;
            tipoTransaccion = pTipoTransaccion;

        }


        public xfrmClienteEmpresas(ClienteEmpresa empresa, int pTipoTransaccion)
        {
            InitializeComponent();
            CargaTipoContacto();
            tipoTransaccion = pTipoTransaccion;
            empresa2 = empresa;
        }

        void CargaTipoContacto()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP))
                {
                    cnx.Open();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.usp_GetTipoContactoEmpresa",cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    dsMantenimientosFacturacion.TipoContacto.Clear();

                    da.Fill(dsMantenimientosFacturacion.TipoContacto);
                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                
                 CajaDialogo.Error( ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

           public ClienteEmpresa empresa = new ClienteEmpresa();
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                switch (tipoTransaccion)
                {
                    case (int)TipoTransaccionesCRUD.Nuevo:
                        empresa.Codigo = txtCodigo.Text;
                        empresa.NombreLargo = txtNombre.Text;
                        empresa.NombreCorto  = txtNombreCorto.Text;
                        empresa.RTN = txtRTN.Text;
                        empresa.Direccion = txtDireccion.Text;
                        empresa.Correo = txtCorreo.Text;
                        empresa.Telefono = txtTelefono.Text;
                        this.DialogResult = DialogResult.OK;
                        break;

                    case (int)TipoTransaccionesCRUD.Editar:

                        DataOperations dp = new DataOperations();

                        SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP);

                        using (SqlCommand cmd = new SqlCommand("uspUpdateClienteEmpresa", cnx))
                        {
                            cnx.Open();

                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@NombreLargo", SqlDbType.VarChar).Value = txtNombre.Text;
                            cmd.Parameters.Add("@NombreCorto", SqlDbType.VarChar).Value = txtNombreCorto.Text;
                            cmd.Parameters.Add("@RTN", SqlDbType.VarChar).Value = txtRTN.Text;
                            cmd.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = txtDireccion.Text;
                            cmd.Parameters.Add("@Correo", SqlDbType.VarChar).Value = txtCorreo.Text;
                            cmd.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = txtTelefono.Text;
                            cmd.Parameters.Add("@IdEmpresa", SqlDbType.Int).Value = empresa2.Id;

                            cmd.ExecuteNonQuery();
                            CajaDialogo.Information("Datos Actualizados");
                            cnx.Close();
                            this.DialogResult = DialogResult.OK;
                        }

                        empresa.Codigo = txtCodigo.Text;
                        empresa.NombreLargo = txtNombre.Text;
                        empresa.NombreCorto = txtNombreCorto.Text;
                        empresa.RTN = txtRTN.Text;
                        empresa.Direccion = txtDireccion.Text;
                        empresa.Telefono = txtTelefono.Text;
                        empresa.Correo = txtCorreo.Text;

                        break;
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void xfrmClienteEmpresas_Load(object sender, EventArgs e)
        {
            if (tipoTransaccion==(int)TipoTransaccionesCRUD.Nuevo)
            {
                ObtenerCorrelativo();
            }
            else
            {


                txtCodigo.Text = empresa2.Codigo;
                 txtNombre.Text= empresa2.NombreLargo ;
                 txtNombreCorto.Text = empresa2.NombreCorto;
                txtRTN.Text = empresa2.RTN;
                 txtDireccion.Text= empresa2.Direccion;
                 txtTelefono.Text =empresa2.Telefono;
                txtCorreo.Text = empresa2.Correo;
               
            }
        }

        private void ObtenerCorrelativo()
        {
            string sql = @"SELECT id_siguiente FROM dbo.LOSA_tables_id
                            WHERE id = 14";
            DataOperations dp = new DataOperations();

            SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP);
            cnx.Open();
            SqlCommand cmd = new SqlCommand(sql, cnx);
            int id_siguiente=(int) cmd.ExecuteScalar();
            cnx.Close();
            txtCodigo.Text = "EMP" + (id_siguiente + countRecords).ToString().PadLeft(3, '0');

        }
    }
}