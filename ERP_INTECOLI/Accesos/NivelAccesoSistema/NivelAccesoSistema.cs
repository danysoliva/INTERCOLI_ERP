using ERP_INTECOLI.Clases;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace ERP_INTECOLI.Accesos.NivelAccesoSistema
{
    public partial class NivelAccesoSistema : DevExpress.XtraEditors.XtraForm
    {
        #region Variables Constantes Propiedades
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private XtraMessageBoxArgs args;

        private const string query = "SELECT * FROM ACS.[conf_sistemas_master_data] where enable = 1;";

        private const string query2 = @"SELECT Distinct
                                                TT.id,
                                                TT.nombre,
                                                TT.[IdNivel],
                                                TT.nivel,
                                                isnull(T3.enable,0) [enable],
                                                isnull(T3.id,0) [id]
                                        FROM(select Distinct  T0.id,
		                                        T0.nombre,
		                                        T1.id as [IdNivel],
		                                        T1.nivel,
		                                        T1.enable
                                        from ACS.[conf_sistemas_master_data] T0 inner join 
		                                        ACS.conf_niveles_acceso T1 on 1 = 1) TT left join 
		                                        ACS.conf_sistemas_niveles_acceso T3 
		                                        on T3.id_nivel = TT.IdNivel 
		                                        and TT.id = T3.id_sistema
		                                        and T3.enable = 1
                                        where TT.enable = 1";

        private const string query3 = "INSERT INTO ACS.[conf_sistemas_niveles_acceso]([id_sistema],[id_nivel],[enable]) VALUES(@id_sistema,@id_nivel,@enable);";

        private const string query4 = "Update ACS.[conf_sistemas_niveles_acceso] SET [enable]=@enable  WHERE id = @id;";
        //private const string connectionString = @"Server=DESKTOP-4Q0PPMK\SQLEXPRESS;Database=ACS;User Id=sa;Password=Sap5erver;";
        DataOperations dp = new DataOperations();
        private List<DatosAccesosSistema> ListaDatosAccesosSistemas { get; set; }
        #endregion
        public NivelAccesoSistema()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(dp.ConnectionStringERP);
            ListaDatosAccesosSistemas = new List<DatosAccesosSistema>();
            LlenarComboEdit();
            CargarInformacionAccesosSistema();

        }
        #region Metodos
        private void LlenarComboEdit()
        {
            sqlCommand = new SqlCommand(query, sqlConnection);
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
                var reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    this.comboBoxEditSistemas.Properties.Items.Add(new KeyValuePair<int, string>(Convert.ToInt32(reader.GetValue(0)), Convert.ToString(reader.GetValue(2))));
                }
                sqlConnection.Close();
            }
        }
        private List<DatosAccesosSistema> TraerdatosAccesosSistemasDB()
        {
            var listaAcceosSistemas = new List<DatosAccesosSistema>();
            sqlCommand = new SqlCommand(query2, sqlConnection);
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
                var reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    listaAcceosSistemas.Add(new DatosAccesosSistema
                    {

                        IdSistema = Convert.ToInt32(reader.GetValue(0)),
                        IdAcceso = Convert.ToInt32(reader.GetValue(2)),
                        NombreAcceso = Convert.ToString(reader.GetValue(3)),
                        Enable = Convert.ToBoolean(reader.GetValue(4)),
                        Id = Convert.ToInt32(reader.GetValue(5))
                    });
                }
                sqlConnection.Close();
            }
            return listaAcceosSistemas;
        }
        private void CargarInformacionAccesosSistema()
        {
            ListaDatosAccesosSistemas = TraerdatosAccesosSistemasDB();
        }
        private bool GuardarAccesosSistemas()
        {
            var accesosEnBD = this.TraerdatosAccesosSistemasDB().Where(l => l.Enable).ToList();

            //Accesos a crear
            var accesosACrear = ListaDatosAccesosSistemas
                .Where(l => l.Enable && !accesosEnBD.Any(x => x.IdSistema == l.IdSistema && x.IdAcceso == l.IdAcceso)).ToList();

            foreach (var item in accesosACrear)
            {
                var result = this.CrearOEditar(query3, new List<SqlParameter>
                {
                    new SqlParameter("@id_sistema", item.IdSistema),
                    new SqlParameter("@id_nivel",item.IdAcceso),
                    new SqlParameter("@enable",true)
                });
                if (!result)
                    return result;
            }

            //Accesos a Eliminar
            var accesosAActualizar = ListaDatosAccesosSistemas.Where(l => l.Id != 0 && !l.Enable && accesosEnBD.Any(x => x.IdSistema == l.IdSistema && x.IdAcceso == l.IdAcceso)).ToList();
            foreach (var item in accesosAActualizar)
            {
                var result = this.CrearOEditar(query4, new List<SqlParameter>
                {
                    new SqlParameter("@enable", item.Enable),
                    new SqlParameter("@id", item.Id)
                });
                if (!result)
                    return result;
            }
            return true;
        }
        private void CargarDatosAGrid()
        {
            var sistemaSeleccioando = ((KeyValuePair<int, string>)this.comboBoxEditSistemas.SelectedItem).Key;
            this.gridControlDetalleAccesos.DataSource = ListaDatosAccesosSistemas.Where(l => l.IdSistema == sistemaSeleccioando);
        }
        private bool CrearOEditar(string query, List<SqlParameter> sqlParameters)
        {
            sqlCommand = new SqlCommand(query, sqlConnection);
            foreach (var item in sqlParameters)
            {
                sqlCommand.Parameters.Add(item);
            }
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
                var result = sqlCommand.ExecuteNonQuery() != 0;

                sqlConnection.Close();
                return result;
            }
            return false;
        }
        #endregion
        #region Clases
        internal class DatosAccesosSistema
        {
            public int Id { get; set; }
            public int IdSistema { get; set; }
            public int IdAcceso { get; set; }
            public string NombreAcceso { get; set; }
            public bool Enable { get; set; }
        }
        #endregion
        #region Eventos
        private void comboBoxEditSistemas_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarInformacionAccesosSistema();
            CargarDatosAGrid();

        }

        private void gridControlDetalleAccesos_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void gridViewDetalleAccesos_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column.Name == "Asignado")
            {
                var selectedSistema = ((KeyValuePair<int, string>)this.comboBoxEditSistemas.SelectedItem).Key;
                var value = (bool)e.CellValue;
                var idAcceso = ((DatosAccesosSistema)gridViewDetalleAccesos.GetRow(e.RowHandle)).IdAcceso;

                var indexLista = ListaDatosAccesosSistemas.FindIndex(l => l.IdSistema == selectedSistema && l.IdAcceso == idAcceso);
                ListaDatosAccesosSistemas[indexLista].Enable = !value;
                CargarDatosAGrid();
            }
        }

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

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Esta seguro que desea guardar los accesos asignados?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!GuardarAccesosSistemas())
                {
                    XtraMessageBox.Show("No se pudieron guardar todos los accesos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                CargarInformacionAccesosSistema();
                CargarDatosAGrid();
                XtraMessageBox.Show("Se guardo correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }

}