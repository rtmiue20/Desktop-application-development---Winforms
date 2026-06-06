using System.ComponentModel;

namespace Desktop_Application_Development;

partial class FormTradeIn
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
        groupBox1 = new System.Windows.Forms.GroupBox();
        btnCancel = new System.Windows.Forms.Button();
        btnConfirm = new System.Windows.Forms.Button();
        btnCreateTradeIn = new System.Windows.Forms.Button();
        dgvInvoiceDetails = new System.Windows.Forms.DataGridView();
        groupBox2 = new System.Windows.Forms.GroupBox();
        cboReason = new System.Windows.Forms.ComboBox();
        label2 = new System.Windows.Forms.Label();
        btnSearch = new System.Windows.Forms.Button();
        txtInvoiceCode = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        txtCustomerName = new System.Windows.Forms.TextBox();
        label4 = new System.Windows.Forms.Label();
        txtPhone = new System.Windows.Forms.TextBox();
        label5 = new System.Windows.Forms.Label();
        rtbTradeInNote = new System.Windows.Forms.RichTextBox();
        label6 = new System.Windows.Forms.Label();
        txtRefundAmount = new System.Windows.Forms.TextBox();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvInvoiceDetails).BeginInit();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(txtPhone);
        groupBox1.Controls.Add(label4);
        groupBox1.Controls.Add(txtCustomerName);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(label1);
        groupBox1.Controls.Add(txtInvoiceCode);
        groupBox1.Controls.Add(btnSearch);
        groupBox1.Location = new System.Drawing.Point(12, 2);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(604, 142);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Đổi trả sản phẩm";
        // 
        // btnCancel
        // 
        btnCancel.Location = new System.Drawing.Point(10, 615);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new System.Drawing.Size(340, 42);
        btnCancel.TabIndex = 2;
        btnCancel.Text = "Hủy";
        btnCancel.UseVisualStyleBackColor = true;
        // 
        // btnConfirm
        // 
        btnConfirm.Location = new System.Drawing.Point(10, 571);
        btnConfirm.Name = "btnConfirm";
        btnConfirm.RightToLeft = System.Windows.Forms.RightToLeft.No;
        btnConfirm.Size = new System.Drawing.Size(340, 38);
        btnConfirm.TabIndex = 1;
        btnConfirm.Text = "Xác nhận";
        btnConfirm.UseVisualStyleBackColor = true;
        // 
        // btnCreateTradeIn
        // 
        btnCreateTradeIn.Location = new System.Drawing.Point(10, 523);
        btnCreateTradeIn.Name = "btnCreateTradeIn";
        btnCreateTradeIn.Size = new System.Drawing.Size(340, 42);
        btnCreateTradeIn.TabIndex = 0;
        btnCreateTradeIn.Text = "+ Tạo phiếu đổi trả";
        btnCreateTradeIn.UseVisualStyleBackColor = true;
        // 
        // dgvInvoiceDetails
        // 
        dgvInvoiceDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvInvoiceDetails.Location = new System.Drawing.Point(12, 151);
        dgvInvoiceDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        dgvInvoiceDetails.Name = "dgvInvoiceDetails";
        dgvInvoiceDetails.RowHeadersWidth = 51;
        dgvInvoiceDetails.Size = new System.Drawing.Size(604, 514);
        dgvInvoiceDetails.TabIndex = 1;
        dgvInvoiceDetails.Text = "dataGridView1";
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(txtRefundAmount);
        groupBox2.Controls.Add(label6);
        groupBox2.Controls.Add(rtbTradeInNote);
        groupBox2.Controls.Add(label5);
        groupBox2.Controls.Add(btnCancel);
        groupBox2.Controls.Add(cboReason);
        groupBox2.Controls.Add(btnConfirm);
        groupBox2.Controls.Add(label2);
        groupBox2.Controls.Add(btnCreateTradeIn);
        groupBox2.Location = new System.Drawing.Point(622, 2);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new System.Drawing.Size(358, 663);
        groupBox2.TabIndex = 2;
        groupBox2.TabStop = false;
        // 
        // cboReason
        // 
        cboReason.FormattingEnabled = true;
        cboReason.Location = new System.Drawing.Point(6, 57);
        cboReason.Name = "cboReason";
        cboReason.Size = new System.Drawing.Size(344, 28);
        cboReason.TabIndex = 4;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(6, 29);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(139, 25);
        label2.TabIndex = 3;
        label2.Text = "Lý do trả hàng:";
        label2.Click += label2_Click;
        // 
        // btnSearch
        // 
        btnSearch.Location = new System.Drawing.Point(409, 29);
        btnSearch.Name = "btnSearch";
        btnSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
        btnSearch.Size = new System.Drawing.Size(131, 34);
        btnSearch.TabIndex = 2;
        btnSearch.Text = "Tìm";
        btnSearch.UseVisualStyleBackColor = true;
        // 
        // txtInvoiceCode
        // 
        txtInvoiceCode.Location = new System.Drawing.Point(105, 36);
        txtInvoiceCode.Name = "txtInvoiceCode";
        txtInvoiceCode.Size = new System.Drawing.Size(280, 27);
        txtInvoiceCode.TabIndex = 1;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(6, 39);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(100, 22);
        label1.TabIndex = 0;
        label1.Text = "Mã HĐ gốc: ";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(6, 73);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(100, 22);
        label3.TabIndex = 3;
        label3.Text = "Khách hàng: ";
        // 
        // txtCustomerName
        // 
        txtCustomerName.Location = new System.Drawing.Point(6, 103);
        txtCustomerName.Name = "txtCustomerName";
        txtCustomerName.ReadOnly = true;
        txtCustomerName.Size = new System.Drawing.Size(266, 27);
        txtCustomerName.TabIndex = 4;
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(332, 76);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(100, 22);
        label4.TabIndex = 5;
        label4.Text = "Số điện thoại: ";
        // 
        // txtPhone
        // 
        txtPhone.Location = new System.Drawing.Point(332, 101);
        txtPhone.Name = "txtPhone";
        txtPhone.ReadOnly = true;
        txtPhone.Size = new System.Drawing.Size(251, 27);
        txtPhone.TabIndex = 6;
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(6, 106);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(139, 25);
        label5.TabIndex = 5;
        label5.Text = "Ghi chú tình trạng: ";
        // 
        // rtbTradeInNote
        // 
        rtbTradeInNote.Location = new System.Drawing.Point(6, 134);
        rtbTradeInNote.Name = "rtbTradeInNote";
        rtbTradeInNote.Size = new System.Drawing.Size(344, 280);
        rtbTradeInNote.TabIndex = 6;
        rtbTradeInNote.Text = "";
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(6, 428);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(219, 25);
        label6.TabIndex = 7;
        label6.Text = "Định giá / Số tiền hoàn (VNĐ):";
        // 
        // txtRefundAmount
        // 
        txtRefundAmount.Location = new System.Drawing.Point(6, 456);
        txtRefundAmount.Name = "txtRefundAmount";
        txtRefundAmount.Size = new System.Drawing.Size(344, 27);
        txtRefundAmount.TabIndex = 8;
        txtRefundAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // FormTradeIn
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(984, 673);
        Controls.Add(groupBox2);
        Controls.Add(dgvInvoiceDetails);
        Controls.Add(groupBox1);
        Text = "Đổi trả sản phẩm";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvInvoiceDetails).EndInit();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.TextBox txtRefundAmount;

    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.RichTextBox rtbTradeInNote;

    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtPhone;

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtCustomerName;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox cboReason;

    private System.Windows.Forms.Button btnSearch;

    private System.Windows.Forms.TextBox txtInvoiceCode;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button btnCreateTradeIn;
    private System.Windows.Forms.Button btnConfirm;
    private System.Windows.Forms.Button btnCancel;

    private System.Windows.Forms.GroupBox groupBox2;

    private System.Windows.Forms.DataGridView dgvInvoiceDetails;

    private System.Windows.Forms.GroupBox groupBox1;

    #endregion
}