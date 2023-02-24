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
    public partial class ProductManag : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=s_stock;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public ProductManag()
        {
            InitializeComponent();
            LoadProduct();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ProductModule Pm = new ProductModule();
            Pm.btnmodulesave.Enabled = true;
            Pm.btnmoduleupdet.Enabled = false;
            Pm.Show();
        }
        public void LoadProduct()
        {
            int i = 0;
            dgvproduct.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM ProductManag where CONCAT(Product_id,Pro_name,Qty,Price,GST,Decription) LIKE '%"+text_pro_search.Text+"%'", con);
            con.Open();
            dr = cm.ExecuteReader();

            
            while (dr.Read())
            {
              i++;
            dgvproduct.Rows.Add(i,dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(),dr[4].ToString(),dr[5].ToString());
             }
            dr.Close();
            con.Close();

        }

        private void dgvproduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String colName = dgvproduct.Columns[e.ColumnIndex].Name;
            if (colName == "Proediti")
            {
                ProductModule productModule = new ProductModule();
                productModule.textproid.Text = dgvproduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                productModule.textpronm.Text = dgvproduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                productModule.textqty.Text = dgvproduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                productModule.textprice.Text = dgvproduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                productModule.textgst.Text = dgvproduct.Rows[e.RowIndex].Cells[5].Value.ToString();
                productModule.textdecription.Text = dgvproduct.Rows[e.RowIndex].Cells[6].Value.ToString();

                productModule.btnmodulesave.Enabled = false;
                productModule.btnmoduleupdet.Enabled = true;
                productModule.textproid.Enabled = false;
                productModule.ShowDialog();
            }
            else if (colName == "Prodelete")
            {
                if (MessageBox.Show("Are you sure Want to delete this user?", "Delete Record?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM ProductManag WHERE Product_id LIKE '" + dgvproduct.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has successfuly Deleted");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void dgvproduct_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //this.dgvproduct.Rows[e.RowIndex].Cells["ProductId"].Value = (e.RowIndex + 1).ToString();
        }
    }
}
