using ERP_INTECOLI.Clases;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ERP_INTECOLI.Accesos.GrupoLosa
{

    public partial class CrearGrupoLosa : DevExpress.XtraEditors.XtraForm
    {
        #region Variables Constantes Propiedades
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private XtraMessageBoxArgs args;
        private const string query = @"INSERT INTO conf_grupos(grupo,enable) VALUES(@grupo,@habilitado);";
        //private const string connectionString = @"Server=DESKTOP-4Q0PPMK\SQLEXPRESS;Database=ACS;User Id=sa;Password=Sap5erver;";
        DataOperations dp = new DataOperations();
        #endregion
        public CrearGrupoLosa()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(dp.ConnectionStringERP);
        }
        #region Eventos
        private void botonCancelar_Click(object sender, EventArgs e)
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

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textEditGrupo.Text))
            {
                CajaDialogo.Error("No se permite guardar un Grupo en Blanco!");
                return;
            }

            if (XtraMessageBox.Show("Esta seguro que desea guarda este grupo?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@grupo", textEditGrupo.EditValue);
                sqlCommand.Parameters.AddWithValue("@habilitado", checkEditHabilitado.Checked);
                if (sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                    if (sqlCommand.ExecuteNonQuery() < 1)
                    {
                        XtraMessageBox.Show("Error", "No se pudo crear el grupo.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    sqlConnection.Close();
                }
                this.Close();
            }
        }
        #endregion


    }
}