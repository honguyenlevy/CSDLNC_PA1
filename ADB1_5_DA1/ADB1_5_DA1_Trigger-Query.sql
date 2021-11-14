use ADB1_5_DA1
go

---------------------------------------------------------------------------------
-- Cập nhật ThanhTien va TongTien trước khi test Câu 2 
update	CT_HoaDon
set ThanhTien = SoLuong * (GiaBan - GiaGiam)

update HoaDon
set TongTien = (select sum(ThanhTien)
				from CT_HoaDon
				where CT_HoaDon.MaHD = HoaDon.MaHD)

-- Cập nhật bảng KhachHang cột TPho trước khi thực hiện truy vấn Câu 3b
update KhachHang
set KhachHang.TPho = N'Thành phố Hồ Chí Minh'
where KhachHang.TPho = N''

---------------------------------------------------------------------------------
---- Cau 2. Cai cac trigger
--a. Thành tiền CTHD = (Số lượng * (Giá bán - Giá giảm))
create trigger trigger_ThanhTien	
on CT_HoaDon
for insert, update, delete	as
if update (SoLuong) or update (GiaBan) or update (GiaGiam)
begin
	if exists (select SoLuong from CT_HoaDon where SoLuong < 0) 
	begin
		raiserror (N'Số lượng sản phẩm không hợp lệ', 10, 1)
		rollback transaction
	end

	if exists (select GiaBan from CT_HoaDon where GiaBan < 0) 
	begin
		raiserror (N'Giá sản phẩm không hợp lệ', 10, 1)
		rollback transaction
	end

	update CT_HoaDon
	set	ThanhTien = cthd.SoLuong * (cthd.GiaBan - cthd.GiaGiam)
	from inserted i, SanPham sp, CT_HoaDon cthd
	where 
		sp.MaSP = i.MaSP and
		sp.MaSP = cthd.MaSP
end
go

--b. Tổng tiền (mahd) = sum (ThanhTien) cthd(mahd)
create trigger trigger_TongTien		
on CT_HoaDon 
for insert, delete, update	as
begin
	update HoaDon 
	set TongTien = (select sum(ThanhTien)
					from CT_HoaDon
					where CT_HoaDon.MaHD = HoaDon.MaHD)	
	where 
		exists (select * from deleted d	 where d.MaHD = HoaDon.MaHD) or
		exists (select * from inserted i where i.MaHD = HoaDon.MaHD) 
end
go

---------------------------------------------------------------------------------
---- Cau 3: Viết các truy vấn sau:
-- a. Cho danh sách các hoá đơn lập trong năm 2020
select *
from HoaDon hd
where YEAR(hd.NgayLap) = '2020'

-- b. Cho danh sách các khách hàng ở TPHCM
select *
from KhachHang kh
where kh.TPho = N'Thành phố Hồ Chí Minh'

-- c. Cho danh sách các sản phẩm có giá trong một khoảng từ ... đến ...
select *
from SanPham sp
where sp.Gia >= 100000 and sp.Gia <= 200000

-- d. Cho danh sách các sản phẩm có số lượng tồn < 100
select *
from SanPham sp
where sp.SoLuongTon < 100

-- e. Cho danh sách các sản phẩm bán chạy nhất (số lượng bán nhiều nhất)
select cthd.MaSP, sp.TenSP, sp.SoLuongTon, sp.Mota, sp.Gia, sum(SoLuong) as 'SoLuongBan'
from CT_HoaDon cthd, SanPham sp
where	cthd.MaSP = sp.MaSP 
group by cthd.MaSP, sp.TenSP, sp.SoLuongTon, sp.Mota, sp.Gia
having sum(cthd.SoLuong) >= all (select sum(SoLuong) 
									from CT_HoaDon cthd, SanPham sp
									where	cthd.MaSP = sp.MaSP 
									group by cthd.MaSP)
		
-- f. Cho danh sách các sản [dbo].[CT_HoaDon] phẩm có doanh thu cao nhất as 
select cthd.MaSP, sp.TenSP, sp.SoLuongTon, sp.Mota, sp.Gia, sum(ThanhTien) as 'DoanhThu'
from CT_HoaDon cthd, SanPham sp
where	cthd.MaSP = sp.MaSP 
group by cthd.MaSP, sp.TenSP, sp.SoLuongTon, sp.Mota, sp.Gia
having sum(cthd.ThanhTien) >= all (select sum(ThanhTien) 
									from CT_HoaDon cthd, SanPham sp
									where	cthd.MaSP = sp.MaSP 
									group by cthd.MaSP)

---------------------------------------------------------------------------------
---- Test for Trigger 
insert into SanPham values (N'AAB000', N'Hershey kisses', 19, '', 150000)
insert into	CT_HoaDon(MaHD, MaSP, SoLuong, GiaBan, GiaGiam) values (N'ID000000', N'AAB000', 23, 150000, 5000)

insert into SanPham values (N'AAA001', N'Kinder chocolate', 18, '', 140000)
insert into	CT_HoaDon(MaHD, MaSP, SoLuong, GiaBan, GiaGiam) values (N'ID000000', N'AAA001', 20, 140000, 5000)

delete from CT_HoaDon where MaHD = N'ID000000' and MaSP = N'AAB000'
delete from CT_HoaDon where MaHD = N'ID000000' and MaSP = N'AAA001'

delete from SanPham where TenSP = N'Hershey kisses'
delete from SanPham where TenSP = N'Kinder chocolate'

update CT_HoaDon set SoLuong = 15 where  MaHD = N'ID000000' and MaSP = N'AAB000'
update CT_HoaDon set SoLuong = -20 where  MaHD = N'ID000000' and MaSP = N'AAA001'

update CT_HoaDon set GiaBan = 12400	 where  MaHD = N'ID000000' and MaSP = N'AAB000'
update CT_HoaDon set GiaBan = -20000 where  MaHD = N'ID000000' and MaSP = N'AAA001'

select * from SanPham
select * from CT_HoaDon where MaHD = N'ID000000'
select * from HoaDon where MaHD = N'ID000000'