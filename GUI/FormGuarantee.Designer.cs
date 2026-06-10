using System.ComponentModel;

namespace Desktop_Application_Development;

partial class FormGuarantee
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
        components = new Container();
        bindingSource1 = new BindingSource(components);
        groupBox1 = new GroupBox();
        cbb_statusUpdate = new ComboBox();
        label1 = new Label();
        cbb_statusFilter = new ComboBox();
        btn_refresh = new Button();
        btn_updateStatus = new Button();
        btn_addWarranty = new Button();
        dgv_guaranteeList = new DataGridView();
        groupBox2 = new GroupBox();
        ((ISupportInitialize)bindingSource1).BeginInit();
        groupBox1.SuspendLayout();
        ((ISupportInitialize)dgv_guaranteeList).BeginInit();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(cbb_statusUpdate);
        groupBox1.Controls.Add(label1);
        groupBox1.Controls.Add(cbb_statusFilter);
        groupBox1.Controls.Add(btn_refresh);
        groupBox1.Controls.Add(btn_updateStatus);
        groupBox1.Controls.Add(btn_addWarranty);
        groupBox1.Location = new Point(5, 13);
        groupBox1.Margin = new Padding(6);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(6);
        groupBox1.Size = new Size(1912, 253);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Tiếp nhận bảo hành";
        // 
        // cbb_statusUpdate
        // 
        cbb_statusUpdate.FormattingEnabled = true;
        cbb_statusUpdate.Location = new Point(9, 195);
        cbb_statusUpdate.Name = "cbb_statusUpdate";
        cbb_statusUpdate.Size = new Size(911, 49);
        cbb_statusUpdate.TabIndex = 6;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(975, 42);
        label1.Name = "label1";
        label1.Size = new Size(155, 41);
        label1.TabIndex = 5;
        label1.Text = "Trạng thái:";
        // 
        // cbb_statusFilter
        // 
        cbb_statusFilter.FormattingEnabled = true;
        cbb_statusFilter.Location = new Point(1139, 44);
        cbb_statusFilter.Margin = new Padding(6);
        cbb_statusFilter.Name = "cbb_statusFilter";
        cbb_statusFilter.Size = new Size(761, 49);
        cbb_statusFilter.TabIndex = 4;
        cbb_statusFilter.SelectedIndexChanged += cbb_statusFilter_SelectedIndexChanged;
        // 
        // btn_refresh
        // 
        btn_refresh.Location = new Point(1304, 136);
        btn_refresh.Margin = new Padding(6);
        btn_refresh.Name = "btn_refresh";
        btn_refresh.Size = new Size(374, 50);
        btn_refresh.TabIndex = 3;
        btn_refresh.Text = "Làm mới";
        btn_refresh.UseVisualStyleBackColor = true;
        btn_refresh.Click += btn_refresh_Click;
        // 
        // btn_updateStatus
        // 
        btn_updateStatus.Location = new Point(10, 135);
        btn_updateStatus.Margin = new Padding(6);
        btn_updateStatus.Name = "btn_updateStatus";
        btn_updateStatus.Size = new Size(323, 51);
        btn_updateStatus.TabIndex = 1;
        btn_updateStatus.Text = "Cập nhật trạng thái";
        btn_updateStatus.UseVisualStyleBackColor = true;
        btn_updateStatus.Click += btn_updateStatus_Click_1;
        // 
        // btn_addWarranty
        // 
        btn_addWarranty.Location = new Point(10, 42);
        btn_addWarranty.Margin = new Padding(6);
        btn_addWarranty.Name = "btn_addWarranty";
        btn_addWarranty.Size = new Size(911, 51);
        btn_addWarranty.TabIndex = 0;
        btn_addWarranty.Text = "Tiếp nhận";
        btn_addWarranty.UseVisualStyleBackColor = true;
        btn_addWarranty.Click += btn_addWarranty_Click;
        // 
        // dgv_guaranteeList
        // 
        dgv_guaranteeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgv_guaranteeList.Location = new Point(0, 0);
        dgv_guaranteeList.Margin = new Padding(6);
        dgv_guaranteeList.Name = "dgv_guaranteeList";
        dgv_guaranteeList.RowHeadersWidth = 51;
        dgv_guaranteeList.Size = new Size(1912, 729);
        dgv_guaranteeList.TabIndex = 1;
        dgv_guaranteeList.Text = "dataGridView1";
        dgv_guaranteeList.CellClick += dgv_guaranteeList_CellClick;
        dgv_guaranteeList.CellContentClick += dgv_guaranteeList_CellContentClick;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(dgv_guaranteeList);
        groupBox2.Location = new Point(5, 275);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(1933, 738);
        groupBox2.TabIndex = 2;
        groupBox2.TabStop = false;
        // 
        // FormGuarantee
        // 
        AutoScaleDimensions = new SizeF(17F, 41F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1922, 1019);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Margin = new Padding(13, 12, 13, 12);
        Name = "FormGuarantee";
        Text = "Tiếp nhận bảo hành";
        Load += FormGuarantee_Load;
        ((ISupportInitialize)bindingSource1).EndInit();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((ISupportInitialize)dgv_guaranteeList).EndInit();
        groupBox2.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button btn_refresh;
    private System.Windows.Forms.ComboBox cbb_statusFilter;
    private System.Windows.Forms.DataGridView dgv_guaranteeList;

    private System.Windows.Forms.Button btn_returnDevice;

    private System.Windows.Forms.Button btn_updateStatus;

    private System.Windows.Forms.Button btn_addWarranty;

    private System.Windows.Forms.GroupBox groupBox1;

    private System.Windows.Forms.BindingSource bindingSource1;

    private System.Windows.Forms.DataGridView dgvWarranty;

    private System.Windows.Forms.Label Số;

    #endregion

    private GroupBox groupBox2;
    private Label label1;
    private ComboBox cbb_statusUpdate;
}