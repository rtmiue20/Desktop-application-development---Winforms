using System;
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

            dgv_suppliers.Columns.Clear();
            dgv_suppliers.AutoGenerateColumns = true;
            dgv_suppliers.DataSource = suppliers;

            if (suppliers == null || suppliers.Count == 0)
            {
                lbl_totalSuppliers.Text = "Tổng NCC: 0 (Database trống)";
                lbl_totalDebt.Text = "Tổng công nợ: 0 đ";
                return;
            }

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

            lbl_totalSuppliers.Text = $"Tổng NCC: {suppliers.Count}";
            lbl_totalDebt.Text = $"Tổng công nợ: {suppliers.Sum(s => s.Debt):N0} đ";
        }

        private void dgv_suppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgv_suppliers.Rows[e.RowIndex];
                _selectedSupplierId = Convert.ToInt32(row.Cells["SupplierID"].Value ?? 0);

                txt_supplierName.Text = row.Cells["SupplierName"].Value?.ToString() ?? string.Empty;
                txt_phone.Text = row.Cells["Phone"].Value?.ToString() ?? string.Empty;
                txt_address.Text = row.Cells["Address"].Value?.ToString() ?? string.Empty;
                txt_debt.Text = Convert.ToDecimal(row.Cells["Debt"].Value ?? 0).ToString("N0");

                // Sau khi hiển thị, mặc định là chế độ xem, chưa cho sửa
                SetStateControls(false);
            }
        }


        private void SetStateControls(bool isEditing)
        {
            txt_supplierName.ReadOnly = !isEditing;
            txt_phone.ReadOnly = !isEditing;
            txt_address.ReadOnly = !isEditing;
            txt_debt.ReadOnly = true;
            dgv_suppliers.Enabled = !isEditing;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            _isAdding = true;
            _selectedSupplierId = 0;
            ClearDetails();
            SetStateControls(true);
            txt_supplierName.Focus();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (_selectedSupplierId > 0)
            {
                _isAdding = false;
                SetStateControls(true); // bật chế độ cho phép sửa
            }
            else
            {
                MessageBox.Show("Vui lòng chọn NCC cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (_selectedSupplierId > 0)
            {
                if (MessageBox.Show("Xóa NCC này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool ok = _supplierBUS.Delete(_selectedSupplierId);
                    if (ok)
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    LoadSupplierData();
                    ClearDetails();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn NCC cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_supplierName.Text) || string.IsNullOrWhiteSpace(txt_phone.Text))
            {
                MessageBox.Show("Tên NCC và SĐT không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dto = new SuppliersDTO
            {
                SupplierID = _selectedSupplierId,
                SupplierName = txt_supplierName.Text.Trim(),
                Phone = txt_phone.Text.Trim(),
                Address = txt_address.Text.Trim(),
                Debt = 0 // công nợ mặc định
            };

            bool ok;
            if (_isAdding)
            {
                ok = _supplierBUS.Add(dto);
                MessageBox.Show(ok ? "Thêm NCC thành công!" : "Thêm NCC thất bại!", "Thông báo");
            }
            else
            {
                ok = _supplierBUS.Update(dto);
                MessageBox.Show(ok ? "Cập nhật NCC thành công!" : "Cập nhật NCC thất bại!", "Thông báo");
            }

            _isAdding = false;
            SetStateControls(false);
            LoadSupplierData();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            _isAdding = false;
            SetStateControls(false);
            ClearDetails();
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
            _selectedSupplierId = 0;
        }

    }

}
