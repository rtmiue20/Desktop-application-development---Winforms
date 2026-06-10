using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Desktop_Application_Development
{
    public partial class FormGuarantee : Form
    {
        private readonly WarrantyBUS _warrantyBUS = new WarrantyBUS();
        private int _selectedClaimID = 0;
        private string _selectedStatus = string.Empty;

        public FormGuarantee()
        {
            InitializeComponent();
        }

        private void FormGuarantee_Load(object sender, EventArgs e)
        {
            // ComboBox bộ lọc
            cbb_statusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_statusFilter.Items.Clear();
            cbb_statusFilter.Items.Add("Tất cả trạng thái");
            cbb_statusFilter.Items.AddRange(new string[] { "Đang kiểm tra", "Chờ linh kiện", "Đang sửa", "Đã sửa xong", "Đã trả khách" });
            cbb_statusFilter.SelectedIndex = 0;

            // ComboBox cập nhật trạng thái
            cbb_statusUpdate.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_statusUpdate.Items.Clear();
            cbb_statusUpdate.Items.AddRange(new string[] { "Đang kiểm tra", "Chờ linh kiện", "Đang sửa", "Đã sửa xong", "Đã trả khách" });

            LoadWarrantyList();
        }

        private void LoadWarrantyList()
        {
            dgv_guaranteeList.DataSource = _warrantyBUS.GetAll() ?? new List<WarrantyClaimsDTO>();
        }

        // Nút Tiếp nhận: chỉ đổi "Chờ linh kiện" -> "Đang sửa"
        private void btn_addWarranty_Click(object sender, EventArgs e)
        {
            if (_selectedClaimID == 0)
            {
                MessageBox.Show("Vui lòng chọn một phiếu bảo hành!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_selectedStatus == "Chờ linh kiện")
            {
                bool ok = _warrantyBUS.UpdateStatus(_selectedClaimID, "Đang sửa");
                if (ok)
                {
                    MessageBox.Show("Đã chuyển trạng thái sang 'Đang sửa'!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadWarrantyList();
                }
                else
                {
                    MessageBox.Show("Cập nhật trạng thái thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Chỉ phiếu đang 'Chờ linh kiện' mới được tiếp nhận để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Nút Cập nhật trạng thái: đổi sang trạng thái được chọn trong combobox
        private void btn_updateStatus_Click_1(object sender, EventArgs e)
        {
            if (_selectedClaimID == 0)
            {
                MessageBox.Show("Vui lòng chọn một phiếu trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newStatus = cbb_statusUpdate.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(newStatus))
            {
                MessageBox.Show("Vui lòng chọn trạng thái mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool ok = _warrantyBUS.UpdateStatus(_selectedClaimID, newStatus);
            if (ok)
            {
                MessageBox.Show($"Đã cập nhật trạng thái thành '{newStatus}'!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadWarrantyList();
            }
            else
            {
                MessageBox.Show("Cập nhật trạng thái thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Nút Làm mới
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            cbb_statusFilter.SelectedIndex = 0;
            cbb_statusUpdate.SelectedIndex = -1;
            _selectedClaimID = 0;
            _selectedStatus = string.Empty;
            LoadWarrantyList();
        }

        // Click vào dòng trong DataGridView
        private void dgv_guaranteeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgv_guaranteeList.Rows[e.RowIndex];
                var cellValue = row.Cells["ClaimID"].Value;
                if (cellValue != null)
                {
                    _selectedClaimID = Convert.ToInt32(cellValue);
                    _selectedStatus = row.Cells["Status"].Value?.ToString() ?? string.Empty;

                    // Chọn đúng trạng thái hiện tại trong combobox cập nhật
                    if (!string.IsNullOrEmpty(_selectedStatus))
                    {
                        int idx = cbb_statusUpdate.Items.IndexOf(_selectedStatus);
                        if (idx >= 0) cbb_statusUpdate.SelectedIndex = idx;
                    }
                }
            }
        }

        private void dgv_guaranteeList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_guaranteeList.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                string status = e.Value.ToString();
                switch (status)
                {
                    case "Đang kiểm tra": e.CellStyle.BackColor = Color.LightYellow; break;
                    case "Chờ linh kiện": e.CellStyle.BackColor = Color.Orange; break;
                    case "Đang sửa": e.CellStyle.BackColor = Color.LightPink; break;
                    case "Đã sửa xong": e.CellStyle.BackColor = Color.LightGreen; break;
                    case "Đã trả khách": e.CellStyle.BackColor = Color.LightBlue; break;
                }
            }
        }

        // Khi chọn trạng thái trong combobox lọc, sort DataGridView theo trạng thái đó
        private void cbb_statusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_statusFilter.SelectedIndex <= 0)
            {
                LoadWarrantyList();
            }
            else
            {
                string filter = cbb_statusFilter.SelectedItem.ToString();
                var filteredData = _warrantyBUS.GetByStatus(filter);
                dgv_guaranteeList.DataSource = filteredData ?? new List<WarrantyClaimsDTO>();
            }
        }

        private void dgv_guaranteeList_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
