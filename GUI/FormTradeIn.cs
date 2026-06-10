using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class FormTradeIn : Form
    {
        // Khởi tạo BUS xử lý dữ liệu
        private readonly WarrantyBUS _warrantyBus = new WarrantyBUS();
        private List<WarrantyClaimsDTO> _allClaims = new List<WarrantyClaimsDTO>();

        public FormTradeIn()
        {
            InitializeComponent();
        }

        private void FormTradeIn_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            LoadData();
        }

        // ─────────────────────────────────────────────
        // 1. NẠP DỮ LIỆU TỪ DATABASE VÀO DATAGRIDVIEW
        // ─────────────────────────────────────────────
        private void LoadData()
        {
            try
            {
                // Lấy toàn bộ dữ liệu từ bảng WarrantyClaims (yêu cầu bạn đã thêm hàm GetAll() trong WarrantyBUS)
                // Nếu chưa có GetAll() trong BUS, bạn có thể gọi dal.GetAll() hoặc viết thêm vào BUS.
                // Ở đây giả định WarrantyBUS có hàm GetAll() trả về List<WarrantyClaimsDTO>
                _allClaims = _warrantyBus.GetAll(); // Ghi chú: Hãy chắc chắn bạn đã bọc hàm GetAll của DAL lên BUS

                dgv_tradeIn.AutoGenerateColumns = false;
                dgv_tradeIn.DataSource = _allClaims;

                FormatDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu từ CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatDataGridView()
        {
            dgv_tradeIn.ReadOnly = true;
            dgv_tradeIn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_tradeIn.AllowUserToAddRows = false;
            dgv_tradeIn.RowHeadersVisible = false;

            dgv_tradeIn.Columns.Clear();

            dgv_tradeIn.Columns.Add(new DataGridViewTextBoxColumn { Name = "ClaimID", DataPropertyName = "ClaimID", Visible = false });
            dgv_tradeIn.Columns.Add(new DataGridViewTextBoxColumn { Name = "ClaimCode", HeaderText = "Mã Yêu Cầu", DataPropertyName = "ClaimCode", FillWeight = 15 });
            dgv_tradeIn.Columns.Add(new DataGridViewTextBoxColumn { Name = "InvoiceID", HeaderText = "Mã HĐ", DataPropertyName = "InvoiceID", FillWeight = 10 });
            dgv_tradeIn.Columns.Add(new DataGridViewTextBoxColumn { Name = "ReceiveDate", HeaderText = "Ngày Nhận", DataPropertyName = "ReceiveDate", FillWeight = 15 });
            dgv_tradeIn.Columns.Add(new DataGridViewTextBoxColumn { Name = "DefectDescription", HeaderText = "Mô Tả / Lỗi", DataPropertyName = "DefectDescription", FillWeight = 25 });
            dgv_tradeIn.Columns.Add(new DataGridViewTextBoxColumn { Name = "Status", HeaderText = "Trạng Thái", DataPropertyName = "Status", FillWeight = 15 });
            dgv_tradeIn.Columns.Add(new DataGridViewTextBoxColumn { Name = "Resolution", HeaderText = "Hướng Giải Quyết", DataPropertyName = "Resolution", FillWeight = 20 });

            // Đổi màu hiển thị theo trạng thái
            foreach (DataGridViewRow row in dgv_tradeIn.Rows)
            {
                string status = row.Cells["Status"].Value?.ToString();
                if (status == "Đang kiểm tra") row.DefaultCellStyle.BackColor = Color.LightYellow;
                else if (status == "Đã hoàn tất") row.DefaultCellStyle.BackColor = Color.LightGreen;
                else if (status == "Đã hủy") row.DefaultCellStyle.BackColor = Color.LightCoral;
            }
        }

        private void LoadComboBoxes()
        {
            cbb_status.Items.Clear();
            cbb_status.Items.AddRange(new string[] { "Đang kiểm tra", "Đang xử lý", "Đã hoàn tất", "Đã hủy" });
            cbb_status.SelectedIndex = 0;
        }

        // ─────────────────────────────────────────────
        // 2. SỰ KIỆN TÌM KIẾM
        // ─────────────────────────────────────────────
        private void btn_search_Click(object sender, EventArgs e)
        {
            string keyword = txt_search.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyword))
            {
                dgv_tradeIn.DataSource = _allClaims;
                return;
            }

            var filtered = _allClaims.Where(c => 
                c.ClaimCode.ToLower().Contains(keyword) || 
                c.DefectDescription.ToLower().Contains(keyword) ||
                c.InvoiceID.ToString().Contains(keyword)
            ).ToList();

            dgv_tradeIn.DataSource = filtered;
            FormatDataGridView();
        }

        // ─────────────────────────────────────────────
        // 3. SỰ KIỆN XÁC NHẬN CẬP NHẬT TRẠNG THÁI
        // ─────────────────────────────────────────────
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (dgv_tradeIn.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một phiếu yêu cầu để xử lý!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int claimId = Convert.ToInt32(dgv_tradeIn.CurrentRow.Cells["ClaimID"].Value);
            string newStatus = cbb_status.SelectedItem.ToString();
            string resolution = txt_resolution.Text.Trim();

            if (string.IsNullOrEmpty(resolution) && newStatus == "Đã hoàn tất")
            {
                MessageBox.Show("Vui lòng nhập hướng giải quyết (Resolution) trước khi hoàn tất!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Gọi DAL thông qua BUS để cập nhật
                bool isSuccess = _warrantyBus.UpdateStatus(claimId, newStatus, resolution);

                if (isSuccess)
                {
                    MessageBox.Show("Cập nhật trạng thái thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); // Tải lại bảng sau khi update
                    txt_resolution.Clear();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─────────────────────────────────────────────
        // 4. SỰ KIỆN XÓA / HỦY BỎ
        // ─────────────────────────────────────────────
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_tradeIn.CurrentRow == null) return;

            int claimId = Convert.ToInt32(dgv_tradeIn.CurrentRow.Cells["ClaimID"].Value);
            
            var confirm = MessageBox.Show("Bạn có chắc muốn hủy phiếu yêu cầu này không?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                // Chuyển status thành "Đã hủy" thay vì xóa hẳn khỏi DB để lưu log
                bool isSuccess = _warrantyBus.UpdateStatus(claimId, "Đã hủy", "Khách hàng/Nhân viên hủy phiếu");
                if (isSuccess)
                {
                    MessageBox.Show("Đã hủy phiếu yêu cầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
        }

        // ─────────────────────────────────────────────
        // 5. SỰ KIỆN THÊM MỚI (CHUYỂN HƯỚNG TỚI FORM THÊM)
        // ─────────────────────────────────────────────
        private void btn_createTradein_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này sẽ mở Form tạo phiếu đổi trả/bảo hành mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // FormCreateWarranty frm = new FormCreateWarranty();
            // frm.ShowDialog();
            // LoadData();
        }

        private void dgv_tradeIn_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_tradeIn.CurrentRow != null)
            {
                string res = dgv_tradeIn.CurrentRow.Cells["Resolution"].Value?.ToString() ?? "";
                string stat = dgv_tradeIn.CurrentRow.Cells["Status"].Value?.ToString() ?? "";

                txt_resolution.Text = res;
                if (cbb_status.Items.Contains(stat))
                {
                    cbb_status.SelectedItem = stat;
                }
            }
        }
    }
}