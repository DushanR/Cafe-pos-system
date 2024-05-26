using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace BrewHouse
{
    public partial class BrewUser : KryptonForm
    {
        public BrewUser()
        {
            InitializeComponent();
        }

        customerDB db = new customerDB();

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-376L562;Initial Catalog=BrewHouse;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Settings obj = new Settings();
            obj.ShowDialog();
        }

        private void btn_new_user_Click(object sender, EventArgs e)
        {
            paneladduser.Visible = true;
            panel_user_delete.Visible = false;
            panel_update_user.Visible = false;
            panel_add_user.Visible = true;
            paneladduser.Controls.Add(panel_add_user);
            panel_add_user.Dock = DockStyle.Fill;

        }

        private void btn_update_user_Click(object sender, EventArgs e)
        {
            paneladduser.Visible = true;
            panel_user_delete.Visible = false;
            panel_update_user.Visible = true;
            panel_add_user.Visible = false;
            paneladduser.Controls.Add(panel_update_user);
            panel_update_user.Dock = DockStyle.Fill;
        }

        private void btn_remove_user_Click(object sender, EventArgs e)
        {
            paneladduser.Visible = true;
            panel_user_delete.Visible = true;
            panel_update_user.Visible = false;
            panel_add_user.Visible = false;
            paneladduser.Controls.Add(panel_user_delete);
            panel_user_delete.Dock = DockStyle.Fill;
        }

        private void btn_add_user_Click(object sender, EventArgs e)
        {
            try
            {
                Error er = new Error();

                if(txt_add_name.Text.Length == 0)
                {
                    er.lblname = "Name can not be blank";
                    er.ShowDialog();
                }
                else if(txt_add_name.Text.Any(char.IsDigit))
                {
                    er.lblname = "Name can not have numbers";
                    er.ShowDialog();
                }
                else if (!txt_add_name.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                {
                    er.lblname = "Name can only contain letters and spaces";
                    er.ShowDialog();
                }
                else if(txt_add_pass.Text.Length == 0)
                {
                    er.lblname = "Password can not be blank";
                    er.ShowDialog();
                }
                else if(txt_add_cpass.Text.Length == 0)
                {
                    er.lblname = "Confirm password can not be blank";
                    er.ShowDialog();
                }
                else if (txt_add_pass.Text != txt_add_cpass.Text)
                {
                    er.lblname = "Confirm password must be same to the password";
                    er.ShowDialog();
                }
                else
                {
                    con.Open();
                    DateTime DT = DateTime.Now;
                    Successfull scc = new Successfull();
                    scc.lblname = "Data Saved Successfully";

                    cmd = new SqlCommand("insert into userlog values ('" + txt_add_name.Text + "' , '" + txt_add_pass.Text + "' , '" + DT + "' , '" + txt_add_cpass.Text + "')",con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        scc.ShowDialog();

                        txt_add_name.Clear();
                        txt_add_pass.Clear();
                        txt_add_cpass.Clear();
                    }
                    else
                    {
                        er.lblname = "Data can not save";
                        er.ShowDialog();
                    }
                }
            }
            catch(Exception)
            {
                Error er = new Error();
                er.lblname = "Check again";
                er.ShowDialog();
            }
            finally
            {
                con.Close();
            }
        }

        private void btn_update_uer_Click(object sender, EventArgs e)
        {
            try
            {
                Error er = new Error();

                if (tex_update_name.Text.Length == 0)
                {
                    er.lblname = "Name can not be blank";
                    er.ShowDialog();
                }
                else if (tex_update_name.Text.Any(char.IsDigit))
                {
                    er.lblname = "Name can not have numbers";
                    er.ShowDialog();
                }
                else if (!tex_update_name.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                {
                    er.lblname = "Name can only contain letters and spaces";
                    er.ShowDialog();
                }
                else if (tex_update_new_name.Text.Length == 0)
                {
                    er.lblname = "New name can not be blank";
                    er.ShowDialog();
                }
                else if (tex_update_new_name.Text.Any(char.IsDigit))
                {
                    er.lblname = "New name can not have numbers";
                    er.ShowDialog();
                }
                else if (!tex_update_new_name.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                {
                    er.lblname = "New name can only contain letters and spaces";
                    er.ShowDialog();
                }
                else if (tex_update_old_pass.Text.Length == 0)
                {
                    er.lblname = "Old password can not be blank";
                    er.ShowDialog();
                }
                else if (tex_update_new_pass.Text.Length == 0)
                {
                    er.lblname = "New password can not be blank";
                    er.ShowDialog();
                }
                else if (tex_update_old_pass.Text == tex_update_new_pass.Text)
                {
                    er.lblname = "Old password can not be new password";
                    er.ShowDialog();
                }
                else
                {
                    con.Open();

                    string querry = "SELECT * from userlog WHERE username = '" + tex_update_name.Text + "' AND userpass = '" + tex_update_old_pass.Text + "'";
                    SqlDataAdapter da = new SqlDataAdapter(querry, con);

                    DateTime DT = DateTime.Now;
                    DataTable dtable = new DataTable();
                    da.Fill(dtable);

                    if (dtable.Rows.Count > 0)
                    {
                        Successfull scc = new Successfull();
                        scc.lblname = "Data Saved Successfully";

                        string query = "update userlog set username = '"+tex_update_new_name.Text+"' , userpass =  '"+tex_update_new_pass.Text+ "' , date =  '" + DT + "', confirmpassword =  '" + tex_update_new_pass.Text + "' where username = '"+tex_update_name.Text+"' ";
                        int i = db.save_update_delete(query);
                        if (i == 1)
                        {
                            scc.ShowDialog();

                            tex_update_name.Clear();
                            tex_update_new_name.Clear();
                            tex_update_old_pass.Clear();
                            tex_update_new_pass.Clear();
                        }
                        else
                        {
                            er.lblname = "Data can not update";
                            er.ShowDialog();
                        }
                    }
                    else
                    {
                        er.lblname = "Old name and Old password not maching";
                        er.ShowDialog();
                    }
                }
            }
            catch (Exception)
            {
                Error er = new Error();
                er.lblname = "Check again";
                er.ShowDialog();
            }
            finally
            {
                con.Close();
            }
        }

        private void btn_delete_user_Click(object sender, EventArgs e)
        {
            try
            {
                Error er = new Error();

                if (text_delete_name.Text.Length == 0)
                {
                    er.lblname = "Name can not be blank";
                    er.ShowDialog();
                }
                else if (text_delete_name.Text.Any(char.IsDigit))
                {
                    er.lblname = "Name can not have numbers";
                    er.ShowDialog();
                }
                else if (!text_delete_name.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                {
                    er.lblname = "Name can only contain letters and spaces";
                    er.ShowDialog();
                }
                else if (text_delete_pass.Text.Length == 0)
                {
                    er.lblname = "Password can not be blank";
                    er.ShowDialog();
                }
                else
                {
                    con.Open();

                    string querry = "SELECT * from userlog WHERE username = '" + text_delete_name.Text + "' AND userpass = '" + text_delete_pass.Text + "'";
                    SqlDataAdapter da = new SqlDataAdapter(querry, con);

                    DataTable dtable = new DataTable();
                    da.Fill(dtable);

                    if (dtable.Rows.Count > 0)
                    {
                        Successfull scc = new Successfull();
                        scc.lblname = "Data delete Successfully";

                        string query = "Delete from userlog where username = '" + text_delete_name.Text + "' ";
                        int i = db.save_update_delete(query);
                        if (i == 1)
                        {
                            scc.ShowDialog();

                            text_delete_name.Clear();
                            text_delete_pass.Clear();
                        }
                        else
                        {
                            er.lblname = "Data can not delete";
                            er.ShowDialog();
                        }
                    }
                    else
                    {
                        er.lblname = "Name and Password not maching";
                        er.ShowDialog();
                    }
                }
            }
            catch
            {
                Error er = new Error();
                er.lblname = "Check again";
                er.ShowDialog();
            }
            finally
            {
                con.Close();
            }
        }

        private void btn_a_clear_Click(object sender, EventArgs e)
        {
            txt_add_name.Clear();
            txt_add_pass.Clear();
            txt_add_cpass.Clear();
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            tex_update_name.Clear();
            tex_update_new_name.Clear();
            tex_update_old_pass.Clear();
            tex_update_new_pass.Clear();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            text_delete_name.Clear();
            text_delete_pass.Clear();
        }

        private void BrewUser_Load(object sender, EventArgs e)
        {
        }
    }
}
