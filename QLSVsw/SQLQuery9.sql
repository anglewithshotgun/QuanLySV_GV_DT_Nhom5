create procedure selectGV
	@magiaovien int
as
begin
	select 
		ho,
		tendem,
		ten,
		gioitinh,
		CONVERT(varchar(10), ngaysinh,103) as ngsinh,
		dienthoai,
		email,diachi
		from tblGiaoVien
		where magiaovien=@magiaovien;
end
select *from tblGiaoVien

