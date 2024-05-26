using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrewHouse.Helpers;
using ComponentFactory.Krypton.Toolkit;
using System.Data.Sql;
using System.Data.SqlClient;

namespace BrewHouse
{
    public partial class Login : KryptonForm
    {
        SqlConnection Con;

        public Login()
        {
            InitializeComponent();
            txt_password.Focus();
        }

        private void btn_add_clear_Click(object sender, EventArgs e)
        {
            txt_password.Clear();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Error er = new Error();

            string querry = "SELECT * from userlog WHERE username = '" + combo_user.Text+ "' AND userpass = '" + txt_password.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(querry, Con);

            DataTable dtable = new DataTable();
            da.Fill(dtable);

            if (dtable.Rows.Count > 0)
            {
                this.Hide();
                Home obj = new Home();
                obj.ShowDialog();
            }
            else
            {
                System.Console.WriteLine("Test1");
                er.lblname = "Invalid login details";
                er.ShowDialog();

                txt_password.Clear();
            }
            Con.Close();
        }

        private void check_password_CheckedChanged(object sender, EventArgs e)
        {
            if (check_password.Checked)
            {
                txt_password.UseSystemPasswordChar = true;
            }
            else
            {
                txt_password.UseSystemPasswordChar = false;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            SplashScreen obj = new SplashScreen();
            obj.Close();

            Con = new SqlConnection("Data Source=DESKTOP-376L562;Initial Catalog=BrewHouse;Integrated Security=True");
            Con.Open();
            Con.Close();

            try
            {
                using (BrewHouseEntities1 db = new BrewHouseEntities1())
                {
                    combo_user.DataSource = db.userlogs.ToList();
                    combo_user.ValueMember = "username";
                    combo_user.DisplayMember = "username";
                }
            }
            catch
            {
                MessageBox.Show("Database Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_add_Enter(object sender, EventArgs e)
        {

        }
    }
}
