using System;
using System.Data;
using System.Windows.Forms;
// using BUS; // Khai báo tầng nghiệp vụ của bạn

namespace GUI
{
    public partial class FormGuest : Form
    {
        private bool isAdding = false;

        // 2 Thuộc tính public giúp FormSell có thể lấy thông tin khách hàng được chọn
        public string SelectedCustomerPhone { get; private set; }
        public string SelectedCustomerName { get; private set; }

        public FormGuest()
        {
            InitializeComponent();
        }

        private void FormGuest_Load(object sender, EventArgs e)
        {
            // Cấu hình UI Grid
            dgv_guest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_guest.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_guest.MultiSelect = false;
            dgv_guest.AllowUserToAddRows = false;
            dgv_guest.ReadOnly = true;

            // Tải dữ liệu thật từ Database ngay khi mở form
            LoadDataGrid();
        }

        // ── NGUYÊN TẮC: Đọc dữ liệu qua BUS và gán thông qua DataSource ──────────
        private void LoadDataGrid()
        {
            try
            {
                // Giả định hàm CustomerBUS.GetAll() trả về một DataTable hoặc List<Customer> trực tiếp từ DB
                // dgv_guest.DataSource = CustomerBUS.GetAll(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải danh sách khách hàng: {ex.Message}", "Lỗi");
            }
        }

        // ── NÚT THÊM KHÁCH HÀNG ──────────────────────────────────────────────────
        private void btn_AddCustomer_Click(object sender, EventArgs e)
        {
            isAdding = true;
            ClearInputFields();
            txt_phoneNumber.Focus();
        }

        // ── NÚT LƯU (Gọi BUS thay vì sửa trên Grid) ──────────────────────────────
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_phoneNumber.Text) || string.IsNullOrWhiteSpace(txt_fullName.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc (SĐT và Họ tên)!");
                return;
            }

            try
            {
                // Gom dữ liệu từ giao diện
                string phone = txt_phoneNumber.Text.Trim();
                string name = txt_fullName.Text.Trim();
                string type = cbo_customerType.Text;
                string address = txt_address.Text.Trim();

                if (isAdding)
                {
                    // NGUYÊN TẮC: Gọi hàm xử lý thêm của BUS để INSERT vào MariaDB
                    // bool success = CustomerBUS.AddCustomer(phone, name, type, address);
                    bool success = true; // Giả lập chạy thành công

                    if (success) MessageBox.Show("Thêm khách hàng thành công vào hệ thống!");
                }
                else
                {
                    // NGUYÊN TẮC: Gọi hàm xử lý cập nhật của BUS để UPDATE vào MariaDB
                    // bool success = CustomerBUS.UpdateCustomer(phone, name, type, address);
                    bool success = true; // Giả lập chạy thành công

                    if (success) MessageBox.Show("Cập nhật thông tin thành công!");
                }

                // Lưu xong thì tải lại lưới từ Database để cập nhật giao diện hiển thị mới nhất
                LoadDataGrid();
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Thao tác thất bại: {ex.Message}", "Lỗi xử lý");
            }
        }

        // ── NÚT SỬA ──────────────────────────────────────────────────────────────
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dgv_guest.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa ở danh sách phía dưới!");
                return;
            }

            isAdding = false;

            // Lấy dữ liệu từ dòng đang chọn để đổ ngược lên các Ô Nhập Liệu
            var row = dgv_guest.CurrentRow;
            txt_phoneNumber.Text = row.Cells["PhoneColumnName"].Value?.ToString(); // Thay bằng tên cột thực tế của bạn
            txt_fullName.Text = row.Cells["NameColumnName"].Value?.ToString();
            cbo_customerType.Text = row.Cells["TypeColumnName"].Value?.ToString();
            // txt_address.Text   = row.Cells["AddressColumnName"].Value?.ToString();
        }

        // ── TÌM KIẾM KHÁCH HÀNG (Gọi BUS để SELECT LIKE từ DB) ───────────────────
        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_search.Text.Trim();

            // NGUYÊN TẮC: Không dùng vòng lặp UI ẩn dòng. Hãy để Database tìm kiếm.
            // dgv_guest.DataSource = CustomerBUS.Search(keyword);
        }

        // ── CLICK CHỌN DÒNG TRÊN BẢNG ────────────────────────────────────────────
        private void dgv_Guest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgv_guest.Rows[e.RowIndex];
            txt_phoneNumber.Text = row.Cells[0].Value?.ToString();
            txt_fullName.Text = row.Cells[1].Value?.ToString();
            cbo_customerType.Text = row.Cells[2].Value?.ToString();

            // Đồng thời gán vào biến lưu trữ tạm để nếu FormSell cần lấy kết quả
            SelectedCustomerPhone = txt_phoneNumber.Text;
            SelectedCustomerName = txt_fullName.Text;
        }

        // ── Đúp chuột vào dòng để chọn nhanh cho Form Bán Hàng ─────────────────────
        private void dgv_guest_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgv_Guest_CellClick(sender, e);
                this.DialogResult = DialogResult.OK; // Đóng FormGuest và báo về cho FormSell biết là đã chọn xong
                this.Close();
            }
        }

        // ── NÚT LÀM MỚI / HỦY THAO TÁC ───────────────────────────────────────────
        private void btn_Cancel_Click(object sender, EventArgs e) => ClearInputFields();
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            txt_search.Clear();
            ClearInputFields();
            LoadDataGrid();
        }

        private void ClearInputFields()
        {
            txt_phoneNumber.Clear();
            txt_fullName.Clear();
            txt_address.Clear();
            cbo_customerType.SelectedIndex = -1;
            dgv_guest.ClearSelection();
        }

        private void btn_PurchaseHistory_Click(object sender, EventArgs e)
        {
            if (dgv_guest.CurrentRow == null) return;
            string customerPhone = dgv_guest.CurrentRow.Cells[0].Value?.ToString();
            // Mở form lịch sử mua hàng, truyền Số điện thoại khách sang cho tầng BUS lấy danh sách hóa đơn cũ
        }

        private void dgv_guest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_address_TextChanged(object sender, EventArgs e)
        {

        }
    }
}