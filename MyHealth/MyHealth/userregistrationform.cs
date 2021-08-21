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
    public partial class userregistrationform : Form
    {
        public Information info = new Information();
        public Operations opr = new Operations();

        string gender;
        public userregistrationform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            info.name = tbname.Text;
            info.email = tbemail.Text;
            info.phone = tbphone.Text;
            info.cgpa = tbbloodgrp.Text;
            if(rbmale.Checked==true)
            {
                gender = "Male";
            }
            if(rbfemale.Checked==true)
            {
                gender="Female";
            }
            info.gender = gender;
            info.dob = Convert.ToString(dateTimePicker1.Value.ToShortDateString());
            info.address = tbaddress.Text;
            info.username = tbusername.Text;
            info.password = tbpassword.Text;

            int rows =opr.insertuser(info);
            if(rows > 0)
            {
                MessageBox.Show("Data Saved Successfully");
            }
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();


        }
    }
}
