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
    public partial class xfrmEditPriceFromListaPrecio : DevExpress.XtraEditors.XtraForm
    {
        int id_listaPrecioProductoAplica = 0;
        int id_pt = 0;
        public xfrmEditPriceFromListaPrecio(int id_listaPrecioProductoAplicaP, int id_ptP, string pt)
        {
            InitializeComponent();
            lblPT.Text = "Producto: " + pt;
            id_listaPrecioProductoAplica = id_listaPrecioProductoAplicaP;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP);

                SqlCommand cmd = new SqlCommand("dbo.uspUpdateListaPrecioProductoAplicaTienda", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@precio",SqlDbType.Decimal).Value=txtPrecio.Text;
                cmd.Parameters.Add("@id_listaPrecioProductoAplicaTienda", SqlDbType.Int).Value= id_listaPrecioProductoAplica;

                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                CajaDialogo.Information("Datos Guardados");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}