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
    class BLL_HoaDonNhap
    {
        private DAL_HoaDonNhap dAL_HoaDonNhap;

        public BLL_HoaDonNhap()
        {
            dAL_HoaDonNhap = new DAL_HoaDonNhap();
        }

        public (int, string) create(HoaDonNhap hoaDonNhap)
        {
            try
            {
                return dAL_HoaDonNhap.create(hoaDonNhap);
            }
            catch (Exception e)
            {
                return (-1, "occurred:" + e.Message);
            }
        }

        public (int, string) update(HoaDonNhap hoaDonNhap)
        {
            try
            {
                return dAL_HoaDonNhap.update(hoaDonNhap);
            }
            catch(Exception e)
            {
                return (-1, "occurred: " + e.Message);
            }
        }

        public (int, string) delete(int iSoHD)
        {
            try
            {
                return dAL_HoaDonNhap.delete(iSoHD);
            }
            catch(Exception e)
            {
                return (-1, "occurred: " + e.Message);
            }
        }

        public (DataTable, string) get_all()
        {
            try
            {
                return dAL_HoaDonNhap.get_all();
            }
            catch (Exception e)
            {
                return (null, "occurred:" + e.Message);
            }
        }

        public (DataTable, string) get_by_query(string maNV, DateTime? ngayLap)
        {
            try
            {
                return dAL_HoaDonNhap.get_by_query(maNV, ngayLap);
            }
            catch(Exception e)
            {
                return (null, "occurred: " + e.Message);
            }
        }

        public (DataTable, string) get_by_id(int iSoHD)
        {
            try
            {
                return dAL_HoaDonNhap.get_by_id(iSoHD);
            }
            catch (Exception e)
            {
                return (null, "occurred: " + e.Message);
            }
        }
    }
}
