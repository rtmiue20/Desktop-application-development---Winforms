using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class FormIntoWarehouse : Form
    {
        private readonly SuppliersBUS _supplierBUS = new();
        private readonly ProductsBUS _productBUS = new();
        private readonly InboundBUS _inboundBUS = new();

        private readonly BindingList<CartItem> _cart = new();

        public FormIntoWarehouse()
        {
            InitializeComponent();

            // Đăng ký sự kiện
            this.Load += FormIntoWarehouse_Load;
            btn_createReceipt.Click += btn_createReceipt_Click;
            btn_addProduct.Click += btn_addProduct_Click;
            btn_confirmReceipt.Click += btn_confirmReceipt_Click;
            btn_cancelReceipt.Click += btn_cancelReceipt_Click;
            btn_history.Click += btn_history_Click;
        }

        private void FormIntoWarehouse_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
            SetupGrid();
            ToggleState(false);
        }

        private void LoadSuppliers()
        {
            try
            {
                var suppliers = _supplierBUS.GetAll();
                if (suppliers != null && suppliers.Count > 0)
                {
                    cb_suppliers.DataSource = suppliers;
                    cb_suppliers.DisplayMember = "SupplierName";
                    cb_suppliers.ValueMember = "SupplierID";
                }
            }
            catch
            {
                cb_suppliers.Items.Add("Không có nhà cung cấp");
                cb_suppliers.SelectedIndex = 0;
            }
        }

        private void SetupGrid()
        {
            dgv_details.AutoGenerateColumns = false;
            dgv_details.Columns.Clear();

            dgv_details.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProductCode", HeaderText = "Mã SP", Width = 100 });
            dgv_details.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProductName", HeaderText = "Tên sản phẩm", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgv_details.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Quantity", HeaderText = "SL nhập", Width = 80 });
            dgv_details.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "UnitCost", HeaderText = "Đơn giá", Width = 130, DefaultCellStyle = { Format = "N0" } });
            dgv_details.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TotalCost", HeaderText = "Thành tiền", Width = 140, DefaultCellStyle = { Format = "N0" } });
            dgv_details.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Serials", HeaderText = "Serial", Width = 200 });

            dgv_details.DataSource = _cart;
        }

        private void ToggleState(bool enabled)
        {
            btn_createReceipt.Enabled = !enabled;
            btn_addProduct.Enabled = enabled;
            btn_confirmReceipt.Enabled = enabled;
            btn_cancelReceipt.Enabled = enabled;
            cb_suppliers.Enabled = enabled;
        }

        private string GenerateReceiptCode() => "PN" + DateTime.Now.ToString("yyyyMMddHHmmss");

        private void RefreshGridSummary()
        {
            lbl_totalQty.Text = $"Tổng SL: {_cart.Sum(x => x.Quantity)}";
            lbl_totalAmount.Text = $"Tổng tiền: {_cart.Sum(x => x.TotalCost):N0} đ";
        }

        // ====================== SỰ KIỆN NÚT ======================

        private void btn_createReceipt_Click(object sender, EventArgs e)
        {
            txt_receiptCode.Text = GenerateReceiptCode();
            _cart.Clear();
            ToggleState(true);
            RefreshGridSummary();
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            string code = Microsoft.VisualBasic.Interaction.InputBox("Nhập mã sản phẩm:", "Thêm hàng", "");
            if (string.IsNullOrWhiteSpace(code)) return;

            var product = _productBUS.GetByCode(code);
            if (product == null)
            {
                MessageBox.Show("Không tìm thấy sản phẩm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string qtyStr = Microsoft.VisualBasic.Interaction.InputBox($"Số lượng cho {product.ProductName}:", "Số lượng", "1");
            if (!int.TryParse(qtyStr, out int qty) || qty <= 0) return;

            string priceStr = Microsoft.VisualBasic.Interaction.InputBox("Đơn giá nhập:", "Giá nhập", product.CostPrice.ToString());
            if (!decimal.TryParse(priceStr, out decimal price) || price <= 0) return;

            string serials = product.IsSerialized
                ? Microsoft.VisualBasic.Interaction.InputBox("Nhập Serial (cách nhau bởi ;):", "Serial", "")
                : "";

            _cart.Add(new CartItem
            {
                ProductID = product.ProductID,
                ProductCode = product.ProductCode,
                ProductName = product.ProductName,
                Quantity = qty,
                UnitCost = price,
                Serials = serials
            });

            RefreshGridSummary();
        }

        private void btn_confirmReceipt_Click(object sender, EventArgs e)
        {
            if (_cart.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm ít nhất 1 sản phẩm vào phiếu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Tạo phiếu nhập
                var receipt = new InboundReceiptsDTO
                {
                    InboundCode = txt_receiptCode.Text.Trim(),
                    SupplierID = Convert.ToInt32(cb_suppliers.SelectedValue),
                    UserID = 1,                       // TODO: Sau thay bằng CurrentUser.UserID
                    TotalQuantity = _cart.Sum(x => x.Quantity),
                    TotalAmount = _cart.Sum(x => x.TotalCost),
                    Note = "Nhập kho từ phần mềm"
                };

                // Tạo danh sách chi tiết
                var details = _cart.Select(item => new InboundDetailsDTO
                {
                    ProductID = item.ProductID,
                    Quantity = item.Quantity,
                    UnitCost = item.UnitCost,
                    TotalCost = item.TotalCost
                }).ToList();

                // Thu thập Serial (nếu có)
                List<string> serialList = new List<string>();
                int serialProductID = 0;

                foreach (var item in _cart)
                {
                    if (!string.IsNullOrWhiteSpace(item.Serials))
                    {
                        serialProductID = item.ProductID;
                        var parts = item.Serials.Split(';')
                                               .Select(s => s.Trim())
                                               .Where(s => !string.IsNullOrEmpty(s));
                        serialList.AddRange(parts);
                    }
                }

                // GỌI BUS ĐỂ LƯU VÀO DATABASE
                var result = _inboundBUS.CreateReceipt(
                    receipt,
                    details,
                    serialList.Count > 0 ? serialList : null,
                    serialProductID);

                if (result.success)
                {
                    MessageBox.Show("Phiếu nhập kho đã được lưu thành công vào Database!",
                        "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _cart.Clear();
                    ToggleState(false);
                    RefreshGridSummary();
                }
                else
                {
                    MessageBox.Show("Lưu thất bại: " + result.error, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi nghiêm trọng",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancelReceipt_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hủy phiếu này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _cart.Clear();
                ToggleState(false);
                RefreshGridSummary();
            }
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            try
            {
                var history = _inboundBUS.GetAll();
                if (history == null || history.Count == 0)
                {
                    MessageBox.Show("Chưa có phiếu nhập kho nào.", "Thông báo");
                    return;
                }

                using var form = new Form
                {
                    Text = "Lịch sử phiếu nhập kho",
                    Size = new Size(1300, 700),
                    StartPosition = FormStartPosition.CenterParent
                };

                var dgv = new DataGridView
                {
                    Dock = DockStyle.Fill,
                    ReadOnly = true,
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                    AllowUserToAddRows = false
                };

                dgv.DataSource = history;
                form.Controls.Add(dgv);
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xem lịch sử: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    // ====================== CLASS HỖ TRỢ ======================
    public class CartItem
    {
        public int ProductID { get; set; }
        public string ProductCode { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal UnitCost { get; set; }
        public decimal TotalCost => Quantity * UnitCost;
        public string Serials { get; set; } = string.Empty;
    }
}