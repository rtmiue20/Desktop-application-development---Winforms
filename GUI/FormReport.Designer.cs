using System.ComponentModel;

namespace GUI;

partial class FormReport
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        components = new System.ComponentModel.Container();
        pnl_top = new System.Windows.Forms.Panel();
        btn_excelOut = new System.Windows.Forms.Button();
        btn_showReport = new System.Windows.Forms.Button();
        panel2 = new System.Windows.Forms.Panel();
        button3 = new System.Windows.Forms.Button();
        button4 = new System.Windows.Forms.Button();
        dgv_listInvoices = new System.Windows.Forms.DataGridView();
        col_maHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_thoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_khachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_sanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_doanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_loiNhuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_thanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
        imageList1 = new System.Windows.Forms.ImageList(components);
        cbb_dayFill = new System.Windows.Forms.ComboBox();
        dtp_from = new System.Windows.Forms.DateTimePicker();
        label1 = new System.Windows.Forms.Label();
        dtp_to = new System.Windows.Forms.DateTimePicker();
        panel3 = new System.Windows.Forms.Panel();
        lbl_warranty = new System.Windows.Forms.Label();
        lbl_invoiceNum = new System.Windows.Forms.Label();
        lbl_productSold = new System.Windows.Forms.Label();
        lbl_grossProfit = new System.Windows.Forms.Label();
        lbl_doanhThu = new System.Windows.Forms.Label();
        pnl_footer = new System.Windows.Forms.Panel();
        lbl_footerRight = new System.Windows.Forms.Label();
        lbl_footerLeft = new System.Windows.Forms.Label();
        groupBox1 = new System.Windows.Forms.GroupBox();
        pnl_top.SuspendLayout();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgv_listInvoices).BeginInit();
        panel3.SuspendLayout();
        pnl_footer.SuspendLayout();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // pnl_top
        // 
        pnl_top.Controls.Add(btn_excelOut);
        pnl_top.Controls.Add(btn_showReport);
        pnl_top.Location = new System.Drawing.Point(0, 2);
        pnl_top.Name = "pnl_top";
        pnl_top.Size = new System.Drawing.Size(1683, 85);
        pnl_top.TabIndex = 1;
        pnl_top.Paint += pnl_Top_Paint;
        // 
        // btn_excelOut
        // 
        btn_excelOut.Location = new System.Drawing.Point(874, 14);
        btn_excelOut.Name = "btn_excelOut";
        btn_excelOut.Size = new System.Drawing.Size(802, 68);
        btn_excelOut.TabIndex = 1;
        btn_excelOut.Text = "📤Xuất Excel";
        btn_excelOut.UseVisualStyleBackColor = true;
        // 
        // btn_showReport
        // 
        btn_showReport.Location = new System.Drawing.Point(18, 14);
        btn_showReport.Name = "btn_showReport";
        btn_showReport.Size = new System.Drawing.Size(850, 68);
        btn_showReport.TabIndex = 0;
        btn_showReport.Text = "📊Xem báo cáo";
        btn_showReport.UseVisualStyleBackColor = true;
        // 
        // panel2
        // 
        panel2.Controls.Add(button3);
        panel2.Controls.Add(button4);
        panel2.Location = new System.Drawing.Point(36, 48);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(731, 75);
        panel2.TabIndex = 3;
        // 
        // button3
        // 
        button3.Location = new System.Drawing.Point(589, 16);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(116, 42);
        button3.TabIndex = 1;
        button3.Text = "button2";
        button3.UseVisualStyleBackColor = true;
        // 
        // button4
        // 
        button4.Location = new System.Drawing.Point(457, 16);
        button4.Name = "button4";
        button4.Size = new System.Drawing.Size(116, 42);
        button4.TabIndex = 0;
        button4.Text = "button1";
        button4.UseVisualStyleBackColor = true;
        // 
        // dgv_listInvoices
        // 
        dgv_listInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgv_listInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { col_maHD, col_thoiGian, col_khachHang, col_sanPham, col_doanhThu, col_loiNhuan, col_thanhToan });
        dgv_listInvoices.Location = new System.Drawing.Point(-4, 494);
        dgv_listInvoices.Name = "dgv_listInvoices";
        dgv_listInvoices.RowHeadersWidth = 51;
        dgv_listInvoices.Size = new System.Drawing.Size(1687, 599);
        dgv_listInvoices.TabIndex = 2;
        dgv_listInvoices.Text = "dataGridView1";
        // 
        // col_maHD
        // 
        col_maHD.HeaderText = "Mã HĐ";
        col_maHD.MinimumWidth = 6;
        col_maHD.Name = "col_maHD";
        col_maHD.Width = 150;
        // 
        // col_thoiGian
        // 
        col_thoiGian.HeaderText = "Thời gian";
        col_thoiGian.MinimumWidth = 6;
        col_thoiGian.Name = "col_thoiGian";
        col_thoiGian.Width = 150;
        // 
        // col_khachHang
        // 
        col_khachHang.HeaderText = "Khách Hàng";
        col_khachHang.MinimumWidth = 6;
        col_khachHang.Name = "col_khachHang";
        col_khachHang.Width = 150;
        // 
        // col_sanPham
        // 
        col_sanPham.HeaderText = "Sản Phẩm";
        col_sanPham.MinimumWidth = 6;
        col_sanPham.Name = "col_sanPham";
        col_sanPham.Width = 150;
        // 
        // col_doanhThu
        // 
        col_doanhThu.HeaderText = "Doanh Thu";
        col_doanhThu.MinimumWidth = 6;
        col_doanhThu.Name = "col_doanhThu";
        col_doanhThu.Width = 150;
        // 
        // col_loiNhuan
        // 
        col_loiNhuan.HeaderText = "Lợi nhuân";
        col_loiNhuan.MinimumWidth = 6;
        col_loiNhuan.Name = "col_loiNhuan";
        col_loiNhuan.Width = 150;
        // 
        // col_thanhToan
        // 
        col_thanhToan.HeaderText = "Thanh toán";
        col_thanhToan.MinimumWidth = 6;
        col_thanhToan.Name = "col_thanhToan";
        col_thanhToan.Width = 150;
        // 
        // imageList1
        // 
        imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
        imageList1.ImageSize = new System.Drawing.Size(16, 16);
        imageList1.TransparentColor = System.Drawing.Color.Transparent;
        // 
        // cbb_dayFill
        // 
        cbb_dayFill.FormattingEnabled = true;
        cbb_dayFill.Items.AddRange(new object[] { "Hôm nay", "", "Hôm qua", "", "7 ngày qua", "", "Tháng này", "", "Tùy chỉnh" });
        cbb_dayFill.Location = new System.Drawing.Point(18, 31);
        cbb_dayFill.Name = "cbb_dayFill";
        cbb_dayFill.Size = new System.Drawing.Size(1658, 49);
        cbb_dayFill.TabIndex = 3;
        // 
        // dtp_from
        // 
        dtp_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        dtp_from.Location = new System.Drawing.Point(18, 101);
        dtp_from.Name = "dtp_from";
        dtp_from.Size = new System.Drawing.Size(1658, 47);
        dtp_from.TabIndex = 4;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(12, 151);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(107, 40);
        label1.TabIndex = 5;
        label1.Text = "Đến:";
        label1.Click += label1_Click;
        // 
        // dtp_to
        // 
        dtp_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        dtp_to.Location = new System.Drawing.Point(12, 194);
        dtp_to.Name = "dtp_to";
        dtp_to.Size = new System.Drawing.Size(1664, 47);
        dtp_to.TabIndex = 6;
        // 
        // panel3
        // 
        panel3.Controls.Add(lbl_warranty);
        panel3.Controls.Add(lbl_invoiceNum);
        panel3.Controls.Add(lbl_productSold);
        panel3.Controls.Add(lbl_grossProfit);
        panel3.Controls.Add(lbl_doanhThu);
        panel3.Location = new System.Drawing.Point(0, 237);
        panel3.Name = "panel3";
        panel3.Size = new System.Drawing.Size(1683, 177);
        panel3.TabIndex = 7;
        // 
        // lbl_warranty
        // 
        lbl_warranty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        lbl_warranty.Location = new System.Drawing.Point(1108, 21);
        lbl_warranty.Name = "lbl_warranty";
        lbl_warranty.Size = new System.Drawing.Size(575, 50);
        lbl_warranty.TabIndex = 4;
        lbl_warranty.Text = "Bảo hành phát sinh";
        lbl_warranty.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        // 
        // lbl_invoiceNum
        // 
        lbl_invoiceNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        lbl_invoiceNum.Location = new System.Drawing.Point(12, 20);
        lbl_invoiceNum.Name = "lbl_invoiceNum";
        lbl_invoiceNum.Size = new System.Drawing.Size(504, 50);
        lbl_invoiceNum.TabIndex = 3;
        lbl_invoiceNum.Text = "Số hóa đơn";
        lbl_invoiceNum.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        // 
        // lbl_productSold
        // 
        lbl_productSold.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        lbl_productSold.Location = new System.Drawing.Point(522, 21);
        lbl_productSold.Name = "lbl_productSold";
        lbl_productSold.Size = new System.Drawing.Size(580, 50);
        lbl_productSold.TabIndex = 2;
        lbl_productSold.Text = "Sản phẩm bán ra";
        lbl_productSold.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        // 
        // lbl_grossProfit
        // 
        lbl_grossProfit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        lbl_grossProfit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        lbl_grossProfit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        lbl_grossProfit.Location = new System.Drawing.Point(0, 21);
        lbl_grossProfit.Name = "lbl_grossProfit";
        lbl_grossProfit.Size = new System.Drawing.Size(1683, 128);
        lbl_grossProfit.TabIndex = 1;
        lbl_grossProfit.Text = "Lợi nhuận gộp (đ)";
        lbl_grossProfit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        // 
        // lbl_doanhThu
        // 
        lbl_doanhThu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        lbl_doanhThu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        lbl_doanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        lbl_doanhThu.Location = new System.Drawing.Point(18, 21);
        lbl_doanhThu.Name = "lbl_doanhThu";
        lbl_doanhThu.Size = new System.Drawing.Size(1062, 128);
        lbl_doanhThu.TabIndex = 0;
        lbl_doanhThu.Text = "Doanh thu (đ)";
        lbl_doanhThu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        // 
        // pnl_footer
        // 
        pnl_footer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        pnl_footer.Controls.Add(lbl_footerRight);
        pnl_footer.Controls.Add(lbl_footerLeft);
        pnl_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
        pnl_footer.Location = new System.Drawing.Point(0, 1099);
        pnl_footer.Name = "pnl_footer";
        pnl_footer.Size = new System.Drawing.Size(1688, 53);
        pnl_footer.TabIndex = 8;
        // 
        // lbl_footerRight
        // 
        lbl_footerRight.Location = new System.Drawing.Point(872, 0);
        lbl_footerRight.Name = "lbl_footerRight";
        lbl_footerRight.Size = new System.Drawing.Size(802, 51);
        lbl_footerRight.TabIndex = 1;
        lbl_footerRight.Text = "Tỉ lệ lợi nhuân";
        // 
        // lbl_footerLeft
        // 
        lbl_footerLeft.Location = new System.Drawing.Point(0, 0);
        lbl_footerLeft.Name = "lbl_footerLeft";
        lbl_footerLeft.Size = new System.Drawing.Size(866, 51);
        lbl_footerLeft.TabIndex = 0;
        lbl_footerLeft.Text = "Báo cáo ngày:";
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(cbb_dayFill);
        groupBox1.Controls.Add(dtp_from);
        groupBox1.Controls.Add(panel3);
        groupBox1.Controls.Add(label1);
        groupBox1.Controls.Add(dtp_to);
        groupBox1.Location = new System.Drawing.Point(0, 93);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(1683, 395);
        groupBox1.TabIndex = 9;
        groupBox1.TabStop = false;
        // 
        // FormReport
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1688, 1152);
        Controls.Add(groupBox1);
        Controls.Add(pnl_footer);
        Controls.Add(dgv_listInvoices);
        Controls.Add(pnl_top);
        Margin = new System.Windows.Forms.Padding(6);
        Text = "Báo cáo doanh thu";
        pnl_top.ResumeLayout(false);
        panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgv_listInvoices).EndInit();
        panel3.ResumeLayout(false);
        pnl_footer.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label lbl_footerLeft;
    private System.Windows.Forms.Label lbl_footerRight;

    private System.Windows.Forms.Panel pnl_footer;

    private System.Windows.Forms.DataGridViewTextBoxColumn col_maHD;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_thoiGian;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_khachHang;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_sanPham;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_doanhThu;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_loiNhuan;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_thanhToan;

    private System.Windows.Forms.Label lbl_invoiceNum;
    private System.Windows.Forms.Label lbl_warranty;

    private System.Windows.Forms.Label lbl_productSold;

    private System.Windows.Forms.Label lbl_grossProfit;

    private System.Windows.Forms.Label lbl_doanhThu;

    private System.Windows.Forms.Panel panel3;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DateTimePicker dtp_to;

    private System.Windows.Forms.DateTimePicker dtp_from;

    private System.Windows.Forms.ComboBox cbb_dayFill;

    private System.Windows.Forms.ImageList imageList1;

    private System.Windows.Forms.Button btn_showReport;
    private System.Windows.Forms.Button btn_excelOut;

    private System.Windows.Forms.DataGridView dgv_listInvoices;
    private System.Windows.Forms.Panel pnl_top;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;

    #endregion
}