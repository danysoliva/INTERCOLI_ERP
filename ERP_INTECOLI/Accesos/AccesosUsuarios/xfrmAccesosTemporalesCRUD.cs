using ERP_INTECOLI.Clases;
using DevExpress.XtraEditors;

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

namespace ERP_INTECOLI.Accesos.AccesosUsuarios
{
    public partial class xfrmAccesosTemporalesCRUD : DevExpress.XtraEditors.XtraForm
    {
        UserLogin usuarioLogin;
        //AccesoTemporal acceso = new AccesoTemporal();
        int form_CRUD;

      public  enum formCRUD
        {
            Nuevo=1,
            Editar=2
        }

        public xfrmAccesosTemporalesCRUD(UserLogin pUser,int formCRUD)
        {
            //usuarioLogin = pUser;
            form_CRUD = formCRUD;
            InitializeComponent();
            LoadUsers();
            LoadVentanas();
        }

        //public xfrmAccesosTemporalesCRUD(int  formCRUD,AccesoTemporal pAcceso, UserLogin pUser)
        //{
        //    usuarioLogin = pUser;
        //    InitializeComponent();
        //    LoadUsers();
        //    LoadVentanas();
        //    form_CRUD = formCRUD;
        //    acceso = pAcceso;
        //}

        void LoadVentanas()
        {
            try
            {
                //DataOperations dp = new DataOperations();

                //using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                //{
                //    cnx.Open();

                //    SqlDataAdapter da = new SqlDataAdapter("ACS.sp_get_Ventanas",cnx);
                //    dsAccesos.Ventana.Clear();

                //    da.Fill(dsAccesos.Ventana);
                //    cnx.Close();
                //}
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
               
            }
        }

       private void LoadVentanasByUser()
        {
            try
            {
                //DataOperations dp = new DataOperations();

                //using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
                //{
                //    cnx.Open();

                //    SqlDataAdapter da = new SqlDataAdapter("ACS.sp_get_ventanas_by_user", cnx);
                //    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                //    da.SelectCommand.Parameters.Add("@id_user",SqlDbType.Int).Value=acceso.UserID;

                //    dsAccesos.Window.Clear();

                //    da.Fill(dsAccesos.Window);
                //    cnx.Close();
                //}
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);

            }
        }

        int countError = 0;
        private void lueVentana_EditValueChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    //lueVentana
            //    SearchLookUpEdit editor = (SearchLookUpEdit)sender;
            //    var id_ventana_old = editor.OldEditValue;
            //    DataRowView dvRow = editor.GetSelectedDataRow() as DataRowView;
            //    //countError = 0;

            //    if (dvRow == null)
            //    {
            //        return;
            //    }
            //    var row =  dvRow.Row;

            //    var rowGrid = (dsAccesos.WindowRow)gvVentana.GetFocusedDataRow();


            //    switch (form_CRUD)
            //    {
            //        case (int)formCRUD.Nuevo:
            //            rowGrid.fecha_vinculo = DateTime.Now;
            //            rowGrid.fecha_inicio = DateTime.Now;
            //            rowGrid.fecha_fin = DateTime.Now.AddDays(1);

            //            foreach (var item in dsAccesos.Window)
            //            {
            //                if (item.id_ventana == Convert.ToInt32(row.ItemArray[0].ToString()))
            //                {
            //                    CajaDialogo.Error("Ya se ha seleccionado esta ventana");
            //                    gvVentana.DeleteRow(gvVentana.FocusedRowHandle);
            //                    return;
            //                }

            //            }

            //            rowGrid.id_ventana = Convert.ToInt32(row.ItemArray[0].ToString());
            //            //rowGrid.fecha_vinculo = DBNull.Value;
            //            break;

            //        case (int)formCRUD.Editar:
            //            DataOperations dp = new DataOperations();
            //            int lastId = 0;

            //            foreach (var item in dsAccesos.Window)
            //            {
            //                if (countError>0)
            //                {
            //                    countError = 0;
            //                    return;
            //                }

            //                if (item.id_ventana == Convert.ToInt32(row.ItemArray[0].ToString()))
            //                {
    
            //                    countError ++;
            //                    CajaDialogo.Error("Ya se ha seleccionado esta ventana");
            //                    editor.EditValue = id_ventana_old;
            //                    return;
            //                    //rowGrid.id_ventana = (int)id_ventana_old;
            //                }

            //            }

            //            if (rowGrid.id==0)
            //            {
            //                rowGrid.fecha_vinculo = DateTime.Now;
            //                rowGrid.fecha_inicio = DateTime.Now;
            //                rowGrid.fecha_fin =  DateTime.Now.AddDays(1);
            //                id_ventana_old = editor.EditValue;
            //            }

            //            using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
            //            {
            //                cnx.Open();
                            
            //                SqlCommand cmd = new SqlCommand("ACS.sp_update_ventana_by_user",cnx);
            //                cmd.CommandType = CommandType.StoredProcedure;

            //                cmd.Parameters.Add("@id_user", SqlDbType.Int).Value = acceso.UserID;
            //                cmd.Parameters.Add("@id_userCreated", SqlDbType.Int).Value = usuarioLogin.Id;
            //                cmd.Parameters.Add("@id_ventana_old", SqlDbType.Int).Value = id_ventana_old;
            //                cmd.Parameters.Add("@id_ventana_new", SqlDbType.Int).Value = Convert.ToInt32(row.ItemArray[0].ToString());
            //                cmd.Parameters.Add("@fecha_inicio", SqlDbType.DateTime).Value = rowGrid.fecha_inicio;
            //                cmd.Parameters.Add("@fecha_fin", SqlDbType.DateTime).Value = rowGrid.fecha_fin;
            //                cmd.Parameters.Add("@fecha_vinculo", SqlDbType.DateTime).Value = rowGrid.fecha_vinculo;
            //                cmd.Parameters.Add("@id", SqlDbType.Int).Value = rowGrid.id;

            //               lastId= (int)cmd.ExecuteScalar();

            //                if (lastId!=0)
            //                {
            //                    rowGrid.id = lastId;
            //                    rowGrid.id_ventana = Convert.ToInt32(row.ItemArray[0].ToString());
            //                }
            //                cnx.Close();
            //            }
            //            break;
            //    }



            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
        }

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //var row = (dsAccesos.WindowRow)gvVentana.GetFocusedDataRow();
            //int id_row = row.id;
            //gvVentana.DeleteRow(gvVentana.FocusedRowHandle);

            //if (form_CRUD == (int)formCRUD.Editar)
            //{
            //    if (XtraMessageBox.Show("DESEA ELIMINAR ESTE REGISTRO?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.No)
            //    {
            //        try
            //        {


            //            DataOperations dp = new DataOperations();

            //            using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
            //            {
            //                cnx.Open();

            //                SqlCommand cmd = new SqlCommand("ACS.sp_delete_acceso_temporal_ventana", cnx);
            //                cmd.CommandType = CommandType.StoredProcedure;
            //                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id_row;

            //                cmd.ExecuteNonQuery();

            //                cnx.Close();
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            CajaDialogo.Error(ex.Message);
            //        }
            //    }
            //}
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       private void LoadUsers()
        {
            //try
            //{
            //    DataOperations dp = new DataOperations();

            //    using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB))
            //    {
            //        cnx.Open();

            //        SqlDataAdapter da = new SqlDataAdapter("ACS.sp_get_usuarios_acceso_temporal", cnx);
            //        dsAccesos.Usuarios.Clear();

            //        da.Fill(dsAccesos.Usuarios);
            //        cnx.Close();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);

            //}
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    DataOperations dp = new DataOperations();
            //    SqlConnection cnx = new SqlConnection(dp.ConnectionStringJAGUAR_DB);


            //    switch (form_CRUD)
            //    {
            //        case (int)formCRUD.Nuevo:
            //            if (dsAccesos.Window.Rows.Count > 0)
            //            {
            //                foreach (var item in dsAccesos.Window)
            //                {
            //                    cnx.Open();
            //                    SqlCommand cmd = new SqlCommand("dbo.sp_insert_acceso_temporal", cnx);
            //                    cmd.CommandType = CommandType.StoredProcedure;

            //                    cmd.Parameters.Add("@id_usuario", SqlDbType.Int).Value = lueUsuario.EditValue;
            //                    cmd.Parameters.Add("@id_ventana", SqlDbType.Int).Value = item.id_ventana;
            //                    cmd.Parameters.Add("@fecha_vinculo", SqlDbType.DateTime).Value = item.fecha_vinculo;
            //                    cmd.Parameters.Add("@fecha_inicio", SqlDbType.DateTime).Value = item.fecha_inicio;
            //                    cmd.Parameters.Add("@fecha_Fin", SqlDbType.DateTime).Value = item.fecha_fin;
            //                    cmd.Parameters.Add("@id_usuario_created", SqlDbType.Int).Value = usuarioLogin.Id;

            //                    cmd.ExecuteNonQuery();
            //                    cnx.Close();
            //                }

            //                CajaDialogo.Information("DATOS GUARDADOS");
            //                this.DialogResult = DialogResult.OK;
            //            }
            //            else
            //            {

            //                CajaDialogo.Error("DEBE DE SELECCIONAR POR LO MENOS UNA VENTANA A BRINDAR ACCESO");
            //                return;
            //            }
            //            break;

            //        case (int)formCRUD.Editar:
            //            break;
            //    }



            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
        }

        private void xfrmAccesosTemporalesCRUD_Load(object sender, EventArgs e)
        {
           
            //if (form_CRUD == (int)formCRUD.Editar)
            //{
            //    LoadVentanasByUser();
            //    lueUsuario.EditValue = acceso.UserID;

            //    lueUsuario.Enabled = false;
            //    cmdNew.Enabled = false;
            //}
        }


        private void gvVentana_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            ////try
            //{
            //    var row = (dsAccesos.WindowRow)gvVentana.GetFocusedDataRow();

            //    //if (row.fecha_inicio== null)
            //    //{
            //    //    return;
            //    //}

            //    if (e.Column.FieldName != "nombre")
            //    {

            //        switch (form_CRUD)
            //        {

            //            case (int)formCRUD.Editar:
            //                DataOperations dp = new DataOperations();

            //                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringERP))
            //                {
            //                    cnx.Open();

            //                    SqlCommand cmd = new SqlCommand("dbo.sp_update_ventana_by_user", cnx);
            //                    cmd.CommandType = CommandType.StoredProcedure;

            //                    cmd.Parameters.Add("@id_user", SqlDbType.Int).Value = acceso.UserID;
            //                    cmd.Parameters.Add("@id_userCreated", SqlDbType.Int).Value = usuarioLogin.Id;
            //                    cmd.Parameters.Add("@id_ventana_old", SqlDbType.Int).Value = row.id_ventana;
            //                    cmd.Parameters.Add("@id_ventana_new", SqlDbType.Int).Value = row.id_ventana;
            //                    cmd.Parameters.Add("@fecha_inicio", SqlDbType.DateTime).Value = row.fecha_inicio;
            //                    cmd.Parameters.Add("@fecha_fin", SqlDbType.DateTime).Value = row.fecha_fin;
            //                    cmd.Parameters.Add("@fecha_vinculo", SqlDbType.DateTime).Value = row.fecha_vinculo;
            //                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = row.id;

            //                    cmd.ExecuteNonQuery();
            //                    cnx.Close();
            //                }
            //                break;
            //        }
            //    }
            //    }
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
        }
    }
}