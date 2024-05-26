using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Microsoft.Win32;
using System.IO;


namespace BrewHouse
{
    public partial class Stock : KryptonForm
    {
        string imagepath;

        public Stock()
        {
            InitializeComponent();
        }

        //Stock add , update , delete class
        CoffeeDB db = new CoffeeDB();

        //.......................................................................................................................//

        //Stock form load
        private void Stock_Load(object sender, EventArgs e)
        {
            panel_update.Visible = false;
            panel_add.Visible = false;
            panel_remove.Visible = false;
            lbl_item.Visible = false;
        }

        //Add new item panel visible..
        private void btn_new_Click(object sender, EventArgs e)
        {
            lbl_item.Visible = true;
            lbl_item.Text = "Add Items";
            panel_remove.Visible = false;
            panel_update.Visible = false;
            panel_add.Visible = true;
        }

        //Update item panel visible..
        private void btn_update_Click_1(object sender, EventArgs e)
        {
            lbl_item.Visible = true;
            lbl_item.Text = "Update Items";
            panel_add.Visible = false;
            panel_remove.Visible = false;
            panel_update.Visible = true;
        }

        //Remove item panel visible..
        private void btn_remove_Click(object sender, EventArgs e)
        {
            lbl_item.Visible = true;
            lbl_item.Text = "Remove Items";
            panel_update.Visible = false;
            panel_add.Visible = false;
            panel_remove.Visible = true;
        }

        //Back to home form..
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //.......................................................................................................................//

        //New items add in to database...
        private void btn_add_Click(object sender, EventArgs e)
        {
            Error obj = new Error();
            Successfull scc = new Successfull();
            scc.lblname = " Item Saved Successfully";

            if (!radio_add_brew.Checked && !radio_add_coffee.Checked && !radio_add_sand.Checked && !radio_add_sweets.Checked)
            {
                obj.lblname = "you have selected an option";
                obj.ShowDialog();
            }
            //Add Coffee
            if (radio_add_coffee.Checked)
            {
                try
                {

                    if (string.IsNullOrEmpty(txt_add_name.Text))
                    {
                        obj.lblname = "Item name cannot be blank";
                        obj.ShowDialog();
                    }
                    else if (txt_add_name.Text.Any(char.IsDigit))
                    {
                        obj.lblname = "Item name cannot contain any numbers";
                        obj.ShowDialog();
                    }
                    else if (!txt_add_name.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                    {
                        obj.lblname = "Name can only contain letters and spaces";
                        obj.ShowDialog();
                    }
                    else if (string.IsNullOrEmpty(txt_add_price.Text))
                    {
                        obj.lblname = "Price cannot be blank";
                        obj.ShowDialog();
                    }
                    else if (txt_add_price.Text.Any(char.IsLetter))
                    {
                        obj.lblname = "Price cannot contain any letters";
                        obj.ShowDialog();
                    }
                    else if (!Regex.IsMatch(txt_add_price.Text, "^[0-9]+$"))
                    {
                        obj.lblname = "Price can only contain digits";
                        obj.ShowDialog();
                    }
                    else
                    {
                        string query = "Insert into coffee values ('" + txt_add_name.Text + "' ,'" + Convert.ToInt32(txt_add_price.Text) + "' , '" + imagepath + "') ";
                        int i = db.add_update_remove(query);
                        if (i == 1)
                        {
                            scc.ShowDialog();
                        }
                        else
                        {
                            obj.lblname = "Data can't save";
                            obj.ShowDialog();
                        }
                    }
                }
                catch (Exception)
                {
                    obj.lblname = "Please Check Again";
                    obj.ShowDialog();
                }

            }
            //Add Sweet
            else if (radio_add_sweets.Checked)
            {
                try
                {
                    if (string.IsNullOrEmpty(txt_add_name.Text))
                    {
                        obj.lblname = "Item name cannot be blank";
                        obj.ShowDialog();
                    }
                    else if (txt_add_name.Text.Any(char.IsDigit))
                    {
                        obj.lblname = "Item name cannot contain any numbers";
                        obj.ShowDialog();
                    }
                    else if (!txt_add_name.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                    {
                        obj.lblname = "Name can only contain letters and spaces";
                        obj.ShowDialog();
                    }
                    else if (string.IsNullOrEmpty(txt_add_price.Text))
                    {
                        obj.lblname = "Price cannot be blank";
                        obj.ShowDialog();
                    }
                    else if (txt_add_price.Text.Any(char.IsLetter))
                    {
                        obj.lblname = "Price cannot contain any letters";
                        obj.ShowDialog();
                    }
                    else if (!Regex.IsMatch(txt_add_price.Text, "^[0-9]+$"))
                    {
                        obj.lblname = "Price can only contain digits";
                        obj.ShowDialog();
                    }
                    else
                    {
                        string query = "Insert into sweets values ('" + txt_add_name.Text + "' ,'" + Convert.ToInt32(txt_add_price.Text) + "', '" + imagepath + "') ";
                        int i = db.add_update_remove(query);
                        if (i == 1)
                        {
                            scc.ShowDialog();
                        }
                        else
                        {
                            obj.lblname = "Data can't save";
                            obj.ShowDialog();
                        }
                    }
                    
                }
                catch (Exception)
                {
                    obj.lblname = "Please Check Again";
                    obj.ShowDialog();
                }
            }
            //Add Sandwich
            else if (radio_add_sand.Checked)
            {
                try
                {
                    if (string.IsNullOrEmpty(txt_add_name.Text))
                    {
                        obj.lblname = "Item name cannot be blank";
                        obj.ShowDialog();
                    }
                    else if (txt_add_name.Text.Any(char.IsDigit))
                    {
                        obj.lblname = "Item name cannot contain any numbers";
                        obj.ShowDialog();
                    }
                    else if (!txt_add_name.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                    {
                        obj.lblname = "Name can only contain letters and spaces";
                        obj.ShowDialog();
                    }
                    else if (string.IsNullOrEmpty(txt_add_price.Text))
                    {
                        obj.lblname = "Price cannot be blank";
                        obj.ShowDialog();
                    }
                    else if (txt_add_price.Text.Any(char.IsLetter))
                    {
                        obj.lblname = "Price cannot contain any letters";
                        obj.ShowDialog();
                    }
                    else if (!Regex.IsMatch(txt_add_price.Text, "^[0-9]+$"))
                    {
                        obj.lblname = "Price can only contain digits";
                        obj.ShowDialog();
                    }
                    else
                    {
                        string query = "Insert into sandwich values ('" + txt_add_name.Text + "' ,'" + Convert.ToInt32(txt_add_price.Text) + "', '" + imagepath + "') ";
                        int i = db.add_update_remove(query);
                        if (i == 1)
                        {
                            scc.ShowDialog();
                        }
                        else
                        {
                        
                                obj.lblname = "Please Check Again";
                                obj.ShowDialog();
                            
                        }
                    }
                    
                }
                catch (Exception)
                {
                    obj.lblname = "Please Check Again";
                    obj.ShowDialog();
                }
            }
            //Add Brew Special
            else if (radio_add_brew.Checked)
            {
                try
                {
                    if (string.IsNullOrEmpty(txt_add_name.Text))
                    {
                        obj.lblname = "Item name cannot be blank";
                        obj.ShowDialog();
                    }
                    else if (txt_add_name.Text.Any(char.IsDigit))
                    {
                        obj.lblname = "Item name cannot contain any numbers";
                        obj.ShowDialog();
                    }
                    else if (!txt_add_name.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                    {
                        obj.lblname = "Name can only contain letters and spaces";
                        obj.ShowDialog();
                    }
                    else if (string.IsNullOrEmpty(txt_add_price.Text))
                    {
                        obj.lblname = "Price cannot be blank";
                        obj.ShowDialog();
                    }
                    else if (txt_add_price.Text.Any(char.IsLetter))
                    {
                        obj.lblname = "Price cannot contain any letters";
                        obj.ShowDialog();
                    }
                    else if (!Regex.IsMatch(txt_add_price.Text, "^[0-9]+$"))
                    {
                        obj.lblname = "Price can only contain digits";
                        obj.ShowDialog();
                    }
                    else
                    {
                        string query = "Insert into BrewSp values ('" + txt_add_name.Text + "' ,'" + Convert.ToInt32(txt_add_price.Text) + "', '" + imagepath + "') ";
                        int i = db.add_update_remove(query);
                        if (i == 1)
                        {
                            scc.ShowDialog();
                        }
                        else
                        {

                            obj.lblname = "Please Check Again";
                            obj.ShowDialog();

                        }
                    }
                    
                }
                catch (Exception)
                {
                    obj.lblname = "Please Check Again";
                    obj.ShowDialog();
                }
            }

            //Clearing text boxes and radio buttons after saving items
            //txt_add_name.Clear();
            //txt_add_price.Clear();
            //radio_add_coffee.Checked = false;
            //radio_add_sweets.Checked = false;
            //radio_add_sand.Checked = false;
            //radio_add_brew.Checked = false;
            //picbox_item.Image = null;

            //Change color back to normal
            radio_add_coffee.ForeColor = Color.MidnightBlue;
            radio_add_sand.ForeColor = Color.MidnightBlue;
            radio_add_sweets.ForeColor = Color.MidnightBlue;
            radio_add_brew.ForeColor = Color.MidnightBlue;
        }
        //New item image 
        private void btn_browse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imagepath = ofd.FileName;
                    picbox_item.Image = Image.FromFile(ofd.FileName);
                }
        }

        //Update items...
        private void btn_update_item_Click(object sender, EventArgs e)
        {
            //Update Coffe items
            if (radio_update_coffee.Checked)
            {
                try
                {
                    string query = "Update coffee set coffee_price = '" + Convert.ToInt32(txt_update_price.Text) + "', coffee_image = '"+ imagepath + "' where coffee_name = '" + txt_update_name.Text + "' ";
                    int i = db.add_update_remove(query);
                    if (i == 1)
                        MessageBox.Show("Data update Successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Data can't update", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    MessageBox.Show("Please check again", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //Update Sweet items
            else if (radio_update_sweets.Checked)
            {
                try
                {
                    string query = "Update sweets set sweet_price = '" + Convert.ToInt32(txt_update_price.Text) + "', coffee_image = '" + imagepath + "' where sweet_name = '" + txt_update_name.Text + "' ";
                    int i = db.add_update_remove(query);
                    if (i == 1)
                        MessageBox.Show("Data update Successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Data can't update", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please check again", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //Update Sandwich items
            else if (radio_update_sand.Checked)
            {
                try
                {
                    string query = "Update sandwich set sandwich_price = '" + Convert.ToInt32(txt_update_price.Text) + "', coffee_image = '" + imagepath + "' where sandwich_name = '" + txt_update_name.Text + "' ";
                    int i = db.add_update_remove(query);
                    if (i == 1)
                        MessageBox.Show("Data update Successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Data can't update", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please check again", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //Update Brew Special items
            else if (radio_update_brew.Checked)
            {
                try
                {
                    string query = "Update BrewSp set brew_price = '" + Convert.ToInt32(txt_update_price.Text) + "', coffee_image = '" + imagepath + "' where brew_name = '" + txt_update_name.Text + "' ";
                    int i = db.add_update_remove(query);
                    if (i == 1)
                        MessageBox.Show("Data update Successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Data can't update", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please check again", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //Clearing text boxes and radio buttons after updating items
            txt_update_name.Clear();
            txt_update_price.Clear();
            radio_update_coffee.Checked = false;
            radio_update_sweets.Checked = false;
            radio_update_sand.Checked = false;
            radio_update_brew.Checked = false;
            picbox_item_update.Image = null;

            //Change color back to normal
            radio_update_coffee.ForeColor = Color.MidnightBlue;
            radio_update_sand.ForeColor = Color.MidnightBlue;
            radio_update_sweets.ForeColor = Color.MidnightBlue;
            radio_update_brew.ForeColor = Color.MidnightBlue;
        }
        //Update item image
        private void btn_update_browse_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagepath = openFileDialog.FileName;
                    picbox_item_update.Image = Image.FromFile(openFileDialog.FileName);

                }
        }

        //Remove items...
        private void btn_remove_item_Click(object sender, EventArgs e)
        {
            //Remove Coffee items
            if (radio_remove_coffee.Checked)
            {
                try
                {
                    string query = "Delete from coffee where coffee_name = '" + txt_remove_name.Text + "' ";
                    int i = db.add_update_remove(query);
                    if (i == 1)
                        MessageBox.Show("Data delete Successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Data can't delete", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    MessageBox.Show("Please check again", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //Remove Sweet items
            else if (radio_remove_sweets.Checked)
            {
                try
                {
                    string query = "Delete from sweets where sweet_name = '" + txt_remove_name.Text + "' ";
                    int i = db.add_update_remove(query);
                    if (i == 1)
                        MessageBox.Show("Data delete Successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Data can't delete", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    MessageBox.Show("Please check again", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //Remove Sandwich items
            else if (radio_remove_sand.Checked)
            {
                try
                {
                    string query = "Delete from sandwich where sandwich_name = '" + txt_remove_name.Text + "' ";
                    int i = db.add_update_remove(query);
                    if (i == 1)
                        MessageBox.Show("Data delete Successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Data can't delete", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    MessageBox.Show("Please check again", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //Remove Brew Special items
            else if (radio_remove_brew.Checked)
            {
                try
                {
                    string query = "Delete from BrewSp where brew_name = '" + txt_remove_name.Text + "' ";
                    int i = db.add_update_remove(query);
                    if (i == 1)
                        MessageBox.Show("Data delete Successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Data can't delete", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    MessageBox.Show("Please check again", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //Clearing text boxes and radio buttons after removing items
            txt_remove_name.Clear();
            radio_remove_coffee.Checked = false;
            radio_remove_sweets.Checked = false;
            radio_remove_sand.Checked = false;
            radio_remove_brew.Checked = false;

            //Change color back to normal
            radio_remove_coffee.ForeColor = Color.MidnightBlue;
            radio_remove_sand.ForeColor = Color.MidnightBlue;
            radio_remove_sweets.ForeColor = Color.MidnightBlue;
            radio_remove_brew.ForeColor = Color.MidnightBlue;
        }

        //.......................................................................................................................//

        //Remove interface text box and radio buttons clear
        private void btn_remove_clear_Click(object sender, EventArgs e)
        {
            txt_remove_name.Clear();
            radio_remove_coffee.Checked = false;
            radio_remove_sweets.Checked = false;
            radio_remove_sand.Checked = false;
            radio_remove_brew.Checked = false;

            radio_update_coffee.ForeColor = Color.Black;
            radio_update_sand.ForeColor = Color.Black;
            radio_update_sweets.ForeColor = Color.Black;
            radio_update_brew.ForeColor = Color.Black;

            radio_remove_coffee.ForeColor = Color.MidnightBlue;
            radio_remove_sand.ForeColor = Color.MidnightBlue;
            radio_remove_sweets.ForeColor = Color.MidnightBlue;
            radio_remove_brew.ForeColor = Color.MidnightBlue;
        }
        //Update interface text box and radio buttons clear
        private void btn_update_clear_Click(object sender, EventArgs e)
        {
            txt_update_name.Clear();
            txt_update_price.Clear();
            radio_update_coffee.Checked = false;
            radio_update_sweets.Checked = false;
            radio_update_sand.Checked = false;
            radio_update_brew.Checked = false;
            picbox_item_update.Image = null;

            radio_update_coffee.ForeColor = Color.MidnightBlue;
            radio_update_sand.ForeColor = Color.MidnightBlue;
            radio_update_sweets.ForeColor = Color.MidnightBlue;
            radio_update_brew.ForeColor = Color.MidnightBlue;
        }
        //Add interface text box and radio buttons clear
        private void btn_add_clear_Click(object sender, EventArgs e)
        {
            txt_add_name.Clear();
            txt_add_price.Clear();
            radio_add_coffee.Checked = false;
            radio_add_sweets.Checked = false;
            radio_add_sand.Checked = false;
            radio_add_brew.Checked = false;
            picbox_item.Image = null;

            radio_update_coffee.ForeColor = Color.Black;
            radio_update_sand.ForeColor = Color.Black;
            radio_update_sweets.ForeColor = Color.Black;
            radio_update_brew.ForeColor = Color.Black;

            radio_add_coffee.ForeColor = Color.MidnightBlue;
            radio_add_sand.ForeColor = Color.MidnightBlue;
            radio_add_sweets.ForeColor = Color.MidnightBlue;
            radio_add_brew.ForeColor = Color.MidnightBlue;
        }

        //.......................................................................................................................//

        //Add panel radio buttons color change
        private void radio_add_coffee_CheckedChanged(object sender, EventArgs e)
        {
            radio_add_coffee.ForeColor = Color.Green;
            radio_add_sand.ForeColor = Color.Red;
            radio_add_sweets.ForeColor = Color.Red;
            radio_add_brew.ForeColor = Color.Red;
        }

        private void radio_add_sweets_CheckedChanged(object sender, EventArgs e)
        {
            radio_add_coffee.ForeColor = Color.Red;
            radio_add_sand.ForeColor = Color.Red;
            radio_add_sweets.ForeColor = Color.Green;
            radio_add_brew.ForeColor = Color.Red;
        }

        private void radio_add_sand_CheckedChanged(object sender, EventArgs e)
        {
            radio_add_coffee.ForeColor = Color.Red;
            radio_add_sand.ForeColor = Color.Green;
            radio_add_sweets.ForeColor = Color.Red;
            radio_add_brew.ForeColor = Color.Red;
        }

        private void radio_add_brew_CheckedChanged(object sender, EventArgs e)
        {
            radio_add_coffee.ForeColor = Color.Red;
            radio_add_sand.ForeColor = Color.Red;
            radio_add_sweets.ForeColor = Color.Red;
            radio_add_brew.ForeColor = Color.Green;
        }

        //Update panel radio buttons color change
        private void radio_update_coffee_CheckedChanged(object sender, EventArgs e)
        {
            radio_update_coffee.ForeColor = Color.Green;
            radio_update_sand.ForeColor = Color.Red;
            radio_update_sweets.ForeColor = Color.Red;
            radio_update_brew.ForeColor = Color.Red;
        }

        private void radio_update_sweets_CheckedChanged(object sender, EventArgs e)
        {
            radio_update_coffee.ForeColor = Color.Red;
            radio_update_sand.ForeColor = Color.Red;
            radio_update_sweets.ForeColor = Color.Green;
            radio_update_brew.ForeColor = Color.Red;
        }

        private void radio_update_sand_CheckedChanged(object sender, EventArgs e)
        {
            radio_update_coffee.ForeColor = Color.Red;
            radio_update_sand.ForeColor = Color.Green;
            radio_update_sweets.ForeColor = Color.Red;
            radio_update_brew.ForeColor = Color.Red;
        }

        private void radio_update_brew_CheckedChanged(object sender, EventArgs e)
        {
            radio_update_coffee.ForeColor = Color.Red;
            radio_update_sand.ForeColor = Color.Red;
            radio_update_sweets.ForeColor = Color.Red;
            radio_update_brew.ForeColor = Color.Green;
        }

        //Remove panel radio buttons color change
        private void radio_remove_coffee_CheckedChanged(object sender, EventArgs e)
        {
            radio_remove_coffee.ForeColor = Color.Green;
            radio_remove_sand.ForeColor = Color.Red;
            radio_remove_sweets.ForeColor = Color.Red;
            radio_remove_brew.ForeColor = Color.Red;
        }

        private void radio_remove_sweets_CheckedChanged(object sender, EventArgs e)
        {
            radio_remove_coffee.ForeColor = Color.Red;
            radio_remove_sand.ForeColor = Color.Red;
            radio_remove_sweets.ForeColor = Color.Green;
            radio_remove_brew.ForeColor = Color.Red;
        }

        private void radio_remove_sand_CheckedChanged(object sender, EventArgs e)
        {
            radio_remove_coffee.ForeColor = Color.Red;
            radio_remove_sand.ForeColor = Color.Green;
            radio_remove_sweets.ForeColor = Color.Red;
            radio_remove_brew.ForeColor = Color.Red;
        }

        private void radio_remove_brew_CheckedChanged(object sender, EventArgs e)
        {
            radio_remove_coffee.ForeColor = Color.Red;
            radio_remove_sand.ForeColor = Color.Red;
            radio_remove_sweets.ForeColor = Color.Red;
            radio_remove_brew.ForeColor = Color.Green;
        }  
    }
}


 