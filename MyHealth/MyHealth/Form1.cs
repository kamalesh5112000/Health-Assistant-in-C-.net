using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using BEL;


namespace MyHealth
{
    public partial class Form1 : Form
    {
        public Information info = new Information();
        public Operations opr = new Operations();
        public string utype;

        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            userregistrationform urf = new userregistrationform();
            urf.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            info.username = tbusername.Text;
            info.password = tbpassword.Text;

            dt = opr.login(info);

            if(dt.Rows.Count>0)
            {
                utype = dt.Rows[0][10].ToString().Trim();
                if(utype=="A")
                {
                    this.Hide();
                    AdminForm userf = new AdminForm();
                    userf.Show();
                }
                else
                {
                    this.Hide();
                    Userform uf = new Userform();
                    uf.Show();
                }
                
            }
            else
            {
                MessageBox.Show("Username or Password Inccorrect");
            }


        }
    }
}
