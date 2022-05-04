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
    public partial class frm_LoaiHang : Form
    {
        private BLL_LoaiHang BLL_LoaiHang;

        public frm_LoaiHang()
        {
            InitializeComponent();
            BLL_LoaiHang = new BLL_LoaiHang();
        }

        private void taidulieu()
        {
            (DataTable kq, string msg) = BLL_LoaiHang.get_all();
            dgv_LoaiHang.DataSource = kq;
            dgv_LoaiHang.Columns["bStatus"].Visible = false;
        }

        private void frm_LoaiHang_Load(object sender, EventArgs e)
        {
            taidulieu();
        }

        private bool ktraMaLoaiHang()
        {
            (bool kq, string msg) = BLL_LoaiHang.ktrMaLoaiHang(txt_MaLoaiHang.Text);
            return kq;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ktraMaLoaiHang())
            {
                MessageBox.Show("Mã loại hàng đã tồn tại");
            }
            else if (check_input())
            {
                LoaiHang loaiHang = new LoaiHang(txt_MaLoaiHang.Text, txtTenLoaiHang.Text);
                (int kq, string msg) = BLL_LoaiHang.create(loaiHang);
                MessageBox.Show(msg);
                taidulieu();
                reset();
            }
            else
                MessageBox.Show("Kiểm tra lại dữ liệu");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(txt_MaLoaiHang.Text == "")
            {
                MessageBox.Show("Bạn cần chọn loại hàng trước khi sửa");
                return;
            }

            if(check_input())
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    LoaiHang loaiHang = new LoaiHang(txt_MaLoaiHang.Text, txtTenLoaiHang.Text);
                    (int kq, string msg) = BLL_LoaiHang.update(loaiHang);
                    MessageBox.Show(msg);
                    taidulieu();
                    reset();
                }
            }
            else
                MessageBox.Show("Kiểm tra lại dữ liệu");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txt_MaLoaiHang.Text == "")
            {
                MessageBox.Show("Bạn cần chọn loại hàng trước khi xóa");
                return;
            }

            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                (int kq, string msg) = BLL_LoaiHang.delete(txt_MaLoaiHang.Text);
                MessageBox.Show(msg);
                taidulieu();
                reset();
            }
    }

        private bool ktra = true;

        private bool check_input()
        {
            if (ktra && txtTenLoaiHang.Text != "" && txt_MaLoaiHang.Text != "")
                return true;

            return false;
        }

        private void txt_MaLoaiHang_Validating(object sender, CancelEventArgs e)
        {
            if(txt_MaLoaiHang.Text == "")
            {
                ktra = false;
                errorProvider1.SetError(txt_MaLoaiHang, "Mã loại hàng không được để trống");
            }
            else if(ktraMaLoaiHang())
            {
                ktra = false;
                errorProvider1.SetError(txt_MaLoaiHang, "Mã loại hàng đã tồn tại");
            }
            else
            {
                ktra = true;
                errorProvider1.SetError(txt_MaLoaiHang, "");
            }
        }

        private void txtTenLoaiHang_Validating(object sender, CancelEventArgs e)
        {
            if (txtTenLoaiHang.Text == "")
            {
                ktra = false;
                errorProvider1.SetError(txtTenLoaiHang, "Tên loại hàng không được để trống");
            }
            else
            {
                ktra = true;
                errorProvider1.SetError(txtTenLoaiHang, "");
            }
        }

        private void reset_error()
        {
            ktra = true;
            errorProvider1.SetError(txt_MaLoaiHang, "");
            errorProvider1.SetError(txtTenLoaiHang, "");
        }

        private void reset()
        {
            txtTenLoaiHang.Text = "";
            txt_MaLoaiHang.Text = "";
        }

        private void dgv_LoaiHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            reset_error();
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = dgv_LoaiHang.Rows[e.RowIndex];
                txt_MaLoaiHang.Text = row.Cells["sMaLH"].Value.ToString();
                txtTenLoaiHang.Text = row.Cells["sTenLH"].Value.ToString();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
            reset_error();
        }
    }
}
