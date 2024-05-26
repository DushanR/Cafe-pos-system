using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BrewHouse
{
    class CoffeeDB
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter da;

        public CoffeeDB()
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

        public int add_update_remove(string a)
        {
            openconnection();
            cmd = new SqlCommand(a, con);
            int i = cmd.ExecuteNonQuery();
            closeconnection();
            return i;
        }

        public string select(string a)
        {
            openconnection();
            string d = "";
            cmd = new SqlCommand(a, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while(rdr.Read())
            {
                d = rdr.GetValue(0).ToString();
            }
            return d;
        }

        public DataTable getData(string q)
        {
            openconnection();
            da = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            closeconnection();
            return dt;
        }
    }
}
