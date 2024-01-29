using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using ERP_INTECOLI.Clases;
using ERP_INTECOLI.Facturacion.CoreFacturas;
using JAGUAR_APP.Facturacion.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAGUAR_APP.Facturacion.CoreFacturas
{
    public partial class HomeEstadoCuenta : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        Estudiante EstudianteActual;
        public HomeEstadoCuenta(int id_clienteP)
        {
            InitializeComponent();
            EstudianteActual = new Estudiante();
            cmdAjusteSaldo.Visible = false;
        }

        public HomeEstadoCuenta(UserLogin pUser)
        {
            InitializeComponent();
            this.UsuarioLogeado = pUser;
            EstudianteActual = new Estudiante();
            ValidarPermisoAjusteSaldo();
        }

        public HomeEstadoCuenta(UserLogin pUser, PuntoVenta pPuntoDeVentaActual, FacturacionEquipo pEquipoActual, Int64 pIdEstudiante)
        {
            InitializeComponent();
            UsuarioLogeado = pUser;
            EstudianteActual = new Estudiante();
            ValidarPermisoAjusteSaldo();
        }

        private void ValidarPermisoAjusteSaldo()
        {
            //string HostName = Dns.GetHostName();
            //FacturacionEquipo EquipoActual = new FacturacionEquipo();
            //PuntoVenta puntoVenta1 = new PuntoVenta();

            //if (EquipoActual.RecuperarRegistro(HostName))
            //{
            //    if (!puntoVenta1.RecuperaRegistro(EquipoActual.id_punto_venta))
            //    {
            //        CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
            //        return;
            //    }
            //}
            //else
            //{
            //    CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
            //    return;
            //}

            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.Id, 12);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar //12 = Success
            {
                case 1://Basic View
                    accesoprevio = false;
                    break;
                case 2://Basic No Autorization
                    accesoprevio = false;
                    break;
                case 3://Medium Autorization
                    accesoprevio = false;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    cmdAjusteSaldo.Visible = true;
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(25))
                    cmdAjusteSaldo.Visible = true;
                else
                    cmdAjusteSaldo.Visible = false;
            }
        }

        Int64 id_cliente_selected=0;
        private void LoadData(Int64 id_cliente)
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP))
                {
                    cnx.Open();
                    SqlDataAdapter da = new SqlDataAdapter("dbo.uspCargarEstadoCuentaByCliente", cnx);

                    dsContabilidad.EstadoCuenta.Clear();

                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add("@id_estudiante", SqlDbType.Int).Value = id_cliente;
                    da.Fill(dsContabilidad.EstadoCuenta);

                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            rptEstadoCuenta  report = new rptEstadoCuenta(id_cliente_selected);

            using (ReportPrintTool printTool = new ReportPrintTool(report))
            {
                // Send the report to the default printer.
                printTool.ShowPreviewDialog();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            id_cliente_selected = 0;

            xfrmSelectCliente frm = new xfrmSelectCliente();
            Cliente cliente = new Cliente();

            if (frm.ShowDialog()==DialogResult.OK)
            {
                if (cliente.RecuperarRegistro(frm.id_cliente))
                {
                    txtCliente.Text = cliente.Nombre;
                    txtCodigo.Text = cliente.Codigo;
                    txtCorreo.Text = cliente.Correo;
                    txtTelefono.Text = cliente.Telefono;
                    txtDireccion.Text = cliente.Direccion;
                    id_cliente_selected = frm.id_cliente;
                    lblSaldo.Text = string.Format("{0: ###,##0.00}", cliente.SaldoActual);

                    LoadData(frm.id_cliente);
                }
                EstudianteActual.RecuperarRegistro(frm.id_cliente);
            }
        }

        private void cmdAjusteSaldo_Click(object sender, EventArgs e)
        {
            if (!EstudianteActual.Recuperado)
            {
                CajaDialogo.Error("Es necesario seleccionar un estudiante para poder continuar!");
                return;
            }


            frmAjusteSaldoEstadoCuenta frm = new frmAjusteSaldoEstadoCuenta(EstudianteActual, this.UsuarioLogeado);
            if(frm.ShowDialog() == DialogResult.OK) 
            {
                Cliente cliente = new Cliente();
                if (cliente.RecuperarRegistro(EstudianteActual.IdEstudiante))
                {
                    txtCliente.Text = cliente.Nombre;
                    txtCodigo.Text = cliente.Codigo;
                    txtCorreo.Text = cliente.Correo;
                    txtTelefono.Text = cliente.Telefono;
                    txtDireccion.Text = cliente.Direccion;
                    id_cliente_selected = EstudianteActual.IdEstudiante;
                    lblSaldo.Text = string.Format("{0: ###,##0.00}", cliente.SaldoActual);

                    LoadData(EstudianteActual.IdEstudiante);
                }
                LoadData(EstudianteActual.IdEstudiante);
            }
        }
    }
}