namespace GUI
{
    partial class FormIntoWarehouse
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
            pnl_header = new Panel();
            btn_history = new Button();
            btn_cancelReceipt = new Button();
            btn_confirmReceipt = new Button();
            btn_createReceipt = new Button();
            pnl_meta = new Panel();
            btn_addProduct = new Button();
            txt_receiptCode = new TextBox();
            lbl_receiptCode = new Label();
            cb_suppliers = new ComboBox();
            lbl_supplier = new Label();
            dgv_details = new DataGridView();
            pnl_summary = new Panel();
            lbl_totalAmount = new Label();
            lbl_totalQty = new Label();
            pnl_footer = new Panel();
            lbl_bottomNcc = new Label();
            pnl_header.SuspendLayout();
            pnl_meta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_details).BeginInit();
            pnl_summary.SuspendLayout();
            pnl_footer.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_header
            // 
            pnl_header.Controls.Add(btn_history);
            pnl_header.Controls.Add(btn_cancelReceipt);
            pnl_header.Controls.Add(btn_confirmReceipt);
            pnl_header.Controls.Add(btn_createReceipt);
            pnl_header.Dock = DockStyle.Top;
            pnl_header.Location = new Point(0, 0);
            pnl_header.Margin = new Padding(7, 8, 7, 8);
            pnl_header.Name = "pnl_header";
            pnl_header.Size = new Size(2448, 162);
            pnl_header.TabIndex = 0;
            // 
            // btn_history
            // 
            btn_history.Location = new Point(874, 33);
            btn_history.Margin = new Padding(7, 8, 7, 8);
            btn_history.Name = "btn_history";
            btn_history.Size = new Size(267, 96);
            btn_history.TabIndex = 3;
            btn_history.Text = "Lịch Sử Phiếu";
            btn_history.UseVisualStyleBackColor = true;
            btn_history.Click += btn_history_Click;
            // 
            // btn_cancelReceipt
            // 
            btn_cancelReceipt.Location = new Point(593, 33);
            btn_cancelReceipt.Margin = new Padding(7, 8, 7, 8);
            btn_cancelReceipt.Name = "btn_cancelReceipt";
            btn_cancelReceipt.Size = new Size(267, 96);
            btn_cancelReceipt.TabIndex = 2;
            btn_cancelReceipt.Text = "Hủy Đơn";
            btn_cancelReceipt.UseVisualStyleBackColor = true;
            btn_cancelReceipt.Click += btn_cancelReceipt_Click;
            // 
            // btn_confirmReceipt
            // 
            btn_confirmReceipt.Location = new Point(311, 33);
            btn_confirmReceipt.Margin = new Padding(7, 8, 7, 8);
            btn_confirmReceipt.Name = "btn_confirmReceipt";
            btn_confirmReceipt.Size = new Size(267, 96);
            btn_confirmReceipt.TabIndex = 1;
            btn_confirmReceipt.Text = "Xác Nhận (Lưu)";
            btn_confirmReceipt.UseVisualStyleBackColor = true;
            btn_confirmReceipt.Click += btn_confirmReceipt_Click;
            // 
            // btn_createReceipt
            // 
            btn_createReceipt.Location = new Point(29, 33);
            btn_createReceipt.Margin = new Padding(7, 8, 7, 8);
            btn_createReceipt.Name = "btn_createReceipt";
            btn_createReceipt.Size = new Size(267, 96);
            btn_createReceipt.TabIndex = 0;
            btn_createReceipt.Text = "+ Tạo Phiếu";
            btn_createReceipt.UseVisualStyleBackColor = true;
            btn_createReceipt.Click += btn_createReceipt_Click;
            // 
            // pnl_meta
            // 
            pnl_meta.Controls.Add(btn_addProduct);
            pnl_meta.Controls.Add(txt_receiptCode);
            pnl_meta.Controls.Add(lbl_receiptCode);
            pnl_meta.Controls.Add(cb_suppliers);
            pnl_meta.Controls.Add(lbl_supplier);
            pnl_meta.Dock = DockStyle.Top;
            pnl_meta.Location = new Point(0, 162);
            pnl_meta.Margin = new Padding(7, 8, 7, 8);
            pnl_meta.Name = "pnl_meta";
            pnl_meta.Size = new Size(2448, 141);
            pnl_meta.TabIndex = 1;
            // 
            // btn_addProduct
            // 
            btn_addProduct.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_addProduct.Location = new Point(2103, 41);
            btn_addProduct.Margin = new Padding(7, 8, 7, 8);
            btn_addProduct.Name = "btn_addProduct";
            btn_addProduct.Size = new Size(316, 82);
            btn_addProduct.TabIndex = 4;
            btn_addProduct.Text = "+ Thêm Hàng Hóa";
            btn_addProduct.UseVisualStyleBackColor = true;
            btn_addProduct.Click += btn_addProduct_Click;
            // 
            // txt_receiptCode
            // 
            txt_receiptCode.Location = new Point(1069, 55);
            txt_receiptCode.Margin = new Padding(7, 8, 7, 8);
            txt_receiptCode.Name = "txt_receiptCode";
            txt_receiptCode.ReadOnly = true;
            txt_receiptCode.Size = new Size(480, 47);
            txt_receiptCode.TabIndex = 3;
            // 
            // lbl_receiptCode
            // 
            lbl_receiptCode.AutoSize = true;
            lbl_receiptCode.Location = new Point(874, 63);
            lbl_receiptCode.Margin = new Padding(7, 0, 7, 0);
            lbl_receiptCode.Name = "lbl_receiptCode";
            lbl_receiptCode.Size = new Size(189, 41);
            lbl_receiptCode.TabIndex = 2;
            lbl_receiptCode.Text = "Mã số phiếu:";
            // 
            // cb_suppliers
            // 
            cb_suppliers.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_suppliers.FormattingEnabled = true;
            cb_suppliers.Location = new Point(243, 55);
            cb_suppliers.Margin = new Padding(7, 8, 7, 8);
            cb_suppliers.Name = "cb_suppliers";
            cb_suppliers.Size = new Size(529, 49);
            cb_suppliers.TabIndex = 1;
            // 
            // lbl_supplier
            // 
            lbl_supplier.AutoSize = true;
            lbl_supplier.Location = new Point(29, 63);
            lbl_supplier.Margin = new Padding(7, 0, 7, 0);
            lbl_supplier.Name = "lbl_supplier";
            lbl_supplier.Size = new Size(208, 41);
            lbl_supplier.TabIndex = 0;
            lbl_supplier.Text = "Nhà cung cấp:";
            // 
            // dgv_details
            // 
            dgv_details.AllowUserToAddRows = false;
            dgv_details.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_details.Dock = DockStyle.Fill;
            dgv_details.Location = new Point(0, 303);
            dgv_details.Margin = new Padding(7, 8, 7, 8);
            dgv_details.Name = "dgv_details";
            dgv_details.RowHeadersWidth = 51;
            dgv_details.Size = new Size(2448, 835);
            dgv_details.TabIndex = 2;
            // 
            // pnl_summary
            // 
            pnl_summary.Controls.Add(lbl_totalAmount);
            pnl_summary.Controls.Add(lbl_totalQty);
            pnl_summary.Dock = DockStyle.Bottom;
            pnl_summary.Location = new Point(0, 1045);
            pnl_summary.Margin = new Padding(7, 8, 7, 8);
            pnl_summary.Name = "pnl_summary";
            pnl_summary.Size = new Size(2448, 93);
            pnl_summary.TabIndex = 3;
            // 
            // lbl_totalAmount
            // 
            lbl_totalAmount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_totalAmount.AutoSize = true;
            lbl_totalAmount.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbl_totalAmount.ForeColor = Color.DarkRed;
            lbl_totalAmount.Location = new Point(1821, 41);
            lbl_totalAmount.Margin = new Padding(7, 0, 7, 0);
            lbl_totalAmount.Name = "lbl_totalAmount";
            lbl_totalAmount.Size = new Size(263, 50);
            lbl_totalAmount.TabIndex = 1;
            lbl_totalAmount.Text = "Tổng tiền: 0 đ";
            // 
            // lbl_totalQty
            // 
            lbl_totalQty.AutoSize = true;
            lbl_totalQty.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbl_totalQty.Location = new Point(29, 41);
            lbl_totalQty.Margin = new Padding(7, 0, 7, 0);
            lbl_totalQty.Name = "lbl_totalQty";
            lbl_totalQty.Size = new Size(316, 50);
            lbl_totalQty.TabIndex = 0;
            lbl_totalQty.Text = "Tổng số lượng: 0";
            // 
            // pnl_footer
            // 
            pnl_footer.Controls.Add(lbl_bottomNcc);
            pnl_footer.Dock = DockStyle.Bottom;
            pnl_footer.Location = new Point(0, 1138);
            pnl_footer.Margin = new Padding(7, 8, 7, 8);
            pnl_footer.Name = "pnl_footer";
            pnl_footer.Size = new Size(2448, 66);
            pnl_footer.TabIndex = 4;
            // 
            // lbl_bottomNcc
            // 
            lbl_bottomNcc.AutoSize = true;
            lbl_bottomNcc.Location = new Point(29, 16);
            lbl_bottomNcc.Margin = new Padding(7, 0, 7, 0);
            lbl_bottomNcc.Name = "lbl_bottomNcc";
            lbl_bottomNcc.Size = new Size(321, 41);
            lbl_bottomNcc.TabIndex = 0;
            lbl_bottomNcc.Text = "Nhà cung cấp hiện tại: ";
            // 
            // FormIntoWarehouse
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2448, 1204);
            Controls.Add(pnl_summary);
            Controls.Add(dgv_details);
            Controls.Add(pnl_footer);
            Controls.Add(pnl_meta);
            Controls.Add(pnl_header);
            Margin = new Padding(7, 8, 7, 8);
            Name = "FormIntoWarehouse";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống quản lý Nhập Kho hàng hóa";
            pnl_header.ResumeLayout(false);
            pnl_meta.ResumeLayout(false);
            pnl_meta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_details).EndInit();
            pnl_summary.ResumeLayout(false);
            pnl_summary.PerformLayout();
            pnl_footer.ResumeLayout(false);
            pnl_footer.PerformLayout();
            ResumeLayout(false);


        }


        #endregion


        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Button btn_history;
        private System.Windows.Forms.Button btn_cancelReceipt;
        private System.Windows.Forms.Button btn_confirmReceipt;
        private System.Windows.Forms.Button btn_createReceipt;
        private System.Windows.Forms.Panel pnl_meta;
        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.TextBox txt_receiptCode;
        private System.Windows.Forms.Label lbl_receiptCode;
        private System.Windows.Forms.ComboBox cb_suppliers;
        private System.Windows.Forms.Label lbl_supplier;
        private System.Windows.Forms.DataGridView dgv_details;
        private System.Windows.Forms.Panel pnl_summary;
        private System.Windows.Forms.Label lbl_totalAmount;
        private System.Windows.Forms.Label lbl_totalQty;
        private System.Windows.Forms.Panel pnl_footer;
        private System.Windows.Forms.Label lbl_bottomNcc;
    }
}

