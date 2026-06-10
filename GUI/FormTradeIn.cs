using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Desktop_Application_Development
{
    public partial class FormTradeIn : Form
    {
        private readonly WarrantyBUS _warrantyBUS = new WarrantyBUS();

        // Hai biến này để lưu lại thông tin khi tìm kiếm mã phiếu
        private int _currentCustomerID = 0;
        private int _currentInvoiceID = 0;

        public FormTradeIn()
        {
            InitializeComponent();
        }

        private void FormTradeIn_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            LoadAllClaimsData();

            // Hỗ trợ click vào ô Checkbox trong lưới nhận giá trị ngay lập tức
            dgv_invoiceDetails.CellContentClick += Dgv_invoiceDetails_CellContentClick;
        }

        private void SetupDataGridView()
        {
            dgv_invoiceDetails.Columns.Clear();
            dgv_invoiceDetails.AutoGenerateColumns = false;
            dgv_invoiceDetails.AllowUserToAddRows = false;
            dgv_invoiceDetails.RowHeadersVisible = false;
            dgv_invoiceDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv_invoiceDetails.Columns.Add(new DataGridViewCheckBoxColumn { HeaderText = "Chọn", Name = "chkSelect", Width = 50 });
            dgv_invoiceDetails.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ClaimID", HeaderText = "Mã Claim", Name = "ClaimID", Width = 80, ReadOnly = true });
            dgv_invoiceDetails.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ClaimCode", HeaderText = "Mã Phiếu", Name = "ClaimCode", Width = 120, ReadOnly = true });
            dgv_invoiceDetails.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "SerialID", HeaderText = "Serial", Name = "SerialID", Width = 100, ReadOnly = true });
            dgv_invoiceDetails.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DefectDescription", HeaderText = "Lỗi sản phẩm", Name = "DefectDescription", Width = 200, ReadOnly = true });
            dgv_invoiceDetails.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Status", HeaderText = "Trạng thái", Name = "Status", Width = 120, ReadOnly = true });
            dgv_invoiceDetails.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Resolution", HeaderText = "Giải quyết", Name = "Resolution", Width = 200, ReadOnly = true });
        }

        private void LoadAllClaimsData()
        {
            try
            {
                // 1. Lấy toàn bộ danh sách phiếu
                var claims = _warrantyBUS.GetAll();
                dgv_invoiceDetails.DataSource = claims;

                // 2. Lọc ra các lỗi duy nhất (distinct) để đẩy vào Combobox "Lý do trả hàng"
                var uniqueDefects = claims
                    .Where(c => !string.IsNullOrEmpty(c.DefectDescription))
                    .Select(c => c.DefectDescription)
                    .Distinct()
                    .ToArray();

                txb_reason.Items.Clear();
                txb_reason.Items.AddRange(uniqueDefects);

                // Mặc định chọn dòng đầu tiên nếu có dữ liệu
                if (txb_reason.Items.Count > 0)
                    txb_reason.SelectedIndex = 0;

                SetTradeInPanelState(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetTradeInPanelState(bool isEnabled)
        {
            txb_reason.Enabled = isEnabled;
            rtb_tradeInNote.Enabled = isEnabled;
            txt_refundAmount.Enabled = isEnabled;
            btn_confirmTradeIn.Enabled = isEnabled;
            btn_createTradeIn.Enabled = isEnabled;
        }

        // --- SỰ KIỆN NÚT TÌM KIẾM ---
        private void btn_searchTradeIn_Click(object sender, EventArgs e)
        {
            try
            {
                string searchKeyword = txt_invoiceCode.Text.Trim();
                var claims = _warrantyBUS.GetAll();

                if (!string.IsNullOrEmpty(searchKeyword))
                {
                    // Lọc những dòng có chứa từ khóa ClaimCode
                    claims = claims.Where(c => c.ClaimCode != null &&
                                               c.ClaimCode.IndexOf(searchKeyword, StringComparison.OrdinalIgnoreCase) >= 0)
                                   .ToList();

                    // Gán tạm CustomerID và InvoiceID của dòng đầu tiên tìm được để dùng cho việc lưu DB
                    if (claims.Any())
                    {
                        _currentInvoiceID = claims.First().InvoiceID;
                        _currentCustomerID = claims.First().CustomerID;
                    }
                }
                else
                {
                    // Nếu ô tìm kiếm trống, reset lại biến
                    _currentInvoiceID = 0;
                    _currentCustomerID = 0;
                }

                // Cập nhật lại danh sách hiển thị
                dgv_invoiceDetails.DataSource = null;
                dgv_invoiceDetails.DataSource = claims;

                if (claims.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy phiếu bảo hành nào khớp với mã đã nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi truy vấn Database: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- SỰ KIỆN NÚT XÁC NHẬN (LƯU DB) ---
        private void btn_confirmTradeIn_Click(object sender, EventArgs e)
        {
            List<string> selectedSerials = new List<string>();

            // Quét xem những ô checkbox nào đang được tích chọn
            foreach (DataGridViewRow row in dgv_invoiceDetails.Rows)
            {
                if (row.Cells["chkSelect"].Value != null && Convert.ToBoolean(row.Cells["chkSelect"].Value))
                {
                    selectedSerials.Add(row.Cells["SerialID"].Value.ToString());
                }
            }

            // Bắt lỗi logic người dùng nhập thiếu
            if (selectedSerials.Count == 0)
            {
                MessageBox.Show("Vui lòng tích chọn ít nhất một phiếu bảo hành ở cột 'Chọn'!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txt_refundAmount.Text.Replace(",", ""), out decimal refundAmount) || refundAmount < 0)
            {
                MessageBox.Show("Số tiền hoàn không hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Bắt đầu lưu thông tin
            if (MessageBox.Show("Xác nhận lưu thông tin hoàn tiền cho các phiếu đã chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string reason = txb_reason.SelectedItem?.ToString() ?? "Khác...";
                string note = rtb_tradeInNote.Text.Trim();

                // TRUYỀN BIẾN _currentInvoiceID XUỐNG ĐỂ LƯU
                var result = _warrantyBUS.CreateTradeIn(_currentInvoiceID, _currentCustomerID, reason, note, refundAmount, selectedSerials);

                if (result.success)
                {
                    MessageBox.Show("Đã lưu phiếu đổi trả và cập nhật kho thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_cancelTradeIn_Click(null, null); // Gọi nút Hủy để clear sạch giao diện
                }
                else
                {
                    MessageBox.Show($"Thất bại: {result.error}", "Lỗi xử lý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Sự kiện hỗ trợ Checkbox
        private void Dgv_invoiceDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_invoiceDetails.Columns["chkSelect"].Index && e.RowIndex >= 0)
            {
                dgv_invoiceDetails.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        // --- SỰ KIỆN NÚT HỦY BỎ ---
        private void btn_cancelTradeIn_Click(object sender, EventArgs e)
        {
            // Xóa sạch chữ trên màn hình
            txt_invoiceCode.Clear();
            txt_customerName.Clear();
            txt_phone.Clear();
            rtb_tradeInNote.Clear();
            txt_refundAmount.Clear();

            // Reset biến
            _currentInvoiceID = 0;
            _currentCustomerID = 0;

            if (txb_reason.Items.Count > 0) txb_reason.SelectedIndex = 0;

            // Load lại toàn bộ data gốc
            LoadAllClaimsData();
        }

        // --- SỰ KIỆN NÚT TẠO PHIẾU ---
        private void btn_createTradeIn_Click(object sender, EventArgs e)
        {
            // Dùng chung một chức năng với nút Xác nhận
            btn_confirmTradeIn_Click(sender, e);
        }

        // Sự kiện để trống (bắt buộc phải giữ lại do file Designer của bạn đang liên kết với nó)
        private void rtb_tradeInNote_TextChanged(object sender, EventArgs e)
        {
        }
    }
}