using System.ComponentModel;

namespace GUI;

partial class FormSell
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
        dgv_cart = new DataGridView();
        col_ProductName = new DataGridViewTextBoxColumn();
        col_SerialNumber = new DataGridViewTextBoxColumn();
        col_Quantity = new DataGridViewTextBoxColumn();
        col_UnitPrice = new DataGridViewTextBoxColumn();
        col_TotalPrice = new DataGridViewTextBoxColumn();
        col_Remove = new DataGridViewTextBoxColumn();
        backgroundWorker1 = new BackgroundWorker();
        grp_Action = new GroupBox();
        btn_promotion = new Button();
        btn_customer = new Button();
        txt_searchProduct = new TextBox();
        pnl_top = new Panel();
        btn_todayInvoice = new Button();
        btn_payment = new Button();
        btn_cancelInvoice = new Button();
        btn_print = new Button();
        groupBox3 = new GroupBox();
        lbl_subTotal = new Label();
        lbl_discount = new Label();
        lbl_finalTotal = new Label();
        groupBox4 = new GroupBox();
        cbo_paymentMethod = new ComboBox();
        btn_confirmPayment = new Button();
        ((ISupportInitialize)dgv_cart).BeginInit();
        grp_Action.SuspendLayout();
        pnl_top.SuspendLayout();
        groupBox3.SuspendLayout();
        groupBox4.SuspendLayout();
        SuspendLayout();
        // 
        // dgv_cart
        // 
        dgv_cart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgv_cart.Columns.AddRange(new DataGridViewColumn[] { col_ProductName, col_SerialNumber, col_Quantity, col_UnitPrice, col_TotalPrice, col_Remove });
        dgv_cart.Location = new Point(0, 93);
        dgv_cart.Margin = new Padding(1, 1, 1, 1);
        dgv_cart.Name = "dgv_cart";
        dgv_cart.RowHeadersWidth = 51;
        dgv_cart.Size = new Size(776, 170);
        dgv_cart.TabIndex = 4;
        dgv_cart.CellContentClick += dgv_Cart_CellContentClick;
        // 
        // col_ProductName
        // 
        col_ProductName.HeaderText = "Tên SP";
        col_ProductName.MinimumWidth = 12;
        col_ProductName.Name = "col_ProductName";
        col_ProductName.Width = 250;
        // 
        // col_SerialNumber
        // 
        col_SerialNumber.HeaderText = "Serial";
        col_SerialNumber.MinimumWidth = 12;
        col_SerialNumber.Name = "col_SerialNumber";
        col_SerialNumber.Width = 200;
        // 
        // col_Quantity
        // 
        col_Quantity.HeaderText = "SL";
        col_Quantity.MinimumWidth = 12;
        col_Quantity.Name = "col_Quantity";
        col_Quantity.Width = 80;
        // 
        // col_UnitPrice
        // 
        col_UnitPrice.HeaderText = "Đơn giá";
        col_UnitPrice.MinimumWidth = 12;
        col_UnitPrice.Name = "col_UnitPrice";
        col_UnitPrice.Width = 150;
        // 
        // col_TotalPrice
        // 
        col_TotalPrice.HeaderText = "Thành tiền";
        col_TotalPrice.MinimumWidth = 12;
        col_TotalPrice.Name = "col_TotalPrice";
        col_TotalPrice.Width = 150;
        // 
        // col_Remove
        // 
        col_Remove.HeaderText = "Xóa";
        col_Remove.MinimumWidth = 12;
        col_Remove.Name = "col_Remove";
        col_Remove.Width = 70;
        // 
        // grp_Action
        // 
        grp_Action.Controls.Add(btn_promotion);
        grp_Action.Controls.Add(btn_customer);
        grp_Action.Controls.Add(txt_searchProduct);
        grp_Action.Location = new Point(0, 41);
        grp_Action.Margin = new Padding(1, 1, 1, 1);
        grp_Action.Name = "grp_Action";
        grp_Action.Padding = new Padding(1, 1, 1, 1);
        grp_Action.Size = new Size(776, 49);
        grp_Action.TabIndex = 5;
        grp_Action.TabStop = false;
        // 
        // btn_promotion
        // 
        btn_promotion.Location = new Point(572, 14);
        btn_promotion.Margin = new Padding(1, 1, 1, 1);
        btn_promotion.Name = "btn_promotion";
        btn_promotion.Size = new Size(196, 24);
        btn_promotion.TabIndex = 2;
        btn_promotion.Text = "Mã KM";
        btn_promotion.UseVisualStyleBackColor = true;
        btn_promotion.Click += btn_Promotion_Click;
        // 
        // btn_customer
        // 
        btn_customer.Location = new Point(367, 14);
        btn_customer.Margin = new Padding(1, 1, 1, 1);
        btn_customer.Name = "btn_customer";
        btn_customer.Size = new Size(202, 24);
        btn_customer.TabIndex = 1;
        btn_customer.Text = "SĐT Khách Hàng";
        btn_customer.UseVisualStyleBackColor = true;
        btn_customer.Click += btn_Customer_Click;
        // 
        // txt_searchProduct
        // 
        txt_searchProduct.Location = new Point(6, 14);
        txt_searchProduct.Margin = new Padding(1, 1, 1, 1);
        txt_searchProduct.Name = "txt_searchProduct";
        txt_searchProduct.PlaceholderText = "Quét mã SP / Serial...";
        txt_searchProduct.Size = new Size(360, 27);
        txt_searchProduct.TabIndex = 0;
        // 
        // pnl_top
        // 
        pnl_top.Controls.Add(btn_todayInvoice);
        pnl_top.Controls.Add(btn_payment);
        pnl_top.Controls.Add(btn_cancelInvoice);
        pnl_top.Controls.Add(btn_print);
        pnl_top.Location = new Point(0, -1);
        pnl_top.Margin = new Padding(1, 1, 1, 1);
        pnl_top.Name = "pnl_top";
        pnl_top.Size = new Size(776, 40);
        pnl_top.TabIndex = 9;
        // 
        // btn_todayInvoice
        // 
        btn_todayInvoice.Location = new Point(572, 7);
        btn_todayInvoice.Margin = new Padding(1, 1, 1, 1);
        btn_todayInvoice.Name = "btn_todayInvoice";
        btn_todayInvoice.Size = new Size(196, 28);
        btn_todayInvoice.TabIndex = 13;
        btn_todayInvoice.Text = "Hóa Đơn Hôm Nay";
        btn_todayInvoice.UseVisualStyleBackColor = true;
        btn_todayInvoice.Click += btnTodayInvoice_Click;
        // 
        // btn_payment
        // 
        btn_payment.Location = new Point(6, 7);
        btn_payment.Margin = new Padding(1, 1, 1, 1);
        btn_payment.Name = "btn_payment";
        btn_payment.Size = new Size(171, 28);
        btn_payment.TabIndex = 10;
        btn_payment.Text = "Thanh Toán";
        btn_payment.UseVisualStyleBackColor = true;
        btn_payment.Click += btn_Payment_Click;
        // 
        // btn_cancelInvoice
        // 
        btn_cancelInvoice.Location = new Point(367, 7);
        btn_cancelInvoice.Margin = new Padding(1, 1, 1, 1);
        btn_cancelInvoice.Name = "btn_cancelInvoice";
        btn_cancelInvoice.Size = new Size(202, 28);
        btn_cancelInvoice.TabIndex = 12;
        btn_cancelInvoice.Text = "Hủy Hóa Đơn";
        btn_cancelInvoice.UseVisualStyleBackColor = true;
        btn_cancelInvoice.Click += btn_CancelInvoice_Click;
        // 
        // btn_print
        // 
        btn_print.Location = new Point(180, 7);
        btn_print.Margin = new Padding(1, 1, 1, 1);
        btn_print.Name = "btn_print";
        btn_print.Size = new Size(184, 28);
        btn_print.TabIndex = 11;
        btn_print.Text = "In Hóa Đơn";
        btn_print.UseVisualStyleBackColor = true;
        btn_print.Click += btn_Print_Click;
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(lbl_subTotal);
        groupBox3.Controls.Add(lbl_discount);
        groupBox3.Controls.Add(lbl_finalTotal);
        groupBox3.Location = new Point(0, 266);
        groupBox3.Margin = new Padding(1, 1, 1, 1);
        groupBox3.Name = "groupBox3";
        groupBox3.Padding = new Padding(1, 1, 1, 1);
        groupBox3.Size = new Size(776, 80);
        groupBox3.TabIndex = 7;
        groupBox3.TabStop = false;
        // 
        // lbl_subTotal
        // 
        lbl_subTotal.AutoSize = true;
        lbl_subTotal.Location = new Point(6, 9);
        lbl_subTotal.Margin = new Padding(1, 0, 1, 0);
        lbl_subTotal.Name = "lbl_subTotal";
        lbl_subTotal.Size = new Size(70, 20);
        lbl_subTotal.TabIndex = 2;
        lbl_subTotal.Text = "Tạm tính:";
        // 
        // lbl_discount
        // 
        lbl_discount.AutoSize = true;
        lbl_discount.ForeColor = Color.OrangeRed;
        lbl_discount.Location = new Point(6, 34);
        lbl_discount.Margin = new Padding(1, 0, 1, 0);
        lbl_discount.Name = "lbl_discount";
        lbl_discount.Size = new Size(72, 20);
        lbl_discount.TabIndex = 4;
        lbl_discount.Text = "Giảm giá:";
        // 
        // lbl_finalTotal
        // 
        lbl_finalTotal.AutoSize = true;
        lbl_finalTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lbl_finalTotal.ForeColor = Color.DarkGreen;
        lbl_finalTotal.Location = new Point(3, 56);
        lbl_finalTotal.Margin = new Padding(1, 0, 1, 0);
        lbl_finalTotal.Name = "lbl_finalTotal";
        lbl_finalTotal.Size = new Size(117, 28);
        lbl_finalTotal.TabIndex = 6;
        lbl_finalTotal.Text = "Tổng cộng:";
        // 
        // groupBox4
        // 
        groupBox4.Controls.Add(cbo_paymentMethod);
        groupBox4.Controls.Add(btn_confirmPayment);
        groupBox4.Location = new Point(0, 350);
        groupBox4.Margin = new Padding(1, 1, 1, 1);
        groupBox4.Name = "groupBox4";
        groupBox4.Padding = new Padding(1, 1, 1, 1);
        groupBox4.Size = new Size(777, 80);
        groupBox4.TabIndex = 8;
        groupBox4.TabStop = false;
        // 
        // cbo_paymentMethod
        // 
        cbo_paymentMethod.FormattingEnabled = true;
        cbo_paymentMethod.Items.AddRange(new object[] { "Tiền mặt", "Chuyển khoản", "MoMo", "ZaloPay", "Thẻ tín dụng" });
        cbo_paymentMethod.Location = new Point(6, 17);
        cbo_paymentMethod.Margin = new Padding(1, 1, 1, 1);
        cbo_paymentMethod.Name = "cbo_paymentMethod";
        cbo_paymentMethod.Size = new Size(764, 28);
        cbo_paymentMethod.TabIndex = 0;
        // 
        // btn_confirmPayment
        // 
        btn_confirmPayment.Location = new Point(6, 43);
        btn_confirmPayment.Margin = new Padding(1, 1, 1, 1);
        btn_confirmPayment.Name = "btn_confirmPayment";
        btn_confirmPayment.Size = new Size(762, 28);
        btn_confirmPayment.TabIndex = 3;
        btn_confirmPayment.Text = "Xác Nhận Thanh Toán";
        btn_confirmPayment.UseVisualStyleBackColor = true;
        btn_confirmPayment.Click += btn_ConfirmPayment_Click;
        // 
        // FormSell
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(773, 436);
        Controls.Add(pnl_top);
        Controls.Add(grp_Action);
        Controls.Add(dgv_cart);
        Controls.Add(groupBox3);
        Controls.Add(groupBox4);
        Name = "FormSell";
        Text = "Bán hàng";
        ((ISupportInitialize)dgv_cart).EndInit();
        grp_Action.ResumeLayout(false);
        grp_Action.PerformLayout();
        pnl_top.ResumeLayout(false);
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        groupBox4.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.DataGridView dgv_cart;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private System.Windows.Forms.GroupBox grp_Action;
    private System.Windows.Forms.Button btn_promotion;
    private System.Windows.Forms.Button btn_customer;
    private System.Windows.Forms.TextBox txt_searchProduct;
    private System.Windows.Forms.Panel pnl_top;
    private System.Windows.Forms.Button btn_todayInvoice;
    private System.Windows.Forms.Button btn_cancelInvoice;
    private System.Windows.Forms.Button btn_print;
    private System.Windows.Forms.Button btn_payment;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Label lbl_subTotal;
    private System.Windows.Forms.Label lbl_discount;
    private System.Windows.Forms.Label lbl_finalTotal;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.ComboBox cbo_paymentMethod;
    private System.Windows.Forms.Button btn_confirmPayment;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_ProductName;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_SerialNumber;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_Quantity;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_UnitPrice;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_TotalPrice;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_Remove;
}