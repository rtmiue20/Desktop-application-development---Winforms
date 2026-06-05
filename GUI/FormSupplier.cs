using System;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class FormSupplier : Form
    {
        // Khởi tạo lớp xử lý nghiệp vụ
        private readonly SuppliersBUS _bus = new SuppliersBUS();

        // Biến lưu trữ ID của nhà cung cấp đang được chọn trên DataGridView (phục vụ cho nút Cập nhật)
        private int _selectedSupplierId = 0;

        public FormSupplier()
        {
            InitializeComponent();
        }

        // 1. Sự kiện khi Form vừa mở lên
        private void FormSupplier_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // Hàm tải dữ liệu lên DataGridView
        private void LoadData()
        {
            dgvSuppliers.DataSource = null;
            dgvSuppliers.DataSource = _bus.GetAll();

            // Tùy chỉnh (ẩn/hiện) các cột cho đẹp mắt nếu cần
            if (dgvSuppliers.Columns["SupplierID"] != null)
                dgvSuppliers.Columns["SupplierID"]!.Visible = false; // Ẩn cột ID khóa chính
        }

        // 2. Sự kiện Click nút THÊM
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Gom dữ liệu từ các TextBox vào DTO
            var newSupplier = new SuppliersDTO
            {
                SupplierCode = txtSupplierCode.Text.Trim(),
                SupplierName = txtSupplierName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Address = txtAddress.Text.Trim()
                // Debt và CreatedAt đã có giá trị mặc định trong class DTO nên không cần gán ở đây
            };

            // Gọi xuống BUS và hứng kết quả trả về dạng Tuple
            var result = _bus.Insert(newSupplier);

            if (result.success)
            {
                MessageBox.Show("Thêm nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Tải lại lưới
                ClearInputs(); // Xóa trắng form nhập
            }
            else
            {
                // Hiển thị lỗi từ tầng BUS (ví dụ: "Tên nhà cung cấp không được để trống")
                MessageBox.Show(result.error, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 3. Sự kiện Click nút CẬP NHẬT
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedSupplierId == 0)
            {
                MessageBox.Show("Vui lòng chọn một nhà cung cấp từ danh sách để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var updateSupplier = new SuppliersDTO
            {
                SupplierID = _selectedSupplierId, // Phải có ID để DAL biết đang cập nhật dòng nào
                SupplierCode = txtSupplierCode.Text.Trim(),
                SupplierName = txtSupplierName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Address = txtAddress.Text.Trim()
            };

            var result = _bus.Update(updateSupplier);

            if (result.success)
            {
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearInputs();
            }
            else
            {
                MessageBox.Show(result.error, "Lỗi cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 4. Sự kiện Click vào dòng trên DataGridView để đẩy dữ liệu lên TextBox
        private void dgvSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Đảm bảo người dùng click vào dòng hợp lệ (không click vào tiêu đề cột)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSuppliers.Rows[e.RowIndex];

                // Lưu lại ID để dùng cho hàm Update
                _selectedSupplierId = Convert.ToInt32(row.Cells["SupplierID"].Value);

                txtSupplierCode.Text = row.Cells["SupplierCode"].Value?.ToString();
                txtSupplierName.Text = row.Cells["SupplierName"].Value?.ToString();
                txtPhone.Text = row.Cells["Phone"].Value?.ToString();
                txtAddress.Text = row.Cells["Address"].Value?.ToString();
            }
        }

        // Hàm hỗ trợ xóa trắng các ô nhập liệu
        private void ClearInputs()
        {
            _selectedSupplierId = 0;
            txtSupplierCode.Clear();
            txtSupplierName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtSupplierCode.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }
    }
}