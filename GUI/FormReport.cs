using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using ClosedXML.Excel; // Đưa thư viện Excel vào sử dụng

namespace GUI;

public partial class FormReport : Form
{
    // Dữ liệu mẫu (Giữ nguyên như code cũ của bạn)
    private List<ReportRecord> _reportList = new List<ReportRecord>
    {
        new ReportRecord { InvoiceCode = "HD012", SaleTime = "09:15", CustomerName = "Nguyễn Văn A", ProductName = "iPhone 15 Pro", Revenue = 28990000, Profit = 4990000, PaymentMethod = "Tiền mặt" },
        new ReportRecord { InvoiceCode = "HD011", SaleTime = "08:45", CustomerName = "Khách lẻ",     ProductName = "AirPods Pro 2", Revenue = 6490000,  Profit = 1990000, PaymentMethod = "CK" },
    };

    // Khởi tạo hộp thoại lưu file bằng code (Không cần kéo thả Toolbox)
    private SaveFileDialog saveDialog_Excel = new SaveFileDialog();

    public FormReport()
    {
        InitializeComponent();
        LoadReport();
    }

    private void LoadReport()
    {
        UpdateCards();
        LoadTable();
        UpdateFooter();
    }

    private void UpdateCards()
    {
        lbl_doanhThu.Text         = "145,200,000\nDoanh thu (đ)";
        lbl_grossProfit.Text      = "42,300,000\nLợi nhuận gộp (đ)";
        lbl_invoiceNum.Text       = "24\nHóa đơn đã xuất";
    }

    private void LoadTable()
    {
        dgv_listInvoices.Rows.Clear();
        for (int i = 0; i < _reportList.Count; i++)
        {
            var r = _reportList[i];
            dgv_listInvoices.Rows.Add(
                r.InvoiceCode,
                r.SaleTime,
                r.CustomerName,
                r.ProductName,
                string.Format("{0:N0}", r.Revenue),
                string.Format("{0:N0}", r.Profit),
                r.PaymentMethod
            );
            
            // Đổi màu theo phương thức thanh toán
            var payCell = dgv_listInvoices.Rows[i].Cells["col_thanhToan"];
            if (r.PaymentMethod == "Tiền mặt")
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

    private void UpdateFooter()
    {
        // Nếu form bạn không có lbl_footerLeft, hãy comment 2 dòng này lại để không báo lỗi đỏ nhé
        // lbl_footerLeft.Text  = "Báo cáo ngày: " + DateTime.Now.ToString("dd/MM/yyyy");
        // lbl_footerRight.Text = "Tỉ lệ lợi nhuận: 29.1%";
    }

    private void btn_xemBaocao_Click(object sender, EventArgs e)
    {
        LoadReport();
    }

    // --- LOGIC XUẤT EXCEL CHÍNH THỨC ---
    private void btn_xuatExcel_Click(object sender, EventArgs e)
    {
        if (dgv_listInvoices.Rows.Count == 0)
        {
            MessageBox.Show("Không có dữ liệu báo cáo để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // Cấu hình hộp thoại
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

                    // 1. Tạo Tiêu đề cột từ DataGridView
                    for (int i = 0; i < dgv_listInvoices.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i + 1).Value = dgv_listInvoices.Columns[i].HeaderText;
                        worksheet.Cell(1, i + 1).Style.Font.Bold = true;
                        worksheet.Cell(1, i + 1).Style.Fill.BackgroundColor = XLColor.LightGray;
                    }

                    // 2. Đổ dữ liệu từ các hàng vào Excel
                    for (int i = 0; i < dgv_listInvoices.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgv_listInvoices.Columns.Count; j++)
                        {
                            var cellValue = dgv_listInvoices.Rows[i].Cells[j].Value?.ToString();
                            worksheet.Cell(i + 2, j + 1).Value = cellValue;
                        }
                    }

                    // Căn chỉnh độ rộng tự động cho đẹp
                    worksheet.Columns().AdjustToContents();

                    // 3. Lưu file
                    workbook.SaveAs(saveDialog_Excel.FileName);
                    
                    MessageBox.Show("Xuất báo cáo Excel thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất Excel: (Hãy đảm bảo file không bị mở ở ứng dụng khác)\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void label1_Click(object sender, EventArgs e) { }
    private void pnl_Top_Paint(object sender, PaintEventArgs e) { }
}

public class ReportRecord
{
    public string InvoiceCode { get; set; }
    public string SaleTime { get; set; }
    public string CustomerName { get; set; }
    public string ProductName { get; set; }
    public decimal Revenue { get; set; }
    public decimal Profit { get; set; }
    public string PaymentMethod { get; set; }
}