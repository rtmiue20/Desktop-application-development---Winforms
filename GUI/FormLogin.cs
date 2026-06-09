using System;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class FormLogin : Form
    {
        private readonly UsersBUS _bus = new();

        public FormLogin()
        {
            InitializeComponent();
        }

        // Khi gõ Username xong bấm Enter -> Tự nhảy xuống ô Password
        private void txt_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txt_password.Focus();
        }

        // Khi gõ Password xong bấm Enter -> Tự kích hoạt đăng nhập luôn không cần click chuột
        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                DoLogin();
        }

        // Sự kiện Click nút đăng nhập
        private void btn_login_Click(object sender, EventArgs e) => DoLogin();

        private void DoLogin()
        {
            lbl_error.Visible = false;

            var username = txt_username.Text.Trim();
            var password = txt_password.Text;

            // Gọi xuống tầng BUS để kiểm tra
            var (success, error) = _bus.Login(username, password);

            if (!success)
            {
                lbl_error.Text = error;
                lbl_error.Visible = true; // Hiện lỗi đỏ lên màn hình
                txt_password.Clear();
                txt_password.Focus();
                return;
            }

            // Đăng nhập thành công -> Mở giao diện chính (Dashboard)
            var dashboard = new FormDashboard();
            dashboard.Show();
            this.Hide();

            // Khi tắt Form chính thì tắt luôn toàn bộ tiến trình chạy ngầm của ứng dụng
            dashboard.FormClosed += (s, args) => Application.Exit();
        }
    }
}