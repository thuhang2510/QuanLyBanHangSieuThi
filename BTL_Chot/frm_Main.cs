using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_Chot
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private bool check_exists_form(string name)
        {
            foreach (Form form in Application.OpenForms)
                if (form.Name.Equals(name))
                    return true;

            return false;
        }

        private void activeChildForm(string name)
        {
            foreach (Form form in this.MdiChildren)
                if (form.Name == name)
                {
                    form.Activate();
                    break;
                }
        }


        private void menu_NhanVien_Click(object sender, EventArgs e)
        {
            string NAME_FORM_NHAN_VIEN = "frm_NhanVien";
            if (!check_exists_form(NAME_FORM_NHAN_VIEN))
            {
                frm_NhanVien frm_NhanVien = new frm_NhanVien();
                frm_NhanVien.Dock = DockStyle.Fill;
                frm_NhanVien.MdiParent = this;
                frm_NhanVien.Name = NAME_FORM_NHAN_VIEN;
                frm_NhanVien.Show();
            }
            else
                activeChildForm(NAME_FORM_NHAN_VIEN);

        }

        private void danhSachLoaiHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NAME_FORM = "frm_LoaiHang";
            if (!check_exists_form(NAME_FORM))
            {
                frm_LoaiHang loaiHang = new frm_LoaiHang();
                loaiHang.Dock = DockStyle.Fill;
                loaiHang.MdiParent = this;
                loaiHang.Name = NAME_FORM;
                loaiHang.Show();
            }
            else
                activeChildForm(NAME_FORM);

        }

        private void KhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NAME_FORM = "frm_KhachHang";
            if (!check_exists_form(NAME_FORM))
            {
                frm_KhachHang frm_KhachHang = new frm_KhachHang();
                frm_KhachHang.Dock = DockStyle.Fill;
                frm_KhachHang.MdiParent = this;
                frm_KhachHang.Name = NAME_FORM;
                frm_KhachHang.Show();
            }
            else
                activeChildForm(NAME_FORM);

        }

        private void MatHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NAME_FORM = "frm_MatHang";
            if (!check_exists_form(NAME_FORM))
            {
                frm_MatHang matHang = new frm_MatHang();
                matHang.Dock = DockStyle.Fill;
                matHang.MdiParent = this;
                matHang.Name = NAME_FORM;
                matHang.Show();
            }
            else
                activeChildForm(NAME_FORM);

        }

        private void menu_giaodichPN_Click(object sender, EventArgs e)
        {
            string NAME_FORM_PHIEU_NHAP = "frm_DonNhapHang";
            if (!check_exists_form(NAME_FORM_PHIEU_NHAP))
            {
                frm_HoaDonNhap hoaDonNhap = new frm_HoaDonNhap();
                hoaDonNhap.Dock = DockStyle.Fill;
                hoaDonNhap.MdiParent = this;
                hoaDonNhap.Name = NAME_FORM_PHIEU_NHAP;
                hoaDonNhap.Show();
            }
            else
                activeChildForm(NAME_FORM_PHIEU_NHAP);
        }

        private void menu_CTPhieuNhap_Click(object sender, EventArgs e)
        {
            string NAME_FORM = "frm_ChiTietHoaDonNhap";
            if (!check_exists_form(NAME_FORM))
            {
                frm_ChiTietHoaDonNhap frm_cTPhieuNhap = new frm_ChiTietHoaDonNhap();
                frm_cTPhieuNhap.Dock = DockStyle.Fill;
                frm_cTPhieuNhap.MdiParent = this;
                frm_cTPhieuNhap.Name = NAME_FORM;
                frm_cTPhieuNhap.Show();
            }
            else
                activeChildForm(NAME_FORM);
        }

        private void HoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NAME_FORM = "frm_HoaDonBan";
            if (!check_exists_form(NAME_FORM))
            {
                frm_HoaDonBan frm_HoaDon = new frm_HoaDonBan();
                frm_HoaDon.Dock = DockStyle.Fill;
                frm_HoaDon.MdiParent = this;
                frm_HoaDon.Name = NAME_FORM;
                frm_HoaDon.Show();
            }
            else
                activeChildForm(NAME_FORM);

        }

        private void CTHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NAME_FORM = "frm_ChiTietHDBan";
            if (!check_exists_form(NAME_FORM))
            {
                frm_ChiTietHDBan frm_HoaDon = new frm_ChiTietHDBan();
                frm_HoaDon.Dock = DockStyle.Fill;
                frm_HoaDon.MdiParent = this;
                frm_HoaDon.Name = NAME_FORM;
                frm_HoaDon.Show();
            }
            else
                activeChildForm(NAME_FORM);

        }

        private void menu_dong_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn đóng ứng dụng?", "đóng ứng dụng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
                Application.Exit();

        }
    }
}
