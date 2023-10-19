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
using static ERP_INTECOLI.Administracion.Instructores.frmAgregarInstructores;
using Infragistics.Win.UltraWinEditors;

namespace ERP_INTECOLI.Administracion.Cursos
{
    public partial class frmNuevo_Editar_Curso : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin psUserLog;
        public int idCurso, idInstructor, idNivel;
        public DateTime fechaPago, fechaInicio, fechaFin;
        public TimeSpan horaInicio, horaFin;

        UltraCheckEditor[] cbDias = new UltraCheckEditor[7];
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            int contaDias = 0;

            for (int i = 1; i < 7; i++)
            {
                if (cbDias[i].Checked == true)
                    contaDias++;
            }

            if (contaDias < 1)
            {
                CajaDialogo.Error("Debe seleccionar por lo menos 1 dia de clase");
                return;
            }

            if (Convert.ToDateTime(dtFin.Value) <= Convert.ToDateTime(dtInicio.Value))
            {
                CajaDialogo.Error("Fecha de inicio no puede ser mayor o igual que la fecha fin");
                return;
            }

            //si hora inicio es mayor que hora fin muestra error
            if (tseHora.Time.Hour >= tseHoraFin.Time.Hour)
            {
                CajaDialogo.Error("Hora de inicio no puede ser mayor o igual que la hora fin");
                return;
            }

            switch (pTipo)
            {
                case TipoTransaccion.insert:

                    //validamos la unicidad del curso
                    try
                    {
                        string v_hora = tseHora.EditValue.ToString();
                        if (v_hora.Length == 1)
                            v_hora = "0" + v_hora;

                        string sql = @"SELECT count(cc.id_nivel) as total
                                FROM cursos cc
                                where not cc.curso_finalizado = 1
                                      and cc.id_nivel = " + cbxNiveles.EditValue.ToString() +
                                              "and cc.seccion = '" + v_hora + "-" + ceSeccion.Text + "';";
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        int total = Convert.ToInt32(cmd.ExecuteScalar());
                        if (total >= 1)
                        {
                            CajaDialogo.Error("No puede crear esta seccion! Actualmente ya existe una seccion igual para este curso " +
                                               "\nGenere un numero mayor para la siguiente seccion.\n" +
                                               "\nDe lo contrario marque como finalizado el curso anterior para poder crear una nueva seccion");
                            return;
                        }
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }

                    //PgSqlTransaction tran1 = psConnection.BeginTransaction();

                    try
                    {
                        //PgSqlCommand cmd;

                        //string Query = @"select * from admon.ft_insert_curso_v2 (
                        //                  :p_id_nivel,
                        //                  :p_id_instructor,
                        //                  :p_hora_inicio,
                        //                  :p_hora_fin,
                        //                  :p_fecha_inicio,
                        //                  :p_fecha_fin,
                        //                  :p_seccion
                        //                    )";
                        
                        string v_hora = tseHora.Time.Hour.ToString();
                        if (v_hora.Length == 1)
                            v_hora = "0" + v_hora;
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("sp_insert_curso", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_nivel", cbxNiveles.EditValue);
                        cmd.Parameters.AddWithValue("@id_instructor", cbxInstructores.EditValue);
                        cmd.Parameters.AddWithValue("@seccion", v_hora + "-" + ceSeccion.Text);
                        cmd.Parameters.AddWithValue("@hora_inicio",tseHora.Time);
                        cmd.Parameters.AddWithValue("@hora_fin", tseHoraFin.Time);
                        cmd.Parameters.AddWithValue("@fecha_inicio", dtInicio.Value);
                        cmd.Parameters.AddWithValue("@fecha_fin", dtFin.Value);

                        int idcurso = Convert.ToInt32(cmd.ExecuteScalar());

                        DiasClases(cb1, cb2, cb3, cb4, cb5, cb6, cb7, idcurso);

                        //tran1.Commit();


                        CajaDialogo.Information("DATOS GUARDADOS");

                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    }

                    catch (Exception error)
                    {
                        //tran1.Rollback();
                        CajaDialogo.Error("Ocurrio un error ", error);
                    }
                    break;

                case TipoTransaccion.update:

                    //PgSqlTransaction tran2 = psConnection.BeginTransaction();
                    try
                    {

                        //string sql = @"select * from admon.ft_update_cursos (
                        //                                  :pid_nivel,
                        //                                  :pid_instructor,
                        //                                  :pfecha_inicio,
                        //                                  :pfecha_fin,
                        //                                  :pcurso_finalizado,
                        //                                  :phora_inicio,
                        //                                  :phora_fin,
                        //                                  :pseccion,
                        //                                  :pid
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("sp_update_cursos",conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        string v_hora = tseHora.Time.Hour.ToString();
                        if (v_hora.Length == 1)
                            v_hora = "0" + v_hora;

                        
                        TimeSpan resulInicio = TimeSpan.FromHours(tseHora.Time.Hour);
                        string InicioHora = resulInicio.ToString("hh':'mm");

                        TimeSpan resulFinal = TimeSpan.FromHours(tseHoraFin.Time.Hour);
                        string FinalHora = resulFinal.ToString("hh':'mm");

                        cmd.Parameters.AddWithValue("@id_nivel",cbxNiveles.EditValue);
                        cmd.Parameters.AddWithValue("@id_instructor", Convert.ToInt32(cbxInstructores.EditValue));
                        cmd.Parameters.AddWithValue("@fecha_inicio", dtInicio.Value);
                        cmd.Parameters.AddWithValue("@fecha_fin", dtFin.Value);
                        cmd.Parameters.AddWithValue("@curso_finalizado", chCursoFinalizado.Checked);
                        cmd.Parameters.AddWithValue("@hora_inicio", InicioHora); //tseHora.Time.Hour);
                        cmd.Parameters.AddWithValue("@hora_fin", FinalHora); //tseHoraFin.Time.Hour);
                        cmd.Parameters.AddWithValue("@seccion", v_hora + "-" + ceSeccion.Text);
                        cmd.Parameters.AddWithValue("@id", idCurso);
                        cmd.ExecuteNonQuery();


                        string sql2 = "delete from curso_dias where id_curso =" + idCurso;
                        cmd = new SqlCommand(sql2, conn);
                        cmd.ExecuteNonQuery();

                        for (int i = 0; i < cbDias.Length; i++)
                        {
                            if (cbDias[i].Checked == true)
                                ActualizarDiasCursos(i + 1);
                        }

                        //tran2.Commit();
                        CajaDialogo.Information("Datos Actualizados");

                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        Close();

                    }

                    catch (Exception error)
                    {
                        //tran2.Rollback();
                        CajaDialogo.Error("Ocurrio un error", error);
                    }
                    break;

            }
        }

        void ActualizarDiasCursos(int dia)
        {

            string sql3 = @"[sp_curso_guardar_dias]";

            SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql3, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id_curso", idCurso);
            cmd.Parameters.AddWithValue("dia", dia);

            cmd.ExecuteNonQuery();

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string Seccion;

        TipoTransaccion pTipo = new TipoTransaccion();
        public enum TipoTransaccion
        {
            insert = 1,
            update = 2

        }

        public frmNuevo_Editar_Curso(TipoTransaccion ParametroTipo)
        {
            InitializeComponent();
            pTipo = ParametroTipo;

            CargarNiveles();
            CargarInstructores();


            //asigna los valores de los checkbox al arreglo de checkbox
            cbDias[0] = cb1;
            cbDias[1] = cb2;
            cbDias[2] = cb3;
            cbDias[3] = cb4;
            cbDias[4] = cb5;
            cbDias[5] = cb6;
            cbDias[6] = cb7;

            dtInicio.Value = dp.Now();
            int mes = dtInicio.Value.Month + 2;
            int anio = dtInicio.Value.Year;
            if (mes > 12)
            {
                mes = mes - 12;
                anio++;
            }
            //DateTime datet = new DateTime(anio, mes, dtInicio.DateTime.Day);
            DateTime primerDia = new DateTime(anio, mes, 1);
            //Para obtener el último día del mes, puedes recurrir al truco de sumar 1 mes y restar 1 día:
            DateTime ultimoDia = primerDia.AddMonths(1).AddDays(-1);

            dtFin.Value = ultimoDia;

        }

        void CargarDias(UltraCheckEditor[] ucbDias)
        {
            try
            {
                dsCursos_1.DiasCursos.Clear();
                string Query = @"select dia from curso_dias where id_curso=" + idCurso;
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsCursos_1.DiasCursos);
                SetDiasClases(dsCursos_1.DiasCursos);
            }

            catch (Exception error)
            {

                CajaDialogo.Error("Ocurrio un error ", error);
            }

        }

        private void frmNuevo_Editar_Curso_Load(object sender, EventArgs e)
        {

            if (pTipo == TipoTransaccion.update)
            {
                cbxNiveles.EditValue = idNivel;
                cbxInstructores.EditValue = idInstructor;
                tseHora.EditValue = horaInicio;
                tseHoraFin.EditValue = horaFin;
                dtInicio.Value = fechaInicio;
                dtFin.Value = fechaFin;
                ceSeccion.Text = Seccion.Substring(3, 2);

                CargarDias(cbDias);
            }
        }

        void SetDiasClases(DataTable dtDias)
        {

            for (int i = 1; i <= cbDias.Length; i++)
            {
                for (int u = 0; u < dtDias.Rows.Count; u++)
                {
                    int fila = Convert.ToInt32(dtDias.Rows[u][0].ToString());

                    if (i == fila)
                        cbDias[fila - 1].Checked = true;

                }
            }
        }

        private void CargarNiveles()
        {
            try
            {
                dsCursos_1.Niveles_academicos.Clear();
                string sql = @"SELECT id_nivel, descripcion
                               FROM niveles;";
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

        public void CargarInstructores()
        {
            try
            {
                dsCursos_1.Instructores.Clear();
                string sql = @"SELECT id_instructor, (coalesce(nombres,'') +' '+ coalesce(apellidos,''))as nombre
                                FROM instructores ins
                                where ins.habilitado = 1;";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql,conn);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsCursos_1.Instructores);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error("No se pudo cargar la lista de instructores!\n", ec);
            }
        }

        void DiasClases(UltraCheckEditor uce1,
                        UltraCheckEditor uce2,
                        UltraCheckEditor uce3,
                        UltraCheckEditor uce4,
                        UltraCheckEditor uce5,
                        UltraCheckEditor uce6,
                        UltraCheckEditor uce7,
                        int cursoID)
        {
            if (uce1.Checked == true)
                GuardarDias(1, cursoID);

            if (uce2.Checked == true)
                GuardarDias(2, cursoID);

            if (uce3.Checked == true)
                GuardarDias(3, cursoID);

            if (uce4.Checked == true)
                GuardarDias(4, cursoID);

            if (uce5.Checked == true)
                GuardarDias(5, cursoID);

            if (uce6.Checked == true)
                GuardarDias(6, cursoID);

            if (uce7.Checked == true)
                GuardarDias(7, cursoID);


        }

        void GuardarDias(int dia, int curso_id)
        {

            try
            {
                string SQL = @"sp_curso_guardar_dias";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(SQL,conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_curso", curso_id);
                cmd.Parameters.AddWithValue("@dia", dia);

                cmd.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                CajaDialogo.Error("Ocurrio un error ", error);
            }

        }

    }
}