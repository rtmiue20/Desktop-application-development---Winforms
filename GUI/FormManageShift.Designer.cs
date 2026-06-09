using System.ComponentModel;

namespace GUI;

partial class FormManageShift
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
        dgv_listShift = new System.Windows.Forms.DataGridView();
        col_maCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_nhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_moLuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_dongLuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_tienDauca = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_tienCuoica = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_chenhLech = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
        btn_shiftOpen = new System.Windows.Forms.Button();
        btn_shiftHistory = new System.Windows.Forms.Button();
        btn_shiftStop = new System.Windows.Forms.Button();
        panel1 = new System.Windows.Forms.Panel();
        lbl_shiftStatus = new System.Windows.Forms.Label();
        lbl_resStatus = new System.Windows.Forms.Label();
        panel2 = new System.Windows.Forms.Panel();
        lbl_shiftOpenTime = new System.Windows.Forms.Label();
        lbl_resTime = new System.Windows.Forms.Label();
        panel3 = new System.Windows.Forms.Panel();
        lbl_shiftStartMoney = new System.Windows.Forms.Label();
        lbl_resMoney = new System.Windows.Forms.Label();
        panel4 = new System.Windows.Forms.Panel();
        lbl_shiftActivity = new System.Windows.Forms.Label();
        lbl_resActivity = new System.Windows.Forms.Label();
        panel5 = new System.Windows.Forms.Panel();
        lbl_shiftRevenue = new System.Windows.Forms.Label();
        lbl_resRevenue = new System.Windows.Forms.Label();
        pnl_footer = new System.Windows.Forms.Panel();
        lbl_footerRight = new System.Windows.Forms.Label();
        lbl_footerLeft = new System.Windows.Forms.Label();
        pnl_top = new System.Windows.Forms.Panel();
        groupBox1 = new System.Windows.Forms.GroupBox();
        ((System.ComponentModel.ISupportInitialize)dgv_listShift).BeginInit();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        panel3.SuspendLayout();
        panel4.SuspendLayout();
        panel5.SuspendLayout();
        pnl_footer.SuspendLayout();
        pnl_top.SuspendLayout();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // dgv_listShift
        // 
        dgv_listShift.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        dgv_listShift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgv_listShift.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { col_maCa, col_nhanVien, col_moLuc, col_dongLuc, col_tienDauca, col_tienCuoica, col_chenhLech, col_trangThai });
        dgv_listShift.Dock = System.Windows.Forms.DockStyle.Fill;
        dgv_listShift.Location = new System.Drawing.Point(0, 180);
        dgv_listShift.Name = "dgv_listShift";
        dgv_listShift.RowHeadersWidth = 51;
        dgv_listShift.Size = new System.Drawing.Size(784, 185);
        dgv_listShift.TabIndex = 0;
        dgv_listShift.Text = "dataGridView1";
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
        // btn_shiftOpen
        // 
        btn_shiftOpen.Location = new System.Drawing.Point(10, 10);
        btn_shiftOpen.Name = "btn_shiftOpen";
        btn_shiftOpen.Size = new System.Drawing.Size(120, 30);
        btn_shiftOpen.TabIndex = 5;
        btn_shiftOpen.Text = "▶ Mở ca";
        btn_shiftOpen.UseVisualStyleBackColor = true;
        // 
        // btn_shiftHistory
        // 
        btn_shiftHistory.Location = new System.Drawing.Point(270, 10);
        btn_shiftHistory.Name = "btn_shiftHistory";
        btn_shiftHistory.Size = new System.Drawing.Size(120, 30);
        btn_shiftHistory.TabIndex = 6;
        btn_shiftHistory.Text = "📋Lịch sử ca";
        btn_shiftHistory.UseVisualStyleBackColor = true;
        // 
        // btn_shiftStop
        // 
        btn_shiftStop.Location = new System.Drawing.Point(140, 10);
        btn_shiftStop.Name = "btn_shiftStop";
        btn_shiftStop.Size = new System.Drawing.Size(120, 30);
        btn_shiftStop.TabIndex = 7;
        btn_shiftStop.Text = "■ Chốt ca";
        btn_shiftStop.UseVisualStyleBackColor = true;
        // 
        // panel1
        // 
        panel1.Controls.Add(lbl_shiftStatus);
        panel1.Controls.Add(lbl_resStatus);
        panel1.Location = new System.Drawing.Point(5, 20);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(150, 100);
        panel1.TabIndex = 8;
        // 
        // lbl_shiftStatus
        // 
        lbl_shiftStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        lbl_shiftStatus.Location = new System.Drawing.Point(2, 50);
        lbl_shiftStatus.Name = "lbl_shiftStatus";
        lbl_shiftStatus.Size = new System.Drawing.Size(145, 45);
        lbl_shiftStatus.TabIndex = 1;
        lbl_shiftStatus.Text = "Trạng thái ca";
        lbl_shiftStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        lbl_shiftStatus.Click += label2_Click_1;
        // 
        // lbl_resStatus
        // 
        lbl_resStatus.BackColor = System.Drawing.SystemColors.ControlLight;
        lbl_resStatus.Location = new System.Drawing.Point(2, 2);
        lbl_resStatus.Name = "lbl_resStatus";
        lbl_resStatus.Size = new System.Drawing.Size(145, 45);
        lbl_resStatus.TabIndex = 0;
        lbl_resStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // panel2
        // 
        panel2.Controls.Add(lbl_shiftOpenTime);
        panel2.Controls.Add(lbl_resTime);
        panel2.Location = new System.Drawing.Point(160, 20);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(150, 100);
        panel2.TabIndex = 9;
        // 
        // lbl_shiftOpenTime
        // 
        lbl_shiftOpenTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        lbl_shiftOpenTime.Location = new System.Drawing.Point(2, 50);
        lbl_shiftOpenTime.Name = "lbl_shiftOpenTime";
        lbl_shiftOpenTime.Size = new System.Drawing.Size(145, 45);
        lbl_shiftOpenTime.TabIndex = 1;
        lbl_shiftOpenTime.Text = "Giờ mở ca";
        lbl_shiftOpenTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lbl_resTime
        // 
        lbl_resTime.BackColor = System.Drawing.SystemColors.ControlLight;
        lbl_resTime.Location = new System.Drawing.Point(2, 2);
        lbl_resTime.Name = "lbl_resTime";
        lbl_resTime.Size = new System.Drawing.Size(145, 45);
        lbl_resTime.TabIndex = 0;
        lbl_resTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // panel3
        // 
        panel3.Controls.Add(lbl_shiftStartMoney);
        panel3.Controls.Add(lbl_resMoney);
        panel3.Location = new System.Drawing.Point(315, 20);
        panel3.Name = "panel3";
        panel3.Size = new System.Drawing.Size(150, 100);
        panel3.TabIndex = 10;
        // 
        // lbl_shiftStartMoney
        // 
        lbl_shiftStartMoney.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        lbl_shiftStartMoney.Location = new System.Drawing.Point(2, 50);
        lbl_shiftStartMoney.Name = "lbl_shiftStartMoney";
        lbl_shiftStartMoney.Size = new System.Drawing.Size(145, 45);
        lbl_shiftStartMoney.TabIndex = 1;
        lbl_shiftStartMoney.Text = "Tiền đầu ca";
        lbl_shiftStartMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lbl_resMoney
        // 
        lbl_resMoney.BackColor = System.Drawing.SystemColors.ControlLight;
        lbl_resMoney.Location = new System.Drawing.Point(2, 2);
        lbl_resMoney.Name = "lbl_resMoney";
        lbl_resMoney.Size = new System.Drawing.Size(145, 45);
        lbl_resMoney.TabIndex = 0;
        lbl_resMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        lbl_resMoney.Click += lbl_tienDaucaTitle_Click;
        // 
        // panel4
        // 
        panel4.Controls.Add(lbl_shiftActivity);
        panel4.Controls.Add(lbl_resActivity);
        panel4.Location = new System.Drawing.Point(470, 20);
        panel4.Name = "panel4";
        panel4.Size = new System.Drawing.Size(150, 100);
        panel4.TabIndex = 11;
        // 
        // lbl_shiftActivity
        // 
        lbl_shiftActivity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        lbl_shiftActivity.Location = new System.Drawing.Point(2, 50);
        lbl_shiftActivity.Name = "lbl_shiftActivity";
        lbl_shiftActivity.Size = new System.Drawing.Size(145, 45);
        lbl_shiftActivity.TabIndex = 1;
        lbl_shiftActivity.Text = "HĐ trong ca";
        lbl_shiftActivity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lbl_resActivity
        // 
        lbl_resActivity.BackColor = System.Drawing.SystemColors.ControlLight;
        lbl_resActivity.Location = new System.Drawing.Point(2, 2);
        lbl_resActivity.Name = "lbl_resActivity";
        lbl_resActivity.Size = new System.Drawing.Size(145, 45);
        lbl_resActivity.TabIndex = 0;
        lbl_resActivity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // panel5
        // 
        panel5.Controls.Add(lbl_shiftRevenue);
        panel5.Controls.Add(lbl_resRevenue);
        panel5.Location = new System.Drawing.Point(625, 20);
        panel5.Name = "panel5";
        panel5.Size = new System.Drawing.Size(150, 100);
        panel5.TabIndex = 12;
        // 
        // lbl_shiftRevenue
        // 
        lbl_shiftRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        lbl_shiftRevenue.Location = new System.Drawing.Point(2, 50);
        lbl_shiftRevenue.Name = "lbl_shiftRevenue";
        lbl_shiftRevenue.Size = new System.Drawing.Size(145, 45);
        lbl_shiftRevenue.TabIndex = 1;
        lbl_shiftRevenue.Text = "Doanh thu ca";
        lbl_shiftRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lbl_resRevenue
        // 
        lbl_resRevenue.BackColor = System.Drawing.SystemColors.ControlLight;
        lbl_resRevenue.Location = new System.Drawing.Point(2, 2);
        lbl_resRevenue.Name = "lbl_resRevenue";
        lbl_resRevenue.Size = new System.Drawing.Size(145, 45);
        lbl_resRevenue.TabIndex = 0;
        lbl_resRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // pnl_footer
        // 
        pnl_footer.Controls.Add(lbl_footerRight);
        pnl_footer.Controls.Add(lbl_footerLeft);
        pnl_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
        pnl_footer.Location = new System.Drawing.Point(0, 365);
        pnl_footer.Name = "pnl_footer";
        pnl_footer.Size = new System.Drawing.Size(784, 50);
        pnl_footer.TabIndex = 13;
        // 
        // lbl_footerRight
        // 
        lbl_footerRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        lbl_footerRight.Location = new System.Drawing.Point(400, 5);
        lbl_footerRight.Name = "lbl_footerRight";
        lbl_footerRight.Size = new System.Drawing.Size(380, 40);
        lbl_footerRight.TabIndex = 1;
        lbl_footerRight.Text = "Mở lúc:";
        lbl_footerRight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lbl_footerLeft
        // 
        lbl_footerLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        lbl_footerLeft.Location = new System.Drawing.Point(5, 5);
        lbl_footerLeft.Name = "lbl_footerLeft";
        lbl_footerLeft.Size = new System.Drawing.Size(380, 40);
        lbl_footerLeft.TabIndex = 0;
        lbl_footerLeft.Text = "Ca hiện tại:";
        lbl_footerLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        lbl_footerLeft.Click += label2_Click_2;
        // 
        // pnl_top
        // 
        pnl_top.Controls.Add(btn_shiftOpen);
        pnl_top.Controls.Add(btn_shiftStop);
        pnl_top.Controls.Add(btn_shiftHistory);
        pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
        pnl_top.Location = new System.Drawing.Point(0, 0);
        pnl_top.Name = "pnl_top";
        pnl_top.Size = new System.Drawing.Size(784, 50);
        pnl_top.TabIndex = 14;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(panel1);
        groupBox1.Controls.Add(panel3);
        groupBox1.Controls.Add(panel2);
        groupBox1.Controls.Add(panel5);
        groupBox1.Controls.Add(panel4);
        groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
        groupBox1.Location = new System.Drawing.Point(0, 50);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(784, 130);
        groupBox1.TabIndex = 15;
        groupBox1.TabStop = false;
        // 
        // FormManageShift
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(784, 415);
        Controls.Add(dgv_listShift);
        Controls.Add(groupBox1);
        Controls.Add(pnl_top);
        Controls.Add(pnl_footer);
        Margin = new System.Windows.Forms.Padding(6);
        Text = "Quản lí ca làm việc";
        ((System.ComponentModel.ISupportInitialize)dgv_listShift).EndInit();
        panel1.ResumeLayout(false);
        panel2.ResumeLayout(false);
        panel3.ResumeLayout(false);
        panel4.ResumeLayout(false);
        panel5.ResumeLayout(false);
        pnl_footer.ResumeLayout(false);
        pnl_top.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Panel pnl_top;
    private System.Windows.Forms.GroupBox groupBox1;

    private System.Windows.Forms.Panel pnl_footer;

    private System.Windows.Forms.DataGridViewTextBoxColumn col_tienDauca;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_tienCuoica;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_chenhLech;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_trangThai;

    private System.Windows.Forms.DataGridViewTextBoxColumn col_nhanVien;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_moLuc;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_dongLuc;

    private System.Windows.Forms.DataGridViewTextBoxColumn col_maCa;

    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label lbl_shiftOpenTime;
    private System.Windows.Forms.Label lbl_resTime;
    private System.Windows.Forms.Label lbl_footerLeft;
    private System.Windows.Forms.Label lbl_footerRight;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Label lbl_shiftStartMoney;
    private System.Windows.Forms.Label lbl_resMoney;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.Label lbl_shiftActivity;
    private System.Windows.Forms.Label lbl_resActivity;
    private System.Windows.Forms.Panel panel5;
    private System.Windows.Forms.Label lbl_shiftRevenue;
    private System.Windows.Forms.Label lbl_resRevenue;

    private System.Windows.Forms.Label lbl_resStatus;
    private System.Windows.Forms.Label lbl_shiftStatus;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.Button btn_shiftHistory;
    private System.Windows.Forms.Button btn_shiftStop;

    private System.Windows.Forms.Button btn_shiftOpen;

    private System.Windows.Forms.DataGridView dgv_listShift;

    #endregion
}