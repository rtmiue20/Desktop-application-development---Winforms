using BUS;
using Desktop_Application_Development;

namespace GUI;

public partial class FormDashboard : Form
{
    public FormDashboard()
    {
        InitializeComponent();
        this.Load += FormDashboard_Load;
    }

    private void FormDashboard_Load(object sender, EventArgs e)
    {
        // Hiển thị tên + vai trò user lên statusbar
        lbl_userInfo.Text = $"👤 {CurrentUser.FullName}  |  {GetRoleName(CurrentUser.RoleID)}";
        lbl_shift.Text = $"⏱ Ca: CA{DateTime.Now:yyyyMMdd}-08  |  Mở lúc {DateTime.Now:HH:mm}";
        lbl_dbStatus.Text = "✅ Đã kết nối CSDL";
        lbl_revenue.Text = "Doanh thu hôm nay: 0 đ";
    }

    private string GetRoleName(int roleID) => roleID switch
    {
        1 => "Quản lý",
        2 => "Thu ngân",
        3 => "Kho",
        4 => "Kỹ thuật",
        _ => "Nhân viên"
    };

    // ── Method dùng chung mở form con ────────────────────────────────────────
    private void OpenForm(Form form)
    {
        // Nếu form đã mở thì focus vào, không mở lại
        foreach (Form child in this.MdiChildren)
        {
            if (child.GetType() == form.GetType())
            {
                child.Activate();
                form.Dispose();
                return;
            }
        }
        form.MdiParent = this;
        form.Show();
    }

    // ── Toolbar buttons ───────────────────────────────────────────────────────
    private void tsBtn_sell_Click(object sender, EventArgs e) => OpenForm(new FormSell());
    private void tsBtn_guest_Click(object sender, EventArgs e) => OpenForm(new FormGuest());
    private void tsBtn_product_Click(object sender, EventArgs e) => OpenForm(new FormManageProduct());
    private void tsBtn_warehouse_Click(object sender, EventArgs e) => OpenForm(new FormIntoWarehouse());
    private void tsBtn_guarantee_Click(object sender, EventArgs e) => OpenForm(new FormGuarantee());
    private void tsBtn_report_Click(object sender, EventArgs e) => OpenForm(new FormReport());
    private void tsBtn_logout_Click(object sender, EventArgs e) => Menu_formLogout_Click(sender, e);

    // ── Menu items ────────────────────────────────────────────────────────────
    // 1. Bán hàng
    private void Menu_formSell_Click(object sender, EventArgs e) => OpenForm(new FormSell());
    private void Menu_formGuest_Click(object sender, EventArgs e) => OpenForm(new FormGuest());
    private void Menu_formPromotion_Click(object sender, EventArgs e) => OpenForm(new FormPromotion());

    // 2. Kho hàng
    private void Menu_formIntoWarehouse_Click(object sender, EventArgs e) => OpenForm(new FormIntoWarehouse());
    private void Menu_formInventory_Click(object sender, EventArgs e) => OpenForm(new FormInventory());
    private void Menu_formSupplier_Click(object sender, EventArgs e) => OpenForm(new FormSupplier());

    // 3. Bảo hành
    private void Menu_formWarranty_Click(object sender, EventArgs e) => OpenForm(new FormGuarantee());
    private void Menu_formTradeIn_Click(object sender, EventArgs e) => OpenForm(new FormTradeIn());

    // 4. Báo cáo
    private void Menu_formReport_Click(object sender, EventArgs e) => OpenForm(new FormReport());
    private void Menu_formManageShift_Click(object sender, EventArgs e) => OpenForm(new FormManageShift());

    // 5. Hệ thống
    private void Menu_formStaff_Click(object sender, EventArgs e) => OpenForm(new FormStaff());
    private void Menu_formProduct_Click(object sender, EventArgs e) => OpenForm(new FormManageProduct());
    private void Menu_formCategory_Click(object sender, EventArgs e) => OpenForm(new FormCategory());
    private void Menu_formSetting_Click(object sender, EventArgs e) => OpenForm(new FormSetting());
    private void Menu_formLogout_Click(object sender, EventArgs e)
    {
        var confirm = MessageBox.Show("Bạn có chắc muốn đăng xuất?",
            "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (confirm == DialogResult.Yes)
        {
            CurrentUser.Clear();
            new FormLogin().Show();
            this.Close();
        }
    }


    private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
    }

    /// <summary>
    /// Bật/tắt menu item dựa trên tên của nó
    /// </summary>
    public void SetMenuEnabled(string menuName, bool enabled)
    {
        var menu = menuStrip.Items.OfType<ToolStripMenuItem>()
            .FirstOrDefault(m => m.Name == menuName);

        if (menu != null)
        {
            menu.Enabled = enabled;
            menu.Visible = enabled;
        }
    }

    /// <summary>
    /// Bật/tắt menu item con dựa trên tên parent và child
    /// </summary>
    public void SetMenuItemEnabled(string parentMenuName, string childItemName, bool enabled)
    {
        var parentMenu = menuStrip.Items.OfType<ToolStripMenuItem>()
            .FirstOrDefault(m => m.Name == parentMenuName);

        if (parentMenu != null)
        {
            var childItem = parentMenu.DropDownItems.OfType<ToolStripMenuItem>()
                .FirstOrDefault(m => m.Name == childItemName);

            if (childItem != null)
            {
                childItem.Enabled = enabled;
                childItem.Visible = enabled;
            }
        }
    }

    /// <summary>
    /// Bật/tắt toolbar button dựa trên tên của nó
    /// </summary>
    public void SetToolbarButtonEnabled(string buttonName, bool enabled)
    {
        var button = toolStrip1.Items.OfType<ToolStripButton>()
            .FirstOrDefault(b => b.Name == buttonName);

        if (button != null)
        {
            button.Enabled = enabled;
            button.Visible = enabled;
        }
    }
}