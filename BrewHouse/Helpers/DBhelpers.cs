using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BrewHouse.Components;
using System.Drawing;
using System.IO;


namespace BrewHouse
{
    class DBhelper
    {

        static string conString = "Data Source=DESKTOP-376L562;Initial Catalog=BrewHouse;Integrated Security=True";

        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader reader;

        public DBhelper()
        {
            con = new SqlConnection(conString);
            cmd = new SqlCommand();
        }
        public bool connect()
        {
            try
            {
                con.Open();
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
                con.Close();
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
                cmd.Connection = con;
                cmd.CommandText = query.ToLower();
                connect();

                reader = cmd.ExecuteReader();

                string name, price, image , imagepath;

                while (reader.Read())
                {
                    widget btn = new widget();

                    name = reader[0].ToString();
                    price = reader[1].ToString();
                    image = reader[2].ToString();
                    imagepath = reader[2].ToString();
                    {
                        if(image != "")
                        {
                            btn.ItemImage = Image.FromFile(image);
                        }
                    }

                    btn.btnitem = name; 
                    btn.ItemName = name;
                    btn.ItemPrice = price;

                    if (name != string.Empty)
                    {
                        panel.Controls.Add(btn);
                    }


                    ret = "Data Fetched Successfully.. :)";
                }


            }
            catch
            {
                MessageBox.Show("Check aganin","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                disconnect();
            }
            return ret;
        }
    }
}
