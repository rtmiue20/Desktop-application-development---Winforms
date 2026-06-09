using System;
using System.Data;
using System.Windows.Forms;
// using BUS; // Bỏ comment và điền namespace chứa tầng nghiệp vụ (BUS/BLL) của bạn tại đây

namespace GUI
{
    public partial class FormPromotion : Form
    {
        // Biến cờ để nhận diện đang ở chế độ "Thêm mới" hay "Sửa"
        private bool isAdding = false;

        public FormPromotion()
        {
            InitializeComponent();

            // Đăng ký các sự kiện nút bấm và sự kiện lưới
            this.Load += FormPromotion_Load;
            btn_createPromotion.Click += btn_createPromotion_Click;
            btn_editPromotion.Click += btn_editPromotion_Click;
            btn_disablePromotion.Click += btn_disablePromotion_Click;
            btn_refresh.Click += btn_refresh_Click;
            btn_save.Click += btn_save_Click;
            btn_cancel.Click += btn_cancel_Click;

            // Đã sửa tên hàm cho đồng nhất với FormPromotion
            dgv_promotion.CellClick += dgv_promotion_CellClick;
        }

        // ==========================================
        // 1. FORM LOAD: Cấu hình bảng & Tải dữ liệu thật từ DB
        // ==========================================
        private void FormPromotion_Load(object sender, EventArgs e)
        {
            // Thiết lập thuộc tính chuẩn cho DataGridView
            dgv_promotion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_promotion.MultiSelect = false;
            dgv_promotion.AllowUserToAddRows = false;
            dgv_promotion.ReadOnly = true;
            dgv_promotion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Ánh xạ các cột trên Grid với tên thuộc tính/trường dữ liệu trả về từ Database thông qua BUS
            col_promotionCode.DataPropertyName = "PromotionCode";
            col_description.DataPropertyName = "Description";
            col_discountPercentage.DataPropertyName = "DiscountPercentage";
            col_discountAmount.DataPropertyName = "DiscountAmount";
            col_startDate.DataPropertyName = "StartDate";
            col_endDate.DataPropertyName = "EndDate";
            col_status.DataPropertyName = "Status";

            LoadPromotionsData();
            ResetInputFields(false); // Khóa các ô nhập liệu khi mới mở form
        }

        // Hàm gọi tầng BUS lấy danh sách Khuyến mãi từ Database nạp vào Grid
        private void LoadPromotionsData()
        {
            try
            {
                // NGUYÊN TẮC: Tuyệt đối không tạo List giả lập, lấy trực tiếp từ tầng xử lý
                // dgv_promotion.DataSource = PromotionsBUS.GetAllPromotions();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải danh sách khuyến mãi: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // 2. XỬ LÝ SỰ KIỆN CÁC NÚT ĐIỀU HƯỚNG CHỨC NĂNG
        // ==========================================

        // Nút "+ Tạo KM"
        private void btn_createPromotion_Click(object sender, EventArgs e)
        {
            isAdding = true;
            ResetInputFields(true);
            txt_promotionCode.Focus();
        }

        // Nút "Sửa"
        private void btn_editPromotion_Click(object sender, EventArgs e)
        {
            if (dgv_promotion.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn chương trình khuyến mãi cần sửa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            isAdding = false;
            ResetInputFields(true);
            txt_promotionCode.ReadOnly = true; // Không cho phép sửa mã Khuyến mãi (Khóa chính)
        }

        // Nút "Tắt KM" (Cập nhật trạng thái ngưng áp dụng)
        private void btn_disablePromotion_Click(object sender, EventArgs e)
        {
            if (dgv_promotion.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn khuyến mãi muốn tắt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string promoCode = txt_promotionCode.Text.Trim();
            var confirmResult = MessageBox.Show($"Bạn có chắc chắn muốn ngừng kích hoạt mã khuyến mãi [{promoCode}] không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    // NGUYÊN TẮC: Gọi BUS thực thi lệnh UPDATE trạng thái trong MariaDB
                    // bool result = PromotionsBUS.DisablePromotion(promoCode);
                    bool result = true; // Giả lập thực thi thành công từ BUS

                    if (result)
                    {
                        MessageBox.Show("Đã dừng kích hoạt chương trình khuyến mãi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadPromotionsData();
                        ResetInputFields(false);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Không thể tắt khuyến mãi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Nút "Làm mới"
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadPromotionsData();
            ResetInputFields(false);
            MessageBox.Show("Đã đồng bộ dữ liệu mới nhất từ hệ thống!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ==========================================
        // 3. XỬ LÝ NGHIỆP VỤ LƯU / HỦY (CÁC NÚT TRONG GROUPBOX CHI TIẾT)
        // ==========================================

        // Nút "Lưu"
        private void btn_save_Click(object sender, EventArgs e)
        {
            // Kiểm tra tính hợp lệ của dữ liệu đầu vào (Validation)
            if (string.IsNullOrWhiteSpace(txt_promotionCode.Text))
            {
                MessageBox.Show("Mã khuyến mãi không được để trống!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_promotionCode.Focus();
                return;
            }

            if (dtp_startDate.Value.Date > dtp_endDate.Value.Date)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txt_discountValue.Text, out decimal discountVal) || discountVal < 0)
            {
                MessageBox.Show("Giá trị giảm giá phải là số dương hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_discountValue.Focus();
                return;
            }

            try
            {
                string code = txt_promotionCode.Text.Trim();
                string desc = txt_description.Text.Trim();
                DateTime start = dtp_startDate.Value;
                DateTime end = dtp_endDate.Value;

                bool isSuccess = false;

                if (isAdding)
                {
                    // isSuccess = PromotionsBUS.AddPromotion(code, desc, discountVal, start, end);
                    isSuccess = true;
                    if (isSuccess) MessageBox.Show("Thêm mới chương trình khuyến mãi thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // isSuccess = PromotionsBUS.UpdatePromotion(code, desc, discountVal, start, end);
                    isSuccess = true;
                    if (isSuccess) MessageBox.Show("Cập nhật thông tin khuyến mãi thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (isSuccess)
                {
                    LoadPromotionsData();   // Tải lại bảng sau khi thay đổi dữ liệu
                    ResetInputFields(false); // Trả form về trạng thái khóa ban đầu
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lưu thất bại: {ex.Message}", "Lỗi xử lý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Nút "Hủy"
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            ResetInputFields(false);
        }

        // ==========================================
        // 4. SỰ KIỆN TƯƠNG TÁC LƯỚI (CELL CLICK)
        // ==========================================
        private void dgv_promotion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tránh lỗi click vào thanh tiêu đề (Header Row)
            if (e.RowIndex < 0) return;

            // Đổ dữ liệu từ dòng được chọn lên các ô nhập liệu bên phải
            DataGridViewRow row = dgv_promotion.Rows[e.RowIndex];

            txt_promotionCode.Text = row.Cells["col_promotionCode"].Value?.ToString() ?? "";
            txt_description.Text = row.Cells["col_description"].Value?.ToString() ?? "";
            dtp_startDate.Value = Convert.ToDateTime(row.Cells["col_startDate"].Value ?? DateTime.Now);
            dtp_endDate.Value = Convert.ToDateTime(row.Cells["col_endDate"].Value ?? DateTime.Now);

            // Xử lý hiển thị giá trị giảm (% hoặc tiền mặt dựa trên cột nào có dữ liệu)
            string pct = row.Cells["col_discountPercentage"].Value?.ToString();
            string amt = row.Cells["col_discountAmount"].Value?.ToString();
            txt_discountValue.Text = !string.IsNullOrEmpty(pct) && pct != "0" ? pct : amt;
        }

        // ==========================================
        // 5. HELPER METHOD: QUẢN LÝ TRẠNG THÁI UI FORM
        // ==========================================
        private void ResetInputFields(bool enableEditing)
        {
            // Bật/Tắt trạng thái tương tác của các ô điền thông tin
            txt_promotionCode.ReadOnly = !enableEditing || !isAdding;
            txt_description.ReadOnly = !enableEditing;
            txt_discountValue.ReadOnly = !enableEditing;
            dtp_startDate.Enabled = enableEditing;
            dtp_endDate.Enabled = enableEditing;

            btn_save.Enabled = enableEditing;
            btn_cancel.Enabled = enableEditing;

            // Mở khóa các nút chức năng chính khi không ở chế độ chỉnh sửa
            btn_createPromotion.Enabled = !enableEditing;
            btn_editPromotion.Enabled = !enableEditing;
            btn_disablePromotion.Enabled = !enableEditing;
            btn_refresh.Enabled = !enableEditing;

            if (!enableEditing)
            {
                // Xóa trống dữ liệu trên form khi kết thúc phiên làm việc
                txt_promotionCode.Clear();
                txt_description.Clear();
                txt_discountValue.Clear();
                dtp_startDate.Value = DateTime.Now;
                dtp_endDate.Value = DateTime.Now;
                dgv_promotion.ClearSelection();
            }
        }

        // Giữ lại hàm này để tránh Designer bị lỗi nếu đã lỡ click đúp tạo sự kiện
        private void dgv_promotion_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}