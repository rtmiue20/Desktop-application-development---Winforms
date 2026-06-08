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
        private readonly SuppliersBUS _supplierBUS = new SuppliersBUS();
        private int _selectedSupplierId = 0;
        private bool _isAdding = false;

        public FormSupplier()
        {
            InitializeComponent();
        }

        private void FormSupplier_Load(object sender, EventArgs e)
        {
            SetStateControls(false);
            LoadSupplierData();
        }

        private void LoadSupplierData()
        {
            // Lấy dữ liệu thật từ Database
            var suppliers = _supplierBUS.GetAll();
            dgv_suppliers.DataSource = suppliers;

            if (dgv_suppliers.Columns["SupplierID"] != null)
                dgv_suppliers.Columns["SupplierID"].Visible = false;

            if (dgv_suppliers.Columns["CreatedAt"] != null)
                dgv_suppliers.Columns["CreatedAt"].Visible = false;

            if (dgv_suppliers.Columns["SupplierCode"] != null) dgv_suppliers.Columns["SupplierCode"].HeaderText = "Mã NCC";
            if (dgv_suppliers.Columns["SupplierName"] != null) dgv_suppliers.Columns["SupplierName"].HeaderText = "Tên nhà cung cấp";
            if (dgv_suppliers.Columns["Phone"] != null) dgv_suppliers.Columns["Phone"].HeaderText = "SĐT";
            if (dgv_suppliers.Columns["Address"] != null) dgv_suppliers.Columns["Address"].HeaderText = "Địa chỉ";

            if (dgv_suppliers.Columns["Debt"] != null)
            {
                dgv_suppliers.Columns["Debt"].HeaderText = "Công nợ";
                dgv_suppliers.Columns["Debt"].DefaultCellStyle.Format = "N0";
            }

            lbl_totalSuppliers.Text = $"Tổng: {suppliers.Count} nhà cung cấp";

            // Tính tổng công nợ từ danh sách thật
            decimal totalDebt = suppliers.Sum(s => s.Debt);
            lbl_totalDebt.Text = $"Tổng công nợ: {totalDebt:N0} đ";
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

                decimal debt = Convert.ToDecimal(row.Cells["Debt"].Value ?? 0);
                txt_debt.Text = debt.ToString("N0");
            }
        }

        private void SetStateControls(bool isEditing)
        {
            txt_supplierName.ReadOnly = !isEditing;
            txt_phone.ReadOnly = !isEditing;
            txt_address.ReadOnly = !isEditing;
            txt_debt.ReadOnly = true; // Công nợ chỉ cập nhật qua hóa đơn

            pnl_details.Enabled = isEditing;
            dgv_suppliers.Enabled = !isEditing;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            _isAdding = true;
            ClearDetails();
            SetStateControls(true);
            txt_supplierName.Focus();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (_selectedSupplierId == 0)
            {
                MessageBox.Show("Vui lòng chọn NCC cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _isAdding = false;
            SetStateControls(true);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (_selectedSupplierId == 0) return;
            if (MessageBox.Show("Xóa nhà cung cấp này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                

                MessageBox.Show("Chức năng xóa chưa được hỗ trợ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearDetails();
                LoadSupplierData();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_supplierName.Text) || string.IsNullOrWhiteSpace(txt_phone.Text))
            {
                MessageBox.Show("Vui lòng điền đủ Tên NCC và SĐT!", "Cảnh báo");
                return;
            }

            // TODO: Khởi tạo SuppliersDTO và gọi _supplierBUS.Insert hoặc Update
            MessageBox.Show(_isAdding ? "Thêm mới thành công!" : "Cập nhật thành công!");

            _isAdding = false;
            SetStateControls(false);
            LoadSupplierData();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            _isAdding = false;
            SetStateControls(false);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            _isAdding = false;
            SetStateControls(false);
            ClearDetails();
            LoadSupplierData();
        }

        private void ClearDetails()
        {
            txt_supplierName.Clear();
            txt_phone.Clear();
            txt_address.Clear();
            txt_debt.Text = "0";
        }
    }
}