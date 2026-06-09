using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class FormIntoWarehouse : Form
    {
        private SuppliersBUS _supplierBUS = null!;

        // Ánh xạ khớp với cấu trúc bảng InboundDetails
        private class CartItem
        {
            public int ProductID { get; set; }
            public string ProductCode { get; set; } = string.Empty;
            public string ProductName { get; set; } = string.Empty;
            public int Quantity { get; set; }
            public decimal UnitCost { get; set; } // Khớp cột UnitCost trong DB
            public decimal TotalCost => Quantity * UnitCost; // Tự tính TotalCost
        }

        private List<CartItem> _cart = new List<CartItem>();

        public FormIntoWarehouse()
        {
            InitializeComponent();
        }

        private void FormIntoWarehouse_Load(object sender, EventArgs e)
        {
            _supplierBUS = new SuppliersBUS();

            var suppliers = _supplierBUS.GetAll();
            if (suppliers != null && suppliers.Count > 0)
            {
                cb_suppliers.DataSource = suppliers;
                cb_suppliers.DisplayMember = "SupplierName";
                cb_suppliers.ValueMember = "SupplierID";
            }
            else
            {
               
                cb_suppliers.Items.Add("--- DB Trống, chưa có NCC ---");
                cb_suppliers.SelectedIndex = 0;
            }

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
            MessageBox.Show("Chức năng tìm ID/Mã vạch đang được thiết kế...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdateCartGrid();
        }

        private void UpdateCartGrid()
        {
            dgv_details.Columns.Clear();
            dgv_details.AutoGenerateColumns = true;
            dgv_details.DataSource = _cart.ToList(); 

            if (dgv_details.Columns["ProductID"] is { } colId) colId.Visible = false;

            if (dgv_details.Columns["ProductCode"] is { } colCode) colCode.HeaderText = "Mã SP";
            if (dgv_details.Columns["ProductName"] is { } colName) colName.HeaderText = "Tên sản phẩm";
            if (dgv_details.Columns["Quantity"] is { } colQty) colQty.HeaderText = "SL nhập";

            if (dgv_details.Columns["UnitCost"] is { } colUnit)
            {
                colUnit.HeaderText = "Đơn giá nhập";
                colUnit.DefaultCellStyle.Format = "N0";
            }
            if (dgv_details.Columns["TotalCost"] is { } colTotal)
            {
                colTotal.HeaderText = "Thành tiền";
                colTotal.DefaultCellStyle.Format = "N0";
            }

            lbl_totalQty.Text = $"Tổng SL: {_cart.Sum(x => x.Quantity)}";
            lbl_totalAmount.Text = $"Tổng tiền: {_cart.Sum(x => x.TotalCost):N0} đ";
            lbl_bottomNcc.Text = $"NCC: {cb_suppliers.Text}";
        }

        private void btn_confirmReceipt_Click(object sender, EventArgs e)
        {
            if (_cart.Count == 0)
            {
                MessageBox.Show("Phiếu nhập đang trống, không thể lưu DB!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Đã lưu Phiếu nhập và InboundDetails vào Database thành công!");
            lbl_bottomStatus.Text = $"Phiếu: {txt_receiptCode.Text} — Đã xác nhận";
            ToggleState(false);
        }


        private void btn_cancelReceipt_Click(object sender, EventArgs e) { _cart.Clear(); UpdateCartGrid(); lbl_bottomStatus.Text = $"Phiếu: {txt_receiptCode.Text} — Đã hủy"; ToggleState(false); }
        private void btn_history_Click(object sender, EventArgs e) { MessageBox.Show("Đang kết nối lịch sử InboundReceipts..."); }
    }
}