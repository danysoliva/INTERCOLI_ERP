using DevExpress.XtraEditors;
using ERP_INTECOLI.Clases;
using ERP_INTECOLI.Facturacion.CoreFacturas;
using JAGUAR_APP.Facturacion.CoreFacturas;
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

namespace ERP_INTECOLI.HistorialAcademico
{
    public partial class frmHomeHistorialAcademico : DevExpress.XtraEditors.XtraForm
    {
        Estudiante EstudianteActual;
        public frmHomeHistorialAcademico()
        {
            InitializeComponent();
            EstudianteActual = new Estudiante();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id_cliente_selected = 0;

            xfrmSelectCliente frm = new xfrmSelectCliente();
            Cliente cliente = new Cliente();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (cliente.RecuperarRegistro(frm.id_cliente))
                {
                    txtCliente.Text = cliente.Nombre;
                    txtCodigo.Text = cliente.Codigo;
                    //txtCorreo.Text = cliente.Correo;
                    //txtTelefono.Text = cliente.Telefono;
                    //txtDireccion.Text = cliente.Direccion;
                    //id_cliente_selected = frm.id_cliente;
                    //lblSaldo.Text = string.Format("{0: ###,##0.00}", cliente.SaldoActual);

                    LoadData(frm.id_cliente);
                }
                EstudianteActual.RecuperarRegistro(frm.id_cliente);
            }
        }


        private void LoadData(Int64 id_cliente)
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP))
                {
                    cnx.Open();
                    SqlDataAdapter da = new SqlDataAdapter("[dbo].[sp_get_datos_detalle_cursos_historial_academico]", cnx);

                    dsHistorialAcademico1.cursos.Clear();

                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@estudiante_id", id_cliente);
                    da.Fill(dsHistorialAcademico1.cursos);

                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}