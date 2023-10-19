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
    public partial class frmHomeSolicitudesAutorizacion : DevExpress.XtraEditors.XtraForm
    {
        UserLogin usuarioLogeado = new UserLogin();
        public frmHomeSolicitudesAutorizacion(UserLogin userLog)
        {
            InitializeComponent();
            LoadData(false);
            usuarioLogeado = userLog;

        }

        private void LoadData(bool filtro)
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP))
                {
                    cnx.Open();
                    SqlDataAdapter da = new SqlDataAdapter("dbo.uspLoadSolicitudesAutorizacion", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add("@filtro", SqlDbType.Bit).Value = filtro;

                    dsFacturasGestion.SolicitudAutorizacion.Clear();

                    //da.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int).Value = id_cliente;
                    da.Fill(dsFacturasGestion.SolicitudAutorizacion);

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

        private void tsFiltro_Toggled(object sender, EventArgs e)
        {
            LoadData(Convert.ToBoolean( tsFiltro.EditValue));
        }

        private void btnGestionar_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsFacturasGestion.SolicitudAutorizacionRow)grd_data.GetFocusedDataRow();

                switch (row.id_tipoAutorizacion)
                {
                    case 1:
                        xfrmDialogGestionSolicitud frm = new xfrmDialogGestionSolicitud(row.id, usuarioLogeado);

                        if (row.estado_id != 1)
                        {
                            CajaDialogo.Error("Esta solicitud ya ha sido procesada");
                            return;
                        }

                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            LoadData(Convert.ToBoolean(tsFiltro.EditValue));
                        }
                        break;

                    case 2:
                        xfrmDialogGestionSolicitud frm2 = new xfrmDialogGestionSolicitud(row.id, usuarioLogeado);

                        if (row.estado_id != 1)
                        {
                            CajaDialogo.Error("Esta solicitud ya ha sido procesada");
                            return;
                        }

                        if (frm2.ShowDialog() == DialogResult.OK)
                        {
                            LoadData(Convert.ToBoolean(tsFiltro.EditValue));
                        }
                        break;

                    case 3:
                        if (row.estado_id != 1)
                        {
                            CajaDialogo.Error("Esta solicitud ya ha sido procesada");
                            return;
                        }
                        frmNotaCRUD frm3 = new frmNotaCRUD(frmNotaCRUD.SourceSolicitud.FacturaEmitida,row.id, usuarioLogeado);

                        if (frm3.ShowDialog() == DialogResult.OK)
                            LoadData(Convert.ToBoolean(tsFiltro.EditValue));

                        break;
                }

                
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
          
            }
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            LoadData(Convert.ToBoolean(tsFiltro.EditValue));

        }
    }
}