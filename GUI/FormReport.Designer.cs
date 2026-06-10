namespace GUI
{
    partial class FormReport
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.btn_excelOut = new System.Windows.Forms.Button();
            this.btn_showReport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbb_dayFill = new System.Windows.Forms.ComboBox();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_outCome = new System.Windows.Forms.Label();
            this.lbl_grossProfit = new System.Windows.Forms.Label();
            this.lbl_productSold = new System.Windows.Forms.Label();
            this.lbl_invoiceNum = new System.Windows.Forms.Label();
            this.lbl_warranty = new System.Windows.Forms.Label();
            this.dgv_listInvoices = new System.Windows.Forms.DataGridView();
            this.col_maHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_thoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_khachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_sanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_doanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_loiNhuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_thanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_footer = new System.Windows.Forms.Panel();
            this.lbl_footerLeft = new System.Windows.Forms.Label();
            this.lbl_footerRight = new System.Windows.Forms.Label();
            this.pnl_top.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listInvoices)).BeginInit();
            this.pnl_footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_top.Controls.Add(this.btn_excelOut);
            this.pnl_top.Controls.Add(this.btn_showReport);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(1587, 102);
            this.pnl_top.TabIndex = 1;
            // 
            // btn_showReport
            // 
            this.btn_showReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_showReport.Location = new System.Drawing.Point(20, 20);
            this.btn_showReport.Name = "btn_showReport";
            this.btn_showReport.Size = new System.Drawing.Size(250, 60);
            this.btn_showReport.TabIndex = 0;
            this.btn_showReport.Text = "📊 Xem báo cáo";
            this.btn_showReport.UseVisualStyleBackColor = true;
            this.btn_showReport.Click += new System.EventHandler(this.btn_xemBaocao_Click);
            // 
            // btn_excelOut
            // 
            this.btn_excelOut.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_excelOut.Location = new System.Drawing.Point(280, 20);
            this.btn_excelOut.Name = "btn_excelOut";
            this.btn_excelOut.Size = new System.Drawing.Size(200, 60);
            this.btn_excelOut.TabIndex = 1;
            this.btn_excelOut.Text = "📤 Xuất Excel";
            this.btn_excelOut.UseVisualStyleBackColor = true;
            this.btn_excelOut.Click += new System.EventHandler(this.btn_xuatExcel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.cbb_dayFill);
            this.groupBox1.Controls.Add(this.dtp_from);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtp_to);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1587, 260);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // cbb_dayFill
            // 
            this.cbb_dayFill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_dayFill.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.cbb_dayFill.FormattingEnabled = true;
            this.cbb_dayFill.Items.AddRange(new object[] {
            "Hôm nay",
            "Hôm qua",
            "7 ngày qua",
            "Tháng này",
            "Tùy chỉnh"});
            this.cbb_dayFill.Location = new System.Drawing.Point(20, 30);
            this.cbb_dayFill.Name = "cbb_dayFill";
            this.cbb_dayFill.Size = new System.Drawing.Size(250, 31);
            this.cbb_dayFill.TabIndex = 3;
            this.cbb_dayFill.SelectedIndexChanged += new System.EventHandler(this.cbb_dayFill_SelectedIndexChanged);
            // 
            // dtp_from
            // 
            this.dtp_from.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.dtp_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_from.Location = new System.Drawing.Point(290, 30);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.Size = new System.Drawing.Size(180, 30);
            this.dtp_from.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label1.Location = new System.Drawing.Point(480, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Đến:";
            // 
            // dtp_to
            // 
            this.dtp_to.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.dtp_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_to.Location = new System.Drawing.Point(535, 30);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.Size = new System.Drawing.Size(180, 30);
            this.dtp_to.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_outCome);
            this.panel3.Controls.Add(this.lbl_grossProfit);
            this.panel3.Controls.Add(this.lbl_productSold);
            this.panel3.Controls.Add(this.lbl_invoiceNum);
            this.panel3.Controls.Add(this.lbl_warranty);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1581, 172);
            this.panel3.TabIndex = 7;
            // 
            // lbl_outCome
            // 
            this.lbl_outCome.BackColor = System.Drawing.Color.White;
            this.lbl_outCome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_outCome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_outCome.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_outCome.Location = new System.Drawing.Point(17, 10);
            this.lbl_outCome.Name = "lbl_outCome";
            this.lbl_outCome.Size = new System.Drawing.Size(295, 150);
            this.lbl_outCome.TabIndex = 0;
            this.lbl_outCome.Text = "0 đ\nDoanh thu";
            this.lbl_outCome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_grossProfit
            // 
            this.lbl_grossProfit.BackColor = System.Drawing.Color.White;
            this.lbl_grossProfit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_grossProfit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_grossProfit.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_grossProfit.Location = new System.Drawing.Point(327, 10);
            this.lbl_grossProfit.Name = "lbl_grossProfit";
            this.lbl_grossProfit.Size = new System.Drawing.Size(295, 150);
            this.lbl_grossProfit.TabIndex = 1;
            this.lbl_grossProfit.Text = "0 đ\nLợi nhuận gộp";
            this.lbl_grossProfit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_productSold
            // 
            this.lbl_productSold.BackColor = System.Drawing.Color.White;
            this.lbl_productSold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_productSold.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_productSold.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_productSold.Location = new System.Drawing.Point(637, 10);
            this.lbl_productSold.Name = "lbl_productSold";
            this.lbl_productSold.Size = new System.Drawing.Size(295, 150);
            this.lbl_productSold.TabIndex = 2;
            this.lbl_productSold.Text = "0\nSản phẩm bán ra";
            this.lbl_productSold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_invoiceNum
            // 
            this.lbl_invoiceNum.BackColor = System.Drawing.Color.White;
            this.lbl_invoiceNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_invoiceNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_invoiceNum.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_invoiceNum.Location = new System.Drawing.Point(947, 10);
            this.lbl_invoiceNum.Name = "lbl_invoiceNum";
            this.lbl_invoiceNum.Size = new System.Drawing.Size(295, 150);
            this.lbl_invoiceNum.TabIndex = 3;
            this.lbl_invoiceNum.Text = "0\nSố hóa đơn";
            this.lbl_invoiceNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_warranty
            // 
            this.lbl_warranty.BackColor = System.Drawing.Color.White;
            this.lbl_warranty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_warranty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_warranty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_warranty.Location = new System.Drawing.Point(1257, 10);
            this.lbl_warranty.Name = "lbl_warranty";
            this.lbl_warranty.Size = new System.Drawing.Size(295, 150);
            this.lbl_warranty.TabIndex = 4;
            this.lbl_warranty.Text = "0\nBảo hành";
            this.lbl_warranty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_listInvoices
            // 
            this.dgv_listInvoices.AllowUserToAddRows = false;
            this.dgv_listInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_listInvoices.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_listInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_maHD,
            this.col_thoiGian,
            this.col_khachHang,
            this.col_sanPham,
            this.col_doanhThu,
            this.col_loiNhuan,
            this.col_thanhToan});
            this.dgv_listInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_listInvoices.Location = new System.Drawing.Point(0, 362);
            this.dgv_listInvoices.Name = "dgv_listInvoices";
            this.dgv_listInvoices.ReadOnly = true;
            this.dgv_listInvoices.RowHeadersVisible = false;
            this.dgv_listInvoices.RowHeadersWidth = 51;
            this.dgv_listInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listInvoices.Size = new System.Drawing.Size(1587, 486);
            this.dgv_listInvoices.TabIndex = 2;
            this.dgv_listInvoices.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_listInvoices_DataBindingComplete);
            // 
            // col_maHD
            // 
            this.col_maHD.DataPropertyName = "InvoiceCode";
            this.col_maHD.HeaderText = "Mã HĐ";
            this.col_maHD.Name = "col_maHD";
            this.col_maHD.ReadOnly = true;
            // 
            // col_thoiGian
            // 
            this.col_thoiGian.DataPropertyName = "SaleDate";
            this.col_thoiGian.HeaderText = "Thời gian";
            this.col_thoiGian.Name = "col_thoiGian";
            this.col_thoiGian.ReadOnly = true;
            // 
            // col_khachHang
            // 
            this.col_khachHang.DataPropertyName = "CustomerName";
            this.col_khachHang.HeaderText = "Khách Hàng";
            this.col_khachHang.Name = "col_khachHang";
            this.col_khachHang.ReadOnly = true;
            // 
            // col_sanPham
            // 
            this.col_sanPham.DataPropertyName = "ProductSummary";
            this.col_sanPham.HeaderText = "Sản Phẩm";
            this.col_sanPham.Name = "col_sanPham";
            this.col_sanPham.ReadOnly = true;
            // 
            // col_doanhThu
            // 
            this.col_doanhThu.DataPropertyName = "FinalAmount";
            this.col_doanhThu.HeaderText = "Doanh Thu";
            this.col_doanhThu.Name = "col_doanhThu";
            this.col_doanhThu.ReadOnly = true;
            // 
            // col_loiNhuan
            // 
            this.col_loiNhuan.DataPropertyName = "RowProfit";
            this.col_loiNhuan.HeaderText = "Lợi nhuận";
            this.col_loiNhuan.Name = "col_loiNhuan";
            this.col_loiNhuan.ReadOnly = true;
            // 
            // col_thanhToan
            // 
            this.col_thanhToan.DataPropertyName = "PaymentMethod";
            this.col_thanhToan.HeaderText = "Thanh toán";
            this.col_thanhToan.Name = "col_thanhToan";
            this.col_thanhToan.ReadOnly = true;
            // 
            // pnl_footer
            // 
            this.pnl_footer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_footer.Controls.Add(this.lbl_footerRight);
            this.pnl_footer.Controls.Add(this.lbl_footerLeft);
            this.pnl_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_footer.Location = new System.Drawing.Point(0, 848);
            this.pnl_footer.Name = "pnl_footer";
            this.pnl_footer.Size = new System.Drawing.Size(1587, 102);
            this.pnl_footer.TabIndex = 8;
            // 
            // lbl_footerLeft
            // 
            this.lbl_footerLeft.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_footerLeft.Location = new System.Drawing.Point(20, 25);
            this.lbl_footerLeft.Name = "lbl_footerLeft";
            this.lbl_footerLeft.Size = new System.Drawing.Size(500, 50);
            this.lbl_footerLeft.TabIndex = 0;
            this.lbl_footerLeft.Text = "Báo cáo ngày:";
            this.lbl_footerLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_footerRight
            // 
            this.lbl_footerRight.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_footerRight.Location = new System.Drawing.Point(1052, 25);
            this.lbl_footerRight.Name = "lbl_footerRight";
            this.lbl_footerRight.Size = new System.Drawing.Size(500, 50);
            this.lbl_footerRight.TabIndex = 1;
            this.lbl_footerRight.Text = "Tỉ lệ lợi nhuận: 0%";
            this.lbl_footerRight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1587, 950);
            this.Controls.Add(this.dgv_listInvoices);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnl_footer);
            this.Controls.Add(this.pnl_top);
            this.Name = "FormReport";
            this.Text = "Báo cáo doanh thu";
            this.Load += new System.EventHandler(this.FormReport_Load);
            this.pnl_top.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listInvoices)).EndInit();
            this.pnl_footer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Button btn_showReport;
        private System.Windows.Forms.Button btn_excelOut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbb_dayFill;
        private System.Windows.Forms.DateTimePicker dtp_from;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_outCome;
        private System.Windows.Forms.Label lbl_grossProfit;
        private System.Windows.Forms.Label lbl_productSold;
        private System.Windows.Forms.Label lbl_invoiceNum;
        private System.Windows.Forms.Label lbl_warranty;
        private System.Windows.Forms.DataGridView dgv_listInvoices;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_maHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_thoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_khachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_sanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_doanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_loiNhuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_thanhToan;
        private System.Windows.Forms.Panel pnl_footer;
        private System.Windows.Forms.Label lbl_footerLeft;
        private System.Windows.Forms.Label lbl_footerRight;
    }
}