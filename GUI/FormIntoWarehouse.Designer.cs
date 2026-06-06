namespace GUI
{
    partial class FormIntoWarehouse
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

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
            lbl_bottomStatus = new Label();
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
            pnl_header.Name = "pnl_header";
            pnl_header.Size = new Size(784, 50);
            pnl_header.TabIndex = 3;
            // 
            // btn_history
            // 
            btn_history.Location = new Point(450, 10);
            btn_history.Name = "btn_history";
            btn_history.Size = new Size(130, 30);
            btn_history.TabIndex = 0;
            btn_history.Text = "📋 Lịch sử nhập";
            btn_history.Click += btn_history_Click;
            // 
            // btn_cancelReceipt
            // 
            btn_cancelReceipt.Location = new Point(320, 10);
            btn_cancelReceipt.Name = "btn_cancelReceipt";
            btn_cancelReceipt.Size = new Size(115, 30);
            btn_cancelReceipt.TabIndex = 1;
            btn_cancelReceipt.Text = "❌ Hủy phiếu";
            btn_cancelReceipt.Click += btn_cancelReceipt_Click;
            // 
            // btn_confirmReceipt
            // 
            btn_confirmReceipt.Location = new Point(170, 10);
            btn_confirmReceipt.Name = "btn_confirmReceipt";
            btn_confirmReceipt.Size = new Size(144, 30);
            btn_confirmReceipt.TabIndex = 2;
            btn_confirmReceipt.Text = "✔️ Xác nhận nhập";
            btn_confirmReceipt.Click += btn_confirmReceipt_Click;
            // 
            // btn_createReceipt
            // 
            btn_createReceipt.Location = new Point(15, 10);
            btn_createReceipt.Name = "btn_createReceipt";
            btn_createReceipt.Size = new Size(140, 30);
            btn_createReceipt.TabIndex = 3;
            btn_createReceipt.Text = "＋ Tạo phiếu nhập";
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
            pnl_meta.Location = new Point(0, 50);
            pnl_meta.Name = "pnl_meta";
            pnl_meta.Size = new Size(784, 75);
            pnl_meta.TabIndex = 2;
            // 
            // btn_addProduct
            // 
            btn_addProduct.Location = new Point(685, 10);
            btn_addProduct.Name = "btn_addProduct";
            btn_addProduct.Size = new Size(80, 55);
            btn_addProduct.TabIndex = 0;
            btn_addProduct.Text = "＋\r\nThêm\r\nSP";
            btn_addProduct.Click += btn_addProduct_Click;
            // 
            // txt_receiptCode
            // 
            txt_receiptCode.Location = new Point(555, 25);
            txt_receiptCode.Name = "txt_receiptCode";
            txt_receiptCode.Size = new Size(115, 27);
            txt_receiptCode.TabIndex = 1;
            txt_receiptCode.TextChanged += txt_receiptCode_TextChanged;
            // 
            // lbl_receiptCode
            // 
            lbl_receiptCode.Location = new Point(480, 30);
            lbl_receiptCode.Name = "lbl_receiptCode";
            lbl_receiptCode.Size = new Size(100, 23);
            lbl_receiptCode.TabIndex = 2;
            lbl_receiptCode.Text = "Mã phiếu:";
            lbl_receiptCode.Click += lbl_receiptCode_Click;
            // 
            // cb_suppliers
            // 
            cb_suppliers.Location = new Point(120, 25);
            cb_suppliers.Name = "cb_suppliers";
            cb_suppliers.Size = new Size(337, 28);
            cb_suppliers.TabIndex = 3;
            // 
            // lbl_supplier
            // 
            lbl_supplier.Location = new Point(15, 28);
            lbl_supplier.Name = "lbl_supplier";
            lbl_supplier.Size = new Size(117, 23);
            lbl_supplier.TabIndex = 4;
            lbl_supplier.Text = "Nhà cung cấp:";
            // 
            // dgv_details
            // 
            dgv_details.ColumnHeadersHeight = 29;
            dgv_details.Dock = DockStyle.Fill;
            dgv_details.Location = new Point(0, 125);
            dgv_details.Name = "dgv_details";
            dgv_details.RowHeadersWidth = 51;
            dgv_details.Size = new Size(784, 225);
            dgv_details.TabIndex = 0;
            // 
            // pnl_summary
            // 
            pnl_summary.Controls.Add(lbl_totalAmount);
            pnl_summary.Controls.Add(lbl_totalQty);
            pnl_summary.Dock = DockStyle.Bottom;
            pnl_summary.Location = new Point(0, 350);
            pnl_summary.Name = "pnl_summary";
            pnl_summary.Size = new Size(784, 30);
            pnl_summary.TabIndex = 1;
            // 
            // lbl_totalAmount
            // 
            lbl_totalAmount.Location = new Point(540, 5);
            lbl_totalAmount.Name = "lbl_totalAmount";
            lbl_totalAmount.Size = new Size(100, 23);
            lbl_totalAmount.TabIndex = 0;
            lbl_totalAmount.Text = "Tổng tiền: 165,000,000 đ";
            // 
            // lbl_totalQty
            // 
            lbl_totalQty.Location = new Point(420, 5);
            lbl_totalQty.Name = "lbl_totalQty";
            lbl_totalQty.Size = new Size(100, 23);
            lbl_totalQty.TabIndex = 1;
            lbl_totalQty.Text = "Tổng SL: 15";
            // 
            // pnl_footer
            // 
            pnl_footer.Controls.Add(lbl_bottomNcc);
            pnl_footer.Controls.Add(lbl_bottomStatus);
            pnl_footer.Dock = DockStyle.Bottom;
            pnl_footer.Location = new Point(0, 380);
            pnl_footer.Name = "pnl_footer";
            pnl_footer.Size = new Size(784, 25);
            pnl_footer.TabIndex = 4;
            // 
            // lbl_bottomNcc
            // 
            lbl_bottomNcc.Location = new Point(570, 3);
            lbl_bottomNcc.Name = "lbl_bottomNcc";
            lbl_bottomNcc.Size = new Size(117, 20);
            lbl_bottomNcc.TabIndex = 0;
            lbl_bottomNcc.Text = "NCC: Apple VN";
            // 
            // lbl_bottomStatus
            // 
            lbl_bottomStatus.Location = new Point(15, 3);
            lbl_bottomStatus.Name = "lbl_bottomStatus";
            lbl_bottomStatus.Size = new Size(262, 20);
            lbl_bottomStatus.TabIndex = 1;
            lbl_bottomStatus.Text = "Phiếu: PN20240601 — Chưa xác nhận";
            // 
            // FormIntoWarehouse
            // 
            ClientSize = new Size(784, 405);
            Controls.Add(dgv_details);
            Controls.Add(pnl_summary);
            Controls.Add(pnl_meta);
            Controls.Add(pnl_header);
            Controls.Add(pnl_footer);
            Name = "FormIntoWarehouse";
            Text = "Nhập kho";
            Load += FormIntoWarehouse_Load;
            pnl_header.ResumeLayout(false);
            pnl_meta.ResumeLayout(false);
            pnl_meta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_details).EndInit();
            pnl_summary.ResumeLayout(false);
            pnl_footer.ResumeLayout(false);
            ResumeLayout(false);
        }
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