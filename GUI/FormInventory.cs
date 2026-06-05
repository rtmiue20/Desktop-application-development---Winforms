using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormInventory : Form
    {
        // Danh sách giả lập cơ sở dữ liệu sản phẩm trong kho phục vụ kiểm kê
        private List<dynamic> _inventoryList = new List<dynamic>();

        public FormInventory()
        {
            InitializeComponent();
        }

        private void FormInventory_Load(object sender, EventArgs e)
        {
            LoadMockInventoryData();
        }

        private void LoadMockInventoryData()
        {
            _inventoryList = new List<dynamic>()
            {
                new { MaSP = "SP001", TenSP = "Laptop ASUS ROG Strix", TonHeThong = 15, TonThucTe = 15, ChenhLech = 0, GhiChu = "Khớp" },
                new { MaSP = "SP002", TenSP = "iPhone 15 Pro Max", TonHeThong = 30, TonThucTe = 29, ChenhLech = -1, GhiChu = "Chưa rõ lý do hao hụt" },
                new { MaSP = "SP003", TenSP = "Bàn phím cơ Akko 3098B", TonHeThong = 8, TonThucTe = 8, ChenhLech = 0, GhiChu = "Khớp" }
            };
            dgvInventory.DataSource = _inventoryList;
        }

        // Sự kiện chọn dòng trên Grid để lấy thông tin chỉnh sửa số kiểm kê thực tế
        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvInventory.Rows[e.RowIndex];
                txtProductCode.Text = row.Cells["MaSP"].Value?.ToString();
                txtProductName.Text = row.Cells["TenSP"].Value?.ToString();
                txtSystemQty.Text = row.Cells["TonHeThong"].Value?.ToString();
                nudActualQty.Value = Convert.ToInt32(row.Cells["TonThucTe"].Value);
                txtNote.Text = row.Cells["GhiChu"].Value?.ToString();

                TinhChenhLech();
            }
        }

        private void nudActualQty_ValueChanged(object sender, EventArgs e)
        {
            TinhChenhLech();
        }

        private void TinhChenhLech()
        {
            if (int.TryParse(txtSystemQty.Text, out int systemQty))
            {
                int actualQty = (int)nudActualQty.Value;
                int diff = actualQty - systemQty;
                txtDifference.Text = diff.ToString();
            }
        }

        // Nút CẬP NHẬT SỐ LIỆU KIỂM KÊ TẠM THỜI LÊN LƯỚI
        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductCode.Text))
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm từ danh sách kiểm kê!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string code = txtProductCode.Text;
            int actualQty = (int)nudActualQty.Value;
            int systemQty = int.Parse(txtSystemQty.Text);
            int diff = actualQty - systemQty;
            string note = txtNote.Text.Trim();

            // Cập nhật lại danh sách In-memory
            for (int i = 0; i < _inventoryList.Count; i++)
            {
                if (_inventoryList[i].MaSP == code)
                {
                    _inventoryList[i] = new
                    {
                        MaSP = code,
                        TenSP = txtProductName.Text,
                        TonHeThong = systemQty,
                        TonThucTe = actualQty,
                        ChenhLech = diff,
                        GhiChu = string.IsNullOrEmpty(note) ? "Đã kiểm kê" : note
                    };
                    break;
                }
            }

            dgvInventory.DataSource = null;
            dgvInventory.DataSource = _inventoryList;
            MessageBox.Show("Cập nhật số liệu kiểm kê tạm thời thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInputs();
        }

        // Nút LƯU BIÊN BẢN KIỂM KÊ TOÀN BỘ XUỐNG HỆ THỐNG
        private void btnSaveInventory_Click(object sender, EventArgs e)
        {
            // Điểm kết nối nghiệp vụ (BUS Layer) sau khi hoàn thiện cơ sở dữ liệu
            MessageBox.Show("Đã lưu biên bản kiểm kê kho và cân bằng số lượng tồn kho thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtProductCode.Clear();
            txtProductName.Clear();
            txtSystemQty.Clear();
            txtDifference.Clear();
            txtNote.Clear();
            nudActualQty.Value = 0;
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}