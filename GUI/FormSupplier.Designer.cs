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
            this.pnl_header = new System.Windows.Forms.Panel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.dgv_suppliers = new System.Windows.Forms.DataGridView();
            this.pnl_details = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_debt = new System.Windows.Forms.TextBox();
            this.lbl_debt = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.lbl_address = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.txt_supplierName = new System.Windows.Forms.TextBox();
            this.lbl_supplierName = new System.Windows.Forms.Label();
            this.lbl_infoTitle = new System.Windows.Forms.Label();
            this.pnl_status = new System.Windows.Forms.Panel();
            this.lbl_totalDebt = new System.Windows.Forms.Label();
            this.lbl_totalSuppliers = new System.Windows.Forms.Label();
            this.pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_suppliers)).BeginInit();
            this.pnl_details.SuspendLayout();
            this.pnl_status.SuspendLayout();
            this.SuspendLayout();
            // pnl_header
            this.pnl_header.Controls.Add(this.btn_refresh);
            this.pnl_header.Controls.Add(this.btn_delete);
            this.pnl_header.Controls.Add(this.btn_edit);
            this.pnl_header.Controls.Add(this.btn_add);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Height = 55;
            // btn_refresh
            this.btn_refresh.Location = new System.Drawing.Point(340, 12);
            this.btn_refresh.Size = new System.Drawing.Size(100, 32);
            this.btn_refresh.Text = "🔄 Làm mới";
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // btn_delete
            this.btn_delete.Location = new System.Drawing.Point(234, 12);
            this.btn_delete.Size = new System.Drawing.Size(100, 32);
            this.btn_delete.Text = "🗑️ Xóa";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // btn_edit
            this.btn_edit.Location = new System.Drawing.Point(128, 12);
            this.btn_edit.Size = new System.Drawing.Size(100, 32);
            this.btn_edit.Text = "✏️ Sửa";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // btn_add
            this.btn_add.Location = new System.Drawing.Point(12, 12);
            this.btn_add.Size = new System.Drawing.Size(110, 32);
            this.btn_add.Text = "➕ Thêm NCC";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // dgv_suppliers
            this.dgv_suppliers.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv_suppliers.Width = 640;
            this.dgv_suppliers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_suppliers_CellClick);
            // pnl_details
            this.pnl_details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_details.Controls.Add(this.btn_cancel);
            this.pnl_details.Controls.Add(this.btn_save);
            this.pnl_details.Controls.Add(this.txt_debt);
            this.pnl_details.Controls.Add(this.lbl_debt);
            this.pnl_details.Controls.Add(this.txt_address);
            this.pnl_details.Controls.Add(this.lbl_address);
            this.pnl_details.Controls.Add(this.txt_phone);
            this.pnl_details.Controls.Add(this.lbl_phone);
            this.pnl_details.Controls.Add(this.txt_supplierName);
            this.pnl_details.Controls.Add(this.lbl_supplierName);
            this.pnl_details.Controls.Add(this.lbl_infoTitle);
            // btn_cancel
            this.btn_cancel.Location = new System.Drawing.Point(175, 335);
            this.btn_cancel.Size = new System.Drawing.Size(120, 35);
            this.btn_cancel.Text = "❌ Hủy";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // btn_save
            this.btn_save.Location = new System.Drawing.Point(35, 335);
            this.btn_save.Size = new System.Drawing.Size(120, 35);
            this.btn_save.Text = "💾 Lưu";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // txt_debt
            this.txt_debt.Location = new System.Drawing.Point(20, 280);
            this.txt_debt.Size = new System.Drawing.Size(300, 26);
            // lbl_debt
            this.lbl_debt.Location = new System.Drawing.Point(20, 260);
            this.lbl_debt.Text = "Công nợ (đ)";
            // txt_address
            this.txt_address.Location = new System.Drawing.Point(20, 210);
            this.txt_address.Size = new System.Drawing.Size(300, 26);
            // lbl_address
            this.lbl_address.Location = new System.Drawing.Point(20, 190);
            this.lbl_address.Text = "Địa chỉ";
            // txt_phone
            this.txt_phone.Location = new System.Drawing.Point(20, 140);
            this.txt_phone.Size = new System.Drawing.Size(300, 26);
            // lbl_phone
            this.lbl_phone.Location = new System.Drawing.Point(20, 120);
            this.lbl_phone.Text = "Số điện thoại *";
            // txt_supplierName
            this.txt_supplierName.Location = new System.Drawing.Point(20, 70);
            this.txt_supplierName.Size = new System.Drawing.Size(300, 29);
            // lbl_supplierName
            this.lbl_supplierName.Location = new System.Drawing.Point(20, 50);
            this.lbl_supplierName.Text = "Tên nhà cung cấp *";
            // lbl_infoTitle
            this.lbl_infoTitle.Location = new System.Drawing.Point(20, 15);
            this.lbl_infoTitle.Text = "📝 Thông tin NCC";
            // pnl_status
            this.pnl_status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_status.Height = 30;
            this.pnl_status.Controls.Add(this.lbl_totalDebt);
            this.pnl_status.Controls.Add(this.lbl_totalSuppliers);
            // lbl_totalDebt
            this.lbl_totalDebt.Location = new System.Drawing.Point(750, 8);
            this.lbl_totalDebt.Text = "Tổng công nợ: 120,000,000 đ";
            // lbl_totalSuppliers
            this.lbl_totalSuppliers.Location = new System.Drawing.Point(12, 8);
            this.lbl_totalSuppliers.Text = "Tổng: 2 nhà cung cấp";
            // FormSupplier
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pnl_details);
            this.Controls.Add(this.dgv_suppliers);
            this.Controls.Add(this.pnl_header);
            this.Controls.Add(this.pnl_status);
            this.Text = "Quản lý Nhà cung cấp";
            this.Load += new System.EventHandler(this.FormSupplier_Load);
            this.pnl_header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_suppliers)).EndInit();
            this.pnl_details.ResumeLayout(false);
            this.pnl_status.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dgv_suppliers;
        private System.Windows.Forms.Panel pnl_details;
        private System.Windows.Forms.Label lbl_infoTitle;
        private System.Windows.Forms.TextBox txt_supplierName;
        private System.Windows.Forms.Label lbl_supplierName;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.TextBox txt_debt;
        private System.Windows.Forms.Label lbl_debt;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel pnl_status;
        private System.Windows.Forms.Label lbl_totalSuppliers;
        private System.Windows.Forms.Label lbl_totalDebt;
    }
}