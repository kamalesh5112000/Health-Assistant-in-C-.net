using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace MyHealth
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            SqlConnection con = new SqlConnection("Data Source=KAMALESH;Initial Catalog=userdata;User ID=kamalesh;Password=kamal@2000");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from userregister where  Username='" + username + "' and Password='" + password + "'",con);
            SqlDataReader da = cmd.ExecuteReader();

            while (da.Read())
            {
                tbname.Text = da.GetValue(1).ToString();
                tbemail.Text = da.GetValue(2).ToString();
                tbphone.Text = da.GetValue(3).ToString();
                tbbloodgrp.Text = da.GetValue(4).ToString();
                tbgender.Text = da.GetValue(5).ToString();
                tbdob.Text = da.GetValue(6).ToString();
                tbaddress.Text = da.GetValue(7).ToString();
                tbusername.Text = da.GetValue(8).ToString();
                tbpassword.Text = da.GetValue(9).ToString();

            }

            con.Close();
        }
    }
}
