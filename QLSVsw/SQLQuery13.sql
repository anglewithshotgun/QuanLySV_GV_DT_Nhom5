
create procedure dkydetai
	@masinhvien varchar(50),
	@malophoc int,
	@maDetai int
as
begin
	declare @v_maDetai int,
			@v_dangky int;

	select @v_maDetai = maDetai
	from tblLop
	where malophoc = @malophoc
	and maDetai = @v_maDetai;

	-- kiem tra xem sinh vien da dang ky de tai o lop khac chua
	--select @v_dangky = count(*)
	--from tblDiemDT
	--inner join tblLop on tblDiemDT.malophoc = tblLop.malophoc
	--where tblLop.daketthuc = 0
	--and tblLop.maDetai = @v_maDetai
	--and tblDiemDT.masinhvien = @masinhvien;
	--neu tra ve -1 la dky roi
	--if @v_dangky > 0  return -1;

	insert into tblDiemDT(nguoitao, masinhvien, malophoc, maDetai)
	values (@masinhvien, @masinhvien, @malophoc, @maDetai);

	if @@ROWCOUNT > 0 return 1 else return 0;
end

select * from tblDeTai
select * from tblSinhVien
exec dkydetai '18110090', 1005, 5;

select * from tblDiemDT

drop procedure dkydetai