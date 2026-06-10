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
        groupBox1 = new GroupBox();
        label1 = new Label();
        txt_invoiceCode = new TextBox();
        btn_searchTradeIn = new Button();
        btn_cancelTradeIn = new Button();
        btn_confirmTradeIn = new Button();
        btn_createTradeIn = new Button();
        dgv_invoiceDetails = new DataGridView();
        groupBox2 = new GroupBox();
        txt_resolution = new TextBox();
        label6 = new Label();
        rtb_tradeInNote = new RichTextBox();
        label5 = new Label();
        txb_reason = new ComboBox();
        label2 = new Label();
        groupBox3 = new GroupBox();
        btn_confirm = new Button();
        groupBox1.SuspendLayout();
        ((ISupportInitialize)dgv_invoiceDetails).BeginInit();
        groupBox2.SuspendLayout();
        groupBox3.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(label1);
        groupBox1.Controls.Add(txt_invoiceCode);
        groupBox1.Controls.Add(btn_searchTradeIn);
        groupBox1.Location = new Point(0, 4);
        groupBox1.Margin = new Padding(6);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(6);
        groupBox1.Size = new Size(970, 120);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Đổi trả sản phẩm";
        // 
        // label1
        // 
        label1.Location = new Point(12, 46);
        label1.Margin = new Padding(6, 0, 6, 0);
        label1.Name = "label1";
        label1.Size = new Size(205, 47);
        label1.TabIndex = 0;
        label1.Text = "Mã HĐ gốc: ";
        // 
        // txt_invoiceCode
        // 
        txt_invoiceCode.Location = new Point(229, 46);
        txt_invoiceCode.Margin = new Padding(6);
        txt_invoiceCode.Name = "txt_invoiceCode";
        txt_invoiceCode.Size = new Size(475, 47);
        txt_invoiceCode.TabIndex = 1;
        // 
        // btn_searchTradeIn
        // 
        btn_searchTradeIn.Location = new Point(716, 46);
        btn_searchTradeIn.Margin = new Padding(6);
        btn_searchTradeIn.Name = "btn_searchTradeIn";
        btn_searchTradeIn.RightToLeft = RightToLeft.No;
        btn_searchTradeIn.Size = new Size(236, 47);
        btn_searchTradeIn.TabIndex = 2;
        btn_searchTradeIn.Text = "Tìm";
        btn_searchTradeIn.UseVisualStyleBackColor = true;
        btn_searchTradeIn.Click += btn_searchTradeIn_Click;
        // 
        // btn_cancelTradeIn
        // 
        btn_cancelTradeIn.Location = new Point(13, 1611);
        btn_cancelTradeIn.Margin = new Padding(6);
        btn_cancelTradeIn.Name = "btn_cancelTradeIn";
        btn_cancelTradeIn.Size = new Size(1711, 121);
        btn_cancelTradeIn.TabIndex = 2;
        btn_cancelTradeIn.Text = "Hủy";
        btn_cancelTradeIn.UseVisualStyleBackColor = true;
        btn_cancelTradeIn.Click += btn_cancelTradeIn_Click;
        // 
        // btn_confirmTradeIn
        // 
        btn_confirmTradeIn.Location = new Point(13, 1451);
        btn_confirmTradeIn.Margin = new Padding(6);
        btn_confirmTradeIn.Name = "btn_confirmTradeIn";
        btn_confirmTradeIn.RightToLeft = RightToLeft.No;
        btn_confirmTradeIn.Size = new Size(1711, 121);
        btn_confirmTradeIn.TabIndex = 1;
        btn_confirmTradeIn.Text = "Xác nhận";
        btn_confirmTradeIn.UseVisualStyleBackColor = true;
        btn_confirmTradeIn.Click += btn_confirmTradeIn_Click;
        // 
        // btn_createTradeIn
        // 
        btn_createTradeIn.Location = new Point(13, 1285);
        btn_createTradeIn.Margin = new Padding(6);
        btn_createTradeIn.Name = "btn_createTradeIn";
        btn_createTradeIn.Size = new Size(1711, 121);
        btn_createTradeIn.TabIndex = 0;
        btn_createTradeIn.Text = "Tạo phiếu đổi trả";
        btn_createTradeIn.UseVisualStyleBackColor = true;
        btn_createTradeIn.Click += btn_createTradeIn_Click;
        // 
        // dgv_invoiceDetails
        // 
        dgv_invoiceDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgv_invoiceDetails.Location = new Point(0, 6);
        dgv_invoiceDetails.Margin = new Padding(6, 8, 6, 8);
        dgv_invoiceDetails.Name = "dgv_invoiceDetails";
        dgv_invoiceDetails.RowHeadersWidth = 51;
        dgv_invoiceDetails.Size = new Size(960, 866);
        dgv_invoiceDetails.TabIndex = 1;
        dgv_invoiceDetails.Text = "dataGridView1";
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(btn_confirm);
        groupBox2.Controls.Add(txt_resolution);
        groupBox2.Controls.Add(label6);
        groupBox2.Controls.Add(rtb_tradeInNote);
        groupBox2.Controls.Add(label5);
        groupBox2.Controls.Add(btn_cancelTradeIn);
        groupBox2.Controls.Add(txb_reason);
        groupBox2.Controls.Add(btn_confirmTradeIn);
        groupBox2.Controls.Add(label2);
        groupBox2.Controls.Add(btn_createTradeIn);
        groupBox2.Location = new Point(978, 4);
        groupBox2.Margin = new Padding(6);
        groupBox2.Name = "groupBox2";
        groupBox2.Padding = new Padding(6);
        groupBox2.Size = new Size(484, 954);
        groupBox2.TabIndex = 2;
        groupBox2.TabStop = false;
        groupBox2.Text = "Trả hàng";
        // 
        // txt_resolution
        // 
        txt_resolution.Location = new Point(13, 566);
        txt_resolution.Margin = new Padding(6);
        txt_resolution.Name = "txt_resolution";
        txt_resolution.Size = new Size(441, 47);
        txt_resolution.TabIndex = 8;
        txt_resolution.TextAlign = HorizontalAlignment.Right;
        // 
        // label6
        // 
        label6.Location = new Point(18, 513);
        label6.Margin = new Padding(6, 0, 6, 0);
        label6.Name = "label6";
        label6.Size = new Size(436, 47);
        label6.TabIndex = 7;
        label6.Text = "Giải quyết:";
        // 
        // rtb_tradeInNote
        // 
        rtb_tradeInNote.Location = new Point(18, 231);
        rtb_tradeInNote.Margin = new Padding(6);
        rtb_tradeInNote.Name = "rtb_tradeInNote";
        rtb_tradeInNote.Size = new Size(436, 257);
        rtb_tradeInNote.TabIndex = 6;
        rtb_tradeInNote.Text = "";
        rtb_tradeInNote.TextChanged += rtb_tradeInNote_TextChanged;
        // 
        // label5
        // 
        label5.Location = new Point(13, 178);
        label5.Margin = new Padding(6, 0, 6, 0);
        label5.Name = "label5";
        label5.Size = new Size(270, 47);
        label5.TabIndex = 5;
        label5.Text = "Ghi chú tình trạng: ";
        // 
        // txb_reason
        // 
        txb_reason.FormattingEnabled = true;
        txb_reason.Location = new Point(13, 99);
        txb_reason.Margin = new Padding(6);
        txb_reason.Name = "txb_reason";
        txb_reason.Size = new Size(441, 49);
        txb_reason.TabIndex = 4;
        // 
        // label2
        // 
        label2.Location = new Point(13, 46);
        label2.Margin = new Padding(6, 0, 6, 0);
        label2.Name = "label2";
        label2.Size = new Size(229, 47);
        label2.TabIndex = 3;
        label2.Text = "Lý do trả hàng:";
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(dgv_invoiceDetails);
        groupBox3.Location = new Point(0, 132);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new Size(969, 872);
        groupBox3.TabIndex = 3;
        groupBox3.TabStop = false;
        // 
        // btn_confirm
        // 
        btn_confirm.Location = new Point(18, 666);
        btn_confirm.Name = "btn_confirm";
        btn_confirm.Size = new Size(436, 58);
        btn_confirm.TabIndex = 9;
        btn_confirm.Text = "Xác nhận";
        btn_confirm.UseVisualStyleBackColor = true;
        // 
        // FormTradeIn
        // 
        AutoScaleDimensions = new SizeF(17F, 41F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1475, 1011);
        Controls.Add(groupBox3);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Margin = new Padding(13, 12, 13, 12);
        Name = "FormTradeIn";
        Text = "Đổi trả sản phẩm";
        Load += FormTradeIn_Load;
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((ISupportInitialize)dgv_invoiceDetails).EndInit();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        groupBox3.ResumeLayout(false);
        ResumeLayout(false);

    }

    private System.Windows.Forms.TextBox txt_resolution;

    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.RichTextBox rtb_tradeInNote;

    private System.Windows.Forms.Label label5;

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

    private GroupBox groupBox3;
    private Button btn_confirm;
}