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
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace ERP_INTECOLI.Administracion.Cursos
{
    public partial class frmCursos : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin usuarioLogueado;
        bool PresionobtnCerra;

        public frmCursos(UserLogin pUserLogin)
        {
            InitializeComponent();
            usuarioLogueado = pUserLogin;
            verificarFechaFin();

            CargarCursos();
            CargarNiveles();

            
        }

        private void verificarFechaFin()
        {
            
            try
            {
                //string sql = "update cursos set curso_finalizado=TRUE where fecha_fin<now()";
                string sql = @"verificacion_fecha_finCursos";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.ExecuteNonQuery();

            }
            catch (Exception error)
            {
                //tran2.Rollback();
                CajaDialogo.Error("Ocurrio un error", error);
            }
        }

        private void CargarNiveles()
        {
            try
            {
                dsCursos_1.Niveles_academicos.Clear();
                string sql = @"SELECT id_nivel, descripcion
                               FROM niveles
                               order by descripcion;";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsCursos_1.Niveles_academicos);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error("No se pudieron cargar los niveles academicos para el ultracombobox! \n", ec);
            }
        }

        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (PresionobtnCerra == false)
                {
                    //UltraGridBand band = this.ultraGrid1.DisplayLayout.Bands[0];
                    //band.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True;
                    //band.Columns["id_nivel"].AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True;
                    //band.Override.RowFilterMode = RowFilterMode.AllRowsInBand;
                    //band.ColumnFilters["id_nivel"].FilterConditions.Clear();
                    //this.ultraGrid1.DisplayLayout.Bands[0].ColumnFilters.ClearAllFilters();
                    if (this.gridView1.RowCount > 0)
                    {
                        if (ucbNiveles.EditValue != DBNull.Value && ucbNiveles.EditValue != null)
                        {
                            //this.ultraGrid1.DisplayLayout.Bands[0].ColumnFilters["id_nivel"].FilterConditions.Add(FilterComparisionOperator.Equals, ucbNiveles.Value);
                        }
                    }
                    if (string.IsNullOrEmpty(this.ucbNiveles.Text))
                    {
                        CargarCursos();
                    }
                }
            }
            catch (Exception error)
            {
                CajaDialogo.Error(error.Message);
            }
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                frmNuevo_Editar_Curso frm = new frmNuevo_Editar_Curso(frmNuevo_Editar_Curso.TipoTransaccion.insert);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarCursos();
                }

            }
            catch (Exception err)
            {
                CajaDialogo.Error(err.Message);
            }
        }

        private void CargarCursos()
        {
            try
            {
                dsCursos_1.Cursos.Clear();
                string sql = @"select 	t1.id,
		                                t1.id_nivel,
                                        t2.descripcion,
                                        t1.seccion,
                                        t1.id_instructor,
		                                (COALESCE(t3.nombres,'') + ' ' + COALESCE(t3.apellidos,'')) as nombres,
                                        t1.hora_inicio,
                                        t1.hora_fin,
                                        t1.fecha_posteo,
                                        t1.fecha_inicio,
                                        t1.fecha_fin,
                                        t1.curso_finalizado
                                from cursos t1 
                                     inner join niveles t2 
                                        on (t1.id_nivel=t2.id_nivel) 
	                            INNER JOIN instructores t3 
                                on (t1.id_instructor=t3.id_instructor)";
                if (!chkFinalizados.Checked)
                {
                    sql += "  where not curso_finalizado =1  and (nulo = 0 or nulo is null)";
                }
                else
                {
                    sql += "  where (nulo = 0 or nulo is null)";
                }
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsCursos_1.Cursos);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error("No se pudo cargar el set de cursos! ", ec);
            }
        }

        private void chkFinalizados_CheckedChanged(object sender, EventArgs e)
        {
            cmdCargar_Click(sender, e);
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            ucbNiveles.EditValue = null;
            CargarCursos();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            PresionobtnCerra = true;
            this.Close();
        }

        private void repositoryEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gridControl1.FocusedView;
            var row = (dsCursos_.CursosRow)gridview.GetFocusedDataRow();

            frmNuevo_Editar_Curso frmEditCurso = new frmNuevo_Editar_Curso(frmNuevo_Editar_Curso.TipoTransaccion.update);
            frmEditCurso.idNivel = row.id_nivel;// Convert.ToInt32(e.Cell.Row.Cells["id_nivel"].Value);
            frmEditCurso.idInstructor = row.id_instructor;//Convert.ToInt32(e.Cell.Row.Cells["id_instructor"].Value);
            frmEditCurso.horaInicio = row.hora_inicio; //TimeSpan.Parse(e.Cell.Row.Cells["hora_inicio"].Value.ToString());
            frmEditCurso.horaFin = row.hora_fin;//TimeSpan.Parse(e.Cell.Row.Cells["hora_fin"].Value.ToString());
            frmEditCurso.Seccion = row.seccion;//e.Cell.Row.Cells["seccion"].Value.ToString();
            frmEditCurso.fechaInicio = row.fecha_inicio; //Convert.ToDateTime(e.Cell.Row.Cells["fecha_inicio"].Value.ToString());
            frmEditCurso.fechaFin = row.fecha_fin; //Convert.ToDateTime(e.Cell.Row.Cells["fecha_fin"].Value.ToString());
            frmEditCurso.idCurso = row.id; //Convert.ToInt32(e.Cell.Row.Cells["id"].Value.ToString());

            if (frmEditCurso.ShowDialog() == DialogResult.OK)
                CargarCursos();

        }

        private void repositoryEliminar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gridControl1.FocusedView;
            var row = (dsCursos_.CursosRow)gridview.GetFocusedDataRow();

            DialogResult r = MessageBox.Show("Realmente quiere eliminar este curso?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == System.Windows.Forms.DialogResult.No)
                return;

            int id_curso = row.id;
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand("[sp_anular_curso]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_cusro", id_curso);
                cmd.ExecuteNonQuery();
                conn.Close();

                CargarCursos();
                CajaDialogo.Information("Curso eliminado satisfactoriamente");
            }
            catch (Exception EX)
            {
                CajaDialogo.Error(EX.Message);
            }
        }

        private void cmdEliminarTodos_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta opción elimina y finaliza todos los cursos activos actualmente, realmente desea realizar esta acción?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == System.Windows.Forms.DialogResult.No)
                return;

            r = MessageBox.Show("Debido a la seriedad de ésta acción necesitamos una doble confirmación, al aceptar eliminarlos tendrá que crearlos nuevamente... " +
                                            @"\nConfirma que desea realizar esta acción?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == System.Windows.Forms.DialogResult.No)
                return;

            bool Elimino = false;
            foreach (dsCursos_.CursosRow row in dsCursos_1.Cursos.Rows)
            {
                int id_curso = Convert.ToInt32(row.id);
                //PgSqlTransaction tranx = psConnection.BeginTransaction();

                try
                {
                    //string sql = "DELETE FROM admon.cursos  WHERE id = :id;";
                    string sql = @"sp_anular_curso";// select * from admon.ft_anular_curso(:pidcurso)";
                    SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id_cusro", id_curso);
                    cmd.ExecuteScalar();
                    //tranx.Commit();
                    Elimino = true;
                    //CargarCursos();
                    //CajaDialogo.Information("Curso eliminado satisfactoriamente");

                }
                catch (Exception ec)
                {
                    //tranx.Rollback();
                    CajaDialogo.Error("No se pudo eliminar el curso!", ec);
                }
            }

            if (Elimino)
            {
                CargarCursos();
                CajaDialogo.Information("Curso(s) eliminado(s) satisfactoriamente!");
            }
        }
    }
}