using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BEL;
using BAL;

namespace MyHealth
{
    public partial class userviewform : Form
    {
        public Operations opr = new Operations();
        public Information info = new Information();
        public userviewform()
        {
            InitializeComponent();
        }

        private void userviewform_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = opr.viewusers(info);
            dgvusers.DataSource = dt;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminForm af = new AdminForm();
            af.Show();
        }
    }
}
