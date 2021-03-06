USE [BanSach]
GO
/****** Object:  Table [dbo].[CHITIET_HD]    Script Date: 10/05/2017 6:48:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIET_HD](
	[masach] [int] NOT NULL,
	[maHD] [int] NOT NULL,
	[soluong] [int] NULL,
	[dongia] [int] NULL,
 CONSTRAINT [PK_CHITIET_HD] PRIMARY KEY CLUSTERED 
(
	[masach] ASC,
	[maHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DANHMUCSACH]    Script Date: 10/05/2017 6:48:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANHMUCSACH](
	[maDMS] [int] IDENTITY(1,1) NOT NULL,
	[tenDMS] [nvarchar](50) NULL,
 CONSTRAINT [PK_DANHMUCSACH] PRIMARY KEY CLUSTERED 
(
	[maDMS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 10/05/2017 6:48:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[maHD] [int] IDENTITY(1,1) NOT NULL,
	[ngaygiaohang] [date] NULL,
	[ngaydathang] [date] NULL,
	[tennguoinhan] [nvarchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
	[maKH] [int] NULL,
	[tinhtranggiaohang] [bit] NULL,
	[dathanhtoan] [bit] NULL,
 CONSTRAINT [PK_HOADON] PRIMARY KEY CLUSTERED 
(
	[maHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 10/05/2017 6:48:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[maKH] [int] IDENTITY(1,1) NOT NULL,
	[tenKH] [nvarchar](50) NULL,
	[gioitinh] [nchar](10) NULL,
	[sodienthoai] [nchar](11) NULL,
	[email] [nvarchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
	[taikhoan] [nchar](10) NULL,
	[matkhau] [nchar](10) NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[maKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NGUOIDUNG]    Script Date: 10/05/2017 6:48:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGUOIDUNG](
	[tenND] [nvarchar](50) NULL,
	[matkhau] [nchar](10) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHAXUATBAN]    Script Date: 10/05/2017 6:48:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHAXUATBAN](
	[maNXB] [int] IDENTITY(1,1) NOT NULL,
	[tenNXB] [nvarchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
 CONSTRAINT [PK_NHAXUATBAN] PRIMARY KEY CLUSTERED 
(
	[maNXB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QUYEN]    Script Date: 10/05/2017 6:48:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUYEN](
	[IDquyen] [int] IDENTITY(1,1) NOT NULL,
	[namequyen] [nvarchar](50) NULL,
 CONSTRAINT [PK_QUYEN] PRIMARY KEY CLUSTERED 
(
	[IDquyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QUYEN_NGUOIDUNG]    Script Date: 10/05/2017 6:48:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUYEN_NGUOIDUNG](
	[tenND] [nvarchar](50) NOT NULL,
	[IDquyen] [int] NULL,
 CONSTRAINT [PK_QUYEN_NGUOIDUNG] PRIMARY KEY CLUSTERED 
(
	[tenND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SACH]    Script Date: 10/05/2017 6:48:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SACH](
	[masach] [int] IDENTITY(1,1) NOT NULL,
	[tensach] [nvarchar](50) NULL,
	[giaban] [int] NULL,
	[mota] [nvarchar](50) NULL,
	[urlAnh] [nvarchar](max) NULL,
	[namXB] [date] NULL,
	[tinhtrang] [bit] NULL,
	[sotrang] [int] NULL,
	[soluong] [int] NULL,
	[maNXB] [int] NULL,
	[maDMS] [int] NULL,
	[maTG] [int] NULL,
 CONSTRAINT [PK_SACH] PRIMARY KEY CLUSTERED 
(
	[masach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TACGIA]    Script Date: 10/05/2017 6:48:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TACGIA](
	[maTG] [int] IDENTITY(1,1) NOT NULL,
	[tenTG] [nvarchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
	[tieusu] [nvarchar](100) NULL,
 CONSTRAINT [PK_TACGIA] PRIMARY KEY CLUSTERED 
(
	[maTG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[DANHMUCSACH] ON 

INSERT [dbo].[DANHMUCSACH] ([maDMS], [tenDMS]) VALUES (1, N'Sách Văn Học')
INSERT [dbo].[DANHMUCSACH] ([maDMS], [tenDMS]) VALUES (2, N'Sách Khoa Học')
INSERT [dbo].[DANHMUCSACH] ([maDMS], [tenDMS]) VALUES (3, N'Sách Kinh Tế')
INSERT [dbo].[DANHMUCSACH] ([maDMS], [tenDMS]) VALUES (4, N'Sách Ngoại Ngữ')
SET IDENTITY_INSERT [dbo].[DANHMUCSACH] OFF
SET IDENTITY_INSERT [dbo].[KHACHHANG] ON 

INSERT [dbo].[KHACHHANG] ([maKH], [tenKH], [gioitinh], [sodienthoai], [email], [diachi], [taikhoan], [matkhau]) VALUES (1, N'Lê kim huệ', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[KHACHHANG] ([maKH], [tenKH], [gioitinh], [sodienthoai], [email], [diachi], [taikhoan], [matkhau]) VALUES (2, N'Nguyễn Thị Trang', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[KHACHHANG] ([maKH], [tenKH], [gioitinh], [sodienthoai], [email], [diachi], [taikhoan], [matkhau]) VALUES (3, N'Lê Thị Hoa', N'nữ        ', N'01667477316', N'kimhue728@gmail.com', N'abc', N'Lê Thị Hoa', N'123456    ')
SET IDENTITY_INSERT [dbo].[KHACHHANG] OFF
SET IDENTITY_INSERT [dbo].[NHAXUATBAN] ON 

INSERT [dbo].[NHAXUATBAN] ([maNXB], [tenNXB], [diachi]) VALUES (1, N'NXB Đại Học Quốc Gia', N'Hà Nội - Việt Nam')
INSERT [dbo].[NHAXUATBAN] ([maNXB], [tenNXB], [diachi]) VALUES (2, N'NXB Giáo Dục', N'Hà Nội - Việt Nam')
INSERT [dbo].[NHAXUATBAN] ([maNXB], [tenNXB], [diachi]) VALUES (3, N'NXB Phụ Nữ', N'Hà Nội - VIệt Nam')
SET IDENTITY_INSERT [dbo].[NHAXUATBAN] OFF
SET IDENTITY_INSERT [dbo].[QUYEN] ON 

INSERT [dbo].[QUYEN] ([IDquyen], [namequyen]) VALUES (1, N'Nguoi dùng')
INSERT [dbo].[QUYEN] ([IDquyen], [namequyen]) VALUES (2, N'Admin')
SET IDENTITY_INSERT [dbo].[QUYEN] OFF
SET IDENTITY_INSERT [dbo].[SACH] ON 

INSERT [dbo].[SACH] ([masach], [tensach], [giaban], [mota], [urlAnh], [namXB], [tinhtrang], [sotrang], [soluong], [maNXB], [maDMS], [maTG]) VALUES (2, N'Bài Tập Cơ Học', 30000, NULL, N'kt2.jpg', CAST(0x2E3C0B00 AS Date), NULL, NULL, NULL, 1, 3, 4)
INSERT [dbo].[SACH] ([masach], [tensach], [giaban], [mota], [urlAnh], [namXB], [tinhtrang], [sotrang], [soluong], [maNXB], [maDMS], [maTG]) VALUES (3, N'Java 2', 50000, NULL, N'It3.jpg', CAST(0x5B2C0B00 AS Date), NULL, NULL, NULL, 2, 2, 5)
INSERT [dbo].[SACH] ([masach], [tensach], [giaban], [mota], [urlAnh], [namXB], [tinhtrang], [sotrang], [soluong], [maNXB], [maDMS], [maTG]) VALUES (4, N'Tuổi Mới Lớn', 25000, NULL, N'sk5.jpg', CAST(0x79380B00 AS Date), NULL, NULL, NULL, 3, 2, 5)
INSERT [dbo].[SACH] ([masach], [tensach], [giaban], [mota], [urlAnh], [namXB], [tinhtrang], [sotrang], [soluong], [maNXB], [maDMS], [maTG]) VALUES (5, N'Kẻ Giết Thổng Thồng', 15000, NULL, N'vn3.jpg', CAST(0x79390B00 AS Date), NULL, NULL, NULL, 3, 4, 2)
INSERT [dbo].[SACH] ([masach], [tensach], [giaban], [mota], [urlAnh], [namXB], [tinhtrang], [sotrang], [soluong], [maNXB], [maDMS], [maTG]) VALUES (6, N'Bài Tập Cơ Học', 30000, NULL, N'kt2.jpg', CAST(0x2E3C0B00 AS Date), NULL, NULL, NULL, 1, 3, 4)
INSERT [dbo].[SACH] ([masach], [tensach], [giaban], [mota], [urlAnh], [namXB], [tinhtrang], [sotrang], [soluong], [maNXB], [maDMS], [maTG]) VALUES (7, N'Java 2', 50000, NULL, N'It3.jpg', CAST(0x5B2C0B00 AS Date), NULL, NULL, NULL, 2, 2, 5)
INSERT [dbo].[SACH] ([masach], [tensach], [giaban], [mota], [urlAnh], [namXB], [tinhtrang], [sotrang], [soluong], [maNXB], [maDMS], [maTG]) VALUES (8, N'Tuổi Mới Lớn', 25000, NULL, N'sk5.jpg', CAST(0x79380B00 AS Date), NULL, NULL, NULL, 3, 2, 5)
INSERT [dbo].[SACH] ([masach], [tensach], [giaban], [mota], [urlAnh], [namXB], [tinhtrang], [sotrang], [soluong], [maNXB], [maDMS], [maTG]) VALUES (9, N'Kẻ Giết Thổng Thồng', 15000, NULL, N'vn3.jpg', CAST(0x79390B00 AS Date), NULL, NULL, NULL, 3, 4, 2)
SET IDENTITY_INSERT [dbo].[SACH] OFF
SET IDENTITY_INSERT [dbo].[TACGIA] ON 

INSERT [dbo].[TACGIA] ([maTG], [tenTG], [diachi], [tieusu]) VALUES (1, N'Nguyễn Nhật Ánh', N'Hà Nội _-Việt Nam', NULL)
INSERT [dbo].[TACGIA] ([maTG], [tenTG], [diachi], [tieusu]) VALUES (2, N'Nguyên Hồng', N'Phú Thọ _ Việt Nam', NULL)
INSERT [dbo].[TACGIA] ([maTG], [tenTG], [diachi], [tieusu]) VALUES (3, N'Jone Smith', N'Califonia- USA', NULL)
INSERT [dbo].[TACGIA] ([maTG], [tenTG], [diachi], [tieusu]) VALUES (4, N'Đỗ Xuân Tiến', N'Vĩnh Phúc - Việt Nam', NULL)
INSERT [dbo].[TACGIA] ([maTG], [tenTG], [diachi], [tieusu]) VALUES (5, N'Trần Hồng Ân', N'Hà Nội - Việt Nam', NULL)
SET IDENTITY_INSERT [dbo].[TACGIA] OFF
ALTER TABLE [dbo].[CHITIET_HD]  WITH CHECK ADD  CONSTRAINT [FK_CHITIET_HD_HOADON] FOREIGN KEY([maHD])
REFERENCES [dbo].[HOADON] ([maHD])
GO
ALTER TABLE [dbo].[CHITIET_HD] CHECK CONSTRAINT [FK_CHITIET_HD_HOADON]
GO
ALTER TABLE [dbo].[CHITIET_HD]  WITH CHECK ADD  CONSTRAINT [FK_CHITIET_HD_SACH] FOREIGN KEY([masach])
REFERENCES [dbo].[SACH] ([masach])
GO
ALTER TABLE [dbo].[CHITIET_HD] CHECK CONSTRAINT [FK_CHITIET_HD_SACH]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_KHACHHANG] FOREIGN KEY([maKH])
REFERENCES [dbo].[KHACHHANG] ([maKH])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_KHACHHANG]
GO
ALTER TABLE [dbo].[NGUOIDUNG]  WITH CHECK ADD  CONSTRAINT [FK_NGUOIDUNG_QUYEN_NGUOIDUNG] FOREIGN KEY([tenND])
REFERENCES [dbo].[QUYEN_NGUOIDUNG] ([tenND])
GO
ALTER TABLE [dbo].[NGUOIDUNG] CHECK CONSTRAINT [FK_NGUOIDUNG_QUYEN_NGUOIDUNG]
GO
ALTER TABLE [dbo].[QUYEN_NGUOIDUNG]  WITH CHECK ADD  CONSTRAINT [FK_QUYEN_NGUOIDUNG_QUYEN] FOREIGN KEY([IDquyen])
REFERENCES [dbo].[QUYEN] ([IDquyen])
GO
ALTER TABLE [dbo].[QUYEN_NGUOIDUNG] CHECK CONSTRAINT [FK_QUYEN_NGUOIDUNG_QUYEN]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_DANHMUCSACH] FOREIGN KEY([maDMS])
REFERENCES [dbo].[DANHMUCSACH] ([maDMS])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_DANHMUCSACH]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_NHAXUATBAN] FOREIGN KEY([maNXB])
REFERENCES [dbo].[NHAXUATBAN] ([maNXB])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_NHAXUATBAN]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_TACGIA] FOREIGN KEY([maTG])
REFERENCES [dbo].[TACGIA] ([maTG])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_TACGIA]
GO
