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
    public partial class frm_ChiTietHoaDonNhap : Form
    {
        private BLL_ChiTietNhapHang BLL_ChiTietNhapHang;

        public frm_ChiTietHoaDonNhap(int? soHD = null)
        {
            InitializeComponent();

            if (soHD != null)
            {
                cb_SoHD.Text = soHD.ToString();
                cb_SoHD.Enabled = false;
            }
            else
            {
                cb_SoHD.Text = "Lựa chọn";
                cb_SoHD.Enabled = true;
            }

            BLL_ChiTietNhapHang = new BLL_ChiTietNhapHang();
        }

        private void layDSMatHang()
        {
            BLL_MatHang bLL_MatHang = new BLL_MatHang();
            (DataTable kq, string msg) = bLL_MatHang.get_all();
            cb_TenHang.DataSource = kq;
            cb_TenHang.AutoCompleteMode = AutoCompleteMode.Suggest;
            cb_TenHang.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_TenHang.DisplayMember = "sTenHang";
            cb_TenHang.ValueMember = "sMaHang";
            cb_TenHang.Text = "Lựa chọn";
            txt_MaHang.Text = "";
        }

        private void taidulieu()
        {
            string soHD = "-1";
            int number;

            if (int.TryParse(cb_SoHD.Text, out number))
                soHD = cb_SoHD.Text;

            (DataTable kq, string msg) = BLL_ChiTietNhapHang.get_by_id(int.Parse(soHD));
            dgv_ChiTietNhapHang.DataSource = kq;
            dgv_ChiTietNhapHang.Columns["iSoHD"].Visible = false;
        }

        private void taidsHoaDonNhap()
        {
            if (cb_SoHD.Text == "Lựa chọn")
            {
                BLL_HoaDonNhap bLL_HoaDonNhap = new BLL_HoaDonNhap();
                (DataTable kq, string msg) = bLL_HoaDonNhap.get_all();
                cb_SoHD.DataSource = kq;
                cb_SoHD.AutoCompleteMode = AutoCompleteMode.Suggest;
                cb_SoHD.AutoCompleteSource = AutoCompleteSource.ListItems;
                cb_SoHD.DisplayMember = "iSoHD";
            }
        }

        private void frm_ChiTietHoaDonNhap_Load(object sender, EventArgs e)
        {
            taidsHoaDonNhap();
            layDSMatHang();
            taidulieu();
        }

        private void cb_TenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_MaHang.Text = cb_TenHang.SelectedValue.ToString();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if(check_input())
            {
                ChiTietHoaDonNhap chiTietHoaDonNhap = new ChiTietHoaDonNhap(
                int.Parse(cb_SoHD.Text), txt_MaHang.Text, float.Parse(txt_GiaNhap.Text), float.Parse(txt_SLNhap.Text));
                (int _, string msg) = BLL_ChiTietNhapHang.create(chiTietHoaDonNhap);
                MessageBox.Show(msg);
                taidulieu();
                reset();
            }
            else
                MessageBox.Show("Bạn cần kiểm tra lại thông tin");
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if(txt_MaHang.Text == "")
            {
                MessageBox.Show("Bạn cần chọn mặt hàng muốn sửa trước");
                return;
            }

            if (check_input())
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn sửa không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    ChiTietHoaDonNhap chiTietHoaDonNhap = new ChiTietHoaDonNhap(
                int.Parse(cb_SoHD.Text), txt_MaHang.Text, float.Parse(txt_GiaNhap.Text), float.Parse(txt_SLNhap.Text));
                    (int _, string msg) = BLL_ChiTietNhapHang.update(chiTietHoaDonNhap);
                    MessageBox.Show(msg);
                    taidulieu();
                    reset();
                }
            }
            else
                MessageBox.Show("Bạn cần kiểm tra lại thông tin");
        }

        private void dgv_ChiTietNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            reset_error();
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = dgv_ChiTietNhapHang.Rows[e.RowIndex];
                txt_MaHang.Text = Convert.ToString(row.Cells["sMaHang"].Value);
                cb_TenHang.Text = Convert.ToString(row.Cells["sTenHang"].Value);
                txt_SLNhap.Text = Convert.ToString(row.Cells["fSoLuong"].Value);
                txt_GiaNhap.Text = Convert.ToString(row.Cells["fGiaNhap"].Value);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txt_MaHang.Text == "")
            {
                MessageBox.Show("Bạn cần chọn mặt hàng muốn sửa trước");
                return;
            }


            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn sửa không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                (int _, string msg) = BLL_ChiTietNhapHang.delete(int.Parse(cb_SoHD.Text), txt_MaHang.Text);
                MessageBox.Show(msg);
                taidulieu();
                reset();
            }
        }

        private void reset_error()
        {
            kiemTra = true;
            errorProvider1.SetError(cb_TenHang, "");
            errorProvider1.SetError(txt_SLNhap, "");
            errorProvider1.SetError(txt_GiaNhap, "");
        }

        private void reset()
        {
            txt_GiaNhap.Text = "";
            txt_SLNhap.Text = "";
            txt_MaHang.Text = "";
            cb_TenHang.Text = "Lựa chọn";
            checkb_TenHang.Checked = false;
            checkb_slNhap.Checked = false;
            checkb_GiaNhap.Checked = false;
            txt_giaNhapMin.Text = "";
            txt_giaNhapMax.Text = "";
            txt_SLNhapMax.Text = "";
            txt_SlNhapMin.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
            reset_error();
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            taidulieu();
        }

        private void cb_SoHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            taidulieu();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sMaHang = "";
            string giaNhapMin = "";
            string gianNhapMax = "";
            string slNhapMax = "";
            string slNhapMin = "";

            if (checkb_TenHang.Checked)
                sMaHang = txt_MaHang.Text;

            if(checkb_GiaNhap.Checked)
            {
                giaNhapMin = txt_giaNhapMin.Text;
                gianNhapMax = txt_giaNhapMax.Text;
            }

            if (checkb_slNhap.Checked)
            {
                slNhapMin = txt_SlNhapMin.Text;
                slNhapMax = txt_SLNhapMax.Text;
            }

            (DataTable kq, string msg) = BLL_ChiTietNhapHang.get_by_query(
                cb_SoHD.Text, sMaHang, giaNhapMin, gianNhapMax, slNhapMin, slNhapMax);
            dgv_ChiTietNhapHang.DataSource = kq;
        }

        private bool kiemTra = true;

        private bool check_input()
        {
            if (kiemTra && cb_SoHD.Text != "" && txt_MaHang.Text != "" && txt_SLNhap.Text != "" && txt_GiaNhap.Text != "")
                return true;

            return false;
        }

        private bool kiemTraMatHangTonTai()
        {
            ChiTietHoaDonNhap chiTietHoaDonNhap = new ChiTietHoaDonNhap(int.Parse(cb_SoHD.Text), txt_MaHang.Text);
            (bool kq, string msg) = BLL_ChiTietNhapHang.kra_mh_ton_tai(chiTietHoaDonNhap);
            return kq;
        }

        private void cb_TenHang_Validating(object sender, CancelEventArgs e)
        {
            if(txt_MaHang.Text == "")
            {
                kiemTra = false;
                errorProvider1.SetError(cb_TenHang, "Bạn cần chọn tên loại hàng");
            }
            else if(kiemTraMatHangTonTai())
            {
                kiemTra = false;
                errorProvider1.SetError(cb_TenHang, "Mặt hàng này đã có trong hóa đơn");
            }
            else
            {
                kiemTra = true;
                errorProvider1.SetError(cb_TenHang, "");
            }
        }

        private void txt_GiaNhap_Validating(object sender, CancelEventArgs e)
        {
            if (txt_GiaNhap.Text == "")
            {
                kiemTra = false;
                errorProvider1.SetError(txt_GiaNhap, "Giá nhập không được bỏ trống");
            }
            else
            {
                kiemTra = true;
                errorProvider1.SetError(txt_GiaNhap, "");
            }
        }

        private void txt_SLNhap_Validating(object sender, CancelEventArgs e)
        {
            if (txt_SLNhap.Text == "")
            {
                kiemTra = false;
                errorProvider1.SetError(txt_SLNhap, "SL nhập không được bỏ trống");
            }
            else
            {
                kiemTra = true;
                errorProvider1.SetError(txt_SLNhap, "");
            }
        }

        private void txt_GiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            char char_LCB = e.KeyChar;

            if ((!Char.IsDigit(char_LCB) && char_LCB != 8 && char_LCB != 46) || char_LCB == '.')
                e.Handled = true;
        }

        private void txt_SLNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            char char_LCB = e.KeyChar;

            if ((!Char.IsDigit(char_LCB) && char_LCB != 8 && char_LCB != 46) || char_LCB == '.')
                e.Handled = true;
        }

        private void cb_SoHD_KeyPress(object sender, KeyPressEventArgs e)
        {
            char char_LCB = e.KeyChar;

            if ((!Char.IsDigit(char_LCB) && char_LCB != 8 && char_LCB != 46) || char_LCB == '.')
                e.Handled = true;
        }

        private void txt_giaNhapMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            char char_LCB = e.KeyChar;

            if ((!Char.IsDigit(char_LCB) && char_LCB != 8 && char_LCB != 46) || char_LCB == '.')
                e.Handled = true;
        }

        private void txt_giaNhapMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            char char_LCB = e.KeyChar;

            if ((!Char.IsDigit(char_LCB) && char_LCB != 8 && char_LCB != 46) || char_LCB == '.')
                e.Handled = true;
        }

        private void txt_SlNhapMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            char char_LCB = e.KeyChar;

            if ((!Char.IsDigit(char_LCB) && char_LCB != 8 && char_LCB != 46) || char_LCB == '.')
                e.Handled = true;
        }

        private void txt_SLNhapMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            char char_LCB = e.KeyChar;

            if ((!Char.IsDigit(char_LCB) && char_LCB != 8 && char_LCB != 46) || char_LCB == '.')
                e.Handled = true;
        }

        private void btn_inHD_Click(object sender, EventArgs e)
        {
            report.report_hoaDonNhap report = new report.report_hoaDonNhap(int.Parse(cb_SoHD.Text));
            report.MdiParent = this.MdiParent;
            report.Show();
        }
    }
}
