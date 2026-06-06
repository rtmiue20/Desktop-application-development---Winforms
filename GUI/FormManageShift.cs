using System;
using System.Drawing;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Desktop_Application_Development
{
    public partial class FormManageShift : Form
    {
        private readonly ShiftsBUS _shiftsBUS = new ShiftsBUS();

        // Controls
        private Label lblStatus;
        private Label lblShiftCode;
        private Label lblStartTime;
        private Label lblOpeningCash;
        private TextBox txtOpeningCash;
        private TextBox txtClosingCash;
        private TextBox txtNote;
        private Button btnOpenShift;
        private Button btnCloseShift;
        private Button btnRefresh;
        private DataGridView dgvShifts;

        public FormManageShift()
        {
            InitializeComponent();
            BuildUI();
            LoadCurrentShift();
        }

        private void BuildUI()
        {
            this.Text = "Ca làm việc";
            this.Size = new Size(900, 620);
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = Color.WhiteSmoke;

            // ===== PANEL CA HIỆN TẠI =====
            var pnlCurrent = new Panel
            {
                Location = new Point(20, 20),
                Size = new Size(420, 330),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };
            this.Controls.Add(pnlCurrent);

            pnlCurrent.Controls.Add(new Label
            {
                Text = "CA HIỆN TẠI",
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = Color.DarkBlue,
                Location = new Point(10, 10),
                AutoSize = true
            });

            lblStatus = new Label { Text = "Trạng thái: ---", Font = new Font("Segoe UI", 10), Location = new Point(10, 45), AutoSize = true };
            lblShiftCode = new Label { Text = "Mã ca: ---", Font = new Font("Segoe UI", 10), Location = new Point(10, 75), AutoSize = true };
            lblStartTime = new Label { Text = "Giờ mở: ---", Font = new Font("Segoe UI", 10), Location = new Point(10, 105), AutoSize = true };
            lblOpeningCash = new Label { Text = "Tiền đầu ca: ---", Font = new Font("Segoe UI", 10), Location = new Point(10, 135), AutoSize = true };
            pnlCurrent.Controls.AddRange(new Control[] { lblStatus, lblShiftCode, lblStartTime, lblOpeningCash });

            pnlCurrent.Controls.Add(new Label { Text = "Tiền đầu ca (đ):", Font = new Font("Segoe UI", 9), Location = new Point(10, 175), AutoSize = true });
            txtOpeningCash = new TextBox { Location = new Point(10, 195), Size = new Size(200, 28), Font = new Font("Segoe UI", 10), PlaceholderText = "Nhập tiền đầu ca..." };
            pnlCurrent.Controls.Add(txtOpeningCash);

            btnOpenShift = new Button
            {
                Text = "Mở ca", Location = new Point(220, 193), Size = new Size(100, 32),
                BackColor = Color.MediumSeaGreen, ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };
            btnOpenShift.FlatAppearance.BorderSize = 0;
            btnOpenShift.Click += btnOpenShift_Click;
            pnlCurrent.Controls.Add(btnOpenShift);

            pnlCurrent.Controls.Add(new Label { Text = "Tiền thực tế (đ):", Font = new Font("Segoe UI", 9), Location = new Point(10, 235), AutoSize = true });
            txtClosingCash = new TextBox { Location = new Point(10, 255), Size = new Size(200, 28), Font = new Font("Segoe UI", 10), PlaceholderText = "Nhập tiền thực tế..." };
            pnlCurrent.Controls.Add(txtClosingCash);

            pnlCurrent.Controls.Add(new Label { Text = "Ghi chú:", Font = new Font("Segoe UI", 9), Location = new Point(10, 290), AutoSize = true });
            txtNote = new TextBox { Location = new Point(80, 288), Size = new Size(130, 28), Font = new Font("Segoe UI", 10) };
            pnlCurrent.Controls.Add(txtNote);

            btnCloseShift = new Button
            {
                Text = "Chốt ca", Location = new Point(220, 253), Size = new Size(100, 32),
                BackColor = Color.Tomato, ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };
            btnCloseShift.FlatAppearance.BorderSize = 0;
            btnCloseShift.Click += btnCloseShift_Click;
            pnlCurrent.Controls.Add(btnCloseShift);

            // ===== PANEL LỊCH SỬ =====
            var pnlHistory = new Panel
            {
                Location = new Point(460, 20),
                Size = new Size(400, 560),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };
            this.Controls.Add(pnlHistory);

            pnlHistory.Controls.Add(new Label
            {
                Text = "LỊCH SỬ CA",
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = Color.DarkBlue,
                Location = new Point(10, 10),
                AutoSize = true
            });

            btnRefresh = new Button
            {
                Text = "Làm mới", Location = new Point(285, 5), Size = new Size(100, 30),
                BackColor = Color.SteelBlue, ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 9)
            };
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.Click += btnRefresh_Click;
            pnlHistory.Controls.Add(btnRefresh);

            dgvShifts = new DataGridView
            {
                Location = new Point(5, 45), Size = new Size(388, 505),
                ReadOnly = true, AllowUserToAddRows = false,
                BackgroundColor = Color.White, BorderStyle = BorderStyle.None,
                RowHeadersVisible = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                Font = new Font("Segoe UI", 9),
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };
            dgvShifts.Columns.Add("ShiftCode", "Mã ca");
            dgvShifts.Columns.Add("StartTime", "Giờ mở");
            dgvShifts.Columns.Add("EndTime", "Giờ chốt");
            dgvShifts.Columns.Add("OpeningCash", "Đầu ca");
            dgvShifts.Columns.Add("ClosingCash", "Thực tế");
            dgvShifts.Columns.Add("DifferenceAmount", "Chênh lệch");
            dgvShifts.Columns.Add("Status", "Trạng thái");
            pnlHistory.Controls.Add(dgvShifts);
        }

        private void LoadCurrentShift()
        {
            var shift = _shiftsBUS.GetOpenShift(CurrentUser.UserID);

            if (shift != null)
            {
                lblStatus.Text = "Trạng thái: Đang mở ca";
                lblStatus.ForeColor = Color.Green;
                lblShiftCode.Text = "Mã ca: " + shift.ShiftCode;
                lblStartTime.Text = "Giờ mở: " + shift.StartTime.ToString("dd/MM/yyyy HH:mm:ss");
                lblOpeningCash.Text = "Tiền đầu ca: " + shift.OpeningCash.ToString("N0") + " đ";
                btnOpenShift.Enabled = false;
                btnCloseShift.Enabled = true;
                txtOpeningCash.Enabled = false;
                txtClosingCash.Enabled = true;
                txtNote.Enabled = true;
            }
            else
            {
                lblStatus.Text = "Trạng thái: Chưa mở ca";
                lblStatus.ForeColor = Color.Red;
                lblShiftCode.Text = "Mã ca: ---";
                lblStartTime.Text = "Giờ mở: ---";
                lblOpeningCash.Text = "Tiền đầu ca: ---";
                btnOpenShift.Enabled = true;
                btnCloseShift.Enabled = false;
                txtOpeningCash.Enabled = true;
                txtClosingCash.Enabled = false;
                txtNote.Enabled = false;
            }
        }

        private void btnOpenShift_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtOpeningCash.Text.Replace(",", "").Trim(), out decimal openingCash) || openingCash < 0)
            {
                MessageBox.Show("Vui lòng nhập tiền đầu ca hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var (success, error) = _shiftsBUS.OpenShift(openingCash);
            if (success)
            {
                MessageBox.Show("Mở ca thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtOpeningCash.Text = "";
                LoadCurrentShift();
            }
            else
            {
                MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCloseShift_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtClosingCash.Text.Replace(",", "").Trim(), out decimal closingCash) || closingCash < 0)
            {
                MessageBox.Show("Vui lòng nhập tiền thực tế hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var confirm = MessageBox.Show("Bạn có chắc muốn chốt ca này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            var (success, error) = _shiftsBUS.CloseShift(closingCash, txtNote.Text.Trim());
            if (success)
            {
                MessageBox.Show("Chốt ca thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtClosingCash.Text = "";
                txtNote.Text = "";
                LoadCurrentShift();
            }
            else
            {
                MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCurrentShift();
        }
    }
}