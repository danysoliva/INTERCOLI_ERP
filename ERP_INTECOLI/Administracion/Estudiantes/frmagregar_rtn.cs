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
using ERP_INTECOLI.Administracion.Estudiantes;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace ERP_INTECOLI.Administracion.Estudiantes
{
    public partial class frmagregar_rtn : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public string rtn;
        public int id_empresa;
        public string empresa;
        public int id_detalle_rtn;
        int Id_estudiante = 0;

        public enum TipoEdicion
        {
            Nuevo = 1,
            Editar = 2
        }

        private TipoEdicion pTipoEdit;

        public frmagregar_rtn(TipoEdicion ptipoEdicion, int pId_estudiante, int pid, string prtn, int pid_empresa)
        {
            InitializeComponent();

            cargar_empresa();

            pTipoEdit = ptipoEdicion;

            switch (ptipoEdicion)
            {
                case TipoEdicion.Nuevo:

                    break;
                case TipoEdicion.Editar:
                    id_empresa = pid_empresa;
                    rtn = prtn;
                    txtRTN.Text = rtn;
                    Id_estudiante = pId_estudiante;
                    id_detalle_rtn = pid;

                    grdEmpresa.EditValue = id_empresa;

                    break;
                default:
                    break;
            }

        }

        public frmagregar_rtn(TipoEdicion ptipoEdicion)
        {
            InitializeComponent();

            cargar_empresa();

            pTipoEdit = ptipoEdicion;

            switch (ptipoEdicion)
            {
                case TipoEdicion.Nuevo:

                    break;
                case TipoEdicion.Editar:

                    break;
                default:
                    break;
            }

        }

        private void cargar_empresa()
        {

            try
            {
                string sql = "sp_estudiantes_get_empresas";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsEstudiantes1.detalle_empresa.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsEstudiantes1.detalle_empresa);
                conn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRTN.Text))
            {
                CajaDialogo.Error("No puede dejar vacio este campo!");
                txtRTN.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtRTN.Text))
            {
                CajaDialogo.Error("Debe Seleccionar una Empresa");
                return;
            }

            
            id_empresa = Convert.ToInt32(grdEmpresa.EditValue);
            empresa = grdEmpresa.Text;
            rtn = txtRTN.Text.Trim();

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void grdEmpresa_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(grdEmpresa.Text))
            {
                return;
            }

            var gridview = grdEmpresa.Properties.View;

            rtn = Convert.ToString(gridview.GetRowCellValue(gridview.FocusedRowHandle, "rtn_empresa"));
            txtRTN.Text = rtn;
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}