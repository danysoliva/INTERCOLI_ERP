using DevExpress.XtraEditors;
using ERP_INTECOLI.Clases;
using JAGUAR_APP.Facturacion.Mantenimientos;
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
    public partial class xfrmSelectCliente : DevExpress.XtraEditors.XtraForm
    {
        public xfrmSelectCliente()
        {
            InitializeComponent();
            ObtenerClientes();
        }

        public int id_cliente=0;
        private void ObtenerClientes()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP))
                {
                    cnx.Open();

                    dsMantenimientosFacturacion.Cliente.Clear();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.uspObtenerClientesFacturacion", cnx);
                    da.Fill(dsMantenimientosFacturacion.Cliente);

                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                id_cliente= 0;
                var row = (dsMantenimientosFacturacion.ClienteRow)gvCliente.GetFocusedDataRow();

                id_cliente = row.IdCliente;

                this.DialogResult= DialogResult.OK;

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}