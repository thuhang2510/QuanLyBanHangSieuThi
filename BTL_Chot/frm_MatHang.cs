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
    public partial class frm_MatHang : Form
    {
        private BLL_MatHang BLL_MatHang;

        public frm_MatHang()
        {
            InitializeComponent();
            BLL_MatHang = new BLL_MatHang();
        }

        private void taidulieu()
        {
            (DataTable kq, string msg) = BLL_MatHang.get_all();
            dgv_mathang.DataSource = kq;
            dgv_mathang.Columns["bStatus"].Visible = false;
        }

        private void layDSLoaiHang()
        {
            (DataTable kq, string msg) = new BLL_LoaiHang().get_all();
            cb_TenLoaiHang.DataSource = kq;
            cb_TenLoaiHang.DisplayMember = "sTenLH";
            cb_TenLoaiHang.ValueMember = "sMaLH";
            cb_TenLoaiHang.AutoCompleteMode = AutoCompleteMode.Suggest;
            cb_TenLoaiHang.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_TenLoaiHang.Text = "Lựa chọn";
            txt_MaLoaiHang.Text = "";
        }

        private void frm_MatHang_Load(object sender, EventArgs e)
        {
            taidulieu();
            layDSLoaiHang();
        }

        private void cb_TenLoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_MaLoaiHang.Text = cb_TenLoaiHang.SelectedValue.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (kiemTra_Input())
            {
                MatHang matHang = new MatHang(
                txtMaHang.Text, txtTenHang.Text, txtTenNCC.Text, txt_MaLoaiHang.Text, float.Parse(txtSL.Text), float.Parse(txtGiaHang.Text));
                (int kq, string msg) = BLL_MatHang.create(matHang);
                MessageBox.Show(msg);
                taidulieu();
                reset();
            }
            else
                MessageBox.Show("Vui lòng kiểm tra tất cả các thông tin");
        }

        private void dgv_mathang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            reset_error();
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = dgv_mathang.Rows[e.RowIndex];
                txtMaHang.Text = row.Cells["sMaHang"].Value.ToString();
                txtTenHang.Text = row.Cells["sTenHang"].Value.ToString();
                txtTenNCC.Text = row.Cells["sTenNCC"].Value.ToString();
                txtSL.Text = row.Cells["fSoLuong"].Value.ToString();
                txtGiaHang.Text = row.Cells["fGiaHang"].Value.ToString();
                txt_MaLoaiHang.Text = row.Cells["sMaLH"].Value.ToString();
                cb_TenLoaiHang.Text = row.Cells["sTenLH"].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(txtMaHang.Text == "")
            {
                MessageBox.Show("Bạn cần chọn mặt hàng muốn sửa trước");
                return;
            }

            if(kiemTra_Input())
            {
                if(DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    MatHang matHang = new MatHang(
                        txtMaHang.Text, txtTenHang.Text, txtTenNCC.Text, txt_MaLoaiHang.Text, float.Parse(txtSL.Text), float.Parse(txtGiaHang.Text));
                    (int kq, string msg) = BLL_MatHang.update(matHang);
                    MessageBox.Show(msg);
                    taidulieu();
                    reset();
                }
            }
            else
                MessageBox.Show("Vui lòng kiểm tra tất cả các thông tin");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text == "")
            {
                MessageBox.Show("Bạn cần chọn mặt hàng muốn xóa trước");
                return;
            }

            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                (int kq, string msg) = BLL_MatHang.delete(txtMaHang.Text);
                MessageBox.Show(msg);
                taidulieu();
                reset();
            }
        }

        private void reset()
        {
            txtMaHang.Text = "";
            txtGiaHang.Text = "";
            txtSL.Text = "";
            txtTenHang.Text = "";
            txtTenNCC.Text = "";
            txt_MaLoaiHang.Text = "";
            cb_TenLoaiHang.Text = "Lựa chọn";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
            reset_error();
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            char char_LCB = e.KeyChar;

            if ((!Char.IsDigit(char_LCB) && char_LCB != 8 && char_LCB != 46) || char_LCB == '.')
                e.Handled = true;
        }

        private void txtGiaHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            char char_LCB = e.KeyChar;

            if ((!Char.IsDigit(char_LCB) && char_LCB != 8 && char_LCB != 46) || char_LCB == '.')
                e.Handled = true;
        }

        private bool kTra = true;

        private bool kiemTra_Input()
        {
            if (kTra && txtGiaHang.Text != "" && txtMaHang.Text != "" && txtSL.Text != "" && txtTenHang.Text != "" && txtTenNCC.Text != "" && txt_MaLoaiHang.Text != "")
                return true;

            return false;
        }

        private void reset_error()
        {
            kTra = true;
            errorProvider1.SetError(txtMaHang, "");
            errorProvider1.SetError(cb_TenLoaiHang, "");
            errorProvider1.SetError(txtTenNCC, "");
            errorProvider1.SetError(txtTenHang, "");
            errorProvider1.SetError(txtSL, "");
            errorProvider1.SetError(txtGiaHang, "");
        }

        private bool kTraMaTrung()
        {
            (bool kq, string msg) = BLL_MatHang.ktra_trung_ma_mat_hang(txtMaHang.Text);
            return kq;
        }

        private void txtMaHang_Validating(object sender, CancelEventArgs e)
        {
            if(txtMaHang.Text == "")
            {
                errorProvider1.SetError(txtMaHang, "Mã hàng không được để trống");
                kTra = false;
            }
            else if(kTraMaTrung())
            {
                errorProvider1.SetError(txtMaHang, "Mã hàng không được trùng nhau");
                kTra = false;
            }
            else
            {
                errorProvider1.SetError(txtMaHang, "");
                kTra = true;
            }
        }

        private void txtTenHang_Validating(object sender, CancelEventArgs e)
        {
            if (txtTenHang.Text == "")
            {
                errorProvider1.SetError(txtTenHang, "Tên hàng không được để trống");
                kTra = false;
            }
            else
            {
                errorProvider1.SetError(txtTenHang, "");
                kTra = true;
            }
        }

        private void txtTenNCC_Validating(object sender, CancelEventArgs e)
        {
            if (txtTenNCC.Text == "")
            {
                errorProvider1.SetError(txtTenNCC, "Tên nhà cung cấp không được để trống");
                kTra = false;
            }
            else
            {
                errorProvider1.SetError(txtTenNCC, "");
                kTra = true;
            }
        }

        private void cb_TenLoaiHang_Validating(object sender, CancelEventArgs e)
        {
            if (txt_MaLoaiHang.Text == "")
            {
                errorProvider1.SetError(cb_TenLoaiHang, "Vui lòng chọn tên loại hàng");
                kTra = false;
            }
            else
            {
                errorProvider1.SetError(cb_TenLoaiHang, "");
                kTra = true;
            }
        }

        private void txtSL_Validating(object sender, CancelEventArgs e)
        {
            if (txtSL.Text == "")
            {
                errorProvider1.SetError(txtSL, "Mã số lượng không được để trống");
                kTra = false;
            }
            else
            {
                errorProvider1.SetError(txtSL, "");
                kTra = true;
            }
        }

        private void txtGiaHang_Validating(object sender, CancelEventArgs e)
        {
            if (txtGiaHang.Text == "")
            {
                errorProvider1.SetError(txtGiaHang, "Mã giá hàng không được để trống");
                kTra = false;
            }
            else
            {
                errorProvider1.SetError(txtGiaHang, "");
                kTra = true;
            }
        }
    }
}
