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
using System.Data.SqlClient;
using ERP_INTECOLI.Administracion.Estudiantes;


namespace ERP_INTECOLI.Transacciones
{
    public partial class frmReservaCupoTransaction : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogueado;
        DataOperations dp = new DataOperations();
        public int IdEstudiante;
        public bool PermisoDenegado;
        Estudiante vEstudiante;
        decimal Valor = 0;
        public int IdCurso;
        public int IdSeccion;
        public int IdNivel;


        public frmReservaCupoTransaction(UserLogin puser)
        {
            InitializeComponent();
            IdSeccion = 0;
            gridNivel.Text = "";
            IdNivel = 0;
            CargarNiveles();
            UsuarioLogueado = puser;
            dtFecha.Value = dp.Now();
            Estudiante vEstudiante = new Estudiante();


            dtDesde.Value = dp.Now().AddDays(-1);
            dtHasta.Value = dp.Now();
        }

        private void CargarNiveles()
        {

            try
            {
                string sql = "[sp_estudiantes_load_niveles_academicos]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsNuevoCursoMatricula1.niveles.Clear(); //dsMatricula1.niveles.Clear();
                adat.Fill(dsNuevoCursoMatricula1.niveles);
                //txtestdiante.Text = vEstudiante.Nombres + " " + vEstudiante.Apellidos;

                
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void CargarSecciones(int pid_nivel)
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand("[sp_matricula_recupera_secciones_for_id_nviel]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_nivel", pid_nivel);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsNuevoCursoMatricula1.secciones.Clear();
                adat.Fill(dsNuevoCursoMatricula1.secciones);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            
        
        }

        private void TSisEstudiante_Toggled(object sender, EventArgs e)
        {
            if (TSisEstudiante.IsOn)//es estudiante
            {
                cmdF2.Enabled = true;
                txtEstudiante.ReadOnly = true;
                //txtEstudiante.tex = "F2 para buscar...";
            }
            else
            {
                txtEstudiante.ReadOnly = false;
                cmdF2.Enabled = false;
                //txtestdiante.NullText = "";
                txtEstudiante.Focus();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gridControl1.ExportToXlsx(dialog.FileName);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void gridNivel_EditValueChanged(object sender, EventArgs e)
        {
            CargarSecciones(IdNivel);

            if (!string.IsNullOrEmpty(gridNivel.Text))
            {
                if (gridNivel.EditValue != DBNull.Value && gridNivel.EditValue != null)
                {
                    IdNivel = Convert.ToInt32(gridNivel.EditValue);
                    foreach (DataRow item in dsNuevoCursoMatricula1.niveles)
                    {
                        if (Convert.ToInt32(item["id_nivel"]) == IdNivel)
                        {
                            Valor = spindValor.Value = Convert.ToDecimal(item["valor"]);
                            break;
                        }
                    }
                }
            }

            
        }

        private void cmdF2_Click(object sender, EventArgs e)
        {
            frmBuscarEstudiantes fx1 = new frmBuscarEstudiantes();
            if (fx1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                if (vEstudiante == null)
                {
                    vEstudiante = new Estudiante();
                }

                if (vEstudiante.RecuperarRegistro(fx1.ItemSeleccionado.id_estudiantes))
                {
                    txtEstudiante.Text = vEstudiante.Nombres + " " + vEstudiante.Apellidos;
                }
            }
            else
            {
                txtEstudiante.Text = "";
            }
        }

        void Loadreservas()
        {
            try
            {
                //string SQL = @"select * from admon.sp_get_resumen_reserva_cupos_home(:pdesde,
                //                                                                     :phasta,
                //                                                                     :ver_nulas);";
                string SQL = @"sp_get_resumen_reserva_cupos_home";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(SQL, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pdesde", dtDesde.Value);
                cmd.Parameters.AddWithValue("@phasta", dtHasta.Value);
                cmd.Parameters.AddWithValue("@ver_nulas", TSverNulas.IsOn);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsNuevoCursoMatricula1.reservas_list.Clear();
                adat.Fill(dsNuevoCursoMatricula1.reservas_list);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void listboxSecciones_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listboxSecciones.SelectedValue != null)
                IdSeccion = Convert.ToInt32(listboxSecciones.SelectedValue);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Loadreservas();
        }

        private void LimpiarVentana()
        {
            vEstudiante = new Estudiante();
            txtEstudiante.Text = "";
            IdSeccion = 0;
            IdNivel = 0;
            spindValor.Value = 0;
            txtComentario.Text = "";
            dsNuevoCursoMatricula1.secciones.Clear();
            CargarNiveles();
            gridNivel.EditValue = DBNull.Value;
            IdNivel = 0;
            //ConfiguracionSuccess dp = new ConfiguracionSuccess(psConnection);
            dtFecha.Value = dp.Now();
        }

        private void cmdAplicar_Click(object sender, EventArgs e)
        {
            //Guardar Datos
            if (IdNivel == 0)
            {
                CajaDialogo.Error("Es necesario definir el nivel!");
                gridNivel.Focus();
                return;
            }
            if (IdSeccion == 0)
            {
                CajaDialogo.Error("Es necesario definir la Sección!");
                listboxSecciones.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtComentario.Text))
            {
                //CajaDialogo.Error("Es necesario ingresar el nombre del Libro!");
                //return;
            }

            if (string.IsNullOrEmpty(txtEstudiante.Text))
            {
                if (TSisEstudiante.IsOn)
                    CajaDialogo.Error("Es necesario Seleccionar un Estudiante!");
                else
                    CajaDialogo.Error("Es necesario escribir el nombre del Estudiante!");

                return;
            }

            if (Valor <= 0)
            {
                CajaDialogo.Error("El valor del libro debe ser mayor a cero (0)");
                return;
            }

            try
            {
                //string SQL = @"select * from admon.ft_insert_boleta_reserva_cupo(:pid_est,
                //                                                                  :pid_nivel,
                //                                                                  :pid_seccion,
                //                                                                  :pvalor,
                //                                                                  :pfecha,
                //                                                                  :pcomentario,
                //                                                                  :pid_user,
                //                                                                  :pnombre);";
                string sql = @"sp_insert_boleta_reserva_cupo";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                if (TSisEstudiante.IsOn)
                    cmd.Parameters.AddWithValue("@id_est", vEstudiante.IdEstudiante);
                else
                    cmd.Parameters.AddWithValue("@id_est", DBNull.Value);

                cmd.Parameters.AddWithValue("@id_ivel", IdNivel);
                cmd.Parameters.AddWithValue("@id_seccion", IdSeccion);
                cmd.Parameters.AddWithValue("@valor", spindValor.Value);
                cmd.Parameters.AddWithValue("@fecha", dtFecha.Value);
                cmd.Parameters.AddWithValue("@comentario", txtComentario.Text);
                cmd.Parameters.AddWithValue("@id_user", UsuarioLogueado.Id);
                cmd.Parameters.AddWithValue("@nombre", txtEstudiante.Text);
                string id = cmd.ExecuteScalar().ToString();

                CajaDialogo.Information("Se creo con exito la Reserva de Cupo #" + id);
                LimpiarVentana();
                //this.DialogResult = DialogResult.Cancel;
                //this.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

        }
    }
}