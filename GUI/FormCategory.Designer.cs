namespace GUI
{
    partial class FormCategory
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
            btn_categoryRefresh = new Button();
            btn_categoryDelete = new Button();
            btn_categoryEdit = new Button();
            btn_categoryAdd = new Button();
            grp_CategorySearch = new GroupBox();
            txt_categorySearch = new TextBox();
            grp_CategoryList = new GroupBox();
            dgv_categoryList = new DataGridView();
            grp_CategoryDetails = new GroupBox();
            btn_categoryCancel = new Button();
            btn_categorySave = new Button();
            cbb_categoryStatus = new ComboBox();
            lbl_CategoryStatus = new Label();
            txt_categoryDesc = new TextBox();
            lbl_CategoryDesc = new Label();
            txt_categoryName = new TextBox();
            lbl_CategoryName = new Label();
            lbl_SectionTitle = new Label();
            grp_Status = new GroupBox();
            grp_Actions.SuspendLayout();
            grp_CategorySearch.SuspendLayout();
            grp_CategoryList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_categoryList).BeginInit();
            grp_CategoryDetails.SuspendLayout();
            SuspendLayout();
            // 
            // grp_Actions
            // 
            grp_Actions.Controls.Add(btn_categoryRefresh);
            grp_Actions.Controls.Add(btn_categoryDelete);
            grp_Actions.Controls.Add(btn_categoryEdit);
            grp_Actions.Controls.Add(btn_categoryAdd);
            grp_Actions.Dock = DockStyle.Top;
            grp_Actions.Location = new Point(0, 0);
            grp_Actions.Margin = new Padding(3, 2, 3, 2);
            grp_Actions.Name = "grp_Actions";
            grp_Actions.Padding = new Padding(3, 2, 3, 2);
            grp_Actions.Size = new Size(1050, 52);
            grp_Actions.TabIndex = 0;
            grp_Actions.TabStop = false;
            // 
            // btn_categoryRefresh
            // 
            btn_categoryRefresh.Location = new Point(298, 19);
            btn_categoryRefresh.Margin = new Padding(3, 2, 3, 2);
            btn_categoryRefresh.Name = "btn_categoryRefresh";
            btn_categoryRefresh.Size = new Size(88, 26);
            btn_categoryRefresh.TabIndex = 0;
            btn_categoryRefresh.Text = "Làm mới";
            btn_categoryRefresh.UseVisualStyleBackColor = true;
            // 
            // btn_categoryDelete
            // 
            btn_categoryDelete.Location = new Point(201, 19);
            btn_categoryDelete.Margin = new Padding(3, 2, 3, 2);
            btn_categoryDelete.Name = "btn_categoryDelete";
            btn_categoryDelete.Size = new Size(88, 26);
            btn_categoryDelete.TabIndex = 1;
            btn_categoryDelete.Text = "Xóa";
            btn_categoryDelete.UseVisualStyleBackColor = true;
            // 
            // btn_categoryEdit
            // 
            btn_categoryEdit.Location = new Point(105, 19);
            btn_categoryEdit.Margin = new Padding(3, 2, 3, 2);
            btn_categoryEdit.Name = "btn_categoryEdit";
            btn_categoryEdit.Size = new Size(88, 26);
            btn_categoryEdit.TabIndex = 2;
            btn_categoryEdit.Text = "Sửa";
            btn_categoryEdit.UseVisualStyleBackColor = true;
            // 
            // btn_categoryAdd
            // 
            btn_categoryAdd.Location = new Point(9, 19);
            btn_categoryAdd.Margin = new Padding(3, 2, 3, 2);
            btn_categoryAdd.Name = "btn_categoryAdd";
            btn_categoryAdd.Size = new Size(88, 26);
            btn_categoryAdd.TabIndex = 3;
            btn_categoryAdd.Text = "Thêm";
            btn_categoryAdd.UseVisualStyleBackColor = true;
            // 
            // grp_CategorySearch
            // 
            grp_CategorySearch.Controls.Add(txt_categorySearch);
            grp_CategorySearch.Dock = DockStyle.Top;
            grp_CategorySearch.Location = new Point(3, 18);
            grp_CategorySearch.Margin = new Padding(3, 2, 3, 2);
            grp_CategorySearch.Name = "grp_CategorySearch";
            grp_CategorySearch.Padding = new Padding(3, 2, 3, 2);
            grp_CategorySearch.Size = new Size(606, 45);
            grp_CategorySearch.TabIndex = 1;
            grp_CategorySearch.TabStop = false;
            grp_CategorySearch.Text = "Tìm kiếm danh mục";
            // 
            // txt_categorySearch
            // 
            txt_categorySearch.Location = new Point(9, 19);
            txt_categorySearch.Margin = new Padding(3, 2, 3, 2);
            txt_categorySearch.Name = "txt_categorySearch";
            txt_categorySearch.Size = new Size(596, 23);
            txt_categorySearch.TabIndex = 0;
            // 
            // grp_CategoryList
            // 
            grp_CategoryList.Controls.Add(dgv_categoryList);
            grp_CategoryList.Controls.Add(grp_CategorySearch);
            grp_CategoryList.Dock = DockStyle.Left;
            grp_CategoryList.Location = new Point(0, 52);
            grp_CategoryList.Margin = new Padding(3, 2, 3, 2);
            grp_CategoryList.Name = "grp_CategoryList";
            grp_CategoryList.Padding = new Padding(3, 2, 3, 2);
            grp_CategoryList.Size = new Size(612, 473);
            grp_CategoryList.TabIndex = 2;
            grp_CategoryList.TabStop = false;
            grp_CategoryList.Text = "Danh sách phân loại";
            // 
            // dgv_categoryList
            // 
            dgv_categoryList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_categoryList.Dock = DockStyle.Fill;
            dgv_categoryList.Location = new Point(3, 63);
            dgv_categoryList.Margin = new Padding(3, 2, 3, 2);
            dgv_categoryList.Name = "dgv_categoryList";
            dgv_categoryList.Size = new Size(606, 408);
            dgv_categoryList.TabIndex = 0;
            // 
            // grp_CategoryDetails
            // 
            grp_CategoryDetails.Controls.Add(btn_categoryCancel);
            grp_CategoryDetails.Controls.Add(btn_categorySave);
            grp_CategoryDetails.Controls.Add(cbb_categoryStatus);
            grp_CategoryDetails.Controls.Add(lbl_CategoryStatus);
            grp_CategoryDetails.Controls.Add(txt_categoryDesc);
            grp_CategoryDetails.Controls.Add(lbl_CategoryDesc);
            grp_CategoryDetails.Controls.Add(txt_categoryName);
            grp_CategoryDetails.Controls.Add(lbl_CategoryName);
            grp_CategoryDetails.Controls.Add(lbl_SectionTitle);
            grp_CategoryDetails.Dock = DockStyle.Fill;
            grp_CategoryDetails.Location = new Point(612, 52);
            grp_CategoryDetails.Margin = new Padding(3, 2, 3, 2);
            grp_CategoryDetails.Name = "grp_CategoryDetails";
            grp_CategoryDetails.Padding = new Padding(3, 2, 3, 2);
            grp_CategoryDetails.Size = new Size(438, 473);
            grp_CategoryDetails.TabIndex = 3;
            grp_CategoryDetails.TabStop = false;
            // 
            // btn_categoryCancel
            // 
            btn_categoryCancel.Location = new Point(324, 285);
            btn_categoryCancel.Margin = new Padding(3, 2, 3, 2);
            btn_categoryCancel.Name = "btn_categoryCancel";
            btn_categoryCancel.Size = new Size(88, 30);
            btn_categoryCancel.TabIndex = 0;
            btn_categoryCancel.Text = "Hủy";
            btn_categoryCancel.UseVisualStyleBackColor = true;
            // 
            // btn_categorySave
            // 
            btn_categorySave.Location = new Point(228, 285);
            btn_categorySave.Margin = new Padding(3, 2, 3, 2);
            btn_categorySave.Name = "btn_categorySave";
            btn_categorySave.Size = new Size(88, 30);
            btn_categorySave.TabIndex = 1;
            btn_categorySave.Text = "Lưu";
            btn_categorySave.UseVisualStyleBackColor = true;
            // 
            // cbb_categoryStatus
            // 
            cbb_categoryStatus.FormattingEnabled = true;
            cbb_categoryStatus.Location = new Point(18, 240);
            cbb_categoryStatus.Margin = new Padding(3, 2, 3, 2);
            cbb_categoryStatus.Name = "cbb_categoryStatus";
            cbb_categoryStatus.Size = new Size(394, 23);
            cbb_categoryStatus.TabIndex = 2;
            // 
            // lbl_CategoryStatus
            // 
            lbl_CategoryStatus.AutoSize = true;
            lbl_CategoryStatus.Location = new Point(18, 221);
            lbl_CategoryStatus.Name = "lbl_CategoryStatus";
            lbl_CategoryStatus.Size = new Size(63, 15);
            lbl_CategoryStatus.TabIndex = 3;
            lbl_CategoryStatus.Text = "Trạng thái:";
            // 
            // txt_categoryDesc
            // 
            txt_categoryDesc.Location = new Point(18, 131);
            txt_categoryDesc.Margin = new Padding(3, 2, 3, 2);
            txt_categoryDesc.Multiline = true;
            txt_categoryDesc.Name = "txt_categoryDesc";
            txt_categoryDesc.Size = new Size(394, 76);
            txt_categoryDesc.TabIndex = 4;
            // 
            // lbl_CategoryDesc
            // 
            lbl_CategoryDesc.AutoSize = true;
            lbl_CategoryDesc.Location = new Point(18, 112);
            lbl_CategoryDesc.Name = "lbl_CategoryDesc";
            lbl_CategoryDesc.Size = new Size(80, 15);
            lbl_CategoryDesc.TabIndex = 5;
            lbl_CategoryDesc.Text = "Mô tả chi tiết:";
            // 
            // txt_categoryName
            // 
            txt_categoryName.Location = new Point(18, 79);
            txt_categoryName.Margin = new Padding(3, 2, 3, 2);
            txt_categoryName.Name = "txt_categoryName";
            txt_categoryName.Size = new Size(394, 23);
            txt_categoryName.TabIndex = 6;
            // 
            // lbl_CategoryName
            // 
            lbl_CategoryName.AutoSize = true;
            lbl_CategoryName.Location = new Point(18, 60);
            lbl_CategoryName.Name = "lbl_CategoryName";
            lbl_CategoryName.Size = new Size(86, 15);
            lbl_CategoryName.TabIndex = 7;
            lbl_CategoryName.Text = "Tên danh mục:";
            // 
            // lbl_SectionTitle
            // 
            lbl_SectionTitle.AutoSize = true;
            lbl_SectionTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_SectionTitle.Location = new Point(18, 22);
            lbl_SectionTitle.Name = "lbl_SectionTitle";
            lbl_SectionTitle.Size = new Size(191, 21);
            lbl_SectionTitle.TabIndex = 8;
            lbl_SectionTitle.Text = "THÔNG TIN DANH MỤC";
            // 
            // grp_Status
            // 
            grp_Status.Location = new Point(0, 0);
            grp_Status.Name = "grp_Status";
            grp_Status.Size = new Size(200, 100);
            grp_Status.TabIndex = 0;
            grp_Status.TabStop = false;
            // 
            // FormCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 525);
            Controls.Add(grp_CategoryDetails);
            Controls.Add(grp_CategoryList);
            Controls.Add(grp_Actions);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormCategory";
            Text = "Quản lý danh mục sản phẩm";
            grp_Actions.ResumeLayout(false);
            grp_CategorySearch.ResumeLayout(false);
            grp_CategorySearch.PerformLayout();
            grp_CategoryList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_categoryList).EndInit();
            grp_CategoryDetails.ResumeLayout(false);
            grp_CategoryDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        // GroupBox
        private System.Windows.Forms.GroupBox grp_Actions;
        private System.Windows.Forms.GroupBox grp_CategorySearch;
        private System.Windows.Forms.GroupBox grp_CategoryList;
        private System.Windows.Forms.GroupBox grp_CategoryDetails;
        private System.Windows.Forms.GroupBox grp_Status;

       
        private System.Windows.Forms.Button btn_categoryAdd;
        private System.Windows.Forms.Button btn_categoryEdit;
        private System.Windows.Forms.Button btn_categoryDelete;
        private System.Windows.Forms.Button btn_categoryRefresh;
        private System.Windows.Forms.Label lbl_SectionTitle;
        private System.Windows.Forms.Label lbl_CategoryName;
        private System.Windows.Forms.TextBox txt_categoryName;
        private System.Windows.Forms.Label lbl_CategoryDesc;
        private System.Windows.Forms.TextBox txt_categoryDesc;
        private System.Windows.Forms.Label lbl_CategoryStatus;
        private System.Windows.Forms.ComboBox cbb_categoryStatus;
        private System.Windows.Forms.Button btn_categorySave;
        private System.Windows.Forms.Button btn_categoryCancel;
        private System.Windows.Forms.DataGridView dgv_categoryList;
        private System.Windows.Forms.TextBox txt_categorySearch;
    }
}