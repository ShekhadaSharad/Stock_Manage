namespace StockManage
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxexit = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Uname = new System.Windows.Forms.Label();
            this.textUname = new System.Windows.Forms.TextBox();
            this.textpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.submit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxpass = new System.Windows.Forms.CheckBox();
            this.Clear = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxexit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBoxexit);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(428, 74);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(65, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Stock Management System";
            // 
            // pictureBoxexit
            // 
            this.pictureBoxexit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxexit.Image")));
            this.pictureBoxexit.Location = new System.Drawing.Point(401, 1);
            this.pictureBoxexit.Name = "pictureBoxexit";
            this.pictureBoxexit.Size = new System.Drawing.Size(24, 23);
            this.pictureBoxexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxexit.TabIndex = 11;
            this.pictureBoxexit.TabStop = false;
            this.pictureBoxexit.Click += new System.EventHandler(this.pictureBoxexit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Uname
            // 
            this.Uname.AutoSize = true;
            this.Uname.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uname.ForeColor = System.Drawing.Color.Black;
            this.Uname.Location = new System.Drawing.Point(46, 251);
            this.Uname.Name = "Uname";
            this.Uname.Size = new System.Drawing.Size(116, 19);
            this.Uname.TabIndex = 2;
            this.Uname.Text = "User Name :-";
            // 
            // textUname
            // 
            this.textUname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUname.Location = new System.Drawing.Point(43, 273);
            this.textUname.Name = "textUname";
            this.textUname.Size = new System.Drawing.Size(344, 24);
            this.textUname.TabIndex = 3;
            // 
            // textpass
            // 
            this.textpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpass.Location = new System.Drawing.Point(43, 343);
            this.textpass.Name = "textpass";
            this.textpass.Size = new System.Drawing.Size(343, 24);
            this.textpass.TabIndex = 5;
            this.textpass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(46, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password :-";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(159, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(33, 414);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(353, 48);
            this.submit.TabIndex = 7;
            this.submit.Text = "Login ";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(161, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Login First";
            // 
            // checkBoxpass
            // 
            this.checkBoxpass.AutoSize = true;
            this.checkBoxpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxpass.Location = new System.Drawing.Point(277, 491);
            this.checkBoxpass.Name = "checkBoxpass";
            this.checkBoxpass.Size = new System.Drawing.Size(106, 22);
            this.checkBoxpass.TabIndex = 9;
            this.checkBoxpass.Text = "Show Pass";
            this.checkBoxpass.UseVisualStyleBackColor = true;
            this.checkBoxpass.CheckedChanged += new System.EventHandler(this.checkBoxpass_CheckedChanged);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.Black;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.Color.White;
            this.Clear.Location = new System.Drawing.Point(33, 486);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 30);
            this.Clear.TabIndex = 10;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progressBar1.Location = new System.Drawing.Point(0, 559);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(428, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(428, 584);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.checkBoxpass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textpass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textUname);
            this.Controls.Add(this.Uname);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxexit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Uname;
        private System.Windows.Forms.TextBox textUname;
        private System.Windows.Forms.TextBox textpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxpass;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.PictureBox pictureBoxexit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}

