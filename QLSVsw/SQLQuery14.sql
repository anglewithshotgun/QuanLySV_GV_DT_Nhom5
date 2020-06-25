select * from tblLop
create procedure dsdiem
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

select * from tblLop where daketthuc = 1
update tblLop set daketthuc = 1 where malophoc = 1001;

select * from tblDiemDT where malophoc = 1001;
update tblDiemDT set diemDetai = 10 where masinhvien = '18110090'

drop procedure dsdiem