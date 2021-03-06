USE [QLSV]
GO
/****** Object:  StoredProcedure [dbo].[SelectAllSinhVien]    Script Date: 6/3/2020 10:24:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SelectAllSinhVien]
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
order by ten


GO;

