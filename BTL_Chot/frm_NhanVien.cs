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
    public partial class frm_NhanVien : Form
    {
        BLL_NhanVien bll_NhanVien;

        public frm_NhanVien()
        {
            InitializeComponent();
            bll_NhanVien = new BLL_NhanVien();
            d_NgaySinh.MaxDate = DateTime.Now;
            d_NgayVaoLam.MaxDate = DateTime.Now;
        }

        private void taiDuLieu()
        {
            (DataTable kq, string msg) = bll_NhanVien.get_all();
            dgv_NhanVien.DataSource = kq;
            dgv_NhanVien.Columns["bStatus"].Visible = false;
        }


        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            taiDuLieu();
        }

        private string change_bool_to_string(bool value)
        {
            if (value)
                return "Nam";

            return "Nữ";
        }

        private void dgv_NhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var grid = (DataGridView)sender;
            if (grid.Columns[e.ColumnIndex].Name == "bGioiTinh")
            {
                if (e.Value != null)
                {
                    e.Value = change_bool_to_string((bool)e.Value);
                    e.FormattingApplied = true;
                }
                else
                {
                    e.Value = "";
                    e.FormattingApplied = true;
                }
            }
        }

        private void btn_LoadNV_Click(object sender, EventArgs e)
        {
            taiDuLieu();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if(kiemTraDauVao())
            {
                NhanVien nhanVien = new NhanVien(int.Parse(txt_MaNV.Text), txt_TenNV.Text, txt_DiaChi.Text, 
                    masktxt_SDTNV.Text, d_NgaySinh.Value, d_NgayVaoLam.Value, float.Parse(txt_LuongCB.Text));

                (int _, string msg) = bll_NhanVien.create(nhanVien);

                MessageBox.Show(msg);
                taiDuLieu();
                reset();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txt_MaNV.Text == "")
            {
                MessageBox.Show("Bạn cần phải chọn nhân viên cần xóa trước", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (kiemTraDauVao())
            {
                DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn sửa chứ?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    NhanVien nhanVien = new NhanVien(int.Parse(txt_MaNV.Text), txt_TenNV.Text, txt_DiaChi.Text,
                        masktxt_SDTNV.Text, d_NgaySinh.Value, d_NgayVaoLam.Value, float.Parse(txt_LuongCB.Text));

                    (int _, string msg) = bll_NhanVien.update(nhanVien);

                    MessageBox.Show(msg);
                    taiDuLieu();
                    reset();
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if(txt_MaNV.Text == "")
            {
                MessageBox.Show("Bạn cần phải chọn nhân viên cần xóa trước", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn xóa chứ?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                (int _, string msg) = bll_NhanVien.delete(int.Parse(txt_MaNV.Text));
                MessageBox.Show(msg);
                taiDuLieu();
                reset();
            }
        }

        private void dgv_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            reset_error();
            if (-1 < e.RowIndex)
            {
                DataGridViewRow row = dgv_NhanVien.Rows[e.RowIndex];
                txt_MaNV.Text = Convert.ToString(row.Cells["MaNV"].Value);
                txt_TenNV.Text = Convert.ToString(row.Cells["TenNV"].Value);
                txt_DiaChi.Text = Convert.ToString(row.Cells["DiaChiNV"].Value);
                masktxt_SDTNV.Text = Convert.ToString(row.Cells["SDT_NV"].Value);
                d_NgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                d_NgayVaoLam.Value = Convert.ToDateTime(row.Cells["NgayVaoLam"].Value);
                txt_LuongCB.Text = Convert.ToString(row.Cells["LCB"].Value);
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string tenNV = "";
            string diaChi = "";
            string sdt = "";
            DateTime? ngayVaoLam = null;
            DateTime? ngaySinh = null;

            for (int i = 0; i < checkedListBox_TimKiem.CheckedIndices.Count; ++i)
            {
                switch (checkedListBox_TimKiem.CheckedIndices[i])
                {
                    case 0: tenNV = txt_TenNV.Text; break;
                    case 1: diaChi = txt_DiaChi.Text; break;
                    case 2: ngaySinh = d_NgaySinh.Value; break;
                    case 3: ngayVaoLam = d_NgayVaoLam.Value; break;
                    case 4: sdt = masktxt_SDTNV.Text; break;
                }
            }

            (DataTable kq, string msg) = bll_NhanVien.get_by_query(tenNV, diaChi, sdt, ngaySinh, ngayVaoLam);
            dgv_NhanVien.DataSource = kq;
            MessageBox.Show(msg);
        }

        private void reset_error()
        {
            dieuKien = true;
            errorProvider1.SetError(txt_MaNV, "");
            errorProvider1.SetError(txt_TenNV, "");
            errorProvider1.SetError(txt_DiaChi, "");
            errorProvider1.SetError(masktxt_SDTNV, "");
            errorProvider1.SetError(txt_LuongCB, "");
        }

        private void reset()
        {
            txt_MaNV.Text = "";
            txt_TenNV.Text = "";
            txt_DiaChi.Text = "";
            masktxt_SDTNV.Text = "";
            d_NgaySinh.Value = new DateTime(2004, 3, 8);
            d_NgayVaoLam.Value = new DateTime(2022, 3, 8);
            txt_LuongCB.Text = "";

            for (int i = 0; i < checkedListBox_TimKiem.Items.Count; ++i)
                checkedListBox_TimKiem.SetItemChecked(i, false);
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            reset();
            reset_error();
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn tắt form Nhân viên?", "Thoát form", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
                Close();
        }

        private void txt_LuongCB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char char_LCB = e.KeyChar;

            if (!Char.IsDigit(char_LCB) && char_LCB != 8 && char_LCB != 46)
                e.Handled = true;
        }

        private void txt_MaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            char char_LCB = e.KeyChar;

            if (char_LCB == (char)Keys.Enter)
                txt_TenNV.Focus();
            else if (!Char.IsDigit(char_LCB) && char_LCB != 8 && char_LCB != 46)
                e.Handled = true;
        }

        private void txt_TenNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                txt_DiaChi.Focus();
        }

        private void txt_DiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                masktxt_SDTNV.Focus();
        }

        private void masktxt_SDTNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                d_NgaySinh.Focus();
        }

        private void d_NgaySinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                d_NgayVaoLam.Focus();
        }

        private void d_NgayVaoLam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                txt_LuongCB.Focus();
        }


        private bool kiemTraTrungMaNV()
        {
            string kq = bll_NhanVien.get_name(int.Parse(txt_MaNV.Text));

            if (kq == null)
                return false;

            return true;
        }

        private bool dieuKien = true;

        private bool isAge18()
        {
            DateTime ngaySinh = d_NgaySinh.Value;
            DateTime ngayVaoLam = d_NgayVaoLam.Value;

            if (ngaySinh > DateTime.Now)
            {
                MessageBox.Show("Ngày sinh lớn hơn ngày hiện tại");
                return false;
            }

            if (ngaySinh > ngayVaoLam)
            {
                MessageBox.Show("Ngày sinh lớn hơn ngày vào làm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            TimeSpan timeSpan = ngayVaoLam - ngaySinh;
            DateTime age = DateTime.MinValue.AddDays(timeSpan.Days);

            if (age.Year - 1 < 18)
            {
                MessageBox.Show("Nhân viên phải có độ tuổi từ 18", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool ktraGioiTinh()
        {
            /*if (rbtn_Nam.Checked || rbtn_Nu.Checked)
                return true;

            MessageBox.Show("Vui lòng chọn giới tính");
            return false;*/
            return true;
        }

        private bool kiemTraDauVao()
        {
            if (isAge18() && dieuKien && ktraGioiTinh())
                return true;

            if (!dieuKien)
                MessageBox.Show("Bạn cần kiểm tra lại thông tin");

            return false;
        }


        private void txt_MaNV_Validating(object sender, CancelEventArgs e)
        {
            if(txt_MaNV.Text == "")
            {
                dieuKien = false;
                errorProvider1.SetError(txt_MaNV, "Mã nhân viên không được trống");
            }
            else if(kiemTraTrungMaNV())
            {
                dieuKien = false;
                errorProvider1.SetError(txt_MaNV, "Mã nhân viên đã tồn tại");
            }
            else
            {
                dieuKien = true;
                errorProvider1.SetError(txt_MaNV, "");
            }
        }

        private void txt_TenNV_Validating(object sender, CancelEventArgs e)
        {
            if(txt_TenNV.Text == "")
            {
                dieuKien = false;
                errorProvider1.SetError(txt_TenNV, "Tên nhân viên không được trống");
            }
            else
            {
                dieuKien = true;
                errorProvider1.SetError(txt_TenNV, "");
            }
        }

        private void txt_DiaChi_Validating(object sender, CancelEventArgs e)
        {
            if (txt_DiaChi.Text == "")
            {
                dieuKien = false;
                errorProvider1.SetError(txt_DiaChi, "Địa chỉ nhân viên không được trống");
            }
            else
            {
                dieuKien = true;
                errorProvider1.SetError(txt_DiaChi, "");
            }
        }

        private void masktxt_SDTNV_Validating(object sender, CancelEventArgs e)
        {
            if (!masktxt_SDTNV.MaskFull)
            {
                dieuKien = false;
                errorProvider1.SetError(masktxt_SDTNV, "SĐT nhân viên không được trống");
            }
            else
            {
                dieuKien = true;
                errorProvider1.SetError(masktxt_SDTNV, "");
            }
        }

        private void txt_LuongCB_Validating(object sender, CancelEventArgs e)
        {
            if (txt_LuongCB.Text == "")
            {
                dieuKien = false;
                errorProvider1.SetError(txt_LuongCB, "Lương cơ bản không được trống");
            }
            else if(float.Parse(txt_LuongCB.Text) <= 0)
            {
                dieuKien = false;
                errorProvider1.SetError(txt_LuongCB, "Lương cơ bản phải lớn hơn 0");
            }
            else
            {
                dieuKien = true;
                errorProvider1.SetError(txt_LuongCB, "");
            }
        }

        private void btnInDSNV_Click(object sender, EventArgs e)
        {
            report.report_DSNV report_DSNV = new report.report_DSNV();
            report_DSNV.Show();
            report_DSNV.MdiParent = this.MdiParent;
        }
    }
}
