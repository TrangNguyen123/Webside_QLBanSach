USE [QuanLyBanSach]
GO
/****** Object:  Table [dbo].[chitietdonhang]    Script Date: 26/04/2017 8:50:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[chitietdonhang](
	[machitietdonhang] [varchar](10) NOT NULL,
	[masach] [varchar](10) NULL,
	[madonhang] [varchar](10) NULL,
	[soluong] [int] NULL,
	[dongia] [int] NULL,
 CONSTRAINT [PK_chitietdonhang] PRIMARY KEY CLUSTERED 
(
	[machitietdonhang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[chudesach]    Script Date: 26/04/2017 8:50:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[chudesach](
	[machudesach] [varchar](10) NOT NULL,
	[tenchudesach] [nvarchar](50) NULL,
 CONSTRAINT [PK_chudesach] PRIMARY KEY CLUSTERED 
(
	[machudesach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[donhang]    Script Date: 26/04/2017 8:50:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[donhang](
	[madonhang] [varchar](10) NOT NULL,
	[ngaygiaohang] [datetime] NULL,
	[ngaydathang] [datetime] NULL,
	[tennguoinhan] [nvarchar](50) NULL,
	[diachi] [nvarchar](100) NULL,
	[makhachhang] [varchar](10) NULL,
 CONSTRAINT [PK_donhang] PRIMARY KEY CLUSTERED 
(
	[madonhang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[khachhang]    Script Date: 26/04/2017 8:50:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[khachhang](
	[makhachhang] [varchar](10) NOT NULL,
	[tenkhachhang] [nvarchar](50) NULL,
	[gioitinh] [bit] NULL,
	[ngaysinh] [datetime] NULL,
	[sodienthoai] [varchar](50) NULL,
	[diachi] [nvarchar](100) NULL,
	[email] [varchar](50) NULL,
	[taikhoan] [nvarchar](50) NULL,
	[matkhau] [varchar](50) NULL,
 CONSTRAINT [PK_khachhang] PRIMARY KEY CLUSTERED 
(
	[makhachhang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[nguoidung]    Script Date: 26/04/2017 8:50:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[nguoidung](
	[username] [nvarchar](50) NULL,
	[password] [varchar](50) NULL,
	[hoten] [nvarchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[nhaxuatban]    Script Date: 26/04/2017 8:50:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[nhaxuatban](
	[manhaxuatban] [varchar](10) NOT NULL,
	[tennhaxuatban] [nvarchar](50) NULL,
	[diachi] [nvarchar](100) NULL,
	[tieusu] [nvarchar](200) NULL,
 CONSTRAINT [PK_nhaxuatban] PRIMARY KEY CLUSTERED 
(
	[manhaxuatban] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[role]    Script Date: 26/04/2017 8:50:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[role](
	[idrole] [varchar](10) NOT NULL,
	[rolename] [nvarchar](100) NULL,
 CONSTRAINT [PK_role] PRIMARY KEY CLUSTERED 
(
	[idrole] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[sach]    Script Date: 26/04/2017 8:50:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sach](
	[masach] [varchar](10) NOT NULL,
	[tensach] [nvarchar](50) NULL,
	[giaban] [money] NULL,
	[mota] [nvarchar](100) NULL,
	[anhbia] [nvarchar](100) NULL,
	[namxuatban] [datetime] NULL,
	[tinhtrang] [bit] NULL,
	[kichco] [varchar](50) NULL,
	[sotrang] [int] NULL,
	[soluong] [int] NULL,
	[manhaxuatban] [varchar](10) NULL,
	[machudesach] [varchar](10) NULL,
	[matacgia] [varchar](10) NULL,
 CONSTRAINT [PK_sach] PRIMARY KEY CLUSTERED 
(
	[masach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tacgia]    Script Date: 26/04/2017 8:50:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tacgia](
	[matacgia] [varchar](10) NOT NULL,
	[tentacgia] [nvarchar](50) NULL,
	[diachi] [nvarchar](100) NULL,
	[tieusu] [nvarchar](200) NULL,
	[sodienthoai] [varchar](50) NULL,
 CONSTRAINT [PK_tacgia] PRIMARY KEY CLUSTERED 
(
	[matacgia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[chudesach] ([machudesach], [tenchudesach]) VALUES (N'CD1', N'Sách Văn Học')
INSERT [dbo].[chudesach] ([machudesach], [tenchudesach]) VALUES (N'CD2', N'Sách Kinh Tế')
INSERT [dbo].[chudesach] ([machudesach], [tenchudesach]) VALUES (N'CD3', N'Sách Thiếu Nhi')
INSERT [dbo].[chudesach] ([machudesach], [tenchudesach]) VALUES (N'CD4', N'Sách Thưởng Thức - Đời Sống')
INSERT [dbo].[chudesach] ([machudesach], [tenchudesach]) VALUES (N'CD5', N'Sách Tin Học - Ngoại Ngữ')
INSERT [dbo].[chudesach] ([machudesach], [tenchudesach]) VALUES (N'CD6', N'Sách Giáo Khoa - Giáo Trình')
INSERT [dbo].[donhang] ([madonhang], [ngaygiaohang], [ngaydathang], [tennguoinhan], [diachi], [makhachhang]) VALUES (N'DH1', CAST(0x0000A72B00000000 AS DateTime), CAST(0x0000A72900000000 AS DateTime), N'Lê Kim Huệ', NULL, N'KH1')
INSERT [dbo].[donhang] ([madonhang], [ngaygiaohang], [ngaydathang], [tennguoinhan], [diachi], [makhachhang]) VALUES (N'DH2', CAST(0x0000A72000000000 AS DateTime), CAST(0x0000A71E00000000 AS DateTime), NULL, NULL, N'KH2')
INSERT [dbo].[khachhang] ([makhachhang], [tenkhachhang], [gioitinh], [ngaysinh], [sodienthoai], [diachi], [email], [taikhoan], [matkhau]) VALUES (N'KH1', N'Lê Kim Huệ', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[khachhang] ([makhachhang], [tenkhachhang], [gioitinh], [ngaysinh], [sodienthoai], [diachi], [email], [taikhoan], [matkhau]) VALUES (N'KH2', N'Lê Thị Hoa', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[khachhang] ([makhachhang], [tenkhachhang], [gioitinh], [ngaysinh], [sodienthoai], [diachi], [email], [taikhoan], [matkhau]) VALUES (N'KH3', N' Nguyễn Thị Trang ', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[khachhang] ([makhachhang], [tenkhachhang], [gioitinh], [ngaysinh], [sodienthoai], [diachi], [email], [taikhoan], [matkhau]) VALUES (N'KH4', N'Nguyễn  Minh Nguyệt', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[nhaxuatban] ([manhaxuatban], [tennhaxuatban], [diachi], [tieusu]) VALUES (N'NXB1', N'NXB Trẻ', NULL, NULL)
INSERT [dbo].[nhaxuatban] ([manhaxuatban], [tennhaxuatban], [diachi], [tieusu]) VALUES (N'NXB2', N'NXB Kim Đồng', NULL, NULL)
INSERT [dbo].[nhaxuatban] ([manhaxuatban], [tennhaxuatban], [diachi], [tieusu]) VALUES (N'NXB3', N'Alphabooks', NULL, NULL)
INSERT [dbo].[nhaxuatban] ([manhaxuatban], [tennhaxuatban], [diachi], [tieusu]) VALUES (N'NXB4', N'Nhã Lam', NULL, NULL)
INSERT [dbo].[nhaxuatban] ([manhaxuatban], [tennhaxuatban], [diachi], [tieusu]) VALUES (N'NXB5', N'Trí Việt', NULL, NULL)
INSERT [dbo].[nhaxuatban] ([manhaxuatban], [tennhaxuatban], [diachi], [tieusu]) VALUES (N'NXB6', N'Kinh Tế', NULL, NULL)
INSERT [dbo].[nhaxuatban] ([manhaxuatban], [tennhaxuatban], [diachi], [tieusu]) VALUES (N'NXB7', N'Đồng Nai', NULL, NULL)
INSERT [dbo].[nhaxuatban] ([manhaxuatban], [tennhaxuatban], [diachi], [tieusu]) VALUES (N'NXB8', N'Hồng Đức', NULL, NULL)
INSERT [dbo].[sach] ([masach], [tensach], [giaban], [mota], [anhbia], [namxuatban], [tinhtrang], [kichco], [sotrang], [soluong], [manhaxuatban], [machudesach], [matacgia]) VALUES (N'1', N'Bài Tập Cơ Bản Và Nâng Cao - Toán 5', 12.0000, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'NXB7', N'CD6', N'TG23')
INSERT [dbo].[sach] ([masach], [tensach], [giaban], [mota], [anhbia], [namxuatban], [tinhtrang], [kichco], [sotrang], [soluong], [manhaxuatban], [machudesach], [matacgia]) VALUES (N'2', N'Yêu Em Từ Cái Nhìn Đầu Tiên ', 30.0000, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'NXB2', N'CD1', N'TG11')
INSERT [dbo].[sach] ([masach], [tensach], [giaban], [mota], [anhbia], [namxuatban], [tinhtrang], [kichco], [sotrang], [soluong], [manhaxuatban], [machudesach], [matacgia]) VALUES (N'3', N'Bên Nhau Trọn Đời', 40.0000, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'NXB2', N'CD1', N'TG11')
INSERT [dbo].[sach] ([masach], [tensach], [giaban], [mota], [anhbia], [namxuatban], [tinhtrang], [kichco], [sotrang], [soluong], [manhaxuatban], [machudesach], [matacgia]) VALUES (N'4', N'MicroSoft SQL Server 2008 - Quản Trị Cơ Sở Dữ Liệu', 55.0000, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'NXB2', N'CD5', N'TG21')
INSERT [dbo].[sach] ([masach], [tensach], [giaban], [mota], [anhbia], [namxuatban], [tinhtrang], [kichco], [sotrang], [soluong], [manhaxuatban], [machudesach], [matacgia]) VALUES (N'5', N'Doremon', 20.0000, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'NXB2', N'CD3', N'TG20')
INSERT [dbo].[sach] ([masach], [tensach], [giaban], [mota], [anhbia], [namxuatban], [tinhtrang], [kichco], [sotrang], [soluong], [manhaxuatban], [machudesach], [matacgia]) VALUES (N'6', N'Thám Tử Lừng Danh Conan', 35.0000, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'NXB4', N'CD3', N'TG19')
INSERT [dbo].[sach] ([masach], [tensach], [giaban], [mota], [anhbia], [namxuatban], [tinhtrang], [kichco], [sotrang], [soluong], [manhaxuatban], [machudesach], [matacgia]) VALUES (N'7', N'120 Món Ăn Ngon', 55.0000, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'NXB8', N'CD4', N'TG26')
INSERT [dbo].[tacgia] ([matacgia], [tentacgia], [diachi], [tieusu], [sodienthoai]) VALUES (N'TG1', N'Nguyễn Nhật Ánh', NULL, NULL, NULL)
INSERT [dbo].[tacgia] ([matacgia], [tentacgia], [diachi], [tieusu], [sodienthoai]) VALUES (N'TG10', N'PGS.TS.Võ Văn Nhị', NULL, NULL, NULL)
INSERT [dbo].[tacgia] ([matacgia], [tentacgia], [diachi], [tieusu], [sodienthoai]) VALUES (N'TG11', N'Cố Mạn', NULL, NULL, NULL)
INSERT [dbo].[tacgia] ([matacgia], [tentacgia], [diachi], [tieusu], [sodienthoai]) VALUES (N'TG12', N'Phỉ Ngã Tư Tồn', NULL, NULL, NULL)
INSERT [dbo].[tacgia] ([matacgia], [tentacgia], [diachi], [tieusu], [sodienthoai]) VALUES (N'TG13', N'Minh Hiểu Khê', NULL, NULL, NULL)
INSERT [dbo].[tacgia] ([matacgia], [tentacgia], [diachi], [tieusu], [sodienthoai]) VALUES (N'TG14', N'Quỳnh Hương', NULL, NULL, NULL)
INSERT [dbo].[tacgia] ([matacgia], [tentacgia], [diachi], [tieusu], [sodienthoai]) VALUES (N'TG15', N'Thiên Kim', NULL, NULL, NULL)
INSERT [dbo].[tacgia] ([matacgia], [tentacgia], [diachi], [tieusu], [sodienthoai]) VALUES (N'TG16', N'Quỳnh Chi', NULL, NULL, NULL)
INSERT [dbo].[tacgia] ([matacgia], [tentacgia], [diachi], [tieusu], [sodienthoai]) VALUES (N'TG17', N'Tuệ Văn', NULL, NULL, NULL)
INSERT [dbo].[tacgia] ([matacgia], [tentacgia], [diachi], [tieusu], [sodienthoai]) VALUES (N'TG18', N'Ngọc Linh', NULL, NULL, NULL)
INSERT [dbo].[tacgia] ([matacgia], [tentacgia], [diachi], [tieusu], [sodienthoai]) VALUES (N'TG19', N'Gosho Aoyama', NULL, NULL, NULL)
INSERT [dbo].[tacgia] ([matacgia], [tentacgia], [diachi], [tieusu], [sodienthoai]) VALUES (N'TG2', N'Vũ Trọng Phụng', NULL, NULL, NULL)
INSERT [dbo].[tacgia] ([matacgia], [tentacgia], [diachi], [tieusu], [sodienthoai]) VALUES (N'TG20', N'Fujiko.F.Fujio', NULL, NULL, NULL)
INSERT [dbo].[tacgia] ([matacgia], [tentacgia], [diachi], [tieusu], [sodienthoai]) VALUES (N'TG21', N'Phạm Hữu Khang', NULL, NULL, NULL)
INSERT [dbo].[tacgia] ([matacgia], [tentacgia], [diachi], [tieusu], [sodienthoai]) VALUES (N'TG22', N'Phạm Quang Huy', NULL, NULL, NULL)
INSERT [dbo].[tacgia] ([matacgia], [tentacgia], [diachi], [tieusu], [sodienthoai]) VALUES (N'TG23', N'Trần Thị Thủy', NULL, NULL, NULL)
INSERT [dbo].[tacgia] ([matacgia], [tentacgia], [diachi], [tieusu], [sodienthoai]) VALUES (N'TG24', N'Đỗ Ngọc Thiện ', NULL, NULL, NULL)
INSERT [dbo].[tacgia] ([matacgia], [tentacgia], [diachi], [tieusu], [sodienthoai]) VALUES (N'TG25', N'Nhiều Tác Giả', NULL, NULL, NULL)
INSERT [dbo].[tacgia] ([matacgia], [tentacgia], [diachi], [tieusu], [sodienthoai]) VALUES (N'TG26', N'Hà Châu', NULL, NULL, NULL)
INSERT [dbo].[tacgia] ([matacgia], [tentacgia], [diachi], [tieusu], [sodienthoai]) VALUES (N'TG3', N'Long Nhân', NULL, NULL, NULL)
INSERT [dbo].[tacgia] ([matacgia], [tentacgia], [diachi], [tieusu], [sodienthoai]) VALUES (N'TG4', N'Nam Cao', NULL, NULL, NULL)
INSERT [dbo].[tacgia] ([matacgia], [tentacgia], [diachi], [tieusu], [sodienthoai]) VALUES (N'TG5', N'Tô Hoài', NULL, NULL, NULL)
INSERT [dbo].[tacgia] ([matacgia], [tentacgia], [diachi], [tieusu], [sodienthoai]) VALUES (N'TG6', N'Đinh Mặc', NULL, NULL, NULL)
INSERT [dbo].[tacgia] ([matacgia], [tentacgia], [diachi], [tieusu], [sodienthoai]) VALUES (N'TG7', N'Alexandre Dumas', NULL, NULL, NULL)
INSERT [dbo].[tacgia] ([matacgia], [tentacgia], [diachi], [tieusu], [sodienthoai]) VALUES (N'TG8', N'Philip Kotler', NULL, NULL, NULL)
INSERT [dbo].[tacgia] ([matacgia], [tentacgia], [diachi], [tieusu], [sodienthoai]) VALUES (N'TG9', N'AdamKhoo', NULL, NULL, NULL)
ALTER TABLE [dbo].[chitietdonhang]  WITH CHECK ADD  CONSTRAINT [FK_chitietdonhang_donhang] FOREIGN KEY([madonhang])
REFERENCES [dbo].[donhang] ([madonhang])
GO
ALTER TABLE [dbo].[chitietdonhang] CHECK CONSTRAINT [FK_chitietdonhang_donhang]
GO
ALTER TABLE [dbo].[chitietdonhang]  WITH CHECK ADD  CONSTRAINT [FK_chitietdonhang_sach] FOREIGN KEY([masach])
REFERENCES [dbo].[sach] ([masach])
GO
ALTER TABLE [dbo].[chitietdonhang] CHECK CONSTRAINT [FK_chitietdonhang_sach]
GO
ALTER TABLE [dbo].[donhang]  WITH CHECK ADD  CONSTRAINT [FK_donhang_khachhang] FOREIGN KEY([makhachhang])
REFERENCES [dbo].[khachhang] ([makhachhang])
GO
ALTER TABLE [dbo].[donhang] CHECK CONSTRAINT [FK_donhang_khachhang]
GO
ALTER TABLE [dbo].[sach]  WITH CHECK ADD  CONSTRAINT [FK_sach_chudesach] FOREIGN KEY([machudesach])
REFERENCES [dbo].[chudesach] ([machudesach])
GO
ALTER TABLE [dbo].[sach] CHECK CONSTRAINT [FK_sach_chudesach]
GO
ALTER TABLE [dbo].[sach]  WITH CHECK ADD  CONSTRAINT [FK_sach_nhaxuatban] FOREIGN KEY([manhaxuatban])
REFERENCES [dbo].[nhaxuatban] ([manhaxuatban])
GO
ALTER TABLE [dbo].[sach] CHECK CONSTRAINT [FK_sach_nhaxuatban]
GO
ALTER TABLE [dbo].[sach]  WITH CHECK ADD  CONSTRAINT [FK_sach_tacgia] FOREIGN KEY([matacgia])
REFERENCES [dbo].[tacgia] ([matacgia])
GO
ALTER TABLE [dbo].[sach] CHECK CONSTRAINT [FK_sach_tacgia]
GO
