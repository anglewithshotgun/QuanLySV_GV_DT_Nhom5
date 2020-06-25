CREATE PROCEDURE SelectAllSinhVien
AS

select 
	
	masinhvien,
	case 
		when LEN(tendem)>0 then
		CONCAT(ho,' ', tendem, ' ', ten)
		else CONCAT(ho, ' ', ten)
	end as hoten,
	CONVERT(varchar(10), ngaysinh, 103) as nsinh, 
	case 
		when gioitinh=1 then N'Nam'
		else N'Nữ'
	end as gt,quequan, diachi, dienthoai,email

from tblSinhVien


GO;


exec SelectAllSinhVien

drop procedure SelectAllSinhVien