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
            this.pnl_header = new System.Windows.Forms.Panel();
            this.btn_history = new System.Windows.Forms.Button();
            this.btn_cancelReceipt = new System.Windows.Forms.Button();
            this.btn_confirmReceipt = new System.Windows.Forms.Button();
            this.btn_createReceipt = new System.Windows.Forms.Button();
            this.pnl_meta = new System.Windows.Forms.Panel();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.txt_receiptCode = new System.Windows.Forms.TextBox();
            this.lbl_receiptCode = new System.Windows.Forms.Label();
            this.cb_suppliers = new System.Windows.Forms.ComboBox();
            this.lbl_supplier = new System.Windows.Forms.Label();
            this.dgv_details = new System.Windows.Forms.DataGridView();
            this.pnl_summary = new System.Windows.Forms.Panel();
            this.lbl_totalAmount = new System.Windows.Forms.Label();
            this.lbl_totalQty = new System.Windows.Forms.Label();
            this.pnl_footer = new System.Windows.Forms.Panel();
            this.lbl_bottomNcc = new System.Windows.Forms.Label();
            this.lbl_bottomStatus = new System.Windows.Forms.Label();
            this.pnl_header.SuspendLayout();
            this.pnl_meta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_details)).BeginInit();
            this.pnl_summary.SuspendLayout();
            this.pnl_footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.Controls.Add(this.btn_history);
            this.pnl_header.Controls.Add(this.btn_cancelReceipt);
            this.pnl_header.Controls.Add(this.btn_confirmReceipt);
            this.pnl_header.Controls.Add(this.btn_createReceipt);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(884, 50);
            this.pnl_header.TabIndex = 0;
            // 
            // btn_history
            // 
            this.btn_history.Location = new System.Drawing.Point(450, 10);
            this.btn_history.Name = "btn_history";
            this.btn_history.Size = new System.Drawing.Size(130, 30);
            this.btn_history.TabIndex = 3;
            this.btn_history.Text = "📋 Lịch sử nhập";
            this.btn_history.UseVisualStyleBackColor = true;
            this.btn_history.Click += new System.EventHandler(this.btn_history_Click);
            // 
            // btn_cancelReceipt
            // 
            this.btn_cancelReceipt.Location = new System.Drawing.Point(320, 10);
            this.btn_cancelReceipt.Name = "btn_cancelReceipt";
            this.btn_cancelReceipt.Size = new System.Drawing.Size(115, 30);
            this.btn_cancelReceipt.TabIndex = 2;
            this.btn_cancelReceipt.Text = "❌ Hủy phiếu";
            this.btn_cancelReceipt.UseVisualStyleBackColor = true;
            this.btn_cancelReceipt.Click += new System.EventHandler(this.btn_cancelReceipt_Click);
            // 
            // btn_confirmReceipt
            // 
            this.btn_confirmReceipt.Location = new System.Drawing.Point(170, 10);
            this.btn_confirmReceipt.Name = "btn_confirmReceipt";
            this.btn_confirmReceipt.Size = new System.Drawing.Size(135, 30);
            this.btn_confirmReceipt.TabIndex = 1;
            this.btn_confirmReceipt.Text = "✔️ Xác nhận nhập";
            this.btn_confirmReceipt.UseVisualStyleBackColor = true;
            this.btn_confirmReceipt.Click += new System.EventHandler(this.btn_confirmReceipt_Click);
            // 
            // btn_createReceipt
            // 
            this.btn_createReceipt.Location = new System.Drawing.Point(15, 10);
            this.btn_createReceipt.Name = "btn_createReceipt";
            this.btn_createReceipt.Size = new System.Drawing.Size(140, 30);
            this.btn_createReceipt.TabIndex = 0;
            this.btn_createReceipt.Text = "＋ Tạo phiếu nhập";
            this.btn_createReceipt.UseVisualStyleBackColor = true;
            this.btn_createReceipt.Click += new System.EventHandler(this.btn_createReceipt_Click);
            // 
            // pnl_meta
            // 
            this.pnl_meta.Controls.Add(this.btn_addProduct);
            this.pnl_meta.Controls.Add(this.txt_receiptCode);
            this.pnl_meta.Controls.Add(this.lbl_receiptCode);
            this.pnl_meta.Controls.Add(this.cb_suppliers);
            this.pnl_meta.Controls.Add(this.lbl_supplier);
            this.pnl_meta.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_meta.Location = new System.Drawing.Point(0, 50);
            this.pnl_meta.Name = "pnl_meta";
            this.pnl_meta.Size = new System.Drawing.Size(884, 75);
            this.pnl_meta.TabIndex = 1;
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.Location = new System.Drawing.Point(750, 10);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(90, 55);
            this.btn_addProduct.TabIndex = 4;
            this.btn_addProduct.Text = "＋\r\nThêm\r\nSP";
            this.btn_addProduct.UseVisualStyleBackColor = true;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // txt_receiptCode
            // 
            this.txt_receiptCode.Location = new System.Drawing.Point(580, 25);
            this.txt_receiptCode.Name = "txt_receiptCode";
            this.txt_receiptCode.ReadOnly = true;
            this.txt_receiptCode.Size = new System.Drawing.Size(150, 22);
            this.txt_receiptCode.TabIndex = 3;
            // 
            // lbl_receiptCode
            // 
            this.lbl_receiptCode.AutoSize = true;
            this.lbl_receiptCode.Location = new System.Drawing.Point(510, 28);
            this.lbl_receiptCode.Name = "lbl_receiptCode";
            this.lbl_receiptCode.Size = new System.Drawing.Size(65, 16);
            this.lbl_receiptCode.TabIndex = 2;
            this.lbl_receiptCode.Text = "Mã phiếu:";
            // 
            // cb_suppliers
            // 
            this.cb_suppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_suppliers.FormattingEnabled = true;
            this.cb_suppliers.Location = new System.Drawing.Point(120, 25);
            this.cb_suppliers.Name = "cb_suppliers";
            this.cb_suppliers.Size = new System.Drawing.Size(350, 24);
            this.cb_suppliers.TabIndex = 1;
            // 
            // lbl_supplier
            // 
            this.lbl_supplier.AutoSize = true;
            this.lbl_supplier.Location = new System.Drawing.Point(15, 28);
            this.lbl_supplier.Name = "lbl_supplier";
            this.lbl_supplier.Size = new System.Drawing.Size(93, 16);
            this.lbl_supplier.TabIndex = 0;
            this.lbl_supplier.Text = "Nhà cung cấp:";
            // 
            // dgv_details
            // 
            this.dgv_details.AllowUserToAddRows = false;
            this.dgv_details.AllowUserToDeleteRows = false;
            this.dgv_details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_details.BackgroundColor = System.Drawing.Color.White;
            this.dgv_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_details.Location = new System.Drawing.Point(0, 125);
            this.dgv_details.Name = "dgv_details";
            this.dgv_details.ReadOnly = true;
            this.dgv_details.RowHeadersWidth = 51;
            this.dgv_details.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_details.Size = new System.Drawing.Size(884, 301);
            this.dgv_details.TabIndex = 2;
            // 
            // pnl_summary
            // 
            this.pnl_summary.Controls.Add(this.lbl_totalAmount);
            this.pnl_summary.Controls.Add(this.lbl_totalQty);
            this.pnl_summary.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_summary.Location = new System.Drawing.Point(0, 426);
            this.pnl_summary.Name = "pnl_summary";
            this.pnl_summary.Size = new System.Drawing.Size(884, 40);
            this.pnl_summary.TabIndex = 3;
            // 
            // lbl_totalAmount
            // 
            this.lbl_totalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_totalAmount.AutoSize = true;
            this.lbl_totalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalAmount.ForeColor = System.Drawing.Color.Green;
            this.lbl_totalAmount.Location = new System.Drawing.Point(650, 10);
            this.lbl_totalAmount.Name = "lbl_totalAmount";
            this.lbl_totalAmount.Size = new System.Drawing.Size(109, 18);
            this.lbl_totalAmount.TabIndex = 1;
            this.lbl_totalAmount.Text = "Tổng tiền: 0 đ";
            // 
            // lbl_totalQty
            // 
            this.lbl_totalQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_totalQty.AutoSize = true;
            this.lbl_totalQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalQty.Location = new System.Drawing.Point(500, 10);
            this.lbl_totalQty.Name = "lbl_totalQty";
            this.lbl_totalQty.Size = new System.Drawing.Size(91, 18);
            this.lbl_totalQty.TabIndex = 0;
            this.lbl_totalQty.Text = "Tổng SL: 0";
            // 
            // pnl_footer
            // 
            this.pnl_footer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_footer.Controls.Add(this.lbl_bottomNcc);
            this.pnl_footer.Controls.Add(this.lbl_bottomStatus);
            this.pnl_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_footer.Location = new System.Drawing.Point(0, 466);
            this.pnl_footer.Name = "pnl_footer";
            this.pnl_footer.Size = new System.Drawing.Size(884, 30);
            this.pnl_footer.TabIndex = 4;
            // 
            // lbl_bottomNcc
            // 
            this.lbl_bottomNcc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_bottomNcc.AutoSize = true;
            this.lbl_bottomNcc.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_bottomNcc.Location = new System.Drawing.Point(650, 5);
            this.lbl_bottomNcc.Name = "lbl_bottomNcc";
            this.lbl_bottomNcc.Size = new System.Drawing.Size(59, 16);
            this.lbl_bottomNcc.TabIndex = 1;
            this.lbl_bottomNcc.Text = "NCC: ---";
            this.lbl_bottomNcc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_bottomStatus
            // 
            this.lbl_bottomStatus.AutoSize = true;
            this.lbl_bottomStatus.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_bottomStatus.Location = new System.Drawing.Point(12, 5);
            this.lbl_bottomStatus.Name = "lbl_bottomStatus";
            this.lbl_bottomStatus.Size = new System.Drawing.Size(65, 16);
            this.lbl_bottomStatus.TabIndex = 0;
            this.lbl_bottomStatus.Text = "Phiếu: ---";
            // 
            // FormIntoWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 496);
            this.Controls.Add(this.dgv_details);
            this.Controls.Add(this.pnl_summary);
            this.Controls.Add(this.pnl_meta);
            this.Controls.Add(this.pnl_header);
            this.Controls.Add(this.pnl_footer);
            this.Name = "FormIntoWarehouse";
            this.Text = "Nhập kho";
            this.Load += new System.EventHandler(this.FormIntoWarehouse_Load);
            this.pnl_header.ResumeLayout(false);
            this.pnl_meta.ResumeLayout(false);
            this.pnl_meta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_details)).EndInit();
            this.pnl_summary.ResumeLayout(false);
            this.pnl_summary.PerformLayout();
            this.pnl_footer.ResumeLayout(false);
            this.pnl_footer.PerformLayout();
            this.ResumeLayout(false);
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
        private System.Windows.Forms.Label lbl_bottomStatus;
    }
}