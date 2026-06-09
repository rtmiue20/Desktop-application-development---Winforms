using System;
using System.Collections.Generic; // Bổ sung để dùng List
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

        public FormGuarantee()
        {
            InitializeComponent();
        }

        private void FormGuarantee_Load(object sender, EventArgs e)
        {
            // Thiết lập ComboBox bộ lọc
            cbb_statusFilter.DropDownStyle = ComboBoxStyle.DropDownList; // Ép người dùng chỉ được chọn
            cbb_statusFilter.Items.Clear();
            cbb_statusFilter.Items.Add("Tất cả trạng thái");
            cbb_statusFilter.Items.AddRange(new string[] { "Đang kiểm tra", "Chờ linh kiện", "Đang sửa", "Đã sửa xong", "Đã trả khách" });
            cbb_statusFilter.SelectedIndex = 0;

            LoadWarrantyList();
        }

        private void LoadWarrantyList()
        {
            // Đảm bảo luôn gán một List để tránh null reference
            dgv_guaranteeList.DataSource = _warrantyBUS.GetAll() ?? new List<WarrantyClaimsDTO>();
        }

        // --- CÁC SỰ KIỆN NÚT BẤM ---

        private void btnAddWarranty_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng mở Form tiếp nhận đang được phát triển!");
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (_selectedClaimID == 0)
            {
                MessageBox.Show("Vui lòng chọn một phiếu trong danh sách để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Code xử lý update status gọi _warrantyBUS.UpdateStatus(...) tại đây
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cbb_statusFilter.SelectedIndex = 0; // Reset về mặc định
            LoadWarrantyList();
        }

        // --- XỬ LÝ LƯỚI DỮ LIỆU ---

        private void dgv_guaranteeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra dòng hợp lệ (bỏ qua header)
            if (e.RowIndex >= 0)
            {
                // THAY ĐỔI: Dùng tên cột "ClaimID" thay vì "Mã BH" 
                // vì trong DTO thường đặt là ClaimID
                var cellValue = dgv_guaranteeList.Rows[e.RowIndex].Cells["ClaimID"].Value;
                if (cellValue != null)
                {
                    _selectedClaimID = Convert.ToInt32(cellValue);
                }
            }
        }

        private void dgv_guaranteeList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Đảm bảo tên cột khớp với thuộc tính trong DTO (thường là 'Status')
            if (dgv_guaranteeList.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                string status = e.Value.ToString();
                switch (status)
                {
                    case "Đang kiểm tra": e.CellStyle.BackColor = Color.LightYellow; break;
                    case "Đã sửa xong": e.CellStyle.BackColor = Color.LightGreen; break;
                    case "Đã trả khách": e.CellStyle.BackColor = Color.LightBlue; break;
                }
            }
        }

        private void cbb_statusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Chỉ chạy khi đã load xong Form
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
    }
}   