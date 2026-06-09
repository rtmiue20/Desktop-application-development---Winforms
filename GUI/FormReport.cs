using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DAL;
using DTO;
using BUS;
using ClosedXML.Excel; // Đưa thư viện Excel vào sử dụng

namespace GUI;

public partial class FormReport : Form
{
    private ReportsBUS _reportsBus = new ReportsBUS();
    private ProductsBUS _productsBus = new ProductsBUS();
    private CustomersBUS _customersBus = new CustomersBUS();

    // Khởi tạo hộp thoại lưu file bằng code (Không cần kéo thả Toolbox)
    private readonly SaveFileDialog saveDialog_Excel = new SaveFileDialog();

    public FormReport()
    {
        InitializeComponent();
        ControlStandardization.ApplyFormStandard(this);
        ApplyStyles();
        LoadReport();
    }

    private void ApplyStyles()
    {
        // Áp dụng chuẩn cho các panel chính
        ControlStandardization.ApplyTopBarPanelStandard(pnl_top);
        ControlStandardization.ApplyStatusPanelStandard(pnl_footer);

        // Áp dụng chuẩn cho DataGridView
        ControlStandardization.ApplyDataGridViewStandard(dgv_listInvoices);

        // Đảm bảo Form có nền trắng
        this.BackColor = Color.White;

        // Cập nhật vị trí các nút trong pnl_top
        ControlStandardization.ApplyTopBarButtonStandard(btn_showReport, ButtonPosition.Add);
        ControlStandardization.ApplyTopBarButtonStandard(btn_excelOut, ButtonPosition.Edit);

        foreach (Control ctrl in pnl_top.Controls)
        {
            if (ctrl is Button btn)
            {
                btn.ForeColor = Color.Black;
                btn.UseVisualStyleBackColor = true;
            }
        }

        // Căn chỉnh bộ lọc trong groupBox1
        groupBox1.Dock = DockStyle.Top;
        groupBox1.Height = 180;
        
        // Sắp xếp các control trong groupBox1 cho gọn gàng
        cbb_dayFill.Location = new Point(12, 25);
        dtp_from.Location = new Point(170, 25);
        label1.Location = new Point(285, 28);
        dtp_to.Location = new Point(330, 25);

        panel3.Dock = DockStyle.Bottom; // Chứa các card thông tin
        panel3.Height = 120;
        panel3.BorderStyle = BorderStyle.None;
        panel3.BackColor = Color.Transparent;

        // Dàn đều các card thông tin trong panel3
        int cardWidth = (this.ClientSize.Width - 40) / 5;
        Control[] cards = { lbl_outCome, lbl_grossProfit, lbl_productSold, lbl_invoiceNum, lbl_warranty };
        for (int i = 0; i < cards.Length; i++)
        {
            if (cards[i] == null) continue; // Skip null controls
            
            cards[i].Width = cardWidth;
            cards[i].Height = 100;
            cards[i].Location = new Point(10 + i * cardWidth, 10);
            cards[i].Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Tinh chỉnh giao diện giống card
            if (cards[i] is Label lbl)
            {
                lbl.Padding = new Padding(5);
                lbl.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                lbl.BackColor = Color.White;
                lbl.BorderStyle = BorderStyle.FixedSingle;
            }
        }
    }

    private void LoadReport()
    {
        DateTime from = dtp_from.Value.Date;
        DateTime to = dtp_to.Value.Date.AddDays(1).AddTicks(-1);

        var summary = _reportsBus.GetSummaryByRange(from, to);
        UpdateCards(summary.revenue, summary.profit, summary.invoiceCount, summary.productCount, summary.warrantyCount);

        var data = GetReportData(from, to);
        LoadTable(data);
        UpdateFooter(from, to);
    }

    private List<object> GetReportData(DateTime from, DateTime to)
    {
        var invoices = _reportsBus.GetInvoicesByRange(from, to);
        var reportList = new List<object>();

        // Load một lần để dùng chung (tối ưu hơn là query trong loop)
        var allProducts = _productsBus.GetAll();
        var allCustomers = _customersBus.GetAll();
        var salesBus = new SalesBUS();

        foreach (var inv in invoices)
        {
            // Lấy chi tiết hóa đơn từ BUS
            var details = salesBus.GetInvoiceDetails(inv.InvoiceID);

            var customer = allCustomers.FirstOrDefault(c => c.CustomerID == inv.CustomerID);

            decimal totalCost = details.Sum(d => d.CostPrice * d.Quantity);
            string productSummary = string.Join(", ", details.Select(d =>
            {
                var product = allProducts.FirstOrDefault(p => p.ProductID == d.ProductID);
                return product != null ? product.ProductName : "Sản phẩm";
            }).ToArray());

            reportList.Add(new
            {
                InvoiceID = inv.InvoiceID,
                InvoiceCode = inv.InvoiceCode,
                SaleDate = inv.SaleDate,
                CustomerName = customer?.FullName ?? "Khách lẻ",
                ProductSummary = productSummary,
                FinalAmount = inv.FinalAmount,
                Profit = inv.FinalAmount - totalCost,
                PaymentMethod = inv.PaymentMethod
            });
        }

        return reportList;
    }

    private void UpdateCards(decimal revenue, decimal profit, int invoiceCount, int productCount, int warrantyCount)
    {
        if (lbl_outCome != null) lbl_outCome.Text = $"{revenue:N0} đ\nDoanh thu";
        if (lbl_grossProfit != null) lbl_grossProfit.Text = $"{profit:N0} đ\nLợi nhuận gộp";
        if (lbl_invoiceNum != null) lbl_invoiceNum.Text = $"{invoiceCount}\nHóa đơn đã xuất";
        if (lbl_productSold != null) lbl_productSold.Text = $"{productCount}\nSản phẩm bán ra";
        if (lbl_warranty != null) lbl_warranty.Text = $"{warrantyCount}\nBảo hành phát sinh";
    }

    private void LoadTable(System.Collections.Generic.List<object> data)
    {
        if (dgv_listInvoices == null) return;

        dgv_listInvoices.Rows.Clear();
        foreach (dynamic item in data)
        {
            int rowIndex = dgv_listInvoices.Rows.Add(
                item.InvoiceCode,
                item.SaleDate.ToString("dd/MM/yyyy HH:mm"),
                item.CustomerName,
                item.ProductSummary,
                $"{item.FinalAmount:N0}",
                $"{item.Profit:N0}",
                item.PaymentMethod
            );

            var row = dgv_listInvoices.Rows[rowIndex];
            if (dgv_listInvoices.Columns.Contains("col_thanhToan"))
            {
                var payCell = row.Cells["col_thanhToan"];
                string paymentMethod = item.PaymentMethod;

                if (paymentMethod == "Tiền mặt")
                {
                    payCell.Style.BackColor = Color.FromArgb(0, 140, 0);
                    payCell.Style.ForeColor = Color.White;
                }
                else
                {
                    payCell.Style.BackColor = Color.FromArgb(0, 102, 204);
                    payCell.Style.ForeColor = Color.White;
                }
            }
        }
    }

    private void UpdateFooter(DateTime from, DateTime to)
    {
        if (lbl_footerLeft != null)
        {
            lbl_footerLeft.Text = $"Báo cáo từ ngày: {from:dd/MM/yyyy} đến {to:dd/MM/yyyy}";
            lbl_footerLeft.BackColor = Color.Transparent;
            lbl_footerLeft.ForeColor = Color.Black;
        }

        if (lbl_footerRight != null)
        {
            lbl_footerRight.BackColor = Color.Transparent;
            lbl_footerRight.ForeColor = Color.Black;
            // Tính tỉ lệ lợi nhuận nếu cần
        }
    }

    private void btn_xemBaocao_Click(object sender, EventArgs e)
    {
        LoadReport();
    }

    // --- LOGIC XUẤT EXCEL CHÍNH THỨC (ĐÃ BỔ SUNG ĐỊNH DẠNG SỐ & KẺ BẢNG) ---
    private void btn_xuatExcel_Click(object sender, EventArgs e)
    {
        if (dgv_listInvoices == null || dgv_listInvoices.Rows.Count == 0)
        {
            MessageBox.Show("Không có dữ liệu báo cáo để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // Cấu hình hộp thoại lưu file
        saveDialog_Excel.Filter = "Excel Files|*.xlsx";
        saveDialog_Excel.Title = "Lưu báo cáo doanh thu";
        saveDialog_Excel.FileName = $"BaoCaoDoanhThu_{DateTime.Now:ddMMyyyy}.xlsx";

        if (saveDialog_Excel.ShowDialog() == DialogResult.OK)
        {
            try
            {
                using (XLWorkbook workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("DoanhThu");

                    // 1. Tạo Tiêu đề cột từ DataGridView thực tế
                    for (int i = 0; i < dgv_listInvoices.Columns.Count; i++)
                    {
                        var headerCell = worksheet.Cell(1, i + 1);
                        headerCell.Value = dgv_listInvoices.Columns[i].HeaderText;
                        headerCell.Style.Font.Bold = true;
                        headerCell.Style.Fill.BackgroundColor = XLColor.LightGray;
                        headerCell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        headerCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    }

                    // 2. Đổ dữ liệu THỰC TẾ từ các hàng của DataGridView vào Excel
                    int excelRowIndex = 2;
                    for (int i = 0; i < dgv_listInvoices.Rows.Count; i++)
                    {
                        var row = dgv_listInvoices.Rows[i];
                        if (row.IsNewRow) continue;

                        for (int j = 0; j < dgv_listInvoices.Columns.Count; j++)
                        {
                            var cellValue = row.Cells[j].Value?.ToString() ?? "";
                            var excelCell = worksheet.Cell(excelRowIndex, j + 1);

                            excelCell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                            string headerText = dgv_listInvoices.Columns[j].HeaderText.ToLower();
                            string columnName = dgv_listInvoices.Columns[j].Name.ToLower();

                            if (headerText.Contains("tiền") || headerText.Contains("giá") || columnName.Contains("tien"))
                            {
                                if (decimal.TryParse(cellValue, out decimal moneyValue))
                                {
                                    excelCell.Value = moneyValue;
                                    excelCell.Style.NumberFormat.Format = "#,##0\" đ\"";
                                }
                                else
                                {
                                    excelCell.Value = cellValue;
                                }
                            }
                            else
                            {
                                excelCell.Value = cellValue;
                            }
                        }
                        excelRowIndex++;
                    }

                    worksheet.Columns().AdjustToContents();
                    workbook.SaveAs(saveDialog_Excel.FileName);

                    MessageBox.Show("Xuất báo cáo Excel thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất Excel (Đảm bảo file không bị mở ở ứng dụng khác):\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void label1_Click(object sender, EventArgs e) { }
    private void pnl_Top_Paint(object sender, PaintEventArgs e) { }

    private void FormReport_Load(object sender, EventArgs e)
    {
        // Stub method - actual loading is done in constructor via LoadReport()
    }
}