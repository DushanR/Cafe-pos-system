using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrewHouse.Components;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;


namespace BrewHouse.Helpers
{
    class ItemCartHelper
    {
        static string conString = "Data Source=DESKTOP-376L562;Initial Catalog=BrewHouse;Integrated Security=True";

        SqlCommand cmd;
        SqlConnection conn;
        SqlDataReader reader;

        public ItemCartHelper()
        {
            conn = new SqlConnection(conString);
            cmd = new SqlCommand();
        }
        public bool connect()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool disconnect()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public string getButtons(string query, FlowLayoutPanel panel)
        {
            string ret = "";

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = query.ToLower();
                connect();

                reader = cmd.ExecuteReader();

                string name, price;


                while (reader.Read())
                {

                    name = reader[0].ToString();
                    price = reader[1].ToString();


                    Cartitem btn = new Cartitem();

                    btn.ItemName = name;
                    btn.ItemPerUnitPrice = "Rs." + price;

                    if (name != string.Empty)
                    {
                        panel.Controls.Add(btn);
                    }

                    ret = "Data Fetched Successfully.. :)";
                }
            }
            catch (Exception ex)
            {
                ret = ex.Message;
                throw;
            }
            finally
            {
                disconnect();
            }
            return ret;
        }
    }
}
