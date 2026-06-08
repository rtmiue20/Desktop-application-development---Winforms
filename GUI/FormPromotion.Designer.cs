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
            txt_promotionCode = new TextBox();
            txt_description = new TextBox();
            txt_discountValue = new TextBox();
            btn_save = new Button();
            btn_cancel = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            dgv_guest = new DataGridView();
            btn_createPromotion = new Button();
            btn_refresh = new Button();
            btn_editPromotion = new Button();
            btn_disablePromotion = new Button();
            dtp_startDate = new DateTimePicker();
            dtp_endDate = new DateTimePicker();
            col_promotionCode = new DataGridViewTextBoxColumn();
            col_description = new DataGridViewTextBoxColumn();
            col_discountPercentage = new DataGridViewTextBoxColumn();
            col_discountAmount = new DataGridViewTextBoxColumn();
            col_startDate = new DataGridViewTextBoxColumn();
            col_endDate = new DataGridViewTextBoxColumn();
            col_status = new DataGridViewTextBoxColumn();
            label1 = new Label();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_guest).BeginInit();
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
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(895, 26);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(334, 554);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            // 
            // txt_promotionCode
            // 
            txt_promotionCode.Location = new Point(20, 90);
            txt_promotionCode.Name = "txt_promotionCode";
            txt_promotionCode.Size = new Size(267, 27);
            txt_promotionCode.TabIndex = 10;
            // 
            // txt_description
            // 
            txt_description.Location = new Point(20, 171);
            txt_description.Name = "txt_description";
            txt_description.Size = new Size(267, 27);
            txt_description.TabIndex = 9;
            // 
            // txt_discountValue
            // 
            txt_discountValue.Location = new Point(20, 239);
            txt_discountValue.Name = "txt_discountValue";
            txt_discountValue.Size = new Size(267, 27);
            txt_discountValue.TabIndex = 3;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(20, 459);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(140, 54);
            btn_save.TabIndex = 6;
            btn_save.Text = "Lưu";
            btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(188, 459);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(140, 54);
            btn_cancel.TabIndex = 7;
            btn_cancel.Text = "Hủy";
            btn_cancel.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 285);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 7;
            label6.Text = "Từ ngày";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 216);
            label5.Name = "label5";
            label5.Size = new Size(138, 20);
            label5.TabIndex = 6;
            label5.Text = "Giảm % / Giảm tiền";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 148);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 5;
            label4.Text = "Mô tả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 63);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 4;
            label3.Text = "Mã khuyến mãi *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 29);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 3;
            label2.Text = "Thông tin KM";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_createPromotion);
            groupBox2.Controls.Add(dgv_guest);
            groupBox2.Controls.Add(btn_refresh);
            groupBox2.Controls.Add(btn_disablePromotion);
            groupBox2.Controls.Add(btn_editPromotion);
            groupBox2.Location = new Point(12, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(841, 672);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // dgv_guest
            // 
            dgv_guest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_guest.Columns.AddRange(new DataGridViewColumn[] { col_promotionCode, col_description, col_discountPercentage, col_discountAmount, col_startDate, col_endDate, col_status });
            dgv_guest.Location = new Point(4, 90);
            dgv_guest.Margin = new Padding(1);
            dgv_guest.Name = "dgv_guest";
            dgv_guest.RowHeadersWidth = 51;
            dgv_guest.Size = new Size(837, 319);
            dgv_guest.TabIndex = 1;
            dgv_guest.CellContentClick += dgv_guest_CellContentClick;
            // 
            // btn_createPromotion
            // 
            btn_createPromotion.Location = new Point(26, 21);
            btn_createPromotion.Name = "btn_createPromotion";
            btn_createPromotion.Size = new Size(140, 54);
            btn_createPromotion.TabIndex = 2;
            btn_createPromotion.Text = "+ Tạo KM";
            btn_createPromotion.UseVisualStyleBackColor = true;
            // 
            // btn_refresh
            // 
            btn_refresh.Location = new Point(505, 21);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(140, 54);
            btn_refresh.TabIndex = 5;
            btn_refresh.Text = "Làm mới";
            btn_refresh.UseVisualStyleBackColor = true;
            // 
            // btn_editPromotion
            // 
            btn_editPromotion.Location = new Point(182, 21);
            btn_editPromotion.Name = "btn_editPromotion";
            btn_editPromotion.Size = new Size(140, 54);
            btn_editPromotion.TabIndex = 3;
            btn_editPromotion.Text = "Sửa";
            btn_editPromotion.UseVisualStyleBackColor = true;
            // 
            // btn_disablePromotion
            // 
            btn_disablePromotion.Location = new Point(340, 21);
            btn_disablePromotion.Name = "btn_disablePromotion";
            btn_disablePromotion.Size = new Size(140, 54);
            btn_disablePromotion.TabIndex = 4;
            btn_disablePromotion.Text = "Tắt KM";
            btn_disablePromotion.UseVisualStyleBackColor = true;
            // 
            // dtp_startDate
            // 
            dtp_startDate.Location = new Point(20, 322);
            dtp_startDate.Name = "dtp_startDate";
            dtp_startDate.Size = new Size(250, 27);
            dtp_startDate.TabIndex = 11;
            dtp_startDate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dtp_endDate
            // 
            dtp_endDate.Location = new Point(20, 391);
            dtp_endDate.Name = "dtp_endDate";
            dtp_endDate.Size = new Size(250, 27);
            dtp_endDate.TabIndex = 12;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 352);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 13;
            label1.Text = "Đến ngày";
            // 
            // FormPromotion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1340, 675);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Name = "FormPromotion";
            Text = "FormPromotion";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_guest).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private TextBox txt_promotionCode;
        private TextBox txt_description;
        private TextBox txt_discountValue;
        private Button btn_save;
        private Button btn_cancel;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private Button btn_createPromotion;
        private DataGridView dgv_guest;
        private Button btn_refresh;
        private Button btn_disablePromotion;
        private Button btn_editPromotion;
        private DateTimePicker dtp_startDate;
        private DateTimePicker dtp_endDate;
        private DataGridViewTextBoxColumn col_promotionCode;
        private DataGridViewTextBoxColumn col_description;
        private DataGridViewTextBoxColumn col_discountPercentage;
        private DataGridViewTextBoxColumn col_discountAmount;
        private DataGridViewTextBoxColumn col_startDate;
        private DataGridViewTextBoxColumn col_endDate;
        private DataGridViewTextBoxColumn col_status;
        private Label label1;
    }
}