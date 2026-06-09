using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI;

public partial class FormSell : Form
{
    // Khởi tạo các công cụ in ấn bằng code (Không cần kéo thả Toolbox)
    private readonly PrintDocument printDocument = new PrintDocument();
    private readonly PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
    private readonly ProductsBUS _productsBUS = new ProductsBUS();

    public FormSell()
    {

        InitializeComponent();
        cbo_paymentMethod.SelectedIndex = 0;

        // Gắn sự kiện vẽ hóa đơn cho PrintDocument
        printDocument.PrintPage += PrintDocument_PrintPage;

        // Gắn sự kiện tìm kiếm sản phẩm
        txt_searchProduct.KeyDown += txt_SearchProduct_KeyDown;
    }

    private void FormSell_Load(object sender, EventArgs e)
    {
        // Setup DataGridView columns nếu cần
        dgv_cart.AllowUserToAddRows = false;
        dgv_cart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgv_cart.MultiSelect = false;

        // Load dữ liệu cần thiết từ DB (sản phẩm, autocomplete...)
        LoadData();
    }

    // Load dữ liệu hỗ trợ cho FormSell (autocomplete, cấu hình lưới nếu Designer chưa tạo)
    private void LoadData()
    {
        try
        {
            var products = _productsBUS.GetAll();

            // Thiết lập AutoComplete cho ô tìm kiếm dựa trên mã và tên sản phẩm
            var ac = new AutoCompleteStringCollection();
            if (products != null)
            {
                foreach (var p in products)
                {
                    if (!string.IsNullOrWhiteSpace(p.ProductCode) && !ac.Contains(p.ProductCode))
                        ac.Add(p.ProductCode);

                    if (!string.IsNullOrWhiteSpace(p.ProductName) && !ac.Contains(p.ProductName))
                        ac.Add(p.ProductName);
                }
            }

            txt_searchProduct.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_searchProduct.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_searchProduct.AutoCompleteCustomSource = ac;

            // Nếu Designer không khởi tạo các cột cần thiết cho dgv_cart, tạo thay thế ở runtime.
            // Các tên cột phải khớp với phần còn lại của FormSell (ví dụ: tham chiếu bởi tên).
            if (dgv_cart.Columns.Count == 0)
            {
                dgv_cart.Columns.Clear();

                var colProductName = new DataGridViewTextBoxColumn
                {
                    Name = "col_productName",
                    HeaderText = "Tên sản phẩm",
                    ReadOnly = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                };
                dgv_cart.Columns.Add(colProductName);

                var colSerial = new DataGridViewTextBoxColumn
                {
                    Name = "col_serielNumber",
                    HeaderText = "Serial / Mã",
                    Width = 150,
                    ReadOnly = true
                };
                dgv_cart.Columns.Add(colSerial);

                var colQty = new DataGridViewTextBoxColumn
                {
                    Name = "col_quantity",
                    HeaderText = "SL",
                    Width = 80
                };
                dgv_cart.Columns.Add(colQty);

                var colUnit = new DataGridViewTextBoxColumn
                {
                    Name = "col_unitPrice",
                    HeaderText = "Đơn giá",
                    Width = 120,
                    ReadOnly = true
                };
                dgv_cart.Columns.Add(colUnit);

                var colTotal = new DataGridViewTextBoxColumn
                {
                    Name = "col_totalPrice",
                    HeaderText = "Thành tiền",
                    Width = 140,
                    ReadOnly = true
                };
                dgv_cart.Columns.Add(colTotal);

                var colRemove = new DataGridViewButtonColumn
                {
                    Name = "col_remove",
                    HeaderText = "Xóa",
                    Text = "X",
                    UseColumnTextForButtonValue = true,
                    Width = 60
                };
                dgv_cart.Columns.Add(colRemove);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Không thể tải dữ liệu sản phẩm: {ex.Message}", "Lỗi tải dữ liệu",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // ── Tìm kiếm sản phẩm khi nhập Serial hoặc Mã SP ────────────────────────
    private void txt_SearchProduct_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode != Keys.Return) return;
        e.Handled = true;

        string searchCode = txt_searchProduct.Text.Trim();
        if (string.IsNullOrEmpty(searchCode))
        {
            MessageBox.Show("Vui lòng nhập Mã SP hoặc Serial!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            // Tìm sản phẩm theo mã
            var product = _productsBUS.GetByCode(searchCode);
            if (product == null)
            {
                MessageBox.Show("Không tìm thấy sản phẩm!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_searchProduct.Clear();
                txt_searchProduct.Focus();
                return;
            }

            // Kiểm tra xem sản phẩm đã có trong giỏ chưa
            int existingRowIndex = -1;
            foreach (DataGridViewRow row in dgv_cart.Rows)
            {
                if (row.Cells["col_serielNumber"].Value?.ToString() == searchCode)
                {
                    existingRowIndex = dgv_cart.Rows.IndexOf(row);
                    break;
                }
            }

            if (existingRowIndex >= 0)
            {
                // Nếu đã có, tăng số lượng
                DataGridViewRow existingRow = dgv_cart.Rows[existingRowIndex];
                int currentQty = int.Parse(existingRow.Cells["col_quantity"].Value?.ToString() ?? "0");
                existingRow.Cells["col_quantity"].Value = currentQty + 1;

                // Cập nhật lại thành tiền
                decimal unitPrice = decimal.Parse(existingRow.Cells["col_unitPrice"].Value?.ToString() ?? "0");
                existingRow.Cells["col_totalPrice"].Value = (currentQty + 1) * unitPrice;
            }
            else
            {
                // Thêm dòng mới vào giỏ
                dgv_cart.Rows.Add(
                    product.ProductName,          // col_productName
                    searchCode,                   // col_serielNumber
                    1,                            // col_quantity
                    product.UnitPrice.ToString("N0"),  // col_unitPrice
                    product.UnitPrice.ToString("N0"),  // col_totalPrice
                    "X"                           // col_remove
                );
            }

            // Tính lại tổng tiền
            RecalcTotal();

            // Xóa ô tìm kiếm để tìm sản phẩm tiếp theo
            txt_searchProduct.Clear();
            txt_searchProduct.Focus();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi: {ex.Message}", "Thất bại",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // ── Thanh toán ───────────────────────────────────────────────────────────
    private void btn_Payment_Click(object sender, EventArgs e)
    {
        if (dgv_cart.Rows.Count == 0)
        {
            MessageBox.Show("Giỏ hàng đang trống!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        // Hiện panel thanh toán (grp_paymentMethod đã có sẵn)
        grp_paymentMethod.Visible = true;
    }

    // ── Xác nhận thanh toán ───────────────────────────────────────────────────
    private void btn_ConfirmPayment_Click(object sender, EventArgs e)
    {
        string paymentMethod = cbo_paymentMethod.Text;
        MessageBox.Show(
            $"Thanh toán thành công!\nPhương thức: {paymentMethod}",
            "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

        // TODO: gọi SalesBUS.Checkout() ở đây trước khi xóa dữ liệu

        // QUY TRÌNH CHUẨN: Hỏi in hóa đơn TRƯỚC KHI reset form dữ liệu
        var printResult = MessageBox.Show("Bạn có muốn in hóa đơn cho khách hàng không?", "In hóa đơn",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (printResult == DialogResult.Yes)
        {
            ExecutePrint(); // Gọi hàm mở màn hình in hóa đơn
        }

        // Sau khi xử lý in ấn xong mới reset toàn bộ form về trống
        ResetForm();
    }

    // ── Nút bấm in hóa đơn độc lập ──────────────────────────────────────────
    private void btn_Print_Click(object sender, EventArgs e)
    {
        if (dgv_cart.Rows.Count == 0)
        {
            MessageBox.Show("Giỏ hàng trống, không có gì để in!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        ExecutePrint();
    }

    // Tách hàm kích hoạt lệnh in ra riêng để tái sử dụng
    private void ExecutePrint()
    {
        printPreviewDialog.Document = printDocument;
        printPreviewDialog.ShowDialog();
    }

    // ── HÀM VẼ (THIẾT KẾ) BỐ CỤC HÓA ĐƠN ────────────────────────────────────
    private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
    {
        Graphics graphics = e.Graphics;

        // Khởi tạo các font chữ
        Font fontTitle = new Font("Courier New", 18, FontStyle.Bold);
        Font fontHeader = new Font("Courier New", 14, FontStyle.Bold);
        Font fontRegular = new Font("Courier New", 12);
        Font fontItalic = new Font("Courier New", 12, FontStyle.Italic);

        float fontHeight = fontRegular.GetHeight();
        int startX = 10;
        int startY = 10;
        int offset = 40;

        // 1. Header (Tên cửa hàng, Ngày giờ)
        graphics.DrawString("CỬA HÀNG CỦA BẢO", fontTitle, new SolidBrush(Color.Black), startX + 50, startY);
        offset += (int)fontTitle.GetHeight() + 10;

        graphics.DrawString("HÓA ĐƠN THANH TOÁN", fontHeader, new SolidBrush(Color.Black), startX + 50, startY + offset);
        offset += (int)fontHeader.GetHeight() + 10;

        graphics.DrawString($"Ngày in: {DateTime.Now:dd/MM/yyyy HH:mm}", fontRegular, new SolidBrush(Color.Black), startX, startY + offset);
        offset += (int)fontHeight + 15;

        graphics.DrawString("---------------------------------------", fontRegular, new SolidBrush(Color.Black), startX, startY + offset);
        offset += (int)fontHeight + 10;

        // Tiêu đề cột của hóa đơn giấy
        graphics.DrawString("Tên món", fontRegular, Brushes.Black, startX, startY + offset);
        graphics.DrawString("SL", fontRegular, Brushes.Black, startX + 180, startY + offset);
        graphics.DrawString("Thành tiền", fontRegular, Brushes.Black, startX + 230, startY + offset);
        offset += (int)fontHeight + 10;
        graphics.DrawString("---------------------------------------", fontRegular, new SolidBrush(Color.Black), startX, startY + offset);
        offset += (int)fontHeight + 10;

        // 2. Lặp qua DataGridView giỏ hàng thực tế (dgv_cart)
        foreach (DataGridViewRow row in dgv_cart.Rows)
        {
            if (row.IsNewRow) continue;

            string name = row.Cells["col_productName"]?.Value?.ToString() ?? "Sản phẩm";
            string qty = row.Cells["col_quantity"]?.Value?.ToString() ?? "1";
            string totalStr = row.Cells["col_totalPrice"]?.Value?.ToString() ?? "0";

            // Cắt ngắn tên nếu quá dài
            if (name.Length > 15) name = name.Substring(0, 15) + "...";

            // Định dạng tiền tệ
            if (decimal.TryParse(totalStr, out decimal totalValue))
                totalStr = totalValue.ToString("N0");

            graphics.DrawString(name, fontRegular, Brushes.Black, startX, startY + offset);
            graphics.DrawString(qty, fontRegular, Brushes.Black, startX + 180, startY + offset);
            graphics.DrawString(totalStr, fontRegular, Brushes.Black, startX + 230, startY + offset);

            offset += (int)fontHeight + 5;
        }

        graphics.DrawString("---------------------------------------", fontRegular, new SolidBrush(Color.Black), startX, startY + offset);
        offset += (int)fontHeight + 10;

        // 3. Tổng tiền
        graphics.DrawString(lbl_subTotal.Text, fontRegular, Brushes.Black, startX, startY + offset);
        offset += (int)fontHeight + 5;

        graphics.DrawString(lbl_discount.Text, fontRegular, Brushes.Black, startX, startY + offset);
        offset += (int)fontHeight + 15;

        graphics.DrawString(lbl_finalTotal.Text, fontTitle, Brushes.Black, startX, startY + offset);
        offset += (int)fontTitle.GetHeight() + 30;

        // 4. Footer
        graphics.DrawString("CẢM ƠN QUÝ KHÁCH VÀ HẸN GẶP LẠI!", fontItalic, Brushes.Black, startX + 10, startY + offset);
    }

    // ── Hủy hóa đơn ─────────────────────────────────────────────────────────
    private void btn_CancelInvoice_Click(object sender, EventArgs e)
    {
        if (dgv_cart.Rows.Count == 0) return;

        var result = MessageBox.Show("Bạn có chắc muốn hủy hóa đơn?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
            ResetForm();
    }

    // ── Hóa đơn hôm nay ─────────────────────────────────────────────────────
    private void btnTodayInvoice_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Hiển thị danh sách hóa đơn hôm nay.",
            "Hóa đơn hôm nay", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    // ── Khách hàng ───────────────────────────────────────────────────────────
    private void btn_Customer_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Mở danh sách khách hàng.",
            "Khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    // ── Mã khuyến mãi ────────────────────────────────────────────────────────
    private void btn_Promotion_Click(object sender, EventArgs e)
    {
        string promoCode = Microsoft.VisualBasic.Interaction.InputBox(
            "Nhập mã khuyến mãi:", "Khuyến mãi", "");

        if (!string.IsNullOrEmpty(promoCode))
        {
            MessageBox.Show($"Đã áp dụng mã: {promoCode}", "Khuyến mãi");
            lbl_discount.Text = $"Giảm giá: -{promoCode}";
        }
    }

    // ── Click ô xóa trong DataGridView ───────────────────────────────────────
    private void dgv_Cart_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        if (dgv_cart.Columns[e.ColumnIndex].Name == "col_remove")
        {
            dgv_cart.Rows.RemoveAt(e.RowIndex);
            RecalcTotal();
        }
    }

    // ── Tính lại tổng tiền ───────────────────────────────────────────────────
    private void RecalcTotal()
    {
        decimal subtotal = 0;
        foreach (DataGridViewRow row in dgv_cart.Rows)
        {
            if (decimal.TryParse(row.Cells["col_totalPrice"].Value?.ToString(), out decimal val))
                subtotal += val;
        }
        lbl_subTotal.Text = $"Tạm tính:    {subtotal:N0} đ";
        lbl_discount.Text = "Giảm giá:    - 0 đ";
        lbl_finalTotal.Text = $"Tổng cộng:  {subtotal:N0} đ";
    }

    // ── Reset form sau khi thanh toán / hủy ─────────────────────────────────
    private void ResetForm()
    {
        dgv_cart.Rows.Clear();
        lbl_subTotal.Text = "Tạm tính:    0 đ";
        lbl_discount.Text = "Giảm giá:    - 0 đ";
        lbl_finalTotal.Text = "Tổng cộng:  0 đ";
        cbo_paymentMethod.SelectedIndex = 0;
        grp_paymentMethod.Visible = false;
        txt_searchProduct.Clear();
        txt_searchProduct.Focus();
    }
}   