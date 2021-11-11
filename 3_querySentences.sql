use LAB01
go
---------------------------------------------------------------------------------
-- Cập nhật bảng KhachHang cột TPho trước khi thực hiện truy vấn câu b
update KhachHang
set KhachHang.TPho = N'Thành phố Hồ Chí Minh'
where KhachHang.TPho = N''

---------------------------------------------------------------------------------
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
