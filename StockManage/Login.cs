using Microsoft.Reporting.Map.WebForms.BingMaps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManage
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

       

        private void checkBoxpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxpass.Checked == false)
                textpass.UseSystemPasswordChar = true;
            else
                textpass.UseSystemPasswordChar = false;

        }
        private void submit_Click(object sender, EventArgs e)
        {

            if(textUname.Text=="8866795143"&& textpass.Text=="8866795143")
            {


                progressBar1.Minimum = 0;
                progressBar1.Maximum = 100;
                for (int i=0;i<=100;i++)
                {
                    progressBar1.Value= i;
                    Thread.Sleep(10);

                }

                MainForm Mf = new MainForm();
                Mf.Show();
            }
            else
            {
                MessageBox.Show("Encrrect id Password");

            }
            textUname.Clear();
            textpass.Clear();
            Login LO = new Login();
            LO.Dispose();

        }
        //void timer1_Tick(object sender , EventHandler e)
        //{
        //    if (progressBar1.Value !=10)
        //    {
        //        progressBar1.Value++;

        //    }
        //    else
        //    {
        //        timer1.Stop();
        //    }
        //}
        private void openchildform(MainForm mainForm)
        {
            throw new NotImplementedException();
        }

        private void pictureBoxexit_Click(object sender, EventArgs e)
        {
            //if(MessageBox.Show("Exit Application","confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            //{
            //    Application.Exit();
            //}
            Login LO = new Login();
            LO.Dispose();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textUname.Clear();
            textpass.Clear();
        }
        public void idpassword()
        {
           

        }

        private void Login_Load(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //this.progressBar1.Increment(1);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            //this.timer1.Start();
        }
    }
}
