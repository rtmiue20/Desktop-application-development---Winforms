using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormInventory : Form
    {
        private class InventoryModel
        {
            // Triệt tiêu cảnh báo CS8618
            public string ProductCode { get; set; } = string.Empty;
            public string ProductName { get; set; } = string.Empty;
            public string Category { get; set; } = string.Empty;
            public int Stock { get; set; }
            public int MinStock { get; set; }
            public string Status { get; set; } = string.Empty;
        }

        private List<InventoryModel> _items = new List<InventoryModel>();

        public FormInventory()
        {
            InitializeComponent();
        }

        private void FormInventory_Load(object sender, EventArgs e)
        {
            cb_categories.Items.AddRange(new[] { "Tất cả danh mục", "Điện thoại", "Máy tính bảng" });
            cb_categories.SelectedIndex = 0;
            cb_statusFilter.Items.AddRange(new[] { "Tất cả trạng thái", "Còn hàng", "Sắp hết", "Hết hàng" });
            cb_statusFilter.SelectedIndex = 0;

            LoadData();
        }

        private void LoadData()
        {
            _items = new List<InventoryModel>
            {
                new InventoryModel { ProductCode = "SP001", ProductName = "iPhone 15 Pro", Category = "Điện thoại", Stock = 8, MinStock = 5, Status = "Còn hàng" },
                new InventoryModel { ProductCode = "SP002", ProductName = "Samsung S24", Category = "Điện thoại", Stock = 3, MinStock = 5, Status = "Sắp hết" },
                new InventoryModel { ProductCode = "SP003", ProductName = "iPad Pro M2", Category = "Máy tính bảng", Stock = 0, MinStock = 3, Status = "Hết hàng" }
            };
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            // Đảm bảo Text không bị null (CS8602)
            string selectedCategory = cb_categories.Text ?? string.Empty;
            string selectedStatus = cb_statusFilter.Text ?? string.Empty;

            var filtered = _items.Where(x =>
                (cb_categories.SelectedIndex == 0 || x.Category == selectedCategory) &&
                (cb_statusFilter.SelectedIndex == 0 || x.Status == selectedStatus)).ToList();

            dgv_inventory.DataSource = filtered;

            if (dgv_inventory.Columns["ProductCode"] != null) dgv_inventory.Columns["ProductCode"].HeaderText = "Mã SP";
            if (dgv_inventory.Columns["ProductName"] != null) dgv_inventory.Columns["ProductName"].HeaderText = "Tên sản phẩm";
            if (dgv_inventory.Columns["Category"] != null) dgv_inventory.Columns["Category"].HeaderText = "Danh mục";
            if (dgv_inventory.Columns["Stock"] != null) dgv_inventory.Columns["Stock"].HeaderText = "Tồn kho";
            if (dgv_inventory.Columns["MinStock"] != null) dgv_inventory.Columns["MinStock"].HeaderText = "Tồn tối thiểu";
            if (dgv_inventory.Columns["Status"] != null) dgv_inventory.Columns["Status"].HeaderText = "Trạng thái";

            lbl_totalCount.Text = "24\nTổng sản phẩm";
            lbl_availableCount.Text = "18\nCòn hàng";
            lbl_warningCount.Text = "4\nSắp hết (≤ MinStock)";
            lbl_outOfStockCount.Text = "2\nHết hàng";
            lbl_timeUpdate.Text = $"Cập nhật lúc: {DateTime.Now:HH:mm dd/MM/yyyy}";
        }

        private void btn_filter_Click(object sender, EventArgs e) => ApplyFilter();
        private void btn_export_Click(object sender, EventArgs e) => MessageBox.Show("Đã xuất Excel!");
        private void btn_refresh_Click(object sender, EventArgs e) { cb_categories.SelectedIndex = 0; cb_statusFilter.SelectedIndex = 0; LoadData(); }

        private void lbl_timeUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}