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

namespace ERP_INTECOLI.Administracion.Caja
{
    public partial class frmTipoPago : DevExpress.XtraEditors.XtraForm
    {
        public int TipoPago
        {
            get;
            set;
        }


        public frmTipoPago()
        {
            InitializeComponent();
        }

        private void cmdEfectivo_Click(object sender, EventArgs e)
        {
            TipoPago = 1;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cmdTarjeta_Click(object sender, EventArgs e)
        {
            TipoPago = 2;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cmdTransferencia_Click(object sender, EventArgs e)
        {
            TipoPago = 3;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}