using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Desktop_Application_Development
{
    public partial class FormTradeIn : Form
    {
        // Khởi tạo các đối tượng nghiệp vụ (Đã đặt đúng vị trí bên trong Class)
        private readonly WarrantyBUS _warrantyBUS = new WarrantyBUS(); 
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
            txb_reason.Items.Clear();
            txb_reason.Items.AddRange(new string[] { "Sản phẩm lỗi do NSX", "Thu cũ đổi mới", "Khách đổi ý (Có tính phí)", "Khác..." });
            if (txb_reason.Items.Count > 0)
            {
                txb_reason.SelectedIndex = 0;
            }
            SetTradeInPanelState(false);
        }

        private void SetupDataGridView()
        {
            dgv_invoiceDetails.Columns.Clear();
            dgv_invoiceDetails.AutoGenerateColumns = false;
            dgv_invoiceDetails.AllowUserToAddRows = false;
            dgv_invoiceDetails.RowHeadersVisible = false;
            dgv_invoiceDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv_invoiceDetails.Columns.Add(new DataGridViewCheckBoxColumn { HeaderText = "Chọn", Name = "chkSelect", Width = 50 });
            dgv_invoiceDetails.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ItemCode", HeaderText = "Mã Serial", Name = "ItemCode", Width = 120, ReadOnly = true });
            dgv_invoiceDetails.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProductName", HeaderText = "Tên Sản Phẩm", Name = "ProductName", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, ReadOnly = true });
            dgv_invoiceDetails.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "UnitPrice", HeaderText = "Giá Bán", Name = "UnitPrice", Width = 100, ReadOnly = true });
        }

        private void SetTradeInPanelState(bool isEnabled)
        {
            txb_reason.Enabled = isEnabled;
            rtb_tradeInNote.Enabled = isEnabled;
            txt_refundAmount.Enabled = isEnabled;
            btn_confirmTradeIn.Enabled = isEnabled;
            btn_createTradeIn.Enabled = isEnabled;
        }

        // ==========================================
        // 1. SỰ KIỆN NÚT TÌM KIẾM HÓA ĐƠN
        // ==========================================
        private void btn_searchTradeIn_Click(object sender, EventArgs e)
        {
            string invoiceCode = txt_invoiceCode.Text.Trim();
            if (string.IsNullOrEmpty(invoiceCode))
            {
                MessageBox.Show("Vui lòng nhập Mã Hóa Đơn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var invoice = _salesBUS.GetByInvoiceCode(invoiceCode); 

                if (invoice != null)
                {
                    _currentInvoiceID = invoice.InvoiceID;
                    _currentCustomerID = invoice.CustomerID ?? 0;
                    
                    var customer = _customerBUS.GetById(_currentCustomerID);
                    txt_customerName.Text = customer != null ? customer.FullName : "Khách lẻ";
                    txt_phone.Text = customer != null ? customer.Phone : "Không có";
                    
                    var chiTietHoaDon = _salesBUS.GetInvoiceDetails(_currentInvoiceID);
                    dgv_invoiceDetails.DataSource = null; 
                    dgv_invoiceDetails.DataSource = chiTietHoaDon;
                    
                    SetTradeInPanelState(true);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btn_cancelTradeIn_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi truy vấn Database: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // 2. SỰ KIỆN NÚT XÁC NHẬN (LƯU DATABASE)
        // ==========================================
        private void btn_confirmTradeIn_Click(object sender, EventArgs e)
        {
            if (_currentInvoiceID == 0)
            {
                MessageBox.Show("Vui lòng tìm kiếm hóa đơn trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> selectedSerials = new List<string>();
            foreach (DataGridViewRow row in dgv_invoiceDetails.Rows)
            {
                // Kiểm tra null trước khi ép kiểu để tránh crash app nếu click vào ô trống
                if (row.Cells["chkSelect"].Value != null && Convert.ToBoolean(row.Cells["chkSelect"].Value))
                {
                    selectedSerials.Add(row.Cells["ItemCode"].Value.ToString());
                }
            }

            if (selectedSerials.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một sản phẩm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txt_refundAmount.Text.Replace(",", ""), out decimal refundAmount) || refundAmount < 0)
            {
                MessageBox.Show("Số tiền hoàn không hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Xác nhận tạo phiếu đổi trả?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string reason = txb_reason.SelectedItem?.ToString() ?? "Khác...";
                string note = rtb_tradeInNote.Text.Trim();

                // Bắn dữ liệu xuống WarrantyBUS
                var result = _warrantyBUS.CreateTradeIn(_currentInvoiceID, _currentCustomerID, reason, note, refundAmount, selectedSerials);

                if (result.success)
                {
                    MessageBox.Show("Đã lưu phiếu đổi trả và cập nhật kho thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_cancelTradeIn_Click(null, null); // Clear sạch form sau khi lưu
                }
                else
                {
                    MessageBox.Show($"Thất bại: {result.error}", "Lỗi xử lý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ==========================================
        // 3. SỰ KIỆN NÚT HỦY / LÀM MỚI
        // ==========================================
        private void btn_cancelTradeIn_Click(object sender, EventArgs e)
        {
            txt_invoiceCode.Clear();
            txt_customerName.Clear();
            txt_phone.Clear();
            rtb_tradeInNote.Clear();
            txt_refundAmount.Clear();
            
            // Phải reset ID về 0 để an toàn cho phiên giao dịch tiếp theo
            _currentInvoiceID = 0; 
            _currentCustomerID = 0; 
            
            dgv_invoiceDetails.DataSource = null;
            SetTradeInPanelState(false);
        }

        // ==========================================
        // 4. SỰ KIỆN NÚT TẠO PHIẾU ĐỔI TRẢ
        // ==========================================
        private void btn_createTradeIn_Click(object sender, EventArgs e)
        {
            // Trỏ thẳng sang hàm Xác nhận để tái sử dụng toàn bộ logic kiểm tra và lưu DB
            // Điều này giúp người dùng bấm nút "Xác nhận" hay "Tạo phiếu" đều có tác dụng như nhau.
            btn_confirmTradeIn_Click(sender, e);
        }
    }
}