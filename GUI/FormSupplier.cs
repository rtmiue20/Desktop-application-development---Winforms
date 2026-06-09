using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class FormSupplier : Form
    {
        private SuppliersBUS _supplierBUS = null!;
        private int _selectedSupplierId = 0;
        private bool _isAdding = false;

        public FormSupplier()
        {
            InitializeComponent();
        }

        private void FormSupplier_Load(object sender, EventArgs e)
        {
            _supplierBUS = new SuppliersBUS();
            SetStateControls(false);
            LoadSupplierData();
        }
        private void LoadSupplierData()
        {
            var suppliers = _supplierBUS.GetAll();

            // Xóa rác Designer và ép vẽ lại cột theo đúng tên biến Database
            dgv_suppliers.Columns.Clear();
            dgv_suppliers.AutoGenerateColumns = true;
            dgv_suppliers.DataSource = suppliers;

            // Bắt lỗi nếu Database trống
            if (suppliers == null || suppliers.Count == 0)
            {
                lbl_totalSuppliers.Text = "Tổng: 0 nhà cung cấp (Database đang trống)";
                lbl_totalDebt.Text = "Tổng công nợ: 0 đ";
                return;
            }

            // Đổi tên Header khớp với DTO (Dựa theo thiết kế Schema)
            if (dgv_suppliers.Columns["SupplierID"] is { } colId) colId.Visible = false;
            if (dgv_suppliers.Columns["CreatedAt"] is { } colDate) colDate.Visible = false;

            if (dgv_suppliers.Columns["SupplierCode"] is { } colCode) colCode.HeaderText = "Mã NCC";
            if (dgv_suppliers.Columns["SupplierName"] is { } colName) colName.HeaderText = "Tên nhà cung cấp";
            if (dgv_suppliers.Columns["Phone"] is { } colPhone) colPhone.HeaderText = "SĐT";
            if (dgv_suppliers.Columns["Address"] is { } colAddr) colAddr.HeaderText = "Địa chỉ";
            if (dgv_suppliers.Columns["Debt"] is { } colDebt)
            {
                colDebt.HeaderText = "Công nợ";
                colDebt.DefaultCellStyle.Format = "N0";
            }

            lbl_totalSuppliers.Text = $"Tổng: {suppliers.Count} nhà cung cấp";
            lbl_totalDebt.Text = $"Tổng công nợ: {suppliers.Sum(s => s.Debt):N0} đ";
        }

        private void dgv_suppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !_isAdding)
            {
                var row = dgv_suppliers.Rows[e.RowIndex];
                _selectedSupplierId = Convert.ToInt32(row.Cells["SupplierID"].Value ?? 0);

                txt_supplierName.Text = row.Cells["SupplierName"].Value?.ToString() ?? string.Empty;
                txt_phone.Text = row.Cells["Phone"].Value?.ToString() ?? string.Empty;
                txt_address.Text = row.Cells["Address"].Value?.ToString() ?? string.Empty;
                txt_debt.Text = Convert.ToDecimal(row.Cells["Debt"].Value ?? 0).ToString("N0");
            }
        }

        private void SetStateControls(bool isEditing)
        {
            txt_supplierName.ReadOnly = !isEditing;
            txt_phone.ReadOnly = !isEditing;
            txt_address.ReadOnly = !isEditing;
            txt_debt.ReadOnly = true;
            pnl_details.Enabled = isEditing;
            dgv_suppliers.Enabled = !isEditing;
        }

        // Các hàm Add, Edit, Delete, Save, Refresh giữ nguyên logic cũ của bạn
        private void btn_add_Click(object sender, EventArgs e) { _isAdding = true; ClearDetails(); SetStateControls(true); txt_supplierName.Focus(); }
        private void btn_edit_Click(object sender, EventArgs e) { if (_selectedSupplierId > 0) { _isAdding = false; SetStateControls(true); } }
        private void btn_delete_Click(object sender, EventArgs e) {
            if (_selectedSupplierId > 0 && MessageBox.Show("Xóa NCC này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Tầng BUS chưa hỗ trợ hàm Delete. Vui lòng bổ sung sau!", "Thông báo");
             LoadSupplierData();
             ClearDetails();
            }
         }
        private void btn_save_Click(object sender, EventArgs e) { SetStateControls(false); LoadSupplierData(); }
        private void btn_cancel_Click(object sender, EventArgs e) { _isAdding = false; SetStateControls(false); LoadSupplierData(); }
        private void btn_refresh_Click(object sender, EventArgs e) { _isAdding = false; SetStateControls(false); ClearDetails(); LoadSupplierData(); }
        private void ClearDetails() { txt_supplierName.Clear(); txt_phone.Clear(); txt_address.Clear(); txt_debt.Text = "0"; }
    }
}