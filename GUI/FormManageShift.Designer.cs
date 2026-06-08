using System.ComponentModel;

namespace GUI;

partial class FormManageShift
{
    private IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        dgv_danhSachCa = new System.Windows.Forms.DataGridView();
        col_maCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_nhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_moLuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_dongLuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_tienDauca = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_tienCuoica = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_chenhLech = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
        btn_moCa = new System.Windows.Forms.Button();
        button5 = new System.Windows.Forms.Button();
        btn_chotCa = new System.Windows.Forms.Button();
        panel1 = new System.Windows.Forms.Panel();
        lbl_trangThaiTitle = new System.Windows.Forms.Label();
        panel2 = new System.Windows.Forms.Panel();
        lbl_gioMoCa = new System.Windows.Forms.Label();
        panel3 = new System.Windows.Forms.Panel();
        lbl_tienDauca = new System.Windows.Forms.Label();
        panel4 = new System.Windows.Forms.Panel();
        lbl_hdTrongca = new System.Windows.Forms.Label();
        panel5 = new System.Windows.Forms.Panel();
        lbl_doanhThuca = new System.Windows.Forms.Label();
        pnl_footer = new System.Windows.Forms.Panel();
        lbl_footerRight = new System.Windows.Forms.Label();
        lbl_footerLeft = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)dgv_danhSachCa).BeginInit();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        panel3.SuspendLayout();
        panel4.SuspendLayout();
        panel5.SuspendLayout();
        pnl_footer.SuspendLayout();
        SuspendLayout();
        // 
        // dgv_danhSachCa
        // 
        dgv_danhSachCa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        dgv_danhSachCa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgv_danhSachCa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { col_maCa, col_nhanVien, col_moLuc, col_dongLuc, col_tienDauca, col_tienCuoica, col_chenhLech, col_trangThai });
        dgv_danhSachCa.Location = new System.Drawing.Point(12, 247);
        dgv_danhSachCa.Name = "dgv_danhSachCa";
        dgv_danhSachCa.RowHeadersWidth = 51;
        dgv_danhSachCa.Size = new System.Drawing.Size(1048, 302);
        dgv_danhSachCa.TabIndex = 0;
        // 
        // col_maCa
        // 
        col_maCa.HeaderText = "Mã ca";
        col_maCa.MinimumWidth = 6;
        col_maCa.Name = "col_maCa";
        col_maCa.Width = 125;
        // 
        // col_nhanVien
        // 
        col_nhanVien.HeaderText = "Nhân viên";
        col_nhanVien.MinimumWidth = 6;
        col_nhanVien.Name = "col_nhanVien";
        col_nhanVien.Width = 125;
        // 
        // col_moLuc
        // 
        col_moLuc.HeaderText = "Mở lúc";
        col_moLuc.MinimumWidth = 6;
        col_moLuc.Name = "col_moLuc";
        col_moLuc.Width = 125;
        // 
        // col_dongLuc
        // 
        col_dongLuc.HeaderText = "Đóng lúc";
        col_dongLuc.MinimumWidth = 6;
        col_dongLuc.Name = "col_dongLuc";
        col_dongLuc.Width = 125;
        // 
        // col_tienDauca
        // 
        col_tienDauca.HeaderText = "Tiền đầu ca";
        col_tienDauca.MinimumWidth = 6;
        col_tienDauca.Name = "col_tienDauca";
        col_tienDauca.Width = 125;
        // 
        // col_tienCuoica
        // 
        col_tienCuoica.HeaderText = "Tiền cuối ca";
        col_tienCuoica.MinimumWidth = 6;
        col_tienCuoica.Name = "col_tienCuoica";
        col_tienCuoica.Width = 125;
        // 
        // col_chenhLech
        // 
        col_chenhLech.HeaderText = "Chênh lệch";
        col_chenhLech.MinimumWidth = 6;
        col_chenhLech.Name = "col_chenhLech";
        col_chenhLech.Width = 125;
        // 
        // col_trangThai
        // 
        col_trangThai.HeaderText = "Trạng thái";
        col_trangThai.MinimumWidth = 6;
        col_trangThai.Name = "col_trangThai";
        col_trangThai.Width = 125;
        // 
        // btn_moCa
        // 
        btn_moCa.Location = new System.Drawing.Point(13, 20);
        btn_moCa.Name = "btn_moCa";
        btn_moCa.Size = new System.Drawing.Size(133, 57);
        btn_moCa.TabIndex = 5;
        btn_moCa.Text = "▶ Mở ca";
        btn_moCa.UseVisualStyleBackColor = true;
        btn_moCa.Click += btn_moCa_Click;
        // 
        // button5
        // 
        button5.Location = new System.Drawing.Point(326, 20);
        button5.Name = "button5";
        button5.Size = new System.Drawing.Size(133, 57);
        button5.TabIndex = 6;
        button5.Text = "📋Lịch sử ca";
        button5.UseVisualStyleBackColor = true;
        button5.Click += button5_Click;
        // 
        // btn_chotCa
        // 
        btn_chotCa.Location = new System.Drawing.Point(172, 20);
        btn_chotCa.Name = "btn_chotCa";
        btn_chotCa.Size = new System.Drawing.Size(133, 57);
        btn_chotCa.TabIndex = 7;
        btn_chotCa.Text = "■ Chốt ca";
        btn_chotCa.UseVisualStyleBackColor = true;
        btn_chotCa.Click += btn_chotCa_Click;
        // 
        // panel1
        // 
        panel1.Controls.Add(lbl_trangThaiTitle);
        panel1.Location = new System.Drawing.Point(30, 117);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(150, 84);
        panel1.TabIndex = 8;
        // 
        // lbl_trangThaiTitle
        // 
        lbl_trangThaiTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        lbl_trangThaiTitle.Location = new System.Drawing.Point(13, 41);
        lbl_trangThaiTitle.Name = "lbl_trangThaiTitle";
        lbl_trangThaiTitle.Size = new System.Drawing.Size(111, 26);
        lbl_trangThaiTitle.TabIndex = 1;
        lbl_trangThaiTitle.Text = "Trạng thái ca";
        lbl_trangThaiTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        lbl_trangThaiTitle.Click += label2_Click_1;
        // 
        // panel2
        // 
        panel2.Controls.Add(lbl_gioMoCa);
        panel2.Location = new System.Drawing.Point(234, 117);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(157, 84);
        panel2.TabIndex = 9;
        // 
        // lbl_gioMoCa
        // 
        lbl_gioMoCa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        lbl_gioMoCa.Location = new System.Drawing.Point(26, 41);
        lbl_gioMoCa.Name = "lbl_gioMoCa";
        lbl_gioMoCa.Size = new System.Drawing.Size(111, 26);
        lbl_gioMoCa.TabIndex = 1;
        lbl_gioMoCa.Text = "Giờ mở ca";
        lbl_gioMoCa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // panel3
        // 
        panel3.Controls.Add(lbl_tienDauca);
        panel3.Location = new System.Drawing.Point(429, 117);
        panel3.Name = "panel3";
        panel3.Size = new System.Drawing.Size(157, 84);
        panel3.TabIndex = 10;
        // 
        // lbl_tienDauca
        // 
        lbl_tienDauca.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        lbl_tienDauca.Location = new System.Drawing.Point(26, 41);
        lbl_tienDauca.Name = "lbl_tienDauca";
        lbl_tienDauca.Size = new System.Drawing.Size(111, 26);
        lbl_tienDauca.TabIndex = 1;
        lbl_tienDauca.Text = "Tiền đầu ca";
        lbl_tienDauca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // panel4
        // 
        panel4.Controls.Add(lbl_hdTrongca);
        panel4.Location = new System.Drawing.Point(651, 117);
        panel4.Name = "panel4";
        panel4.Size = new System.Drawing.Size(157, 84);
        panel4.TabIndex = 11;
        // 
        // lbl_hdTrongca
        // 
        lbl_hdTrongca.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        lbl_hdTrongca.Location = new System.Drawing.Point(26, 41);
        lbl_hdTrongca.Name = "lbl_hdTrongca";
        lbl_hdTrongca.Size = new System.Drawing.Size(111, 26);
        lbl_hdTrongca.TabIndex = 1;
        lbl_hdTrongca.Text = "HĐ trong ca";
        lbl_hdTrongca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // panel5
        // 
        panel5.Controls.Add(lbl_doanhThuca);
        panel5.Location = new System.Drawing.Point(870, 117);
        panel5.Name = "panel5";
        panel5.Size = new System.Drawing.Size(157, 84);
        panel5.TabIndex = 12;
        // 
        // lbl_doanhThuca
        // 
        lbl_doanhThuca.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        lbl_doanhThuca.Location = new System.Drawing.Point(26, 41);
        lbl_doanhThuca.Name = "lbl_doanhThuca";
        lbl_doanhThuca.Size = new System.Drawing.Size(111, 26);
        lbl_doanhThuca.TabIndex = 1;
        lbl_doanhThuca.Text = "Doanh thu ca";
        lbl_doanhThuca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // pnl_footer
        // 
        pnl_footer.Controls.Add(lbl_footerRight);
        pnl_footer.Controls.Add(lbl_footerLeft);
        pnl_footer.Location = new System.Drawing.Point(27, 554);
        pnl_footer.Name = "pnl_footer";
        pnl_footer.Size = new System.Drawing.Size(1033, 40);
        pnl_footer.TabIndex = 13;
        // 
        // lbl_footerRight
        // 
        lbl_footerRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        lbl_footerRight.Location = new System.Drawing.Point(929, 0);
        lbl_footerRight.Name = "lbl_footerRight";
        lbl_footerRight.Size = new System.Drawing.Size(104, 36);
        lbl_footerRight.TabIndex = 1;
        lbl_footerRight.Text = "Mở lúc:";
        // 
        // lbl_footerLeft
        // 
        lbl_footerLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        lbl_footerLeft.Location = new System.Drawing.Point(1, 3);
        lbl_footerLeft.Name = "lbl_footerLeft";
        lbl_footerLeft.Size = new System.Drawing.Size(104, 36);
        lbl_footerLeft.TabIndex = 0;
        lbl_footerLeft.Text = "Ca hiện tại:";
        lbl_footerLeft.Click += label2_Click_2;
        // 
        // FormManageShift
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1072, 606);
        Controls.Add(pnl_footer);
        Controls.Add(panel5);
        Controls.Add(panel4);
        Controls.Add(panel3);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Controls.Add(btn_chotCa);
        Controls.Add(button5);
        Controls.Add(btn_moCa);
        Controls.Add(dgv_danhSachCa);
        Text = "Quản lí ca làm việc";
        ((System.ComponentModel.ISupportInitialize)dgv_danhSachCa).EndInit();
        panel1.ResumeLayout(false);
        panel2.ResumeLayout(false);
        panel3.ResumeLayout(false);
        panel4.ResumeLayout(false);
        panel5.ResumeLayout(false);
        pnl_footer.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridView dgv_danhSachCa;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_maCa;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_nhanVien;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_moLuc;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_dongLuc;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_tienDauca;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_tienCuoica;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_chenhLech;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_trangThai;

    private System.Windows.Forms.Button btn_moCa;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button btn_chotCa;

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label lbl_trangThaiTitle;

    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label lbl_gioMoCa;

    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Label lbl_tienDauca;

    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.Label lbl_hdTrongca;

    private System.Windows.Forms.Panel panel5;
    private System.Windows.Forms.Label lbl_doanhThuca;

    private System.Windows.Forms.Panel pnl_footer;
    private System.Windows.Forms.Label lbl_footerLeft;
    private System.Windows.Forms.Label lbl_footerRight;

    #endregion
}

