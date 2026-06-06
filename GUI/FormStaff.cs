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
        private int _selectedUserID = -1; // lưu id nhân viên đang chọn trên grid
        private bool _isAdding = false; // check xem đang thêm hay sửa

        public FormStaff()
        {
            InitializeComponent();
        }

        private void FormStaff_Load(object sender, EventArgs e)
        {
            LoadData();
            SetInputState(false); // mới mở form thì khóa mấy ô nhập liệu lại
        }

        //1. Load dữ liệu từ database lên datagridview
        private void LoadData()
        {
            List<UsersDTO> list = _userBUS.GetAll();
            dgv_StaffList.DataSource = list;

            // Ẩn các cột không cần thiết cho gọn
            if (dgv_StaffList.Columns["Password"] != null)
                dgv_StaffList.Columns["Password"].Visible = false;

            if (dgv_StaffList.Columns["CreatedAt"] != null)
                dgv_StaffList.Columns["CreatedAt"].Visible = false;

            // Đổi tên cột hiển thị 
            if (dgv_StaffList.Columns["UserID"] != null) dgv_StaffList.Columns["UserID"].HeaderText = "Mã NV";
            if (dgv_StaffList.Columns["FullName"] != null) dgv_StaffList.Columns["FullName"].HeaderText = "Họ tên";
            if (dgv_StaffList.Columns["Username"] != null) dgv_StaffList.Columns["Username"].HeaderText = "Tài khoản";
            if (dgv_StaffList.Columns["Phone"] != null) dgv_StaffList.Columns["Phone"].HeaderText = "SĐT";

            dgv_StaffList.ClearSelection();
            _selectedUserID = -1;
        }

        //2. Format lại màu chữ và đổi id quyền sang chữ
        private void dgv_StaffList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null) return;

            if (dgv_StaffList.Columns[e.ColumnIndex].Name == "IsActive")
            {
                bool isActive = (bool)e.Value;
                e.Value = isActive ? "Hoạt động" : "Vô hiệu";
                e.CellStyle.ForeColor = isActive ? Color.Green : Color.Red;
                e.FormattingApplied = true;
            }
            else if (dgv_StaffList.Columns[e.ColumnIndex].Name == "RoleID")
            {
                int roleId = (int)e.Value;
                e.Value = GetRoleName(roleId);
                e.FormattingApplied = true;
            }
        }

        //3. Click 1 dòng đổ data sang các textbox 
        private void dgv_StaffList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !_isAdding)
            {
                DataGridViewRow row = dgv_StaffList.Rows[e.RowIndex];

                _selectedUserID = Convert.ToInt32(row.Cells["UserID"].Value);
                txt_FullName.Text = row.Cells["FullName"].Value?.ToString();
                txt_Username.Text = row.Cells["Username"].Value?.ToString();
                txt_Phone.Text = row.Cells["Phone"].Value?.ToString();
                txt_Password.Text = "******"; 

                int roleId = Convert.ToInt32(row.Cells["RoleID"].Value);
                cb_Role.Text = GetRoleName(roleId);
            }
        }

        //4. Hàm bật/tắt các textbox và 
        private void SetInputState(bool isEnabled)
        {
            txt_FullName.Enabled = isEnabled;
            txt_Username.Enabled = isEnabled;
            txt_Password.Enabled = isEnabled;
            txt_Phone.Enabled = isEnabled;
            cb_Role.Enabled = isEnabled;

            btn_StaffSave.Enabled = isEnabled;
            btn_StaffCancel.Enabled = isEnabled;

            btn_StaffAdd.Enabled = !isEnabled;
            btn_StaffEdit.Enabled = !isEnabled;
            btn_StaffDisable.Enabled = !isEnabled;
            btn_StaffResetPass.Enabled = !isEnabled;
            dgv_StaffList.Enabled = !isEnabled;
        }
        
        //5. xóa trắng các ô nhập
        private void ClearInputs()
        {
            txt_FullName.Clear();
            txt_Username.Clear();
            txt_Password.Clear();
            txt_Phone.Clear();
            cb_Role.SelectedIndex = -1;
        }
        
        //6. Xử lý các nút 
        // xử lý nút thêm
        private void btn_StaffAdd_Click(object sender, EventArgs e)
        {
            _isAdding = true;
            ClearInputs();
            SetInputState(true);
            cb_Role.SelectedIndex = 1; // mặc định để là Quản lý
            txt_Username.Focus();
        }

        // xử lý nút sửa
        private void btn_StaffEdit_Click(object sender, EventArgs e)
        {
            if (_selectedUserID == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _isAdding = false;
            SetInputState(true);

            txt_Username.Enabled = false; // không cho sửa username
            txt_Password.Enabled = false; // không cho sửa pass ở đây
        }

        // xử lý nút làm mới
        private void btn_StaffRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            ClearInputs();
            SetInputState(false);
        }

        // xử lý nút hủy
        private void btn_StaffCancel_Click(object sender, EventArgs e)
        {
            _isAdding = false;
            ClearInputs();
            SetInputState(false);
        }

        //7. lưu dữ liệu (xài chung cho cả thêm và sửa)
        private void btn_StaffSave_Click(object sender, EventArgs e)
        {
            // check xem có để trống không
            if (string.IsNullOrWhiteSpace(txt_FullName.Text) || string.IsNullOrWhiteSpace(txt_Username.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ Họ tên và Tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = new UsersDTO
            {
                FullName = txt_FullName.Text,
                Username = txt_Username.Text,
                Phone = txt_Phone.Text,
                RoleID = GetRoleID(cb_Role.Text),
                IsActive = true
            };

            bool success;
            string error;

            if (_isAdding)
            {
                // nếu không nhập pass thì lấy mặc định là 123456
                user.Password = string.IsNullOrWhiteSpace(txt_Password.Text) ? "123456" : txt_Password.Text;
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
                btn_StaffRefresh_Click(null, null); // load lại grid
            }
            else
            {
                MessageBox.Show("Lỗi: " + error, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //8. khóa tài khoản nhân viên
        private void btn_StaffDisable_Click(object sender, EventArgs e)
        {
            if (_selectedUserID == -1) return;

            if (MessageBox.Show("Bạn có chắc muốn vô hiệu hóa tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var disabledUser = new UsersDTO
                {
                    UserID = _selectedUserID,
                    Username = txt_Username.Text,
                    FullName = txt_FullName.Text,
                    Phone = txt_Phone.Text,
                    RoleID = GetRoleID(cb_Role.Text),
                    IsActive = false // set thuộc tính này về false
                };

                var (success, err) = _userBUS.Update(disabledUser);
                if (success) btn_StaffRefresh_Click(null, null);
            }
        }

        //9. reset pass về mặc định
        private void btn_StaffResetPass_Click(object sender, EventArgs e)
        {
            if (_selectedUserID == -1) return;

            if (MessageBox.Show("Đổi mật khẩu tài khoản này về mặc định: '123456'?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var resetUser = new UsersDTO
                {
                    UserID = _selectedUserID,
                    Username = txt_Username.Text,
                    FullName = txt_FullName.Text,
                    Phone = txt_Phone.Text,
                    RoleID = GetRoleID(cb_Role.Text),
                    IsActive = true,
                    Password = "123456" // đè mật khẩu mới vô
                };

                var (success, err) = _userBUS.Update(resetUser);
                if (success) MessageBox.Show("Reset mật khẩu thành công!", "Thông báo");
            }
        }

        //10. Các hàm phụ trợ convert qua lại giữa ID quyền và tên quyền
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