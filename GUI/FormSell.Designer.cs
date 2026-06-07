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
        grp_Search = new GroupBox();
        btn_todayInvoice = new Button();
        btn_cancelInvoice = new Button();
        btn_print = new Button();
        btn_payment = new Button();
        lbl_FinalTotal = new Label();
        lbl_Discount = new Label();
        lbl_SubTotal = new Label();
        groupBox3 = new GroupBox();
        groupBox4 = new GroupBox();
        btn_confirmPayment = new Button();
        cbo_paymentMethod = new ComboBox();
        ((ISupportInitialize)dgv_cart).BeginInit();
        grp_Action.SuspendLayout();
        grp_Search.SuspendLayout();
        groupBox3.SuspendLayout();
        groupBox4.SuspendLayout();
        SuspendLayout();
        // 
        // dgv_cart
        // 
        dgv_cart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgv_cart.Columns.AddRange(new DataGridViewColumn[] { col_ProductName, col_SerialNumber, col_Quantity, col_UnitPrice, col_TotalPrice, col_Remove });
        dgv_cart.Location = new Point(12, 227);
        dgv_cart.Name = "dgv_cart";
        dgv_cart.RowHeadersWidth = 51;
        dgv_cart.Size = new Size(812, 198);
        dgv_cart.TabIndex = 4;
        dgv_cart.CellContentClick += dgv_Cart_CellContentClick;
        // 
        // col_ProductName
        // 
        col_ProductName.HeaderText = "Tên SP\n";
        col_ProductName.MinimumWidth = 6;
        col_ProductName.Name = "col_ProductName";
        col_ProductName.Width = 125;
        // 
        // col_SerialNumber
        // 
        col_SerialNumber.HeaderText = "Serial";
        col_SerialNumber.MinimumWidth = 6;
        col_SerialNumber.Name = "col_SerialNumber";
        col_SerialNumber.Width = 125;
        // 
        // col_Quantity
        // 
        col_Quantity.HeaderText = "SL";
        col_Quantity.MinimumWidth = 6;
        col_Quantity.Name = "col_Quantity";
        col_Quantity.Width = 125;
        // 
        // col_UnitPrice
        // 
        col_UnitPrice.HeaderText = "Đơn giá\n";
        col_UnitPrice.MinimumWidth = 6;
        col_UnitPrice.Name = "col_UnitPrice";
        col_UnitPrice.Width = 125;
        // 
        // col_TotalPrice
        // 
        col_TotalPrice.HeaderText = "Thành tiền\n";
        col_TotalPrice.MinimumWidth = 6;
        col_TotalPrice.Name = "col_TotalPrice";
        col_TotalPrice.Width = 125;
        // 
        // col_Remove
        // 
        col_Remove.HeaderText = "Xóa";
        col_Remove.MinimumWidth = 6;
        col_Remove.Name = "col_Remove";
        col_Remove.Width = 125;
        // 
        // grp_Action
        // 
        grp_Action.Controls.Add(btn_promotion);
        grp_Action.Controls.Add(btn_customer);
        grp_Action.Controls.Add(txt_searchProduct);
        grp_Action.Location = new Point(12, 108);
        grp_Action.Name = "grp_Action";
        grp_Action.Size = new Size(713, 100);
        grp_Action.TabIndex = 5;
        grp_Action.TabStop = false;
        grp_Action.Enter += grp_Action_Enter;
        // 
        // btn_promotion
        // 
        btn_promotion.Location = new Point(531, 28);
        btn_promotion.Name = "btn_promotion";
        btn_promotion.Size = new Size(164, 51);
        btn_promotion.TabIndex = 2;
        btn_promotion.Text = "Mã KM";
        btn_promotion.UseVisualStyleBackColor = true;
        btn_promotion.Click += btn_Promotion_Click;
        // 
        // btn_customer
        // 
        btn_customer.Location = new Point(329, 29);
        btn_customer.Name = "btn_customer";
        btn_customer.Size = new Size(164, 51);
        btn_customer.TabIndex = 1;
        btn_customer.Text = " Khách Hàng";
        btn_customer.UseVisualStyleBackColor = true;
        // 
        // txt_searchProduct
        // 
        txt_searchProduct.Location = new Point(29, 41);
        txt_searchProduct.Name = "txt_searchProduct";
        txt_searchProduct.Size = new Size(279, 27);
        txt_searchProduct.TabIndex = 0;
        // 
        // grp_Search
        // 
        grp_Search.Controls.Add(btn_todayInvoice);
        grp_Search.Controls.Add(btn_cancelInvoice);
        grp_Search.Controls.Add(btn_print);
        grp_Search.Controls.Add(btn_payment);
        grp_Search.Location = new Point(12, 6);
        grp_Search.Name = "grp_Search";
        grp_Search.Size = new Size(713, 96);
        grp_Search.TabIndex = 6;
        grp_Search.TabStop = false;
        // 
        // btn_todayInvoice
        // 
        btn_todayInvoice.Location = new Point(513, 29);
        btn_todayInvoice.Name = "btn_todayInvoice";
        btn_todayInvoice.Size = new Size(161, 42);
        btn_todayInvoice.TabIndex = 13;
        btn_todayInvoice.Text = "Hóa Đơn Hôm Nay";
        btn_todayInvoice.UseVisualStyleBackColor = true;
        // 
        // btn_cancelInvoice
        // 
        btn_cancelInvoice.Location = new Point(329, 29);
        btn_cancelInvoice.Name = "btn_cancelInvoice";
        btn_cancelInvoice.Size = new Size(153, 42);
        btn_cancelInvoice.TabIndex = 12;
        btn_cancelInvoice.Text = "Hủy Hóa Đơn";
        btn_cancelInvoice.UseVisualStyleBackColor = true;
        btn_cancelInvoice.Click += btn_cancelInvoice_Click_1;
        // 
        // btn_print
        // 
        btn_print.Location = new Point(174, 29);
        btn_print.Name = "btn_print";
        btn_print.Size = new Size(134, 42);
        btn_print.TabIndex = 11;
        btn_print.Text = "In Hóa Đơn";
        btn_print.UseVisualStyleBackColor = true;
        btn_print.Click += btn_Print_Click_1;
        // 
        // btn_payment
        // 
        btn_payment.Location = new Point(36, 29);
        btn_payment.Name = "btn_payment";
        btn_payment.Size = new Size(132, 42);
        btn_payment.TabIndex = 10;
        btn_payment.Text = "Thanh Toán";
        btn_payment.UseVisualStyleBackColor = true;
        // 
        // lbl_FinalTotal
        // 
        lbl_FinalTotal.AutoSize = true;
        lbl_FinalTotal.Location = new Point(19, 101);
        lbl_FinalTotal.Name = "lbl_FinalTotal";
        lbl_FinalTotal.Size = new Size(83, 20);
        lbl_FinalTotal.TabIndex = 6;
        lbl_FinalTotal.Text = "Tổng cộng:";
        // 
        // lbl_Discount
        // 
        lbl_Discount.AutoSize = true;
        lbl_Discount.Location = new Point(19, 59);
        lbl_Discount.Name = "lbl_Discount";
        lbl_Discount.Size = new Size(72, 20);
        lbl_Discount.TabIndex = 4;
        lbl_Discount.Text = "Giảm giá:\n";
        // 
        // lbl_SubTotal
        // 
        lbl_SubTotal.AutoSize = true;
        lbl_SubTotal.Location = new Point(19, 23);
        lbl_SubTotal.Name = "lbl_SubTotal";
        lbl_SubTotal.Size = new Size(70, 20);
        lbl_SubTotal.TabIndex = 2;
        lbl_SubTotal.Text = "Tạm tính:\n";
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(lbl_SubTotal);
        groupBox3.Controls.Add(lbl_Discount);
        groupBox3.Controls.Add(lbl_FinalTotal);
        groupBox3.Location = new Point(12, 431);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new Size(812, 137);
        groupBox3.TabIndex = 7;
        groupBox3.TabStop = false;
        // 
        // groupBox4
        // 
        groupBox4.Controls.Add(btn_confirmPayment);
        groupBox4.Controls.Add(cbo_paymentMethod);
        groupBox4.Location = new Point(12, 574);
        groupBox4.Name = "groupBox4";
        groupBox4.Size = new Size(812, 164);
        groupBox4.TabIndex = 8;
        groupBox4.TabStop = false;
        groupBox4.Text = "groupBox4";
        // 
        // btn_confirmPayment
        // 
        btn_confirmPayment.Location = new Point(387, 37);
        btn_confirmPayment.Name = "btn_confirmPayment";
        btn_confirmPayment.Size = new Size(164, 51);
        btn_confirmPayment.TabIndex = 3;
        btn_confirmPayment.Text = "Xác Nhận Thanh Toán";
        btn_confirmPayment.UseVisualStyleBackColor = true;
        // 
        // cbo_paymentMethod
        // 
        cbo_paymentMethod.FormattingEnabled = true;
        cbo_paymentMethod.Items.AddRange(new object[] { "Cash", "Banking", "Momo", "ZaloPay", "Credit Card" });
        cbo_paymentMethod.Location = new Point(18, 49);
        cbo_paymentMethod.Name = "cbo_paymentMethod";
        cbo_paymentMethod.Size = new Size(309, 28);
        cbo_paymentMethod.TabIndex = 0;
        // 
        // FormSell
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1253, 750);
        Controls.Add(groupBox4);
        Controls.Add(groupBox3);
        Controls.Add(grp_Search);
        Controls.Add(grp_Action);
        Controls.Add(dgv_cart);
        Name = "FormSell";
        Text = "FormSell";
        ((ISupportInitialize)dgv_cart).EndInit();
        grp_Action.ResumeLayout(false);
        grp_Action.PerformLayout();
        grp_Search.ResumeLayout(false);
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        groupBox4.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion
    private DataGridView dgv_cart;
    private BackgroundWorker backgroundWorker1;
    private GroupBox grp_Action;
    private GroupBox grp_Search;
    private Label lbl_FinalTotal;
    private Label lbl_Discount;
    private Label lbl_SubTotal;
    private Button btn_print;
    private Button btn_payment;
    private TextBox txt_searchProduct;
    private Button btn_todayInvoice;
    private Button btn_cancelInvoice;
    private Button btn_promotion;
    private Button btn_customer;
    private DataGridViewTextBoxColumn col_ProductName;
    private DataGridViewTextBoxColumn col_SerialNumber;
    private DataGridViewTextBoxColumn col_Quantity;
    private DataGridViewTextBoxColumn col_UnitPrice;
    private DataGridViewTextBoxColumn col_TotalPrice;
    private DataGridViewTextBoxColumn col_Remove;
    private GroupBox groupBox3;
    private GroupBox groupBox4;
    private ComboBox cbo_paymentMethod;
    private Button btn_confirmPayment;
}