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
    public partial class frm_KhachHang : Form
    {
        private BLL_KhachHang BLL_KhachHang;

        public frm_KhachHang()
        {
            InitializeComponent();
            BLL_KhachHang = new BLL_KhachHang();
        }

        private void taidulieu()
        {
            (DataTable kq, string msg) = BLL_KhachHang.get_all();
            dgv_KhachHang.DataSource = kq;
            dgv_KhachHang.Columns["bStatus"].Visible = false;
        }

        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            taidulieu();
        }

        private string change_bool_to_string(bool value)
        {
            if (value)
                return "Nam";

            return "Nữ";
        }

        private void dgv_KhachHang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var grid = (DataGridView)sender;
            if (grid.Columns[e.ColumnIndex].Name == "bGioiTinh")
            {
                if (e.Value != null)
                {
                    e.Value = change_bool_to_string((bool)e.Value);
                    e.FormattingApplied = true;
                }
            }
        }

        private void dgv_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            reset_error();
            if (-1 < e.RowIndex)
            {
                DataGridViewRow row = dgv_KhachHang.Rows[e.RowIndex];
                txt_MaKH.Text = Convert.ToString(row.Cells["iMaKH"].Value);
                txt_TenKH.Text = Convert.ToString(row.Cells["sTenKH"].Value);
                txt_DiaChi.Text = Convert.ToString(row.Cells["sDiaChi"].Value);
                mask_SDT.Text = Convert.ToString(row.Cells["sDienthoai"].Value);

                if ((bool)row.Cells["bGioiTinh"].Value)
                {
                    rb_Nam.Checked = true;
                    rb_Nu.Checked = false;
                }
                else
                {
                    rb_Nu.Checked = true;
                    rb_Nam.Checked = false;
                }
            }
        }

        private void reset_error()
        {
            kiemTra = true;
            errorProvider1.SetError(txt_DiaChi, "");
            errorProvider1.SetError(txt_MaKH, "");
            errorProvider1.SetError(txt_TenKH, "");
            errorProvider1.SetError(mask_SDT, "");
        }

        private void reset()
        {
            txt_MaKH.Text = "";
            txt_TenKH.Text = "";
            txt_DiaChi.Text = "";
            mask_SDT.Text = "";
            rb_Nam.Checked = false;
            rb_Nu.Checked = false;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            reset();
            reset_error();
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            taidulieu();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn tắt form?", "Thoát form", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
                Close();
        }

        private bool change_string_to_bool()
        {
            if (rb_Nam.Checked)
                return true;

            return false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            (bool ktra, string info) = check_input();

            if (ktra)
            {
                KhachHang khachHang = new KhachHang(int.Parse(txt_MaKH.Text), txt_TenKH.Text, txt_DiaChi.Text, mask_SDT.Text, change_string_to_bool());
                (int kq, string msg) = BLL_KhachHang.create(khachHang);
                MessageBox.Show(msg);
                taidulieu();
                reset();
            }
            else
                MessageBox.Show(info);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(txt_MaKH.Text == "")
            {
                MessageBox.Show("Bạn phải chọn khách hàng muốn sửa");
                return;
            }

            (bool ktra, string info) = check_input();

            if (ktra)
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    KhachHang khachHang = new KhachHang(int.Parse(txt_MaKH.Text), txt_TenKH.Text, txt_DiaChi.Text, mask_SDT.Text, change_string_to_bool());
                    (int kq, string msg) = BLL_KhachHang.update(khachHang);
                    MessageBox.Show(msg);
                    taidulieu();
                    reset();
                }
            }
            else
                MessageBox.Show(info);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txt_MaKH.Text == "")
            {
                MessageBox.Show("Bạn phải chọn khách hàng muốn xóa");
                return;
            }

            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                (int kq, string msg) = BLL_KhachHang.delete(int.Parse(txt_MaKH.Text));
                MessageBox.Show(msg);
                taidulieu();
                reset();
            }
        }

        private void txt_MaKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            char char_LCB = e.KeyChar;

            if ((!Char.IsDigit(char_LCB) && char_LCB != 8 && char_LCB != 46) || char_LCB == '.')
                e.Handled = true;
        }

        private bool kiemTra = true;

        private (bool, string) check_input()
        {
            if (kiemTra && txt_MaKH.Text != "" && txt_DiaChi.Text != "" && txt_TenKH.Text != "" && mask_SDT.Text != "")
                return (true, "");

            if (rb_Nam.Checked == false && rb_Nu.Checked == false)
                return (false, "Chưa chọn giới tính khách hàng");

            return (false, "Vui lòng kiểm tra các thông tin");
        }

        private bool kiemTraTrungMa()
        {
            (bool kq, string msg) = BLL_KhachHang.kiemTraTrungMa(int.Parse(txt_MaKH.Text));
            return kq;
        }

        private void txt_MaKH_Validating(object sender, CancelEventArgs e)
        {
            if(txt_MaKH.Text == "")
            {
                kiemTra = false;
                errorProvider1.SetError(txt_MaKH, "Mã khách hàng không được trống");
            }
            else if(kiemTraTrungMa())
            {
                kiemTra = false;
                errorProvider1.SetError(txt_MaKH, "Mã khách hàng đã tồn tại");
            }
            else
            {
                kiemTra = true;
                errorProvider1.SetError(txt_MaKH, "");
            }
        }

        private void txt_TenKH_Validating(object sender, CancelEventArgs e)
        {
            if (txt_TenKH.Text == "")
            {
                kiemTra = false;
                errorProvider1.SetError(txt_TenKH, "Tên khách hàng không được trống");
            }
            else
            {
                kiemTra = true;
                errorProvider1.SetError(txt_TenKH, "");
            }
        }

        private void txt_DiaChi_Validating(object sender, CancelEventArgs e)
        {
            if (txt_DiaChi.Text == "")
            {
                kiemTra = false;
                errorProvider1.SetError(txt_DiaChi, "Tên khách hàng không được trống");
            }
            else
            {
                kiemTra = true;
                errorProvider1.SetError(txt_DiaChi, "");
            }
        }

        private void mask_SDT_Validating(object sender, CancelEventArgs e)
        {
            if (!mask_SDT.MaskFull)
            {
                kiemTra = false;
                errorProvider1.SetError(mask_SDT, "SĐT khách hàng không được trống");
            }
            else
            {
                kiemTra = true;
                errorProvider1.SetError(mask_SDT, "");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sTenKH = "";
            string sDiaChi = "";
            string sSDT = "";
            bool? bGioiTinh = null;

            for (int i = 0; i < checklistbox.CheckedIndices.Count; ++i)
            {
                switch (checklistbox.CheckedIndices[i])
                {
                    case 0: sTenKH = txt_TenKH.Text; break;
                    case 1: sDiaChi = txt_DiaChi.Text; break;
                    case 2: sSDT = mask_SDT.Text; break;
                    case 3: bGioiTinh = change_string_to_bool(); break;
                }
            }

            (DataTable kq, string msg) = BLL_KhachHang.tim_kiem(sTenKH, sDiaChi, sSDT, bGioiTinh);
            dgv_KhachHang.DataSource = kq;
            MessageBox.Show(msg);
        }

        private void checklistbox_Click(object sender, EventArgs e)
        {
            reset_error();
        }
    }
}
