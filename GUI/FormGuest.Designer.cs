namespace GUI
{
    partial class FormGuest
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
            this.components = new System.ComponentModel.Container();
            this.dgv_guest = new System.Windows.Forms.DataGridView();
            this.col_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_date = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.btn_addCustomer = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_purchaseHistory = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();

            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_search = new System.Windows.Forms.TextBox();

            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();

            this.txt_phoneNumber = new System.Windows.Forms.TextBox();
            this.txt_fullName = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.cbo_customerType = new System.Windows.Forms.ComboBox();

            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();

            this.pnl_top = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();

            ((System.ComponentModel.ISupportInitialize)(this.dgv_guest)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnl_top.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();

            // dgv_guest
            this.dgv_guest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_guest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.col_phone,
                this.col_name,
                this.col_type,
                this.col_points,
                this.col_total,
                this.col_date
            });
            this.dgv_guest.Location = new System.Drawing.Point(6, 16);
            this.dgv_guest.Name = "dgv_guest";
            this.dgv_guest.RowHeadersWidth = 51;
            this.dgv_guest.Size = new System.Drawing.Size(620, 380);
            this.dgv_guest.TabIndex = 1;
            this.dgv_guest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_guest_CellContentClick);

            // col_phone
            this.col_phone.HeaderText = "SĐT";
            this.col_phone.MinimumWidth = 6;
            this.col_phone.Name = "col_phone";
            this.col_phone.Width = 125;
            this.col_phone.DataPropertyName = "Phone";

            // col_name
            this.col_name.HeaderText = "Họ tên";
            this.col_name.MinimumWidth = 6;
            this.col_name.Name = "col_name";
            this.col_name.Width = 150;
            this.col_name.DataPropertyName = "FullName";

            // col_type
            this.col_type.HeaderText = "Loại KH";
            this.col_type.MinimumWidth = 6;
            this.col_type.Name = "col_type";
            this.col_type.Width = 100;
            this.col_type.DataPropertyName = "CustomerType";

            // col_points
            this.col_points.HeaderText = "Điểm tích lũy";
            this.col_points.MinimumWidth = 6;
            this.col_points.Name = "col_points";
            this.col_points.Width = 100;
            this.col_points.DataPropertyName = "TotalPoints";

            // col_total
            this.col_total.HeaderText = "Tổng mua";
            this.col_total.MinimumWidth = 6;
            this.col_total.Name = "col_total";
            this.col_total.Width = 120;
            this.col_total.DataPropertyName = "TotalPurchase";

            // col_date
            this.col_date.HeaderText = "Ngày tạo";
            this.col_date.MinimumWidth = 6;
            this.col_date.Name = "col_date";
            this.col_date.Width = 140;
            this.col_date.DataPropertyName = "CreatedAt";

            // Buttons top
            this.btn_addCustomer.Location = new System.Drawing.Point(6, 6);
            this.btn_addCustomer.Name = "btn_addCustomer";
            this.btn_addCustomer.Size = new System.Drawing.Size(120, 28);
            this.btn_addCustomer.TabIndex = 2;
            this.btn_addCustomer.Text = "Thêm KH";
            this.btn_addCustomer.UseVisualStyleBackColor = true;

            this.btn_edit.Location = new System.Drawing.Point(132, 6);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(120, 28);
            this.btn_edit.TabIndex = 3;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.UseVisualStyleBackColor = true;

            this.btn_purchaseHistory.Location = new System.Drawing.Point(258, 6);
            this.btn_purchaseHistory.Name = "btn_purchaseHistory";
            this.btn_purchaseHistory.Size = new System.Drawing.Size(140, 28);
            this.btn_purchaseHistory.TabIndex = 4;
            this.btn_purchaseHistory.Text = "Lịch sử mua";
            this.btn_purchaseHistory.UseVisualStyleBackColor = true;

            this.btn_refresh.Location = new System.Drawing.Point(404, 6);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(120, 28);
            this.btn_refresh.TabIndex = 5;
            this.btn_refresh.Text = "Làm mới";
            this.btn_refresh.UseVisualStyleBackColor = true;

            // groupBox2 (table)
            this.groupBox2.Controls.Add(this.dgv_guest);
            this.groupBox2.Location = new System.Drawing.Point(6, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(632, 406);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;

            // Search box
            this.txt_search.Location = new System.Drawing.Point(6, 12);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(632, 27);
            this.txt_search.TabIndex = 2;
            this.txt_search.Text = "";

            // groupBox3 (detail)
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txt_phoneNumber);
            this.groupBox3.Controls.Add(this.txt_fullName);
            this.groupBox3.Controls.Add(this.txt_address);
            this.groupBox3.Controls.Add(this.cbo_customerType);
            this.groupBox3.Controls.Add(this.btn_save);
            this.groupBox3.Controls.Add(this.btn_cancel);
            this.groupBox3.Location = new System.Drawing.Point(644, 72);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 406);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "THÔNG TIN KHÁCH HÀNG";

            // Labels and inputs
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.Text = "SĐT:";

            this.txt_phoneNumber.Location = new System.Drawing.Point(12, 48);
            this.txt_phoneNumber.Name = "txt_phoneNumber";
            this.txt_phoneNumber.Size = new System.Drawing.Size(332, 27);

            this.label7.Location = new System.Drawing.Point(12, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.Text = "Họ Tên:";

            this.txt_fullName.Location = new System.Drawing.Point(12, 100);
            this.txt_fullName.Name = "txt_fullName";
            this.txt_fullName.Size = new System.Drawing.Size(332, 27);

            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.Text = "Địa Chỉ:";

            this.txt_address.Location = new System.Drawing.Point(12, 156);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(332, 27);

            this.label2.Location = new System.Drawing.Point(12, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.Text = "Loại Khách:";

            this.cbo_customerType.Location = new System.Drawing.Point(12, 212);
            this.cbo_customerType.Name = "cbo_customerType";
            this.cbo_customerType.Size = new System.Drawing.Size(332, 28);
            this.cbo_customerType.Items.AddRange(new object[] { "Thường", "Thân thiết", "VIP" });

            this.btn_save.Location = new System.Drawing.Point(12, 260);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(332, 30);
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;

            this.btn_cancel.Location = new System.Drawing.Point(12, 300);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(332, 30);
            this.btn_cancel.Text = "Hủy";
            this.btn_cancel.UseVisualStyleBackColor = true;

            // pnl_top
            this.pnl_top.Controls.Add(this.btn_addCustomer);
            this.pnl_top.Controls.Add(this.btn_edit);
            this.pnl_top.Controls.Add(this.btn_purchaseHistory);
            this.pnl_top.Controls.Add(this.btn_refresh);
            this.pnl_top.Location = new System.Drawing.Point(6, 6);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(998, 40);

            // groupBox1 (search)
            this.groupBox1.Controls.Add(this.txt_search);
            this.groupBox1.Location = new System.Drawing.Point(6, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 44);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;

            // FormGuest
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 490);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormGuest";
            this.Text = "Quản lý Khách hàng";

            ((System.ComponentModel.ISupportInitialize)(this.dgv_guest)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.pnl_top.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_guest;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_points;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_date;

        private System.Windows.Forms.Button btn_addCustomer;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_purchaseHistory;
        private System.Windows.Forms.Button btn_refresh;

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_search;

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox txt_phoneNumber;
        private System.Windows.Forms.TextBox txt_fullName;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.ComboBox cbo_customerType;

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
