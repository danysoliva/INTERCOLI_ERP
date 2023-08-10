using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERP_INTECOLI.Clases;
using ERP_INTECOLI.Administracion;
using System.Data.SqlClient;
using ERP_INTECOLI.Administracion.Estudiantes;
using DevExpress.XtraGrid.Views.Grid;

namespace ERP_INTECOLI.Administracion.Instructores
{
    public partial class frmAgregarInstructores : DevExpress.XtraEditors.XtraForm
    {
        public TipoTransaccion TipoEdicion;
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLoegueado;
        int id_instructor;
        public enum TipoTransaccion
        {
            Insert = 1,
            Update = 2
        }



        public frmAgregarInstructores(UserLogin pUserLogin, int pid_instructor, TipoTransaccion pTipoTrans)
        {
            InitializeComponent();
            UsuarioLoegueado = pUserLogin;
            id_instructor = pid_instructor;
            TipoEdicion = pTipoTrans;
            

            switch (TipoEdicion)
            {
                case TipoTransaccion.Insert:
                    cbkHabilitado.Checked = true;
                    dtIngreso.Value = dp.Now();
                    grdvTelefonos.OptionsMenu.EnableColumnMenu = false;
                    grdvTelefonos.Columns["editar"].Visible = false;
                    break;
                case TipoTransaccion.Update:
                    cargar_telefonos(pid_instructor);
                    Clases.Instructores inst = new Clases.Instructores();
                    inst.RecuperarRegistros(id_instructor);
                    txtCedula.Text = inst.Num_cedula;
                    txtNombres.Text = inst.Nombres;
                    txtApellidos.Text = inst.Apellidos;
                    cbxSexo.SelectedItem = inst.Sexo;
                    txtDireccion.Text = inst.Direccion;
                    dtIngreso.Value = inst.Fecha_ingreso;
                    cbkHabilitado.Checked = inst.Habilitado;

                    break;
                default:
                    break;
            }
        }

        private void cargar_telefonos(int pid_instructor)
        {
            try
            {
                string query = @"sp_instructores_get_telefonos";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_instructor", pid_instructor);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsInstructores1.detalle_telefonos.Clear();
                adat.Fill(dsInstructores1.detalle_telefonos);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdAgregarTelefono_Click(object sender, EventArgs e)
        {
            switch (TipoEdicion)
            {
                case TipoTransaccion.Insert:
                    frmAgregarTelefono frm = new frmAgregarTelefono(frmAgregarTelefono.TipoEdicion.Nuevo, id_instructor, 0, "", 0);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        DataRow dr = dsInstructores1.detalle_telefonos.NewRow();
                        dr[0] = 0;
                        dr[1] = frm.num_telefono;
                        dr[2] = frm.id_tipo_telefono;
                        dr[4] = frm.tipo_Telefono;
                        dr[6] = 0;
                        dsInstructores1.detalle_telefonos.Rows.Add(dr);
                        dsInstructores1.detalle_telefonos.AcceptChanges();

                    }

                    break;
                case TipoTransaccion.Update:
                    //Insercion 
                    frmAgregarTelefono frmx = new frmAgregarTelefono(frmAgregarTelefono.TipoEdicion.Nuevo,id_instructor,0,"",0);
                    if (frmx.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                            conn.Open();
                            SqlCommand cmd = new SqlCommand("[sp_instructor_insert_detalle_telefono]", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_instructor", id_instructor);
                            cmd.Parameters.AddWithValue("@telefono", frmx.num_telefono);
                            cmd.Parameters.AddWithValue("@tipo_telefono_id", frmx.id_tipo_telefono);
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        catch (Exception EX)
                        {
                            CajaDialogo.Error(EX.Message);
                        }
                    }
                    

                    cargar_telefonos(id_instructor);

                    break;
                default:
                    break;
            }
        }

        private void grDetalle_ClickCellButton(object sender, Infragistics.Win.UltraWinGrid.CellEventArgs e)
        {
            switch (e.Cell.Column.Key)
            {
                case "editar":
                    frmAgregarTelefono frm = new frmAgregarTelefono(frmAgregarTelefono.TipoEdicion.Editar, id_instructor, Convert.ToInt32(e.Cell.Row.Cells["id"].Value), e.Cell.Row.Cells["telefono"].Value.ToString(), Convert.ToInt32(e.Cell.Row.Cells["tipo_telefono_id"].Value));
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        //SQL Update
                    }
                    break;

                case "eliminar":

                    DialogResult r = CajaDialogo.Pregunta("Realmente quiere eliminar este Telefono?");
                    if (r == System.Windows.Forms.DialogResult.OK)
                        return;

                    switch (TipoEdicion)
                    {
                        case TipoTransaccion.Insert:

                            //Eliminar en Memoria

                            

                            break;
                        case TipoTransaccion.Update:
                            //Eliminar en SQL 

                            this.DialogResult = DialogResult.OK;
                            this.Close();


                            break;
                        default:
                            break;
                    }

                    break;
                default:
                    break;
            }

           
        }

       

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCedula.Text))
            {
                CajaDialogo.Error("El campo Cedula no debe quedar Vacio!");
                return;
            }

            if (string.IsNullOrEmpty(txtNombres.Text))
            {
                CajaDialogo.Error("El campo Nombre no debe quedar Vacio!");
                return;
            }

            if (string.IsNullOrEmpty(txtApellidos.Text))
            {
                CajaDialogo.Error("El campo Apellidos no debe quedar Vacio!");
                return;
            }

            if (string.IsNullOrEmpty(cbxSexo.SelectedItem.ToString()))
            {
                CajaDialogo.Error("El campo Sexo no debe quedar Vacio!");
                return;
            }


            switch (TipoEdicion)
            {
                case TipoTransaccion.Insert:
                    //
                    SqlTransaction transaction = null;

                    SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                    bool Guardar = false;

                    try
                    {
                        conn.Open();
                        transaction = conn.BeginTransaction("Transaction Order");

                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "[sp_instructores_insert_new]";
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@numero_cedula", txtCedula.Text);
                        cmd.Parameters.AddWithValue("@nombres", txtNombres.Text);
                        cmd.Parameters.AddWithValue("@apellidos",txtApellidos.Text);
                        cmd.Parameters.AddWithValue("@sexo",cbxSexo.SelectedItem);
                        cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                        cmd.Parameters.AddWithValue("@fecha_ingreso", dtIngreso.Value);
                        cmd.Parameters.AddWithValue("@id_usuario",UsuarioLoegueado.Id);

                        int id_header_instructor = Convert.ToInt32(cmd.ExecuteScalar());

                        foreach (dsInstructores.detalle_telefonosRow row in dsInstructores1.detalle_telefonos.Rows)
                        {
                            cmd.Parameters.Clear();
                            cmd.CommandText = "[sp_instructor_insert_detalle_telefono]";
                            cmd.Connection = conn;
                            cmd.Transaction = transaction;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_instructor", id_header_instructor);
                            cmd.Parameters.AddWithValue("@telefono", row.telefono);
                            cmd.Parameters.AddWithValue("@tipo_telefono_id", row.tipo_telefono_id);
                            cmd.ExecuteNonQuery();
                        }

                        

                        transaction.Commit();
                        Guardar = true;

                    }
                    catch (Exception ec)
                    {
                        transaction.Rollback();
                        CajaDialogo.Error(ec.Message);
                        Guardar = false;
                    }

                    if (Guardar)
                    {
                        CajaDialogo.Information("Transaccion Exitosa!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }

                    break;
                case TipoTransaccion.Update:
                    //
                   
                    try
                    {
                        SqlConnection conn2 = new SqlConnection(dp.ConnectionStringERP);
                        conn2.Open();
                        SqlCommand cmd = new SqlCommand("sp_instructores_update", conn2);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_instructor", id_instructor);
                        cmd.Parameters.AddWithValue("@numero_cedula",txtCedula.Text);
                        cmd.Parameters.AddWithValue("@nombres",txtNombres.Text);
                        cmd.Parameters.AddWithValue("@apellidos",txtApellidos.Text);
                        cmd.Parameters.AddWithValue("@sexo",cbxSexo.SelectedItem);
                        cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                        if (cbkHabilitado.Checked == true)
                            cmd.Parameters.AddWithValue("@habilitado", 1);
                        else
                            cmd.Parameters.AddWithValue("@habilitado", 0);
                        cmd.Parameters.AddWithValue("@fecha_ingreso",dtIngreso.Text);
                        cmd.Parameters.AddWithValue("@id_usuario", UsuarioLoegueado.Id);
                        cmd.ExecuteNonQuery();
                        conn2.Close();
                        Guardar = true;
                    }
                    catch (Exception EX)
                    {
                        CajaDialogo.Error(EX.Message);
                        Guardar = false;
                    }

                    if (Guardar)
                    {
                        CajaDialogo.Information("Transaccion Exitosa!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }

                    break;
                default:

                    CajaDialogo.Error("No se pudo Definir una Transaccion (Insert/Update)");
                    break;
            }

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            txtNombres.Text = "";
            txtCedula.Text = "";
            txtApellidos.Text = "";
            txtDireccion.Text = "";
        }

        private void reposEditarTelefono_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grdTelefonos.FocusedView;
            var row = (dsInstructores.detalle_telefonosRow)gridview.GetFocusedDataRow();

            frmAgregarTelefono frm = new frmAgregarTelefono(frmAgregarTelefono.TipoEdicion.Editar, id_instructor, row.id, row.telefono, row.tipo_telefono_id);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("[sp_instructor_update_detalle_telefono]", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_detalle_telefono", frm.id_detalle_telefono);
                    cmd.Parameters.AddWithValue("@id_instructor", id_instructor);
                    cmd.Parameters.AddWithValue("@id_tipo_telefono", frm.id_tipo_telefono);
                    cmd.Parameters.AddWithValue("@telefono", frm.num_telefono);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }

                cargar_telefonos(id_instructor);
            }
        }

        private void reposEliminar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grdTelefonos.FocusedView;
            var row = (dsInstructores.detalle_telefonosRow)gridview.GetFocusedDataRow();

            switch (TipoEdicion)
            {
                case TipoTransaccion.Insert:

                    //Eliminar en Memoria
                    try
                    {
                        grdvTelefonos.DeleteRow(grdvTelefonos.FocusedRowHandle);
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }

                    break;
                case TipoTransaccion.Update:
                    //Eliminar en SQL 

                    DialogResult r = CajaDialogo.Pregunta("Desea Elimianr este Registro?");
                    if (r != System.Windows.Forms.DialogResult.Yes)
                        return;

                    try
                    {
                        string query = @"[sp_instructor_delete_telefono]";
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_detalle", row.id);
                        cmd.Parameters.AddWithValue("@id_instructor", row.id_instructor);
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }

                    cargar_telefonos(id_instructor);

                    break;
                default:

                    CajaDialogo.Error("No se logro definir un proceso de Nuevo/Edicion \n Contactar a su Administrador");

                    break;
            }
        }
    }
}