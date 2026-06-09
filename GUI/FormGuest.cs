using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class FormGuest : Form
    {
        private readonly CustomersBUS guestBUS = new CustomersBUS();

        private bool isAdding = false;
        private int selectedRow = -1;

        public FormGuest()
        {
            InitializeComponent();

            // Gắn event handlers (nếu Designer chưa gắn)
            Load += FormGuest_Load;
            btn_addCustomer.Click += btn_AddCustomer_Click;
            btn_edit.Click += btn_Edit_Click;
            btn_purchaseHistory.Click += btn_PurchaseHistory_Click;
            btn_refresh.Click += btn_Refresh_Click;
            btn_save.Click += btn_Save_Click;
            btn_cancel.Click += btn_Cancel_Click;
            txt_search.TextChanged += txt_Search_TextChanged;
            dgv_guest.CellClick += dgv_Guest_CellClick;
            dgv_guest.CellContentClick += dgv_guest_CellContentClick;
        }

        private void FormGuest_Load(object? sender, EventArgs e)
        {
            dgv_guest.AutoGenerateColumns = false;
            dgv_guest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_guest.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_guest.MultiSelect = false;
            dgv_guest.AllowUserToAddRows = false;
            dgv_guest.ReadOnly = true;

            // Nếu Designer chưa set DataPropertyName, set ở đây (không duplicate nếu đã có)
            if (dgv_guest.Columns.Count == 0)
            {
                dgv_guest.Columns.Add(new DataGridViewTextBoxColumn { Name = "col_phone", HeaderText = "SĐT", DataPropertyName = "Phone" });
                dgv_guest.Columns.Add(new DataGridViewTextBoxColumn { Name = "col_name", HeaderText = "Họ tên", DataPropertyName = "FullName" });
                dgv_guest.Columns.Add(new DataGridViewTextBoxColumn { Name = "col_type", HeaderText = "Loại KH", DataPropertyName = "CustomerType" });
                dgv_guest.Columns.Add(new DataGridViewTextBoxColumn { Name = "col_points", HeaderText = "Điểm tích lũy", DataPropertyName = "TotalPoints" });
                dgv_guest.Columns.Add(new DataGridViewTextBoxColumn { Name = "col_total", HeaderText = "Tổng mua", DataPropertyName = "TotalPoints" });
                dgv_guest.Columns.Add(new DataGridViewTextBoxColumn { Name = "col_date", HeaderText = "Ngày tạo", DataPropertyName = "CreatedAt" });
            }

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var list = guestBUS.GetAll() ?? new List<CustomersDTO>();
                dgv_guest.DataSource = list;
                dgv_guest.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load dữ liệu khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_AddCustomer_Click(object? sender, EventArgs e)
        {
            isAdding = true;
            selectedRow = -1;
            txt_phoneNumber.Clear();
            txt_fullName.Clear();
            txt_address.Clear();
            cbo_customerType.SelectedIndex = -1;
            txt_phoneNumber.Focus();
        }

        private void btn_Save_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_phoneNumber.Text) || string.IsNullOrWhiteSpace(txt_fullName.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin (SĐT và Họ tên).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var dto = new CustomersDTO
                {
                    Phone = txt_phoneNumber.Text.Trim(),
                    FullName = txt_fullName.Text.Trim(),
                    Address = txt_address.Text.Trim(),
                    CustomerType = string.IsNullOrWhiteSpace(cbo_customerType.Text) ? "Thường" : cbo_customerType.Text
                };

                if (isAdding)
                {
                    bool ok = guestBUS.Add(dto);
                    if (ok)
                    {
                        MessageBox.Show("Thêm khách hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm khách hàng thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (selectedRow >= 0 && dgv_guest.CurrentRow != null)
                    {
                        var bound = dgv_guest.CurrentRow.DataBoundItem as CustomersDTO;
                        if (bound == null)
                        {
                            MessageBox.Show("Không xác định được khách hàng để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        dto.CustomerID = bound.CustomerID;
                        var (success, error) = guestBUS.Update(dto);
                        if (success)
                        {
                            MessageBox.Show("Cập nhật khách hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật khách hàng thất bại: " + error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                LoadData();
                isAdding = false;
                selectedRow = -1;
                txt_phoneNumber.Clear();
                txt_fullName.Clear();
                txt_address.Clear();
                cbo_customerType.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Edit_Click(object? sender, EventArgs e)
        {
            if (dgv_guest.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            selectedRow = dgv_guest.CurrentRow.Index;
            var bound = dgv_guest.CurrentRow.DataBoundItem as CustomersDTO;
            if (bound == null)
            {
                MessageBox.Show("Dữ liệu khách hàng không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txt_phoneNumber.Text = bound.Phone;
            txt_fullName.Text = bound.FullName;
            txt_address.Text = bound.Address;
            cbo_customerType.Text = bound.CustomerType;

            isAdding = false;
            txt_phoneNumber.Focus();
        }

        private void btn_Cancel_Click(object? sender, EventArgs e)
        {
            btn_Refresh_Click(sender, e);
        }

        private void btn_Refresh_Click(object? sender, EventArgs e)
        {
            txt_search.Clear();
            txt_phoneNumber.Clear();
            txt_fullName.Clear();
            txt_address.Clear();
            cbo_customerType.SelectedIndex = -1;
            dgv_guest.ClearSelection();
            isAdding = false;
            selectedRow = -1;
            LoadData();
        }

        private void btn_PurchaseHistory_Click(object? sender, EventArgs e)
        {
            if (dgv_guest.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var bound = dgv_guest.CurrentRow.DataBoundItem as CustomersDTO;
            string customerName = bound?.FullName ?? dgv_guest.CurrentRow.Cells["col_name"].Value?.ToString() ?? "(không tên)";
            MessageBox.Show("Hiển thị lịch sử mua của khách hàng: " + customerName, "Lịch sử mua", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgv_Guest_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            selectedRow = e.RowIndex;
            var row = dgv_guest.Rows[e.RowIndex];
            txt_phoneNumber.Text = row.Cells["col_phone"].Value?.ToString();
            txt_fullName.Text = row.Cells["col_name"].Value?.ToString();
            cbo_customerType.Text = row.Cells["col_type"].Value?.ToString();

            var bound = row.DataBoundItem as CustomersDTO;
            if (bound != null) txt_address.Text = bound.Address;
        }

        private void txt_Search_TextChanged(object? sender, EventArgs e)
        {
            string keyword = txt_search.Text.Trim();
            try
            {
                var result = guestBUS.Search(keyword) ?? new List<CustomersDTO>();
                dgv_guest.DataSource = result;
                dgv_guest.ClearSelection();
            }
            catch (Exception)
            {
                // fallback: nothing
            }
        }

        private void dgv_guest_CellContentClick(object? sender, DataGridViewCellEventArgs e) { }
    }
}
