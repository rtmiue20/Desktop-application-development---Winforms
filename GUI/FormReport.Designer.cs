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
        pnl_Top = new System.Windows.Forms.Panel();
        btn_xuatExcel = new System.Windows.Forms.Button();
        btn_xemBaocao = new System.Windows.Forms.Button();
        panel2 = new System.Windows.Forms.Panel();
        button3 = new System.Windows.Forms.Button();
        button4 = new System.Windows.Forms.Button();
        dgv_danhSachHD = new System.Windows.Forms.DataGridView();
        col_maHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_thoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_khachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_sanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_doanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_loiNhuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_thanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
        imageList1 = new System.Windows.Forms.ImageList(components);
        cbb_locNgsy = new System.Windows.Forms.ComboBox();
        dtp_tu = new System.Windows.Forms.DateTimePicker();
        label1 = new System.Windows.Forms.Label();
        dtp_den = new System.Windows.Forms.DateTimePicker();
        panel3 = new System.Windows.Forms.Panel();
        lbl_baoHanhphatsinh = new System.Windows.Forms.Label();
        lbl_soHoadon = new System.Windows.Forms.Label();
        lbl_sanPhambanra = new System.Windows.Forms.Label();
        lbl_loiNhuangop = new System.Windows.Forms.Label();
        lbl_doanhThu = new System.Windows.Forms.Label();
        pnl_footer = new System.Windows.Forms.Panel();
        lbl_footerLeft = new System.Windows.Forms.Label();
        lbl_footerRight = new System.Windows.Forms.Label();
        pnl_Top.SuspendLayout();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgv_danhSachHD).BeginInit();
        panel3.SuspendLayout();
        pnl_footer.SuspendLayout();
        SuspendLayout();
        // 
        // pnl_Top
        // 
        pnl_Top.Controls.Add(btn_xuatExcel);
        pnl_Top.Controls.Add(btn_xemBaocao);
        pnl_Top.Location = new System.Drawing.Point(12, 12);
        pnl_Top.Name = "pnl_Top";
        pnl_Top.Size = new System.Drawing.Size(874, 75);
        pnl_Top.TabIndex = 1;
        pnl_Top.Paint += pnl_Top_Paint;
        // 
        // btn_xuatExcel
        // 
        btn_xuatExcel.Location = new System.Drawing.Point(185, 14);
        btn_xuatExcel.Name = "btn_xuatExcel";
        btn_xuatExcel.Size = new System.Drawing.Size(126, 50);
        btn_xuatExcel.TabIndex = 1;
        btn_xuatExcel.Text = "📤Xuất Excel";
        btn_xuatExcel.UseVisualStyleBackColor = true;
        // 
        // btn_xemBaocao
        // 
        btn_xemBaocao.Location = new System.Drawing.Point(18, 14);
        btn_xemBaocao.Name = "btn_xemBaocao";
        btn_xemBaocao.Size = new System.Drawing.Size(128, 50);
        btn_xemBaocao.TabIndex = 0;
        btn_xemBaocao.Text = "📊Xem báo cáo";
        btn_xemBaocao.UseVisualStyleBackColor = true;
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
        // dgv_danhSachHD
        // 
        dgv_danhSachHD.ColumnHeadersHeightSizeMode =
            System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgv_danhSachHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            { col_maHD, col_thoiGian, col_khachHang, col_sanPham, col_doanhThu, col_loiNhuan, col_thanhToan });
        dgv_danhSachHD.Location = new System.Drawing.Point(12, 379);
        dgv_danhSachHD.Name = "dgv_danhSachHD";
        dgv_danhSachHD.RowHeadersWidth = 51;
        dgv_danhSachHD.Size = new System.Drawing.Size(895, 156);
        dgv_danhSachHD.TabIndex = 2;
        dgv_danhSachHD.Text = "dataGridView1";
        // 
        // col_maHD
        // 
        col_maHD.HeaderText = "Mã HĐ";
        col_maHD.MinimumWidth = 6;
        col_maHD.Name = "col_maHD";
        col_maHD.Width = 125;
        // 
        // col_thoiGian
        // 
        col_thoiGian.HeaderText = "Thời gian";
        col_thoiGian.MinimumWidth = 6;
        col_thoiGian.Name = "col_thoiGian";
        col_thoiGian.Width = 125;
        // 
        // col_khachHang
        // 
        col_khachHang.HeaderText = "Khách Hàng";
        col_khachHang.MinimumWidth = 6;
        col_khachHang.Name = "col_khachHang";
        col_khachHang.Width = 125;
        // 
        // col_sanPham
        // 
        col_sanPham.HeaderText = "Sản Phẩm";
        col_sanPham.MinimumWidth = 6;
        col_sanPham.Name = "col_sanPham";
        col_sanPham.Width = 125;
        // 
        // col_doanhThu
        // 
        col_doanhThu.HeaderText = "Doanh Thu";
        col_doanhThu.MinimumWidth = 6;
        col_doanhThu.Name = "col_doanhThu";
        col_doanhThu.Width = 125;
        // 
        // col_loiNhuan
        // 
        col_loiNhuan.HeaderText = "Lợi nhuân";
        col_loiNhuan.MinimumWidth = 6;
        col_loiNhuan.Name = "col_loiNhuan";
        col_loiNhuan.Width = 125;
        // 
        // col_thanhToan
        // 
        col_thanhToan.HeaderText = "Thanh toán";
        col_thanhToan.MinimumWidth = 6;
        col_thanhToan.Name = "col_thanhToan";
        col_thanhToan.Width = 125;
        // 
        // imageList1
        // 
        imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
        imageList1.ImageSize = new System.Drawing.Size(16, 16);
        imageList1.TransparentColor = System.Drawing.Color.Transparent;
        // 
        // cbb_locNgsy
        // 
        cbb_locNgsy.FormattingEnabled = true;
        cbb_locNgsy.Items.AddRange(new object[]
            { "Hôm nay", "", "Hôm qua", "", "7 ngày qua", "", "Tháng này", "", "Tùy chỉnh" });
        cbb_locNgsy.Location = new System.Drawing.Point(90, 106);
        cbb_locNgsy.Name = "cbb_locNgsy";
        cbb_locNgsy.Size = new System.Drawing.Size(712, 28);
        cbb_locNgsy.TabIndex = 3;
        // 
        // dtp_tu
        // 
        dtp_tu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        dtp_tu.Location = new System.Drawing.Point(90, 156);
        dtp_tu.Name = "dtp_tu";
        dtp_tu.Size = new System.Drawing.Size(714, 27);
        dtp_tu.TabIndex = 4;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(39, 195);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(57, 23);
        label1.TabIndex = 5;
        label1.Text = "đến";
        label1.Click += label1_Click;
        // 
        // dtp_den
        // 
        dtp_den.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        dtp_den.Location = new System.Drawing.Point(90, 230);
        dtp_den.Name = "dtp_den";
        dtp_den.Size = new System.Drawing.Size(714, 27);
        dtp_den.TabIndex = 6;
        // 
        // panel3
        // 
        panel3.Controls.Add(lbl_baoHanhphatsinh);
        panel3.Controls.Add(lbl_soHoadon);
        panel3.Controls.Add(lbl_sanPhambanra);
        panel3.Controls.Add(lbl_loiNhuangop);
        panel3.Controls.Add(lbl_doanhThu);
        panel3.Location = new System.Drawing.Point(67, 274);
        panel3.Name = "panel3";
        panel3.Size = new System.Drawing.Size(761, 99);
        panel3.TabIndex = 7;
        // 
        // lbl_baoHanhphatsinh
        // 
        lbl_baoHanhphatsinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        lbl_baoHanhphatsinh.Location = new System.Drawing.Point(618, 20);
        lbl_baoHanhphatsinh.Name = "lbl_baoHanhphatsinh";
        lbl_baoHanhphatsinh.Size = new System.Drawing.Size(140, 50);
        lbl_baoHanhphatsinh.TabIndex = 4;
        lbl_baoHanhphatsinh.Text = "Bảo hành phát sinh";
        lbl_baoHanhphatsinh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        // 
        // lbl_soHoadon
        // 
        lbl_soHoadon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        lbl_soHoadon.Location = new System.Drawing.Point(336, 20);
        lbl_soHoadon.Name = "lbl_soHoadon";
        lbl_soHoadon.Size = new System.Drawing.Size(111, 50);
        lbl_soHoadon.TabIndex = 3;
        lbl_soHoadon.Text = "Số hóa đơn";
        lbl_soHoadon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        // 
        // lbl_sanPhambanra
        // 
        lbl_sanPhambanra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        lbl_sanPhambanra.Location = new System.Drawing.Point(464, 20);
        lbl_sanPhambanra.Name = "lbl_sanPhambanra";
        lbl_sanPhambanra.Size = new System.Drawing.Size(134, 50);
        lbl_sanPhambanra.TabIndex = 2;
        lbl_sanPhambanra.Text = "Sản phẩm bán ra";
        lbl_sanPhambanra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        // 
        // lbl_loiNhuangop
        // 
        lbl_loiNhuangop.Anchor =
            ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top |
                                                   System.Windows.Forms.AnchorStyles.Bottom) |
                                                  System.Windows.Forms.AnchorStyles.Left) |
            System.Windows.Forms.AnchorStyles.Right));
        lbl_loiNhuangop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        lbl_loiNhuangop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        lbl_loiNhuangop.Location = new System.Drawing.Point(176, 21);
        lbl_loiNhuangop.Name = "lbl_loiNhuangop";
        lbl_loiNhuangop.Size = new System.Drawing.Size(140, 50);
        lbl_loiNhuangop.TabIndex = 1;
        lbl_loiNhuangop.Text = "Lợi nhuận gộp (đ)";
        lbl_loiNhuangop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        // 
        // lbl_doanhThu
        // 
        lbl_doanhThu.Anchor =
            ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top |
                                                   System.Windows.Forms.AnchorStyles.Bottom) |
                                                  System.Windows.Forms.AnchorStyles.Left) |
            System.Windows.Forms.AnchorStyles.Right));
        lbl_doanhThu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        lbl_doanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        lbl_doanhThu.Location = new System.Drawing.Point(18, 21);
        lbl_doanhThu.Name = "lbl_doanhThu";
        lbl_doanhThu.Size = new System.Drawing.Size(140, 50);
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
        pnl_footer.Location = new System.Drawing.Point(0, 566);
        pnl_footer.Name = "pnl_footer";
        pnl_footer.Size = new System.Drawing.Size(915, 28);
        pnl_footer.TabIndex = 8;
        // 
        // lbl_footerLeft
        // 
        lbl_footerLeft.Location = new System.Drawing.Point(0, 0);
        lbl_footerLeft.Name = "lbl_footerLeft";
        lbl_footerLeft.Size = new System.Drawing.Size(161, 25);
        lbl_footerLeft.TabIndex = 0;
        lbl_footerLeft.Text = "Báo cáo ngày:";
        // 
        // lbl_footerRight
        // 
        lbl_footerRight.Location = new System.Drawing.Point(728, 2);
        lbl_footerRight.Name = "lbl_footerRight";
        lbl_footerRight.Size = new System.Drawing.Size(184, 23);
        lbl_footerRight.TabIndex = 1;
        lbl_footerRight.Text = "Tỉ lệ lợi nhuân";
        // 
        // FormReport
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(915, 594);
        Controls.Add(pnl_footer);
        Controls.Add(panel3);
        Controls.Add(dtp_den);
        Controls.Add(label1);
        Controls.Add(dtp_tu);
        Controls.Add(cbb_locNgsy);
        Controls.Add(dgv_danhSachHD);
        Controls.Add(pnl_Top);
        Text = "Báo cáo doanh thu";
        pnl_Top.ResumeLayout(false);
        panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgv_danhSachHD).EndInit();
        panel3.ResumeLayout(false);
        pnl_footer.ResumeLayout(false);
        ResumeLayout(false);
    }
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

    private System.Windows.Forms.Label lbl_soHoadon;
    private System.Windows.Forms.Label lbl_baoHanhphatsinh;

    private System.Windows.Forms.Label lbl_sanPhambanra;

    private System.Windows.Forms.Label lbl_loiNhuangop;

    private System.Windows.Forms.Label lbl_doanhThu;

    private System.Windows.Forms.Panel panel3;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DateTimePicker dtp_den;

    private System.Windows.Forms.DateTimePicker dtp_tu;

    private System.Windows.Forms.ComboBox cbb_locNgsy;

    private System.Windows.Forms.ImageList imageList1;

    private System.Windows.Forms.Button btn_xemBaocao;
    private System.Windows.Forms.Button btn_xuatExcel;

    private System.Windows.Forms.DataGridView dgv_danhSachHD;
    private System.Windows.Forms.Panel pnl_Top;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;

    #endregion
}

