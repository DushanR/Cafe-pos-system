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
using Microsoft.Reporting.WinForms;
using System.Data.Sql;

namespace BrewHouse.Stock_Report
{
    public partial class StockReport : KryptonForm
    {
        public StockReport()
        {
            InitializeComponent();
        }

        private void StockReport_Load(object sender, EventArgs e)
        {
            this.StockreportViewer.RefreshReport();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-376L562;Initial Catalog=BrewHouse;Integrated Security=True");
            con.Open();

            if (radio_coffee.Checked)
            {
                SqlCommand cmd = new SqlCommand("select * from coffee", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                ReportDataSource rds = new ReportDataSource("DataSet1", dt);
                StockreportViewer.LocalReport.ReportPath = @"C:\Users\HI\source\repos\BrewHouse\BrewHouse\Stock Report\StockReport.rdlc";
                StockreportViewer.LocalReport.DataSources.Clear();
                StockreportViewer.LocalReport.DataSources.Add(rds);
                StockreportViewer.RefreshReport();
            }

            else if(radio_sweets.Checked)
            {
                SqlCommand cmd = new SqlCommand("select * from sweets", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                ReportDataSource rds = new ReportDataSource("DataSet1", dt);
                StockreportViewer.LocalReport.ReportPath = @"C:\Users\HI\source\repos\BrewHouse\BrewHouse\Stock Report\SweetsReport.rdlc";
                StockreportViewer.LocalReport.DataSources.Clear();
                StockreportViewer.LocalReport.DataSources.Add(rds);
                StockreportViewer.RefreshReport();
            }

            else if(radio_sandwich.Checked)
            {
                SqlCommand cmd = new SqlCommand("select * from sandwich", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                ReportDataSource rds = new ReportDataSource("DataSet1", dt);
                StockreportViewer.LocalReport.ReportPath = @"C:\Users\HI\source\repos\BrewHouse\BrewHouse\Stock Report\SandwichStock.rdlc";
                StockreportViewer.LocalReport.DataSources.Clear();
                StockreportViewer.LocalReport.DataSources.Add(rds);
                StockreportViewer.RefreshReport();
            }
            else if(radio_brewsp.Checked)
            {
                SqlCommand cmd = new SqlCommand("select * from BrewSp", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                ReportDataSource rds = new ReportDataSource("DataSet1", dt);
                StockreportViewer.LocalReport.ReportPath = @"C:\Users\HI\source\repos\BrewHouse\BrewHouse\Stock Report\BrewSpStock.rdlc";
                StockreportViewer.LocalReport.DataSources.Clear();
                StockreportViewer.LocalReport.DataSources.Add(rds);
                StockreportViewer.RefreshReport();
            }
        }


        ///Radio Buttons Color Changed When Click.....
        private void radio_coffee_CheckedChanged_1(object sender, EventArgs e)
        {
            radio_coffee.ForeColor = Color.Green;
            radio_sweets.ForeColor = Color.Red;
            radio_sandwich.ForeColor = Color.Red;
            radio_brewsp.ForeColor = Color.Red;
        }

        private void radio_sweets_CheckedChanged_1(object sender, EventArgs e)
        {
            radio_sweets.ForeColor = Color.Green;
            radio_coffee.ForeColor = Color.Red;
            radio_sandwich.ForeColor = Color.Red;
            radio_brewsp.ForeColor = Color.Red;
        }

        private void radio_sandwich_CheckedChanged_1(object sender, EventArgs e)
        {
            radio_sandwich.ForeColor = Color.Green;
            radio_sweets.ForeColor = Color.Red;
            radio_coffee.ForeColor = Color.Red;
            radio_brewsp.ForeColor = Color.Red;
        }

        private void radio_brewsp_CheckedChanged_1(object sender, EventArgs e)
        {
            radio_brewsp.ForeColor = Color.Green;
            radio_sweets.ForeColor = Color.Red;
            radio_sandwich.ForeColor = Color.Red;
            radio_coffee.ForeColor = Color.Red;
        }
    }
}
