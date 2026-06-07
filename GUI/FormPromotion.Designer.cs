using System.ComponentModel;

namespace GUI;

partial class FormPromotion
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        dtp_endDate = new DateTimePicker();
        label1 = new Label();
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
        label2 = new Label();
        groupBox2 = new GroupBox();
        btn_createPromotion = new Button();
        dgv_guest = new DataGridView();
        btn_refresh = new Button();
        btn_edit = new Button();
        btn_disablePromotion = new Button();
        mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
        col_PromotionCode = new DataGridViewTextBoxColumn();
        col_description = new DataGridViewTextBoxColumn();
        col_DiscountPercentage = new DataGridViewTextBoxColumn();
        col_DiscountAmount = new DataGridViewTextBoxColumn();
        col_StartDate = new DataGridViewTextBoxColumn();
        col_EndDate = new DataGridViewTextBoxColumn();
        col_Status = new DataGridViewTextBoxColumn();
        groupBox3.SuspendLayout();
        groupBox2.SuspendLayout();
        ((ISupportInitialize)dgv_guest).BeginInit();
        SuspendLayout();
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(dtp_endDate);
        groupBox3.Controls.Add(label1);
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
        groupBox3.Location = new Point(923, 29);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new Size(334, 554);
        groupBox3.TabIndex = 11;
        groupBox3.TabStop = false;
        // 
        // dtp_endDate
        // 
        dtp_endDate.Location = new Point(20, 409);
        dtp_endDate.Name = "dtp_endDate";
        dtp_endDate.Size = new Size(250, 27);
        dtp_endDate.TabIndex = 13;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(20, 372);
        label1.Name = "label1";
        label1.Size = new Size(72, 20);
        label1.TabIndex = 12;
        label1.Text = "Đến ngày";
        // 
        // dtp_startDate
        // 
        dtp_startDate.Location = new Point(20, 317);
        dtp_startDate.Name = "dtp_startDate";
        dtp_startDate.Size = new Size(250, 27);
        dtp_startDate.TabIndex = 11;
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
        btn_save.Click += btn_save_Click_1;
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
        label5.Location = new System.Drawing.Point(41, 211);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(211, 41);
        label5.TabIndex = 4;
        label5.Text = "Ngày Kết Thúc";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new System.Drawing.Point(41, 122);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(112, 41);
        label4.TabIndex = 3;
        label4.Text = "Giảm%";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new System.Drawing.Point(41, 160);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(199, 41);
        label3.TabIndex = 2;
        label3.Text = "Ngày Bắt Đầu";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new System.Drawing.Point(41, 88);
        label2.Name = "label2";
        label2.Size = new Size(179, 20);
        label2.TabIndex = 3;
        label2.Text = "THÔNG TIN KHUYẾN MÃI";
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(btn_createPromotion);
        groupBox2.Controls.Add(dgv_guest);
        groupBox2.Controls.Add(btn_refresh);
        groupBox2.Controls.Add(btn_edit);
        groupBox2.Controls.Add(btn_disablePromotion);
        groupBox2.Location = new Point(12, 12);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(888, 616);
        groupBox2.TabIndex = 10;
        groupBox2.TabStop = false;
        groupBox2.Enter += groupBox2_Enter;
        // 
        // btn_createPromotion
        // 
        btn_createPromotion.Location = new Point(24, 45);
        btn_createPromotion.Name = "btn_createPromotion";
        btn_createPromotion.Size = new Size(140, 54);
        btn_createPromotion.TabIndex = 2;
        btn_createPromotion.Text = "+ Tạo KM";
        btn_createPromotion.UseVisualStyleBackColor = true;
        // 
        // dgv_guest
        // 
        dgv_guest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgv_guest.Columns.AddRange(new DataGridViewColumn[] { col_PromotionCode, col_description, col_DiscountPercentage, col_DiscountAmount, col_StartDate, col_EndDate, col_Status });
        dgv_guest.Location = new Point(0, 143);
        dgv_guest.Margin = new Padding(1);
        dgv_guest.Name = "dgv_guest";
        dgv_guest.RowHeadersWidth = 51;
        dgv_guest.Size = new Size(880, 319);
        dgv_guest.TabIndex = 1;
        dgv_guest.CellContentClick += dgv_Guest_CellContentClick;
        // 
        // btn_refresh
        // 
        btn_refresh.Location = new Point(503, 45);
        btn_refresh.Name = "btn_refresh";
        btn_refresh.Size = new Size(140, 54);
        btn_refresh.TabIndex = 5;
        btn_refresh.Text = "Làm mới";
        btn_refresh.UseVisualStyleBackColor = true;
        // 
        // btn_edit
        // 
        btn_edit.Location = new Point(180, 45);
        btn_edit.Name = "btn_edit";
        btn_edit.Size = new Size(140, 54);
        btn_edit.TabIndex = 3;
        btn_edit.Text = "Sửa";
        btn_edit.UseVisualStyleBackColor = true;
        // 
        // btn_disablePromotion
        // 
        btn_disablePromotion.Location = new Point(338, 45);
        btn_disablePromotion.Name = "btn_disablePromotion";
        btn_disablePromotion.Size = new Size(140, 54);
        btn_disablePromotion.TabIndex = 4;
        btn_disablePromotion.Text = "Tắt KM";
        btn_disablePromotion.UseVisualStyleBackColor = true;
        // 
        // mySqlCommand1
        // 
        mySqlCommand1.CacheAge = 0;
        mySqlCommand1.Connection = null;
        mySqlCommand1.EnableCaching = false;
        mySqlCommand1.Transaction = null;
        // 
        // col_PromotionCode
        // 
        col_PromotionCode.HeaderText = "Mã KM";
        col_PromotionCode.MinimumWidth = 6;
        col_PromotionCode.Name = "col_PromotionCode";
        col_PromotionCode.Width = 125;
        // 
        // col_description
        // 
        col_description.HeaderText = "Mô tả";
        col_description.MinimumWidth = 6;
        col_description.Name = "col_description";
        col_description.Width = 125;
        // 
        // col_DiscountPercentage
        // 
        col_DiscountPercentage.HeaderText = "Giảm %";
        col_DiscountPercentage.MinimumWidth = 6;
        col_DiscountPercentage.Name = "col_DiscountPercentage";
        col_DiscountPercentage.Width = 125;
        // 
        // col_DiscountAmount
        // 
        col_DiscountAmount.HeaderText = "Giảm tiền";
        col_DiscountAmount.MinimumWidth = 6;
        col_DiscountAmount.Name = "col_DiscountAmount";
        col_DiscountAmount.Width = 125;
        // 
        // col_StartDate
        // 
        col_StartDate.HeaderText = "Từ ngày";
        col_StartDate.MinimumWidth = 6;
        col_StartDate.Name = "col_StartDate";
        col_StartDate.Width = 125;
        // 
        // col_EndDate
        // 
        col_EndDate.HeaderText = "Đến ngày";
        col_EndDate.MinimumWidth = 6;
        col_EndDate.Name = "col_EndDate";
        col_EndDate.Width = 125;
        // 
        // col_Status
        // 
        col_Status.HeaderText = "Trạng thái";
        col_Status.MinimumWidth = 6;
        col_Status.Name = "col_Status";
        col_Status.Width = 125;
        // 
        // FormPromotion
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1425, 1084);
        Controls.Add(dgv_Promotion);
        Controls.Add(groupBox1);
        Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
        Text = "FormPromotion";
        Load += FormPromotion_Load;
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)num_Discount).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgv_Promotion).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridView dgv_Promotion;
    private System.Windows.Forms.GroupBox groupBox1;

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
    private DataGridView dgv_guest;
    private Button btn_createPromotion;
    private Button btn_refresh;
    private Button btn_edit;
    private Button btn_disablePromotion;
    private DateTimePicker dtp_endDate;
    private Label label1;
    private DateTimePicker dtp_startDate;
    private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    private DataGridViewTextBoxColumn col_PromotionCode;
    private DataGridViewTextBoxColumn col_description;
    private DataGridViewTextBoxColumn col_DiscountPercentage;
    private DataGridViewTextBoxColumn col_DiscountAmount;
    private DataGridViewTextBoxColumn col_StartDate;
    private DataGridViewTextBoxColumn col_EndDate;
    private DataGridViewTextBoxColumn col_Status;
}