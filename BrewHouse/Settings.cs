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
using ComponentFactory.Krypton.Navigator;
using BrewHouse.Reports;
using BrewHouse.Stock_Report;
using BrewHouse.Chart_View;

namespace BrewHouse
{
    public partial class Settings : KryptonForm
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btn_user_settings_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            BrewUser obj = new BrewUser();
            obj.ShowDialog();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btn_customer_report_Click(object sender, EventArgs e)
        {
            CustomerReport obj = new CustomerReport();
            obj.ShowDialog();
        }

        private void btn_stock_report_Click(object sender, EventArgs e)
        {
            StockReport obj = new StockReport();
            obj.ShowDialog();
        }

        private void btn_chart_view_Click(object sender, EventArgs e)
        {
            ChartView obj = new ChartView();
            obj.ShowDialog();
        }

        private void btn_user_set_Click(object sender, EventArgs e)
        {
            BrewUser bs = new BrewUser();
            bs.ShowDialog();
        }
    }
}
