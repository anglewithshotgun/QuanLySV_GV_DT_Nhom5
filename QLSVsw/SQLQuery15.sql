create procedure trcuulop
	@magiaovien int,
	@tukhoa nvarchar(50)
as
begin
	set @tukhoa=LOWER(@tukhoa);
	select
		tb.malophoc,
		tb.maDetai,
		tb.tenDetai,
		count(d.masinhvien) as siso
	from 
	(
	select 

		l.malophoc,
		l.maDetai,
		m.tenDetai
	from tblLop l
	inner join tblDeTai m on l.maDetai=m.maDetai
	where daketthuc=0
	and magiaovien=@magiaovien
	and LOWER( m.tenDetai) like '%' +@tukhoa+'%'
	)
	as tb inner join tblDiemDT d on d.malophoc=tb.malophoc
	group by tb.malophoc,tb.maDetai,tb.tenDetai
end

exec trcuulop '14',''