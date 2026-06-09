using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class FormSell : Form
    {
        private readonly PrintDocument printDocument = new PrintDocument();
        private readonly PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
        private readonly ProductsBUS _productsBUS = new ProductsBUS();
        private readonly SalesBUS _salesBUS = new SalesBUS();

        // Biến lưu tổng tiền khi người dùng click chọn sản phẩm
        private decimal clickedSelectionTotal = 0m;
        private bool selectionMode = false; // true: labels hiển thị theo click-selection; false: hiển thị theo tổng giỏ hàng

        // Biến lưu khuyến mãi hiện tại
        private decimal currentDiscountPercent = 0m; // ví dụ 10 => 10%
        private decimal currentDiscountAmount = 0m;

        public FormSell()
        {
            InitializeComponent();
            cbo_paymentMethod.SelectedIndex = 0;

            printDocument.PrintPage += PrintDocument_PrintPage;

            // Gắn sự kiện
            txt_searchProduct.KeyDown += txt_SearchProduct_KeyDown;
            dgv_cart.CellClick += dgv_cart_CellClick;
            dgv_cart.CellContentClick += dgv_Cart_CellContentClick;
        }

        private void FormSell_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            LoadProductsToGrid();
            txt_searchProduct.Focus();
        }

        private void SetupDataGridView()
        {
            dgv_cart.AllowUserToAddRows = false;
            dgv_cart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_cart.MultiSelect = false;
            dgv_cart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_cart.RowHeadersVisible = false;

            dgv_cart.Columns.Clear();

            dgv_cart.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "col_productName",
                HeaderText = "Tên SP",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgv_cart.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "col_productId",
                HeaderText = "Mã SP",
                Width = 160
            });

            dgv_cart.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "col_quantity",
                HeaderText = "SL",
                Width = 70
            });

            var colUnitPrice = new DataGridViewTextBoxColumn
            {
                Name = "col_unitPrice",
                HeaderText = "Đơn giá",
                Width = 130,
                DefaultCellStyle = { Format = "N0" }
            };
            dgv_cart.Columns.Add(colUnitPrice);

            var colTotalPrice = new DataGridViewTextBoxColumn
            {
                Name = "col_totalPrice",
                HeaderText = "Thành tiền",
                Width = 140,
                DefaultCellStyle = { Format = "N0" }
            };
            dgv_cart.Columns.Add(colTotalPrice);

            dgv_cart.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "col_remove",
                HeaderText = "Xóa",
                Text = "X",
                UseColumnTextForButtonValue = true,
                Width = 60
            });
        }

        private void LoadProductsToGrid()
        {
            // Nếu bạn muốn giỏ hàng mặc định rỗng khi mở form, comment phần load sản phẩm mẫu này.
            var products = _productsBUS.GetAll();
            dgv_cart.Rows.Clear();
            foreach (var p in products)
            {
                dgv_cart.Rows.Add(p.ProductName, p.ProductID, 1, p.UnitPrice, p.UnitPrice);
            }

            // Khởi tạo hiển thị
            clickedSelectionTotal = 0;
            selectionMode = false;
            currentDiscountPercent = 0;
            currentDiscountAmount = 0;
            RecalcTotal();
        }

        // Thêm sản phẩm bằng mã (Enter)
        private void txt_SearchProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            e.Handled = true;

            string searchCode = txt_searchProduct.Text.Trim();
            if (string.IsNullOrEmpty(searchCode)) return;

            try
            {
                var product = _productsBUS.GetByCode(searchCode);
                if (product == null)
                {
                    MessageBox.Show($"Không tìm thấy sản phẩm có mã: {searchCode}", "Không tìm thấy",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_searchProduct.Clear();
                    return;
                }

                // Kiểm tra đã có trong giỏ chưa (so sánh theo ProductID)
                foreach (DataGridViewRow row in dgv_cart.Rows)
                {
                    if (row.Cells["col_productId"].Value?.ToString() == product.ProductID.ToString())
                    {
                        int qty = Convert.ToInt32(row.Cells["col_quantity"].Value ?? 1);
                        qty++;
                        row.Cells["col_quantity"].Value = qty;
                        row.Cells["col_totalPrice"].Value = qty * product.UnitPrice;

                        // Khi thay đổi giỏ hàng, reset selectionMode để tránh nhầm lẫn
                        clickedSelectionTotal = 0;
                        selectionMode = false;
                        RecalcTotal();
                        txt_searchProduct.Clear();
                        return;
                    }
                }

                // Thêm mới
                dgv_cart.Rows.Add(product.ProductName, product.ProductID, 1, product.UnitPrice, product.UnitPrice);

                clickedSelectionTotal = 0;
                selectionMode = false;
                RecalcTotal();
                txt_searchProduct.Clear();
                txt_searchProduct.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm sản phẩm: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Click vào dòng: cộng đơn giá vào clickedSelectionTotal
        private void dgv_cart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgv_cart.Rows.Count == 0) return;

            // Nếu click vào nút Xóa thì bỏ qua (xử lý ở CellContentClick)
            if (dgv_cart.Columns[e.ColumnIndex].Name == "col_remove") return;

            var row = dgv_cart.Rows[e.RowIndex];
            if (row.IsNewRow) return;

            if (decimal.TryParse(row.Cells["col_unitPrice"].Value?.ToString(), out decimal unitPrice))
            {
                // Cộng dồn đơn giá
                clickedSelectionTotal += unitPrice;
                selectionMode = true;
                // Khi user bắt đầu chọn bằng click, discount vẫn áp dụng trên giá trị đang hiển thị
                UpdateDiscountAndLabels();
            }
        }

        // Xử lý nút Xóa: xóa dòng và trừ tiền khỏi tạm tính
        private void dgv_Cart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgv_cart.Columns[e.ColumnIndex].Name != "col_remove") return;

            // Lấy giá trị thành tiền của dòng trước khi xóa
            decimal rowTotal = 0;
            var cellVal = dgv_cart.Rows[e.RowIndex].Cells["col_totalPrice"].Value;
            if (cellVal != null)
                decimal.TryParse(cellVal.ToString(), out rowTotal);

            // Xóa dòng khỏi DataGridView
            dgv_cart.Rows.RemoveAt(e.RowIndex);

            // Nếu đang ở selectionMode thì trừ clickedSelectionTotal
            if (selectionMode)
            {
                clickedSelectionTotal = Math.Max(0, clickedSelectionTotal - rowTotal);
                UpdateDiscountAndLabels();
            }
            else
            {
                // Nếu không ở selectionMode thì tính lại tổng từ các dòng còn lại
                RecalcTotal();
            }
        }

        private void btn_Payment_Click(object sender, EventArgs e)
        {
            if (dgv_cart.Rows.Count == 0)
            {
                MessageBox.Show("Giỏ hàng đang trống!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            grp_paymentMethod.Visible = true;
        }

        private decimal CalculateSubtotal()
        {
            decimal subtotal = 0;
            foreach (DataGridViewRow row in dgv_cart.Rows)
            {
                if (row.IsNewRow) continue;
                if (decimal.TryParse(row.Cells["col_totalPrice"].Value?.ToString(), out decimal val))
                    subtotal += val;
            }
            return subtotal;
        }

        // Áp dụng mã khuyến mãi: nếu mã là "KM10" => 10%, "KM5" => 5%, hoặc nhập "10%" sẽ parse
        private void btn_Promotion_Click(object sender, EventArgs e)
        {
            string promoCode = Microsoft.VisualBasic.Interaction.InputBox(
                "Nhập mã khuyến mãi (ví dụ KM10 hoặc 10%):", "Khuyến mãi", "");

            if (string.IsNullOrEmpty(promoCode)) return;

            // Xác định phần trăm giảm
            decimal percent = 0m;
            promoCode = promoCode.Trim().ToUpper();

            if (promoCode.EndsWith("%"))
            {
                // ví dụ "10%"
                var num = promoCode.TrimEnd('%');
                if (decimal.TryParse(num, out decimal p)) percent = p;
            }
            else if (promoCode.StartsWith("KM"))
            {
                // ví dụ "KM10"
                var num = promoCode.Substring(2);
                if (decimal.TryParse(num, out decimal p)) percent = p;
            }
            else if (decimal.TryParse(promoCode, out decimal p2))
            {
                // nếu người dùng nhập "10" hiểu là 10%
                percent = p2;
            }

            if (percent <= 0)
            {
                MessageBox.Show("Mã khuyến mãi không hợp lệ hoặc không có giảm giá.", "Khuyến mãi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            currentDiscountPercent = percent;

            // Tính discount amount dựa trên subtotal hiện tại (lưu ý selectionMode)
            decimal baseAmount = selectionMode ? clickedSelectionTotal : CalculateSubtotal();
            currentDiscountAmount = Math.Round(baseAmount * currentDiscountPercent / 100m, 0);

            // Cập nhật label hiển thị
            UpdateDiscountAndLabels();

            MessageBox.Show($"Áp dụng mã {promoCode}: giảm {currentDiscountPercent}% => {currentDiscountAmount:N0} đ", "Khuyến mãi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_ConfirmPayment_Click(object sender, EventArgs e)
        {
            if (dgv_cart.Rows.Count == 0)
            {
                MessageBox.Show("Giỏ hàng đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal baseSubtotal = selectionMode ? clickedSelectionTotal : CalculateSubtotal();
            // Nếu có discountPercent thì recalc discountAmount trên baseSubtotal
            currentDiscountAmount = Math.Round(baseSubtotal * currentDiscountPercent / 100m, 0);
            decimal finalAmount = Math.Max(0, baseSubtotal - currentDiscountAmount);

            var invoice = new SalesInvoicesDTO
            {
                InvoiceCode = Guid.NewGuid().ToString().Substring(0, 8),
                UserID = CurrentUser.UserID,
                TotalAmount = baseSubtotal,
                DiscountAmount = currentDiscountAmount,
                FinalAmount = finalAmount,
                PaymentMethod = cbo_paymentMethod.Text
            };

            var details = new List<SalesDetailsDTO>();
            foreach (DataGridViewRow row in dgv_cart.Rows)
            {
                if (row.IsNewRow) continue;

                if (!int.TryParse(row.Cells["col_productId"].Value?.ToString(), out int productId))
                    continue;

                int qty = Convert.ToInt32(row.Cells["col_quantity"].Value ?? 1);
                decimal unitPrice = Convert.ToDecimal(row.Cells["col_unitPrice"].Value ?? 0);
                decimal costPrice = unitPrice;

                details.Add(new SalesDetailsDTO
                {
                    ProductID = productId,
                    Quantity = qty,
                    UnitPrice = unitPrice,
                    CostPrice = costPrice,
                    SerialID = null
                });
            }

            var result = _salesBUS.Checkout(invoice, details);

            if (result.success)
            {
                MessageBox.Show("Thanh toán thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var printResult = MessageBox.Show("Bạn có muốn in hóa đơn cho khách hàng không?", "In hóa đơn",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (printResult == DialogResult.Yes)
                    ExecutePrint();

                ResetForm();
            }
            else
            {
                MessageBox.Show("Lỗi: " + result.error, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            if (dgv_cart.Rows.Count == 0)
            {
                MessageBox.Show("Giỏ hàng trống, không có gì để in!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ExecutePrint();
        }

        private void ExecutePrint()
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font fontTitle = new Font("Courier New", 18, FontStyle.Bold);
            Font fontHeader = new Font("Courier New", 14, FontStyle.Bold);
            Font fontRegular = new Font("Courier New", 12);
            Font fontItalic = new Font("Courier New", 12, FontStyle.Italic);

            float fontHeight = fontRegular.GetHeight();
            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphics.DrawString("CỬA HÀNG CỦA BẢO", fontTitle, new SolidBrush(Color.Black), startX + 50, startY);
            offset += (int)fontTitle.GetHeight() + 10;

            graphics.DrawString("HÓA ĐƠN THANH TOÁN", fontHeader, new SolidBrush(Color.Black), startX + 50, startY + offset);
            offset += (int)fontHeader.GetHeight() + 10;

            graphics.DrawString($"Ngày in: {DateTime.Now:dd/MM/yyyy HH:mm}", fontRegular, new SolidBrush(Color.Black), startX, startY + offset);
            offset += (int)fontHeight + 15;

            graphics.DrawString("---------------------------------------", fontRegular, new SolidBrush(Color.Black), startX, startY + offset);
            offset += (int)fontHeight + 10;

            graphics.DrawString("Tên món", fontRegular, Brushes.Black, startX, startY + offset);
            graphics.DrawString("SL", fontRegular, Brushes.Black, startX + 180, startY + offset);
            graphics.DrawString("Thành tiền", fontRegular, Brushes.Black, startX + 230, startY + offset);
            offset += (int)fontHeight + 10;
            graphics.DrawString("---------------------------------------", fontRegular, new SolidBrush(Color.Black), startX, startY + offset);
            offset += (int)fontHeight + 10;

            foreach (DataGridViewRow row in dgv_cart.Rows)
            {
                if (row.IsNewRow) continue;

                string name = row.Cells["col_productName"]?.Value?.ToString() ?? "Sản phẩm";
                string qty = row.Cells["col_quantity"]?.Value?.ToString() ?? "1";
                string totalStr = row.Cells["col_totalPrice"]?.Value?.ToString() ?? "0";

                if (name.Length > 15) name = name.Substring(0, 15) + "...";

                if (decimal.TryParse(totalStr, out decimal totalValue))
                    totalStr = totalValue.ToString("N0");

                graphics.DrawString(name, fontRegular, Brushes.Black, startX, startY + offset);
                graphics.DrawString(qty, fontRegular, Brushes.Black, startX + 180, startY + offset);
                graphics.DrawString(totalStr, fontRegular, Brushes.Black, startX + 230, startY + offset);

                offset += (int)fontHeight + 5;
            }

            graphics.DrawString("---------------------------------------", fontRegular, new SolidBrush(Color.Black), startX, startY + offset);
            offset += (int)fontHeight + 10;

            graphics.DrawString(lbl_subTotal.Text, fontRegular, Brushes.Black, startX, startY + offset);
            offset += (int)fontHeight + 5;

            graphics.DrawString(lbl_discount.Text, fontRegular, Brushes.Black, startX, startY + offset);
            offset += (int)fontHeight + 15;

            graphics.DrawString(lbl_finalTotal.Text, fontTitle, Brushes.Black, startX, startY + offset);
            offset += (int)fontTitle.GetHeight() + 30;

            graphics.DrawString("CẢM ƠN QUÝ KHÁCH VÀ HẸN GẶP LẠI!", fontItalic, Brushes.Black, startX + 10, startY + offset);
        }

        private void btn_CancelInvoice_Click(object sender, EventArgs e)
        {
            if (dgv_cart.Rows.Count == 0) return;

            var result = MessageBox.Show("Bạn có chắc muốn hủy hóa đơn?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                ResetForm();
        }

        // Mở FormReport khi bấm "Hóa đơn hôm nay"
        private void btnTodayInvoice_Click(object sender, EventArgs e)
        {
            var frm = new FormReport();
            frm.ShowDialog();
        }

        // Mở FormGuest khi bấm "Khách Hàng"
        private void btn_Customer_Click(object sender, EventArgs e)
        {
            var frm = new FormGuest();
            frm.ShowDialog();
        }

        private void RecalcTotal()
        {
            // Nếu đang ở selectionMode (người dùng đã click để cộng dồn), không override labels
            if (selectionMode)
                return;

            decimal subtotal = 0;
            foreach (DataGridViewRow row in dgv_cart.Rows)
            {
                if (row.IsNewRow) continue;
                if (decimal.TryParse(row.Cells["col_totalPrice"].Value?.ToString(), out decimal val))
                    subtotal += val;
            }

            // Áp dụng khuyến mãi nếu có
            currentDiscountAmount = Math.Round(subtotal * currentDiscountPercent / 100m, 0);
            decimal final = Math.Max(0, subtotal - currentDiscountAmount);

            lbl_subTotal.Text = $"Tạm tính:    {subtotal:N0} đ";
            lbl_discount.Text = $"Giảm giá:    - {currentDiscountAmount:N0} đ ({currentDiscountPercent}% )";
            lbl_finalTotal.Text = $"Tổng cộng:  {final:N0} đ";
        }

        // Cập nhật labels theo selection (click) và áp dụng khuyến mãi nếu có
        private void UpdateDiscountAndLabels()
        {
            decimal baseAmount = clickedSelectionTotal;
            currentDiscountAmount = Math.Round(baseAmount * currentDiscountPercent / 100m, 0);
            decimal final = Math.Max(0, baseAmount - currentDiscountAmount);

            lbl_subTotal.Text = $"Tạm tính:    {baseAmount:N0} đ";
            lbl_discount.Text = $"Giảm giá:    - {currentDiscountAmount:N0} đ ({currentDiscountPercent}% )";
            lbl_finalTotal.Text = $"Tổng cộng:  {final:N0} đ";
        }

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

            clickedSelectionTotal = 0;
            selectionMode = false;
            currentDiscountPercent = 0;
            currentDiscountAmount = 0;
        }
    }
}
