using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BUS;
using DAL;
using DTO;
using ClosedXML.Excel;

namespace GUI;

public partial class FormReport : Form
{
    private readonly ReportsBUS   _reportsBus   = new ReportsBUS();
    private readonly ProductsBUS  _productsBus  = new ProductsBUS();
    private readonly CustomersBUS _customersBus = new CustomersBUS();
    private readonly SalesDetailsDAL _detailDAL = new SalesDetailsDAL();

    private readonly SaveFileDialog _saveDialog = new SaveFileDialog();

    public FormReport()
    {
        InitializeComponent();
        LoadData(); // Gọi hàm load data khi mở form
    }

    // ─────────────────────────────────────────────
    // HÀM LOADDATA CHÍNH THỨC — NẠP THẲNG VÀO .DATASOURCE
    // ─────────────────────────────────────────────
    private void LoadData()
    {
        DateTime from = dtp_from.Value.Date;
        DateTime to   = dtp_to.Value.Date.AddDays(1).AddTicks(-1);

        // 1. Lấy dữ liệu từ tầng BUS
        var invoices = _reportsBus.GetInvoicesByRange(from, to);
        if (invoices.Count == 0)
        {
            dgv_listInvoices.DataSource = null; // Xóa sạch bảng nếu không có data
            UpdateCards(0, 0, 0, 0, 0);
            UpdateFooter(from, to, 0, 0);
            return;
        }

        // 2. Gom dữ liệu chi tiết (tối ưu hiệu năng)
        var allDetails = invoices.SelectMany(inv => _detailDAL.GetByInvoice(inv.InvoiceID)).ToList();
        var allProducts  = _productsBus.GetAll().ToDictionary(p => p.ProductID, p => p.ProductName);
        var allCustomers = _customersBus.GetAll().ToDictionary(c => c.CustomerID, c => c.FullName);

        // 3. Tính toán các con số tổng quan cho thẻ KPI Cards
        decimal revenue      = invoices.Sum(i => i.FinalAmount);
        decimal cost         = allDetails.Sum(d => d.CostPrice * d.Quantity);
        decimal profit       = revenue - cost;
        int     invoiceCount = invoices.Count;
        int     productCount = allDetails.Sum(d => d.Quantity);

        UpdateCards(revenue, profit, invoiceCount, productCount, 0);

        // 4. BIẾN ĐỔI DỮ LIỆU THÀNH MỘT DANH SÁCH SẠCH ĐỂ NẠP VÀO DATAGRIDVIEW
        var detailsByInvoice = allDetails.GroupBy(d => d.InvoiceID).ToDictionary(g => g.Key, g => g.ToList());

        var reportDataSource = invoices.Select(inv => {
            var details = detailsByInvoice.ContainsKey(inv.InvoiceID) ? detailsByInvoice[inv.InvoiceID] : new List<SalesDetailsDTO>();
            string customerName = inv.CustomerID.HasValue && allCustomers.ContainsKey(inv.CustomerID.Value) ? allCustomers[inv.CustomerID.Value] : "Khách lẻ";
            string productSummary = string.Join(", ", details.Select(d => allProducts.ContainsKey(d.ProductID) ? allProducts[d.ProductID] : "SP").Distinct());
            
            decimal totalCost   = details.Sum(d => d.CostPrice * d.Quantity);
            decimal rowProfit   = inv.FinalAmount - totalCost;

            // Trả về đối tượng có các thuộc tính khớp với DataPropertyName ở file thiết kế
            return new {
                InvoiceCode    = inv.InvoiceCode,
                SaleDate       = inv.SaleDate.ToString("dd/MM/yyyy HH:mm"),
                CustomerName   = customerName,
                ProductSummary = productSummary,
                FinalAmount    = $"{inv.FinalAmount:N0}",
                RowProfit      = $"{rowProfit:N0}",
                PaymentMethod  = inv.PaymentMethod
            };
        }).ToList();

        // 5. ĐỔ DATA VÀO BẢNG CHỈ VỚI 1 DÒNG LỆNH
        dgv_listInvoices.DataSource = reportDataSource;

        // 6. Sau khi lên data thì đổi màu sắc trạng thái thanh toán
        FormatGridRows();

        decimal profitRate = revenue > 0 ? Math.Round(profit / revenue * 100, 1) : 0;
        UpdateFooter(from, to, revenue, profitRate);
    }

    // ─────────────────────────────────────────────
    // HÀM ĐỊNH DẠNG MÀU SẮC CHO BẢNG DỮ LIỆU
    // ─────────────────────────────────────────────
    private void FormatGridRows()
    {
        dgv_listInvoices.RowHeadersVisible  = false;
        dgv_listInvoices.AllowUserToAddRows = false;
        dgv_listInvoices.ReadOnly           = true;
        dgv_listInvoices.SelectionMode      = DataGridViewSelectionMode.FullRowSelect;

        for (int i = 0; i < dgv_listInvoices.Rows.Count; i++)
        {
            var row = dgv_listInvoices.Rows[i];
            if (row.IsNewRow) continue;

            if (dgv_listInvoices.Columns.Contains("col_thanhToan"))
            {
                var payCell = row.Cells["col_thanhToan"];
                string paymentMethod = payCell.Value?.ToString() ?? "";

                if (paymentMethod == "Tiền mặt")
                { 
                    payCell.Style.BackColor = Color.FromArgb(0, 140, 0);   
                    payCell.Style.ForeColor = Color.White; 
                }
                else if (!string.IsNullOrEmpty(paymentMethod))
                { 
                    payCell.Style.BackColor = Color.FromArgb(0, 102, 204); 
                    payCell.Style.ForeColor = Color.White; 
                }
            }
        }
    }

    // ─────────────────────────────────────────────
    // CẬP NHẬT CARDS
    // ─────────────────────────────────────────────
    private void UpdateCards(decimal revenue, decimal profit,
                             int invoiceCount, int productCount, int warrantyCount)
    {
        lbl_outCome.Text     = $"{revenue:N0} đ\nDoanh thu";
        lbl_grossProfit.Text = $"{profit:N0} đ\nLợi nhuận gộp";
        lbl_invoiceNum.Text  = $"{invoiceCount}\nHóa đơn đã xuất";
        lbl_productSold.Text = $"{productCount}\nSản phẩm bán ra";
        lbl_warranty.Text    = $"{warrantyCount}\nBảo hành phát sinh";
    }

    // ─────────────────────────────────────────────
    // FOOTER
    // ─────────────────────────────────────────────
    private void UpdateFooter(DateTime from, DateTime to, decimal revenue, decimal profitRate)
    {
        lbl_footerLeft.Text  = $"Báo cáo từ: {from:dd/MM/yyyy} đến {to:dd/MM/yyyy}";
        lbl_footerRight.Text = revenue > 0 ? $"Tỉ lệ lợi nhuận: {profitRate}%" : "Tỉ lệ lợi nhuận: —";
    }

    // ─────────────────────────────────────────────
    // EVENTS BUTTON CLICK
    // ─────────────────────────────────────────────
    private void btn_xemBaocao_Click(object sender, EventArgs e) => LoadData();

    private void btn_xuatExcel_Click(object sender, EventArgs e)
    {
        if (dgv_listInvoices.Rows.Count == 0)
        {
            MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        _saveDialog.Filter   = "Excel Files|*.xlsx";
        _saveDialog.Title    = "Lưu báo cáo doanh thu";
        _saveDialog.FileName = $"BaoCaoDoanhThu_{DateTime.Now:ddMMyyyy}.xlsx";

        if (_saveDialog.ShowDialog() != DialogResult.OK) return;

        try
        {
            using var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("DoanhThu");

            for (int i = 0; i < dgv_listInvoices.Columns.Count; i++)
            {
                var cell = ws.Cell(1, i + 1);
                cell.Value = dgv_listInvoices.Columns[i].HeaderText;
                cell.Style.Font.Bold = true;
                cell.Style.Fill.BackgroundColor = XLColor.LightGray;
                cell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            }

            int rowIdx = 2;
            foreach (DataGridViewRow row in dgv_listInvoices.Rows)
            {
                if (row.IsNewRow) continue;
                for (int j = 0; j < dgv_listInvoices.Columns.Count; j++)
                {
                    var cell = ws.Cell(rowIdx, j + 1);
                    var val  = row.Cells[j].Value?.ToString() ?? "";
                    cell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                    string colName = dgv_listInvoices.Columns[j].Name.ToLower();
                    if ((colName.Contains("tien") || colName.Contains("doanh") || colName.Contains("loi"))
                        && decimal.TryParse(val.Replace(",", ""), out decimal num))
                    {
                        cell.Value = num;
                        cell.Style.NumberFormat.Format = "#,##0\" đ\"";
                    }
                    else
                    {
                        cell.Value = val;
                    }
                }
                rowIdx++;
            }

            ws.Columns().AdjustToContents();
            wb.SaveAs(_saveDialog.FileName);
            MessageBox.Show("Xuất Excel thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi xuất Excel:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void label1_Click(object sender, EventArgs e) { }
    private void pnl_Top_Paint(object sender, PaintEventArgs e) { }
    private void FormReport_Load(object sender, EventArgs e) { }
}