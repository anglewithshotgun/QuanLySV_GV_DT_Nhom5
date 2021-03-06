USE [QLSV]
GO
/****** Object:  StoredProcedure [dbo].[ThemMoiSV]    Script Date: 6/18/2020 8:45:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[ThemMoiSV]
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

exec ThemMoiSV '18110011', 'Nguyễn','Văn','Chóa', '1/1/2000', '1','','','',''

select * from tblSinhVien


