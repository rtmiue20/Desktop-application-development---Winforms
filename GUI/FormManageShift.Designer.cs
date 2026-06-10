namespace GUI
{
    partial class FormManageShift
    {
        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            grp_Action = new GroupBox();
            btn_shiftHistory = new Button();
            btn_shiftStop = new Button();
            btn_shiftOpen = new Button();
            grp_CurrentShift = new GroupBox();
            lbl_resStatus = new Label();
            lbl_shiftStatus = new Label();
            lbl_resMoney = new Label();
            lbl_shiftStartMoney = new Label();
            lbl_resTime = new Label();
            lbl_shiftOpenTime = new Label();
            grp_ListShift = new GroupBox();
            dgv_listShift = new DataGridView();
            col_maCa = new DataGridViewTextBoxColumn();
            col_nhanVien = new DataGridViewTextBoxColumn();
            col_trangThai = new DataGridViewTextBoxColumn();
            col_moLuc = new DataGridViewTextBoxColumn();
            col_dongLuc = new DataGridViewTextBoxColumn();
            col_tienDauca = new DataGridViewTextBoxColumn();
            col_tienCuoica = new DataGridViewTextBoxColumn();
            col_chenhLech = new DataGridViewTextBoxColumn();
            col_ghiChu = new DataGridViewTextBoxColumn();
            grp_Action.SuspendLayout();
            grp_CurrentShift.SuspendLayout();
            grp_ListShift.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_listShift).BeginInit();
            SuspendLayout();
            // 
            // grp_Action
            // 
            grp_Action.BackColor = Color.WhiteSmoke;
            grp_Action.Controls.Add(btn_shiftHistory);
            grp_Action.Controls.Add(btn_shiftStop);
            grp_Action.Controls.Add(btn_shiftOpen);
            grp_Action.Dock = DockStyle.Top;
            grp_Action.Font = new Font("Segoe UI", 10.2F);
            grp_Action.Location = new Point(0, 0);
            grp_Action.Margin = new Padding(6, 6, 6, 6);
            grp_Action.Name = "grp_Action";
            grp_Action.Padding = new Padding(6, 6, 6, 6);
            grp_Action.Size = new Size(2237, 145);
            grp_Action.TabIndex = 0;
            grp_Action.TabStop = false;
            grp_Action.Text = "Chức năng Ca làm việc";
            // 
            // btn_shiftHistory
            // 
            btn_shiftHistory.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btn_shiftHistory.Location = new Point(765, 58);
            btn_shiftHistory.Margin = new Padding(6, 6, 6, 6);
            btn_shiftHistory.Name = "btn_shiftHistory";
            btn_shiftHistory.Size = new Size(361, 62);
            btn_shiftHistory.TabIndex = 2;
            btn_shiftHistory.Text = "🔄 Làm mới";
            btn_shiftHistory.UseVisualStyleBackColor = true;
            btn_shiftHistory.Click += btn_shiftHistory_Click;
            // 
            // btn_shiftStop
            // 
            btn_shiftStop.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btn_shiftStop.Location = new Point(392, 58);
            btn_shiftStop.Margin = new Padding(6, 6, 6, 6);
            btn_shiftStop.Name = "btn_shiftStop";
            btn_shiftStop.Size = new Size(361, 62);
            btn_shiftStop.TabIndex = 1;
            btn_shiftStop.Text = "🔒 Chốt Ca";
            btn_shiftStop.UseVisualStyleBackColor = true;
            btn_shiftStop.Click += btn_shiftStop_Click;
            // 
            // btn_shiftOpen
            // 
            btn_shiftOpen.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btn_shiftOpen.Location = new Point(21, 58);
            btn_shiftOpen.Margin = new Padding(6, 6, 6, 6);
            btn_shiftOpen.Name = "btn_shiftOpen";
            btn_shiftOpen.Size = new Size(350, 62);
            btn_shiftOpen.TabIndex = 0;
            btn_shiftOpen.Text = "🔓 Mở Ca";
            btn_shiftOpen.UseVisualStyleBackColor = true;
            btn_shiftOpen.Click += btn_shiftOpen_Click;
            // 
            // grp_CurrentShift
            // 
            grp_CurrentShift.BackColor = Color.White;
            grp_CurrentShift.Controls.Add(lbl_resStatus);
            grp_CurrentShift.Controls.Add(lbl_shiftStatus);
            grp_CurrentShift.Controls.Add(lbl_resMoney);
            grp_CurrentShift.Controls.Add(lbl_shiftStartMoney);
            grp_CurrentShift.Controls.Add(lbl_resTime);
            grp_CurrentShift.Controls.Add(lbl_shiftOpenTime);
            grp_CurrentShift.Dock = DockStyle.Top;
            grp_CurrentShift.Font = new Font("Segoe UI", 10.2F);
            grp_CurrentShift.Location = new Point(0, 145);
            grp_CurrentShift.Margin = new Padding(6, 6, 6, 6);
            grp_CurrentShift.Name = "grp_CurrentShift";
            grp_CurrentShift.Padding = new Padding(6, 6, 6, 6);
            grp_CurrentShift.Size = new Size(2237, 194);
            grp_CurrentShift.TabIndex = 1;
            grp_CurrentShift.TabStop = false;
            grp_CurrentShift.Text = "Thông tin Ca hiện tại";
            // 
            // lbl_resStatus
            // 
            lbl_resStatus.AutoSize = true;
            lbl_resStatus.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lbl_resStatus.ForeColor = Color.ForestGreen;
            lbl_resStatus.Location = new Point(287, 92);
            lbl_resStatus.Margin = new Padding(6, 0, 6, 0);
            lbl_resStatus.Name = "lbl_resStatus";
            lbl_resStatus.Size = new Size(305, 74);
            lbl_resStatus.TabIndex = 5;
            lbl_resStatus.Text = "ĐANG MỞ";
            // 
            // lbl_shiftStatus
            // 
            lbl_shiftStatus.AutoSize = true;
            lbl_shiftStatus.Location = new Point(42, 113);
            lbl_shiftStatus.Margin = new Padding(6, 0, 6, 0);
            lbl_shiftStatus.Name = "lbl_shiftStatus";
            lbl_shiftStatus.Size = new Size(175, 46);
            lbl_shiftStatus.TabIndex = 4;
            lbl_shiftStatus.Text = "Trạng thái:";
            // 
            // lbl_resMoney
            // 
            lbl_resMoney.AutoSize = true;
            lbl_resMoney.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lbl_resMoney.ForeColor = SystemColors.HotTrack;
            lbl_resMoney.Location = new Point(1955, 102);
            lbl_resMoney.Margin = new Padding(6, 0, 6, 0);
            lbl_resMoney.Name = "lbl_resMoney";
            lbl_resMoney.Size = new Size(95, 62);
            lbl_resMoney.TabIndex = 3;
            lbl_resMoney.Text = "0 đ";
            // 
            // lbl_shiftStartMoney
            // 
            lbl_shiftStartMoney.AutoSize = true;
            lbl_shiftStartMoney.Location = new Point(1572, 113);
            lbl_shiftStartMoney.Margin = new Padding(6, 0, 6, 0);
            lbl_shiftStartMoney.Name = "lbl_shiftStartMoney";
            lbl_shiftStartMoney.Size = new Size(303, 46);
            lbl_shiftStartMoney.TabIndex = 2;
            lbl_shiftStartMoney.Text = "Tiền mặt quầy đầu:";
            // 
            // lbl_resTime
            // 
            lbl_resTime.AutoSize = true;
            lbl_resTime.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_resTime.Location = new Point(1041, 107);
            lbl_resTime.Margin = new Padding(6, 0, 6, 0);
            lbl_resTime.Name = "lbl_resTime";
            lbl_resTime.Size = new Size(316, 54);
            lbl_resTime.TabIndex = 1;
            lbl_resTime.Text = "--/--/---- --:--:--";
            // 
            // lbl_shiftOpenTime
            // 
            lbl_shiftOpenTime.AutoSize = true;
            lbl_shiftOpenTime.Location = new Point(808, 113);
            lbl_shiftOpenTime.Margin = new Padding(6, 0, 6, 0);
            lbl_shiftOpenTime.Name = "lbl_shiftOpenTime";
            lbl_shiftOpenTime.Size = new Size(178, 46);
            lbl_shiftOpenTime.TabIndex = 0;
            lbl_shiftOpenTime.Text = "Giờ mở ca:";
            // 
            // grp_ListShift
            // 
            grp_ListShift.Controls.Add(dgv_listShift);
            grp_ListShift.Dock = DockStyle.Fill;
            grp_ListShift.Font = new Font("Segoe UI", 10.2F);
            grp_ListShift.Location = new Point(0, 339);
            grp_ListShift.Margin = new Padding(6, 6, 6, 6);
            grp_ListShift.Name = "grp_ListShift";
            grp_ListShift.Padding = new Padding(21, 20, 21, 20);
            grp_ListShift.Size = new Size(2237, 888);
            grp_ListShift.TabIndex = 2;
            grp_ListShift.TabStop = false;
            grp_ListShift.Text = "Lịch sử giao ca";
            // 
            // dgv_listShift
            // 
            dgv_listShift.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dgv_listShift.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_listShift.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_listShift.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Gainsboro;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_listShift.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_listShift.ColumnHeadersHeight = 45;
            dgv_listShift.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv_listShift.Columns.AddRange(new DataGridViewColumn[] { col_maCa, col_nhanVien, col_trangThai, col_moLuc, col_dongLuc, col_tienDauca, col_tienCuoica, col_chenhLech, col_ghiChu });
            dgv_listShift.Dock = DockStyle.Fill;
            dgv_listShift.Location = new Point(21, 66);
            dgv_listShift.Margin = new Padding(6, 6, 6, 6);
            dgv_listShift.Name = "dgv_listShift";
            dgv_listShift.ReadOnly = true;
            dgv_listShift.RowHeadersVisible = false;
            dgv_listShift.RowHeadersWidth = 51;
            dgv_listShift.RowTemplate.Height = 35;
            dgv_listShift.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_listShift.Size = new Size(2195, 802);
            dgv_listShift.TabIndex = 0;
            dgv_listShift.DataBindingComplete += dgv_listShift_DataBindingComplete;
            // 
            // col_maCa
            // 
            col_maCa.DataPropertyName = "ShiftCode";
            col_maCa.FillWeight = 12F;
            col_maCa.HeaderText = "Mã Ca";
            col_maCa.MinimumWidth = 12;
            col_maCa.Name = "col_maCa";
            col_maCa.ReadOnly = true;
            // 
            // col_nhanVien
            // 
            col_nhanVien.DataPropertyName = "UserID";
            col_nhanVien.FillWeight = 8F;
            col_nhanVien.HeaderText = "Mã NV";
            col_nhanVien.MinimumWidth = 12;
            col_nhanVien.Name = "col_nhanVien";
            col_nhanVien.ReadOnly = true;
            // 
            // col_trangThai
            // 
            col_trangThai.DataPropertyName = "Status";
            col_trangThai.FillWeight = 10F;
            col_trangThai.HeaderText = "Trạng Thái";
            col_trangThai.MinimumWidth = 12;
            col_trangThai.Name = "col_trangThai";
            col_trangThai.ReadOnly = true;
            // 
            // col_moLuc
            // 
            col_moLuc.DataPropertyName = "StartTime";
            col_moLuc.FillWeight = 12F;
            col_moLuc.HeaderText = "Mở Lúc";
            col_moLuc.MinimumWidth = 12;
            col_moLuc.Name = "col_moLuc";
            col_moLuc.ReadOnly = true;
            // 
            // col_dongLuc
            // 
            col_dongLuc.DataPropertyName = "EndTime";
            col_dongLuc.FillWeight = 12F;
            col_dongLuc.HeaderText = "Đóng Lúc";
            col_dongLuc.MinimumWidth = 12;
            col_dongLuc.Name = "col_dongLuc";
            col_dongLuc.ReadOnly = true;
            // 
            // col_tienDauca
            // 
            col_tienDauca.DataPropertyName = "OpeningCash";
            col_tienDauca.FillWeight = 12F;
            col_tienDauca.HeaderText = "Tiền Đầu Ca";
            col_tienDauca.MinimumWidth = 12;
            col_tienDauca.Name = "col_tienDauca";
            col_tienDauca.ReadOnly = true;
            // 
            // col_tienCuoica
            // 
            col_tienCuoica.DataPropertyName = "ClosingCash";
            col_tienCuoica.FillWeight = 14F;
            col_tienCuoica.HeaderText = "Tiền Thực Tế (Cuối)";
            col_tienCuoica.MinimumWidth = 12;
            col_tienCuoica.Name = "col_tienCuoica";
            col_tienCuoica.ReadOnly = true;
            // 
            // col_chenhLech
            // 
            col_chenhLech.DataPropertyName = "DifferenceAmount";
            col_chenhLech.FillWeight = 10F;
            col_chenhLech.HeaderText = "Chênh Lệch";
            col_chenhLech.MinimumWidth = 12;
            col_chenhLech.Name = "col_chenhLech";
            col_chenhLech.ReadOnly = true;
            // 
            // col_ghiChu
            // 
            col_ghiChu.DataPropertyName = "DifferenceNote";
            col_ghiChu.FillWeight = 15F;
            col_ghiChu.HeaderText = "Ghi Chú";
            col_ghiChu.MinimumWidth = 12;
            col_ghiChu.Name = "col_ghiChu";
            col_ghiChu.ReadOnly = true;
            // 
            // FormManageShift
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(2237, 1227);
            Controls.Add(grp_ListShift);
            Controls.Add(grp_CurrentShift);
            Controls.Add(grp_Action);
            Margin = new Padding(6, 6, 6, 6);
            Name = "FormManageShift";
            Text = "Quản lý Ca làm việc & Quỹ đầu ngày";
            Load += FormManageShift_Load;
            grp_Action.ResumeLayout(false);
            grp_CurrentShift.ResumeLayout(false);
            grp_CurrentShift.PerformLayout();
            grp_ListShift.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_listShift).EndInit();
            ResumeLayout(false);


        }


        #endregion


        private System.Windows.Forms.GroupBox grp_Action;
        private System.Windows.Forms.Button btn_shiftHistory;
        private System.Windows.Forms.Button btn_shiftStop;
        private System.Windows.Forms.Button btn_shiftOpen;
        private System.Windows.Forms.GroupBox grp_CurrentShift;
        private System.Windows.Forms.Label lbl_resStatus;
        private System.Windows.Forms.Label lbl_shiftStatus;
        private System.Windows.Forms.Label lbl_resMoney;
        private System.Windows.Forms.Label lbl_shiftStartMoney;
        private System.Windows.Forms.Label lbl_resTime;
        private System.Windows.Forms.Label lbl_shiftOpenTime;
        private System.Windows.Forms.GroupBox grp_ListShift;
        private System.Windows.Forms.DataGridView dgv_listShift;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_maCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_trangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_moLuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dongLuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tienDauca;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tienCuoica;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_chenhLech;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ghiChu;
    }
}


