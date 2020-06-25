create procedure XoaSV
	@Masinhvien varchar(50)
as
begin
	delete from tblSinhVien
	where masinhvien= @Masinhvien
end

select * from tblSinhVien
exec XoaSV '18110123'