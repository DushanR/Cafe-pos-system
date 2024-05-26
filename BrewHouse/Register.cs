using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

using System.Net.Http;

using System.Web;
using System.Security.Cryptography;

//Nuget Libraries to Gmail APi

using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Services;
using Google.Apis.Util.Store;

using System.Threading;
using System.Linq.Expressions;



namespace BrewHouse
{
    public partial class Register : KryptonForm
    {

        string messageNum;
        private const string API_KEY = "KRqVTgO2Iy6Xy3CUPC2X";
        private const string USER_ID = "25360";

        public Register()
        {
            InitializeComponent();
            BHno();
        }

        //customer save , update , delete class
        customerDB db = new customerDB();

        //.......................................................................................................................//

        //Customer save panel visible..
        private void btn_new_Click(object sender, EventArgs e)
        {
            panal_remove.Visible = false;
            panel_update.Visible = false;
            panal_save.Visible = true;
        }

        //Customer update panel visible..
        private void btn_update_Click_1(object sender, EventArgs e)
        {
            panal_save.Visible = false;
            panal_remove.Visible = false;
            panel_update.Visible = true;
        }

        //Customer delete panel visible..
        private void btn_remove_Click_1(object sender, EventArgs e)
        {
            panel_update.Visible = false;
            panal_save.Visible = false;
            panal_remove.Visible = true;
        }

        //back to home menu..
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //.......................................................................................................................//

        //connetction string for auto increment customer id......
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-376L562;Initial Catalog=BrewHouse;Integrated Security=True");
        SqlCommand cmd;
        string sql;

        //Auto increment customer id
        public void BHno()
        {
            try
            {
                sql = "select MAX(customerid) from customer";
                cmd = new SqlCommand(sql, con);
                con.Open();
                var maxid = cmd.ExecuteScalar() as string;



                if (maxid == null)
                {
                    label10.Text = "BH0001";
                }
                else
                {
                    int intval = int.Parse(maxid.Substring(2, 4));
                    intval++;
                    label10.Text = string.Format("BH{0:0000}", intval);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
        //Customer details update
        private void btn_update_customer_Click_1(object sender, EventArgs e)
        {
            try
            {
                //Validations...
                Error obj = new Error();
                Successfull ssc = new Successfull();
                ssc.lblname = "Data update Successfully";

                if (string.IsNullOrEmpty(update_txt_id.Text))
                {
                    obj.lblname = "Id cannot be blank";
                    obj.ShowDialog();
                }
                else if (update_txt_id.Text.Length > 8)
                {
                    obj.lblname = "Id length should be less than 8";
                    obj.ShowDialog();
                }
                else if (string.IsNullOrEmpty(update_txt_name.Text))
                {
                    obj.lblname = "Name cannot be blank";
                    obj.ShowDialog();
                }
                else if ((update_txt_name.Text.Any(char.IsDigit)))
                {
                    obj.lblname = "Name cannot contain any numbers";
                    obj.ShowDialog();
                }
                else if (!update_txt_name.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                {
                    obj.lblname = "Name can only contain letters and spaces";
                    obj.ShowDialog();
                }
                else if (string.IsNullOrEmpty(update_txt_city.Text))
                {
                    obj.lblname = "City cannot be blank";
                    obj.ShowDialog();
                }
                else if (!update_txt_city.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                {
                    obj.lblname = "City can only contain letters and spaces";
                    obj.ShowDialog();
                }
                else if (string.IsNullOrEmpty(update_txt_mobile.Text))
                {
                    obj.lblname = "Mobile cannot be blank";
                    obj.ShowDialog();
                }
                else if (update_txt_mobile.Text.Any(char.IsLetter))
                {
                    obj.lblname = "Mobile cannot contain any letters";
                    obj.ShowDialog();
                }
                else if (!Regex.IsMatch(update_txt_mobile.Text, "^[0-9]+$"))
                {
                    obj.lblname = "Mobile can only contain digits";
                    obj.ShowDialog();
                }
                else if (!Regex.IsMatch(update_txt_mobile.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
                {
                    obj.lblname = "Mobile must have 10 numbers";
                    obj.ShowDialog();
                }

                else if (update_txt_email.Text.Length == 0)
                {
                    obj.lblname = "Enter email address";
                    obj.ShowDialog();
                }
                else if (!Regex.IsMatch(update_txt_email.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                {
                    obj.lblname = "Enter a valid email. " +
                                  "Ex:name@gmail.com";
                    obj.ShowDialog();
                }

                else
                {
                    string query = "Update customer set customer_name = '" + update_txt_name.Text + "' , customer_city = '" + update_txt_city.Text + "' , customer_mobile = '" + Convert.ToInt32(update_txt_mobile.Text) + "' , customer_email = '" + update_txt_email.Text + "' where customerid = '" + update_txt_id.Text + "' ";
                    int i = db.save_update_delete(query);
                    if (i == 1)
                    {
                        ssc.ShowDialog();
                    }

                    else
                    {
                        obj.lblname = "Check again enterd data";
                        obj.ShowDialog();
                    }
                }
            }
            catch (Exception)
            {
                Error obj = new Error();
                obj.lblname = "Check again data";
                obj.ShowDialog();
            }

            //Clearing text boxes after updating customer data
            //update_txt_id.Clear();
            //update_txt_name.Clear();
            //update_txt_city.Clear();
            //update_txt_mobile.Clear();
            //update_txt_email.Clear();
        }

        //Customer details delete
        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                Error obj = new Error();
                Successfull ssc = new Successfull();
                ssc.lblname = "Data save Successfully";

                if (!radio_id.Checked && !radio_mobile.Checked)
                {
                    obj.lblname = "you have selected an option";
                    obj.ShowDialog();
                }
                
                


                if (radio_id.Checked == true)
                {
                    

                    string query = "Delete from customer where customerid = '" + delete_txt_id_mobile.Text + "' ";
                    int i = db.save_update_delete(query);
                    if (i == 1)
                    {
                        ssc.ShowDialog();
                    }
                    else
                    {
                        obj.lblname = "Check again customer id";
                        obj.ShowDialog();
                    }


                }
                else if (radio_mobile.Checked == true)
                {
                    

                    string query = "Delete from customer where customer_mobile = '" + Convert.ToInt32(delete_txt_id_mobile.Text) + "' ";
                    int i = db.save_update_delete(query);
                    if (i == 1)
                    {
                        ssc.ShowDialog();
                    }
                    else
                    {
                        obj.lblname = "Check again mobile number";
                        obj.ShowDialog();
                    }

                }

            }
            catch (Exception)
            {
                Error obj = new Error();
                obj.lblname = "Check again Data";
                obj.ShowDialog();
            }

            //Clearing text boxes and radion buttons after deleting customer data
            //delete_txt_id_mobile.Clear();
            //radio_id.Checked = false;
            //radio_mobile.Checked = false;
        }

        //.......................................................................................................................//

        //Save interface text box clear
        private void btn_clear_Click(object sender, EventArgs e)
        {
            save_txt_name.Clear();
            save_txt_city.Clear();
            save_txt_number.Clear();
            save_txt_email.Clear();
        }

        //Delete interface text box and radio buttons clear
        private void btn_clear_delete_Click(object sender, EventArgs e)
        {
            delete_txt_id_mobile.Clear();
            radio_id.Checked = false;
            radio_mobile.Checked = false;
        }

        //Update interface text box clear
        private void btn_update_clear_Click(object sender, EventArgs e)
        {
            update_txt_id.Clear();
            update_txt_name.Clear();
            update_txt_city.Clear();
            update_txt_mobile.Clear();
            update_txt_email.Clear();
        }

        private async void btn_save_Click(object sender, EventArgs e)
        {
            string phoneNumber = "94"+save_txt_number.Text;
            string message = "Thank you for purchasing Brew House Master Card. You get 10 % off any purchase from Brew House.";

            try
            {
                DateTime DT = DateTime.Now;

                Error obj = new Error();
                Successfull ssc = new Successfull();
                ssc.lblname = "Data save Successfully";



                if (string.IsNullOrEmpty(save_txt_name.Text))
                {
                    obj.lblname = "Name cannot be blank";
                    obj.ShowDialog();
                }
                else if (save_txt_name.Text.Any(char.IsDigit))
                {
                    obj.lblname = "Name cannot contain any numbers";
                    obj.ShowDialog();
                }
                else if (!save_txt_name.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                {
                    obj.lblname = "Name can only contain letters and spaces";
                    obj.ShowDialog();
                }
                else if (string.IsNullOrEmpty(save_txt_city.Text))
                {
                    obj.lblname = "City cannot be blank";
                    obj.ShowDialog();
                }
                else if (!save_txt_city.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                {
                    obj.lblname = "City can only contain letters and spaces";
                    obj.ShowDialog();
                }
                else if (string.IsNullOrEmpty(save_txt_number.Text))
                {
                    obj.lblname = "Mobile cannot be blank";
                    obj.ShowDialog();
                }
                else if (save_txt_number.Text.Any(char.IsLetter))
                {
                    obj.lblname = "Mobile cannot contain any letters";
                    obj.ShowDialog();
                }
                else if (!Regex.IsMatch(save_txt_number.Text, "^[0-9]+$"))
                {
                    obj.lblname = "Mobile can only contain digits";
                    obj.ShowDialog();
                }
                else if (!Regex.IsMatch(save_txt_number.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
                {
                    obj.lblname = "Mobile must have 10 numbers";
                    obj.ShowDialog();
                }

                else if (save_txt_email.Text.Length == 0)
                {
                    obj.lblname = "Enter email address";
                    obj.ShowDialog();
                }
                else if (!Regex.IsMatch(save_txt_email.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                {
                    obj.lblname = "Enter a valid email. " +
                                  "Ex:name@gmail.com";
                    obj.ShowDialog();
                }

                else
                {
                    string query = "Insert into customer values ('" + label10.Text + "' ,'" + save_txt_name.Text + "' ,'" + save_txt_city.Text + "' ,'" + Convert.ToInt32(save_txt_number.Text) + "' ,'" + save_txt_email.Text + "', '" + DT + "') ";
                    int i = db.save_update_delete(query);
                    if (i == 1)
                    {
                        await SendSMS(phoneNumber, message);
                        ssc.ShowDialog();
                    }
                    else
                    {
                        obj.lblname = "Check again enterd data";
                        obj.ShowDialog();
                    }

                }
            }
            catch (Exception)
            {
                Error obj = new Error();
                obj.lblname = "Check again enterd";
                obj.ShowDialog();
            }

            //Clearing text boxes and refresh id number after saving customer data
            //save_txt_name.Clear();
            //save_txt_city.Clear();
            //save_txt_number.Clear();
            //save_txt_email.Clear();
            BHno();
        }
        private async Task SendSMS(string phoneNumber, string message)
        {
            string apiUrl = @"https://app.notify.lk/api/v1/send";
            string urlParameters = $"user_id={USER_ID}&api_key={API_KEY}&sender_id=NotifyDEMO&to={HttpUtility.UrlEncode(phoneNumber)}&message={HttpUtility.UrlEncode(message)}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync($"{apiUrl}?{urlParameters}");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

            }
        }
    }
}
