using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using DevExpress.CodeParser;
using ERP_INTECOLI.Clases;

namespace JAGUAR_APP.Facturacion.Reportes
{
    public partial class rpt_cierre_dia_complete : DevExpress.XtraReports.UI.XtraReport
    {
        PuntoVenta PuntoVentaActual;
        public rpt_cierre_dia_complete(FacturacionCierreDiaPuntoVenta cierre1)
        {
            InitializeComponent();
            if ( cierre1 != null)
            {
                if (cierre1.Recuperado)
                {
                    PuntoVentaActual = new PuntoVenta();
                    if (PuntoVentaActual.RecuperaRegistro(cierre1.id_punto_venta))
                    {
                        lblDireccion.Text = PuntoVentaActual.Direccion;
                        lblCompanyName.Text = PuntoVentaActual.Nombre;
                        lblLegalName.Text = PuntoVentaActual.NombreLegal;
                        lblCodigoCierreDia.Text = cierre1.codigo;
                    }
                    lblResponsable.Text = cierre1.usuario_responsable_nombre;
                    lblRevisadoPor.Text = cierre1.usuario_validacion_nombre;
                    lblFechaCierre.Text = string.Format("{0:dd/MMM/yyyy}", cierre1.fecha);

                    LoadDatosHeader(cierre1.id);

                    LoadDatosDetalle(cierre1.id);
                }
            }
            
        }

        private void LoadDatosHeader(Int64 pIdCierre)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_datos_resumen_cierre_caja_by_id_v2]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCierreH", pIdCierre);
                SqlDataReader dr = cmd.ExecuteReader();
                decimal Total = 0;
                decimal TotalC = 0;

                while (dr.Read())
                {
                    int tipopago = 0;
                    if (!dr.IsDBNull(dr.GetOrdinal("id_tipo_pago")))
                        tipopago = dr.GetInt32(1);

                    

                    switch(tipopago)
                    {
                        case 1:
                            decimal valor1 = dr.GetDecimal(3);
                            decimal valorC1 = dr.GetDecimal(4);

                            Total += valor1;
                            TotalC += valorC1;
                            lblTotalEfectivo.Text = string.Format("{0:L ###,##0.00}", valor1);
                            lblTotalEfectivoVerificado.Text = string.Format("{0:L ###,##0.00}", valorC1);
                            break;
                        case 2:
                            decimal valor2 = dr.GetDecimal(3);
                            decimal valorC2 = dr.GetDecimal(4);
                            Total += valor2;
                            TotalC += valorC2;
                            lblTotalTarjetas.Text = string.Format("{0:L ###,##0.00}", valor2);
                            lblTotalTarjetaVerificado.Text = string.Format("{0:L ###,##0.00}", valorC2);
                            break; 
                        case 3:
                            decimal valor3 = dr.GetDecimal(3);
                            decimal valorC3 = dr.GetDecimal(4);
                            Total += valor3;
                            TotalC += valorC3;
                            lblTotalDeposito.Text = string.Format("{0:L ###,##0.00}", valor3);
                            lblTotalBancosVerificado.Text = string.Format("{0:L ###,##0.00}", valorC3);
                            break;
                            case 4:
                            decimal valor4 = dr.GetDecimal(3);
                            decimal valorC4 = dr.GetDecimal(4);
                            Total += valor4;
                            TotalC += valorC4;
                            lblTotalDeposito.Text = string.Format("{0:L ###,##0.00}", valor4);
                            lblTotalBancosVerificado.Text = string.Format("{0:L ###,##0.00}", valorC4);
                            break;
                        case 5:
                            break;
                        default:
                            break;
                    }
                    
                }
                lblTotalIngresos.Text = string.Format("{0:L ###,##0.00}", Total);
                lblTotalVerificado.Text = string.Format("{0:L ###,##0.00}", TotalC);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadDatosDetalle(Int64 pIdCierre)
        {
            //
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_home_facturacion_punto_venta_print_version]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCierreDia", pIdCierre);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsContabilidad1.HomeFacturasPrint.Clear();
                adat.Fill(dsContabilidad1.HomeFacturasPrint);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}
