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

namespace BrewHouse.Chart_View
{
    public partial class ChartView : KryptonForm
    {
        //Fields
        private Dashboard model;

        //Constructor
        public ChartView()
        {
            InitializeComponent();
            //Default - ToDay
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Now;
            btn_today.Select();

            model = new Dashboard();
            LoadData();
        }

        private void LoadData()
        {
            var refreshData = model.LoadData(dtpStartDate.Value, dtpEndDate.Value);
            if (refreshData == true)
            {
                lbl_num_of_orders.Text = model.NumOrders.ToString();
                lbl_tota_revenue.Text = "Rs." + model.TotalRevenue.ToString()+".00";
                lbl_total_profit.Text = "Rs." + model.TotalProfit.ToString()+".00";

                lbl_count_coffee.Text = model.NumCoffe.ToString();
                lbl_count_sweet.Text = model.NumSweets.ToString();
                lbl_count_sadnwich.Text = model.NumSandwiches.ToString();
                lbl_count_brewsp.Text = model.NumBrewSpecial.ToString();
                lbl_count_master_customers.Text = model.NumMasterCustomers.ToString();

                chart_gross_revenue.DataSource = model.GrossRevenueList;
                chart_gross_revenue.Series[0].XValueMember = "Date";
                chart_gross_revenue.Series[0].YValueMembers = "TotalAmount";
                chart_gross_revenue.DataBind();

                chart_top_5_prod.DataSource = model.TopProductsList;
                chart_top_5_prod.Series[0].XValueMember = "Key";
                chart_top_5_prod.Series[0].YValueMembers = "Value";
                chart_top_5_prod.DataBind();

                Console.WriteLine("Loaded view :)");
            }
            else Console.WriteLine("View not loaded, same query");
        }

        private void DisableCustomDates()
        {
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            btn_ok_custom_dates.Visible = false;
        }
        private void btn_today_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();

            btn_custom_days.StateNormal.Border.Color1 = Color.Navy;
            btn_custom_days.StateNormal.Border.Color2 = Color.Navy;
        }

        private void btn_last_7_days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();

            btn_custom_days.StateNormal.Border.Color1 = Color.Navy;
            btn_custom_days.StateNormal.Border.Color2 = Color.Navy;
        }

        private void btn_last_30_days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-30);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();

            btn_custom_days.StateNormal.Border.Color1 = Color.Navy;
            btn_custom_days.StateNormal.Border.Color2 = Color.Navy;
        }

        private void btn_this_month_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();

            btn_custom_days.StateNormal.Border.Color1 = Color.Navy;
            btn_custom_days.StateNormal.Border.Color2 = Color.Navy;
        }

        private void btn_custom_days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Enabled = true;
            dtpEndDate.Enabled = true;
            btn_ok_custom_dates.Visible = true;
        }

        private void btn_ok_custom_dates_Click_1(object sender, EventArgs e)
        {
            LoadData();
            btn_custom_days.StateNormal.Border.Color1 = Color.OrangeRed;
            btn_custom_days.StateNormal.Border.Color2 = Color.OrangeRed;
        }
    }
}
