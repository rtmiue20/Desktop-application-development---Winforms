using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormGuest : Form
    {
        // Biến kiểm tra đang ở chế độ thêm mới hay sửa
        private bool isAdding = false;

        // Lưu vị trí dòng đang chọn trong DataGridView
        private int selectedRow = -1;

        public FormGuest()
        {
            InitializeComponent();
        }

        // ==========================
        // FORM LOAD
        // ==========================
        private void FormGuest_Load(object sender, EventArgs e)
        {
            // Hiển thị cột tự động đầy đủ chiều rộng
            dgv_guest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Chỉ cho phép chọn nguyên dòng
            dgv_guest.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Không cho chọn nhiều dòng
            dgv_guest.MultiSelect = false;

            // Không cho người dùng tự thêm dòng
            dgv_guest.AllowUserToAddRows = false;

            // Chỉ đọc dữ liệu
            dgv_guest.ReadOnly = true;
        }

        // ==========================
        // NÚT THÊM KHÁCH HÀNG
        // ==========================
        private void btn_AddCustomer_Click(object sender, EventArgs e)
        {
            // Chuyển sang chế độ thêm
            isAdding = true;

            // Xóa dữ liệu cũ trên form
            txt_phoneNumber.Clear();
            txt_fullName.Clear();
            txt_address.Clear();

            cbo_customerType.SelectedIndex = -1;

            // Đưa con trỏ vào ô SĐT
            txt_phoneNumber.Focus();
        }

        // ==========================
        // NÚT LƯU
        // ==========================
        private void btn_Save_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu bắt buộc
            if (string.IsNullOrWhiteSpace(txt_phoneNumber.Text) ||
                string.IsNullOrWhiteSpace(txt_fullName.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            // Nếu đang thêm khách hàng
            if (isAdding)
            {
                dgv_guest.Rows.Add(
                    txt_phoneNumber.Text,      // SĐT
                    txt_fullName.Text,         // Họ tên
                    cbo_customerType.Text,    // Loại khách
                    0,                         // Điểm tích lũy
                    0,                         // Tổng mua
                    DateTime.Now.ToString("dd/MM/yyyy")
                );

                MessageBox.Show("Thêm khách hàng thành công!");
            }
            else
            {
                // Nếu đang sửa khách hàng
                if (selectedRow >= 0)
                {
                    dgv_guest.Rows[selectedRow].Cells[0].Value = txt_phoneNumber.Text;
                    dgv_guest.Rows[selectedRow].Cells[1].Value = txt_fullName.Text;
                    dgv_guest.Rows[selectedRow].Cells[2].Value = cbo_customerType.Text;

                    MessageBox.Show("Cập nhật khách hàng thành công!");
                }
            }
        }

        // ==========================
        // NÚT SỬA
        // ==========================
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            // Kiểm tra đã chọn dòng chưa
            if (dgv_guest.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa!");
                return;
            }

            // Lưu vị trí dòng đang chọn
            selectedRow = dgv_guest.CurrentRow.Index;

            // Đổ dữ liệu lên form
            txt_phoneNumber.Text =
                dgv_guest.Rows[selectedRow].Cells[0].Value?.ToString();

            txt_fullName.Text =
                dgv_guest.Rows[selectedRow].Cells[1].Value?.ToString();

            cbo_customerType.Text =
                dgv_guest.Rows[selectedRow].Cells[2].Value?.ToString();

            // Chuyển sang chế độ sửa
            isAdding = false;
        }

        // ==========================
        // NÚT HỦY
        // ==========================
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_phoneNumber.Clear();
            txt_fullName.Clear();
            txt_address.Clear();

            cbo_customerType.SelectedIndex = -1;

            MessageBox.Show("Đã hủy thao tác!");
        }

        // ==========================
        // NÚT LÀM MỚI
        // ==========================
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            // Xóa ô tìm kiếm
            txt_search.Clear();

            // Xóa dữ liệu trên form
            txt_phoneNumber.Clear();
            txt_fullName.Clear();
            txt_address.Clear();

            cbo_customerType.SelectedIndex = -1;

            // Bỏ chọn DataGridView
            dgv_guest.ClearSelection();

            MessageBox.Show("Đã làm mới!");
        }

        // ==========================
        // NÚT LỊCH SỬ MUA
        // ==========================
        private void btn_PurchaseHistory_Click(object sender, EventArgs e)
        {
            if (dgv_guest.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng!");
                return;
            }

            string customerName =
                dgv_guest.CurrentRow.Cells[1].Value?.ToString();

            MessageBox.Show(
                "Hiển thị lịch sử mua của khách hàng: "
                + customerName);
        }

        // ==========================
        // CLICK VÀO DÒNG TRONG BẢNG
        // ==========================
        private void dgv_Guest_CellClick(object sender,
            DataGridViewCellEventArgs e)
        {
            // Nếu click tiêu đề thì bỏ qua
            if (e.RowIndex < 0)
                return;

            selectedRow = e.RowIndex;

            // Hiển thị dữ liệu lên form
            txt_phoneNumber.Text =
                dgv_guest.Rows[e.RowIndex].Cells[0].Value?.ToString();

            txt_fullName.Text =
                dgv_guest.Rows[e.RowIndex].Cells[1].Value?.ToString();

            cbo_customerType.Text =
                dgv_guest.Rows[e.RowIndex].Cells[2].Value?.ToString();
        }

        // ==========================
        // TÌM KIẾM KHÁCH HÀNG
        // ==========================
        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_search.Text.ToLower();

            foreach (DataGridViewRow row in dgv_guest.Rows)
            {
                if (row.IsNewRow)
                    continue;

                string phone =
                    row.Cells[0].Value?.ToString().ToLower() ?? "";

                string name =
                    row.Cells[1].Value?.ToString().ToLower() ?? "";

                // Hiện dòng nếu tìm thấy SĐT hoặc tên
                row.Visible =
                    phone.Contains(keyword) ||
                    name.Contains(keyword);
            }
        }

        private void dgv_guest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}