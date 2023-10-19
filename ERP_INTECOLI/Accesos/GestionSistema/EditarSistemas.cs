using ACS.Classes;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace JAGUAR_APP.Accesos.GestionSistemas
{
    public partial class EditarSistemas : DevExpress.XtraEditors.XtraForm
    {
        #region Variables Constantes Propiedades
        private XtraMessageBoxArgs args;
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private const string query = "UPDATE conf_sistemas_master_data SET nombre=@nombre, codigo =@codigo, nombre_corto =@nombre_corto, enable=@habilitado WHERE ID =@id;";
        private const string query2 = "SELECT * FROM conf_sistemas_master_data WHERE id = @id;";
        //private const string connectionString = @"Server=DESKTOP-4Q0PPMK\SQLEXPRESS;Database=ACS;User Id=sa;Password=Sap5erver;";
        DataOperations dp = new DataOperations();
        private int id;
        #endregion
        public EditarSistemas(int id)
        {
            InitializeComponent();
            this.id = id;
            sqlConnection = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            loadData();
        }
        #region Metodos
        private void loadData()
        {
            sqlCommand = new SqlCommand(query2, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@id", id);
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
                var reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    this.txtNombreSistema.EditValue = Convert.ToString(reader.GetValue(1));
                    this.textEdit2.EditValue = Convert.ToString(reader.GetValue(2));
                    this.textEdit3.EditValue = Convert.ToString(reader.GetValue(3));
                    this.checkEditHabilitado.Checked = Convert.ToBoolean(reader.GetValue(4));

                    reader.NextResult();
                }
                sqlConnection.Close();
            }

        }
        #endregion

        #region Eventos
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            args = new XtraMessageBoxArgs();
            args.Caption = "Advertencia";
            args.Buttons = new DialogResult[] {
            DialogResult.OK, DialogResult.Cancel
            };

            args.Text = "Esta seguro que desea salir? \n Los cambios se perderan.";
            if (XtraMessageBox.Show(args) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreSistema.Text))
            {
                CajaDialogo.Error("No se permite guardar un Sistema en Blanco!");
                return;
            }

            if (XtraMessageBox.Show("Esta seguro que desea editar este sistema?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@nombre", txtNombreSistema.Text);
                sqlCommand.Parameters.AddWithValue("@codigo", textEdit2.Text);
                sqlCommand.Parameters.AddWithValue("@nombre_corto", textEdit3.Text);
                sqlCommand.Parameters.AddWithValue("@habilitado", checkEditHabilitado.Checked);
                sqlCommand.Parameters.AddWithValue("@id", id);
                if (sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                    if (sqlCommand.ExecuteNonQuery() < 1)
                    {
                        XtraMessageBox.Show("Error", "No se pudo editar el sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    sqlConnection.Close();
                }
                this.Close();
            }
        }
        #endregion
    }
}