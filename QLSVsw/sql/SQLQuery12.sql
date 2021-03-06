create procedure selectDetai
	@masinhvien varchar(50),
	@tukhoa nvarchar(50)
	
as
begin
set @tukhoa = lower(@tukhoa);
	select
		tblDeTai.maDetai,
		tblDeTai.tenDetai,
		tblDetai.loaiDetai,
		tblDetai.part1,
		tblDetai.part2,
		tblDetai.part3,
		tblDetai.part4,
		tblDiemDT.diemDetai,

	 case when len(trim(tblGiaoVien.tenDem)) > 0 then CONCAT(tblGiaoVien.ho,' ',tblGiaoVien.tenDem,' ',tblGiaoVien.ten)
		else CONCAT(tblGiaoVien.ho,' ',tblGiaoVien.ten) end as gvien
	from tblDiemDT
	inner join tblLop on tblDiemDT.malophoc = tblLop.malophoc
	inner join tblDeTai on tblLop.maDetai = tblDeTai.maDetai
	inner join tblGiaoVien on tblLop.magiaovien = tblGiaoVien.magiaovien
	
	where
	tblDiemDT.masinhvien = @masinhvien
	and (lower(tblDeTai.tenDetai) like '%'+@tukhoa+'%'
	or tblDeTai.maDetai = @tukhoa);
end

create procedure detaidadky
	@masinhvien varchar(50),
	@tukhoa nvarchar(50)
	
as
begin
set @tukhoa = lower(@tukhoa);
	select
		tblDeTai.maDetai,
		tblDeTai.tenDetai,


	 case when len(trim(tblGiaoVien.tenDem)) > 0 then CONCAT(tblGiaoVien.ho,' ',tblGiaoVien.tenDem,' ',tblGiaoVien.ten)
		else CONCAT(tblGiaoVien.ho,' ',tblGiaoVien.ten) end as gvien
	from tblDiemDT
	inner join tblLop on tblDiemDT.malophoc = tblLop.malophoc
	inner join tblDeTai on tblLop.maDetai = tblDeTai.maDetai
	inner join tblGiaoVien on tblLop.magiaovien = tblGiaoVien.magiaovien
	
	where
	tblDiemDT.masinhvien = @masinhvien
	and (lower(tblDeTai.tenDetai) like '%'+@tukhoa+'%'
	or tblDeTai.maDetai = @tukhoa);
end

exec selectDetai '18110090', '1'
drop procedure selectDetai
exec detaidadky '18110090','1'

