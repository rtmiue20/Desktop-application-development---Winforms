using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI;

public partial class FormIntoWarehouse : Form
{
    // ── BUS ──────────────────────────────────────────────────────────────────
    private readonly SuppliersBUS _supplierBUS = new();
    private readonly ProductsBUS _productBUS = new();
    private readonly InboundBUS _inboundBUS = new();

    // ── Model giỏ hàng nhập ──────────────────────────────────────────────────
    private class CartItem
    {
        public int ProductID { get; set; }
        public string ProductCode { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal UnitCost { get; set; }
        public decimal TotalCost => Quantity * UnitCost;
        public string Serials { get; set; } = string.Empty; // danh sách serial cách nhau bởi ;
    }

    private readonly List<CartItem> _cart = new();

    public FormIntoWarehouse()
    {
        InitializeComponent();
        this.Load += FormIntoWarehouse_Load;
    }

    // ── Load ─────────────────────────────────────────────────────────────────
    private void FormIntoWarehouse_Load(object sender, EventArgs e)
    {
        LoadSuppliers();
        SetupGrid();
        ToggleState(false);
        txt_receiptCode.Text = GenerateReceiptCode();
    }

    private void LoadSuppliers()
    {
        var list = _supplierBUS.GetAll();
        if (list != null && list.Count > 0)
        {
            cb_suppliers.DataSource = list;
            cb_suppliers.DisplayMember = "SupplierName";
            cb_suppliers.ValueMember = "SupplierID";
        }
        else
        {
            cb_suppliers.Items.Add("--- Chưa có NCC ---");
            cb_suppliers.SelectedIndex = 0;
        }
    }

    private void SetupGrid()
    {
        dgv_details.AutoGenerateColumns = false;
        dgv_details.Columns.Clear();
        dgv_details.Columns.AddRange(
            new DataGridViewTextBoxColumn { Name = "colCode", HeaderText = "Mã SP", DataPropertyName = "ProductCode", Width = 80 },
            new DataGridViewTextBoxColumn { Name = "colName", HeaderText = "Tên sản phẩm", DataPropertyName = "ProductName", Width = 200 },
            new DataGridViewTextBoxColumn { Name = "colQty", HeaderText = "SL nhập", DataPropertyName = "Quantity", Width = 70 },
            new DataGridViewTextBoxColumn
            {
                Name = "colCost",
                HeaderText = "Đơn giá nhập",
                DataPropertyName = "UnitCost",
                Width = 110,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }
            },
            new DataGridViewTextBoxColumn
            {
                Name = "colTotal",
                HeaderText = "Thành tiền",
                DataPropertyName = "TotalCost",
                Width = 110,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }
            },
            new DataGridViewTextBoxColumn { Name = "colSerial", HeaderText = "Serial (nếu có)", DataPropertyName = "Serials", Width = 150 },
            new DataGridViewButtonColumn
            {
                Name = "colDel",
                HeaderText = "Xóa",
                Width = 50,
                Text = "✕",
                UseColumnTextForButtonValue = true
            }
        );
        dgv_details.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgv_details.AllowUserToAddRows = false;
        dgv_details.AllowUserToDeleteRows = false;
        dgv_details.RowHeadersVisible = false;
        dgv_details.CellClick += dgv_details_CellClick;
    }

    // ── Xóa dòng khi bấm nút ✕ ──────────────────────────────────────────────
    private void dgv_details_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        if (dgv_details.Columns[e.ColumnIndex].Name == "colDel")
        {
            _cart.RemoveAt(e.RowIndex);
            RefreshGrid();
        }
    }

    // ── Toggle trạng thái form ───────────────────────────────────────────────
    private void ToggleState(bool enabled)
    {
        cb_suppliers.Enabled = enabled;
        btn_addProduct.Enabled = enabled;
        btn_confirmReceipt.Enabled = enabled;
        btn_cancelReceipt.Enabled = enabled;
        btn_createReceipt.Enabled = !enabled;
    }

    // ── Tạo phiếu mới ────────────────────────────────────────────────────────
    private void btn_createReceipt_Click(object sender, EventArgs e)
    {
        ToggleState(true);
        _cart.Clear();
        RefreshGrid();
        txt_receiptCode.Text = GenerateReceiptCode();
        lbl_bottomStatus.Text = $"Phiếu: {txt_receiptCode.Text} — Đang lập";
    }

    // ── Thêm sản phẩm vào phiếu ──────────────────────────────────────────────
    private void btn_addProduct_Click(object sender, EventArgs e)
    {
        // Lấy danh sách sản phẩm từ DB
        var products = _productBUS.GetAll();
        if (products == null || products.Count == 0)
        {
            MessageBox.Show("Chưa có sản phẩm nào trong hệ thống!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // Dialog chọn sản phẩm
        using var dlg = new Form
        {
            Text = "Chọn sản phẩm nhập kho",
            Size = new System.Drawing.Size(700, 500),
            StartPosition = FormStartPosition.CenterParent,
            FormBorderStyle = FormBorderStyle.FixedDialog,
            MaximizeBox = false
        };

        var dgv = new DataGridView
        {
            Dock = DockStyle.Fill,
            ReadOnly = true,
            SelectionMode = DataGridViewSelectionMode.FullRowSelect,
            MultiSelect = false,
            AllowUserToAddRows = false,
            AutoGenerateColumns = false,
            RowHeadersVisible = false
        };
        dgv.Columns.AddRange(
            new DataGridViewTextBoxColumn { HeaderText = "Mã SP", DataPropertyName = "ProductCode", Width = 80 },
            new DataGridViewTextBoxColumn { HeaderText = "Tên SP", DataPropertyName = "ProductName", Width = 220 },
            new DataGridViewTextBoxColumn { HeaderText = "Danh mục", DataPropertyName = "CategoryID", Width = 80 },
            new DataGridViewTextBoxColumn
            {
                HeaderText = "Giá nhập",
                DataPropertyName = "CostPrice",
                Width = 110,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }
            }
        );
        dgv.DataSource = products;

        var pnlBottom = new Panel { Dock = DockStyle.Bottom, Height = 120, Padding = new Padding(10) };

        var lblQty = new Label { Text = "Số lượng:", Location = new System.Drawing.Point(10, 10), AutoSize = true };
        var numQty = new NumericUpDown { Location = new System.Drawing.Point(100, 7), Width = 80, Minimum = 1, Maximum = 9999, Value = 1 };
        var lblCost = new Label { Text = "Đơn giá nhập:", Location = new System.Drawing.Point(200, 10), AutoSize = true };
        var txtCost = new TextBox { Location = new System.Drawing.Point(310, 7), Width = 120, Text = "0" };
        var lblSerial = new Label { Text = "Serials (cách nhau bởi dấu phẩy):", Location = new System.Drawing.Point(10, 50), AutoSize = true };
        var txtSerial = new TextBox { Location = new System.Drawing.Point(10, 72), Width = 550, PlaceholderText = "VD: SN001,SN002,SN003 (bỏ trống nếu không có serial)" };
        var btnOK = new Button { Text = "✔ Thêm", Location = new System.Drawing.Point(580, 7), Width = 90, Height = 30 };

        // Khi chọn dòng → tự điền giá nhập
        dgv.SelectionChanged += (s, _) =>
        {
            if (dgv.CurrentRow?.DataBoundItem is ProductsDTO p)
                txtCost.Text = p.CostPrice.ToString("N0").Replace(",", "");
        };

        pnlBottom.Controls.AddRange(new Control[] { lblQty, numQty, lblCost, txtCost, lblSerial, txtSerial, btnOK });
        dlg.Controls.Add(dgv);
        dlg.Controls.Add(pnlBottom);

        btnOK.Click += (s, _) =>
        {
            if (dgv.CurrentRow?.DataBoundItem is not ProductsDTO selected) return;
            if (!decimal.TryParse(txtCost.Text.Replace(",", "").Replace(".", ""), out decimal cost) || cost <= 0)
            {
                MessageBox.Show("Vui lòng nhập đơn giá hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int qty = (int)numQty.Value;
            string serials = txtSerial.Text.Trim();

            // Kiểm tra nếu sản phẩm có serial thì số serial phải khớp số lượng
            if (selected.IsSerialized && !string.IsNullOrEmpty(serials))
            {
                var serialList = serials.Split(',').Select(s2 => s2.Trim()).Where(s2 => !string.IsNullOrEmpty(s2)).ToList();
                if (serialList.Count != qty)
                {
                    MessageBox.Show($"Số lượng serial ({serialList.Count}) không khớp số lượng nhập ({qty})!",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Thêm vào giỏ hoặc cộng dồn nếu đã có
            var existing = _cart.FirstOrDefault(c => c.ProductID == selected.ProductID);
            if (existing != null)
            {
                existing.Quantity += qty;
                existing.UnitCost = cost;
                if (!string.IsNullOrEmpty(serials))
                    existing.Serials = string.IsNullOrEmpty(existing.Serials)
                        ? serials : existing.Serials + "," + serials;
            }
            else
            {
                _cart.Add(new CartItem
                {
                    ProductID = selected.ProductID,
                    ProductCode = selected.ProductCode,
                    ProductName = selected.ProductName,
                    Quantity = qty,
                    UnitCost = cost,
                    Serials = serials
                });
            }

            RefreshGrid();
            dlg.Close();
        };

        dlg.ShowDialog();
    }

    // ── Xác nhận nhập kho → lưu DB ──────────────────────────────────────────
    private void btn_confirmReceipt_Click(object sender, EventArgs e)
    {
        if (_cart.Count == 0)
        {
            MessageBox.Show("Phiếu nhập đang trống!", "Cảnh báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        if (cb_suppliers.SelectedValue is not int supplierID)
        {
            MessageBox.Show("Vui lòng chọn nhà cung cấp!", "Cảnh báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var confirm = MessageBox.Show(
            $"Xác nhận nhập {_cart.Sum(x => x.Quantity)} sản phẩm từ {cb_suppliers.Text}?\n" +
            $"Tổng tiền: {_cart.Sum(x => x.TotalCost):N0} đ",
            "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (confirm != DialogResult.Yes) return;

        // Tạo receipt DTO
        var receipt = new InboundReceiptsDTO
        {
            InboundCode = txt_receiptCode.Text,
            SupplierID = supplierID,
            UserID = BUS.CurrentUser.UserID,
            TotalQuantity = _cart.Sum(x => x.Quantity),
            TotalAmount = _cart.Sum(x => x.TotalCost),
            ReceiptDate = DateTime.Now
        };

        // Tạo details DTO
        var details = _cart.Select(c => new InboundDetailsDTO
        {
            ProductID = c.ProductID,
            Quantity = c.Quantity,
            UnitCost = c.UnitCost,
            TotalCost = c.TotalCost
        }).ToList();

        // Gom tất cả serial codes
        var allSerials = _cart
            .Where(c => !string.IsNullOrEmpty(c.Serials))
            .SelectMany(c => c.Serials.Split(',')
                .Select(s => s.Trim())
                .Where(s => !string.IsNullOrEmpty(s)))
            .ToList();

        // ProductID cho serials: lấy productID đầu tiên có serial
        int pidForSerial = _cart.FirstOrDefault(c => !string.IsNullOrEmpty(c.Serials))?.ProductID ?? 0;

        var (ok, err) = _inboundBUS.CreateReceipt(receipt, details, allSerials, pidForSerial);

        if (ok)
        {
            MessageBox.Show("✅ Nhập kho thành công! Đã lưu vào DB.", "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            lbl_bottomStatus.Text = $"Phiếu: {txt_receiptCode.Text} — Đã xác nhận";
            _cart.Clear();
            RefreshGrid();
            ToggleState(false);
            txt_receiptCode.Text = GenerateReceiptCode();
        }
        else
        {
            MessageBox.Show($"❌ Lỗi: {err}", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // ── Hủy phiếu ────────────────────────────────────────────────────────────
    private void btn_cancelReceipt_Click(object sender, EventArgs e)
    {
        if (_cart.Count > 0)
        {
            var confirm = MessageBox.Show("Hủy phiếu nhập hiện tại?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;
        }
        _cart.Clear();
        RefreshGrid();
        lbl_bottomStatus.Text = $"Phiếu: {txt_receiptCode.Text} — Đã hủy";
        ToggleState(false);
    }

    // ── Lịch sử nhập kho ─────────────────────────────────────────────────────
    private void btn_history_Click(object sender, EventArgs e)
    {
        var receipts = _inboundBUS.GetAll();
        if (receipts == null || receipts.Count == 0)
        {
            MessageBox.Show("Chưa có phiếu nhập nào.", "Lịch sử nhập");
            return;
        }

        using var dlg = new Form
        {
            Text = "Lịch sử nhập kho",
            Size = new System.Drawing.Size(800, 500),
            StartPosition = FormStartPosition.CenterParent
        };
        var dgv = new DataGridView
        {
            Dock = DockStyle.Fill,
            ReadOnly = true,
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
            AllowUserToAddRows = false,
            RowHeadersVisible = false
        };
        dgv.DataSource = receipts;
        dlg.Controls.Add(dgv);
        dlg.ShowDialog();
    }

    // ── Helpers ───────────────────────────────────────────────────────────────
    private void RefreshGrid()
    {
        dgv_details.DataSource = null;
        dgv_details.DataSource = _cart;
        lbl_totalQty.Text = $"Tổng SL: {_cart.Sum(x => x.Quantity)}";
        lbl_totalAmount.Text = $"Tổng tiền: {_cart.Sum(x => x.TotalCost):N0} đ";
        lbl_bottomNcc.Text = $"NCC: {cb_suppliers.Text}";
    }

    private static string GenerateReceiptCode()
        => "PN" + DateTime.Now.ToString("yyyyMMddHHmmss");
}