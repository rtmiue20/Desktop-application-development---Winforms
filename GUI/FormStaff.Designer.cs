namespace GUI
{
    partial class FormStaff
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
            this.grp_topBar = new System.Windows.Forms.GroupBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_changePassword = new System.Windows.Forms.Button();
            this.btn_disable = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.grp_bottom = new System.Windows.Forms.GroupBox();
            this.lbl_selectedStaff = new System.Windows.Forms.Label();
            this.lbl_totalStaff = new System.Windows.Forms.Label();
            this.grp_staffInfo = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.cbb_role = new System.Windows.Forms.ComboBox();
            this.lbl_role = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.txt_fullName = new System.Windows.Forms.TextBox();
            this.lbl_fullName = new System.Windows.Forms.Label();
            this.grp_list = new System.Windows.Forms.GroupBox();
            this.dgv_staffList = new System.Windows.Forms.DataGridView();

            this.grp_topBar.SuspendLayout();
            this.grp_bottom.SuspendLayout();
            this.grp_staffInfo.SuspendLayout();
            this.grp_list.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staffList)).BeginInit();
            this.SuspendLayout();

            // 
            // grp_topBar
            // 
            this.grp_topBar.Controls.Add(this.btn_refresh);
            this.grp_topBar.Controls.Add(this.btn_changePassword);
            this.grp_topBar.Controls.Add(this.btn_disable);
            this.grp_topBar.Controls.Add(this.btn_edit);
            this.grp_topBar.Controls.Add(this.btn_add);
            this.grp_topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp_topBar.Location = new System.Drawing.Point(0, 0);
            this.grp_topBar.Name = "grp_topBar";
            this.grp_topBar.Size = new System.Drawing.Size(1200, 70);
            this.grp_topBar.TabIndex = 0;
            this.grp_topBar.TabStop = false;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(520, 20);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(100, 40);
            this.btn_refresh.TabIndex = 4;
            this.btn_refresh.Text = "Làm mới";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_changePassword
            // 
            this.btn_changePassword.Location = new System.Drawing.Point(370, 20);
            this.btn_changePassword.Name = "btn_changePassword";
            this.btn_changePassword.Size = new System.Drawing.Size(140, 40);
            this.btn_changePassword.TabIndex = 3;
            this.btn_changePassword.Text = "Đổi mật khẩu";
            this.btn_changePassword.UseVisualStyleBackColor = true;
            this.btn_changePassword.Click += new System.EventHandler(this.btn_changePassword_Click);
            // 
            // btn_disable
            // 
            this.btn_disable.Location = new System.Drawing.Point(240, 20);
            this.btn_disable.Name = "btn_disable";
            this.btn_disable.Size = new System.Drawing.Size(120, 40);
            this.btn_disable.TabIndex = 2;
            this.btn_disable.Text = "Vô hiệu hóa";
            this.btn_disable.UseVisualStyleBackColor = true;
            this.btn_disable.Click += new System.EventHandler(this.btn_disable_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(130, 20);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(100, 40);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(20, 20);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 40);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "+ Thêm NV";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // grp_bottom
            // 
            this.grp_bottom.Controls.Add(this.lbl_selectedStaff);
            this.grp_bottom.Controls.Add(this.lbl_totalStaff);
            this.grp_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grp_bottom.Location = new System.Drawing.Point(0, 660);
            this.grp_bottom.Name = "grp_bottom";
            this.grp_bottom.Size = new System.Drawing.Size(1200, 40);
            this.grp_bottom.TabIndex = 3;
            this.grp_bottom.TabStop = false;
            // 
            // lbl_selectedStaff
            // 
            this.lbl_selectedStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_selectedStaff.AutoSize = true;
            this.lbl_selectedStaff.Location = new System.Drawing.Point(950, 15);
            this.lbl_selectedStaff.Name = "lbl_selectedStaff";
            this.lbl_selectedStaff.Size = new System.Drawing.Size(200, 16);
            this.lbl_selectedStaff.TabIndex = 1;
            this.lbl_selectedStaff.Text = "Đang chọn: Không có";
            this.lbl_selectedStaff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_totalStaff
            // 
            this.lbl_totalStaff.AutoSize = true;
            this.lbl_totalStaff.Location = new System.Drawing.Point(20, 15);
            this.lbl_totalStaff.Name = "lbl_totalStaff";
            this.lbl_totalStaff.Size = new System.Drawing.Size(115, 16);
            this.lbl_totalStaff.TabIndex = 0;
            this.lbl_totalStaff.Text = "Tổng: 0 nhân viên";
            // 
            // grp_staffInfo
            // 
            this.grp_staffInfo.Controls.Add(this.btn_cancel);
            this.grp_staffInfo.Controls.Add(this.btn_save);
            this.grp_staffInfo.Controls.Add(this.cbb_role);
            this.grp_staffInfo.Controls.Add(this.lbl_role);
            this.grp_staffInfo.Controls.Add(this.txt_phone);
            this.grp_staffInfo.Controls.Add(this.lbl_phone);
            this.grp_staffInfo.Controls.Add(this.txt_password);
            this.grp_staffInfo.Controls.Add(this.lbl_password);
            this.grp_staffInfo.Controls.Add(this.txt_username);
            this.grp_staffInfo.Controls.Add(this.lbl_username);
            this.grp_staffInfo.Controls.Add(this.txt_fullName);
            this.grp_staffInfo.Controls.Add(this.lbl_fullName);
            this.grp_staffInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.grp_staffInfo.Location = new System.Drawing.Point(850, 70); // Right side
            this.grp_staffInfo.Name = "grp_staffInfo";
            this.grp_staffInfo.Size = new System.Drawing.Size(350, 590); // Thu nhỏ Form thông tin
            this.grp_staffInfo.TabIndex = 2;
            this.grp_staffInfo.TabStop = false;
            this.grp_staffInfo.Text = "Thông tin nhân viên";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(180, 390);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(140, 45);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "X Hủy";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(20, 390);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(140, 45);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // cbb_role
            // 
            this.cbb_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_role.FormattingEnabled = true;
            this.cbb_role.Items.AddRange(new object[] { "Quản lý", "Thu ngân", "Kho" });
            this.cbb_role.Location = new System.Drawing.Point(20, 330);
            this.cbb_role.Name = "cbb_role";
            this.cbb_role.Size = new System.Drawing.Size(300, 24);
            this.cbb_role.TabIndex = 9;
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.Location = new System.Drawing.Point(20, 310);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(45, 16);
            this.lbl_role.TabIndex = 8;
            this.lbl_role.Text = "Vai trò";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(20, 260);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(300, 30);
            this.txt_phone.TabIndex = 7;
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(20, 240);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(85, 16);
            this.lbl_phone.TabIndex = 6;
            this.lbl_phone.Text = "Số điện thoại";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(20, 190);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(300, 30);
            this.txt_password.TabIndex = 5;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(20, 170);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(61, 16);
            this.lbl_password.TabIndex = 4;
            this.lbl_password.Text = "Mật khẩu";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(20, 120);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(300, 30);
            this.txt_username.TabIndex = 3;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(20, 100);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(76, 16);
            this.lbl_username.TabIndex = 2;
            this.lbl_username.Text = "Tài khoản *";
            // 
            // txt_fullName
            // 
            this.txt_fullName.Location = new System.Drawing.Point(20, 50);
            this.txt_fullName.Name = "txt_fullName";
            this.txt_fullName.Size = new System.Drawing.Size(300, 30);
            this.txt_fullName.TabIndex = 1;
            // 
            // lbl_fullName
            // 
            this.lbl_fullName.AutoSize = true;
            this.lbl_fullName.Location = new System.Drawing.Point(20, 30);
            this.lbl_fullName.Name = "lbl_fullName";
            this.lbl_fullName.Size = new System.Drawing.Size(55, 16);
            this.lbl_fullName.TabIndex = 0;
            this.lbl_fullName.Text = "Họ tên *";
            // 
            // grp_list
            // 
            this.grp_list.Controls.Add(this.dgv_staffList);
            this.grp_list.Dock = System.Windows.Forms.DockStyle.Fill; // Fill phần còn lại, bự ra
            this.grp_list.Location = new System.Drawing.Point(0, 70);
            this.grp_list.Name = "grp_list";
            this.grp_list.Padding = new System.Windows.Forms.Padding(10);
            this.grp_list.Size = new System.Drawing.Size(850, 590);
            this.grp_list.TabIndex = 1;
            this.grp_list.TabStop = false;
            // 
            // dgv_staffList
            // 
            this.dgv_staffList.AllowUserToAddRows = false;
            this.dgv_staffList.AllowUserToDeleteRows = false;
            this.dgv_staffList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill; // Hiển thị full chiều rộng
            this.dgv_staffList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_staffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_staffList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_staffList.Location = new System.Drawing.Point(10, 25);
            this.dgv_staffList.Name = "dgv_staffList";
            this.dgv_staffList.ReadOnly = true;
            this.dgv_staffList.RowHeadersVisible = false;
            this.dgv_staffList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_staffList.Size = new System.Drawing.Size(830, 555);
            this.dgv_staffList.TabIndex = 0;
            this.dgv_staffList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_staffList_CellClick);
            // 
            // FormStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.grp_list);
            this.Controls.Add(this.grp_staffInfo);
            this.Controls.Add(this.grp_bottom);
            this.Controls.Add(this.grp_topBar);
            this.Name = "FormStaff";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.FormStaff_Load);
            this.grp_topBar.ResumeLayout(false);
            this.grp_bottom.ResumeLayout(false);
            this.grp_bottom.PerformLayout();
            this.grp_staffInfo.ResumeLayout(false);
            this.grp_staffInfo.PerformLayout();
            this.grp_list.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staffList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_topBar;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_changePassword;
        private System.Windows.Forms.Button btn_disable;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.GroupBox grp_bottom;
        private System.Windows.Forms.Label lbl_selectedStaff;
        private System.Windows.Forms.Label lbl_totalStaff;
        private System.Windows.Forms.GroupBox grp_staffInfo;
        private System.Windows.Forms.GroupBox grp_list;
        private System.Windows.Forms.DataGridView dgv_staffList;
        private System.Windows.Forms.TextBox txt_fullName;
        private System.Windows.Forms.Label lbl_fullName;
        private System.Windows.Forms.ComboBox cbb_role;
        private System.Windows.Forms.Label lbl_role;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
    }
}