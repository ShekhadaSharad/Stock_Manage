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
    public partial class ProductModule : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=s_stock;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        public ProductModule()
        {
            InitializeComponent();
        }

        

        private void btnmodulesave_Click(object sender, EventArgs e)
        {
            try
            {

                if (textproid.Text!="" && textpronm.Text!="" &&  textqty.Text!=""&& textprice.Text!=""&& textgst.Text!=""&& textdecription.Text!= "" ) {
                    con.Open();
                    SqlCommand cm = new SqlCommand("insert into ProductManag(Product_id,Pro_Name,Qty,Price,Decription,GST) values('" + textproid.Text + "','" + textpronm.Text + "','" + textqty.Text + "','" +float.Parse(textprice.Text) + "','" +textdecription.Text + "','" +float.Parse(textgst.Text) + "')", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Add Product  Successfuly saved.");
                    proClear();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error :: " + e, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                proClear();

            }

        }
        private void btnmoduleclear_Click(object sender, EventArgs e)
        {
            proClear();
        }
        public void proClear()
        {
            textproid.Clear();
            textpronm.Clear();
            textqty.Clear();
            textprice.Clear();
            textgst.Clear();
          
            textdecription.Clear();
        }

        private void pictureBoxexit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnmoduleupdet_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                SqlCommand cm = new SqlCommand("UPDATE ProductManag SET Pro_name=@Pro_name, Qty=@Qty, Price=@Price, GST=@GST, Decription=@Decription WHERE Product_id LIKE '" + textproid.Text + "' ", con);
                cm.Parameters.AddWithValue("@Pro_name", textpronm.Text);
                cm.Parameters.AddWithValue("@Qty", Convert.ToInt16(textqty.Text));
                cm.Parameters.AddWithValue("@Price", float.Parse(textprice.Text));
                cm.Parameters.AddWithValue("@GST", float.Parse(textgst.Text));
       
                cm.Parameters.AddWithValue("@Decription", textdecription.Text);
                cm.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Add Product  Successfuly Upadet!.");
                proClear();
                this.Dispose();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                proClear();

            }
        }

        private void textproid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textcgst_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textproid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textpronm.Focus();
            }
        }

        private void textpronm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textqty.Focus();
            }
        }

        private void textqty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textprice.Focus();
            }
        }

        private void textprice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textgst.Focus();
            }
        }

        private void textgst_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textdecription.Focus();
            }
        }

        private void textdecription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnmodulesave.Focus();
            }
        }

        private void textqty_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
