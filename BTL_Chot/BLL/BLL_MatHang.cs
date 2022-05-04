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
    class BLL_MatHang
    {
        private DAL_MatHang DAL_MatHang;

        public BLL_MatHang()
        {
            DAL_MatHang = new DAL_MatHang();
        }

        public (DataTable, string) get_all()
        {
            try
            {
                return DAL_MatHang.get_all();
            }
            catch(Exception e)
            {
                return (null, "occurred:" + e.Message);
            }
        }

        public (int, string) create(MatHang matHang)
        {
            try
            {
                return DAL_MatHang.create(matHang);
            }
            catch (Exception e)
            {
                return (-1, "occurred:" + e.Message);
            }
        }

        public (int, string) update(MatHang matHang)
        {
            try
            {
                return DAL_MatHang.update(matHang);
            }
            catch (Exception e)
            {
                return (-1, "occurred:" + e.Message);
            }
        }

        public (int, string) delete(string sMaHang)
        { 
            try
            {
                return DAL_MatHang.delete(sMaHang);
            }
            catch (Exception e)
            {
                return (-1, "occurred:" + e.Message);
            }
        }

        public (bool, string) ktra_trung_ma_mat_hang(string sMaHang)
        {
            try
            {
                (DataTable kq, string msg) = DAL_MatHang.get_by_id(sMaHang);

                if (kq.Rows.Count > 0)
                    return (true, "Mã mặt hàng đã tồn tại");

                return (false, "Mã mặt hàng chưa tồn tại");
            }
            catch (Exception e)
            {
                return (true, "occurred:" + e.Message);
            }
        }
    }
}
