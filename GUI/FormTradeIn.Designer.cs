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
            panel1 = new Panel();
            btn_createTradein = new Button();
            btn_search = new Button();
            btn_delete = new Button();
            btn_confirm = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            txt_resolution = new TextBox();
            label2 = new Label();
            cbb_status = new ComboBox();
            label1 = new Label();
            txt_search = new TextBox();
            dgv_tradeIn = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_tradeIn).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_createTradein);
            panel1.Controls.Add(btn_search);
            panel1.Controls.Add(btn_delete);
            panel1.Controls.Add(btn_confirm);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 821);
            panel1.Name = "panel1";
            panel1.Size = new Size(1843, 100);
            panel1.TabIndex = 0;
            // 
            // btn_createTradein
            // 
            btn_createTradein.Location = new Point(30, 25);
            btn_createTradein.Name = "btn_createTradein";
            btn_createTradein.Size = new Size(405, 50);
            btn_createTradein.TabIndex = 0;
            btn_createTradein.Text = "+ Tạo Phiếu Mới";
            btn_createTradein.Click += btn_createTradein_Click;
            // 
            // btn_search
            // 
            btn_search.Location = new Point(451, 25);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(505, 50);
            btn_search.TabIndex = 1;
            btn_search.Text = "Tìm Kiếm";
            btn_search.Click += btn_search_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(1480, 25);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(150, 50);
            btn_delete.TabIndex = 2;
            btn_delete.Text = "Hủy Phiếu";
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_confirm
            // 
            btn_confirm.Location = new Point(1650, 25);
            btn_confirm.Name = "btn_confirm";
            btn_confirm.Size = new Size(160, 50);
            btn_confirm.TabIndex = 3;
            btn_confirm.Text = "Xác Nhận Xử Lý";
            btn_confirm.Click += btn_confirm_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_resolution);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cbb_status);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_search);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1843, 172);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bộ Lọc & Xử Lý Phiếu";
            // 
            // label3
            // 
            label3.Location = new Point(589, 47);
            label3.Name = "label3";
            label3.Size = new Size(300, 44);
            label3.TabIndex = 0;
            label3.Text = "Hướng Giải Quyết:";
            // 
            // txt_resolution
            // 
            txt_resolution.Location = new Point(860, 47);
            txt_resolution.Name = "txt_resolution";
            txt_resolution.Size = new Size(950, 47);
            txt_resolution.TabIndex = 1;
            // 
            // label2
            // 
            label2.Location = new Point(12, 109);
            label2.Name = "label2";
            label2.Size = new Size(289, 44);
            label2.TabIndex = 2;
            label2.Text = "Cập nhật Trạng Thái:";
            // 
            // cbb_status
            // 
            cbb_status.Location = new Point(307, 109);
            cbb_status.Name = "cbb_status";
            cbb_status.Size = new Size(465, 49);
            cbb_status.TabIndex = 3;
            // 
            // label1
            // 
            label1.Location = new Point(12, 50);
            label1.Name = "label1";
            label1.Size = new Size(149, 46);
            label1.TabIndex = 4;
            label1.Text = "Tìm kiếm:";
            // 
            // txt_search
            // 
            txt_search.Location = new Point(167, 50);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(300, 47);
            txt_search.TabIndex = 5;
            // 
            // dgv_tradeIn
            // 
            dgv_tradeIn.ColumnHeadersHeight = 58;
            dgv_tradeIn.Dock = DockStyle.Fill;
            dgv_tradeIn.Location = new Point(0, 172);
            dgv_tradeIn.Name = "dgv_tradeIn";
            dgv_tradeIn.RowHeadersWidth = 102;
            dgv_tradeIn.Size = new Size(1843, 649);
            dgv_tradeIn.TabIndex = 2;
            dgv_tradeIn.SelectionChanged += dgv_tradeIn_SelectionChanged;
            // 
            // FormTradeIn
            // 
            ClientSize = new Size(1843, 921);
            Controls.Add(dgv_tradeIn);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "FormTradeIn";
            Text = "Quản lý Bảo Hành & Đổi Trả";
            Load += FormTradeIn_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_tradeIn).EndInit();
            ResumeLayout(false);
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
