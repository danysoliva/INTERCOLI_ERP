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
    public partial class xfrmDialogAutorizacionConfirmation : DevExpress.XtraEditors.XtraForm
    {
        Factura factura = new Factura();
        int factura_id = 0;

       public enum TipoAutorizacion
        {
            Anulacion=1,
            Reimpresion=2,
            NotaCreditoDebito=3
        }

        TipoAutorizacion TipoAutorizacionSeleccionada;
        Factura_SolicitudAutorizacion datosSolicitud;

        public xfrmDialogAutorizacionConfirmation(Factura_SolicitudAutorizacion solicitud, TipoAutorizacion autorizacion)
        {
            InitializeComponent();
            LoadData();
            //TipoAutorizacionSeleccionada = tAutorizacion;
            datosSolicitud = solicitud;

            TipoAutorizacionSeleccionada = autorizacion;
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

                    SqlDataAdapter da = new SqlDataAdapter("dbo.uspObtenerClientesFacturacion", cnx);
                    da.Fill(dsFacturasGestion.TipoAutorizacion);

                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cdmConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty( txtJustificacion.Text))
                {
                    CajaDialogo.Error("Antes de confirmar, debe de ingresar una justificación para esta solicitud");
                    return;
                }

                DataOperations dp = new DataOperations();
                bool guardado = false;

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP);
                long id_inserted = 0;


                switch (TipoAutorizacionSeleccionada)
                {
                    case TipoAutorizacion.Anulacion:
                        foreach (var item in datosSolicitud.Facturas_seleccionadas)
                        {
                            using (SqlCommand cmd = new SqlCommand("dbo.usp_Facturacion_InsertSolicitudAutorizacion", cnx))
                            {
                                cnx.Open();

                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add("@id_tipoAutorizacion", SqlDbType.Int).Value = datosSolicitud.TipoAutorizacionID;
                                cmd.Parameters.Add("@justificacion", SqlDbType.VarChar).Value = txtJustificacion.Text;
                                cmd.Parameters.Add("@created_date", SqlDbType.DateTime).Value = DateTime.Now;
                                cmd.Parameters.Add("@id_pdv", SqlDbType.Int).Value = datosSolicitud.PuntoDeVenta_Id;
                                cmd.Parameters.Add("@id_usuario_solicita", SqlDbType.Int).Value = datosSolicitud.UsuarioSolicita_Id;
                                cmd.Parameters.Add("@id_cliente", SqlDbType.BigInt).Value = datosSolicitud.ClienteId;
                                //cmd.Parameters.Add("@factura_id_H", SqlDbType.BigInt).Value = datosSolicitud.FacturaId;

                                id_inserted = Convert.ToInt64(cmd.ExecuteScalar());

                                cnx.Close();
                            }


                            using (SqlCommand cmd2 = new SqlCommand("dbo.uspInsertAutorizacion_FacuracionAsociada", cnx))
                            {
                                cnx.Open();

                                cmd2.CommandType = CommandType.StoredProcedure;
                                cmd2.Parameters.Add("@id_autorizacion_h", SqlDbType.BigInt).Value = id_inserted;
                                cmd2.Parameters.Add("@id_factura", SqlDbType.BigInt).Value = item;
                                cmd2.Parameters.Add("@created_date", SqlDbType.DateTime).Value = DateTime.Now;

                                cmd2.ExecuteNonQuery();
                                guardado = true;
                                cnx.Close();
                            }
                        }


                        if (guardado == true)
                        {

                            CajaDialogo.Information("Solicitud creada satisfactoriamente!. Se estará procesando su solicitud lo más pronto posible.");
                            this.DialogResult = DialogResult.OK;
                        }
                        break;
                    case TipoAutorizacion.Reimpresion:
                        foreach (var item in datosSolicitud.Facturas_seleccionadas)
                        {
                            using (SqlCommand cmd = new SqlCommand("dbo.usp_Facturacion_InsertSolicitudAutorizacion", cnx))
                            {
                                cnx.Open();

                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add("@id_tipoAutorizacion", SqlDbType.Int).Value = datosSolicitud.TipoAutorizacionID;
                                cmd.Parameters.Add("@justificacion", SqlDbType.VarChar).Value = txtJustificacion.Text;
                                cmd.Parameters.Add("@created_date", SqlDbType.DateTime).Value = DateTime.Now;
                                cmd.Parameters.Add("@id_pdv", SqlDbType.Int).Value = datosSolicitud.PuntoDeVenta_Id;
                                cmd.Parameters.Add("@id_usuario_solicita", SqlDbType.Int).Value = datosSolicitud.UsuarioSolicita_Id;
                                cmd.Parameters.Add("@id_cliente", SqlDbType.BigInt).Value = datosSolicitud.ClienteId;
                                //cmd.Parameters.Add("@factura_id_H", SqlDbType.BigInt).Value = datosSolicitud.FacturaId;

                                id_inserted = Convert.ToInt64(cmd.ExecuteScalar());

                                cnx.Close();
                            }


                            using (SqlCommand cmd2 = new SqlCommand("dbo.uspInsertAutorizacion_FacuracionAsociada", cnx))
                            {
                                cnx.Open();

                                cmd2.CommandType = CommandType.StoredProcedure;
                                cmd2.Parameters.Add("@id_autorizacion_h", SqlDbType.BigInt).Value = id_inserted;
                                cmd2.Parameters.Add("@id_factura", SqlDbType.BigInt).Value = item;
                                cmd2.Parameters.Add("@created_date", SqlDbType.DateTime).Value = DateTime.Now;

                                cmd2.ExecuteNonQuery();
                                guardado = true;
                                cnx.Close();
                            }
                        }


                        if (guardado == true)
                        {

                            CajaDialogo.Information("Solicitud creada satisfactoriamente!. Se estará procesando su solicitud lo más pronto posible.");
                            this.DialogResult = DialogResult.OK;
                        }
                        break;
                    case TipoAutorizacion.NotaCreditoDebito:

                        using (SqlCommand cmd = new SqlCommand("dbo.usp_Facturacion_InsertSolicitudAutorizacion", cnx))
                        {
                            cnx.Open();

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@id_tipoAutorizacion", SqlDbType.Int).Value = datosSolicitud.TipoAutorizacionID;
                            cmd.Parameters.Add("@justificacion", SqlDbType.VarChar).Value = txtJustificacion.Text;
                            cmd.Parameters.Add("@created_date", SqlDbType.DateTime).Value = DateTime.Now;
                            cmd.Parameters.Add("@id_pdv", SqlDbType.Int).Value = datosSolicitud.PuntoDeVenta_Id;
                            cmd.Parameters.Add("@id_usuario_solicita", SqlDbType.Int).Value = datosSolicitud.UsuarioSolicita_Id;
                            cmd.Parameters.Add("@id_cliente", SqlDbType.BigInt).Value = datosSolicitud.ClienteId;
                            //cmd.Parameters.Add("@factura_id_H", SqlDbType.BigInt).Value = datosSolicitud.FacturaId;

                            id_inserted = Convert.ToInt64(cmd.ExecuteScalar());

                            //CajaDialogo.Information("Solicitud creada satisfactoriamente!. Se estará procesando su solicitud lo más pronto posible.");
                            //this.DialogResult = DialogResult.OK;
                            cnx.Close();
                        }


                        foreach (var item in datosSolicitud.Facturas_seleccionadas)
                        {
                            using (SqlCommand cmd2 = new SqlCommand("dbo.uspInsertAutorizacion_FacuracionAsociada", cnx))
                            {
                                cnx.Open();

                                cmd2.CommandType = CommandType.StoredProcedure;
                                cmd2.Parameters.Add("@id_autorizacion_h", SqlDbType.BigInt).Value = id_inserted;
                                cmd2.Parameters.Add("@id_factura", SqlDbType.BigInt).Value = item;
                                cmd2.Parameters.Add("@created_date", SqlDbType.DateTime).Value = DateTime.Now;

                                cmd2.ExecuteNonQuery();
                                guardado = true;
                                cnx.Close();
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


            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}