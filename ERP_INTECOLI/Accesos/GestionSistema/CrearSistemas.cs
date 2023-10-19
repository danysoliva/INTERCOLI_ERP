using ACS.Classes;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace JAGUAR_APP.Accesos.GestionSistemas
{
    public partial class CrearSistemas : DevExpress.XtraEditors.XtraForm
    {
        #region Variables Constantes Propiedades
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private XtraMessageBoxArgs args;
        private const string query = "declare @id integer = (select max(id)+1 from [conf_sistemas_master_data]);" +
            "INSERT INTO [conf_sistemas_master_data](id,nombre,codigo,nombre_corto,enable) VALUES(@id,@nombre,@codigo,@nombre_corto,@habilitado);";
        DataOperations dp = new DataOperations();
        //private const string connectionString = @"Server=DESKTOP-4Q0PPMK\SQLEXPRESS;Database=ACS;User Id=sa;Password=Sap5erver;";
        #endregion
        public CrearSistemas()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
        }
        #region Eventos
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreSistema.Text))
            {
                CajaDialogo.Error("No se permite guardar un Sistema en Blanco!");
                return;
            }

            if (XtraMessageBox.Show("Esta seguro que desea guardar este sistema?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@nombre", txtNombreSistema.Text);
                sqlCommand.Parameters.AddWithValue("@codigo", textEdit2.Text);
                sqlCommand.Parameters.AddWithValue("@nombre_corto", textEdit3.Text);
                sqlCommand.Parameters.AddWithValue("@habilitado", checkEditHabilitado.Checked);
                if (sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                    if (sqlCommand.ExecuteNonQuery() < 1)
                    {
                        XtraMessageBox.Show("Error", "No se pudo crear el nuevo sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    sqlConnection.Close();
                }
                this.Close();
            }
        }

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
        #endregion
    }
}