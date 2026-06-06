using System.ComponentModel;

namespace Desktop_Application_Development;

partial class FormWarranty
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
        groupBox1 = new System.Windows.Forms.GroupBox();
        txtDeviceStatus = new System.Windows.Forms.TextBox();
        txtPhone = new System.Windows.Forms.TextBox();
        txtProductName = new System.Windows.Forms.TextBox();
        txtCustomerName = new System.Windows.Forms.TextBox();
        label5 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        btnSearch = new System.Windows.Forms.Button();
        txtSearch = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        dgvWarranty = new System.Windows.Forms.DataGridView();
        groupBox2 = new System.Windows.Forms.GroupBox();
        btnUpdateStatus = new System.Windows.Forms.Button();
        rtbResolution = new System.Windows.Forms.RichTextBox();
        label8 = new System.Windows.Forms.Label();
        cboStatus = new System.Windows.Forms.ComboBox();
        label7 = new System.Windows.Forms.Label();
        btnCreateClaim = new System.Windows.Forms.Button();
        rtbDefectDescription = new System.Windows.Forms.RichTextBox();
        label6 = new System.Windows.Forms.Label();
        bindingSource1 = new System.Windows.Forms.BindingSource(components);
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvWarranty).BeginInit();
        groupBox2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(txtDeviceStatus);
        groupBox1.Controls.Add(txtPhone);
        groupBox1.Controls.Add(txtProductName);
        groupBox1.Controls.Add(txtCustomerName);
        groupBox1.Controls.Add(label5);
        groupBox1.Controls.Add(label4);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(btnSearch);
        groupBox1.Controls.Add(txtSearch);
        groupBox1.Controls.Add(label1);
        groupBox1.Location = new System.Drawing.Point(12, 0);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(604, 167);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "GIAI ĐOẠN TIẾP NHẬN";
        // 
        // txtDeviceStatus
        // 
        txtDeviceStatus.Location = new System.Drawing.Point(315, 132);
        txtDeviceStatus.Name = "txtDeviceStatus";
        txtDeviceStatus.ReadOnly = true;
        txtDeviceStatus.Size = new System.Drawing.Size(251, 27);
        txtDeviceStatus.TabIndex = 10;
        // 
        // txtPhone
        // 
        txtPhone.Location = new System.Drawing.Point(315, 82);
        txtPhone.Name = "txtPhone";
        txtPhone.ReadOnly = true;
        txtPhone.Size = new System.Drawing.Size(251, 27);
        txtPhone.TabIndex = 9;
        // 
        // txtProductName
        // 
        txtProductName.Location = new System.Drawing.Point(6, 132);
        txtProductName.Name = "txtProductName";
        txtProductName.ReadOnly = true;
        txtProductName.Size = new System.Drawing.Size(251, 27);
        txtProductName.TabIndex = 8;
        // 
        // txtCustomerName
        // 
        txtCustomerName.Location = new System.Drawing.Point(6, 79);
        txtCustomerName.Name = "txtCustomerName";
        txtCustomerName.ReadOnly = true;
        txtCustomerName.Size = new System.Drawing.Size(251, 27);
        txtCustomerName.TabIndex = 7;
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(315, 112);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(117, 23);
        label5.TabIndex = 6;
        label5.Text = "Tình trạng máy";
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(6, 112);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(115, 23);
        label4.TabIndex = 5;
        label4.Text = "Tên sản phẩm";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(315, 56);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(104, 23);
        label3.TabIndex = 4;
        label3.Text = "Số điện thoại";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(6, 56);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(88, 23);
        label2.TabIndex = 3;
        label2.Text = "Khách hàng";
        // 
        // btnSearch
        // 
        btnSearch.Location = new System.Drawing.Point(463, 23);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new System.Drawing.Size(103, 33);
        btnSearch.TabIndex = 2;
        btnSearch.Text = "Tìm kiếm";
        btnSearch.UseVisualStyleBackColor = true;
        // 
        // txtSearch
        // 
        txtSearch.Location = new System.Drawing.Point(160, 26);
        txtSearch.Name = "txtSearch";
        txtSearch.Size = new System.Drawing.Size(297, 27);
        txtSearch.TabIndex = 1;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(6, 31);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(157, 23);
        label1.TabIndex = 0;
        label1.Text = "Số Serial/ Điện thoại: ";
        // 
        // dgvWarranty
        // 
        dgvWarranty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvWarranty.Location = new System.Drawing.Point(12, 174);
        dgvWarranty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        dgvWarranty.Name = "dgvWarranty";
        dgvWarranty.RowHeadersWidth = 51;
        dgvWarranty.Size = new System.Drawing.Size(604, 514);
        dgvWarranty.TabIndex = 1;
        dgvWarranty.Text = "dataGridView1";
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(btnUpdateStatus);
        groupBox2.Controls.Add(rtbResolution);
        groupBox2.Controls.Add(label8);
        groupBox2.Controls.Add(cboStatus);
        groupBox2.Controls.Add(label7);
        groupBox2.Controls.Add(btnCreateClaim);
        groupBox2.Controls.Add(rtbDefectDescription);
        groupBox2.Controls.Add(label6);
        groupBox2.Location = new System.Drawing.Point(622, 0);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new System.Drawing.Size(350, 688);
        groupBox2.TabIndex = 2;
        groupBox2.TabStop = false;
        // 
        // btnUpdateStatus
        // 
        btnUpdateStatus.Location = new System.Drawing.Point(0, 649);
        btnUpdateStatus.Name = "btnUpdateStatus";
        btnUpdateStatus.Size = new System.Drawing.Size(338, 33);
        btnUpdateStatus.TabIndex = 12;
        btnUpdateStatus.Text = "Cập nhật tiến độ\r\n";
        btnUpdateStatus.UseVisualStyleBackColor = true;
        // 
        // rtbResolution
        // 
        rtbResolution.Location = new System.Drawing.Point(6, 441);
        rtbResolution.Name = "rtbResolution";
        rtbResolution.Size = new System.Drawing.Size(338, 202);
        rtbResolution.TabIndex = 11;
        rtbResolution.Text = "";
        // 
        // label8
        // 
        label8.Location = new System.Drawing.Point(6, 415);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(150, 23);
        label8.TabIndex = 10;
        label8.Text = "Ghi chú xử lý";
        // 
        // cboStatus
        // 
        cboStatus.FormattingEnabled = true;
        cboStatus.Location = new System.Drawing.Point(6, 384);
        cboStatus.Name = "cboStatus";
        cboStatus.Size = new System.Drawing.Size(338, 28);
        cboStatus.TabIndex = 9;
        // 
        // label7
        // 
        label7.Location = new System.Drawing.Point(6, 358);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(150, 23);
        label7.TabIndex = 8;
        label7.Text = "Cập nhật trạng thái: ";
        // 
        // btnCreateClaim
        // 
        btnCreateClaim.Location = new System.Drawing.Point(6, 321);
        btnCreateClaim.Name = "btnCreateClaim";
        btnCreateClaim.Size = new System.Drawing.Size(338, 33);
        btnCreateClaim.TabIndex = 7;
        btnCreateClaim.Text = "LẬP PHIẾU BẢO HÀNH";
        btnCreateClaim.UseVisualStyleBackColor = true;
        // 
        // rtbDefectDescription
        // 
        rtbDefectDescription.Location = new System.Drawing.Point(6, 49);
        rtbDefectDescription.Name = "rtbDefectDescription";
        rtbDefectDescription.Size = new System.Drawing.Size(338, 256);
        rtbDefectDescription.TabIndex = 5;
        rtbDefectDescription.Text = "";
        rtbDefectDescription.TextChanged += richTextBox1_TextChanged;
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(6, 23);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(120, 23);
        label6.TabIndex = 4;
        label6.Text = "Mô tả sản phẩm";
        // 
        // FormWarranty
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(984, 701);
        Controls.Add(groupBox2);
        Controls.Add(dgvWarranty);
        Controls.Add(groupBox1);
        Text = "Tiếp nhận bảo hành";
        Load += FormWarranty_Load;
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvWarranty).EndInit();
        groupBox2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnUpdateStatus;

    private System.Windows.Forms.RichTextBox rtbResolution;

    private System.Windows.Forms.Label label8;

    private System.Windows.Forms.ComboBox cboStatus;

    private System.Windows.Forms.Label label7;

    private System.Windows.Forms.BindingSource bindingSource1;

    private System.Windows.Forms.Button btnCreateClaim;

    private System.Windows.Forms.RichTextBox rtbDefectDescription;

    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.TextBox txtCustomerName;
    private System.Windows.Forms.TextBox txtProductName;
    private System.Windows.Forms.TextBox txtPhone;
    private System.Windows.Forms.TextBox txtDeviceStatus;

    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.GroupBox groupBox2;

    private System.Windows.Forms.DataGridView dgvWarranty;

    private System.Windows.Forms.Button btnSearch;

    private System.Windows.Forms.TextBox txtSearch;

    private System.Windows.Forms.Label Số;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.GroupBox groupBox1;

    #endregion
}