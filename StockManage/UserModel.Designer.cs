namespace StockManage
{
    partial class UserModel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserModel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxexit = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textshopnm = new System.Windows.Forms.TextBox();
            this.textcity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textfullnm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textphone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnusersave = new System.Windows.Forms.Button();
            this.btnuserclear = new System.Windows.Forms.Button();
            this.btnuserupdet = new System.Windows.Forms.Button();
            this.textshopgst = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxexit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBoxexit);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 54);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxexit
            // 
            this.pictureBoxexit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxexit.Image")));
            this.pictureBoxexit.Location = new System.Drawing.Point(647, 3);
            this.pictureBoxexit.Name = "pictureBoxexit";
            this.pictureBoxexit.Size = new System.Drawing.Size(24, 23);
            this.pictureBoxexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxexit.TabIndex = 13;
            this.pictureBoxexit.TabStop = false;
            this.pictureBoxexit.Click += new System.EventHandler(this.pictureBoxexit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(303, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Manag Users ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Shop Name :-";
            // 
            // textshopnm
            // 
            this.textshopnm.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textshopnm.Location = new System.Drawing.Point(244, 112);
            this.textshopnm.Name = "textshopnm";
            this.textshopnm.Size = new System.Drawing.Size(401, 28);
            this.textshopnm.TabIndex = 3;
            this.textshopnm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textshopnm_KeyDown);
            // 
            // textcity
            // 
            this.textcity.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcity.Location = new System.Drawing.Point(244, 200);
            this.textcity.Name = "textcity";
            this.textcity.Size = new System.Drawing.Size(401, 28);
            this.textcity.TabIndex = 5;
            this.textcity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textcity_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "City  :-";
            // 
            // textfullnm
            // 
            this.textfullnm.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textfullnm.Location = new System.Drawing.Point(244, 155);
            this.textfullnm.Name = "textfullnm";
            this.textfullnm.Size = new System.Drawing.Size(401, 28);
            this.textfullnm.TabIndex = 7;
            this.textfullnm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textfullnm_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Full Name  :-";
            // 
            // textphone
            // 
            this.textphone.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textphone.Location = new System.Drawing.Point(244, 245);
            this.textphone.Name = "textphone";
            this.textphone.Size = new System.Drawing.Size(401, 28);
            this.textphone.TabIndex = 9;
            this.textphone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textphone_KeyDown);
            this.textphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textphone_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phone NO  :-";
            // 
            // btnusersave
            // 
            this.btnusersave.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnusersave.Location = new System.Drawing.Point(241, 344);
            this.btnusersave.Name = "btnusersave";
            this.btnusersave.Size = new System.Drawing.Size(112, 34);
            this.btnusersave.TabIndex = 10;
            this.btnusersave.Text = "Save ";
            this.btnusersave.UseVisualStyleBackColor = true;
            this.btnusersave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnuserclear
            // 
            this.btnuserclear.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuserclear.Location = new System.Drawing.Point(529, 344);
            this.btnuserclear.Name = "btnuserclear";
            this.btnuserclear.Size = new System.Drawing.Size(112, 34);
            this.btnuserclear.TabIndex = 11;
            this.btnuserclear.Text = "Clear";
            this.btnuserclear.UseVisualStyleBackColor = true;
            this.btnuserclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnuserupdet
            // 
            this.btnuserupdet.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuserupdet.Location = new System.Drawing.Point(385, 344);
            this.btnuserupdet.Name = "btnuserupdet";
            this.btnuserupdet.Size = new System.Drawing.Size(112, 34);
            this.btnuserupdet.TabIndex = 12;
            this.btnuserupdet.Text = "Updet";
            this.btnuserupdet.UseVisualStyleBackColor = true;
            this.btnuserupdet.Click += new System.EventHandler(this.btnuserupdet_Click);
            // 
            // textshopgst
            // 
            this.textshopgst.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textshopgst.Location = new System.Drawing.Point(244, 287);
            this.textshopgst.Name = "textshopgst";
            this.textshopgst.Size = new System.Drawing.Size(401, 28);
            this.textshopgst.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(98, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Shop GST";
            // 
            // UserModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 421);
            this.Controls.Add(this.textshopgst);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnuserupdet);
            this.Controls.Add(this.btnuserclear);
            this.Controls.Add(this.btnusersave);
            this.Controls.Add(this.textphone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textfullnm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textcity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textshopnm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserModel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserModel";
            this.Load += new System.EventHandler(this.UserModel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxexit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxexit;
        public System.Windows.Forms.TextBox textshopnm;
        public System.Windows.Forms.TextBox textcity;
        public System.Windows.Forms.TextBox textfullnm;
        public System.Windows.Forms.TextBox textphone;
        public System.Windows.Forms.Button btnusersave;
        public System.Windows.Forms.Button btnuserclear;
        public System.Windows.Forms.Button btnuserupdet;
        public System.Windows.Forms.TextBox textshopgst;
        private System.Windows.Forms.Label label6;
    }
}