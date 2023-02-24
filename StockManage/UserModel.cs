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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace StockManage
   
{
    public partial class UserModel : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=s_stock;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        public UserModel()
        {
            InitializeComponent();
        }
        

        private void pictureBoxexit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (textshopnm.Text !="" && textfullnm.Text !="" && textcity.Text != "" && textphone.Text != ""&& textshopgst.Text!="" )
                {

                    con.Open();
                    SqlCommand cm = new SqlCommand("insert into UserModule values('" + textshopnm.Text + "','" + textfullnm.Text + "','" + textcity.Text + "','" + textphone.Text + "','"+textshopgst.Text+"')", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User has been Successfuly saved.");
                    Clear();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error :: " + e, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Clear();

            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public void Clear()
        {
            textshopnm.Clear();
            textfullnm.Clear();
            textcity.Clear();
            textphone.Clear();
        }

        private void btnuserupdet_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to Update this user?","Update Record",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes) 
                {
                    con.Open();
                    cm = new SqlCommand("UPDATE UserModule SET Fullnm = @Fullnm, City = @City, Phone=@Phone, ShopGST=@ShopGST  WHERE Shopnm LIKE '" + textshopnm.Text + "' ", con);
                    cm.Parameters.AddWithValue("@Fullnm", textfullnm.Text);
                    cm.Parameters.AddWithValue("@City", textcity.Text);
                    cm.Parameters.AddWithValue("@Phone", textphone.Text);
                    cm.Parameters.AddWithValue("@ShopGST", textshopgst.Text);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User has been Successfuly Update.");
                    this.Dispose();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void textphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void UserModel_Load(object sender, EventArgs e)
        {

        }

        private void textshopnm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textfullnm.Focus();
            }
        }

        private void textfullnm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textcity.Focus();
            }
        }

        private void textcity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textphone.Focus();
            }
        }

        private void textphone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnusersave.Focus();
            }
        }
    }
}