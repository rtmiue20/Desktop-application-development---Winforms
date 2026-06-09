using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class FormStaff : Form
    {
        private readonly UsersBUS _userBUS = new UsersBUS();
        private int _selectedUserID = -1;
        private bool _isAdding = false;

        public FormStaff()
        {
            InitializeComponent();
            dgv_staffList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FormStaff_Load(object sender, EventArgs e)
        {
            // Cấu hình thêm cho combobox Role nếu chưa có item
            if (cbb_role.Items.Count == 0)
            {
                cbb_role.Items.AddRange(new object[] { "Admin", "Quản lý", "Thu ngân", "Kho", "Kỹ thuật", "Nhân viên" });
            }

            LoadData();
            SetInputState(false); // mới mở form thì khóa mấy ô nhập liệu lại
        }

        // 1. Load dữ liệu từ database lên datagridview
        private void LoadData()
        {
            List<UsersDTO> list = _userBUS.GetAll();
            dgv_staffList.DataSource = list;

            // Ẩn các cột không cần thiết cho gọn
            if (dgv_staffList.Columns["Password"] != null)
                dgv_staffList.Columns["Password"].Visible = false;

            if (dgv_staffList.Columns["CreatedAt"] != null)
                dgv_staffList.Columns["CreatedAt"].Visible = false;

            // Đổi tên cột hiển thị 
            if (dgv_staffList.Columns["UserID"] != null) dgv_staffList.Columns["UserID"].HeaderText = "Mã NV";
            if (dgv_staffList.Columns["FullName"] != null) dgv_staffList.Columns["FullName"].HeaderText = "Họ tên";
            if (dgv_staffList.Columns["Username"] != null) dgv_staffList.Columns["Username"].HeaderText = "Tài khoản";
            if (dgv_staffList.Columns["Phone"] != null) dgv_staffList.Columns["Phone"].HeaderText = "SĐT";

            // Cập nhật số lượng nhân viên xuống thanh Bottom
            lbl_totalStaff.Text = $"Tổng: {(list != null ? list.Count : 0)} nhân viên";

            dgv_staffList.ClearSelection();
            _selectedUserID = -1;
            lbl_selectedStaff.Text = "Đang chọn: Không có";
        }

        // 2. Format lại màu chữ và đổi id quyền sang chữ
        // (Lưu ý: Bạn nhớ qua file Designer hoặc giao diện click sấm sét để gán sự kiện CellFormatting này cho DataGridView nhé)
        private void dgv_staffList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null) return;

            try
            {
                if (e.Value is bool isActive)
                {
                    e.Value = isActive ? "Hoạt động" : "Vô hiệu";
                    e.CellStyle.ForeColor = isActive ? Color.Green : Color.Red;
                    e.FormattingApplied = true;
                }
            }
            catch (Exception ex)
            {
                if (e.Value is int roleId)
                {
                    e.Value = GetRoleName(roleId);
                    e.FormattingApplied = true;
                }
            }
        }

        // 3. Click 1 dòng đổ data sang các textbox 
        private void dgv_staffList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !_isAdding)
            {
                DataGridViewRow row = dgv_staffList.Rows[e.RowIndex];

                _selectedUserID = Convert.ToInt32(row.Cells["UserID"].Value);
                txt_fullName.Text = row.Cells["FullName"].Value?.ToString();
                txt_username.Text = row.Cells["Username"].Value?.ToString();
                txt_phone.Text = row.Cells["Phone"].Value?.ToString();
                txt_password.Text = "******";

                int roleId = Convert.ToInt32(row.Cells["RoleID"].Value);
                cbb_role.Text = GetRoleName(roleId);

                // Cập nhật label đang chọn ở dưới góc
                lbl_selectedStaff.Text = $"Đang chọn: {txt_fullName.Text}";
            }
        }

        // 4. Hàm bật/tắt các textbox và button
        private void SetInputState(bool isEnabled)
        {
            txt_fullName.Enabled = isEnabled;
            txt_username.Enabled = isEnabled;
            txt_password.Enabled = isEnabled;
            txt_phone.Enabled = isEnabled;
            cbb_role.Enabled = isEnabled;

            // Nút Lưu và Hủy sẽ sáng lên khi bật Input
            btn_save.Enabled = isEnabled;
            btn_cancel.Enabled = isEnabled;

            // Các nút thao tác sẽ tối đi khi đang nhập liệu
            btn_add.Enabled = !isEnabled;
            btn_edit.Enabled = !isEnabled;
            btn_disable.Enabled = !isEnabled;
            btn_changePassword.Enabled = !isEnabled;
            dgv_staffList.Enabled = !isEnabled;
        }

        // 5. Xóa trắng các ô nhập
        private void ClearInputs()
        {
            txt_fullName.Clear();
            txt_username.Clear();
            txt_password.Clear();
            txt_phone.Clear();
            cbb_role.SelectedIndex = -1;
        }

        // 6. Xử lý các nút trên Top Bar
        private void btn_add_Click(object sender, EventArgs e)
        {
            _isAdding = true;
            ClearInputs();
            SetInputState(true);
            cbb_role.SelectedIndex = 1; // mặc định để là Quản lý
            txt_username.Focus();
            lbl_selectedStaff.Text = "Đang chọn: Thêm mới...";
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (_selectedUserID == -1)
            {
                grp_StaffDetails.Enabled = isEnabled;
            }
            _isAdding = false;
            SetInputState(true);

            txt_username.Enabled = false; // không cho sửa username
            txt_password.Enabled = false; // không cho sửa pass ở đây
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadData();
            ClearInputs();
            SetInputState(false);
        }

        // Xử lý nút Hủy trong Form điền thông tin
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            _isAdding = false;
            ClearInputs();
            SetInputState(false);
            lbl_selectedStaff.Text = "Đang chọn: Không có";
            _selectedUserID = -1;
            dgv_staffList.ClearSelection();
        }

        // 7. Lưu dữ liệu (xài chung cho cả thêm và sửa)
        private void btn_save_Click(object sender, EventArgs e)
        {
            // check xem có để trống không
            if (string.IsNullOrWhiteSpace(txt_fullName.Text) || string.IsNullOrWhiteSpace(txt_username.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ Họ tên và Tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = new UsersDTO
            {
                FullName = txt_fullName.Text,
                Username = txt_username.Text,
                Phone = txt_phone.Text,
                RoleID = GetRoleID(cbb_role.Text),
                IsActive = true
            };

            bool success;
            string error;

            if (_isAdding)
            {
                // nếu không nhập pass thì lấy mặc định là 123456
                user.Password = string.IsNullOrWhiteSpace(txt_password.Text) ? "123456" : txt_password.Text;
                (success, error) = _userBUS.Insert(user);
            }
            else
            {
                user.UserID = _selectedUserID;
                (success, error) = _userBUS.Update(user);
            }

            if (success)
            {
                MessageBox.Show(_isAdding ? "Thêm mới thành công!" : "Sửa thông tin thành công!", "Thông báo");
                btn_refresh_Click(null, null); // load lại grid và khóa ô nhập
            }
            else
            {
                MessageBox.Show("Lỗi: " + error, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 8. Vô hiệu hóa (Khóa tài khoản) nhân viên
        private void btn_disable_Click(object sender, EventArgs e)
        {
            if (_selectedUserID == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần vô hiệu hóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn vô hiệu hóa tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var disabledUser = new UsersDTO
                {
                    UserID = _selectedUserID,
                    Username = txt_username.Text,
                    FullName = txt_fullName.Text,
                    Phone = txt_phone.Text,
                    RoleID = GetRoleID(cbb_role.Text),
                    IsActive = false // set thuộc tính này về false
                };

                var (success, err) = _userBUS.Update(disabledUser);
                if (success)
                {
                    MessageBox.Show("Đã vô hiệu hóa thành công!", "Thông báo");
                    btn_refresh_Click(null, null);
                }
            }
        }

        // 9. Reset pass về mặc định (sử dụng lại nút Đổi mật khẩu)
        private void btn_changePassword_Click(object sender, EventArgs e)
        {
            if (_selectedUserID == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên để đặt lại mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Đổi mật khẩu tài khoản này về mặc định: '123456'?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var resetUser = new UsersDTO
                {
                    UserID = _selectedUserID,
                    Username = txt_username.Text,
                    FullName = txt_fullName.Text,
                    Phone = txt_phone.Text,
                    RoleID = GetRoleID(cbb_role.Text),
                    IsActive = true,
                    Password = "123456" // đè mật khẩu mới vô
                };

                var (success, err) = _userBUS.Update(resetUser);
                if (success) MessageBox.Show("Reset mật khẩu thành công!", "Thông báo");
            }
        }

        // 10. Các hàm phụ trợ convert qua lại giữa ID quyền và tên quyền
        private string GetRoleName(int roleId)
        {
            switch (roleId)
            {
                case 1: return "Admin";
                case 2: return "Quản lý";
                case 3: return "Thu ngân";
                case 4: return "Kho";
                case 5: return "Kỹ thuật";
                default: return "Nhân viên";
            }
        }

        private int GetRoleID(string roleName)
        {
            switch (roleName)
            {
                case "Admin": return 1;
                case "Quản lý": return 2;
                case "Thu ngân": return 3;
                case "Kho": return 4;
                case "Kỹ thuật": return 5;
                default: return 6;
            }
        }
    }
}