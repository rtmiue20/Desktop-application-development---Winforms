using System;
using System.Data;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class FormSupplier : Form
    {
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
            DataTable dt = new DataTable();
            dt.Columns.Add("SupplierID", typeof(int));
            dt.Columns.Add("SupplierCode", typeof(string));
            dt.Columns.Add("SupplierName", typeof(string));
            dt.Columns.Add("Phone", typeof(string));
            dt.Columns.Add("Address", typeof(string));
            dt.Columns.Add("Debt", typeof(decimal));

            dt.Rows.Add(1, "NCC001", "Apple Vietnam", "028 1234 5678", "Q.1, TP.HCM", 120000000);
            dt.Rows.Add(2, "NCC002", "Samsung Vietnam", "028 9876 5432", "Q.7, TP.HCM", 0);

            dgv_suppliers.DataSource = dt;

            if (dgv_suppliers.Columns["SupplierID"] != null)
                dgv_suppliers.Columns["SupplierID"].Visible = false;

            dgv_suppliers.Columns["SupplierCode"].HeaderText = "Mã NCC";
            dgv_suppliers.Columns["SupplierName"].HeaderText = "Tên nhà cung cấp";
            dgv_suppliers.Columns["Phone"].HeaderText = "SĐT";
            dgv_suppliers.Columns["Address"].HeaderText = "Địa chỉ";
            dgv_suppliers.Columns["Debt"].HeaderText = "Công nợ";
            dgv_suppliers.Columns["Debt"].DefaultCellStyle.Format = "N0";

            lbl_totalSuppliers.Text = $"Tổng: {dt.Rows.Count} nhà cung cấp";

            decimal totalDebt = 0;
            foreach (DataRow row in dt.Rows)
            {
                // Sử dụng toán tử null-coalescing (??) để tránh lỗi CS8602
                totalDebt += Convert.ToDecimal(row["Debt"] ?? 0);
            }
            lbl_totalDebt.Text = $"Tổng công nợ: {totalDebt:N0} đ";
        }

        private void dgv_suppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !_isAdding)
            {
                DataGridViewRow row = dgv_suppliers.Rows[e.RowIndex];

                _selectedSupplierId = Convert.ToInt32(row.Cells["SupplierID"].Value ?? 0);

                // Tránh null khi cast sang ToString()
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
            txt_debt.ReadOnly = true;

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
                MessageBox.Show("Xóa thành công!");
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