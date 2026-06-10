using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormTradeIn : Form
    {
        // Khởi tạo đối tượng tầng BUS (Ví dụ)
        // private readonly TradeInBUS _tradeInBUS = new TradeInBUS();

        public FormTradeIn()
        {
            InitializeComponent();
            SetupDataGridView();
        }

        private void FormTradeIn_Load(object sender, EventArgs e)
        {
            LoadComboBoxReasons();
        }

        // Cập nhật: Thêm các cột mới vào DataGridView theo mẫu
        private void SetupDataGridView()
        {
            dgvInvoiceDetails.AutoGenerateColumns = false;
            dgvInvoiceDetails.AllowUserToAddRows = false;
            dgvInvoiceDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInvoiceDetails.MultiSelect = false;
            dgvInvoiceDetails.ReadOnly = true;
            dgvInvoiceDetails.BackgroundColor = Color.DarkGray; 
            dgvInvoiceDetails.RowHeadersVisible = false;
            dgvInvoiceDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Xóa các cột cũ (nếu có) để tạo lại
            dgvInvoiceDetails.Columns.Clear();

            // Cột 1: Mã SP
            dgvInvoiceDetails.Columns.Add(new DataGridViewTextBoxColumn 
            { 
                Name = "colProductID", HeaderText = "Mã SP", DataPropertyName = "ProductID", FillWeight = 15 
            });
            // Cột 2: Tên sản phẩm
            dgvInvoiceDetails.Columns.Add(new DataGridViewTextBoxColumn 
            { 
                Name = "colProductName", HeaderText = "Tên sản phẩm", DataPropertyName = "ProductName", FillWeight = 30 
            });
            // Cột 3: Serial/IMEI
            dgvInvoiceDetails.Columns.Add(new DataGridViewTextBoxColumn 
            { 
                Name = "colSerial", HeaderText = "Serial/IMEI", DataPropertyName = "SerialNumber", FillWeight = 20 
            });
            // Cột 4: Đơn giá bán ban đầu
            dgvInvoiceDetails.Columns.Add(new DataGridViewTextBoxColumn 
            { 
                Name = "colOriginalPrice", HeaderText = "Đơn giá bán", DataPropertyName = "OriginalPrice", FillWeight = 15 
            });
            // Cột 5: Tình trạng máy (MỚI THÊM)
            dgvInvoiceDetails.Columns.Add(new DataGridViewTextBoxColumn 
            { 
                Name = "colCondition", HeaderText = "Tình trạng", DataPropertyName = "Condition", FillWeight = 15 
            });
            // Cột 6: Giá thu cũ dự kiến (MỚI THÊM)
            dgvInvoiceDetails.Columns.Add(new DataGridViewTextBoxColumn 
            { 
                Name = "colTradeInPrice", HeaderText = "Giá thu lại", DataPropertyName = "TradeInPrice", FillWeight = 15 
            });
        }

        // Load dữ liệu ComboBox lý do trả hàng
        private void LoadComboBoxReasons()
        {
            cboReason.Items.Clear();
            cboReason.Items.Add("Sản phẩm bị lỗi do nhà sản xuất");
            cboReason.Items.Add("Khách hàng muốn đổi mẫu khác");
            cboReason.Items.Add("Thu cũ đổi mới (Trade-in)");
            cboReason.Items.Add("Lý do khác");
            cboReason.SelectedIndex = 0;
        }

        // Sự kiện TÌM KIẾM
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string invoiceId = txtInvoiceId.Text.Trim();

            if (string.IsNullOrEmpty(invoiceId))
            {
                MessageBox.Show("Vui lòng nhập Mã hóa đơn gốc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Demo tạo dữ liệu giả lập để hiển thị đủ các cột mới khi test UI
                DataTable dtMock = new DataTable();
                dtMock.Columns.Add("ProductID");
                dtMock.Columns.Add("ProductName");
                dtMock.Columns.Add("SerialNumber");
                dtMock.Columns.Add("OriginalPrice");
                dtMock.Columns.Add("Condition");
                dtMock.Columns.Add("TradeInPrice");

                dtMock.Rows.Add("SP001", "iPhone 15 Pro Max 256GB", "IMEI123456789", "29,000,000", "Trầy xước nhẹ", "20,000,000");
                dtMock.Rows.Add("SP002", "MacBook Air M2 2022", "SER987654321", "25,000,000", "Hoạt động tốt", "18,500,000");

                dgvInvoiceDetails.DataSource = dtMock;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi truy xuất dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sự kiện XÁC NHẬN (Xử lý Trade-In)
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (dgvInvoiceDetails.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm từ danh sách để xử lý!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string reason = cboReason.SelectedItem?.ToString();
            string resolution = txtResolution.Text.Trim();

            if (string.IsNullOrEmpty(resolution))
            {
                MessageBox.Show("Vui lòng nhập phương án giải quyết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Lấy thông tin từ các cột mới
                string serialNumber = dgvInvoiceDetails.CurrentRow.Cells["colSerial"].Value.ToString();
                string tradeInPrice = dgvInvoiceDetails.CurrentRow.Cells["colTradeInPrice"].Value.ToString();
                string condition = dgvInvoiceDetails.CurrentRow.Cells["colCondition"].Value.ToString();

                MessageBox.Show($"Xử lý thành công!\nSerial: {serialNumber}\nTình trạng: {condition}\nGiá thu lại: {tradeInPrice}\nGiải quyết: {resolution}", 
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xử lý dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            txtInvoiceId.Clear();
            txtNotes.Clear();
            txtResolution.Clear();
            cboReason.SelectedIndex = 0;
            dgvInvoiceDetails.DataSource = null;
        }
    }
}