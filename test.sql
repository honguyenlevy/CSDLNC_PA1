use test1
go

create table KhachHang
(
	MaKH nvarchar (20),
	Ho nvarchar(20),
	Ten nvarchar(50),
	Ngsinh date,
	Sonha nvarchar(10),
	Duong nvarchar(60),
	Phuong nvarchar(30),
	Quan nvarchar(30),
	TPho nvarchar(60),
	DienThoai int
	PRIMARY KEY (Makh)
)

create table HoaDon
(
	MaHD nvarchar (20),
	MaKH nvarchar (20),
	NgayLap date,
	TongTien int
	PRIMARY KEY (MaHD)
)

create table CT_HoaDon
(
	MaHD nvarchar (20),
	MaSP nvarchar (20),
	SoLuong int,
	GiaBan int,
	GiaGiam int,
	ThanhTien int
	PRIMARY KEY (MaHD, MaSP)
)

create table SanPham
(
	MaSP nvarchar (20),
	TenSP nvarchar (100),
	SoLuongTon int,
	Mota nvarchar (200),
	Gia int
	PRIMARY KEY (MaSP)
)

alter table HoaDon add
	constraint FK_HoaDon_KhachHang foreign key (MaKH) references KhachHang (MaKH)

alter table CT_HoaDon add
	constraint FK_CT_HoaDon_HoaDon foreign key (MaHD) references HoaDon (MaHD)

alter table CT_HoaDon add
	constraint FK_CT_HoaDon_SanPham foreign key (MaSP) references SanPham (MaSP)

update KhachHang set TPho = 'Thành phố Hồ Chí Minh' where TPho = NULL

select *
from KhachHang