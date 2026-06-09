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
        txt_phone = new System.Windows.Forms.TextBox();
        label4 = new System.Windows.Forms.Label();
        txt_customerName = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        txt_invoiceCode = new System.Windows.Forms.TextBox();
        btn_searchTradeIn = new System.Windows.Forms.Button();
        btn_cancelTradeIn = new System.Windows.Forms.Button();
        btn_confirmTradeIn = new System.Windows.Forms.Button();
        btn_createTradeIn = new System.Windows.Forms.Button();
        dgv_invoiceDetails = new System.Windows.Forms.DataGridView();
        groupBox2 = new System.Windows.Forms.GroupBox();
        txt_refundAmount = new System.Windows.Forms.TextBox();
        label6 = new System.Windows.Forms.Label();
        rtb_tradeInNote = new System.Windows.Forms.RichTextBox();
        label5 = new System.Windows.Forms.Label();
        txb_reason = new System.Windows.Forms.ComboBox();
        label2 = new System.Windows.Forms.Label();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgv_invoiceDetails).BeginInit();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(txt_phone);
        groupBox1.Controls.Add(label4);
        groupBox1.Controls.Add(txt_customerName);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(label1);
        groupBox1.Controls.Add(txt_invoiceCode);
        groupBox1.Controls.Add(btn_searchTradeIn);
        groupBox1.Location = new System.Drawing.Point(12, 2);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(744, 219);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Đổi trả sản phẩm";
        // 
        // txt_phone
        // 
        txt_phone.Location = new System.Drawing.Point(349, 157);
        txt_phone.Name = "txt_phone";
        txt_phone.ReadOnly = true;
        txt_phone.Size = new System.Drawing.Size(389, 27);
        txt_phone.TabIndex = 6;
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(349, 106);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(248, 48);
        label4.TabIndex = 5;
        label4.Text = "Số điện thoại: ";
        // 
        // txt_customerName
        // 
        txt_customerName.Location = new System.Drawing.Point(6, 157);
        txt_customerName.Name = "txt_customerName";
        txt_customerName.ReadOnly = true;
        txt_customerName.Size = new System.Drawing.Size(337, 27);
        txt_customerName.TabIndex = 4;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(6, 106);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(266, 48);
        label3.TabIndex = 3;
        label3.Text = "Khách hàng: ";
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(6, 43);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(193, 47);
        label1.TabIndex = 0;
        label1.Text = "Mã HĐ gốc: ";
        // 
        // txt_invoiceCode
        // 
        txt_invoiceCode.Location = new System.Drawing.Point(205, 43);
        txt_invoiceCode.Name = "txt_invoiceCode";
        txt_invoiceCode.Size = new System.Drawing.Size(353, 27);
        txt_invoiceCode.TabIndex = 1;
        // 
        // btn_searchTradeIn
        // 
        btn_searchTradeIn.Location = new System.Drawing.Point(564, 43);
        btn_searchTradeIn.Name = "btn_searchTradeIn";
        btn_searchTradeIn.RightToLeft = System.Windows.Forms.RightToLeft.No;
        btn_searchTradeIn.Size = new System.Drawing.Size(174, 47);
        btn_searchTradeIn.TabIndex = 2;
        btn_searchTradeIn.Text = "Tìm";
        btn_searchTradeIn.UseVisualStyleBackColor = true;
        // 
        // btn_cancelTradeIn
        // 
        btn_cancelTradeIn.Location = new System.Drawing.Point(6, 786);
        btn_cancelTradeIn.Name = "btn_cancelTradeIn";
        btn_cancelTradeIn.Size = new System.Drawing.Size(805, 59);
        btn_cancelTradeIn.TabIndex = 2;
        btn_cancelTradeIn.Text = "Hủy";
        btn_cancelTradeIn.UseVisualStyleBackColor = true;
        // 
        // btn_confirmTradeIn
        // 
        btn_confirmTradeIn.Location = new System.Drawing.Point(6, 708);
        btn_confirmTradeIn.Name = "btn_confirmTradeIn";
        btn_confirmTradeIn.RightToLeft = System.Windows.Forms.RightToLeft.No;
        btn_confirmTradeIn.Size = new System.Drawing.Size(805, 59);
        btn_confirmTradeIn.TabIndex = 1;
        btn_confirmTradeIn.Text = "Xác nhận";
        btn_confirmTradeIn.UseVisualStyleBackColor = true;
        // 
        // btn_createTradeIn
        // 
        btn_createTradeIn.Location = new System.Drawing.Point(6, 627);
        btn_createTradeIn.Name = "btn_createTradeIn";
        btn_createTradeIn.Size = new System.Drawing.Size(805, 59);
        btn_createTradeIn.TabIndex = 0;
        btn_createTradeIn.Text = "Tạo phiếu đổi trả";
        btn_createTradeIn.UseVisualStyleBackColor = true;
        // 
        // dgv_invoiceDetails
        // 
        dgv_invoiceDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgv_invoiceDetails.Location = new System.Drawing.Point(12, 228);
        dgv_invoiceDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        dgv_invoiceDetails.Name = "dgv_invoiceDetails";
        dgv_invoiceDetails.RowHeadersWidth = 51;
        dgv_invoiceDetails.Size = new System.Drawing.Size(744, 770);
        dgv_invoiceDetails.TabIndex = 1;
        dgv_invoiceDetails.Text = "dataGridView1";
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(txt_refundAmount);
        groupBox2.Controls.Add(label6);
        groupBox2.Controls.Add(rtb_tradeInNote);
        groupBox2.Controls.Add(label5);
        groupBox2.Controls.Add(btn_cancelTradeIn);
        groupBox2.Controls.Add(txb_reason);
        groupBox2.Controls.Add(btn_confirmTradeIn);
        groupBox2.Controls.Add(label2);
        groupBox2.Controls.Add(btn_createTradeIn);
        groupBox2.Location = new System.Drawing.Point(762, 12);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new System.Drawing.Size(817, 986);
        groupBox2.TabIndex = 2;
        groupBox2.TabStop = false;
        // 
        // txt_refundAmount
        // 
        txt_refundAmount.Location = new System.Drawing.Point(6, 530);
        txt_refundAmount.Name = "txt_refundAmount";
        txt_refundAmount.Size = new System.Drawing.Size(805, 27);
        txt_refundAmount.TabIndex = 8;
        txt_refundAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(6, 480);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(264, 47);
        label6.TabIndex = 7;
        label6.Text = "Định giá / Số tiền hoàn (VNĐ):";
        // 
        // rtb_tradeInNote
        // 
        rtb_tradeInNote.Location = new System.Drawing.Point(6, 184);
        rtb_tradeInNote.Name = "rtb_tradeInNote";
        rtb_tradeInNote.Size = new System.Drawing.Size(805, 280);
        rtb_tradeInNote.TabIndex = 6;
        rtb_tradeInNote.Text = "";
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(6, 134);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(281, 47);
        label5.TabIndex = 5;
        label5.Text = "Ghi chú tình trạng: ";
        // 
        // txb_reason
        // 
        txb_reason.FormattingEnabled = true;
        txb_reason.Location = new System.Drawing.Point(6, 82);
        txb_reason.Name = "txb_reason";
        txb_reason.Size = new System.Drawing.Size(805, 28);
        txb_reason.TabIndex = 4;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(6, 32);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(222, 47);
        label2.TabIndex = 3;
        label2.Text = "Lý do trả hàng:";
        label2.Click += label2_Click;
        // 
        // FormTradeIn
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1536, 976);
        Controls.Add(groupBox2);
        Controls.Add(dgv_invoiceDetails);
        Controls.Add(groupBox1);
        Margin = new System.Windows.Forms.Padding(6);
        Text = "Đổi trả sản phẩm";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgv_invoiceDetails).EndInit();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.TextBox txt_refundAmount;

    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.RichTextBox rtb_tradeInNote;

    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txt_phone;

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txt_customerName;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox txb_reason;

    private System.Windows.Forms.Button btn_searchTradeIn;

    private System.Windows.Forms.TextBox txt_invoiceCode;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button btn_createTradeIn;
    private System.Windows.Forms.Button btn_confirmTradeIn;
    private System.Windows.Forms.Button btn_cancelTradeIn;

    private System.Windows.Forms.GroupBox groupBox2;

    private System.Windows.Forms.DataGridView dgv_invoiceDetails;

    private System.Windows.Forms.GroupBox groupBox1;

    #endregion
}