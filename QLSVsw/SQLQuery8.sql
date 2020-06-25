select * from tblGiaoVien

create procedure updateGiaoVien
	@nguoicapnhat varchar(30),
	@magiaovien int,
	@ho nvarchar(10),
	@tendem nvarchar(20),
	@ten nvarchar(10),
	@gioitinh tinyint,
	@ngaysinh date,
	@dienthoai varchar(30),
	@email varchar(150),
	@diachi nvarchar(150)
as
begin
	update tblGiaoVien
	set
		nguoicapnhat=@nguoicapnhat,
		ngaycapnhat =GETDATE(),
		ho=@ho, tenDem=@tendem,ten=@ten,
		gioitinh=@gioitinh, ngaySinh=@ngaysinh,
		dienThoai=@dienthoai, email=@email, diachi=@diachi
	where magiaovien=@magiaovien;

end