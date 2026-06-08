namespace GUI
{
    partial class FormPromotion
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
            groupBox3 = new GroupBox();
            label1 = new Label();
            dtp_endDate = new DateTimePicker();
            dtp_startDate = new DateTimePicker();
            txt_promotionCode = new TextBox();
            txt_description = new TextBox();
            txt_discountValue = new TextBox();
            btn_save = new Button();
            btn_cancel = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            dgv_promotion = new DataGridView();
            col_promotionCode = new DataGridViewTextBoxColumn();
            col_description = new DataGridViewTextBoxColumn();
            col_discountPercentage = new DataGridViewTextBoxColumn();
            col_discountAmount = new DataGridViewTextBoxColumn();
            col_startDate = new DataGridViewTextBoxColumn();
            col_endDate = new DataGridViewTextBoxColumn();
            col_status = new DataGridViewTextBoxColumn();
            btn_createPromotion = new Button();
            btn_refresh = new Button();
            btn_disablePromotion = new Button();
            btn_editPromotion = new Button();
            pnl_top = new Panel();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_promotion).BeginInit();
            pnl_top.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(dtp_endDate);
            groupBox3.Controls.Add(dtp_startDate);
            groupBox3.Controls.Add(txt_promotionCode);
            groupBox3.Controls.Add(txt_description);
            groupBox3.Controls.Add(txt_discountValue);
            groupBox3.Controls.Add(btn_save);
            groupBox3.Controls.Add(btn_cancel);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(478, 48);
            groupBox3.Margin = new Padding(1);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(1);
            groupBox3.Size = new Size(356, 442);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin KM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 238);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 13;
            label1.Text = "Đến ngày";
            // 
            // dtp_endDate
            // 
            dtp_endDate.Location = new Point(7, 260);
            dtp_endDate.Margin = new Padding(1);
            dtp_endDate.Name = "dtp_endDate";
            dtp_endDate.Size = new Size(346, 27);
            dtp_endDate.TabIndex = 12;
            // 
            // dtp_startDate
            // 
            dtp_startDate.Location = new Point(7, 202);
            dtp_startDate.Margin = new Padding(1);
            dtp_startDate.Name = "dtp_startDate";
            dtp_startDate.Size = new Size(346, 27);
            dtp_startDate.TabIndex = 11;
            // 
            // txt_promotionCode
            // 
            txt_promotionCode.Location = new Point(7, 42);
            txt_promotionCode.Margin = new Padding(1);
            txt_promotionCode.Name = "txt_promotionCode";
            txt_promotionCode.Size = new Size(346, 27);
            txt_promotionCode.TabIndex = 10;
            // 
            // txt_description
            // 
            txt_description.Location = new Point(7, 94);
            txt_description.Margin = new Padding(1);
            txt_description.Name = "txt_description";
            txt_description.Size = new Size(346, 27);
            txt_description.TabIndex = 9;
            // 
            // txt_discountValue
            // 
            txt_discountValue.Location = new Point(7, 148);
            txt_discountValue.Margin = new Padding(1);
            txt_discountValue.Name = "txt_discountValue";
            txt_discountValue.Size = new Size(346, 27);
            txt_discountValue.TabIndex = 3;
            txt_discountValue.TextChanged += txt_discountValue_TextChanged;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(7, 314);
            btn_save.Margin = new Padding(1);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(344, 26);
            btn_save.TabIndex = 6;
            btn_save.Text = "Lưu";
            btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(7, 350);
            btn_cancel.Margin = new Padding(1);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(344, 26);
            btn_cancel.TabIndex = 7;
            btn_cancel.Text = "Hủy";
            btn_cancel.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 181);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 7;
            label6.Text = "Từ ngày";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 126);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(138, 20);
            label5.TabIndex = 6;
            label5.Text = "Giảm % / Giảm tiền";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 72);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 5;
            label4.Text = "Mô tả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 21);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 4;
            label3.Text = "Mã khuyến mãi *";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgv_promotion);
            groupBox2.Location = new Point(-1, 48);
            groupBox2.Margin = new Padding(1);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(1);
            groupBox2.Size = new Size(476, 442);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            // 
            // dgv_promotion
            // 
            dgv_promotion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_promotion.Columns.AddRange(new DataGridViewColumn[] { col_promotionCode, col_description, col_discountPercentage, col_discountAmount, col_startDate, col_endDate, col_status });
            dgv_promotion.Location = new Point(2, -1);
            dgv_promotion.Margin = new Padding(0);
            dgv_promotion.Name = "dgv_promotion";
            dgv_promotion.RowHeadersWidth = 51;
            dgv_promotion.Size = new Size(472, 443);
            dgv_promotion.TabIndex = 1;
            dgv_promotion.CellContentClick += dgv_guest_CellContentClick;
            // 
            // col_promotionCode
            // 
            col_promotionCode.HeaderText = "Mã KM";
            col_promotionCode.MinimumWidth = 6;
            col_promotionCode.Name = "col_promotionCode";
            col_promotionCode.Width = 125;
            // 
            // col_description
            // 
            col_description.HeaderText = "Mô tả";
            col_description.MinimumWidth = 6;
            col_description.Name = "col_description";
            col_description.Width = 125;
            // 
            // col_discountPercentage
            // 
            col_discountPercentage.HeaderText = "Giảm %";
            col_discountPercentage.MinimumWidth = 6;
            col_discountPercentage.Name = "col_discountPercentage";
            col_discountPercentage.Width = 125;
            // 
            // col_discountAmount
            // 
            col_discountAmount.HeaderText = "Giảm tiền";
            col_discountAmount.MinimumWidth = 6;
            col_discountAmount.Name = "col_discountAmount";
            col_discountAmount.Width = 125;
            // 
            // col_startDate
            // 
            col_startDate.HeaderText = "Từ ngày";
            col_startDate.MinimumWidth = 6;
            col_startDate.Name = "col_startDate";
            col_startDate.Width = 125;
            // 
            // col_endDate
            // 
            col_endDate.HeaderText = "Đến ngày";
            col_endDate.MinimumWidth = 6;
            col_endDate.Name = "col_endDate";
            col_endDate.Width = 125;
            // 
            // col_status
            // 
            col_status.HeaderText = "Trạng thái";
            col_status.MinimumWidth = 6;
            col_status.Name = "col_status";
            col_status.Width = 125;
            // 
            // btn_createPromotion
            // 
            btn_createPromotion.Location = new Point(8, 6);
            btn_createPromotion.Margin = new Padding(1);
            btn_createPromotion.Name = "btn_createPromotion";
            btn_createPromotion.Size = new Size(185, 26);
            btn_createPromotion.TabIndex = 2;
            btn_createPromotion.Text = "+ Tạo KM";
            btn_createPromotion.UseVisualStyleBackColor = true;
            // 
            // btn_refresh
            // 
            btn_refresh.Location = new Point(623, 6);
            btn_refresh.Margin = new Padding(1);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(208, 26);
            btn_refresh.TabIndex = 5;
            btn_refresh.Text = "Làm mới";
            btn_refresh.UseVisualStyleBackColor = true;
            // 
            // btn_disablePromotion
            // 
            btn_disablePromotion.Location = new Point(405, 6);
            btn_disablePromotion.Margin = new Padding(1);
            btn_disablePromotion.Name = "btn_disablePromotion";
            btn_disablePromotion.Size = new Size(215, 26);
            btn_disablePromotion.TabIndex = 4;
            btn_disablePromotion.Text = "Tắt KM";
            btn_disablePromotion.UseVisualStyleBackColor = true;
            // 
            // btn_editPromotion
            // 
            btn_editPromotion.Location = new Point(196, 6);
            btn_editPromotion.Margin = new Padding(1);
            btn_editPromotion.Name = "btn_editPromotion";
            btn_editPromotion.Size = new Size(206, 26);
            btn_editPromotion.TabIndex = 3;
            btn_editPromotion.Text = "Sửa";
            btn_editPromotion.UseVisualStyleBackColor = true;
            // 
            // pnl_top
            // 
            pnl_top.Controls.Add(btn_createPromotion);
            pnl_top.Controls.Add(btn_refresh);
            pnl_top.Controls.Add(btn_editPromotion);
            pnl_top.Controls.Add(btn_disablePromotion);
            pnl_top.Location = new Point(-1, 0);
            pnl_top.Margin = new Padding(1);
            pnl_top.Name = "pnl_top";
            pnl_top.Size = new Size(835, 45);
            pnl_top.TabIndex = 12;
            // 
            // FormPromotion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 492);
            Controls.Add(pnl_top);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Name = "FormPromotion";
            Text = "FormPromotion";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_promotion).EndInit();
            pnl_top.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnl_top;

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_promotionCode;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.TextBox txt_discountValue;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_createPromotion;
        private System.Windows.Forms.DataGridView dgv_promotion;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_disablePromotion;
        private System.Windows.Forms.Button btn_editPromotion;
        private System.Windows.Forms.DateTimePicker dtp_startDate;
        private System.Windows.Forms.DateTimePicker dtp_endDate;
        private DataGridViewTextBoxColumn col_promotionCode;
        private DataGridViewTextBoxColumn col_description;
        private DataGridViewTextBoxColumn col_discountPercentage;
        private DataGridViewTextBoxColumn col_discountAmount;
        private DataGridViewTextBoxColumn col_startDate;
        private DataGridViewTextBoxColumn col_endDate;
        private DataGridViewTextBoxColumn col_status;
        private System.Windows.Forms.Label label1;
    }
}