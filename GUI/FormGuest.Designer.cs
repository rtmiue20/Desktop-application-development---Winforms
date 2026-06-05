using System.ComponentModel;

namespace GUI;

partial class FormGuest
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
        txt_GuestID = new TextBox();
        txt_GuestName = new TextBox();
        txt_Phone = new TextBox();
        mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
        cbo_Rank = new ComboBox();
        btn_add = new Button();
        btn_update = new Button();
        btn_delete = new Button();
        btn_search = new Button();
        dgv_Guest = new DataGridView();
        col_CustomerID = new DataGridViewTextBoxColumn();
        col_customer_name = new DataGridViewTextBoxColumn();
        col_PhoneNumber = new DataGridViewTextBoxColumn();
        col_RewardPoints = new DataGridViewTextBoxColumn();
        col_MembershipTier = new DataGridViewTextBoxColumn();
        groupBox1.SuspendLayout();
        ((ISupportInitialize)dgv_Guest).BeginInit();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(btn_search);
        groupBox1.Controls.Add(btn_delete);
        groupBox1.Controls.Add(btn_update);
        groupBox1.Controls.Add(btn_add);
        groupBox1.Controls.Add(cbo_Rank);
        groupBox1.Controls.Add(txt_Phone);
        groupBox1.Controls.Add(txt_GuestName);
        groupBox1.Controls.Add(txt_GuestID);
        groupBox1.Controls.Add(label4);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(label1);
        groupBox1.Location = new Point(27, 35);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(1072, 304);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "groupBox1";
        groupBox1.Enter += groupBox1_Enter;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(37, 45);
        label1.Name = "label1";
        label1.Size = new Size(54, 20);
        label1.TabIndex = 0;
        label1.Text = "Mã KH";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(37, 83);
        label2.Name = "label2";
        label2.Size = new Size(56, 20);
        label2.TabIndex = 1;
        label2.Text = "Tên KH";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(37, 128);
        label3.Name = "label3";
        label3.Size = new Size(36, 20);
        label3.TabIndex = 2;
        label3.Text = "SĐT";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(37, 184);
        label4.Name = "label4";
        label4.Size = new Size(51, 20);
        label4.TabIndex = 3;
        label4.Text = "HẠNG";
        // 
        // txt_GuestID
        // 
        txt_GuestID.Location = new Point(131, 45);
        txt_GuestID.Name = "txt_GuestID";
        txt_GuestID.Size = new Size(125, 27);
        txt_GuestID.TabIndex = 4;
        // 
        // txt_GuestName
        // 
        txt_GuestName.Location = new Point(131, 83);
        txt_GuestName.Name = "txt_GuestName";
        txt_GuestName.Size = new Size(125, 27);
        txt_GuestName.TabIndex = 5;
        // 
        // txt_Phone
        // 
        txt_Phone.Location = new Point(131, 125);
        txt_Phone.Name = "txt_Phone";
        txt_Phone.Size = new Size(125, 27);
        txt_Phone.TabIndex = 6;
        // 
        // mySqlCommand1
        // 
        mySqlCommand1.CacheAge = 0;
        mySqlCommand1.Connection = null;
        mySqlCommand1.EnableCaching = false;
        mySqlCommand1.Transaction = null;
        // 
        // cbo_Rank
        // 
        cbo_Rank.FormattingEnabled = true;
        cbo_Rank.Location = new Point(131, 184);
        cbo_Rank.Name = "cbo_Rank";
        cbo_Rank.Size = new Size(151, 28);
        cbo_Rank.TabIndex = 7;
        // 
        // btn_add
        // 
        btn_add.Location = new Point(37, 246);
        btn_add.Name = "btn_add";
        btn_add.Size = new Size(117, 41);
        btn_add.TabIndex = 8;
        btn_add.Text = "Thêm";
        btn_add.UseVisualStyleBackColor = true;
        // 
        // btn_update
        // 
        btn_update.Location = new Point(198, 246);
        btn_update.Name = "btn_update";
        btn_update.Size = new Size(117, 41);
        btn_update.TabIndex = 9;
        btn_update.Text = "Sửa";
        btn_update.UseVisualStyleBackColor = true;
        // 
        // btn_delete
        // 
        btn_delete.Location = new Point(369, 246);
        btn_delete.Name = "btn_delete";
        btn_delete.Size = new Size(117, 41);
        btn_delete.TabIndex = 10;
        btn_delete.Text = "Xóa";
        btn_delete.UseVisualStyleBackColor = true;
        // 
        // btn_search
        // 
        btn_search.Location = new Point(535, 246);
        btn_search.Name = "btn_search";
        btn_search.Size = new Size(117, 41);
        btn_search.TabIndex = 12;
        btn_search.Text = "Tìm Kiếm";
        btn_search.UseVisualStyleBackColor = true;
        // 
        // dgv_Guest
        // 
        dgv_Guest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgv_Guest.Columns.AddRange(new DataGridViewColumn[] { col_CustomerID, col_customer_name, col_PhoneNumber, col_RewardPoints, col_MembershipTier });
        dgv_Guest.Location = new Point(27, 358);
        dgv_Guest.Name = "dgv_Guest";
        dgv_Guest.RowHeadersWidth = 51;
        dgv_Guest.Size = new Size(1072, 287);
        dgv_Guest.TabIndex = 1;
        // 
        // col_CustomerID
        // 
        col_CustomerID.HeaderText = "Mã KH";
        col_CustomerID.MinimumWidth = 6;
        col_CustomerID.Name = "col_CustomerID";
        col_CustomerID.Width = 125;
        // 
        // col_customer_name
        // 
        col_customer_name.HeaderText = "Tên KH\n\n";
        col_customer_name.MinimumWidth = 6;
        col_customer_name.Name = "col_customer_name";
        col_customer_name.Width = 125;
        // 
        // col_PhoneNumber
        // 
        col_PhoneNumber.HeaderText = "SĐT";
        col_PhoneNumber.MinimumWidth = 6;
        col_PhoneNumber.Name = "col_PhoneNumber";
        col_PhoneNumber.Width = 125;
        // 
        // col_RewardPoints
        // 
        col_RewardPoints.HeaderText = "Điểm tích lũy";
        col_RewardPoints.MinimumWidth = 6;
        col_RewardPoints.Name = "col_RewardPoints";
        col_RewardPoints.Width = 125;
        // 
        // col_MembershipTier
        // 
        col_MembershipTier.HeaderText = "Hạng";
        col_MembershipTier.MinimumWidth = 6;
        col_MembershipTier.Name = "col_MembershipTier";
        col_MembershipTier.Width = 125;
        // 
        // FormGuest
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1276, 646);
        Controls.Add(dgv_Guest);
        Controls.Add(groupBox1);
        Name = "FormGuest";
        Text = "FormGuest";
        Load += FormGuest_Load;
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((ISupportInitialize)dgv_Guest).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBox1;
    private Button btn_search;
    private Button btn_delete;
    private Button btn_update;
    private Button btn_add;
    private ComboBox cbo_Rank;
    private TextBox txt_Phone;
    private TextBox txt_GuestName;
    private TextBox txt_GuestID;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label label1;
    private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    private DataGridView dgv_Guest;
    private DataGridViewTextBoxColumn col_CustomerID;
    private DataGridViewTextBoxColumn col_customer_name;
    private DataGridViewTextBoxColumn col_PhoneNumber;
    private DataGridViewTextBoxColumn col_RewardPoints;
    private DataGridViewTextBoxColumn col_MembershipTier;
}