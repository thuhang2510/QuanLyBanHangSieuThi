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
    class BLL_HoaDonBan
    {
        private DAL_HoaDonBan DAL_HoaDonBan;

        public BLL_HoaDonBan()
        {
            DAL_HoaDonBan = new DAL_HoaDonBan();
        }

        public (DataTable, string) get_all()
        {
            try
            {
                return DAL_HoaDonBan.get_all();
            }
            catch(Exception e)
            {
                return (null, e.Message);
            }
        }

        public (int, string) create(HoaDonBan hoaDonBan)
        {
            try
            {
                return DAL_HoaDonBan.create(hoaDonBan);
            }
            catch(Exception e)
            {
                return (-1, e.Message);
            }
        }

        public (int, string) update(HoaDonBan hoaDonBan)
        {
            try
            {
                return DAL_HoaDonBan.update(hoaDonBan);
            }
            catch (Exception e)
            {
                return (-1, e.Message);
            }
        }

        public (int, string) delete(int iSoHD)
        {
            try
            {
                return DAL_HoaDonBan.delete(iSoHD);
            }
            catch (Exception e)
            {
                return (-1, e.Message);
            }
        }

        public (DataTable, string) get_by_query(string maNV, string maKH, DateTime? ngayLap)
        {
            try
            {
                return DAL_HoaDonBan.get_by_query(maNV, maKH, ngayLap);
            }
            catch (Exception e)
            {
                return (null, e.Message);
            }
        }

        public (bool, string) kiem_tra_trung_soHD(int iSoHD)
        {
            try
            {
                (DataTable kq, string msg) = DAL_HoaDonBan.get_by_id(iSoHD);

                if (kq.Rows.Count > 0)
                    return (true, "Số hóa đơn này đã tồn tại");

                return (false, "Chưa có số hóa đơn này");
            }
            catch (Exception e)
            {
                return (true, e.Message);
            }
        }

        public (DataTable, string) get_by_id(int iSoHD)
        {
            try
            {
                return DAL_HoaDonBan.get_by_id(iSoHD);
            }
            catch (Exception e)
            {
                return (null, e.Message);
            }
        }
    }
}
