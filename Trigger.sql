alter trigger trigthanhTien on CT_HoaDon
alter insert, update
as
	update CT_HoaDon set ThanhTien = CT.SoLuong * (GiaBan - GiaGiam)
			from inserted i, CT_HoaDon CT 
			where CT.MaSP = i.MaSP
go

alter trigger trigTongTien on HoaDon
alter insert, update
as
	update HoaDon set TongTien = sum(CT.ThanhTien)
			from inserted i, CT_HoaDon CT, HoaDon HD 
			where i.MaHD = HD.MaHD and HD.MaHD = CT.MaHD
go