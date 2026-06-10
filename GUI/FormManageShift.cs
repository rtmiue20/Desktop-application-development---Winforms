using System;
using System.Drawing;
using System.Windows.Forms;
using BUS;
using DTO;
using Microsoft.VisualBasic; // Dùng cho Interaction.InputBox


namespace GUI
{
    public partial class FormManageShift : Form
    {
        private readonly ShiftsBUS _shiftsBus = new ShiftsBUS();

        // Giả lập ID người dùng hiện tại (Trong dự án thực tế, thay bằng CurrentUser.UserID)
        private readonly int _currentUserId = 1;


        public FormManageShift()
        {
            InitializeComponent();
        }


        private void FormManageShift_Load(object sender, EventArgs e)
        {
            LoadData();

            // Định dạng cột tiền tệ một lần
            string[] moneyCols = { "col_tienDauca", "col_tienCuoica", "col_chenhLech" };
            foreach (string col in moneyCols)
            {
                if (dgv_listShift.Columns[col] != null)
                {
                    dgv_listShift.Columns[col].DefaultCellStyle.Format = "N0";
                    dgv_listShift.Columns[col].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
        }


        // ─────────────────────────────────────────────
        // 1. TẢI DỮ LIỆU & CẬP NHẬT TRẠNG THÁI CA
        // ─────────────────────────────────────────────
        private void LoadData()
        {
            try
            {
                // 1. Tải danh sách lịch sử toàn bộ ca làm việc
                var listShifts = _shiftsBus.GetAllShifts();
                dgv_listShift.AutoGenerateColumns = false;
                dgv_listShift.DataSource = listShifts;


                // 2. Lấy thông tin ca đang mở của user hiện tại
                var currentShift = _shiftsBus.GetOpenShift(_currentUserId);
                UpdateCurrentShiftUI(currentShift);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu ca làm việc:\n" + ex.Message, "Lỗi Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void UpdateCurrentShiftUI(ShiftsDTO currentShift)
        {
            if (currentShift != null)
            {
                lbl_resStatus.Text = "ĐANG MỞ";
                lbl_resStatus.ForeColor = Color.ForestGreen;
                lbl_resTime.Text = currentShift.StartTime.ToString("dd/MM/yyyy HH:mm");
                lbl_resMoney.Text = $"{currentShift.OpeningCash:N0} đ";
            }
            else
            {
                lbl_resStatus.Text = "CHƯA MỞ CA";
                lbl_resStatus.ForeColor = Color.Firebrick;
                lbl_resTime.Text = "--/--/---- --:--";
                lbl_resMoney.Text = "0 đ";
            }
        }


        // ─────────────────────────────────────────────
        // 2. LOGIC MỞ CA (OPEN SHIFT)
        // ─────────────────────────────────────────────
        private void btn_shiftOpen_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã có ca nào đang mở chưa
            var currentShift = _shiftsBus.GetOpenShift(_currentUserId);
            if (currentShift != null)
            {
                MessageBox.Show("Bạn đang có ca chưa chốt. Vui lòng chốt ca cũ trước khi mở ca mới!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Gọi InputBox để nhập tiền mặt đầu ca
            string inputCash = Interaction.InputBox("Nhập số tiền mặt đầu ca (VNĐ):", "Mở ca làm việc", "0");
            if (string.IsNullOrWhiteSpace(inputCash)) return;


            if (decimal.TryParse(inputCash, out decimal openingCash))
            {
                var result = _shiftsBus.OpenShift(openingCash);
                if (result.success)
                {
                    MessageBox.Show("Mở ca thành công! Chúc bạn một ngày làm việc hiệu quả.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show(result.error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Số tiền không hợp lệ. Vui lòng chỉ nhập số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // ─────────────────────────────────────────────
        // 3. LOGIC CHỐT CA (CLOSE SHIFT)
        // ─────────────────────────────────────────────
        private void btn_shiftStop_Click(object sender, EventArgs e)
        {
            var currentShift = _shiftsBus.GetOpenShift(_currentUserId);
            if (currentShift == null)
            {
                MessageBox.Show("Không có ca nào đang mở để chốt!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Gọi InputBox để kiểm đếm thực tế
            string inputCash = Interaction.InputBox("Nhập tổng tiền mặt thực tế đang có tại quầy (VNĐ):", "Chốt ca làm việc", "0");
            if (string.IsNullOrWhiteSpace(inputCash)) return;


            if (decimal.TryParse(inputCash, out decimal actualCash))
            {
                string note = Interaction.InputBox("Ghi chú chênh lệch (nếu có):", "Ghi chú chốt ca", "");

                var result = _shiftsBus.CloseShift(actualCash, note);
                if (result.success)
                {
                    MessageBox.Show("Chốt ca thành công! Số liệu đã được lưu lại hệ thống.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show(result.error, "Lỗi chốt ca", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Số tiền không hợp lệ. Vui lòng chỉ nhập số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // ─────────────────────────────────────────────
        // 4. LÀM MỚI LỊCH SỬ CA
        // ─────────────────────────────────────────────
        private void btn_shiftHistory_Click(object sender, EventArgs e)
        {
            LoadData();
        }


        // ─────────────────────────────────────────────
        // 5. ĐỊNH DẠNG MÀU SẮC GRIDVIEW TỰ ĐỘNG
        // ─────────────────────────────────────────────
        private void dgv_listShift_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgv_listShift.ClearSelection();

            foreach (DataGridViewRow row in dgv_listShift.Rows)
            {
                if (row.IsNewRow) continue;

                string status = row.Cells["col_trangThai"]?.Value?.ToString() ?? "";

                // Tô màu theo trạng thái
                if (status == "Đang mở")
                {
                    row.DefaultCellStyle.BackColor = Color.LightYellow;
                    row.Cells["col_trangThai"].Style.ForeColor = Color.DarkOrange;
                    row.Cells["col_trangThai"].Style.Font = new Font(dgv_listShift.Font, FontStyle.Bold);
                }
                else if (status == "Đã chốt")
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.Cells["col_trangThai"].Style.ForeColor = Color.ForestGreen;
                }

                // ĐỊNH DẠNG TIỀN TỆ - CÁCH ĐÚNG (Không gán chuỗi " đ" vào Value)
                string[] moneyColumns = { "col_tienDauca", "col_tienCuoica", "col_chenhLech" };

                foreach (string colName in moneyColumns)
                {
                    if (row.Cells[colName].Value != null &&
                        decimal.TryParse(row.Cells[colName].Value.ToString(), out decimal amount))
                    {
                        // Chỉ thay đổi cách hiển thị, không thay đổi giá trị thật
                        row.Cells[colName].Style.Format = "N0";
                        row.Cells[colName].Style.Alignment = DataGridViewContentAlignment.MiddleRight;

                        // Bôi đỏ nếu chênh lệch âm
                        if (colName == "col_chenhLech" && amount < 0)
                        {
                            row.Cells[colName].Style.ForeColor = Color.Red;
                            row.Cells[colName].Style.Font = new Font(dgv_listShift.Font, FontStyle.Bold);
                        }
                    }
                }
            }
        }
    }
}


