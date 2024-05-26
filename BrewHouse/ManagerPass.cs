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

namespace BrewHouse
{
    public partial class ManagerPass : KryptonForm
    {
        public ManagerPass()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            string password;
            password = txt_password.Text;

            if(password == "mbrew")
            {
                this.Hide();
                this.Close();
                Settings obj = new Settings();
                obj.ShowDialog();
            }

            else
            {
                MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txt_password.Clear();
            }
        }
    }
}
