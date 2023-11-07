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

namespace JAGUAR_APP.Facturacion.CoreFacturas
{
    public partial class frmNavigationPageAutorizacion : DevExpress.XtraEditors.XtraForm
    {
        Factura factura = new Factura();
        int factura_id = 0;
        PuntoVenta PuntoVentaActual;

        UserLogin userLogin;

        Factura_SolicitudAutorizacion solicitud = new Factura_SolicitudAutorizacion();
        public enum TipoAutorizacion
        {
            Anulacion = 1,
            Reimpresion = 2,
            NotaCredito_Debito = 3
        }

        enum TipoNota
        {
            Credito=1,
            Debito=2
        }

        TipoAutorizacion tipoAutorizacionActual;
        public frmNavigationPageAutorizacion(Factura_SolicitudAutorizacion request)
        {
            InitializeComponent();
            LoadData();
            //userLogin = usuarioLog;
            solicitud = request;
        }

        public frmNavigationPageAutorizacion(Factura_SolicitudAutorizacion request, PuntoVenta pPuntoVenta)
        {
            InitializeComponent();
            PuntoVentaActual = pPuntoVenta;
            LoadData();
            //userLogin = usuarioLog;
            solicitud = request;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.navigationFrame1.SelectedPage = npGestionSolicitudConfirmation;
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

        private bool ValidarSolicitudExistente(long id_solicitud)
        {
            try
            {
                DataOperations dp = new DataOperations();
                bool existeSolicitud;

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP);

                using (SqlCommand cmd = new SqlCommand("ValidarSolicitudAutorizacionExistente_V2", cnx))
                {
                    cnx.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id_factura", id_solicitud);
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

        private void btnAutorizar_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsFacturasGestion.TipoAutorizacionRow)grd_data.GetFocusedDataRow();

                solicitud.TipoAutorizacionID = row.id;

                foreach (var item in solicitud.Facturas_seleccionadas)
                {

                    if (ValidarSolicitudExistente(item.FacturaId))
                    {
                        CajaDialogo.Error("Ya existe una solicitud en proceso para la factura seleccionada");
                        return;
                    }
                }

                if (row.id == 3)
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
                        this.tipoAutorizacionActual = TipoAutorizacion.Reimpresion;
                        this.navigationFrame1.SelectedPage = npGestionSolicitudConfirmation;
                        txtJustificacion.Focus();
                        break;
                    case 1:
                        this.tipoAutorizacionActual = TipoAutorizacion.Anulacion;
                        this.navigationFrame1.SelectedPage = npGestionSolicitudConfirmation;
                        txtJustificacion.Focus();
                        break;
                    case 3:
                        this.tipoAutorizacionActual = TipoAutorizacion.NotaCredito_Debito;
                        dsFacturasGestion.facturas_solicitud_NC_ND.Clear();

                        foreach (var item in solicitud.Facturas_seleccionadas)
                        {
                            dsFacturasGestion.facturas_solicitud_NC_ND.Rows.Add(item.FacturaId, item.NumeroFactura, item.Monto,item.PuntoVenda_Id,item.PuntoVenta);
                        }
                        
                        this.navigationFrame1.SelectedPage = npNC_ND;
                        break;
                }


            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

                SqlTransaction transaccion;
        private void cdmConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtJustificacion.Text))
                {
                    CajaDialogo.Error("Antes de confirmar, debe de ingresar una justificación para esta solicitud");
                    return;
                }

                DataOperations dp = new DataOperations();
                bool guardado = false;

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP);
                long id_inserted = 0;

                cnx.Open();
                transaccion = cnx.BeginTransaction();

                switch (tipoAutorizacionActual)
                {
                    case TipoAutorizacion.Anulacion:
                        foreach (var item in solicitud.Facturas_seleccionadas)
                        {
                            using (SqlCommand cmd = new SqlCommand("dbo.usp_Facturacion_InsertSolicitudAutorizacion", transaccion.Connection))
                            {

                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Transaction = transaccion;
                                cmd.Parameters.Add("@id_tipoAutorizacion", SqlDbType.Int).Value = solicitud.TipoAutorizacionID;
                                cmd.Parameters.Add("@justificacion", SqlDbType.VarChar).Value = txtJustificacion.Text;
                                cmd.Parameters.Add("@created_date", SqlDbType.DateTime).Value = DateTime.Now;
                                cmd.Parameters.Add("@id_PuntoVenta", SqlDbType.Int).Value = solicitud.PuntoDeVenta_Id;
                                cmd.Parameters.Add("@id_usuario_solicita", SqlDbType.Int).Value = solicitud.UsuarioSolicita_Id;
                                cmd.Parameters.Add("@id_cliente", SqlDbType.BigInt).Value = solicitud.ClienteId;
                                cmd.Parameters.Add("@id_tipo_nota", SqlDbType.Int).Value = 0;

                                id_inserted = Convert.ToInt64(cmd.ExecuteScalar());

                                //cnx.Close();
                            }


                            using (SqlCommand cmd2 = new SqlCommand("dbo.uspInsertAutorizacion_FacuracionAsociada", transaccion.Connection))
                            {
                                //cnx.Open();

                                cmd2.CommandType = CommandType.StoredProcedure;
                                cmd2.Transaction = transaccion;
                                cmd2.Parameters.Add("@id_autorizacion_h", SqlDbType.BigInt).Value = id_inserted;
                                cmd2.Parameters.Add("@id_factura", SqlDbType.BigInt).Value = item.FacturaId;
                                cmd2.Parameters.Add("@created_date", SqlDbType.DateTime).Value = DateTime.Now;
                                cmd2.Parameters.Add("@monto", SqlDbType.Decimal).Value = 0;

                                cmd2.ExecuteNonQuery();
                                guardado = true;
                                //cnx.Close();
                            }
                        }


                        if (guardado == true)
                        {

                            CajaDialogo.Information("Solicitud creada satisfactoriamente!. Se estará procesando su solicitud lo más pronto posible.");
                            this.DialogResult = DialogResult.OK;
                        }
                        break;
                    case TipoAutorizacion.Reimpresion:
                        foreach (var item in solicitud.Facturas_seleccionadas)
                        {
                            using (SqlCommand cmd = new SqlCommand("dbo.usp_Facturacion_InsertSolicitudAutorizacion", transaccion.Connection))
                            {
                                //cnx.Open();

                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Transaction = transaccion;

                                cmd.Parameters.Add("@id_tipoAutorizacion", SqlDbType.Int).Value = solicitud.TipoAutorizacionID;
                                cmd.Parameters.Add("@justificacion", SqlDbType.VarChar).Value = txtJustificacion.Text;
                                cmd.Parameters.Add("@created_date", SqlDbType.DateTime).Value = dp.NowSetDateTime();
                                cmd.Parameters.Add("@id_PuntoVenta", SqlDbType.Int).Value = solicitud.PuntoDeVenta_Id;
                                cmd.Parameters.Add("@id_usuario_solicita", SqlDbType.Int).Value = solicitud.UsuarioSolicita_Id;
                                cmd.Parameters.Add("@id_cliente", SqlDbType.BigInt).Value = solicitud.ClienteId;
                                cmd.Parameters.Add("@id_tipo_nota", SqlDbType.Int).Value = 0;

                                id_inserted = Convert.ToInt64(cmd.ExecuteScalar());

                                //cnx.Close();
                            }


                            using (SqlCommand cmd2 = new SqlCommand("dbo.uspInsertAutorizacion_FacuracionAsociada", transaccion.Connection))
                            {
                                //cnx.Open();

                                cmd2.CommandType = CommandType.StoredProcedure;
                                cmd2.Transaction = transaccion;

                                cmd2.Parameters.Add("@id_autorizacion_h", SqlDbType.BigInt).Value = id_inserted;
                                cmd2.Parameters.Add("@id_factura", SqlDbType.BigInt).Value = item.FacturaId;
                                cmd2.Parameters.Add("@created_date", SqlDbType.DateTime).Value = DateTime.Now;
                                cmd2.Parameters.Add("@monto", SqlDbType.Decimal).Value = 0;

                                cmd2.ExecuteNonQuery();
                                guardado = true;
                                //cnx.Close();
                            }
                        }


                        if (guardado == true)
                        {

                            CajaDialogo.Information("Solicitud creada satisfactoriamente!. Se estará procesando su solicitud lo más pronto posible.");
                            this.DialogResult = DialogResult.OK;
                        }
                        break;
                    case TipoAutorizacion.NotaCredito_Debito:

                        using (SqlCommand cmd = new SqlCommand("dbo.usp_Facturacion_InsertSolicitudAutorizacion", transaccion.Connection))
                        {
                            //cnx.Open();

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Transaction = transaccion;

                            cmd.Parameters.Add("@id_tipoAutorizacion", SqlDbType.Int).Value = solicitud.TipoAutorizacionID;
                            cmd.Parameters.Add("@justificacion", SqlDbType.VarChar).Value = txtJustificacion.Text;
                            cmd.Parameters.Add("@created_date", SqlDbType.DateTime).Value = DateTime.Now;
                            cmd.Parameters.Add("@id_PuntoVenta", SqlDbType.Int).Value = solicitud.PuntoDeVenta_Id;
                            cmd.Parameters.Add("@id_usuario_solicita", SqlDbType.Int).Value = solicitud.UsuarioSolicita_Id;
                            cmd.Parameters.Add("@id_cliente", SqlDbType.BigInt).Value = solicitud.ClienteId;
                            cmd.Parameters.Add("@id_tipo_nota", SqlDbType.Int).Value = Convert.ToBoolean(toggleSwitch1.EditValue) == true ? (int)TipoNota.Credito : (int)TipoNota.Debito;


                            id_inserted = Convert.ToInt64(cmd.ExecuteScalar());

                            //cnx.Close();
                        }


                        foreach (var item in dsFacturasGestion.facturas_solicitud_NC_ND)
                        {
                            using (SqlCommand cmd2 = new SqlCommand("dbo.uspInsertAutorizacion_FacuracionAsociada", transaccion.Connection))
                            {
                                //cnx.Open();

                                cmd2.CommandType = CommandType.StoredProcedure;
                                cmd2.Transaction = transaccion;

                                cmd2.Parameters.Add("@id_autorizacion_h", SqlDbType.BigInt).Value = id_inserted;
                                cmd2.Parameters.Add("@id_factura", SqlDbType.BigInt).Value = item.id_factura;
                                cmd2.Parameters.Add("@created_date", SqlDbType.DateTime).Value = DateTime.Now;
                                cmd2.Parameters.Add("@monto", SqlDbType.Decimal).Value = item.monto;

                                cmd2.ExecuteNonQuery();
                                guardado = true;
                                //cnx.Close();
                            }
                        }


                        if (guardado == true)
                        {

                            CajaDialogo.Information("Solicitud creada satisfactoriamente!. Se estará procesando su solicitud lo más pronto posible.");
                            this.DialogResult = DialogResult.OK;
                        }
                        break;
                    default:
                        break;
                }

                transaccion.Commit();
                cnx.Close();


            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                transaccion.Rollback();
            }
        }

        private void cdmCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.navigationFrame1.SelectedPage = npGestionSolicitud;
        }

        private void cmdNext_Click(object sender, EventArgs e)
        {
            this.navigationFrame1.SelectedPage = npGestionSolicitudConfirmation;
        }
    }
}