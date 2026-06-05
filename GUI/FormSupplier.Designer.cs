namespace GUI
{
    partial class FormSupplier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvSuppliers = new DataGridView();
            txtSupplierCode = new TextBox();
            txtSupplierName = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            SuspendLayout();
            // 
            // dgvSuppliers
            // 
            dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuppliers.Location = new Point(19, 223);
            dgvSuppliers.Margin = new Padding(4, 5, 4, 5);
            dgvSuppliers.Name = "dgvSuppliers";
            dgvSuppliers.RowHeadersWidth = 51;
            dgvSuppliers.Size = new Size(1013, 385);
            dgvSuppliers.TabIndex = 0;
            dgvSuppliers.CellClick += dgvSuppliers_CellClick;
            // 
            // txtSupplierCode
            // 
            txtSupplierCode.Location = new Point(160, 31);
            txtSupplierCode.Margin = new Padding(4, 5, 4, 5);
            txtSupplierCode.Name = "txtSupplierCode";
            txtSupplierCode.Size = new Size(265, 27);
            txtSupplierCode.TabIndex = 1;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(160, 77);
            txtSupplierName.Margin = new Padding(4, 5, 4, 5);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(265, 27);
            txtSupplierName.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(160, 123);
            txtPhone.Margin = new Padding(4, 5, 4, 5);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(265, 27);
            txtPhone.TabIndex = 3;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(160, 169);
            txtAddress.Margin = new Padding(4, 5, 4, 5);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(265, 27);
            txtAddress.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(467, 28);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(133, 46);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(467, 89);
            btnUpdate.Margin = new Padding(4, 5, 4, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(133, 46);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(467, 151);
            btnClear.Margin = new Padding(4, 5, 4, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(133, 46);
            btnClear.TabIndex = 7;
            btnClear.Text = "Làm mới";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 8;
            label1.Text = "Mã NCC:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 82);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 9;
            label2.Text = "Tên NCC:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 128);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 10;
            label3.Text = "SĐT:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 174);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 11;
            label4.Text = "Địa chỉ:";
            // 
            // FormSupplier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 678);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtSupplierName);
            Controls.Add(txtSupplierCode);
            Controls.Add(dgvSuppliers);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormSupplier";
            Text = "Quản lý Nhà cung cấp";
            Load += FormSupplier_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSuppliers;
        private System.Windows.Forms.TextBox txtSupplierCode;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}