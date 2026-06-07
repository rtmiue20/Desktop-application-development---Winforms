using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormSell : Form
    {
        public FormSell()
        {
            InitializeComponent();
            btn_payment.Click += btn_Payment_Click;
            btn_print.Click += btn_Print_Click;
            btn_cancelInvoice.Click += btn_CancelInvoice_Click;
            btn_todayInvoice.Click += btnTodayInvoice_Click;
            btn_customer.Click += btn_Customer_Click;
            btn_promotion.Click += btn_Promotion_Click;
            btn_confirmPayment.Click += btn_ConfirmPayment_Click;
            cbo_paymentMethod.SelectedIndex = 0;
        }

        // Thanh toán
        private void btn_Payment_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Vui lòng chọn phương thức thanh toán!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // In hóa đơn
        private void btn_Print_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Đang in hóa đơn...",
                "In hóa đơn",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // Hủy hóa đơn
        private void btn_CancelInvoice_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn hủy hóa đơn?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                dgv_cart.Rows.Clear();

                lbl_SubTotal.Text = "Tạm tính: 0 VNĐ";
                lbl_Discount.Text = "Giảm giá: 0 VNĐ";
                lbl_FinalTotal.Text = "Tổng cộng: 0 VNĐ";

                MessageBox.Show("Đã hủy hóa đơn!");
            }
        }

        // Hóa đơn hôm nay
        private void btnTodayInvoice_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Hiển thị danh sách hóa đơn hôm nay.",
                "Hóa đơn hôm nay",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // Khách hàng
        private void btn_Customer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Mở danh sách khách hàng.",
                "Khách hàng",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // Mã khuyến mãi
        private void btn_Promotion_Click(object sender, EventArgs e)
        {
            string promoCode = Microsoft.VisualBasic.Interaction.InputBox(
                "Nhập mã khuyến mãi:",
                "Khuyến mãi",
                "");

            if (!string.IsNullOrEmpty(promoCode))
            {
                MessageBox.Show(
                    $"Đã áp dụng mã: {promoCode}",
                    "Khuyến mãi");
            }
        }

        // Xác nhận thanh toán
        private void btn_ConfirmPayment_Click(object sender, EventArgs e)
        {
            string paymentMethod = cbo_paymentMethod.Text;

            MessageBox.Show(
                $"Thanh toán thành công!\nPhương thức: {paymentMethod}",
                "Thành công",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void dgv_Cart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Print_Click_1(object sender, EventArgs e)
        {

        }

        private void grp_Action_Enter(object sender, EventArgs e)
        {

        }

        private void btn_cancelInvoice_Click_1(object sender, EventArgs e)
        {

        }
    }
}