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

namespace ERP_INTECOLI.Administracion.Caja
{
    public partial class frmCaja : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeuado;

        public frmCaja(UserLogin pUserLogin) 
        {
        
            InitializeComponent();
            UsuarioLogeuado = pUserLogin;
            dateEdit1.EditValue = dateEditLibros.EditValue = dateEditReservas.EditValue = dtFechaEmision.EditValue = dp.Now();

            CargarDatos();
            CargarDatosB();
            CargarDatosLibros();
            CargarDatosReservas();
        }

        private void CargarDatos()
        {
            try
            {
                string sql = @"select * from admon.ft_carga_fact_pendientes_v2 (:p_fecha);";
                PgSqlCommand cmd = new PgSqlCommand(sql, psConnection);
                cmd.Parameters.Add("p_fecha", PgSqlType.Date).Value = dtFechaEmision.EditValue;
                PgSqlDataAdapter adat = new PgSqlDataAdapter(cmd);
                dsCaja1.pendientes.Clear();
                dsCaja1.liberadas.Clear();
                adat.Fill(dsCaja1.pendientes);

                string sql1 = @"select * from admon.ft_carga_fact_liberadas_v2 (:p_fecha);";
                PgSqlCommand cmd1 = new PgSqlCommand(sql1, psConnection);
                cmd1.Parameters.Add("p_fecha", PgSqlType.Date).Value = dtFechaEmision.EditValue;
                PgSqlDataAdapter adat1 = new PgSqlDataAdapter(cmd1);
                adat1.Fill(dsCaja1.liberadas);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}