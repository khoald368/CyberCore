using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CyberCore.DataMining;

namespace SampleApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private async void btnTest_Click(object sender, EventArgs e)
        {
            var conn = "Data Source=SQL5108.site4now.net;Initial Catalog=db_a7d12c_base;User Id=db_a7d12c_base_admin;Password=aassdd11;TrustServerCertificate=True;";
            ISqlClient sql = new SqlClient();
            var z = await sql.QuerySingleOrDefaultAsync<string>(conn, "select top 1 fullname from customers;");
            txtInput.Text = z.ToString();
        }
    }
}
