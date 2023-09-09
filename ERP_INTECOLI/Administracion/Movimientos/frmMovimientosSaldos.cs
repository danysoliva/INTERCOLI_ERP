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

namespace ERP_INTECOLI.Administracion.Movimientos
{
    public partial class frmMovimientosSaldos : DevExpress.XtraEditors.XtraForm
    {

        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogueado;

        public frmMovimientosSaldos(UserLogin pUserLogin)
        {
            InitializeComponent();
            UsuarioLogueado = pUserLogin;

        }
    }
}