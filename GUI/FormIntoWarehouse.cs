using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DTO;

namespace GUI
{
    public partial class FormIntoWarehouse : Form
    {
        // Danh sách giỏ hàng tạm lưu thông tin hiển thị lên DataGridView
        // Nó sẽ được chuyển đổi thành List<InboundDetailsDTO> khi bấm lưu
        private class CartItem
        {
            public int ProductID { get; set; }
            public string ProductName { get; set; } = string.Empty;
            public int Quantity { get; set; }
            public decimal UnitCost { get; set; }
            public decimal TotalCost { get; set; }
        }

        private List<CartItem> _cart = new List<CartItem>();
        private decimal _totalAmount = 0;
        private int _totalQuantity = 0;

        public FormIntoWarehouse()
        {
            InitializeComponent();
        }

        private void FormIntoWarehouse_Load(object sender, EventArgs e)
        {
            LoadMockDataToComboBox();
            ResetForm();
        }

        // Tải dữ liệu mẫu vào ComboBox sử dụng DataBinding (Dựa trên DTO)
        private void LoadMockDataToComboBox()
        {
            // 1. Setup ComboBox Nhà Cung Cấp
            var suppliers = new List<SuppliersDTO>
            {
                new SuppliersDTO { SupplierID = 1, SupplierName = "Công ty Linh kiện Alpha" },
                new SuppliersDTO { SupplierID = 2, SupplierName = "Nhà phân phối Sigma" }
            };
            cbSuppliers.DataSource = suppliers;
            cbSuppliers.DisplayMember = "SupplierName"; // Hiển thị tên
            cbSuppliers.ValueMember = "SupplierID";     // Ngầm giữ ID bên dưới

            // 2. Setup ComboBox Sản Phẩm
            var products = new List<ProductsDTO>
            {
                new ProductsDTO { ProductID = 101, ProductName = "Laptop ASUS ROG Strix", CostPrice = 25000000 },
                new ProductsDTO { ProductID = 102, ProductName = "iPhone 15 Pro Max", CostPrice = 28000000 },
                new ProductsDTO { ProductID = 103, ProductName = "Bàn phím cơ Akko 3098B", CostPrice = 1500000 }
            };
            cbProducts.DataSource = products;
            cbProducts.DisplayMember = "ProductName";
            cbProducts.ValueMember = "ProductID";
        }

        // Tự động nhảy giá nhập (CostPrice) khi chọn Sản phẩm khác
        private void cbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProducts.SelectedItem is ProductsDTO selectedProduct)
            {
                nudPrice.Value = selectedProduct.CostPrice;
            }
        }

        // THÊM SẢN PHẨM VÀO GIỎ HÀNG NHẬP
        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            if (cbProducts.SelectedValue == null) return;

            int productId = (int)cbProducts.SelectedValue;
            var selectedProduct = cbProducts.SelectedItem as ProductsDTO;
            if (selectedProduct == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string productName = selectedProduct.ProductName;
            int quantity = (int)nudQuantity.Value;
            decimal unitCost = nudPrice.Value;

            if (quantity <= 0 || unitCost <= 0)
            {
                MessageBox.Show("Số lượng và đơn giá nhập phải lớn hơn 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cập nhật giỏ hàng: nếu sản phẩm đã có thì cộng dồn số lượng
            var existingItem = _cart.FirstOrDefault(x => x.ProductID == productId);
            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
                existingItem.UnitCost = unitCost; // Cập nhật lại giá nhập mới nhất
                existingItem.TotalCost = existingItem.Quantity * existingItem.UnitCost;
            }
            else
            {
                _cart.Add(new CartItem
                {
                    ProductID = productId,
                    ProductName = productName,
                    Quantity = quantity,
                    UnitCost = unitCost,
                    TotalCost = quantity * unitCost
                });
            }

            UpdateGridAndTotal();
        }

        private void UpdateGridAndTotal()
        {
            dgvDetails.DataSource = null;
            dgvDetails.DataSource = _cart;

            // Tính toán tổng số lượng và tổng tiền chuẩn bị cho InboundReceiptsDTO
            _totalAmount = _cart.Sum(x => x.TotalCost);
            _totalQuantity = _cart.Sum(x => x.Quantity);

            txtTotalAmount.Text = _totalAmount.ToString("N0") + " VND";
        }

        // HOÀN TẤT NHẬP KHO - Khởi tạo DTO đẩy xuống BUS
        private void btnSaveReceipt_Click(object sender, EventArgs e)
        {
            if (_cart.Count == 0)
            {
                MessageBox.Show("Phiếu nhập kho chưa có sản phẩm nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Khởi tạo InboundReceiptsDTO
            var receiptDTO = new InboundReceiptsDTO
            {
                InboundCode = txtReceiptCode.Text,
                SupplierID = (int)cbSuppliers.SelectedValue,
                UserID = 1, // ID của nhân viên đang đăng nhập (Giả định là 1)
                TotalQuantity = _totalQuantity,
                TotalAmount = _totalAmount,
                ReceiptDate = DateTime.Now,
                Note = "Nhập kho mới" // Nếu trên UI có txtNote thì đổi thành txtNote.Text
            };

            // 2. Khởi tạo List<InboundDetailsDTO>
            var detailsList = new List<InboundDetailsDTO>();
            foreach (var item in _cart)
            {
                detailsList.Add(new InboundDetailsDTO
                {
                    // InboundID sẽ được gán tự động ở tầng DAL sau khi Insert Receipt thành công
                    ProductID = item.ProductID,
                    Quantity = item.Quantity,
                    UnitCost = item.UnitCost,
                    TotalCost = item.TotalCost
                });
            }

            // 3. Đẩy xuống tầng BUS xử lý (Giả lập)
            // var result = _inboundBUS.InsertReceipt(receiptDTO, detailsList);
            bool isSuccess = true; // Giả lập kết quả trả về từ BUS

            if (isSuccess)
            {
                MessageBox.Show("Lập phiếu nhập kho thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _cart.Clear();
                UpdateGridAndTotal();
                ResetForm();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi lưu phiếu nhập!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _cart.Clear();
            UpdateGridAndTotal();
            ResetForm();
        }

        private void ResetForm()
        {
            txtReceiptCode.Text = "PN-" + DateTime.Now.ToString("yyyyMMddHHmmss");
            nudQuantity.Value = 1;

            if (cbProducts.Items.Count > 0)
                cbProducts.SelectedIndex = 0;
        }

        private void cbSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}