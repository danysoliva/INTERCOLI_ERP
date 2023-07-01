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
using ERP_INTECOLI.Clases;

namespace ERP_INTECOLI
{
    public partial class Form1 : Form
    {
        DataOperations dp = new DataOperations();
        public Form1()
        {
            InitializeComponent();

            SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
            conn.Open();

            SqlCommand cmd = new SqlCommand("");
        }
    }
}
