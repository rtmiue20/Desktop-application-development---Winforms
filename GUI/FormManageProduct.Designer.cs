namespace GUI
{
    partial class FormManageProduct
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grp_topBar = new System.Windows.Forms.GroupBox();
            btn_productRefresh = new System.Windows.Forms.Button();
            btn_category = new System.Windows.Forms.Button();
            btn_productDelete = new System.Windows.Forms.Button();
            btn_productEdit = new System.Windows.Forms.Button();
            btn_productAdd = new System.Windows.Forms.Button();
            grp_bottom = new System.Windows.Forms.GroupBox();
            lbl_inventoryWarning = new System.Windows.Forms.Label();
            lbl_statusSummary = new System.Windows.Forms.Label();
            grp_left = new System.Windows.Forms.GroupBox();
            dgv_categoryFilter = new System.Windows.Forms.DataGridView();
            grp_main = new System.Windows.Forms.GroupBox();
            dgv_productList = new System.Windows.Forms.DataGridView();
            grp_mainTop = new System.Windows.Forms.GroupBox();
            cbb_statusFilter = new System.Windows.Forms.ComboBox();
            grp_topBar.SuspendLayout();
            grp_bottom.SuspendLayout();
            grp_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_categoryFilter).BeginInit();
            grp_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_productList).BeginInit();
            grp_mainTop.SuspendLayout();
            SuspendLayout();
            // 
            // grp_topBar
            // 
            grp_topBar.Controls.Add(btn_productRefresh);
            grp_topBar.Controls.Add(btn_category);
            grp_topBar.Controls.Add(btn_productDelete);
            grp_topBar.Controls.Add(btn_productEdit);
            grp_topBar.Controls.Add(btn_productAdd);
            grp_topBar.Dock = System.Windows.Forms.DockStyle.Top;
            grp_topBar.Location = new System.Drawing.Point(0, 0);
            grp_topBar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8); // StandardMargin
            grp_topBar.Name = "grp_topBar";
            grp_topBar.Padding = new System.Windows.Forms.Padding(6); // StandardPadding
            grp_topBar.Size = new System.Drawing.Size(1587, 102); // PanelHeaderHeight = 102
            grp_topBar.TabIndex = 0;
            grp_topBar.TabStop = false;
            // 
            // btn_productRefresh
            // 
            btn_productRefresh.Location = new System.Drawing.Point(1228, 12); // ButtonTopBarRefreshLocation = (1228, 12)
            btn_productRefresh.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            btn_productRefresh.Name = "btn_productRefresh";
            btn_productRefresh.Size = new System.Drawing.Size(347, 63); // ButtonTopBarRefreshWidth = 347, Height = 63
            btn_productRefresh.TabIndex = 4;
            btn_productRefresh.Text = "Làm mới";
            btn_productRefresh.UseVisualStyleBackColor = true;
            btn_productRefresh.Click += btn_productRefresh_Click;
            // 
            // btn_category
            // 
            // Nút Category xếp nối tiếp hoặc đè tùy chỉnh, tạm thời để chung tọa độ nút chức năng góc phải
            btn_category.Location = new System.Drawing.Point(1228, 12);
            btn_category.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            btn_category.Name = "btn_category";
            btn_category.Size = new System.Drawing.Size(347, 63);
            btn_category.TabIndex = 3;
            btn_category.Text = "Danh mục";
            btn_category.UseVisualStyleBackColor = true;
            btn_category.Visible = false; // Tạm ẩn nếu không dùng thanh Top Bar, lọc theo Grid trái chuyên nghiệp hơn
            btn_category.Click += btn_category_Click;
            // 
            // btn_productDelete
            // 
            btn_productDelete.Location = new System.Drawing.Point(801, 12); // ButtonTopBarDeleteLocation = (801, 12)
            btn_productDelete.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            btn_productDelete.Name = "btn_productDelete";
            btn_productDelete.Size = new System.Drawing.Size(421, 63); // ButtonTopBarDeleteWidth = 421, Height = 63
            btn_productDelete.TabIndex = 2;
            btn_productDelete.Text = "Xóa";
            btn_productDelete.UseVisualStyleBackColor = true;
            btn_productDelete.Click += btn_productDelete_Click;
            // 
            // btn_productEdit
            // 
            btn_productEdit.Location = new System.Drawing.Point(393, 12); // ButtonTopBarEditLocation = (393, 12)
            btn_productEdit.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            btn_productEdit.Name = "btn_productEdit";
            btn_productEdit.Size = new System.Drawing.Size(402, 63); // ButtonTopBarEditWidth = 402, Height = 63
            btn_productEdit.TabIndex = 1;
            btn_productEdit.Text = "Sửa";
            btn_productEdit.UseVisualStyleBackColor = true;
            btn_productEdit.Click += btn_productEdit_Click;
            // 
            // btn_productAdd
            // 
            btn_productAdd.Location = new System.Drawing.Point(12, 12); // ButtonTopBarAddLocation = (12, 12)
            btn_productAdd.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            btn_productAdd.Name = "btn_productAdd";
            btn_productAdd.Size = new System.Drawing.Size(375, 63); // ButtonTopBarAddWidth = 375, Height = 63
            btn_productAdd.TabIndex = 0;
            btn_productAdd.Text = "Thêm SP";
            btn_productAdd.UseVisualStyleBackColor = true;
            btn_productAdd.Click += btn_productAdd_Click;
            // 
            // grp_bottom
            // 
            grp_bottom.Controls.Add(lbl_inventoryWarning);
            grp_bottom.Controls.Add(lbl_statusSummary);
            grp_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            grp_bottom.Location = new System.Drawing.Point(0, 848); // 950 tổng - 102 chiều cao panel status
            grp_bottom.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            grp_bottom.Name = "grp_bottom";
            grp_bottom.Padding = new System.Windows.Forms.Padding(6);
            grp_bottom.Size = new System.Drawing.Size(1587, 102); // PanelStatusHeight = 102
            grp_bottom.TabIndex = 1;
            grp_bottom.TabStop = false;
            // 
            // lbl_inventoryWarning
            // 
            lbl_inventoryWarning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            lbl_inventoryWarning.AutoSize = true;
            lbl_inventoryWarning.ForeColor = System.Drawing.Color.DimGray;
            lbl_inventoryWarning.Location = new System.Drawing.Point(1200, 42);
            lbl_inventoryWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_inventoryWarning.Name = "lbl_inventoryWarning";
            lbl_inventoryWarning.Size = new System.Drawing.Size(236, 19);
            lbl_inventoryWarning.TabIndex = 1;
            lbl_inventoryWarning.Text = "Tồn kho thấp: 0 SP | Hết hàng: 0 SP";
            lbl_inventoryWarning.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_statusSummary
            // 
            lbl_statusSummary.AutoSize = true;
            lbl_statusSummary.Location = new System.Drawing.Point(20, 42);
            lbl_statusSummary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_statusSummary.Name = "lbl_statusSummary";
            lbl_statusSummary.Size = new System.Drawing.Size(268, 19);
            lbl_statusSummary.TabIndex = 0;
            lbl_statusSummary.Text = "Tổng: 0 sản phẩm | Đang chọn: Không";
            // 
            // grp_left
            // 
            grp_left.BackColor = System.Drawing.Color.White;
            grp_left.Controls.Add(dgv_categoryFilter);
            grp_left.Dock = System.Windows.Forms.DockStyle.Left;
            grp_left.Location = new System.Drawing.Point(0, 102);
            grp_left.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            grp_left.Name = "grp_left";
            grp_left.Padding = new System.Windows.Forms.Padding(6);
            grp_left.Size = new System.Drawing.Size(640, 746); // PanelLeftWidth = 640
            grp_left.TabIndex = 2;
            grp_left.TabStop = false;
            grp_left.Text = "Danh mục";
            // 
            // dgv_categoryFilter
            // 
            dgv_categoryFilter.AllowUserToAddRows = false;
            dgv_categoryFilter.AllowUserToDeleteRows = false;
            dgv_categoryFilter.AllowUserToResizeColumns = false;
            dgv_categoryFilter.AllowUserToResizeRows = false;
            dgv_categoryFilter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgv_categoryFilter.BackgroundColor = System.Drawing.Color.White;
            dgv_categoryFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgv_categoryFilter.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dgv_categoryFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_categoryFilter.ColumnHeadersVisible = false;
            dgv_categoryFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            dgv_categoryFilter.Location = new System.Drawing.Point(6, 32);
            dgv_categoryFilter.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            dgv_categoryFilter.MultiSelect = false;
            dgv_categoryFilter.Name = "dgv_categoryFilter";
            dgv_categoryFilter.ReadOnly = true;
            dgv_categoryFilter.RowHeadersVisible = false;
            dgv_categoryFilter.RowHeadersWidth = 102; // DataGridViewRowHeadersWidth = 102
            dgv_categoryFilter.RowTemplate.Height = 45;
            dgv_categoryFilter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgv_categoryFilter.Size = new System.Drawing.Size(628, 708);
            dgv_categoryFilter.TabIndex = 1;
            dgv_categoryFilter.CellClick += dgv_categoryFilter_CellClick;
            // 
            // grp_main
            // 
            grp_main.Controls.Add(dgv_productList);
            grp_main.Controls.Add(grp_mainTop);
            grp_main.Dock = System.Windows.Forms.DockStyle.Fill;
            grp_main.Location = new System.Drawing.Point(640, 102);
            grp_main.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            grp_main.Name = "grp_main";
            grp_main.Padding = new System.Windows.Forms.Padding(10);
            grp_main.Size = new System.Drawing.Size(947, 746); // PanelRightWidth = 947 (1587 tổng - 640 trái)
            grp_main.TabIndex = 3;
            grp_main.TabStop = false;
            grp_main.Text = "Trạng thái sản phẩm";
            // 
            // dgv_productList
            // 
            dgv_productList.AllowUserToAddRows = false;
            dgv_productList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgv_productList.BackgroundColor = System.Drawing.Color.White;
            dgv_productList.ColumnHeadersHeight = 58; // DataGridViewColumnHeadersHeight = 58
            dgv_productList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv_productList.Dock = System.Windows.Forms.DockStyle.Fill;
            dgv_productList.Location = new System.Drawing.Point(10, 90);
            dgv_productList.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            dgv_productList.Name = "dgv_productList";
            dgv_productList.ReadOnly = true;
            dgv_productList.RowHeadersWidth = 102; // DataGridViewRowHeadersWidth = 102
            dgv_productList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgv_productList.Size = new System.Drawing.Size(927, 646);
            dgv_productList.TabIndex = 1;
            dgv_productList.CellClick += dgv_productList_CellClick;
            dgv_productList.CellFormatting += dgv_productList_CellFormatting;
            // 
            // grp_mainTop
            // 
            grp_mainTop.Controls.Add(cbb_statusFilter);
            grp_mainTop.Dock = System.Windows.Forms.DockStyle.Top;
            grp_mainTop.Location = new System.Drawing.Point(10, 26);
            grp_mainTop.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            grp_mainTop.Name = "grp_mainTop";
            grp_mainTop.Padding = new System.Windows.Forms.Padding(6);
            grp_mainTop.Size = new System.Drawing.Size(927, 64);
            grp_mainTop.TabIndex = 0;
            grp_mainTop.TabStop = false;
            // 
            // cbb_statusFilter
            // 
            cbb_statusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbb_statusFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            cbb_statusFilter.FormattingEnabled = true;
            cbb_statusFilter.Items.AddRange(new object[] { "Tất cả trạng thái", "Còn hàng", "Sắp hết", "Hết hàng" });
            cbb_statusFilter.Location = new System.Drawing.Point(6, 16);
            cbb_statusFilter.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            cbb_statusFilter.Name = "cbb_statusFilter";
            cbb_statusFilter.Size = new System.Drawing.Size(915, 29);
            cbb_statusFilter.TabIndex = 0;
            cbb_statusFilter.SelectedIndexChanged += cbb_statusFilter_SelectedIndexChanged;
            // 
            // FormManageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F); // StandardAutoScaleDimensions = (17F, 41F)
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; // StandardAutoScaleMode = Font
            this.ClientSize = new System.Drawing.Size(1587, 950); // StandardFormSize = (1587, 950)
            this.Controls.Add(grp_main);
            this.Controls.Add(grp_left);
            this.Controls.Add(grp_bottom);
            this.Controls.Add(grp_topBar);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8); // StandardMargin
            this.Text = "Quản lý sản phẩm";
            this.Load += FormManageProduct_Load;
            grp_topBar.ResumeLayout(false);
            grp_bottom.ResumeLayout(false);
            grp_bottom.PerformLayout();
            grp_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_categoryFilter).EndInit();
            grp_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_productList).EndInit();
            grp_mainTop.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grp_topBar;
        private System.Windows.Forms.Button btn_productAdd;
        private System.Windows.Forms.Button btn_productEdit;
        private System.Windows.Forms.Button btn_productDelete;
        private System.Windows.Forms.Button btn_category;
        private System.Windows.Forms.Button btn_productRefresh;
        private System.Windows.Forms.GroupBox grp_bottom;
        private System.Windows.Forms.Label lbl_statusSummary;
        private System.Windows.Forms.Label lbl_inventoryWarning;
        private System.Windows.Forms.GroupBox grp_left;
        private System.Windows.Forms.DataGridView dgv_categoryFilter;
        private System.Windows.Forms.GroupBox grp_main;
        private System.Windows.Forms.GroupBox grp_mainTop;
        private System.Windows.Forms.ComboBox cbb_statusFilter;
        private System.Windows.Forms.DataGridView dgv_productList;
    }
}