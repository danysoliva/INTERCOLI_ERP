using DevExpress.XtraEditors;
using ERP_INTECOLI.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_INTECOLI.Facturacion.FacturacionAutomatica
{
    public partial class frmFacturasAutomaticasHome : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        PuntoVenta PuntoVentaActual;
        public frmFacturasAutomaticasHome(UserLogin pUsuarioLogeado, PuntoVenta pPuntoVenta)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
            PuntoVentaActual = pPuntoVenta;
        }
    }
}