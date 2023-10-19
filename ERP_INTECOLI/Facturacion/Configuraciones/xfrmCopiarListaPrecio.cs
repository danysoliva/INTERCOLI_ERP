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
    public partial class xfrmCopiarListaPrecio : DevExpress.XtraEditors.XtraForm
    {
        UserLogin usuarioLogueado;

        public delegate void get_MP_inserted(int Id_MP_inserted);
        public event get_MP_inserted EventoPasarId_MP_inserted;
        Conf_TablesID tableID = new Conf_TablesID();
        ListaPrecios lista_precios = new ListaPrecios();
        public enum TipoTransaccion
        {
            Nuevo = 1,
            Editar = 2,
            Copiar=3
        }

        TipoTransaccion transaccion = new TipoTransaccion();

        public xfrmCopiarListaPrecio(UserLogin userLog, int id_listaPrecio)
        {
            InitializeComponent();
            usuarioLogueado = userLog;
            buildMonthListh();

            lista_precios.RecuperaRegistro(id_listaPrecio);
 
        }

        private void xfrmMasterMP_CRUD_Load(object sender, EventArgs e)
        {
            //txtDescripcion.Text = lista_precios.Descripcion;
            //DateTime FechaDesde =
            //deFecha.EditValue = Convert.ToDateTime(lista_precios.Anio + "-01-01");
            //cbxMonth.EditValue = lista_precios.Mes;
            //deDesde.EditValue = lista_precios.Desde;
            //deHasta.EditValue = lista_precios.Hasta;

            GetIDTable();
            lblListaViejaName.Text = lista_precios.Descripcion;

            lblCopiando.Text = "Copiando desde: ";

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            DataOperations dp = new DataOperations();
            SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP);

            try
            {

                if (string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    CajaDialogo.Error("DEBE INGRESAR UNA DESCRIPCIÓN");
                    return;
                }

                if (string.IsNullOrEmpty(cbxMonth.Text))
                {
                    CajaDialogo.Error("DEBE SELECCIONAR UN MES");
                    return;
                }

                if (string.IsNullOrEmpty(deFecha.Text))
                {
                    CajaDialogo.Error("DEBE SELECCIONAR UN AÑO");
                    return;
                }

                if (string.IsNullOrEmpty(deDesde.Text))
                {
                    CajaDialogo.Error("DEBE SELECCIONAR UNA FECHA INICIAL");
                    return;
                }

                if (string.IsNullOrEmpty(deHasta.Text))
                {
                    CajaDialogo.Error("DEBE SELECCIONAR UNA FECHA FINAL");
                    return;
                }

                if (string.IsNullOrEmpty(txtCodigo.Text))
                {
                    CajaDialogo.Error("DEBE INGRESAR UN CODIGO");
                    return;
                }

                if (ValidarListaExistente(Convert.ToInt32(cbxMonth.EditValue), deFecha.DateTime.Year) == true)
                {
                    CajaDialogo.Error("Ya existe una lista de Precios para el mes de " + cbxMonth.Text + " del " + deFecha.DateTime.Year);
                    return;
                }

                SqlCommand cmd4 = new SqlCommand("dbo.uspCopiarListaPrecio_V2", cnx);

                cmd4.CommandType = CommandType.StoredProcedure;
                cnx.Open();

                cmd4.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = txtDescripcion.Text;
                cmd4.Parameters.Add("@anio", SqlDbType.Int).Value = deFecha.DateTime.Year;
                cmd4.Parameters.Add("@mes", SqlDbType.Int).Value = cbxMonth.EditValue;
                cmd4.Parameters.Add("@codigo", SqlDbType.VarChar).Value = txtCodigo.Text;
                cmd4.Parameters.Add("@usuario_id", SqlDbType.Int).Value = usuarioLogueado.Id;
                cmd4.Parameters.Add("@id_listaPrecio", SqlDbType.Int).Value = lista_precios.ID;
                cmd4.Parameters.Add("@fecha_creacion", SqlDbType.DateTime).Value = DateTime.Now;
                cmd4.Parameters.Add("@desde", SqlDbType.DateTime).Value = deDesde.EditValue;
                cmd4.Parameters.Add("@hasta", SqlDbType.DateTime).Value = deHasta.EditValue;

                cmd4.ExecuteNonQuery();

                CajaDialogo.Information("DATOS GUARDADOS");
                this.DialogResult = DialogResult.OK;
                cnx.Close();
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

            for (int i = 0; i < meses.Length; i++)
            {

                _row = dt.NewRow();
                _row["id"] = i + 1;
                _row["Mes"] = meses[i];
                dt.Rows.Add(_row);
            }

            cbxMonth.Properties.DataSource = dt;

            cbxMonth.Properties.DisplayMember = "Mes";
            cbxMonth.Properties.ValueMember = "id";


        }

        private void GetIDTable()
        {
            try
            {
                if (tableID.ObtenerIDTable((int)TablesIDOptions.ListaPrecios, 4))
                {
                    txtCodigo.Text = tableID.Codigo;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

     
        private bool ValidarListaExistente(int mes,int anio)
        {
            try
            {

            DataOperations dp = new DataOperations();
            SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP);

            bool existeLista;

            cnx.Open();
            SqlCommand cmd = new SqlCommand("dbo.uspValidateListaPrecioExistente",cnx);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@mes",SqlDbType.Int).Value=mes;
            cmd.Parameters.Add("@anio",SqlDbType.Int).Value=anio;
            cmd.Parameters.Add("@fechaInicio",SqlDbType.DateTime).Value=deDesde.EditValue;
            cmd.Parameters.Add("@fechaFin",SqlDbType.DateTime).Value=deHasta.EditValue;

            existeLista = (bool)cmd.ExecuteScalar();
            cnx.Close();

            return existeLista;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return false;
            }

        }

       
    }
}