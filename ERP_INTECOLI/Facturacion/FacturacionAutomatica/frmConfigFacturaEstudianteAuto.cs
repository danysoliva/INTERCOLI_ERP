using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Drawing;
using DevExpress.XtraGrid.Views.Grid;
using ERP_INTECOLI.Clases;
using ERP_INTECOLI.Facturacion.CoreFacturas;
using JAGUAR_APP.Facturacion.Configuraciones;
using LOSA.Calidad.LoteConfConsumo;
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
using static JAGUAR_APP.Facturacion.Configuraciones.xfrmListaPreciosCRUD;

namespace ERP_INTECOLI.Facturacion.FacturacionAutomatica
{
    public partial class frmConfigFacturaEstudianteAuto : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        PuntoVenta puntoVentaActual;
        DataOperations dp;
        public frmConfigFacturaEstudianteAuto(UserLogin pUsuario, PuntoVenta pPuntoVenta)
        {
            InitializeComponent();
            dp= new DataOperations();
            UsuarioLogeado = pUsuario;
            puntoVentaActual = pPuntoVenta;
            LoadDatos();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            xfrmSelectEstudiante_FactAuto frm = new xfrmSelectEstudiante_FactAuto(this.UsuarioLogeado, puntoVentaActual);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                
                DateTime FechaHoraActual = dp.NowSetDateTime();
                SqlTransaction transaction = null;

                //Guardar Cada Fila de Productos
                using (SqlConnection connection = new SqlConnection(dp.ConnectionStringERP))
                {
                    try
                    {
                        connection.Open();

                        SqlCommand command = connection.CreateCommand();
                        transaction = connection.BeginTransaction("SampleTransaction");
                        command.Connection = connection;
                        command.Transaction = transaction;

                        

                        foreach (var item in frm.productos)
                        {
                            dsConfigFacturaAutomatica.detalle_cursos_estudiantes_configRow row1 = dsConfigFacturaAutomatica1.detalle_cursos_estudiantes_config.Newdetalle_cursos_estudiantes_configRow();

                            var existe_pt = from rows in dsConfigFacturaAutomatica1.busqueda_estudiante_cursos.AsEnumerable()
                                            group rows by new { ProductoID = rows["id_pt"] } into grp
                                            where Convert.ToInt32(grp.Key.ProductoID) == item.ID_PT
                                            select new
                                            {
                                                Count = grp.Count()
                                            };

                            if (existe_pt.Count() == 0)
                            {
                                if (item.Precio > 0)
                                {

                                    int IdDetalleCOnfigInserted = 0;
                                    DateTime FechaActual = dp.NowSetDateTime();

                                    command.CommandText = "dbo.sp_insert_detalle_config_estudiante";
                                    command.CommandType = CommandType.StoredProcedure;

                                    command.Parameters.Clear();
                                    command.Parameters.AddWithValue("@id_estudiante", item.IdEstudiante);
                                    command.Parameters.AddWithValue("@min_dia_pago", item.min_dia_pago);
                                    command.Parameters.AddWithValue("@max_dia_pago", item.max_dia_pago);
                                    command.Parameters.AddWithValue("@fecha_registro_creado", FechaActual);
                                    command.Parameters.AddWithValue("@valor", item.Precio);
                                    command.Parameters.AddWithValue("@id_usuario", this.UsuarioLogeado.Id);
                                    command.Parameters.AddWithValue("@id_matricula_detalle", item.IdDetalleMatricula);
                                    command.Parameters.AddWithValue("@curso_id", item.CursoID);
                                    command.Parameters.AddWithValue("@enable", 1);

                                    IdDetalleCOnfigInserted = dp.ValidateNumberInt32(command.ExecuteScalar());
                                    int RowEncontrado = 0;


                                    //Si el row existe solo actualizamos los valores
                                    foreach(dsConfigFacturaAutomatica.detalle_cursos_estudiantes_configRow row in dsConfigFacturaAutomatica1.detalle_cursos_estudiantes_config)
                                    {
                                        if(IdDetalleCOnfigInserted == row.id)
                                        {
                                            //row.id = IdDetalleCOnfigInserted;
                                            row.id_pt = item.ID_PT;
                                            row.ItemCodeFacturacion = item.ItemCodePT_Facturacion;
                                            row.ItemNameFacturacion = item.ItemName_Pt_Facturacion;
                                            row.Item_Code = item.ItemCodeEstudiante;
                                            row.id_estudiante = item.IdEstudiante;
                                            row.nombre = item.EstudianteName;
                                            row.min_dia_pago = item.min_dia_pago;
                                            row.max_dia_pago = item.max_dia_pago;
                                            row.enable = true;
                                            row.fecha_registrado = FechaActual;
                                            row.valor = item.Precio;
                                            row.id_usuario = this.UsuarioLogeado.Id;
                                            row.Usuario_Nombre = this.UsuarioLogeado.Nombre;
                                            row.id_matricula_detalle = item.IdDetalleMatricula;
                                            row.curso_id = item.CursoID;
                                            row.curso = item.Curso_Name;
                                            row.rango_pago = "Del " + item.min_dia_pago.ToString() + " al " + item.max_dia_pago.ToString();
                                            RowEncontrado++;
                                            break;
                                        }
                                    }


                                    //Si el row no existe, agregaremos un row al grid.
                                    if (RowEncontrado == 0)
                                    {
                                        row1.id = IdDetalleCOnfigInserted;
                                        row1.id_pt = item.ID_PT;
                                        row1.ItemCodeFacturacion = item.ItemCodePT_Facturacion;
                                        row1.ItemNameFacturacion = item.ItemName_Pt_Facturacion;
                                        row1.Item_Code = item.ItemCodeEstudiante;
                                        row1.id_estudiante = item.IdEstudiante;
                                        row1.nombre = item.EstudianteName;
                                        row1.min_dia_pago = item.min_dia_pago;
                                        row1.max_dia_pago = item.max_dia_pago;
                                        row1.enable = true;
                                        row1.fecha_registrado = FechaActual;
                                        row1.valor = item.Precio;
                                        row1.id_usuario = this.UsuarioLogeado.Id;
                                        row1.Usuario_Nombre = this.UsuarioLogeado.Nombre;
                                        row1.id_matricula_detalle = item.IdDetalleMatricula;
                                        row1.curso_id = item.CursoID;
                                        row1.curso = item.Curso_Name;
                                        row1.rango_pago = "Del " + item.min_dia_pago.ToString() + " al " + item.max_dia_pago.ToString();

                                        dsConfigFacturaAutomatica1.detalle_cursos_estudiantes_config.Adddetalle_cursos_estudiantes_configRow(row1);
                                    }
                                }
                            }
                        }

                        transaction.Commit();
                        CajaDialogo.InformationAuto();
                    }
                    catch (Exception ec)
                    {   // Attempt to roll back the transaction.
                        try
                        {
                            transaction.Rollback();
                            CajaDialogo.Error(ec.Message);
                        }
                        catch (Exception ex2)
                        {
                            CajaDialogo.Error(ex2.Message);
                        }
                    }
                }

                dsConfigFacturaAutomatica1.detalle_cursos_estudiantes_config.AcceptChanges();

            }//End ShowDialog Buscar estudiante
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            LoadDatos();
        }

        

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        //Functions
        private void LoadDatos()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand("dbo.sp_get_detalle_config_factura_automatica", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("", 0);
                dsConfigFacturaAutomatica1.detalle_cursos_estudiantes_config.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsConfigFacturaAutomatica1.detalle_cursos_estudiantes_config);
                conn.Close();
            }
            catch (Exception EX)
            {
                CajaDialogo.Error(EX.Message);
            }
        }//end LoadDatos()

        private void checkSeleccionarTodos_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cmdEliminarLinea_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Eliminar row del grid
            DialogResult r = MessageBox.Show("¿Desea Eliminar ésta linea?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r != DialogResult.Yes)
            {
                return;
            }

            var gridView1 = (GridView)gridControl1.FocusedView;
            var row = (dsConfigFacturaAutomatica.detalle_cursos_estudiantes_configRow)gridView1.GetFocusedDataRow();

            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand("dbo.sp_update_config_linea_factuacion_automatica", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_config", row.id);
                cmd.ExecuteNonQuery();
                conn.Close();

                gridView1.DeleteRow(gridView1.FocusedRowHandle);
                dsConfigFacturaAutomatica1.AcceptChanges();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}