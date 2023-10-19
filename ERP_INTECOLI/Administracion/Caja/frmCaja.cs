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
using DevExpress.XtraGrid.Views.Grid;
using ERP_INTECOLI.Administracion.Facturacion;
using DevExpress.XtraReports.UI;

namespace ERP_INTECOLI.Administracion.Caja
{
    public partial class frmCaja : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeuado;

        public frmCaja(UserLogin pUserLogin) 
        {
        
            InitializeComponent();
            UsuarioLogeuado = pUserLogin;
            dateEdit1.EditValue = dateEditLibros.EditValue = dateEditReservas.EditValue = dtFechaEmision.EditValue = dp.Now();

            CargarDatos();
            CargarDatosB();
            CargarDatosLibros();
            CargarDatosReservas();
        }

        private void CargarDatosReservas()
        {
            try
            {
                //string sql = @"select * from admon.ft_carga_boletas_reservas_pendientes(:p_fecha);";
                string sql = @"sp_caja_carga_boletas_reservas_pendientes";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha", dateEditReservas.EditValue);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCaja1.ReservasPendientes.Clear();
                dsCaja1.ReservasLiberadas.Clear();
                adat.Fill(dsCaja1.ReservasPendientes);

                string sql1 = @"sp_caja_carga_boletas_reservas_liberadas";
                //@"select * from admon.ft_carga_boletas_reservas_liberadas(:p_fecha);";\
                SqlConnection conn1 = new SqlConnection(dp.ConnectionStringERP);
                conn1.Open();
                SqlCommand cmd1 = new SqlCommand(sql1, conn1);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@fecha", dateEditReservas.EditValue);
                SqlDataAdapter adat1 = new SqlDataAdapter(cmd1);
                adat1.Fill(dsCaja1.ReservasLiberadas);

            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void CargarDatosLibros()
        {
            try
            {
                //string sql = @"select * from admon.ft_carga_boletas_libros_pendientes(:p_fecha);";
                string sql = @"sp_caja_carga_boletas_libros_pendientes";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha", dateEditLibros.EditValue);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCaja1.LibrosPendientes.Clear();
                dsCaja1.Librosliberadas.Clear();
                adat.Fill(dsCaja1.LibrosPendientes);
                conn.Close();

                //string sql1 = @"select * from admon.ft_carga_boletas_libros_liberadas(:p_fecha);";
                string sql1 = @"sp_caja_carga_boletas_libros_liberadas";
                SqlConnection conn1 = new SqlConnection(dp.ConnectionStringERP);
                conn1.Open();
                SqlCommand cmd1 = new SqlCommand(sql1, conn1);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@fecha",  dateEditLibros.EditValue);
                SqlDataAdapter adat1 = new SqlDataAdapter(cmd1);
                adat1.Fill(dsCaja1.Librosliberadas);
                conn1.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void CargarDatos()
        {
            try
            {
                //string sql = @"select * from admon.ft_carga_fact_pendientes_v2 (:p_fecha);";
                string sql = @"sp_caja_cargar_fact_pendientes";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha", dtFechaEmision.EditValue);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCaja1.pendientes.Clear();
                dsCaja1.liberadas.Clear();
                adat.Fill(dsCaja1.pendientes);

                //string sql1 = @"select * from admon.ft_carga_fact_liberadas_v2 (:p_fecha);";
                string sql1 = @"sp_caja_cargar_fact_liberadas";
                SqlConnection conn1 = new SqlConnection(dp.ConnectionStringERP);
                conn1.Open();
                SqlCommand cmd1 = new SqlCommand(sql1, conn1);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@fecha", dtFechaEmision.EditValue);
                SqlDataAdapter adat1 = new SqlDataAdapter(cmd1);
                adat1.Fill(dsCaja1.liberadas);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void CargarDatosB()
        {
            try
            {
                //string sql = @"select * from admon.ft_carga_boletas_pendientes(:p_fecha);";
                string sql = @"sp_caja_cargar_boletas_pendientes";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha", dtFechaEmision.EditValue);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCaja1.bliberadas.Clear();
                dsCaja1.bpendientes.Clear();
                adat.Fill(dsCaja1.bpendientes);

                //string sql1 = @"select * from admon.ft_carga_boletas_liberadas(:p_fecha);";
                string sql1 = @"sp_caja_cargar_boletas_liberadas";
                SqlConnection conn1 = new SqlConnection(dp.ConnectionStringERP);
                conn1.Open();
                SqlCommand cmd1 = new SqlCommand(sql1, conn1);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@fecha", dtFechaEmision.EditValue);
                SqlDataAdapter adat1 = new SqlDataAdapter(cmd1);
                adat1.Fill(dsCaja1.bliberadas);

            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void cmdPrint_Click(object sender, EventArgs e)
        {
            
        }

        private void cmdPrintFact_Click(object sender, EventArgs e)
        {
            frmRePrintFactura fx = new frmRePrintFactura();
            //fx.MdiParent = this.MdiParent;
            fx.Show();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            CargarDatosB();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            CargarDatosLibros();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            CargarDatosReservas();
        }

        private void repositoryItemButtonEdit2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl2.FocusedView;
            var row = (dsCaja.liberadasRow)gridView.GetFocusedDataRow();

            DialogResult r = CajaDialogo.Pregunta("Realmente desea anular esta factura?");

            if (r == DialogResult.Yes)
            {
                try
                {
                    //string sql = @"select * from admon.ft_anular_factura(:p_id);";
                    string sql = @"sp_caja_anular_factura";
                    SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", row.id);
                    cmd.ExecuteScalar();
                    CajaDialogo.Information("Transacción Exitosa!");
                    CargarDatos();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }
        }

        private void UpdateFacturaPagada(int idFact, int idTipo)
        {
            try
            {
                //string sql = @"select * from admon.ft_update_factura_pagada (:pid, :p_id_tipo);";
                string sql = @"sp_caja_update_factura_pagada";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", idFact);
                cmd.Parameters.AddWithValue("@id_tipo", idTipo);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsCaja.pendientesRow)gridView.GetFocusedDataRow();
            frmTipoPago frm = new frmTipoPago();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                switch (frm.TipoPago)
                {
                    case 1:
                        frmPagoEfectivo frm1 = new frmPagoEfectivo(row.valor);
                        if (frm1.ShowDialog() == DialogResult.OK)
                        {
                            int id = row.id;
                            UpdateFacturaPagada(id, 1);//update factura efectivo
                            CargarDatos();
                            FacturaBK fact1 = new FacturaBK();
                            if (fact1.RecuperarRegistro(id))
                            {
                                switch (frm1.IdFormato)
                                {
                                    case 1:
                                        rptFactura fac = new rptFactura(fact1, rptFactura.TipoCopia.Azul);
                                        fac.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                                        ReportPrintTool printReport = new ReportPrintTool(fac);
                                        //printReport.ShowPreview();
                                        //printReport.Print("EPSON TM-U220 Receipt");
                                        //printReport.PrinterSettings.PrinterName = "EPSON TM-U220 Receipt";
                                        printReport.PrinterSettings.PrinterName = frm1.PrinterName;
                                        printReport.Print();

                                        break;
                                    case 2:
                                        rptFacturaLetterSize FactLetter1 = new rptFacturaLetterSize(fact1, rptFacturaLetterSize.TipoCopia.Azul);
                                        FactLetter1.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                                        ReportPrintTool printReport2 = new ReportPrintTool(FactLetter1);
                                        printReport2.PrinterSettings.PrinterName = frm1.PrinterName;
                                        printReport2.Print();
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                        break;
                    case 2:
                        //UpdateFacturaPagada(row.id, 2);
                        frmPagoTarjeta frm2 = new frmPagoTarjeta(row.valor);
                        if (frm2.ShowDialog() == DialogResult.OK)
                        {
                            int id_ = row.id;
                            UpdateFacturaPagada(id_, 2);//update factura efectivo
                            CargarDatos();
                            FacturaBK fact1 = new FacturaBK();
                            if (fact1.RecuperarRegistro(id_))
                            {
                                //rptFactura fac = new rptFactura(fact1, psConnection, rptFactura.TipoCopia.Azul);
                                //fac.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                                //ReportPrintTool printReport = new ReportPrintTool(fac);
                                ////printReport.ShowPreview();
                                ////printReport.Print("EPSON TM-U220 Receipt");
                                //printReport.PrinterSettings.PrinterName = "EPSON TM-U220 Receipt";
                                //printReport.Print();
                                switch (frm2.IdFormato)
                                {
                                    case 1:
                                        rptFactura fac = new rptFactura(fact1, rptFactura.TipoCopia.Azul);
                                        fac.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                                        ReportPrintTool printReport = new ReportPrintTool(fac);
                                        //printReport.ShowPreview();
                                        //printReport.Print("EPSON TM-U220 Receipt");
                                        //printReport.PrinterSettings.PrinterName = "EPSON TM-U220 Receipt";
                                        printReport.PrinterSettings.PrinterName = frm2.PrinterName;
                                        printReport.Print();

                                        break;
                                    case 2:
                                        rptFacturaLetterSize FactLetter1 = new rptFacturaLetterSize(fact1, rptFacturaLetterSize.TipoCopia.Azul);
                                        FactLetter1.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                                        ReportPrintTool printReport2 = new ReportPrintTool(FactLetter1);
                                        printReport2.PrinterSettings.PrinterName = frm2.PrinterName;
                                        printReport2.Print();
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                        break;
                    case 3:

                        //UpdateFacturaPagada(row.id, 2);
                        frmPagoTransferencia frm3 = new frmPagoTransferencia(row.valor);
                        if (frm3.ShowDialog() == DialogResult.OK)
                        {
                            int id_ = row.id;
                            UpdateFacturaPagada(id_, 3);


                            CargarDatos();
                            FacturaBK fact1 = new FacturaBK();
                            if (fact1.RecuperarRegistro(id_))
                            {
                                switch (frm3.IdFormato)
                                {
                                    case 1:
                                        rptFactura fac = new rptFactura(fact1, rptFactura.TipoCopia.Azul);
                                        fac.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                                        ReportPrintTool printReport = new ReportPrintTool(fac);
                                        //printReport.ShowPreview();
                                        //printReport.Print("EPSON TM-U220 Receipt");
                                        //printReport.PrinterSettings.PrinterName = "EPSON TM-U220 Receipt";
                                        printReport.PrinterSettings.PrinterName = frm3.PrinterName;
                                        printReport.Print();

                                        break;
                                    case 2:
                                        rptFacturaLetterSize FactLetter1 = new rptFacturaLetterSize(fact1, rptFacturaLetterSize.TipoCopia.Azul);
                                        FactLetter1.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                                        ReportPrintTool printReport2 = new ReportPrintTool(FactLetter1);
                                        printReport2.PrinterSettings.PrinterName = frm3.PrinterName;
                                        printReport2.Print();
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                        break;
                }

            }
        }
        private void UpdateBoletaPagada(int id, int pTipo)
        {
            try
            {
                //string sql = @"select * from admon.ft_update_boleta_pagada (:pid, :p_id_tipo);";
                string sql = @"sp_caja_update_boleta_pagada";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_matricula", id);
                cmd.Parameters.AddWithValue("@id_tipo",  pTipo);
                cmd.ExecuteScalar();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void repositoryItemButtonEdit4_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl4.FocusedView;
            var row = (dsCaja.bpendientesRow)gridView.GetFocusedDataRow();
            frmTipoPago frm = new frmTipoPago();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //if (frm.TipoPago == 1)//Efectivo
                switch (frm.TipoPago)
                {
                    case 1:
                        frmPagoEfectivo frm1 = new frmPagoEfectivo(row.valor);
                        if (frm1.ShowDialog() == DialogResult.OK)
                        {
                            int id = row.id;
                            UpdateBoletaPagada(id, 1);

                            //Secuencia de impresion

                            rptBoleta bol = new rptBoleta(id.ToString(), row.cliente, row.valor, row.fecha);
                            CargarDatosB();
                            bol.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                            ReportPrintTool printReport = new ReportPrintTool(bol);
                            //printReport.ShowPreview();
                            //printReport.Print("EPSON TM-U220 Receipt");
                            printReport.PrinterSettings.PrinterName = "EPSON TM-U220 Receipt";
                            try
                            {
                                printReport.Print();
                            }
                            catch
                            {
                                printReport.ShowPreview();
                            }
                        }
                        break;
                    case 2:

                        //UpdateFacturaPagada(row.id, 2);
                        frmPagoTarjeta frm2 = new frmPagoTarjeta(row.valor);
                        if (frm2.ShowDialog() == DialogResult.OK)
                        {
                            int id_ = row.id;
                            UpdateBoletaPagada(id_, 2);

                            //Secuencia de Impresion
                            rptBoleta bol = new rptBoleta(id_.ToString(), row.cliente, row.valor, row.fecha);

                            CargarDatosB();
                            bol.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                            ReportPrintTool printReport = new ReportPrintTool(bol);
                            //printReport.ShowPreview();
                            //printReport.Print("EPSON TM-U220 Receipt");
                            printReport.PrinterSettings.PrinterName = "EPSON TM-U220 Receipt";
                            try
                            {
                                printReport.Print();
                            }
                            catch
                            {
                                printReport.ShowPreview();
                            }
                        }
                        break;
                    case 3:

                        //UpdateFacturaPagada(row.id, 2);
                        frmPagoTransferencia frm3 = new frmPagoTransferencia(row.valor);
                        if (frm3.ShowDialog() == DialogResult.OK)
                        {
                            int id_ = row.id;
                            UpdateBoletaPagada(id_, 3);

                            //Secuencia de Impresion
                            rptBoleta bol = new rptBoleta(id_.ToString(), row.cliente, row.valor, row.fecha);

                            CargarDatosB();
                            bol.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                            ReportPrintTool printReport = new ReportPrintTool(bol);
                            //printReport.ShowPreview();
                            //printReport.Print("EPSON TM-U220 Receipt");
                            printReport.PrinterSettings.PrinterName = "EPSON TM-U220 Receipt";
                            try
                            {
                                printReport.Print();
                            }
                            catch
                            {
                                printReport.ShowPreview();
                            }
                        }
                        break;
                }

            }
        }

        private void repositoryItemButtonEdit3_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Boletas de matricula
            var gridView = (GridView)gridControl3.FocusedView;
            var row = (dsCaja.bliberadasRow)gridView.GetFocusedDataRow();
            DialogResult r = CajaDialogo.Pregunta("Realmente desea anular esta Boleta?");
            if (r == DialogResult.Yes)
            {
                try
                {
                    //string sql = @"select * from admon.ft_anular_boleta(:p_id);";
                    string sql = @"sp_caja_anular_boleta";
                    SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", row.id);
                    cmd.ExecuteScalar();
                    CajaDialogo.Information("Transacción Exitosa!");
                    CargarDatos();
                    CargarDatosB();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }
        }

        private void btnReprint_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmReprintBoleta fx = new frmReprintBoleta();
            //fx.MdiParent = this.MdiParent;
            fx.Show();
        }

        private void UpdateDocumentoLibro_Reserva(int pId, int idTipoPago, int pTipoBoleta)
        {
            try
            {
                //string sql = @"select * from admon.ft_update_boleta_libro_reserva_pagada (:pid, :p_id_tipo, :p_id_tipoboleta);";
                string sql = @"sp_caja_update_boleta_libro_reserva_pagada";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pId);
                cmd.Parameters.AddWithValue("@id_tipo", idTipoPago);
                cmd.Parameters.AddWithValue("@id_tipoboleta", pTipoBoleta);
                cmd.ExecuteScalar();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void repositoryItemButtonEdit6_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Boleta de Libros
            var gridView = (GridView)gridControl6.FocusedView;
            var row = (dsCaja.LibrosPendientesRow)gridView.GetFocusedDataRow();
            frmTipoPago frm = new frmTipoPago();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                switch (frm.TipoPago)
                {
                    case 1:
                        frmPagoEfectivo frm1 = new frmPagoEfectivo(row.valor);
                        if (frm1.ShowDialog() == DialogResult.OK)
                        {
                            int id = row.id;
                            //3 es el tipo "Boleta de Libros"
                            UpdateDocumentoLibro_Reserva(id, 1, 3);//update factura efectivo


                            //rptBoletaLibro fac = new rptBoletaLibro(fact1, psConnection, rptFactura.TipoCopia.Azul);
                            rptBoletaLibro bol = new rptBoletaLibro(row.numero, row.cliente, row.valor, row.fecha);
                            bol.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                            ReportPrintTool printReport = new ReportPrintTool(bol);
                            //printReport.ShowPreview();
                            //printReport.Print("EPSON TM-U220 Receipt");
                            printReport.PrinterSettings.PrinterName = "EPSON TM-U220 Receipt";
                            printReport.Print();
                            CargarDatosLibros();
                        }
                        break;
                    case 2:
                        //UpdateFacturaPagada(row.id, 2);
                        frmPagoTarjeta frm2 = new frmPagoTarjeta(row.valor);
                        if (frm2.ShowDialog() == DialogResult.OK)
                        {
                            int id_ = row.id;
                            //3 es el tipo "Boleta de Libros"
                            UpdateDocumentoLibro_Reserva(row.id, 2, 3);//update factura efectivo


                            //rptBoletaLibro fac = new rptBoletaLibro(fact1, psConnection, rptFactura.TipoCopia.Azul);
                            rptBoletaLibro bol = new rptBoletaLibro(row.numero, row.cliente, row.valor, row.fecha);
                            bol.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                            ReportPrintTool printReport = new ReportPrintTool(bol);
                            //printReport.ShowPreview();
                            //printReport.Print("EPSON TM-U220 Receipt");
                            printReport.PrinterSettings.PrinterName = "EPSON TM-U220 Receipt";
                            printReport.Print();
                            CargarDatosLibros();
                        }
                        break;
                    case 3:

                        //UpdateFacturaPagada(row.id, 2);
                        frmPagoTransferencia frm3 = new frmPagoTransferencia(row.valor);
                        if (frm3.ShowDialog() == DialogResult.OK)
                        {
                            int id_ = row.id;
                            //3 es el tipo "Boleta de Libros"
                            UpdateDocumentoLibro_Reserva(row.id, 3, 3);//Pagada con transferencia


                            //rptBoletaLibro fac = new rptBoletaLibro(fact1, psConnection, rptFactura.TipoCopia.Azul);
                            rptBoletaLibro bol = new rptBoletaLibro(row.numero, row.cliente, row.valor, row.fecha);
                            bol.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                            ReportPrintTool printReport = new ReportPrintTool(bol);
                            //printReport.ShowPreview();
                            //printReport.Print("EPSON TM-U220 Receipt");
                            printReport.PrinterSettings.PrinterName = "EPSON TM-U220 Receipt";
                            try
                            {
                                printReport.Print();
                            }
                            catch
                            {
                                printReport.ShowPreview();
                            }
                            CargarDatosLibros();
                        }
                        break;
                }

            }
        }

        private void repositoryItemButtonEdit5_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            AnularBoleta(3, 0);
        }

        public void AnularBoleta(int ptipoBoleta, int pId)
        {
            object grid_;
            switch (ptipoBoleta)
            {
                case 3://Libros
                    //grid_ = gridControl5.FocusedView;
                    var gridView = (GridView)gridControl5.FocusedView;
                    var row = (dsCaja.LibrosliberadasRow)gridView.GetFocusedDataRow();
                    DialogResult r = CajaDialogo.Pregunta("Realmente desea anular esta Boleta?");
                    if (r == DialogResult.Yes)
                    {
                        try
                        {
                            //string sql = @"select * from admon.ft_anular_boleta_v2(:p_id,:p_tipo);";
                            string sql = @"[sp_caja_anular_v2]";
                            SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                            conn.Open();
                            SqlCommand cmd = new SqlCommand(sql, conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id", row.id);
                            cmd.Parameters.AddWithValue("@tipo_boleta", 3);//boletas de libro
                            cmd.ExecuteScalar();
                            CajaDialogo.Information("Transacción Exitosa!");
                            CargarDatosLibros();
                        }
                        catch (Exception ec)
                        {
                            CajaDialogo.Error(ec.Message);
                        }
                    }
                    break;
                case 4://Reserva
                    var gridView1 = (GridView)gridControl7.FocusedView;
                    var row1 = (dsCaja.ReservasLiberadasRow)gridView1.GetFocusedDataRow();
                    DialogResult r1 = CajaDialogo.Pregunta("Realmente desea anular esta Boleta?");
                    if (r1 == DialogResult.Yes)
                    {
                        try
                        {
                            //string sql = @"select * from admon.ft_anular_boleta_v2(:p_id,:p_tipo);";
                            string sql = @"sp_caja_anular_v2";
                            SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                            conn.Open();
                            SqlCommand cmd = new SqlCommand(sql, conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id", row1.id);
                            cmd.Parameters.AddWithValue("@tipo_boleta", 4);
                            cmd.ExecuteScalar();
                            CajaDialogo.Information("Transacción Exitosa!");
                            CargarDatosReservas();
                        }
                        catch (Exception ec)
                        {
                            CajaDialogo.Error(ec.Message);
                        }
                    }
                    break;
                default:
                    grid_ = null;
                    break;
            }

        }

        private void cmdReimprimir_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl5.FocusedView;
            var row = (dsCaja.LibrosliberadasRow)gridView.GetFocusedDataRow();
            rptBoletaLibro bol = new rptBoletaLibro(row.numero, row.cliente, row.valor, row.fecha);
            bol.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            ReportPrintTool printReport = new ReportPrintTool(bol);
            //printReport.ShowPreview();
            //printReport.Print("EPSON TM-U220 Receipt");
            printReport.PrinterSettings.PrinterName = "EPSON TM-U220 Receipt";
            try
            {
                printReport.Print();
            }
            catch
            {
                printReport.ShowPreview();
            }
        }

        private void repositoryItemButtonEdit8_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Reservas
            var gridView = (GridView)gridControl8.FocusedView;
            var row = (dsCaja.ReservasPendientesRow)gridView.GetFocusedDataRow();
            frmTipoPago frm = new frmTipoPago();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                switch (frm.TipoPago)
                {
                    case 1:
                        frmPagoEfectivo frm1 = new frmPagoEfectivo(row.valor);
                        if (frm1.ShowDialog() == DialogResult.OK)
                        {
                            int id = row.id;
                            //3 es el tipo "Boleta de Libros"
                            UpdateDocumentoLibro_Reserva(id, 1, 4);//update factura efectivo


                            //rptBoletaLibro fac = new rptBoletaLibro(fact1, psConnection, rptFactura.TipoCopia.Azul);
                            rptBoletaReserva bol = new rptBoletaReserva(row.numero, row.cliente, row.valor, row.fecha);
                            bol.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                            ReportPrintTool printReport = new ReportPrintTool(bol);
                            //printReport.ShowPreview();
                            //printReport.Print("EPSON TM-U220 Receipt");
                            printReport.PrinterSettings.PrinterName = "EPSON TM-U220 Receipt";
                            printReport.Print();
                            CargarDatosReservas();
                        }
                        break;
                    case 2:
                        //UpdateFacturaPagada(row.id, 2);
                        frmPagoTarjeta frm2 = new frmPagoTarjeta(row.valor);
                        if (frm2.ShowDialog() == DialogResult.OK)
                        {
                            int id_ = row.id;
                            //3 es el tipo "Boleta de Libros"
                            UpdateDocumentoLibro_Reserva(row.id, 2, 4);//update factura efectivo


                            //rptBoletaLibro fac = new rptBoletaLibro(fact1, psConnection, rptFactura.TipoCopia.Azul);
                            rptBoletaReserva bol = new rptBoletaReserva(row.numero, row.cliente, row.valor, row.fecha);
                            bol.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                            ReportPrintTool printReport = new ReportPrintTool(bol);
                            //printReport.ShowPreview();
                            //printReport.Print("EPSON TM-U220 Receipt");
                            printReport.PrinterSettings.PrinterName = "EPSON TM-U220 Receipt";
                            printReport.Print();
                            CargarDatosReservas();
                        }
                        break;
                    case 3:

                        //UpdateFacturaPagada(row.id, 2);
                        frmPagoTransferencia frm3 = new frmPagoTransferencia(row.valor);
                        if (frm3.ShowDialog() == DialogResult.OK)
                        {
                            int id_ = row.id;
                            //3 es el tipo "Boleta de Libros"
                            UpdateDocumentoLibro_Reserva(row.id, 3, 4);//Pagada con transferencia


                            //rptBoletaLibro fac = new rptBoletaLibro(fact1, psConnection, rptFactura.TipoCopia.Azul);
                            rptBoletaReserva bol = new rptBoletaReserva(row.numero, row.cliente, row.valor, row.fecha);
                            bol.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                            ReportPrintTool printReport = new ReportPrintTool(bol);
                            //printReport.ShowPreview();
                            //printReport.Print("EPSON TM-U220 Receipt");
                            printReport.PrinterSettings.PrinterName = "EPSON TM-U220 Receipt";
                            try
                            {
                                printReport.Print();
                            }
                            catch
                            {
                                printReport.ShowPreview();
                            }
                            CargarDatosReservas();
                        }
                        break;
                }

            }
        }

        private void repositoryItemButtonEdit7_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            AnularBoleta(4, 0);
        }

        private void cmdReimprimir__ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl7.FocusedView;
            var row = (dsCaja.ReservasLiberadasRow)gridView.GetFocusedDataRow();
            rptBoletaReserva bol = new rptBoletaReserva(row.numero, row.cliente, row.valor, row.fecha);
            bol.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            ReportPrintTool printReport = new ReportPrintTool(bol);
            //printReport.ShowPreview();
            //printReport.Print("EPSON TM-U220 Receipt");
            printReport.PrinterSettings.PrinterName = "EPSON TM-U220 Receipt";
            try
            {
                printReport.Print();
            }
            catch
            {
                printReport.ShowPreview();
            }
        }
    }
}