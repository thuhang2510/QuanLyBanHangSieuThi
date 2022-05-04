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
    class DAL_ChiTietHoaDonNhap
    {
        private DungChung DungChung;

        public DAL_ChiTietHoaDonNhap()
        {
            DungChung = new DungChung();
        }

        public (DataTable, string) get_by_id(int iSoHD)
        {
            try
            {
                string query = "lay_ds_mathang_cua_CTNhapHang";
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@iSoHD", iSoHD));
                DataTable kq = DungChung.executeSelectQuery(query, sqlParameters.ToArray<SqlParameter>());

                if (kq != null)
                    return (kq, "Lấy ds mặt hàng của 1 hóa đơn nhập thành công");

                return (null, "Lấy ds mặt hàng của 1 hóa đơn nhập thất bại");
            }
            catch(SqlException e)
            {
                return (null, e.Message);
            }
        }

        public (int, string) create(ChiTietHoaDonNhap chiTietHoaDonNhap)
        {
            try
            {
                string query = "them_mh_vao_CTHoaDonNhap";
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@iSoHD", chiTietHoaDonNhap.ISoHD));
                sqlParameters.Add(new SqlParameter("@sMaHang", chiTietHoaDonNhap.SMaHang));
                sqlParameters.Add(new SqlParameter("@fGianhap", chiTietHoaDonNhap.FGiaNhap));
                sqlParameters.Add(new SqlParameter("@fSoluongnhap", chiTietHoaDonNhap.FSoLuongNhap));
                int kq = DungChung.executeInsertQuery(query, sqlParameters.ToArray<SqlParameter>());

                if (kq > 0)
                    return (kq, "Thêm mặt hàng vào chi tiết hóa đơn nhập thành công");

                return (kq, "Thêm mặt hàng vào chi tiết hóa đơn nhập thất bại");
            }
            catch(SqlException e)
            {
                return (-1, e.Message);
            }
        }

        public (int, string) update(ChiTietHoaDonNhap chiTietHoaDonNhap)
        {
            try
            {
                string query = "sua_mathang_cua_hoa_don_nhap";
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@iSoHD", chiTietHoaDonNhap.ISoHD));
                sqlParameters.Add(new SqlParameter("@sMaHang", chiTietHoaDonNhap.SMaHang));
                sqlParameters.Add(new SqlParameter("@fGianhap", chiTietHoaDonNhap.FGiaNhap));
                sqlParameters.Add(new SqlParameter("@fSoluongnhap", chiTietHoaDonNhap.FSoLuongNhap));
                int kq = DungChung.executeUpdateQuery(query, sqlParameters.ToArray<SqlParameter>());

                if (kq > 0)
                    return (kq, "Sửa mặt hàng vào chi tiết hóa đơn nhập thành công");

                return (kq, "Sửa mặt hàng vào chi tiết hóa đơn nhập thất bại");
            }
            catch (SqlException e)
            {
                return (-1, e.Message);
            }
        }

        public (int, string) delete(int iSoHD, string sMaHang)
        {
            try
            {
                string query = "xoa_mh_cua_hoa_don_nhap";
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@iSoHD", iSoHD));
                sqlParameters.Add(new SqlParameter("@sMaHang", sMaHang));
                int kq = DungChung.executeDeleteQuery(query, sqlParameters.ToArray<SqlParameter>());

                if (kq > 0)
                    return (kq, "Xóa mặt hàng trong chi tiết hóa đơn nhập thành công");

                return (kq, "Xóa mặt hàng vào chi tiết hóa đơn nhập thất bại");
            }
            catch (SqlException e)
            {
                return (-1, e.Message);
            }
        }

        public (DataTable, string) get_by_query(string iSoHD, string sMaHang, string giaNhapMin, string giaNhapMax, string slNhapMin, string slNhapMax)
        {
            try
            {
                string query = "tim_kiem_mh_trong_hoa_don_nhap";
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@iSoHD", iSoHD));
                sqlParameters.Add(new SqlParameter("@sMaHang", sMaHang));
                sqlParameters.Add(new SqlParameter("@fGianhapMin", giaNhapMin));
                sqlParameters.Add(new SqlParameter("@fGianhapMax", giaNhapMax));
                sqlParameters.Add(new SqlParameter("@fSoluongnhapMin", slNhapMin));
                sqlParameters.Add(new SqlParameter("@fSoluongnhapMax", slNhapMax));
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

        public (DataTable, string) get_by_query(ChiTietHoaDonNhap chiTietHoaDonNhap)
        {
            try
            {
                string query = "kt_mh_cua_hoa_don_nhap";
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@iSoHD", chiTietHoaDonNhap.ISoHD));
                sqlParameters.Add(new SqlParameter("@sMaHang", chiTietHoaDonNhap.SMaHang));
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
