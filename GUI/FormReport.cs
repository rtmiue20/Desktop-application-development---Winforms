using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DAL;
using Dapper;
using DTO;
using ClosedXML.Excel; // Đưa thư viện Excel vào sử dụng

namespace GUI;

public partial class FormReport : Form
{
    // Khởi tạo hộp thoại lưu file bằng code (Không cần kéo thả Toolbox)
    private readonly SaveFileDialog saveDialog_Excel = new SaveFileDialog();

    public FormReport()
    {
        InitializeComponent();
        LoadReport();
    }

    private void LoadReport()
    {
        DateTime from = dtp_from.Value.Date;
        DateTime to = dtp_to.Value.Date;

        var summary = GetSummary_Direct(from, to);
        UpdateCards(summary.revenue, summary.profit, summary.invoiceCount, summary.productCount, summary.warrantyCount);

        var data = GetReportData_Direct(from, to);
        LoadTable(data);
        UpdateFooter(from, to);
    }

    private (decimal revenue, decimal profit, int invoiceCount, int productCount, int warrantyCount) GetSummary_Direct(DateTime from, DateTime to)
    {
        using (IDbConnection db = DatabaseHelper.GetConnection())
        {
            string sqlInvoices = "SELECT * FROM SalesInvoices WHERE DATE(SaleDate) BETWEEN DATE(@from) AND DATE(@to)";
            var invoices = db.Query<SalesInvoicesDTO>(sqlInvoices, new { from, to }).ToList();

            string sqlWarranties = "SELECT COUNT(*) FROM WarrantyClaims WHERE DATE(ReceiveDate) BETWEEN DATE(@from) AND DATE(@to)";
            int warrantyCount = db.ExecuteScalar<int>(sqlWarranties, new { from, to });

            decimal revenue = 0, cost = 0;
            int productCount = 0;

            foreach (var inv in invoices)
            {
                revenue += inv.FinalAmount;
                string sqlDetails = "SELECT * FROM SalesDetails WHERE InvoiceID = @InvoiceID";
                var details = db.Query<SalesDetailsDTO>(sqlDetails, new { inv.InvoiceID }).ToList();
                cost += details.Sum(d => d.CostPrice * d.Quantity);
                productCount += details.Sum(d => d.Quantity);
            }

            return (revenue, revenue - cost, invoices.Count, productCount, warrantyCount);
        }
    }

    private List<object> GetReportData_Direct(DateTime from, DateTime to)
    {
        using (IDbConnection db = DatabaseHelper.GetConnection())
        {
            string sqlInvoices = "SELECT * FROM SalesInvoices WHERE DATE(SaleDate) BETWEEN DATE(@from) AND DATE(@to)";
            var invoices = db.Query<SalesInvoicesDTO>(sqlInvoices, new { from, to }).ToList();
            
            var reportList = new List<object>();
            var allProducts = db.Query<ProductsDTO>("SELECT * FROM Products").ToList();

            foreach (var inv in invoices)
            {
                string sqlDetails = "SELECT * FROM SalesDetails WHERE InvoiceID = @InvoiceID";
                var details = db.Query<SalesDetailsDTO>(sqlDetails, new { inv.InvoiceID }).ToList();
                
                string sqlCustomer = "SELECT * FROM Customers WHERE CustomerID = @CustomerID";
                var customer = inv.CustomerID.HasValue 
                    ? db.QueryFirstOrDefault<CustomersDTO>(sqlCustomer, new { CustomerID = inv.CustomerID.Value }) 
                    : null;

                decimal totalCost = details.Sum(d => d.CostPrice * d.Quantity);
                string productSummary = string.Join(", ", details.Select(d => {
                    var product = allProducts.FirstOrDefault(p => p.ProductID == d.ProductID);
                    return product != null ? product.ProductName : "Sản phẩm";
                }));

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
    }

    private void UpdateCards(decimal revenue, decimal profit, int invoiceCount, int productCount, int warrantyCount)
    {
        if (lbl_doanhThu != null) lbl_doanhThu.Text = $"{revenue:N0} đ\nDoanh thu";
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
            lbl_footerLeft.Text = $"Báo cáo từ ngày: {from:dd/MM/yyyy} đến {to:dd/MM/yyyy}";
        
        if (lbl_footerRight != null)
        {
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
                        headerCell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin; // Kẻ khung tiêu đề
                        headerCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center; // Căn giữa tiêu đề
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
                            
                            // Kẻ khung mỏng cho từng ô dữ liệu
                            excelCell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                            // Lấy tên Header để nhận diện cột tiền
                            string headerText = dgv_listInvoices.Columns[j].HeaderText.ToLower();
                            string columnName = dgv_listInvoices.Columns[j].Name.ToLower();

                            // Tự động ép kiểu Số nếu cột có chữ "tiền", "giá", "tổng" để Excel dùng được hàm SUM()
                            if (headerText.Contains("tiền") || headerText.Contains("giá") || columnName.Contains("tien"))
                            {
                                if (decimal.TryParse(cellValue, out decimal moneyValue))
                                {
                                    excelCell.Value = moneyValue;
                                    excelCell.Style.NumberFormat.Format = "#,##0\" đ\""; // Thêm dấu phẩy hàng nghìn
                                }
                                else
                                {
                                    excelCell.Value = cellValue; // Nếu không phải số (bị lỗi chữ) thì in bình thường
                                }
                            }
                            else
                            {
                                excelCell.Value = cellValue;
                            }
                        }
                        excelRowIndex++;
                    }

                    // Căn chỉnh độ rộng tự động cho các cột Excel đẹp mắt
                    worksheet.Columns().AdjustToContents();

                    // 3. Lưu file thực tế vào máy tính
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
}