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

namespace merescs
{
    public partial class MainForm : Form
    {
        public string ConnectionString { get; set; }
        public MainForm()
        {
            ConnectionString =
                "Server=(localdb)\\MSSQLLocalDB;" +
                "Database=palyazatok;";

            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUjp_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
