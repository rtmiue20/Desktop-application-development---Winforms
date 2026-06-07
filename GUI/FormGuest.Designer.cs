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
        mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
        dgv_guest = new DataGridView();
        col_Phone = new DataGridViewTextBoxColumn();
        col_Name = new DataGridViewTextBoxColumn();
        col_Type = new DataGridViewTextBoxColumn();
        col_Point = new DataGridViewTextBoxColumn();
        col_Total = new DataGridViewTextBoxColumn();
        col_Date = new DataGridViewTextBoxColumn();
        btn_addCustomer = new Button();
        btn_edit = new Button();
        btn_purchaseHistory = new Button();
        btn_refresh = new Button();
        groupBox1 = new GroupBox();
        groupBox2 = new GroupBox();
        txt_search = new TextBox();
        label1 = new Label();
        groupBox3 = new GroupBox();
        txt_phoneNumber = new TextBox();
        txt_fullName = new TextBox();
        txt_address = new TextBox();
        cbo_customerType = new ComboBox();
        btn_save = new Button();
        btn_cancel = new Button();
        label6 = new Label();
        label5 = new Label();
        label4 = new Label();
        label3 = new Label();
        label2 = new Label();
        ((ISupportInitialize)dgv_guest).BeginInit();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        groupBox3.SuspendLayout();
        SuspendLayout();
        // 
        // mySqlCommand1
        // 
        mySqlCommand1.CacheAge = 0;
        mySqlCommand1.Connection = null;
        mySqlCommand1.EnableCaching = false;
        mySqlCommand1.Transaction = null;
        // 
        // dgv_guest
        // 
        dgv_guest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgv_guest.Columns.AddRange(new DataGridViewColumn[] { col_Phone, col_Name, col_Type, col_Point, col_Total, col_Date });
        dgv_guest.Location = new Point(8, 93);
        dgv_guest.Margin = new Padding(1);
        dgv_guest.Name = "dgv_guest";
        dgv_guest.RowHeadersWidth = 51;
        dgv_guest.Size = new Size(752, 319);
        dgv_guest.TabIndex = 1;
        dgv_guest.CellContentClick += dgv_guest_CellContentClick;
        // 
        // col_Phone
        // 
        col_Phone.HeaderText = "SĐT";
        col_Phone.MinimumWidth = 6;
        col_Phone.Name = "col_Phone";
        col_Phone.Width = 125;
        // 
        // col_Name
        // 
        col_Name.HeaderText = "Họ tên";
        col_Name.MinimumWidth = 6;
        col_Name.Name = "col_Name";
        col_Name.Width = 125;
        // 
        // col_Type
        // 
        col_Type.HeaderText = "Loại KH";
        col_Type.MinimumWidth = 6;
        col_Type.Name = "col_Type";
        col_Type.Width = 125;
        // 
        // col_Point
        // 
        col_Point.HeaderText = "Điểm tích lũy";
        col_Point.MinimumWidth = 6;
        col_Point.Name = "col_Point";
        col_Point.Width = 125;
        // 
        // col_Total
        // 
        col_Total.HeaderText = "Tổng mua";
        col_Total.MinimumWidth = 6;
        col_Total.Name = "col_Total";
        col_Total.Width = 125;
        // 
        // col_Date
        // 
        col_Date.HeaderText = "Ngày tạo";
        col_Date.MinimumWidth = 6;
        col_Date.Name = "col_Date";
        col_Date.Width = 125;
        // 
        // btn_addCustomer
        // 
        btn_addCustomer.Location = new Point(19, 43);
        btn_addCustomer.Name = "btn_addCustomer";
        btn_addCustomer.Size = new Size(140, 54);
        btn_addCustomer.TabIndex = 2;
        btn_addCustomer.Text = "Thêm KH";
        btn_addCustomer.UseVisualStyleBackColor = true;
        // 
        // btn_edit
        // 
        btn_edit.Location = new Point(175, 43);
        btn_edit.Name = "btn_edit";
        btn_edit.Size = new Size(140, 54);
        btn_edit.TabIndex = 3;
        btn_edit.Text = "Sửa";
        btn_edit.UseVisualStyleBackColor = true;
        btn_edit.Click += btn_Edit_Click;
        // 
        // btn_purchaseHistory
        // 
        btn_purchaseHistory.Location = new Point(333, 43);
        btn_purchaseHistory.Name = "btn_purchaseHistory";
        btn_purchaseHistory.Size = new Size(140, 54);
        btn_purchaseHistory.TabIndex = 4;
        btn_purchaseHistory.Text = "Lịch sử mua";
        btn_purchaseHistory.UseVisualStyleBackColor = true;
        // 
        // btn_refresh
        // 
        btn_refresh.Location = new Point(498, 43);
        btn_refresh.Name = "btn_refresh";
        btn_refresh.Size = new Size(140, 54);
        btn_refresh.TabIndex = 5;
        btn_refresh.Text = "Làm mới";
        btn_refresh.UseVisualStyleBackColor = true;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(btn_addCustomer);
        groupBox1.Controls.Add(btn_refresh);
        groupBox1.Controls.Add(btn_edit);
        groupBox1.Controls.Add(btn_purchaseHistory);
        groupBox1.Location = new Point(12, 12);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(659, 131);
        groupBox1.TabIndex = 6;
        groupBox1.TabStop = false;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(txt_search);
        groupBox2.Controls.Add(label1);
        groupBox2.Controls.Add(dgv_guest);
        groupBox2.Location = new Point(12, 149);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(764, 549);
        groupBox2.TabIndex = 7;
        groupBox2.TabStop = false;
        // 
        // txt_search
        // 
        txt_search.Location = new Point(106, 34);
        txt_search.Name = "txt_search";
        txt_search.Size = new Size(311, 27);
        txt_search.TabIndex = 2;
        txt_search.Text = "🔍 Tìm theo SĐT, tên khách hàng...";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(28, 34);
        label1.Name = "label1";
        label1.Size = new Size(72, 20);
        label1.TabIndex = 0;
        label1.Text = "Tìm Kiếm";
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(txt_phoneNumber);
        groupBox3.Controls.Add(txt_fullName);
        groupBox3.Controls.Add(txt_address);
        groupBox3.Controls.Add(cbo_customerType);
        groupBox3.Controls.Add(btn_save);
        groupBox3.Controls.Add(btn_cancel);
        groupBox3.Controls.Add(label6);
        groupBox3.Controls.Add(label5);
        groupBox3.Controls.Add(label4);
        groupBox3.Controls.Add(label3);
        groupBox3.Controls.Add(label2);
        groupBox3.Location = new Point(795, 26);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new Size(334, 554);
        groupBox3.TabIndex = 8;
        groupBox3.TabStop = false;
        // 
        // txt_phoneNumber
        // 
        txt_phoneNumber.Location = new Point(20, 90);
        txt_phoneNumber.Name = "txt_phoneNumber";
        txt_phoneNumber.Size = new Size(267, 27);
        txt_phoneNumber.TabIndex = 10;
        // 
        // txt_fullName
        // 
        txt_fullName.Location = new Point(20, 171);
        txt_fullName.Name = "txt_fullName";
        txt_fullName.Size = new Size(267, 27);
        txt_fullName.TabIndex = 9;
        // 
        // txt_address
        // 
        txt_address.Location = new Point(20, 239);
        txt_address.Name = "txt_address";
        txt_address.Size = new Size(267, 27);
        txt_address.TabIndex = 3;
        // 
        // cbo_customerType
        // 
        cbo_customerType.FormattingEnabled = true;
        cbo_customerType.Items.AddRange(new object[] { "Thường", "Thân thiết", "VIP" });
        cbo_customerType.Location = new Point(20, 328);
        cbo_customerType.Name = "cbo_customerType";
        cbo_customerType.Size = new Size(246, 28);
        cbo_customerType.TabIndex = 8;
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
        label6.Size = new Size(81, 20);
        label6.TabIndex = 7;
        label6.Text = "Loại Khách";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(20, 216);
        label5.Name = "label5";
        label5.Size = new Size(57, 20);
        label5.TabIndex = 6;
        label5.Text = "Địa Chỉ";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(20, 148);
        label4.Name = "label4";
        label4.Size = new Size(56, 20);
        label4.TabIndex = 5;
        label4.Text = "Họ Tên";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(20, 63);
        label3.Name = "label3";
        label3.Size = new Size(36, 20);
        label3.TabIndex = 4;
        label3.Text = "SĐT";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(20, 29);
        label2.Name = "label2";
        label2.Size = new Size(187, 20);
        label2.TabIndex = 3;
        label2.Text = "THÔNG TIN KHÁCH HÀNG";
        // 
        // FormGuest
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1320, 690);
        Controls.Add(groupBox3);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Name = "FormGuest";
        Text = "FormGuest";
        Load += FormGuest_Load;
        ((ISupportInitialize)dgv_guest).EndInit();
        groupBox1.ResumeLayout(false);
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        ResumeLayout(false);
    }

    #endregion
    private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    private DataGridView dgv_guest;
    private Button btn_addCustomer;
    private Button btn_edit;
    private Button btn_purchaseHistory;
    private Button btn_refresh;
    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private Label label1;
    private GroupBox groupBox3;
    private DataGridViewTextBoxColumn col_Phone;
    private DataGridViewTextBoxColumn col_Name;
    private DataGridViewTextBoxColumn col_Type;
    private DataGridViewTextBoxColumn col_Point;
    private DataGridViewTextBoxColumn col_Total;
    private DataGridViewTextBoxColumn col_Date;
    private TextBox txt_search;
    private Label label3;
    private Label label2;
    private Label label4;
    private TextBox txt_phoneNumber;
    private TextBox txt_fullName;
    private TextBox txt_address;
    private ComboBox cbo_customerType;
    private Button btn_save;
    private Button btn_cancel;
    private Label label6;
    private Label label5;
}