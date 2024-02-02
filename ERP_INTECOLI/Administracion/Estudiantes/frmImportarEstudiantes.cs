using DevExpress.XtraEditors;
using ERP_INTECOLI.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
        bool Existe;

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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grdEstudiantes.ExportToXlsx(dialog.FileName);
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            try
            {
                string file_name = string.Empty;

                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Excel File(.xlsx)| *.xlsx";
                dialog.Title = "Seleccione el archivo importado anteriormente";

                dsEstudiantes dsEstu = new dsEstudiantes();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    file_name = @dialog.FileName.ToString();
                    string Connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + file_name + "; Extended Properties=\"Excel 12.0 Xml; HDR = YES\"";
                    OleDbConnection con = new OleDbConnection(Connection);
                    OleDbDataAdapter myCommand = new OleDbDataAdapter("Select * from [Sheet$]", con);
                    dsEstudiantes1.prev_estudiantes.Clear();

                    //SplashForm frm = new SplashForm();

                    try
                    {
                        myCommand.Fill(dsEstudiantes1.prev_estudiantes);
                        dsEstudiantes1.prev_estudiantes.AcceptChanges();


                        for (int i = 0; i < gridView1.DataRowCount; i++)
                        {

                            DataRow row = gridView1.GetDataRow(i);

                            string numIdentidad = Convert.ToString(row.ItemArray[4]);

                            if (numIdentidad.Length > 1)
                            {
                                ValidacionNumIdentidad(numIdentidad);

                                if (Existe)
                                {
                                    row["ya_existe"] = true;
                                }


                                //if (Existe)
                                //    row.ItemArray[7] = true;
                                //else
                                //    row.ItemArray[7] = false;}

                            }
                            else
                            {
                                row["ya_existe"] = false;
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void ValidacionNumIdentidad(string num_identidad)
        {
            try
            {
                Existe = false;
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand("[sp_estudiantes_validar_existencia_identidad]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@identidad", num_identidad);
                Existe = Convert.ToBoolean(cmd.ExecuteScalar());
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            DialogResult r = CajaDialogo.Pregunta("Desea Guardar estos Registros como Estudiantes?\nSe omitiran los Estudiantes que el Num Identidad existan en Sistema!");
            if (r != System.Windows.Forms.DialogResult.Yes)
                return;

            if (gridView1.RowCount == 0)
            {
                CajaDialogo.Error("No se a cargado ningun dato!");
                return;
            }

            if (string.IsNullOrEmpty(gridPuntoVenta.Text))
            {
                CajaDialogo.Error("Debe seleccionar una Sucursal!");
                return;
            }

            foreach (dsEstudiantes.prev_estudiantesRow  item in dsEstudiantes1.prev_estudiantes.Rows)
            {
                if (item.ya_existe == false)
                {
                    SqlTransaction transaction = null;

                    SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                    bool Guardar = false;

                    try
                    {
                        conn.Open();
                        transaction = conn.BeginTransaction("Transaction Order");

                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "[sp_estudiantes_insert_new_estudiante]";
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (string.IsNullOrEmpty(item.nombre))
                            cmd.Parameters.AddWithValue("@nombres", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@nombres", item.nombre);

                        if (string.IsNullOrEmpty(item.apellido))
                            cmd.Parameters.AddWithValue("@apellidos", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@apellidos", item.apellido);

                        if (string.IsNullOrEmpty(item.correo))
                            cmd.Parameters.AddWithValue("@direccion", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@direccion", item.direccion);
                        cmd.Parameters.AddWithValue("@fecha_nacimiento", item.fecha_nacimiento);

                        cmd.Parameters.AddWithValue("@nivel_id_ingreso", DBNull.Value);
                        cmd.Parameters.AddWithValue("@sexo", DBNull.Value);

                        if (string.IsNullOrEmpty(item.correo))
                            cmd.Parameters.AddWithValue("@correo", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@correo", item.correo);

                        cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogueado.Id);

                        cmd.Parameters.AddWithValue("@proxima_fecha_pago", dp.Now().AddDays(30));
                        cmd.Parameters.AddWithValue("@seguimiento_saldo", 1);
                        cmd.Parameters.AddWithValue("@tipo_pago", 1);
                        cmd.Parameters.AddWithValue("@id_zona", DBNull.Value);
                        cmd.Parameters.AddWithValue("@id_estudiante_recomendo", DBNull.Value);
                        cmd.Parameters.AddWithValue("@nombre_recomendo", DBNull.Value);
                        cmd.Parameters.AddWithValue("@id_sucursal", gridPuntoVenta.EditValue);
                        cmd.Parameters.AddWithValue("@numero_identidad", item.num_identidad);
                        cmd.Parameters.AddWithValue("@IsEmpleado", 0);
                        cmd.Parameters.AddWithValue("@dias_min_pago", 1);
                        cmd.Parameters.AddWithValue("@dias_max_pago", 10);
                        cmd.Parameters.AddWithValue("@id_punto_venta", gridPuntoVenta.EditValue);

                        int id_header_estudiante = Convert.ToInt32(cmd.ExecuteScalar());

                        if (id_header_estudiante > 0)
                        {
                            if (!string.IsNullOrEmpty(item.telefono))
                            {
                                cmd.Parameters.Clear();
                                cmd.CommandText = "[sp_estudiantes_insert_detalle_telefono]";
                                cmd.Connection = conn;
                                cmd.Transaction = transaction;
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@id_estudiante", id_header_estudiante);
                                cmd.Parameters.AddWithValue("@telefono", item.telefono);
                                cmd.Parameters.AddWithValue("@tipo_telefono_id", 1); //tipos_telefono: 1 celular
                                cmd.ExecuteNonQuery();
                            }

                        }

                        transaction.Commit();
                        Guardar = true;

                        this.DialogResult = DialogResult.OK;
                        this.Close();

                    }
                    catch (Exception ec)
                    {
                        transaction.Rollback();
                        CajaDialogo.Error(ec.Message);
                        Guardar = false;
                    }
                }

            }
        }
    }
}