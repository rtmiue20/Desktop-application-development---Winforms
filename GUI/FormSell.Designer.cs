using System.ComponentModel;

namespace GUI
;

partial class FormSell
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
        label1 = new Label();
        txt_ProductID = new TextBox();
        btn_Search = new Button();
        dgv_Product = new DataGridView();
        dgv_Cart = new DataGridView();
        col_MaSP = new DataGridViewTextBoxColumn();
        col_TenSP = new DataGridViewTextBoxColumn();
        col_DonGia = new DataGridViewTextBoxColumn();
        col_SoLuong = new DataGridViewTextBoxColumn();
        col_ThanhTien = new DataGridViewTextBoxColumn();
        backgroundWorker1 = new BackgroundWorker();
        groupBox1 = new GroupBox();
        groupBox2 = new GroupBox();
        btn_Print = new Button();
        btn_Payment = new Button();
        txt_Final = new TextBox();
        label6 = new Label();
        txt_Discount = new TextBox();
        label5 = new Label();
        txt_Total = new TextBox();
        label4 = new Label();
        cbo_Promotion = new ComboBox();
        label3 = new Label();
        cbo_Guest = new ComboBox();
        label2 = new Label();
        ((ISupportInitialize)dgv_Product).BeginInit();
        ((ISupportInitialize)dgv_Cart).BeginInit();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(15, 32);
        label1.Name = "label1";
        label1.Size = new Size(50, 20);
        label1.TabIndex = 0;
        label1.Text = "Mã SP";
        // 
        // txt_ProductID
        // 
        txt_ProductID.Location = new Point(86, 29);
        txt_ProductID.Name = "txt_ProductID";
        txt_ProductID.Size = new Size(168, 27);
        txt_ProductID.TabIndex = 1;
        // 
        // btn_Search
        // 
        btn_Search.Location = new Point(270, 28);
        btn_Search.Name = "btn_Search";
        btn_Search.Size = new Size(94, 29);
        btn_Search.TabIndex = 2;
        btn_Search.Text = "Tìm Kiếm";
        btn_Search.UseVisualStyleBackColor = true;
        // 
        // dgv_Product
        // 
        dgv_Product.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgv_Product.Location = new Point(15, 71);
        dgv_Product.Name = "dgv_Product";
        dgv_Product.RowHeadersWidth = 51;
        dgv_Product.Size = new Size(295, 433);
        dgv_Product.TabIndex = 3;
        // 
        // dgv_Cart
        // 
        dgv_Cart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgv_Cart.Columns.AddRange(new DataGridViewColumn[] { col_MaSP, col_TenSP, col_DonGia, col_SoLuong, col_ThanhTien });
        dgv_Cart.Location = new Point(404, 45);
        dgv_Cart.Name = "dgv_Cart";
        dgv_Cart.RowHeadersWidth = 51;
        dgv_Cart.Size = new Size(585, 471);
        dgv_Cart.TabIndex = 4;
        // 
        // col_MaSP
        // 
        col_MaSP.HeaderText = "Mã SP";
        col_MaSP.MinimumWidth = 6;
        col_MaSP.Name = "col_MaSP";
        col_MaSP.Width = 125;
        // 
        // col_TenSP
        // 
        col_TenSP.HeaderText = "Tên SP";
        col_TenSP.MinimumWidth = 6;
        col_TenSP.Name = "col_TenSP";
        col_TenSP.Width = 125;
        // 
        // col_DonGia
        // 
        col_DonGia.HeaderText = "Đơn giá";
        col_DonGia.MinimumWidth = 6;
        col_DonGia.Name = "col_DonGia";
        col_DonGia.Width = 125;
        // 
        // col_SoLuong
        // 
        col_SoLuong.HeaderText = "Số Lượng";
        col_SoLuong.MinimumWidth = 6;
        col_SoLuong.Name = "col_SoLuong";
        col_SoLuong.Width = 125;
        // 
        // col_ThanhTien
        // 
        col_ThanhTien.HeaderText = "Thành Tiền";
        col_ThanhTien.MinimumWidth = 6;
        col_ThanhTien.Name = "col_ThanhTien";
        col_ThanhTien.Width = 125;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(dgv_Product);
        groupBox1.Controls.Add(label1);
        groupBox1.Controls.Add(txt_ProductID);
        groupBox1.Controls.Add(btn_Search);
        groupBox1.Location = new Point(12, 12);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(373, 519);
        groupBox1.TabIndex = 5;
        groupBox1.TabStop = false;
        groupBox1.Text = "groupBox1";
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(btn_Print);
        groupBox2.Controls.Add(btn_Payment);
        groupBox2.Controls.Add(txt_Final);
        groupBox2.Controls.Add(label6);
        groupBox2.Controls.Add(txt_Discount);
        groupBox2.Controls.Add(label5);
        groupBox2.Controls.Add(txt_Total);
        groupBox2.Controls.Add(label4);
        groupBox2.Controls.Add(cbo_Promotion);
        groupBox2.Controls.Add(label3);
        groupBox2.Controls.Add(cbo_Guest);
        groupBox2.Controls.Add(label2);
        groupBox2.Location = new Point(1004, 41);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(258, 471);
        groupBox2.TabIndex = 6;
        groupBox2.TabStop = false;
        groupBox2.Text = "groupBox2";
        // 
        // btn_Print
        // 
        btn_Print.Location = new Point(131, 405);
        btn_Print.Name = "btn_Print";
        btn_Print.Size = new Size(94, 29);
        btn_Print.TabIndex = 11;
        btn_Print.Text = "In Hóa Đơn";
        btn_Print.UseVisualStyleBackColor = true;
        // 
        // btn_Payment
        // 
        btn_Payment.Location = new Point(17, 405);
        btn_Payment.Name = "btn_Payment";
        btn_Payment.Size = new Size(94, 29);
        btn_Payment.TabIndex = 10;
        btn_Payment.Text = "Thanh Toán";
        btn_Payment.UseVisualStyleBackColor = true;
        // 
        // txt_Final
        // 
        txt_Final.Location = new Point(41, 353);
        txt_Final.Name = "txt_Final";
        txt_Final.Size = new Size(154, 27);
        txt_Final.TabIndex = 9;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(17, 318);
        label6.Name = "label6";
        label6.Size = new Size(81, 20);
        label6.TabIndex = 8;
        label6.Text = "Thành Tiền";
        // 
        // txt_Discount
        // 
        txt_Discount.Location = new Point(44, 271);
        txt_Discount.Name = "txt_Discount";
        txt_Discount.Size = new Size(154, 27);
        txt_Discount.TabIndex = 7;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(17, 248);
        label5.Name = "label5";
        label5.Size = new Size(70, 20);
        label5.TabIndex = 6;
        label5.Text = "Giảm Giá";
        // 
        // txt_Total
        // 
        txt_Total.Location = new Point(44, 218);
        txt_Total.Name = "txt_Total";
        txt_Total.Size = new Size(154, 27);
        txt_Total.TabIndex = 5;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(17, 195);
        label4.Name = "label4";
        label4.Size = new Size(75, 20);
        label4.TabIndex = 4;
        label4.Text = "Tổng Tiền";
        // 
        // cbo_Promotion
        // 
        cbo_Promotion.FormattingEnabled = true;
        cbo_Promotion.Location = new Point(44, 147);
        cbo_Promotion.Name = "cbo_Promotion";
        cbo_Promotion.Size = new Size(151, 28);
        cbo_Promotion.TabIndex = 3;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(17, 124);
        label3.Name = "label3";
        label3.Size = new Size(86, 20);
        label3.TabIndex = 2;
        label3.Text = "Khuyến Mãi";
        // 
        // cbo_Guest
        // 
        cbo_Guest.FormattingEnabled = true;
        cbo_Guest.Location = new Point(44, 75);
        cbo_Guest.Name = "cbo_Guest";
        cbo_Guest.Size = new Size(151, 28);
        cbo_Guest.TabIndex = 1;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(17, 38);
        label2.Name = "label2";
        label2.Size = new Size(89, 20);
        label2.TabIndex = 0;
        label2.Text = "Khách Hàng";
        // 
        // FormSell
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1253, 640);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Controls.Add(dgv_Cart);
        Name = "FormSell";
        Text = "FormSell";
        ((ISupportInitialize)dgv_Product).EndInit();
        ((ISupportInitialize)dgv_Cart).EndInit();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Label label1;
    private TextBox txt_ProductID;
    private Button btn_Search;
    private DataGridView dgv_Product;
    private DataGridView dgv_Cart;
    private DataGridViewTextBoxColumn col_MaSP;
    private DataGridViewTextBoxColumn col_TenSP;
    private DataGridViewTextBoxColumn col_DonGia;
    private DataGridViewTextBoxColumn col_SoLuong;
    private DataGridViewTextBoxColumn col_ThanhTien;
    private BackgroundWorker backgroundWorker1;
    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private Label label5;
    private TextBox txt_Total;
    private Label label4;
    private ComboBox cbo_Promotion;
    private Label label3;
    private ComboBox cbo_Guest;
    private Label label2;
    private Button btn_Print;
    private Button btn_Payment;
    private TextBox txt_Final;
    private Label label6;
    private TextBox txt_Discount;
}