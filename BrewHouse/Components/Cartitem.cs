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
    public partial class Cartitem : UserControl
    {
        public string ItemId { get; set; }
        public string ItemPerUnitPrice
        {
            get { return lbl_itemperunit.Text; }
            set { lbl_itemperunit.Text = value; }
        }
        public string ItemName
        {
            get { return lbl_itemname.Text; }
            set { lbl_itemname.Text = value; }
        }
        public string ItemPrice
        {
            get { return lbl_cost.Text; }
            set { lbl_cost.Text = value; }
        }
        public string Itemqty
        {
            get { return lbl_qty.Text; }
            set { lbl_qty.Text = value; }
        }

        public Cartitem()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(lbl_qty.Text);
            if( i < 99 )
            i = i + 1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void lbl_itemperunit_Click(object sender, EventArgs e)
        {

        }
    }
}
