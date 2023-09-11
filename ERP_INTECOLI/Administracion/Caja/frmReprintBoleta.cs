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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using ERP_INTECOLI.Clases;
using ERP_INTECOLI.Administracion.Facturacion;
using System.Data.SqlClient;

namespace ERP_INTECOLI.Administracion.Caja
{
    public partial class frmReprintBoleta : DevExpress.XtraEditors.XtraForm
    {


        DataOperations dp = new DataOperations();
        public frmReprintBoleta()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            try
            {
                //string sql = @"select * from admon.ft_carga_boletas_efectuadas (:p_limit);";
                string sql = @"sp_caja_carga_boletas_efectuadas";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@limit", textBox1.Text);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCaja1.boletas_reprint.Clear();
                adat.Fill(dsCaja1.boletas_reprint);
                conn.Open();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Load();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnReimprimir_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult r = CajaDialogo.Pregunta("Desea Reimprimir esta boleta?");
            if (r != System.Windows.Forms.DialogResult.Yes)
                return;

            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsCaja.boletas_reprintRow)gridView.GetFocusedDataRow();

            int id_ = row.id_m;
            //UpdateBoletaPagada(id_, 2);

            //Secuencia de Impresion
            rptBoleta bol = new rptBoleta(id_.ToString(), row.est, row.val, row.fech);

            //CargarDatosB();
            bol.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            ReportPrintTool printReport = new ReportPrintTool(bol);
            //printReport.ShowPreview();

            printReport.PrinterSettings.PrinterName = "EPSON TM-U220 Receipt";
            printReport.Print();
        }
    }
}