using DevExpress.XtraReports.UI;
using ERP_INTECOLI.Clases;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;

namespace ERP_INTECOLI.Compras
{
    public partial class rptOrdenCompra : DevExpress.XtraReports.UI.XtraReport
    {
        DataOperations dp = new DataOperations();
        public rptOrdenCompra(int pIdOrdenCompraActual)
        {
            InitializeComponent();

            OrdenesCompra oc = new OrdenesCompra();
            oc.RecuperarRegistos(pIdOrdenCompraActual);
            lblCliente.Text = oc.Itemcode_Prov + " - " + oc.Nombre_Prov;
            Proveedor prov = new Proveedor();
            prov.RecuperarRegistroFromItemCode(oc.Itemcode_Prov);
            lblRTN.Text = prov._RTN;
            lblDireccion.Text = oc.Direccion;
            lblNumeroOrden.Text = "OC #" + oc.Id_OrdenCompra;
            lblFechaOrden.Text = string.Format("{0:dd/MM/yyyy}",oc.Fecha_Contabilizacion);
            lblFechaVencimiento.Text = string.Format("{0:dd/MM/yyyy}", oc.Fecha_Contabilizacion.AddDays(30).ToString());
            load_detalle(pIdOrdenCompraActual);
        }

        private void load_detalle(int PIdOrdenCompraActual)
        {
            try
            {
                string sql = @"[sp_get_compras_ordenes_detalle]";

                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_header_orden", PIdOrdenCompraActual);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.oc_detalle.Clear();
                adat.Fill(dsCompras1.oc_detalle);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}
