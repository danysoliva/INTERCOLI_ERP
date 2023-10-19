using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ERP_INTECOLI.Clases;

namespace JAGUAR_APP.Facturacion.CoreFacturas
{
    public partial class frmAjusteKardexFactura : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp1 = new DataOperations();
        UserLogin UsuarioLogeado;
        ProductoTerminado pt = new ProductoTerminado();

        private decimal factorValue;

        int Id_PT; //ID de Producto Terminado - Tabla en AQFSVR003.ACS4
        string ItemCode; //Id de lote de Producto Terminado
        public frmAjusteKardexFactura(UserLogin pUserLogin)
        {
            InitializeComponent();
            UsuarioLogeado = pUserLogin;
            dtFechaDocumento.DateTime = dp1.NowSetDateTime();

            LoadPresentaciones();
            sluePDV.Visible = true;
            ObtenerPDV();
        }



        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadPresentaciones()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_get_presentaciones_activas_ajuste_PT_V2", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                //dsRecepcionMP.presentaciones.Clear();
                //adat.Fill(dsRecepcionMP.presentaciones);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        //private void LoadBodega()
        //{
        //    try
        //    {
        //        DataOperations dp = new DataOperations();
        //        SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
        //        con.Open();

        //        SqlCommand cmd = new SqlCommand("dbo.usp_get_JAGUAR_Bodega", con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        SqlDataAdapter adat = new SqlDataAdapter(cmd);
        //        dsTarima1.bodega_destino.Clear();
        //        adat.Fill(dsRecepcionMP.presentaciones);
        //        con.Close();
        //    }
        //    catch (Exception ec)
        //    {
        //        CajaDialogo.Error(ec.Message);
        //    }
        //}



        //private void LoadMaestrosBodegas()
        //{
        //    try
        //    {
        //        DataOperations dp = new DataOperations();
        //        SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
        //        con.Open();

        //        SqlCommand cmd = new SqlCommand("dbo.usp_get_bodega_Kardex_PT", con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        dsTarima1.bodega_destino.Clear();
        //        SqlDataAdapter adat = new SqlDataAdapter(cmd);
        //        adat = new SqlDataAdapter(cmd);
        //        adat.Fill(dsTarima1.bodega_destino);

        //        con.Close();
        //    }
        //    catch (Exception ec)
        //    {
        //        CajaDialogo.Error(ec.Message);
        //    }
        //}

        private void gridLookUpEditPresentacion_EditValueChanged(object sender, EventArgs e)
        {
            //if (gvLookUpEditPresentacion.RowCount <= 0)
            //{
            //    this.factorValue = 0;
            //}
            //else
            //{
            //    this.factorValue = Convert.ToDecimal(gvLookUpEditPresentacion.GetFocusedRowCellValue(gvLookUpEditPresentacion.Columns[2]).ToString());
            //}

            decimal cantidad_ = 0;
            try
            {
                cantidad_ = Convert.ToDecimal(txtCantidadUnidades.Text);
            }
            catch { 
            }

        }

        private void txtCantidadUnidades_Leave(object sender, EventArgs e)
        {
            decimal cantidad_ = 0;
            try
            {
                cantidad_ = Convert.ToDecimal(txtCantidadUnidades.Text);
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPT_Name.Text))
            {
                CajaDialogo.Error("Es necesario seleccionar el Producto Terminado!");
                return;
            }
            if (string.IsNullOrEmpty(sluePDV.Text))
            {
                CajaDialogo.Error("Es Necesario seleccionar un Numero de Lote de Producto Terminado");
                return;
            }
            if (txtPresentacion.EditValue == null)
            {
                CajaDialogo.Error("Debe Seleccionar el tipo de presentacion!");
                return;
            }

            if (Convert.ToDecimal(txtCantidadUnidades.Text) <= 0)
            {
                CajaDialogo.Error("No se puede registrar una cantidad de producto terminado en cero (0)!");
                return;
            }
            if (!string.IsNullOrEmpty(dtFechaDocumento.Text))
            {
                if (dtFechaDocumento.DateTime.Year <= 2020)
                {
                    CajaDialogo.Error("Es necesario ingresar una fecha de documento valida!");
                    return;
                }
            }

           
            DataOperations dp = new DataOperations();

            int tipoTransaccion = 0;

            if (tsTipoTransaccion.IsOn)
            {
                tipoTransaccion = 1;
            }
            else
            {
                tipoTransaccion = 2;
            }

            try
            {

                // Crear un objeto SqlCommand.

                SqlCommand comando = new SqlCommand();
                comando.Connection = new SqlConnection(dp.ConnectionStringERP);
                comando.CommandType = CommandType.StoredProcedure; // Puedes cambiar esto según tus necesidades.

                comando.Connection.Open();
                // Especificar el nombre del procedimiento almacenado o consulta SQL que deseas ejecutar.
                comando.CommandText = "uspInsertKardexFacturacion";

                // Agregar los parámetros con sus nombres y tipos correspondientes.
                comando.Parameters.Add("@id_referencia_operacion", SqlDbType.Int).Value = DBNull.Value;
                comando.Parameters.Add("@fecha_transaccion", SqlDbType.DateTime).Value = dtFechaDocumento.EditValue;
                comando.Parameters.Add("@itemCode", SqlDbType.VarChar, 15).Value = pt.Code;
                comando.Parameters.Add("@idBodega", SqlDbType.Int).Value = DBNull.Value;
                comando.Parameters.Add("@user_id", SqlDbType.Int).Value = UsuarioLogeado.Id;
                comando.Parameters.Add("@cantidad", SqlDbType.Int).Value = txtCantidadUnidades.Text;
                comando.Parameters.Add("@row_date_created", SqlDbType.DateTime).Value = DBNull.Value;
                comando.Parameters.Add("@id_presentacion", SqlDbType.Int).Value = pt.Id_presentacion;
                comando.Parameters.Add("@id_detalle_contabilizacion", SqlDbType.Int).Value = DBNull.Value;
                comando.Parameters.Add("@lote", SqlDbType.VarChar, 50).Value = DBNull.Value;
                comando.Parameters.Add("@id_punto_venta", SqlDbType.Int).Value = sluePDV.EditValue;
                comando.Parameters.Add("@id_pt", SqlDbType.Int).Value = pt.Id;
                comando.Parameters.Add("@id_tipo_transaccion", SqlDbType.Int).Value = tipoTransaccion;

                comando.ExecuteNonQuery();

                comando.Connection.Close();

                CajaDialogo.Information("Transaccion realizada con éxito!");
                this.DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }


        private void txtCantidadUnidades_KeyDown(object sender, KeyEventArgs e)
        {
            decimal cantidad_ = 0;
            try
            {
                cantidad_ = Convert.ToDecimal(txtCantidadUnidades.Text);
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void txtPT_Name_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPT_Name_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int tipoTraansaccion = 0;

            if (tsTipoTransaccion.IsOn)
            {
                tipoTraansaccion = 1;
            }
            else
                tipoTraansaccion = 2;

            pt = new ProductoTerminado();


            frmPTFromKardexFacturacion frm = new frmPTFromKardexFacturacion();
            frm.MdiParent = this.MdiParent;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Id_PT = frm.id_pt;
                pt.Recuperar_producto(Id_PT);

                txtPT_Name.Text = pt.Descripcion;
                txtPresentacion.Text = pt.Presentacion_name;
            }
        }

        private void txtNumLote_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //frmLotesxPT frm = new frmLotesxPT(Id_PT);
            //frm.MdiParent = this.MdiParent;

            //if (frm.ShowDialog() == DialogResult.OK)
            //{
            //    txtNumLote.Text = Convert.ToString(frm.lot_number);
            //    ItemCode = frm.code;
            //    gridLookUpEditPresentacion.EditValue = frm.id_presentacion;
            //}
        }

        private void ObtenerPDV()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP))
                {
                    cnx.Open();

                    dsMantenimientosFacturacion.PDV.Clear();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.uspCargaPDV", cnx);
                    da.Fill(dsMantenimientosFacturacion.PDV);

                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}