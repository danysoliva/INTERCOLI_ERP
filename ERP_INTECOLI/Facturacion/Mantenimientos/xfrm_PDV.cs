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

namespace JAGUAR_APP.Facturacion.Mantenimientos
{
    public partial class xfrm_PDV : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();

        UserLogin usuarioLogueado = new UserLogin();

        public xfrm_PDV(UserLogin userLogged)
        {
            InitializeComponent();
            ObtenerPDV();
            usuarioLogueado = userLogged;
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

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
           PDV_CRUD frm = new PDV_CRUD((int)DataOperations.TipoTransaccionesCRUD.Nuevo,null,usuarioLogueado);
           NumeracionFiscal nf = new NumeracionFiscal();

            frm.EventoPasarId_inserted += new PDV_CRUD.get_pdv_inserted(Ejecutar);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                ObtenerPDV();
            }
        }

        public void Ejecutar(int pIdInserted)
        {
            PDVBack pdv = new PDVBack();

            if (pdv.RecuperaRegistro(pIdInserted))
            {
                dsMantenimientosFacturacion.PDVRow row1 = dsMantenimientosFacturacion.PDV.NewPDVRow();
                row1.id = pIdInserted;
                row1.codigo = pdv.Codigo;
                row1.nombre_local = pdv.Nombre;
                row1.FechaCreacion = pdv.FechaCreacion;
                row1.FechaApertura = pdv.FechaApertura;
                row1.direccion = pdv.Direccion;
                row1.nombre_departamento = pdv.Departamento;
                row1.nombre_municipio = pdv.Ciudad;
                //row1.usuario = panadero.UsuarioCreacion;


                dsMantenimientosFacturacion.PDV.AddPDVRow(row1);
                dsMantenimientosFacturacion.AcceptChanges();
            }
        }

        private void cmdDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("Deseas eliminar este registro?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.No)
                {
                    try
                    {
                        DataOperations dp = new DataOperations();
                        var row = (dsMantenimientosFacturacion.PDVRow)gvPanaderos.GetFocusedDataRow();


                        SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP);
                        using (SqlCommand command = new SqlCommand("UPDATE dbo.Facturacion_PuntoVenta set enable=0 WHERE id = "+row.id, cnx))
                        {
                            cnx.Open();
                            //command.CommandType = CommandType.StoredProcedure;
                            //command.Parameters.Add("@id", SqlDbType.Int).Value = row.id;
                            //command.Parameters.Add("@user_id", SqlDbType.Int).Value = usuarioLogueado.Id;

                            command.ExecuteNonQuery();
                            cnx.Close();

                            //ObtenerPanaderos();
                            ObtenerPDV();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                throw;
            }
        }

        private void cmdEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsMantenimientosFacturacion.PDVRow)gvPanaderos.GetFocusedDataRow();
                PuntoVenta pdv = new PuntoVenta();

                //pdv.ID = row.id;
                //pdv.Nombre = row.nombre_local;
                //pdv.FechaApertura = row.FechaApertura;
                //pdv.Codigo = row.codigo;
                //pdv.Direccion = row.direccion;
                //pdv.DepartamentoID = row.id_departamento;
                //pdv.CiudadID = row.id_municipio;

                if (pdv.RecuperaRegistro(row.id))
                {


                    PDV_CRUD frm = new PDV_CRUD((int)DataOperations.TipoTransaccionesCRUD.Editar, pdv, usuarioLogueado);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        ObtenerPDV();
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ObtenerPDV();
        }

        private void gcPanaderos_Click(object sender, EventArgs e)
        {

        }
    }
}