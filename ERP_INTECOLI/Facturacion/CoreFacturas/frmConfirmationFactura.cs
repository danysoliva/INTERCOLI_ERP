using DevExpress.XtraEditors;
using ERP_INTECOLI.Facturacion.CoreFacturas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAGUAR_APP.Facturacion.CoreFacturas
{
    public partial class frmConfirmationFactura : DevExpress.XtraEditors.XtraForm
    {
        public string NombreCliente;
        public string RTN;
        public string Direccion;
        public frmConfirmationFactura(string nombreCliente, string rTN, string pDireccion, dsVentaSuccess.detalle_factura_transactionDataTable pdatasetlleno)
        {
            InitializeComponent();
            txtNombreCliente.Text = NombreCliente = nombreCliente;
            txtRTN.Text = RTN = rTN;
            this.Direccion = txtDireccion.Text = pDireccion;

            foreach(dsVentaSuccess.detalle_factura_transactionRow row in pdatasetlleno) 
            {
                dsVentaSuccess.detalle_factura_transactionRow row1 = dsVentaSuccess1.detalle_factura_transaction.Newdetalle_factura_transactionRow();
                row1.cantidad = row.cantidad;  
                row1.id_pt = row.id_pt;
                row1.inventario = row.inventario;
                row1.id_isv_aplicable = row.id_isv_aplicable;
                row1.descuento = row.descuento;
                row1.isv1 = row.isv1;
                row1.isv2 = row.isv2;
                row1.isv3 = row.isv3;
                row1.precio = row.precio;   
                row1.tasa_isv = row.tasa_isv;   
                row1.total_linea = row.total_linea;
                row1.itemcode = row.itemcode;
                row1.itemname = row.itemname;
                dsVentaSuccess1.detalle_factura_transaction.Adddetalle_factura_transactionRow(row1);
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;    
            this.Close();
        }

        private void cmdConfirmar_Click(object sender, EventArgs e)
        {
            NombreCliente = txtNombreCliente.Text;
            RTN = txtRTN.Text;
            this.Direccion = txtDireccion.Text;

            this.DialogResult= DialogResult.OK;
            this.Close();
        }
    }
}