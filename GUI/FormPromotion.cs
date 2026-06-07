using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormPromotion : Form
    {
        public FormPromotion()
        {
            InitializeComponent();
        }

        // ===========================
        // FORM LOAD
        // ===========================
        private void FormPromotion_Load(object sender, EventArgs e)
        {
            // Gắn sự kiện cho các nút
            btn_createPromotion.Click += btn_CreatePromotion_Click;
            btn_save.Click += btn_Save_Click;
            btn_edit.Click += btn_Edit_Click;
            btn_disablePromotion.Click += btn_DisablePromotion_Click;
            btn_refresh.Click += btn_Refresh_Click;

            // Sự kiện chọn dòng DataGridView
            dgv_guest.CellClick += dgv_Guest_CellClick;
        }

        // ==================================================
        // NÚT + TẠO KHUYẾN MÃI
        // Xóa dữ liệu đang nhập để tạo mới
        // ==================================================
        private void btn_CreatePromotion_Click(object sender, EventArgs e)
        {
            txt_promotionCode.Clear();
            txt_description.Clear();
            txt_discountValue.Clear();

            dtp_startDate.Value = DateTime.Now;
            dtp_endDate.Value = DateTime.Now.AddDays(7);

            txt_promotionCode.Focus();
        }

        // ==================================================
        // NÚT LƯU
        // Thêm khuyến mãi vào DataGridView
        // ==================================================
        private void btn_Save_Click(object sender, EventArgs e)
        {
            // Kiểm tra mã KM
            if (string.IsNullOrWhiteSpace(txt_promotionCode.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập mã khuyến mãi!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string discountPercent = "";
            string discountAmount = "";

            // Phân biệt giảm % và giảm tiền
            if (decimal.TryParse(txt_discountValue.Text, out decimal value))
            {
                if (value <= 100)
                {
                    discountPercent = value + "%";
                }
                else
                {
                    discountAmount = value.ToString("N0");
                }
            }

            dgv_guest.Rows.Add(
                txt_promotionCode.Text,
                txt_description.Text,
                discountPercent,
                discountAmount,
                dtp_startDate.Value.ToShortDateString(),
                dtp_endDate.Value.ToShortDateString(),
                "Đang hoạt động"
            );

            MessageBox.Show(
                "Lưu khuyến mãi thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // ==================================================
        // NÚT SỬA
        // Cập nhật dòng đang chọn
        // ==================================================
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dgv_guest.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn khuyến mãi cần sửa!");
                return;
            }

            DataGridViewRow row = dgv_guest.CurrentRow;

            row.Cells["col_PromotionCode"].Value =
                txt_promotionCode.Text;

            row.Cells["col_Description"].Value =
                txt_description.Text;

            if (decimal.TryParse(txt_discountValue.Text, out decimal value))
            {
                if (value <= 100)
                {
                    row.Cells["col_DiscountPercentage"].Value =
                        value + "%";

                    row.Cells["col_DiscountAmount"].Value = "";
                }
                else
                {
                    row.Cells["col_DiscountPercentage"].Value = "";

                    row.Cells["col_DiscountAmount"].Value =
                        value.ToString("N0");
                }
            }

            row.Cells["col_StartDate"].Value =
                dtp_startDate.Value.ToShortDateString();

            row.Cells["col_EndDate"].Value =
                dtp_endDate.Value.ToShortDateString();

            MessageBox.Show(
                "Cập nhật thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // ==================================================
        // NÚT TẮT KHUYẾN MÃI
        // Chuyển trạng thái sang ngừng hoạt động
        // ==================================================
        private void btn_DisablePromotion_Click(object sender, EventArgs e)
        {
            if (dgv_guest.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn khuyến mãi!");
                return;
            }

            dgv_guest.CurrentRow.Cells["col_Status"].Value =
                "Ngừng hoạt động";

            MessageBox.Show(
                "Khuyến mãi đã được tắt!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // ==================================================
        // NÚT LÀM MỚI
        // Reset form nhập liệu
        // ==================================================
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            txt_promotionCode.Clear();
            txt_description.Clear();
            txt_discountValue.Clear();

            dtp_startDate.Value = DateTime.Now;
            dtp_endDate.Value = DateTime.Now;

            dgv_guest.ClearSelection();
        }

        // ==================================================
        // CLICK DÒNG TRONG DATAGRIDVIEW
        // Đổ dữ liệu lên form bên phải
        // ==================================================
        private void dgv_Guest_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row =
                dgv_guest.Rows[e.RowIndex];

            txt_promotionCode.Text =
                row.Cells["col_PromotionCode"].Value?.ToString();

            txt_description.Text =
                row.Cells["col_Description"].Value?.ToString();

            string percent =
                row.Cells["col_DiscountPercentage"].Value?.ToString();

            string amount =
                row.Cells["col_DiscountAmount"].Value?.ToString();

            if (!string.IsNullOrEmpty(percent))
            {
                txt_discountValue.Text =
                    percent.Replace("%", "");
            }
            else
            {
                txt_discountValue.Text = amount;
            }

            if (DateTime.TryParse(
                row.Cells["col_StartDate"].Value?.ToString(),
                out DateTime startDate))
            {
                dtp_startDate.Value = startDate;
            }

            if (DateTime.TryParse(
                row.Cells["col_EndDate"].Value?.ToString(),
                out DateTime endDate))
            {
                dtp_endDate.Value = endDate;
            }
        }

        // Không dùng nữa nhưng Designer đã tạo sẵn
        private void dgv_Guest_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_save_Click_1(object sender, EventArgs e)
        {

        }
    }
}