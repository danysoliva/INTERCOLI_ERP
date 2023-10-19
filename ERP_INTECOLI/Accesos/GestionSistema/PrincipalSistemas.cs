using ACS.Classes;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace JAGUAR_APP.Accesos.GestionSistemas
{
    public partial class PrincipalSistemas : DevExpress.XtraEditors.XtraForm
    {
        #region Variables constantes Propiedades
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataReader sqlDataReader;
        private DataTable dataTable;
        //private const string connectionString = @"Server=DESKTOP-4Q0PPMK\SQLEXPRESS;Database=ACS;User Id=sa;Password=Sap5erver;";
        DataOperations dp = new DataOperations();
        #endregion
        public PrincipalSistemas()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            dataTable = new DataTable();
            this.RefrescarDatos();
        }
        #region Metodos
        private void RefrescarDatos()
        {
            var query = "Select * from ACS.conf_sistemas_master_data";
            sqlCommand = new SqlCommand(query, sqlConnection);
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
                sqlDataReader = sqlCommand.ExecuteReader();
                dataTable.Clear();
                dataTable.Load(sqlDataReader);

                this.gridControlSistemas.DataSource = dataTable;
                this.gridView1.OptionsSelection.EnableAppearanceFocusedRow = true;
                this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
                sqlConnection.Close();
            }


        }
        #endregion
        #region Eventos
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            CrearSistemas crearSistemas = new CrearSistemas();
            crearSistemas.StartPosition = FormStartPosition.CenterParent;
            crearSistemas.FormClosed += CrearGrupoLosa_FormClosed;
            crearSistemas.ShowDialog(this);
        }
        private void CrearGrupoLosa_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.RefrescarDatos();
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (this.gridView1.SelectedRowsCount > 0)
            {
                var selectedId = this.gridView1.GetDataRow(this.gridView1.GetSelectedRows().FirstOrDefault()).Field<int>("Id");
                EditarSistemas editarSistemas = new EditarSistemas(selectedId);
                editarSistemas.StartPosition = FormStartPosition.CenterParent;
                editarSistemas.FormClosed += CrearGrupoLosa_FormClosed;
                editarSistemas.ShowDialog(this);
            }
            else
            {
                XtraMessageBox.Show("Error", "Debe se seleccionar un grupo a editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}