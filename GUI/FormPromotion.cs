using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormPromotion : Form
    {
        public FormPromotion()
        {
            InitializeComponent();

            // Đăng ký các sự kiện (Events) cho nút bấm nếu chưa đăng ký bên Designer
            btn_Add.Click += new EventHandler(btn_Add_Click);
            btn_Update.Click += new EventHandler(btn_Update_Click);
            btn_Delete.Click += new EventHandler(btn_Delete_Click);
        }

        private void FormPromotion_Load(object sender, EventArgs e)
        {
            // Code load dữ liệu từ Database lên dgv_Promotion khi mở Form
            // Ví dụ: dgv_Promotion.DataSource = promotionBUS.GetAll();
        }

        // ==========================================
        // 1. CHỨC NĂNG THÊM (Add)
        // ==========================================
        private void btn_Add_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào cơ bản
            if (string.IsNullOrWhiteSpace(txt_PromotionID.Text) || string.IsNullOrWhiteSpace(txt_PromotionName.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã Khuyến Mãi và Tên Chương Trình!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dt_Start.Value > dt_End.Value)
            {
                MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: Viết code Insert vào Database ở đây
            // Ví dụ: promotionBUS.Insert(txt_PromotionID.Text, txt_PromotionName.Text, num_Discount.Value, dt_Start.Value, dt_End.Value);

            // Hiển thị tạm lên DataGridView (Nếu không dùng DataSource)
            dgv_Promotion.Rows.Add(
                txt_PromotionID.Text,
                txt_PromotionName.Text,
                num_Discount.Value,
                dt_Start.Value.ToString("dd/MM/yyyy"),
                dt_End.Value.ToString("dd/MM/yyyy")
            );

            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
        }

        // ==========================================
        // 2. CHỨC NĂNG SỬA (Update)
        // ==========================================
        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (dgv_Promotion.CurrentRow == null || dgv_Promotion.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Vui lòng chọn một chương trình khuyến mãi để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: Viết code Update vào Database ở đây dựa vào txt_PromotionID.Text

            // Cập nhật lại thông tin trên lưới DataGridView
            DataGridViewRow row = dgv_Promotion.CurrentRow;
            row.Cells[0].Value = txt_PromotionID.Text;
            row.Cells[1].Value = txt_PromotionName.Text;
            row.Cells[2].Value = num_Discount.Value;
            row.Cells[3].Value = dt_Start.Value.ToString("dd/MM/yyyy");
            row.Cells[4].Value = dt_End.Value.ToString("dd/MM/yyyy");

            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ==========================================
        // 3. CHỨC NĂNG XÓA (Delete)
        // ==========================================
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_Promotion.CurrentRow == null || dgv_Promotion.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Vui lòng chọn một chương trình khuyến mãi để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa khuyến mãi này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                // TODO: Viết code Delete khỏi Database ở đây dựa vào txt_PromotionID.Text

                // Xóa dòng đang chọn trên DataGridView
                dgv_Promotion.Rows.RemoveAt(dgv_Promotion.CurrentRow.Index);

                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
        }

        // ==========================================
        // 4. SỰ KIỆN CLICK VÀO DATAGRIDVIEW 
        // (Đẩy dữ liệu từ dòng được chọn lên các TextBox phía trên)
        // ==========================================
        private void dgv_Promotion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Đảm bảo click vào dòng hợp lệ
            if (e.RowIndex >= 0 && e.RowIndex < dgv_Promotion.Rows.Count - 1)
            {
                DataGridViewRow row = dgv_Promotion.Rows[e.RowIndex];

                txt_PromotionID.Text = row.Cells[0].Value?.ToString();
                txt_PromotionName.Text = row.Cells[1].Value?.ToString();

                if (decimal.TryParse(row.Cells[2].Value?.ToString(), out decimal discount))
                    num_Discount.Value = discount;

                if (DateTime.TryParse(row.Cells[3].Value?.ToString(), out DateTime startDate))
                    dt_Start.Value = startDate;

                if (DateTime.TryParse(row.Cells[4].Value?.ToString(), out DateTime endDate))
                    dt_End.Value = endDate;
            }
        }

        // ==========================================
        // Hàm hỗ trợ: Xóa trắng các ô nhập liệu sau khi thao tác xong
        // ==========================================
        private void ClearFields()
        {
            txt_PromotionID.Clear();
            txt_PromotionName.Clear();
            num_Discount.Value = 0;
            dt_Start.Value = DateTime.Now;
            dt_End.Value = DateTime.Now;
            txt_PromotionID.Focus();
        }
    }
}