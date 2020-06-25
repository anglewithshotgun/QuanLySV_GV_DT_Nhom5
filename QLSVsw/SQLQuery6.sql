
create procedure dangnhap
	@loaitaikhoan varchar(50),
	@taikhoan varchar(50),
	@matkhau varchar(50)
as
begin
if @loaitaikhoan='admin' 
			select*
			from TaiKhoan
			where tentaikhoan =@taikhoan
			and matkhau=@matkhau;
	else if @loaitaikhoan='GV' 
			select *
			from tblGiaoVien
			where CONVERT(varchar(50),magiaovien)=@taikhoan
			and matkhau=@matkhau;
	else 
		select *
		from tblSinhVien
		where masinhvien=@taikhoan
		and matkhau= @matkhau;
end

select * from tblGiaoVien
dangnhap 'gv','16','cocailol'