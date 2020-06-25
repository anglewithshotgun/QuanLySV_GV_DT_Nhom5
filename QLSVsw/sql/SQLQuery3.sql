create procedure doimatkhau

	@loaitaikhoan varchar(50),
	@taikhoan varchar(50),
	@matkhau varchar(50),
	@matkhaumoi varchar(50)
as
begin
	if @loaitaikhoan = 'GV'
		update tblGiaoVien
		set matkhau = @matkhaumoi
		where CONVERT(varchar(50),magiaovien)=@taikhoan
			and matkhau=@matkhau;
	else if @loaitaikhoan = 'SV'
		update tblSinhVien
		set matkhau = @matkhaumoi
		where CONVERT(varchar(50),masinhvien)=@taikhoan
		and matkhau=@matkhau;
end
drop procedure doimatkhau
exec doimatkhau 'GV','16','cocailol','16'
exec doimatkhau 'SV','18110090', '14062000', '18110090'
select * from tblGiaoVien
select * from tblSinhVien