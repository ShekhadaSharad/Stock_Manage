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

namespace StockManage
{
    public partial class Billmanage : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=s_stock;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public Billmanage()
        {
            InitializeComponent();
            LoadBill();
        }

        private void Billmanage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 's_stockDataSet7.Billbox' table. You can move, or remove it, as needed.
            this.billboxTableAdapter.Fill(this.s_stockDataSet7.Billbox);
            // TODO: This line of code loads data into the 's_stockDataSet6.Billbox' table. You can move, or remove it, as needed.
           // this.billboxTableAdapter3.Fill(this.s_stockDataSet6.Billbox);
            // TODO: This line of code loads data into the 's_stockDataSet1.Billbox' table. You can move, or remove it, as needed.
            // this.billboxTableAdapter2.Fill(this.s_stockDataSet1.Billbox);
            //// TODO: This line of code loads data into the 's_stockDataSet.Billbox' table. You can move, or remove it, as needed.
            //this.billboxTableAdapter1.Fill(this.s_stockDataSet.Billbox);
            //// TODO: This line of code loads data into the 'stockmanagDataSet1.Billbox' table. You can move, or remove it, as needed.
            //this.billboxTableAdapter.Fill(this.stockmanagDataSet1.Billbox);

        }
        public void LoadBill()
        {
            int i = 0;
            dgvUser.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM Billbox where CONCAT(user_name,mobile_no,gst_in,user_address,date,bill_no,sub_totel,discount,net_amount,paid_amount,SGST,CGST) LIKE '%" + text_Bill_search.Text + "%'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                
                dgvUser.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString(), dr[11].ToString());

            }
            dr.Close();
            con.Close();

        }

        private void dgvUser_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dgvUser.Rows[e.RowIndex].Cells["No"].Value = (e.RowIndex + 1).ToString();
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void text_Bill_search_TextChanged(object sender, EventArgs e)
        {
            // LoadBill();

            BindingSource bs = new BindingSource();
            bs.DataSource = dgvUser.DataSource;
            bs.Filter = "user_name like '%" + text_Bill_search.Text + "%'";
            bs.Filter = "mobile_no like '%" + text_Bill_search.Text + "%'";
            bs.Filter = "gst_in like '%" + text_Bill_search.Text + "%'";
            bs.Filter = "user_address like '%" + text_Bill_search.Text + "%'";
            bs.Filter = "bill_no like '%" + text_Bill_search.Text + "%'";
            dgvUser.DataSource = bs;


        }
    }
}
