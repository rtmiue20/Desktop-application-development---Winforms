using BUS;
using Desktop_Application_Development;

namespace GUI;

public partial class FormDashboard : Form
{
    public FormDashboard()
    {
        InitializeComponent();
    }

    // Method dùng chung
    private void OpenForm(Form form)
    {
        form.MdiParent = this;
        form.Show();
    }

    // Gọi hàm
    // 1. Bán hàng
    private void Menu_formSell_Click(object sender, EventArgs e) => OpenForm(new FormSell());
    private void Menu_formGuest_Click(object sender, EventArgs e) => OpenForm(new FormGuest());
    private void Menu_formPromotion_Click(object sender, EventArgs e) => OpenForm(new FormPromotion());
    
    // 2. Kho hàng
    private void Menu_formIntoWarehouse_Click(object sender, EventArgs e) => OpenForm(new FormIntoWarehouse());
    private void Menu_formInventory_Click(object sender, EventArgs e) => OpenForm(new FormInventory());
    private void Menu_formSupplier_Click(object sender, EventArgs e) => OpenForm(new FormSupplier());
    
    // 3. Bảo hành
    private void Menu_formWarranty_Click(object sender, EventArgs e) => OpenForm(new FormWarranty());
    private void Menu_formTradeIn_Click(object sender, EventArgs e) => OpenForm(new FormTradeIn());
    
    // 4. Báo cáo
    private void Menu_formReport_Click(object sender, EventArgs e) => OpenForm(new FormReport());
    private void Menu_formManageShift_Click(object sender, EventArgs e) => OpenForm(new FormManageShift());
    
    // 5. Hệ thống
    private void Menu_formStaff_Click(object sender, EventArgs e) => OpenForm(new FormStaff());
    private void Menu_formProduct_Click(object sender, EventArgs e) => OpenForm(new FormPromotion());
    private void Menu_formCategory_Click(object sender, EventArgs e) => OpenForm(new FormCategory());
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


    

}
    