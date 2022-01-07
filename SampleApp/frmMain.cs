using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SampleApp.CyberCore;

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
            ISqlClient sql = new SqlClient("Server=.\\SQL2019; Database=Sample; User Id=sa; Password=aassdd11;TrustServerCertificate=True");


            var z = await sql.QuerySingleOrDefaultAsync<DateTime>("select getdate();");
        }
    }
}
