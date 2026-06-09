using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class FormCategory : Form
    {
        //1. Khai báo đối tượng giao tiếp với tầng BUS và các biến lưu trữ trạng thái
        private readonly CategoriesBUS _categoryBUS = new CategoriesBUS();
        private List<CategoriesDTO> _originalList = new List<CategoriesDTO>();

        private int _selectedCategoryID = -1; // Lưu trữ khóa chính của danh mục đang thao tác
        private bool _isAdding = false; // Cờ xác định trạng thái: true là thêm mới, false là cập nhật

        public FormCategory()
        {
            InitializeComponent();

            // Tự động giãn cột lắp kín bảng DataGridView (như đã hướng dẫn ở bước trước)
            dgv_categoryList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //2. Thiết lập trạng thái mặc định khi khởi tạo Form
        private void FormCategory_Load(object sender, EventArgs e)
        {
            LoadData();
            SetInputState(false);
        }

        //3. Truy xuất toàn bộ dữ liệu từ cơ sở dữ liệu và liên kết với DataGridView
        private void LoadData()
        {
            _originalList = _categoryBUS.GetAll() ?? new List<CategoriesDTO>();
            dgv_categoryList.DataSource = _originalList;

            // Tùy chỉnh tiêu đề hiển thị cho các cột dữ liệu
            if (dgv_categoryList.Columns["CategoryID"] != null) dgv_categoryList.Columns["CategoryID"].HeaderText = "Mã DM";
            if (dgv_categoryList.Columns["CategoryName"] != null) dgv_categoryList.Columns["CategoryName"].HeaderText = "Tên danh mục";
            if (dgv_categoryList.Columns["Description"] != null) dgv_categoryList.Columns["Description"].HeaderText = "Mô tả";
            if (dgv_categoryList.Columns["Status"] != null) dgv_categoryList.Columns["Status"].HeaderText = "Trạng thái";

            dgv_categoryList.ClearSelection();
            _selectedCategoryID = -1;
            UpdateStatusStrip("Không");
        }

        //4. Định dạng lại nội dung và màu sắc hiển thị của lưới dữ liệu dựa trên giá trị thô
        private void dgv_categoryList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_categoryList.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                string rawStatus = e.Value.ToString();
                if (rawStatus == "Hoat dong")
                {
                    e.Value = "Hoạt động";
                    e.CellStyle.ForeColor = Color.Green;
                }
                else
                {
                    e.Value = "Ngừng";
                    e.CellStyle.ForeColor = Color.Red;
                }
                e.FormattingApplied = true;
            }
        }

        //5. Trích xuất dữ liệu từ dòng được chọn và gán vào các điều khiển nhập liệu
        private void dgv_categoryList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !_isAdding)
            {
                DataGridViewRow row = dgv_categoryList.Rows[e.RowIndex];

                _selectedCategoryID = Convert.ToInt32(row.Cells["CategoryID"].Value);
                txt_categoryName.Text = row.Cells["CategoryName"].Value?.ToString();
                txt_categoryDesc.Text = row.Cells["Description"].Value?.ToString();

                string rawStatus = row.Cells["Status"].Value?.ToString();
                cbb_categoryStatus.Text = (rawStatus == "Hoat dong") ? "Hoạt động" : "Ngừng";

                UpdateStatusStrip(txt_categoryName.Text);
            }
        }

        //6. Kiểm soát trạng thái kích hoạt của các điều khiển dựa trên ngữ cảnh thao tác
        private void SetInputState(bool isEnabled)
        {
            // Tận dụng sức mạnh của GroupBox: Tắt 1 phát là tắt hết toàn bộ TextBox, ComboBox bên trong
            if (grp_CategoryDetails != null)
            {
                grp_CategoryDetails.Enabled = isEnabled;
            }
            else // Backup dự phòng nếu chưa Load kịp
            {
                txt_categoryName.Enabled = isEnabled;
                txt_categoryDesc.Enabled = isEnabled;
                cbb_categoryStatus.Enabled = isEnabled;
                btn_categorySave.Enabled = isEnabled;
                btn_categoryCancel.Enabled = isEnabled;
            }

            btn_categoryAdd.Enabled = !isEnabled;
            btn_categoryEdit.Enabled = !isEnabled;
            btn_categoryDelete.Enabled = !isEnabled;
            dgv_categoryList.Enabled = !isEnabled;
        }

        //7. Làm sạch toàn bộ dữ liệu trên các trường nhập liệu
        private void ClearInputs()
        {
            txt_categoryName.Clear();
            txt_categoryDesc.Clear();
            cbb_categoryStatus.SelectedIndex = -1;
        }

        //8. Cập nhật thông tin thống kê trên thanh trạng thái (StatusStrip)
        private void UpdateStatusStrip(string currentSelection)
        {
            // Nếu Form có khai báo lbl_StatusSummary thì bỏ comment dòng dưới
            // lbl_StatusSummary.Text = $"Tổng: {_originalList.Count} danh mục | Đang chọn: {currentSelection}";
        }

        //9. Xử lý sự kiện khởi tạo phiên thêm mới danh mục
        private void btn_categoryAdd_Click(object sender, EventArgs e)
        {
            _isAdding = true;
            ClearInputs();
            SetInputState(true);
            cbb_categoryStatus.Text = "Hoạt động";
            txt_categoryName.Focus();
        }

        //10. Xử lý sự kiện khởi tạo phiên chỉnh sửa danh mục hiện tại
        private void btn_categoryEdit_Click(object sender, EventArgs e)
        {
            if (_selectedCategoryID == -1)
            {
                MessageBox.Show("Vui lòng lựa chọn một danh mục cần sửa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _isAdding = false;
            SetInputState(true);
        }

        //11. Xử lý thao tác xóa bản ghi khỏi hệ thống
        private void btn_categoryDelete_Click(object sender, EventArgs e)
        {
            if (_selectedCategoryID == -1)
            {
                MessageBox.Show("Vui lòng chọn danh mục muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dialog = MessageBox.Show($"Bạn có thực sự muốn xóa danh mục '{txt_categoryName.Text}' không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                var (success, error) = _categoryBUS.Delete(_selectedCategoryID);
                if (success)
                {
                    MessageBox.Show("Xóa danh mục thành công!", "Thông báo");
                    btn_categoryRefresh_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Không thể xóa: " + error, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //12. Tải lại dữ liệu và khôi phục giao diện về trạng thái ban đầu
        private void btn_categoryRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            ClearInputs();
            SetInputState(false);
            txt_categorySearch.Text = "Tìm danh mục...";
            txt_categorySearch.ForeColor = Color.Gray;
        }

        //13. Hủy bỏ thao tác hiện tại và khóa các trường nhập liệu
        private void btn_categoryCancel_Click(object sender, EventArgs e)
        {
            _isAdding = false;
            ClearInputs();
            SetInputState(false);
        }

        //14. Kiểm tra tính hợp lệ của dữ liệu và thực thi lưu trữ vào cơ sở dữ liệu
        private void btn_categorySave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_categoryName.Text))
            {
                MessageBox.Show("Tên danh mục không được phép để trống!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var category = new CategoriesDTO
            {
                CategoryName = txt_categoryName.Text.Trim(),
                Description = txt_categoryDesc.Text.Trim(),
                Status = (cbb_categoryStatus.Text == "Hoạt động") ? "Hoat dong" : "Ngung"
            };

            bool success;
            string error;

            if (_isAdding)
            {
                (success, error) = _categoryBUS.Insert(category);
            }
            else
            {
                category.CategoryID = _selectedCategoryID;
                (success, error) = _categoryBUS.Update(category);
            }

            if (success)
            {
                MessageBox.Show(_isAdding ? "Thêm danh mục mới thành công!" : "Cập nhật danh mục thành công!", "Thông báo");
                btn_categoryRefresh_Click(null, null);
            }
            else
            {
                MessageBox.Show("Thao tác thất bại: " + error, "Lỗi xử lý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //15. Bộ lọc dữ liệu cục bộ hỗ trợ tìm kiếm linh hoạt (không thực thi truy vấn tới cơ sở dữ liệu)
        private void txt_categorySearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_categorySearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword) || txt_categorySearch.Text == "Tìm danh mục...")
            {
                dgv_categoryList.DataSource = _originalList;
            }
            else
            {
                var filtered = _originalList.Where(c =>
                    c.CategoryID.ToString().Contains(keyword) ||
                    (!string.IsNullOrEmpty(c.CategoryName) && c.CategoryName.ToLower().Contains(keyword)) ||
                    (!string.IsNullOrEmpty(c.Description) && c.Description.ToLower().Contains(keyword))
                ).ToList();

                dgv_categoryList.DataSource = filtered;
            }
        }

        //16. Quản lý hiệu ứng văn bản gợi ý (placeholder) khi điều khiển nhận tiêu điểm
        private void txt_categorySearch_Enter(object sender, EventArgs e)
        {
            if (txt_categorySearch.Text == "Tìm danh mục...")
            {
                txt_categorySearch.Text = "";
                txt_categorySearch.ForeColor = Color.Black;
            }
        }

        //17. Quản lý hiệu ứng văn bản gợi ý (placeholder) khi điều khiển mất tiêu điểm
        private void txt_categorySearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_categorySearch.Text))
            {
                txt_categorySearch.Text = "Tìm danh mục...";
                txt_categorySearch.ForeColor = Color.Gray;
            }
        }

   
    }
}