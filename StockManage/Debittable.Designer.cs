namespace StockManage
{
    partial class Debittable
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Debittable));
            this.dgvUser_debit = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.text_user_search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.s_stockDataSet2 = new StockManage.s_stockDataSet2();
            this.debitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.debitTableAdapter = new StockManage.s_stockDataSet2TableAdapters.DebitTableAdapter();
            this.s_stockDataSet3 = new StockManage.s_stockDataSet3();
            this.debitUsreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.debit_UsreTableAdapter = new StockManage.s_stockDataSet3TableAdapters.Debit_UsreTableAdapter();
            this.sstockDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.debitUsreBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit_Debit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete_Debit = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser_debit)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.s_stockDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s_stockDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debitUsreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sstockDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debitUsreBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUser_debit
            // 
            this.dgvUser_debit.AllowUserToAddRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUser_debit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUser_debit.ColumnHeadersHeight = 26;
            this.dgvUser_debit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUser_debit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.BillNo,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Edit_Debit,
            this.Delete_Debit});
            this.dgvUser_debit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUser_debit.EnableHeadersVisualStyles = false;
            this.dgvUser_debit.Location = new System.Drawing.Point(0, 0);
            this.dgvUser_debit.Name = "dgvUser_debit";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUser_debit.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvUser_debit.RowHeadersVisible = false;
            this.dgvUser_debit.RowHeadersWidth = 51;
            this.dgvUser_debit.RowTemplate.Height = 24;
            this.dgvUser_debit.Size = new System.Drawing.Size(1128, 636);
            this.dgvUser_debit.TabIndex = 3;
            this.dgvUser_debit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_debit_CellContentClick);
            this.dgvUser_debit.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvUser_RowPostPaint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.text_user_search);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 592);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1128, 44);
            this.panel2.TabIndex = 4;
            // 
            // text_user_search
            // 
            this.text_user_search.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.text_user_search.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_user_search.Location = new System.Drawing.Point(418, 10);
            this.text_user_search.Name = "text_user_search";
            this.text_user_search.Size = new System.Drawing.Size(389, 23);
            this.text_user_search.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(282, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search Bar :- ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Debit User";
            // 
            // s_stockDataSet2
            // 
            this.s_stockDataSet2.DataSetName = "s_stockDataSet2";
            this.s_stockDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // debitBindingSource
            // 
            this.debitBindingSource.DataMember = "Debit";
            this.debitBindingSource.DataSource = this.s_stockDataSet2;
            // 
            // debitTableAdapter
            // 
            this.debitTableAdapter.ClearBeforeFill = true;
            // 
            // s_stockDataSet3
            // 
            this.s_stockDataSet3.DataSetName = "s_stockDataSet3";
            this.s_stockDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // debitUsreBindingSource
            // 
            this.debitUsreBindingSource.DataMember = "Debit_Usre";
            this.debitUsreBindingSource.DataSource = this.s_stockDataSet3;
            // 
            // debit_UsreTableAdapter
            // 
            this.debit_UsreTableAdapter.ClearBeforeFill = true;
            // 
            // sstockDataSet3BindingSource
            // 
            this.sstockDataSet3BindingSource.DataSource = this.s_stockDataSet3;
            this.sstockDataSet3BindingSource.Position = 0;
            // 
            // debitUsreBindingSource1
            // 
            this.debitUsreBindingSource1.DataMember = "Debit_Usre";
            this.debitUsreBindingSource1.DataSource = this.sstockDataSet3BindingSource;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "No";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 63;
            // 
            // BillNo
            // 
            this.BillNo.HeaderText = "Bill No";
            this.BillNo.MinimumWidth = 6;
            this.BillNo.Name = "BillNo";
            this.BillNo.Width = 125;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "User Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 130;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "City";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Mobile No";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "Debit $";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 99;
            // 
            // Edit_Debit
            // 
            this.Edit_Debit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit_Debit.HeaderText = "";
            this.Edit_Debit.Image = ((System.Drawing.Image)(resources.GetObject("Edit_Debit.Image")));
            this.Edit_Debit.MinimumWidth = 6;
            this.Edit_Debit.Name = "Edit_Debit";
            this.Edit_Debit.Width = 6;
            // 
            // Delete_Debit
            // 
            this.Delete_Debit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete_Debit.HeaderText = "";
            this.Delete_Debit.Image = ((System.Drawing.Image)(resources.GetObject("Delete_Debit.Image")));
            this.Delete_Debit.MinimumWidth = 6;
            this.Delete_Debit.Name = "Delete_Debit";
            this.Delete_Debit.Width = 6;
            // 
            // Debittable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 636);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvUser_debit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Debittable";
            this.Text = "Debittable";
            this.Load += new System.EventHandler(this.Debittable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser_debit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.s_stockDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s_stockDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debitUsreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sstockDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debitUsreBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUser_debit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox text_user_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private s_stockDataSet2 s_stockDataSet2;
        private System.Windows.Forms.BindingSource debitBindingSource;
        private s_stockDataSet2TableAdapters.DebitTableAdapter debitTableAdapter;
        private s_stockDataSet3 s_stockDataSet3;
        private System.Windows.Forms.BindingSource debitUsreBindingSource;
        private s_stockDataSet3TableAdapters.Debit_UsreTableAdapter debit_UsreTableAdapter;
        private System.Windows.Forms.BindingSource sstockDataSet3BindingSource;
        private System.Windows.Forms.BindingSource debitUsreBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn Edit_Debit;
        private System.Windows.Forms.DataGridViewImageColumn Delete_Debit;
    }
}