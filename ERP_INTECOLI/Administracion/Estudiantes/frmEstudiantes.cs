﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ERP_INTECOLI.Clases;
using System.Collections;
using ERP_INTECOLI.Administracion.Estudiantes;

namespace ERP_INTECOLI.Administracion.Estudiantes
{
    public partial class frmEstudiantes : DevExpress.XtraEditors.XtraForm
    {
        private int Idestudiante = 0;
        Estudiante vEstudiante;
        ArrayList ListaTelefonos;
        private int IdEstudianteRecomendo = 0;
        
        public enum TipoEdicion
        { 
            Nuevo = 1,
            Editar = 2
        }

        private UserLogin UsuarioLogeado;
        private TipoEdicion pTipoEdit;

        public frmEstudiantes(UserLogin pUserLogin, TipoEdicion pTipo)
        {
            InitializeComponent();
            pTipoEdit = pTipo;
            UsuarioLogeado = pUserLogin;
            
            CargarNiveles();
            CargarZonas();

            ListaTelefonos = new ArrayList();

            switch (pTipoEdit)
            {
                case TipoEdicion.Nuevo:
                    chkReingreso.Visible = false;
                    rdGraduado.Visible = rdDesertor.Visible = false;
                    break;

                case TipoEdicion.Editar:
                    chkReingreso.Visible = true;
                    rdGraduado.Visible = rdDesertor.Visible = true;
                    break;

                default:
                    break;
            }

        }

        public frmEstudiantes(UserLogin pUserLogin, TipoEdicion pTipo, int pid_estudiante)
        {
            InitializeComponent();
            UsuarioLogeado = pUserLogin;

            Idestudiante = pid_estudiante;
            CargarNiveles();
            CargarZonas();

            Estudiante est = new Estudiante();
            est.RecuperarRegistro(Idestudiante);
            txtIdentidad.Text = est.identidad;
            txtNombre.Text = est.Nombres;
            txtApellido.Text = est.Apellidos;
            dtFechaNac.EditValue = est.FechaNacimiento;
            dtFechaIngreso.EditValue = est.FechaIngreso;
            cbxSexo.Text = est.Sexo;
            txtDireccion.Text = est.Direccion;

            if (est.TipoPagoEstudiante == Estudiante.TipoPago.Anterior)
                tsTipoPago.IsOn = false;
            else
                tsTipoPago.IsOn = true;

            gridZonas.EditValue = est.IdZona;

            if (est.IdEstudianteRecomendo == 0)
            {
                radioGroup1.EditValue = 0;
            }
            else
            {
                radioGroup1.EditValue = 1;
                txtRecomendo.Text = est.NameEstudianteRecomendo;
            }

            cbxNivelIngreso.Value = est.IdNivelIngreso;
            txtEmail.Text = est.Correo;

            chkReingreso.Checked = est.Reingreso_Retiro;
            chkSeguimientoSaldo.Checked = est.SeguimientoSaldo;

            if (est.Desertor)
                rdDesertor.Checked = true;
            else
                rdDesertor.Checked = false;
            if (est.Graduado)
                rdGraduado.Checked = true;
            else
                rdGraduado.Checked = false;

            if (est.Habilitado)
                tsEstado.IsOn = true;
            else
                tsEstado.IsOn = false;

            

            switch (pTipoEdit)
            {
                case TipoEdicion.Nuevo:
                    chkReingreso.Visible = false;
                    rdGraduado.Visible = rdDesertor.Visible = false;
                    break;

                case TipoEdicion.Editar:
                    chkReingreso.Visible = true;
                    rdGraduado.Visible = rdDesertor.Visible = true;
                    cargar_telefonos(Idestudiante);
                    cargar_rtn(Idestudiante);
                    break;

                default:
                    break;
            }
        }

        private void cargar_rtn(int idestudiante)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();

                SqlCommand cmd = new SqlCommand("", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_estudiante", idestudiante);
                dsEstudiantes1.detalle_rtn.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsEstudiantes1.detalle_rtn);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cargar_telefonos(int idestudiante)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_estudiante_load_detalle_telefono", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_estudiante", idestudiante);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsEstudiantes1.detalle_telefonos.Clear();
                adat.Fill(dsEstudiantes1.detalle_telefonos);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void CargarZonas()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_get_zonas", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsEstudiantes1.niveles_academicos.Clear();
                adat.Fill(dsEstudiantes1.niveles_academicos);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void CargarNiveles()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_load_niveles_", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsEstudiantes1.niveles_academicos.Clear();
                adat.Fill(dsEstudiantes1.niveles_academicos);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(radioGroup1.EditValue) == 0)
            {
                cmdBuscarEstudiante.Visible = false;
                IdEstudianteRecomendo = 0;
                txtRecomendo.Text = "";
            }      
            else
                cmdBuscarEstudiante.Visible = true;
        }

        private void btnTelefono_Rtn_Click(object sender, EventArgs e)
        {
            if (xtraTabControl2.SelectedTabPage == tabTelefonos)
            {
                if (pTipoEdit == TipoEdicion.Nuevo)
                {
                    frmagregar_telefono frm = new frmagregar_telefono(frmagregar_telefono.TipoEdicion.Nuevo, Idestudiante);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        DataRow row = dsEstudiantes1.detalle_telefonos.NewRow();
                        row[2] = frm.num_telefono;
                        row[3] = frm.id_tipo_telefono;
                        row[4] = frm.tipo_Telefono;
                        dsEstudiantes1.detalle_telefonos.Rows.Add(row);
                    }

                }
            }
            else
            {
                if (pTipoEdit == TipoEdicion.Nuevo)
                {

                }
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            DataOperations dp = new DataOperations();

            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text)
               || string.IsNullOrEmpty(cbxSexo.Text) || string.IsNullOrEmpty(txtDireccion.Text)
               || string.IsNullOrEmpty(txtEmail.Text))
            {
                CajaDialogo.Error("Aun hay datos del estudiante que no sean ingresado!");
                return;
            }


            DialogResult r = CajaDialogo.Pregunta("Desea Guardar los datos del nuevo estudiante?");

            if (r == DialogResult.OK)
                return;

            switch (pTipoEdit)
            {
                case TipoEdicion.Nuevo:
                   
                    Estudiante est = new Estudiante();

                    if (!est.ValidarIdDisponible(txtIdentidad.Text.Trim()))
                    {
                        CajaDialogo.Error("Este Numero de Identidad ya Existe!");
                        return;
                    }

                    SqlTransaction transaction = null;

                    SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                    bool Guardar = false;

                    try
                    {
                        conn.Open();
                        transaction = conn.BeginTransaction("Transaction Order");

                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "sp_estudiantes_insert_new_estudiante";
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nombres",txtNombre.Text);
                        cmd.Parameters.AddWithValue("@apellidos", txtApellido.Text);
                        cmd.Parameters.AddWithValue("@direccion",txtDireccion.Text);
                        cmd.Parameters.AddWithValue("@fecha_nacimiento",dtFechaNac.EditValue);

                        if (Convert.ToInt32(cbxNivelIngreso.Value) > 0)
                            cmd.Parameters.AddWithValue("@nivel_id_ingreso", cbxNivelIngreso.Value);
                        else
                            cmd.Parameters.AddWithValue("@nivel_id_ingreso", DBNull.Value);

                        cmd.Parameters.AddWithValue("@sexo", cbxSexo.Text);
                        cmd.Parameters.AddWithValue("@correo",txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogeado.UserId);
                        cmd.Parameters.AddWithValue("@proxima_fecha_pago", dtFechaProximoPago.Value);
                        if (chkSeguimientoSaldo.Checked)
                            cmd.Parameters.AddWithValue("@seguimiento_saldo", 1);
                        else
                            cmd.Parameters.AddWithValue("@seguimiento_saldo", 0);

                        //cmd.Parameters.AddWithValue("@fecha_anulado", null);
                        if (tsTipoPago.IsOn) //Posterior
                            cmd.Parameters.AddWithValue("@tipo_pago",2);
                        else //Anterior 
                            cmd.Parameters.AddWithValue("@tipo_pago",1);
                        if (Convert.ToInt32(gridZonas.EditValue) > 0)
                            cmd.Parameters.AddWithValue("@id_zona", Convert.ToInt32(gridZonas.EditValue));
                        else
                            cmd.Parameters.AddWithValue("@id_zona", DBNull.Value);

                        if (IdEstudianteRecomendo > 0)
                        {
                            cmd.Parameters.AddWithValue("@id_estudiante_recomendo", IdEstudianteRecomendo);
                            cmd.Parameters.AddWithValue("@nombre_recomendo", txtRecomendo.Text);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@id_estudiante_recomendo", DBNull.Value);
                            cmd.Parameters.AddWithValue("@nombre_recomendo", DBNull.Value);
                        }

                        cmd.Parameters.AddWithValue("@id_sucursal", 1);
                        cmd.Parameters.AddWithValue("@numero_identidad", txtIdentidad.Text.Trim());



                        int id_header_estudiante = Convert.ToInt32(cmd.ExecuteScalar());

                        //foreach (dsEstudiantes.detalle_telefonosRow row in dsEstudiantes1.detalle_telefonos.Rows)
                        //{
                        //    cmd.Parameters.Clear();
                        //    cmd.CommandText = "";
                        //    cmd.Connection = conn;
                        //    cmd.Transaction = transaction;
                        //    cmd.CommandType = CommandType.StoredProcedure;
                        //    cmd.Parameters.AddWithValue("",);
                        //    cmd.ExecuteNonQuery();
                        //}

                        //foreach (dsEstudiantes.detalle_rtnRow row in dsEstudiantes1.detalle_rtn.Rows)
                        //{
                        //    cmd.Parameters.Clear();
                        //    cmd.CommandText = "";
                        //    cmd.Connection = conn;
                        //    cmd.Transaction = transaction;
                        //    cmd.CommandType = CommandType.StoredProcedure;
                        //    cmd.Parameters.AddWithValue("",);
                        //    cmd.ExecuteNonQuery();
                        //}

                        transaction.Commit();
                        Guardar = true;

                        this.DialogResult = DialogResult.OK;
                        this.Close();

                    }
                    catch (Exception ec)
                    {
                        transaction.Rollback();
                        CajaDialogo.Error(ec.Message);
                        Guardar = false;
                    }

                    break;
                case TipoEdicion.Editar:
                    break;

                default:
                    break;
            }


        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void cmdBuscarEstudiante_Click(object sender, EventArgs e)
        {
            frmBuscarEstudiantes frm = new frmBuscarEstudiantes();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (frm.ItemSeleccionado.id_estudiantes > 0)
                {
                    radioGroup1.EditValue = 1;
                    IdEstudianteRecomendo = frm.ItemSeleccionado.id_estudiantes;
                    txtRecomendo.Text = frm.ItemSeleccionado.Nombres + " " + frm.ItemSeleccionado.Apellidos;
                }
            }
        }
    }
}