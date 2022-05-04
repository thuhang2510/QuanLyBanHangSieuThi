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
    class BLL_ChiTietNhapHang
    {
        private DAL_ChiTietHoaDonNhap DAL_ChiTietHoaDonNhap;

        public BLL_ChiTietNhapHang()
        {
            DAL_ChiTietHoaDonNhap = new DAL_ChiTietHoaDonNhap();
        }

        public (DataTable, string) get_by_id(int iSoHD)
        {
            try
            {
                return DAL_ChiTietHoaDonNhap.get_by_id(iSoHD);
            }
            catch(Exception e)
            {
                return (null, "occurred: " + e.Message);
            }
        }

        public (int, string) create(ChiTietHoaDonNhap chiTietHoaDonNhap)
        {
            try
            {
                return DAL_ChiTietHoaDonNhap.create(chiTietHoaDonNhap);
            }
            catch(Exception e)
            {
                return (-1, "occurred: " + e.Message);
            }
        }

        public (int, string) update(ChiTietHoaDonNhap chiTietHoaDonNhap)
        {
            try
            {
                return DAL_ChiTietHoaDonNhap.update(chiTietHoaDonNhap);
            }
            catch(Exception e)
            {
                return (-1, "occurred: " + e.Message);
            }
        }

        public (int, string) delete(int iSoHD, string sMaHang)
        {
            try
            {
                return DAL_ChiTietHoaDonNhap.delete(iSoHD, sMaHang);
            }
            catch (Exception e)
            {
                return (-1, "occurred: " + e.Message);
            }
        }

        public (DataTable, string) get_by_query(string iSoHD, string sMaHang, string giaNhapMin, string giaNhapMax, string slNhapMin, string slNhapMax)
        {
            try
            {
                return DAL_ChiTietHoaDonNhap.get_by_query(iSoHD, sMaHang, giaNhapMin, giaNhapMax, slNhapMin, slNhapMax);
            }
            catch (Exception e)
            {
                return (null, "occurred: " + e.Message);
            }
        }

        public (bool, string) kra_mh_ton_tai(ChiTietHoaDonNhap chiTietHoaDonNhap)
        {
            try
            {
                (DataTable kq, string msg) = DAL_ChiTietHoaDonNhap.get_by_query(chiTietHoaDonNhap);
                if (kq.Rows.Count > 0)
                    return (true, "Mặt hàng này đã tồn tại");
                return (false, "Chưa có mặt hàng này");
            }
            catch (Exception e)
            {
                return (true, e.Message);
            }
        }
    }
}
