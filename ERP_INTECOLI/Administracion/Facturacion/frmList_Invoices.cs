using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERP_INTECOLI.Clases;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace ERP_INTECOLI.Administracion.Facturacion
{
    public partial class frmList_Invoices : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        //UserLogin UsuarioLogueado;

        public int IdFactura;
        public string NumFactura;

        public frmList_Invoices()
        {
            InitializeComponent();
            dtDesde.EditValue = dp.Now().AddDays(-8);
            dtHasta.EditValue = dp.Now();
            LoadData();
        }

        private void LoadData()
        {
            if (string.IsNullOrEmpty(dtDesde.Text))
                return;

            if (string.IsNullOrEmpty(dtHasta.Text))
                return;

            try
            {
                //string sql = @"SELECT id, numero, 
		              //                 cliente, 
		              //                 fecha_emision,
		              //                 case when nula then
		   		         //                   'Si'
			             //               else 'No' end as anulada, 
		              //                 case when pagada then
		   		         //                   'Si'
			             //               else 'No' end as pagada, 
		              //                 fecha_pagado, 
		              //                 case when id_tipo_pago =1 then
		   		         //                   'Contado'
			             //               else 'Credito'end as tipo_factura
	               //             FROM factura 
                //            where fecha_emision between @desde and @hasta
	     
                //            order by fecha_emision desc ";
                string sql = @"sp_get_facturas_lista";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtDesde.EditValue);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.EditValue);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsFactura1.factura_list.Clear();
                adat.Fill(dsFactura1.factura_list);
                //gridLookUpImpresoras.EditValue = 1;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                gridControl1.ExportToXlsx(dialog.FileName);
        }

        private void CargarDatos_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cmdSeleccionar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Seleccionar row
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsFactura.factura_listRow)gridView.GetFocusedDataRow();

            IdFactura = row.id;
            NumFactura = row.numero;

            if (IdFactura > 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                CajaDialogo.Error("El registro seleccionado presenta un error! Seleccione otra vez la factura o contacte a soporte de Sistemas!");
            }
        }
    }
}