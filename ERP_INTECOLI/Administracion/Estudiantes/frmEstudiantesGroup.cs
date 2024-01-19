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
using System.Data.SqlClient;
using ERP_INTECOLI.Clases;
using ERP_INTECOLI.Administracion.Estudiantes;
using Infragistics.Win.UltraWinGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace ERP_INTECOLI.Administracion.Estudiantes
{
    public partial class frmEstudiantesGroup : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();
        PuntoVenta PuntoDeVentaActual;

        public frmEstudiantesGroup(UserLogin pUserLogin, PuntoVenta pPuntoDeVentaActual)
        {
            InitializeComponent();
            UsuarioLogeado = pUserLogin;
            this.PuntoDeVentaActual = pPuntoDeVentaActual;
            load_data();
            txtParametro.Focus();
        }

        private void load_data()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_load_estudiantes", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ver_todos", tsVerTodos.IsOn);
                cmd.Parameters.AddWithValue("@id_punto_venta", this.PuntoDeVentaActual.ID);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsEstudiantes1.estudiantes.Clear();
                adat.Fill(dsEstudiantes1.estudiantes);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void tsVerTodos_Toggled(object sender, EventArgs e)
        {
            load_data();
        }

        private void txtParametro_ValueChanged(object sender, EventArgs e)
        {
            //UltraGridBand band = this.grDetalle.DisplayLayout.Bands[0];
            //band.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True;
            //band.Columns["concatenacion"].AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True;
            //band.Override.RowFilterMode = RowFilterMode.AllRowsInBand;
            //band.ColumnFilters["concatenacion"].FilterConditions.Clear();
            //this.grDetalle.DisplayLayout.Bands[0].ColumnFilters.ClearAllFilters();

            //if (this.grDetalle.Rows.Count > 0)
            //{
            //    if (txtParametro.Value != DBNull.Value && txtParametro.Value != null)
            //    {
            //        this.grDetalle.DisplayLayout.Bands[0].ColumnFilters["concatenacion"].FilterConditions.Add(FilterComparisionOperator.Like, "*" + txtParametro.Value + "*");
            //    }
            //}
            //if (string.IsNullOrEmpty(this.txtParametro.Text))
            //{
            //    load_data();
            //}
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            frmEstudiantes frm = new frmEstudiantes(UsuarioLogeado, frmEstudiantes.TipoEdicion.Nuevo, PuntoDeVentaActual);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                load_data();
            }
        }

        private void grDetalle_ClickCellButton(object sender, Infragistics.Win.UltraWinGrid.CellEventArgs e)
        {
            switch (e.Cell.Column.Key)
            {
                case "editar":
                    frmEstudiantes frm = new frmEstudiantes(this.UsuarioLogeado, frmEstudiantes.TipoEdicion.Editar, Convert.ToInt32(e.Cell.Row.Cells["id_estudiante"].Value), PuntoDeVentaActual);
                    frm.ShowDialog(this);
                    load_data();
                    break;

                case "antiguiedad":
                    frmHistoarialAntiguedad frx = new frmHistoarialAntiguedad(Convert.ToInt32(e.Cell.Row.Cells["id_estudiante"].Value));
                    frx.ShowDialog();

                    break;
                default:
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reposEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gridEstudiantes.FocusedView;
            var row = (dsEstudiantes.estudiantesRow)gridview.GetFocusedDataRow();

            frmEstudiantes frm = new frmEstudiantes(this.UsuarioLogeado, frmEstudiantes.TipoEdicion.Editar, row.id_estudiante, PuntoDeVentaActual);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                load_data();
            }


        }

        private void reposAntiguedad_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gridEstudiantes.FocusedView;
            var row = (dsEstudiantes.estudiantesRow)gridview.GetFocusedDataRow();

            frmHistoarialAntiguedad frx = new frmHistoarialAntiguedad(row.id_estudiante);
            frx.ShowDialog();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            frmImportarEstudiantes frm = new frmImportarEstudiantes(UsuarioLogeado, PuntoDeVentaActual);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                load_data();
            }
        }
    }
}