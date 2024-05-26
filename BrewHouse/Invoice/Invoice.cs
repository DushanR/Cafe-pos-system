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
using Microsoft.Reporting.WinForms;

namespace BrewHouse.Invoice
{
    public partial class Invoice : KryptonForm
    {
        string _invoice_id;
        public Invoice(string _id)
        {
            _invoice_id = _id;
            InitializeComponent();
        }

        public string invo { get; set; }

        private void Invoice_Load(object sender, EventArgs e)
        {

            this.InvoicereportViewer.RefreshReport();

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-376L562;Initial Catalog=BrewHouse;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from View_All_Bill_Test where InvoiceID = '"+ _invoice_id +"'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            InvoiceDataSet ds = new InvoiceDataSet();
            da.Fill(ds , "DataTable Invoice");

            ReportDataSource rds = new ReportDataSource("DataSet_Report", ds.Tables[0]);

            this.InvoicereportViewer.LocalReport.DataSources.Clear();
            this.InvoicereportViewer.LocalReport.DataSources.Add(rds);
            this.InvoicereportViewer.RefreshReport();
        }
    }
}
