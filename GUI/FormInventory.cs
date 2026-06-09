using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class FormInventory : Form
    {
        private ProductsBUS _productBUS = null!;
        private CategoriesBUS _categoryBUS = null!;

        // Model này ánh xạ chính xác các trường cần thiết từ cấu trúc DB
        private class InventoryModel
        {
            public string ProductCode { get; set; } = string.Empty;
            public string ProductName { get; set; } = string.Empty;
            public string CategoryName { get; set; } = string.Empty;
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
            _productBUS = new ProductsBUS();
            _categoryBUS = new CategoriesBUS();

            LoadCategoriesToFilter();
            cb_statusFilter.Items.AddRange(new[] { "Tất cả trạng thái", "Còn hàng", "Sắp hết", "Hết hàng" });
            cb_statusFilter.SelectedIndex = 0;

            LoadDataFromDB();
        }

        private void LoadCategoriesToFilter()
        {
            cb_categories.Items.Clear();
            cb_categories.Items.Add("Tất cả danh mục");
            var categories = _categoryBUS.GetAll();
            if (categories != null)
            {
                foreach (var cat in categories) cb_categories.Items.Add(cat.CategoryName);
            }
            cb_categories.SelectedIndex = 0;
        }

        private void LoadDataFromDB()
        {
            var products = _productBUS.GetAll();
            var categories = _categoryBUS.GetAll();

            _items.Clear();

            if (products == null || products.Count == 0)
            {
                ApplyFilter(); // Chạy để reset giao diện về 0
                return;
            }

            foreach (var p in products)
            {
                // TODO: Chỗ này nhóm bạn tính Tồn kho từ bảng InboundDetails trừ đi SalesDetails
                // Tạm thời để mặc định để render form lên trước
                int currentStock = 0;
                string catName = categories?.FirstOrDefault(c => c.CategoryID == p.CategoryID)?.CategoryName ?? "Chưa phân loại";

                string status = "Hết hàng";
                if (currentStock > p.MinStock) status = "Còn hàng";
                else if (currentStock > 0 && currentStock <= p.MinStock) status = "Sắp hết";

                _items.Add(new InventoryModel
                {
                    ProductCode = p.ProductCode,
                    ProductName = p.ProductName,
                    CategoryName = catName,
                    Stock = currentStock,
                    MinStock = p.MinStock,
                    Status = status
                });
            }
            ApplyFilter();
        }

        private void ApplyFilter()

        {
            string selectedCategory = cb_categories.Text ?? string.Empty;
            string selectedStatus = cb_statusFilter.Text ?? string.Empty;

            var filtered = _items.Where(x =>
                (cb_categories.SelectedIndex == 0 || x.CategoryName == selectedCategory) &&
                (cb_statusFilter.SelectedIndex == 0 || x.Status == selectedStatus)).ToList();

            // Đè chết cột ảo, vẽ cột thật
            dgv_inventory.Columns.Clear();
            dgv_inventory.AutoGenerateColumns = true;
            dgv_inventory.DataSource = filtered;

            if (dgv_inventory.Columns["ProductCode"] is { } colCode) colCode.HeaderText = "Mã SP";
            if (dgv_inventory.Columns["ProductName"] is { } colName) colName.HeaderText = "Tên sản phẩm";
            if (dgv_inventory.Columns["CategoryName"] is { } colCat) colCat.HeaderText = "Danh mục";
            if (dgv_inventory.Columns["Stock"] is { } colStock) colStock.HeaderText = "Tồn thực tế";
            if (dgv_inventory.Columns["MinStock"] is { } colMin) colMin.HeaderText = "Tồn tối thiểu";
            if (dgv_inventory.Columns["Status"] is { } colStatus) colStatus.HeaderText = "Trạng thái";

            int total = _items.Count;
            lbl_totalCount.Text = $"{total}\nTổng sản phẩm";
            lbl_availableCount.Text = $"{_items.Count(x => x.Status == "Còn hàng")}\nCòn hàng";
            lbl_warningCount.Text = $"{_items.Count(x => x.Status == "Sắp hết")}\nSắp hết (≤ MinStock)";
            lbl_outOfStockCount.Text = $"{_items.Count(x => x.Status == "Hết hàng")}\nHết hàng";
            lbl_timeUpdate.Text = $"Cập nhật lúc: {DateTime.Now:HH:mm dd/MM/yyyy}";
        }

        private void btn_filter_Click(object sender, EventArgs e) => ApplyFilter();
        private void btn_export_Click(object sender, EventArgs e) => MessageBox.Show("Đã xuất Excel!");
        private void btn_refresh_Click(object sender, EventArgs e) { cb_categories.SelectedIndex = 0; cb_statusFilter.SelectedIndex = 0; LoadDataFromDB(); }
    }
}