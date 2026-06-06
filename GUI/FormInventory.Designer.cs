namespace GUI
{
    partial class FormInventory
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            pnl_header = new Panel();
            btn_refresh = new Button();
            btn_export = new Button();
            btn_filter = new Button();
            pnl_filters = new Panel();
            cb_statusFilter = new ComboBox();
            cb_categories = new ComboBox();
            pnl_dashboard = new Panel();
            lbl_outOfStockCount = new Label();
            lbl_warningCount = new Label();
            lbl_availableCount = new Label();
            lbl_totalCount = new Label();
            dgv_inventory = new DataGridView();
            pnl_footer = new Panel();
            lbl_needOrder = new Label();
            lbl_timeUpdate = new Label();
            pnl_header.SuspendLayout();
            pnl_filters.SuspendLayout();
            pnl_dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_inventory).BeginInit();
            pnl_footer.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_header
            // 
            pnl_header.Controls.Add(btn_refresh);
            pnl_header.Controls.Add(btn_export);
            pnl_header.Controls.Add(btn_filter);
            pnl_header.Dock = DockStyle.Top;
            pnl_header.Location = new Point(0, 0);
            pnl_header.Name = "pnl_header";
            pnl_header.Size = new Size(784, 50);
            pnl_header.TabIndex = 3;
            // 
            // btn_refresh
            // 
            btn_refresh.Location = new Point(245, 10);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(100, 30);
            btn_refresh.TabIndex = 0;
            btn_refresh.Text = "🔄 Làm mới";
            btn_refresh.Click += btn_refresh_Click;
            // 
            // btn_export
            // 
            btn_export.Location = new Point(125, 10);
            btn_export.Name = "btn_export";
            btn_export.Size = new Size(110, 30);
            btn_export.TabIndex = 1;
            btn_export.Text = "📤 Xuất Excel";
            btn_export.Click += btn_export_Click;
            // 
            // btn_filter
            // 
            btn_filter.Location = new Point(15, 10);
            btn_filter.Name = "btn_filter";
            btn_filter.Size = new Size(100, 30);
            btn_filter.TabIndex = 2;
            btn_filter.Text = "🔍 Kiểm kê";
            btn_filter.Click += btn_filter_Click;
            // 
            // pnl_filters
            // 
            pnl_filters.Controls.Add(cb_statusFilter);
            pnl_filters.Controls.Add(cb_categories);
            pnl_filters.Dock = DockStyle.Top;
            pnl_filters.Location = new Point(0, 50);
            pnl_filters.Name = "pnl_filters";
            pnl_filters.Size = new Size(784, 85);
            pnl_filters.TabIndex = 2;
            // 
            // cb_statusFilter
            // 
            cb_statusFilter.Location = new Point(15, 48);
            cb_statusFilter.Name = "cb_statusFilter";
            cb_statusFilter.Size = new Size(750, 28);
            cb_statusFilter.TabIndex = 0;
            // 
            // cb_categories
            // 
            cb_categories.Location = new Point(15, 12);
            cb_categories.Name = "cb_categories";
            cb_categories.Size = new Size(750, 28);
            cb_categories.TabIndex = 1;
            // 
            // pnl_dashboard
            // 
            pnl_dashboard.Controls.Add(lbl_outOfStockCount);
            pnl_dashboard.Controls.Add(lbl_warningCount);
            pnl_dashboard.Controls.Add(lbl_availableCount);
            pnl_dashboard.Controls.Add(lbl_totalCount);
            pnl_dashboard.Dock = DockStyle.Top;
            pnl_dashboard.Location = new Point(0, 135);
            pnl_dashboard.Name = "pnl_dashboard";
            pnl_dashboard.Size = new Size(784, 65);
            pnl_dashboard.TabIndex = 1;
            // 
            // lbl_outOfStockCount
            // 
            lbl_outOfStockCount.Location = new Point(590, 5);
            lbl_outOfStockCount.Name = "lbl_outOfStockCount";
            lbl_outOfStockCount.Size = new Size(175, 50);
            lbl_outOfStockCount.TabIndex = 0;
            lbl_outOfStockCount.Text = "2\r\nHết hàng";
            // 
            // lbl_warningCount
            // 
            lbl_warningCount.Location = new Point(400, 5);
            lbl_warningCount.Name = "lbl_warningCount";
            lbl_warningCount.Size = new Size(175, 50);
            lbl_warningCount.TabIndex = 1;
            lbl_warningCount.Text = "4\r\nSắp hết (≤ MinStock)";
            // 
            // lbl_availableCount
            // 
            lbl_availableCount.Location = new Point(210, 5);
            lbl_availableCount.Name = "lbl_availableCount";
            lbl_availableCount.Size = new Size(175, 50);
            lbl_availableCount.TabIndex = 2;
            lbl_availableCount.Text = "18\r\nCòn hàng";
            // 
            // lbl_totalCount
            // 
            lbl_totalCount.Location = new Point(20, 5);
            lbl_totalCount.Name = "lbl_totalCount";
            lbl_totalCount.Size = new Size(175, 50);
            lbl_totalCount.TabIndex = 3;
            lbl_totalCount.Text = "24\r\nTổng sản phẩm";
            // 
            // dgv_inventory
            // 
            dgv_inventory.ColumnHeadersHeight = 29;
            dgv_inventory.Dock = DockStyle.Fill;
            dgv_inventory.Location = new Point(0, 200);
            dgv_inventory.Name = "dgv_inventory";
            dgv_inventory.RowHeadersWidth = 51;
            dgv_inventory.Size = new Size(784, 190);
            dgv_inventory.TabIndex = 0;
            // 
            // pnl_footer
            // 
            pnl_footer.Controls.Add(lbl_needOrder);
            pnl_footer.Controls.Add(lbl_timeUpdate);
            pnl_footer.Dock = DockStyle.Bottom;
            pnl_footer.Location = new Point(0, 390);
            pnl_footer.Name = "pnl_footer";
            pnl_footer.Size = new Size(784, 25);
            pnl_footer.TabIndex = 4;
            // 
            // lbl_needOrder
            // 
            lbl_needOrder.Location = new Point(547, 3);
            lbl_needOrder.Name = "lbl_needOrder";
            lbl_needOrder.Size = new Size(194, 20);
            lbl_needOrder.TabIndex = 0;
            lbl_needOrder.Text = "Cần nhập thêm: 6 sản phẩm";
            // 
            // lbl_timeUpdate
            // 
            lbl_timeUpdate.Location = new Point(20, 3);
            lbl_timeUpdate.Name = "lbl_timeUpdate";
            lbl_timeUpdate.Size = new Size(226, 20);
            lbl_timeUpdate.TabIndex = 1;
            lbl_timeUpdate.Text = "Cập nhật lúc: 09:30 01/06/2026";
            lbl_timeUpdate.Click += lbl_timeUpdate_Click;
            // 
            // FormInventory
            // 
            ClientSize = new Size(784, 415);
            Controls.Add(dgv_inventory);
            Controls.Add(pnl_dashboard);
            Controls.Add(pnl_filters);
            Controls.Add(pnl_header);
            Controls.Add(pnl_footer);
            Name = "FormInventory";
            Text = "Kiểm kê tồn kho";
            Load += FormInventory_Load;
            pnl_header.ResumeLayout(false);
            pnl_filters.ResumeLayout(false);
            pnl_dashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_inventory).EndInit();
            pnl_footer.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.Panel pnl_filters;
        private System.Windows.Forms.ComboBox cb_statusFilter;
        private System.Windows.Forms.ComboBox cb_categories;
        private System.Windows.Forms.Panel pnl_dashboard;
        private System.Windows.Forms.Label lbl_totalCount;
        private System.Windows.Forms.Label lbl_outOfStockCount;
        private System.Windows.Forms.Label lbl_warningCount;
        private System.Windows.Forms.Label lbl_availableCount;
        private System.Windows.Forms.DataGridView dgv_inventory;
        private System.Windows.Forms.Panel pnl_footer;
        private System.Windows.Forms.Label lbl_needOrder;
        private System.Windows.Forms.Label lbl_timeUpdate;
    }
}