using BUS;
using DTO;

namespace GUI;

public partial class FormReport : Form
{
    private readonly ReportsBUS _reportsBUS = new ReportsBUS();

    public FormReport()
    {
        InitializeComponent();
        LoadReport();
    }

    // =============================================
    // LOAD BÁO CÁO KHI MỞ FORM
    // =============================================
    private void LoadReport()
    {
        // Mặc định: báo cáo hôm nay
        dtpFrom.Value = DateTime.Today;
        dtpTo.Value = DateTime.Today;

        LoadRevenueChart();
        LoadTopProducts();
        LoadSummaryCards();
    }

    // =============================================
    // NÚT LỌC THEO NGÀY
    // =============================================
    private void btnFilter_Click(object sender, EventArgs e)
    {
        if (dtpFrom.Value > dtpTo.Value)
        {
            MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!",
                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        LoadRevenueChart();
        LoadTopProducts();
        LoadSummaryCards();
    }

    // =============================================
    // NÚT HÔM NAY
    // =============================================
    private void btnToday_Click(object sender, EventArgs e)
    {
        dtpFrom.Value = DateTime.Today;
        dtpTo.Value = DateTime.Today;
        LoadRevenueChart();
        LoadTopProducts();
        LoadSummaryCards();
    }

    // =============================================
    // NÚT TUẦN NÀY
    // =============================================
    private void btnThisWeek_Click(object sender, EventArgs e)
    {
        int day = (int)DateTime.Today.DayOfWeek;
        dtpFrom.Value = DateTime.Today.AddDays(-(day == 0 ? 6 : day - 1));
        dtpTo.Value = DateTime.Today;
        LoadRevenueChart();
        LoadTopProducts();
        LoadSummaryCards();
    }

    // =============================================
    // NÚT THÁNG NÀY
    // =============================================
    private void btnThisMonth_Click(object sender, EventArgs e)
    {
        dtpFrom.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
        dtpTo.Value = DateTime.Today;
        LoadRevenueChart();
        LoadTopProducts();
        LoadSummaryCards();
    }

    // =============================================
    // TẢI THỐNG KÊ TỔNG (CARDS)
    // =============================================
    private void LoadSummaryCards()
    {
        try
        {
            var summary = _reportsBUS.GetSummary(dtpFrom.Value, dtpTo.Value);

            lblTotalRevenue.Text = summary.Revenue.ToString("N0") + " ₫";
            lblTotalProfit.Text  = summary.Profit.ToString("N0") + " ₫";
            lblTotalOrders.Text  = summary.OrderCount.ToString("N0") + " đơn";
            lblTotalItems.Text   = summary.ItemsSold.ToString("N0") + " sản phẩm";
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi tải thống kê: " + ex.Message, "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // =============================================
    // TẢI BẢNG TOP SẢN PHẨM BÁN CHẠY
    // =============================================
    private void LoadTopProducts()
    {
        try
        {
            var data = _reportsBUS.GetTopProducts(dtpFrom.Value, dtpTo.Value, top: 10);
            dgvTopProducts.DataSource = data;

            // Đặt tên cột hiển thị tiếng Việt
            if (dgvTopProducts.Columns.Count > 0)
            {
                dgvTopProducts.Columns["ProductName"].HeaderText  = "Tên sản phẩm";
                dgvTopProducts.Columns["QuantitySold"].HeaderText = "Số lượng bán";
                dgvTopProducts.Columns["TotalRevenue"].HeaderText = "Doanh thu";
                dgvTopProducts.Columns["TotalProfit"].HeaderText  = "Lợi nhuận";
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi tải top sản phẩm: " + ex.Message, "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // =============================================
    // TẢI BẢNG DOANH THU THEO NGÀY
    // =============================================
    private void LoadRevenueChart()
    {
        try
        {
            var data = _reportsBUS.GetRevenueByDate(dtpFrom.Value, dtpTo.Value);
            dgvRevenue.DataSource = data;

            if (dgvRevenue.Columns.Count > 0)
            {
                dgvRevenue.Columns["SaleDate"].HeaderText  = "Ngày";
                dgvRevenue.Columns["Revenue"].HeaderText   = "Doanh thu";
                dgvRevenue.Columns["Profit"].HeaderText    = "Lợi nhuận";
                dgvRevenue.Columns["OrderCount"].HeaderText = "Số đơn";
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi tải doanh thu: " + ex.Message, "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // =============================================
    // NÚT XUẤT EXCEL (để trống, leader bổ sung sau)
    // =============================================
    private void btnExport_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Tính năng xuất Excel đang phát triển.", "Thông báo",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}

    
