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
        btn_addCustomer = new Button();
        btn_edit = new Button();
        btn_purchaseHistory = new Button();
        btn_refresh = new Button();
        groupBox2 = new GroupBox();
        txt_search = new TextBox();
        groupBox3 = new GroupBox();
        label7 = new Label();
        label3 = new Label();
        label2 = new Label();
        label1 = new Label();
        txt_phoneNumber = new TextBox();
        txt_fullName = new TextBox();
        txt_address = new TextBox();
        cbo_customerType = new ComboBox();
        btn_save = new Button();
        btn_cancel = new Button();
        pnl_top = new Panel();
        groupBox1 = new GroupBox();
        col_phones = new DataGridViewTextBoxColumn();
        col_names = new DataGridViewTextBoxColumn();
        col_types = new DataGridViewTextBoxColumn();
        col_points = new DataGridViewTextBoxColumn();
        col_totals = new DataGridViewTextBoxColumn();
        col_dates = new DataGridViewTextBoxColumn();
        ((ISupportInitialize)dgv_guest).BeginInit();
        groupBox2.SuspendLayout();
        groupBox3.SuspendLayout();
        pnl_top.SuspendLayout();
        groupBox1.SuspendLayout();
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
        dgv_guest.Columns.AddRange(new DataGridViewColumn[] { col_phones, col_names, col_types, col_points, col_totals, col_dates });
        dgv_guest.Location = new Point(5, 13);
        dgv_guest.Margin = new Padding(0);
        dgv_guest.Name = "dgv_guest";
        dgv_guest.RowHeadersWidth = 51;
        dgv_guest.Size = new Size(494, 378);
        dgv_guest.TabIndex = 1;
        dgv_guest.CellContentClick += dgv_guest_CellContentClick;
        // 
        // btn_addCustomer
        // 
        btn_addCustomer.Location = new Point(5, 8);
        btn_addCustomer.Margin = new Padding(1);
        btn_addCustomer.Name = "btn_addCustomer";
        btn_addCustomer.Size = new Size(214, 26);
        btn_addCustomer.TabIndex = 2;
        btn_addCustomer.Text = "Thêm KH";
        btn_addCustomer.UseVisualStyleBackColor = true;
        // 
        // btn_edit
        // 
        btn_edit.Location = new Point(223, 8);
        btn_edit.Margin = new Padding(1);
        btn_edit.Name = "btn_edit";
        btn_edit.Size = new Size(201, 26);
        btn_edit.TabIndex = 3;
        btn_edit.Text = "Sửa";
        btn_edit.UseVisualStyleBackColor = true;
        btn_edit.Click += btn_Edit_Click;
        // 
        // btn_purchaseHistory
        // 
        btn_purchaseHistory.Location = new Point(426, 8);
        btn_purchaseHistory.Margin = new Padding(1);
        btn_purchaseHistory.Name = "btn_purchaseHistory";
        btn_purchaseHistory.Size = new Size(194, 26);
        btn_purchaseHistory.TabIndex = 4;
        btn_purchaseHistory.Text = "Lịch sử mua";
        btn_purchaseHistory.UseVisualStyleBackColor = true;
        // 
        // btn_refresh
        // 
        btn_refresh.Location = new Point(623, 8);
        btn_refresh.Margin = new Padding(1);
        btn_refresh.Name = "btn_refresh";
        btn_refresh.Size = new Size(198, 26);
        btn_refresh.TabIndex = 5;
        btn_refresh.Text = "Làm mới";
        btn_refresh.UseVisualStyleBackColor = true;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(dgv_guest);
        groupBox2.Location = new Point(0, 79);
        groupBox2.Margin = new Padding(1);
        groupBox2.Name = "groupBox2";
        groupBox2.Padding = new Padding(1);
        groupBox2.Size = new Size(501, 394);
        groupBox2.TabIndex = 7;
        groupBox2.TabStop = false;
        // 
        // txt_search
        // 
        txt_search.Location = new Point(5, 11);
        txt_search.Margin = new Padding(1);
        txt_search.Name = "txt_search";
        txt_search.Size = new Size(818, 27);
        txt_search.TabIndex = 2;
        txt_search.Text = "🔍 Tìm theo SĐT, tên khách hàng...";
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(label7);
        groupBox3.Controls.Add(label3);
        groupBox3.Controls.Add(label2);
        groupBox3.Controls.Add(label1);
        groupBox3.Controls.Add(txt_phoneNumber);
        groupBox3.Controls.Add(txt_fullName);
        groupBox3.Controls.Add(txt_address);
        groupBox3.Controls.Add(cbo_customerType);
        groupBox3.Controls.Add(btn_save);
        groupBox3.Controls.Add(btn_cancel);
        groupBox3.Location = new Point(504, 91);
        groupBox3.Margin = new Padding(1);
        groupBox3.Name = "groupBox3";
        groupBox3.Padding = new Padding(1);
        groupBox3.Size = new Size(324, 381);
        groupBox3.TabIndex = 8;
        groupBox3.TabStop = false;
        groupBox3.Text = "THÔNG TIN KHÁCH HÀNG";
        // 
        // label7
        // 
        label7.Location = new Point(9, 80);
        label7.Margin = new Padding(1, 0, 1, 0);
        label7.Name = "label7";
        label7.Size = new Size(72, 22);
        label7.TabIndex = 14;
        label7.Text = "Họ Tên:";
        // 
        // label3
        // 
        label3.Location = new Point(9, 139);
        label3.Margin = new Padding(1, 0, 1, 0);
        label3.Name = "label3";
        label3.Size = new Size(83, 22);
        label3.TabIndex = 13;
        label3.Text = "Địa Chỉ:";
        // 
        // label2
        // 
        label2.Location = new Point(9, 198);
        label2.Margin = new Padding(1, 0, 1, 0);
        label2.Name = "label2";
        label2.Size = new Size(116, 23);
        label2.TabIndex = 12;
        label2.Text = "Loại Khách:";
        // 
        // label1
        // 
        label1.Location = new Point(9, 25);
        label1.Margin = new Padding(1, 0, 1, 0);
        label1.Name = "label1";
        label1.Size = new Size(55, 21);
        label1.TabIndex = 11;
        label1.Text = "SĐT:";
        // 
        // txt_phoneNumber
        // 
        txt_phoneNumber.Location = new Point(9, 48);
        txt_phoneNumber.Margin = new Padding(1);
        txt_phoneNumber.Name = "txt_phoneNumber";
        txt_phoneNumber.Size = new Size(310, 27);
        txt_phoneNumber.TabIndex = 10;
        // 
        // txt_fullName
        // 
        txt_fullName.Location = new Point(9, 104);
        txt_fullName.Margin = new Padding(1);
        txt_fullName.Name = "txt_fullName";
        txt_fullName.Size = new Size(310, 27);
        txt_fullName.TabIndex = 9;
        // 
        // txt_address
        // 
        txt_address.Location = new Point(9, 163);
        txt_address.Margin = new Padding(1);
        txt_address.Name = "txt_address";
        txt_address.Size = new Size(310, 27);
        txt_address.TabIndex = 3;
        txt_address.TextChanged += txt_address_TextChanged;
        // 
        // cbo_customerType
        // 
        cbo_customerType.FormattingEnabled = true;
        cbo_customerType.Items.AddRange(new object[] { "Thường", "Thân thiết", "VIP" });
        cbo_customerType.Location = new Point(9, 222);
        cbo_customerType.Margin = new Padding(1);
        cbo_customerType.Name = "cbo_customerType";
        cbo_customerType.Size = new Size(310, 28);
        cbo_customerType.TabIndex = 8;
        // 
        // btn_save
        // 
        btn_save.Location = new Point(9, 272);
        btn_save.Margin = new Padding(1);
        btn_save.Name = "btn_save";
        btn_save.Size = new Size(308, 26);
        btn_save.TabIndex = 6;
        btn_save.Text = "Lưu";
        btn_save.UseVisualStyleBackColor = true;
        // 
        // btn_cancel
        // 
        btn_cancel.Location = new Point(9, 309);
        btn_cancel.Margin = new Padding(1);
        btn_cancel.Name = "btn_cancel";
        btn_cancel.Size = new Size(308, 26);
        btn_cancel.TabIndex = 7;
        btn_cancel.Text = "Hủy";
        btn_cancel.UseVisualStyleBackColor = true;
        // 
        // pnl_top
        // 
        pnl_top.Controls.Add(btn_refresh);
        pnl_top.Controls.Add(btn_addCustomer);
        pnl_top.Controls.Add(btn_purchaseHistory);
        pnl_top.Controls.Add(btn_edit);
        pnl_top.Location = new Point(0, -2);
        pnl_top.Margin = new Padding(1);
        pnl_top.Name = "pnl_top";
        pnl_top.Size = new Size(827, 41);
        pnl_top.TabIndex = 9;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(txt_search);
        groupBox1.Location = new Point(0, 41);
        groupBox1.Margin = new Padding(1);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(1);
        groupBox1.Size = new Size(827, 37);
        groupBox1.TabIndex = 10;
        groupBox1.TabStop = false;
        // 
        // col_phones
        // 
        col_phones.HeaderText = "SĐT";
        col_phones.MinimumWidth = 6;
        col_phones.Name = "col_phones";
        col_phones.Width = 125;
        // 
        // col_names
        // 
        col_names.HeaderText = "Họ tên";
        col_names.MinimumWidth = 6;
        col_names.Name = "col_names";
        col_names.Width = 125;
        // 
        // col_types
        // 
        col_types.HeaderText = "Loại KH";
        col_types.MinimumWidth = 6;
        col_types.Name = "col_types";
        col_types.Width = 125;
        // 
        // col_points
        // 
        col_points.HeaderText = "Điểm tích lũy";
        col_points.MinimumWidth = 6;
        col_points.Name = "col_points";
        col_points.Width = 125;
        // 
        // col_totals
        // 
        col_totals.HeaderText = "Tổng mua";
        col_totals.MinimumWidth = 6;
        col_totals.Name = "col_totals";
        col_totals.Width = 125;
        // 
        // col_dates
        // 
        col_dates.HeaderText = "Ngày tạo";
        col_dates.MinimumWidth = 6;
        col_dates.Name = "col_dates";
        col_dates.Width = 125;
        // 
        // FormGuest
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(827, 474);
        Controls.Add(groupBox1);
        Controls.Add(pnl_top);
        Controls.Add(groupBox3);
        Controls.Add(groupBox2);
        Name = "FormGuest";
        Text = "FormGuest";
        Load += FormGuest_Load;
        ((ISupportInitialize)dgv_guest).EndInit();
        groupBox2.ResumeLayout(false);
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        pnl_top.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label7;

    private System.Windows.Forms.GroupBox groupBox1;

    private System.Windows.Forms.Panel pnl_top;

    #endregion
    private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    private System.Windows.Forms.DataGridView dgv_guest;
    private System.Windows.Forms.Button btn_addCustomer;
    private System.Windows.Forms.Button btn_edit;
    private System.Windows.Forms.Button btn_purchaseHistory;
    private System.Windows.Forms.Button btn_refresh;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.TextBox txt_search;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txt_phoneNumber;
    private System.Windows.Forms.TextBox txt_fullName;
    private System.Windows.Forms.TextBox txt_address;
    private System.Windows.Forms.ComboBox cbo_customerType;
    private System.Windows.Forms.Button btn_save;
    private System.Windows.Forms.Button btn_cancel;
    private DataGridViewTextBoxColumn col_phones;
    private DataGridViewTextBoxColumn col_names;
    private DataGridViewTextBoxColumn col_types;
    private DataGridViewTextBoxColumn col_points;
    private DataGridViewTextBoxColumn col_totals;
    private DataGridViewTextBoxColumn col_dates;
}