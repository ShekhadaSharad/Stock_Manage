namespace StockManage
{
    partial class ProductModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductModule));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBoxexit = new System.Windows.Forms.PictureBox();
            this.btnmoduleupdet = new System.Windows.Forms.Button();
            this.btnmoduleclear = new System.Windows.Forms.Button();
            this.btnmodulesave = new System.Windows.Forms.Button();
            this.textprice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textpronm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textqty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textproid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textdecription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textgst = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxexit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBoxexit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 41);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(258, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Product Module";
            // 
            // pictureBoxexit
            // 
            this.pictureBoxexit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxexit.Image")));
            this.pictureBoxexit.Location = new System.Drawing.Point(663, 0);
            this.pictureBoxexit.Name = "pictureBoxexit";
            this.pictureBoxexit.Size = new System.Drawing.Size(24, 23);
            this.pictureBoxexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxexit.TabIndex = 14;
            this.pictureBoxexit.TabStop = false;
            this.pictureBoxexit.Click += new System.EventHandler(this.pictureBoxexit_Click);
            // 
            // btnmoduleupdet
            // 
            this.btnmoduleupdet.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmoduleupdet.Location = new System.Drawing.Point(380, 367);
            this.btnmoduleupdet.Name = "btnmoduleupdet";
            this.btnmoduleupdet.Size = new System.Drawing.Size(112, 34);
            this.btnmoduleupdet.TabIndex = 23;
            this.btnmoduleupdet.Text = "Updet";
            this.btnmoduleupdet.UseVisualStyleBackColor = true;
            this.btnmoduleupdet.Click += new System.EventHandler(this.btnmoduleupdet_Click);
            // 
            // btnmoduleclear
            // 
            this.btnmoduleclear.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmoduleclear.Location = new System.Drawing.Point(524, 367);
            this.btnmoduleclear.Name = "btnmoduleclear";
            this.btnmoduleclear.Size = new System.Drawing.Size(112, 34);
            this.btnmoduleclear.TabIndex = 22;
            this.btnmoduleclear.Text = "Clear";
            this.btnmoduleclear.UseVisualStyleBackColor = true;
            this.btnmoduleclear.Click += new System.EventHandler(this.btnmoduleclear_Click);
            // 
            // btnmodulesave
            // 
            this.btnmodulesave.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodulesave.Location = new System.Drawing.Point(236, 367);
            this.btnmodulesave.Name = "btnmodulesave";
            this.btnmodulesave.Size = new System.Drawing.Size(112, 34);
            this.btnmodulesave.TabIndex = 21;
            this.btnmodulesave.Text = "Save ";
            this.btnmodulesave.UseVisualStyleBackColor = true;
            this.btnmodulesave.Click += new System.EventHandler(this.btnmodulesave_Click);
            // 
            // textprice
            // 
            this.textprice.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textprice.Location = new System.Drawing.Point(239, 216);
            this.textprice.Name = "textprice";
            this.textprice.Size = new System.Drawing.Size(401, 28);
            this.textprice.TabIndex = 20;
            this.textprice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textprice_KeyDown);
            this.textprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textcgst_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(132, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Price  :-";
            // 
            // textpronm
            // 
            this.textpronm.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpronm.Location = new System.Drawing.Point(239, 126);
            this.textpronm.Name = "textpronm";
            this.textpronm.Size = new System.Drawing.Size(401, 28);
            this.textpronm.TabIndex = 18;
            this.textpronm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textpronm_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Pro Name  :-";
            // 
            // textqty
            // 
            this.textqty.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textqty.Location = new System.Drawing.Point(239, 171);
            this.textqty.Name = "textqty";
            this.textqty.Size = new System.Drawing.Size(401, 28);
            this.textqty.TabIndex = 16;
            this.textqty.TextChanged += new System.EventHandler(this.textqty_TextChanged);
            this.textqty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textqty_KeyDown);
            this.textqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textqty_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Qty  :-";
            // 
            // textproid
            // 
            this.textproid.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textproid.Location = new System.Drawing.Point(239, 83);
            this.textproid.Name = "textproid";
            this.textproid.Size = new System.Drawing.Size(401, 28);
            this.textproid.TabIndex = 14;
            this.textproid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textproid_KeyDown);
            this.textproid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textproid_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Product Id :-";
            // 
            // textdecription
            // 
            this.textdecription.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textdecription.Location = new System.Drawing.Point(239, 306);
            this.textdecription.Name = "textdecription";
            this.textdecription.Size = new System.Drawing.Size(401, 28);
            this.textdecription.TabIndex = 25;
            this.textdecription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textdecription_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(95, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 19);
            this.label5.TabIndex = 24;
            this.label5.Text = "Decription :-";
            // 
            // textgst
            // 
            this.textgst.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textgst.Location = new System.Drawing.Point(239, 258);
            this.textgst.Name = "textgst";
            this.textgst.Size = new System.Drawing.Size(401, 28);
            this.textgst.TabIndex = 27;
            this.textgst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textgst_KeyDown);
            this.textgst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textcgst_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(132, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 26;
            this.label7.Text = "GST  :-";
            // 
            // ProductModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 440);
            this.Controls.Add(this.textgst);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textdecription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnmoduleupdet);
            this.Controls.Add(this.btnmoduleclear);
            this.Controls.Add(this.btnmodulesave);
            this.Controls.Add(this.textprice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textpronm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textqty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textproid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductModule";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxexit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBoxexit;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button btnmoduleupdet;
        public System.Windows.Forms.Button btnmoduleclear;
        public System.Windows.Forms.Button btnmodulesave;
        public System.Windows.Forms.TextBox textprice;
        public System.Windows.Forms.TextBox textpronm;
        public System.Windows.Forms.TextBox textqty;
        public System.Windows.Forms.TextBox textproid;
        public System.Windows.Forms.TextBox textdecription;
        public System.Windows.Forms.TextBox textgst;
    }
}