using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DTO;
using DAL;
using BUS;

namespace GUI
{
    public partial class FormSell : Form
    {
        // Khởi tạo các DAL để xử lý trực tiếp nghiệp vụ thanh toán
        private readonly ProductsDAL _productsDAL = new ProductsDAL();
        private readonly ProductItemsDAL _productItemsDAL = new ProductItemsDAL();
        private readonly SalesInvoicesDAL _invoicesDAL = new SalesInvoicesDAL();
        private readonly SalesDetailsDAL _detailsDAL = new SalesDetailsDAL();

        private decimal currentDiscountPercent = 0m; // Ví dụ 10 => 10%

        public FormSell()
        {
            InitializeComponent();
        }

        private void FormSell_Load(object sender, EventArgs e)
        {
            // Thiết lập mặc định
            cbo_paymentMethod.SelectedIndex = 0;
            ResetForm();
        }

        // ─────────────────────────────────────────────
        // 1. TÌM KIẾM VÀ THÊM SẢN PHẨM VÀO GIỎ HÀNG
        // ─────────────────────────────────────────────
        private void txt_searchProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string keyword = txt_searchProduct.Text.Trim();
                if (string.IsNullOrEmpty(keyword)) return;

                try
                {
                    // Giả lập tìm kiếm theo Serial (ItemCode) trước
                    var serialItem = _productItemsDAL.GetByItemCode(keyword);
                    if (serialItem != null && serialItem.Status == "Trong kho")
                    {
                        // Tìm thấy máy theo Serial -> Thêm vào giỏ
                        var product = _productsDAL.GetAll().FirstOrDefault(p => p.ProductID == serialItem.ProductID);
                        if (product != null)
                        {
                            AddProductToCart(product.ProductID, product.ProductName, serialItem.ItemID, serialItem.ItemCode, 1, product.UnitPrice);
                        }
                    }
                    else
                    {
                        // Tìm theo ProductCode (Sản phẩm không có Serial, ví dụ phụ kiện)
                        var product = _productsDAL.GetByCode(keyword);
                        if (product != null)
                        {
                            AddProductToCart(product.ProductID, product.ProductName, null, "N/A", 1, product.UnitPrice);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sản phẩm hoặc Serial đã được bán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    
                    txt_searchProduct.Clear();
                    txt_searchProduct.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddProductToCart(int productId, string productName, int? serialId, string serialNumber, int qty, decimal price)
        {
            // Nếu sản phẩm không có Serial, kiểm tra xem đã có trong giỏ chưa để cộng dồn số lượng
            if (serialId == null)
            {
                foreach (DataGridViewRow row in dgv_cart.Rows)
                {
                    if (row.Cells["col_productsId"].Value != null && Convert.ToInt32(row.Cells["col_productsId"].Value) == productId)
                    {
                        int currentQty = Convert.ToInt32(row.Cells["col_quantity"].Value);
                        row.Cells["col_quantity"].Value = currentQty + qty;
                        row.Cells["col_totalPrice"].Value = (currentQty + qty) * price;
                        UpdateCartTotals();
                        return;
                    }
                }
            }

            // Nếu là máy có Serial hoặc chưa có trong giỏ, thêm dòng mới
            dgv_cart.Rows.Add(
                productId,
                productName,
                serialId,
                serialNumber,
                qty,
                price,
                qty * price
            );
            UpdateCartTotals();
        }

        // ─────────────────────────────────────────────
        // 2. TÍNH TOÁN TỔNG TIỀN
        // ─────────────────────────────────────────────
        private void UpdateCartTotals()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgv_cart.Rows)
            {
                if (!row.IsNewRow && row.Cells["col_totalPrice"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["col_totalPrice"].Value);
                }
            }

            decimal discountAmount = Math.Round(total * currentDiscountPercent / 100m, 0);
            decimal finalTotal = Math.Max(0, total - discountAmount);

            lbl_subTotal.Text = total.ToString("N0");
            lbl_discount.Text = discountAmount.ToString("N0");
            lbl_finalTotal.Text = finalTotal.ToString("N0");
        }

        private decimal ParseCurrency(string value)
        {
            string clean = value.Replace(",", "").Replace(".", "").Replace(" đ", "").Replace("đ", "").Trim();
            if (decimal.TryParse(clean, out decimal result)) return result;
            return 0m;
        }

        // ─────────────────────────────────────────────
        // 3. XỬ LÝ THANH TOÁN (LỖI ĐƯỢC FIX TẠI ĐÂY)
        // ─────────────────────────────────────────────
        private void btn_confirmPayment_Click(object sender, EventArgs e)
        {
            ProcessCheckout();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            ProcessCheckout();
        }

        private void ProcessCheckout()
        {
            if (dgv_cart.Rows.Count == 0)
            {
                MessageBox.Show("Giỏ hàng đang trống. Vui lòng quét mã sản phẩm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hộp thoại xác nhận trước khi thanh toán
            var confirm = MessageBox.Show($"Xác nhận thu tiền: {lbl_finalTotal.Text} đ ?", "Thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                // Bước 1: Tạo đối tượng Hóa đơn
                SalesInvoicesDTO invoice = new SalesInvoicesDTO
                {
                    InvoiceCode = "HD" + DateTime.Now.ToString("ddMMyyHHmmss"),
                    UserID = 1, // Giả lập UserID đang đăng nhập
                    CustomerID = null, // Khách lẻ
                    TotalAmount = ParseCurrency(lbl_subTotal.Text),
                    DiscountAmount = ParseCurrency(lbl_discount.Text),
                    FinalAmount = ParseCurrency(lbl_finalTotal.Text),
                    PaymentMethod = cbo_paymentMethod.SelectedItem?.ToString() ?? "Tiền mặt",
                    SaleDate = DateTime.Now
                };

                // Bước 2: Lưu Hóa đơn vào DB và lấy mã InvoiceID
                int invoiceId = _invoicesDAL.Insert(invoice);

                if (invoiceId > 0)
                {
                    // Bước 3: Lưu chi tiết hóa đơn & Cập nhật kho
                    foreach (DataGridViewRow row in dgv_cart.Rows)
                    {
                        if (row.IsNewRow) continue;

                        int productId = Convert.ToInt32(row.Cells["col_productsId"].Value);
                        int qty = Convert.ToInt32(row.Cells["col_quantity"].Value);
                        decimal price = Convert.ToDecimal(row.Cells["col_unitPrice"].Value);

                        int? serialId = null;
                        if (row.Cells["col_serialId"].Value != null)
                        {
                            serialId = Convert.ToInt32(row.Cells["col_serialId"].Value);
                        }

                        SalesDetailsDTO detail = new SalesDetailsDTO
                        {
                            InvoiceID = invoiceId,
                            ProductID = productId,
                            SerialID = serialId,
                            Quantity = qty,
                            UnitPrice = price,
                            CostPrice = price * 0.8m // Tạm tính giá vốn giả lập (Dự án thật cần query lại từ DB)
                        };

                        _detailsDAL.Insert(detail);

                        // Bước 4: Chuyển trạng thái Serial thành "Đã bán"
                        if (serialId.HasValue && serialId.Value > 0)
                        {
                            _productItemsDAL.UpdateStatus(serialId.Value, "Đã bán");
                        }
                    }

                    MessageBox.Show($"Thanh toán thành công!\nMã hóa đơn: {invoice.InvoiceCode}\nTổng thu: {lbl_finalTotal.Text} đ", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Lỗi hệ thống: Không thể khởi tạo hóa đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình thanh toán:\n" + ex.Message, "Lỗi Nghiệp Vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─────────────────────────────────────────────
        // 4. TIỆN ÍCH UI
        // ─────────────────────────────────────────────
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (dgv_cart.Rows.Count > 0)
            {
                var confirm = MessageBox.Show("Bạn có chắc muốn hủy giỏ hàng hiện tại?", "Hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes) ResetForm();
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            dgv_cart.Rows.Clear();
            lbl_subTotal.Text = "0";
            lbl_discount.Text = "0";
            lbl_finalTotal.Text = "0";
            cbo_paymentMethod.SelectedIndex = 0;
            txt_searchProduct.Clear();
            txt_searchProduct.Focus();
        }
        
        // Sự kiện xóa dòng trong giỏ hàng
        private void dgv_cart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Nếu muốn thêm nút XÓA trên DataGridView, xử lý ở đây
        }
        
        private void dgv_Cart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}