using Microsoft.Reporting.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManage.Report
{
    public partial class BillReportForm : Form
    {
       
        public BillReportForm()
        {
            InitializeComponent();
        }

        private void PrintBill_Load(object sender, EventArgs e)
        {
            
           
            this.reportViewer1.RefreshReport();
        }




        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=s_stock;Integrated Security=True");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from View_Bill_Print where Bill_no= '" + Bill_no_s.Text +"'", con);
            // DataTable ds = new DataTable();
            DataBill db = new DataBill();
            da.Fill(db, "Bill_Box");
            con.Close();

            ReportDataSource dataSource = new ReportDataSource("DataSet_Report", db.Tables[0]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(dataSource);
            reportViewer1.RefreshReport();

        }

        private void BIll_no_s_TextChanged(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
