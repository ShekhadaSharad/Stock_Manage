namespace StockManage
{
    partial class billbox
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(billbox));
            this.date_day = new System.Windows.Forms.DateTimePicker();
            this.text_bill_no = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.text_user_gst = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.text_user_address = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.text_user_mo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_add_pro = new System.Windows.Forms.Button();
            this.text_qty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_totel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_itme = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_discount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_net_amount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.text_sub_totel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.bnt_print = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.text_paid_amount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox_user = new System.Windows.Forms.ComboBox();
            this.radiobtn_cash = new System.Windows.Forms.RadioButton();
            this.radiobtn_debit = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.listView_1 = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Products = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.billboxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.text_product_gst = new System.Windows.Forms.TextBox();
            this.text_Pro_gst = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.text_sgst = new System.Windows.Forms.TextBox();
            this.text_cgst = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.listView_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billboxBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // date_day
            // 
            this.date_day.Location = new System.Drawing.Point(316, 148);
            this.date_day.Name = "date_day";
            this.date_day.Size = new System.Drawing.Size(200, 22);
            this.date_day.TabIndex = 42;
            // 
            // text_bill_no
            // 
            this.text_bill_no.Location = new System.Drawing.Point(672, 148);
            this.text_bill_no.Name = "text_bill_no";
            this.text_bill_no.ReadOnly = true;
            this.text_bill_no.Size = new System.Drawing.Size(214, 22);
            this.text_bill_no.TabIndex = 41;
            this.text_bill_no.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_bill_no_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(563, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 16);
            this.label12.TabIndex = 40;
            this.label12.Text = "Bill No :-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(211, 148);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 16);
            this.label13.TabIndex = 39;
            this.label13.Text = "Date  :-";
            // 
            // text_user_gst
            // 
            this.text_user_gst.Location = new System.Drawing.Point(672, 77);
            this.text_user_gst.Name = "text_user_gst";
            this.text_user_gst.Size = new System.Drawing.Size(214, 22);
            this.text_user_gst.TabIndex = 38;
            this.text_user_gst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_user_gst_KeyDown);
            this.text_user_gst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_user_gst_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(563, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 16);
            this.label11.TabIndex = 37;
            this.label11.Text = "GST IN :-";
            // 
            // text_user_address
            // 
            this.text_user_address.Location = new System.Drawing.Point(316, 112);
            this.text_user_address.Name = "text_user_address";
            this.text_user_address.Size = new System.Drawing.Size(569, 22);
            this.text_user_address.TabIndex = 36;
            this.text_user_address.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_user_address_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(211, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 35;
            this.label10.Text = "Address :-";
            // 
            // text_user_mo
            // 
            this.text_user_mo.Location = new System.Drawing.Point(316, 74);
            this.text_user_mo.Name = "text_user_mo";
            this.text_user_mo.Size = new System.Drawing.Size(214, 22);
            this.text_user_mo.TabIndex = 34;
            this.text_user_mo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_user_mo_KeyDown);
            this.text_user_mo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_user_mo_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(211, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 33;
            this.label9.Text = "MO :-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(211, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "M / S :-";
            // 
            // btn_add_pro
            // 
            this.btn_add_pro.Location = new System.Drawing.Point(752, 183);
            this.btn_add_pro.Name = "btn_add_pro";
            this.btn_add_pro.Size = new System.Drawing.Size(134, 28);
            this.btn_add_pro.TabIndex = 51;
            this.btn_add_pro.Text = "Add Itme";
            this.btn_add_pro.UseVisualStyleBackColor = true;
            this.btn_add_pro.Click += new System.EventHandler(this.button1_Click);
            this.btn_add_pro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_add_pro_KeyDown);
            // 
            // text_qty
            // 
            this.text_qty.Location = new System.Drawing.Point(337, 236);
            this.text_qty.Name = "text_qty";
            this.text_qty.Size = new System.Drawing.Size(124, 22);
            this.text_qty.TabIndex = 50;
            this.text_qty.TextChanged += new System.EventHandler(this.text_qty_TextChanged);
            this.text_qty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_qty_KeyDown);
            this.text_qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_qty_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 49;
            this.label4.Text = "Qty";
            // 
            // text_totel
            // 
            this.text_totel.Location = new System.Drawing.Point(601, 235);
            this.text_totel.Name = "text_totel";
            this.text_totel.Size = new System.Drawing.Size(124, 22);
            this.text_totel.TabIndex = 48;
            this.text_totel.TextChanged += new System.EventHandler(this.text_totel_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(641, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "Totel";
            // 
            // text_price
            // 
            this.text_price.Location = new System.Drawing.Point(214, 236);
            this.text_price.Name = "text_price";
            this.text_price.Size = new System.Drawing.Size(124, 22);
            this.text_price.TabIndex = 46;
            this.text_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_price_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 45;
            this.label2.Text = "Price";
            // 
            // comboBox_itme
            // 
            this.comboBox_itme.FormattingEnabled = true;
            this.comboBox_itme.Location = new System.Drawing.Point(316, 185);
            this.comboBox_itme.Name = "comboBox_itme";
            this.comboBox_itme.Size = new System.Drawing.Size(363, 24);
            this.comboBox_itme.TabIndex = 44;
            this.comboBox_itme.SelectedIndexChanged += new System.EventHandler(this.comboBox_itme_SelectedIndexChanged);
            this.comboBox_itme.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_itme_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Select Itme :- ";
            // 
            // text_discount
            // 
            this.text_discount.Location = new System.Drawing.Point(490, 486);
            this.text_discount.Name = "text_discount";
            this.text_discount.Size = new System.Drawing.Size(124, 22);
            this.text_discount.TabIndex = 59;
            this.text_discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_discount.TextChanged += new System.EventHandler(this.text_discount_TextChanged);
            this.text_discount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_discount_KeyDown);
            this.text_discount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_discount_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(420, 489);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 58;
            this.label5.Text = "Discount :-";
            // 
            // text_net_amount
            // 
            this.text_net_amount.Location = new System.Drawing.Point(762, 485);
            this.text_net_amount.Name = "text_net_amount";
            this.text_net_amount.ReadOnly = true;
            this.text_net_amount.Size = new System.Drawing.Size(124, 22);
            this.text_net_amount.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(664, 489);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 56;
            this.label6.Text = "Net Amount :-";
            // 
            // text_sub_totel
            // 
            this.text_sub_totel.Location = new System.Drawing.Point(285, 486);
            this.text_sub_totel.Name = "text_sub_totel";
            this.text_sub_totel.ReadOnly = true;
            this.text_sub_totel.Size = new System.Drawing.Size(124, 22);
            this.text_sub_totel.TabIndex = 55;
            this.text_sub_totel.Text = "0";
            this.text_sub_totel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 489);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 54;
            this.label7.Text = "Sub Totel :-";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(210, 584);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(106, 27);
            this.btn_save.TabIndex = 60;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // bnt_print
            // 
            this.bnt_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_print.Location = new System.Drawing.Point(477, 584);
            this.bnt_print.Name = "bnt_print";
            this.bnt_print.Size = new System.Drawing.Size(106, 27);
            this.bnt_print.TabIndex = 61;
            this.bnt_print.Text = "Print ";
            this.bnt_print.UseVisualStyleBackColor = true;
            this.bnt_print.Click += new System.EventHandler(this.bnt_print_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(342, 584);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(106, 27);
            this.btn_clear.TabIndex = 62;
            this.btn_clear.Text = "Clear ";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // text_paid_amount
            // 
            this.text_paid_amount.Location = new System.Drawing.Point(762, 580);
            this.text_paid_amount.Name = "text_paid_amount";
            this.text_paid_amount.ReadOnly = true;
            this.text_paid_amount.Size = new System.Drawing.Size(124, 22);
            this.text_paid_amount.TabIndex = 64;
            this.text_paid_amount.TextChanged += new System.EventHandler(this.text_paid_amount_TextChanged);
            this.text_paid_amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_paid_amount_KeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(657, 584);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 16);
            this.label14.TabIndex = 63;
            this.label14.Text = "Paid Amount :-";
            // 
            // comboBox_user
            // 
            this.comboBox_user.FormattingEnabled = true;
            this.comboBox_user.Location = new System.Drawing.Point(316, 36);
            this.comboBox_user.Name = "comboBox_user";
            this.comboBox_user.Size = new System.Drawing.Size(569, 24);
            this.comboBox_user.TabIndex = 67;
            this.comboBox_user.SelectedIndexChanged += new System.EventHandler(this.comboBox_user_SelectedIndexChanged);
            this.comboBox_user.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_user_KeyDown);
            // 
            // radiobtn_cash
            // 
            this.radiobtn_cash.AutoSize = true;
            this.radiobtn_cash.Location = new System.Drawing.Point(472, 4);
            this.radiobtn_cash.Name = "radiobtn_cash";
            this.radiobtn_cash.Size = new System.Drawing.Size(59, 20);
            this.radiobtn_cash.TabIndex = 69;
            this.radiobtn_cash.TabStop = true;
            this.radiobtn_cash.Text = "Cash";
            this.radiobtn_cash.UseVisualStyleBackColor = true;
            this.radiobtn_cash.CheckedChanged += new System.EventHandler(this.radiobtn_cash_CheckedChanged);
            // 
            // radiobtn_debit
            // 
            this.radiobtn_debit.AutoSize = true;
            this.radiobtn_debit.Location = new System.Drawing.Point(582, 4);
            this.radiobtn_debit.Name = "radiobtn_debit";
            this.radiobtn_debit.Size = new System.Drawing.Size(63, 20);
            this.radiobtn_debit.TabIndex = 70;
            this.radiobtn_debit.TabStop = true;
            this.radiobtn_debit.Text = "Debit ";
            this.radiobtn_debit.UseVisualStyleBackColor = true;
            this.radiobtn_debit.CheckedChanged += new System.EventHandler(this.radiobtn_debit_CheckedChanged);
            // 
            // listView_1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listView_1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listView_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listView_1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Products,
            this.Price,
            this.Qty,
            this.GST,
            this.Amount,
            this.ProDelete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listView_1.DefaultCellStyle = dataGridViewCellStyle2;
            this.listView_1.EnableHeadersVisualStyles = false;
            this.listView_1.Location = new System.Drawing.Point(207, 276);
            this.listView_1.Name = "listView_1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listView_1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.listView_1.RowHeadersVisible = false;
            this.listView_1.RowHeadersWidth = 51;
            this.listView_1.RowTemplate.Height = 24;
            this.listView_1.Size = new System.Drawing.Size(679, 199);
            this.listView_1.TabIndex = 71;
            this.listView_1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listView_1_CellContentClick);
            this.listView_1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.listView_1_RowPostPaint);
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.No.Frozen = true;
            this.No.HeaderText = "No";
            this.No.MinimumWidth = 6;
            this.No.Name = "No";
            this.No.Width = 54;
            // 
            // Products
            // 
            this.Products.Frozen = true;
            this.Products.HeaderText = "Products";
            this.Products.MinimumWidth = 6;
            this.Products.Name = "Products";
            this.Products.Width = 350;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Price.Frozen = true;
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 67;
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Qty.Frozen = true;
            this.Qty.HeaderText = "Qty";
            this.Qty.MinimumWidth = 6;
            this.Qty.Name = "Qty";
            this.Qty.Width = 56;
            // 
            // GST
            // 
            this.GST.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.GST.Frozen = true;
            this.GST.HeaderText = "GST";
            this.GST.MinimumWidth = 6;
            this.GST.Name = "GST";
            this.GST.Width = 64;
            // 
            // Amount
            // 
            this.Amount.Frozen = true;
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.Width = 90;
            // 
            // ProDelete
            // 
            this.ProDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProDelete.Frozen = true;
            this.ProDelete.HeaderText = "";
            this.ProDelete.Image = ((System.Drawing.Image)(resources.GetObject("ProDelete.Image")));
            this.ProDelete.MinimumWidth = 6;
            this.ProDelete.Name = "ProDelete";
            this.ProDelete.Width = 24;
            // 
            // billboxBindingSource
            // 
            this.billboxBindingSource.DataMember = "Billbox";
            // 
            // text_product_gst
            // 
            this.text_product_gst.Location = new System.Drawing.Point(460, 236);
            this.text_product_gst.Name = "text_product_gst";
            this.text_product_gst.Size = new System.Drawing.Size(124, 22);
            this.text_product_gst.TabIndex = 73;
            this.text_product_gst.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // text_Pro_gst
            // 
            this.text_Pro_gst.AutoSize = true;
            this.text_Pro_gst.Location = new System.Drawing.Point(501, 214);
            this.text_Pro_gst.Name = "text_Pro_gst";
            this.text_Pro_gst.Size = new System.Drawing.Size(35, 16);
            this.text_Pro_gst.TabIndex = 72;
            this.text_Pro_gst.Text = "GST";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(762, 540);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(25, 22);
            this.textBox2.TabIndex = 75;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(696, 547);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 16);
            this.label15.TabIndex = 74;
            this.label15.Text = "CGST :-";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(762, 513);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(25, 22);
            this.textBox3.TabIndex = 77;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(696, 519);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 16);
            this.label16.TabIndex = 76;
            this.label16.Text = "SGST :-";
            // 
            // text_sgst
            // 
            this.text_sgst.Location = new System.Drawing.Point(793, 513);
            this.text_sgst.Name = "text_sgst";
            this.text_sgst.ReadOnly = true;
            this.text_sgst.Size = new System.Drawing.Size(92, 22);
            this.text_sgst.TabIndex = 79;
            // 
            // text_cgst
            // 
            this.text_cgst.Location = new System.Drawing.Point(793, 540);
            this.text_cgst.Name = "text_cgst";
            this.text_cgst.ReadOnly = true;
            this.text_cgst.Size = new System.Drawing.Size(92, 22);
            this.text_cgst.TabIndex = 80;
            // 
            // billbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 620);
            this.Controls.Add(this.text_cgst);
            this.Controls.Add(this.text_sgst);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.text_product_gst);
            this.Controls.Add(this.text_Pro_gst);
            this.Controls.Add(this.listView_1);
            this.Controls.Add(this.radiobtn_debit);
            this.Controls.Add(this.radiobtn_cash);
            this.Controls.Add(this.comboBox_user);
            this.Controls.Add(this.text_paid_amount);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.bnt_print);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.text_discount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text_net_amount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.text_sub_totel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_add_pro);
            this.Controls.Add(this.text_qty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_totel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_itme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date_day);
            this.Controls.Add(this.text_bill_no);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.text_user_gst);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.text_user_address);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.text_user_mo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "billbox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "billbox";
            this.Load += new System.EventHandler(this.billbox_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.billbox_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.listView_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billboxBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_add_pro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button bnt_print;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.ComboBox comboBox_user;
        public System.Windows.Forms.TextBox text_user_mo;
        public System.Windows.Forms.TextBox text_user_address;
        private System.Windows.Forms.RadioButton radiobtn_cash;
        private System.Windows.Forms.RadioButton radiobtn_debit;
        public System.Windows.Forms.DateTimePicker date_day;
        public System.Windows.Forms.TextBox text_bill_no;
        public System.Windows.Forms.TextBox text_user_gst;
        public System.Windows.Forms.TextBox text_qty;
        public System.Windows.Forms.TextBox text_totel;
        public System.Windows.Forms.TextBox text_price;
        public System.Windows.Forms.ComboBox comboBox_itme;
        public System.Windows.Forms.TextBox text_discount;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox text_net_amount;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox text_sub_totel;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox text_paid_amount;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView listView_1;
   
        private System.Windows.Forms.BindingSource billboxBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Products;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn GST;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewImageColumn ProDelete;
        public System.Windows.Forms.TextBox text_product_gst;
        private System.Windows.Forms.Label text_Pro_gst;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox text_sgst;
        public System.Windows.Forms.TextBox text_cgst;
    }
}