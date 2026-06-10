using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BUS;
using DAL;
using DTO;
using ClosedXML.Excel;


namespace GUI
{
    public partial class FormReport : Form
    {
        // Khởi tạo các BUS/DAL cần thiết
        private readonly ReportsBUS _reportsBus = new ReportsBUS();
        private readonly ProductsBUS _productsBus = new ProductsBUS();
        private readonly CustomersBUS _customersBus = new CustomersBUS();
        private readonly SalesDetailsDAL _detailDAL = new SalesDetailsDAL();


        private readonly SaveFileDialog _saveDialog = new SaveFileDialog();


        public FormReport()
        {
            InitializeComponent();
        }


        private void FormReport_Load(object sender, EventArgs e)
        {
            // Thiết lập mặc định lọc theo "Tháng này" khi vừa mở Form
            cbb_dayFill.SelectedIndex = 3;
        }


        // ─────────────────────────────────────────────
        // 1. LOGIC COMBOBOX: CHỌN NHANH KHOẢNG THỜI GIAN
        // ─────────────────────────────────────────────
        private void cbb_dayFill_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            switch (cbb_dayFill.SelectedIndex)
            {
                case 0: // Hôm nay
                    dtp_from.Value = today;
                    dtp_to.Value = today;
                    break;
                case 1: // Hôm qua
                    dtp_from.Value = today.AddDays(-1);
                    dtp_to.Value = today.AddDays(-1);
                    break;
                case 2: // 7 ngày qua
                    dtp_from.Value = today.AddDays(-7);
                    dtp_to.Value = today;
                    break;
                case 3: // Tháng này
                    dtp_from.Value = new DateTime(today.Year, today.Month, 1);
                    dtp_to.Value = new DateTime(today.Year, today.Month, DateTime.DaysInMonth(today.Year, today.Month));
                    break;
                case 4: // Tùy chỉnh
                        // Giữ nguyên ngày hiện tại trên DateTimePicker để người dùng tự chọn
                    break;
            }

            // Tự động load lại dữ liệu khi thay đổi bộ lọc (trừ khi là tùy chỉnh)
            if (cbb_dayFill.SelectedIndex != 4)
            {
                LoadData();
            }
        }


        // ─────────────────────────────────────────────
        // 2. HÀM LOADDATA AN TOÀN (BẮT LỖI TRY-CATCH)
        // ─────────────────────────────────────────────
        private void LoadData()
        {
            try
            {
                // Lấy ngày cuối cùng của dtp_to (đến 23:59:59)
                DateTime from = dtp_from.Value.Date;
                DateTime to = dtp_to.Value.Date.AddDays(1).AddTicks(-1);


                // Lấy danh sách hóa đơn từ DB
                var invoices = _reportsBus.GetInvoicesByRange(from, to);

                if (invoices == null || invoices.Count == 0)
                {
                    dgv_listInvoices.DataSource = null;
                    UpdateCards(0, 0, 0, 0, 0);
                    UpdateFooter(from, to, 0, 0);
                    return;
                }


                // Lấy chi tiết các hóa đơn (Sử dụng hàm GetByInvoiceID của SalesDetailsDAL)
                var allDetails = invoices.SelectMany(inv => _detailDAL.GetByInvoiceID(inv.InvoiceID)).ToList();

                // Giả định bạn có hàm GetAll() trong BUS để map tên SP và Tên KH
                var allProducts = _productsBus.GetAll().ToDictionary(p => p.ProductID, p => p.ProductName);
                var allCustomers = _customersBus.GetAll().ToDictionary(c => c.CustomerID, c => c.FullName);


                // Tính toán KPI cho các thẻ Cards
                decimal revenue = invoices.Sum(i => i.FinalAmount);
                decimal cost = allDetails.Sum(d => d.CostPrice * d.Quantity);
                decimal profit = revenue - cost;
                int invoiceCount = invoices.Count;
                int productCount = allDetails.Sum(d => d.Quantity);


                // Tạm thời set bảo hành = 0 (bạn có thể gọi WarrantyBUS.GetCountByDate nếu cần)
                UpdateCards(revenue, profit, invoiceCount, productCount, 0);


                // Biến đổi dữ liệu nạp vào DataGridView
                var detailsByInvoice = allDetails.GroupBy(d => d.InvoiceID).ToDictionary(g => g.Key, g => g.ToList());


                var reportDataSource = invoices.Select(inv => {
                    var details = detailsByInvoice.ContainsKey(inv.InvoiceID) ? detailsByInvoice[inv.InvoiceID] : new List<SalesDetailsDTO>();
                    string customerName = inv.CustomerID.HasValue && allCustomers.ContainsKey(inv.CustomerID.Value) ? allCustomers[inv.CustomerID.Value] : "Khách lẻ";
                    string productSummary = string.Join(", ", details.Select(d => allProducts.ContainsKey(d.ProductID) ? allProducts[d.ProductID] : $"SP {d.ProductID}").Distinct());

                    decimal totalCost = details.Sum(d => d.CostPrice * d.Quantity);
                    decimal rowProfit = inv.FinalAmount - totalCost;


                    return new
                    {
                        InvoiceCode = inv.InvoiceCode,
                        SaleDate = inv.SaleDate.ToString("dd/MM/yyyy HH:mm"),
                        CustomerName = customerName,
                        ProductSummary = productSummary,
                        FinalAmount = inv.FinalAmount,
                        RowProfit = rowProfit,
                        PaymentMethod = inv.PaymentMethod
                    };
                }).ToList();


                // Đổ Data vào Grid
                dgv_listInvoices.DataSource = reportDataSource;


                // Tính tỉ lệ lợi nhuận hiển thị dưới Footer
                decimal profitRate = revenue > 0 ? Math.Round((profit / revenue) * 100, 2) : 0;
                UpdateFooter(from, to, revenue, profitRate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu báo cáo:\n" + ex.Message, "Lỗi Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // ─────────────────────────────────────────────
        // 3. SỰ KIỆN TỰ ĐỘNG FORMAT MÀU CHO GRIDVIEW
        // ─────────────────────────────────────────────
        private void dgv_listInvoices_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgv_listInvoices.RowHeadersVisible = false;
            dgv_listInvoices.ClearSelection();


            // Định dạng cột tiền tệ
            if (dgv_listInvoices.Columns.Contains("col_doanhThu"))
                dgv_listInvoices.Columns["col_doanhThu"].DefaultCellStyle.Format = "#,##0 đ";
            if (dgv_listInvoices.Columns.Contains("col_loiNhuan"))
                dgv_listInvoices.Columns["col_loiNhuan"].DefaultCellStyle.Format = "#,##0 đ";


            // Định dạng màu sắc cột Thanh toán
            foreach (DataGridViewRow row in dgv_listInvoices.Rows)
            {
                if (row.IsNewRow) continue;


                if (dgv_listInvoices.Columns.Contains("col_thanhToan"))
                {
                    var payCell = row.Cells["col_thanhToan"];
                    string paymentMethod = payCell.Value?.ToString() ?? "";


                    if (paymentMethod.Contains("Tiền mặt"))
                    {
                        payCell.Style.BackColor = Color.ForestGreen;
                        payCell.Style.ForeColor = Color.White;
                    }
                    else if (!string.IsNullOrEmpty(paymentMethod))
                    {
                        payCell.Style.BackColor = Color.DodgerBlue;
                        payCell.Style.ForeColor = Color.White;
                    }
                }
            }
        }


        // ─────────────────────────────────────────────
        // 4. HÀM GIAO DIỆN CARDS & FOOTER
        // ─────────────────────────────────────────────
        private void UpdateCards(decimal revenue, decimal profit, int invoiceCount, int productCount, int warrantyCount)
        {
            lbl_outCome.Text = $"{revenue:N0} đ\nDoanh thu";
            lbl_grossProfit.Text = $"{profit:N0} đ\nLợi nhuận gộp";
            lbl_invoiceNum.Text = $"{invoiceCount}\nHóa đơn đã xuất";
            lbl_productSold.Text = $"{productCount}\nSản phẩm bán ra";
            lbl_warranty.Text = $"{warrantyCount}\nBảo hành phát sinh";
        }


        private void UpdateFooter(DateTime from, DateTime to, decimal revenue, decimal profitRate)
        {
            lbl_footerLeft.Text = $"Báo cáo từ: {from:dd/MM/yyyy} đến {to:dd/MM/yyyy}";
            lbl_footerRight.Text = revenue > 0 ? $"Tỉ lệ lợi nhuận: {profitRate}%" : "Tỉ lệ lợi nhuận: 0%";
        }


        // ─────────────────────────────────────────────
        // 5. EVENTS BUTTON CLICK
        // ─────────────────────────────────────────────
        private void btn_showReport_Click(object sender, EventArgs e)
        {
            // Set combo box về tùy chỉnh nếu người dùng bấm nút Xem
            cbb_dayFill.SelectedIndex = 4;
            LoadData();
        }


        private void btn_excelOut_Click(object sender, EventArgs e)
        {
            if (dgv_listInvoices.Rows.Count == 0 || dgv_listInvoices.DataSource == null)
            {
                MessageBox.Show("Không có dữ liệu để xuất Excel!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            _saveDialog.Filter = "Excel Files|*.xlsx";
            _saveDialog.Title = "Lưu báo cáo doanh thu";
            _saveDialog.FileName = $"BaoCaoDoanhThu_{DateTime.Now:ddMMyyyy}.xlsx";


            if (_saveDialog.ShowDialog() != DialogResult.OK) return;


            try
            {
                using (var wb = new XLWorkbook())
                {
                    var ws = wb.Worksheets.Add("DoanhThu");


                    // Ghi Header
                    for (int i = 0; i < dgv_listInvoices.Columns.Count; i++)
                    {
                        var cell = ws.Cell(1, i + 1);
                        cell.Value = dgv_listInvoices.Columns[i].HeaderText;
                        cell.Style.Font.Bold = true;
                        cell.Style.Fill.BackgroundColor = XLColor.LightGray;
                        cell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                    }


                    // Ghi Dữ liệu
                    int rowIdx = 2;
                    foreach (DataGridViewRow row in dgv_listInvoices.Rows)
                    {
                        if (row.IsNewRow) continue;
                        for (int j = 0; j < dgv_listInvoices.Columns.Count; j++)
                        {
                            var cell = ws.Cell(rowIdx, j + 1);
                            var val = row.Cells[j].Value?.ToString() ?? "";
                            cell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;


                            string colName = dgv_listInvoices.Columns[j].Name.ToLower();
                            if ((colName.Contains("doanhthu") || colName.Contains("loinhuan"))
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất Excel. Vui lòng đảm bảo file không bị mở bởi chương trình khác.\nChi tiết: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

