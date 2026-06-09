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
            grp_Actions = new GroupBox();
            btn_ProductRefresh = new Button();
            btn_Category = new Button();
            btn_ProductDelete = new Button();
            btn_ProductEdit = new Button();
            btn_ProductAdd = new Button();
            grp_Status = new GroupBox();
            lbl_InventoryWarning = new Label();
            lbl_StatusSummary = new Label();
            grp_CategoryFilter = new GroupBox();
            dgv_CategoryFilter = new DataGridView();
            grp_ProductList = new GroupBox();
            dgv_ProductList = new DataGridView();
            grp_Filter = new GroupBox();
            cb_StatusFilter = new ComboBox();
            grp_Actions.SuspendLayout();
            grp_Status.SuspendLayout();
            grp_CategoryFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_CategoryFilter).BeginInit();
            grp_ProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_ProductList).BeginInit();
            grp_Filter.SuspendLayout();
            SuspendLayout();
            // 
            // grp_Actions
            // 
            grp_Actions.Controls.Add(btn_ProductRefresh);
            grp_Actions.Controls.Add(btn_Category);
            grp_Actions.Controls.Add(btn_ProductDelete);
            grp_Actions.Controls.Add(btn_ProductEdit);
            grp_Actions.Controls.Add(btn_ProductAdd);
            grp_Actions.Dock = DockStyle.Top;
            grp_Actions.Location = new Point(0, 0);
            grp_Actions.Name = "grp_Actions";
            grp_Actions.Size = new Size(861, 66);
            grp_Actions.TabIndex = 0;
            grp_Actions.TabStop = false;
            grp_Actions.Text = "Thao tác nghiệp vụ";
            // 
            // btn_ProductRefresh
            // 
            btn_ProductRefresh.Location = new Point(385, 23);
            btn_ProductRefresh.Name = "btn_ProductRefresh";
            btn_ProductRefresh.Size = new Size(88, 28);
            btn_ProductRefresh.TabIndex = 4;
            btn_ProductRefresh.Text = "Làm mới";
            btn_ProductRefresh.UseVisualStyleBackColor = true;
            btn_ProductRefresh.Click += btn_ProductRefresh_Click;
            // 
            // btn_Category
            // 
            btn_Category.Location = new Point(298, 23);
            btn_Category.Name = "btn_Category";
            btn_Category.Size = new Size(88, 28);
            btn_Category.TabIndex = 3;
            btn_Category.Text = "Danh mục";
            btn_Category.UseVisualStyleBackColor = true;
            btn_Category.Click += btn_Category_Click;
            // 
            // btn_ProductDelete
            // 
            btn_ProductDelete.Location = new Point(210, 23);
            btn_ProductDelete.Name = "btn_ProductDelete";
            btn_ProductDelete.Size = new Size(88, 28);
            btn_ProductDelete.TabIndex = 2;
            btn_ProductDelete.Text = "Xóa";
            btn_ProductDelete.UseVisualStyleBackColor = true;
            btn_ProductDelete.Click += btn_ProductDelete_Click;
            // 
            // btn_ProductEdit
            // 
            btn_ProductEdit.Location = new Point(122, 23);
            btn_ProductEdit.Name = "btn_ProductEdit";
            btn_ProductEdit.Size = new Size(88, 28);
            btn_ProductEdit.TabIndex = 1;
            btn_ProductEdit.Text = "Sửa";
            btn_ProductEdit.UseVisualStyleBackColor = true;
            btn_ProductEdit.Click += btn_ProductEdit_Click;
            // 
            // btn_ProductAdd
            // 
            btn_ProductAdd.Location = new Point(18, 23);
            btn_ProductAdd.Name = "btn_ProductAdd";
            btn_ProductAdd.Size = new Size(105, 28);
            btn_ProductAdd.TabIndex = 0;
            btn_ProductAdd.Text = " Thêm SP";
            btn_ProductAdd.UseVisualStyleBackColor = true;
            btn_ProductAdd.Click += btn_ProductAdd_Click;
            // 
            // grp_Status
            // 
            grp_Status.Controls.Add(lbl_InventoryWarning);
            grp_Status.Controls.Add(lbl_StatusSummary);
            grp_Status.Dock = DockStyle.Bottom;
            grp_Status.Location = new Point(0, 479);
            grp_Status.Name = "grp_Status";
            grp_Status.Size = new Size(861, 47);
            grp_Status.TabIndex = 1;
            grp_Status.TabStop = false;
            // 
            // lbl_InventoryWarning
            // 
            lbl_InventoryWarning.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_InventoryWarning.AutoSize = true;
            lbl_InventoryWarning.ForeColor = Color.DimGray;
            lbl_InventoryWarning.Location = new Point(656, 19);
            lbl_InventoryWarning.Name = "lbl_InventoryWarning";
            lbl_InventoryWarning.Size = new Size(192, 15);
            lbl_InventoryWarning.TabIndex = 1;
            lbl_InventoryWarning.Text = "Tồn kho thấp: 0 SP | Hết hàng: 0 SP";
            lbl_InventoryWarning.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_StatusSummary
            // 
            lbl_StatusSummary.AutoSize = true;
            lbl_StatusSummary.Location = new Point(10, 19);
            lbl_StatusSummary.Name = "lbl_StatusSummary";
            lbl_StatusSummary.Size = new Size(210, 15);
            lbl_StatusSummary.TabIndex = 0;
            lbl_StatusSummary.Text = "Tổng: 0 sản phẩm | Đang chọn: Không";
            // 
            // grp_CategoryFilter
            // 
            grp_CategoryFilter.Controls.Add(dgv_CategoryFilter);
            grp_CategoryFilter.Dock = DockStyle.Left;
            grp_CategoryFilter.Location = new Point(0, 66);
            grp_CategoryFilter.Name = "grp_CategoryFilter";
            grp_CategoryFilter.Size = new Size(192, 413);
            grp_CategoryFilter.TabIndex = 2;
            grp_CategoryFilter.TabStop = false;
            grp_CategoryFilter.Text = "Lọc theo danh mục";
            // 
            // dgv_CategoryFilter
            // 
            dgv_CategoryFilter.AllowUserToAddRows = false;
            dgv_CategoryFilter.AllowUserToDeleteRows = false;
            dgv_CategoryFilter.AllowUserToResizeColumns = false;
            dgv_CategoryFilter.AllowUserToResizeRows = false;
            dgv_CategoryFilter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_CategoryFilter.BackgroundColor = Color.White;
            dgv_CategoryFilter.BorderStyle = BorderStyle.None;
            dgv_CategoryFilter.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_CategoryFilter.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_CategoryFilter.ColumnHeadersVisible = false;
            dgv_CategoryFilter.Dock = DockStyle.Fill;
            dgv_CategoryFilter.Location = new Point(3, 19);
            dgv_CategoryFilter.MultiSelect = false;
            dgv_CategoryFilter.Name = "dgv_CategoryFilter";
            dgv_CategoryFilter.ReadOnly = true;
            dgv_CategoryFilter.RowHeadersVisible = false;
            dgv_CategoryFilter.RowTemplate.Height = 35;
            dgv_CategoryFilter.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_CategoryFilter.Size = new Size(186, 391);
            dgv_CategoryFilter.TabIndex = 1;
            dgv_CategoryFilter.CellClick += dgv_CategoryFilter_CellClick;
            // 
            // grp_ProductList
            // 
            grp_ProductList.Controls.Add(dgv_ProductList);
            grp_ProductList.Controls.Add(grp_Filter);
            grp_ProductList.Dock = DockStyle.Fill;
            grp_ProductList.Location = new Point(192, 66);
            grp_ProductList.Name = "grp_ProductList";
            grp_ProductList.Size = new Size(669, 413);
            grp_ProductList.TabIndex = 3;
            grp_ProductList.TabStop = false;
            grp_ProductList.Text = "Danh sách sản phẩm";
            // 
            // dgv_ProductList
            // 
            dgv_ProductList.AllowUserToAddRows = false;
            dgv_ProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_ProductList.BackgroundColor = Color.White;
            dgv_ProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ProductList.Dock = DockStyle.Fill;
            dgv_ProductList.Location = new Point(3, 75);
            dgv_ProductList.Name = "dgv_ProductList";
            dgv_ProductList.ReadOnly = true;
            dgv_ProductList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_ProductList.Size = new Size(663, 335);
            dgv_ProductList.TabIndex = 1;
            dgv_ProductList.CellClick += dgv_ProductList_CellClick;
            dgv_ProductList.CellFormatting += dgv_ProductList_CellFormatting;
            // 
            // grp_Filter
            // 
            grp_Filter.Controls.Add(cb_StatusFilter);
            grp_Filter.Dock = DockStyle.Top;
            grp_Filter.Location = new Point(3, 19);
            grp_Filter.Name = "grp_Filter";
            grp_Filter.Size = new Size(663, 56);
            grp_Filter.TabIndex = 0;
            grp_Filter.TabStop = false;
            grp_Filter.Text = "Trạng thái tồn kho";
            // 
            // cb_StatusFilter
            // 
            cb_StatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_StatusFilter.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_StatusFilter.FormattingEnabled = true;
            cb_StatusFilter.Items.AddRange(new object[] { "Tất cả trạng thái", "Còn hàng", "Sắp hết", "Hết hàng" });
            cb_StatusFilter.Location = new Point(9, 19);
            cb_StatusFilter.Name = "cb_StatusFilter";
            cb_StatusFilter.Size = new Size(219, 25);
            cb_StatusFilter.TabIndex = 0;
            cb_StatusFilter.SelectedIndexChanged += cb_StatusFilter_SelectedIndexChanged;
            // 
            // FormManageProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 526);
            Controls.Add(grp_ProductList);
            Controls.Add(grp_CategoryFilter);
            Controls.Add(grp_Status);
            Controls.Add(grp_Actions);
            Name = "FormManageProduct";
            Text = "Quản lý sản phẩm";
            Load += FormManageProduct_Load;
            grp_Actions.ResumeLayout(false);
            grp_Status.ResumeLayout(false);
            grp_Status.PerformLayout();
            grp_CategoryFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_CategoryFilter).EndInit();
            grp_ProductList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_ProductList).EndInit();
            grp_Filter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        // Khai báo thay thế các Panel thành GroupBox
        private System.Windows.Forms.GroupBox grp_Actions;
        private System.Windows.Forms.GroupBox grp_Status;
        private System.Windows.Forms.GroupBox grp_CategoryFilter;
        private System.Windows.Forms.GroupBox grp_ProductList;
        private System.Windows.Forms.GroupBox grp_Filter;

        // Các thành phần control còn lại giữ nguyên logic
        private System.Windows.Forms.Button btn_ProductAdd;
        private System.Windows.Forms.Button btn_ProductEdit;
        private System.Windows.Forms.Button btn_ProductDelete;
        private System.Windows.Forms.Button btn_Category;
        private System.Windows.Forms.Button btn_ProductRefresh;
        private System.Windows.Forms.Label lbl_StatusSummary;
        private System.Windows.Forms.Label lbl_InventoryWarning;
        private System.Windows.Forms.DataGridView dgv_CategoryFilter;
        private System.Windows.Forms.ComboBox cb_StatusFilter;
        private System.Windows.Forms.DataGridView dgv_ProductList;
    }
}