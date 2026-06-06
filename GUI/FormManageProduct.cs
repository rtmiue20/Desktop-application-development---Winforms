using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class FormManageProduct : Form
    {
        // 1. Khai báo các đối tượng giao tiếp tầng BUS và biến trạng thái lưu trữ
        private readonly ProductsBUS _productBUS = new ProductsBUS();
        private readonly CategoriesBUS _categoryBUS = new CategoriesBUS();

        private List<ProductsDTO> _originalProductList = new List<ProductsDTO>();
        private int _selectedCategoryID = -1; // Khóa chính của danh mục đang được áp dụng bộ lọc (-1 là Tất cả)
        private int _selectedProductID = -1; // Khóa chính của sản phẩm đang được thao tác (-1 là chưa chọn)

        public FormManageProduct()
        {
            InitializeComponent();
        }

        // 2. Thiết lập trạng thái mặc định và nạp dữ liệu khi khởi tạo Form
        private void FormManageProduct_Load(object sender, EventArgs e)
        {
            cb_StatusFilter.SelectedIndex = 0; // Khởi tạo tiêu chí lọc mặc định
            LoadCategories();
            LoadProducts();
        }

        // Truy xuất danh mục từ cơ sở dữ liệu và liên kết với lưới điều hướng bên trái
        private void LoadCategories()
        {
            var categories = _categoryBUS.GetAll();
            dgv_CategoryFilter.DataSource = categories;

            // Tùy chỉnh định dạng hiển thị cho lưới danh mục (ẩn cột ID)
            if (dgv_CategoryFilter.Columns["CategoryID"] != null)
                dgv_CategoryFilter.Columns["CategoryID"].Visible = false;

            dgv_CategoryFilter.ClearSelection();
        }

        // Truy xuất toàn bộ bản ghi sản phẩm và kích hoạt chu trình lọc
        private void LoadProducts()
        {
            _originalProductList = _productBUS.GetAll();
            ApplyFilters();
        }

        // 3. Xử lý logic lọc dữ liệu đa chiều và cập nhật thông số thống kê
        private void ApplyFilters()
        {
            if (_originalProductList == null || !_originalProductList.Any()) return;

            // Khởi tạo tập hợp dữ liệu trung gian dựa trên danh sách gốc
            var filteredList = _originalProductList.AsEnumerable();

            // Áp dụng rào lọc dựa trên khóa chính của danh mục
            if (_selectedCategoryID != -1)
            {
                filteredList = filteredList.Where(p => p.CategoryID == _selectedCategoryID);
            }

            // Áp dụng rào lọc dựa trên số lượng tồn kho định mức
            string statusFilter = cb_StatusFilter.Text;
            if (statusFilter == "Còn hàng")
            {
                filteredList = filteredList.Where(p => p.MinStock > 0);
            }
            else if (statusFilter == "Hết hàng")
            {
                filteredList = filteredList.Where(p => p.MinStock <= 0);
            }

            // Ràng buộc tập dữ liệu đã qua xử lý lên giao diện người dùng
            dgv_ProductList.DataSource = filteredList.ToList();

            UpdateBottomStatus();
        }

        // Tính toán và hiển thị thông số quản trị trên thanh trạng thái (StatusStrip)
        private void UpdateBottomStatus()
        {
            int totalProducts = dgv_ProductList.Rows.Count;
            string selectedName = "Không";

            if (dgv_ProductList.SelectedRows.Count > 0)
            {
                selectedName = dgv_ProductList.SelectedRows[0].Cells["ProductName"]?.Value?.ToString() ?? "Không";
            }

            lbl_StatusSummary.Text = $"Tổng: {totalProducts} sản phẩm | Đang chọn: {selectedName}";
        }

        // 4. Kiểm soát các sự kiện tương tác trên lưới dữ liệu (DataGridView)

        // Nhận diện sự kiện chuyển đổi danh mục và cập nhật luồng lọc
        private void dgv_CategoryFilter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var cellValue = dgv_CategoryFilter.Rows[e.RowIndex].Cells["CategoryID"].Value;
                if (cellValue != null && int.TryParse(cellValue.ToString(), out int catId))
                {
                    _selectedCategoryID = catId;
                }
                else
                {
                    _selectedCategoryID = -1;
                }
                ApplyFilters();
            }
        }

        // Ghi nhận khóa chính của bản ghi khi người dùng thiết lập tiêu điểm
        private void dgv_ProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var cellValue = dgv_ProductList.Rows[e.RowIndex].Cells["ProductID"].Value;
                if (cellValue != null && int.TryParse(cellValue.ToString(), out int prodId))
                {
                    _selectedProductID = prodId;
                }
                UpdateBottomStatus();
            }
        }

        // Can thiệp vào quá trình kết xuất đồ họa (render) để định dạng chuỗi tiền tệ
        private void dgv_ProductList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null) return;

            if (dgv_ProductList.Columns[e.ColumnIndex].Name == "Price")
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal price))
                {
                    e.Value = price.ToString("#,##0"); // Định dạng phân cách hàng nghìn
                    e.FormattingApplied = true;
                }
            }
        }

        // Kích hoạt lại chu trình lọc dữ liệu khi tiêu chí trạng thái thay đổi
        private void cb_StatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        // 5. Kiểm soát các thao tác chức năng chính của Form (CRUD)

        // Khởi tạo phiên giao dịch bổ sung bản ghi sản phẩm mới
        private void btn_ProductAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui lòng thực thi luồng chuyển trang thêm sản phẩm tại đây.", "Tiến trình hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Khởi tạo phiên giao dịch cập nhật thông tin cho bản ghi đang được chọn
        private void btn_ProductEdit_Click(object sender, EventArgs e)
        {
            if (_selectedProductID == -1)
            {
                MessageBox.Show("Vui lòng chỉ định một bản ghi sản phẩm để thực thi thao tác!", "Cảnh báo thao tác", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show($"Đang truy xuất thông tin cấu hình cho sản phẩm mã: {_selectedProductID}", "Tiến trình hệ thống");
        }

        // Thực thi tiến trình loại bỏ bản ghi ra khỏi cơ sở dữ liệu
        private void btn_ProductDelete_Click(object sender, EventArgs e)
        {
            if (_selectedProductID == -1)
            {
                MessageBox.Show("Vui lòng chỉ định một bản ghi sản phẩm để thực thi thao tác xóa!", "Cảnh báo thao tác", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Hành động này không thể hoàn tác. Xác nhận loại bỏ bản ghi này?", "Xác thực bảo mật", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var (success, error) = _productBUS.Delete(_selectedProductID);

                if (success)
                {
                    MessageBox.Show("Loại bỏ bản ghi thành công!");
                    LoadProducts();
                }
                else
                {
                    MessageBox.Show("Lỗi xử lý: " + error, "Ngoại lệ hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Điều hướng luồng công việc sang phân hệ quản trị danh mục
        private void btn_Category_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đang chuyển hướng sang phân hệ Quản lý danh mục...", "Điều hướng hệ thống");
        }

        // Hủy bỏ các bộ lọc cục bộ và đồng bộ hóa lại toàn bộ tập dữ liệu
        private void btn_ProductRefresh_Click(object sender, EventArgs e)
        {
            cb_StatusFilter.SelectedIndex = 0;
            _selectedCategoryID = -1;
            _selectedProductID = -1;
            LoadCategories();
            LoadProducts();
        }
    }
}