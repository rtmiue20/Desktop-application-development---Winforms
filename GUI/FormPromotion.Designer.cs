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
        groupBox1 = new GroupBox();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        txt_PromotionID = new TextBox();
        txt_PromotionName = new TextBox();
        num_Discount = new NumericUpDown();
        dt_Start = new DateTimePicker();
        dt_End = new DateTimePicker();
        btn_Add = new Button();
        btn_Update = new Button();
        btn_Delete = new Button();
        dgv_Promotion = new DataGridView();
        col_Promotion = new DataGridViewTextBoxColumn();
        col_PromotionName = new DataGridViewTextBoxColumn();
        col_Discount = new DataGridViewTextBoxColumn();
        col_Start = new DataGridViewTextBoxColumn();
        col_End = new DataGridViewTextBoxColumn();
        groupBox1.SuspendLayout();
        ((ISupportInitialize)num_Discount).BeginInit();
        ((ISupportInitialize)dgv_Promotion).BeginInit();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(btn_Delete);
        groupBox1.Controls.Add(btn_Update);
        groupBox1.Controls.Add(btn_Add);
        groupBox1.Controls.Add(dt_End);
        groupBox1.Controls.Add(dt_Start);
        groupBox1.Controls.Add(num_Discount);
        groupBox1.Controls.Add(txt_PromotionName);
        groupBox1.Controls.Add(txt_PromotionID);
        groupBox1.Controls.Add(label5);
        groupBox1.Controls.Add(label4);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(label1);
        groupBox1.Location = new Point(12, 12);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(1120, 265);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = " ";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(41, 35);
        label1.Name = "label1";
        label1.Size = new Size(111, 20);
        label1.TabIndex = 0;
        label1.Text = "Mã Khuyến Mãi";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(41, 88);
        label2.Name = "label2";
        label2.Size = new Size(124, 20);
        label2.TabIndex = 1;
        label2.Text = "Tên Chương Trình";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(41, 160);
        label3.Name = "label3";
        label3.Size = new Size(101, 20);
        label3.TabIndex = 2;
        label3.Text = "Ngày Bắt Đầu";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(41, 122);
        label4.Name = "label4";
        label4.Size = new Size(56, 20);
        label4.TabIndex = 3;
        label4.Text = "Giảm%";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(41, 211);
        label5.Name = "label5";
        label5.Size = new Size(105, 20);
        label5.TabIndex = 4;
        label5.Text = "Ngày Kết Thúc";
        // 
        // txt_PromotionID
        // 
        txt_PromotionID.Location = new Point(185, 32);
        txt_PromotionID.Name = "txt_PromotionID";
        txt_PromotionID.Size = new Size(125, 27);
        txt_PromotionID.TabIndex = 5;
        // 
        // txt_PromotionName
        // 
        txt_PromotionName.Location = new Point(171, 81);
        txt_PromotionName.Name = "txt_PromotionName";
        txt_PromotionName.Size = new Size(336, 27);
        txt_PromotionName.TabIndex = 6;
        // 
        // num_Discount
        // 
        num_Discount.Location = new Point(136, 122);
        num_Discount.Name = "num_Discount";
        num_Discount.Size = new Size(214, 27);
        num_Discount.TabIndex = 7;
        // 
        // dt_Start
        // 
        dt_Start.Location = new Point(148, 160);
        dt_Start.Name = "dt_Start";
        dt_Start.Size = new Size(276, 27);
        dt_Start.TabIndex = 8;
        // 
        // dt_End
        // 
        dt_End.Location = new Point(171, 211);
        dt_End.Name = "dt_End";
        dt_End.Size = new Size(276, 27);
        dt_End.TabIndex = 9;
        // 
        // btn_Add
        // 
        btn_Add.Location = new Point(470, 172);
        btn_Add.Name = "btn_Add";
        btn_Add.Size = new Size(94, 29);
        btn_Add.TabIndex = 10;
        btn_Add.Text = "Thêm";
        btn_Add.UseVisualStyleBackColor = true;
        // 
        // btn_Update
        // 
        btn_Update.Location = new Point(589, 172);
        btn_Update.Name = "btn_Update";
        btn_Update.Size = new Size(94, 29);
        btn_Update.TabIndex = 11;
        btn_Update.Text = "Sửa";
        btn_Update.UseVisualStyleBackColor = true;
        // 
        // btn_Delete
        // 
        btn_Delete.Location = new Point(713, 172);
        btn_Delete.Name = "btn_Delete";
        btn_Delete.Size = new Size(94, 29);
        btn_Delete.TabIndex = 12;
        btn_Delete.Text = "Xóa";
        btn_Delete.UseVisualStyleBackColor = true;
        // 
        // dgv_Promotion
        // 
        dgv_Promotion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgv_Promotion.Columns.AddRange(new DataGridViewColumn[] { col_Promotion, col_PromotionName, col_Discount, col_Start, col_End });
        dgv_Promotion.Location = new Point(12, 283);
        dgv_Promotion.Name = "dgv_Promotion";
        dgv_Promotion.RowHeadersWidth = 51;
        dgv_Promotion.Size = new Size(731, 355);
        dgv_Promotion.TabIndex = 1;
        dgv_Promotion.CellContentClick += dgv_Promotion_CellContentClick;
        // 
        // col_Promotion
        // 
        col_Promotion.HeaderText = "Mã Khuyến Mãi";
        col_Promotion.MinimumWidth = 6;
        col_Promotion.Name = "col_Promotion";
        col_Promotion.Width = 125;
        // 
        // col_PromotionName
        // 
        col_PromotionName.HeaderText = "Tên Chương Trình";
        col_PromotionName.MinimumWidth = 6;
        col_PromotionName.Name = "col_PromotionName";
        col_PromotionName.Width = 125;
        // 
        // col_Discount
        // 
        col_Discount.HeaderText = "Giảm %";
        col_Discount.MinimumWidth = 6;
        col_Discount.Name = "col_Discount";
        col_Discount.Width = 125;
        // 
        // col_Start
        // 
        col_Start.HeaderText = "Ngày Bắt Đầu";
        col_Start.MinimumWidth = 6;
        col_Start.Name = "col_Start";
        col_Start.Width = 125;
        // 
        // col_End
        // 
        col_End.HeaderText = "Ngày Kết Thúc";
        col_End.MinimumWidth = 6;
        col_End.Name = "col_End";
        col_End.Width = 125;
        // 
        // FormPromotion
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1269, 637);
        Controls.Add(dgv_Promotion);
        Controls.Add(groupBox1);
        Name = "FormPromotion";
        Text = "FormPromotion";
        Load += FormPromotion_Load;
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((ISupportInitialize)num_Discount).EndInit();
        ((ISupportInitialize)dgv_Promotion).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBox1;
    private Button btn_Delete;
    private Button btn_Update;
    private Button btn_Add;
    private DateTimePicker dt_End;
    private DateTimePicker dt_Start;
    private NumericUpDown num_Discount;
    private TextBox txt_PromotionName;
    private TextBox txt_PromotionID;
    private Label label5;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label label1;
    private DataGridView dgv_Promotion;
    private DataGridViewTextBoxColumn col_Promotion;
    private DataGridViewTextBoxColumn col_PromotionName;
    private DataGridViewTextBoxColumn col_Discount;
    private DataGridViewTextBoxColumn col_Start;
    private DataGridViewTextBoxColumn col_End;
}