
using ERP_INTECOLI.Clases;
using DevExpress.XtraEditors;
//using PRININ.Gestion_de_Usuarios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using ERP_INTECOLI.Usuarios;

namespace ERP_INTECOLI.Accesos.AccesosUsuarios
{
    public partial class AccesoUsuario : DevExpress.XtraEditors.XtraForm
    {
        #region Variables constantes Propiedades
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private XtraMessageBoxArgs args;

        //private const string connectionString = @"Server=DESKTOP-4Q0PPMK\SQLEXPRESS;Database=ACS;User Id=sa;Password=Sap5erver;";
        private const string query = @"SELECT [id_usuario]
		                                        ,concat(nombre, ' ' + apellidos )as [nombre]
		                                        ,alias
                                        FROM usuarios
                                        WHERE habilitado = 1
                                        Order by [nombre];";

        private const string query2 = @"Select T0.id_usuario, 
                                              T0.nombre, 
                                              T0.alias,
                                              T1.id [id_sistema], 
                                              T1.nombre [nombre_sistema],
                                              T1.Codigo,
                                              T3.id [id_nivel],
                                              T2.id[id_acceso],
                                              T2.nivel,
                                              isnull(T4.enable,0) [enable],
                                              isnull(T4.id,0) [id_conf]
                                                    from  [dbo].[usuarios] T0
                                                    cross join dbo.conf_sistemas_master_data T1
                                                    cross join dbo.conf_niveles_acceso T2
                                                    inner join dbo.conf_sistemas_niveles_acceso T3 
														on T3.id_nivel = T2.id and T3.id_sistema = T1.id
                                                    left join dbo.conf_usuarios_niveles_acceso T4 
														on T4.id_nivel = T3.id and T4.id_user = T0.id_usuario
                                                    Where T0.id_usuario = @id";

        //private const string query2 = @"Select T0.id_usuario, 
        //                                      T0.nombre, 
        //                                      T0.alias,
        //                                      T1.id [id_sistema], 
        //                                      T1.nombre [nombre_sistema],
        //                                      T1.Codigo,
        //                                      T3.id [id_nivel],
        //                                      T2.id[id_acceso],
        //                                      T2.nivel,
        //                                      isnull(T4.enable,0) [enable],
        //                                      isnull(T4.id,0) [id_conf]
        //                                            from usuarios T0
        //                                            cross join conf_sistemas_master_data T1
        //                                            cross join conf_niveles_acceso T2
        //                                            inner join conf_sistemas_niveles_acceso T3 
        //						on T3.id_nivel = T2.id and T3.id_sistema = T1.id
        //                                            left join conf_usuarios_niveles_acceso T4 
        //						on T4.id_nivel = T3.id and T4.id_user = T0.id_usuario
        //                                           Where T0.id_usuario = @id";





        private const string query3 = @"INSERT INTO conf_usuarios_niveles_acceso([id_user],[id_nivel],[enable],[date_start])
                                        VALUES(@id_user, @id_nivel, @enable, @date_start)";

        private const string query4 = @"DELETE FROM conf_usuarios_niveles_acceso
                                        WHERE id = @id";

        private List<UserData> UserDatas { get; set; }
        private List<FlatData> FlatDatas { get; set; }
        private List<Sistema> LocalSistemas { get; set; }
        private List<Acceso> LocalAccesos { get; set; }

        private bool Editado { get; set; }
        private bool CambioUserDataValido { get; set; }
        private UserData UserDataActual { get; set; }
        UserLogin UsuarioLogeado;
        DataOperations dp;
        #endregion
        public AccesoUsuario(UserLogin puser)
        {
            InitializeComponent();
            dp = new DataOperations();
            UsuarioLogeado = puser;
            sqlConnection = new SqlConnection(dp.ConnectionStringERP);
            LlenarDatos();
            CargarUsuariosEnCombo();
            LocalSistemas = new List<Sistema>();
            LocalAccesos = new List<Acceso>();
        }
        #region Metodos
        private void CargarUsuariosEnCombo()
        {
            this.comboUsuarios.Properties.DataSource = UserDatas;
        }
        private void LlenarDatos()
        {
            this.UserDatas = TraerdatosUserDataDB();

        }
        private List<UserData> TraerdatosUserDataDB()
        {
            var listaAcceosSistemas = new List<UserData>();
            sqlCommand = new SqlCommand(query, sqlConnection);
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
                var reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    listaAcceosSistemas.Add(new UserData
                    {

                        Id = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Usuario = reader.GetString(2)
                    });
                }
                sqlConnection.Close();
            }
            return listaAcceosSistemas;
        }


        private List<FlatData> TraerdatosFlatDataDB(int idUsuario)
        {
            var listaAcceosSistemas = new List<FlatData>();
            sqlCommand = new SqlCommand(query2, sqlConnection);
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@id", idUsuario);
                var reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    listaAcceosSistemas.Add(new FlatData
                    {

                        IdUsuario = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Usuario = reader.GetString(2),
                        Id_Sistema = reader.GetInt32(3),
                        CodigoSistema = reader.GetString(5),
                        NombreSistema = reader.GetString(4),
                        IdNivel = reader.GetInt32(6),
                        Id_Acceso = reader.GetInt32(7),
                        Nivel = reader.GetString(8),
                        Enable = reader.GetBoolean(9),
                        IdConf = reader.GetInt32(10)

                    });
                }
                sqlConnection.Close();
            }
            return listaAcceosSistemas;

        }
        private void CargarGridSistemas(int idUsuario)
        {


            LocalSistemas.Clear();
            foreach (var item in FlatDatas.Select(l => new { Id = l.Id_Sistema, Nombre = l.NombreSistema, l.CodigoSistema }).Distinct())
            {
                LocalSistemas.Add(new Sistema
                {
                    Id = item.Id,
                    Nombre = item.Nombre,
                    Codigo =  item.CodigoSistema
                });
            }
            this.gridControlDetalleSistemas.DataSource = LocalSistemas;
            this.gridControlDetalleSistemas.RefreshDataSource();
        }

        private void CargarGridAccesos(int idSistema)
        {
            LocalAccesos.Clear();


            foreach (var item in FlatDatas.Where(l => l.Id_Sistema == idSistema).Select(l => new { Id = l.Id_Acceso, Nombre = l.Nivel, Enable = l.Enable }).Distinct())
            {
                LocalAccesos.Add(new Acceso
                {
                    Id = item.Id,
                    Nombre = item.Nombre,
                    Enable = item.Enable
                });
            }
            this.gridControlAccesos.DataSource = LocalAccesos;
            this.gridControlAccesos.RefreshDataSource();
        }
        private bool Guardar()
        {
            var idUsuario = ((UserData)this.comboUsuarios.EditValue).Id;
            var datosFlatDB = this.TraerdatosFlatDataDB(idUsuario).Where(l => l.Enable);

            var datosFlatACrear = FlatDatas.Where(l => l.Enable && !datosFlatDB.Any(x=> x.IdConf == l.IdConf)).ToList();

            foreach (var item in datosFlatACrear)
            {
                var result = CrearOEditar(query3, new List<SqlParameter> {
                    new SqlParameter("@id_user",idUsuario),
                    new SqlParameter("@id_nivel",item.IdNivel),
                    new SqlParameter("@enable",item.Enable),
                    new SqlParameter("@date_start",DateTime.Now),
                  
                });
                if (!result)
                    return result;
            }
            var datosFlatAEliminar = FlatDatas.Where(l => !l.Enable && datosFlatDB.Any(x => x.Enable && x.IdConf == l.IdConf)).ToList();

            foreach (var item in datosFlatAEliminar)
            {
              var result =  CrearOEditar(query4, new List<SqlParameter>
                {
                    new SqlParameter("@id", item.IdConf)
                });
                if (!result)
                    return result;
            }

            FlatDatas = TraerdatosFlatDataDB(idUsuario);
            return true;

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
        internal class UserData
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Usuario { get; set; }

            public string FullName { get { return $"{Id}-{Nombre}"; } }
        }
        internal class FlatData
        {
            public int IdUsuario { get; set; }
            public string Nombre { get; set; }
            public string Usuario { get; set; }
            public int Id_Sistema { get; set; }

            public string NombreSistema { get; set; }
            public string CodigoSistema { get; set; }
            public int IdNivel { get; set; }
            public int Id_Acceso { get; set; }
            public string Nivel { get; set; }
            public bool Enable { get; set; }
            public int IdConf { get; set; }
        }
        internal class Sistema
        {
            public int Id { get; set; }
            public string Nombre { get; set; }

            public string Codigo { get; set; }
        }
        internal class Acceso
        {
            public int IdNivel { get; set; }
            public int Id { get; set; }
            public string Nombre { get; set; }
            public bool Enable { get; set; }
        }
        #endregion Clases
        #region Eventos
        private void comboSistemas_EditValueChanged(object sender, EventArgs e)
        {
            if (Editado && !CambioUserDataValido)
            {
                if (XtraMessageBox.Show("Si cambia de usuario se perderan los cambios aun no guardados! \n Desea proceder?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    CambioUserDataValido = true;
                    this.comboUsuarios.EditValue = UserDataActual;
                    return;
                }
            }
            var idUsuario = ((UserData)this.comboUsuarios.EditValue).Id;
            this.UserDataActual = (UserData)this.comboUsuarios.EditValue;
            CambioUserDataValido = false;
            this.FlatDatas = TraerdatosFlatDataDB(idUsuario);
            this.CargarGridSistemas(idUsuario);
            if (gridViewDetalleSistemas.DataRowCount > 0)
            {
                var idSistema = this.LocalSistemas[this.gridViewDetalleSistemas.GetDataSourceRowIndex(this.gridViewDetalleSistemas.GetSelectedRows().First())].Id;
                this.CargarGridAccesos(idSistema);
            }
        }

        private void gridViewDetalleSistemas_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var idSistema = this.LocalSistemas[this.gridViewDetalleSistemas.GetDataSourceRowIndex(e.FocusedRowHandle)].Id;
            this.CargarGridAccesos(idSistema);
        }

        private void gridViewAccesos_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column.FieldName == "Enable")
            {
                var idSistema = this.LocalSistemas[this.gridViewDetalleSistemas.GetDataSourceRowIndex(this.gridViewDetalleSistemas.GetSelectedRows().First())].Id; 
                var value = (bool)e.CellValue;
                var idAcceso = LocalAccesos[gridViewAccesos.GetDataSourceRowIndex(gridViewAccesos.GetSelectedRows().First())].Id;
                var indexAEditar = this.FlatDatas.FindIndex(l => l.Id_Acceso == idAcceso && l.Id_Sistema == idSistema);
                FlatDatas[indexAEditar].Enable = !value;
                this.Editado = true;
                CargarGridAccesos(idSistema);
              
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Esta seguro que desea guardar los niveles de acceso asignados?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               if(!Guardar())
                {
                    XtraMessageBox.Show("No se pudieron guardar todos los niveles de acceso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Editado = false;
                XtraMessageBox.Show("Se guardo correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void cmdNuevoUser_Click(object sender, EventArgs e)
        {
            frmUser frm = new frmUser(frmUser.TipoEdicion.Nuevo, UsuarioLogeado, "");
            if(frm.ShowDialog() == DialogResult.OK)
            {
                sqlConnection = new SqlConnection(dp.ConnectionStringERP);
                LlenarDatos();
                CargarUsuariosEnCombo();
                LocalSistemas = new List<Sistema>();
                LocalAccesos = new List<Acceso>();
            }
        }

        private void cmdEditarUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboUsuarios.Text))
            {
                CajaDialogo.Error("DEBE SELECCIONAR UN USUARIO PARA EDITAR");
                return;
            }

            frmUser frm = new frmUser(frmUser.TipoEdicion.Editar, UsuarioLogeado, ((UserData)this.comboUsuarios.EditValue).Usuario);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                sqlConnection = new SqlConnection(dp.ConnectionStringERP);
                LlenarDatos();
                CargarUsuariosEnCombo();
                LocalSistemas = new List<Sistema>();
                LocalAccesos = new List<Acceso>();
            }
        }
    }
}