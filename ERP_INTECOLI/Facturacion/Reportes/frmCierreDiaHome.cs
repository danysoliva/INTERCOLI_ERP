using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using ERP_INTECOLI.Clases;
using ERP_INTECOLI.Facturacion.CoreFacturas;
using JAGUAR_APP.Facturacion.CoreFacturas;
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

namespace JAGUAR_APP.Facturacion.Reportes
{
    public partial class frmCierreDiaHome : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        PuntoVenta PuntoVenta;
        DataOperations dp;
        public frmCierreDiaHome(UserLogin puser, PuntoVenta pPuntoVenta)
        {
            InitializeComponent();
            dp = new DataOperations();
            UsuarioLogeado = puser;
            PuntoVenta = pPuntoVenta;
            
            LoadPuntosVenta();

            if (PuntoVenta == null)
            {
                PuntoVenta = new PuntoVenta();
            }
            else
            {
                glePuntoVenta.EditValueChanged -= new EventHandler(glePuntoVenta_EditValueChanged);
                glePuntoVenta.EditValue = PuntoVenta.ID;
                glePuntoVenta.EditValueChanged -= new EventHandler(glePuntoVenta_EditValueChanged);
            }
                
            

            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.Id, 11);//11=Ovejita
            switch (idNivel)
            {
                case 1://Basic View
                case 2://Basic No Autorization
                case 3://Medium Autorization
                    glePuntoVenta.Visible = false;
                    lblSeleccionarPuntoVenta.Visible = false;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    //Accesso a costos
                    glePuntoVenta.Visible = true;
                    lblSeleccionarPuntoVenta.Visible = true;
                    break;
                default:
                    glePuntoVenta.Visible = false;
                    lblSeleccionarPuntoVenta.Visible = false;
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(7))
                {
                    glePuntoVenta.Visible = true;
                    lblSeleccionarPuntoVenta.Visible = true;
                }
                else
                {
                    //CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #7");
                }
            }
            Load_Lista_Cierres();

        }

        private void LoadPuntosVenta()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_lista_puntos_de_venta]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                dsContabilidad1.punto_venta.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsContabilidad1.punto_venta);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void Load_Lista_Cierres()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[usp_GetFacturacionCierreDiaPuntoVenta_all_puntos_venta]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@fechadesde", fechaDesde);
                //cmd.Parameters.AddWithValue("@fechahasta", fechaHasta);
                cmd.Parameters.AddWithValue("@id_punto_venta", PuntoVenta.ID);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsContabilidad1.cierre_dia_home.Clear();
                adat.Fill(dsContabilidad1.cierre_dia_home);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            frmArqueoCaja frm = new frmArqueoCaja(this.UsuarioLogeado, this.PuntoVenta,0, frmArqueoCaja.TipoTransaccion.Insert, false);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //var row = (dsContabilidad.cierre_dia_homeRow)gridView1.GetFocusedDataRow();
                dsContabilidad.cierre_dia_homeRow row = dsContabilidad1.cierre_dia_home.Newcierre_dia_homeRow();
                row.id_estado = frm.CierreDiaActual.id_estado;
                row.estado_descripcion = frm.CierreDiaActual.estado_descripcion;
                row.id_user_validacion = frm.CierreDiaActual.id_user_validacion;
                row.usuario_validacion_nombre = frm.CierreDiaActual.usuario_validacion_nombre;
                row.codigo = frm.CierreDiaActual.codigo;
                row.id = frm.CierreDiaActual.id;
                row.id_user_responsable = frm.CierreDiaActual.id_user_responsable;
                row.usuario_responsable_nombre = frm.CierreDiaActual.usuario_responsable_nombre;
                row.fecha = frm.CierreDiaActual.fecha;
                row.id_punto_venta = frm.CierreDiaActual.id_punto_venta;
                row.punto_venta_descripcion = frm.CierreDiaActual.punto_venta_descripcion;

                dsContabilidad1.cierre_dia_home.Addcierre_dia_homeRow(row);
                dsContabilidad1.AcceptChanges();

               
            }
        }

        private void cmdEditarCierre_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Editar Cierre
            bool accesoprevio = false;
            bool PermitirAcceso = false; 
            int idNivel = this.UsuarioLogeado.idNivelAcceso(UsuarioLogeado.Id, 11);//9 = AMS
            switch (idNivel)                                                      //11 = Jaguar
            {
                case 1://Basic View
                    accesoprevio = true;
                    break;
                case 2://Basic No Autorization
                    accesoprevio = true;
                    break;
                case 3://Medium Autorization
                    accesoprevio = true;
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    PermitirAcceso = accesoprevio = true;
                    break;
                default:
                    break;
            }


            if (PermitirAcceso)
            {
                var row = (dsContabilidad.cierre_dia_homeRow)gridView1.GetFocusedDataRow();
                frmArqueoCaja frm = new frmArqueoCaja(this.UsuarioLogeado, this.PuntoVenta, row.id, frmArqueoCaja.TipoTransaccion.Update, true);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    row.id_estado = frm.CierreDiaActual.id_estado;
                    row.estado_descripcion = frm.CierreDiaActual.estado_descripcion;
                    row.id_user_validacion = frm.CierreDiaActual.id_user_validacion;
                    row.usuario_validacion_nombre = frm.CierreDiaActual.usuario_validacion_nombre;
                    row.codigo = frm.CierreDiaActual.codigo;
                    row.id = frm.CierreDiaActual.id;
                }
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(14))
                {
                    PermitirAcceso = true;

                    var row = (dsContabilidad.cierre_dia_homeRow)gridView1.GetFocusedDataRow();
                    frmArqueoCaja frm = new frmArqueoCaja(this.UsuarioLogeado, this.PuntoVenta, row.id, frmArqueoCaja.TipoTransaccion.Update, true);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        row.id_estado = frm.CierreDiaActual.id_estado;
                        row.estado_descripcion = frm.CierreDiaActual.estado_descripcion;
                        row.id_user_validacion = frm.CierreDiaActual.id_user_validacion;
                        row.usuario_validacion_nombre = frm.CierreDiaActual.usuario_validacion_nombre;
                        row.codigo = frm.CierreDiaActual.codigo;
                        row.id = frm.CierreDiaActual.id;
                    }
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #15 (Autorizacion de Cierre de caja)");
                }
            }
        }


        private void cmdImprimirCierres_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Imprimir
            var row = (dsContabilidad.cierre_dia_homeRow)gridView1.GetFocusedDataRow();
            FacturacionCierreDiaPuntoVenta cierreDia = new FacturacionCierreDiaPuntoVenta();
            if (cierreDia.RecuperarRegistro(row.id))
            {
                decimal vEfectivo;
                decimal vTarjeta;
                decimal vBancos;


                rpt_cierre_dia_complete report = new rpt_cierre_dia_complete(cierreDia) { ShowPrintMarginsWarning = false };
                //RPT_OrdenCompra report = new RPT_OrdenCompra(num) { DataSource = dsCompras1, ShowPrintMarginsWarning = false };
                report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                ReportPrintTool printReport = new ReportPrintTool(report);
                printReport.ShowPreviewDialog();
            }
            
        }

        private void cmdVerDetalleCierre_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Ver detalle
            var row = (dsContabilidad.cierre_dia_homeRow)gridView1.GetFocusedDataRow();
            frmArqueoCaja frm = new frmArqueoCaja(this.UsuarioLogeado, this.PuntoVenta, row.id, frmArqueoCaja.TipoTransaccion.Update, false);
            if (frm.ShowDialog() == DialogResult.OK)
                Load_Lista_Cierres();
            
        }

        private void cmdrefresh_Click(object sender, EventArgs e)
        {
            Load_Lista_Cierres();
        }

        private void glePuntoVenta_EditValueChanged(object sender, EventArgs e)
        {
            this.PuntoVenta.ID = dp.ValidateNumberInt32(glePuntoVenta.EditValue);
            Load_Lista_Cierres();
        }
    }
}