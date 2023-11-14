using DevExpress.XtraEditors;
using ERP_INTECOLI.Clases;
using ERP_INTECOLI.Facturacion.CoreFacturas;
using JAGUAR_APP.Facturacion.Configuraciones;
using LOSA.Calidad.LoteConfConsumo;
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

namespace ERP_INTECOLI.Facturacion.FacturacionAutomatica
{
    public partial class frmConfigFacturaEstudianteAuto : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        PuntoVenta puntoVentaActual;
        public frmConfigFacturaEstudianteAuto(UserLogin pUsuario, PuntoVenta pPuntoVenta)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuario;
            puntoVentaActual = pPuntoVenta;
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            xfrmSelectEstudiante_FactAuto frm = new xfrmSelectEstudiante_FactAuto(this.UsuarioLogeado, puntoVentaActual);
            if (frm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {

        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {

        }

        //Functions
        void BuscarCliente(int pParametro)
        {
            
        }//end BuscarCliente()




    }
}