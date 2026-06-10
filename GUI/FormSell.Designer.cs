namespace GUI
{
    partial class FormSell
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.pnl_search = new System.Windows.Forms.Panel();
            this.txt_searchProduct = new System.Windows.Forms.TextBox();
            this.pnl_details = new System.Windows.Forms.Panel();
            this.grp_paymentMethod = new System.Windows.Forms.GroupBox();
            this.btn_confirmPayment = new System.Windows.Forms.Button();
            this.cbo_paymentMethod = new System.Windows.Forms.ComboBox();
            this.grp_payment = new System.Windows.Forms.GroupBox();
            this.lbl_finalTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_discount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_subTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_bottom = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.dgv_cart = new System.Windows.Forms.DataGridView();
            this.col_productsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_serialId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_serialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_top.SuspendLayout();
            this.pnl_search.SuspendLayout();
            this.pnl_details.SuspendLayout();
            this.grp_paymentMethod.SuspendLayout();
            this.grp_payment.SuspendLayout();
            this.pnl_bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cart)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_top.Controls.Add(this.btn_refresh);
            this.pnl_top.Controls.Add(this.btn_delete);
            this.pnl_top.Controls.Add(this.btn_edit);
            this.pnl_top.Controls.Add(this.btn_add);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(1587, 80);
            this.pnl_top.TabIndex = 0;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_refresh.Location = new System.Drawing.Point(440, 15);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(120, 50);
            this.btn_refresh.TabIndex = 3;
            this.btn_refresh.Text = "Làm mới";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_delete.Location = new System.Drawing.Point(300, 15);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(120, 50);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Xóa dòng";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_edit.Location = new System.Drawing.Point(160, 15);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(120, 50);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "Sửa SL";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_add.Location = new System.Drawing.Point(20, 15);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(120, 50);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Tìm KH";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // pnl_search
            // 
            this.pnl_search.BackColor = System.Drawing.Color.White;
            this.pnl_search.Controls.Add(this.txt_searchProduct);
            this.pnl_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_search.Location = new System.Drawing.Point(0, 80);
            this.pnl_search.Name = "pnl_search";
            this.pnl_search.Padding = new System.Windows.Forms.Padding(20);
            this.pnl_search.Size = new System.Drawing.Size(1137, 80);
            this.pnl_search.TabIndex = 1;
            // 
            // txt_searchProduct
            // 
            this.txt_searchProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_searchProduct.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_searchProduct.Location = new System.Drawing.Point(20, 20);
            this.txt_searchProduct.Name = "txt_searchProduct";
            this.txt_searchProduct.PlaceholderText = "Quét mã vạch (Barcode) hoặc nhập mã Serial, Mã sản phẩm rồi nhấn Enter...";
            this.txt_searchProduct.Size = new System.Drawing.Size(1097, 38);
            this.txt_searchProduct.TabIndex = 0;
            this.txt_searchProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_searchProduct_KeyDown);
            // 
            // pnl_details
            // 
            this.pnl_details.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_details.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_details.Controls.Add(this.grp_paymentMethod);
            this.pnl_details.Controls.Add(this.grp_payment);
            this.pnl_details.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_details.Location = new System.Drawing.Point(1137, 80);
            this.pnl_details.Name = "pnl_details";
            this.pnl_details.Padding = new System.Windows.Forms.Padding(10);
            this.pnl_details.Size = new System.Drawing.Size(450, 770);
            this.pnl_details.TabIndex = 3;
            // 
            // grp_paymentMethod
            // 
            this.grp_paymentMethod.Controls.Add(this.btn_confirmPayment);
            this.grp_paymentMethod.Controls.Add(this.cbo_paymentMethod);
            this.grp_paymentMethod.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp_paymentMethod.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grp_paymentMethod.Location = new System.Drawing.Point(10, 310);
            this.grp_paymentMethod.Name = "grp_paymentMethod";
            this.grp_paymentMethod.Size = new System.Drawing.Size(428, 150);
            this.grp_paymentMethod.TabIndex = 1;
            this.grp_paymentMethod.TabStop = false;
            this.grp_paymentMethod.Text = "Hình thức thanh toán";
            // 
            // btn_confirmPayment
            // 
            this.btn_confirmPayment.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_confirmPayment.ForeColor = System.Drawing.Color.White;
            this.btn_confirmPayment.Location = new System.Drawing.Point(20, 80);
            this.btn_confirmPayment.Name = "btn_confirmPayment";
            this.btn_confirmPayment.Size = new System.Drawing.Size(390, 50);
            this.btn_confirmPayment.TabIndex = 1;
            this.btn_confirmPayment.Text = "XÁC NHẬN THANH TOÁN (F9)";
            this.btn_confirmPayment.UseVisualStyleBackColor = false;
            this.btn_confirmPayment.Click += new System.EventHandler(this.btn_confirmPayment_Click);
            // 
            // cbo_paymentMethod
            // 
            this.cbo_paymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_paymentMethod.FormattingEnabled = true;
            this.cbo_paymentMethod.Items.AddRange(new object[] {
            "Tiền mặt",
            "Chuyển khoản / Quẹt thẻ"});
            this.cbo_paymentMethod.Location = new System.Drawing.Point(20, 35);
            this.cbo_paymentMethod.Name = "cbo_paymentMethod";
            this.cbo_paymentMethod.Size = new System.Drawing.Size(390, 33);
            this.cbo_paymentMethod.TabIndex = 0;
            // 
            // grp_payment
            // 
            this.grp_payment.Controls.Add(this.lbl_finalTotal);
            this.grp_payment.Controls.Add(this.label3);
            this.grp_payment.Controls.Add(this.lbl_discount);
            this.grp_payment.Controls.Add(this.label2);
            this.grp_payment.Controls.Add(this.lbl_subTotal);
            this.grp_payment.Controls.Add(this.label1);
            this.grp_payment.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp_payment.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grp_payment.Location = new System.Drawing.Point(10, 10);
            this.grp_payment.Name = "grp_payment";
            this.grp_payment.Size = new System.Drawing.Size(428, 300);
            this.grp_payment.TabIndex = 0;
            this.grp_payment.TabStop = false;
            this.grp_payment.Text = "Thông tin thanh toán";
            // 
            // lbl_finalTotal
            // 
            this.lbl_finalTotal.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_finalTotal.ForeColor = System.Drawing.Color.Red;
            this.lbl_finalTotal.Location = new System.Drawing.Point(15, 200);
            this.lbl_finalTotal.Name = "lbl_finalTotal";
            this.lbl_finalTotal.Size = new System.Drawing.Size(400, 60);
            this.lbl_finalTotal.TabIndex = 5;
            this.lbl_finalTotal.Text = "0";
            this.lbl_finalTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "TỔNG PHẢI TRẢ:";
            // 
            // lbl_discount
            // 
            this.lbl_discount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_discount.Location = new System.Drawing.Point(215, 100);
            this.lbl_discount.Name = "lbl_discount";
            this.lbl_discount.Size = new System.Drawing.Size(200, 35);
            this.lbl_discount.TabIndex = 3;
            this.lbl_discount.Text = "0";
            this.lbl_discount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giảm giá:";
            // 
            // lbl_subTotal
            // 
            this.lbl_subTotal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_subTotal.Location = new System.Drawing.Point(215, 50);
            this.lbl_subTotal.Name = "lbl_subTotal";
            this.lbl_subTotal.Size = new System.Drawing.Size(200, 35);
            this.lbl_subTotal.TabIndex = 1;
            this.lbl_subTotal.Text = "0";
            this.lbl_subTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tạm tính:";
            // 
            // pnl_bottom
            // 
            this.pnl_bottom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_bottom.Controls.Add(this.btn_cancel);
            this.pnl_bottom.Controls.Add(this.btn_save);
            this.pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_bottom.Location = new System.Drawing.Point(0, 850);
            this.pnl_bottom.Name = "pnl_bottom";
            this.pnl_bottom.Size = new System.Drawing.Size(1587, 100);
            this.pnl_bottom.TabIndex = 4;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cancel.Location = new System.Drawing.Point(20, 25);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(150, 50);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "✖ HỦY PHIẾU";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(1377, 25);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(180, 50);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "💾 THU TIỀN (F9)";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dgv_cart
            // 
            this.dgv_cart.AllowUserToAddRows = false;
            this.dgv_cart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cart.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_cart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_cart.ColumnHeadersHeight = 45;
            this.dgv_cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_cart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_productsId,
            this.col_productName,
            this.col_serialId,
            this.col_serialNumber,
            this.col_quantity,
            this.col_unitPrice,
            this.col_totalPrice});
            this.dgv_cart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_cart.Location = new System.Drawing.Point(0, 160);
            this.dgv_cart.Name = "dgv_cart";
            this.dgv_cart.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgv_cart.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_cart.RowTemplate.Height = 40;
            this.dgv_cart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cart.Size = new System.Drawing.Size(1137, 690);
            this.dgv_cart.TabIndex = 2;
            this.dgv_cart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cart_CellClick);
            this.dgv_cart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Cart_CellContentClick);
            // 
            // col_productsId
            // 
            this.col_productsId.HeaderText = "Mã SP";
            this.col_productsId.Name = "col_productsId";
            this.col_productsId.ReadOnly = true;
            this.col_productsId.Visible = false;
            // 
            // col_productName
            // 
            this.col_productName.HeaderText = "Tên Sản Phẩm";
            this.col_productName.Name = "col_productName";
            this.col_productName.ReadOnly = true;
            // 
            // col_serialId
            // 
            this.col_serialId.HeaderText = "ID Serial";
            this.col_serialId.Name = "col_serialId";
            this.col_serialId.ReadOnly = true;
            this.col_serialId.Visible = false;
            // 
            // col_serialNumber
            // 
            this.col_serialNumber.HeaderText = "Mã Serial / IMEI";
            this.col_serialNumber.Name = "col_serialNumber";
            this.col_serialNumber.ReadOnly = true;
            // 
            // col_quantity
            // 
            this.col_quantity.HeaderText = "SL";
            this.col_quantity.Name = "col_quantity";
            // 
            // col_unitPrice
            // 
            this.col_unitPrice.HeaderText = "Đơn Giá";
            this.col_unitPrice.Name = "col_unitPrice";
            this.col_unitPrice.ReadOnly = true;
            // 
            // col_totalPrice
            // 
            this.col_totalPrice.HeaderText = "Thành Tiền";
            this.col_totalPrice.Name = "col_totalPrice";
            this.col_totalPrice.ReadOnly = true;
            // 
            // FormSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1587, 950);
            this.Controls.Add(this.dgv_cart);
            this.Controls.Add(this.pnl_details);
            this.Controls.Add(this.pnl_search);
            this.Controls.Add(this.pnl_bottom);
            this.Controls.Add(this.pnl_top);
            this.Name = "FormSell";
            this.Text = "Giao Diện Bán Hàng (POS)";
            this.Load += new System.EventHandler(this.FormSell_Load);
            this.pnl_top.ResumeLayout(false);
            this.pnl_search.ResumeLayout(false);
            this.pnl_search.PerformLayout();
            this.pnl_details.ResumeLayout(false);
            this.grp_paymentMethod.ResumeLayout(false);
            this.grp_payment.ResumeLayout(false);
            this.grp_payment.PerformLayout();
            this.pnl_bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_productsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_serialId;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_serialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_unitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_totalPrice;
    }
}