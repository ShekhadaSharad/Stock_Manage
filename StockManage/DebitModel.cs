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
    public partial class DebitModel : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=s_stock;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        public DebitModel()
        {
            InitializeComponent();
        }

        private void pictureBoxexit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void DebitModel_Load(object sender, EventArgs e)
        {

        }

        private void btn_debit_save_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_debit_updet_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to Update this user?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("UPDATE Debit SET User_Name = @User_Name, User_City = @User_City, Mobile_No=@Mobile_No, Rupya_Baki=@Rupya_Baki  WHERE Bill_No LIKE '" + text_debit_id.Text + "' ", con);
                    cm.Parameters.AddWithValue("@User_Name", text_debit_user.Text);
                    cm.Parameters.AddWithValue("@User_City", text_debit_city.Text);
                    cm.Parameters.AddWithValue("@Mobile_No", text_debit_no.Text);
                    cm.Parameters.AddWithValue("@Rupya_Baki", text_debit_money.Text);
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
    }
}
