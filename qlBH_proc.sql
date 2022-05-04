use quanlybanhang
/* Lấy ds nhân viên*/
create proc lay_ds_nhanvien
as
begin
	select * from tblNhanVien
	where bStatus = 1
end

exec lay_ds_nhanvien

/*Thêm nhân viên*/
create proc them_nhan_vien
@iMaNV int,
@sTenNV nvarchar(30),
@sDiachi nvarchar(50),
@sDienthoai nvarchar(12),
@dNgaysinh date,
@dNgayvaolam date,
@fLuongcoban float
as
begin
	INSERT INTO tblNhanVien (iMaNV, sTenNV, sDiachi, sDienthoai, dNgaysinh, dNgayvaolam, fLuongcoban) VALUES
	(@iMaNV, @sTenNV, @sDiachi, @sDienthoai, @dNgaysinh, @dNgayvaolam, @fLuongcoban)
end

exec them_nhan_vien 4, N'Đàm Hằng', N'Hà Nội', '0389682304', '2001-10-25', '2022-3-17', 8000000

/*Xóa nhân viên*/
create proc xoa_nhanvien
@iMaNV int
as
begin
	update tblNhanVien
	set bStatus = 0
	where iMaNV = @iMaNV and bStatus = 1
end

exec xoa_nhanvien 4

/*Sửa nhân viên*/
create proc sua_nhanvien
@iMaNV int,
@sTenNV nvarchar(30),
@sDiachi nvarchar(50),
@sDienthoai nvarchar(12),
@dNgaysinh date,
@dNgayvaolam date,
@fLuongcoban float
as
begin
	update tblNhanVien set
	sTenNV = @sTenNV,
	sDiachi = @sDiachi,
	sDienthoai = @sDienthoai,
	dNgaysinh = @dNgaysinh,
	dNgayvaolam = @dNgayvaolam,
	fLuongcoban = @fLuongcoban
	where iMaNV = @iMaNV and bStatus = 1
end

/*Kiểm tra mã nhân viên tồn tại*/
create proc ktra_ma_nhanvien
@iMaNV int
as
begin
	select * from tblNhanVien
	where iMaNV = @iMaNV
end

exec ktra_ma_nhanvien 1

/*Tìm kiếm nhân viên*/
create proc proc_timkiemNV
@sTenNV nvarchar(30) = null,
@sDiachi nvarchar(50) = null,
@sDienthoai varchar(12) = null,
@dNgaysinh datetime = null,
@dNgayvaolam datetime = null
as
begin
	select * from tblNhanVien
	where ((sTenNV like '%' + @sTenNV + '%') or ISNULL(@sTenNV,'') = '')
	and ((sDiachi like '%' + @sDiachi + '%') or ISNULL(@sDiachi,'') = '')
	and ((sDienthoai like '%' + @sDienthoai + '%') or ISNULL(@sDienthoai,'') = '')
	and ((dNgaysinh = @dNgaysinh) or ISNULL(@dNgaysinh,'') = '')
	and ((dNgayvaolam = @dNgayvaolam) or ISNULL(@dNgayvaolam,'') = '')
	and bStatus = 1
end

exec proc_timkiemNV N'Đàm Hằng', null, null, null, null

create proc proc_timkiemNVCoGioiTinh
@sTenNV nvarchar(30) = null,
@sDiachi nvarchar(50) = null,
@sDienthoai varchar(12) = null,
@dNgaysinh datetime = null,
@dNgayvaolam datetime = null,
@bGioiTinh bit = null
as
begin
	select * from tblNhanVien
	where ((sTenNV like '%' + @sTenNV + '%') or ISNULL(@sTenNV,'') = '')
	and ((sDiachi like '%' + @sDiachi + '%') or ISNULL(@sDiachi,'') = '')
	and ((sDienthoai like '%' + @sDienthoai + '%') or ISNULL(@sDienthoai,'') = '')
	and ((dNgaysinh = @dNgaysinh) or ISNULL(@dNgaysinh,'') = '')
	and ((dNgayvaolam = @dNgayvaolam) or ISNULL(@dNgayvaolam,'') = '')
	and ((bGioiTinh = @bGioiTinh) or ISNULL(@bGioiTinh,'') = '')
	and bStatus = 1
end

exec proc_timkiemNVCoGioiTinh N'Nguyễn', null, null, null, '2017-03-25', 0

/*Lấy danh sách nhân viên vào combox*/
create proc lay_dsNV_den_combox
as
begin
	SELECT tblNhanVien.*, sTenNV+' - '+sDienthoai AS Description 
	from tblNhanVien
	where bStatus = 1
end

exec lay_dsNV_den_combox


/*Thêm hóa đơn nhập*/
create proc them_hoaDonNhap
@iSoHD int,
@iMaNV int,
@dNgaynhaphang date
as
begin
	insert into tblDonnhaphang values (@iSoHD, @iMaNV, @dNgaynhaphang)
end

exec them_hoaDonNhap 5, 1, '2022-04-17'

/*Lấy danh sách hóa đơn nhập*/
create proc lay_ds_hoaDonNhap
as
begin
	select iSoHD, iMaNV, (select sTenNV + ' - ' + sDienthoai from tblNhanVien where iMaNV = tblDonnhaphang.iMaNV) as [Tên nhân viên],
	dNgaynhaphang, 
	ISNULL((Select sum(fGianhap * fSoluongnhap)
		from tblChiTietNhapHang
		where iSoHD = tblDonnhaphang.iSoHD
		group by iSoHD), 0) as [Tổng tiền]
	from tblDonnhaphang
end

exec lay_ds_hoaDonNhap

/*Kiểm tra trùng số hóa đơn*/
create proc kiem_tra_trung_soHD
@iSoHD int
as
begin
	select * from tblDonnhaphang
	where iSoHD = @iSoHD
end

exec kiem_tra_trung_soHD 1

/*Kiểm tra mặt hàng đã tồn tại trong hóa đơn nhập*/
create proc kt_mh_cua_hoa_don_nhap
@iSoHD int,
@sMaHang varchar(10)
as
begin
	select * from tblChiTietNhapHang
	where iSoHD = @iSoHD and sMaHang = @sMaHang
end

/*Sửa hóa đơn nhập*/
create proc sua_hoa_don_nhap
@iSoHD int,
@iMaNV int,
@dNgaynhaphang date
as
begin
	update tblDonnhaphang set
	iMaNV = @iMaNV,
	dNgaynhaphang = @dNgaynhaphang
	where iSoHD = @iSoHD
end

/*Xóa hóa đơn nhập*/
drop proc xoa_hoa_don_nhap
create proc xoa_hoa_don_nhap
@iSoHD int
as
begin
	delete from tblDonnhaphang
	where iSoHD = @iSoHD
end

select * from tblDonnhaphang
select * from tblChiTietNhapHang
select * from tblMatHang
exec xoa_hoa_don_nhap 1
select * from tblDonnhaphang
select * from tblChiTietNhapHang
select * from tblMatHang

/*Tìm kiếm hóa đơn nhập*/
create proc proc_timkiemHD
@iMaNV int = null,
@dNgayLap datetime = null
as
begin
	select iSoHD, iMaNV, (select sTenNV + ' - ' + sDienthoai from tblNhanVien where iMaNV = tblDonnhaphang.iMaNV) as [Tên nhân viên],
	dNgaynhaphang, 
	ISNULL((Select sum(fGianhap * fSoluongnhap)
		from tblChiTietNhapHang
		where iSoHD = tblDonnhaphang.iSoHD
		group by iSoHD), 0) as [Tổng tiền]
	from tblDonnhaphang
	where ((iMaNV = @iMaNV) or ISNULL(@iMaNV,'') = '')
	and ((dNgaynhaphang = @dNgayLap) or ISNULL(@dNgayLap,'') = '')
end

exec proc_timkiemHD 1, null


/*Lấy danh sách các mặt hàng của 1 chi tiết nhập hàng*/
drop proc lay_ds_mathang_cua_CTNhapHang
create proc lay_ds_mathang_cua_CTNhapHang
@iSoHD int
as
begin
	select tblChiTietNhapHang.*, tblMatHang.sTenHang from tblChiTietNhapHang, tblMatHang
	where iSoHD = @iSoHD and tblMatHang.sMaHang = tblChiTietNhapHang.sMaHang
end

exec lay_ds_mathang_cua_CTNhapHang 1




/*Trigger thực hiện việc thêm mặt hàng vào hóa đơn nhập thì mặt hàng đó sẽ đc xóa*/
drop trigger tr_them_mh_hoa_don_nhap
create trigger tr_them_mh_hoa_don_nhap
on tblChiTietNhapHang
after insert
as
begin
	declare @sMaHang varchar(10), @fSoluongnhap float
	select @sMaHang = sMaHang, @fSoluongnhap = fSoluongnhap from inserted
	if EXISTS(select * from tblMatHang where sMaHang = @sMaHang)
		begin
			update tblMatHang set fSoLuong = fSoLuong + @fSoluongnhap
			where sMaHang = @sMaHang
		end
end

/*Thêm 1 mặt hàng vào hóa đơn nhập*/
drop proc them_mh_vao_CTHoaDonNhap
create proc them_mh_vao_CTHoaDonNhap
@iSoHD int,
@sMaHang varchar(10),
@fGianhap float,
@fSoluongnhap float
as
begin
	if NOT EXISTS(select * from tblChiTietNhapHang where iSoHD = @iSoHD and sMaHang = @sMaHang) and EXISTS(select * from tblMatHang where sMaHang = @sMaHang)
		begin
			insert into tblChiTietNhapHang values (@iSoHD, @sMaHang, @fGianhap, @fSoluongnhap)
		end
end

select * from tblDonnhaphang
select * from tblChiTietNhapHang
select * from tblMatHang
exec them_mh_vao_CTHoaDonNhap 1, 'MH03', 100000, 7
select * from tblDonnhaphang
select * from tblChiTietNhapHang
select * from tblMatHang

/*trigger giảm sl mặt hàng khi xóa 1 mặt hàng trong chi tiết hóa đơn nhập*/
drop trigger tr_xoa_mh_hoa_don_nhap
create trigger tr_xoa_mh_hoa_don_nhap
on tblChiTietNhapHang
for delete
as
begin
	declare @sMaHang varchar(10), @fSoluongnhap float
	DECLARE cursorProduct CURSOR FOR  -- khai báo con trỏ cursorProduct
	SELECT sMaHang, fSoluongnhap FROM deleted     -- dữ liệu trỏ tới
	OPEN cursorProduct                -- Mở con trỏ
	FETCH NEXT FROM cursorProduct     -- Đọc dòng đầu tiên
		INTO @sMaHang, @fSoluongnhap
	WHILE @@FETCH_STATUS = 0          --vòng lặp WHILE khi đọc Cursor thành công
	BEGIN
		IF @fSoluongnhap <= (SELECT fSoLuong FROM tblMatHang WHERE sMaHang = @sMaHang)
			BEGIN
				UPDATE tblMatHang
				SET fSoLuong = fSoLuong - @fSoluongnhap
				WHERE sMaHang = @sMaHang
			END
		else
			begin
				print 'khong xoa dc'
				ROLLBACK TRAN
			end
		FETCH NEXT FROM cursorProduct -- Đọc dòng tiếp
          INTO @sMaHang, @fSoluongnhap
	END

	CLOSE cursorProduct              -- Đóng Cursor
	DEALLOCATE cursorProduct         -- Giải phóng tài nguyên
end

/*Xóa mặt hàng của chi tiết hóa đơn nhập*/
create proc xoa_mh_cua_hoa_don_nhap
@iSoHD int,
@sMaHang varchar(10)
as
begin
	delete from tblChiTietNhapHang
	where iSoHD = @iSoHD and sMaHang = @sMaHang
end

select * from tblDonnhaphang
select * from tblChiTietNhapHang
select * from tblMatHang
exec xoa_mh_cua_hoa_don_nhap 2, 'MH03'
select * from tblDonnhaphang
select * from tblChiTietNhapHang
select * from tblMatHang

/*trigger update mặt hàng trong chi tiết hóa đơn*/
drop trigger tr_sua_mh_cua_hoa_don_nhap
create trigger tr_sua_mh_cua_hoa_don_nhap
on tblChiTietNhapHang
after update
as
begin
	DECLARE @slmoi int, @slcu int, @sMaHang VARCHAR(10)
	SELECT @slmoi = fSoluongnhap, @sMaHang = sMaHang FROM inserted
	SELECT @slcu = fSoluongnhap FROM deleted
	
	IF EXISTS(SELECT * FROM tblMatHang WHERE sMaHang = @sMaHang)
	and  (SELECT fSoLuong FROM tblMatHang WHERE sMaHang = @sMaHang)-@slcu+@slmoi>=0
		BEGIN
			UPDATE tblMatHang
			SET fSoLuong = fSoLuong - @slcu + @slmoi
			WHERE sMaHang = @sMaHang
		END
	else
		BEGIN
			print N'Không thể sửa được'
			ROLLBACK TRAN
		END
end

/*Sửa mặt hàng trong hóa đơn nhập*/
drop proc sua_mathang_cua_hoa_don_nhap
create proc sua_mathang_cua_hoa_don_nhap
@iSoHD int,
@sMaHang varchar(10),
@fGianhap float,
@fSoluongnhap float
as
begin
	if ((SELECT fSoLuong from tblMatHang where sMaHang = @sMaHang) - 
		(SELECT fSoluongnhap from tblChiTietNhapHang where iSoHD = @iSoHD and sMaHang = @sMaHang) + @fSoluongnhap >= 0)
		begin
			update tblChiTietNhapHang
			set fGianhap = @fGianhap,
				fSoluongnhap = @fSoluongnhap
			where iSoHD = @iSoHD and sMaHang = @sMaHang
		end
end

select * from tblDonnhaphang
select * from tblChiTietNhapHang
select * from tblMatHang
exec sua_mathang_cua_hoa_don_nhap 1, 'MH01', 100001, 1 
select * from tblChiTietNhapHang
select * from tblMatHang




/*Tìm kiếm mặt hàng trong hóa đơn nhập*/
drop proc tim_kiem_mh_trong_hoa_don_nhap
create proc tim_kiem_mh_trong_hoa_don_nhap
@iSoHD int,
@sMaHang varchar(10) = NULL,
@fGianhapMin float = NULL,
@fGianhapMax float = NULL,
@fSoluongnhapMin float = NULL,
@fSoluongnhapMax float = NULL
as
begin
	select tblChiTietNhapHang.*, tblMatHang.sTenHang
	from tblChiTietNhapHang, tblMatHang
	where tblChiTietNhapHang.iSoHD = @iSoHD and
		tblMatHang.sMaHang = tblChiTietNhapHang.sMaHang
		and (tblChiTietNhapHang.sMaHang = @sMaHang or ISNULL(@sMaHang,'') = '')
		and (tblChiTietNhapHang.fGianhap >= @fGianhapMin or ISNULL(@fGianhapMin,'') = '')
		and (tblChiTietNhapHang.fGianhap <= @fGianhapMax or ISNULL(@fGianhapMax,'') = '')
		and (tblChiTietNhapHang.fSoluongnhap >= @fSoluongnhapMin or ISNULL(@fSoluongnhapMin,'') = '')
		and (tblChiTietNhapHang.fSoluongnhap <= @fSoluongnhapMax or ISNULL(@fSoluongnhapMax,'') = '')
end

select * from tblChiTietNhapHang
exec tim_kiem_mh_trong_hoa_don_nhap 1, 'MH01', null, null


/*Lấy danh sách hóa đơn bán*/
drop proc lay_ds_hdBan
create proc lay_ds_hdBan
as
begin
	select tblHoaDon.*, tblNhanVien.sTenNV, tblNhanVien.sDienthoai as sDTNV, tblKhachHang.sTenKH, tblKhachHang.sDienthoai as sDTKH,
	ISNULL((Select sum(fGiaban * fSoluongmua)
		from tblChiTietHoaDon
		where iSoHD = tblHoaDon.iSoHD
		group by iSoHD), 0) as [Tổng tiền]
	from tblHoaDon
	inner join tblNhanVien on tblHoaDon.iMaNV = tblNhanVien.iMaNV
	inner join tblKhachHang on tblHoaDon.iMaKH = tblKhachHang.iMaKH
end

exec lay_ds_hdBan

/*Thêm hóa đơn bán*/
create proc them_hd_ban
@iSoHD int,
@iMaNV int,
@iMaKH int,
@dNgaymuahang date
as
begin
	insert into tblHoaDon values (@iSoHD, @iMaNV, @iMaKH, @dNgaymuahang)
end

select * from tblHoaDon
exec them_hd_ban 5, 1, 3, '2022-02-22'
select * from tblHoaDon

/*Xóa hóa đơn bán*/
create proc xoa_hd_ban
@iSoHD int
as
begin
	delete from tblHoaDon where tblHoaDon.iSoHD = @iSoHD
end

exec xoa_hd_ban 3

/*Sửa hóa đơn bán*/
create proc sua_hd_ban
@iSoHD int,
@iMaNV int,
@iMaKH int,
@dNgaymuahang date
as
begin
	update tblHoaDon
	set iMaNV = @iMaNV,
	iMaKH = @iMaKH,
	dNgaymuahang= @dNgaymuahang
	where iSoHD = @iSoHD
end

exec sua_hd_ban 6, 4, 3, '2022-04-20'

/*Tìm kiếm hóa đơn bán*/
drop proc tim_kiem_cua_hd_ban
create proc tim_kiem_cua_hd_ban
@iMaNV int = null,
@iMaKH int = null,
@dNgayLap datetime = null
as
begin
	select tblHoaDon.*, tblNhanVien.sTenNV, tblNhanVien.sDienthoai as sDTNV, tblKhachHang.sTenKH, tblKhachHang.sDienthoai as sDTKH,
	ISNULL((Select sum(fGiaban * fSoluongmua)
		from tblChiTietHoaDon
		where iSoHD = tblHoaDon.iSoHD
		group by iSoHD), 0) as [Tổng tiền]
	from tblHoaDon, tblNhanVien, tblKhachHang
	where tblHoaDon.iMaNV = tblNhanVien.iMaNV
	and tblHoaDon.iMaKH = tblKhachHang.iMaKH
	and ((tblHoaDon.iMaNV = @iMaNV) or ISNULL(@iMaNV,'') = '')
	and ((tblHoaDon.iMaKH = @iMaKH) or ISNULL(@iMaKH,'') = '')
	and ((dNgaymuahang = @dNgayLap) or ISNULL(@dNgayLap,'') = '')
end

exec tim_kiem_cua_hd_ban 1, 1, null

/*Lấy hóa đơn bán theo id*/
create proc lay_mot_hd_theo_id
@iSoHD int
as
begin 
	select tblHoaDon.*, tblNhanVien.sTenNV, tblNhanVien.sDienthoai as sDTNV, tblKhachHang.sTenKH, tblKhachHang.sDienthoai as sDTKH,
	ISNULL((Select sum(fGiaban * fSoluongmua)
		from tblChiTietHoaDon
		where iSoHD = tblHoaDon.iSoHD
		group by iSoHD), 0) as [Tổng tiền]
	from tblHoaDon, tblNhanVien, tblKhachHang
	where tblHoaDon.iMaNV = tblNhanVien.iMaNV
	and tblHoaDon.iMaKH = tblKhachHang.iMaKH
	and tblHoaDon.iSoHD = @iSoHD
end

exec lay_mot_hd_theo_id 11




/*Lấy danh sách chi tiết hóa đơn theo id*/
create proc lay_ds_cthd_theo_id
@iSoHD int
as
begin
	select tblChiTietHoaDon.*, tblMatHang.sTenHang, tblMatHang.fSoLuong 
	from tblChiTietHoaDon, tblMatHang
	where tblChiTietHoaDon.iSoHD = @iSoHD
	and tblChiTietHoaDon.sMaHang = tblMatHang.sMaHang
end

exec lay_ds_cthd_theo_id 1


/*trigger giảm số lượng mặt hàng khi thêm mặt hàng vào chi tiết hóa đơn bán*/
create trigger tr_them_mh_vao_ct_hoa_don
on tblChiTietHoaDon
after insert
as
begin
	declare @sMaHang varchar(10), @fSoluongban float
	select @sMaHang = sMaHang, @fSoluongban = fSoluongmua from inserted
	if EXISTS(select * from tblMatHang where sMaHang = @sMaHang) 
	and ((SELECT fSoLuong from tblMatHang where sMaHang = @sMaHang) - @fSoluongban >= 0)
		begin
			update tblMatHang set fSoLuong = fSoLuong - @fSoluongban
			where sMaHang = @sMaHang
		end
	else
		BEGIN
			print N'Không thể thêm được'
			ROLLBACK TRAN
		END
end

/*Thêm mặt hàng trong hóa đơn bán*/
create proc them_mh_hoa_don_ban
@iSoHD int, 
@sMaHang varchar(10),
@fGiaban float,
@fSoluongmua float
as
begin
	insert into tblChiTietHoaDon (iSoHD, sMaHang, fGiaban, fSoluongmua) values (@iSoHD, @sMaHang, @fGiaban, @fSoluongmua)
end

select * from tblChiTietHoaDon
select * from tblMatHang
exec them_mh_hoa_don_ban 1, 'MH02', 15000, 4
select * from tblChiTietHoaDon
select * from tblMatHang


/*trigger sửa hóa đơn bán hàng*/
drop trigger tr_sua_mh_cua_hoa_don_ban
create trigger tr_sua_mh_cua_hoa_don_ban
on tblChiTietHoaDon
after update
as
begin
	DECLARE @slmoi int, @slcu int, @sMaHang VARCHAR(10)
	SELECT @slmoi = fSoluongmua, @sMaHang = sMaHang FROM inserted
	SELECT @slcu = fSoluongmua FROM deleted
	
	IF EXISTS(SELECT * FROM tblMatHang WHERE sMaHang = @sMaHang)
	and  (SELECT fSoLuong FROM tblMatHang WHERE sMaHang = @sMaHang)+@slcu-@slmoi>=0
		BEGIN
			UPDATE tblMatHang
			SET fSoLuong = fSoLuong + @slcu - @slmoi
			WHERE sMaHang = @sMaHang
		END
	else
		BEGIN
			print N'Không thể sửa được'
			ROLLBACK TRAN
		END
end

/*sửa hóa đơn bán hàng*/
create proc sua_mh_cua_hoa_don_ban
@iSoHD int, 
@sMaHang varchar(10),
@fGiaban float,
@fSoluongmua float
as
begin
	update tblChiTietHoaDon
	set fGiaban = @fGiaban,
	fSoluongmua = @fSoluongmua
	where iSoHD = @iSoHD and sMaHang = @sMaHang
end

select * from tblChiTietHoaDon
select * from tblMatHang
exec sua_mh_cua_hoa_don_ban 1, 'MH09', 5000 ,12
select * from tblChiTietHoaDon
select * from tblMatHang


/*trigger tăng mặt hàng khi xóa mặt hàng khỏi hóa đơn bán*/
create trigger xoa_mat_hang_cua_hoa_don_ban
on tblChiTietHoaDon
for delete
as
begin
	declare @sMaHang varchar(10), @fSoluongmua float
	DECLARE cursorProduct CURSOR FOR  -- khai báo con trỏ cursorProduct
	SELECT sMaHang, fSoluongmua FROM deleted     -- dữ liệu trỏ tới
	OPEN cursorProduct                -- Mở con trỏ
	FETCH NEXT FROM cursorProduct     -- Đọc dòng đầu tiên
		INTO @sMaHang, @fSoluongmua
	WHILE @@FETCH_STATUS = 0          --vòng lặp WHILE khi đọc Cursor thành công
	BEGIN
		IF EXISTS(SELECT * FROM tblMatHang WHERE sMaHang = @sMaHang)
			BEGIN
				UPDATE tblMatHang
				SET fSoLuong = fSoLuong + @fSoluongmua
				WHERE sMaHang = @sMaHang
			END
		else
			begin
				print 'khong có mặt hàng này'
				ROLLBACK TRAN
			end
		FETCH NEXT FROM cursorProduct -- Đọc dòng tiếp
          INTO @sMaHang, @fSoluongmua
	END

	CLOSE cursorProduct              -- Đóng Cursor
	DEALLOCATE cursorProduct         -- Giải phóng tài nguyên
end

/*Xóa mặt hàng trong chi tiết hóa đơn bán*/
create proc xoa_mh_cua_hoa_don_ban
@iSoHD int,
@sMaHang varchar(10)
as
begin
	delete tblChiTietHoaDon
	where tblChiTietHoaDon.iSoHD = @iSoHD
	and tblChiTietHoaDon.sMaHang = @sMaHang
end

select * from tblChiTietHoaDon
select * from tblMatHang
exec xoa_mh_cua_hoa_don_ban 1, 'MH02'
select * from tblChiTietHoaDon
select * from tblMatHang

/*Tìm kiếm mặt hàng hóa đơn bán*/
drop proc tim_kiem_mh_hoa_don_ban
create proc tim_kiem_mh_hoa_don_ban
@iSoHD int,
@sMaHang varchar(10) = NULL,
@fGiabanMin float = NULL,
@fGiabanMax float = NULL,
@fSoluongbanMin float = NULL,
@fSoluongbanMax float = NULL
as
begin
	select tblChiTietHoaDon.*, tblMatHang.sTenHang, tblMatHang.fSoLuong
	from tblChiTietHoaDon, tblMatHang
	where tblChiTietHoaDon.iSoHD = @iSoHD and
		tblMatHang.sMaHang = tblChiTietHoaDon.sMaHang
		and (tblChiTietHoaDon.sMaHang = @sMaHang or ISNULL(@sMaHang,'') = '')
		and (tblChiTietHoaDon.fGiaban >= @fGiabanMin or ISNULL(@fGiabanMin,'') = '')
		and (tblChiTietHoaDon.fGiaban <= @fGiabanMax or ISNULL(@fGiabanMax,'') = '')
		and (tblChiTietHoaDon.fSoluongmua >= @fSoluongbanMin or ISNULL(@fSoluongbanMin,'') = '')
		and (tblChiTietHoaDon.fSoluongmua <= @fSoluongbanMax or ISNULL(@fSoluongbanMax,'') = '')
end

select * from tblChiTietHoaDon
exec tim_kiem_mh_hoa_don_ban 2, null, 10, 50000, 7, 10

/*Kiểm tra mặt hàng đã tồn tại trong hóa đơn bán*/
create proc kt_mh_cua_hoa_don_ban
@iSoHD int,
@sMaHang varchar(10)
as
begin
	select * from tblChiTietHoaDon
	where iSoHD = @iSoHD and sMaHang = @sMaHang
end

exec kt_mh_cua_hoa_don_ban 2, 'MH04'



/*Lấy danh sách loại hàng*/
drop proc lay_ds_loaiHang
create proc lay_ds_loaiHang
as
begin
	select * from tblLoaiHang
	where bStatus = 1
end

exec lay_ds_loaiHang

/*Lấy thông tin loại hàng theo mã*/
drop proc kiem_tra_ma_loai_hang_ton_tai
create proc kiem_tra_ma_loai_hang_ton_tai
@sMaLH varchar(10)
as
begin
	select * from tblLoaiHang
	where sMaLH = @sMaLH
end

exec kiem_tra_ma_loai_hang_ton_tai 'LH05'

/*Thêm loại hàng*/
create proc them_loai_hang
@sMaLH varchar(10),
@sTenLH  NVARCHAR(30)
as
begin
	insert into tblLoaiHang (sMaLH, sTenLH) values (@sMaLH, @sTenLH)
end

exec them_loai_hang 'LH05', 'Bim bim' 

/*Sửa loại hàng*/
drop proc sua_loai_hang
create proc sua_loai_hang
@sMaLH varchar(10),
@sTenLH  NVARCHAR(30)
as
begin
	update tblLoaiHang
	set sTenLH = @sTenLH
	where sMaLH = @sMaLH
	and bStatus = 1
end

exec sua_loai_hang 'LH05', 'Mì tôm'

/*Xóa loại hàng*/
drop proc xoa_loai_hang
create proc xoa_loai_hang
@sMaLH varchar(10)
as
begin
	update tblLoaiHang
	set bStatus = 0
	where sMaLH = @sMaLH
	and bStatus = 1
end

exec xoa_loai_hang 'LH04'


/*Lấy danh sách mặt hàng*/
drop proc lay_ds_mathang
create proc lay_ds_mathang
as
begin
	select tblMatHang.*, tblLoaiHang.sTenLH from tblMatHang, tblLoaiHang
	where tblMatHang.bStatus = 1 and tblMatHang.sMaLH = tblLoaiHang.sMaLH
end

exec lay_ds_mathang

/*Lấy mặt hàng theo id*/
create proc lay_mat_hang_id
@sMaHang varchar(10)
as
begin
	select * from tblMatHang
	where sMahang = @sMaHang
end

/*Kiểm tra mã mặt hàng tồn tại chưa*/
create proc ktra_matHang_ton_tai
@sMaHang varchar(10)
as
begin
	select * from tblMatHang
	where sMaHang = @sMaHang
end

exec ktra_matHang_ton_tai 'MH01'

/*Thêm mặt hàng*/
create proc them_mat_hang
@sMaHang VARCHAR(10),
@sTenHang NVARCHAR(50),
@sTenNCC NVARCHAR(50),
@sMaLH VARCHAR(10),
@fSoLuong FLOAT,
@fGiaHang FLOAT
as
begin
	insert into tblMatHang (sMaHang, sTenHang, sTenNCC, sMaLH, fSoLuong, fGiaHang) values (@sMaHang, @sTenHang, @sTenNCC, @sMaLH, @fSoLuong, @fGiaHang)
end

/*Sửa mặt hàng*/
create proc sua_mat_hang
@sMaHang VARCHAR(10),
@sTenHang NVARCHAR(50),
@sTenNCC NVARCHAR(50),
@sMaLH VARCHAR(10),
@fSoLuong FLOAT,
@fGiaHang FLOAT
as
begin
	update tblMatHang
	set sTenHang = @sTenHang,
	sTenNCC = @sTenNCC,
	sMaLH = @sMaLH,
	fSoLuong = @fSoLuong,
	fGiaHang = @fGiaHang
	where sMaHang = @sMaHang and bStatus = 1
end

/*xóa mặt hàng*/
create proc xoa_mat_hang
@sMaHang varchar(10)
as
begin
	update tblMatHang
	set bStatus = 0
	where sMaHang = @sMaHang and bStatus = 1
end



/*Lấy danh sách khách hàng vào combox*/
create proc lay_dsKH_den_combox
as
begin
	SELECT tblKhachHang.*, sTenKH+' - '+sDienthoai AS Description 
	from tblKhachHang
	where bStatus = 1
end

exec lay_dsKH_den_combox

/*Lấy danh sách khách hàng*/
create proc lay_ds_khach_hang
as
begin
	select * from tblKhachHang
	where bStatus = 1
end

exec lay_ds_khach_hang

/*Lấy khách hàng theo id*/
create proc lay_khach_hang_theo_id
@iMaKH int
as
begin
	select * from tblKhachHang
	where iMaKH = @iMaKH
end

/*Thêm khách hàng*/
create proc them_khach_hang
@iMaKH int,
@sTenKH nvarchar(30),
@sDiachi nvarchar(50),
@sDienthoai nvarchar(12),
@bGioiTinh bit
as
begin
	insert into tblKhachHang (iMaKH, sTenKH, sDiachi, sDienthoai, bGioiTinh) values (@iMaKH, @sTenKH, @sDiachi, @sDienthoai, @bGioiTinh)
end

/*Sửa khách hàng*/
create proc sua_khach_hang
@iMaKH int,
@sTenKH nvarchar(30),
@sDiachi nvarchar(50),
@sDienthoai nvarchar(12),
@bGioiTinh bit
as
begin
	update tblKhachHang
	set sTenKH = @sTenKH,
	sDiachi = @sDiachi,
	sDienthoai = @sDienthoai,
	bGioiTinh = @bGioiTinh
	where iMaKH = @iMaKH and bStatus = 1
end

/*Xóa khách hàng*/
create proc xoa_khach_hang
@iMaKH int
as
begin
	update tblKhachHang
	set bStatus = 0
	where iMaKH = @iMaKH and bStatus = 1
end

/*Tìm kiếm khách hàng*/
create proc proc_timkiemKH
@sTenKH nvarchar(30) = null,
@sDiachi nvarchar(50) = null,
@sDienthoai nvarchar(12) = null,
@bGioiTinh bit = null
as
begin
	select * from tblKhachHang
	where ((sTenKH like '%' + @sTenKH + '%') or ISNULL(@sTenKH,'') = '')
	and ((sDiachi like '%' + @sDiachi + '%') or ISNULL(@sDiachi,'') = '')
	and ((sDienthoai like '%' + @sDienthoai + '%') or ISNULL(@sDienthoai,'') = '')
	and ((bGioiTinh = @bGioiTinh) or ISNULL(@bGioiTinh,'') = '')
	and bStatus = 1
end

select * from tblKhachHang
exec proc_timkiemKH N'Nguyễn', N'Hà', null, 0

create proc layTaiKhoan
@sTenTK varchar(10),
@sMatKhau varchar(20)
as
begin
	select * from taikhoan
	where taikhoan.sTenTK = @sTenTK
	and taikhoan.sMatKhau = @sMatKhau
end

exec layTaiKhoan 'admin', 'D1234'

create proc doimatkhau
@sTenTK varchar(10),
@sMatKhau varchar(20)
as
begin
	update taikhoan
	set sMatKhau = @sMatKhau
	where sTenTK = @sTenTK
end

exec doimatkhau 'admin', 'D1234'