using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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

namespace ERP_INTECOLI.Compras
{
    public partial class frmSearchSolicitud : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public int IdSolicitudSeleccionado = 0;

        public enum FiltroSolicitudes
        {
            Todas = 1,
            Abiertas = 2
        }

        FiltroSolicitudes Filtro;

        public frmSearchSolicitud(frmSearchSolicitud.FiltroSolicitudes pfiltroSolicitudes)
        {
            InitializeComponent();
            Filtro = pfiltroSolicitudes;
            CargarSolicitudes();
            
        }

        private void CargarSolicitudes()
        {
            try
            {
                string query = @"sp_get_all_solicitudes";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                switch (Filtro)
                {
                    case FiltroSolicitudes.Todas:
                        cmd.Parameters.AddWithValue("@filtro",1);
                        break;

                    case FiltroSolicitudes.Abiertas:
                        cmd.Parameters.AddWithValue("@filtro", 2);
                        break;

                    default:
                        break;
                }
                
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.solicitudes.Clear();
                adat.Fill(dsCompras1.solicitudes);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var gridview = (GridView)grdSolicitudes.FocusedView;
            var row = (dsCompras.solicitudesRow)gridview.GetFocusedDataRow();

            if (row.id_estado_solicitud > 0)
            {
                IdSolicitudSeleccionado = row.id_solicitud;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}