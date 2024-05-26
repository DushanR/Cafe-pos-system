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
    public partial class Error : KryptonForm
    {
        public Error()
        {
            InitializeComponent();
        }

        public string lblname
        {
            get { return lbl_error.Text; }
            set { lbl_error.Text = value; }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
