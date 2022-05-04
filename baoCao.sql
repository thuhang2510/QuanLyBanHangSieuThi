/*Doanh thu bán hàng theo nhân viên*/
select top(5) tblHoaDon.iMaNV, sum(tblChiTietHoaDon.fGiaban * tblChiTietHoaDon.fSoluongmua) as [Tổng tiền]
from tblHoaDon, tblChiTietHoaDon
where tblHoaDon.iSoHD = tblChiTietHoaDon.iSoHD
group by tblHoaDon.iMaNV
order by [Tổng tiền] DESC

select * from tblNhanVien
select * from tblHoaDon
select * from tblChiTietHoaDon

/*Doanh thu bán hàng theo nhân viên từ ngày bn đến ngày bn*/
create proc doanhThuNVTheoNgay
@iMaNV int = null,
@dNgayNhapMin datetime = null,
@dNgayNhapMax datetime = null
as
begin
	select tblNhanVien.iMaNV, tblNhanVien.sTenNV, tblHoaDon.iSoHD, tblHoaDon.dNgaymuahang, sum(tblChiTietHoaDon.fSoluongmua * tblChiTietHoaDon.fGiaban) as [Tổng tiền]
	from tblNhanVien, tblChiTietHoaDon, tblHoaDon
	where tblNhanVien.iMaNV = tblHoaDon.iMaNV
	and tblHoaDon.iSoHD = tblChiTietHoaDon.iSoHD
	and ((tblHoaDon.iMaNV = @iMaNV) or ISNULL(@iMaNV,'') = '')
	and ((tblHoaDon.dNgaymuahang >= @dNgayNhapMin) or ISNULL(@dNgayNhapMin,'') = '')
	and ((tblHoaDon.dNgaymuahang <= @dNgayNhapMax) or ISNULL(@dNgayNhapMax,'') = '')
	group by tblNhanVien.iMaNV, tblNhanVien.sTenNV, tblHoaDon.iSoHD, tblHoaDon.dNgaymuahang
end

exec doanhThuNVTheoNgay 2

select * from tblNhanVien
select * from tblHoaDon
select * from tblChiTietHoaDon

/*Số lượng mặt hàng đc bán hàng theo nhân viên*/
select top(5) tblHoaDon.iMaNV, sum(tblChiTietHoaDon.fSoluongmua) as [Số lượng]
from tblHoaDon, tblChiTietHoaDon
where tblHoaDon.iSoHD = tblChiTietHoaDon.iSoHD
group by tblHoaDon.iMaNV
order by [Số lượng] DESC

select * from tblHoaDon
select * from tblChiTietHoaDon

/*Trong 10 khách hàng có doanh số cao nhất*/
select top(10) tblHoaDon.iMaKH, sum(tblChiTietHoaDon.fGiaban * tblChiTietHoaDon.fSoluongmua) as [Tổng tiền]
from tblHoaDon, tblChiTietHoaDon
where tblHoaDon.iSoHD = tblChiTietHoaDon.iSoHD
group by tblHoaDon.iMaKH
order by [Tổng tiền] DESC

/*số lần mua hàng của khách hàng*/
select iMaKH, count(iSoHD) as [Số lần mua]
from tblHoaDon
group by iMaKH

/*Trong 10 khách hàng có doanh số cao nhất, tìm khách hàng có số lần mua hàng nhiều nhất.*/
select top 3 A.iMaKH, B.[Số lần mua] from (select top(10) tblHoaDon.iMaKH, sum(tblChiTietHoaDon.fGiaban * tblChiTietHoaDon.fSoluongmua) as [Tổng tiền]
from tblHoaDon, tblChiTietHoaDon
where tblHoaDon.iSoHD = tblChiTietHoaDon.iSoHD
group by tblHoaDon.iMaKH
order by [Tổng tiền] DESC) as A
left join (select iMaKH, count(iSoHD) as [Số lần mua]
from tblHoaDon
group by iMaKH) as B
on A.iMaKH = B.iMaKH
ORDER BY [Số lần mua] DESC

select * from tblNhanVien
where tblNhanVien.sTenNV like '%Duy%'


/*Top n hàng hóa bán chạy nhất theo sl*/
select top(10) tblChiTietHoaDon.sMaHang, sum(tblChiTietHoaDon.fSoluongmua) as [Số lượng]
from tblChiTietHoaDon
group by tblChiTietHoaDon.sMaHang
order by [Số lượng] DESC


/*Lấy danh sách tất cả của 2 điều kiện*/
create proc laynhanvienvahoadon
as
begin
	select tblNhanVien.iMaNV, tblNhanVien.sTenNV, tblHoaDon.iSoHD, tblHoaDon.dNgaymuahang, sum(tblChiTietHoaDon.fSoluongmua * tblChiTietHoaDon.fGiaban) as [Tổng tiền]
	from tblNhanVien, tblChiTietHoaDon, tblHoaDon
	where tblNhanVien.iMaNV = tblHoaDon.iMaNV
	and tblHoaDon.iSoHD = tblChiTietHoaDon.iSoHD
	group by tblNhanVien.iMaNV, tblNhanVien.sTenNV, tblHoaDon.iSoHD, tblHoaDon.dNgaymuahang
end

/*Lấy danh sách nhân viên chưa bán được mặt hàng nào*/
select * from tblNhanVien
where iMaNV not in (select iMaNV from tblHoaDon, tblChiTietHoaDon where tblHoaDon.iSoHD = tblChiTietHoaDon.iSoHD)

select * from tblChiTietHoaDon
where fSoluongmua > 10

/**/
create proc debai
as
begin
select * from tblMatHang
where tblMatHang.sMaHang in (select tblChiTietHoaDon.sMaHang from tblChiTietHoaDon where tblChiTietHoaDon.fSoluongmua > 10)
end