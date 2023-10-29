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
using ERP_INTECOLI.Compras;
using System.Data.SqlClient;

namespace ERP_INTECOLI.Compras
{
    public partial class frmSolicitudesMain : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogueado;
        DataOperations dp = new DataOperations();
        TipoOperacion tipooperacion;
        public frmSolicitudesMain(UserLogin pUserLog, TipoOperacion ptipo)
        {
            InitializeComponent();
            tipooperacion = ptipo;
        }

        public enum TipoOperacion
        {
            New = 1,
            Update = 2
        }
    }
}