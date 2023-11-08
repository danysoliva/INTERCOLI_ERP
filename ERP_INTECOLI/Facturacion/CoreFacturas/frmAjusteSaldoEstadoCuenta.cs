using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using ERP_INTECOLI.Clases;
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

namespace ERP_INTECOLI.Facturacion.CoreFacturas
{
    public partial class frmAjusteSaldoEstadoCuenta : DevExpress.XtraEditors.XtraForm
    {
        enum TransaccionTipoAjuste
        {
            Credito =1,
            Debito =2 
        }

        Int64 IdDetalleMatricula;
        DataOperations dp;
        Estudiante EstudianteActual;
        UserLogin UsuarioLogeado;
        TransaccionTipoAjuste TipoTransaccionActual;
        decimal Monto;

        public frmAjusteSaldoEstadoCuenta(Estudiante pEstudianteActual, UserLogin pUsuario)
        {
            InitializeComponent();
            Monto = 0;
            dp = new DataOperations();
            EstudianteActual = pEstudianteActual;
            UsuarioLogeado = pUsuario;
            lblNombre.Text = "Aplicar a: " +pEstudianteActual.Nombres.Trim() + " " + EstudianteActual.Apellidos.Trim();
            CargarDatosCuros();
        }

        private void CargarDatosCuros()
        {
            //sp_get_cursos_estudiante_small_view
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_cursos_estudiante_small_view", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_estudiante", EstudianteActual.IdEstudiante);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsVentaSuccess1.detalle_cursos_estudiante);
                conn.Close();
            }
            catch (Exception EX)
            {
                CajaDialogo.Error(EX.Message);
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdCredito_Click(object sender, EventArgs e)
        {
            cmdCredito.Appearance.BackColor = Color.FromArgb(225, 253, 234);
            cmdDebito.Appearance.BackColor = Color.Transparent;
            TipoTransaccionActual = TransaccionTipoAjuste.Credito;
            txtMonto.Focus();
        }

        private void cmdDebito_Click(object sender, EventArgs e)
        {
            cmdCredito.Appearance.BackColor = Color.Transparent;
            cmdDebito.Appearance.BackColor = Color.FromArgb(225, 253, 234);
            TipoTransaccionActual = TransaccionTipoAjuste.Debito;
            txtMonto.Focus();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (Monto<=0)
            {
                CajaDialogo.Error("No se permite ajustes menores o iguales a cero (0)!");
                errorProvider1.SetError(txtMonto, "Es necesario ingresar un valor mayor a cero!");
                return;
            }

            if (txtDescripcion.Text.Length <= 10)
            {
                CajaDialogo.Error("Es necesario agregar una descripción!");
                errorProvider1.SetError(txtDescripcion, "Es necesario agregar una descripción válida!");
                return;
            }

            if (IdDetalleMatricula == 0)
            {
                CajaDialogo.Error("Es necesario indicar un curso!");
                errorProvider1.SetError(gridControl1, "Es necesario indicar un curso!");
                return;
            }

            DialogResult r = CajaDialogo.Pregunta("Esta seguro de aplicar este ajuste?");

            if (r != DialogResult.Yes)
                return;

            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand("dbo.sp_set_insert_ajuste_estado_cuenta", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_matricula_detalle", IdDetalleMatricula);
                cmd.Parameters.AddWithValue("@id_estudiante", EstudianteActual.IdEstudiante);

                if(TipoTransaccionActual == TransaccionTipoAjuste.Credito)
                {
                    cmd.Parameters.AddWithValue("@credito", Monto);
                    cmd.Parameters.AddWithValue("@debito", 0);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@credito", 0);
                    cmd.Parameters.AddWithValue("@debito", Monto);
                }
                
                cmd.Parameters.AddWithValue("@concepto", txtDescripcion.Text);
                cmd.Parameters.AddWithValue("@fecha_creado", dp.NowSetDateTime());
                cmd.Parameters.AddWithValue("@id_usuario", this.UsuarioLogeado.Id);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception EX)
            {
                CajaDialogo.Error(EX.Message);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtMonto_EditValueChanged(object sender, EventArgs e)
        {
            Monto = dp.ValidateNumberDecimal(txtMonto.Text);
        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                var gridView = (GridView)gridControl1.FocusedView;
                var row = (dsVentaSuccess.detalle_cursos_estudianteRow)gridView.GetDataRow(e.RowHandle);
                if (row != null)
                {
                    if (row.seleccionado)
                        e.Appearance.BackColor = Color.FromArgb(225, 253, 234);
                    else
                        e.Appearance.BackColor = Color.White;

                }
            }
        }

        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsVentaSuccess.detalle_cursos_estudianteRow)gridView.GetFocusedDataRow();
            row.seleccionado = true;
            IdDetalleMatricula = row.id_detalle;

            foreach (dsVentaSuccess.detalle_cursos_estudianteRow row2 in dsVentaSuccess1.detalle_cursos_estudiante)
            {
                if(row2.id_detalle!= row.id_detalle)
                {
                    row.seleccionado = false;
                }
            }
        }

        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsVentaSuccess.detalle_cursos_estudianteRow)gridView.GetFocusedDataRow();
            row.seleccionado = true;
            IdDetalleMatricula = row.id_detalle;

            foreach (dsVentaSuccess.detalle_cursos_estudianteRow row2 in dsVentaSuccess1.detalle_cursos_estudiante)
            {
                if (row2.id_detalle != row.id_detalle)
                {
                    row.seleccionado = false;
                }
            }
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsVentaSuccess.detalle_cursos_estudianteRow)gridView.GetFocusedDataRow();
            row.seleccionado = true;
            IdDetalleMatricula = row.id_detalle;

            foreach (dsVentaSuccess.detalle_cursos_estudianteRow row2 in dsVentaSuccess1.detalle_cursos_estudiante)
            {
                if (row2.id_detalle != row.id_detalle)
                {
                    row.seleccionado = false;
                }
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsVentaSuccess.detalle_cursos_estudianteRow)gridView.GetFocusedDataRow();
            //row.seleccionado = true;
            

            if (row.seleccionado)
            {
                IdDetalleMatricula = row.id_detalle;
                foreach (dsVentaSuccess.detalle_cursos_estudianteRow row2 in dsVentaSuccess1.detalle_cursos_estudiante)
                {
                    if (row2.id_detalle != row.id_detalle)
                    {
                        row.seleccionado = false;
                    }
                }
            }
        }

        private void txtMonto_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                txtDescripcion.Focus();
        }

        private void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cmdGuardar.Focus();
        }
    }
}