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

namespace JAGUAR_APP.Facturacion.Configuraciones
{
    public partial class xfrmSelectCliente : DevExpress.XtraEditors.XtraForm
    {
        public xfrmSelectCliente()
        {
            InitializeComponent();
            ObtenerClientes();
        }
        public List<ClienteListaPreciosAplica> clientes = new List<ClienteListaPreciosAplica>();

        private void ObtenerClientes()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP))
                {
                    cnx.Open();

                    dsListaPrecios.Clientes.Clear();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.uspObtenerClientesFacturacionFromListaPrecios", cnx);
                    da.Fill(dsListaPrecios.Clientes);

                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }


        private void gvCliente_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "seleccion")
            {
                clientes = new List<ClienteListaPreciosAplica>();

                foreach (var item in dsListaPrecios.Clientes)
                {
                    if (item.seleccion == true)
                    {

                        ClienteListaPreciosAplica clienteNew = new ClienteListaPreciosAplica()
                        {
                            ID = item.IdCliente,
                            NombreCliente = item.nombre_cliente,
                            Codigo = item.codigo,
                            ListaPrecioID =0
                        };

                        clientes.Add(clienteNew);
                    }
                }

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
public class ClienteListaPreciosAplica
{

    public int ID { get; set; }
    public int ListaPrecioID { get; set; }
    public string NombreCliente { get; set; }
    public string Codigo { get; set; }
}

