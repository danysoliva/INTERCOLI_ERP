using DevExpress.XtraEditors;
using ERP_INTECOLI.Clases;
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
using static ERP_INTECOLI.Clases.Conf_TablesID;

namespace JAGUAR_APP.Facturacion.Configuraciones
{
    public partial class xfrmListaPreciosClientesAplicaCRUD : DevExpress.XtraEditors.XtraForm
    {
        UserLogin usuarioLogueado;

        public delegate void get_MP_inserted(int Id_MP_inserted);
        public event get_MP_inserted EventoPasarId_MP_inserted;
        Conf_TablesID tableID = new Conf_TablesID();
        ListaPrecios lista_precios = new ListaPrecios();
        public enum TipoTransaccion
        {
           Nuevo=1,
           Editar=2
        }

        TipoTransaccion transaccion = new TipoTransaccion();

        public xfrmListaPreciosClientesAplicaCRUD(UserLogin userLog, TipoTransaccion pTransaccion,int id_listaPrecio)
        {
            InitializeComponent();
            usuarioLogueado = userLog;
            buildMonthListh();
            transaccion = pTransaccion;

            lista_precios.RecuperaRegistro(id_listaPrecio);        
        }

        private void xfrmMasterMP_CRUD_Load(object sender, EventArgs e)
        {
            if (transaccion == TipoTransaccion.Editar)
            {
                txtCodigo.Text = lista_precios.Codigo;
                //txtDescripcion.Text = lista_precios.Descripcion;
                //slueCliente.EditValue = Convert.ToDateTime( lista_precios.Anio+"-01-01");
                //cbxMonth.EditValue = lista_precios.Mes;
            }
            else
            {
                GetIDTable();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            try
            {

                DataOperations dp = new DataOperations();
                int id_inserted = 0;

                //if (string.IsNullOrEmpty(txtDescripcion.Text))
                //{
                //    CajaDialogo.Error("DEBE INGRESAR UNA DESCRIPCIÓN");
                //    return;
                //}

                //if (string.IsNullOrEmpty( cbxMonth.Text))
                //{
                //    CajaDialogo.Error("DEBE SELECCIONAR UN MES");
                //    return;
                //}

                if (string.IsNullOrEmpty(slueCliente.Text))
                {
                    CajaDialogo.Error("DEBE SELECCIONAR UN AÑO");
                    return;
                }

                if (string.IsNullOrEmpty(txtCodigo.Text))
                {
                    CajaDialogo.Error("DEBE INGRESAR UN CODIGO");
                    return;
                }

                
                switch (transaccion)
                {
                    case TipoTransaccion.Nuevo:

                        using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP))
                        {
                            cnx.Open();
                            SqlCommand cmd = new SqlCommand("dbo.uspInsert_ListaPrecio", cnx);

                            cmd.CommandType = CommandType.StoredProcedure;
                            //cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = txtDescripcion.Text;
                            //cmd.Parameters.Add("@anio", SqlDbType.Int).Value = slueCliente.DateTime.Year;
                            //cmd.Parameters.Add("@mes", SqlDbType.VarChar).Value = cbxMonth.EditValue;
                            cmd.Parameters.Add("@usuario_id", SqlDbType.Int).Value = usuarioLogueado.Id;
                            cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = txtCodigo.Text;
                            cmd.Parameters.Add("@fecha_creacion", SqlDbType.VarChar).Value = DateTime.Now;
                            
                            id_inserted=Convert.ToInt32( cmd.ExecuteScalar());

                           //EventoPasarId_MP_inserted(id_inserted);


                            CajaDialogo.Information("DATOS GUARDADOS");
                            this.DialogResult = DialogResult.OK;
                            cnx.Close();
                        }
                     break;

                    case TipoTransaccion.Editar:

                        using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP))
                        {
                            cnx.Open();
                            SqlCommand cmd2 = new SqlCommand("dbo.uspUpdate_ListaPrecio", cnx);

                            //cmd2.CommandType = CommandType.StoredProcedure;
                            //cmd2.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = txtDescripcion.Text;
                            //cmd2.Parameters.Add("@anio", SqlDbType.Int).Value = slueCliente.DateTime.Year;
                            //cmd2.Parameters.Add("@mes", SqlDbType.Int).Value = cbxMonth.EditValue;
                            //cmd2.Parameters.Add("@id", SqlDbType.Int).Value = lista_precios.ID;

                            cmd2.ExecuteNonQuery();

                            CajaDialogo.Information("DATOS ACTUALIZADOS");
                            this.DialogResult = DialogResult.OK;
                            cnx.Close();
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void buildMonthListh()
        {

            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("Mes", typeof(string));

            string[] meses = new string[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            DataRow _row = dt.NewRow();

            for (int i = 0; i < meses.Length;i++)
            {

            _row = dt.NewRow();
            _row["id"] = i+1;
            _row["Mes"] = meses[i];
            dt.Rows.Add(_row);
            }

            //cbxMonth.Properties.DataSource = dt;

            //cbxMonth.Properties.DisplayMember = "Mes";
            //cbxMonth.Properties.ValueMember = "id";


        }

        private void GetIDTable()
        {
            try
            {
                if (tableID.ObtenerIDTable((int)TablesIDOptions.ListaPrecios,4))
                {
                    txtCodigo.Text = tableID.Codigo;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }
    }
}