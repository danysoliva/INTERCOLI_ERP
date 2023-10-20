using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
using static ERP_INTECOLI.Clases.Conf_TablesID;

namespace JAGUAR_APP.Facturacion.Mantenimientos
{
    public partial class PDV_CRUD : DevExpress.XtraEditors.XtraForm
    {
        public delegate void get_pdv_inserted(int Id_inserted);
        public event get_pdv_inserted EventoPasarId_inserted;
        PuntoVenta pdv = new PuntoVenta();

        public enum Transacciones
        {
            Nuevo=1,
            Editar=2
        }

        Conf_TablesID tableID = new Conf_TablesID();

        int tipoTransaccion = 0;
        //int panadero_id = 0;

        UserLogin usuarioLogueado = new UserLogin();

        public PDV_CRUD(int pTransaccion,PuntoVenta pPDV, UserLogin pUser)
        {
            InitializeComponent();
            tipoTransaccion = pTransaccion;

            if(tipoTransaccion == 1)
            {
                gridControl1.Visible = false;
                lblTituloGrid.Visible = false;
                cmdAgregarEquipo.Visible = false;
            }

            pdv = pPDV;
            usuarioLogueado = pUser;
            //LoadTipoFacturacion();
            LoadFormatosFactura();

            if(pPDV != null)
                if(pPDV.ID>0)
                    LoadEquipos(pPDV.ID);
        }

        private void LoadFormatosFactura()
        {
            try
            {
                DataOperations dp = new DataOperations();
                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP))
                {
                    cnx.Open();
                    string sql = @"dbo.sp_get_formatos_facturacion_dato_maestro";
                    SqlCommand cmd = cnx.CreateCommand();
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dsCRUDS_Facturacion1.formatos_impresion_facturas.Clear();
                    da.Fill(dsCRUDS_Facturacion1.formatos_impresion_facturas);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadEquipos(int pidPuntoVenta)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_get_listado_equipos_for_punto_facturacion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_punto_facturacion", pidPuntoVenta);
                dsCRUDS_Facturacion1.Equipos_por_Punto_venta.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsCRUDS_Facturacion1.Equipos_por_Punto_venta);
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
        { //dbo.usp_JAGUAR_InsertNewProveedorCAI
           
           

            if (string.IsNullOrEmpty(txtNombrePuntoVenta.Text))
            {
                CajaDialogo.Error("Debe ingresar un Nombre de Punto de Venta valido!");
                return;
            }

            if (string.IsNullOrEmpty(gleFormatoImpresion.Text))
            {
                CajaDialogo.Error("Es necesario definir el formato en el que se emitiran las facturas en el punto de venta!");
                return;
            }


            try
            {
                DataOperations dp = new DataOperations();
                int id_inserted = 0;

                switch (tipoTransaccion)
                {
                    case (int)Transacciones.Nuevo:
                        using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP))
                        {
                            cnx.Open();
                            SqlCommand cmd = new SqlCommand("[dbo].[uspInsertPDV_V5]", cnx);

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@nombre_local", SqlDbType.VarChar).Value = txtNombrePuntoVenta.Text;
                            cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = txtCod.Text;
                            cmd.Parameters.Add("@direccion", SqlDbType.VarChar).Value = txtDireccion.Text;
                            cmd.Parameters.Add("@FechaApertura", SqlDbType.Date).Value = deFechaApertura.Text;
                            cmd.Parameters.Add("@FechaCreacion", SqlDbType.DateTime).Value = DateTime.Now;
                            
                            if(string.IsNullOrEmpty(slueCiudad.Text))
                                cmd.Parameters.Add("@ciudad", SqlDbType.Int).Value = DBNull.Value;
                            else
                                cmd.Parameters.Add("@ciudad", SqlDbType.Int).Value = slueCiudad.EditValue;

                            if (string.IsNullOrEmpty(slueDepto.Text))
                                cmd.Parameters.Add("@departamento", SqlDbType.Int).Value = DBNull.Value;
                            else
                                cmd.Parameters.Add("@departamento", SqlDbType.Int).Value = slueDepto.EditValue;


                            cmd.Parameters.Add("@usuario_id", SqlDbType.Int).Value = usuarioLogueado.Id;
                            //cmd.Parameters.AddWithValue("@id_tipo_facturacion", slueTipoFacturacion.EditValue);
                            cmd.Parameters.AddWithValue("@tipoFacturacionId", DBNull.Value);
                            cmd.Parameters.Add("@bloqueoPorFaltaStock", SqlDbType.Bit).Value = tsStock.EditValue;
                            cmd.Parameters.Add("@permiteAnulacionConAutorizacion", SqlDbType.Bit).Value = tsAnulacion.EditValue;
                            cmd.Parameters.Add("@conteoPrintFactura", SqlDbType.Bit).Value = tsPrint.EditValue;
                            cmd.Parameters.Add("@permiteReimpresion", SqlDbType.Bit).Value = tsReimpresion.EditValue;
                            cmd.Parameters.Add("@emisionFactura", SqlDbType.Bit).Value = tsEmision.EditValue;
                            cmd.Parameters.Add("@FacturaBuffet", SqlDbType.Bit).Value = ts_facturaBuffet.EditValue; 
                            cmd.Parameters.Add("@correo", SqlDbType.VarChar).Value = txtCorreo.Text; 
                            cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = txtTelefono.Text; 
                            cmd.Parameters.Add("@nombre_legal", SqlDbType.VarChar).Value = txtNombreLegal.Text; 
                            cmd.Parameters.Add("@factura_almacen_produccion", SqlDbType.Bit).Value = tsFacturaAlmacenPRD.EditValue; 
                            cmd.Parameters.AddWithValue("@rtn", txtRTN.Text);

                            if(string.IsNullOrEmpty(gleFormatoImpresion.Text))
                                cmd.Parameters.AddWithValue("@id_formato_facturacion", DBNull.Value);
                            else
                                cmd.Parameters.AddWithValue("@id_formato_facturacion", gleFormatoImpresion.EditValue);

                            cmd.Parameters.AddWithValue("@emitaFacturaFiscal", ts_EmiteFacturaFiscal.EditValue);

                            id_inserted = Convert.ToInt32( cmd.ExecuteScalar());

                            CajaDialogo.Information("DATOS GUARDADOS");
                            EventoPasarId_inserted(id_inserted);
                            this.DialogResult = DialogResult.OK;
                            cnx.Close();
                        }
                        break;

                    case (int)Transacciones.Editar:
                        using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP))
                        {
                            cnx.Open();
                            SqlCommand cmd2 = new SqlCommand("[dbo].[usp_UpdatePDV_V5]", cnx);

                            cmd2.CommandType = CommandType.StoredProcedure;
                            cmd2.Parameters.Add("@id_PDV", SqlDbType.Int).Value = pdv.ID;
                            cmd2.Parameters.Add("@nombre_local", SqlDbType.VarChar).Value = txtNombrePuntoVenta.Text;
                            cmd2.Parameters.Add("@direccion", SqlDbType.VarChar).Value = txtDireccion.Text;
                            cmd2.Parameters.Add("@FechaApertura", SqlDbType.Date).Value = deFechaApertura.Text;
                            cmd2.Parameters.Add("@ciudad", SqlDbType.Int).Value = slueCiudad.EditValue;
                            cmd2.Parameters.Add("@departamento", SqlDbType.Int).Value = slueDepto.EditValue;
                            cmd2.Parameters.Add("@id_usuario_creado", SqlDbType.Int).Value = usuarioLogueado.Id;
                            //cmd2.Parameters.AddWithValue("@id_tipo_facturacion", slueTipoFacturacion.EditValue);
                            cmd2.Parameters.AddWithValue("@id_tipo_facturacion", DBNull.Value);
                            cmd2.Parameters.Add("@bloqueo_por_falta_stock", SqlDbType.Bit).Value = tsStock.EditValue;
                            cmd2.Parameters.Add("@permite_anulacion_con_autorizacion", SqlDbType.Bit).Value = tsAnulacion.EditValue;
                            cmd2.Parameters.Add("@conteo_print_factura", SqlDbType.Bit).Value = tsPrint.EditValue;
                            cmd2.Parameters.Add("@permite_reimpresion_fact_con_autorizacion", SqlDbType.Bit).Value = tsReimpresion.EditValue;
                            cmd2.Parameters.Add("@emision_factura_en_dos_pasos", SqlDbType.Bit).Value = tsEmision.EditValue;
                            cmd2.Parameters.Add("@FacturaBuffet", SqlDbType.Bit).Value = ts_facturaBuffet.EditValue;
                            cmd2.Parameters.Add("@correo", SqlDbType.VarChar).Value = txtCorreo.Text;
                            cmd2.Parameters.Add("@telefono", SqlDbType.VarChar).Value = txtTelefono.Text;
                            cmd2.Parameters.Add("@nombre_legal", SqlDbType.VarChar).Value = txtNombreLegal.Text;
                            cmd2.Parameters.Add("@factura_almacen_produccion", SqlDbType.Bit).Value = tsFacturaAlmacenPRD.EditValue; 
                            cmd2.Parameters.AddWithValue("@rtn", txtRTN.Text);

                            if (string.IsNullOrEmpty(gleFormatoImpresion.Text))
                                cmd2.Parameters.AddWithValue("@id_formato_facturacion", DBNull.Value);
                            else
                                cmd2.Parameters.AddWithValue("@id_formato_facturacion", gleFormatoImpresion.EditValue);

                            cmd2.Parameters.AddWithValue("@emitaFacturaFiscal", ts_EmiteFacturaFiscal.EditValue);
                            cmd2.ExecuteNonQuery();

                            CajaDialogo.Information("DATOS ACTUALIZADOS");
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

        private void xfrmProveedorCAI_CRUD_Load(object sender, EventArgs e)
        {
            LoadDepto();

            if (tipoTransaccion == (int)Transacciones.Editar)
            {
                txtNombrePuntoVenta.Text = pdv.Nombre;
                txtCod.Text=pdv.Codigo;
                deFechaApertura.EditValue = pdv.FechaApertura;
                slueDepto.EditValue = pdv.DepartamentoID;
                slueCiudad.EditValue = pdv.CiudadID;
                txtDireccion.Text = pdv.Direccion;
                //slueTipoFacturacion.EditValue = pdv.TipoFacturacionID;
                tsAnulacion.EditValue = pdv.PermiteAnulacionConAutorizacion;
                tsEmision.EditValue = pdv.EmisionFacturaDosPasos;
                tsPrint.EditValue = pdv.ConteoPrintFactura;
                tsStock.EditValue = pdv.BloqueoPorFaltaStock;
                ts_facturaBuffet.EditValue = pdv.FacturaComidaBuffet;
                tsReimpresion.EditValue = pdv.PermiteReimpresionFacturaConAutorizacion;
                txtCorreo.Text = pdv.Correo;
                txtTelefono.Text = pdv.Telefono;
                txtNombreLegal.Text = pdv.NombreLegal;
                gleFormatoImpresion.EditValue = pdv.IdFormatoFactura;
                ts_EmiteFacturaFiscal.EditValue = pdv.EmiteFacturaFiscal;
                tsFacturaAlmacenPRD.EditValue = pdv.FacturaAlmacenPRD;
                if(!string.IsNullOrEmpty(pdv.RTN))
                    txtRTN.Text = pdv.RTN;
            }
            else
            {
                GetIDTable();
            }
           
        }

        private void GetIDTable()
        {
            try
            {
                if (tableID.ObtenerIDTable((int)TablesIDOptions.PuntoDeVenta,3))
                {
                    txtCod.Text = tableID.Codigo;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }

        private void LoadDepto()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP))
                {
                    cnx.Open();
                    string sql = @"SELECT id_departamento,
                                       nombre_departamento 
                                FROM dbo.Facturacion_DepartamentosDireccion
                                WHERE enable=1";

                    dsMantenimientosFacturacion.Departamentos.Clear();

                    SqlDataAdapter da = new SqlDataAdapter(sql,cnx);

                    da.Fill(dsMantenimientosFacturacion.Departamentos);

                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadCiudades(int id_depto)
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP))
                {
                    cnx.Open();
                    string sql = @"SELECT id_municipio,
                                           nombre_municipio
                                     FROM dbo.Facturacion_MunicipiosDireccion
                                    WHERE id_departamento="+ id_depto+" AND enable=1";

                    dsMantenimientosFacturacion.municipios.Clear();

                    SqlDataAdapter da = new SqlDataAdapter(sql, cnx);

                    da.Fill(dsMantenimientosFacturacion.municipios);

                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void slueDepto_EditValueChanged(object sender, EventArgs e)
        {
            LoadCiudades(Convert.ToInt32(slueDepto.EditValue));
        }

        private void LoadTipoFacturacion()
        {
            try
            {
                DataOperations dp = new DataOperations();
                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP))
                {
                    cnx.Open();
                    string sql = @"SELECT id,
                                          descripcion
                                    FROM dbo.Facturacion_TipoFacturacion
                                    WHERE enable=1";

                    dsMantenimientosFacturacion.TipoFacturacion.Clear();
                    SqlDataAdapter da = new SqlDataAdapter(sql, cnx);
                    da.Fill(dsMantenimientosFacturacion.TipoFacturacion);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void gridCmd_Editar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Editar equipo de computo
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsCRUDS_Facturacion.Equipos_por_Punto_ventaRow)gridView.GetFocusedDataRow();

            int idPuntoVentaActual = 0;
            if (pdv != null)
                idPuntoVentaActual = pdv.ID;

            frmAddEquipoPuntoVenta frmAdd = new frmAddEquipoPuntoVenta(this.usuarioLogueado, frmAddEquipoPuntoVenta.TipoTransaccion.Update, row.id, idPuntoVentaActual);
            if (frmAdd.ShowDialog() == DialogResult.OK)
            {
                //dsCRUDS_Facturacion.Equipos_por_Punto_ventaRow row = dsCRUDS_Facturacion1.Equipos_por_Punto_venta.NewEquipos_por_Punto_ventaRow();
                //row.id = frmAdd.equipo.Id;
                row.pc_name = frmAdd.equipo.PcName;
                row.id_punto_venta = frmAdd.equipo.IdPuntoVenta;
                row.enable = frmAdd.equipo.Enable;
                row.id_usuario = frmAdd.equipo.IdUsuario;
                row.id_user_asigned = frmAdd.equipo.IdUserAsigned;
                row.fecha = frmAdd.equipo.Fecha;
                row.descripcion = frmAdd.equipo.Descripcion;
                row.Usuario_Asignado = frmAdd.equipo.Usuario_Asignado;
                
                //dsCRUDS_Facturacion1.Equipos_por_Punto_venta.AddEquipos_por_Punto_ventaRow(row);
                dsCRUDS_Facturacion1.AcceptChanges();
                //dsCRUDS_Facturacion1.Equipos_por_Punto_venta

                LoadEquipos(idPuntoVentaActual);
            }
        }

        private void cmdAgregarEquipo_Click(object sender, EventArgs e)
        {
            int idPuntoVentaActual = 0;
            if (pdv != null)
                idPuntoVentaActual = pdv.ID;

            frmAddEquipoPuntoVenta frmAdd = new frmAddEquipoPuntoVenta(this.usuarioLogueado, frmAddEquipoPuntoVenta.TipoTransaccion.Insert, 0, idPuntoVentaActual);
            if(frmAdd.ShowDialog()== DialogResult.OK)
            {
                dsCRUDS_Facturacion.Equipos_por_Punto_ventaRow row = dsCRUDS_Facturacion1.Equipos_por_Punto_venta.NewEquipos_por_Punto_ventaRow();
                row.id = frmAdd.equipo.Id;
                row.pc_name = frmAdd.equipo.PcName;
                row.id_punto_venta = frmAdd.equipo.IdPuntoVenta;
                row.enable = frmAdd.equipo.Enable;
                row.id_usuario = frmAdd.equipo.IdUsuario;
                row.id_user_asigned = frmAdd.equipo.IdUserAsigned;
                row.fecha = frmAdd.equipo.Fecha;
                row.descripcion = frmAdd.equipo.Descripcion;
                row.Usuario_Asignado = frmAdd.equipo.Usuario_Asignado;
                row.RowNumber = dsCRUDS_Facturacion1.Equipos_por_Punto_venta.Count + 1;

                dsCRUDS_Facturacion1.Equipos_por_Punto_venta.AddEquipos_por_Punto_ventaRow(row);
                dsCRUDS_Facturacion1.AcceptChanges();
                //dsCRUDS_Facturacion1.Equipos_por_Punto_venta
            }
        }
    }
}