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
using ERP_INTECOLI.Transacciones;
using System.Data.SqlClient;
using ERP_INTECOLI.Administracion.Estudiantes;
using ERP_INTECOLI.Facturacion;
using DevExpress.XtraGrid.Views.Grid;

namespace ERP_INTECOLI.Transacciones
{
    public partial class frmPostearMensualidad : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogueado;
        Estudiante vEstudiante;
        DataOperations dp = new DataOperations();
        int V_Dias = 0;
        Decimal VarDescuento;
        Decimal VarRecargo;
        Decimal VarAbono;

        enum switchColor
        {
            no_pintado = 0,
            pintado = 1
        }

        switchColor ColorActual = switchColor.no_pintado;

        public frmPostearMensualidad(UserLogin PuserLogin)
        {
            InitializeComponent();
            UsuarioLogueado = PuserLogin;
            VarDescuento = 0;
            VarRecargo = 0;
            VarAbono = 0;
            vEstudiante = new Estudiante();

            //ConfiguracionSuccess Conf = new ConfiguracionSuccess(psConnection);
            dtFechaLimite.Value = dp.Now();
            CargarNiveles();
        }

        private void CargarNiveles()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                dsMensualidades1.niveles_academicos.Clear();
                string sql = @"sp_load_niveles_";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMensualidades1.niveles_academicos);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error("No se pudieron cargar los niveles academicos para el ultracombobox! \n", ec);
            }
        }

        private void cmdRecargarSaldo_Click(object sender, EventArgs e)
        {
            if (vEstudiante != null)
            {
                if (vEstudiante.Recuperado)
                {
                    txtestudiante.Text = vEstudiante.Nombres + " " + vEstudiante.Apellidos;
                    if (vEstudiante.FechaProximoPago.ToString() == "1/1/0001 12:00:00 AM")
                    {
                        dtFechaPagoProximo.Value = DateTime.Now;
                    }
                    else
                    {
                        dtFechaPagoProximo.Value = vEstudiante.FechaProximoPago;
                    }

                    if (vEstudiante != null)
                    {
                        if (vEstudiante.IdEstudiante > 0)
                        {
                            CargarCursos(vEstudiante.IdEstudiante);
                            Saldos sal = new Saldos();
                            CargarDetalleMensualidades(vEstudiante.IdEstudiante);
                            decimal dsal = sal.ConsultarSaldo(vEstudiante.IdEstudiante);
                            if (dsal == 0)
                                txtSaldo.Text = "0";
                            else
                                if (dsal > 1000)
                                txtSaldo.Text = String.Format("{0:0,000.00}", dsal);
                            else
                                txtSaldo.Text = String.Format("{0:00.00}", dsal);
                        }
                    }
                }
            }
        }

        private void cmdF2_Click(object sender, EventArgs e)
        {
            frmBuscarEstudiantes fx1 = new frmBuscarEstudiantes();
            if (fx1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                if (vEstudiante.RecuperarRegistro(fx1.ItemSeleccionado.id_estudiantes))
                {
                    txtestudiante.Text = vEstudiante.Nombres + " " + vEstudiante.Apellidos;
                    if (vEstudiante.FechaProximoPago.ToString() == "1/1/0001 12:00:00 AM")
                        dtFechaPagoProximo.Value = DateTime.Now;
                    else
                        dtFechaPagoProximo.Value = vEstudiante.FechaProximoPago;

                    if (vEstudiante != null)
                    {
                        if (vEstudiante.IdEstudiante > 0)
                        {
                            if (!vEstudiante.Habilitado)
                            {
                                timer1.Start();
                            }
                            else
                            {
                                timer1.Stop();
                                //PanelEncabezado.BackColor = Color.White;
                                lblRotulo.Visible = false;
                            }

                            if (vEstudiante.TipoPagoEstudiante == Estudiante.TipoPago.Posterior)
                                toggleSwitch1.IsOn = true;
                            else
                                toggleSwitch1.IsOn = false;

                            CargarCursos(vEstudiante.IdEstudiante);
                            Saldos sal = new Saldos();
                            CargarDetalleMensualidades(vEstudiante.IdEstudiante);
                            decimal dsal = sal.ConsultarSaldo(vEstudiante.IdEstudiante);
                            if (dsal == 0)
                                txtSaldo.Text = "0";
                            else
                                if (dsal > 1000)
                                txtSaldo.Text = String.Format("{0:0,000.00}", dsal);
                            else
                                txtSaldo.Text = String.Format("{0:00.00}", dsal);

                        }
                    }

                }

            }
            else
            {
                txtestudiante.Text = "";
            }
        }

        private void CargarDetalleMensualidades(long pIdEstudiante)
        {
            try
            {

                //string sql = "select * from admon.ft_detalle_mensualidades_abonos_v3 (:p_id_est);";
                string sql = @"sp_detalle_mensualidades_abonos";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_est", pIdEstudiante);
                //cmd.Parameters.Add("p_id_est", PgSqlType.Int).Value = pIdEstudiante;
                dsMensualidades1.mensualidades.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMensualidades1.mensualidades);
                conn.Close();
                
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void CargarCursos(long pEstudiante)
        {
            try
            {
                //string sql = "select * from admon.ft_cursos_matriculados (:p_estudiante_id);";
                string sql = @"cursos_matriculados";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add("p_estudiante_id", PgSqlType.Int).Value = pEstudiante;
                cmd.Parameters.AddWithValue("@estudiante_id", pEstudiante);
                dsMensualidades1.cursos.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMensualidades1.cursos);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error("No se pudo cargar los cursos matriculados por el alumno!\n" + ec.Message);
            }
        }

        private void cmdGuardarProximoPago_Click(object sender, EventArgs e)
        {
            if (vEstudiante != null)
            {
                if (!string.IsNullOrEmpty(vEstudiante.Nombres))
                {
                    try
                    {
                        string sql = @"sp_update_proximo_pago";
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(sql,conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@fecha", dtFechaPagoProximo.Value);
                        cmd.Parameters.AddWithValue("@id", vEstudiante.IdEstudiante);
                        cmd.ExecuteNonQuery();
                        CajaDialogo.Information("Fecha guardada con Exito!");
                    }
                    //PgSqlTransaction tranx = psConnection.BeginTransaction();
                    //try
                    //{
                    //    string sql = @"UPDATE admon.estudiante
                    //           SET 
                    //               proxima_fecha_pago = :fecha
                    //         WHERE id_estudiante = :id;";
                    //    PgSqlCommand cmd = new PgSqlCommand(sql, psConnection);
                    //    cmd.Parameters.Add("fecha", PgSqlType.TimeStamp).Value = dtFechaPagoProximo.Value;
                    //    cmd.Parameters.Add("id", PgSqlType.Int).Value = vEstudiante.IdEstudiante;
                    //    cmd.ExecuteNonQuery();
                    //    tranx.Commit();
                    //    CajaDialogo.Information("Fecha guardada con Exito!");
                    //}
                    catch (Exception ec)
                    {
                        //tranx.Rollback();
                        CajaDialogo.Error("No se pudo actualizar la fecha de proximo pago!", ec);
                    }
                }
                else
                {
                    CajaDialogo.Error("No hay ningun Estudiante cargado!");
                }
            }
            else
            {
                CajaDialogo.Error("No hay ningun Estudiante cargado!");
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {

            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            spinDiasHabiles.Value = 0;
            txtSubtotal.Text = "0.00";
            txtDescuento.Text = "0.00";
            txtRecargos.Text = "0.00";
            txtImpuesto.Text = "0.00";
            txtestudiante.Text = "";
            vEstudiante = new Estudiante();
            txtTotal.Text = "0.00";
            txtSaldo.Text = "0.00";
            
            dtFechaLimite.Value = dp.Now();
            cbxMes.Text = "";
            timer1.Stop();
        }

        private void cmdCerrarRecibo_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void cmdNuevoRecibo_Click(object sender, EventArgs e)
        {
            txtestudiante.Text = "";
            vEstudiante = new Estudiante();
            //txtConcepto.Text = "";
            txtValorRecibo.Text = "0.00";
            VarDescuento = 0;
            VarRecargo = 0;
            VarAbono = 0;
            dsMensualidades1.mensualidades.Clear();
            //txtConcepto1.Text = "";
            timer1.Stop();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (vEstudiante == null)
            {
                CajaDialogo.Error("Es necesario cargar un estudiante para postear una mensualidad!");
                return;
            }

            if (vEstudiante.Nombres == null)
            {
                CajaDialogo.Error("Es necesario cargar un estudiante para postear una mensualidad!");
                return;
            }

            if (!vEstudiante.TieneMatricula(vEstudiante.IdEstudiante))
            {
                CajaDialogo.Error("Antes de postear una mensualidad debe Matricular el alumno seleccionado");
                return;
            }

            if (Convert.ToDecimal(txtTotal.Text) == 0)
            {
                CajaDialogo.Error("¡No puede postear Mensualidades con valor cero!");
                return;
            }

            if (cmdCursos.EditValue == null && cmdCursos.EditValue == DBNull.Value)
            {
                CajaDialogo.Error("Debe seleccionar un curso!");
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
                cmd.CommandText = "sp_mensualidades_insert";
                cmd.Connection = conn;
                cmd.Transaction = transaction;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_estudiante", vEstudiante.IdEstudiante);
                cmd.Parameters.AddWithValue("@fecha_pago", dtFechaPago.Value);
                cmd.Parameters.AddWithValue("@subtotal", Convert.ToDecimal(txtSubtotal.Text));
                cmd.Parameters.AddWithValue("@recargos", Convert.ToDecimal(txtRecargos.Text));
                cmd.Parameters.AddWithValue("@descuento", Convert.ToDecimal(txtDescuento.Text));
                cmd.Parameters.AddWithValue("@impuesto",Convert.ToDecimal(txtImpuesto.Text));
                cmd.Parameters.AddWithValue("@total", Convert.ToDecimal(txtTotal.Text));
                cmd.Parameters.AddWithValue("@id_nivel", DBNull.Value);
                cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogueado.Id);
                cmd.Parameters.AddWithValue("@concepto", "Cargo por Mensualidad del mes de " + cbxMes.Text);
                cmd.Parameters.AddWithValue("@curso_id", Convert.ToInt32(cmdCursos.EditValue));
                cmd.Parameters.AddWithValue("@recibo_s", null);
                cmd.Parameters.AddWithValue("@mes", cbxMes.Text);
                cmd.Parameters.AddWithValue("@dias_habiles", spinDiasHabiles.Value);
                cmd.Parameters.AddWithValue("@fecha_limite", dtFechaLimite.Value);

                int iMes = 0;
                switch (cbxMes.Text)
                {
                    case "Enero":
                        iMes = 1;
                        break;
                    case "Febrero":
                        iMes = 2;
                        break;
                    case "Marzo":
                        iMes = 3;
                        break;
                    case "Abril":
                        iMes = 4;
                        break;
                    case "Mayo":
                        iMes = 5;
                        break;
                    case "Junio":
                        iMes = 6;
                        break;
                    case "Julio":
                        iMes = 7;
                        break;
                    case "Agosto":
                        iMes = 8;
                        break;
                    case "Septiembre":
                        iMes = 9;
                        break;
                    case "Octubre":
                        iMes = 10;
                        break;
                    case "Noviembre":
                        iMes = 11;
                        break;
                    case "Diciembre":
                        iMes = 12;
                        break;
                    default:
                        iMes = 0;
                        break;
                }

                cmd.Parameters.AddWithValue("@mes_i", iMes);
                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                cmd.CommandText = "sp_mensualidades_update_fecha_pago";
                cmd.Connection = conn;
                cmd.Transaction = transaction;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proxima_fecha_pago", dtFechaPagoProximo.Value.AddMonths(1));
                cmd.Parameters.AddWithValue("@id_estudiante", vEstudiante.IdEstudiante);
                cmd.ExecuteNonQuery();
                
                transaction.Commit();
                Guardar = true;
                txtSaldo.Text = "0.00";

                CajaDialogo.Information("Transaccion Exitosa!");
                cmdNuevo_Click(sender, e);
                txtestudiante.Focus();
                
            }
            catch (Exception ec)
            {
                transaction.Rollback();
                CajaDialogo.Error("No se pudo guardar el posteo de mensualidad!", ec);
                Guardar = false;
            }

        }

        private void dtFechaEmisionrecibo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //txtConcepto.Focus();
                //txtConcepto.SelectAll();
            }
        }

        private void txtValorRecibo_ImeModeChanged(object sender, EventArgs e)
        {

        }

        private void txtValorRecibo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cmdGuardarRecibo_Click(sender, e);
        }

        private void cmdGuardarRecibo_Click(object sender, EventArgs e)
        {
            if (vEstudiante == null)
            {
                CajaDialogo.Error("Es necesario cargar un estudiante para postear un Recibo!");
                return;
            }

            if (vEstudiante.Nombres == null)
            {
                CajaDialogo.Error("Es necesario cargar un estudiante para postear un Recibo!");
                return;
            }

            if (Convert.ToDecimal(txtValorRecibo.Text) <= 0)
            {
                CajaDialogo.Error("No se puede emitir una factura con Valor Cero (0)!");
                txtValorRecibo.Focus();
                return;
            }

            bool PostearFactura = false;
            var gridViewx = (GridView)gridControl1.FocusedView;
            for (int i = 0; i < gridViewx.DataRowCount; i++)
            {
                DataRow row = gridViewx.GetDataRow(i);
                //row["cantidad"] = 1; 
                if (Convert.ToBoolean(row["seleccion"].ToString()))
                {
                    PostearFactura = true;
                    break;
                }
            }

            frmFacturaBK frm1 = new frmFacturaBK();
            frm1.txtCliente.Text = vEstudiante.Nombres + " " + vEstudiante.Apellidos;
            frm1.txtTelefono.Text = vEstudiante.RecuperaTelefonosConcatenadosEstudiante();
            frm1.txtDireccion.Text = vEstudiante.Direccion;
            frm1.txtRTNCLiente.Text = vEstudiante.identidad;
            frm1.txtDescuento.Text = string.Format("{0:L ###,##0.00}", VarDescuento);
            frm1.txtRecargo.Text = string.Format("{0:L ###,##0.00}", VarRecargo);
            frm1.txtSubTotal.Text = string.Format("{0:L ###,##0.00}", VarAbono);
            frm1.txtTotal.Text = string.Format("{0:L ###,##0.00}", ((VarAbono + VarRecargo) - VarDescuento));
            frm1.gridControl1.DataSource = dsMensualidades1.mensualidades;
            FacturaBK Fact1 = new FacturaBK();

            if (frm1.ShowDialog() == DialogResult.OK)
            {
                doc_fiscal doc1 = new doc_fiscal();
                //ConfiguracionSuccess conf1 = new ConfiguracionSuccess();
                ConversorNumALetras num1 = new ConversorNumALetras(((VarAbono + VarRecargo) - VarDescuento));

                if (doc1.CargarDatosFacturaSiguiente())
                {
                    Fact1.numero = doc1.NumeroFactura;
                    Fact1.rango_a = doc1.rango_inicial + " a " + doc1.rango_final;
                    Fact1.cai = doc1.cai;
                    Fact1.fecha_limite = doc1.fecha_limite_aut;
                    Fact1.fecha_emision = dp.Now();
                    Fact1.cliente = frm1.txtCliente.Text;
                    Fact1.sub = (VarAbono);
                    Fact1.descuento = VarDescuento;
                    Fact1.Recargo = VarRecargo;
                    Fact1.Saldo = Convert.ToDecimal(txtSaldo.Text);
                    Fact1.Impuesto = Convert.ToDecimal(txtImpuesto.Text);
                    Fact1.nula = false;
                    Fact1.rtn_cliente = frm1.txtRTNCLiente.Text;
                    Fact1.oc = frm1.txtOrdenCompra.Text;
                    Fact1.direccion_c = frm1.txtDireccion.Text;
                    Fact1.telefono_c = frm1.txtTelefono.Text;

                    if (frm1.toggleTipoFactura.IsOn)
                        Fact1.tipo = 1;
                    else
                        Fact1.tipo = 2;

                    Fact1.id_estudiante = vEstudiante.IdEstudiante;
                    Fact1.valor_letras = num1.NumeroEnLetras;
                    Fact1.GuardarRegistro();
                    PostearFactura = true;
                    doc1.UpdateSecuencia();
                }
            }
            else
            {
                PostearFactura = false;
            }

            if (!PostearFactura)
            {
                //CajaDialogo.Error("No hay elementos para facturar!");
                return;
            }

            SqlTransaction transaction = null;

            SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
            bool Guardar = false;

            try
            {
                conn.Open();
                transaction = conn.BeginTransaction("Transaction Order");

                var gridView1 = (GridView)gridControl1.FocusedView;

                for (int i = 0; i < gridView1.DataRowCount; i++)
                {

                    DataRow row = gridView1.GetDataRow(i);
                    int id = Convert.ToInt32(row["id"]);

                    decimal abono = 0;
                    decimal descuento = 0;
                    decimal recargo = 0;

                    if (Convert.ToBoolean(row["seleccion"].ToString()))
                    {
                        try
                        {
                            abono = Convert.ToDecimal(row["abono"]);
                            descuento = Convert.ToDecimal(row["descuento"]);
                            recargo = Convert.ToDecimal(row["recargo"]);
                        }
                        catch { }

                        SqlCommand cmd = conn.CreateCommand();

                        if (abono > 0)
                        {
                            
                            
                            cmd.CommandText = "sp_mensualidad_insert_abono_estudiante";
                            cmd.Connection = conn;
                            cmd.Transaction = transaction;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_mens",id);
                            cmd.Parameters.AddWithValue("@cargo",0);
                            cmd.Parameters.AddWithValue("@credito", (abono + recargo));
                            cmd.ExecuteNonQuery();

                            cmd.Parameters.Clear();
                            cmd.CommandText = "sp_mensualidad_insert_recibo";
                            cmd.Connection = conn;
                            cmd.Transaction = transaction;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@valor",(abono - descuento));
                            cmd.Parameters.AddWithValue("@fecha_posteo", dtFechaEmisionrecibo.Value);
                            cmd.Parameters.AddWithValue("@id_usuario",this.UsuarioLogueado.Id);
                            cmd.Parameters.AddWithValue("@concepto", "Abono");
                            cmd.Parameters.AddWithValue("@id_estudiante",vEstudiante.IdEstudiante);
                            cmd.ExecuteNonQuery();

                            if (descuento > 0)
                            {
                                cmd.Parameters.Clear();
                                cmd.CommandText = "sp_mensualidad_insert_abono_estudiante_recibo_descuento";
                                cmd.Connection = conn;
                                cmd.Transaction = transaction;
                                cmd.CommandType = CommandType.StoredProcedure;
                                //Abono Estudiante con Descuento
                                cmd.Parameters.AddWithValue("@id_mens",id);
                                cmd.Parameters.AddWithValue("@cargo",0);
                                cmd.Parameters.AddWithValue("@credito",descuento);
                                //Recibo + Descuento
                                cmd.Parameters.AddWithValue("@valor",descuento);
                                cmd.Parameters.AddWithValue("@fecha_posteo",dtFechaEmisionrecibo.Value);
                                cmd.Parameters.AddWithValue("@id_usuario",this.UsuarioLogueado.Id);
                                cmd.Parameters.AddWithValue("@concepto","Descuento");
                                cmd.Parameters.AddWithValue("@id_estudiante", vEstudiante.IdEstudiante);
                                cmd.ExecuteNonQuery();
                            }

                            if (recargo > 0)
                            {
                                //Vamos hacer el update de recargo en la mensualidad
                                cmd.Parameters.Clear();
                                cmd.CommandText = "sp_mensualidad_update_de_recargo";
                                cmd.Connection = conn;
                                cmd.Transaction = transaction;
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@recargos", recargo);
                                cmd.Parameters.AddWithValue("@id_mensualidad", id);
                                cmd.ExecuteNonQuery();

                                cmd.Parameters.Clear();
                                cmd.CommandText = "sp_mensualidad_posteo_de_recargo_pago";
                                cmd.Connection = conn;
                                cmd.Transaction = transaction;
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@valor", recargo);
                                cmd.Parameters.AddWithValue("@fecha_posteo",  dtFechaEmisionrecibo.Value);
                                cmd.Parameters.AddWithValue("@id_usuario", this.UsuarioLogueado.Id);
                                cmd.Parameters.AddWithValue("@concepto", "Recargo");
                                cmd.Parameters.AddWithValue("@id_estudiante", vEstudiante.IdEstudiante);
                                cmd.ExecuteNonQuery();

                            }

                        }
                        else
                        {
                            throw new Exception("Ingrese un valor mayor a cero en las casillas seleccionadas!");
                        }


                        //Insert Factura Detalle

                        cmd.Parameters.Clear();
                        cmd.CommandText = "sp_insert_factura_detalle";
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_factura",Fact1.id);
                        cmd.Parameters.AddWithValue("@descripcion", row["mes"].ToString());
                        cmd.Parameters.AddWithValue("@id_mensualidad",id);
                        cmd.Parameters.AddWithValue("@precio",abono);
                        cmd.Parameters.AddWithValue("@descuento", descuento);
                        cmd.Parameters.AddWithValue("@recargo", recargo);
                        cmd.ExecuteNonQuery();
                    }
             
                }
                transaction.Commit();
                CajaDialogo.Information("Transaccion exitosa!");
                Guardar = true;
                txtSaldo.Text = "0.00";
                cmdNuevoRecibo_Click(sender, e);
            }
            catch (Exception ec)
            {
                transaction.Rollback();
                CajaDialogo.Error("No se pudo guardar el abono!\n", ec);
                Guardar = false;
            }

        }

        private void cmdGuardarRecibo_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                decimal a = Convert.ToDecimal(txtValorRecibo.Text);
                CalcularTotal();
            }
            catch
            {
                CajaDialogo.Error("El valor ingresado es incorrecto, verifiquelo!\nRecuerde ingresar el valor sin puntos ni comas");
                txtValorRecibo.Focus();
                txtValorRecibo.SelectAll();
            }
        }

        public void CalcularTotal()
        {
            txtTotal.Text = ((Convert.ToDecimal(txtSubtotal.Text) - Convert.ToDecimal(txtDescuento.Text)) + (Convert.ToDecimal(txtRecargos.Text)) + (Convert.ToDecimal(txtImpuesto.Text))).ToString();
        }

        private void ItemCheckEditSeleccion_CheckedChanged(object sender, EventArgs e)
        {
            decimal total = 0;
            var gridView = (GridView)gridControl1.FocusedView;

            var actual = (dsMensualidades.mensualidadesRow)gridView.GetFocusedDataRow();
            bool seleccion = actual.seleccion;
            if (seleccion)
                actual.seleccion = false;
            else
                actual.seleccion = true;

            //txtConcepto.Text = "Pago mes de ";
            //for (int i = 0; i < gridView1.DataRowCount; i++)
            //{
            //    DataRow row = gridView1.GetDataRow(i);
            //    if (Convert.ToBoolean(row["seleccion"]))
            //    {
            //        txtConcepto.Text += row["mes"].ToString() + " ";
            //        total += Convert.ToDecimal(row["valor"].ToString());
            //    }
            //}
            txtValorRecibo.Text = total.ToString();
        }

        private void button_delete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult r = CajaDialogo.Pregunta("¿Confirma que desea eliminar este elemento?");
            if (r != System.Windows.Forms.DialogResult.Yes)
                return;

            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsMensualidades.mensualidadesRow)gridView.GetFocusedDataRow();

            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_mensualidades_delete_saldos_pago", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", row.id);
                cmd.ExecuteNonQuery();

                CajaDialogo.Information("Transaccion Exitosa!");
                cmdRecargarSaldo_Click(sender, new EventArgs());
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

            //PgSqlTransaction tran1 = psConnection.BeginTransaction();
            //try
            //{
            //    string sql = @"DELETE FROM admon.mensualidades_saldos 
            //                    WHERE id_mensualidad = :id;";

            //    string sql2 = @"DELETE FROM admon.pago 
            //                    WHERE id_mensualidad = :id;";

            //    string sql3 = @"DELETE FROM admon.mensualidades 
            //                    WHERE id_mensualidad = :id;";

            //    PgSqlCommand cmd = new PgSqlCommand(sql, psConnection);
            //    PgSqlCommand cmd2 = new PgSqlCommand(sql2, psConnection);
            //    PgSqlCommand cmd3 = new PgSqlCommand(sql3, psConnection);

            //    cmd.Parameters.Add("id", PgSqlType.Int).Value = row.id;
            //    cmd2.Parameters.Add("id", PgSqlType.Int).Value = row.id;
            //    cmd3.Parameters.Add("id", PgSqlType.Int).Value = row.id;

            //    cmd.ExecuteNonQuery();
            //    cmd2.ExecuteNonQuery();
            //    cmd3.ExecuteNonQuery();

            //    tran1.Commit();
            //    CajaDialogo.Information("Transaccion Exitosa!");
            //    cmdRecargarSaldo_Click(sender, new EventArgs());
            //}
            //catch (Exception ec)
            //{
            //    tran1.Rollback();
            //    CajaDialogo.Error(ec.Message);
            //}
        }

        private void txtestudiante_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                frmBuscarEstudiantes fx1 = new frmBuscarEstudiantes();
                if (fx1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    if (vEstudiante.RecuperarRegistro(fx1.ItemSeleccionado.id_estudiantes))
                    {
                        txtestudiante.Text = vEstudiante.Nombres + " " + vEstudiante.Apellidos;
                        if (vEstudiante.FechaProximoPago.ToString() == "1/1/0001 12:00:00 AM")
                        {
                            dtFechaPagoProximo.Value = DateTime.Now;
                        }
                        else
                        {
                            dtFechaPagoProximo.Value = vEstudiante.FechaProximoPago;
                        }

                        if (vEstudiante != null)
                        {
                            if (vEstudiante.IdEstudiante > 0)
                            {
                                CargarCursos(vEstudiante.IdEstudiante);
                                Saldos sal = new Saldos();
                                CargarDetalleMensualidades(vEstudiante.IdEstudiante);
                                decimal dsal = sal.ConsultarSaldo(vEstudiante.IdEstudiante);
                                if (dsal == 0)
                                    txtSaldo.Text = "0";
                                else
                                    if (dsal > 1000)
                                    txtSaldo.Text = String.Format("{0:0,000.00}", dsal);
                                else
                                    txtSaldo.Text = String.Format("{0:00.00}", dsal);
                            }
                        }
                    }
                }
                else
                {
                    txtestudiante.Text = "";
                }
            }
        }

        private void cbxMes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                dtFechaPago.Focus();
        }

        private void cbxMes_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtFechaPago_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                spinDiasHabiles.Focus();
            }
        }

        private void spinDiasHabiles_ValueChanged(object sender, EventArgs e)
        {
            if (spinDiasHabiles.Value > V_Dias)//incremento
            {
                DateTime data = Convert.ToDateTime(dtFechaPago.Value);
                dtFechaLimite.Value = data.AddDays(Convert.ToInt32(spinDiasHabiles.Value));
                V_Dias = Convert.ToInt32(spinDiasHabiles.Value);
            }
            else
            {
                //resto
                DateTime data = Convert.ToDateTime(dtFechaPago.Value);
                dtFechaLimite.Value = data.AddDays(Convert.ToInt32(spinDiasHabiles.Value));
                V_Dias = Convert.ToInt32(spinDiasHabiles.Value);
            }
        }

        private void cmdCursos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtSubtotal.Focus();
        }

        private void txtSubtotal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDescuento.Focus();
                txtDescuento.SelectAll();
            }
        }

        private void txtSubtotal_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                decimal a = Convert.ToDecimal(this.txtSubtotal.Text);
                CalcularTotal();
            }
            catch
            {
                CajaDialogo.Error("El valor ingresado es incorrecto, verifiquelo!\nRecuerde ingresar el valor sin puntos ni comas");
                txtSubtotal.Focus();
                txtSubtotal.SelectAll();
            }
        }

        private void txtDescuento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtRecargos.Focus();
                txtRecargos.SelectAll();
            }
        }

        private void txtDescuento_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                decimal a = Convert.ToDecimal(this.txtDescuento.Text);
                CalcularTotal();
            }
            catch
            {
                CajaDialogo.Error("El valor ingresado es incorrecto, verifiquelo!\nRecuerde ingresar el valor sin puntos ni comas");
                txtDescuento.Focus();
                txtDescuento.SelectAll();
            }
        }

        private void txtRecargos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtImpuesto.Focus();
                txtImpuesto.SelectAll();
            }
        }

        private void txtRecargos_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                decimal a = Convert.ToDecimal(this.txtRecargos.Text);
                CalcularTotal();
            }
            catch
            {
                CajaDialogo.Error("El valor ingresado es incorrecto, verifiquelo!\nRecuerde ingresar el valor sin puntos ni comas");
                txtRecargos.Focus();
                txtRecargos.SelectAll();
            }
        }

        private void txtImpuesto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmdGuardar.Focus();
            }
        }

        private void txtImpuesto_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                decimal a = Convert.ToDecimal(txtImpuesto.Text);
                CalcularTotal();
            }
            catch
            {
                CajaDialogo.Error("El valor ingresado es incorrecto, verifiquelo!\nRecuerde ingresar el valor sin puntos ni comas");
                txtImpuesto.Focus();
                txtImpuesto.SelectAll();
            }
        }
    }
}