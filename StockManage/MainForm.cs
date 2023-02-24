using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManage
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openchildform(new Users());
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            billbox Bm = new billbox();
            Bm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            openchildform(new ProductManag());
        }

      

        private void MainForm_Load(object sender, EventArgs e)
        {
            Login LO = new Login();
            LO.Dispose();
        }
        private Form activeform = null;
        private void openchildform(Form childform)
        {
            if (activeform != null)
                activeform.Close();
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panel3.Controls.Add(childform);
            panel3.BringToFront();
            childform.BringToFront();
            childform.Show();
        }

        

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            openchildform(new Debittable());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            openchildform(new Billmanage());
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            new Report.BillReportForm().Show();
        }

       
    }
}
