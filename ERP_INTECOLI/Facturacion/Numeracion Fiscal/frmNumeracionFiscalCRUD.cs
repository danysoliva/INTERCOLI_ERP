using DevExpress.XtraEditors;
using ERP_INTECOLI.Clases;
using JAGUAR_APP.Facturacion.Mantenimientos.Models;
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

namespace JAGUAR_APP.Facturacion.Numeracion_Fiscal
{
    public partial class frmNumeracionFiscalCRUD : DevExpress.XtraEditors.XtraForm
    {
        UserLogin usuarioLogueado;

        int tipo_transaccion;
        NumeracionFiscal numeracionFiscal = new NumeracionFiscal();

       public enum TipoTransaccion { 
            agregar=1,
            editar=2
        }

        public frmNumeracionFiscalCRUD(UserLogin userLogin,int t_transaccion)
        {
            InitializeComponent();
            load_typedoc();
            load_pdv();
            usuarioLogueado = userLogin;

            tipo_transaccion = t_transaccion;
        }

        public frmNumeracionFiscalCRUD(UserLogin userLogin, int t_transaccion,NumeracionFiscal pNumeracionFiscal)
        {
            InitializeComponent();
            usuarioLogueado = userLogin;

            tipo_transaccion = t_transaccion;
            numeracionFiscal = pNumeracionFiscal;
            load_typedoc();
            load_pdv();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            switch (tipo_transaccion)
            {
                case 1:
                    try
                    {
                        DataOperations dp = new DataOperations();

                        if (string.IsNullOrEmpty(sluePDV.Text))
                        {
                            CajaDialogo.Error("DEBE SELECCIONAR UN PUNTO DE VENTA");
                            return;
                        }

                        if (string.IsNullOrEmpty(txtCAI.Text))
                        {
                            CajaDialogo.Error("DEBE INGRESAR EL CAI");
                            return;
                        }

                        if (string.IsNullOrEmpty(txtNumIni.Text))
                        {
                            CajaDialogo.Error("DEBE INGRESAR EL FORMATO DE NUMERACION INICIAL");
                            return;
                        }

                        if (string.IsNullOrEmpty(txtNumFin.Text))
                        {
                            CajaDialogo.Error("DEBE INGRESAR EL FORMATO DE NUMERACION FINAL");
                            return;
                        }

                        if (string.IsNullOrEmpty(deFechaEmision.Text))
                        {
                            CajaDialogo.Error("DEBE INGRESAR LA FECHA DE EMISION");
                            return;
                        }

                        if (string.IsNullOrEmpty(deFechaVence.Text))
                        {
                            CajaDialogo.Error("DEBE INGRESAR LA FECHA DE VENCIMIENTO");
                            return;
                        }

                        if (string.IsNullOrEmpty(luEstado.Text))
                        {
                            CajaDialogo.Error("DEBE INGRESAR UN ESTADO");
                            return;
                        }

                        if (string.IsNullOrEmpty(lueTypeDoc.Text))
                        {
                            CajaDialogo.Error("DEBE INGRESAR TIPO DE DOCUMENTO");
                            return;
                        }




                        int correlativo;
                        if (tsSecuencia.IsOn)
                        {
                            correlativo = Convert.ToInt32(txtNumIni.Text.Substring(11, 8));
                        }
                        else
                        {
                            correlativo = 0;
                        }


                       
                        using (SqlConnection cnx= new SqlConnection(dp.ConnectionStringERP))
                        {

                            cnx.Open();

                            SqlCommand cmd = new SqlCommand("dbo.usp_InsertNumeracionFiscal", cnx);

                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("cai", SqlDbType.VarChar).Value = txtCAI.Text;
                            cmd.Parameters.Add("fechaEmision", SqlDbType.DateTime).Value = deFechaEmision.EditValue;
                            cmd.Parameters.Add("fechaVence", SqlDbType.DateTime).Value = deFechaVence.EditValue;
                            cmd.Parameters.Add("@numeracionInicial", SqlDbType.VarChar).Value = txtNumIni.Text;
                            cmd.Parameters.Add("@numeracionFinal", SqlDbType.VarChar).Value = txtNumFin.Text;
                            cmd.Parameters.Add("@estado_id", SqlDbType.Int).Value = luEstado.EditValue;
                            cmd.Parameters.Add("@fechaCreacion", SqlDbType.DateTime).Value = DateTime.Now;
                            //cmd.Parameters.Add("created_by", SqlDbType.VarChar).Value = usuarioLogueado.Id;
                            cmd.Parameters.Add("@usuarioId", SqlDbType.Int).Value = usuarioLogueado.Id;
                            cmd.Parameters.Add("@CreadoDesde", SqlDbType.VarChar).Value = Environment.MachineName;
                            cmd.Parameters.Add("@tipoDocumento_id", SqlDbType.Int).Value = lueTypeDoc.EditValue;
                            cmd.Parameters.Add("@gen_correlativo", SqlDbType.Bit).Value = tsSecuencia.EditValue;
                            cmd.Parameters.Add("correlativo", SqlDbType.Int).Value = correlativo;
                            cmd.Parameters.Add("leyenda", SqlDbType.NVarChar).Value = txtNumIni.Text.Substring(0, 11);
                            cmd.Parameters.Add("@pdv_id", SqlDbType.Int).Value = sluePDV.EditValue;

                            cmd.ExecuteNonQuery();

                            CajaDialogo.Information("DATOS GUARDADOS");

                            this.DialogResult = DialogResult.OK;
                            cnx.Close();
                        }

                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }
                    break;

                    case 2:

                    try
                    {
                        if (string.IsNullOrEmpty(sluePDV.Text))
                        {
                            CajaDialogo.Error("DEBE SELECCIONAR UN PUNTO DE VENTA");
                            return;
                        }

                        if (string.IsNullOrEmpty(txtCAI.Text))
                        {
                            CajaDialogo.Error("DEBE INGRESAR EL CAI");
                            return;
                        }

                        if (string.IsNullOrEmpty(txtNumIni.Text))
                        {
                            CajaDialogo.Error("DEBE INGRESAR EL FORMATO DE NUMERACION INICIAL");
                            return;
                        }

                        if (string.IsNullOrEmpty(txtNumFin.Text))
                        {
                            CajaDialogo.Error("DEBE INGRESAR EL FORMATO DE NUMERACION FINAL");
                            return;
                        }

                        if (string.IsNullOrEmpty(deFechaEmision.Text))
                        {
                            CajaDialogo.Error("DEBE INGRESAR LA FECHA DE EMISION");
                            return;
                        }

                        if (string.IsNullOrEmpty(deFechaVence.Text))
                        {
                            CajaDialogo.Error("DEBE INGRESAR LA FECHA DE VENCIMIENTO");
                            return;
                        }

                        if (string.IsNullOrEmpty(luEstado.Text))
                        {
                            CajaDialogo.Error("DEBE INGRESAR UN ESTADO");
                            return;
                        }

                        if (string.IsNullOrEmpty(lueTypeDoc.Text))
                        {
                            CajaDialogo.Error("DEBE INGRESAR TIPO DE DOCUMENTO");
                            return;
                        }
                        DataOperations dp = new DataOperations();


                        numeracionFiscal.CAI = txtCAI.Text;
                        numeracionFiscal.Numeracion_Final = txtNumFin.Text;
                        numeracionFiscal.Numeracion_Inicial= txtNumIni.Text;
                        numeracionFiscal.FechaEmision= Convert.ToDateTime( deFechaEmision.EditValue);
                        numeracionFiscal.FechaVence = Convert.ToDateTime(deFechaVence.EditValue);
                        numeracionFiscal.GenCorr    =  Convert.ToBoolean(     tsSecuencia.EditValue);
                        numeracionFiscal.TipoDocID = Convert.ToInt32( lueTypeDoc.EditValue);
                        numeracionFiscal.EstadoID = Convert.ToInt32(luEstado.EditValue);
                        

                        int correlativo;
                        if (tsSecuencia.IsOn)
                        {
                            correlativo = Convert.ToInt32(txtNumIni.Text.Substring(11, 8));
                        }
                        else
                        {
                            correlativo = 0;
                        }


                        using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP))
                        {

                            cnx.Open();

                            SqlCommand cmd = new SqlCommand("[dbo].[usp_UpdateNumeracionFiscal]", cnx);

                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@cai", SqlDbType.VarChar).Value = txtCAI.Text;
                            cmd.Parameters.Add("@fechaEmision", SqlDbType.DateTime).Value = deFechaEmision.EditValue;
                            cmd.Parameters.Add("@fechaVence", SqlDbType.DateTime).Value = deFechaVence.EditValue;
                            cmd.Parameters.Add("@numeracionInicial", SqlDbType.VarChar).Value = txtNumIni.Text;
                            cmd.Parameters.Add("@numeracionFinal", SqlDbType.VarChar).Value = txtNumFin.Text;
                            cmd.Parameters.Add("@estado_id", SqlDbType.Int).Value = luEstado.EditValue;
                            //cmd.Parameters.Add("@fechaCreacion", SqlDbType.DateTime).Value = DateTime.Now;
                            //cmd.Parameters.Add("@created_by", SqlDbType.Int).Value = usuarioLogueado.Id;
                            //cmd.Parameters.Add("@CreadoDesde", SqlDbType.VarChar).Value = Environment.MachineName;
                            cmd.Parameters.Add("@gen_correlativo", SqlDbType.Bit).Value = tsSecuencia.EditValue;
                            cmd.Parameters.Add("@correlativo", SqlDbType.Int).Value = correlativo;
                            cmd.Parameters.Add("@leyenda", SqlDbType.VarChar).Value = txtNumIni.Text.Substring(0, 11);
                            cmd.Parameters.Add("@tipoDocumento_id", SqlDbType.Int).Value = lueTypeDoc.EditValue;
                            cmd.Parameters.Add("@id", SqlDbType.Int).Value = numeracionFiscal.ID;
                            cmd.Parameters.Add("@pdv_id", SqlDbType.Int).Value = sluePDV.EditValue;

                            cmd.ExecuteNonQuery();

                            CajaDialogo.Information("DATOS GUARDADOS");

                            this.DialogResult = DialogResult.OK;
                            cnx.Close();
                        }

                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }
                    break;
            }


        }

        
        private void frmNumeracionFiscalCRUD_Load(object sender, EventArgs e)
        {

            try
            {

                DataRow workRow2 = dsNumeracionFiscal.Estado.NewRow();
                workRow2["id_estado"] = 1;
                workRow2["descripcion"] = "Activo";
                dsNumeracionFiscal.Estado.Rows.Add(workRow2);


                DataRow workRow = dsNumeracionFiscal.Estado.NewRow();
                workRow["id_estado"] = 2;
                workRow["descripcion"] = "Inactivo";
                dsNumeracionFiscal.Estado.Rows.Add(workRow);

                if (tipo_transaccion==2)
                {
                    txtCAI.Text = numeracionFiscal.CAI;
                    txtNumFin.Text = numeracionFiscal.Numeracion_Final;
                    txtNumIni.Text = numeracionFiscal.Numeracion_Inicial;
                    deFechaEmision.EditValue = numeracionFiscal.FechaEmision;
                    deFechaVence.EditValue = numeracionFiscal.FechaVence;
                    tsSecuencia.EditValue = numeracionFiscal.GenCorr;
                    lueTypeDoc.EditValue = numeracionFiscal.TipoDocID;
                    luEstado.EditValue = numeracionFiscal.EstadoID;
                    sluePDV.EditValue = numeracionFiscal.PuntoVentaID;

                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }


        }

      
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void load_typedoc()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP))
                {
                    cnx.Open();

                    dsNumeracionFiscal.typedoc.Clear();
                    SqlDataAdapter da = new SqlDataAdapter("dbo.usp_GetTipoDocumento", cnx);
                    da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                    da.Fill(dsNumeracionFiscal.typedoc);

                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void load_pdv()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP))
                {
                    cnx.Open();

                    dsNumeracionFiscal.PDV.Clear();
                    SqlDataAdapter da = new SqlDataAdapter("dbo.usp_GetPDV", cnx);
                    da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                    da.Fill(dsNumeracionFiscal.PDV);

                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void luEstado_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}