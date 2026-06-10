namespace GUI 
{
    partial class FormTradeIn
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_createTradein = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_status = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_resolution = new System.Windows.Forms.TextBox();
            this.dgv_tradeIn = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tradeIn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_createTradein);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_confirm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 821);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1843, 100);
            this.panel1.TabIndex = 0;
            // 
            // btn_createTradein
            // 
            this.btn_createTradein.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_createTradein.Location = new System.Drawing.Point(30, 25);
            this.btn_createTradein.Name = "btn_createTradein";
            this.btn_createTradein.Size = new System.Drawing.Size(180, 50);
            this.btn_createTradein.TabIndex = 0;
            this.btn_createTradein.Text = "+ Tạo Phiếu Mới";
            this.btn_createTradein.UseVisualStyleBackColor = true;
            this.btn_createTradein.Click += new System.EventHandler(this.btn_createTradein_Click);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_search.Location = new System.Drawing.Point(230, 25);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(150, 50);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Tìm Kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_delete.Location = new System.Drawing.Point(1480, 25);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(150, 50);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Hủy Phiếu";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_confirm.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_confirm.Location = new System.Drawing.Point(1650, 25);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(160, 50);
            this.btn_confirm.TabIndex = 3;
            this.btn_confirm.Text = "Xác Nhận Xử Lý";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_resolution);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbb_status);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_search);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1843, 120);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bộ Lọc & Xử Lý Phiếu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm:";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(130, 47);
            this.txt_search.Name = "txt_search";
            this.txt_search.PlaceholderText = "Nhập mã phiếu, mã HĐ...";
            this.txt_search.Size = new System.Drawing.Size(300, 30);
            this.txt_search.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(470, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cập nhật Trạng Thái:";
            // 
            // cbb_status
            // 
            this.cbb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_status.FormattingEnabled = true;
            this.cbb_status.Location = new System.Drawing.Point(600, 47);
            this.cbb_status.Name = "cbb_status";
            this.cbb_status.Size = new System.Drawing.Size(250, 31);
            this.cbb_status.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(890, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hướng Giải Quyết:";
            // 
            // txt_resolution
            // 
            this.txt_resolution.Location = new System.Drawing.Point(1040, 47);
            this.txt_resolution.Name = "txt_resolution";
            this.txt_resolution.PlaceholderText = "Nhập ghi chú xử lý (vd: Đã đổi máy mới)...";
            this.txt_resolution.Size = new System.Drawing.Size(770, 30);
            this.txt_resolution.TabIndex = 4;
            // 
            // dgv_tradeIn
            // 
            this.dgv_tradeIn.BackgroundColor = System.Drawing.Color.White;
            this.dgv_tradeIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tradeIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_tradeIn.Location = new System.Drawing.Point(0, 120);
            this.dgv_tradeIn.Name = "dgv_tradeIn";
            this.dgv_tradeIn.RowHeadersWidth = 51;
            this.dgv_tradeIn.RowTemplate.Height = 35;
            this.dgv_tradeIn.Size = new System.Drawing.Size(1843, 701);
            this.dgv_tradeIn.TabIndex = 2;
            this.dgv_tradeIn.SelectionChanged += new System.EventHandler(this.dgv_tradeIn_SelectionChanged);
            // 
            // FormTradeIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1843, 921);
            this.Controls.Add(this.dgv_tradeIn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FormTradeIn";
            this.Text = "Quản lý Bảo Hành & Đổi Trả";
            this.Load += new System.EventHandler(this.FormTradeIn_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tradeIn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_createTradein;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_resolution;
        private System.Windows.Forms.DataGridView dgv_tradeIn;
    }
}