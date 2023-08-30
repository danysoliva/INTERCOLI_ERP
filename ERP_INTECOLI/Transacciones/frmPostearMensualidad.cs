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

namespace ERP_INTECOLI.Transacciones
{
    public partial class frmPostearMensualidad : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogueado;
        Estudiante vEstudiante;
        DataOperations dp = new DataOperations();
        int V_Dias = 0;
        Decimal VarDescuento;
        Decimal VarRecargo;
        Decimal VarAbono;

        enum switchColor
        {
            no_pintado = 0,
            pintado = 1
        }

        switchColor ColorActual = switchColor.no_pintado;

        public frmPostearMensualidad(UserLogin PuserLogin)
        {
            InitializeComponent();
            UsuarioLogueado = PuserLogin;
            VarDescuento = 0;
            VarRecargo = 0;
            VarAbono = 0;
            vEstudiante = new Estudiante();

            //ConfiguracionSuccess Conf = new ConfiguracionSuccess(psConnection);
            dtFechaLimite.Value = dp.Now();
            CargarNiveles();
        }

        private void CargarNiveles()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                dsMensualidades1.niveles_academicos.Clear();
                string sql = @"sp_load_niveles_";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMensualidades1.niveles_academicos);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error("No se pudieron cargar los niveles academicos para el ultracombobox! \n", ec);
            }
        }

        private void cmdRecargarSaldo_Click(object sender, EventArgs e)
        {

        }

        private void cmdF2_Click(object sender, EventArgs e)
        {
            frmBuscarEstudiantes fx1 = new frmBuscarEstudiantes();
            if (fx1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                if (vEstudiante.RecuperarRegistro(fx1.ItemSeleccionado.id_estudiantes))
                {
                    txtestudiante.Text = vEstudiante.Nombres + " " + vEstudiante.Apellidos;
                    if (vEstudiante.FechaProximoPago.ToString() == "1/1/0001 12:00:00 AM")
                        dtFechaPagoProximo.Value = DateTime.Now;
                    else
                        dtFechaPagoProximo.Value = vEstudiante.FechaProximoPago;

                    if (vEstudiante != null)
                    {
                        if (vEstudiante.IdEstudiante > 0)
                        {
                            if (!vEstudiante.Habilitado)
                            {
                                timer1.Start();
                            }
                            else
                            {
                                timer1.Stop();
                                //PanelEncabezado.BackColor = Color.White;
                                lblRotulo.Visible = false;
                            }

                            if (vEstudiante.TipoPagoEstudiante == Estudiante.TipoPago.Posterior)
                                toggleSwitch1.IsOn = true;
                            else
                                toggleSwitch1.IsOn = false;

                            CargarCursos(vEstudiante.IdEstudiante);
                            Saldos sal = new Saldos();
                            CargarDetalleMensualidades(vEstudiante.IdEstudiante);
                            decimal dsal = sal.ConsultarSaldo(vEstudiante.IdEstudiante);
                            if (dsal == 0)
                                txtSaldo.Text = "0";
                            else
                                if (dsal > 1000)
                                txtSaldo.Text = String.Format("{0:0,000.00}", dsal);
                            else
                                txtSaldo.Text = String.Format("{0:00.00}", dsal);

                        }
                    }

                }

            }
            else
            {
                txtestudiante.Text = "";
            }
        }

        private void CargarDetalleMensualidades(long pIdEstudiante)
        {
            try
            {

                //string sql = "select * from admon.ft_detalle_mensualidades_abonos_v3 (:p_id_est);";
                string sql = @"sp_detalle_mensualidades_abonos";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_est", pIdEstudiante);
                //cmd.Parameters.Add("p_id_est", PgSqlType.Int).Value = pIdEstudiante;
                dsMensualidades1.mensualidades.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMensualidades1.mensualidades);
                conn.Close();
                
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void CargarCursos(long pEstudiante)
        {
            try
            {
                //string sql = "select * from admon.ft_cursos_matriculados (:p_estudiante_id);";
                string sql = "cursos_matriculados";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add("p_estudiante_id", PgSqlType.Int).Value = pEstudiante;
                cmd.Parameters.AddWithValue("@estudiante_id", pEstudiante);
                dsMensualidades1.cursos.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMensualidades1.cursos);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error("No se pudo cargar los cursos matriculados por el alumno!\n" + ec.Message);
            }
        }
    }
}