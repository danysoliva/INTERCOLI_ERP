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

namespace ERP_INTECOLI.Administracion.Estudiantes
{
    public partial class frmImportarEstudiantes : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogueado;
        DataOperations dp = new DataOperations();
        PuntoVenta PuntoVentaActual;

        public frmImportarEstudiantes(UserLogin pUserLog, PuntoVenta pPuntoVenta)
        {
            InitializeComponent();
            UsuarioLogueado = pUserLog;
            PuntoVentaActual = pPuntoVenta;
            CargarPuntosVentas();

            gridPuntoVenta.EditValue = PuntoVentaActual.ID;
        }

        private void CargarPuntosVentas()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();
                SqlCommand cmd = new SqlCommand("[sp_get_lista_puntos_de_venta]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsEstudiantes1.punto_venta.Clear();
                adat.Fill(dsEstudiantes1.punto_venta);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}