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
            dgvDetails = new DataGridView();
            txtReceiptCode = new TextBox();
            cbSuppliers = new ComboBox();
            cbProducts = new ComboBox();
            nudQuantity = new NumericUpDown();
            nudPrice = new NumericUpDown();
            txtTotalAmount = new TextBox();
            btnAddDetail = new Button();
            btnSaveReceipt = new Button();
            btnClear = new Button();
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            lbl4 = new Label();
            lbl5 = new Label();
            lbl6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            SuspendLayout();
            // 
            // dgvDetails
            // 
            dgvDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetails.Location = new Point(15, 170);
            dgvDetails.Name = "dgvDetails";
            dgvDetails.RowHeadersWidth = 51;
            dgvDetails.Size = new Size(750, 210);
            dgvDetails.TabIndex = 0;
            // 
            // txtReceiptCode
            // 
            txtReceiptCode.Location = new Point(110, 20);
            txtReceiptCode.Name = "txtReceiptCode";
            txtReceiptCode.ReadOnly = true;
            txtReceiptCode.Size = new Size(200, 27);
            txtReceiptCode.TabIndex = 1;
            // 
            // cbSuppliers
            // 
            cbSuppliers.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSuppliers.Location = new Point(110, 58);
            cbSuppliers.Name = "cbSuppliers";
            cbSuppliers.Size = new Size(200, 28);
            cbSuppliers.TabIndex = 2;
            cbSuppliers.SelectedIndexChanged += cbSuppliers_SelectedIndexChanged;
            // 
            // cbProducts
            // 
            cbProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProducts.Location = new Point(440, 20);
            cbProducts.Name = "cbProducts";
            cbProducts.Size = new Size(200, 28);
            cbProducts.TabIndex = 3;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(440, 55);
            nudQuantity.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(200, 27);
            nudQuantity.TabIndex = 4;
            // 
            // nudPrice
            // 
            nudPrice.Location = new Point(440, 90);
            nudPrice.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(200, 27);
            nudPrice.TabIndex = 5;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            txtTotalAmount.ForeColor = Color.Red;
            txtTotalAmount.Location = new Point(554, 392);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new Size(218, 28);
            txtTotalAmount.TabIndex = 6;
            txtTotalAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // btnAddDetail
            // 
            btnAddDetail.Location = new Point(440, 125);
            btnAddDetail.Name = "btnAddDetail";
            btnAddDetail.Size = new Size(120, 30);
            btnAddDetail.TabIndex = 7;
            btnAddDetail.Text = "Thêm vào danh sách";
            btnAddDetail.Click += btnAddDetail_Click;
            // 
            // btnSaveReceipt
            // 
            btnSaveReceipt.Location = new Point(15, 393);
            btnSaveReceipt.Name = "btnSaveReceipt";
            btnSaveReceipt.Size = new Size(130, 30);
            btnSaveReceipt.TabIndex = 8;
            btnSaveReceipt.Text = "Hoàn tất nhập kho";
            btnSaveReceipt.Click += btnSaveReceipt_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(160, 393);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 30);
            btnClear.TabIndex = 9;
            btnClear.Text = "Hủy / Làm mới";
            btnClear.Click += btnClear_Click;
            // 
            // lbl1
            // 
            lbl1.Location = new Point(20, 23);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(84, 24);
            lbl1.TabIndex = 5;
            lbl1.Text = "Mã phiếu nhập:";
            // 
            // lbl2
            // 
            lbl2.Location = new Point(10, 58);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(110, 24);
            lbl2.TabIndex = 4;
            lbl2.Text = "Nhà cung cấp:";
            // 
            // lbl3
            // 
            lbl3.Location = new Point(350, 23);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(80, 24);
            lbl3.TabIndex = 3;
            lbl3.Text = "Sản phẩm:";
            // 
            // lbl4
            // 
            lbl4.Location = new Point(350, 58);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(80, 24);
            lbl4.TabIndex = 2;
            lbl4.Text = "Số lượng nhập:";
            // 
            // lbl5
            // 
            lbl5.Location = new Point(350, 93);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(80, 24);
            lbl5.TabIndex = 1;
            lbl5.Text = "Đơn giá nhập:";
            // 
            // lbl6
            // 
            lbl6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lbl6.Location = new Point(430, 395);
            lbl6.Name = "lbl6";
            lbl6.Size = new Size(130, 25);
            lbl6.TabIndex = 0;
            lbl6.Text = "Tổng tiền nhập:";
            // 
            // FormIntoWarehouse
            // 
            ClientSize = new Size(784, 441);
            Controls.Add(lbl6);
            Controls.Add(lbl5);
            Controls.Add(lbl4);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(btnClear);
            Controls.Add(btnSaveReceipt);
            Controls.Add(btnAddDetail);
            Controls.Add(txtTotalAmount);
            Controls.Add(nudPrice);
            Controls.Add(nudQuantity);
            Controls.Add(cbProducts);
            Controls.Add(cbSuppliers);
            Controls.Add(txtReceiptCode);
            Controls.Add(dgvDetails);
            Name = "FormIntoWarehouse";
            Text = "Quản lý Nhập kho";
            Load += FormIntoWarehouse_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.TextBox txtReceiptCode;
        private System.Windows.Forms.ComboBox cbSuppliers;
        private System.Windows.Forms.ComboBox cbProducts;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Button btnAddDetail;
        private System.Windows.Forms.Button btnSaveReceipt;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
    }
}