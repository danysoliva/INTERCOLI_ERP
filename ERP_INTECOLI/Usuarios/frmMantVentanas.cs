﻿using DevExpress.XtraEditors;
using ERP_INTECOLI.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_INTECOLI.Usuarios
{
    public partial class frmMantVentanas : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public frmMantVentanas()
        {
            InitializeComponent();

            cargar_dats();
        }

        private void cargar_dats()
        {
            try
            {
                string query = @"sp_usuarios_get_autorizacion";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsUsuarios1.autorizaciones.Clear();
                adat.Fill(dsUsuarios1.autorizaciones);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdCargarDatos_Click(object sender, EventArgs e)
        {
            cargar_dats();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            frmManVentanasOP frm = new frmManVentanasOP();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                cargar_dats();
            }
        }
    }
}