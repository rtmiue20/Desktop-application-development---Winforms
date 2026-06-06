using System;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Desktop_Application_Development
{
    public partial class FormWarranty : Form
    {
        // 1. Khai báo các đối tượng giao tiếp với tầng BUS
        private readonly WarrantyBUS _warrantyBUS = new WarrantyBUS();
        private readonly ProductItemsBUS _itemBUS = new ProductItemsBUS();
        private readonly CustomersBUS _customerBUS = new CustomersBUS();
        private readonly ProductsBUS _productBUS = new ProductsBUS();

        // 2. Biến toàn cục để lưu ID khi người dùng đang thao tác
        private int _currentSerialID = 0;
        private int _currentCustomerID = 0;
        private int _selectedClaimID = 0;

        public FormWarranty()
        {
            InitializeComponent();
        }

        // --- SỰ KIỆN LOAD FORM ---
        private void FormWarranty_Load(object sender, EventArgs e)
        {
            LoadWarrantyList();
            
            // Đổ dữ liệu vào ComboBox Cập nhật trạng thái
            cboStatus.Items.Clear();
            cboStatus.Items.AddRange(new string[] { "Đang kiểm tra", "Chờ linh kiện", "Đang sửa", "Đã gửi hãng", "Đã sửa xong", "Đã trả khách" });
            cboStatus.SelectedIndex = 0;
        }

        // Hàm hỗ trợ tải danh sách lên DataGridView
        private void LoadWarrantyList()
        {
            // Mở comment dòng dưới khi bạn đã viết hàm GetAll() trong WarrantyBUS
            // dgvWarranty.DataSource = _warrantyBUS.GetAll(); 
        }

        // --- 1. CHỨC NĂNG TÌM KIẾM THIẾT BỊ ---
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập Mã Serial để tìm kiếm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var item = _itemBUS.GetByItemCode(keyword); 
            if (item != null)
            {
                // Máy chưa bán thì không thể bảo hành
                if (item.Status == "Trong kho")
                {
                    MessageBox.Show("Thiết bị này đang nằm trong kho (Chưa xuất bán), không thể bảo hành!", "Lỗi Nghiệp Vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // FIX: Thêm ?? 0 để xử lý trường hợp int? bị null
                _currentSerialID = item.ItemID;
                _currentCustomerID = item.CustomerID ?? 0;

                // Hiển thị trạng thái máy lên TextBox ReadOnly
                txtDeviceStatus.Text = item.Status; 

                // FIX: Đổi GetByID thành GetById (chữ d viết thường)
                var product = _productBUS.GetById(item.ProductID);
                txtProductName.Text = product != null ? product.ProductName : "Không xác định";

                // FIX: Đổi GetByID thành GetById và thêm ?? 0
                var customer = _customerBUS.GetById(item.CustomerID ?? 0);
                if (customer != null)
                {
                    txtCustomerName.Text = customer.FullName;
                    txtPhone.Text = customer.Phone;
                }

                MessageBox.Show("Đã xác thực thiết bị hợp lệ!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rtbDefectDescription.Focus(); // Chuyển con trỏ nháy vào ô ghi chú lỗi
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu về Serial này!", "Lỗi Tìm Kiếm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- 2. CHỨC NĂNG LẬP PHIẾU BẢO HÀNH ---
        private void btnCreateClaim_Click(object sender, EventArgs e)
        {
            if (_currentSerialID == 0)
            {
                MessageBox.Show("Vui lòng tìm kiếm thiết bị trước!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(rtbDefectDescription.Text))
            {
                MessageBox.Show("Vui lòng ghi rõ mô tả lỗi của khách hàng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gói dữ liệu vào DTO
            var claim = new WarrantyClaimsDTO
            {
                ClaimCode = "BH" + DateTime.Now.ToString("yyyyMMddHHmmss"), // Mã tự sinh theo thời gian thực
                SerialID = _currentSerialID,
                CustomerID = _currentCustomerID,
                UserID = CurrentUser.UserID, // Lấy ID nhân viên đang đăng nhập
                DefectDescription = rtbDefectDescription.Text.Trim()
            };

            // Gọi BUS xử lý
            var result = _warrantyBUS.Receive(claim);
            if (result.success) 
            {
                MessageBox.Show("Đã tiếp nhận thiết bị vào hệ thống bảo hành!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Xóa trắng form để nhận ca tiếp theo
                rtbDefectDescription.Clear();
                txtSearch.Clear();
                txtCustomerName.Clear();
                txtPhone.Clear();
                txtProductName.Clear();
                txtDeviceStatus.Clear();
                _currentSerialID = 0;
                
                LoadWarrantyList(); // Tải lại bảng
            }
            else
            {
                MessageBox.Show($"Có lỗi xảy ra: {result.error}", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- 3. ĐỔ DỮ LIỆU TỪ BẢNG XUỐNG KHUNG CẬP NHẬT ---
        private void dgvWarranty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvWarranty.CurrentRow != null)
            {
                var row = dgvWarranty.CurrentRow;
                _selectedClaimID = Convert.ToInt32(row.Cells["ClaimID"].Value);
                _currentSerialID = Convert.ToInt32(row.Cells["SerialID"].Value); // Cần thiết để trả máy
                
                cboStatus.Text = row.Cells["Status"].Value?.ToString();
                rtbResolution.Text = row.Cells["Resolution"].Value?.ToString();
            }
        }

        // --- 4. CHỨC NĂNG CẬP NHẬT & TRẢ MÁY (GỘP CHUNG) ---
        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (_selectedClaimID == 0)
            {
                MessageBox.Show("Vui lòng chọn một phiếu trên danh sách để cập nhật!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newStatus = cboStatus.Text;
            string resolution = rtbResolution.Text.Trim();

            // Nếu là thao tác Trả Máy cho khách
            if (newStatus == "Đã trả khách")
            {
                if (string.IsNullOrWhiteSpace(resolution))
                {
                    MessageBox.Show("Vui lòng ghi rõ phương án giải quyết (VD: Đã thay pin) trước khi trả máy!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var dialog = MessageBox.Show("Xác nhận hoàn tất quá trình sửa chữa và bàn giao lại máy cho khách?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    bool isDone = _warrantyBUS.ReturnToCustomer(_selectedClaimID, _currentSerialID, resolution);
                    if (isDone)
                    {
                        MessageBox.Show("Đã đóng phiếu bảo hành và trả Serial về trạng thái Đã bán!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _selectedClaimID = 0;
                        rtbResolution.Clear();
                    }
                }
            }
            else // Nếu chỉ là cập nhật tiến độ bình thường (Đang sửa, chờ linh kiện...)
            {
                bool isUpdated = _warrantyBUS.UpdateStatus(_selectedClaimID, newStatus, resolution);
                if (isUpdated)
                {
                    MessageBox.Show("Đã cập nhật tiến độ thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
            LoadWarrantyList(); // Cập nhật lại Grid
        }

        // --- CÁC HÀM TRỐNG ĐỂ TRÁNH LỖI VĂNG APP ---
        // Do bạn đã lỡ tay click đúp vào nên UI đã sinh ra 2 hàm này, hãy để trống chúng, đừng xóa nhé.
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
        }
    }
}