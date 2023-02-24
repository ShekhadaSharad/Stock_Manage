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
using System.Runtime.Remoting.Contexts;
using System.Data.OleDb;
using System.Runtime.InteropServices;

namespace StockManage
{
    public partial class billbox : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=s_stock;Integrated Security=True");
        SqlCommand cm = new SqlCommand();

        public billbox()
        {
            InitializeComponent();
            Product_insert();
            


        }

        private void btn_save_Click(object sender, EventArgs e)
        {
           
            try
            {
                //insert  data to BIllbox table 
                if (comboBox_user.Text != "" && text_user_mo.Text != "" && text_user_gst.Text != "" && text_user_address.Text != "" && comboBox_itme.Text != "" && text_price.Text != "" && text_qty.Text != "" && text_sgst.Text != ""&& text_cgst.Text != "") 
                {

                    SqlCommand cm = new SqlCommand("insert into Billbox(user_name,mobile_no,gst_in,user_address,date,bill_no,sub_totel,discount,net_amount,paid_amount,SGST,CGST) values(@user_name,@mobile_no,@gst_in,@user_address,@date,@bill_no,@sub_totel,@discount,@net_amount,@paid_amount,@SGST,@CGST)", con);
                    cm.Parameters.AddWithValue("@user_name",comboBox_user.Text);
                    cm.Parameters.AddWithValue("@mobile_no", text_user_mo.Text);
                    cm.Parameters.AddWithValue("@gst_in", text_user_gst.Text);
                    cm.Parameters.AddWithValue("@user_address", text_user_address.Text);
                    cm.Parameters.AddWithValue("@date", Convert.ToString(date_day.Text));
                    cm.Parameters.AddWithValue("@bill_no", text_bill_no.Text);
                    cm.Parameters.AddWithValue("@sub_totel",float.Parse (text_sub_totel.Text));
                    cm.Parameters.AddWithValue("@discount",float.Parse(text_discount.Text));
                    cm.Parameters.AddWithValue("@net_amount", float.Parse(text_net_amount.Text));
                    cm.Parameters.AddWithValue("@paid_amount", float.Parse(text_paid_amount.Text));
                    cm.Parameters.AddWithValue("@SGST", float.Parse(text_sgst.Text));
                    cm.Parameters.AddWithValue("@CGST", float.Parse(text_cgst.Text));
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    //MessageBox.Show("User has been Successfuly saved.");




                    //insert data to Debit table
                    if (radiobtn_debit.Checked == true)
                    {
                        if (text_bill_no.Text != "" && comboBox_user.Text != "" && text_user_address.Text != "" && text_user_mo.Text != "" && text_paid_amount.Text != "")
                        {

                            SqlCommand db = new SqlCommand("insert into Debit(Bill_No,User_Name,User_City,Mobile_No,Rupya_Baki) values(@Bill_No,@User_Name,@User_City,@Mobile_No,@Rupya_Baki)", con);
                            db.Parameters.AddWithValue("@Bill_No", text_bill_no.Text);
                            db.Parameters.AddWithValue("@User_Name", comboBox_user.Text);
                            db.Parameters.AddWithValue("@User_City", text_user_address.Text);
                            db.Parameters.AddWithValue("@Mobile_No", text_user_mo.Text);
                            db.Parameters.AddWithValue("@Rupya_Baki",float.Parse(text_paid_amount.Text));
                            con.Open();
                            db.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Debit has been Successfuly saved.");
                           
                        }
                        
                    }
                    

                    //insert date to BIll_Product Table Save All Product  
                    for (int i = 0; i <= listView_1.Rows.Count; ++i)
                    {
                        
                            SqlCommand cmd = new SqlCommand("insert into Bill_Product(bill_no,Product_Name,Qty,Price,Total,GST) values(@bill_no,@Product_Name,@Qty,@Price,@Total,@GST)", con);
                            cmd.Parameters.AddWithValue("@bill_no", text_bill_no.Text);
                            cmd.Parameters.AddWithValue("@Product_Name", listView_1.Rows[i].Cells[1].Value);
                            cmd.Parameters.AddWithValue("@Qty", listView_1.Rows[i].Cells[3].Value);
                            cmd.Parameters.AddWithValue("@Price", listView_1.Rows[i].Cells[2].Value);
                            cmd.Parameters.AddWithValue("@Total", listView_1.Rows[i].Cells[5].Value);
                            cmd.Parameters.AddWithValue("@GST", listView_1.Rows[i].Cells[4].Value);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                       

                    }

                    MessageBox.Show("Bill Added Success fully", "SUCCESS", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Error :: " + e, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                Userclear();



            }

            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }


            this.Dispose();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Userclear();
        }
        private void Userclear()
        {
            
            text_user_mo.Clear();
            text_user_gst.Clear();
            text_user_address.Clear();
            text_bill_no.Clear();
            text_price.Clear();
            text_qty.Clear();
            text_totel.Clear();
            text_sub_totel.Clear();
            text_sub_totel.Clear();
            text_discount.Clear();
            text_net_amount.Clear();
            text_paid_amount.Clear();
            text_sgst.Clear();
            text_cgst.Clear();
          
        }

        private void comboBox_itme_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=s_stock;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from ProductManag where Pro_name='"+comboBox_itme.SelectedItem.ToString()+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox_itme.Text = dr["Pro_name"].ToString();
              text_price.Text = dr["Price"].ToString();
                text_product_gst.Text = dr["GST"].ToString();

            }
            con.Close();
           
        }
       public void Product_insert()
        {
            //data base to  select data and insert data Product comboBox 
            comboBox_itme.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Pro_name from ProductManag ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox_itme.Items.Add(dr["Pro_name"].ToString());
            }
            con.Close();


        }

        private void billbox_Load(object sender, EventArgs e)
        {
           
            //GetProductId();
            // TODO: This line of code loads data into the 'stockmanagDataSet.Billbox' table. You can move, or remove it, as needed.
         //   this.billboxTableAdapter.Fill(this.stockmanagDataSet.Billbox);
            Product_insert();
            User_insert();
            text_sub_totel.Enabled = false;
            text_totel.Enabled = false;
            BillnoLoad();


        }

      

        private void text_totel_TextChanged(object sender, EventArgs e)
        {
            text_totel.Text = (Convert.ToInt16(text_price.Text) * Convert.ToInt16(text_qty.Text)).ToString();
        }

        private void text_qty_TextChanged(object sender, EventArgs e)
        {
            if (text_qty.Text.Length > 0)
            {
                text_totel.Text = (Convert.ToInt16(text_price.Text) * Convert.ToInt16(text_qty.Text) + Convert.ToInt16( text_product_gst.Text) ).ToString();
            }
        }
        //private void dgv1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        //{
        //    this.listView_1.Rows[e.RowIndex].Cells["No"].Value = (e.RowIndex + 1).ToString();
        //}
        private void button1_Click(object sender, EventArgs e)
        {





            con.Open();
            if (text_totel.Text == "")
            {
                MessageBox.Show("please enter valid information", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else

            {
               
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(listView_1);
                newRow.Cells[1].Value = comboBox_itme.Text.ToString();
                newRow.Cells[2].Value = text_price.Text;
                newRow.Cells[3].Value = text_qty.Text;
                newRow.Cells[4].Value = text_product_gst.Text;
                newRow.Cells[5].Value = text_totel.Text;
                listView_1.Rows.Add(newRow);

                //con.Open();
                SqlCommand cmdupdatestock = new SqlCommand("update ProductManag set ProductManag.Qty=ProductManag.Qty-'" + Convert.ToInt16(text_qty.Text) + "'where ProductManag.Pro_name='"+comboBox_itme.Text+"'", con);
                int res = cmdupdatestock.ExecuteNonQuery();



                //cm = new SqlCommand("UPDATE ProductManag SET Product_id=@Product_id  WHERE Qty LIKE '" + text_qty.Text + "' ", con);
                //update  ProductManag set Qry= 100 -newRow.Cells[3].Value = text_qty.Text; where Pro_NAme = newRow.Cells[1].Value = comboBox_itme.Text.ToString();

                int sum = 0;
                for (int i = 0; i < listView_1.Rows.Count; ++i)
                {
                    sum += Convert.ToInt32(listView_1.Rows[i].Cells[4].Value);
                }
                listView_1.Text = sum.ToString();
            }

            if (text_user_gst.Text==null && text_price.Text==null && text_totel.Text==null)
            {
                MessageBox.Show("aenter value");  
            }
            else
            {
                 text_sub_totel.Text = (Convert.ToInt16(text_sub_totel.Text) + Convert.ToInt16(text_totel.Text)).ToString();
            }

            con.Close();

        }
       
        public void User_insert()
        {
            comboBox_user.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select Fullnm from UserMOdule ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox_user.Items.Add(dr["Fullnm"].ToString());
            }
            con.Close();
        }

        private void comboBox_user_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sharad\OneDrive\Documents\Stockmanag.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from UserMOdule where Fullnm='" + comboBox_user.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox_user.Text = dr["Fullnm "].ToString();
                text_user_mo.Text = dr["Phone"].ToString();
                text_user_address.Text = dr["City"].ToString();
                text_user_gst.Text = dr["ShopGST"].ToString();

            }
            con.Close();

        }

        private void text_user_mo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void radiobtn_cash_CheckedChanged(object sender, EventArgs e)
        {
            radiobtn_cash.ForeColor = System.Drawing.Color.Green;
            radiobtn_debit.ForeColor = System.Drawing.Color.Red;

        }

        private void radiobtn_debit_CheckedChanged(object sender, EventArgs e)
        {
            radiobtn_cash.ForeColor = System.Drawing.Color.Red;
            radiobtn_debit.ForeColor = System.Drawing.Color.Green;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (listView_1.SelectedCells.Count > 0)
            //{
            //    for (int i = 0; i < listView_1.Rows.Count; i++)
            //    {
            //        if (listView_1.Rows[i].Selected)
            //        {
            //            text_sub_totel.Text = (Convert.ToInt16(text_sub_totel.Text) - Convert.ToInt16(listView_1.Rows[i].SubItems[4].Text)).ToString();
            //            listView_1.Rows[i].Remove();
            //        }
            //    }
            //}
            //if (listView_1.SelectedItems.Count > 0)
            //{
            //    for(int i=0; i < listView_1.Items.Count; i++)
            //    {
            //        if (listView_1.Items[i].Selected) 
            //        {
            //            text_sub_totel.Text = (Convert.ToInt16(text_sub_totel.Text) - Convert.ToInt16(listView_1.Items[i].SubItems[5].Text)).ToString();
            //            listView_1.Items[i].Remove();
            //        }
            //    }
            //}
        }

        private void text_discount_TextChanged(object sender, EventArgs e)
        {
            if (text_discount.Text.Length > 0) 
            {
                text_net_amount.Text =  (Convert.ToInt16(text_sub_totel.Text) - Convert.ToInt16(text_discount.Text)).ToString();
            }

            
        }

        private void text_paid_amount_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void text_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void text_qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void text_discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void listView_1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.listView_1.Rows[e.RowIndex].Cells["No"].Value = (e.RowIndex + 1).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView_1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 1)
            {
                if (e.RowIndex > -1)
                {
                    if (MessageBox.Show("Are you sure you want to delete product ! ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                       
                        int grand_total = Convert.ToInt32(text_totel.Text) - Convert.ToInt32(listView_1.Rows[e.RowIndex].Cells[6].Value);
                        text_totel.Text = grand_total.ToString();

                        listView_1.Rows.Remove(listView_1.Rows[e.RowIndex]);
                      
                    }
                }
            }
            if (e.ColumnIndex == 2)
            {
                if (e.RowIndex > -1)
                {
                    comboBox_itme.Text = listView_1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    text_price.Text = listView_1.Rows[e.RowIndex].Cells[5].Value.ToString();
                    text_qty.Text = listView_1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    text_totel.Text = listView_1.Rows[e.RowIndex].Cells[6].Value.ToString();
                    listView_1.Rows.Remove(listView_1.Rows[e.RowIndex]);
                  
                }
            }
            if (e.ColumnIndex == 6)
            {
                if (e.RowIndex > -1)
                {
                    if (MessageBox.Show("Are you sure you want to delete product ! ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SqlCommand cmdaddstock = new SqlCommand("Update ProductManag set Qty=Qty+'" + Convert.ToInt16(listView_1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString()) + "' Where Pro_Name='" + listView_1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString() + "'", con);
                        con.Open();
                        int res = cmdaddstock.ExecuteNonQuery();
                        con.Close();
                        //  int grand_total = Convert.ToInt32(lbltotal.Text) - Convert.ToInt32(dgv1.Rows[e.RowIndex].Cells[6].Value);
                        //  lbltotal.Text = grand_total.ToString();

                        listView_1.Rows.Remove(listView_1.Rows[e.RowIndex]);
                    }
                }
            }
            //String colName = listView_1.Columns[e.ColumnIndex].Name;
            //if (colName == "ProDelete")
            //{
            //    if (MessageBox.Show("Are you sure Want to delete this user?", "Delete Record?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        con.Open();
            //        cm = new SqlCommand("DELETE FROM Billbox WHERE itme_name LIKE '" + listView_1.Rows[e.RowIndex].Cells[4].Value.ToString() + "'", con);
            //        cm.ExecuteNonQuery();
            //        con.Close();
            //        MessageBox.Show("Record has successfuly Deleted");
            //    }
            //}
        }
        private void billbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboBox_user.Focus();
            }
        }

        private void text_user_gst_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox_user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_user_mo.Focus();
            }
        }

        private void text_user_gst_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_user_address.Focus();
            }
        }

        private void text_user_mo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_user_gst.Focus();
            }
        }

        private void text_user_address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_bill_no.Focus();
            }
        }

        private void text_bill_no_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboBox_itme.Focus();
            }
        }

        private void comboBox_itme_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_qty.Focus();
            }
        }

        private void text_qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_add_pro.Focus();

            }
        }

        private void text_discount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox3.Focus();
            }

        }

        private void text_paid_amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_save.Focus();
            }

        }

        private void btn_add_pro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_discount.Focus();
            }
        }

        private void bnt_print_Click(object sender, EventArgs e)
        {
            new Report.BillReportForm().Show();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void text_totel_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {

            }
            else
            {
                float SGST = 0.000f; 
                    SGST = float.Parse(textBox3.Text);
                text_sgst.Text = ((float.Parse(text_net_amount.Text) * SGST) / 100).ToString();
            }
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {

            }
            else
            {
                float CGST = 0.000f;
                

                CGST = float.Parse(textBox2.Text);
               // MessageBox.Show(""+CGST);
                text_cgst.Text = ((Convert.ToInt16(text_net_amount.Text) * CGST) / 100).ToString();
                float Total = float.Parse(text_net_amount.Text) + float.Parse(text_sgst.Text) + float.Parse(text_cgst.Text);
                
                text_paid_amount.Text = Total.ToString();

            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_paid_amount.Focus();
            }
        }
        private void BillnoLoad()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=s_stock;Integrated Security=True");
            SqlCommand cm = new SqlCommand();
            con.Open();
            SqlCommand billno = new SqlCommand("SELECT MAX(bill_no) FROM BillBox", con);
            SqlDataReader reader = billno.ExecuteReader();
            while (reader.Read())
            {
                int x = Int32.Parse(reader.GetValue(0).ToString());
                x += 1;
                text_bill_no.Text = x.ToString();
            }

            con.Close();



        }
           

        }
    }
        