using System;
using System.Data;
using System.Windows.Forms;
// Giả định Namespace chứa các lớp xử lý nghiệp vụ của bạn
// using BUS; 

namespace GUI
{
    public partial class FormSell : Form
    {
        // Lưu trữ thông tin khách hàng và mã khuyến mãi đang áp dụng cho hóa đơn này
        private string currentCustomerPhone = "KH000"; // Mặc định là khách vãng lai
        private string currentPromoCode = "";
        private decimal discountAmount = 0;

        public FormSell()
        {
            InitializeComponent();
            cbo_paymentMethod.SelectedIndex = 0;
        }

        // ── Chọn Khách Hàng từ FormGuest ─────────────────────────────────────────
        private void btn_Customer_Click(object sender, EventArgs e)
        {
            // Mở FormGuest dưới dạng Dialog để chọn khách hàng
            using (FormGuest frm = new FormGuest())
            {
                // Hiện nút "Chọn" hoặc bắt sự kiện double click (đã cấu hình trong FormGuest)
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    currentCustomerPhone = frm.SelectedCustomerPhone;
                    // Hiển thị tên khách hàng lên giao diện (Ví dụ giả định bạn có lbl_CustomerName)
                    // lbl_CustomerName.Text = $"Khách hàng: {frm.SelectedCustomerName}";

                    MessageBox.Show($"Đã áp dụng khách hàng: {frm.SelectedCustomerName}", "Thông báo");
                    RecalcTotal(); // Tính lại tiền nếu loại khách hàng có ưu đãi
                }
            }
        }

        // ── Mã khuyến mãi (Gọi BUS kiểm tra thực tế) ─────────────────────────────
        private void btn_Promotion_Click(object sender, EventArgs e)
        {
            string promoCode = Microsoft.VisualBasic.Interaction.InputBox(
                "Nhập mã khuyến mãi:", "Khuyến mãi", "");

            if (string.IsNullOrEmpty(promoCode)) return;

            // NGUYÊN TẮC: Gọi tầng BUS để kiểm tra mã trong Database xem hợp lệ không
            // Giả sử hàm này trả về số tiền giảm hoặc % giảm giá
            // decimal discount = PromotionsBUS.ApplyPromoCode(promoCode, GetSubTotal());

            // DEMO gọi hàm (bạn hãy đổi tên hàm cho khớp với BUS của bạn):
            bool isValid = true; // PromotionsBUS.CheckValid(promoCode); 

            if (isValid)
            {
                currentPromoCode = promoCode;
                discountAmount = 50000; // Giả sử giảm 50k, thay bằng hàm lấy từ BUS: PromotionsBUS.GetDiscountValue(promoCode);

                lbl_discount.Text = $"Giảm giá: -{discountAmount:N0} đ";
                RecalcTotal();
            }
            else
            {
                MessageBox.Show("Mã khuyến mãi không tồn tại hoặc đã hết hạn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Thanh toán ───────────────────────────────────────────────────────────
        private void btn_Payment_Click(object sender, EventArgs e)
        {
            if (dgv_cart.Rows.Count == 0)
            {
                MessageBox.Show("Giỏ hàng đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            groupBox4.Visible = true; // Hiện panel chọn phương thức thanh toán
        }

        // ── Xác nhận thanh toán (Đẩy dữ liệu vào DB qua BUS) ─────────────────────
        private void btn_ConfirmPayment_Click(object sender, EventArgs e)
        {
            try
            {
                string paymentMethod = cbo_paymentMethod.Text;
                decimal finalTotal = GetSubTotal() - discountAmount;

                // NGUYÊN TẮC: Tạo đối tượng Invoice và gọi SalesBUS để xử lý nghiệp vụ lưu DB
                // var invoice = new SalesInvoice {
                //     CustomerPhone = currentCustomerPhone,
                //     PaymentMethod = paymentMethod,
                //     TotalAmount = finalTotal,
                //     PromoCode = currentPromoCode
                // };
                // List<SalesDetail> details = ... lấy dữ liệu từ dgv_cart ...

                // Gọi hàm lưu:
                // bool success = SalesBUS.Checkout(invoice, details);
                bool isSuccess = true; // Giả định BUS chạy thành công

                if (isSuccess)
                {
                    MessageBox.Show($"Thanh toán thành công!\nPhương thức: {paymentMethod}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Lưu hóa đơn thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi hệ thống");
            }
        }

        // ── In hóa đơn ───────────────────────────────────────────────────────────
        private void btn_Print_Click(object sender, EventArgs e)
        {
            // Gọi lớp hỗ trợ in ấn hoặc cấu hình PrintDocument tại đây
            MessageBox.Show("Đang kết nối máy in xuất hóa đơn...", "In hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ── Hủy hóa đơn ─────────────────────────────────────────────────────────
        private void btn_CancelInvoice_Click(object sender, EventArgs e)
        {
            if (dgv_cart.Rows.Count == 0) return;

            var result = MessageBox.Show("Bạn có chắc muốn hủy toàn bộ giỏ hàng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                ResetForm();
        }

        // ── Hóa đơn hôm nay ─────────────────────────────────────────────────────
        private void btnTodayInvoice_Click(object sender, EventArgs e)
        {
            // Mở form lịch sử hóa đơn (Truyền tham số ngày hôm nay nếu cần)
            // FormInvoiceHistory frm = new FormInvoiceHistory(DateTime.Today);
            // frm.ShowDialog();
        }

        // ── Click ô xóa trong DataGridView ───────────────────────────────────────
        private void dgv_Cart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgv_cart.Columns[e.ColumnIndex].Name == "col_Remove")
            {
                dgv_cart.Rows.RemoveAt(e.RowIndex);
                RecalcTotal();
            }
        }

        // ── Helper: Lấy tổng tiền tạm tính từ Grid ──────────────────────────────
        private decimal GetSubTotal()
        {
            decimal subtotal = 0;
            foreach (DataGridViewRow row in dgv_cart.Rows)
            {
                if (decimal.TryParse(row.Cells["col_TotalPrice"].Value?.ToString(), out decimal val))
                    subtotal += val;
            }
            return subtotal;
        }

        // ── Tính lại tổng tiền ───────────────────────────────────────────────────
        private void RecalcTotal()
        {
            decimal subtotal = GetSubTotal();
            decimal finalTotal = subtotal - discountAmount;
            if (finalTotal < 0) finalTotal = 0;

            lbl_subTotal.Text = $"Tạm tính:    {subtotal:N0} đ";
            lbl_discount.Text = $"Giảm giá:   - {discountAmount:N0} đ";
            lbl_finalTotal.Text = $"Tổng cộng:  {finalTotal:N0} đ";
        }

        // ── Reset form ───────────────────────────────────────────────────────────
        private void ResetForm()
        {
            dgv_cart.Rows.Clear();
            currentCustomerPhone = "KH000";
            currentPromoCode = "";
            discountAmount = 0;

            lbl_subTotal.Text = "Tạm tính:    0 đ";
            lbl_discount.Text = "Giảm giá:    - 0 đ";
            lbl_finalTotal.Text = "Tổng cộng:  0 đ";
            cbo_paymentMethod.SelectedIndex = 0;
            groupBox4.Visible = false;
        }
    }
}