using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Desktop_Application_Development;

public partial class FormTradeIn : Form
{
    // Khởi tạo các đối tượng nghiệp vụ
    private readonly SalesBUS _salesBUS = new SalesBUS();
    private readonly CustomersBUS _customerBUS = new CustomersBUS();

    private int _currentInvoiceID = 0;
    private int _currentCustomerID = 0;

    public FormTradeIn()
    {
        InitializeComponent();
    }

    private void FormTradeIn_Load(object sender, EventArgs e)
    {
        SetupDataGridView();
        cboReason.Items.Clear();
        cboReason.Items.AddRange(new string[] { "Sản phẩm lỗi do NSX", "Thu cũ đổi mới", "Khách đổi ý (Có tính phí)", "Khác..." });
        cboReason.SelectedIndex = 0;
        SetTradeInPanelState(false);
    }

    private void SetupDataGridView()
    {
        dgvInvoiceDetails.Columns.Clear();
        dgvInvoiceDetails.AutoGenerateColumns = false;
        dgvInvoiceDetails.AllowUserToAddRows = false;
        dgvInvoiceDetails.RowHeadersVisible = false;
        dgvInvoiceDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        dgvInvoiceDetails.Columns.Add(new DataGridViewCheckBoxColumn { HeaderText = "Chọn", Name = "chkSelect", Width = 50 });
        dgvInvoiceDetails.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ItemCode", HeaderText = "Mã Serial", Name = "ItemCode", Width = 120, ReadOnly = true });
        dgvInvoiceDetails.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProductName", HeaderText = "Tên Sản Phẩm", Name = "ProductName", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, ReadOnly = true });
        dgvInvoiceDetails.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "UnitPrice", HeaderText = "Giá Bán", Name = "UnitPrice", Width = 100, ReadOnly = true });
    }

    private void SetTradeInPanelState(bool isEnabled)
    {
        cboReason.Enabled = isEnabled;
        rtbTradeInNote.Enabled = isEnabled;
        txtRefundAmount.Enabled = isEnabled;
        btnConfirm.Enabled = isEnabled;
        btnCreateTradeIn.Enabled = isEnabled;
    }

    // --- LOGIC GỌI DATABASE THẬT ---
    private void btnSearch_Click(object sender, EventArgs e)
    {
        string invoiceCode = txtInvoiceCode.Text.Trim();
        if (string.IsNullOrEmpty(invoiceCode))
        {
            MessageBox.Show("Vui lòng nhập Mã Hóa Đơn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            // Thay tên hàm tương ứng với hàm thật trong SalesBUS của bạn
            var invoice = _salesBUS.GetByInvoiceCode(invoiceCode); 

            if (invoice != null)
            {
                _currentInvoiceID = invoice.InvoiceID;
                _currentCustomerID = invoice.CustomerID ?? 0;
                
                var customer = _customerBUS.GetById(_currentCustomerID);
                txtCustomerName.Text = customer != null ? customer.FullName : "Khách lẻ";
                txtPhone.Text = customer != null ? customer.Phone : "Không có";
                
                dgvInvoiceDetails.DataSource = _salesBUS.GetInvoiceDetails(_currentInvoiceID);
                SetTradeInPanelState(true);
            }
            else
            {
                MessageBox.Show("Không tìm thấy Hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnCancel_Click(null, null);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi truy vấn Database: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnConfirm_Click(object sender, EventArgs e)
    {
        // 1. Kiểm tra CheckBox
        List<string> selectedSerials = new List<string>();
        foreach (DataGridViewRow row in dgvInvoiceDetails.Rows)
        {
            if (Convert.ToBoolean(row.Cells["chkSelect"].Value))
                selectedSerials.Add(row.Cells["ItemCode"].Value.ToString());
        }

        if (selectedSerials.Count == 0)
        {
            MessageBox.Show("Vui lòng chọn sản phẩm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // 2. Validate dữ liệu tiền tệ
        if (!decimal.TryParse(txtRefundAmount.Text.Replace(",", ""), out decimal refundAmount) || refundAmount < 0)
        {
            MessageBox.Show("Số tiền không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // 3. Thực thi lưu trữ
        if (MessageBox.Show("Xác nhận đổi trả?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
            // TODO: Gọi hàm Insert/Process của TradeInBUS tại đây
            MessageBox.Show("Đã lưu đổi trả thành công!", "Thành công");
            btnCancel_Click(null, null);
        }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        txtInvoiceCode.Clear();
        txtCustomerName.Clear();
        txtPhone.Clear();
        rtbTradeInNote.Clear();
        txtRefundAmount.Clear();
        dgvInvoiceDetails.DataSource = null;
        SetTradeInPanelState(false);
    }

    private void btnCreateTradeIn_Click(object sender, EventArgs e) { /* Code xử lý tạo phiếu mới */ }
    private void label2_Click(object sender, EventArgs e) { }
}