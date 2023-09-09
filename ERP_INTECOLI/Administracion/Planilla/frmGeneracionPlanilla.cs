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
using ERP_INTECOLI.Clases;
using ERP_INTECOLI.Transacciones;
using System.Data.SqlClient;
using ERP_INTECOLI.Administracion.Estudiantes;
using ERP_INTECOLI.Facturacion;
using DevExpress.XtraGrid.Views.Grid;

namespace ERP_INTECOLI.Administracion.Planilla
{
    public partial class frmGeneracionPlanilla : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogueado;
        DataOperations dp = new DataOperations();

        public frmGeneracionPlanilla(UserLogin pUserLogin)
        {
            InitializeComponent();
            UsuarioLogueado = pUserLogin;


            dtFecha.Value = dp.Now();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //string sql = "select * from admon.ft_cargar_detalle_nueva_planilla();";
                string sql = @"[sp_planilla_get_detalle_nueva_planilla]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsPlanilla1.detalle.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsPlanilla1.detalle);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (dsPlanilla.detalleRow dtRow in dsPlanilla1.detalle.Rows)
            {
                dtRow.seleccionar = checkBox1.Checked;
            }
            dsPlanilla1.AcceptChanges();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            dsPlanilla1.AcceptChanges();
        }

        private void cbxMes_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (dsPlanilla.detalleRow dtRow in dsPlanilla1.detalle.Rows)
            {
                dtRow.mes = cbxMes.Text;
            }
            dsPlanilla1.AcceptChanges();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            DialogResult r = CajaDialogo.Pregunta("Esta seguro de generar esta planilla?");
            if (r == System.Windows.Forms.DialogResult.No)
                return;

            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                CajaDialogo.Error("Escriba una descripción a la Planilla!");
                return;
            }

            SqlTransaction transaction = null;

            SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
            bool Guardar = false;

            try
            {
                conn.Open();
                transaction = conn.BeginTransaction("Transaction Order");

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "sp_planilla_guardar_planilla";
                cmd.Connection = conn;
                cmd.Transaction = transaction;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                cmd.Parameters.AddWithValue("@usuario", UsuarioLogueado.Id);
                cmd.Parameters.AddWithValue("@fecha_correspondiente", dtFecha.Value);

                int id_header_planilla = Convert.ToInt32(cmd.ExecuteScalar());




                foreach (dsPlanilla.detalleRow dtRow in dsPlanilla1.detalle.Rows)
                {
                    int iMes = 0;

                    if (dtRow.seleccionar)
                    {
                        try
                        {
                            if (dtRow.mes == null)
                            {
                                CajaDialogo.Error("Debe seleccionar el mes que se va postear! NO puede estar en blanco.");
                                return;
                            }
                        }
                        catch
                        {
                            CajaDialogo.Error("Debe seleccionar el mes que se va a postear! NO puede estar en blanco.");
                            return;
                        }

                        try
                        {
                            if (dtRow.fecha_limite == null)
                            {
                                CajaDialogo.Error("Debe seleccionar la fecha limite que se va a postear! NO puede estar en blanco.");
                                return;
                            }
                        }
                        catch
                        {
                            CajaDialogo.Error("Debe seleccionar la fecha que se va a postear! NO puede estar en blanco.");
                            return;
                        }
                        switch (dtRow.mes)
                        {
                            case "Enero":
                                iMes = 1;
                                break;
                            case "Febrero":
                                iMes = 2;
                                break;
                            case "Marzo":
                                iMes = 3;
                                break;
                            case "Abril":
                                iMes = 4;
                                break;
                            case "Mayo":
                                iMes = 5;
                                break;
                            case "Junio":
                                iMes = 6;
                                break;
                            case "Julio":
                                iMes = 7;
                                break;
                            case "Agosto":
                                iMes = 8;
                                break;
                            case "Septiembre":
                                iMes = 9;
                                break;
                            case "Octubre":
                                iMes = 10;
                                break;
                            case "Noviembre":
                                iMes = 11;
                                break;
                            case "Diciembre":
                                iMes = 12;
                                break;
                            default:
                                CajaDialogo.Error("Debe seleccionar el mes que se va a postear! NO puede estar en blanco.");
                                break;
                        }

                    }


                    cmd.Parameters.Clear();
                    cmd.CommandText = "sp_planilla_insert_detalle";
                    cmd.Connection = conn;
                    cmd.Transaction = transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_planilla", id_header_planilla);
                    cmd.Parameters.AddWithValue("@id_estudiante", dtRow.id_estudiante);
                    cmd.Parameters.AddWithValue("@nombre",  dtRow.nombre);
                    cmd.Parameters.AddWithValue("@mes_i", iMes);
                    cmd.Parameters.AddWithValue("@mes",  dtRow.mes);
                    cmd.Parameters.AddWithValue("@valor",  dtRow.valor);
                    cmd.Parameters.AddWithValue("@fecha_limite",  dtRow.fecha_limite);
                    cmd.Parameters.AddWithValue("@fecha_pago", dtRow.fecha_pago);
                    cmd.ExecuteNonQuery();


                    cmd.Parameters.Clear();
                    cmd.CommandText = "sp_planilla_insert_mensualidades";
                    cmd.Connection = conn;
                    cmd.Transaction = transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_estudiante", dtRow.id_estudiante);
                    cmd.Parameters.AddWithValue("@fecha_pago", dtRow.fecha_pago);
                    cmd.Parameters.AddWithValue("@subtotal", dtRow.valor);
                    cmd.Parameters.AddWithValue("@recargos", 0);
                    cmd.Parameters.AddWithValue("@descuento", 0);
                    cmd.Parameters.AddWithValue("@impuesto", 0);
                    cmd.Parameters.AddWithValue("@total",  dtRow.valor);
                    cmd.Parameters.AddWithValue("@id_nivel", dtRow.id_nivel);
                    cmd.Parameters.AddWithValue("@p_concepto", "Mensualidad del mes de " + dtRow.mes + " - " + dtRow.curso);
                    cmd.Parameters.AddWithValue("@curso_id", dtRow.id_curso);
                    cmd.Parameters.AddWithValue("@recibo_s", null);
                    cmd.Parameters.AddWithValue("@mes", dtRow.mes);
                    cmd.Parameters.AddWithValue("@dias_habiles", dtRow.dias_habiles);
                    cmd.Parameters.AddWithValue("@fecha_limite", dtRow.fecha_limite);
                    if (this.UsuarioLogueado.Super_user)
                        cmd.Parameters.AddWithValue("@id_usuario", 0);
                    else
                        cmd.Parameters.AddWithValue("@id_usuario", this.UsuarioLogueado.Id);
                    cmd.Parameters.AddWithValue("@mes_i", iMes);
                    cmd.Parameters.AddWithValue("@id_planilla", id_header_planilla);
                    //////////////////////////////////
                    cmd.Parameters.AddWithValue("@proximopago", dtFecha.Value.AddMonths(1));
                    cmd.ExecuteNonQuery();

                    Guardar = true;

                    
                    
                }

                if (Guardar)
                {
                    transaction.Commit();
                    CajaDialogo.Information("Transaccion Completada!");
                    dsPlanilla1.detalle.Clear();
                }


            }
            catch (Exception ec)
            {
                transaction.Rollback();
                CajaDialogo.Error(ec.Message);
                Guardar = false;
            }

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}