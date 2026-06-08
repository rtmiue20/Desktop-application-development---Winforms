using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GUI;

public partial class FormManageShift : Form
{
    private bool _isShiftOpen = true;
    private List<ShiftRecord> _shiftList = new List<ShiftRecord>();

    public FormManageShift()
    {
        InitializeComponent();
        LoadData();
    }

    private void LoadData()
    {
        UpdateCards();
        LoadTable();
        UpdateFooter();
    }

    private void UpdateCards()
    {
        lbl_trangThaiTitle.Text      = _isShiftOpen ? "Đang mở" : "Đã đóng";
        lbl_trangThaiTitle.ForeColor = _isShiftOpen ? Color.FromArgb(0, 140, 0) : Color.Red;
        lbl_gioMoCa.Text             = "—";
        lbl_tienDauca.Text           = "—";
        lbl_hdTrongca.Text           = "—";
        lbl_doanhThuca.Text          = "—";
        lbl_doanhThuca.ForeColor     = Color.FromArgb(0, 102, 204);
    }

    private void LoadTable()
    {
        dgv_danhSachCa.Rows.Clear();
        dgv_danhSachCa.RowHeadersVisible  = false;
        dgv_danhSachCa.AllowUserToAddRows = false;
        dgv_danhSachCa.ReadOnly           = true;
        dgv_danhSachCa.SelectionMode      = DataGridViewSelectionMode.FullRowSelect;
        dgv_danhSachCa.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 248, 255);

        foreach (var s in _shiftList)
        {
            int i = dgv_danhSachCa.Rows.Add(
                s.MaCa, s.NhanVien, s.MoLuc, s.DongLuc,
                string.Format("{0:N0}", s.TienDau),
                s.TienCuoi > 0 ? string.Format("{0:N0}", s.TienCuoi) : "—",
                s.ChenhLech > 0 ? "+" + string.Format("{0:N0}", s.ChenhLech) : "—",
                s.TrangThai
            );

            var ttCell = dgv_danhSachCa.Rows[i].Cells["col_trangThai"];
            if (s.TrangThai == "Đang mở")
            { ttCell.Style.BackColor = Color.FromArgb(0, 102, 204); ttCell.Style.ForeColor = Color.White; }
            else
            { ttCell.Style.BackColor = Color.FromArgb(100, 100, 100); ttCell.Style.ForeColor = Color.White; }

            var clCell = dgv_danhSachCa.Rows[i].Cells["col_chenhLech"];
            if (s.ChenhLech > 0) clCell.Style.ForeColor = Color.Green;
            else if (s.ChenhLech < 0) clCell.Style.ForeColor = Color.Red;
        }
    }

    private void UpdateFooter()
    {
        lbl_footerLeft.Text  = "Ca hiện tại: —";
        lbl_footerRight.Text = "Mở lúc: —";
    }

    private void btn_moCa_Click(object sender, EventArgs e)
    {
        if (_isShiftOpen)
        {
            MessageBox.Show("Đang có ca đang mở!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        _isShiftOpen = true;
        UpdateCards();
        MessageBox.Show("Mở ca thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btn_chotCa_Click(object sender, EventArgs e)
    {
        if (!_isShiftOpen)
        {
            MessageBox.Show("Không có ca nào đang mở!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        if (MessageBox.Show("Bạn có chắc muốn chốt ca?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            _isShiftOpen = false;
            UpdateCards();
            MessageBox.Show("Chốt ca thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void button5_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Tính năng lịch sử ca đang phát triển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void label2_Click_1(object sender, EventArgs e) { }
    private void label2_Click_2(object sender, EventArgs e) { }
}

public class ShiftRecord
{
    public string  MaCa      { get; set; }
    public string  NhanVien  { get; set; }
    public string  MoLuc     { get; set; }
    public string  DongLuc   { get; set; }
    public decimal TienDau   { get; set; }
    public decimal TienCuoi  { get; set; }
    public decimal ChenhLech { get; set; }
    public string  TrangThai { get; set; }
}

