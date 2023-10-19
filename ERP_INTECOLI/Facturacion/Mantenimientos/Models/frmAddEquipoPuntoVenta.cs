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

namespace JAGUAR_APP.Facturacion.Mantenimientos.Models
{
    public partial class frmAddEquipoPuntoVenta : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp;
        public PuntoVentaEquipo equipo;
        public PuntoVenta PuntoVentaActual;
        public enum TipoTransaccion
        {
            Insert =1, Update =2
        }

        TipoTransaccion TipoTransaccionActual;
        public frmAddEquipoPuntoVenta(UserLogin pUserLogin, TipoTransaccion pTipoTransaccionActual, int pIdEquipo, int pIdPuntoVenta)
        {
            InitializeComponent();
            dp = new DataOperations();
            equipo = new PuntoVentaEquipo();
            PuntoVentaActual = new PuntoVenta();
            TipoTransaccionActual = pTipoTransaccionActual;
            UsuarioLogeado = pUserLogin;
            LoadUsuarios();
            LoadPuntosVenta();

            if(PuntoVentaActual.RecuperaRegistro(pIdPuntoVenta))
            {
                glePuntoVenta.EditValue = PuntoVentaActual.ID;
            }

            switch (TipoTransaccionActual)
            {
                case TipoTransaccion.Insert:
                    break;
                case TipoTransaccion.Update:
                    lblTitulo.Text = "Modificar datos de Equipo";
                    if (equipo.RecuperarRegistro(pIdEquipo))
                    {
                        txtNombreEquipo.Text= equipo.PcName;
                        glePuntoVenta.EditValue = equipo.IdPuntoVenta;
                        tggEnable.IsOn = equipo.Enable ;
                        txtDescripcionEquipo.Text = equipo.Descripcion;
                        gleUsuarioAsignado.EditValue = equipo.IdUserAsigned;
                        txtNombreEquipo.Enabled = false;
                    }
                    break;
            }
        }

        private void LoadPuntosVenta()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();

                SqlCommand cmd = new SqlCommand(@"SELECT [id],concat(coalesce([codigo],'S/N'),'  ',[nombre_local])as descripcion
                                                  FROM [Facturacion_PuntoVenta]
                                                  where [enable] = 1", con);
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                SqlDataAdapter ds = new SqlDataAdapter(cmd);
                dsCRUDS_Facturacion1.punto_venta.Clear();
                ds.Fill(dsCRUDS_Facturacion1.punto_venta);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadUsuarios()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_get_user_for_assign_equipment", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                SqlDataAdapter ds = new SqlDataAdapter(cmd);
                dsCRUDS_Facturacion1.usuarios_asignados.Clear();
                ds.Fill(dsCRUDS_Facturacion1.usuarios_asignados);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreEquipo.Text))
            {
                errorProvider1.SetError(txtNombreEquipo, "No se permite dejar el nombre de equipo en blanco!");
                return;
            }

            if (string.IsNullOrEmpty(glePuntoVenta.Text))
            {
                errorProvider1.SetError(glePuntoVenta, "No se permite dejar el Punto de Venta en blanco!");
                return;
            }

            if (string.IsNullOrEmpty(gleUsuarioAsignado.Text))
            {
                errorProvider1.SetError(gleUsuarioAsignado, "No se permite dejar el Usuario Asignado en blanco!");
                return;
            }
                       

            equipo.PcName = txtNombreEquipo.Text;
            equipo.IdPuntoVenta = dp.ValidateNumberInt32(glePuntoVenta.EditValue);
            equipo.Enable = tggEnable.IsOn;
            equipo.IdUsuario = this.UsuarioLogeado.Id;
            equipo.Fecha = dp.NowSetDateTime();

            if(!string.IsNullOrEmpty(txtDescripcionEquipo.Text))
                equipo.Descripcion = txtDescripcionEquipo.Text;

            equipo.IdUserAsigned = dp.ValidateNumberInt32(gleUsuarioAsignado.EditValue);
            equipo.Usuario_Asignado = gleUsuarioAsignado.Text;

            switch (TipoTransaccionActual)
            {
                case TipoTransaccion.Insert:
                    if (!string.IsNullOrEmpty(equipo.validarEquipoEnOtroPDV(txtNombreEquipo.Text)))
                    {
                        errorProvider1.SetError(txtNombreEquipo, equipo.RepuestaValidacion);
                        return;
                    }
                    equipo.InsertarNewRow();
                    break;
                case TipoTransaccion.Update: 
                    equipo.ActualizarRow();
                    break;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

      
    }
}