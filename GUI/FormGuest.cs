using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormGuest : Form
    {
        public FormGuest()
        {
            InitializeComponent();

            // Đăng ký thủ công sự kiện Click cho các nút nếu chưa cấu hình ở Designer
            btn_add.Click += new EventHandler(btn_add_Click);
            btn_update.Click += new EventHandler(btn_update_Click);
            btn_delete.Click += new EventHandler(btn_delete_Click);
            btn_search.Click += new EventHandler(btn_search_Click);
            dgv_Guest.CellClick += new DataGridViewCellEventHandler(dgv_Guest_CellClick);
        }

        private void FormGuest_Load(object sender, EventArgs e)
        {
            // Tự động nạp dữ liệu mẫu vào ComboBox Hạng khi mở Form
            cbo_Rank.Items.Clear();
            cbo_Rank.Items.Add("Đồng");
            cbo_Rank.Items.Add("Bạc");
            cbo_Rank.Items.Add("Vàng");
            cbo_Rank.Items.Add("Kim cương");
            if (cbo_Rank.Items.Count > 0) cbo_Rank.SelectedIndex = 0;

            // Chừa chỗ để gọi hàm load dữ liệu từ MySQL (nếu có)
            // LoadDataFromDatabase();
        }

        // ==========================================
        // 1. CHỨC NĂNG THÊM KHÁCH HÀNG
        // ==========================================
        private void btn_add_Click(object sender, EventArgs e)
        {
            // Kiểm tra tính hợp lệ của dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(txt_GuestID.Text) || string.IsNullOrWhiteSpace(txt_GuestName.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã KH và Tên KH!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: Viết lệnh truy vấn MySQL để INSERT vào database tại đây

            // Thêm trực tiếp vào DataGridView (Cột Điểm tích lũy mặc định ban đầu là 0)
            dgv_Guest.Rows.Add(
                txt_GuestID.Text,
                txt_GuestName.Text,
                txt_Phone.Text,
                "0",
                cbo_Rank.SelectedItem?.ToString()
            );

            MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
        }

        // ==========================================
        // 2. CHỨC NĂNG SỬA THÔNG TIN
        // ==========================================
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (dgv_Guest.CurrentRow == null || dgv_Guest.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Vui lòng chọn một khách hàng từ danh sách dưới đây để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: Viết lệnh truy vấn MySQL để UPDATE vào database tại đây theo txt_GuestID.Text

            // Cập nhật hiển thị trên GridView dòng đang chọn
            DataGridViewRow currentRow = dgv_Guest.CurrentRow;
            currentRow.Cells["col_CustomerID"].Value = txt_GuestID.Text;
            currentRow.Cells["col_customer_name"].Value = txt_GuestName.Text;
            currentRow.Cells["col_PhoneNumber"].Value = txt_Phone.Text;
            currentRow.Cells["col_MembershipTier"].Value = cbo_Rank.SelectedItem?.ToString();

            MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
        }

        // ==========================================
        // 3. CHỨC NĂNG XÓA KHÁCH HÀNG
        // ==========================================
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_Guest.CurrentRow == null || dgv_Guest.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                // TODO: Viết lệnh truy vấn MySQL để DELETE khách hàng theo txt_GuestID.Text tại đây

                // Xóa dòng hiển thị khỏi GridView
                dgv_Guest.Rows.RemoveAt(dgv_Guest.CurrentRow.Index);

                MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
        }

        // ==========================================
        // 4. CHỨC NĂNG TÌM KIẾM
        // ==========================================
        private void btn_search_Click(object sender, EventArgs e)
        {
            string keyword = txt_GuestName.Text.Trim().ToLower();
            string searchID = txt_GuestID.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword) && string.IsNullOrEmpty(searchID))
            {
                MessageBox.Show("Vui lòng nhập Tên KH hoặc Mã KH để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Giải pháp tìm kiếm nhanh trực tiếp trên DataGridView UI:
            bool statusFound = false;
            dgv_Guest.ClearSelection();

            foreach (DataGridViewRow row in dgv_Guest.Rows)
            {
                if (row.IsNewRow) continue;

                string valID = row.Cells["col_CustomerID"].Value?.ToString().ToLower() ?? "";
                string valName = row.Cells["col_customer_name"].Value?.ToString().ToLower() ?? "";

                if ((!string.IsNullOrEmpty(searchID) && valID.Contains(searchID)) ||
                    (!string.IsNullOrEmpty(keyword) && valName.Contains(keyword)))
                {
                    row.Selected = true;
                    dgv_Guest.FirstDisplayedScrollingRowIndex = row.Index; // Cuộn màn hình đến dòng tìm thấy

                    // Đổ dữ liệu ngược lên Control để xem/sửa
                    txt_GuestID.Text = row.Cells["col_CustomerID"].Value?.ToString();
                    txt_GuestName.Text = row.Cells["col_customer_name"].Value?.ToString();
                    txt_Phone.Text = row.Cells["col_PhoneNumber"].Value?.ToString();
                    cbo_Rank.SelectedItem = row.Cells["col_MembershipTier"].Value?.ToString();

                    statusFound = true;
                    break;
                }
            }

            if (!statusFound)
            {
                MessageBox.Show("Không tìm thấy khách hàng phù hợp nào!", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // ==========================================
        // 5. SỰ KIỆN CLICK CHỌN DÒNG TRÊN GRIDVIEW
        // ==========================================
        private void dgv_Guest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra click chuột có nằm trong vùng dòng hợp lệ (loại bỏ dòng tiêu đề index -1)
            if (e.RowIndex >= 0 && e.RowIndex < dgv_Guest.Rows.Count && !dgv_Guest.Rows[e.RowIndex].IsNewRow)
            {
                DataGridViewRow row = dgv_Guest.Rows[e.RowIndex];

                // Đẩy dữ liệu từ dòng được chọn lên các Controls phía trên
                txt_GuestID.Text = row.Cells["col_CustomerID"].Value?.ToString();
                txt_GuestName.Text = row.Cells["col_customer_name"].Value?.ToString();
                txt_Phone.Text = row.Cells["col_PhoneNumber"].Value?.ToString();

                string rankValue = row.Cells["col_MembershipTier"].Value?.ToString();
                if (cbo_Rank.Items.Contains(rankValue))
                {
                    cbo_Rank.SelectedItem = rankValue;
                }
            }
        }

        // ==========================================
        // HÀM BỔ TRỢ: XÓA TRẮNG FORM NHẬP
        // ==========================================
        private void ClearFields()
        {
            txt_GuestID.Clear();
            txt_GuestName.Clear();
            txt_Phone.Clear();
            if (cbo_Rank.Items.Count > 0) cbo_Rank.SelectedIndex = 0;
            txt_GuestID.Focus();
        }
    }
}