using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTL_Chot.DAL;
using BTL_Chot.DTO;

namespace BTL_Chot.BLL
{
    class BLL_KhachHang
    {
        private DAL_KhachHang DAL_KhachHang;

        public BLL_KhachHang()
        {
            DAL_KhachHang = new DAL_KhachHang();
        }

        public (DataTable, string) get_all_have_description()
        {
            try
            {
                return DAL_KhachHang.get_all_have_description();
            }
            catch (Exception e)
            {
                return (null, e.Message);
            }
        }

        public (DataTable, string) get_all()
        {
            try
            {
                return DAL_KhachHang.get_all();
            }
            catch (Exception e)
            {
                return (null, e.Message);
            }
        }

        public (int, string) create(KhachHang khachHang)
        {
            try
            {
                return DAL_KhachHang.create(khachHang);
            }
            catch (Exception e)
            {
                return (-1, e.Message);
            }
        }

        public (int, string) update(KhachHang khachHang)
        {
            try
            {
                return DAL_KhachHang.update(khachHang);
            }
            catch (Exception e)
            {
                return (-1, e.Message);
            }
        }

        public (int, string) delete(int maKH)
        { 
            try
            {
                return DAL_KhachHang.delete(maKH);
            }
            catch (Exception e)
            {
                return (-1, e.Message);
            }
        }

        public (bool, string) kiemTraTrungMa(int iMaKH)
        {
            try
            {
                (DataTable kq, string msg) = DAL_KhachHang.get_by_id(iMaKH);

                if (kq.Rows.Count > 0)
                    return (true, "Mã khách hàng đã tồn tại");

                return (false, "Mã khách hàng chưa tồn tại");
            }
            catch (Exception e)
            {
                return (true, e.Message);
            }
        }

        public (DataTable, string) tim_kiem(string sTenKH, string sDiaChi, string sSDT, bool? bGioiTinh)
        {
            try
            {
                return DAL_KhachHang.tim_kiem(sTenKH, sDiaChi, sSDT, bGioiTinh);
            }
            catch (Exception e)
            {
                return (null, e.Message);
            }
        }
    }
}
