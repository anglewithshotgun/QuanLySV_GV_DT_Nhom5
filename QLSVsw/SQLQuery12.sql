
create procedure dsDetai
	@masinhvien varchar(50),
	@tukhoa nvarchar(50)
as
begin
	set @tukhoa = lower(@tukhoa);
select 
	tblDeTai.maDetai,
	tblDeTai.loaiDetai,
	tblDeTai.tenDetai,
	tblLop.malophoc,
	case when len(tblGiaoVien.tenDem) > 0 then  CONCAT(tblGiaoVien.ho,' ', tblGiaoVien.tenDem,' ', tblGiaoVien.ten)
	else CONCAT(tblGiaoVien.ho,' ', tblGiaoVien.ten) end as gvien
from tblLop
	inner join tblGiaoVien on tblLop.magiaovien = tblGiaoVien.magiaovien
	inner join tblDeTai on tblLop.maDetai = tblDeTai.maDetai
where tblLop.daketthuc = 0 and 
tblLop.malophoc not in ( select malophoc from tblDiemDT where masinhvien = @masinhvien)
and lower(tblDeTai.tenDetai) like '%'+@tukhoa+'%';


end
select * from tblDeTai
select * from tblLop
exec dsDetai '18110090'
drop procedure dsDetai