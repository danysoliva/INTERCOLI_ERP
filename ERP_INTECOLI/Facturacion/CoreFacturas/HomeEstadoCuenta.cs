using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using ERP_INTECOLI.Clases;
using JAGUAR_APP.Facturacion.Reportes;
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

namespace JAGUAR_APP.Facturacion.CoreFacturas
{
    public partial class HomeEstadoCuenta : DevExpress.XtraEditors.XtraForm
    {
        public HomeEstadoCuenta(int id_clienteP)
        {
            InitializeComponent();
            //LoadData(20);
        }

        public HomeEstadoCuenta(UserLogin pUser, PuntoVenta pPuntoDeVentaActual, FacturacionEquipo pEquipoActual, Int64 pIdEstudiante)
        {
            InitializeComponent();
        }

        int id_cliente_selected=0;
        private void LoadData(int id_cliente)
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
                    da.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int).Value = id_cliente;
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
            }
        }
    }
}