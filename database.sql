CREATE DATABASE hotelhub
GO
USE [hotelhub]
GO
/****** Object:  Table [dbo].[ct_dichvu]    Script Date: 2/11/2024 2:12:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ct_dichvu](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_dichvu] [int] NULL,
	[tendichvu] [nvarchar](50) NULL,
	[giatien] [decimal](18, 0) NULL,
	[soluong] [int] NULL,
	[thanhtien] [decimal](18, 0) NULL,
 CONSTRAINT [PK_ct_dichvu] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cthoadon]    Script Date: 2/11/2024 2:12:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cthoadon](
	[id_cthoadon] [int] IDENTITY(1,1) NOT NULL,
	[id_hoadon] [int] NULL,
	[id_dichvu] [int] NULL,
	[dongia] [decimal](18, 0) NULL,
	[soluongsudungdichvu] [int] NULL,
 CONSTRAINT [PK_cthoadon] PRIMARY KEY CLUSTERED 
(
	[id_cthoadon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customer]    Script Date: 2/11/2024 2:12:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer](
	[id_customer] [int] IDENTITY(1,1) NOT NULL,
	[tenkhachhang] [nvarchar](50) NULL,
	[so_cmt] [nvarchar](50) NULL,
	[quoctich] [nvarchar](50) NULL,
	[gioitinh] [nvarchar](50) NULL,
	[sdt] [nvarchar](50) NULL,
 CONSTRAINT [PK_customer] PRIMARY KEY CLUSTERED 
(
	[id_customer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dichvu]    Script Date: 2/11/2024 2:12:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dichvu](
	[id_dichvu] [int] IDENTITY(1,1) NOT NULL,
	[tendichvu] [nvarchar](50) NULL,
	[giadichvu] [decimal](18, 0) NULL,
 CONSTRAINT [PK_dichvu] PRIMARY KEY CLUSTERED 
(
	[id_dichvu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hoadon]    Script Date: 2/11/2024 2:12:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hoadon](
	[id_hoadon] [int] IDENTITY(1,1) NOT NULL,
	[id_customer] [int] NULL,
	[id_staff] [int] NULL,
	[giaphongmotngay] [decimal](18, 0) NULL,
	[id_room] [int] NULL,
	[ngaythuephong] [date] NULL,
	[ngaytraphong] [date] NULL,
	[thanhtien] [decimal](18, 0) NULL,
 CONSTRAINT [PK_hoadon] PRIMARY KEY CLUSTERED 
(
	[id_hoadon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[loaiphong]    Script Date: 2/11/2024 2:12:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[loaiphong](
	[id_loaiphong] [int] IDENTITY(1,1) NOT NULL,
	[tenloaiphong] [nvarchar](50) NULL,
	[giaphongmotngay] [decimal](18, 0) NULL,
	[mota] [nvarchar](200) NULL,
 CONSTRAINT [PK_loaiphong] PRIMARY KEY CLUSTERED 
(
	[id_loaiphong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[phong]    Script Date: 2/11/2024 2:12:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phong](
	[id_room] [int] IDENTITY(1,1) NOT NULL,
	[tenphong] [nvarchar](50) NULL,
	[id_loaiphong] [int] NULL,
	[tinhtrang] [nvarchar](50) NULL,
 CONSTRAINT [PK_phong] PRIMARY KEY CLUSTERED 
(
	[id_room] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[staff]    Script Date: 2/11/2024 2:12:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[staff](
	[id_staff] [int] IDENTITY(1,1) NOT NULL,
	[taikhoan] [nvarchar](50) NULL,
	[hoten] [nvarchar](200) NULL,
	[ngaysinh] [date] NULL,
	[gioitinh] [nvarchar](50) NULL,
	[matkhau] [nvarchar](50) NULL,
	[role] [nvarchar](50) NULL,
 CONSTRAINT [PK_staff] PRIMARY KEY CLUSTERED 
(
	[id_staff] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[customer] ON 

INSERT [dbo].[customer] ([id_customer], [tenkhachhang], [so_cmt], [quoctich], [gioitinh], [sdt]) VALUES (4, N'Nguyễn  Thị Quỳnh Nga', N'010003659', N'Việt Nam', N'Nam', N'0862587229')
INSERT [dbo].[customer] ([id_customer], [tenkhachhang], [so_cmt], [quoctich], [gioitinh], [sdt]) VALUES (5, N'Võ Quốc Việt', N'0653946123', N'Việt Nam', N'Nam', N'0862587229')
INSERT [dbo].[customer] ([id_customer], [tenkhachhang], [so_cmt], [quoctich], [gioitinh], [sdt]) VALUES (6, N'Trần Văn Chiến', N'0312065946', N'Việt Nam', N'Nam', N'0862587229')
INSERT [dbo].[customer] ([id_customer], [tenkhachhang], [so_cmt], [quoctich], [gioitinh], [sdt]) VALUES (7, N'Phạm Tuấn Vũ', N'0616548651', N'Việt Nam', N'Nam', N'0862587229')
SET IDENTITY_INSERT [dbo].[customer] OFF
GO
SET IDENTITY_INSERT [dbo].[dichvu] ON 

INSERT [dbo].[dichvu] ([id_dichvu], [tendichvu], [giadichvu]) VALUES (1, N'Dịch vụ Spa', CAST(500000 AS Decimal(18, 0)))
INSERT [dbo].[dichvu] ([id_dichvu], [tendichvu], [giadichvu]) VALUES (2, N'Dịch vụ phòng họp', CAST(1000000 AS Decimal(18, 0)))
INSERT [dbo].[dichvu] ([id_dichvu], [tendichvu], [giadichvu]) VALUES (3, N'Pepsi', CAST(10000 AS Decimal(18, 0)))
INSERT [dbo].[dichvu] ([id_dichvu], [tendichvu], [giadichvu]) VALUES (4, N'CoCa-CoLa', CAST(10000 AS Decimal(18, 0)))
INSERT [dbo].[dichvu] ([id_dichvu], [tendichvu], [giadichvu]) VALUES (5, N'Dịch vụ bể bơi 4 mùa', CAST(2000000 AS Decimal(18, 0)))
INSERT [dbo].[dichvu] ([id_dichvu], [tendichvu], [giadichvu]) VALUES (6, N'Gym', CAST(300000 AS Decimal(18, 0)))
INSERT [dbo].[dichvu] ([id_dichvu], [tendichvu], [giadichvu]) VALUES (7, N'Dịch vụ giặt, ủi là', CAST(20000 AS Decimal(18, 0)))
INSERT [dbo].[dichvu] ([id_dichvu], [tendichvu], [giadichvu]) VALUES (8, N'Cơm tấm', CAST(30000 AS Decimal(18, 0)))
INSERT [dbo].[dichvu] ([id_dichvu], [tendichvu], [giadichvu]) VALUES (9, N'Bữa ăn phục vụ tại phòng', CAST(100000 AS Decimal(18, 0)))
INSERT [dbo].[dichvu] ([id_dichvu], [tendichvu], [giadichvu]) VALUES (10, N'Cơm gà', CAST(30000 AS Decimal(18, 0)))
INSERT [dbo].[dichvu] ([id_dichvu], [tendichvu], [giadichvu]) VALUES (11, N'Phở bò', CAST(5000 AS Decimal(18, 0)))
INSERT [dbo].[dichvu] ([id_dichvu], [tendichvu], [giadichvu]) VALUES (12, N'Cơm rang thập cẩm', CAST(30000 AS Decimal(18, 0)))
INSERT [dbo].[dichvu] ([id_dichvu], [tendichvu], [giadichvu]) VALUES (13, N'Mỳ xào', CAST(30000 AS Decimal(18, 0)))
INSERT [dbo].[dichvu] ([id_dichvu], [tendichvu], [giadichvu]) VALUES (14, N'Bánh đa cua', CAST(30000 AS Decimal(18, 0)))
INSERT [dbo].[dichvu] ([id_dichvu], [tendichvu], [giadichvu]) VALUES (15, N'Phở gà ta', CAST(30000 AS Decimal(18, 0)))
INSERT [dbo].[dichvu] ([id_dichvu], [tendichvu], [giadichvu]) VALUES (16, N'Sân Golf', CAST(5000000 AS Decimal(18, 0)))
INSERT [dbo].[dichvu] ([id_dichvu], [tendichvu], [giadichvu]) VALUES (17, N'Đưa đón tại Sân Bay', CAST(1000000 AS Decimal(18, 0)))
INSERT [dbo].[dichvu] ([id_dichvu], [tendichvu], [giadichvu]) VALUES (18, N'Quầy bar', CAST(2000000 AS Decimal(18, 0)))
INSERT [dbo].[dichvu] ([id_dichvu], [tendichvu], [giadichvu]) VALUES (19, N'Nhà hàng sang trọng', CAST(12000000 AS Decimal(18, 0)))
INSERT [dbo].[dichvu] ([id_dichvu], [tendichvu], [giadichvu]) VALUES (20, N'Dịch vụ phòng 24/24', CAST(1000000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[dichvu] OFF
GO
SET IDENTITY_INSERT [dbo].[loaiphong] ON 

INSERT [dbo].[loaiphong] ([id_loaiphong], [tenloaiphong], [giaphongmotngay], [mota]) VALUES (1, N'1 Người', CAST(500000 AS Decimal(18, 0)), N'Loại phòng 1 giường đầy đủ các tiện nghi như điều hoà, tủ lạnh, bếp, nhà tắm, vệ sinh, ...')
INSERT [dbo].[loaiphong] ([id_loaiphong], [tenloaiphong], [giaphongmotngay], [mota]) VALUES (2, N'2 Người', CAST(1000000 AS Decimal(18, 0)), N'Loại phòng 1 giường đầy đủ các tiện nghi  view biển, ...')
INSERT [dbo].[loaiphong] ([id_loaiphong], [tenloaiphong], [giaphongmotngay], [mota]) VALUES (3, N'Gia đình', CAST(5000000 AS Decimal(18, 0)), N'Bao gồm 2 đầy đủ cho 4 người hoặc hơn chút')
INSERT [dbo].[loaiphong] ([id_loaiphong], [tenloaiphong], [giaphongmotngay], [mota]) VALUES (4, N'Phòng Cao Cấp', CAST(10000000 AS Decimal(18, 0)), N'Bao gồm: phòng khách, phòng ngủ, phòng tắm lớn, tiện nghi bổ sung như máy pha cà phê, ban công hoặc view đẹp, phục vụ cho những trải nghiệm sang trọng và thoải mái')
SET IDENTITY_INSERT [dbo].[loaiphong] OFF
GO
SET IDENTITY_INSERT [dbo].[phong] ON 

INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (1, N'Room 100', 1, N'Trống')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (2, N'Room 101', 1, N'Trống')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (3, N'Room 102', 1, N'Trống')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (4, N'Room 103', 1, N'Đang thuê')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (5, N'Room 104', 1, N'Trống')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (6, N'Room 105', 2, N'Trống')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (7, N'Room 106', 2, N'Trống')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (8, N'Room 107', 2, N'Đang thuê')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (9, N'Room 108', 2, N'Đang thuê')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (10, N'Room 109', 2, N'Trống')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (11, N'Room 110', 3, N'Trống')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (12, N'Room 111', 3, N'Đang thuê')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (13, N'Room 112', 3, N'Trống')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (14, N'Room 113', 3, N'Đang thuê')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (15, N'Room 114', 3, N'Trống')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (16, N'Room 115', 4, N'Đang thuê')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (17, N'Room 116', 4, N'Đang thuê')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (18, N'Room 117', 4, N'Trống')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (19, N'Room 118', 4, N'Trống')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (20, N'Room 119 ', 4, N'Đang thuê')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (21, N'Room 120', 4, N'Trống')
SET IDENTITY_INSERT [dbo].[phong] OFF
GO
SET IDENTITY_INSERT [dbo].[staff] ON 

INSERT [dbo].[staff] ([id_staff], [taikhoan], [hoten], [ngaysinh], [gioitinh], [matkhau], [role]) VALUES (1, N'nhanvien1', N'Trần Văn Chiến', CAST(N'2003-02-24' AS Date), N'Nam', N'nhanvien1', N'staff')
INSERT [dbo].[staff] ([id_staff], [taikhoan], [hoten], [ngaysinh], [gioitinh], [matkhau], [role]) VALUES (2, N'admin', N'Võ Quốc Việt', CAST(N'2003-03-04' AS Date), N'Nam', N'admin', N'admin')
INSERT [dbo].[staff] ([id_staff], [taikhoan], [hoten], [ngaysinh], [gioitinh], [matkhau], [role]) VALUES (3, N'nhanvien2', N'Lưu Quang Hùng', CAST(N'2003-06-07' AS Date), N'Nam', N'nhanvien2', N'staff')
INSERT [dbo].[staff] ([id_staff], [taikhoan], [hoten], [ngaysinh], [gioitinh], [matkhau], [role]) VALUES (4, N'nhanvien3', N'Nguyễn Đăng Khánh', CAST(N'2003-02-24' AS Date), N'Nam', N'nhanvien3', N'staff')
INSERT [dbo].[staff] ([id_staff], [taikhoan], [hoten], [ngaysinh], [gioitinh], [matkhau], [role]) VALUES (5, N'nhanvien4', N'Trần Tuấn Anh', CAST(N'2003-02-24' AS Date), N'Nam', N'nhanvien4', N'staff')
SET IDENTITY_INSERT [dbo].[staff] OFF
GO
ALTER TABLE [dbo].[ct_dichvu]  WITH CHECK ADD  CONSTRAINT [FK_ct_dichvu_dichvu] FOREIGN KEY([id_dichvu])
REFERENCES [dbo].[dichvu] ([id_dichvu])
GO
ALTER TABLE [dbo].[ct_dichvu] CHECK CONSTRAINT [FK_ct_dichvu_dichvu]
GO
ALTER TABLE [dbo].[cthoadon]  WITH CHECK ADD  CONSTRAINT [FK_cthoadon_dichvu] FOREIGN KEY([id_dichvu])
REFERENCES [dbo].[dichvu] ([id_dichvu])
GO
ALTER TABLE [dbo].[cthoadon] CHECK CONSTRAINT [FK_cthoadon_dichvu]
GO
ALTER TABLE [dbo].[cthoadon]  WITH CHECK ADD  CONSTRAINT [FK_cthoadon_hoadon] FOREIGN KEY([id_hoadon])
REFERENCES [dbo].[hoadon] ([id_hoadon])
GO
ALTER TABLE [dbo].[cthoadon] CHECK CONSTRAINT [FK_cthoadon_hoadon]
GO
ALTER TABLE [dbo].[hoadon]  WITH CHECK ADD  CONSTRAINT [FK_hoadon_customer] FOREIGN KEY([id_customer])
REFERENCES [dbo].[customer] ([id_customer])
GO
ALTER TABLE [dbo].[hoadon] CHECK CONSTRAINT [FK_hoadon_customer]
GO
ALTER TABLE [dbo].[hoadon]  WITH CHECK ADD  CONSTRAINT [FK_hoadon_room] FOREIGN KEY([id_room])
REFERENCES [dbo].[phong] ([id_room])
GO
ALTER TABLE [dbo].[hoadon] CHECK CONSTRAINT [FK_hoadon_room]
GO
ALTER TABLE [dbo].[hoadon]  WITH CHECK ADD  CONSTRAINT [FK_hoadon_staff] FOREIGN KEY([id_staff])
REFERENCES [dbo].[staff] ([id_staff])
GO
ALTER TABLE [dbo].[hoadon] CHECK CONSTRAINT [FK_hoadon_staff]
GO
ALTER TABLE [dbo].[phong]  WITH CHECK ADD  CONSTRAINT [FK_phong_loaiphong] FOREIGN KEY([id_loaiphong])
REFERENCES [dbo].[loaiphong] ([id_loaiphong])
GO
ALTER TABLE [dbo].[phong] CHECK CONSTRAINT [FK_phong_loaiphong]
GO
