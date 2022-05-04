using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL_Chot.BLL;
using BTL_Chot.DTO;

namespace BTL_Chot
{
    public partial class frm_HoaDonNhap : Form
    {
        private BLL_HoaDonNhap BLL_HoaDonNhap;

        public frm_HoaDonNhap()
        {
            InitializeComponent();
            BLL_HoaDonNhap = new BLL_HoaDonNhap();
            d_NgayNhapHang.MaxDate = DateTime.Now;
        }

        private void taidulieu()
        {
            (DataTable kq, string msg) = BLL_HoaDonNhap.get_all();
            dgv_phieuNhap.DataSource = kq;
        }

        private void getNameNhanVien()
        {
            BLL_NhanVien bLL_NhanVien = new BLL_NhanVien();
            (DataTable kq, string _) = bLL_NhanVien.get_all_have_description();
            cb_TenNV.DataSource = kq;
            cb_TenNV.AutoCompleteMode = AutoCompleteMode.Suggest;
            cb_TenNV.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_TenNV.DisplayMember = "Description";
            cb_TenNV.ValueMember = "iMaNV";
            cb_TenNV.Text = "Lựa chọn";
            txt_MaNV.Text = "";
        }

        private void frm_HoaDonNhap_Load(object sender, EventArgs e)
        {
            getNameNhanVien();
            taidulieu();
        }

        private void cb_TenNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_MaNV.Text = cb_TenNV.SelectedValue.ToString();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            taidulieu();
        }

        private void dgv_phieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            reset_error();
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = dgv_phieuNhap.Rows[e.RowIndex];
                txt_MaNV.Text = Convert.ToString(row.Cells["iMaNV"].Value);
                txt_maHDNhap.Text = Convert.ToString(row.Cells["iSoHD"].Value);
                cb_TenNV.Text = Convert.ToString(row.Cells["sTenNV"].Value);
                d_NgayNhapHang.Value = Convert.ToDateTime(row.Cells["dNgaynhaphang"].Value);
            }
        }

        private void reset_error()
        {
            kiemTra = true; 
            errorProvider1.SetError(txt_maHDNhap, "");
            errorProvider1.SetError(cb_TenNV, "");
        }

        private void reset()
        {
            txt_maHDNhap.Text = "";
            txt_MaNV.Text = "";
            d_NgayNhapHang.Value = new DateTime(2000, 11, 03);
            cb_TenNV.Text = "Lựa chọn";
            checkb_NgayLap.Checked = false;
            checkb_TenNV.Checked = false;
            reset_error();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txt_maHDNhap.Text == "")
            {
                MessageBox.Show("Bạn cần chọn hóa đơn nhập muốn sửa trước", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (check_input())
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    HoaDonNhap hoaDonNhap = new HoaDonNhap(int.Parse(txt_maHDNhap.Text), int.Parse(txt_MaNV.Text), d_NgayNhapHang.Value);
                    (int _, string msg) = BLL_HoaDonNhap.update(hoaDonNhap);
                    MessageBox.Show(msg);
                    taidulieu();
                    reset();
                }
            }
            else
                MessageBox.Show("Vui lòng nhập đủ các trường");
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (check_input())
            {
                HoaDonNhap hoaDonNhap = new HoaDonNhap(int.Parse(txt_maHDNhap.Text), int.Parse(txt_MaNV.Text), d_NgayNhapHang.Value);
                (int kq, string msg) = BLL_HoaDonNhap.create(hoaDonNhap);
                MessageBox.Show(msg);
                taidulieu();
                reset();
            }
            else
                MessageBox.Show("Vui lòng nhập đủ các trường");
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if(txt_maHDNhap.Text == "")
            {
                MessageBox.Show("Bạn cần chọn hóa đơn nhập muốn xóa trước", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                (int _, string msg) = BLL_HoaDonNhap.delete(int.Parse(txt_maHDNhap.Text));
                MessageBox.Show(msg);
                taidulieu();
                reset();
            }
        }


        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string maNV = "";
            DateTime? ngayLap = null;

            if (checkb_TenNV.Checked)
                maNV = txt_MaNV.Text;

            if (checkb_NgayLap.Checked)
                ngayLap = d_NgayNhapHang.Value;

            (DataTable kq, string msg) = BLL_HoaDonNhap.get_by_query(maNV, ngayLap);
            dgv_phieuNhap.DataSource = kq;
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn đóng from này không?", "Đóng from", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }

        private bool check_input()
        {
            if (kiemTra && txt_maHDNhap.Text != "" && txt_MaNV.Text != "")
                return true;

            return false;
        }

        private bool ktraTrungSoHD()
        {
            (DataTable kq, string msg) = BLL_HoaDonNhap.get_by_id(int.Parse(txt_maHDNhap.Text));

            if (kq.Rows.Count > 0)
                return true;

            return false;
        }

        private bool kiemTra = true;

        private void txt_maHDNhap_Validating(object sender, CancelEventArgs e)
        {
            if(txt_maHDNhap.Text == "")
            {
                kiemTra = false;
                errorProvider1.SetError(txt_maHDNhap, "Số hóa đơn ko đc để trống");
            }
            else if(ktraTrungSoHD())
            {
                kiemTra = false;
                errorProvider1.SetError(txt_maHDNhap, "Số hóa đơn ko đc trùng nhau");
            }
            else
            {
                kiemTra = true;
                errorProvider1.SetError(txt_maHDNhap, "");
            }
        }

        private void cb_TenNV_Validating(object sender, CancelEventArgs e)
        {
            if(txt_MaNV.Text == "")
            {
                kiemTra = false;
                errorProvider1.SetError(cb_TenNV, "Chưa chọn nhân viên lập hóa đơn");
            }
            else
            {
                kiemTra = true;
                errorProvider1.SetError(cb_TenNV, "");
            }
        }

        private void txt_maHDNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            char char_LCB = e.KeyChar;

            if ((!Char.IsDigit(char_LCB) && char_LCB != 8 && char_LCB != 46) || char_LCB == '.')
                e.Handled = true;
        }

        private void btn_XemCT_Click(object sender, EventArgs e)
        {
            if(txt_maHDNhap.Text == "")
            {
                MessageBox.Show("Bạn cần chọn hóa đơn bán muốn xem chi tiết trước");
                return;
            }

            if (ktraTrungSoHD())
            {
                frm_ChiTietHoaDonNhap frm_ChiTietHoaDonNhap = new frm_ChiTietHoaDonNhap(int.Parse(txt_maHDNhap.Text));
                frm_ChiTietHoaDonNhap.MdiParent = this.MdiParent;
                frm_ChiTietHoaDonNhap.Show();
            }
            else
                MessageBox.Show("Mã hóa đơn không tồn tại");
        }
    }
}
