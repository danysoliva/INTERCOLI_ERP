
using DevExpress.XtraEditors;
using ERP_INTECOLI.Clases;
using JAGUAR_APP.Facturacion.Mantenimientos;
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

namespace JAGUAR_APP.Mantenimientos.Facturacion.Mantenimiento
{
    public partial class xfrmFacturacion_Clientes : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();

        UserLogin usuarioLogueado = new UserLogin();

        public xfrmFacturacion_Clientes(UserLogin userLogged)
        {
            InitializeComponent();
            ObtenerClientes();
            usuarioLogueado = userLogged;
        }

        private void ObtenerClientes()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP))
                {
                    cnx.Open();

                    dsMantenimientosFacturacion1.Cliente.Clear();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.uspObtenerClientesFacturacion", cnx);
                    da.Fill(dsMantenimientosFacturacion1.Cliente);

                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            xformFacturacion_Clientes_CRUD frm = new xformFacturacion_Clientes_CRUD(xformFacturacion_Clientes_CRUD.TransactionCRUD.Nuevo, usuarioLogueado);
            //frm.EventoPasarId_cliente_inserted += new xformFacturacion_Clientes_CRUD.get_cliente_inserted(Ejecutar);

            if(frm.ShowDialog()== DialogResult.OK)
            {
                //Agregando el nuevo row creado 
                //dsMantenimientosFacturacion.Cliente
                ClienteFacturacion cliente = new ClienteFacturacion();
                dsMantenimientosFacturacion.ClienteRow row = dsMantenimientosFacturacion1.Cliente.NewClienteRow();
                if (cliente.RecuperarRegistro(frm.Cliente.Id))
                {
                    row.IdCliente = cliente.Id;
                    row.Codigo = cliente.Codigo;
                    row.NombreCliente = cliente.NombreCliente;
                    row.NombreCorto = cliente.NombreCorto;
                    row.Direccion = cliente.Direccion;
                    row.Correo = cliente.Correo;
                    row.Telefono = cliente.Telefono;
                }
                dsMantenimientosFacturacion1.Cliente.AddClienteRow(row);
                dsMantenimientosFacturacion1.AcceptChanges();
            }
        }

        private void cmdDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("Deseas eliminar este registro?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.No)
                {
                    try
                    {
                        DataOperations dp = new DataOperations();
                        var row = (dsMantenimientosFacturacion.ClienteRow)gvClientes.GetFocusedDataRow();


                        SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP);
                        using (SqlCommand command = new SqlCommand("dbo.uspDeshabilitarCliente", cnx))
                        {
                            cnx.Open();
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add("@id", SqlDbType.Int).Value = row.IdCliente;

                            command.ExecuteNonQuery();
                            cnx.Close();

                            ObtenerClientes();
                        }
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
                throw;
            }
        }

        private void cmdEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsMantenimientosFacturacion.ClienteRow)gvClientes.GetFocusedDataRow();

                ClienteFacturacion cliente = new ClienteFacturacion();

                cliente.Id = row.IdCliente;
                cliente.Codigo = row.Codigo;
                cliente.NombreCliente = row.NombreCliente;
                cliente.NombreCorto = row.NombreCorto;
                cliente.Direccion = row.Direccion;
                cliente.Correo = row.Correo;
                cliente.Telefono = row.Telefono;
                //cliente.ID = row.id;
                //cliente.Nombre = row.nombre;
                //cliente.Contacto = row.contacto;
                //cliente.Correo = row.correo;
                //cliente.Codigo = row.codigo;
                //cliente.Telefono = row.telefono;

                xformFacturacion_Clientes_CRUD frm = new xformFacturacion_Clientes_CRUD(xformFacturacion_Clientes_CRUD.TransactionCRUD.Editar, usuarioLogueado,cliente);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    //Los usuarios odian que se recarguen los grids, lo mejor es agregar el row de forma manual
                    //ObtenerClientes();
                    if (cliente.RecuperarRegistro(row.IdCliente))
                    {
                        row.IdCliente = cliente.Id;
                        row.Codigo = cliente.Codigo;
                        row.NombreCliente = cliente.NombreCliente;
                        row.NombreCorto = cliente.NombreCorto;
                        row.Direccion = cliente.Direccion;
                        row.Correo = cliente.Correo;
                        row.Telefono = cliente.Telefono;
                    }
                    

                    
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ObtenerClientes();
        }

        //public void Ejecutar(int pIdLataInserted)
        //{
        //    JAGUAR_Clientes cliente = new JAGUAR_Clientes();
        //    if (cliente.RecuperarRegistro(pIdLataInserted))
        //    {
        //        dsMantenimiento.JAGUAR_ClientesRow row1 = dsMantenimiento.JAGUAR_Clientes.NewJAGUAR_ClientesRow();
        //        row1.id = pIdLataInserted;
        //        row1.nombre = cliente.Nombre;
        //        row1.codigo = cliente.Codigo;
        //        row1.contacto = cliente.Contacto;
        //        row1.correo = cliente.Correo;
              

        //        dsMantenimiento.JAGUAR_Clientes.AddJAGUAR_ClientesRow(row1);
        //        dsMantenimiento.AcceptChanges();
        //    }
        //}
    }
}