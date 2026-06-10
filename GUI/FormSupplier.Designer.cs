namespace GUI
{
    partial class FormSupplier
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnl_header = new Panel();
            btn_refresh = new Button();
            btn_delete = new Button();
            btn_edit = new Button();
            btn_add = new Button();
            pnl_status = new Panel();
            lbl_totalDebt = new Label();
            lbl_totalSuppliers = new Label();
            groupBox1 = new GroupBox();
            lbl_supplierName = new Label();
            btn_cancel = new Button();
            txt_supplierName = new TextBox();
            btn_save = new Button();
            lbl_phone = new Label();
            txt_debt = new TextBox();
            txt_phone = new TextBox();
            lbl_debt = new Label();
            lbl_address = new Label();
            txt_address = new TextBox();
            groupBox2 = new GroupBox();
            dgv_suppliers = new DataGridView();
            pnl_header.SuspendLayout();
            pnl_status.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_suppliers).BeginInit();
            SuspendLayout();
            // 
            // pnl_header
            // 
            pnl_header.Controls.Add(btn_refresh);
            pnl_header.Controls.Add(btn_delete);
            pnl_header.Controls.Add(btn_edit);
            pnl_header.Controls.Add(btn_add);
            pnl_header.Dock = DockStyle.Top;
            pnl_header.Location = new Point(0, 0);
            pnl_header.Margin = new Padding(6, 8, 6, 8);
            pnl_header.Name = "pnl_header";
            pnl_header.Size = new Size(1923, 93);
            pnl_header.TabIndex = 0;
            // 
            // btn_refresh
            // 
            btn_refresh.Location = new Point(1228, 12);
            btn_refresh.Margin = new Padding(6, 8, 6, 8);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(347, 63);
            btn_refresh.TabIndex = 3;
            btn_refresh.Text = "🔄 Làm mới";
            btn_refresh.UseVisualStyleBackColor = true;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(801, 12);
            btn_delete.Margin = new Padding(6, 8, 6, 8);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(421, 63);
            btn_delete.TabIndex = 2;
            btn_delete.Text = "🗑️ Xóa";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(393, 12);
            btn_edit.Margin = new Padding(6, 8, 6, 8);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(402, 63);
            btn_edit.TabIndex = 1;
            btn_edit.Text = "✏️ Sửa";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(12, 12);
            btn_add.Margin = new Padding(6, 8, 6, 8);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(375, 63);
            btn_add.TabIndex = 0;
            btn_add.Text = "➕ Thêm NCC";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // pnl_status
            // 
            pnl_status.Controls.Add(lbl_totalDebt);
            pnl_status.Controls.Add(lbl_totalSuppliers);
            pnl_status.Dock = DockStyle.Bottom;
            pnl_status.Location = new Point(0, 864);
            pnl_status.Margin = new Padding(6, 8, 6, 8);
            pnl_status.Name = "pnl_status";
            pnl_status.Size = new Size(1923, 86);
            pnl_status.TabIndex = 1;
            // 
            // lbl_totalDebt
            // 
            lbl_totalDebt.AutoSize = true;
            lbl_totalDebt.Location = new Point(750, 30);
            lbl_totalDebt.Margin = new Padding(6, 0, 6, 0);
            lbl_totalDebt.Name = "lbl_totalDebt";
            lbl_totalDebt.Size = new Size(254, 41);
            lbl_totalDebt.TabIndex = 1;
            lbl_totalDebt.Text = "Tổng công nợ: 0đ";
            // 
            // lbl_totalSuppliers
            // 
            lbl_totalSuppliers.AutoSize = true;
            lbl_totalSuppliers.Location = new Point(26, 30);
            lbl_totalSuppliers.Margin = new Padding(6, 0, 6, 0);
            lbl_totalSuppliers.Name = "lbl_totalSuppliers";
            lbl_totalSuppliers.Size = new Size(185, 41);
            lbl_totalSuppliers.TabIndex = 0;
            lbl_totalSuppliers.Text = "Tổng NCC: 0";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbl_supplierName);
            groupBox1.Controls.Add(btn_cancel);
            groupBox1.Controls.Add(txt_supplierName);
            groupBox1.Controls.Add(btn_save);
            groupBox1.Controls.Add(lbl_phone);
            groupBox1.Controls.Add(txt_debt);
            groupBox1.Controls.Add(txt_phone);
            groupBox1.Controls.Add(lbl_debt);
            groupBox1.Controls.Add(lbl_address);
            groupBox1.Controls.Add(txt_address);
            groupBox1.Location = new Point(1251, 104);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(672, 749);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "📋 Thông tin nhà cung cấp";
            // 
            // lbl_supplierName
            // 
            lbl_supplierName.Location = new Point(6, 59);
            lbl_supplierName.Name = "lbl_supplierName";
            lbl_supplierName.Size = new Size(314, 46);
            lbl_supplierName.TabIndex = 1;
            lbl_supplierName.Text = "Tên NCC *:";
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(6, 654);
            btn_cancel.Margin = new Padding(6, 8, 6, 8);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(457, 64);
            btn_cancel.TabIndex = 10;
            btn_cancel.Text = "❌ Hủy";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // txt_supplierName
            // 
            txt_supplierName.Location = new Point(9, 113);
            txt_supplierName.Margin = new Padding(6, 8, 6, 8);
            txt_supplierName.Name = "txt_supplierName";
            txt_supplierName.Size = new Size(929, 47);
            txt_supplierName.TabIndex = 2;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(9, 577);
            btn_save.Margin = new Padding(6, 8, 6, 8);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(466, 64);
            btn_save.TabIndex = 9;
            btn_save.Text = "💾 Lưu";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // lbl_phone
            // 
            lbl_phone.Location = new Point(9, 186);
            lbl_phone.Name = "lbl_phone";
            lbl_phone.Size = new Size(314, 46);
            lbl_phone.TabIndex = 3;
            lbl_phone.Text = "Số điện thoại *:";
            // 
            // txt_debt
            // 
            txt_debt.Location = new Point(9, 489);
            txt_debt.Margin = new Padding(6, 8, 6, 8);
            txt_debt.Name = "txt_debt";
            txt_debt.Size = new Size(929, 47);
            txt_debt.TabIndex = 8;
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(9, 240);
            txt_phone.Margin = new Padding(6, 8, 6, 8);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(929, 47);
            txt_phone.TabIndex = 4;
            // 
            // lbl_debt
            // 
            lbl_debt.Location = new Point(9, 435);
            lbl_debt.Name = "lbl_debt";
            lbl_debt.Size = new Size(314, 46);
            lbl_debt.TabIndex = 7;
            lbl_debt.Text = "Công nợ (đ):";
            // 
            // lbl_address
            // 
            lbl_address.Location = new Point(9, 315);
            lbl_address.Name = "lbl_address";
            lbl_address.Size = new Size(314, 46);
            lbl_address.TabIndex = 5;
            lbl_address.Text = "Địa chỉ:";
            // 
            // txt_address
            // 
            txt_address.Location = new Point(6, 369);
            txt_address.Margin = new Padding(6, 8, 6, 8);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(929, 47);
            txt_address.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgv_suppliers);
            groupBox2.Location = new Point(0, 104);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1254, 749);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            // 
            // dgv_suppliers
            // 
            dgv_suppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_suppliers.Location = new Point(6, 29);
            dgv_suppliers.Name = "dgv_suppliers";
            dgv_suppliers.RowHeadersWidth = 102;
            dgv_suppliers.Size = new Size(1239, 720);
            dgv_suppliers.TabIndex = 0;
            dgv_suppliers.CellClick += dgv_suppliers_CellClick;
            // 
            // FormSupplier
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1923, 950);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pnl_status);
            Controls.Add(pnl_header);
            Margin = new Padding(6, 8, 6, 8);
            Name = "FormSupplier";
            Text = "Quản lý nhà cung cấp";
            Load += FormSupplier_Load;
            pnl_header.ResumeLayout(false);
            pnl_status.ResumeLayout(false);
            pnl_status.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_suppliers).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Panel pnl_status;
        private System.Windows.Forms.Label lbl_totalSuppliers;
        private System.Windows.Forms.Label lbl_totalDebt;
        private System.Windows.Forms.Panel pnl_details;
        private System.Windows.Forms.Label lbl_infoTitle;
        private System.Windows.Forms.Label lbl_supplierName;
        private System.Windows.Forms.TextBox txt_supplierName;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label lbl_debt;
        private System.Windows.Forms.TextBox txt_debt;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dgv_suppliers;
    }
}