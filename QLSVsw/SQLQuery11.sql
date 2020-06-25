select * from tblDiemDT
select * from tblLop
select * from tblDeTai

detaidadky '18110090'

create procedure detaidadky
	@masinhvien varchar(50),
	@tukhoa nvarchar(50)

as
begin
set @tukhoa = lower(@tukhoa);
	select
		tblDeTai.maDetai,
		tblDeTai.tenDetai,
		tblDeTai.loaiDetai,
	 case when len(trim(tblGiaoVien.tenDem)) > 0 then CONCAT(tblGiaoVien.ho,' ',tblGiaoVien.tenDem,' ',tblGiaoVien.ten)
		else CONCAT(tblGiaoVien.ho,' ',tblGiaoVien.ten) end as gvien
	from tblDiemDT
	inner join tblLop on tblDiemDT.malophoc = tblLop.malophoc
	inner join tblDeTai on tblLop.maDetai = tblDeTai.maDetai
	inner join tblGiaoVien on tblLop.magiaovien = tblGiaoVien.magiaovien
	
	where
	tblDiemDT.masinhvien = @masinhvien
	and lower(tblDeTai.tenDetai) like '%'+@tukhoa+'%';
end

drop procedure detaidadky