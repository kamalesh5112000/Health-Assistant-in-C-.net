using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHealth
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void registeredUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userviewform uvf = new userviewform();
            uvf.MdiParent = this;
            uvf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            userviewform uvf = new userviewform();
            uvf.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Booking bk = new Booking();
            bk.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            viewcompany vc = new viewcompany();
            vc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addcompany ac = new addcompany();
            ac.Show();

        }
    }
}
