using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BEL;
using System.Data;
using System.Data.SqlClient;

namespace BAL
{
    public class Operations
    {
        public Dbconnection db = new Dbconnection();
        public Information info = new Information();

        public int insertuser(Information info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO logindatails VALUES ('"+info.name+"','"+info.email+"','"+info.phone+"','"+info.cgpa+"','"+info.gender+"','"+info.dob+"','"+info.address+"','"+info.username+"','"+info.password+"','U')";
            return db.ExeNonQuery(cmd);
        }

        public DataTable viewusers(Information info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from logindatails where Usertype='U'";
            return db.ExeReader(cmd);
        }

        public DataTable login(Information info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from logindatails where Username='"+info.username+"' and Password='"+info.password+"'";
            return db.ExeReader(cmd);

        }
    }
}
