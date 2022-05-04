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
    public partial class frm_HoaDonBan : Form
    {
        private BLL_HoaDonBan BLL_HoaDonBan;

        public frm_HoaDonBan()
        {
            InitializeComponent();
            BLL_HoaDonBan = new BLL_HoaDonBan();
            d_NgayLap.MaxDate = DateTime.Now;
        }

        private void taidulieu()
        {
            (DataTable kq, string msg) = BLL_HoaDonBan.get_all();
            dgv_HDBan.DataSource = kq;
            dgv_HDBan.Columns["iMaKH"].Visible = false;
            dgv_HDBan.Columns["iMaNV"].Visible = false;
            dgv_HDBan.Columns["sDTNV"].Visible = false;
            dgv_HDBan.Columns["sDTKH"].Visible = false;
        }

        private void layDSNV()
        {
            BLL_NhanVien bLL_NhanVien = new BLL_NhanVien();
            (DataTable kq, string msg) = bLL_NhanVien.get_all_have_description();
            cb_NhanVien.DataSource = kq;
            cb_NhanVien.AutoCompleteMode = AutoCompleteMode.Suggest;
            cb_NhanVien.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_NhanVien.DisplayMember = "Description";
            cb_NhanVien.ValueMember = "iMaNV";
            cb_NhanVien.Text = "Lựa chọn";
            txt_MaNV.Text = "";
        }

        private void layDSKH()
        {
            BLL_KhachHang bLL_KhachHang = new BLL_KhachHang();
            (DataTable kq, string msg) = bLL_KhachHang.get_all_have_description();
            cb_KhachHang.DataSource = kq;
            cb_KhachHang.AutoCompleteMode = AutoCompleteMode.Suggest;
            cb_KhachHang.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_KhachHang.DisplayMember = "Description";
            cb_KhachHang.ValueMember = "iMaKH";
            cb_KhachHang.Text = "Lựa chọn";
            txt_MaKH.Text = "";
        }

        private void frm_HoaDonBan_Load(object sender, EventArgs e)
        {
            taidulieu();
            layDSNV();
            layDSKH();
        }

        private void cb_NhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_MaNV.Text = cb_NhanVien.SelectedValue.ToString();
        }

        private void cb_KhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_MaKH.Text = cb_KhachHang.SelectedValue.ToString();
        }

        private void dgv_HDBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            reset_error();
            if (-1 < e.RowIndex)
            {
                DataGridViewRow row = dgv_HDBan.Rows[e.RowIndex];
                txt_SoHD.Text = row.Cells["iSoHD"].Value.ToString();
                cb_NhanVien.Text = row.Cells["sTenNV"].Value.ToString() + " - " + row.Cells["sDTNV"].Value.ToString();
                txt_MaNV.Text = row.Cells["iMaNV"].Value.ToString();
                cb_KhachHang.Text = row.Cells["sTenKH"].Value.ToString() + " - " + row.Cells["sDTKH"].Value.ToString();
                txt_MaKH.Text = row.Cells["iMaKH"].Value.ToString();
                d_NgayLap.Value = Convert.ToDateTime(row.Cells["dNgaymuahang"].Value);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            taidulieu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (check_Input())
            {
                HoaDonBan hoaDonBan = new HoaDonBan(int.Parse(txt_SoHD.Text), int.Parse(txt_MaNV.Text), int.Parse(txt_MaKH.Text), d_NgayLap.Value);
                (int kq, string msg) = BLL_HoaDonBan.create(hoaDonBan);
                MessageBox.Show(msg);
                taidulieu();
                reset();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txt_SoHD.Text == "")
            {
                MessageBox.Show("Bạn cần chọn hóa đơn muốn xóa trước", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn xóa hóa đơn này không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                (int kq, string msg) = BLL_HoaDonBan.delete(int.Parse(txt_SoHD.Text));
                MessageBox.Show(msg);
                taidulieu();
                reset();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txt_SoHD.Text == "")
            {
                MessageBox.Show("Bạn cần chọn hóa đơn muốn sửa trước", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn sửa hóa đơn này không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (check_Input())
                {
                    HoaDonBan hoaDonBan = new HoaDonBan(int.Parse(txt_SoHD.Text), int.Parse(txt_MaNV.Text), int.Parse(txt_MaKH.Text), d_NgayLap.Value);
                    (int kq, string msg) = BLL_HoaDonBan.update(hoaDonBan);
                    MessageBox.Show(msg);
                    taidulieu();
                    reset();
                }
                else
                {
                    MessageBox.Show("Bạn cần kiểm tra lại thông tin trước khi sửa");
                }
            }
        }

        private void reset_error()
        {
            kiemTra = true;
            errorProvider1.SetError(txt_SoHD, "");
            errorProvider1.SetError(cb_KhachHang, "");
            errorProvider1.SetError(cb_NhanVien, "");
        }

        public void reset()
        {
            txt_SoHD.Text = "";
            txt_MaNV.Text = "";
            txt_MaKH.Text = "";
            cb_KhachHang.Text = "Lựa chọn";
            cb_NhanVien.Text = "Lựa chọn";
            d_NgayLap.Value = DateTime.Today;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
            reset_error();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            reset_error();
            string maNV = "";
            string maKH = "";
            DateTime? ngayLap = null;

            if (checkb_TenNV.Checked)
                maNV = txt_MaNV.Text;

            if (checkb_TenKH.Checked)
                maKH = txt_MaKH.Text;

            if (checkb_NgayLap.Checked)
                ngayLap = d_NgayLap.Value;

            (DataTable kq, string msg) = BLL_HoaDonBan.get_by_query(maNV, maKH, ngayLap);
            MessageBox.Show(msg);
            dgv_HDBan.DataSource = kq;
        }

        private bool kiemTraTrungSoHD()
        {
            (bool kq, string msg) = BLL_HoaDonBan.kiem_tra_trung_soHD(int.Parse(txt_SoHD.Text));
            return kq;
        }

        private bool kiemTra = true;

        private bool check_Input()
        {
            if (kiemTra && txt_MaNV.Text != "" && txt_MaKH.Text != "")
                return true;

            return false;
        }

        private void txt_SoHD_Validating(object sender, CancelEventArgs e)
        {
            if(txt_SoHD.Text == "")
            {
                kiemTra = false;
                errorProvider1.SetError(txt_SoHD, "Số hóa đơn không được trống");
            }
            else if(kiemTraTrungSoHD())
            {
                kiemTra = false;
                errorProvider1.SetError(txt_SoHD, "Số hóa đơn đã bị trùng");
            }
            else
            {
                kiemTra = true;
                errorProvider1.SetError(txt_SoHD, "");
            }
        }

        private void txt_SoHD_KeyPress(object sender, KeyPressEventArgs e)
        {
            char char_LCB = e.KeyChar;

            if ((!Char.IsDigit(char_LCB) && char_LCB != 8 && char_LCB != 46) || char_LCB == '.')
                e.Handled = true;
        }

        private void cb_NhanVien_Validating(object sender, CancelEventArgs e)
        {
            if(txt_MaNV.Text == "")
            {
                kiemTra = false;
                errorProvider1.SetError(cb_NhanVien, "Vui lòng chọn nhân viên");
            }
            else
            {
                kiemTra = true;
                errorProvider1.SetError(cb_NhanVien, "");
            }
        }

        private void cb_KhachHang_Validating(object sender, CancelEventArgs e)
        {
            if (txt_MaKH.Text == "")
            {
                kiemTra = false;
                errorProvider1.SetError(cb_KhachHang, "Vui lòng chọn khách hàng");
            }
            else
            {
                kiemTra = true;
                errorProvider1.SetError(cb_KhachHang, "");
            }
        }

        private void btn_CTHD_Click(object sender, EventArgs e)
        {
            if(txt_SoHD.Text == "")
            {
                MessageBox.Show("Bạn cần chọn hóa đơn muốn xem chi tiết trước");
                return;
            }

            if (kiemTraTrungSoHD())
            {
                frm_ChiTietHDBan frm_ChiTietHDBan = new frm_ChiTietHDBan(int.Parse(txt_SoHD.Text));
                frm_ChiTietHDBan.MdiParent = this.MdiParent;
                frm_ChiTietHDBan.Show();
            }
            else
                MessageBox.Show("Mã hóa đơn không tồn tại");
            
        }
    }
}
