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
using ERP_INTECOLI.Clases;
using ERP_INTECOLI.Administracion.Matricula;
using System.Data.SqlClient;

namespace ERP_INTECOLI.Administracion.Matricula
{
    public partial class ctl_Matricula : DevExpress.XtraEditors.XtraForm
    {
        Estudiante est = new Estudiante();
        DataOperations dp = new DataOperations();
        public decimal Valor;
        public bool editar;
        public UserLogin UsuarioLogueado;
        public int IdCurso;
        public int IdSeccion;
        public int IdNivel;
 
        public ctl_Matricula(UserLogin pUserLOgin, long pIdEstudiante)
        {
            InitializeComponent();
            UsuarioLogueado = pUserLOgin;
            est.RecuperarRegistro(pIdEstudiante);
            editar = false;
            CargarDatos();
            //CargarSecciones();
        }

        //public Estudiante vEstudiante;
        

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void CargarDatos()
        {
            try
            {
                string sql = "sp_matricula_cargar_niveles_disponibles";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsNuevoCursoMatricula1.niveles.Clear(); //dsMatricula1.niveles.Clear();
                adat.Fill(dsNuevoCursoMatricula1.niveles);
                txtEstudiante.Text = est.Nombres + " " + est.Apellidos;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void CargarSecciones()
        {
            try
            {
                //string sql = "select * from admon.ft_recupera_secciones (:p_id_nivel);";
                string sql = @"sp_matricula_recupera_secciones_for_id_nviel";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                if (!string.IsNullOrEmpty(grNivel.EditValue.ToString()))
                    cmd.Parameters.AddWithValue("@id_nivel", grNivel.EditValue);
                else
                    cmd.Parameters.AddWithValue("@id_nivel", 0);

                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsNuevoCursoMatricula1.secciones.Clear(); //dsMatricula1.niveles.Clear();
                adat.Fill(dsNuevoCursoMatricula1.secciones);
                foreach (DataRow row in dsNuevoCursoMatricula1.secciones)
                {
                    if (Convert.ToInt32(row["id_nivel"]) == Convert.ToInt32(grNivel.EditValue))
                    {
                        txtValor.Text = row["valor"].ToString();
                        Valor = Convert.ToDecimal(txtValor.Text);
                        break;
                    }
                }
                if (grNivel.EditValue != null)
                    IdNivel = Convert.ToInt32(grNivel.EditValue);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdEditNivel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(grNivel.Text))
            {
                txtNuevoNombre.Text = grNivel.Text;
                lblNuevoNombre.Enabled = txtNuevoNombre.Enabled = cmdGuardarNuevoNombre.Enabled = true;
            }
        }

        private void cmdGuardarNuevoNombre_Click(object sender, EventArgs e)
        {
            DialogResult r = CajaDialogo.Pregunta("¿Esta seguro(a) de cambiar el nombre de este nivel?");
            if (r != DialogResult.Yes)
                return;

            try
            {
                //string sql = @"UPDATE admon.niveles 
                //                SET descripcion = :descripcion
                //                WHERE id_nivel = :id_nivel;";
                string sql = @"sp_matricula_actualizar_nivel";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@descripcion", txtNuevoNombre.Text);
                cmd.Parameters.AddWithValue("@id_nivel", IdNivel);
                cmd.ExecuteNonQuery();

                CargarDatos();
                grNivel.EditValue = IdNivel;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdEditSecciones_Click(object sender, EventArgs e)
        {
            frmEditSecciones frm = new frmEditSecciones(dsNuevoCursoMatricula1.secciones);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarSecciones();

            }
        }

        private void listBoxSeccion_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBoxSeccion.SelectedValue != null)
                IdSeccion = Convert.ToInt32(listBoxSeccion.SelectedValue);
        }

        private void grNivel_EditValueChanged(object sender, EventArgs e)
        {
            CargarSecciones();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
