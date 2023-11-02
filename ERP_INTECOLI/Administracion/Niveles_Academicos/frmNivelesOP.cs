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
using System.Data.SqlClient;
using ERP_INTECOLI.Clases;


namespace ERP_INTECOLI.Administracion.Niveles_Academicos
{
    public partial class frmNivelesOP : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogueado;
        DataOperations dp = new DataOperations();
        public int id_nivel = 0;
        public enum TipoOperacion
        { 
            Insert = 1,
            Update = 2
        }
        Niveles NivelActual;

        private TipoOperacion TipoOP;

        public frmNivelesOP(TipoOperacion pTipoOP, UserLogin pUserLogin, int pId_nivel, string pDescrpcion, decimal pvalor, bool phabilitado)
        {
            InitializeComponent();
            TipoOP = pTipoOP;
            UsuarioLogueado = pUserLogin;
            NivelActual = new Niveles();

            LoadITEMS(pId_nivel);
            switch (TipoOP)
            {
                case TipoOperacion.Insert:
                    chkHabilitado.Checked = true;

                    break;
                case TipoOperacion.Update:
                    id_nivel = pId_nivel;
                    txtDescripcion.Text = pDescrpcion;
                    txtValor.Text = pvalor.ToString();
                    chkHabilitado.Checked = phabilitado;
                    break;
                default:
                    break;
            }
        }

        private void LoadITEMS(int pIdNivel)
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_detalle_pt_for_niveles_cursos", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idnivel", pIdNivel);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(dsNivelesItems1.item_pt_selection);

                if (NivelActual.CargarDatosPorId(pIdNivel))
                {
                    if (dsNivelesItems1.item_pt_selection.Rows.Count > 0)
                        gridLookUpEdit1.EditValue = NivelActual.id_pt;
                }
                
                conn.Close();
            }
            catch (Exception EX)
            {
                CajaDialogo.Error(EX.Message);
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                //CajaDialogo.Error("No puede dejar vacio este campo!");
                errorProvider1.SetError(txtDescripcion, "No puede dejar vacio este campo!");
                txtDescripcion.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtValor.Text))
            {
                //CajaDialogo.Error("No puede dejar vacio este campo!");
                errorProvider1.SetError(txtDescripcion, "No puede dejar vacio este campo!");
                txtValor.Focus();
                return;
            }

            if (string.IsNullOrEmpty(gridLookUpEdit1.Text))
            {
                //CajaDialogo.Error("No puede dejar vacio este campo!");
                errorProvider1.SetError(txtDescripcion, "No puede dejar vacio este campo!");
                gridLookUpEdit1.Focus();
                return;
            }

            switch (TipoOP)
            {
                case TipoOperacion.Insert:

                    try
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("dbo.[sp_niveles_academicos_insert_update_v2]", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_nivel", 0);
                        cmd.Parameters.AddWithValue("@descripcion",txtDescripcion.Text);
                        cmd.Parameters.AddWithValue("@valor", Convert.ToDecimal(txtValor.Text));
                        cmd.Parameters.AddWithValue("@habilitado", chkHabilitado.Checked);
                        cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogueado.Id);
                        cmd.Parameters.AddWithValue("@TipoOperacion", 1); //Insert
                        cmd.Parameters.AddWithValue("@idpt", gridLookUpEdit1.EditValue); //Insert
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception EX)
                    {
                        CajaDialogo.Error(EX.Message);
                    }

                    CajaDialogo.Information("Nivel Creado con Exito");
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                    break;
                case TipoOperacion.Update:

                    try
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("dbo.[sp_niveles_academicos_insert_update_v2]", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_nivel", id_nivel);
                        cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                        cmd.Parameters.AddWithValue("@valor", txtValor.Text);
                        cmd.Parameters.AddWithValue("@habilitado",chkHabilitado.Checked);
                        cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogueado.Id);
                        cmd.Parameters.AddWithValue("@TipoOperacion", 2);
                        cmd.Parameters.AddWithValue("@idpt", gridLookUpEdit1.EditValue); //Update
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception EX)
                    {
                        CajaDialogo.Error(EX.Message);
                    }

                    CajaDialogo.Information("Nivel Actualizado con Exito");
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                    break;
                default:
                    break;
            }

        }

        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}