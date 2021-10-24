use LAB01
go
---------------------------------------------------------------------------------
-- Cau 3. Viet cac truy van
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
select cthd.MaSP, sp.TenSP, max(cthd.SoLuong)
from CT_HoaDon cthd, SanPham sp
where sp.MaSP = cthd.MaSP
group by cthd.MaSP, sp.TenSP

-- f. Cho danh sách các sản [dbo].[CT_HoaDon] phẩm có doanh thu cao nhất
select cthd.MaSP, sp.TenSP, max(cthd.ThanhTien) as N'Doanh thu'
from CT_HoaDon cthd, SanPham sp
where sp.MaSP = cthd.MaSP
group by cthd.MaSP, sp.TenSP 

select *
from CT_HoaDon cthd