using BrewHouse.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BrewHouse.Components
{

    public partial class widget : UserControl
    {
        cart cc = new cart();
        //CoffeeDB db = new CoffeeDB();
        //int price, qty;

        public string ItemId { get; set; }
        public Image ItemImage
        {
            get { return btn_item.StateCommon.Back.Image; }
            set { btn_item.StateCommon.Back.Image = value; }
        }
        public string ItemName
        {
            get { return lbl_title.Text; }
            set { lbl_title.Text = value; }
        }
        public string ItemPrice
        {
            get { return lbl_cost.Text; }
            set { lbl_cost.Text = value; }
        }
        public string btnitem
        {
            get { return btn_item.Name; }
            set { btn_item.Name = value; }
        }

        public widget()
        {
            InitializeComponent();
        }
        

        private void btn_item_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(ItemName, ItemPrice);
            //string query1 = "select coffee_name from coffee";
            //string query1 = "insert into temCoffe(coffee_name,coffee_price) values('" + ItemName + "','" + ItemPrice + "')";
            //int i = db.add_update_remove(query1);
            //if (i == 1)
            //{
            //    //MessageBox.Show("Data save Successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    //dataGridView2.da.DataSource = db.getData("select * from temCoffe");
            //    Home.instance.dataGridView2.DataSource = db.getData("select * from temCoffe");
            //    //price = Convert.ToInt32(Home.instance.dataGridView2.CurrentRow.Cells["coffee_price"].Value);
            //    //qty = Convert.ToInt32(Home.instance.dataGridView2.CurrentRow.Cells["QTY"].Value);
            //    //Home.instance.dataGridView2.CurrentRow.Cells["cost"].Value=price*qty;
                
            //}


            //else
            //    MessageBox.Show("Data can't save", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
