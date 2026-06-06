using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormIntoWarehouse : Form
    {
        private class CartItem
        {
            // Khởi tạo string.Empty để triệt tiêu cảnh báo CS8618
            public string ProductCode { get; set; } = string.Empty;
            public string ProductName { get; set; } = string.Empty;
            public int Quantity { get; set; }
            public decimal UnitCost { get; set; }
            public decimal TotalCost => Quantity * UnitCost;
            public string SerialDisplay { get; set; } = string.Empty;
        }

        private List<CartItem> _cart = new List<CartItem>();

        public FormIntoWarehouse()
        {
            InitializeComponent();
        }

        private void FormIntoWarehouse_Load(object sender, EventArgs e)
        {
            var listNCC = new List<dynamic>
            {
                new { Id = 1, Name = "Apple VN" },
                new { Id = 2, Name = "Samsung VN" }
            };
            cb_suppliers.DataSource = listNCC;
            cb_suppliers.DisplayMember = "Name";
            cb_suppliers.ValueMember = "Id";

            ToggleState(false);
            txt_receiptCode.Text = "PN" + DateTime.Now.ToString("yyyyMMdd");
        }

        private void ToggleState(bool enabled)
        {
            cb_suppliers.Enabled = enabled;
            btn_addProduct.Enabled = enabled;
            btn_confirmReceipt.Enabled = enabled;
            btn_cancelReceipt.Enabled = enabled;
            btn_createReceipt.Enabled = !enabled;
        }

        private void btn_createReceipt_Click(object sender, EventArgs e)
        {
            ToggleState(true);
            _cart.Clear();
            UpdateCartGrid();
            txt_receiptCode.Text = "PN" + DateTime.Now.ToString("yyyyMMddHHmmss");
            lbl_bottomStatus.Text = $"Phiếu: {txt_receiptCode.Text} — Đang lập";
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            if (_cart.Count == 0)
            {
                _cart.Add(new CartItem { ProductCode = "SP001", ProductName = "iPhone 15 Pro", Quantity = 5, UnitCost = 24000000, SerialDisplay = "📱 5 serials" });
                _cart.Add(new CartItem { ProductCode = "SP004", ProductName = "AirPods Pro 2", Quantity = 10, UnitCost = 4500000, SerialDisplay = "—" });
            }
            UpdateCartGrid();
        }

        private void UpdateCartGrid()
        {
            dgv_details.DataSource = null;
            dgv_details.DataSource = _cart;

            // Kiểm tra cột tồn tại trước khi thao tác để chống lỗi CS8602
            if (dgv_details.Columns["ProductCode"] != null) dgv_details.Columns["ProductCode"].HeaderText = "Mã SP";
            if (dgv_details.Columns["ProductName"] != null) dgv_details.Columns["ProductName"].HeaderText = "Tên sản phẩm";
            if (dgv_details.Columns["Quantity"] != null) dgv_details.Columns["Quantity"].HeaderText = "SL nhập";
            if (dgv_details.Columns["UnitCost"] != null)
            {
                dgv_details.Columns["UnitCost"].HeaderText = "Đơn giá nhập";
                dgv_details.Columns["UnitCost"].DefaultCellStyle.Format = "N0";
            }
            if (dgv_details.Columns["TotalCost"] != null)
            {
                dgv_details.Columns["TotalCost"].HeaderText = "Thành tiền";
                dgv_details.Columns["TotalCost"].DefaultCellStyle.Format = "N0";
            }
            if (dgv_details.Columns["SerialDisplay"] != null) dgv_details.Columns["SerialDisplay"].HeaderText = "Serial (nếu có)";

            lbl_totalQty.Text = $"Tổng SL: {_cart.Sum(x => x.Quantity)}";
            lbl_totalAmount.Text = $"Tổng tiền: {_cart.Sum(x => x.TotalCost):N0} đ";
            lbl_bottomNcc.Text = $"NCC: {cb_suppliers.Text ?? string.Empty}";
        }

        private void btn_confirmReceipt_Click(object sender, EventArgs e)
        {
            if (_cart.Count == 0) return;
            MessageBox.Show("Xác nhận nhập kho thành công!");
            lbl_bottomStatus.Text = $"Phiếu: {txt_receiptCode.Text} — Đã xác nhận";
            ToggleState(false);
        }

        private void btn_cancelReceipt_Click(object sender, EventArgs e)
        {
            _cart.Clear();
            UpdateCartGrid();
            lbl_bottomStatus.Text = $"Phiếu: {txt_receiptCode.Text} — Đã hủy";
            ToggleState(false);
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mở lịch sử nhập...");
        }

        private void txt_receiptCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_receiptCode_Click(object sender, EventArgs e)
        {

        }
    }
}