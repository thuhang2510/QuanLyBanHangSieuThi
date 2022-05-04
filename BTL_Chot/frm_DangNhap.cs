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
    public partial class frm_DangNhap : Form
    {
        DateTime loginDate;

        public frm_DangNhap()
        {
            InitializeComponent();
            loginDate = DateTime.Now;
        }

        private void dangNhap()
        {
            BLL_TaiKhoan bLL_TaiKhoan = new BLL_TaiKhoan();
            (bool kq, string msg) = bLL_TaiKhoan.dangNhap(new TaiKhoan(txt_tenDN.Text, txt_MK.Text));

            if (kq)
            {
                //MessageBox.Show(msg + " vào lúc: " + loginDate.ToString());
                frm_Main frm_Main = new frm_Main();
                this.Hide();
                frm_Main.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show(msg);
        }

        private void btn_DN_Click(object sender, EventArgs e)
        {
            dangNhap();
        }

        private void checkBox_HienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_HienMK.Checked)
                txt_MK.UseSystemPasswordChar = false;
            else
                txt_MK.UseSystemPasswordChar = true;
        }

        private void frm_DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            string sessionHours = (DateTime.Now - loginDate).ToString();
            //MessageBox.Show(sessionHours);
        }
    }
}
