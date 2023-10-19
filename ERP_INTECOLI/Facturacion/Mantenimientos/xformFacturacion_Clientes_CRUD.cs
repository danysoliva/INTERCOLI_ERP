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
using static ERP_INTECOLI.Clases.Conf_TablesID;
using static ERP_INTECOLI.Clases.DataOperations;

namespace JAGUAR_APP.Facturacion.Mantenimientos
{
    public partial class xformFacturacion_Clientes_CRUD : DevExpress.XtraEditors.XtraForm
    {
        public delegate void get_cliente_inserted(int Id_cliente_inserted);
        //public event get_cliente_inserted EventoPasarId_cliente_inserted;
        List<ClienteEmpresa> empresas = new List<ClienteEmpresa>();
        ListToDataTable converterDT = new ListToDataTable();
        //int tipoTransaccion = 0;
        UserLogin usuarioLogeado = new UserLogin();

        Conf_TablesID tableID = new Conf_TablesID();

        public ClienteFacturacion Cliente;

       public enum TransactionCRUD
        {
            Nuevo=1,
            Editar=2
        }

        TransactionCRUD transaccionActual;

        public xformFacturacion_Clientes_CRUD(TransactionCRUD pTransaccion,UserLogin usuarioL)
        {
            InitializeComponent();
            Cliente = new ClienteFacturacion();
            empresas = new List<ClienteEmpresa>();
            usuarioLogeado = usuarioL;
            transaccionActual = pTransaccion;
        }

        public xformFacturacion_Clientes_CRUD(TransactionCRUD pTransaccion, UserLogin usuarioL, ClienteFacturacion pCliente)
        {
            InitializeComponent();
            empresas = new List<ClienteEmpresa>();
            usuarioLogeado = usuarioL;
            transaccionActual = pTransaccion;
            Cliente = pCliente;
        }


        int CountRecord = 0;
        private void btnNew_Click(object sender, EventArgs e)
        {

            try
            {
                xfrmClienteEmpresas frm = new xfrmClienteEmpresas(CountRecord, (int)TipoTransaccionesCRUD.Nuevo);

                if (frm.ShowDialog() == DialogResult.OK)
                {

                    switch (transaccionActual)
                    {
                        case TransactionCRUD.Nuevo:
                            empresas.Add(frm.empresa);
                            DataRow row = dsMantenimientosFacturacion.ClienteEmpresa.NewRow();
                            row["IdEmpresa"] = 0;
                            row["NombreLargo"] = frm.empresa.NombreLargo;
                            row["NombreCorto"] = frm.empresa.NombreCorto;
                            row["Codigo"] = frm.empresa.Codigo;
                            row["Direccion"] = frm.empresa.Direccion;
                            row["RTN"] = frm.empresa.RTN;
                            row["FechaCreacion"] = DateTime.Now;
                            row["Correo"] = frm.empresa.Correo;
                            row["Telefono"] = frm.empresa.Telefono;
                            row["Codigo"] = frm.empresa.Codigo;

                            dsMantenimientosFacturacion.ClienteEmpresa.Rows.Add(row);
                            CountRecord++;
                            break;
                        case TransactionCRUD.Editar:
                            DataOperations dp = new DataOperations();
                            using (SqlConnection connection = new SqlConnection(dp.ConnectionStringERP))
                            {
                                empresas.Add(frm.empresa);
                                DataRow row2 = dsMantenimientosFacturacion.ClienteEmpresa.NewRow();
                                row2["IdEmpresa"] = 0;
                                row2["NombreLargo"] = frm.empresa.NombreLargo;
                                row2["NombreCorto"] = frm.empresa.NombreCorto;
                                row2["Codigo"] = frm.empresa.Codigo;
                                row2["Direccion"] = frm.empresa.Direccion;
                                row2["RTN"] = frm.empresa.RTN;
                                row2["FechaCreacion"] = DateTime.Now;
                                row2["Correo"] = frm.empresa.Correo;
                                row2["Telefono"] = frm.empresa.Telefono;
                                row2["Codigo"] = frm.empresa.Codigo;

                                dsMantenimientosFacturacion.ClienteEmpresa.Rows.Add(row2);
                                CountRecord++;

                                connection.Open();

                                using (SqlCommand command = new SqlCommand("uspUpSertInsertarClienteEmpresa", connection))
                                {
                                    command.CommandType = CommandType.StoredProcedure;

                                    // Agregar parámetros
                                    command.Parameters.Add("@IdCliente", SqlDbType.Int).Value = Cliente.Id;
                                    command.Parameters.Add("@NombreLargo", SqlDbType.NVarChar, 100).Value = row2["NombreLargo"];
                                    command.Parameters.Add("@NombreCorto", SqlDbType.NVarChar, 50).Value = row2["NombreCorto"];
                                    command.Parameters.Add("@Direccion", SqlDbType.NVarChar, 200).Value = row2["Direccion"];
                                    command.Parameters.Add("@RTN", SqlDbType.NVarChar, 20).Value = frm.empresa.RTN;
                                    command.Parameters.Add("@FechaActual", SqlDbType.DateTime).Value = DateTime.Now;
                                    command.Parameters.Add("@UsuarioActual", SqlDbType.Int, 50).Value = usuarioLogeado.Id;
                                    command.Parameters.Add("@Telefono", SqlDbType.NVarChar, 20).Value = row2["Telefono"];
                                    command.Parameters.Add("@Correo", SqlDbType.NVarChar, 100).Value = row2["Correo"];
                                    command.Parameters.Add("@Codigo", SqlDbType.NVarChar, 10).Value = row2["Codigo"];

                                    command.ExecuteNonQuery();
                                }
                            }
                            break;
                    }

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                //throw;
            }

        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

            SqlTransaction transaction;
        private void simpleButton1_Click(object sender, EventArgs e)
        {

            try
            {

                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP);

                cnx.Open();

                transaction = cnx.BeginTransaction();


                switch (transaccionActual)
                {
                    case TransactionCRUD.Nuevo:
                        SqlCommand cmd1 = new SqlCommand("dbo.uspInsertClienteFacturacion", cnx,transaction);
                        cmd1.CommandType = CommandType.StoredProcedure;

                        cmd1.Parameters.Add("@NombreCorto", SqlDbType.VarChar).Value = txtNombreCorto.Text;
                        cmd1.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = txtCodigo.Text;
                        cmd1.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = txtDireccion.Text;
                        cmd1.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = txtTelefono.Text;
                        cmd1.Parameters.Add("@Correo", SqlDbType.VarChar).Value = txtCorreo.Text;
                        cmd1.Parameters.Add("@NombreCliente", SqlDbType.VarChar).Value = txtNombreLargo.Text;
                        cmd1.Parameters.Add("@id_usuario", SqlDbType.Int).Value = usuarioLogeado.Id;

                        int id_inserted = (int)cmd1.ExecuteScalar();
                        Cliente.Id = id_inserted;

                        foreach (DataRow item in dsMantenimientosFacturacion.ClienteEmpresa)
                        {
                            SqlCommand cmd2 = new SqlCommand("[dbo].[uspInsertFacturacionCliente_Empresav2]", cnx,transaction);
                            cmd2.CommandType = CommandType.StoredProcedure;

                            cmd2.Parameters.Add("@idCliente", SqlDbType.Int).Value = id_inserted;
                            cmd2.Parameters.Add("@NombreCorto", SqlDbType.VarChar).Value = item["NombreCorto"];
                            cmd2.Parameters.Add("@RTN", SqlDbType.VarChar).Value = item["RTN"];
                            cmd2.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = item["Direccion"];
                            cmd2.Parameters.Add("@NombreLargo", SqlDbType.VarChar).Value = item["NombreLargo"];
                            cmd2.Parameters.Add("@idUsuario", SqlDbType.Int).Value = usuarioLogeado.Id;

                            cmd2.ExecuteNonQuery();
                        }

                        transaction.Commit();

                        cnx.Close();
                        CajaDialogo.Information("Datos Guardados");
                        this.DialogResult = DialogResult.OK;
                        break;


                    case TransactionCRUD.Editar:
                        SqlCommand cmd3 = new SqlCommand("dbo.uspUpdateClienteFacturacion", cnx, transaction);
                        cmd3.CommandType = CommandType.StoredProcedure;

                        cmd3.Parameters.Add("@NombreCorto", SqlDbType.VarChar).Value = txtNombreCorto.Text;
                        cmd3.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = txtCodigo.Text;
                        cmd3.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = txtDireccion.Text;
                        cmd3.Parameters.Add("@Correo", SqlDbType.VarChar).Value = txtCorreo.Text;
                        cmd3.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = txtTelefono.Text;
                        cmd3.Parameters.Add("@NombreCliente", SqlDbType.VarChar).Value = txtNombreLargo.Text;
                        cmd3.Parameters.Add("@FechaModificacion", SqlDbType.DateTime).Value =DateTime.Now;
                        cmd3.Parameters.Add("@id_usuario", SqlDbType.Int).Value = usuarioLogeado.Id;
                        cmd3.Parameters.Add("@IdCliente", SqlDbType.Int).Value = Cliente.Id;

                        cmd3.ExecuteNonQuery();
         
                        foreach (DataRow item in dsMantenimientosFacturacion.ClienteEmpresa)
                        {
                            SqlCommand cmd4 = new SqlCommand("dbo.uspInsertFacturacionCliente_Empresa", cnx, transaction);
                            cmd4.CommandType = CommandType.StoredProcedure;

                            cmd4.Parameters.Add("@idCliente", SqlDbType.Int).Value = Cliente.Id;
                            cmd4.Parameters.Add("@NombreCorto", SqlDbType.VarChar).Value = item["NombreCorto"];
                            cmd4.Parameters.Add("@RTN", SqlDbType.VarChar).Value = item["RTN"];
                            cmd4.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = item["Direccion"];
                            cmd4.Parameters.Add("@NombreLargo", SqlDbType.VarChar).Value = item["NombreLargo"];
                            cmd4.Parameters.Add("@idUsuario", SqlDbType.Int).Value = usuarioLogeado.Id;
                            cmd4.Parameters.Add("@IdEmpresa", SqlDbType.Int).Value = item["IdEmpresa"];

                            cmd4.ExecuteNonQuery();
                        }

                        transaction.Commit();

                        cnx.Close();
                        CajaDialogo.Information("Datos Guardados");
                        this.DialogResult = DialogResult.OK;
                        break;


                        //default:
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                transaction.Rollback();
            }
        }

        private void GetIDTable()
        {
            try
            {
                if (tableID.ObtenerIDTable((int)TablesIDOptions.ClienteFacturacion))
                {
                    txtCodigo.Text = tableID.Codigo;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }

        private void xformFacturacion_Clientes_CRUD_Load(object sender, EventArgs e)
        {
            if (transaccionActual== TransactionCRUD.Nuevo)
            {
            GetIDTable();

            }
            else
            {
                txtCodigo.Text = Cliente.Codigo;
                txtNombreCorto.Text = Cliente.NombreCorto;
                txtDireccion.Text = Cliente.Direccion;
                txtNombreLargo.Text = Cliente.NombreCliente;
                txtTelefono.Text = Cliente.Telefono;
                txtCorreo.Text = Cliente.Correo;

                ObtenerEmpresas(Cliente.Id);
            }
        }

        private void ObtenerEmpresas(int IdCliente)
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP))
                {
                    cnx.Open();

                    dsMantenimientosFacturacion.ClienteEmpresa.Clear();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.uspObtenerEmpresaClientesFacturacion", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.SelectCommand.Parameters.Add("@idCliente",SqlDbType.Int).Value=IdCliente;
                    da.Fill(dsMantenimientosFacturacion.ClienteEmpresa);

                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ClienteEmpresa empresa = new ClienteEmpresa();
            var row = (dsMantenimientosFacturacion.ClienteEmpresaRow)gvEmpresa.GetFocusedDataRow();

            empresa.NombreLargo = row.NombreLargo;
            empresa.NombreCorto = row.NombreCorto;
            empresa.RTN = row.RTN;
            empresa.Codigo = row.Codigo;
            empresa.Direccion = row.Direccion;
            empresa.Telefono = row.Telefono;
            empresa.Correo = row.Correo;
            empresa.Id = row.IdEmpresa;

            xfrmClienteEmpresas frm = new xfrmClienteEmpresas(empresa, (int)TipoTransaccionesCRUD.Editar);

            if (frm.ShowDialog()== DialogResult.OK)
            {
                row.NombreCorto = frm.empresa.NombreCorto;    
                row.NombreLargo = frm.empresa.NombreLargo;
                row.RTN = frm.empresa.RTN;
                row.Direccion = frm.empresa.Direccion;
                row.Correo = frm.empresa.Correo;
                row.Telefono = frm.empresa.Telefono;
            }

        }

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("Deseas eliminar este registro?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.No)
                {
                    try
                    {
                        DataOperations dp = new DataOperations();
                        var row = (dsMantenimientosFacturacion.ClienteEmpresaRow)gvEmpresa.GetFocusedDataRow();

                        int IdCliente = row.IdCliente;

                        SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP);
                        using (SqlCommand command = new SqlCommand("dbo.uspDeshabilitarEmpresa", cnx))
                        {
                            cnx.Open();
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add("@id", SqlDbType.Int).Value = row.IdEmpresa;

                            command.ExecuteNonQuery();
                            cnx.Close();

                            //ObtenerEmpresas(IdCliente);
                        }
                        gvEmpresa.DeleteRow(gvEmpresa.FocusedRowHandle);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}