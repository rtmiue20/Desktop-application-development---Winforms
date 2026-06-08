using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging; // Add this if not present
using System.IO;          // Cần thiết để xử lý đường dẫn Path
using System.Linq;
using System.Windows.Forms;
using BUS;
using DTO;
using ImageMagick;        // Thư viện giải mã WebP, AVIF

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
            cbb_statusFilter.SelectedIndex = 0; // Khởi tạo tiêu chí lọc mặc định
            LoadCategories();
            LoadProducts();
        }

        // Truy xuất danh mục từ cơ sở dữ liệu và liên kết với lưới điều hướng bên trái
        private void LoadCategories()
        {
            var categories = _categoryBUS.GetAll();
            dgv_categoryFilter.DataSource = categories;

            // Tùy chỉnh định dạng hiển thị cho lưới danh mục (ẩn cột ID)
            if (dgv_categoryFilter.Columns["CategoryID"] != null)
                dgv_categoryFilter.Columns["CategoryID"].Visible = false;

            dgv_categoryFilter.ClearSelection();
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
            string statusFilter = cbb_statusFilter.Text;
            if (statusFilter == "Còn hàng")
            {
                filteredList = filteredList.Where(p => p.MinStock > 0);
            }
            else if (statusFilter == "Hết hàng")
            {
                filteredList = filteredList.Where(p => p.MinStock <= 0);
            }

            // Ràng buộc tập dữ liệu đã qua xử lý lên giao diện người dùng
            dgv_productList.DataSource = filteredList.ToList();

            UpdateBottomStatus();
        }

        // Tính toán và hiển thị thông số quản trị trên thanh trạng thái (StatusStrip)
        private void UpdateBottomStatus()
        {
            int totalProducts = dgv_productList.Rows.Count;
            string selectedName = "Không";

            if (dgv_productList.SelectedRows.Count > 0)
            {
                selectedName = dgv_productList.SelectedRows[0].Cells["ProductName"]?.Value?.ToString() ?? "Không";
            }

            lbl_statusSummary.Text = $"Tổng: {totalProducts} sản phẩm | Đang chọn: {selectedName}";
        }

        // 4. Kiểm soát các sự kiện tương tác trên lưới dữ liệu (DataGridView)

        // Nhận diện sự kiện chuyển đổi danh mục và cập nhật luồng lọc
        private void dgv_CategoryFilter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var cellValue = dgv_categoryFilter.Rows[e.RowIndex].Cells["CategoryID"].Value;
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

        // Ghi nhận khóa chính của bản ghi khi người dùng thiết lập tiêu điểm VÀ LOAD ẢNH
        private void dgv_ProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var cellValue = dgv_productList.Rows[e.RowIndex].Cells["ProductID"].Value;
                if (cellValue != null && int.TryParse(cellValue.ToString(), out int prodId))
                {
                    _selectedProductID = prodId;
                }
                UpdateBottomStatus();

                // Lấy đối tượng DTO từ dòng được chọn để truyền ImagePath
                var selectedProduct = dgv_productList.Rows[e.RowIndex].DataBoundItem as ProductsDTO;
                if (selectedProduct != null)
                {
                    HienThiAnhSanPham(selectedProduct.ImagePath);
                }
            }
        }

        // HÀM MỚI: Xử lý giải mã ảnh WebP/AVIF bằng Magick.NET
        private void HienThiAnhSanPham(string imagePath)
        {
            // Dọn bộ nhớ ảnh cũ nếu có
            if (pic_productImage.Image != null)
            {
                pic_productImage.Image.Dispose();
                pic_productImage.Image = null;
            }

            if (string.IsNullOrWhiteSpace(imagePath)) return;

            // Kết hợp thư mục chạy ứng dụng (net9.0-windows) với đường dẫn tương đối trong DB
            string fullPath = Path.Combine(Application.StartupPath, imagePath);

            if (File.Exists(fullPath))
            {
                try
                {
                    // Magick.NET không có ToBitmap, cần chuyển đổi thủ công
                    using (var magickImage = new MagickImage(fullPath))
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            magickImage.Write(memoryStream, MagickFormat.Bmp);
                            memoryStream.Position = 0;
                            pic_productImage.Image = new Bitmap(memoryStream);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi khi load ảnh: {ex.Message}");
                }
            }
        }

        // Can thiệp vào quá trình kết xuất đồ họa (render) để định dạng chuỗi tiền tệ
        private void dgv_ProductList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null) return;

            if (dgv_productList.Columns[e.ColumnIndex].Name == "Price")
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
            cbb_statusFilter.SelectedIndex = 0;
            _selectedCategoryID = -1;
            _selectedProductID = -1;
            LoadCategories();
            LoadProducts();
        }
    }
}