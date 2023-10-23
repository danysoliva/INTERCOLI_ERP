using ERP_INTECOLI.Clases;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace ERP_INTECOLI.Accesos.GestionGrupos
{
    public partial class PrincipalGestionGrupos : DevExpress.XtraEditors.XtraForm
    {
        #region Variables Constantes Propiedades
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataReader sqlDataReader;
        private DataTable dataTable;
        DataOperations dp = new DataOperations();
        //private const string connectionString = @"Server=DESKTOP-4Q0PPMK\SQLEXPRESS;Database=ACS;User Id=sa;Password=Sap5erver;";
        #endregion
        public PrincipalGestionGrupos()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(dp.ConnectionStringERP);
            dataTable = new DataTable();
            this.RefrescarDatos();
        }
        #region Metodos
        private void RefrescarDatos()
        {
            var query = "Select * from conf_group";
            sqlCommand = new SqlCommand(query, sqlConnection);
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
                sqlDataReader = sqlCommand.ExecuteReader();
                dataTable.Clear();
                dataTable.Load(sqlDataReader);

                this.gridControlGrupos.DataSource = dataTable;
                this.gridView1.OptionsSelection.EnableAppearanceFocusedRow = true;
                this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
                sqlConnection.Close();
            }


        }
        #endregion
        #region Eventos
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            CrearGrupo crearGrupo = new CrearGrupo();
            crearGrupo.StartPosition = FormStartPosition.CenterParent;
            crearGrupo.FormClosed += CrearGrupo_FormClosed;
            crearGrupo.ShowDialog(this);
        }

        private void CrearGrupo_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.RefrescarDatos();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (this.gridView1.SelectedRowsCount > 0)
            {
                var selectedId = this.gridView1.GetDataRow(this.gridView1.GetSelectedRows().FirstOrDefault()).Field<int>("Id");
                EditarGrupo editarGrupo = new EditarGrupo(selectedId);
                editarGrupo.StartPosition = FormStartPosition.CenterParent;
                editarGrupo.FormClosed += CrearGrupo_FormClosed;
                editarGrupo.ShowDialog(this);
            }
            else
            {
                XtraMessageBox.Show("Error", "Debe se seleccionar un grupo a editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            CrearGrupo crearGrupo = new CrearGrupo();
            crearGrupo.StartPosition = FormStartPosition.CenterParent;
            crearGrupo.FormClosed += CrearGrupo_FormClosed;
            crearGrupo.ShowDialog(this);
        }
    }
}