using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTL_Chot.DAL;
using BTL_Chot.DTO;

namespace BTL_Chot.BLL
{
    class BLL_TaiKhoan
    {
        private DAL_TaiKhoan DAL_TaiKhoan;

        public BLL_TaiKhoan()
        {
            DAL_TaiKhoan = new DAL_TaiKhoan();
        }

        public (bool, string) dangNhap(TaiKhoan taiKhoan)
        {
            try
            {
                (string tenTK, string mk) = DAL_TaiKhoan.dangNhap(taiKhoan);

                if (tenTK != null && mk != null)
                    return (true, "đăng nhập thành công");

                return (false, "Tài khoản này không tồn tại");
            }
            catch(Exception e)
            {
                return (false, e.Message);
            }
        }

        public (int, string) doiMK(TaiKhoan taiKhoan)
        {
            try
            {
                return DAL_TaiKhoan.update(taiKhoan);
            }
            catch (Exception e)
            {
                return (-1, e.Message);
            }
        }
    }
}
