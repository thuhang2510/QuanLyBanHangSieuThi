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
    class BLL_LoaiHang
    {
        private DAL_LoaiHang DAL_LoaiHang;

        public BLL_LoaiHang()
        {
            DAL_LoaiHang = new DAL_LoaiHang();
        }

        public (DataTable, string) get_all()
        {
            try
            {
                return DAL_LoaiHang.get_all();
            }
            catch(Exception e)
            {
                return (null, e.Message);
            }
        }

        public (bool, string) ktrMaLoaiHang(string sMaLoai)
        {
            try
            {
                (DataTable kq, string msg) = DAL_LoaiHang.get_by_query(sMaLoai);

                if (kq.Rows.Count > 0)
                    return (true, "Mã loại hàng đã tồn tại");

                return (false, "Mã loại hàng chưa tồn tại");
            }
            catch (Exception e)
            {
                return (true, e.Message);
            }
        }

        public (int, string) create(LoaiHang loaiHang)
        {
            try
            {
                return DAL_LoaiHang.create(loaiHang);
            }
            catch (Exception e)
            {
                return (-1, e.Message);
            }
        }

        public (int, string) update(LoaiHang loaiHang)
        {
            try
            {
                return DAL_LoaiHang.update(loaiHang);
            }
            catch (Exception e)
            {
                return (-1, e.Message);
            }
        }

        public (int, string) delete(string sMaLH)
        {
            try
            {
                return DAL_LoaiHang.delete(sMaLH);
            }
            catch (Exception e)
            {
                return (-1, e.Message);
            }
        }
    }
}
