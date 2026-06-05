using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormSell : Form
    {
        double total = 0;

        public FormSell()
        {
            InitializeComponent();

            // Gán sự kiện
            btn_Search.Click += btn_Search_Click;
            btn_Payment.Click += btn_Payment_Click;
            btn_Print.Click += btn_Print_Click;
        }

        // ==========================
        // TÌM KIẾM SẢN PHẨM
        // ==========================
        private void btn_Search_Click(object sender, EventArgs e)
        {
            string maSP = txt_ProductID.Text.Trim();

            if (string.IsNullOrEmpty(maSP))
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm!");
                return;
            }

            // Demo dữ liệu sản phẩm
            string tenSP = "Laptop Dell";
            double donGia = 15000000;
            int soLuong = 1;

            double thanhTien = donGia * soLuong;

            dgv_Cart.Rows.Add(
                maSP,
                tenSP,
                donGia,
                soLuong,
                thanhTien
            );

            total += thanhTien;
            txt_Total.Text = total.ToString("N0");
        }

        // ==========================
        // THANH TOÁN
        // ==========================
        private void btn_Payment_Click(object sender, EventArgs e)
        {
            double discount = 0;

            double.TryParse(txt_Discount.Text, out discount);

            double final = total - discount;

            if (final < 0)
                final = 0;

            txt_Final.Text = final.ToString("N0");

            MessageBox.Show(
                "Thanh toán thành công!\nThành tiền: " +
                final.ToString("N0") + " VNĐ",
                "Thông báo"
            );
        }

        // ==========================
        // IN HÓA ĐƠN
        // ==========================
        private void btn_Print_Click(object sender, EventArgs e)
        {
            string hoaDon =
                "===== HÓA ĐƠN =====\n" +
                "Tổng tiền: " + txt_Total.Text + " VNĐ\n" +
                "Giảm giá: " + txt_Discount.Text + " VNĐ\n" +
                "Thành tiền: " + txt_Final.Text + " VNĐ";

            MessageBox.Show(hoaDon, "Hóa đơn");
        }
        private void dgv_Product_CellDoubleClick(object sender,
    DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maSP =
                    dgv_Product.Rows[e.RowIndex].Cells[0].Value.ToString();

                string tenSP =
                    dgv_Product.Rows[e.RowIndex].Cells[1].Value.ToString();

                double gia =
                    Convert.ToDouble(
                        dgv_Product.Rows[e.RowIndex].Cells[2].Value);

                dgv_Cart.Rows.Add(
                    maSP,
                    tenSP,
                    gia,
                    1,
                    gia);

                total += gia;

                txt_Total.Text = total.ToString("N0");
            }
        }
    }
}