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

namespace ERP_INTECOLI.Administracion.Caja
{
    public partial class frmCaja : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeuado;

        public frmCaja(UserLogin pUserLogin) 
        {
        
            InitializeComponent();
            UsuarioLogeuado = pUserLogin;
            dateEdit1.EditValue = dateEditLibros.EditValue = dateEditReservas.EditValue = dtFechaEmision.EditValue = dp.Now();

            CargarDatos();
            CargarDatosB();
            CargarDatosLibros();
            CargarDatosReservas();
        }

        private void CargarDatosReservas()
        {
            try
            {
                //string sql = @"select * from admon.ft_carga_boletas_reservas_pendientes(:p_fecha);";
                string sql = @"sp_caja_carga_boletas_reservas_pendientes";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha", dateEditReservas.EditValue);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCaja1.ReservasPendientes.Clear();
                dsCaja1.ReservasLiberadas.Clear();
                adat.Fill(dsCaja1.ReservasPendientes);

                string sql1 = @"sp_caja_carga_boletas_reservas_liberadas";
                //@"select * from admon.ft_carga_boletas_reservas_liberadas(:p_fecha);";\
                SqlConnection conn1 = new SqlConnection(dp.ConnectionStringERP);
                conn1.Open();
                SqlCommand cmd1 = new SqlCommand(sql1, conn1);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@fecha", dateEditReservas.EditValue);
                SqlDataAdapter adat1 = new SqlDataAdapter(cmd1);
                adat1.Fill(dsCaja1.ReservasLiberadas);

            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void CargarDatosLibros()
        {
            try
            {
                //string sql = @"select * from admon.ft_carga_boletas_libros_pendientes(:p_fecha);";
                string sql = @"sp_caja_carga_boletas_libros_pendientes";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha", dateEditLibros.EditValue);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCaja1.LibrosPendientes.Clear();
                dsCaja1.Librosliberadas.Clear();
                adat.Fill(dsCaja1.LibrosPendientes);
                conn.Close();

                //string sql1 = @"select * from admon.ft_carga_boletas_libros_liberadas(:p_fecha);";
                string sql1 = @"sp_caja_carga_boletas_libros_liberadas";
                SqlConnection conn1 = new SqlConnection(dp.ConnectionStringERP);
                conn1.Open();
                SqlCommand cmd1 = new SqlCommand(sql1, conn1);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@fecha",  dateEditLibros.EditValue);
                SqlDataAdapter adat1 = new SqlDataAdapter(cmd1);
                adat1.Fill(dsCaja1.Librosliberadas);
                conn1.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void CargarDatos()
        {
            try
            {
                //string sql = @"select * from admon.ft_carga_fact_pendientes_v2 (:p_fecha);";
                string sql = @"sp_caja_cargar_fact_pendientes";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha", dtFechaEmision.EditValue);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCaja1.pendientes.Clear();
                dsCaja1.liberadas.Clear();
                adat.Fill(dsCaja1.pendientes);

                //string sql1 = @"select * from admon.ft_carga_fact_liberadas_v2 (:p_fecha);";
                string sql1 = @"sp_caja_cargar_fact_liberadas";
                SqlConnection conn1 = new SqlConnection(dp.ConnectionStringERP);
                conn1.Open();
                SqlCommand cmd1 = new SqlCommand(sql1, conn1);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@fecha", dtFechaEmision.EditValue);
                SqlDataAdapter adat1 = new SqlDataAdapter(cmd1);
                adat1.Fill(dsCaja1.liberadas);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void CargarDatosB()
        {
            try
            {
                //string sql = @"select * from admon.ft_carga_boletas_pendientes(:p_fecha);";
                string sql = @"sp_caja_cargar_boletas_pendientes";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha", dtFechaEmision.EditValue);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCaja1.bliberadas.Clear();
                dsCaja1.bpendientes.Clear();
                adat.Fill(dsCaja1.bpendientes);

                //string sql1 = @"select * from admon.ft_carga_boletas_liberadas(:p_fecha);";
                string sql1 = @"sp_caja_cargar_boletas_liberadas";
                SqlConnection conn1 = new SqlConnection(dp.ConnectionStringERP);
                conn1.Open();
                SqlCommand cmd1 = new SqlCommand(sql1, conn1);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@fecha", dtFechaEmision.EditValue);
                SqlDataAdapter adat1 = new SqlDataAdapter(cmd1);
                adat1.Fill(dsCaja1.bliberadas);

            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void cmdPrint_Click(object sender, EventArgs e)
        {
            
        }

        private void cmdPrintFact_Click(object sender, EventArgs e)
        {
            frmRePrintFactura fx = new frmRePrintFactura();
            //fx.MdiParent = this.MdiParent;
            fx.Show();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            CargarDatosB();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            CargarDatosLibros();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            CargarDatosReservas();
        }
    }
}