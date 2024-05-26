using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BrewHouse
{
    class customerDB
    {
        private SqlConnection con;
        private SqlCommand cmd;

        public customerDB()
        {
            con = new SqlConnection("Data Source=DESKTOP-376L562;Initial Catalog=BrewHouse;Integrated Security=True");
        }

        public void openconnection()
        {
            con.Open();
        }

        public void closeconnection()
        {
            con.Close();
        }

        public int save_update_delete(string a)
        {
            openconnection();
            cmd = new SqlCommand(a, con);
            int i = cmd.ExecuteNonQuery();
            closeconnection();
            return i;
        }
    }
}
