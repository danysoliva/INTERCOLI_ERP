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

                    break;
                case TipoTransaccion.Update:
                    cargar_telefonos(pid_instructor);
                    //Instructores inst = new Instructores();
                    
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

                            this.DialogResult = DialogResult.OK;
                            this.Close();

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

            if (string.IsNullOrEmpty(cbxSexo.ValueMember))
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
                        cmd.CommandText = "";
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@numero_cedula", txtCedula.Text);
                        cmd.Parameters.AddWithValue("@nombres", txtNombres.Text);
                        cmd.Parameters.AddWithValue("@apellidos",txtApellidos.Text);
                        cmd.Parameters.AddWithValue("@sexo",cbxSexo.ValueMember);
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
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("sp_instructores_update", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_instructor", id_instructor);
                        cmd.Parameters.AddWithValue("@numero_cedula",txtCedula.Text);
                        cmd.Parameters.AddWithValue("@nombres",txtNombres.Text);
                        cmd.Parameters.AddWithValue("@apellidos",txtApellidos.Text);
                        cmd.Parameters.AddWithValue("@sexo",cbxSexo.ValueMember);
                        cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                        if (cbkHabilitado.Checked == true)
                            cmd.Parameters.AddWithValue("@habilitado", 1);
                        else
                            cmd.Parameters.AddWithValue("@habilitado", 0);
                        cmd.Parameters.AddWithValue("@fecha_ingreso",dtIngreso.Text);
                        cmd.Parameters.AddWithValue("@id_usuario", UsuarioLoegueado.Id);
                        cmd.Parameters.AddWithValue("",);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception EX)
                    {
                        CajaDialogo.Error(EX.Message);
                    }

                    break;
                default:

                    CajaDialogo.Error("No se pudo Definir una Transaccion (Insert/Update)");
                    break;
            }

        }
    }
}