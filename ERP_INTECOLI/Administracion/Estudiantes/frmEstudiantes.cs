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
using System.Collections;
using ERP_INTECOLI.Administracion.Estudiantes;
using DevExpress.XtraGrid.Views.Grid;

namespace ERP_INTECOLI.Administracion.Estudiantes
{
    public partial class frmEstudiantes : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        private int Idestudiante = 0;
        //Estudiante vEstudiante;
        ArrayList ListaTelefonos;
        PuntoVenta PuntoDeVentaActual;
        private Int64 IdEstudianteRecomendo = 0;
        bool IsEmpleado;
        public enum TipoEdicion
        { 
            Nuevo = 1,
            Editar = 2
        }

        private UserLogin UsuarioLogeado;
        private TipoEdicion pTipoEdit;

        public frmEstudiantes(UserLogin pUserLogin, TipoEdicion pTipo, PuntoVenta pPuntoDeVentaActual)
        {
            InitializeComponent();
            pTipoEdit = pTipo;
            UsuarioLogeado = pUserLogin;
            this.PuntoDeVentaActual = pPuntoDeVentaActual;
            
            CargarNiveles();
            CargarZonas();
            CargarPuntosVentas();

            ListaTelefonos = new ArrayList();

            switch (pTipoEdit)
            {
                case TipoEdicion.Nuevo:
                    //rdEstudiante.Checked = true;
                    chkReingreso.Visible = false;
                    rdGraduado.Visible = rdDesertor.Visible = false;
                    grdvTelefonos.OptionsMenu.EnableColumnMenu = false;
                    grdvTelefonos.Columns["editar"].Visible = false;
                    grdvRTN.Columns["editar"].Visible = false;
                    dtFechaIngreso.EditValue = dp.Now();

                    break;

                case TipoEdicion.Editar:
                    chkReingreso.Visible = true;
                    rdGraduado.Visible = rdDesertor.Visible = true;
                    grdvTelefonos.OptionsMenu.EnableColumnMenu = false;
                    radioGroup2.Enabled = false;
                    break;

                default:
                    break;
            }

        }

        private void CargarPuntosVentas()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringERP);
                con.Open();
                SqlCommand cmd = new SqlCommand("[sp_get_lista_puntos_de_venta]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsEstudiantes1.punto_venta.Clear();
                adat.Fill(dsEstudiantes1.punto_venta);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        public frmEstudiantes(UserLogin pUserLogin, TipoEdicion pTipo, int pid_estudiante, PuntoVenta pPuntoDeVentaActual)
        {
            InitializeComponent();
            pTipoEdit = pTipo;
            UsuarioLogeado = pUserLogin;
            this.PuntoDeVentaActual = pPuntoDeVentaActual;
            Idestudiante = pid_estudiante;
            CargarNiveles();
            CargarZonas();
            CargarPuntosVentas();
            Estudiante est = new Estudiante();
            est.RecuperarRegistro(Idestudiante);
            txtIdentidad.Text = est.identidad;
            txtNombre.Text = est.Nombres;
            txtApellido.Text = est.Apellidos;
            dtFechaNac.EditValue = est.FechaNacimiento;
            dtFechaIngreso.EditValue = est.FechaIngreso;
            
            txtDireccion.Text = est.Direccion;
            cbxSexo.Text = est.Sexo;
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

            cbxNivelIngreso2.EditValue = est.IdNivelIngreso;
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

            spinMinPago.Value = est.Dia_min_pago;
            spinMaxPago.Value = est.Dia_max_pago;
            gridPuntoVenta.EditValue = est.Id_punto_venta;
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

                SqlCommand cmd = new SqlCommand("[sp_estudiante_load_detalle_rtn]", con);
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
                dsEstudiantes1.zonas.Clear();
                adat.Fill(dsEstudiantes1.zonas);
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
                SqlCommand cmd = new SqlCommand("sp_estudiantes_load_niveles_academicos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsEstudiantes1.niveles_academicos.Clear();
                adat.Fill(dsEstudiantes1.niveles_academicos);
                con.Close();

                cbxNivelIngreso.DisplayLayout.Bands[0].Columns["id_nivel"].Hidden = true;
                cbxNivelIngreso.DisplayLayout.Bands[0].Columns["valor"].Hidden = true;
                //cbxNivelIngreso.DisplayLayout.
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
                if (pTipoEdit == TipoEdicion.Editar)
                {
                    frmagregar_telefono frm = new frmagregar_telefono(frmagregar_telefono.TipoEdicion.Editar, Idestudiante);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            string query = @"[sp_estudiantes_insert_detalle_telefono]";
                            SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                            conn.Open();
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_estudiante", Idestudiante);
                            cmd.Parameters.AddWithValue("@tipo_telefono_id", frm.id_tipo_telefono);
                            cmd.Parameters.AddWithValue("@telefono", frm.num_telefono);
                            cmd.ExecuteNonQuery();


                            cargar_telefonos(Idestudiante);
                        }
                        catch (Exception ex)
                        {
                            CajaDialogo.Error(ex.Message);
                        }
                    }
                }
                
                
            }
            if (xtraTabControl2.SelectedTabPage == tabRTN)
            {
                if (pTipoEdit == TipoEdicion.Nuevo)
                {
                    frmagregar_rtn frm = new frmagregar_rtn(frmagregar_rtn.TipoEdicion.Nuevo);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        DataRow row = dsEstudiantes1.detalle_rtn.NewRow();
                        row[2] = frm.id_empresa;
                        row[4] = frm.rtn;
                        row[5] = frm.empresa;
                        dsEstudiantes1.detalle_rtn.Rows.Add(row);
                    }
                }
                if (pTipoEdit == TipoEdicion.Editar)
                {
                    frmagregar_rtn frm = new frmagregar_rtn(frmagregar_rtn.TipoEdicion.Editar);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            string query = @"[sp_estudiantes_insert_detalle_rtn]";
                            SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                            conn.Open();
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_estudiante", Idestudiante);
                            cmd.Parameters.AddWithValue("@id_empresa", frm.id_empresa);
                            cmd.Parameters.AddWithValue("@rtn", frm.rtn);
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            cargar_rtn(Idestudiante);
                        }
                        catch (Exception ex)
                        {
                            CajaDialogo.Error(ex.Message);
                        }
                    }
                }
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
           

            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text)
               || string.IsNullOrEmpty(cbxSexo.SelectedItem.ToString()) || string.IsNullOrEmpty(txtDireccion.Text)
               || string.IsNullOrEmpty(txtEmail.Text))
            {
                CajaDialogo.Error("Aun hay datos del estudiante que no sean ingresado!");
                return;
            }

            if (spinMinPago.Value == 0)
            {
                CajaDialogo.Error("Dia Minimo Pago no puede ser Cero (0)");
                return;
            }

            if (spinMaxPago.Value == 0)
            {
                CajaDialogo.Error("Dia Maximo Pago no puede ser Cero (0)");
                return;
            }

            switch (pTipoEdit)
            {
                case TipoEdicion.Nuevo:
                    break;
                case TipoEdicion.Editar:



                    break;
                default:
                    break;
            }

            if (string.IsNullOrEmpty(gridPuntoVenta.Text))
            {
                CajaDialogo.Error("Debe seleccionar la Sucursal!");
                return;
            }

            //if (spinMinPago.Value > spinMaxPago.Value)
            //{
            //    CajaDialogo.Error("Dias minimos de pago no pueden ser mayor a los dias maximos!");
            //    return;
            //}

            DialogResult r = CajaDialogo.Pregunta("Desea Guardar los datos del nuevo estudiante?");

            if (r != DialogResult.Yes)
                return;

            switch (pTipoEdit)
            {
                case TipoEdicion.Nuevo:
                   
                    Estudiante est = new Estudiante();

                    if (est.ValidarIdDisponible(txtIdentidad.Text.Trim()))
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

                        if (Convert.ToInt32(cbxNivelIngreso2.EditValue) > 0)
                            cmd.Parameters.AddWithValue("@nivel_id_ingreso", cbxNivelIngreso2.EditValue);
                        else
                            cmd.Parameters.AddWithValue("@nivel_id_ingreso", DBNull.Value);

                        cmd.Parameters.AddWithValue("@sexo", cbxSexo.SelectedItem);
                        cmd.Parameters.AddWithValue("@correo",txtEmail.Text.Trim());
                       
                        cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogeado.Id);
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
                        cmd.Parameters.AddWithValue("@IsEmpleado", IsEmpleado);
                        cmd.Parameters.AddWithValue("@dias_min_pago", spinMinPago.Value);
                        cmd.Parameters.AddWithValue("@dias_max_pago", spinMaxPago.Value);
                        cmd.Parameters.AddWithValue("@id_punto_venta", gridPuntoVenta.EditValue);

                        int id_header_estudiante = Convert.ToInt32(cmd.ExecuteScalar());

                        foreach (dsEstudiantes.detalle_telefonosRow row in dsEstudiantes1.detalle_telefonos.Rows)
                        {
                            cmd.Parameters.Clear();
                            cmd.CommandText = "[sp_estudiantes_insert_detalle_telefono]";
                            cmd.Connection = conn;
                            cmd.Transaction = transaction;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_estudiante", id_header_estudiante);
                            cmd.Parameters.AddWithValue("@telefono", row.telefono);
                            cmd.Parameters.AddWithValue("@tipo_telefono_id", row.tipo_telefono_id);
                            cmd.ExecuteNonQuery();
                        }

                        foreach (dsEstudiantes.detalle_rtnRow row in dsEstudiantes1.detalle_rtn.Rows)
                        {
                            cmd.Parameters.Clear();
                            cmd.CommandText = "sp_estudiantes_insert_detalle_rtn";
                            cmd.Connection = conn;
                            cmd.Transaction = transaction;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_estudiante", id_header_estudiante);
                            cmd.Parameters.AddWithValue("@id_empresa", row.id_empresa);
                            cmd.Parameters.AddWithValue("@rtn", row.rtn);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        Guardar = true;

                        try
                        {
                            SqlConnection conn1 = new SqlConnection(dp.ConnectionStringERP);
                            conn1.Open();
                            SqlCommand cmd1 = new SqlCommand("sp_update_tablas_id_Estudiante", conn);
                            cmd1.CommandType = CommandType.StoredProcedure;
                            cmd1.ExecuteNonQuery();
                            conn1.Close();
                        }
                        catch (Exception ec)
                        {
                            CajaDialogo.Error(ec.Message);
                        }

                        

                    }
                    catch (Exception ec)
                    {
                        transaction.Rollback();
                        CajaDialogo.Error(ec.Message);
                        Guardar = false;
                    }

                    if (Guardar)
                    {
                        CajaDialogo.Information("Informacion Guardada con Exito!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }

                    break;
                case TipoEdicion.Editar:

                    Estudiante est1 = new Estudiante();

                    //if (est1.ValidarIdDisponible(txtIdentidad.Text.Trim()))
                    //{
                    //    CajaDialogo.Error("Este Numero de Identidad ya Existe!");
                    //    return;
                    //}
                    string query = "";
                    int id_tipo_retiro = 0;
                    if (chkReingreso.Checked)
                    {
                        if (rdGraduado.Checked)
                            id_tipo_retiro = 1;
                        if (rdDesertor.Checked)
                            id_tipo_retiro = 2;
                    }
                    

                    query = @"sp_estudiante_update";

                    try
                    {
                        SqlConnection connection = new SqlConnection(dp.ConnectionStringERP);
                        connection.Open();
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@numero_identidad", txtIdentidad.Text.Trim());
                        cmd.Parameters.AddWithValue("@nombres", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@apellidos",txtApellido.Text);
                        cmd.Parameters.AddWithValue("@direccion",txtDireccion.Text);
                        cmd.Parameters.AddWithValue("@fecha_nacimiento", dtFechaNac.EditValue);
                        if (chkReingreso.Checked)
                        {
                            if (tsEstado.IsOn)
                                cmd.Parameters.AddWithValue("@habilitado", 1);
                            else
                                cmd.Parameters.AddWithValue("@habilitado",0);

                            cmd.Parameters.AddWithValue("@id_tipo_retiro", id_tipo_retiro);
                        }
                        else
                        {
                            if (tsEstado.IsOn)
                                cmd.Parameters.AddWithValue("@habilitado", 1);
                            else
                                cmd.Parameters.AddWithValue("@habilitado", 0);
                            cmd.Parameters.AddWithValue("@id_tipo_retiro", id_tipo_retiro);
                        }

                        cmd.Parameters.AddWithValue("@fecha_ingreso",dtFechaIngreso.EditValue);
                        cmd.Parameters.AddWithValue("@id", Idestudiante);
                        cmd.Parameters.AddWithValue("@proxima_fecha_pago",dtFechaProximoPago.Value);
                        if (tsTipoPago.IsOn) //Posterior
                            cmd.Parameters.AddWithValue("@tipo_pago", 2);
                        else //Anterior 
                            cmd.Parameters.AddWithValue("@tipo_pago", 1);

                        if (Convert.ToInt32(cbxNivelIngreso2.EditValue) > 0)
                            cmd.Parameters.AddWithValue("@nivel_id_ingreso", cbxNivelIngreso2.EditValue);
                        else
                            cmd.Parameters.AddWithValue("@nivel_id_ingreso", DBNull.Value);

                        cmd.Parameters.AddWithValue("@sexo", cbxSexo.Text);
                        cmd.Parameters.AddWithValue("@correo", txtEmail.Text.Trim());

                        cmd.Parameters.AddWithValue("@seguimiento_saldo", chkSeguimientoSaldo.Checked);

                        if (Convert.ToInt32(gridZonas.EditValue) > 0)
                            cmd.Parameters.AddWithValue("@id_zona", gridZonas.EditValue);
                        else
                            cmd.Parameters.AddWithValue("@id_zona", DBNull.Value);

                        //if (!string.IsNullOrEmpty(IdToken))
                        //    cmd.Parameters.AddWithValue("id_tarjeta", PgSqlType.VarChar).Value = IdToken;
                        //else
                        //    cmd.Parameters.AddWithValue("id_tarjeta", PgSqlType.VarChar).Value = DBNull.Value;

                        if (IdEstudianteRecomendo == 0)
                            cmd.Parameters.AddWithValue("@id_estudiante_recomendo", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@id_estudiante_recomendo", IdEstudianteRecomendo);

                        cmd.Parameters.AddWithValue("@nombre_recomendo", txtRecomendo.Text);
                        cmd.Parameters.AddWithValue("@dias_min_pago", spinMinPago.Value);
                        cmd.Parameters.AddWithValue("@dias_max_pago", spinMaxPago.Value);
                        cmd.Parameters.AddWithValue("@id_punto_venta", gridPuntoVenta.EditValue);
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        Guardar = true;

                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                        Guardar = false;
                    }

                    if (Guardar)
                    {
                        CajaDialogo.Information("Informacion Actualizada con Exito!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }

                    break;

                default:
                    CajaDialogo.Error("No se pudo definir transaccion (Crear/Editar)\n Contacte a su Proveedor!");
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

        private void reposEditarTelefono_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grdTelefonos.FocusedView;
            var row = (dsEstudiantes.detalle_telefonosRow)gridview.GetFocusedDataRow();

            frmagregar_telefono frm = new frmagregar_telefono(frmagregar_telefono.TipoEdicion.Editar, Idestudiante, row.id, row.tipo_telefono_id, row.telefono);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_estudiante_update_detalle_telefono",conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_detalle_telefono", frm.id_detalle_telefono);
                    cmd.Parameters.AddWithValue("@idestudiante", Idestudiante);
                    cmd.Parameters.AddWithValue("@id_tipo_telefono", frm.id_tipo_telefono);
                    cmd.Parameters.AddWithValue("@telefono", frm.num_telefono);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }

                cargar_telefonos(Idestudiante);
            }
        }

        private void reposEliminar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grdTelefonos.FocusedView;
            var row = (dsEstudiantes.detalle_telefonosRow)gridview.GetFocusedDataRow();

            switch (pTipoEdit)
            {
                case TipoEdicion.Nuevo:

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
                case TipoEdicion.Editar:
                    //Eliminar en SQL 

                    DialogResult r = CajaDialogo.Pregunta("Desea Elimianr este Registro?");
                    if (r != System.Windows.Forms.DialogResult.Yes)
                        return;

                    try
                    {
                        string query = @"sp_delete_rtn_or_telefono";
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(query,conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_detalle", row.id);
                        cmd.Parameters.AddWithValue("@id_estudiante", row.id_estudiante);
                        cmd.Parameters.AddWithValue("@id_tipo_detalle", 1); //Eliminar Telefono
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }

                    cargar_telefonos(Idestudiante);

                    break;
                default:

                    CajaDialogo.Error("No se logro definir un proceso de Nuevo/Edicion \n Contactar a su Administrador");

                    break;
            }



        }

        private void repostEditRTN_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grdRtn.FocusedView;
            var row = (dsEstudiantes.detalle_rtnRow)gridview.GetFocusedDataRow();

            frmagregar_rtn frm = new frmagregar_rtn(frmagregar_rtn.TipoEdicion.Editar, Idestudiante, row.id, row.rtn, row.id_empresa);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_estudiante_update_detalle_rtn", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_detalle", frm.id_detalle_rtn);
                    cmd.Parameters.AddWithValue("@id_estudiante", Idestudiante);
                    cmd.Parameters.AddWithValue("@id_empresa", frm.id_empresa);
                    cmd.Parameters.AddWithValue("@rtn", frm.rtn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }

                cargar_rtn(Idestudiante);
            }
        }

        private void repostDeleteRTN_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grdRtn.FocusedView;
            var row = (dsEstudiantes.detalle_rtnRow)gridview.GetFocusedDataRow();

            switch (pTipoEdit)
            {
                case TipoEdicion.Nuevo:

                    //Eliminar en Memoria
                    try
                    {
                        grdvRTN.DeleteRow(grdvRTN.FocusedRowHandle);
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }

                    break;
                case TipoEdicion.Editar:
                    //Eliminar en SQL 
                    DialogResult r = CajaDialogo.Pregunta("Desea Elimianr este Registro?");
                    if (r != System.Windows.Forms.DialogResult.Yes)
                        return;

                    try
                    {
                        string query = @"sp_delete_rtn_or_telefono";
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_detalle", row.id);
                        cmd.Parameters.AddWithValue("@id_estudiante", row.id_estudiante);
                        cmd.Parameters.AddWithValue("@id_tipo_detalle", 2); //Eliminar RTN
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }

                    cargar_rtn(Idestudiante);


                    break;
                default:

                    CajaDialogo.Error("No se logro definir un proceso de Nuevo/Edicion \n Contactar a su Administrador");

                    break;
            }
        }

        private void radioGroup2_SelectedIndexChanged(object sender, EventArgs e)
        {
            RadioGroup edit = sender as RadioGroup;
            if (edit.SelectedIndex == 0) //Estudiante
            {
                IsEmpleado = false;
            }
            if (edit.SelectedIndex == 1) //Empleado
            {
                IsEmpleado = true;
            }
        }
    }
}