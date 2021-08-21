using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyHealth
{
    public partial class addcompany : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=Kamalesh;Initial Catalog=placement;Integrated Security=True");

        public addcompany()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmmd = con.CreateCommand();
            cmmd.CommandType = CommandType.Text;
            cmmd.CommandText = "insert into company values('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"')";
            cmmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Company Added");
        }
    }
}
