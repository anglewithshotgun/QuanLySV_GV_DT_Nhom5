
CREATE PROCEDURE ThemMoiSV
	@Masinhvien varchar(50),
	@Ho nvarchar(10),
	@TenDem nvarchar(20),
	@Ten nvarchar(10),
	@Ngaysinh date,
	@Gioitinh tinyint,
	@Quequan nvarchar(150),
	@Diachi nvarchar(150),
	@Dienthoai varchar(30),
	@Email varchar(150)
AS
BEGIN
	INSERT INTO tblSinhVien
	(
	masinhvien, ho, tendem, ten, ngaysinh, gioitinh, quequan, diachi, dienthoai, email
	)
	VALUES
		(
		--CAST(NEXT VALUE FOR sinhvienSeq as varchar(30)),
		@Masinhvien,
		@Ho,@TenDem,  @Ten, @Ngaysinh, @Gioitinh, @Quequan, @Diachi, @Dienthoai, @Email);

	IF @@ROWCOUNT>0 BEGIN RETURN 1 END
	ELSE BEGIN RETURN 0 END;
END

-- test 

exec ThemMoiSV '18110199',N'Nguyễn','Linh', 'Anh', '2000-01-01', 0, N'Bến Tre', 'TPHCM', '09876543211', 'anhnl@gmail.com';
--Drop out 
drop procedure ThemMoiSV




select * from tblSinhVien




####Update Sinh vien

CREATE PROCEDURE UpdateSV
	@masinhvien varchar(50),
	@ho nvarchar(10),
	@tenDem nvarchar(20),
	@ten nvarchar(10),
	@ngaysinh date,
	@gioitinh tinyint,
	@quequan nvarchar(150),
	@diachi nvarchar(150),
	@dienthoai varchar(30),
	@email varchar(150)
AS
BEGIN
	UPDATE tblSinhVien
	SET
		--masinhvien = @masinhvien,
		ho= @ho,tendem= @tenDem, ten= @ten,
		ngaysinh = @ngaysinh,gioitinh= @gioitinh,
		quequan= @quequan,diachi= @diachi,
		dienthoai= @dienthoai,email= @email
	WHERE masinhvien = @masinhvien;
	IF @@ROWCOUNT>0 BEGIN RETURN 1 END
	ELSE BEGIN RETURN 0 END;
	
END

drop procedure UpdateSV

select * from tblSinhVien

exec UpdateSV '18110198',N'Nguyễn','Minh', 'Anh', '2000-01-01', 0, N'Bến Tre', 'TPHCM', '09876543211', 'anhmn@gmail.com';



---- Select hiện thông tin sinh viên
create procedure selectSV
	@masinhvien varchar(50)
as 
begin
	select 
		masinhvien, ho, tendem, ten, convert (varchar(10), ngaysinh, 103) as ngsinh,
		
		gioitinh,
		quequan, diachi, dienthoai, email
	from tblSinhVien
	where masinhvien = @masinhvien;
end 
--go;


drop procedure selectSV


exec selectSV '18110198'

select * from tblSinhVien