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

            // Đảm bảo cột đã được tạo trước khi chọn dòng
            if (dgv_tradeIn.Rows.Count > 0)
                dgv_tradeIn.Rows[0].Selected = true;
        }

        private void LoadData()
        {
            try
            {
                _allClaims = _warrantyBus.GetAll() ?? new List<WarrantyClaimsDTO>();
                dgv_tradeIn.DataSource = _allClaims;
                FormatDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatDataGridView()
        {
            dgv_tradeIn.ReadOnly = true;
            dgv_tradeIn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_tradeIn.AllowUserToAddRows = false;
            dgv_tradeIn.RowHeadersVisible = false;
            dgv_tradeIn.AutoGenerateColumns = false;

            dgv_tradeIn.Columns.Clear();

            // Tạo cột với Name rõ ràng
            dgv_tradeIn.Columns.Add(new DataGridViewTextBoxColumn { Name = "ClaimID", DataPropertyName = "ClaimID", HeaderText = "ID", Visible = false });
            dgv_tradeIn.Columns.Add(new DataGridViewTextBoxColumn { Name = "ClaimCode", DataPropertyName = "ClaimCode", HeaderText = "Mã Yêu Cầu", Width = 130 });
            dgv_tradeIn.Columns.Add(new DataGridViewTextBoxColumn { Name = "InvoiceID", DataPropertyName = "InvoiceID", HeaderText = "Mã HĐ", Width = 80 });
            dgv_tradeIn.Columns.Add(new DataGridViewTextBoxColumn { Name = "ReceiveDate", DataPropertyName = "ReceiveDate", HeaderText = "Ngày Nhận", Width = 110, DefaultCellStyle = { Format = "dd/MM/yyyy" } });
            dgv_tradeIn.Columns.Add(new DataGridViewTextBoxColumn { Name = "DefectDescription", DataPropertyName = "DefectDescription", HeaderText = "Mô Tả Lỗi", Width = 280 });
            dgv_tradeIn.Columns.Add(new DataGridViewTextBoxColumn { Name = "Status", DataPropertyName = "Status", HeaderText = "Trạng Thái", Width = 130 });
            dgv_tradeIn.Columns.Add(new DataGridViewTextBoxColumn { Name = "Resolution", DataPropertyName = "Resolution", HeaderText = "Hướng Giải Quyết", Width = 250 });

            // Tô màu
            foreach (DataGridViewRow row in dgv_tradeIn.Rows)
            {
                string status = row.Cells["Status"]?.Value?.ToString() ?? "";
                if (status.Contains("kiểm tra") || status.Contains("xử lý"))
                    row.DefaultCellStyle.BackColor = Color.LightYellow;
                else if (status.Contains("hoàn tất"))
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                else if (status.Contains("hủy"))
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
            }
        }

        private void LoadComboBoxes()
        {
            cbb_status.Items.Clear();
            cbb_status.Items.AddRange(new string[] { "Đang kiểm tra", "Đang xử lý", "Đã hoàn tất", "Đã hủy" });
            cbb_status.SelectedIndex = 0;
        }

        // ==================== SỰ KIỆN CHÍNH ====================

        private void btn_createTradein_Click(object sender, EventArgs e)
        {
            // TODO: Mở form tạo phiếu mới (sau này bạn sẽ tạo)
            MessageBox.Show("Mở form tạo phiếu bảo hành mới...", "Tạo Phiếu Mới");
            // FormCreateWarranty frm = new FormCreateWarranty();
            // if (frm.ShowDialog() == DialogResult.OK) LoadData();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string keyword = txt_search.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyword))
            {
                dgv_tradeIn.DataSource = _allClaims;
                return;
            }

            var filtered = _allClaims.Where(c =>
                (c.ClaimCode?.ToLower().Contains(keyword) == true) ||
                (c.DefectDescription?.ToLower().Contains(keyword) == true)
            ).ToList();

            dgv_tradeIn.DataSource = filtered;
        }

        private void dgv_tradeIn_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_tradeIn.CurrentRow == null) return;

            try
            {
                // Kiểm tra cột tồn tại trước khi truy cập
                if (dgv_tradeIn.Columns.Contains("Resolution"))
                {
                    txt_resolution.Text = dgv_tradeIn.CurrentRow.Cells["Resolution"]?.Value?.ToString() ?? "";
                }

                if (dgv_tradeIn.Columns.Contains("Status"))
                {
                    string status = dgv_tradeIn.CurrentRow.Cells["Status"]?.Value?.ToString() ?? "";
                    if (cbb_status.Items.Contains(status))
                    {
                        cbb_status.SelectedItem = status;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("SelectionChanged Error: " + ex.Message);
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (dgv_tradeIn.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một phiếu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int claimId = Convert.ToInt32(dgv_tradeIn.CurrentRow.Cells["ClaimID"].Value);
            string newStatus = cbb_status.Text;
            string resolution = txt_resolution.Text.Trim();

            if (string.IsNullOrEmpty(resolution) && newStatus == "Đã hoàn tất")
            {
                MessageBox.Show("Vui lòng nhập Hướng giải quyết trước khi hoàn tất!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = _warrantyBus.UpdateStatus(claimId, newStatus, resolution);

            if (success)
            {
                MessageBox.Show("Cập nhật thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_tradeIn.CurrentRow == null) return;

            int claimId = Convert.ToInt32(dgv_tradeIn.CurrentRow.Cells["ClaimID"].Value);

            if (MessageBox.Show("Hủy phiếu này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool success = _warrantyBus.UpdateStatus(claimId, "Đã hủy", "Hủy bởi nhân viên");
                if (success) LoadData();
            }
        }
    }
}