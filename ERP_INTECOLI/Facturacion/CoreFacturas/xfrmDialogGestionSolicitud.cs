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
    public partial class xfrmDialogGestionSolicitud : DevExpress.XtraEditors.XtraForm
    {
       
        enum EstadoSolicitud { 
                Pendiente=1,
                Aprobada=2,
                Rechazada=3
        }

        string[] Estados =  { "Pendiente","Aprobada","Rechazada" };

        EstadoSolicitud seleccionGestion;
        UserLogin usuarioLogeado;
        

       Factura_SolicitudAutorizacion datosSolicitud= new Factura_SolicitudAutorizacion();

        public xfrmDialogGestionSolicitud(long id_solicitudP, UserLogin usuarioLog)
        {
            InitializeComponent();
            LoadData();
            //TipoAutorizacionSeleccionada = tAutorizacion;
            datosSolicitud.RecuperaRegistro(id_solicitudP);
            usuarioLogeado = usuarioLog;
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
            try
            {

                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP);
                seleccionGestion = EstadoSolicitud.Rechazada;


                switch (datosSolicitud.TipoAutorizacionID)
                {
                    case 1://Anulacion
                        using (SqlCommand cmd = new SqlCommand("dbo.GestionAutorizacionAnulacion", cnx))
                        {
                            cnx.Open();

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@id_pdv", SqlDbType.Int).Value = datosSolicitud.PuntoDeVenta_Id;
                            cmd.Parameters.Add("@id_factura_H", SqlDbType.BigInt).Value = datosSolicitud.FacturaId;
                            cmd.Parameters.Add("@estado", SqlDbType.Int).Value = Convert.ToInt32(seleccionGestion);
                            cmd.Parameters.Add("@id_solicitud", SqlDbType.Int).Value = datosSolicitud.Id;
                            cmd.Parameters.Add("@id_user", SqlDbType.BigInt).Value = usuarioLogeado.Id;
                            cmd.Parameters.Add("@FechaProceso", SqlDbType.DateTime).Value = DateTime.Now;

                            cmd.ExecuteNonQuery();

                            CajaDialogo.Information("La solicitud ha sido " + Estados[Convert.ToInt32(seleccionGestion) - 1]);
                            this.DialogResult = DialogResult.OK;
                            cnx.Close();
                        }
                        break;



                    case 2://Reimpresion
                        using (SqlCommand cmd = new SqlCommand("dbo.GestionAutorizacionReimpresion", cnx))
                        {
                            cnx.Open();

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@id_pdv", SqlDbType.Int).Value = datosSolicitud.PuntoDeVenta_Id;
                            cmd.Parameters.Add("@id_factura_H", SqlDbType.BigInt).Value = datosSolicitud.FacturaId;
                            cmd.Parameters.Add("@estado", SqlDbType.Int).Value = Convert.ToInt32(seleccionGestion);
                            cmd.Parameters.Add("@id_solicitud", SqlDbType.BigInt).Value = datosSolicitud.Id;
                            cmd.Parameters.Add("@id_user", SqlDbType.BigInt).Value = usuarioLogeado.Id;
                            cmd.Parameters.Add("@FechaProceso", SqlDbType.DateTime).Value = DateTime.Now;

                            cmd.ExecuteNonQuery();

                            CajaDialogo.Information("Solicitud ha sido " + Estados[Convert.ToInt32(seleccionGestion) - 1]);
                            this.DialogResult = DialogResult.OK;
                            cnx.Close();
                        }
                        break;

                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cdmConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
              
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP);
                seleccionGestion = EstadoSolicitud.Aprobada;


                switch (datosSolicitud.TipoAutorizacionID)
                {
                    case 1://Anulacion
                        using (SqlCommand cmd = new SqlCommand("dbo.GestionAutorizacionAnulacion", cnx))
                        {
                            cnx.Open();

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@id_pdv", SqlDbType.Int).Value = datosSolicitud.PuntoDeVenta_Id;
                            cmd.Parameters.Add("@id_factura_H", SqlDbType.BigInt).Value = datosSolicitud.FacturaId;
                            cmd.Parameters.Add("@estado", SqlDbType.Int).Value = Convert.ToInt32(seleccionGestion);
                            cmd.Parameters.Add("@id_solicitud", SqlDbType.BigInt).Value = datosSolicitud.Id;
                            cmd.Parameters.Add("@id_user", SqlDbType.Int).Value = usuarioLogeado.Id;
                            cmd.Parameters.Add("@FechaProceso", SqlDbType.DateTime).Value = DateTime.Now;

                            cmd.ExecuteNonQuery();

                            CajaDialogo.Information("La solicitud ha sido " + Estados[Convert.ToInt32(seleccionGestion) - 1]);
                            this.DialogResult = DialogResult.OK;
                            cnx.Close();
                        }
                        break;


                    case 2://Reimpresion
                        using (SqlCommand cmd = new SqlCommand("dbo.GestionAutorizacionReimpresion", cnx))
                        {
                            cnx.Open();

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@id_pdv", SqlDbType.Int).Value = datosSolicitud.PuntoDeVenta_Id;
                            cmd.Parameters.Add("@id_factura_H", SqlDbType.BigInt).Value = datosSolicitud.FacturaId;
                            cmd.Parameters.Add("@estado", SqlDbType.Int).Value = Convert.ToInt32(seleccionGestion);
                            cmd.Parameters.Add("@id_solicitud", SqlDbType.BigInt).Value = datosSolicitud.Id;
                            cmd.Parameters.Add("@id_user", SqlDbType.Int).Value = usuarioLogeado.Id;
                            cmd.Parameters.Add("@FechaProceso", SqlDbType.DateTime).Value = DateTime.Now;

                            cmd.ExecuteNonQuery();

                            CajaDialogo.Information("La solicitud ha sido " + Estados[Convert.ToInt32(seleccionGestion) - 1]);
                            this.DialogResult = DialogResult.OK;
                            cnx.Close();
                        }
                        break;

                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}