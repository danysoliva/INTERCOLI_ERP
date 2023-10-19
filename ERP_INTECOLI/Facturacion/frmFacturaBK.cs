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
using DevExpress.XtraGrid.Views.Grid;

namespace ERP_INTECOLI.Facturacion
{
    public partial class frmFacturaBK : DevExpress.XtraEditors.XtraForm
    {
        public frmFacturaBK()
        {
            InitializeComponent();
        }

        private void toggleTipoFactura_Toggled(object sender, EventArgs e)
        {
            if (toggleTipoFactura.IsOn == false)
                lblFechaVencimiento.Visible = dtFechaVenc.Visible = false;
            else
                lblFechaVencimiento.Visible = dtFechaVenc.Visible = true;
        }

        private void cmdGenerar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {

            var gridViewx = (GridView)gridControl1.FocusedView;
            int borrar = 0;
            for (int i = 0; i < gridViewx.DataRowCount; i++)
            {
                DataRow row = gridViewx.GetDataRow(i);
                row["cantidad"] = 1;
                if (!Convert.ToBoolean(row["seleccion"].ToString()))
                {
                    borrar++;
                }
            }

            while (borrar >= 1)
            {
                for (int i = 0; i < gridViewx.DataRowCount; i++)
                {
                    DataRow row = gridViewx.GetDataRow(i);
                    //row["cantidad"] = 1;
                    if (!Convert.ToBoolean(row["seleccion"].ToString()))
                    {
                        gridViewx.DeleteRow(i);
                        borrar = borrar - 1;
                        break;
                    }
                }
            }
        }
    }
}