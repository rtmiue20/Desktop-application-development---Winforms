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
        components = new System.ComponentModel.Container();
        bindingSource1 = new System.Windows.Forms.BindingSource(components);
        groupBox1 = new System.Windows.Forms.GroupBox();
        btn_addWarranty = new System.Windows.Forms.Button();
        btn_updateStatus = new System.Windows.Forms.Button();
        btn_returnDevice = new System.Windows.Forms.Button();
        btn_refresh = new System.Windows.Forms.Button();
        cbb_statusFilter = new System.Windows.Forms.ComboBox();
        dgv_guaranteeList = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgv_guaranteeList).BeginInit();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(cbb_statusFilter);
        groupBox1.Controls.Add(btn_refresh);
        groupBox1.Controls.Add(btn_returnDevice);
        groupBox1.Controls.Add(btn_updateStatus);
        groupBox1.Controls.Add(btn_addWarranty);
        groupBox1.Location = new System.Drawing.Point(12, 12);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(835, 119);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Tiếp nhận bảo hành";
        // 
        // btn_addWarranty
        // 
        btn_addWarranty.Location = new System.Drawing.Point(27, 26);
        btn_addWarranty.Name = "btn_addWarranty";
        btn_addWarranty.Size = new System.Drawing.Size(113, 34);
        btn_addWarranty.TabIndex = 0;
        btn_addWarranty.Text = "Tiếp nhận";
        btn_addWarranty.UseVisualStyleBackColor = true;
        // 
        // btn_updateStatus
        // 
        btn_updateStatus.Location = new System.Drawing.Point(239, 26);
        btn_updateStatus.Name = "btn_updateStatus";
        btn_updateStatus.Size = new System.Drawing.Size(151, 34);
        btn_updateStatus.TabIndex = 1;
        btn_updateStatus.Text = "Cập nhật trạng thái";
        btn_updateStatus.UseVisualStyleBackColor = true;
        // 
        // btn_returnDevice
        // 
        btn_returnDevice.Location = new System.Drawing.Point(500, 26);
        btn_returnDevice.Name = "btn_returnDevice";
        btn_returnDevice.Size = new System.Drawing.Size(116, 34);
        btn_returnDevice.TabIndex = 2;
        btn_returnDevice.Text = "Trả máy";
        btn_returnDevice.UseVisualStyleBackColor = true;
        // 
        // btn_refresh
        // 
        btn_refresh.Location = new System.Drawing.Point(700, 26);
        btn_refresh.Name = "btn_refresh";
        btn_refresh.Size = new System.Drawing.Size(116, 34);
        btn_refresh.TabIndex = 3;
        btn_refresh.Text = "Làm mới";
        btn_refresh.UseVisualStyleBackColor = true;
        // 
        // cbb_statusFilter
        // 
        cbb_statusFilter.FormattingEnabled = true;
        cbb_statusFilter.Location = new System.Drawing.Point(227, 85);
        cbb_statusFilter.Name = "cbb_statusFilter";
        cbb_statusFilter.Size = new System.Drawing.Size(408, 28);
        cbb_statusFilter.TabIndex = 4;
        // 
        // dgv_guaranteeList
        // 
        dgv_guaranteeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgv_guaranteeList.Location = new System.Drawing.Point(12, 137);
        dgv_guaranteeList.Name = "dgv_guaranteeList";
        dgv_guaranteeList.RowHeadersWidth = 51;
        dgv_guaranteeList.Size = new System.Drawing.Size(835, 539);
        dgv_guaranteeList.TabIndex = 1;
        dgv_guaranteeList.Text = "dataGridView1";
        // 
        // FormGuarantee
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1536, 976);
        Controls.Add(dgv_guaranteeList);
        Controls.Add(groupBox1);
        Margin = new System.Windows.Forms.Padding(6);
        Text = "Tiếp nhận bảo hành";
        Load += FormWarranty_Load;
        ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
        groupBox1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgv_guaranteeList).EndInit();
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
}