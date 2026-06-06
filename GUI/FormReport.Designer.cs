using System.ComponentModel;

namespace GUI;

partial class FormReport
{
    private IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        // ── Controls ─────────────────────────────────────────────
        pnlTop        = new Panel();
        pnlCards      = new Panel();
        pnlFilter     = new Panel();
        pnlBottom     = new Panel();

        // Filter bar
        lblFrom       = new Label();
        dtpFrom       = new DateTimePicker();
        lblTo         = new Label();
        dtpTo         = new DateTimePicker();
        btnFilter     = new Button();
        btnToday      = new Button();
        btnThisWeek   = new Button();
        btnThisMonth  = new Button();
        btnExport     = new Button();

        // Cards
        pnlCardRevenue = new Panel();
        pnlCardProfit  = new Panel();
        pnlCardOrders  = new Panel();
        pnlCardItems   = new Panel();

        lblCardRevenue     = new Label();
        lblTotalRevenue    = new Label();
        lblCardProfit      = new Label();
        lblTotalProfit     = new Label();
        lblCardOrders      = new Label();
        lblTotalOrders     = new Label();
        lblCardItems       = new Label();
        lblTotalItems      = new Label();

        // Grids
        tabControl       = new TabControl();
        tabRevenue       = new TabPage();
        tabTopProducts   = new TabPage();
        dgvRevenue       = new DataGridView();
        dgvTopProducts   = new DataGridView();

        // Title
        lblTitle = new Label();

        // ── Suspend ───────────────────────────────────────────────
        pnlTop.SuspendLayout();
        pnlCards.SuspendLayout();
        pnlFilter.SuspendLayout();
        pnlBottom.SuspendLayout();
        pnlCardRevenue.SuspendLayout();
        pnlCardProfit.SuspendLayout();
        pnlCardOrders.SuspendLayout();
        pnlCardItems.SuspendLayout();
        tabControl.SuspendLayout();
        tabRevenue.SuspendLayout();
        tabTopProducts.SuspendLayout();
        ((ISupportInitialize)dgvRevenue).BeginInit();
        ((ISupportInitialize)dgvTopProducts).BeginInit();
        SuspendLayout();

        // ══════════════════════════════════════════════════════════
        // FORM
        // ══════════════════════════════════════════════════════════
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode       = AutoScaleMode.Font;
        ClientSize          = new Size(1200, 750);
        Text                = "Báo cáo & Thống kê";
        BackColor           = Color.FromArgb(245, 247, 250);
        Font                = new Font("Segoe UI", 9F);
        Padding             = new Padding(0);
        Controls.Add(pnlTop);
        Controls.Add(pnlFilter);
        Controls.Add(pnlCards);
        Controls.Add(pnlBottom);

        // ══════════════════════════════════════════════════════════
        // pnlTop — Tiêu đề
        // ══════════════════════════════════════════════════════════
        pnlTop.BackColor = Color.FromArgb(30, 58, 138);   // xanh đậm
        pnlTop.Dock      = DockStyle.Top;
        pnlTop.Height    = 56;
        pnlTop.Controls.Add(lblTitle);

        lblTitle.Text      = "📊  BÁO CÁO DOANH THU VÀ LỢI NHUẬN";
        lblTitle.ForeColor = Color.White;
        lblTitle.Font      = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblTitle.AutoSize  = true;
        lblTitle.Location  = new Point(20, 14);

        // ══════════════════════════════════════════════════════════
        // pnlFilter — Thanh lọc ngày
        // ══════════════════════════════════════════════════════════
        pnlFilter.BackColor = Color.White;
        pnlFilter.Dock      = DockStyle.Top;
        pnlFilter.Height    = 52;
        pnlFilter.Padding   = new Padding(12, 8, 12, 8);
        pnlFilter.Controls.AddRange(new Control[]
        {
            lblFrom, dtpFrom, lblTo, dtpTo,
            btnFilter, btnToday, btnThisWeek, btnThisMonth, btnExport
        });

        // Từ ngày
        lblFrom.Text      = "Từ ngày:";
        lblFrom.AutoSize  = true;
        lblFrom.Location  = new Point(12, 18);
        lblFrom.Font      = new Font("Segoe UI", 9F);

        dtpFrom.Format       = DateTimePickerFormat.Custom;
        dtpFrom.CustomFormat = "dd/MM/yyyy";
        dtpFrom.Size     = new Size(110, 30);
        dtpFrom.Location = new Point(75, 15);

        // Đến ngày
        lblTo.Text      = "Đến:";
        lblTo.AutoSize  = true;
        lblTo.Location  = new Point(192, 18);
        lblTo.Font      = new Font("Segoe UI", 9F);

        dtpTo.Format         = DateTimePickerFormat.Custom;
        dtpTo.CustomFormat   = "dd/MM/yyyy";
        dtpTo.Size     = new Size(110, 30);
        dtpTo.Location = new Point(229, 15);

        // Nút Lọc
        StyleButton(btnFilter, "🔍 Lọc", Color.FromArgb(30, 58, 138), Color.White);
        btnFilter.Location = new Point(348, 10);
        btnFilter.Click   += btnFilter_Click;

        // Nút Hôm nay
        StyleButton(btnToday, "Hôm nay", Color.FromArgb(229, 231, 235), Color.FromArgb(30, 30, 30));
        btnToday.Location = new Point(444, 10);
        btnToday.Click   += btnToday_Click;

        // Nút Tuần này
        StyleButton(btnThisWeek, "Tuần này", Color.FromArgb(229, 231, 235), Color.FromArgb(30, 30, 30));
        btnThisWeek.Location = new Point(544, 10);
        btnThisWeek.Click   += btnThisWeek_Click;

        // Nút Tháng này
        StyleButton(btnThisMonth, "Tháng này", Color.FromArgb(229, 231, 235), Color.FromArgb(30, 30, 30));
        btnThisMonth.Location = new Point(652, 10);
        btnThisMonth.Click   += btnThisMonth_Click;

        // Nút Xuất Excel
        StyleButton(btnExport, "⬇ Xuất Excel", Color.FromArgb(21, 128, 61), Color.White);
        btnExport.Location = new Point(770, 10);
        btnExport.Click   += btnExport_Click;

        // ══════════════════════════════════════════════════════════
        // pnlCards — 4 thẻ thống kê tổng
        // ══════════════════════════════════════════════════════════
        pnlCards.BackColor = Color.Transparent;
        pnlCards.Dock      = DockStyle.Top;
        pnlCards.Height    = 110;
        pnlCards.Padding   = new Padding(12, 8, 12, 4);
        pnlCards.Controls.AddRange(new Control[]
        {
            pnlCardRevenue, pnlCardProfit, pnlCardOrders, pnlCardItems
        });

        BuildCard(pnlCardRevenue, lblCardRevenue, lblTotalRevenue,
                  "DOANH THU", "0 ₫",
                  Color.FromArgb(239, 246, 255), Color.FromArgb(30, 58, 138),
                  new Point(12, 8));

        BuildCard(pnlCardProfit, lblCardProfit, lblTotalProfit,
                  "LỢI NHUẬN", "0 ₫",
                  Color.FromArgb(240, 253, 244), Color.FromArgb(21, 128, 61),
                  new Point(222, 8));

        BuildCard(pnlCardOrders, lblCardOrders, lblTotalOrders,
                  "SỐ ĐƠN HÀNG", "0 đơn",
                  Color.FromArgb(255, 251, 235), Color.FromArgb(146, 64, 14),
                  new Point(432, 8));

        BuildCard(pnlCardItems, lblCardItems, lblTotalItems,
                  "SẢN PHẨM ĐÃ BÁN", "0 sản phẩm",
                  Color.FromArgb(253, 242, 248), Color.FromArgb(157, 23, 77),
                  new Point(642, 8));

        // ══════════════════════════════════════════════════════════
        // pnlBottom — TabControl chứa 2 bảng
        // ══════════════════════════════════════════════════════════
        pnlBottom.Dock      = DockStyle.Fill;
        pnlBottom.Padding   = new Padding(12, 4, 12, 12);
        pnlBottom.BackColor = Color.Transparent;
        pnlBottom.Controls.Add(tabControl);

        tabControl.Dock = DockStyle.Fill;
        tabControl.Font = new Font("Segoe UI", 9F);
        tabControl.TabPages.Add(tabRevenue);
        tabControl.TabPages.Add(tabTopProducts);

        // Tab doanh thu theo ngày
        tabRevenue.Text       = "  📅  Doanh thu theo ngày  ";
        tabRevenue.BackColor  = Color.White;
        tabRevenue.Padding    = new Padding(4);
        tabRevenue.Controls.Add(dgvRevenue);

        StyleGrid(dgvRevenue);
        dgvRevenue.Dock = DockStyle.Fill;

        // Tab top sản phẩm
        tabTopProducts.Text      = "  🏆  Top sản phẩm bán chạy  ";
        tabTopProducts.BackColor = Color.White;
        tabTopProducts.Padding   = new Padding(4);
        tabTopProducts.Controls.Add(dgvTopProducts);

        StyleGrid(dgvTopProducts);
        dgvTopProducts.Dock = DockStyle.Fill;

        // ── Resume ────────────────────────────────────────────────
        pnlTop.ResumeLayout(false);
        pnlCards.ResumeLayout(false);
        pnlFilter.ResumeLayout(false);
        pnlBottom.ResumeLayout(false);
        pnlCardRevenue.ResumeLayout(false);
        pnlCardProfit.ResumeLayout(false);
        pnlCardOrders.ResumeLayout(false);
        pnlCardItems.ResumeLayout(false);
        tabControl.ResumeLayout(false);
        tabRevenue.ResumeLayout(false);
        tabTopProducts.ResumeLayout(false);
        ((ISupportInitialize)dgvRevenue).EndInit();
        ((ISupportInitialize)dgvTopProducts).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    // ══════════════════════════════════════════════════════════════
    // HELPER: tạo card thống kê
    // ══════════════════════════════════════════════════════════════
    private void BuildCard(Panel panel, Label lblTitle, Label lblValue,
                           string title, string defaultVal,
                           Color bg, Color accent, Point location)
    {
        panel.Size      = new Size(196, 88);
        panel.Location  = location;
        panel.BackColor = bg;
        panel.Padding   = new Padding(12, 10, 8, 8);
        // bo góc cần custom paint — dùng border đơn giản thay thế
        panel.Controls.Add(lblTitle);
        panel.Controls.Add(lblValue);

        lblTitle.Text      = title;
        lblTitle.ForeColor = Color.FromArgb(100, 116, 139);
        lblTitle.Font      = new Font("Segoe UI", 7.5F, FontStyle.Regular);
        lblTitle.AutoSize  = true;
        lblTitle.Location  = new Point(12, 10);

        lblValue.Text      = defaultVal;
        lblValue.ForeColor = accent;
        lblValue.Font      = new Font("Segoe UI", 15F, FontStyle.Bold);
        lblValue.AutoSize  = true;
        lblValue.Location  = new Point(12, 32);
    }

    // ══════════════════════════════════════════════════════════════
    // HELPER: style button
    // ══════════════════════════════════════════════════════════════
    private void StyleButton(Button btn, string text, Color bg, Color fg)
    {
        btn.Text      = text;
        btn.BackColor = bg;
        btn.ForeColor = fg;
        btn.FlatStyle = FlatStyle.Flat;
        btn.FlatAppearance.BorderSize = 0;
        btn.Size      = new Size(90, 30);
        btn.Font      = new Font("Segoe UI", 8.5F, FontStyle.Regular);
        btn.Cursor    = Cursors.Hand;
    }

    // ══════════════════════════════════════════════════════════════
    // HELPER: style DataGridView
    // ══════════════════════════════════════════════════════════════
    private void StyleGrid(DataGridView dgv)
    {
        dgv.ReadOnly                  = true;
        dgv.AllowUserToAddRows        = false;
        dgv.AllowUserToDeleteRows     = false;
        dgv.SelectionMode             = DataGridViewSelectionMode.FullRowSelect;
        dgv.AutoSizeColumnsMode       = DataGridViewAutoSizeColumnsMode.Fill;
        dgv.BackgroundColor           = Color.White;
        dgv.GridColor                 = Color.FromArgb(226, 232, 240);
        dgv.BorderStyle               = BorderStyle.None;
        dgv.RowHeadersVisible         = false;
        dgv.Font                      = new Font("Segoe UI", 9F);

        dgv.ColumnHeadersDefaultCellStyle.BackColor  = Color.FromArgb(30, 58, 138);
        dgv.ColumnHeadersDefaultCellStyle.ForeColor  = Color.White;
        dgv.ColumnHeadersDefaultCellStyle.Font       = new Font("Segoe UI", 9F, FontStyle.Bold);
        dgv.ColumnHeadersDefaultCellStyle.Padding    = new Padding(8, 0, 0, 0);
        dgv.ColumnHeadersHeight      = 38;
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgv.EnableHeadersVisualStyles = false;

        dgv.DefaultCellStyle.Padding   = new Padding(8, 4, 0, 4);
        dgv.DefaultCellStyle.BackColor = Color.White;
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);

        dgv.RowTemplate.Height = 34;
    }

    // ══════════════════════════════════════════════════════════════
    // FIELDS
    // ══════════════════════════════════════════════════════════════
    private Panel       pnlTop, pnlCards, pnlFilter, pnlBottom;
    private Panel       pnlCardRevenue, pnlCardProfit, pnlCardOrders, pnlCardItems;
    private Label       lblTitle;
    private Label       lblFrom, lblTo;
    private Label       lblCardRevenue,  lblTotalRevenue;
    private Label       lblCardProfit,   lblTotalProfit;
    private Label       lblCardOrders,   lblTotalOrders;
    private Label       lblCardItems,    lblTotalItems;
    private DateTimePicker dtpFrom, dtpTo;
    private Button      btnFilter, btnToday, btnThisWeek, btnThisMonth, btnExport;
    private TabControl  tabControl;
    private TabPage     tabRevenue, tabTopProducts;
    private DataGridView dgvRevenue, dgvTopProducts;

    #endregion
}