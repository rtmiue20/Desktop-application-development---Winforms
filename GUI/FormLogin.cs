using System;
using System.Windows.Forms;
using BUS;

namespace GUI;

public partial class FormLogin : Form
{
    private readonly UsersBUS _bus = new();

    public FormLogin()
    {
        InitializeComponent();
    }

    // ── Nhấn Enter ở txt_username → nhảy sang txt_password ────────────────────
    private void txt_username_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
            txt_password.Focus();
    }

    // ── Nhấn Enter ở txt_password → thực hiện đăng nhập ──────────────────────
    private void txt_password_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
            DoLogin();
    }

    private void btnLogin_Click(object sender, EventArgs e) => DoLogin();

    // ── Logic đăng nhập ──────────────────────────────────────────────────────
    private void DoLogin()
    {
        lbl_error.Visible = false;

        var username = txt_username.Text.Trim();
        var password = txt_password.Text;

        var (success, error) = _bus.Login(username, password);

        if (!success)
        {
            lbl_error.Text = error;
            lbl_error.Visible = true;
            txt_password.Clear();
            txt_password.Focus();
            return;
        }

        // Mở FormDashboard, đóng FormLogin
        var dashboard = new FormDashboard();
        dashboard.Show();
        this.Hide();

        // Khi đóng Dashboard → thoát hẳn app
        dashboard.FormClosed += (s, args) => Application.Exit();
    }
}