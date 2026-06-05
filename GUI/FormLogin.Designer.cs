namespace GUI;

partial class FormLogin
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        label1 = new System.Windows.Forms.Label();
        groupBox1 = new System.Windows.Forms.GroupBox();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        txt_username = new System.Windows.Forms.TextBox();
        txt_password = new System.Windows.Forms.TextBox();
        btn_login = new System.Windows.Forms.Button();
        lbl_error = new System.Windows.Forms.Label();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(266, 86);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(306, 47);
        label1.TabIndex = 0;
        label1.Text = "Đăng nhập hệ thống";
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(lbl_error);
        groupBox1.Controls.Add(btn_login);
        groupBox1.Controls.Add(txt_password);
        groupBox1.Controls.Add(txt_username);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(label1);
        groupBox1.Location = new System.Drawing.Point(350, 111);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(858, 837);
        groupBox1.TabIndex = 1;
        groupBox1.TabStop = false;
        // 
        // label2
        // 
        label2.BackColor = System.Drawing.SystemColors.ControlDark;
        label2.Location = new System.Drawing.Point(6, 432);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(234, 47);
        label2.TabIndex = 1;
        label2.Text = "Mật khẩu";
        // 
        // label3
        // 
        label3.BackColor = System.Drawing.SystemColors.ControlDark;
        label3.Location = new System.Drawing.Point(6, 341);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(234, 47);
        label3.TabIndex = 2;
        label3.Text = "Tên đăng nhập";
        // 
        // txt_username
        // 
        txt_username.Location = new System.Drawing.Point(246, 341);
        txt_username.Name = "txt_username";
        txt_username.Size = new System.Drawing.Size(606, 47);
        txt_username.TabIndex = 3;
        // 
        // txt_password
        // 
        txt_password.Location = new System.Drawing.Point(246, 432);
        txt_password.Name = "txt_password";
        txt_password.Size = new System.Drawing.Size(606, 47);
        txt_password.TabIndex = 4;
        txt_password.UseSystemPasswordChar = true;
        // 
        // btn_login
        // 
        btn_login.Location = new System.Drawing.Point(6, 552);
        btn_login.Name = "btn_login";
        btn_login.Size = new System.Drawing.Size(846, 125);
        btn_login.TabIndex = 5;
        btn_login.Text = "Đăng nhập";
        btn_login.UseVisualStyleBackColor = true;
        // 
        // lbl_error
        // 
        lbl_error.BackColor = System.Drawing.SystemColors.ControlDark;
        lbl_error.Location = new System.Drawing.Point(6, 193);
        lbl_error.Name = "lbl_error";
        lbl_error.Size = new System.Drawing.Size(846, 94);
        lbl_error.TabIndex = 6;
        // 
        // FormLogin
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1564, 1120);
        Controls.Add(groupBox1);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        MinimizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Đăng nhập";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button btn_login;
    private System.Windows.Forms.Label lbl_error;

    private System.Windows.Forms.TextBox txt_username;
    private System.Windows.Forms.TextBox txt_password;

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label1;

    #endregion
}