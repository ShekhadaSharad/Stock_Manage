namespace StockManage.Report
{
    partial class BillReportForm
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
            this.billboxBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stockmanagDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockmanagDataSet1 = new StockManage.StockmanagDataSet1();
            this.billProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.s_stockDataSet10 = new StockManage.s_stockDataSet10();
            this.BillboxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billboxTableAdapter = new StockManage.StockmanagDataSet1TableAdapters.BillboxTableAdapter();
            this.bill_ProductTableAdapter = new StockManage.s_stockDataSet10TableAdapters.Bill_ProductTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.Bill_no_s = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.billboxBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockmanagDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockmanagDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s_stockDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillboxBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // billboxBindingSource1
            // 
            this.billboxBindingSource1.DataMember = "Billbox";
            this.billboxBindingSource1.DataSource = this.stockmanagDataSet1BindingSource;
            // 
            // stockmanagDataSet1BindingSource
            // 
            this.stockmanagDataSet1BindingSource.DataSource = this.stockmanagDataSet1;
            this.stockmanagDataSet1BindingSource.Position = 0;
            // 
            // stockmanagDataSet1
            // 
            this.stockmanagDataSet1.DataSetName = "StockmanagDataSet1";
            this.stockmanagDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billProductBindingSource
            // 
            this.billProductBindingSource.DataMember = "Bill_Product";
            this.billProductBindingSource.DataSource = this.s_stockDataSet10;
            // 
            // s_stockDataSet10
            // 
            this.s_stockDataSet10.DataSetName = "s_stockDataSet10";
            this.s_stockDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BillboxBindingSource
            // 
            this.BillboxBindingSource.DataMember = "Billbox";
            this.BillboxBindingSource.DataSource = this.stockmanagDataSet1;
            // 
            // billboxTableAdapter
            // 
            this.billboxTableAdapter.ClearBeforeFill = true;
            // 
            // bill_ProductTableAdapter
            // 
            this.bill_ProductTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(403, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Print Bill";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Bill_no_s
            // 
            this.Bill_no_s.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill_no_s.Location = new System.Drawing.Point(114, 13);
            this.Bill_no_s.Name = "Bill_no_s";
            this.Bill_no_s.Size = new System.Drawing.Size(260, 27);
            this.Bill_no_s.TabIndex = 2;
            this.Bill_no_s.TextChanged += new System.EventHandler(this.BIll_no_s_TextChanged);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "StockManage.Report.Bill.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(113, 42);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(539, 527);
            this.reportViewer1.TabIndex = 3;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // BillReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 597);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.Bill_no_s);
            this.Controls.Add(this.button1);
            this.Name = "BillReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintBill";
            this.Load += new System.EventHandler(this.PrintBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.billboxBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockmanagDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockmanagDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s_stockDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillboxBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource stockmanagDataSet1BindingSource;
        private StockmanagDataSet1 stockmanagDataSet1;
        private System.Windows.Forms.BindingSource BillboxBindingSource;
        private System.Windows.Forms.BindingSource billboxBindingSource1;
        private StockmanagDataSet1TableAdapters.BillboxTableAdapter billboxTableAdapter;
        private s_stockDataSet10 s_stockDataSet10;
        private System.Windows.Forms.BindingSource billProductBindingSource;
        private s_stockDataSet10TableAdapters.Bill_ProductTableAdapter bill_ProductTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Bill_no_s;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}