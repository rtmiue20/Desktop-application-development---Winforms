using System;
using System.Windows.Forms;
// Thêm thư viện chứa các lớp BUS và DTO của project ông vào đây (ví dụ minh họa):
using BUS;
using DTO;

namespace GUI
{
    public partial class FormGuest : Form
    {
        // 1. Khai báo thẳng class BUS xử lý dữ liệu Khách Hàng ở đây
        // (Ông nhớ đổi tên 'GuestBUS' lại cho khớp với file BUS trong project của ông nhé)
        private CustomersBUS guestBUS = new CustomersBUS();

        private bool isAdding = false;
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
            // 1. TẮT TÍNH NĂNG TỰ ĐỘNG SINH CỘT TỪ DTO
            dgv_guest.AutoGenerateColumns = false;

            dgv_guest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_guest.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_guest.MultiSelect = false;
            dgv_guest.AllowUserToAddRows = false;
            dgv_guest.ReadOnly = true;

            // Load data chuẩn
            LoadData();
        }

        // ==========================
        // LOAD DATA (Chuẩn 3 lớp)
        // ==========================
        private void LoadData()
        {
            try
            {
                // Gọi thẳng hàm lấy dữ liệu từ BUS (ví dụ GetAll) và gán làm DataSource cho bảng.
                // Vừa ngắn gọn, vừa an toàn, chạy nhanh gấp nhiều lần Reflection.
                dgv_guest.DataSource = guestBUS.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load dữ liệu khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================
        // NÚT THÊM KHÁCH HÀNG
        // ==========================
        private void btn_AddCustomer_Click(object sender, EventArgs e)
        {
            isAdding = true;
            txt_phoneNumber.Clear();
            txt_fullName.Clear();
            txt_address.Clear();
            cbo_customerType.SelectedIndex = -1;
            txt_phoneNumber.Focus();
        }

        // ==========================
        // NÚT LƯU
        // ==========================
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_phoneNumber.Text) || string.IsNullOrWhiteSpace(txt_fullName.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (isAdding)
                {
                    // GỌI XUỐNG LỚP BUS ĐỂ LƯU VÀO DATABASE
                    // Ví dụ: 
                    // guestBUS.Add(new GuestDTO { PhoneNumber = txt_phoneNumber.Text, FullName = txt_fullName.Text, ... });

                    MessageBox.Show("Thêm khách hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (selectedRow >= 0)
                    {
                        // GỌI XUỐNG LỚP BUS ĐỂ CẬP NHẬT XUỐNG DATABASE
                        // Ví dụ: 
                        // guestBUS.Update(new GuestDTO { ... });

                        MessageBox.Show("Cập nhật khách hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                // Sau khi Thêm/Sửa DB xong, gọi LoadData() để bảng tự động cập nhật dữ liệu mới nhất
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================
        // NÚT SỬA
        // ==========================
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dgv_guest.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            selectedRow = dgv_guest.CurrentRow.Index;

            // Chú ý: Cột lấy dữ liệu có thể thay đổi tùy vào việc gán DataSource,
            // Ông cần check xem tên cột (Cells["Tên_Cột"]) cho chuẩn nhé.
            txt_phoneNumber.Text = dgv_guest.Rows[selectedRow].Cells[0].Value?.ToString();
            txt_fullName.Text = dgv_guest.Rows[selectedRow].Cells[1].Value?.ToString();
            cbo_customerType.Text = dgv_guest.Rows[selectedRow].Cells[2].Value?.ToString();

            isAdding = false;
        }

        // ==========================
        // NÚT HỦY & LÀM MỚI
        // ==========================
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            btn_Refresh_Click(sender, e);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            txt_search.Clear();
            txt_phoneNumber.Clear();
            txt_fullName.Clear();
            txt_address.Clear();
            cbo_customerType.SelectedIndex = -1;
            dgv_guest.ClearSelection();
        }

        // ==========================
        // LỊCH SỬ MUA
        // ==========================
        private void btn_PurchaseHistory_Click(object sender, EventArgs e)
        {
            if (dgv_guest.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string customerName = dgv_guest.CurrentRow.Cells[1].Value?.ToString();
            MessageBox.Show("Hiển thị lịch sử mua của khách hàng: " + customerName, "Lịch sử mua", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ==========================
        // CLICK VÀO DÒNG TRONG BẢNG
        // ==========================
        private void dgv_Guest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            selectedRow = e.RowIndex;
            txt_phoneNumber.Text = dgv_guest.Rows[e.RowIndex].Cells[0].Value?.ToString();
            txt_fullName.Text = dgv_guest.Rows[e.RowIndex].Cells[1].Value?.ToString();
            cbo_customerType.Text = dgv_guest.Rows[e.RowIndex].Cells[2].Value?.ToString();
        }

        // ==========================
        // TÌM KIẾM
        // ==========================
        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            // Nếu dùng DataSource là List/DataTable, ông nên viết hàm Search ở tầng BUS rồi gán lại DataSource nhé.
            // Dùng row.Visible khi đã gán DataSource có thể gây ra lỗi.
            string keyword = txt_search.Text.Trim();

            // Ví dụ chuẩn 3 lớp:
            // dgv_guest.DataSource = guestBUS.Search(keyword); 
        }

        private void dgv_guest_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }

        private void dgv_guest_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
