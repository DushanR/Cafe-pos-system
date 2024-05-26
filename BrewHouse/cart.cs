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
    class cart
    {
        public string getButtons(FlowLayoutPanel panel)
        {
            string ret = "";

            try
            {
                widget btn = new widget();

                string btnname, price;
                btnname = btn.btnitem;
                price = btn.ItemPrice;

                Cartitem btnc = new Cartitem();

                btnc.ItemName = btnname;
                btnc.ItemPerUnitPrice = price;


                if (btnname != string.Empty)
                {
                    panel.Controls.Add(btnc);
                }
                Home obj = new Home();
                obj.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Check aganin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ret;
            
        }
    }
}
