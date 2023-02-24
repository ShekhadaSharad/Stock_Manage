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
using System.Collections;

namespace StockManage
{
    public partial class Users : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=s_stock;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
       

        public Users()
        {
            InitializeComponent();
            LoadUser();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UserModel userModel = new UserModel();
            userModel.btnusersave.Enabled = true;
            userModel.btnuserupdet.Enabled = false;
            userModel.ShowDialog();
            LoadUser();

        }
        public void LoadUser()
        {
            int i = 0;
            dgvUser.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM UserMOdule where CONCAT(Shopnm,Fullnm,City,Phone,ShopGST) LIKE '%"+text_user_search.Text+"%'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvUser.Rows.Add(i,dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());

            }
            dr.Close();
            con.Close();

        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String colName = dgvUser.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                UserModel userModel = new UserModel();
                userModel.textshopnm.Text = dgvUser.Rows[e.RowIndex].Cells[1].Value.ToString();
                userModel.textfullnm.Text = dgvUser.Rows[e.RowIndex].Cells[2].Value.ToString();
                userModel.textcity.Text = dgvUser.Rows[e.RowIndex].Cells[3].Value.ToString();
                userModel.textphone.Text = dgvUser.Rows[e.RowIndex].Cells[4].Value.ToString();
                userModel.textshopgst.Text = dgvUser.Rows[e.RowIndex].Cells[5].Value.ToString();

                userModel.btnusersave.Enabled = false;
                userModel.btnuserupdet.Enabled = true;
                userModel.textshopnm.Enabled = false;
                userModel.ShowDialog();
            }
            else if (colName== "Delete")
            {
                if(MessageBox.Show("Are you sure Want to delete this user?","Delete Record?",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM UserMOdule WHERE Phone LIKE '" + dgvUser.Rows[e.RowIndex].Cells[4].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has successfuly Deleted");
                }
            }
            LoadUser();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadUser();
        }
    }
}
