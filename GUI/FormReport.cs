using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GUI;

public partial class FormReport : Form
{
    private List<ReportRecord> _reportList = new List<ReportRecord>();

    public FormReport()
    {
        InitializeComponent();
        LoadReport();
    }

    private void LoadReport()
    {
        UpdateCards();
        LoadTable();
        UpdateFooter();
    }

    private void UpdateCards()
    {
        lbl_doanhThu.Text         = "—\nDoanh thu (đ)";
        lbl_loiNhuangop.Text      = "—\nLợi nhuận gộp (đ)";
        lbl_soHoadon.Text         = "—\nSố hóa đơn";
        lbl_sanPhambanra.Text     = "—\nSản phẩm bán ra";
        lbl_baoHanhphatsinh.Text  = "—\nBảo hành phát sinh";

        lbl_doanhThu.ForeColor        = Color.FromArgb(0, 102, 204);
        lbl_loiNhuangop.ForeColor     = Color.FromArgb(0, 140, 0);
        lbl_baoHanhphatsinh.ForeColor = Color.FromArgb(200, 100, 0);

        lbl_doanhThu.TextAlign        = ContentAlignment.MiddleCenter;
        lbl_loiNhuangop.TextAlign     = ContentAlignment.MiddleCenter;
        lbl_soHoadon.TextAlign        = ContentAlignment.MiddleCenter;
        lbl_sanPhambanra.TextAlign    = ContentAlignment.MiddleCenter;
        lbl_baoHanhphatsinh.TextAlign = ContentAlignment.MiddleCenter;

        lbl_doanhThu.Font        = new Font("Segoe UI", 9F, FontStyle.Bold);
        lbl_loiNhuangop.Font     = new Font("Segoe UI", 9F, FontStyle.Bold);
        lbl_soHoadon.Font        = new Font("Segoe UI", 9F, FontStyle.Bold);
        lbl_sanPhambanra.Font    = new Font("Segoe UI", 9F, FontStyle.Bold);
        lbl_baoHanhphatsinh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
    }

    private void LoadTable()
    {
        dgv_danhSachHD.Rows.Clear();
        dgv_danhSachHD.RowHeadersVisible  = false;
        dgv_danhSachHD.AllowUserToAddRows = false;
        dgv_danhSachHD.ReadOnly           = true;
        dgv_danhSachHD.SelectionMode      = DataGridViewSelectionMode.FullRowSelect;
        dgv_danhSachHD.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 248, 255);

        foreach (var r in _reportList)
        {
            int i = dgv_danhSachHD.Rows.Add(
                r.InvoiceCode, r.SaleTime, r.CustomerName, r.ProductName,
                string.Format("{0:N0}", r.Revenue),
                string.Format("{0:N0}", r.Profit),
                r.PaymentMethod
            );
            var payCell = dgv_danhSachHD.Rows[i].Cells["col_thanhToan"];
            if (r.PaymentMethod == "Tiền mặt")
            { payCell.Style.BackColor = Color.FromArgb(0, 140, 0);   payCell.Style.ForeColor = Color.White; }
            else
            { payCell.Style.BackColor = Color.FromArgb(0, 102, 204); payCell.Style.ForeColor = Color.White; }
        }
    }

    private void UpdateFooter()
    {
        lbl_footerLeft.Text  = "Báo cáo ngày: " + DateTime.Now.ToString("dd/MM/yyyy");
        lbl_footerRight.Text = "Tỉ lệ lợi nhuận: —";
    }

    private void btn_xemBaocao_Click(object sender, EventArgs e)
    {
        LoadReport();
    }

    private void btn_xuatExcel_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Tính năng xuất Excel đang phát triển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void label1_Click(object sender, EventArgs e) { }

    private void pnl_Top_Paint(object sender, PaintEventArgs e) { }
}

public class ReportRecord
{
    public string  InvoiceCode   { get; set; }
    public string  SaleTime      { get; set; }
    public string  CustomerName  { get; set; }
    public string  ProductName   { get; set; }
    public decimal Revenue       { get; set; }
    public decimal Profit        { get; set; }
    public string  PaymentMethod { get; set; }
}

