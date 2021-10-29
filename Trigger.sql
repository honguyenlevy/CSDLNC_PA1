create database HoaDon
go
use HoaDon
go

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

alter table CT_HoaDon add
	constraint FK_CT_HoaDon_HoaDon foreign key (MaHD) references HoaDon (MaHD)
	

--Tạo trigger
--Câu a
go
create trigger trg_ThanhTien on CT_HoaDon after insert as
begin
	update CT_HoaDon set ThanhTien = CT.SoLuong * (CT.GiaBan - CT.GiaGiam)
					from inserted i, CT_HoaDon CT 
					where (i.MaHD = CT.MaHD) and (i.MaSP = CT.MaSP)
end


--Câu b
go
create trigger trg_TongTien on HoaDon after insert as
begin

	update HoaDon set TongTien = (select sum(CT.ThanhTien) 
					from CT_HoaDon CT
					where CT.MaHD = i.MaHD
					group by CT.MaHD)					
				from inserted i, HoaDon HD
				where i.MaHD  = HD.MaHD 
				
end
go
--Thêm dữ liệu
insert into HoaDon values ('HD01', 'KH01',null, null)
insert into HoaDon values ('HD02', 'KH02',null, null)
insert into HoaDon values ('HD03', 'KH03',null, null)
insert into HoaDon values ('HD04', 'KH04',null, null)

insert into CT_HoaDon values ('HD01', 'SP01',3,20000,3000, null)
insert into CT_HoaDon values ('HD01', 'SP02',6,7000,5000, null)
insert into CT_HoaDon values ('HD01', 'SP03',2,15000,2000, null)
insert into CT_HoaDon values ('HD01', 'SP04',1,11000,4000, null)
insert into CT_HoaDon values ('HD02', 'SP01',5,20000,3000, null)
insert into CT_HoaDon values ('HD02', 'SP02',1,7000,5000, null)
insert into CT_HoaDon values ('HD02', 'SP03',8,15000,2000, null)
insert into CT_HoaDon values ('HD02', 'SP04',4,11000,4000, null)

go
select * from CT_HoaDon
select * from HoaDon
