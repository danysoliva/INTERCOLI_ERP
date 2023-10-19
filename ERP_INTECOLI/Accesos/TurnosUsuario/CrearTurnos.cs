using ACS.Classes;
using DevExpress.XtraEditors;
using JAGUAR_APP.Clases;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace JAGUAR_APP.Accesos.TurnosUsuario
{
    public partial class CrearTurnos : DevExpress.XtraEditors.XtraForm
    {
        #region Variables Constantes Propiedades
        private UserLogin userLogged = new UserLogin();
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private XtraMessageBoxArgs args;
        private const string query = "dbo.usp_insert_turno_usuario";
        DataOperations dp = new DataOperations();
        //private const string connectionString = @"Server=DESKTOP-4Q0PPMK\SQLEXPRESS;Database=ACS;User Id=sa;Password=Sap5erver;";
        #endregion
        public CrearTurnos(Clases.UserLogin usuarioLogueadP)
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            userLogged = usuarioLogueadP;
        }
        #region Eventos
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTurno.Text))
            {
                CajaDialogo.Error("No se permite guardar un Sistema en Blanco!");
                return;
            }

            if (XtraMessageBox.Show("Esta seguro que desea guardar este sistema?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@turno", txtTurno.Text);
                sqlCommand.Parameters.AddWithValue("@usuario_id", userLogged.UserId);
                //sqlCommand.Parameters.AddWithValue("@nombre_corto", textEdit3.Text);
                sqlCommand.Parameters.AddWithValue("@habilitado", checkEditHabilitado.Checked);

                if (sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                    if (sqlCommand.ExecuteNonQuery() < 1)
                    {
                        XtraMessageBox.Show("Error", "No se pudo crear el nuevo turno.", MessageBoxButtons.OK, MessageBoxIcon.Error);
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