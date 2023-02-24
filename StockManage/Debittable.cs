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
    public partial class Debittable : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=s_stock;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public Debittable()
        {
            InitializeComponent();
            LoadUser();
        }

        private void dgvUser_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //this.dgvUser_debit.Rows[e.RowIndex].Cells["No"].Value = (e.RowIndex + 1).ToString();
        }
        public void LoadUser()
        {
            int i = 0;
            dgvUser_debit.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM Debit where CONCAT(Bill_No,User_Name,User_City,Mobile_NO,Rupya_Baki) LIKE '%" + text_user_search.Text + "%'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvUser_debit.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());

            }
            dr.Close();
            con.Close();

        }
        private void Debittable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 's_stockDataSet3.Debit_Usre' table. You can move, or remove it, as needed.
           // this.debit_UsreTableAdapter.Fill(this.s_stockDataSet3.Debit_Usre);
            // TODO: This line of code loads data into the 's_stockDataSet2.Debit' table. You can move, or remove it, as needed.
            // this.debitTableAdapter.Fill(this.s_stockDataSet2.Debit);

        }

        private void dgvUser_debit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String colName = dgvUser_debit.Columns[e.ColumnIndex].Name;
            if (colName == "Edit_Debit")
            {
                DebitModel DebitModel = new DebitModel();
                DebitModel.text_debit_id.Text = dgvUser_debit.Rows[e.RowIndex].Cells[1].Value.ToString();
                DebitModel.text_debit_user.Text = dgvUser_debit.Rows[e.RowIndex].Cells[2].Value.ToString();
                DebitModel.text_debit_city.Text = dgvUser_debit.Rows[e.RowIndex].Cells[3].Value.ToString();
                DebitModel.text_debit_no.Text = dgvUser_debit.Rows[e.RowIndex].Cells[4].Value.ToString();
                DebitModel.text_debit_money.Text = dgvUser_debit.Rows[e.RowIndex].Cells[5].Value.ToString();


                DebitModel.ShowDialog();
            }
            else if (colName == "Delete_Debit")
            {
                if (MessageBox.Show("Are you sure Want to delete this user?", "Delete Record?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM Debit WHERE Bill_No LIKE '" + dgvUser_debit.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has successfuly Deleted");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DebitModel debitmodel = new DebitModel();
            debitmodel.btn_debit_save.Enabled = true;
            debitmodel.btn_debit_updet.Enabled = false;
            debitmodel.ShowDialog();
            LoadUser();

        }
    }
}
