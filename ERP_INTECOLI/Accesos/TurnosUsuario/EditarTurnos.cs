using ACS.Classes;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace JAGUAR_APP.Accesos.TurnosUsuario
{
    public partial class EditarTurnos : DevExpress.XtraEditors.XtraForm
    {
        #region Variables Constantes Propiedades
        private XtraMessageBoxArgs args;
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private const string query = "dbo.usp_Update_Turno_Usuario";
        //string turno;
        //bool habilitado;
        //private const string query2 = "SELECT * FROM conf_sistemas_master_data WHERE id = @id;";
        //private const string connectionString = @"Server=DESKTOP-4Q0PPMK\SQLEXPRESS;Database=ACS;User Id=sa;Password=Sap5erver;";
        DataOperations dp = new DataOperations();
        private int id;
        #endregion

        public EditarTurnos(int id,string turno_P,bool habilitado_P )
        {
            InitializeComponent();
            this.id = id;

            sqlConnection = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            txtTurno.Text = turno_P;
            checkEditHabilitado.EditValue = habilitado_P;
            //loadData();
        }
        #region Metodos
        //private void loadData()
        //{
        //    sqlCommand = new SqlCommand(query2, sqlConnection);
        //    sqlCommand.Parameters.AddWithValue("@id", id);
        //    if (sqlConnection.State != ConnectionState.Open)
        //    {
        //        sqlConnection.Open();
        //        var reader = sqlCommand.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            this.txtTurno.EditValue = Convert.ToString(reader.GetValue(1));
        //            this.textEdit2.EditValue = Convert.ToString(reader.GetValue(2));
        //            this.textEdit3.EditValue = Convert.ToString(reader.GetValue(3));
        //            this.checkEditHabilitado.Checked = Convert.ToBoolean(reader.GetValue(4));

        //            reader.NextResult();
        //        }
        //        sqlConnection.Close();
        //    }

        //}
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
            if (string.IsNullOrEmpty(txtTurno.Text))
            {
                CajaDialogo.Error("No se permite guardar un Sistema en Blanco!");
                return;
            }

            if (XtraMessageBox.Show("Esta seguro que desea editar este sistema?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@turno", txtTurno.Text);
                //sqlCommand.Parameters.AddWithValue("@id", textEdit2.Text);
                //sqlCommand.Parameters.AddWithValue("@nombre_corto", textEdit3.Text);
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

        private void EditarTurnos_Load(object sender, EventArgs e)
        {

        }
    }
}