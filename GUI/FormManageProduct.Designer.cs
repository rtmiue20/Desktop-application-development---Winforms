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

        private void InitializeComponent()
        {
            pnl_topBar = new System.Windows.Forms.Panel();
            btn_productRefresh = new System.Windows.Forms.Button();
            btn_category = new System.Windows.Forms.Button();
            btn_productDelete = new System.Windows.Forms.Button();
            btn_productEdit = new System.Windows.Forms.Button();
            btn_productAdd = new System.Windows.Forms.Button();
            pnl_Bottom = new System.Windows.Forms.Panel();
            lbl_inventoryWarning = new System.Windows.Forms.Label();
            lbl_statusSummary = new System.Windows.Forms.Label();
            pnl_Left = new System.Windows.Forms.Panel();
            dgv_categoryFilter = new System.Windows.Forms.DataGridView();
            lbl_CategoryTitle = new System.Windows.Forms.Label();
            pnl_main = new System.Windows.Forms.Panel();
            dgv_productList = new System.Windows.Forms.DataGridView();
            pnl_mainTop = new System.Windows.Forms.Panel();
            cbb_statusFilter = new System.Windows.Forms.ComboBox();
            pic_productImage = new System.Windows.Forms.PictureBox();
            pnl_topBar.SuspendLayout();
            pnl_Bottom.SuspendLayout();
            pnl_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_categoryFilter).BeginInit();
            pnl_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_productList).BeginInit();
            pnl_mainTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_productImage).BeginInit();
            SuspendLayout();
            // 
            // pnl_topBar
            // 
            pnl_topBar.Controls.Add(btn_productRefresh);
            pnl_topBar.Controls.Add(btn_category);
            pnl_topBar.Controls.Add(btn_productDelete);
            pnl_topBar.Controls.Add(btn_productEdit);
            pnl_topBar.Controls.Add(btn_productAdd);
            pnl_topBar.Dock = System.Windows.Forms.DockStyle.Top;
            pnl_topBar.Location = new System.Drawing.Point(0, 0);
            pnl_topBar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            pnl_topBar.Name = "pnl_topBar";
            pnl_topBar.Size = new System.Drawing.Size(2091, 154);
            pnl_topBar.TabIndex = 0;
            // 
            // btn_productRefresh
            // 
            btn_productRefresh.Location = new System.Drawing.Point(935, 38);
            btn_productRefresh.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            btn_productRefresh.Name = "btn_productRefresh";
            btn_productRefresh.Size = new System.Drawing.Size(212, 77);
            btn_productRefresh.TabIndex = 4;
            btn_productRefresh.Text = "Làm mới";
            btn_productRefresh.UseVisualStyleBackColor = true;
            btn_productRefresh.Click += btn_ProductRefresh_Click;
            // 
            // btn_category
            // 
            btn_category.Location = new System.Drawing.Point(722, 38);
            btn_category.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            btn_category.Name = "btn_category";
            btn_category.Size = new System.Drawing.Size(212, 77);
            btn_category.TabIndex = 3;
            btn_category.Text = "Danh mục";
            btn_category.UseVisualStyleBackColor = true;
            btn_category.Click += btn_Category_Click;
            // 
            // btn_productDelete
            // 
            btn_productDelete.Location = new System.Drawing.Point(510, 38);
            btn_productDelete.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            btn_productDelete.Name = "btn_productDelete";
            btn_productDelete.Size = new System.Drawing.Size(212, 77);
            btn_productDelete.TabIndex = 2;
            btn_productDelete.Text = "Xóa";
            btn_productDelete.UseVisualStyleBackColor = true;
            btn_productDelete.Click += btn_ProductDelete_Click;
            // 
            // btn_productEdit
            // 
            btn_productEdit.Location = new System.Drawing.Point(298, 38);
            btn_productEdit.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            btn_productEdit.Name = "btn_productEdit";
            btn_productEdit.Size = new System.Drawing.Size(212, 77);
            btn_productEdit.TabIndex = 1;
            btn_productEdit.Text = "Sửa";
            btn_productEdit.UseVisualStyleBackColor = true;
            btn_productEdit.Click += btn_ProductEdit_Click;
            // 
            // btn_productAdd
            // 
            btn_productAdd.Location = new System.Drawing.Point(42, 38);
            btn_productAdd.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            btn_productAdd.Name = "btn_productAdd";
            btn_productAdd.Size = new System.Drawing.Size(255, 77);
            btn_productAdd.TabIndex = 0;
            btn_productAdd.Text = "Thêm SP";
            btn_productAdd.UseVisualStyleBackColor = true;
            btn_productAdd.Click += btn_ProductAdd_Click;
            // 
            // pnl_Bottom
            // 
            pnl_Bottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnl_Bottom.Controls.Add(lbl_inventoryWarning);
            pnl_Bottom.Controls.Add(lbl_statusSummary);
            pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnl_Bottom.Location = new System.Drawing.Point(0, 1364);
            pnl_Bottom.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            pnl_Bottom.Name = "pnl_Bottom";
            pnl_Bottom.Size = new System.Drawing.Size(2091, 74);
            pnl_Bottom.TabIndex = 1;
            // 
            // lbl_inventoryWarning
            // 
            lbl_inventoryWarning.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            lbl_inventoryWarning.AutoSize = true;
            lbl_inventoryWarning.ForeColor = System.Drawing.Color.DimGray;
            lbl_inventoryWarning.Location = new System.Drawing.Point(1596, 15);
            lbl_inventoryWarning.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lbl_inventoryWarning.Name = "lbl_inventoryWarning";
            lbl_inventoryWarning.Size = new System.Drawing.Size(484, 41);
            lbl_inventoryWarning.TabIndex = 1;
            lbl_inventoryWarning.Text = "Tồn kho thấp: 0 SP | Hết hàng: 0 SP";
            lbl_inventoryWarning.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_statusSummary
            // 
            lbl_statusSummary.AutoSize = true;
            lbl_statusSummary.Location = new System.Drawing.Point(26, 15);
            lbl_statusSummary.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lbl_statusSummary.Name = "lbl_statusSummary";
            lbl_statusSummary.Size = new System.Drawing.Size(525, 41);
            lbl_statusSummary.TabIndex = 0;
            lbl_statusSummary.Text = "Tổng: 0 sản phẩm | Đang chọn: Không";
            // 
            // pnl_Left
            // 
            pnl_Left.BackColor = System.Drawing.Color.White;
            pnl_Left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnl_Left.Controls.Add(dgv_categoryFilter);
            pnl_Left.Controls.Add(lbl_CategoryTitle);
            pnl_Left.Dock = System.Windows.Forms.DockStyle.Left;
            pnl_Left.Location = new System.Drawing.Point(0, 154);
            pnl_Left.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            pnl_Left.Name = "pnl_Left";
            pnl_Left.Size = new System.Drawing.Size(465, 1210);
            pnl_Left.TabIndex = 2;
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
            dgv_categoryFilter.Location = new System.Drawing.Point(0, 102);
            dgv_categoryFilter.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            dgv_categoryFilter.MultiSelect = false;
            dgv_categoryFilter.Name = "dgv_categoryFilter";
            dgv_categoryFilter.ReadOnly = true;
            dgv_categoryFilter.RowHeadersVisible = false;
            dgv_categoryFilter.RowHeadersWidth = 102;
            dgv_categoryFilter.RowTemplate.Height = 35;
            dgv_categoryFilter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgv_categoryFilter.Size = new System.Drawing.Size(463, 1106);
            dgv_categoryFilter.TabIndex = 1;
            dgv_categoryFilter.CellClick += dgv_CategoryFilter_CellClick;
            // 
            // lbl_CategoryTitle
            // 
            lbl_CategoryTitle.Dock = System.Windows.Forms.DockStyle.Top;
            lbl_CategoryTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lbl_CategoryTitle.Location = new System.Drawing.Point(0, 0);
            lbl_CategoryTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lbl_CategoryTitle.Name = "lbl_CategoryTitle";
            lbl_CategoryTitle.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            lbl_CategoryTitle.Size = new System.Drawing.Size(463, 102);
            lbl_CategoryTitle.TabIndex = 0;
            lbl_CategoryTitle.Text = "Danh mục";
            lbl_CategoryTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_main
            // 
            pnl_main.Controls.Add(dgv_productList);
            pnl_main.Controls.Add(pnl_mainTop);
            pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl_main.Location = new System.Drawing.Point(465, 154);
            pnl_main.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            pnl_main.Name = "pnl_main";
            pnl_main.Padding = new System.Windows.Forms.Padding(21, 26, 21, 26);
            pnl_main.Size = new System.Drawing.Size(1626, 1210);
            pnl_main.TabIndex = 3;
            // 
            // dgv_productList
            // 
            dgv_productList.AllowUserToAddRows = false;
            dgv_productList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgv_productList.BackgroundColor = System.Drawing.Color.White;
            dgv_productList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_productList.Dock = System.Windows.Forms.DockStyle.Fill;
            dgv_productList.Location = new System.Drawing.Point(21, 154);
            dgv_productList.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            dgv_productList.Name = "dgv_productList";
            dgv_productList.ReadOnly = true;
            dgv_productList.RowHeadersWidth = 102;
            dgv_productList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgv_productList.Size = new System.Drawing.Size(1584, 1030);
            dgv_productList.TabIndex = 1;
            dgv_productList.CellClick += dgv_ProductList_CellClick;
            dgv_productList.CellFormatting += dgv_ProductList_CellFormatting;
            // 
            // pnl_mainTop
            // 
            pnl_mainTop.Controls.Add(pic_productImage);
            pnl_mainTop.Controls.Add(cbb_statusFilter);
            pnl_mainTop.Dock = System.Windows.Forms.DockStyle.Top;
            pnl_mainTop.Location = new System.Drawing.Point(21, 26);
            pnl_mainTop.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            pnl_mainTop.Name = "pnl_mainTop";
            pnl_mainTop.Size = new System.Drawing.Size(1584, 128);
            pnl_mainTop.TabIndex = 0;
            // 
            // cbb_statusFilter
            // 
            cbb_statusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbb_statusFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            cbb_statusFilter.FormattingEnabled = true;
            cbb_statusFilter.Items.AddRange(new object[] { "Tất cả trạng thái", "Còn hàng", "Sắp hết", "Hết hàng" });
            cbb_statusFilter.Location = new System.Drawing.Point(0, 26);
            cbb_statusFilter.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            cbb_statusFilter.Name = "cbb_statusFilter";
            cbb_statusFilter.Size = new System.Drawing.Size(640, 47);
            cbb_statusFilter.TabIndex = 0;
            cbb_statusFilter.SelectedIndexChanged += cb_StatusFilter_SelectedIndexChanged;
            // 
            // pic_productImage
            // 
            pic_productImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            pic_productImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pic_productImage.Location = new System.Drawing.Point(1370, 8);
            pic_productImage.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            pic_productImage.Name = "pic_productImage";
            pic_productImage.Size = new System.Drawing.Size(200, 110);
            pic_productImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pic_productImage.TabIndex = 1;
            pic_productImage.TabStop = false;
            // 
            // FormManageProduct
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(2091, 1438);
            Controls.Add(pnl_main);
            Controls.Add(pnl_Left);
            Controls.Add(pnl_Bottom);
            Controls.Add(pnl_topBar);
            Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            Text = "Quản lý sản phẩm";
            Load += FormManageProduct_Load;
            pnl_topBar.ResumeLayout(false);
            pnl_Bottom.ResumeLayout(false);
            pnl_Bottom.PerformLayout();
            pnl_Left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_categoryFilter).EndInit();
            pnl_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_productList).EndInit();
            pnl_mainTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_productImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnl_topBar;
        private System.Windows.Forms.Button btn_productAdd;
        private System.Windows.Forms.Button btn_productEdit;
        private System.Windows.Forms.Button btn_productDelete;
        private System.Windows.Forms.Button btn_category;
        private System.Windows.Forms.Button btn_productRefresh;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Label lbl_statusSummary;
        private System.Windows.Forms.Label lbl_inventoryWarning;
        private System.Windows.Forms.Panel pnl_Left;
        private System.Windows.Forms.Label lbl_CategoryTitle;
        private System.Windows.Forms.DataGridView dgv_categoryFilter;
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Panel pnl_mainTop;
        private System.Windows.Forms.ComboBox cbb_statusFilter;
        private System.Windows.Forms.DataGridView dgv_productList;
        private System.Windows.Forms.PictureBox pic_productImage;
    }
}