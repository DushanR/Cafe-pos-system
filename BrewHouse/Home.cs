using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrewHouse.Components;
using ComponentFactory.Krypton.Toolkit;
using System.Data.SqlClient;

namespace BrewHouse
{
    public partial class Home : KryptonForm
    {
        DBhelper db;
        customerDB dc = new customerDB();
        public Home()
        {
            InitializeComponent();
            SetHeight(listView1, 30);
            db = new DBhelper();
        }
        CoffeeDB cdb = new CoffeeDB();

        private void SetHeight(ListView listView, int height)
        {
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, height);
            listView.SmallImageList = imgList;
        }

        //.......................................................................................................................//

        //connetction string for auto increment Invoice No......
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-376L562;Initial Catalog=BrewHouse;Integrated Security=True");
        

        //Home load and visible all items in panel
        private void Home_Load(object sender, EventArgs e)
        {
            timer1.Start();
            panel_all_item.Visible = true;
            panel_all_item.Controls.Clear();
            db.getButtons("select * from coffee", panel_all_item);
            db.getButtons("select * from sweets", panel_all_item);
            db.getButtons("select * from sandwich", panel_all_item);
            db.getButtons("select * from BrewSp", panel_all_item);

            string sqlquery = "SELECT * FROM coffee";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, con);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            combo_coffee.ValueMember = "coffee_name";
            combo_coffee.DisplayMember = "coffee_name";
            combo_coffee.DataSource = dt;
            con.Close();

            string sqlquery1 = "SELECT * FROM sweets";
            SqlCommand sqlcomm1 = new SqlCommand(sqlquery1, con);
            SqlDataAdapter sda1 = new SqlDataAdapter(sqlcomm1);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            combo_sweet.ValueMember = "sweet_name";
            combo_sweet.DisplayMember = "sweet_name";
            combo_sweet.DataSource = dt1;
            con.Close();

            string sqlquery2 = "SELECT * FROM sandwich";
            SqlCommand sqlcomm2 = new SqlCommand(sqlquery2, con);
            SqlDataAdapter sda2 = new SqlDataAdapter(sqlcomm2);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            combo_sandwich.ValueMember = "sandwich_name";
            combo_sandwich.DisplayMember = "sandwich_name";
            combo_sandwich.DataSource = dt2;
            con.Close();

            string sqlquery3 = "SELECT * FROM BrewSp";
            SqlCommand sqlcomm3 = new SqlCommand(sqlquery3, con);
            SqlDataAdapter sda3 = new SqlDataAdapter(sqlcomm3);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            combo_brew.ValueMember = "brew_name";
            combo_brew.DisplayMember = "brew_name";
            combo_brew.DataSource = dt3;
            con.Close();

            txtitemcost.Text = "";
        }

        

        //All items visible true
        private void btn_allitems_Click(object sender, EventArgs e)
        {
            panel_all_item.Visible = true;
            panel_all_item.Controls.Clear();
            db.getButtons("select * from coffee", panel_all_item);
            db.getButtons("select * from sweets", panel_all_item);
            db.getButtons("select * from sandwich", panel_all_item);
            db.getButtons("select * from BrewSp", panel_all_item);

            btn_coffee.StateNormal.Back.Color1 = Color.Transparent;
            btn_coffee.StateNormal.Back.Color2 = Color.Transparent;
            btn_coffee.StateNormal.Border.Color1 = Color.Transparent;
            btn_coffee.StateNormal.Border.Color2 = Color.Transparent;
            btn_sweets.StateNormal.Back.Color1 = Color.Transparent;
            btn_sweets.StateNormal.Back.Color2 = Color.Transparent;
            btn_sweets.StateNormal.Border.Color1 = Color.Transparent;
            btn_sweets.StateNormal.Border.Color2 = Color.Transparent;
            btn_sandwiches.StateNormal.Back.Color1 = Color.Transparent;
            btn_sandwiches.StateNormal.Back.Color2 = Color.Transparent;
            btn_sandwiches.StateNormal.Border.Color1 = Color.Transparent;
            btn_sandwiches.StateNormal.Border.Color2 = Color.Transparent;
            btn_bspecial.StateNormal.Back.Color1 = Color.Transparent;
            btn_bspecial.StateNormal.Back.Color2 = Color.Transparent;
            btn_bspecial.StateNormal.Border.Color1 = Color.Transparent;
            btn_bspecial.StateNormal.Border.Color2 = Color.Transparent;
        }

        //All Coffee items visible true
        private void btn_coffee_Click(object sender, EventArgs e)
        {
            btn_coffee.StateNormal.Back.Color1 = Color.LightGray;
            btn_coffee.StateNormal.Back.Color2 = Color.LightGray;
            btn_coffee.StateNormal.Border.Color1 = Color.Red;
            btn_coffee.StateNormal.Border.Color2 = Color.Red;
            btn_sweets.StateNormal.Back.Color1 = Color.Transparent;
            btn_sweets.StateNormal.Back.Color2 = Color.Transparent;
            btn_sweets.StateNormal.Border.Color1 = Color.Transparent;
            btn_sweets.StateNormal.Border.Color2 = Color.Transparent;
            btn_sandwiches.StateNormal.Back.Color1 = Color.Transparent;
            btn_sandwiches.StateNormal.Back.Color2 = Color.Transparent;
            btn_sandwiches.StateNormal.Border.Color1 = Color.Transparent;
            btn_sandwiches.StateNormal.Border.Color2 = Color.Transparent;
            btn_bspecial.StateNormal.Back.Color1 = Color.Transparent;
            btn_bspecial.StateNormal.Back.Color2 = Color.Transparent;
            btn_bspecial.StateNormal.Border.Color1 = Color.Transparent;
            btn_bspecial.StateNormal.Border.Color2 = Color.Transparent;

            panel_all_item.Visible = true;
            panel_all_item.Controls.Clear();
            db.getButtons("select * from coffee ", panel_all_item);
        }

        //All Sweet items visible true
        private void btn_sweets_Click(object sender, EventArgs e)
        {
            btn_sweets.StateNormal.Back.Color1 = Color.LightGray;
            btn_sweets.StateNormal.Back.Color2 = Color.LightGray;
            btn_sweets.StateNormal.Border.Color1 = Color.Red;
            btn_sweets.StateNormal.Border.Color2 = Color.Red;
            btn_coffee.StateNormal.Back.Color1 = Color.Transparent;
            btn_coffee.StateNormal.Back.Color2 = Color.Transparent;
            btn_coffee.StateNormal.Border.Color1 = Color.Transparent;
            btn_coffee.StateNormal.Border.Color2 = Color.Transparent;
            btn_sandwiches.StateNormal.Back.Color1 = Color.Transparent;
            btn_sandwiches.StateNormal.Back.Color2 = Color.Transparent;
            btn_sandwiches.StateNormal.Border.Color1 = Color.Transparent;
            btn_sandwiches.StateNormal.Border.Color2 = Color.Transparent;
            btn_bspecial.StateNormal.Back.Color1 = Color.Transparent;
            btn_bspecial.StateNormal.Back.Color2 = Color.Transparent;
            btn_bspecial.StateNormal.Border.Color1 = Color.Transparent;
            btn_bspecial.StateNormal.Border.Color2 = Color.Transparent;

            panel_all_item.Visible = true;
            panel_all_item.Controls.Clear();
            db.getButtons("select * from sweets", panel_all_item);
        }

        //All Sandwich items visible true
        private void btn_sandwiches_Click(object sender, EventArgs e)
        {
            btn_sandwiches.StateNormal.Back.Color1 = Color.LightGray;
            btn_sandwiches.StateNormal.Back.Color2 = Color.LightGray;
            btn_sandwiches.StateNormal.Border.Color1 = Color.Red;
            btn_sandwiches.StateNormal.Border.Color2 = Color.Red;
            btn_coffee.StateNormal.Back.Color1 = Color.Transparent;
            btn_coffee.StateNormal.Back.Color2 = Color.Transparent;
            btn_coffee.StateNormal.Border.Color1 = Color.Transparent;
            btn_coffee.StateNormal.Border.Color2 = Color.Transparent;
            btn_sweets.StateNormal.Back.Color1 = Color.Transparent;
            btn_sweets.StateNormal.Back.Color2 = Color.Transparent;
            btn_sweets.StateNormal.Border.Color1 = Color.Transparent;
            btn_sweets.StateNormal.Border.Color2 = Color.Transparent;
            btn_bspecial.StateNormal.Back.Color1 = Color.Transparent;
            btn_bspecial.StateNormal.Back.Color2 = Color.Transparent;
            btn_bspecial.StateNormal.Border.Color1 = Color.Transparent;
            btn_bspecial.StateNormal.Border.Color2 = Color.Transparent;

            panel_all_item.Visible = true;
            panel_all_item.Controls.Clear();
            db.getButtons("select * from sandwich", panel_all_item);


        }

        //All Brew Special items visible true
        private void btn_bspecial_Click(object sender, EventArgs e)
        {
            btn_bspecial.StateNormal.Back.Color1 = Color.LightGray;
            btn_bspecial.StateNormal.Back.Color2 = Color.LightGray;
            btn_bspecial.StateNormal.Border.Color1 = Color.Red;
            btn_bspecial.StateNormal.Border.Color2 = Color.Red;
            btn_coffee.StateNormal.Back.Color1 = Color.Transparent;
            btn_coffee.StateNormal.Back.Color2 = Color.Transparent;
            btn_coffee.StateNormal.Border.Color1 = Color.Transparent;
            btn_coffee.StateNormal.Border.Color2 = Color.Transparent;
            btn_sweets.StateNormal.Back.Color1 = Color.Transparent;
            btn_sweets.StateNormal.Back.Color2 = Color.Transparent;
            btn_sweets.StateNormal.Border.Color1 = Color.Transparent;
            btn_sweets.StateNormal.Border.Color2 = Color.Transparent;
            btn_sandwiches.StateNormal.Back.Color1 = Color.Transparent;
            btn_sandwiches.StateNormal.Back.Color2 = Color.Transparent;
            btn_sandwiches.StateNormal.Border.Color1 = Color.Transparent;
            btn_sandwiches.StateNormal.Border.Color2 = Color.Transparent;

            panel_all_item.Visible = true;
            panel_all_item.Controls.Clear();
            db.getButtons("select * from BrewSp", panel_all_item);
        }

        //.......................................................................................................................//
       

        //.......................................................................................................................//

        //Refresh home form
        private void btn_refresh_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home obj = new Home();
            obj.ShowDialog();
        }

        //Open Customer registration form
        private void btn_reg_customers_form_Click(object sender, EventArgs e)
        {
            Register obj = new Register();
            obj.ShowDialog();
        }

        //Open stock add , update , delete form
        private void btn_stock_form_Click(object sender, EventArgs e)
        {
            Stock obj = new Stock();
            obj.ShowDialog();
        }

        //Open manager login form before go to settings form
        private void btn_settings_form_Click(object sender, EventArgs e)
        {
            ManagerPass obj = new ManagerPass();
            obj.ShowDialog();
        }

        //Digital clock display
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_status.Text = DateTime.Now.ToString("T");
        }
  
        //Search box..
        private void search_box_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in panel_all_item.Controls)
            {
                var wdg = (widget)item;
                {
                    wdg.Visible = wdg.lbl_title.Text.ToLower().ToLower().Contains(search_box.Text.Trim().ToLower());
                }
            }
        }
        //.......................................................................................................................//


        //.......................................................................................................................//

        //Place order and saving data to db....
        


        //.......................................................................................................................//

        //Log out..
        private void lbl_logout_Click(object sender, EventArgs e)
        {
            DialogResult Dialog = MessageBox.Show("Are you sure to logout", "logout", MessageBoxButtons.YesNo);
            if (Dialog == DialogResult.Yes)
            {

                MessageBox.Show("Logout Successfuly", "info", MessageBoxButtons.OK);
                this.Hide();
                this.Close();
                Login obj = new Login();
                obj.ShowDialog();
            }
        }





        //Placer Order....
        private void btn_porder_Click_1(object sender, EventArgs e)
        {
            Error er = new Error();
            try
            {
                if(listView1.Items.Count > 0)
                {
                    panel_pay.Visible = true;
                    panel1.Visible = false;
                    txt_sub_total.Text = lbl_sub_tot.Text;
                    txt_discount.Text = "0";
                    txt_net_amount.Text = lbl_sub_tot.Text;
                }
                else
                {
                    er.lblname = "Must Add an Item in the List!";
                    er.ShowDialog();
                }
            }
            catch (Exception)
            {
                er.lblname = "Check again";
                er.ShowDialog();
            }
        }

        ///...............................................................................................................................


        ////Add items in to cart..
        private void btn_add_cart_Click(object sender, EventArgs e)
        {
            Error er = new Error();
            try
            {
                if(string.IsNullOrEmpty(txtitemcost.Text))
                {
                    er.lblname = "Select Coffee Item";
                    er.ShowDialog();
                }
                else if(txtqty.Text.Length <= 0)
                {
                    er.lblname = "Add Coffee Quantity";
                    er.ShowDialog();
                }
                else if(txtqty.Text.Length > 0)
                {
                    string[] arr = new string[4];
                    arr[0] = combo_coffee.SelectedValue.ToString();
                    arr[1] = txtitemcost.Text;
                    arr[2] = txtqty.Text;
                    arr[3] = txtcost.Text;

                    ListViewItem lvi = new ListViewItem(arr);
                    listView1.Items.Add(lvi);


                    lbl_sub_tot.Text = (Convert.ToInt32(lbl_sub_tot.Text) + Convert.ToInt32(txtcost.Text)).ToString();

                    txtqty.Clear();
                    txtcost.Clear();
                }
            }
            catch
            {
                er.lblname = "Check aganin";
                er.ShowDialog();
            }
        }

        private void btn_sweet_add_cart_Click(object sender, EventArgs e)
        {
            Error er = new Error();
            try
            {
                if (string.IsNullOrEmpty(txtitemcost.Text))
                {
                    er.lblname = "Select Sweet Item";
                    er.ShowDialog();
                }
                else if (txtqty.Text.Length <= 0)
                {
                    er.lblname = "Add Sweet Quantity";
                    er.ShowDialog();
                }
                else if (txtqty.Text.Length > 0)
                {
                    string[] arr = new string[4];
                    arr[0] = combo_sweet.SelectedValue.ToString();
                    arr[1] = txtitemcost.Text;
                    arr[2] = txtqty.Text;
                    arr[3] = txtcost.Text;

                    ListViewItem lvi = new ListViewItem(arr);
                    listView1.Items.Add(lvi);


                    lbl_sub_tot.Text = (Convert.ToInt32(lbl_sub_tot.Text) + Convert.ToInt32(txtcost.Text)).ToString();

                    txtqty.Clear();
                    txtcost.Clear();
                }
            }
            catch
            {
                er.lblname = "Check aganin";
                er.ShowDialog();
            }
        }

        private void btn_sandwich_add_cart_Click(object sender, EventArgs e)
        {
            Error er = new Error();
            try
            {
                if (string.IsNullOrEmpty(txtitemcost.Text))
                {
                    er.lblname = "Select Sandwich Item";
                    er.ShowDialog();
                }
                else if (txtqty.Text.Length <= 0)
                {
                    er.lblname = "Add Sandwich Quantity";
                    er.ShowDialog();
                }
                else if (txtqty.Text.Length > 0)
                {
                    string[] arr = new string[4];
                    arr[0] = combo_sandwich.SelectedValue.ToString();
                    arr[1] = txtitemcost.Text;
                    arr[2] = txtqty.Text;
                    arr[3] = txtcost.Text;

                    ListViewItem lvi = new ListViewItem(arr);
                    listView1.Items.Add(lvi);


                    lbl_sub_tot.Text = (Convert.ToInt32(lbl_sub_tot.Text) + Convert.ToInt32(txtcost.Text)).ToString();

                    txtqty.Clear();
                    txtcost.Clear();
                }
            }
            catch
            {
                er.lblname = "Check aganin";
                er.ShowDialog();
            }
        }

        private void btn_brew_add_cart_Click(object sender, EventArgs e)
        {
            Error er = new Error();
            try
            {
                if (string.IsNullOrEmpty(txtitemcost.Text))
                {
                    er.lblname = "Select Brew Item";
                    er.ShowDialog();
                }
                else if (txtqty.Text.Length <= 0)
                {
                    er.lblname = "Add Brew Quantity";
                    er.ShowDialog();
                }
                else if (txtqty.Text.Length > 0)
                {
                    string[] arr = new string[4];
                    arr[0] = combo_brew.SelectedValue.ToString();
                    arr[1] = txtitemcost.Text;
                    arr[2] = txtqty.Text;
                    arr[3] = txtcost.Text;

                    ListViewItem lvi = new ListViewItem(arr);
                    listView1.Items.Add(lvi);


                    lbl_sub_tot.Text = (Convert.ToInt32(lbl_sub_tot.Text) + Convert.ToInt32(txtcost.Text)).ToString();

                    txtqty.Clear();
                    txtcost.Clear();
                }
            }
            catch
            {
                er.lblname = "Check aganin";
                er.ShowDialog();
            }
        }

        ///...............................................................................................................................


        private void txtqty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtqty.Text.Length > 0)
                {
                    txtcost.Text = (Convert.ToInt32(txtqty.Text) * Convert.ToInt32(txtitemcost.Text)).ToString();
                }
                else
                {
                    txtcost.Text = "0";
                }
            }
            catch
            {
                MessageBox.Show("Check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_back_Click(object sender, EventArgs e)
        {
            panel_pay.Visible = false;
            panel1.Visible = true;
        }

        private void txt_discount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_discount.Text.Length > 0)
                {
                    txt_net_amount.Text = (Convert.ToInt32(txt_sub_total.Text) - (Convert.ToInt32(txt_sub_total.Text) * Convert.ToInt32(txt_discount.Text) / 100)).ToString();
                }
                else
                {
                    txt_net_amount.Text = "0";
                }
            }
            catch
            {
                MessageBox.Show("Check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_paid_amount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_paid_amount.Text.Length > 0)
                {
                    txt_balance.Text = (Convert.ToInt32(txt_paid_amount.Text) - Convert.ToInt32(txt_net_amount.Text)).ToString();
                }
                else
                {
                    txt_balance.Text = "0";
                }
            }
            catch
            {
                MessageBox.Show("Check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            try
            {
                Error er = new Error();
                
                if(txt_paid_amount.Text.Length <= 0)
                {
                    er.lblname = "Enter Paid Amount";
                    er.ShowDialog();
                }
                else if (Convert.ToInt32(txt_paid_amount.Text) <= 0)
                {
                    er.lblname = "Check again paid amount ";
                    er.ShowDialog();
                }
                else if (Convert.ToInt32(txt_net_amount.Text) > Convert.ToInt32(txt_paid_amount.Text))
                {
                    er.lblname = "Check again paid amount ";
                    er.ShowDialog();
                }
                else
                {
                    DateTime DT = DateTime.Now;

                    string ConnectionString = "Data Source=DESKTOP-376L562;Initial Catalog=BrewHouse;Integrated Security=True";

                    SqlConnection connection = new SqlConnection(ConnectionString);
                    SqlCommand command = connection.CreateCommand();

                    connection.Open();

                    command.CommandText = "Insert into Test_Invoice_Master (InvoiceDate, Sub_Total, Discount, Net_Amount, Paid_Amount) values " +
                           " ( '" + DT + "' , " + txt_sub_total.Text + " ," + txt_discount.Text + " , " + txt_net_amount.Text + ", " + txt_paid_amount.Text + ")  select scope_identity() ";

                    string InvoiceID = command.ExecuteScalar().ToString();

                    foreach (ListViewItem ListItem in listView1.Items)
                    {

                        command.CommandText = "Insert into Test_Invoice_Detail (MasterID, ItemName, ItemPrice, ItemQtty, ItemTotal ) values   " +
                     " ('" + InvoiceID + "', '" + ListItem.SubItems[0].Text + "', '" + ListItem.SubItems[1].Text + "', '" + ListItem.SubItems[2].Text + "' , " + ListItem.SubItems[3].Text + ")";

                        command.ExecuteNonQuery();

                    }
                    connection.Close();
                    panel_pay.Visible = false;

                    lbl_sub_tot.Text = "0";

                    mobile_num.Clear();
                    txt_sub_total.Clear();
                    txt_discount.Clear();
                    txt_net_amount.Clear();
                    txt_paid_amount.Clear();
                    txt_balance.Clear();

                    listView1.Items.Clear();
                    panel1.Visible = true;
                    new Invoice.Invoice(InvoiceID).Show();
                }
                
            }
            catch (Exception)
            {
                Error er = new Error();
                er.lblname = "Check again";
                er.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string querry = "SELECT * from customer WHERE customer_mobile = '" + mobile_num.Text.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(querry, con);

                DataTable dtable = new DataTable();
                da.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    txt_discount.Text = ((Convert.ToInt32(txt_sub_total.Text) * 10 / 100)).ToString();
                    txt_net_amount.Text = (Convert.ToInt32(txt_sub_total.Text) - (Convert.ToInt32(txt_sub_total.Text) * 10 / 100)).ToString();
                }
                else
                {
                    txt_discount.Text = "0";
                    txt_net_amount.Text = txt_sub_total.Text;
                }
            }
            catch(Exception)
            {
                Error er = new Error();
                er.lblname = "System Error";
                er.ShowDialog();
            }
        }

        private void combo_coffee_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlquery = "SELECT * FROM coffee WHERE coffee_name = @CoffeeName ";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, con);

            sqlcomm.Parameters.AddWithValue("@CoffeeName", combo_coffee.SelectedValue.ToString());
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtitemcost.Text = dr["coffee_price"].ToString();
            }

            con.Close();

            txtcost.Text = "";
            txtqty.Text = "";
        }

        private void combo_sweet_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlquery = "SELECT * FROM sweets WHERE sweet_name = @SweetName ";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, con);

            sqlcomm.Parameters.AddWithValue("@SweetName", combo_sweet.SelectedValue.ToString());
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtitemcost.Text = dr["sweet_price"].ToString();
            }

            con.Close();

            txtcost.Text = "";
            txtqty.Text = "";
        }

        private void combo_sandwich_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlquery = "SELECT * FROM sandwich WHERE sandwich_name = @SandName ";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, con);

            sqlcomm.Parameters.AddWithValue("@SandName", combo_sandwich.SelectedValue.ToString());
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtitemcost.Text = dr["sandwich_price"].ToString();
            }

            con.Close();

            txtcost.Text = "";
            txtqty.Text = "";
        }

        private void combo_brew_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlquery = "SELECT * FROM BrewSp WHERE brew_name = @BrewName ";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, con);

            sqlcomm.Parameters.AddWithValue("@BrewName", combo_brew.SelectedValue.ToString());
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtitemcost.Text = dr["brew_price"].ToString();
            }

            con.Close();

            txtcost.Text = "";
            txtqty.Text = "";
        }

        private void lbl_coffee_Click(object sender, EventArgs e)
        {
            combo_coffee.Focus();

            txtitemcost.Text = "";
            txtqty.Text = "";
            txtcost.Text = "";

            lbl_coffee.ForeColor = Color.OrangeRed;
            lbl_sweet.ForeColor = Color.Navy;
            lbl_sandwich.ForeColor = Color.Navy;
            lbl_brew.ForeColor = Color.Navy;

            btn_add_cart.Visible = true;
            btn_sweet_add_cart.Visible = false;
            btn_sandwich_add_cart.Visible = false;
            btn_brew_add_cart.Visible = false;

            combo_sweet.Enabled = false;
            combo_coffee.Enabled = true;
            combo_sandwich.Enabled = false;
            combo_brew.Enabled = false;
        }

        private void lbl_sweet_Click(object sender, EventArgs e)
        {
            combo_sweet.Focus();

            txtitemcost.Text = "";
            txtqty.Text = "";
            txtcost.Text = "";

            lbl_sweet.ForeColor = Color.OrangeRed;
            lbl_sandwich.ForeColor = Color.Navy;
            lbl_brew.ForeColor = Color.Navy;
            lbl_coffee.ForeColor = Color.Navy;

            btn_add_cart.Visible = false;
            btn_sweet_add_cart.Visible = true;
            btn_sandwich_add_cart.Visible = false;
            btn_brew_add_cart.Visible = false;

            combo_sweet.Enabled = true;
            combo_coffee.Enabled = false;
            combo_sandwich.Enabled = false;
            combo_brew.Enabled = false;
        }

        private void lbl_brew_Click(object sender, EventArgs e)
        {
            combo_sandwich.Focus();

            txtitemcost.Text = "";
            txtqty.Text = "";
            txtcost.Text = "";

            lbl_brew.ForeColor = Color.OrangeRed;
            lbl_sweet.ForeColor = Color.Navy;
            lbl_sandwich.ForeColor = Color.Navy;
            lbl_coffee.ForeColor = Color.Navy;

            btn_add_cart.Visible = false;
            btn_sweet_add_cart.Visible = false;
            btn_sandwich_add_cart.Visible = false;
            btn_brew_add_cart.Visible = true;

            combo_sweet.Enabled = false;
            combo_coffee.Enabled = false;
            combo_sandwich.Enabled = false;
            combo_brew.Enabled = true;
        }

        private void lbl_sandwich_Click(object sender, EventArgs e)
        {
            combo_brew.Focus();

            txtitemcost.Text = "";
            txtqty.Text = "";
            txtcost.Text = "";

            lbl_sandwich.ForeColor = Color.OrangeRed;
            lbl_sweet.ForeColor = Color.Navy;
            lbl_brew.ForeColor = Color.Navy;
            lbl_coffee.ForeColor = Color.Navy;

            btn_add_cart.Visible = false;
            btn_sweet_add_cart.Visible = false;
            btn_sandwich_add_cart.Visible = true;
            btn_brew_add_cart.Visible = false;

            combo_sweet.Enabled = false;
            combo_coffee.Enabled = false;
            combo_sandwich.Enabled = true;
            combo_brew.Enabled = false;
        }

        private void delete_cart_Click(object sender, EventArgs e)
        {
            Error er = new Error();

            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        int item = Convert.ToInt32(listView1.Items[i].SubItems[3].Text);
                        int subtot = Convert.ToInt32(lbl_sub_tot.Text);
                        int cal = subtot - item;

                    if (listView1.Items[i].Selected)
                        {
                            lbl_sub_tot.Text = cal.ToString();
                            listView1.Items[i].Remove();
                        }
                    }
                }
                else
                {
                    er.lblname = "Select remove item";
                    er.ShowDialog();
                }
            }
            catch(Exception)
            {
                er.lblname = "Check again";
                er.ShowDialog();
            }
        }
    }
}


