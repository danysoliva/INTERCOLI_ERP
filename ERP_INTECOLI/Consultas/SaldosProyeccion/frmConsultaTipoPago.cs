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

namespace ERP_INTECOLI.Administracion.Consultas
{
    public partial class frmConsultaTipoPago : DevExpress.XtraEditors.XtraForm
    {
        public frmConsultaTipoPago()
        {
            InitializeComponent();
        }

        void CargarDatos()
        {
            try
            {
                string sql = "";
                if (tgOpcionPago.IsOn)
                {
                    sql = @"select (es.nombres + ' ' + es.apellidos) as nombre 
                            from estudiante es
                            where  es.tipo_pago = 2
                                  and es.habilitado =  1
                            order by es.nombres asc, es.apellidos asc";
                }
                else
                {
                    sql = @"select (es.nombres + ' '+ es.apellidos) as nombre 
                            from estudiante es
                            where  es.tipo_pago = 1 and
                                   es.habilitado = 1
                            order by es.nombres asc, es.apellidos asc";
                }
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                //cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                dsEstudiantes1.tipo_pago.Clear();
                adap.Fill(dsEstudiantes1.tipo_pago);
                lblTotal.Text = dsEstudiantes1.tipo_pago.Count.ToString();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }


        private void cmdCargar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void tgOpcionPago_Toggled(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}