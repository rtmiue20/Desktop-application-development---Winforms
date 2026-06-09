namespace GUI;

partial class FormLogin
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
        this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
        this.panel_left = new Guna.UI2.WinForms.Guna2Panel();
        this.lbl_sub_title = new System.Windows.Forms.Label();
        this.lbl_brand = new System.Windows.Forms.Label();
        this.btn_close = new Guna.UI2.WinForms.Guna2ControlBox();
        this.lbl_login_title = new System.Windows.Forms.Label();
        this.txt_username = new Guna.UI2.WinForms.Guna2TextBox();
        this.txt_password = new Guna.UI2.WinForms.Guna2TextBox();
        this.btn_login = new Guna.UI2.WinForms.Guna2Button();
        this.lbl_error = new System.Windows.Forms.Label();
        this.panel_left.SuspendLayout();
        this.SuspendLayout();
        // 
        // guna2Elipse1
        // 
        this.guna2Elipse1.BorderRadius = 18;
        this.guna2Elipse1.TargetControl = this;
        // 
        // guna2DragControl1
        // 
        this.guna2DragControl1.DockForm = true;
        this.guna2DragControl1.TargetControl = this;
        this.guna2DragControl1.TransparentWhileDrag = true;
        this.guna2DragControl1.UseTransparentDrag = true;
        // 
        // panel_left
        // 
        this.panel_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
        this.panel_left.Controls.Add(this.lbl_sub_title);
        this.panel_left.Controls.Add(this.lbl_brand);
        this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
        this.panel_left.Location = new System.Drawing.Point(0, 0);
        this.panel_left.Name = "panel_left";
        this.panel_left.Size = new System.Drawing.Size(350, 500);
        this.panel_left.TabIndex = 0;
        // 
        // lbl_sub_title
        // 
        this.lbl_sub_title.AutoSize = true;
        this.lbl_sub_title.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lbl_sub_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
        this.lbl_sub_title.Location = new System.Drawing.Point(35, 255);
        this.lbl_sub_title.Name = "lbl_sub_title";
        this.lbl_sub_title.Size = new System.Drawing.Size(262, 25);
        this.lbl_sub_title.TabIndex = 1;
        this.lbl_sub_title.Text = "Hệ thống Quản lý Cửa hàng";
        // 
        // lbl_brand
        // 
        this.lbl_brand.AutoSize = true;
        this.lbl_brand.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lbl_brand.ForeColor = System.Drawing.Color.White;
        this.lbl_brand.Location = new System.Drawing.Point(30, 190);
        this.lbl_brand.Name = "lbl_brand";
        this.lbl_brand.Size = new System.Drawing.Size(279, 60);
        this.lbl_brand.TabIndex = 0;
        this.lbl_brand.Text = "TECH STORE";
        // 
        // btn_close
        // 
        this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btn_close.FillColor = System.Drawing.Color.Transparent;
        this.btn_close.IconColor = System.Drawing.Color.Gray;
        this.btn_close.Location = new System.Drawing.Point(755, 12);
        this.btn_close.Name = "btn_close";
        this.btn_close.Size = new System.Drawing.Size(33, 29);
        this.btn_close.TabIndex = 5;
        // 
        // lbl_login_title
        // 
        this.lbl_login_title.AutoSize = true;
        this.lbl_login_title.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lbl_login_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
        this.lbl_login_title.Location = new System.Drawing.Point(400, 90);
        this.lbl_login_title.Name = "lbl_login_title";
        this.lbl_login_title.Size = new System.Drawing.Size(225, 46);
        this.lbl_login_title.TabIndex = 1;
        this.lbl_login_title.Text = "Đăng Nhập";
        // 
        // txt_username
        // 
        this.txt_username.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(233)))));
        this.txt_username.BorderRadius = 8;
        this.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam;
        this.txt_username.DefaultText = "";
        this.txt_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
        this.txt_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
        this.txt_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
        this.txt_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
        this.txt_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
        this.txt_username.Font = new System.Drawing.Font("Segoe UI", 10.51F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txt_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
        this.txt_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
        this.txt_username.Location = new System.Drawing.Point(405, 175);
        this.txt_username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        this.txt_username.Name = "txt_username";
        this.txt_username.PasswordChar = '\0';
        this.txt_username.PlaceholderForeColor = System.Drawing.Color.DarkGray;
        this.txt_username.PlaceholderText = "Tên đăng nhập";
        this.txt_username.SelectedText = "";
        this.txt_username.Size = new System.Drawing.Size(340, 48);
        this.txt_username.TabIndex = 2;
        this.txt_username.TextOffset = new System.Drawing.Point(8, 0);
        this.txt_username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_username_KeyDown);
        // 
        // txt_password
        // 
        this.txt_password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(233)))));
        this.txt_password.BorderRadius = 8;
        this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
        this.txt_password.DefaultText = "";
        this.txt_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
        this.txt_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
        this.txt_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
        this.txt_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
        this.txt_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
        this.txt_password.Font = new System.Drawing.Font("Segoe UI", 10.51F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txt_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
        this.txt_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
        this.txt_password.Location = new System.Drawing.Point(405, 245);
        this.txt_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        this.txt_password.Name = "txt_password";
        this.txt_password.PasswordChar = '●';
        this.txt_password.PlaceholderForeColor = System.Drawing.Color.DarkGray;
        this.txt_password.PlaceholderText = "Mật khẩu";
        this.txt_password.SelectedText = "";
        this.txt_password.Size = new System.Drawing.Size(340, 48);
        this.txt_password.TabIndex = 3;
        this.txt_password.TextOffset = new System.Drawing.Point(8, 0);
        this.txt_password.UseSystemPasswordChar = true;
        this.txt_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_password_KeyDown);
        // 
        // btn_login
        // 
        this.btn_login.Animated = true;
        this.btn_login.BorderRadius = 8;
        this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btn_login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
        this.btn_login.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btn_login.ForeColor = System.Drawing.Color.White;
        this.btn_login.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
        this.btn_login.Location = new System.Drawing.Point(405, 345);
        this.btn_login.Name = "btn_login";
        this.btn_login.Size = new System.Drawing.Size(340, 48);
        this.btn_login.TabIndex = 4;
        this.btn_login.Text = "ĐĂNG NHẬP";
        this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
        // 
        // lbl_error
        // 
        this.lbl_error.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lbl_error.ForeColor = System.Drawing.Color.Crimson;
        this.lbl_error.Location = new System.Drawing.Point(405, 303);
        this.lbl_error.Name = "lbl_error";
        this.lbl_error.Size = new System.Drawing.Size(340, 30);
        this.lbl_error.TabIndex = 6;
        this.lbl_error.Text = "Lỗi hiển thị ở đây";
        this.lbl_error.Visible = false;
        // 
        // FormLogin
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.White;
        this.ClientSize = new System.Drawing.Size(800, 500);
        this.Controls.Add(this.lbl_error);
        this.Controls.Add(this.btn_login);
        this.Controls.Add(this.txt_password);
        this.Controls.Add(this.txt_username);
        this.Controls.Add(this.lbl_login_title);
        this.Controls.Add(this.btn_close);
        this.Controls.Add(this.panel_left);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        this.Name = "FormLogin";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Đăng nhập";
        this.panel_left.ResumeLayout(false);
        this.panel_left.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    private Guna.UI2.WinForms.Guna2Panel panel_left;
    private System.Windows.Forms.Label lbl_sub_title;
    private System.Windows.Forms.Label lbl_brand;
    private Guna.UI2.WinForms.Guna2ControlBox btn_close;
    private System.Windows.Forms.Label lbl_login_title;
    private Guna.UI2.WinForms.Guna2TextBox txt_username;
    private Guna.UI2.WinForms.Guna2TextBox txt_password;
    private Guna.UI2.WinForms.Guna2Button btn_login;
    private System.Windows.Forms.Label lbl_error;
}