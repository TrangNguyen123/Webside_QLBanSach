USE [BanSach]
GO
/****** Object:  Table [dbo].[CHITIET_HD]    Script Date: 5/7/2017 2:37:01 PM ******/
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
/****** Object:  Table [dbo].[DANHMUCSACH]    Script Date: 5/7/2017 2:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANHMUCSACH](
	[maDMS] [int] NOT NULL,
	[tenDMS] [nvarchar](50) NULL,
 CONSTRAINT [PK_DANHMUCSACH] PRIMARY KEY CLUSTERED 
(
	[maDMS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 5/7/2017 2:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[maHD] [int] NOT NULL,
	[ngaygiaohang] [date] NULL,
	[ngaydathang] [date] NULL,
	[tennguoinhan] [nvarchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
	[maKH] [int] NULL,
 CONSTRAINT [PK_HOADON] PRIMARY KEY CLUSTERED 
(
	[maHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 5/7/2017 2:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[maKH] [int] NOT NULL,
	[tenKH] [nvarchar](50) NULL,
	[gioitinh] [nchar](10) NULL,
	[sodienthoai] [nchar](10) NULL,
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
/****** Object:  Table [dbo].[NGUOIDUNG]    Script Date: 5/7/2017 2:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGUOIDUNG](
	[tenND] [nvarchar](50) NULL,
	[matkhau] [nchar](10) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHAXUATBAN]    Script Date: 5/7/2017 2:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHAXUATBAN](
	[maNXB] [int] NOT NULL,
	[tenNXB] [nvarchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
 CONSTRAINT [PK_NHAXUATBAN] PRIMARY KEY CLUSTERED 
(
	[maNXB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QUYEN]    Script Date: 5/7/2017 2:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUYEN](
	[IDquyen] [int] NOT NULL,
	[namequyen] [nvarchar](50) NULL,
 CONSTRAINT [PK_QUYEN] PRIMARY KEY CLUSTERED 
(
	[IDquyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QUYEN_NGUOIDUNG]    Script Date: 5/7/2017 2:37:01 PM ******/
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
/****** Object:  Table [dbo].[SACH]    Script Date: 5/7/2017 2:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SACH](
	[masach] [int] NOT NULL,
	[tensach] [nvarchar](50) NULL,
	[giaban] [int] NULL,
	[mota] [nvarchar](50) NULL,
	[urlAnh] [nvarchar](MAX) NULL,
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
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TACGIA]    Script Date: 5/7/2017 2:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TACGIA](
	[maTG] [int] NOT NULL,
	[tenTG] [nvarchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
	[tieusu] [nvarchar](100) NULL,
 CONSTRAINT [PK_TACGIA] PRIMARY KEY CLUSTERED 
(
	[maTG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[DANHMUCSACH] ([maDMS], [tenDMS]) VALUES (1         , N'Sách Văn Học')
INSERT [dbo].[DANHMUCSACH] ([maDMS], [tenDMS]) VALUES (2         , N'Sách Khoa Học')
INSERT [dbo].[DANHMUCSACH] ([maDMS], [tenDMS]) VALUES (3         , N'Sách Kinh Tế')
INSERT [dbo].[DANHMUCSACH] ([maDMS], [tenDMS]) VALUES (4         , N'Sách Ngoại Ngữ')
INSERT [dbo].[NHAXUATBAN] ([maNXB], [tenNXB], [diachi]) VALUES (1         , N'NXB Đại Học Quốc Gia', N'Hà Nội - Việt Nam')
INSERT [dbo].[NHAXUATBAN] ([maNXB], [tenNXB], [diachi]) VALUES (2         , N'NXB Giáo Dục', N'Hà Nội - Việt Nam')
INSERT [dbo].[NHAXUATBAN] ([maNXB], [tenNXB], [diachi]) VALUES (3         , N'NXB Phụ Nữ', N'Hà Nội - VIệt Nam')
INSERT [dbo].[QUYEN] ([IDquyen], [namequyen]) VALUES (1         , N'Nguoi dùng')
INSERT [dbo].[QUYEN] ([IDquyen], [namequyen]) VALUES (2         , N'Admin')
INSERT [dbo].[SACH] ([masach], [tensach], [giaban], [mota], [urlAnh], [namXB], [tinhtrang], [sotrang], [soluong], [maNXB], [maDMS], [maTG]) VALUES (1         , N'Giải Thích Ngữ Pháp Tiếng Anh', 120000, NULL, N'e6.jpg', CAST(0xBC3A0B00 AS Date), NULL, NULL, NULL, 1         , 4         , 2         )
INSERT [dbo].[TACGIA] ([maTG], [tenTG], [diachi], [tieusu]) VALUES (1         , N'Nguyễn Nhật Ánh', N'Hà Nội _-Việt Nam', NULL)
INSERT [dbo].[TACGIA] ([maTG], [tenTG], [diachi], [tieusu]) VALUES (2         , N'Nguyên Hồng', N'Phú Thọ _ Việt Nam', NULL)
INSERT [dbo].[TACGIA] ([maTG], [tenTG], [diachi], [tieusu]) VALUES (3         , N'Jone Smith', N'Califonia- USA', NULL)
INSERT [dbo].[TACGIA] ([maTG], [tenTG], [diachi], [tieusu]) VALUES (4         , N'Đỗ Xuân Tiến', N'Vĩnh Phúc - Việt Nam', NULL)
INSERT [dbo].[TACGIA] ([maTG], [tenTG], [diachi], [tieusu]) VALUES (5         , N'Trần Hồng Ân', N'Hà Nội - Việt Nam', NULL)
INSERT [dbo].[TACGIA] ([maTG], [tenTG], [diachi], [tieusu]) VALUES (6         , NULL, NULL, NULL)
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
