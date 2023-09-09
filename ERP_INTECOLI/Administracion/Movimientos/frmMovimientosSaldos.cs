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
using Infragistics.Win.UltraWinGrid;

namespace ERP_INTECOLI.Administracion.Movimientos
{
    public partial class frmMovimientosSaldos : DevExpress.XtraEditors.XtraForm
    {

        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogueado;
        Estudiante vEstudiante;

        public frmMovimientosSaldos(UserLogin pUserLogin)
        {
            InitializeComponent();
            UsuarioLogueado = pUserLogin;
            vEstudiante = new Estudiante();

            dtFechaDesde.Value = dtFechaDesde.Value.AddDays(7 * (-1));
        }

        private void cmdF2_Click(object sender, EventArgs e)
        {
            frmBuscarEstudiantes fx1 = new frmBuscarEstudiantes();
            if (fx1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                if (vEstudiante.RecuperarRegistro(fx1.ItemSeleccionado.id_estudiantes))
                {
                    txtEstudiante.Text = vEstudiante.Nombres + " " + vEstudiante.Apellidos;
                    CargarDatos(fx1.ItemSeleccionado.id_estudiantes);
                }
            }
            else
            {
                txtEstudiante.Text = "";
            }
        }

        private void CargarDatos(long ID_ESTUDIANTE)
        {
            try
            {
                string sql = "sp_movimientos_get_datos_estudiante";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_Estudiante", ID_ESTUDIANTE);
                cmd.Parameters.AddWithValue("@fechai",  dtFechaDesde.Value);
                cmd.Parameters.AddWithValue("@fechaf", dtFechaHasta.Value);
                if (rdSoloHabilitados.Checked)
                    cmd.Parameters.AddWithValue("@solo_habilitados", 1);
                else
                    cmd.Parameters.AddWithValue("@solo_habilitados", 0);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsMovimientosSaldos1.movimientos.Clear();
                adat.Fill(dsMovimientosSaldos1.movimientos);

                //this.grDetalle.DisplayLayout.Bands[0].Summaries.Clear();
                //foreach (UltraGridColumn columna_ in this.grDetalle.DisplayLayout.Bands[0].Columns)
                //{
                //    if (columna_.DataType == typeof(decimal))
                //    {
                //        SummarySettings s = this.grDetalle.DisplayLayout.Bands[0].Summaries.Add(SummaryType.Sum, columna_);
                //        s.DisplayFormat = "{0:#,###0.00}";

                //        s.Appearance.TextHAlign = Infragistics.Win.HAlign.Right;
                //        s.Appearance.BackColor = Color.LightYellow;
                //    }
                //}
            }
            catch (Exception ec)
            {
                CajaDialogo.Error("No se pudo cargar el detalle de Movimientos del Estudiante!", ec);
            }
        }

        private void txtEstudiante_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                frmBuscarEstudiantes fx1 = new frmBuscarEstudiantes();
                if (fx1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    if (vEstudiante.RecuperarRegistro(fx1.ItemSeleccionado.id_estudiantes))
                    {
                        txtEstudiante.Text = vEstudiante.Nombres + " " + vEstudiante.Apellidos;
                        CargarDatos(fx1.ItemSeleccionado.id_estudiantes);
                    }
                }
                else
                {
                    txtEstudiante.Text = "";
                }
            }
        }

        private void cmbCargarDatos_Click(object sender, EventArgs e)
        {

            if (vEstudiante != null)
            {
                CargarDatos(vEstudiante.IdEstudiante);
            }
        }

        private void reposAnular_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grDetalle.FocusedView;
            var row = (dsMovimientosSaldos.movimientosRow)gridview.GetFocusedDataRow();

            if (row.nulo)
            {
                DialogResult r = MessageBox.Show("Desea habilitar este Documento?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == System.Windows.Forms.DialogResult.Yes)
                {
                    UpdateDocumento(false, row.tipo, row.id);
                    cmbCargarDatos_Click(sender, new EventArgs());
                }
            }
            else
            {
                DialogResult r = MessageBox.Show("Desea Anular este Documento?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == System.Windows.Forms.DialogResult.Yes)
                {
                    UpdateDocumento(true, row.tipo, row.id);
                    cmbCargarDatos_Click(sender, new EventArgs());
                }
            }
        }

        private void UpdateDocumento(bool documento_anulado, int tipo, int num_documento)
        {
            //PgSqlTransaction tran = psConnection.BeginTransaction();
            try
            {
                string sql = @"sp_movimientos_habiliat_deshabilitar_documento";
                //if (tipo_doc == 1)
                //    sql = @"UPDATE admon.recibos
                //           SET nulo = :p_nulo
                //           WHERE id_recibo= :p_id;";
                //if (tipo_doc == 2)
                //    sql = @"UPDATE admon.mensualidades
                //           SET nulo= :p_nulo
                //           WHERE id_mensualidad= :p_id;";
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_nulo", documento_anulado);
                cmd.Parameters.AddWithValue("p_id",  num_documento);
                cmd.ExecuteNonQuery();
                CajaDialogo.Information("Transaccion exitosa!");

            }
            catch (Exception ec)
            {
                CajaDialogo.Error("No se pudo Guardar el cambio solicitado! ", ec);
            }
            
        }

        private void reposImprimir_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grDetalle.FocusedView;
            var row = (dsMovimientosSaldos.movimientosRow)gridview.GetFocusedDataRow();

            if (row.tipo == 1)
            {
                //rptRecibos rpt = new rptRecibos(psConnection, Convert.ToInt32(e.Cell.Row.Cells["id"].Value));
                //frmReporteador rep = new frmReporteador(rpt);
                //rep.MdiParent = this.MdiParent;
                //rep.Show();
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}