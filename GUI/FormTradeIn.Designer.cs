namespace Desktop_Application_Development
{
    partial class FormTradeIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            panel1 = new Panel();
            btn_createTradein = new Button();
            btn_search = new Button();
            btn_delete = new Button();
            btn_confirm = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            textBox1 = new TextBox();
            label2 = new Label();
            cbb_reason = new ComboBox();
            dgv_tradeIn = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_tradeIn).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_confirm);
            panel1.Controls.Add(btn_delete);
            panel1.Controls.Add(btn_createTradein);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1831, 81);
            panel1.TabIndex = 0;
            // 
            // btn_createTradein
            // 
            btn_createTradein.Location = new Point(14, 12);
            btn_createTradein.Name = "btn_createTradein";
            btn_createTradein.Size = new Size(298, 58);
            btn_createTradein.TabIndex = 0;
            btn_createTradein.Text = "Tạo phiếu đổi trả";
            btn_createTradein.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            btn_search.Location = new Point(419, 40);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(188, 47);
            btn_search.TabIndex = 1;
            btn_search.Text = "Tìm";
            btn_search.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(541, 12);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(188, 58);
            btn_delete.TabIndex = 2;
            btn_delete.Text = "Xóa";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += button3_Click;
            // 
            // btn_confirm
            // 
            btn_confirm.Location = new Point(318, 12);
            btn_confirm.Name = "btn_confirm";
            btn_confirm.Size = new Size(217, 58);
            btn_confirm.TabIndex = 3;
            btn_confirm.Text = "Xác nhận";
            btn_confirm.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.AccessibleRole = AccessibleRole.None;
            groupBox1.Controls.Add(dgv_tradeIn);
            groupBox1.Controls.Add(cbb_reason);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btn_search);
            groupBox1.Location = new Point(12, 99);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1831, 777);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 43);
            label1.Name = "label1";
            label1.Size = new Size(117, 41);
            label1.TabIndex = 0;
            label1.Text = "Mã HĐ:";
            // 
            // guna2ContextMenuStrip1
            // 
            guna2ContextMenuStrip1.ImageScalingSize = new Size(40, 40);
            guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            guna2ContextMenuStrip1.RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
            guna2ContextMenuStrip1.RenderStyle.BorderColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SeparatorColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            guna2ContextMenuStrip1.Size = new Size(61, 4);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(137, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 47);
            textBox1.TabIndex = 1;
            textBox1.Tag = "";
            textBox1.Text = "HD0001";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(728, 43);
            label2.Name = "label2";
            label2.Size = new Size(97, 41);
            label2.TabIndex = 2;
            label2.Text = "Lý do:";
            // 
            // cbb_reason
            // 
            cbb_reason.FormattingEnabled = true;
            cbb_reason.Location = new Point(831, 43);
            cbb_reason.Name = "cbb_reason";
            cbb_reason.Size = new Size(443, 49);
            cbb_reason.TabIndex = 3;
            // 
            // dgv_tradeIn
            // 
            dgv_tradeIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_tradeIn.Location = new Point(0, 93);
            dgv_tradeIn.Name = "dgv_tradeIn";
            dgv_tradeIn.RowHeadersWidth = 102;
            dgv_tradeIn.Size = new Size(1819, 678);
            dgv_tradeIn.TabIndex = 4;
            // 
            // FormTradeIn
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1843, 921);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "FormTradeIn";
            Text = "FormTradeIn";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_tradeIn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_confirm;
        private Button btn_delete;
        private Button btn_search;
        private Button btn_createTradein;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private DataGridView dgv_tradeIn;
        private ComboBox cbb_reason;
        private Label label2;
    }
}