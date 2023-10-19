using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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

namespace JAGUAR_APP.Facturacion.CoreFacturas
{
    public partial class xfrmDialogAutorizacion : DevExpress.XtraEditors.XtraForm
    {
        Factura factura = new Factura();
        int factura_id = 0;
        PuntoVenta PuntoVentaActual;

        UserLogin userLogin;

        Factura_SolicitudAutorizacion solicitud = new Factura_SolicitudAutorizacion();
       public enum TipoAutorizacion
        {
            Anulacion=1,
            Reimpresion=2,
            NotaCredito_Debito=3
        }

        TipoAutorizacion tipoAutorizacionActual;
        public xfrmDialogAutorizacion(Factura_SolicitudAutorizacion request)
        {
            InitializeComponent();
            LoadData();
            //userLogin = usuarioLog;
            solicitud = request;
        }

        public xfrmDialogAutorizacion(Factura_SolicitudAutorizacion request, PuntoVenta pPuntoVenta)
        {
            InitializeComponent();
            PuntoVentaActual = pPuntoVenta;
            LoadData();
            //userLogin = usuarioLog;
            solicitud = request;
        }

        private void LoadData()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP))
                {
                    cnx.Open();
                    dsFacturasGestion.TipoAutorizacion.Clear();

                    SqlCommand cmd = cnx.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (this.PuntoVentaActual == null)
                    {
                        cmd.CommandText = "dbo.LoadTiposAutorizacion";
                    }
                    else
                    {
                        cmd.CommandText = "[dbo].[LoadTiposAutorizacion_by_punto_venta_V2]";
                        cmd.Parameters.AddWithValue("@id_punto_venta", this.PuntoVentaActual.ID);
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dsFacturasGestion.TipoAutorizacion);

                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnAutorizar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsFacturasGestion.TipoAutorizacionRow)grd_data.GetFocusedDataRow();

                solicitud.TipoAutorizacionID = row.id;


                if (ValidarSolicitudExistente())
                {
                    CajaDialogo.Error("Ya existe una solicitud en proceso para la factura seleccionada");
                    return;
                }

                if (row.id==3)
                {
                    if (solicitud.Clientes_Seleccionados.Distinct().Count() != 1)
                    {
                        CajaDialogo.Error("Para autorizar Notas de Crédito y Débito, debe seleccionar facturas del mismo cliente");
                        return;
                    }
                }

                switch (row.id)
                {
                    case 2:
                        xfrmDialogAutorizacionConfirmation confirm = new xfrmDialogAutorizacionConfirmation(solicitud,xfrmDialogAutorizacionConfirmation.TipoAutorizacion.Reimpresion);

                        if (confirm.ShowDialog() == DialogResult.OK)
                        {
                            this.Close();
                        }
                        break;
                    case 1:
                        xfrmDialogAutorizacionConfirmation confirm2 = new xfrmDialogAutorizacionConfirmation(solicitud, xfrmDialogAutorizacionConfirmation.TipoAutorizacion.Anulacion);

                        if (confirm2.ShowDialog() == DialogResult.OK)
                        {
                            this.Close();
                        }
                        break;
                    case 3:
                        xfrmDialogAutorizacionConfirmation confirm3 = new xfrmDialogAutorizacionConfirmation(solicitud, xfrmDialogAutorizacionConfirmation.TipoAutorizacion.Reimpresion);

                        if (confirm3.ShowDialog() == DialogResult.OK)
                        {
                            this.Close();
                        }
                        break;
                }

                
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }


        private bool ValidarSolicitudExistente()
        {
            try
            {
                DataOperations dp = new DataOperations();
                bool existeSolicitud;

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP);

                using (SqlCommand cmd = new SqlCommand("ValidarSolicitudAutorizacionExistente", cnx))
                {
                    cnx.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id_factura", solicitud.FacturaId);
                    cmd.Parameters.Add("@id_tipo_autorizacion", solicitud.TipoAutorizacionID);

                    existeSolicitud = Convert.ToBoolean(cmd.ExecuteScalar());
                    cnx.Close();
                }


                return existeSolicitud;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return false;
            }
        }
    }
}