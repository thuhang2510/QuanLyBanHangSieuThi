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
    class BLL_ChiTietHoaDonBan
    {
        private DAL_ChiTietHoaDonBan DAL_ChiTietHoaDonBan;

        public BLL_ChiTietHoaDonBan()
        {
            DAL_ChiTietHoaDonBan = new DAL_ChiTietHoaDonBan();
        }

        public (DataTable, string) get_by_id(int iSoHD)
        {
            try
            {
                return DAL_ChiTietHoaDonBan.get_by_id(iSoHD);
            }
            catch(Exception e)
            {
                return (null, e.Message);
            }
        }

        public (int, string) create(ChiTietHoaDonBan chiTietHoaDonBan)
        {
            try
            {
                return DAL_ChiTietHoaDonBan.create(chiTietHoaDonBan);
            }
            catch (Exception e)
            {
                return (-1, e.Message);
            }
        }

        public (int, string) update(ChiTietHoaDonBan chiTietHoaDonBan)
        {
            try
            {
                return DAL_ChiTietHoaDonBan.update(chiTietHoaDonBan);
            }
            catch (Exception e)
            {
                return (-1, e.Message);
            }
        }

        public (int, string) delete(ChiTietHoaDonBan chiTietHoaDonBan)
        {
            try
            {
                return DAL_ChiTietHoaDonBan.delete(chiTietHoaDonBan);
            }
            catch (Exception e)
            {
                return (-1, e.Message);
            }
        }

        public (DataTable, string) get_by_query(string iSoHD, string sMaHang, string giaBanMin, string giaBanMax, string slBanMin, string slBanMax)
        {
            try
            {
                return DAL_ChiTietHoaDonBan.get_by_query(iSoHD, sMaHang, giaBanMin, giaBanMax, slBanMin, slBanMax);
            }
            catch (Exception e)
            {
                return (null, e.Message);
            }
        }

        public (bool, string) kra_mh_ton_tai(ChiTietHoaDonBan chiTietHoaDonBan)
        {
            try
            {
                (DataTable kq, string msg) = DAL_ChiTietHoaDonBan.get_by_query(chiTietHoaDonBan);
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
