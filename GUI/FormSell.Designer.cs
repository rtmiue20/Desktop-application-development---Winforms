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

    private void InitializeComponent()
    {
        pnl_top = new Panel();
        btn_add = new Button();
        btn_edit = new Button();
        btn_delete = new Button();
        btn_refresh = new Button();
        pnl_search = new Panel();
        txt_searchProduct = new TextBox();
        dgv_cart = new DataGridView();
        pnl_details = new Panel();
        grp_paymentMethod = new GroupBox();
        cbo_paymentMethod = new ComboBox();
        btn_confirmPayment = new Button();
        grp_payment = new GroupBox();
        lbl_subTotal = new Label();
        lbl_discount = new Label();
        lbl_finalTotal = new Label();
        pnl_bottom = new Panel();
        btn_save = new Button();
        btn_cancel = new Button();
        col_productName = new DataGridViewTextBoxColumn();
        col_productsId = new DataGridViewTextBoxColumn();
        col_quantity = new DataGridViewTextBoxColumn();
        col_unitPrice = new DataGridViewTextBoxColumn();
        col_totalPrice = new DataGridViewTextBoxColumn();
        col_remove = new DataGridViewTextBoxColumn();
        pnl_top.SuspendLayout();
        pnl_search.SuspendLayout();
        ((ISupportInitialize)dgv_cart).BeginInit();
        pnl_details.SuspendLayout();
        grp_paymentMethod.SuspendLayout();
        grp_payment.SuspendLayout();
        pnl_bottom.SuspendLayout();
        SuspendLayout();
        // 
        // pnl_top
        // 
        pnl_top.Controls.Add(btn_add);
        pnl_top.Controls.Add(btn_edit);
        pnl_top.Controls.Add(btn_delete);
        pnl_top.Controls.Add(btn_refresh);
        pnl_top.Dock = DockStyle.Top;
        pnl_top.Location = new Point(0, 0);
        pnl_top.Margin = new Padding(2);
        pnl_top.Name = "pnl_top";
        pnl_top.Size = new Size(1988, 102);
        pnl_top.TabIndex = 0;
        // 
        // btn_add
        // 
        btn_add.Location = new Point(13, 12);
        btn_add.Margin = new Padding(2);
        btn_add.Name = "btn_add";
        btn_add.Size = new Size(374, 64);
        btn_add.TabIndex = 0;
        btn_add.Text = "Khách Hàng";
        btn_add.UseVisualStyleBackColor = true;
        btn_add.Click += btn_Customer_Click;
        // 
        // btn_edit
        // 
        btn_edit.Location = new Point(393, 12);
        btn_edit.Margin = new Padding(2);
        btn_edit.Name = "btn_edit";
        btn_edit.Size = new Size(402, 64);
        btn_edit.TabIndex = 1;
        btn_edit.Text = "Khuyến Mãi";
        btn_edit.UseVisualStyleBackColor = true;
        btn_edit.Click += btn_Promotion_Click;
        // 
        // btn_delete
        // 
        btn_delete.Location = new Point(801, 12);
        btn_delete.Margin = new Padding(2);
        btn_delete.Name = "btn_delete";
        btn_delete.Size = new Size(421, 64);
        btn_delete.TabIndex = 2;
        btn_delete.Text = "Hủy Hóa Đơn";
        btn_delete.UseVisualStyleBackColor = true;
        btn_delete.Click += btn_CancelInvoice_Click;
        // 
        // btn_refresh
        // 
        btn_refresh.Location = new Point(1228, 12);
        btn_refresh.Margin = new Padding(2);
        btn_refresh.Name = "btn_refresh";
        btn_refresh.Size = new Size(346, 64);
        btn_refresh.TabIndex = 3;
        btn_refresh.Text = "Hóa Đơn Hôm Nay";
        btn_refresh.UseVisualStyleBackColor = true;
        btn_refresh.Click += btnTodayInvoice_Click;
        // 
        // pnl_search
        // 
        pnl_search.Controls.Add(txt_searchProduct);
        pnl_search.Dock = DockStyle.Top;
        pnl_search.Location = new Point(0, 102);
        pnl_search.Margin = new Padding(2);
        pnl_search.Name = "pnl_search";
        pnl_search.Size = new Size(1988, 70);
        pnl_search.TabIndex = 4;
        // 
        // txt_searchProduct
        // 
        txt_searchProduct.Dock = DockStyle.Fill;
        txt_searchProduct.Font = new Font("Segoe UI", 14F);
        txt_searchProduct.Location = new Point(0, 0);
        txt_searchProduct.Margin = new Padding(13, 12, 13, 12);
        txt_searchProduct.Name = "txt_searchProduct";
        txt_searchProduct.PlaceholderText = "Quét mã SP / Serial... (Nhấn Enter để thêm)";
        txt_searchProduct.Size = new Size(1988, 70);
        txt_searchProduct.TabIndex = 0;
        // 
        // dgv_cart
        // 
        dgv_cart.ColumnHeadersHeight = 58;
        dgv_cart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgv_cart.Columns.AddRange(new DataGridViewColumn[] { col_productName, col_productsId, col_quantity, col_unitPrice, col_totalPrice, col_remove });
        dgv_cart.Dock = DockStyle.Left;
        dgv_cart.Location = new Point(0, 172);
        dgv_cart.Margin = new Padding(2);
        dgv_cart.Name = "dgv_cart";
        dgv_cart.RowHeadersWidth = 102;
        dgv_cart.Size = new Size(1238, 821);
        dgv_cart.TabIndex = 1;
        dgv_cart.CellContentClick += dgv_Cart_CellContentClick;
        // 
        // pnl_details
        // 
        pnl_details.Controls.Add(grp_paymentMethod);
        pnl_details.Controls.Add(grp_payment);
        pnl_details.Dock = DockStyle.Fill;
        pnl_details.Location = new Point(1238, 172);
        pnl_details.Margin = new Padding(2);
        pnl_details.Name = "pnl_details";
        pnl_details.Size = new Size(750, 821);
        pnl_details.TabIndex = 2;
        // 
        // grp_paymentMethod
        // 
        grp_paymentMethod.Controls.Add(cbo_paymentMethod);
        grp_paymentMethod.Controls.Add(btn_confirmPayment);
        grp_paymentMethod.Location = new Point(6, 291);
        grp_paymentMethod.Margin = new Padding(2);
        grp_paymentMethod.Name = "grp_paymentMethod";
        grp_paymentMethod.Padding = new Padding(2);
        grp_paymentMethod.Size = new Size(708, 201);
        grp_paymentMethod.TabIndex = 1;
        grp_paymentMethod.TabStop = false;
        grp_paymentMethod.Text = "Phương Thức Thanh Toán";
        grp_paymentMethod.Visible = false;
        // 
        // cbo_paymentMethod
        // 
        cbo_paymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
        cbo_paymentMethod.FormattingEnabled = true;
        cbo_paymentMethod.Items.AddRange(new object[] { "Tiền mặt", "Chuyển khoản", "MoMo", "ZaloPay", "Thẻ tín dụng" });
        cbo_paymentMethod.Location = new Point(13, 43);
        cbo_paymentMethod.Margin = new Padding(2);
        cbo_paymentMethod.Name = "cbo_paymentMethod";
        cbo_paymentMethod.Size = new Size(686, 49);
        cbo_paymentMethod.TabIndex = 0;
        // 
        // btn_confirmPayment
        // 
        btn_confirmPayment.Location = new Point(13, 104);
        btn_confirmPayment.Margin = new Padding(2);
        btn_confirmPayment.Name = "btn_confirmPayment";
        btn_confirmPayment.Size = new Size(686, 64);
        btn_confirmPayment.TabIndex = 1;
        btn_confirmPayment.Text = "Xác Nhận Thanh Toán";
        btn_confirmPayment.UseVisualStyleBackColor = true;
        btn_confirmPayment.Click += btn_ConfirmPayment_Click;
        // 
        // grp_payment
        // 
        grp_payment.Controls.Add(lbl_subTotal);
        grp_payment.Controls.Add(lbl_discount);
        grp_payment.Controls.Add(lbl_finalTotal);
        grp_payment.Location = new Point(6, 6);
        grp_payment.Margin = new Padding(2);
        grp_payment.Name = "grp_payment";
        grp_payment.Padding = new Padding(2);
        grp_payment.Size = new Size(710, 281);
        grp_payment.TabIndex = 0;
        grp_payment.TabStop = false;
        grp_payment.Text = "Thanh Toán";
        // 
        // lbl_subTotal
        // 
        lbl_subTotal.AutoSize = true;
        lbl_subTotal.Location = new Point(13, 59);
        lbl_subTotal.Margin = new Padding(2, 0, 2, 0);
        lbl_subTotal.Name = "lbl_subTotal";
        lbl_subTotal.Size = new Size(215, 41);
        lbl_subTotal.TabIndex = 0;
        lbl_subTotal.Text = "Tạm tính:    0 đ";
        // 
        // lbl_discount
        // 
        lbl_discount.AutoSize = true;
        lbl_discount.ForeColor = Color.OrangeRed;
        lbl_discount.Location = new Point(13, 116);
        lbl_discount.Margin = new Padding(2, 0, 2, 0);
        lbl_discount.Name = "lbl_discount";
        lbl_discount.Size = new Size(236, 41);
        lbl_discount.TabIndex = 1;
        lbl_discount.Text = "Giảm giá:    - 0 đ";
        // 
        // lbl_finalTotal
        // 
        lbl_finalTotal.AutoSize = true;
        lbl_finalTotal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lbl_finalTotal.ForeColor = Color.DarkGreen;
        lbl_finalTotal.Location = new Point(13, 191);
        lbl_finalTotal.Margin = new Padding(2, 0, 2, 0);
        lbl_finalTotal.Name = "lbl_finalTotal";
        lbl_finalTotal.Size = new Size(426, 72);
        lbl_finalTotal.TabIndex = 2;
        lbl_finalTotal.Text = "Tổng cộng:  0 đ";
        // 
        // pnl_bottom
        // 
        pnl_bottom.Controls.Add(btn_save);
        pnl_bottom.Controls.Add(btn_cancel);
        pnl_bottom.Dock = DockStyle.Bottom;
        pnl_bottom.Location = new Point(0, 993);
        pnl_bottom.Margin = new Padding(2);
        pnl_bottom.Name = "pnl_bottom";
        pnl_bottom.Size = new Size(1988, 121);
        pnl_bottom.TabIndex = 3;
        // 
        // btn_save
        // 
        btn_save.Location = new Point(13, 29);
        btn_save.Margin = new Padding(2);
        btn_save.Name = "btn_save";
        btn_save.Size = new Size(812, 64);
        btn_save.TabIndex = 0;
        btn_save.Text = "In Hóa Đơn";
        btn_save.UseVisualStyleBackColor = true;
        btn_save.Click += btn_Print_Click;
        // 
        // btn_cancel
        // 
        btn_cancel.Location = new Point(829, 29);
        btn_cancel.Margin = new Padding(2);
        btn_cancel.Name = "btn_cancel";
        btn_cancel.Size = new Size(771, 64);
        btn_cancel.TabIndex = 1;
        btn_cancel.Text = "Thanh Toán";
        btn_cancel.UseVisualStyleBackColor = true;
        btn_cancel.Click += btn_Payment_Click;
        // 
        // col_productName
        // 
        col_productName.HeaderText = "Tên SP";
        col_productName.MinimumWidth = 6;
        col_productName.Name = "col_productName";
        col_productName.Width = 180;
        // 
        // col_productsId
        // 
        col_productsId.HeaderText = "Mã SP";
        col_productsId.MinimumWidth = 6;
        col_productsId.Name = "col_productsId";
        col_productsId.Width = 150;
        // 
        // col_quantity
        // 
        col_quantity.HeaderText = "SL";
        col_quantity.MinimumWidth = 6;
        col_quantity.Name = "col_quantity";
        col_quantity.Width = 80;
        // 
        // col_unitPrice
        // 
        col_unitPrice.HeaderText = "Đơn giá";
        col_unitPrice.MinimumWidth = 6;
        col_unitPrice.Name = "col_unitPrice";
        col_unitPrice.Width = 120;
        // 
        // col_totalPrice
        // 
        col_totalPrice.HeaderText = "Thành tiền";
        col_totalPrice.MinimumWidth = 6;
        col_totalPrice.Name = "col_totalPrice";
        col_totalPrice.Width = 120;
        // 
        // col_remove
        // 
        col_remove.HeaderText = "Xóa";
        col_remove.MinimumWidth = 6;
        col_remove.Name = "col_remove";
        col_remove.Width = 70;
        // 
        // FormSell
        // 
        AutoScaleDimensions = new SizeF(17F, 41F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1988, 1114);
        Controls.Add(pnl_details);
        Controls.Add(dgv_cart);
        Controls.Add(pnl_search);
        Controls.Add(pnl_bottom);
        Controls.Add(pnl_top);
        Margin = new Padding(6);
        Name = "FormSell";
        Text = "Bán hàng";
        Load += FormSell_Load;
        pnl_top.ResumeLayout(false);
        pnl_search.ResumeLayout(false);
        pnl_search.PerformLayout();
        ((ISupportInitialize)dgv_cart).EndInit();
        pnl_details.ResumeLayout(false);
        grp_paymentMethod.ResumeLayout(false);
        grp_payment.ResumeLayout(false);
        grp_payment.PerformLayout();
        pnl_bottom.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Panel pnl_top;
    private System.Windows.Forms.Button btn_add;
    private System.Windows.Forms.Button btn_edit;
    private System.Windows.Forms.Button btn_delete;
    private System.Windows.Forms.Button btn_refresh;
    
    private System.Windows.Forms.Panel pnl_search;
    private System.Windows.Forms.TextBox txt_searchProduct;
    
    private System.Windows.Forms.DataGridView dgv_cart;
    
    private System.Windows.Forms.Panel pnl_details;
    private System.Windows.Forms.GroupBox grp_payment;
    private System.Windows.Forms.Label lbl_subTotal;
    private System.Windows.Forms.Label lbl_discount;
    private System.Windows.Forms.Label lbl_finalTotal;
    
    private System.Windows.Forms.GroupBox grp_paymentMethod;
    private System.Windows.Forms.ComboBox cbo_paymentMethod;
    private System.Windows.Forms.Button btn_confirmPayment;
    
    private System.Windows.Forms.Panel pnl_bottom;
    private System.Windows.Forms.Button btn_save;
    private System.Windows.Forms.Button btn_cancel;

    #endregion

    private DataGridViewTextBoxColumn col_productName;
    private DataGridViewTextBoxColumn col_productsId;
    private DataGridViewTextBoxColumn col_quantity;
    private DataGridViewTextBoxColumn col_unitPrice;
    private DataGridViewTextBoxColumn col_totalPrice;
    private DataGridViewTextBoxColumn col_remove;
}