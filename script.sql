USE [QuanliSinhvien]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 6/25/2020 10:31:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[tentaikhoan] [varchar](50) NULL,
	[matkhau] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDeTai]    Script Date: 6/25/2020 10:31:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDeTai](
	[ngaytao] [datetime] NULL,
	[nguoitao] [varchar](50) NULL,
	[ngaycapnhat] [datetime] NULL,
	[nguoicapnhat] [varchar](50) NULL,
	[maDetai] [tinyint] NOT NULL,
	[tenDetai] [nvarchar](150) NULL,
	[loaiDetai] [nchar](30) NULL,
	[part1] [tinyint] NULL,
	[part2] [tinyint] NULL,
	[part3] [tinyint] NULL,
	[part4] [tinyint] NULL,
 CONSTRAINT [PK_tblDeTai] PRIMARY KEY CLUSTERED 
(
	[maDetai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDiemDT]    Script Date: 6/25/2020 10:31:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDiemDT](
	[ngaytao] [datetime] NULL,
	[nguoitao] [varchar](50) NULL,
	[ngaycapnhat] [datetime] NULL,
	[nguoicapnhat] [varchar](50) NULL,
	[masinhvien] [varchar](50) NOT NULL,
	[maDetai] [tinyint] NOT NULL,
	[diemDetai] [float] NULL,
	[tienTrinhDT] [nchar](10) NULL,
	[malophoc] [tinyint] NULL,
	[magiaovien] [tinyint] NULL,
 CONSTRAINT [PK_tblDiemDT] PRIMARY KEY CLUSTERED 
(
	[masinhvien] ASC,
	[maDetai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblGiaoVien]    Script Date: 6/25/2020 10:31:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblGiaoVien](
	[ngaytao] [datetime] NULL,
	[nguoitao] [varchar](50) NULL,
	[ngaycapnhat] [datetime] NULL,
	[nguoicapnhat] [varchar](50) NULL,
	[magiaovien] [tinyint] NOT NULL,
	[matkhau] [nvarchar](50) NULL,
	[ho] [nvarchar](10) NULL,
	[tenDem] [nvarchar](20) NULL,
	[ten] [nvarchar](10) NULL,
	[gioitinh] [tinyint] NULL,
	[ngaySinh] [date] NULL,
	[dienThoai] [varchar](20) NULL,
	[email] [varchar](150) NULL,
	[diachi] [varchar](150) NULL,
 CONSTRAINT [PK_tblGiaoVien] PRIMARY KEY CLUSTERED 
(
	[magiaovien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLop]    Script Date: 6/25/2020 10:31:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLop](
	[ngaytao] [datetime] NULL,
	[nguoitao] [varchar](50) NULL,
	[ngaycapnhat] [datetime] NULL,
	[nguoicapnhat] [varchar](50) NULL,
	[malophoc] [tinyint] NULL,
	[magiaovien] [tinyint] NULL,
	[maDetai] [tinyint] NULL,
	[daketthuc] [nchar](1) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSinhVien]    Script Date: 6/25/2020 10:31:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSinhVien](
	[ngaytao] [datetime] NULL,
	[nguoitao] [varchar](50) NULL,
	[ngaycapnhat] [datetime] NULL,
	[nguoicapnhat] [varchar](50) NULL,
	[ho] [nvarchar](10) NULL,
	[tendem] [nvarchar](20) NULL,
	[ten] [nvarchar](10) NULL,
	[ngaysinh] [date] NULL,
	[gioitinh] [tinyint] NULL,
	[quequan] [nvarchar](150) NULL,
	[diachi] [nvarchar](150) NULL,
	[dienthoai] [varchar](30) NULL,
	[email] [varchar](150) NULL,
	[malophoc] [tinyint] NULL,
	[matkhau] [varchar](50) NULL,
	[masinhvien] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblSinhVien] PRIMARY KEY CLUSTERED 
(
	[masinhvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[TaiKhoan] ([tentaikhoan], [matkhau]) VALUES (N'admin', N'admin')
GO
INSERT [dbo].[tblDeTai] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [maDetai], [tenDetai], [loaiDetai], [part1], [part2], [part3], [part4]) VALUES (CAST(N'2020-06-22T21:35:45.340' AS DateTime), N'admin', CAST(N'2020-06-22T21:35:45.340' AS DateTime), N'admin', 0, N'test thu lan 1', N'test thu lan 1                ', 1, 0, 1, 0)
INSERT [dbo].[tblDeTai] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [maDetai], [tenDetai], [loaiDetai], [part1], [part2], [part3], [part4]) VALUES (CAST(N'2020-06-22T21:28:46.777' AS DateTime), N'admin', CAST(N'2020-06-22T21:28:46.777' AS DateTime), N'admin', 3, N'Quản lý dự án', N'3                             ', NULL, NULL, NULL, NULL)
INSERT [dbo].[tblDeTai] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [maDetai], [tenDetai], [loaiDetai], [part1], [part2], [part3], [part4]) VALUES (CAST(N'2020-06-22T14:14:53.950' AS DateTime), N'admin', CAST(N'2020-06-22T14:14:53.950' AS DateTime), N'admin', 99, N'Quan ly bai test', N'Đồ án tốt nghiệp              ', 1, 1, 1, 0)
INSERT [dbo].[tblDeTai] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [maDetai], [tenDetai], [loaiDetai], [part1], [part2], [part3], [part4]) VALUES (CAST(N'2020-06-22T14:00:14.563' AS DateTime), N'admin', CAST(N'2020-06-22T14:00:14.563' AS DateTime), N'admin', 111, N'Quản lý quán cafe', N'Đồ án môn học                 ', NULL, NULL, NULL, NULL)
INSERT [dbo].[tblDeTai] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [maDetai], [tenDetai], [loaiDetai], [part1], [part2], [part3], [part4]) VALUES (CAST(N'2020-06-22T14:10:06.857' AS DateTime), N'admin', CAST(N'2020-06-22T14:10:06.857' AS DateTime), N'admin', 112, N'Quản lý chuỗi nhà hàng', N'Đồ án môn học                 ', NULL, NULL, NULL, NULL)
INSERT [dbo].[tblDeTai] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [maDetai], [tenDetai], [loaiDetai], [part1], [part2], [part3], [part4]) VALUES (CAST(N'2020-06-22T14:11:10.300' AS DateTime), N'admin', CAST(N'2020-06-22T14:11:10.300' AS DateTime), N'admin', 115, N'Quan ly khach san', N'Do an mon hoc                 ', NULL, NULL, NULL, NULL)
INSERT [dbo].[tblDeTai] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [maDetai], [tenDetai], [loaiDetai], [part1], [part2], [part3], [part4]) VALUES (CAST(N'2020-06-22T22:06:42.707' AS DateTime), N'admin', CAST(N'2020-06-22T22:06:42.707' AS DateTime), N'admin', 200, N'quan ly chuoi nha an cong doan', N'Đồ án môn học                 ', 1, 1, 1, 0)
GO
INSERT [dbo].[tblDiemDT] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [masinhvien], [maDetai], [diemDetai], [tienTrinhDT], [malophoc], [magiaovien]) VALUES (CAST(N'2020-06-22T22:47:38.050' AS DateTime), N'18110090', CAST(N'2020-06-22T22:47:38.050' AS DateTime), N'admin', N'18110090', 99, 9, NULL, 1, NULL)
INSERT [dbo].[tblDiemDT] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [masinhvien], [maDetai], [diemDetai], [tienTrinhDT], [malophoc], [magiaovien]) VALUES (CAST(N'2020-06-24T16:10:50.883' AS DateTime), N'18110123', CAST(N'2020-06-24T16:10:50.883' AS DateTime), N'admin', N'18110123', 99, 9, NULL, 1, NULL)
INSERT [dbo].[tblDiemDT] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [masinhvien], [maDetai], [diemDetai], [tienTrinhDT], [malophoc], [magiaovien]) VALUES (CAST(N'2020-06-25T09:05:32.627' AS DateTime), N'18110123', CAST(N'2020-06-25T09:05:32.627' AS DateTime), N'admin', N'18110123', 200, NULL, NULL, 10, NULL)
GO
INSERT [dbo].[tblGiaoVien] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [magiaovien], [matkhau], [ho], [tenDem], [ten], [gioitinh], [ngaySinh], [dienThoai], [email], [diachi]) VALUES (CAST(N'2020-06-22T13:38:41.693' AS DateTime), N'admin', CAST(N'2020-06-22T13:38:41.693' AS DateTime), N'admin', 1, N'0000', N'Nguyen', N'Van', N'Long', 1, CAST(N'1995-03-22' AS Date), N'', N'', N'')
INSERT [dbo].[tblGiaoVien] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [magiaovien], [matkhau], [ho], [tenDem], [ten], [gioitinh], [ngaySinh], [dienThoai], [email], [diachi]) VALUES (CAST(N'2020-06-22T13:41:23.123' AS DateTime), N'admin', CAST(N'2020-06-22T13:41:23.123' AS DateTime), N'admin', 2, N'0000', N'Nguyen', N'Thanh', N'Long', 1, CAST(N'1997-03-12' AS Date), N'', N'', N'')
INSERT [dbo].[tblGiaoVien] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [magiaovien], [matkhau], [ho], [tenDem], [ten], [gioitinh], [ngaySinh], [dienThoai], [email], [diachi]) VALUES (CAST(N'2020-06-24T14:48:00.137' AS DateTime), N'admin', CAST(N'2020-06-24T14:48:00.137' AS DateTime), N'admin', 150, N'0000', N'Lâm', N'Lang', N'Thiên', 1, CAST(N'1998-12-12' AS Date), N'', N'', N'')
GO
INSERT [dbo].[tblLop] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [malophoc], [magiaovien], [maDetai], [daketthuc]) VALUES (CAST(N'2020-06-22T22:06:42.710' AS DateTime), N'admin', CAST(N'2020-06-22T22:06:42.710' AS DateTime), N'admin', 10, 1, 200, N'0')
GO
INSERT [dbo].[tblSinhVien] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [ho], [tendem], [ten], [ngaysinh], [gioitinh], [quequan], [diachi], [dienthoai], [email], [malophoc], [matkhau], [masinhvien]) VALUES (NULL, NULL, NULL, NULL, N'Lê', N'Ngọc', N'Hải', CAST(N'2000-06-01' AS Date), 1, N'', N'', N'', N'', NULL, N'0000', N'18110000')
INSERT [dbo].[tblSinhVien] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [ho], [tendem], [ten], [ngaysinh], [gioitinh], [quequan], [diachi], [dienthoai], [email], [malophoc], [matkhau], [masinhvien]) VALUES (NULL, NULL, NULL, NULL, N'Bùi', N'Việt', N'Duy', CAST(N'2000-06-14' AS Date), 1, N'Nha Trang', N'', N'', N'', NULL, N'0000', N'18110090')
INSERT [dbo].[tblSinhVien] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [ho], [tendem], [ten], [ngaysinh], [gioitinh], [quequan], [diachi], [dienthoai], [email], [malophoc], [matkhau], [masinhvien]) VALUES (NULL, NULL, NULL, NULL, N'Nguyễn', N'Văn', N'Huy', CAST(N'2000-06-21' AS Date), 1, N'Trà Vinh', N'', N'', N'', NULL, N'0000', N'18110123')
INSERT [dbo].[tblSinhVien] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [ho], [tendem], [ten], [ngaysinh], [gioitinh], [quequan], [diachi], [dienthoai], [email], [malophoc], [matkhau], [masinhvien]) VALUES (NULL, NULL, NULL, NULL, N'Tran ', N'Gia', N'Phuc', CAST(N'2000-06-21' AS Date), 1, N'Bến Tre', N'', N'', N'', NULL, N'0000', N'18110178')
GO
ALTER TABLE [dbo].[tblDeTai] ADD  CONSTRAINT [DF_tblDeTai_ngaytao]  DEFAULT (getdate()) FOR [ngaytao]
GO
ALTER TABLE [dbo].[tblDeTai] ADD  CONSTRAINT [DF_tblDeTai_nguoitao]  DEFAULT ('admin') FOR [nguoitao]
GO
ALTER TABLE [dbo].[tblDeTai] ADD  CONSTRAINT [DF_tblDeTai_ngaycapnhat]  DEFAULT (getdate()) FOR [ngaycapnhat]
GO
ALTER TABLE [dbo].[tblDeTai] ADD  CONSTRAINT [DF_tblDeTai_nguoicapnhat]  DEFAULT ('admin') FOR [nguoicapnhat]
GO
ALTER TABLE [dbo].[tblDiemDT] ADD  CONSTRAINT [DF_tblDiemDT_ngaytao]  DEFAULT (getdate()) FOR [ngaytao]
GO
ALTER TABLE [dbo].[tblDiemDT] ADD  CONSTRAINT [DF_tblDiemDT_nguoitao]  DEFAULT ('admin') FOR [nguoitao]
GO
ALTER TABLE [dbo].[tblDiemDT] ADD  CONSTRAINT [DF_tblDiemDT_ngaycapnhat]  DEFAULT (getdate()) FOR [ngaycapnhat]
GO
ALTER TABLE [dbo].[tblDiemDT] ADD  CONSTRAINT [DF_tblDiemDT_nguoicapnhat]  DEFAULT ('admin') FOR [nguoicapnhat]
GO
ALTER TABLE [dbo].[tblGiaoVien] ADD  CONSTRAINT [DF_tblGiaoVien_ngaytao]  DEFAULT (getdate()) FOR [ngaytao]
GO
ALTER TABLE [dbo].[tblGiaoVien] ADD  CONSTRAINT [DF_tblGiaoVien_nguoitao]  DEFAULT ('admin') FOR [nguoitao]
GO
ALTER TABLE [dbo].[tblGiaoVien] ADD  CONSTRAINT [DF_tblGiaoVien_ngaycapnhat]  DEFAULT (getdate()) FOR [ngaycapnhat]
GO
ALTER TABLE [dbo].[tblGiaoVien] ADD  CONSTRAINT [DF_tblGiaoVien_nguoicapnhat]  DEFAULT ('admin') FOR [nguoicapnhat]
GO
ALTER TABLE [dbo].[tblGiaoVien] ADD  CONSTRAINT [DF_tblGiaoVien_matkhau]  DEFAULT ('0000') FOR [matkhau]
GO
ALTER TABLE [dbo].[tblLop] ADD  CONSTRAINT [DF_tblLop_ngaytao]  DEFAULT (getdate()) FOR [ngaytao]
GO
ALTER TABLE [dbo].[tblLop] ADD  CONSTRAINT [DF_tblLop_nguoitao]  DEFAULT ('admin') FOR [nguoitao]
GO
ALTER TABLE [dbo].[tblLop] ADD  CONSTRAINT [DF_tblLop_ngaycapnhat]  DEFAULT (getdate()) FOR [ngaycapnhat]
GO
ALTER TABLE [dbo].[tblLop] ADD  CONSTRAINT [DF_tblLop_nguoicapnhat]  DEFAULT ('admin') FOR [nguoicapnhat]
GO
ALTER TABLE [dbo].[tblLop] ADD  CONSTRAINT [DF_tblLop_daketthuc]  DEFAULT ('0') FOR [daketthuc]
GO
ALTER TABLE [dbo].[tblSinhVien] ADD  CONSTRAINT [DF_tblSinhVien_matkhau]  DEFAULT ('0000') FOR [matkhau]
GO
ALTER TABLE [dbo].[tblDiemDT]  WITH CHECK ADD  CONSTRAINT [FK_tblDiemDT_tblDeTai] FOREIGN KEY([maDetai])
REFERENCES [dbo].[tblDeTai] ([maDetai])
GO
ALTER TABLE [dbo].[tblDiemDT] CHECK CONSTRAINT [FK_tblDiemDT_tblDeTai]
GO
ALTER TABLE [dbo].[tblDiemDT]  WITH CHECK ADD  CONSTRAINT [FK_tblDiemDT_tblGiaoVien] FOREIGN KEY([magiaovien])
REFERENCES [dbo].[tblGiaoVien] ([magiaovien])
GO
ALTER TABLE [dbo].[tblDiemDT] CHECK CONSTRAINT [FK_tblDiemDT_tblGiaoVien]
GO
ALTER TABLE [dbo].[tblDiemDT]  WITH CHECK ADD  CONSTRAINT [FK_tblDiemDT_tblSinhVien] FOREIGN KEY([masinhvien])
REFERENCES [dbo].[tblSinhVien] ([masinhvien])
GO
ALTER TABLE [dbo].[tblDiemDT] CHECK CONSTRAINT [FK_tblDiemDT_tblSinhVien]
GO
ALTER TABLE [dbo].[tblLop]  WITH CHECK ADD  CONSTRAINT [FK_tblLop_tblDeTai] FOREIGN KEY([maDetai])
REFERENCES [dbo].[tblDeTai] ([maDetai])
GO
ALTER TABLE [dbo].[tblLop] CHECK CONSTRAINT [FK_tblLop_tblDeTai]
GO
ALTER TABLE [dbo].[tblLop]  WITH CHECK ADD  CONSTRAINT [FK_tblLop_tblGiaoVien] FOREIGN KEY([magiaovien])
REFERENCES [dbo].[tblGiaoVien] ([magiaovien])
GO
ALTER TABLE [dbo].[tblLop] CHECK CONSTRAINT [FK_tblLop_tblGiaoVien]
GO
/****** Object:  StoredProcedure [dbo].[dangnhap]    Script Date: 6/25/2020 10:31:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[dangnhap]	
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
GO
/****** Object:  StoredProcedure [dbo].[detaidadky]    Script Date: 6/25/2020 10:31:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[detaidadky]
@masinhvien varchar(50),
	@tukhoa nvarchar(50)
	
as
begin
set @tukhoa = lower(@tukhoa);
	select
		tblDeTai.maDetai,
		tblDeTai.tenDetai,


	 case when len(trim(tblGiaoVien.tenDem)) > 0 then CONCAT(tblGiaoVien.ho,' ',tblGiaoVien.tenDem,' ',tblGiaoVien.ten)
		else CONCAT(tblGiaoVien.ho,' ',tblGiaoVien.ten) end as gvien
	from tblDiemDT
	inner join tblLop on tblDiemDT.malophoc = tblLop.malophoc
	inner join tblDeTai on tblLop.maDetai = tblDeTai.maDetai
	inner join tblGiaoVien on tblLop.magiaovien = tblGiaoVien.magiaovien
	
	where
	tblDiemDT.masinhvien = @masinhvien
	and (lower(tblDeTai.tenDetai) like '%'+@tukhoa+'%'
	or tblDeTai.maDetai = @tukhoa);
end
GO
/****** Object:  StoredProcedure [dbo].[DiemDT]    Script Date: 6/25/2020 10:31:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[DiemDT]	
	@madetai tinyint,
	@diemdetai float
as
begin
	update tblDiemDT
	set 
	diemDetai=@diemdetai
	where maDetai=@madetai
end
GO
/****** Object:  StoredProcedure [dbo].[dkydetai]    Script Date: 6/25/2020 10:31:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[dkydetai]
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
GO
/****** Object:  StoredProcedure [dbo].[doimatkhau]    Script Date: 6/25/2020 10:31:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[doimatkhau]
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
GO
/****** Object:  StoredProcedure [dbo].[dsDetai]    Script Date: 6/25/2020 10:31:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[dsDetai]
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
GO
/****** Object:  StoredProcedure [dbo].[dsdiem]    Script Date: 6/25/2020 10:31:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[dsdiem]
@masinhvien varchar(50),
	@tukhoa nvarchar(50)
as
begin
	set @tukhoa = lower(@tukhoa);
	select 
		tblDetai.maDetai,
		tblDeTai.tenDetai,
		tblDetai.loaiDetai,
		tblDiemDT.diemDetai,
		tblDiemDT.tienTrinhDT,
		case when len(trim(tblGiaoVien.tenDem)) > 0 then CONCAT(tblGiaoVien.ho,' ',tblGiaoVien.tenDem,' ',tblGiaoVien.ten)
		else CONCAT(tblGiaoVien.ho,' ',tblGiaoVien.ten) end as gvien
	from tblDiemDT 
	inner join tblLop on tblDiemDT.malophoc = tblLop.malophoc
	inner join tblDeTai on tblLop.maDetai = tblDeTai.maDetai
	inner join tblGiaoVien on tblLop.magiaovien =tblGiaoVien.magiaovien
	where  tblDiemDT.masinhvien = @masinhvien
	and lower(tblDeTai.tenDetai) like '%'+@tukhoa+'%';

end
GO
/****** Object:  StoredProcedure [dbo].[InsertDT]    Script Date: 6/25/2020 10:31:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InsertDT]
	@magiaovien tinyint,
	@madetai tinyint,
	@malophoc int
	

as
begin
	insert into tblLop
	(magiaovien,maDetai, malophoc)
	values
	(@magiaovien,@madetai, @malophoc);
	if @@ROWCOUNT>0 begin return 1 end
	else begin return 0 end
end
GO
/****** Object:  StoredProcedure [dbo].[InsertGV]    Script Date: 6/25/2020 10:31:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InsertGV]
	@magiaovien tinyint,
	@nguoitao varchar(30),
	@ho nvarchar(10),
	@tendem nvarchar(20),
	@ten nvarchar(10),
	@gioitinh tinyint,
	@ngaysinh date,
	@email varchar(150),
	@dienthoai varchar(30),

	@diachi nvarchar(150)
as
begin
	insert into tblGiaoVien
	(
		magiaovien,
		nguoitao,
		ho,tenDem, ten,gioitinh,ngaySinh,
		dienThoai, email, diachi

	) values (
		@magiaovien,
		@nguoitao,
		@ho,@tendem,@ten,
		@gioitinh,@ngaysinh,
		@dienthoai, @email,@diachi
	);


	if @@ROWCOUNT>0 begin return 1 end
	else begin return 0 end
end
GO
/****** Object:  StoredProcedure [dbo].[LoadDSDT]    Script Date: 6/25/2020 10:31:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[LoadDSDT]
@magiaovien int
as
begin
	
	select
		tb.maDetai,
		tb.tenDetai,
		
		tb.daketthuc
	from 
	(
	select 

		l.malophoc,
		l.maDetai,
		m.tenDetai,
		l.daketthuc
	from tblLop l
	inner join tblDeTai m on l.maDetai=m.maDetai
	where 
	magiaovien=@magiaovien
	)
	as tb 
	group by tb.malophoc,tb.maDetai,tb.tenDetai, tb.daketthuc
end
GO
/****** Object:  StoredProcedure [dbo].[selectAllGV]    Script Date: 6/25/2020 10:31:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[selectAllGV]
@tukhoa nvarchar(50)
as
begin
	select 
		magiaovien,
		case
			when LEN(tendem)>0 then CONCAT(ho,'',tendem,'',ten)
		else CONCAT(ho,'',ten)
		end as hoten,
		case when gioitinh=1 then 'Nam'
		else N'Nữ' end as gt,
		dienthoai,
		email,
		diachi
	from tblGiaoVien
	where
	LOWER(CONCAT(ho,'',tenDem,'',ten)) like '%'+LOWER(TRIM(@tukhoa))+'%'
	or lower(ho) like '%'+LOWER(TRIM(@tukhoa))+'%'
	or lower(tenDem) like '%'+LOWER(TRIM(@tukhoa))+'%'
	or lower(ten) like '%'+LOWER(TRIM(@tukhoa))+'%'
	or dienThoai like '%'+LOWER(TRIM(@tukhoa))+'%'
	or CAST(magiaovien as varchar(30)) like '%'+LOWER(TRIM(@tukhoa))+'%'
	or LOWER(email) like '%' +LOWER(TRIM(@tukhoa))+'%'
	order by ten;
end
GO
/****** Object:  StoredProcedure [dbo].[SelectAllSinhvien]    Script Date: 6/25/2020 10:31:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SelectAllSinhvien]
@tukhoa nvarchar(50)

AS

select 
	
	masinhvien,
	case 
		when LEN(tendem)>0 then
		CONCAT(ho,' ', tendem, ' ', ten)
		else CONCAT(ho, ' ', ten)
	end as hoten,
	CONVERT(varchar(10), ngaysinh, 103) as nsinh, 
	case 
		when gioitinh=1 then N'Nam'
		else N'Nữ'
	end as gt,quequan

from tblSinhVien

where 
	lower(ho) like '%'+lower(@tukhoa)+'%'
	or lower(tendem) like '%'+lower(@tukhoa)+'%'
	or lower(ten) like '%'+lower(@tukhoa)+'%'
	or dienthoai like '%'+lower(@tukhoa)+'%'
	or masinhvien= @tukhoa

order by ten


GO
/****** Object:  StoredProcedure [dbo].[selectDetai]    Script Date: 6/25/2020 10:31:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[selectDetai]
@masinhvien varchar(50),
	@tukhoa nvarchar(50)
	
as
begin
set @tukhoa = lower(@tukhoa);
	select
		tblDeTai.maDetai,
		tblDeTai.tenDetai,
		tblDetai.loaiDetai,
		tblDetai.part1,
		tblDetai.part2,
		tblDetai.part3,
		tblDetai.part4,
		tblDiemDT.diemDetai,

	 case when len(trim(tblGiaoVien.tenDem)) > 0 then CONCAT(tblGiaoVien.ho,' ',tblGiaoVien.tenDem,' ',tblGiaoVien.ten)
		else CONCAT(tblGiaoVien.ho,' ',tblGiaoVien.ten) end as gvien
	from tblDiemDT
	inner join tblLop on tblDiemDT.malophoc = tblLop.malophoc
	inner join tblDeTai on tblLop.maDetai = tblDeTai.maDetai
	inner join tblGiaoVien on tblLop.magiaovien = tblGiaoVien.magiaovien
	
	where
	tblDiemDT.masinhvien = @masinhvien
	and (lower(tblDeTai.tenDetai) like '%'+@tukhoa+'%'
	or tblDeTai.maDetai = @tukhoa);
end
GO
/****** Object:  StoredProcedure [dbo].[selectDT]    Script Date: 6/25/2020 10:31:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[selectDT]
	@madetai tinyint
as 
begin
	select 
		maDetai, tenDetai, loaiDetai
	from tblDeTai
	where maDetai = @madetai;
end 
GO
/****** Object:  StoredProcedure [dbo].[selectGV]    Script Date: 6/25/2020 10:31:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[selectGV]
@magiaovien int
as
begin
	select 
		magiaovien,
		ho,
		tenDem,
		ten,
		gioitinh,
		CONVERT(varchar(10), ngaySinh,103) as ngsinh,
		dienThoai,
		email,diachi
		from tblGiaoVien
		where magiaovien=@magiaovien;
end
GO
/****** Object:  StoredProcedure [dbo].[selectSV]    Script Date: 6/25/2020 10:31:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[selectSV]
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
GO
/****** Object:  StoredProcedure [dbo].[ThemDT]    Script Date: 6/25/2020 10:31:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ThemDT]
	@madetai tinyint,
	@tendetai nvarchar(150),
	@loaidetai nchar(30)
as
begin
	insert into tblDeTai
	(maDetai,tenDetai, loaiDetai )
	values
	( @madetai,@tendetai, @loaidetai);
	IF @@ROWCOUNT>0 BEGIN RETURN 1 END
	ELSE BEGIN RETURN 0 END;
end
GO
/****** Object:  StoredProcedure [dbo].[ThemMoiSV]    Script Date: 6/25/2020 10:31:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ThemMoiSV]
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
GO
/****** Object:  StoredProcedure [dbo].[trcuulop]    Script Date: 6/25/2020 10:31:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[trcuulop]
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
GO
/****** Object:  StoredProcedure [dbo].[UpdateDT]    Script Date: 6/25/2020 10:31:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[UpdateDT]
	@madetai tinyint,
	@tendetai nvarchar(150)
	
	
as
begin
	update tblDeTai
	set 
		
		tenDetai=@tendetai
	
	where maDetai=@madetai
end
GO
/****** Object:  StoredProcedure [dbo].[updateGV]    Script Date: 6/25/2020 10:31:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[updateGV]
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
GO
/****** Object:  StoredProcedure [dbo].[UpdateSV]    Script Date: 6/25/2020 10:31:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UpdateSV]
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
GO
/****** Object:  StoredProcedure [dbo].[updatethongtindetai]    Script Date: 6/25/2020 10:31:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[updatethongtindetai]
	@madetai tinyint,
	@part1 tinyint,
	@part2 tinyint,
	@part3 tinyint,
	@part4 tinyint


as
begin 
	UPDATE tblDeTai
	SET 
	
	
	part1= @part1,part2= @part2, part3=@part3, part4= @part4
	where maDetai= @madetai;
	IF @@ROWCOUNT>0 BEGIN RETURN 1 END
	ELSE BEGIN RETURN 0 END;


end
GO
/****** Object:  StoredProcedure [dbo].[XoaDT]    Script Date: 6/25/2020 10:31:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[XoaDT]
	@madetai tinyint
as 
begin
	delete from tblLop where maDetai=@madetai
	delete from tblDeTai where maDetai=@madetai
end 
GO
/****** Object:  StoredProcedure [dbo].[XoaGV]    Script Date: 6/25/2020 10:31:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[XoaGV]
		@magiaovien varchar(50)
as 
begin
	delete from tblGiaoVien where magiaovien=@magiaovien
end 
GO
/****** Object:  StoredProcedure [dbo].[XoaSV]    Script Date: 6/25/2020 10:31:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[XoaSV]
@Masinhvien varchar(50)
as 
begin
	delete from tblSinhVien where masinhvien=@Masinhvien
end 

GO
