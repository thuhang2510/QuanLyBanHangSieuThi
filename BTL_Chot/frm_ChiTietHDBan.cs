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
    public partial class frm_ChiTietHDBan : Form
    {
        private BLL_ChiTietHoaDonBan BLL_ChiTietHoaDonBan;

        public frm_ChiTietHDBan(int? soHD = null)
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

            BLL_ChiTietHoaDonBan = new BLL_ChiTietHoaDonBan();
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
            txtSLTon.Text = "";
        }

        private void taidsHoaDonBan()
        {
            if (cb_SoHD.Text == "Lựa chọn")
            {
                BLL_HoaDonBan bLL_HoaDonBan = new BLL_HoaDonBan();
                (DataTable kq, string msg) = bLL_HoaDonBan.get_all();
                cb_SoHD.DataSource = kq;
                cb_SoHD.AutoCompleteMode = AutoCompleteMode.Suggest;
                cb_SoHD.AutoCompleteSource = AutoCompleteSource.ListItems;
                cb_SoHD.DisplayMember = "iSoHD";
            }
        }

        private void taidulieu()
        {
            string soHD = "-1";
            int number;

            if (int.TryParse(cb_SoHD.Text, out number))
                soHD = cb_SoHD.Text;

            (DataTable kq, string msg) = BLL_ChiTietHoaDonBan.get_by_id(int.Parse(soHD));
            dgv_ChiTietBan.DataSource = kq;
            dgv_ChiTietBan.Columns["iSoHD"].Visible = false;
            dgv_ChiTietBan.Columns["fSoLuong"].Visible = false;
        }

        private void frm_ChiTietHDBan_Load(object sender, EventArgs e)
        {
            layDSMatHang();
            taidsHoaDonBan();
            taidulieu();
        }

        private void cb_TenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_MaHang.Text = cb_TenHang.SelectedValue.ToString();
            DataRowView dataRowview = (DataRowView)cb_TenHang.SelectedItem;
            txtSLTon.Text = dataRowview.Row["fSoLuong"].ToString();
        }

        private void cb_SoHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            taidulieu();
        }

        private void dgv_ChiTietBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            reset_error();
            if (-1 < e.RowIndex)
            {
                DataGridViewRow row = dgv_ChiTietBan.Rows[e.RowIndex];
                txt_MaHang.Text = Convert.ToString(row.Cells["sMaHang"].Value);
                cb_TenHang.Text = Convert.ToString(row.Cells["sTenHang"].Value);
                txt_SLBan.Text = Convert.ToString(row.Cells["fSoluongmua"].Value);
                txt_GiaBan.Text = Convert.ToString(row.Cells["fGiaban"].Value);
                txtSLTon.Text = row.Cells["fSoLuong"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (check_input())
            {
                ChiTietHoaDonBan chiTietHoaDonBan = new ChiTietHoaDonBan(
                int.Parse(cb_SoHD.Text), txt_MaHang.Text, float.Parse(txt_GiaBan.Text), float.Parse(txt_SLBan.Text));

                (int kq, string msg) = BLL_ChiTietHoaDonBan.create(chiTietHoaDonBan);
                MessageBox.Show(msg);
                taidulieu();
                reset();
            }
            else
                MessageBox.Show("Vui lòng nhập đủ các trường");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(txt_MaHang.Text == "")
            {
                MessageBox.Show("Bạn cần chọn mặt hàng muốn sửa trước");
                return;
            }

            if(check_input())
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    ChiTietHoaDonBan chiTietHoaDonBan = new ChiTietHoaDonBan(
                    int.Parse(cb_SoHD.Text), txt_MaHang.Text, float.Parse(txt_GiaBan.Text), float.Parse(txt_SLBan.Text));

                    (int kq, string msg) = BLL_ChiTietHoaDonBan.update(chiTietHoaDonBan);
                    MessageBox.Show(msg);
                    taidulieu();
                    reset();
                }
            }
            else
                MessageBox.Show("Vui lòng nhập đủ các trường");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txt_MaHang.Text == "")
            {
                MessageBox.Show("Bạn cần chọn mặt hàng muốn xóa trước");
                return;
            }

            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                ChiTietHoaDonBan chiTietHoaDonBan = new ChiTietHoaDonBan(
                    int.Parse(cb_SoHD.Text), txt_MaHang.Text);

                (int kq, string msg) = BLL_ChiTietHoaDonBan.delete(chiTietHoaDonBan);
                MessageBox.Show(msg);
                taidulieu();
                reset();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string sMaHang = "";
            string giaBanMin = "";
            string gianBanMax = "";
            string slBanMax = "";
            string slBanMin = "";

            if (checkb_TenHang.Checked)
                sMaHang = txt_MaHang.Text;

            if (checkb_GiaNhap.Checked)
            {
                giaBanMin = txt_giaBanMin.Text;
                gianBanMax = txt_giaBanMax.Text;
            }

            if (checkb_slNhap.Checked)
            {
                slBanMin = txt_SlBanMin.Text;
                slBanMax = txt_SLBanMax.Text;
            }

            (DataTable kq, string msg) = BLL_ChiTietHoaDonBan.get_by_query(
                cb_SoHD.Text, sMaHang, giaBanMin, gianBanMax, slBanMin, slBanMax);
            dgv_ChiTietBan.DataSource = kq;
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            taidulieu();
        }


        private bool check_input()
        {
            if (kiemTra && txt_MaHang.Text != "" && txt_SLBan.Text != "" && txt_GiaBan.Text != "" && cb_SoHD.Text != "")
                return true;

            return false;
        }


        private void reset_error()
        {
            errorProvider1.SetError(cb_TenHang, "");
            errorProvider1.SetError(txt_GiaBan, "");
            errorProvider1.SetError(txt_SLBan, "");
        }

        private void reset()
        {
            txtSLTon.Text = "";
            txt_GiaBan.Text = "";
            txt_giaBanMax.Text = "";
            txt_giaBanMin.Text = "";
            txt_MaHang.Text = "";
            txt_SLBan.Text = "";
            txt_SLBanMax.Text = "";
            txt_SlBanMin.Text = "";
            cb_TenHang.Text = "Lựa chọn";
            checkb_GiaNhap.Checked = false;
            checkb_slNhap.Checked = false;
            checkb_TenHang.Checked = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
            reset_error();
        }

        private bool ktraMatHangTonTai()
        {
            ChiTietHoaDonBan chiTietHoaDonBan = new ChiTietHoaDonBan(int.Parse(cb_SoHD.Text), txt_MaHang.Text);
            (bool kq, string msg) = BLL_ChiTietHoaDonBan.kra_mh_ton_tai(chiTietHoaDonBan);
            return kq;
        }

        private void cb_SoHD_KeyPress(object sender, KeyPressEventArgs e)
        {
            char char_LCB = e.KeyChar;

            if ((!Char.IsDigit(char_LCB) && char_LCB != 8 && char_LCB != 46) || char_LCB == '.')
                e.Handled = true;
        }

        private void txt_GiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            char char_LCB = e.KeyChar;

            if ((!Char.IsDigit(char_LCB) && char_LCB != 8 && char_LCB != 46) || char_LCB == '.')
                e.Handled = true;
        }

        private void txt_SLBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            char char_LCB = e.KeyChar;

            if ((!Char.IsDigit(char_LCB) && char_LCB != 8 && char_LCB != 46) || char_LCB == '.')
                e.Handled = true;
        }

        private bool kiemTra = true;

        private void cb_TenHang_Validating(object sender, CancelEventArgs e)
        {
            if(txt_MaHang.Text == "")
            {
                kiemTra = false;
                errorProvider1.SetError(cb_TenHang, "Chưa chọn mặt hàng");
            }
            else if(ktraMatHangTonTai())
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

        private void txt_GiaBan_Validating(object sender, CancelEventArgs e)
        {
            if(txt_GiaBan.Text == "")
            {
                kiemTra = false;
                errorProvider1.SetError(txt_GiaBan, "Giá bán không được để trống");
            }
            else
            {
                kiemTra = true;
                errorProvider1.SetError(txt_GiaBan, "");
            }
        }

        private void txt_SLBan_Validating(object sender, CancelEventArgs e)
        {
            if (txt_SLBan.Text == "")
            {
                kiemTra = false;
                errorProvider1.SetError(txt_SLBan, "Số lượng bán không được để trống");
                return;
            }
            else if (txtSLTon.Text != "" && int.Parse(txt_SLBan.Text) >= int.Parse(txtSLTon.Text))
            {
                kiemTra = false;
                errorProvider1.SetError(txt_SLBan, "Số lượng bán không được lớn hơn số lượng hàng tồn");
            }
            else
            {
                kiemTra = true;
                errorProvider1.SetError(txt_SLBan, "");
            }
        }

        private void txt_giaBanMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            char char_LCB = e.KeyChar;

            if ((!Char.IsDigit(char_LCB) && char_LCB != 8 && char_LCB != 46) || char_LCB == '.')
                e.Handled = true;
        }

        private void txt_SlBanMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            char char_LCB = e.KeyChar;

            if ((!Char.IsDigit(char_LCB) && char_LCB != 8 && char_LCB != 46) || char_LCB == '.')
                e.Handled = true;
        }

        private void txt_giaBanMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            char char_LCB = e.KeyChar;

            if ((!Char.IsDigit(char_LCB) && char_LCB != 8 && char_LCB != 46) || char_LCB == '.')
                e.Handled = true;
        }

        private void txt_SLBanMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            char char_LCB = e.KeyChar;

            if ((!Char.IsDigit(char_LCB) && char_LCB != 8 && char_LCB != 46) || char_LCB == '.')
                e.Handled = true;
        }
    }
}
