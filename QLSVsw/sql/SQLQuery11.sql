USE [QLSV]
GO
/****** Object:  StoredProcedure [dbo].[dsdiem]    Script Date: 6/18/2020 9:04:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[dsdiem]
	@masinhvien varchar(50),
	@tukhoa nvarchar(50)
as
begin
	set @tukhoa = lower(@tukhoa);
	select 
		tblDetai.maDetai,
		tblDeTai.tenDetai,
		tblDetai.loaiDetai,
		tblDiemDT.diemDetai,
		tblDiemDT.tienTrinhDT,
		case when len(trim(tblGiaoVien.tenDem)) > 0 then CONCAT(tblGiaoVien.ho,' ',tblGiaoVien.tenDem,' ',tblGiaoVien.ten)
		else CONCAT(tblGiaoVien.ho,' ',tblGiaoVien.ten) end as gvien
	from tblDiemDT 
	inner join tblLop on tblDiemDT.malophoc = tblLop.malophoc
	inner join tblDeTai on tblLop.maDetai = tblDeTai.maDetai
	inner join tblGiaoVien on tblLop.magiaovien =tblGiaoVien.magiaovien
	where  tblDiemDT.masinhvien = @masinhvien
	and lower(tblDeTai.tenDetai) like '%'+@tukhoa+'%';

end



exec dsdiem '18110090',''