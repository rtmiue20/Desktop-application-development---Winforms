using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Desktop_Application_Development
{
    public partial class FormReport : Form
    {
        private readonly SalesBUS _salesBUS = new SalesBUS();

        // Controls
        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private Button btnSearch;
        private Button btnToday;
        private Button btnThisWeek;
        private Button btnThisMonth;
        private Label lblTotalRevenue;
        private Label lblTotalOrders;
        private Label lblTotalDiscount;
        private Label lblCashRevenue;
        private Label lblTransferRevenue;
        private Panel pnlChart;
        private DataGridView dgvInvoices;

        public FormReport()
        {
            InitializeComponent();
            BuildUI();
            dtpFrom.Value = DateTime.Today.AddDays(-7);
            dtpTo.Value = DateTime.Today;
            LoadReport();
        }

        private void BuildUI()
        {
            this.Text = "Báo cáo doanh thu";
            this.Size = new Size(1100, 700);
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = Color.WhiteSmoke;

            // ===== PANEL BỘ LỌC =====
            var pnlFilter = new Panel
            {
                Location = new Point(10, 10), Size = new Size(1060, 55),
                BackColor = Color.White, BorderStyle = BorderStyle.FixedSingle
            };
            this.Controls.Add(pnlFilter);

            pnlFilter.Controls.Add(new Label { Text = "Từ ngày:", Location = new Point(10, 15), AutoSize = true, Font = new Font("Segoe UI", 10) });
            dtpFrom = new DateTimePicker { Location = new Point(85, 12), Size = new Size(150, 30), Format = DateTimePickerFormat.Short, Font = new Font("Segoe UI", 10) };
            pnlFilter.Controls.Add(dtpFrom);

            pnlFilter.Controls.Add(new Label { Text = "Đến ngày:", Location = new Point(250, 15), AutoSize = true, Font = new Font("Segoe UI", 10) });
            dtpTo = new DateTimePicker { Location = new Point(335, 12), Size = new Size(150, 30), Format = DateTimePickerFormat.Short, Font = new Font("Segoe UI", 10) };
            pnlFilter.Controls.Add(dtpTo);

            btnSearch = new Button
            {
                Text = "Xem báo cáo", Location = new Point(500, 10), Size = new Size(130, 33),
                BackColor = Color.SteelBlue, ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.Click += (s, e) => LoadReport();
            pnlFilter.Controls.Add(btnSearch);

            btnToday = new Button { Text = "Hôm nay", Location = new Point(645, 10), Size = new Size(90, 33), BackColor = Color.Gray, ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 9) };
            btnToday.FlatAppearance.BorderSize = 0;
            btnToday.Click += (s, e) => { dtpFrom.Value = DateTime.Today; dtpTo.Value = DateTime.Today; LoadReport(); };
            pnlFilter.Controls.Add(btnToday);

            btnThisWeek = new Button { Text = "Tuần này", Location = new Point(745, 10), Size = new Size(90, 33), BackColor = Color.Gray, ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 9) };
            btnThisWeek.FlatAppearance.BorderSize = 0;
            btnThisWeek.Click += (s, e) => { dtpFrom.Value = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + 1); dtpTo.Value = DateTime.Today; LoadReport(); };
            pnlFilter.Controls.Add(btnThisWeek);

            btnThisMonth = new Button { Text = "Tháng này", Location = new Point(845, 10), Size = new Size(100, 33), BackColor = Color.Gray, ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 9) };
            btnThisMonth.FlatAppearance.BorderSize = 0;
            btnThisMonth.Click += (s, e) => { dtpFrom.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1); dtpTo.Value = DateTime.Today; LoadReport(); };
            pnlFilter.Controls.Add(btnThisMonth);

            // ===== PANEL THỐNG KÊ =====
            var pnlStats = new Panel
            {
                Location = new Point(10, 75), Size = new Size(1060, 90),
                BackColor = Color.White, BorderStyle = BorderStyle.FixedSingle
            };
            this.Controls.Add(pnlStats);

            AddStatCard(pnlStats, "TỔNG DOANH THU", 10, out lblTotalRevenue, Color.MediumSeaGreen);
            AddStatCard(pnlStats, "SỐ HÓA ĐƠN", 225, out lblTotalOrders, Color.SteelBlue);
            AddStatCard(pnlStats, "TỔNG GIẢM GIÁ", 440, out lblTotalDiscount, Color.Orange);
            AddStatCard(pnlStats, "TIỀN MẶT", 655, out lblCashRevenue, Color.Teal);
            AddStatCard(pnlStats, "CHUYỂN KHOẢN", 870, out lblTransferRevenue, Color.Purple);

            // ===== PANEL BIỂU ĐỒ =====
            var pnlChartWrap = new Panel
            {
                Location = new Point(10, 175), Size = new Size(1060, 220),
                BackColor = Color.White, BorderStyle = BorderStyle.FixedSingle
            };
            this.Controls.Add(pnlChartWrap);

            pnlChartWrap.Controls.Add(new Label
            {
                Text = "BIỂU ĐỒ DOANH THU THEO NGÀY",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.DarkBlue, Location = new Point(10, 8), AutoSize = true
            });

            pnlChart = new Panel { Location = new Point(5, 30), Size = new Size(1048, 180), BackColor = Color.White };
            pnlChartWrap.Controls.Add(pnlChart);

            // ===== PANEL DANH SÁCH HÓA ĐƠN =====
            var pnlGrid = new Panel
            {
                Location = new Point(10, 405), Size = new Size(1060, 255),
                BackColor = Color.White, BorderStyle = BorderStyle.FixedSingle
            };
            this.Controls.Add(pnlGrid);

            pnlGrid.Controls.Add(new Label
            {
                Text = "DANH SÁCH HÓA ĐƠN",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.DarkBlue, Location = new Point(10, 8), AutoSize = true
            });

            dgvInvoices = new DataGridView
            {
                Location = new Point(5, 35), Size = new Size(1048, 210),
                ReadOnly = true, AllowUserToAddRows = false,
                BackgroundColor = Color.White, BorderStyle = BorderStyle.None,
                RowHeadersVisible = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                Font = new Font("Segoe UI", 9),
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.AliceBlue }
            };
            dgvInvoices.Columns.Add("InvoiceCode", "Mã hóa đơn");
            dgvInvoices.Columns.Add("SaleDate", "Ngày bán");
            dgvInvoices.Columns.Add("TotalAmount", "Tổng tiền");
            dgvInvoices.Columns.Add("DiscountAmount", "Giảm giá");
            dgvInvoices.Columns.Add("FinalAmount", "Thành tiền");
            dgvInvoices.Columns.Add("PaymentMethod", "Thanh toán");
            pnlGrid.Controls.Add(dgvInvoices);
        }

        private void AddStatCard(Panel parent, string title, int x, out Label valueLabel, Color color)
        {
            var card = new Panel { Location = new Point(x, 8), Size = new Size(205, 70), BackColor = Color.WhiteSmoke, BorderStyle = BorderStyle.FixedSingle };
            parent.Controls.Add(card);

            var bar = new Panel { Location = new Point(0, 0), Size = new Size(4, 70), BackColor = color };
            card.Controls.Add(bar);

            card.Controls.Add(new Label { Text = title, Font = new Font("Segoe UI", 8), ForeColor = Color.Gray, Location = new Point(10, 8), AutoSize = true });

            valueLabel = new Label { Text = "---", Font = new Font("Segoe UI", 13, FontStyle.Bold), ForeColor = color, Location = new Point(10, 32), AutoSize = true };
            card.Controls.Add(valueLabel);
        }

        private void LoadReport()
        {
            DateTime fromDate = dtpFrom.Value.Date;
            DateTime toDate = dtpTo.Value.Date;

            if (fromDate > toDate)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var allInvoices = new List<SalesInvoicesDTO>();
            for (DateTime d = fromDate; d <= toDate; d = d.AddDays(1))
            {
                var invoices = _salesBUS.GetByShift(CurrentUser.UserID, d);
                allInvoices.AddRange(invoices);
            }

            // Hiển thị danh sách
            dgvInvoices.Rows.Clear();
            foreach (var inv in allInvoices)
            {
                dgvInvoices.Rows.Add(
                    inv.InvoiceCode,
                    inv.SaleDate.ToString("dd/MM/yyyy HH:mm"),
                    inv.TotalAmount.ToString("N0") + " đ",
                    inv.DiscountAmount.ToString("N0") + " đ",
                    inv.FinalAmount.ToString("N0") + " đ",
                    inv.PaymentMethod
                );
            }

            // Thống kê
            lblTotalRevenue.Text = allInvoices.Sum(x => x.FinalAmount).ToString("N0") + " đ";
            lblTotalOrders.Text = allInvoices.Count.ToString();
            lblTotalDiscount.Text = allInvoices.Sum(x => x.DiscountAmount).ToString("N0") + " đ";
            lblCashRevenue.Text = allInvoices.Where(x => x.PaymentMethod == "Tiền mặt").Sum(x => x.FinalAmount).ToString("N0") + " đ";
            lblTransferRevenue.Text = allInvoices.Where(x => x.PaymentMethod != "Tiền mặt").Sum(x => x.FinalAmount).ToString("N0") + " đ";

            DrawBarChart(fromDate, toDate, allInvoices);
        }

        private void DrawBarChart(DateTime fromDate, DateTime toDate, List<SalesInvoicesDTO> invoices)
        {
            pnlChart.Controls.Clear();
            int days = (toDate - fromDate).Days + 1;
            if (days > 31) return;

            var dailyRevenue = new System.Collections.Generic.Dictionary<DateTime, decimal>();
            for (DateTime d = fromDate; d <= toDate; d = d.AddDays(1))
                dailyRevenue[d.Date] = invoices.Where(x => x.SaleDate.Date == d.Date).Sum(x => x.FinalAmount);

            decimal maxVal = dailyRevenue.Values.DefaultIfEmpty(1).Max();
            if (maxVal == 0) maxVal = 1;

            var chart = new Panel { Dock = DockStyle.Fill, BackColor = Color.White };
            chart.Paint += (s, e) =>
            {
                var g = e.Graphics;
                int w = chart.Width, h = chart.Height;
                int pad = 45;
                int barAreaW = w - pad * 2;
                int barAreaH = h - pad * 2;
                var penAxis = new Pen(Color.Gray, 1);
                g.DrawLine(penAxis, pad, pad, pad, h - pad);
                g.DrawLine(penAxis, pad, h - pad, w - pad, h - pad);

                int barW = Math.Max(8, barAreaW / days - 4);
                int i = 0;
                var font = new Font("Segoe UI", 7);
                var brushBar = new SolidBrush(Color.SteelBlue);
                var brushLabel = new SolidBrush(Color.DimGray);
                var penGrid = new Pen(Color.LightGray, 1);

                for (int j = 1; j <= 4; j++)
                {
                    int y = h - pad - (int)(barAreaH * j / 4);
                    g.DrawLine(penGrid, pad, y, w - pad, y);
                    g.DrawString((maxVal * j / 4 / 1000).ToString("N0") + "k", font, brushLabel, 2, y - 7);
                }

                foreach (var kv in dailyRevenue.OrderBy(x => x.Key))
                {
                    int barH = (int)(barAreaH * kv.Value / maxVal);
                    int x = pad + i * (barAreaW / days) + 2;
                    int y = h - pad - barH;
                    g.FillRectangle(barH > 0 ? brushBar : new SolidBrush(Color.LightGray), x, barH > 0 ? y : h - pad - 2, barW, Math.Max(barH, 2));
                    g.DrawString(kv.Key.ToString("dd/M"), font, brushLabel, x, h - pad + 3);
                    if (barH > 15)
                        g.DrawString((kv.Value / 1000).ToString("N0") + "k", font, Brushes.White, x, y + 2);
                    i++;
                }
            };
            pnlChart.Controls.Add(chart);
        }
    }
}