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
using ERP_INTECOLI.Administracion.Caja;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace ERP_INTECOLI.Administracion.Caja
{
    public partial class frmArqueoCaja : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin usuariologueado;
        public frmArqueoCaja(UserLogin pUserLog)
        {
            InitializeComponent();
            usuariologueado = pUserLog;
            dtFechaBoletas.EditValue = dtFechaFacturas.EditValue = dtFechaNulas.EditValue = dp.Now();
            LoadData(1, Convert.ToDateTime(dtFechaFacturas.EditValue));
            LoadData(2, Convert.ToDateTime(dtFechaFacturas.EditValue));
            LoadData(3, Convert.ToDateTime(dtFechaNulas.EditValue));
            LoadData(4, Convert.ToDateTime(dtFechaBoletas.EditValue));
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            LoadData(1, Convert.ToDateTime(dtFechaFacturas.EditValue));
            LoadData(2, Convert.ToDateTime(dtFechaFacturas.EditValue));
        }

        private void LoadData(int pIdTipo, DateTime pFecha)
        {
            try
            {
                //string sql = @"select * from admon.ft_get_data_arqueo (:pid_tipo, :pfecha);";
                string sql = @"sp_get_data_arqueo";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_tipo", pIdTipo);
                cmd.Parameters.AddWithValue("@fecha", pFecha);
                switch (pIdTipo)
                {
                    case 1:
                        dsCaja1.efectivo.Clear();
                        SqlDataAdapter adat = new SqlDataAdapter(cmd);
                        adat.Fill(dsCaja1.efectivo);
                        grEfectivo.RefreshDataSource();

                        var gridView = (GridView)grEfectivo.FocusedView;
                        decimal total = 0;

                        for (int i = 0; i < gridView.DataRowCount; i++)
                        {
                            DataRow row = gridView.GetDataRow(i);
                            try
                            {
                                //abono
                                total += Convert.ToDecimal(row["monto"]);
                            }
                            catch { }
                        }
                        txtTotalEfectivo.Text = String.Format("{0:##,##0.00}", total);
                        break;
                    case 2:
                        dsCaja1.tarjeta.Clear();
                        SqlDataAdapter adat2 = new SqlDataAdapter(cmd);
                        adat2.Fill(dsCaja1.tarjeta);
                        grTarjetas.RefreshDataSource();

                        var gridView1 = (GridView)grTarjetas.FocusedView;
                        decimal total1 = 0;

                        for (int i = 0; i < gridView1.DataRowCount; i++)
                        {
                            DataRow row = gridView1.GetDataRow(i);
                            try
                            {
                                //abono
                                total1 += Convert.ToDecimal(row["monto"]);
                            }
                            catch { }
                        }
                        txtTotalTarjeta.Text = String.Format("{0:0,000.00}", total1);
                        break;
                    case 3:
                        dsCaja1.nulas.Clear();
                        SqlDataAdapter adat3 = new SqlDataAdapter(cmd);
                        adat3.Fill(dsCaja1.nulas);
                        grNulas.RefreshDataSource();

                        var gridView3 = (GridView)grNulas.FocusedView;
                        decimal total3 = 0;

                        for (int i = 0; i < gridView3.DataRowCount; i++)
                        {
                            DataRow row = gridView3.GetDataRow(i);
                            try
                            {
                                //abono
                                total3 += Convert.ToDecimal(row["monto"]);
                            }
                            catch { }
                        }
                        txtTotalNulas.Text = String.Format("{0:0,000.00}", total3);
                        break;
                    case 4:
                        dsCaja1.boletas.Clear();
                        SqlDataAdapter adat4 = new SqlDataAdapter(cmd);
                        adat4.Fill(dsCaja1.boletas);
                        grBoletas.RefreshDataSource();

                        var gridView4 = (GridView)grBoletas.FocusedView;
                        decimal total4 = 0;

                        for (int i = 0; i < gridView4.DataRowCount; i++)
                        {
                            DataRow row = gridView4.GetDataRow(i);
                            try
                            {
                                //abono
                                total4 += Convert.ToDecimal(row["monto"]);
                            }
                            catch { }
                        }
                        txtTotalBoleta.Text = String.Format("{0:0,000.00}", total4);
                        break;
                }
                //cmd.ExecuteScalar();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            LoadData(3, Convert.ToDateTime(dtFechaNulas.EditValue));
        }

        private void cmdRefreshBoletas_Click(object sender, EventArgs e)
        {
            LoadData(4, Convert.ToDateTime(dtFechaBoletas.EditValue));
        }
    }
}