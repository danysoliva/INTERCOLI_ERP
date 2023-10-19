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
    public partial class frmHomeNotasCreditoDebito : DevExpress.XtraEditors.XtraForm
    {
        public frmHomeNotasCreditoDebito()
        {
            InitializeComponent();
            //LoadData();
            LoadTipoNota();
        }

        private void LoadData()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP);
                //var row = (dsFacturasGestion.NotaHRow)grd_data.GetFocusedDataRow();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspGetNotas", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add("@desde", dtDesde.EditValue);
                    da.SelectCommand.Parameters.Add("@hasta", dtHasta.EditValue);
                    da.SelectCommand.Parameters.Add("@tipo_nota", lookUpEdit1.EditValue);

                    dsFacturasGestion.NotaH.Clear();
                    da.Fill(dsFacturasGestion.NotaH);
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

        private void btnPrint_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsFacturasGestion.NotaHRow)grd_data.GetFocusedDataRow();
                Notas_CreditoDebito nota = new Notas_CreditoDebito();

                if (nota.RecuperarRegistro(row.id))
                {


                RPT_ND_NC_Local report = new RPT_ND_NC_Local(nota);

                using (ReportPrintTool printTool = new ReportPrintTool(report))
                {
                    // Send the report to the default printer.
                    //factura.UpdatePrintCount(factura_id);
                    printTool.ShowPreviewDialog();
                }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                
            }
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dtDesde.Text))
            {
                CajaDialogo.Error("Debe de seleccionar la fecha de inicio");
                return;
            }

            if (string.IsNullOrEmpty(dtHasta.Text))
            {
                CajaDialogo.Error("Debe de seleccionar la fecha final");
                return;
            }

            LoadData();
        }

        private void frmHomeNotasCreditoDebito_Load(object sender, EventArgs e)
        {
            dtDesde.EditValue = DateTime.Now;
            dtHasta.EditValue = DateTime.Now.AddDays(1);
            lookUpEdit1.EditValue = 0;
            LoadData();
        }

        private void LoadTipoNota()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP);
                string query = @"select 0 id, 'Todo' descripcion UNION Select id, descripcion from dbo.Facturacion_Notas_Tipo where enable = 1";
                //var row = (dsFacturasGestion.NotaHRow)grd_data.GetFocusedDataRow();

                using (SqlDataAdapter da = new SqlDataAdapter(query, cnx))
                {
                    cnx.Open();
                    //da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    dsFacturasGestion.Tipo_Nota.Clear();
                    da.Fill(dsFacturasGestion.Tipo_Nota);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdExportToExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                gridControl1.ExportToXlsx(dialog.FileName);
        }
    }
}