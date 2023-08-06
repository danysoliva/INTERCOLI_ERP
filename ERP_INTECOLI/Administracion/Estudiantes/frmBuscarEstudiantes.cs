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
using DevExpress.XtraGrid.Views.Grid;

namespace ERP_INTECOLI.Administracion.Estudiantes
{
    public partial class frmBuscarEstudiantes : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public ItemBusqueda ItemSeleccionado;
        DataView dv;// = new DataView(dsConfigLoteConsumo1.search_mp);

        public frmBuscarEstudiantes()
        {
            InitializeComponent();

            load_estudiantes(); 
            txtParametroBusqueda.Focus();
            ItemSeleccionado = new ItemBusqueda();
        }

        private void load_estudiantes()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_estudiantes_search_all", con);
                cmd.CommandType = CommandType.StoredProcedure;
                dsEstudiantes1.serach_estudiantes.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsEstudiantes1.serach_estudiantes);
                dv = new DataView(dsEstudiantes1.serach_estudiantes);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtParametroBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dv.Count == 1)
                {
                    var gridView = (GridView)gridControlDetalleEstudiantes.FocusedView;
                    var row = (dsEstudiantes.serach_estudiantesRow)gridView.GetDataRow(0);

                    ItemSeleccionado.id_estudiantes = row.id_estudiante;
                    ItemSeleccionado.Nombres = row.nombres;
                    ItemSeleccionado.Apellidos = row.apellidos;
                    ItemSeleccionado.Identidad = row.numero_identidad;
                    row.Seleccionado = true;

                    cmdAplicar_Click(new object(), new EventArgs());

                }
            }
        }

        private void cmdAplicar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtParametroBusqueda_EditValueChanged(object sender, EventArgs e)
        {
            dv.RowFilter = @"[concat_] like '%" + txtParametroBusqueda.Text + "%'";
            gridControlDetalleEstudiantes.DataSource = dv;

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var gridView = (GridView)gridControlDetalleEstudiantes.FocusedView;
            var row = (dsEstudiantes.serach_estudiantesRow)gridView.GetFocusedDataRow();

            ItemSeleccionado.id_estudiantes = row.id_estudiante;
            ItemSeleccionado.Nombres = row.nombres;
            ItemSeleccionado.Apellidos = row.apellidos;
            ItemSeleccionado.Identidad = row.numero_identidad;
            row.Seleccionado = true;

            cmdAplicar_Click(new object(), new EventArgs());

            foreach (dsEstudiantes.serach_estudiantesRow row1 in dsEstudiantes1.serach_estudiantes)
            {
                if (row1.id_estudiante != ItemSeleccionado.id_estudiantes)
                    row1.Seleccionado = false;
            }
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Seleccionado")
            {
                var gridView = (GridView)gridControlDetalleEstudiantes.FocusedView;
                var row = (dsEstudiantes.serach_estudiantesRow)gridView.GetFocusedDataRow();
                if (Convert.ToBoolean(e.Value))
                {
                    ItemSeleccionado.id_estudiantes = row.id_estudiante;
                    ItemSeleccionado.Nombres = row.nombres;
                    ItemSeleccionado.Apellidos = row.apellidos;
                    ItemSeleccionado.Identidad = row.numero_identidad;
                    row.Seleccionado = true;
                }

                foreach (dsEstudiantes.serach_estudiantesRow row1 in dsEstudiantes1.serach_estudiantes)
                {
                    if (row1.id_estudiante != ItemSeleccionado.id_estudiantes)
                        row1.Seleccionado = false;
                }
            }
        }
    }
}