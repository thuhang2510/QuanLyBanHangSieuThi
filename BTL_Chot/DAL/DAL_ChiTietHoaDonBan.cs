using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTL_Chot.DTO;

namespace BTL_Chot.DAL
{
    class DAL_ChiTietHoaDonBan
    {
        private DungChung DungChung;

        public DAL_ChiTietHoaDonBan()
        {
            DungChung = new DungChung();
        }

        public (DataTable, string) get_by_id(int iSoHD)
        {
            try
            {
                string query = "lay_ds_cthd_theo_id";
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@iSoHD", iSoHD));
                DataTable kq = DungChung.executeSelectQuery(query, sqlParameters.ToArray<SqlParameter>());

                if (kq != null)
                    return (kq, "Lấy danh sách chi tiết hóa đơn thành công");

                return (kq, "Lấy ds thất bại");
            }
            catch(SqlException e)
            {
                return (null, e.Message);
            }
        }

        public (int, string) create(ChiTietHoaDonBan chiTietHoaDonBan)
        {
            try
            {
                string query = "them_mh_hoa_don_ban";
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@iSoHD", chiTietHoaDonBan.ISoHD));
                sqlParameters.Add(new SqlParameter("@sMaHang", chiTietHoaDonBan.SMaHang));
                sqlParameters.Add(new SqlParameter("@fGiaban", chiTietHoaDonBan.FGiaban));
                sqlParameters.Add(new SqlParameter("@fSoluongmua", chiTietHoaDonBan.FSoluongmua));
                int kq = DungChung.executeInsertQuery(query, sqlParameters.ToArray<SqlParameter>());

                if (kq > 0)
                    return (kq, "Thêm mặt hàng vào chi tiết hóa đơn bán thành công");

                return (kq, "Thêm mặt hàng vào chi tiết hóa đơn bán thất bại");
            }
            catch (SqlException e)
            {
                return (-1, e.Message);
            }
        }


        public (int, string) update(ChiTietHoaDonBan chiTietHoaDonBan)
        {
            try
            {
                string query = "sua_mh_cua_hoa_don_ban";
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@iSoHD", chiTietHoaDonBan.ISoHD));
                sqlParameters.Add(new SqlParameter("@sMaHang", chiTietHoaDonBan.SMaHang));
                sqlParameters.Add(new SqlParameter("@fGiaban", chiTietHoaDonBan.FGiaban));
                sqlParameters.Add(new SqlParameter("@fSoluongmua", chiTietHoaDonBan.FSoluongmua));
                int kq = DungChung.executeUpdateQuery(query, sqlParameters.ToArray<SqlParameter>());

                if (kq > 0)
                    return (kq, "Sửa mặt hàng vào chi tiết hóa đơn bán thành công");

                return (kq, "Sửa mặt hàng vào chi tiết hóa đơn bán thất bại");
            }
            catch (SqlException e)
            {
                return (-1, e.Message);
            }
        }

        public (int, string) delete(ChiTietHoaDonBan chiTietHoaDonBan)
        {
            try
            {
                string query = "xoa_mh_cua_hoa_don_ban";
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@iSoHD", chiTietHoaDonBan.ISoHD));
                sqlParameters.Add(new SqlParameter("@sMaHang", chiTietHoaDonBan.SMaHang));
                int kq = DungChung.executeUpdateQuery(query, sqlParameters.ToArray<SqlParameter>());

                if (kq > 0)
                    return (kq, "Xóa mặt hàng vào chi tiết hóa đơn bán thành công");

                return (kq, "Xóa mặt hàng vào chi tiết hóa đơn bán thất bại");
            }
            catch (SqlException e)
            {
                return (-1, e.Message);
            }
        }

        public (DataTable, string) get_by_query(string iSoHD, string sMaHang, string giaBanMin, string giaBanMax, string slBanMin, string slBanMax)
        {
            try
            {
                string query = "tim_kiem_mh_hoa_don_ban";
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@iSoHD", iSoHD));
                sqlParameters.Add(new SqlParameter("@sMaHang", sMaHang));
                sqlParameters.Add(new SqlParameter("@fGiabanMin", giaBanMin));
                sqlParameters.Add(new SqlParameter("@fGiabanMax", giaBanMax));
                sqlParameters.Add(new SqlParameter("@fSoluongbanMin", slBanMin));
                sqlParameters.Add(new SqlParameter("@fSoluongbanMax", slBanMax));
                DataTable kq = DungChung.executeSelectQuery(query, sqlParameters.ToArray<SqlParameter>());

                if (kq != null)
                    return (kq, "Lấy ds mặt hàng theo điều kiện lọc thành công");

                return (null, "Không có danh sách nào thuộc điều kiện lọc");
            }
            catch (SqlException e)
            {
                return (null, e.Message);
            }
        }

        public (DataTable, string) get_by_query(ChiTietHoaDonBan chiTietHoaDonBan)
        {
            try
            {
                string query = "kt_mh_cua_hoa_don_ban";
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@iSoHD", chiTietHoaDonBan.ISoHD));
                sqlParameters.Add(new SqlParameter("@sMaHang", chiTietHoaDonBan.SMaHang));
                DataTable kq = DungChung.executeSelectQuery(query, sqlParameters.ToArray<SqlParameter>());

                if (kq != null)
                    return (kq, "Lấy ds mặt hàng theo điều kiện lọc thành công");

                return (null, "Không có danh sách nào thuộc điều kiện lọc");
            }
            catch (SqlException e)
            {
                return (null, e.Message);
            }
        }
    }
}
