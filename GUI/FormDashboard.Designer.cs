using System.ComponentModel;

namespace GUI;

partial class FormDashboard
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        menuStrip = new System.Windows.Forms.MenuStrip();
        MI_sale = new System.Windows.Forms.ToolStripMenuItem();
        toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
        toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
        toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
        Menu_formSell = new System.Windows.Forms.ToolStripMenuItem();
        Menu_formGuest = new System.Windows.Forms.ToolStripMenuItem();
        Menu_formPromotion = new System.Windows.Forms.ToolStripMenuItem();
        MI_warehouse = new System.Windows.Forms.ToolStripMenuItem();
        toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
        toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
        Menu_formIntoWarehouse = new System.Windows.Forms.ToolStripMenuItem();
        Menu_formInventory = new System.Windows.Forms.ToolStripMenuItem();
        Menu_formSupplier = new System.Windows.Forms.ToolStripMenuItem();
        MI_guarantee = new System.Windows.Forms.ToolStripMenuItem();
        Menu_formWarranty = new System.Windows.Forms.ToolStripMenuItem();
        Menu_formTradeIn = new System.Windows.Forms.ToolStripMenuItem();
        MI_report = new System.Windows.Forms.ToolStripMenuItem();
        toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
        Menu_formReport = new System.Windows.Forms.ToolStripMenuItem();
        Menu_formManageShift = new System.Windows.Forms.ToolStripMenuItem();
        MI_system = new System.Windows.Forms.ToolStripMenuItem();
        Menu_formStaff = new System.Windows.Forms.ToolStripMenuItem();
        Menu_formProduct = new System.Windows.Forms.ToolStripMenuItem();
        Menu_formCategory = new System.Windows.Forms.ToolStripMenuItem();
        Menu_formLogout = new System.Windows.Forms.ToolStripMenuItem();
        toolStrip1 = new System.Windows.Forms.ToolStrip();
        statusStrip = new System.Windows.Forms.StatusStrip();
        menuStrip.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip
        // 
        menuStrip.BackColor = System.Drawing.SystemColors.ControlDark;
        menuStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
        menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { MI_sale, MI_warehouse, MI_guarantee, MI_report, MI_system });
        menuStrip.Location = new System.Drawing.Point(0, 0);
        menuStrip.Name = "menuStrip";
        menuStrip.Size = new System.Drawing.Size(1832, 28);
        menuStrip.TabIndex = 0;
        menuStrip.Text = "menuStrip1";
        // 
        // MI_sale
        // 
        MI_sale.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripSeparator, toolStripSeparator1, toolStripSeparator2, Menu_formSell, Menu_formGuest, Menu_formPromotion });
        MI_sale.Name = "MI_sale";
        MI_sale.Size = new System.Drawing.Size(85, 24);
        MI_sale.Text = "Bán hàng";
        // 
        // toolStripSeparator
        // 
        toolStripSeparator.Name = "toolStripSeparator";
        toolStripSeparator.Size = new System.Drawing.Size(166, 6);
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new System.Drawing.Size(166, 6);
        // 
        // toolStripSeparator2
        // 
        toolStripSeparator2.Name = "toolStripSeparator2";
        toolStripSeparator2.Size = new System.Drawing.Size(166, 6);
        // 
        // Menu_formSell
        // 
        Menu_formSell.Name = "Menu_formSell";
        Menu_formSell.Size = new System.Drawing.Size(169, 26);
        Menu_formSell.Text = "Bán hàng";
        Menu_formSell.Click += Menu_formSell_Click;
        // 
        // Menu_formGuest
        // 
        Menu_formGuest.Name = "Menu_formGuest";
        Menu_formGuest.Size = new System.Drawing.Size(169, 26);
        Menu_formGuest.Text = "Khách hàng";
        Menu_formGuest.Click += Menu_formGuest_Click;
        // 
        // Menu_formPromotion
        // 
        Menu_formPromotion.Name = "Menu_formPromotion";
        Menu_formPromotion.Size = new System.Drawing.Size(169, 26);
        Menu_formPromotion.Text = "Khuyến mãi";
        Menu_formPromotion.Click += Menu_formPromotion_Click;
        // 
        // MI_warehouse
        // 
        MI_warehouse.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripSeparator3, toolStripSeparator4, Menu_formIntoWarehouse, Menu_formInventory, Menu_formSupplier });
        MI_warehouse.Name = "MI_warehouse";
        MI_warehouse.Size = new System.Drawing.Size(86, 24);
        MI_warehouse.Text = "Kho hàng";
        // 
        // toolStripSeparator3
        // 
        toolStripSeparator3.Name = "toolStripSeparator3";
        toolStripSeparator3.Size = new System.Drawing.Size(180, 6);
        // 
        // toolStripSeparator4
        // 
        toolStripSeparator4.Name = "toolStripSeparator4";
        toolStripSeparator4.Size = new System.Drawing.Size(180, 6);
        // 
        // Menu_formIntoWarehouse
        // 
        Menu_formIntoWarehouse.Name = "Menu_formIntoWarehouse";
        Menu_formIntoWarehouse.Size = new System.Drawing.Size(183, 26);
        Menu_formIntoWarehouse.Text = "Nhập kho";
        Menu_formIntoWarehouse.Click += Menu_formIntoWarehouse_Click;
        // 
        // Menu_formInventory
        // 
        Menu_formInventory.Name = "Menu_formInventory";
        Menu_formInventory.Size = new System.Drawing.Size(183, 26);
        Menu_formInventory.Text = "Kiểm kê";
        Menu_formInventory.Click += Menu_formInventory_Click;
        // 
        // Menu_formSupplier
        // 
        Menu_formSupplier.Name = "Menu_formSupplier";
        Menu_formSupplier.Size = new System.Drawing.Size(183, 26);
        Menu_formSupplier.Text = "Nhà cung cấp";
        Menu_formSupplier.Click += Menu_formSupplier_Click;
        // 
        // MI_guarantee
        // 
        MI_guarantee.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { Menu_formWarranty, Menu_formTradeIn });
        MI_guarantee.Name = "MI_guarantee";
        MI_guarantee.Size = new System.Drawing.Size(85, 24);
        MI_guarantee.Text = "Bảo hành";
        // 
        // Menu_formWarranty
        // 
        Menu_formWarranty.Name = "Menu_formWarranty";
        Menu_formWarranty.Size = new System.Drawing.Size(224, 26);
        Menu_formWarranty.Text = "Tiếp nhận bảo hành";
        Menu_formWarranty.Click += Menu_formWarranty_Click;
        // 
        // Menu_formTradeIn
        // 
        Menu_formTradeIn.Name = "Menu_formTradeIn";
        Menu_formTradeIn.Size = new System.Drawing.Size(224, 26);
        Menu_formTradeIn.Text = "Đổi trả";
        Menu_formTradeIn.Click += Menu_formTradeIn_Click;
        // 
        // MI_report
        // 
        MI_report.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripSeparator5, Menu_formReport, Menu_formManageShift });
        MI_report.Name = "MI_report";
        MI_report.Size = new System.Drawing.Size(77, 24);
        MI_report.Text = "Báo cáo";
        // 
        // toolStripSeparator5
        // 
        toolStripSeparator5.Name = "toolStripSeparator5";
        toolStripSeparator5.Size = new System.Drawing.Size(214, 6);
        // 
        // Menu_formReport
        // 
        Menu_formReport.Name = "Menu_formReport";
        Menu_formReport.Size = new System.Drawing.Size(217, 26);
        Menu_formReport.Text = "Báo cáo doanh thu";
        Menu_formReport.Click += Menu_formReport_Click;
        // 
        // Menu_formManageShift
        // 
        Menu_formManageShift.Name = "Menu_formManageShift";
        Menu_formManageShift.Size = new System.Drawing.Size(217, 26);
        Menu_formManageShift.Text = "Ca làm việc";
        Menu_formManageShift.Click += Menu_formManageShift_Click;
        // 
        // MI_system
        // 
        MI_system.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { Menu_formStaff, Menu_formProduct, Menu_formCategory, Menu_formLogout });
        MI_system.Name = "MI_system";
        MI_system.Size = new System.Drawing.Size(85, 24);
        MI_system.Text = "Hệ thống";
        // 
        // Menu_formStaff
        // 
        Menu_formStaff.Name = "Menu_formStaff";
        Menu_formStaff.Size = new System.Drawing.Size(160, 26);
        Menu_formStaff.Text = "Nhân viên";
        Menu_formStaff.Click += Menu_formStaff_Click;
        // 
        // Menu_formProduct
        // 
        Menu_formProduct.Name = "Menu_formProduct";
        Menu_formProduct.Size = new System.Drawing.Size(160, 26);
        Menu_formProduct.Text = "Sản phẩm";
        Menu_formProduct.Click += Menu_formProduct_Click;
        // 
        // Menu_formCategory
        // 
        Menu_formCategory.Name = "Menu_formCategory";
        Menu_formCategory.Size = new System.Drawing.Size(160, 26);
        Menu_formCategory.Text = "Danh mục";
        Menu_formCategory.Click += Menu_formCategory_Click;
        // 
        // Menu_formLogout
        // 
        Menu_formLogout.Name = "Menu_formLogout";
        Menu_formLogout.Size = new System.Drawing.Size(160, 26);
        Menu_formLogout.Text = "Đăng xuất";
        Menu_formLogout.Click += Menu_formLogout_Click;
        // 
        // toolStrip1
        // 
        toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
        toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
        toolStrip1.Location = new System.Drawing.Point(0, 28);
        toolStrip1.Name = "toolStrip1";
        toolStrip1.Size = new System.Drawing.Size(1832, 25);
        toolStrip1.TabIndex = 1;
        toolStrip1.Text = "toolStrip";
        // 
        // statusStrip
        // 
        statusStrip.BackColor = System.Drawing.SystemColors.ControlLight;
        statusStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
        statusStrip.Location = new System.Drawing.Point(0, 1033);
        statusStrip.Name = "statusStrip";
        statusStrip.Size = new System.Drawing.Size(1832, 22);
        statusStrip.TabIndex = 2;
        statusStrip.Text = "statusStrip1";
        // 
        // FormDashboard
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1832, 1055);
        Controls.Add(statusStrip);
        Controls.Add(toolStrip1);
        Controls.Add(menuStrip);
        IsMdiContainer = true;
        Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
        Text = "Quản lý Cửa hàng";
        WindowState = System.Windows.Forms.FormWindowState.Maximized;
        menuStrip.ResumeLayout(false);
        menuStrip.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ToolStripMenuItem Menu_formLogout;

    private System.Windows.Forms.ToolStripMenuItem Menu_formCategory;

    private System.Windows.Forms.ToolStripMenuItem Menu_formCate;

    private System.Windows.Forms.ToolStripMenuItem Menu_formProduct;

    private System.Windows.Forms.ToolStripMenuItem Menu_formStaff;

    private System.Windows.Forms.ToolStripMenuItem Menu_formManageShift;

    private System.Windows.Forms.ToolStripMenuItem Menu_form;

    private System.Windows.Forms.ToolStripMenuItem Menu_formReport;

    private System.Windows.Forms.ToolStripMenuItem Menu_formTradeIn;

    private System.Windows.Forms.ToolStripMenuItem Menu_formWarranty;

    private System.Windows.Forms.ToolStripMenuItem Menu_formSupplier;

    private System.Windows.Forms.ToolStripMenuItem Menu_formInventory;

    private System.Windows.Forms.ToolStripMenuItem Menu_formIntoWarehouse;

    private System.Windows.Forms.ToolStripMenuItem Menu_formGuest;
    private System.Windows.Forms.ToolStripMenuItem Menu_formPromotion;

    private System.Windows.Forms.ToolStripMenuItem Menu_formSell;

    private System.Windows.Forms.ToolStripMenuItem MI_system;

    private System.Windows.Forms.ToolStripMenuItem MI_sale;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem MI_warehouse;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripMenuItem MI_guarantee;
    private System.Windows.Forms.ToolStripMenuItem MI_report;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

    private System.Windows.Forms.ToolStrip toolStrip1;

    private System.Windows.Forms.MenuStrip menuStrip;
    private System.Windows.Forms.StatusStrip statusStrip;

    #endregion
}