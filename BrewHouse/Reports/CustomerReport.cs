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
using System.Data.Sql;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace BrewHouse.Reports
{
    public partial class CustomerReport : KryptonForm
    {
        public CustomerReport()
        {
            InitializeComponent();
        }

        private void CustomerReport_Load(object sender, EventArgs e)
        {
            this.CustomerreportViewer.RefreshReport();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-376L562;Initial Catalog=BrewHouse;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from customer", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            CustomerreportViewer.LocalReport.ReportPath = @"C:\Users\HI\source\repos\BrewHouse\BrewHouse\Reports\CustomerReport.rdlc";
            CustomerreportViewer.LocalReport.DataSources.Clear();
            CustomerreportViewer.LocalReport.DataSources.Add(rds);
            CustomerreportViewer.RefreshReport();

            try
            {
                using (BrewHouseEntities2 db = new BrewHouseEntities2())
                {
                    //combo_city.DataSource = db.customers.ToList();
                    //combo_city.ValueMember = "customer_city";
                    //combo_city.DisplayMember = "customer_city";
                }
            }
            catch
            {
                MessageBox.Show("Database Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_save_Click(object sender, EventArgs e)
        {

        }
    }
}
