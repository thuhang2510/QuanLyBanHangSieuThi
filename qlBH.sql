use quanlybanhang

CREATE TABLE tblLoaiHang 
(
	sMaLH VARCHAR(10) PRIMARY KEY,
	sTenLH  NVARCHAR(30),
	bStatus bit default 1
)

CREATE TABLE tblMatHang (
	sMaHang VARCHAR(10) PRIMARY KEY,
	sTenHang NVARCHAR(50) NULL,
	sTenNCC NVARCHAR(50) NULL,
	sMaLH VARCHAR(10) NULL,
	fSoLuong FLOAT default 0,
	fGiaHang FLOAT NULL,
	bStatus bit default 1
)
ALTER TABLE tblMatHang
ADD CONSTRAINT FK_sMaLH_LoaiHang FOREIGN KEY(sMaLH) REFERENCES  tblLoaiHang(sMaLH)

CREATE TABLE tblKhachHang(
iMaKH int NOT NULL,
sTenKH nvarchar(30) not NULL,
sDiachi nvarchar(50) not NULL,
sDienthoai nvarchar(12) not null,
bGioiTinh bit NULL,
bStatus bit default 1
CONSTRAINT PK_tblKhachHang PRIMARY KEY (iMaKH)
);

create table tblCapNhatSL(
sMaHang VARCHAR(10) primary key,
fSoLuong FLOAT default 0,
dNgayCapNhat datetime
);

create trigger tr_them
on tblCapNhatSL
after insert
as
begin
	declare @sMaHang varchar(10), @fSoluongnhap float, @dNgayCapNhat datetime
	select @sMaHang = sMaHang, @fSoluongnhap = fSoLuong, @dNgayCapNhat = dNgayCapNhat from inserted
	if EXISTS(select * from tblMatHang where sMaHang = @sMaHang)
		begin
			update tblMatHang set fSoLuong = fSoLuong + @fSoluongnhap
			where sMaHang = @sMaHang
		end
end

create proc them
@sMaHang VARCHAR(10),
@fSoLuong FLOAT,
@dNgayCapNhat datetime
as
begin
	insert into tblCapNhatSL values(@sMaHang, @fSoLuong, @dNgayCapNhat)
end




CREATE TABLE tblNhanVien(
iMaNV int NOT NULL,
sTenNV nvarchar(30)NULL,
sDiachi nvarchar(50)NULL,
sDienthoai nvarchar(12) not null,
dNgaysinh DateTime NULL,
dNgayvaolam DateTime NULL,
fLuongcoban float NULL,
bStatus bit default 1
CONSTRAINT PK_tblNhanVien PRIMARY KEY (iMaNV)
);
ALTER TABLE tblNhanVien ADD CONSTRAINT CK_Nhanvien check (datediff("d", dNgaysinh, dNgayvaolam)/365 >= 18);

alter table tblNhanVien add bGioiTinh bit
alter table tblNhanVien drop column bGioiTinh

CREATE TABLE tblDonnhaphang(
iSoHD int NOT NULL PRIMARY KEY,
iMaNV int NOT NULL,
dNgaynhaphang DateTime NULL
);

ALTER TABLE tblDonnhaphang ADD CONSTRAINT FK_nhanvien_donnhaphang FOREIGN KEY (iMaNV) REFERENCES tblNhanVien(iMaNV),
CONSTRAINT CHK_dNgayLapHDX CHECK (dNgaynhaphang<=GETDATE());


CREATE TABLE tblChiTietNhapHang(
iSoHD int NOT NULL,
sMaHang varchar(10)NOT NULL,
fGianhap float NULL,
fSoluongnhap float NULL
);

ALTER TABLE tblChiTietNhapHang ADD CONSTRAINT PK_tblChiTietNhapHang PRIMARY KEY (iSoHD,sMahang);
ALTER TABLE tblChiTietNhapHang ADD CONSTRAINT FK_mathang_chitietnhaphang FOREIGN KEY (sMaHang) REFERENCES tblMatHang(sMaHang);
ALTER TABLE tblChiTietNhapHang ADD CONSTRAINT FK_donnhaphang_chitietnhaphang FOREIGN KEY (iSoHD) REFERENCES tblDonnhaphang(iSoHD) ON DELETE CASCADE;
ALTER TABLE tblChiTietNhapHang ADD CONSTRAINT CK_ChiTietNhapHang CHECK (fGianhap>0);
ALTER TABLE tblChiTietNhapHang ADD CONSTRAINT CK_CTnhaphang CHECK (fSoluongnhap>0);

CREATE TABLE tblHoaDon(
iSoHD int NOT NULL,
iMaNV int NOT NULL,
iMaKH int NOT NULL,
dNgaymuahang DateTime NULL,
CONSTRAINT PK_tblHoaDon PRIMARY KEY (iSoHD)
);
ALTER TABLE tblHoaDon ADD CONSTRAINT CK_DonDH CHECK (dNgaymuahang<=GETDATE());
ALTER TABLE tblHoaDon ADD CONSTRAINT FK_khachhang_donmuahang FOREIGN KEY (iMaKH) REFERENCES tblKhachHang;
ALTER TABLE tblHoaDon ADD CONSTRAINT FK_nhanvien_donmuahang FOREIGN KEY (iMaNV) REFERENCES tblNhanVien;


CREATE TABLE tblChiTietHoaDon(
iSoHD int NOT NULL,
sMaHang varchar(10)NOT NULL,
fGiaban float NULL,
fSoluongmua float NULL
);
ALTER TABLE tblChiTietHoaDon ADD CONSTRAINT FK_hoadon_chitiethoadon FOREIGN KEY (iSoHD) REFERENCES tblHoaDon(iSoHD)  ON DELETE CASCADE;
ALTER TABLE tblChiTietHoaDon ADD CONSTRAINT FK_mathang_chitiethoadon FOREIGN KEY (sMaHang) REFERENCES tblMatHang(sMaHang);
ALTER TABLE tblChiTietHoaDon ADD CONSTRAINT PK_tblChiTietHoaDon PRIMARY KEY (iSoHD,sMaHang);
ALTER TABLE tblChiTietHoaDon ADD CONSTRAINT CK_chitiethoadon CHECK (fGiaban>0);
ALTER TABLE tblChiTietHoaDon ADD CONSTRAINT CK_soluongmua CHECK (fSoluongmua>0);

insert into tblLoaiHang (sMaLH, sTenLH) values
(N'LH01',N'Nước ngọt'),
(N'LH02',N'Bánh'),
(N'LH03',N'Sữa'),
(N'LH04',N'Kẹo');
SELECT * FROM tblLoaiHang;

INSERT INTO tblMatHang(sMaHang, sTenHang, sTenNCC, sMaLH, fSoLuong, fGiaHang) VALUES
(N'MH01',N'Fanta',N'Hải Phòng',N'LH01',50,5000),
(N'MH02',N'Coca Cola',N'Nam Định',N'LH01',35,10000),
(N'MH03',N'Bánh Oreo',N'Hà Nam',N'LH02',50,150000),
(N'MH04',N'Bánh CHocolate',N'Ninh Bình',N'LH02',55,100000),
(N'MH05',N'Vinamilk',N'Hà Nam',N'LH03',20,35000),
(N'MH06',N'TH True Milk',N'Ninh Bình',N'LH03',60,40000),
(N'MH07',N'Kẹo dừa',N'Hà Nội',N'LH04',65,35000),
(N'MH08',N'Kẹo ổi',N'Hải Dương',N'LH04',70,35000);
SELECT * FROM tblMatHang;

INSERT INTO tblKhachHang(iMaKH, sTenKH, sDiachi, sDienthoai, bGioiTinh) VALUES
(1,N'Nguyễn Thị Hạnh',N'Hà Nội',N'0123457895',0),
(2,N'Nguyễn Văn Tiến',N'Hưng Yên',N'0126958441',1),
(3,N'Trần Văn Dũng',N'Bắc Giang',N'016589478',0);

INSERT INTO tblKhachHang(iMaKH, sTenKH, sDiachi, sDienthoai, bGioiTinh) VALUES (4,N'Trần Thị Vân',N'Bắc Giang',N'016589418',0);
SELECT * FROM tblKhachHang;

INSERT INTO tblNhanVien (iMaNV, sTenNV, sDiachi, sDienthoai, dNgaysinh, dNgayvaolam, fLuongcoban) VALUES
(1,N'Nguyễn Duy Khánh',N'Hà Nội',N'0163496729','1999-11-07','2017-11-11',7000000),
(2,N'Vũ Minh Cương',N'Hưng Yên',N'0163498899','1998-01-11','2017-08-11',8500000),
(3,N'Nguyễn Thị Nghiệp',N'Hưng Yên',N'0163401569','1998-07-11','2017-03-25',6000000);

SELECT * FROM tblNhanVien;

INSERT INTO tblHoaDon VALUES
(1,1,1,'2021-09-18 00:00:00'),
(2,1,2,'2020-09-06 00:00:00'),
(3,2,3,'2021-09-25 00:00:00'),
(4,3,2,'2022-01-21 00:00:00');
SELECT * FROM tblHoaDon;

INSERT INTO tblChiTietHoaDon VALUES
(1,N'MH01',5000,10),
(1,N'MH08',35000,12),
(1,N'MH03',150000,1),
(2,N'MH04',100000,5),
(2,N'MH05',35000,7),
(2,N'MH06',40000,11),
(3,N'MH07',35000,4),
(3,N'MH04',100000,5),
(3,N'MH06',40000,9);
SELECT * FROM tblChiTietHoaDon;

INSERT INTO tblDonnhaphang VALUES
(1,1,'2020-2-15'),
(2,2,'2020-1-29'),
(3,1,'2020-3-22');

INSERT INTO tblDonnhaphang VALUES(4,1,'2020-2-16')

INSERT INTO tblChiTietNhapHang VALUES
(1,'MH01',3000,20),
(2,'MH03',100000,15),
(3,'MH04',75000,40),
(1,'MH05',15000,100),
(2,'MH06',20000,30),
(3,'MH07',25000,25),
(2,'MH08',25000,25);

