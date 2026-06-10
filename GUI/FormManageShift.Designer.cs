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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grp_Action = new System.Windows.Forms.GroupBox();
            this.btn_shiftHistory = new System.Windows.Forms.Button();
            this.btn_shiftStop = new System.Windows.Forms.Button();
            this.btn_shiftOpen = new System.Windows.Forms.Button();
            this.grp_CurrentShift = new System.Windows.Forms.GroupBox();
            this.lbl_resStatus = new System.Windows.Forms.Label();
            this.lbl_shiftStatus = new System.Windows.Forms.Label();
            this.lbl_resMoney = new System.Windows.Forms.Label();
            this.lbl_shiftStartMoney = new System.Windows.Forms.Label();
            this.lbl_resTime = new System.Windows.Forms.Label();
            this.lbl_shiftOpenTime = new System.Windows.Forms.Label();
            this.grp_ListShift = new System.Windows.Forms.GroupBox();
            this.dgv_listShift = new System.Windows.Forms.DataGridView();
            this.col_maCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_moLuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dongLuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tienDauca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tienCuoica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_chenhLech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ghiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_Action.SuspendLayout();
            this.grp_CurrentShift.SuspendLayout();
            this.grp_ListShift.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listShift)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_Action
            // 
            this.grp_Action.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grp_Action.Controls.Add(this.btn_shiftHistory);
            this.grp_Action.Controls.Add(this.btn_shiftStop);
            this.grp_Action.Controls.Add(this.btn_shiftOpen);
            this.grp_Action.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp_Action.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grp_Action.Location = new System.Drawing.Point(0, 0);
            this.grp_Action.Name = "grp_Action";
            this.grp_Action.Size = new System.Drawing.Size(1587, 100);
            this.grp_Action.TabIndex = 0;
            this.grp_Action.TabStop = false;
            this.grp_Action.Text = "Chức năng Ca làm việc";
            // 
            // btn_shiftHistory
            // 
            this.btn_shiftHistory.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_shiftHistory.Location = new System.Drawing.Point(400, 30);
            this.btn_shiftHistory.Name = "btn_shiftHistory";
            this.btn_shiftHistory.Size = new System.Drawing.Size(170, 50);
            this.btn_shiftHistory.TabIndex = 2;
            this.btn_shiftHistory.Text = "🔄 Làm mới";
            this.btn_shiftHistory.UseVisualStyleBackColor = true;
            this.btn_shiftHistory.Click += new System.EventHandler(this.btn_shiftHistory_Click);
            // 
            // btn_shiftStop
            // 
            this.btn_shiftStop.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_shiftStop.Location = new System.Drawing.Point(210, 30);
            this.btn_shiftStop.Name = "btn_shiftStop";
            this.btn_shiftStop.Size = new System.Drawing.Size(170, 50);
            this.btn_shiftStop.TabIndex = 1;
            this.btn_shiftStop.Text = "🔒 Chốt Ca";
            this.btn_shiftStop.UseVisualStyleBackColor = true;
            this.btn_shiftStop.Click += new System.EventHandler(this.btn_shiftStop_Click);
            // 
            // btn_shiftOpen
            // 
            this.btn_shiftOpen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_shiftOpen.Location = new System.Drawing.Point(20, 30);
            this.btn_shiftOpen.Name = "btn_shiftOpen";
            this.btn_shiftOpen.Size = new System.Drawing.Size(170, 50);
            this.btn_shiftOpen.TabIndex = 0;
            this.btn_shiftOpen.Text = "🔓 Mở Ca";
            this.btn_shiftOpen.UseVisualStyleBackColor = true;
            this.btn_shiftOpen.Click += new System.EventHandler(this.btn_shiftOpen_Click);
            // 
            // grp_CurrentShift
            // 
            this.grp_CurrentShift.BackColor = System.Drawing.Color.White;
            this.grp_CurrentShift.Controls.Add(this.lbl_resStatus);
            this.grp_CurrentShift.Controls.Add(this.lbl_shiftStatus);
            this.grp_CurrentShift.Controls.Add(this.lbl_resMoney);
            this.grp_CurrentShift.Controls.Add(this.lbl_shiftStartMoney);
            this.grp_CurrentShift.Controls.Add(this.lbl_resTime);
            this.grp_CurrentShift.Controls.Add(this.lbl_shiftOpenTime);
            this.grp_CurrentShift.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp_CurrentShift.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grp_CurrentShift.Location = new System.Drawing.Point(0, 100);
            this.grp_CurrentShift.Name = "grp_CurrentShift";
            this.grp_CurrentShift.Size = new System.Drawing.Size(1587, 120);
            this.grp_CurrentShift.TabIndex = 1;
            this.grp_CurrentShift.TabStop = false;
            this.grp_CurrentShift.Text = "Thông tin Ca hiện tại";
            // 
            // lbl_resStatus
            // 
            this.lbl_resStatus.AutoSize = true;
            this.lbl_resStatus.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_resStatus.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_resStatus.Location = new System.Drawing.Point(135, 45);
            this.lbl_resStatus.Name = "lbl_resStatus";
            this.lbl_resStatus.Size = new System.Drawing.Size(159, 38);
            this.lbl_resStatus.TabIndex = 5;
            this.lbl_resStatus.Text = "ĐANG MỞ";
            // 
            // lbl_shiftStatus
            // 
            this.lbl_shiftStatus.AutoSize = true;
            this.lbl_shiftStatus.Location = new System.Drawing.Point(20, 55);
            this.lbl_shiftStatus.Name = "lbl_shiftStatus";
            this.lbl_shiftStatus.Size = new System.Drawing.Size(91, 23);
            this.lbl_shiftStatus.TabIndex = 4;
            this.lbl_shiftStatus.Text = "Trạng thái:";
            // 
            // lbl_resMoney
            // 
            this.lbl_resMoney.AutoSize = true;
            this.lbl_resMoney.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_resMoney.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_resMoney.Location = new System.Drawing.Point(920, 50);
            this.lbl_resMoney.Name = "lbl_resMoney";
            this.lbl_resMoney.Size = new System.Drawing.Size(46, 31);
            this.lbl_resMoney.TabIndex = 3;
            this.lbl_resMoney.Text = "0 đ";
            // 
            // lbl_shiftStartMoney
            // 
            this.lbl_shiftStartMoney.AutoSize = true;
            this.lbl_shiftStartMoney.Location = new System.Drawing.Point(740, 55);
            this.lbl_shiftStartMoney.Name = "lbl_shiftStartMoney";
            this.lbl_shiftStartMoney.Size = new System.Drawing.Size(155, 23);
            this.lbl_shiftStartMoney.TabIndex = 2;
            this.lbl_shiftStartMoney.Text = "Tiền mặt quầy đầu:";
            // 
            // lbl_resTime
            // 
            this.lbl_resTime.AutoSize = true;
            this.lbl_resTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_resTime.Location = new System.Drawing.Point(490, 52);
            this.lbl_resTime.Name = "lbl_resTime";
            this.lbl_resTime.Size = new System.Drawing.Size(176, 28);
            this.lbl_resTime.TabIndex = 1;
            this.lbl_resTime.Text = "--/--/---- --:--:--";
            // 
            // lbl_shiftOpenTime
            // 
            this.lbl_shiftOpenTime.AutoSize = true;
            this.lbl_shiftOpenTime.Location = new System.Drawing.Point(380, 55);
            this.lbl_shiftOpenTime.Name = "lbl_shiftOpenTime";
            this.lbl_shiftOpenTime.Size = new System.Drawing.Size(95, 23);
            this.lbl_shiftOpenTime.TabIndex = 0;
            this.lbl_shiftOpenTime.Text = "Giờ mở ca:";
            // 
            // grp_ListShift
            // 
            this.grp_ListShift.Controls.Add(this.dgv_listShift);
            this.grp_ListShift.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_ListShift.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grp_ListShift.Location = new System.Drawing.Point(0, 220);
            this.grp_ListShift.Name = "grp_ListShift";
            this.grp_ListShift.Padding = new System.Windows.Forms.Padding(10);
            this.grp_ListShift.Size = new System.Drawing.Size(1587, 730);
            this.grp_ListShift.TabIndex = 2;
            this.grp_ListShift.TabStop = false;
            this.grp_ListShift.Text = "Lịch sử giao ca";
            // 
            // dgv_listShift
            // 
            this.dgv_listShift.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_listShift.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_listShift.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_listShift.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_listShift.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_listShift.ColumnHeadersHeight = 45;
            this.dgv_listShift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_listShift.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_maCa,
            this.col_nhanVien,
            this.col_trangThai,
            this.col_moLuc,
            this.col_dongLuc,
            this.col_tienDauca,
            this.col_tienCuoica,
            this.col_chenhLech,
            this.col_ghiChu});
            this.dgv_listShift.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_listShift.Location = new System.Drawing.Point(10, 33);
            this.dgv_listShift.Name = "dgv_listShift";
            this.dgv_listShift.ReadOnly = true;
            this.dgv_listShift.RowHeadersVisible = false;
            this.dgv_listShift.RowHeadersWidth = 51;
            this.dgv_listShift.RowTemplate.Height = 35;
            this.dgv_listShift.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listShift.Size = new System.Drawing.Size(1567, 687);
            this.dgv_listShift.TabIndex = 0;
            this.dgv_listShift.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_listShift_DataBindingComplete);
            // 
            // col_maCa
            // 
            this.col_maCa.DataPropertyName = "ShiftCode";
            this.col_maCa.HeaderText = "Mã Ca";
            this.col_maCa.Name = "col_maCa";
            this.col_maCa.ReadOnly = true;
            this.col_maCa.FillWeight = 12F;
            // 
            // col_nhanVien
            // 
            this.col_nhanVien.DataPropertyName = "UserID";
            this.col_nhanVien.HeaderText = "Mã NV";
            this.col_nhanVien.Name = "col_nhanVien";
            this.col_nhanVien.ReadOnly = true;
            this.col_nhanVien.FillWeight = 8F;
            // 
            // col_trangThai
            // 
            this.col_trangThai.DataPropertyName = "Status";
            this.col_trangThai.HeaderText = "Trạng Thái";
            this.col_trangThai.Name = "col_trangThai";
            this.col_trangThai.ReadOnly = true;
            this.col_trangThai.FillWeight = 10F;
            // 
            // col_moLuc
            // 
            this.col_moLuc.DataPropertyName = "StartTime";
            this.col_moLuc.HeaderText = "Mở Lúc";
            this.col_moLuc.Name = "col_moLuc";
            this.col_moLuc.ReadOnly = true;
            this.col_moLuc.FillWeight = 12F;
            // 
            // col_dongLuc
            // 
            this.col_dongLuc.DataPropertyName = "EndTime";
            this.col_dongLuc.HeaderText = "Đóng Lúc";
            this.col_dongLuc.Name = "col_dongLuc";
            this.col_dongLuc.ReadOnly = true;
            this.col_dongLuc.FillWeight = 12F;
            // 
            // col_tienDauca
            // 
            this.col_tienDauca.DataPropertyName = "OpeningCash";
            this.col_tienDauca.HeaderText = "Tiền Đầu Ca";
            this.col_tienDauca.Name = "col_tienDauca";
            this.col_tienDauca.ReadOnly = true;
            this.col_tienDauca.FillWeight = 12F;
            // 
            // col_tienCuoica
            // 
            this.col_tienCuoica.DataPropertyName = "ClosingCash";
            this.col_tienCuoica.HeaderText = "Tiền Thực Tế (Cuối)";
            this.col_tienCuoica.Name = "col_tienCuoica";
            this.col_tienCuoica.ReadOnly = true;
            this.col_tienCuoica.FillWeight = 14F;
            // 
            // col_chenhLech
            // 
            this.col_chenhLech.DataPropertyName = "DifferenceAmount";
            this.col_chenhLech.HeaderText = "Chênh Lệch";
            this.col_chenhLech.Name = "col_chenhLech";
            this.col_chenhLech.ReadOnly = true;
            this.col_chenhLech.FillWeight = 10F;
            // 
            // col_ghiChu
            // 
            this.col_ghiChu.DataPropertyName = "DifferenceNote";
            this.col_ghiChu.HeaderText = "Ghi Chú";
            this.col_ghiChu.Name = "col_ghiChu";
            this.col_ghiChu.ReadOnly = true;
            this.col_ghiChu.FillWeight = 15F;
            // 
            // FormManageShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1587, 950);
            this.Controls.Add(this.grp_ListShift);
            this.Controls.Add(this.grp_CurrentShift);
            this.Controls.Add(this.grp_Action);
            this.Name = "FormManageShift";
            this.Text = "Quản lý Ca làm việc & Quỹ đầu ngày";
            this.Load += new System.EventHandler(this.FormManageShift_Load);
            this.grp_Action.ResumeLayout(false);
            this.grp_CurrentShift.ResumeLayout(false);
            this.grp_CurrentShift.PerformLayout();
            this.grp_ListShift.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listShift)).EndInit();
            this.ResumeLayout(false);

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