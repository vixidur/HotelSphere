CREATE DATABASE hotelhub
GO
USE [hotelhub]
GO
/****** Object:  Table [dbo].[ct_dichvu]    Script Date: 20/11/2024 4:36:03 PM ******/
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
/****** Object:  Table [dbo].[cthoadon]    Script Date: 20/11/2024 4:36:03 PM ******/
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
/****** Object:  Table [dbo].[customer]    Script Date: 20/11/2024 4:36:03 PM ******/
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
/****** Object:  Table [dbo].[dichvu]    Script Date: 20/11/2024 4:36:03 PM ******/
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
/****** Object:  Table [dbo].[hoadon]    Script Date: 20/11/2024 4:36:03 PM ******/
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
/****** Object:  Table [dbo].[loaiphong]    Script Date: 20/11/2024 4:36:03 PM ******/
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
/****** Object:  Table [dbo].[phong]    Script Date: 20/11/2024 4:36:03 PM ******/
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
/****** Object:  Table [dbo].[staff]    Script Date: 20/11/2024 4:36:03 PM ******/
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
SET IDENTITY_INSERT [dbo].[ct_dichvu] ON 

INSERT [dbo].[ct_dichvu] ([id], [id_dichvu], [tendichvu], [giatien], [soluong], [thanhtien]) VALUES (329, 5, N'Dịch vụ bể bơi 4 mùa', CAST(2000000 AS Decimal(18, 0)), 1, CAST(2000000 AS Decimal(18, 0)))
INSERT [dbo].[ct_dichvu] ([id], [id_dichvu], [tendichvu], [giatien], [soluong], [thanhtien]) VALUES (330, 8, N'Cơm tấm', CAST(30000 AS Decimal(18, 0)), 1, CAST(30000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[ct_dichvu] OFF
GO
SET IDENTITY_INSERT [dbo].[cthoadon] ON 

INSERT [dbo].[cthoadon] ([id_cthoadon], [id_hoadon], [id_dichvu], [dongia], [soluongsudungdichvu]) VALUES (43, 106, 14, CAST(30000 AS Decimal(18, 0)), 1)
INSERT [dbo].[cthoadon] ([id_cthoadon], [id_hoadon], [id_dichvu], [dongia], [soluongsudungdichvu]) VALUES (44, 106, 11, CAST(5000 AS Decimal(18, 0)), 1)
INSERT [dbo].[cthoadon] ([id_cthoadon], [id_hoadon], [id_dichvu], [dongia], [soluongsudungdichvu]) VALUES (45, 106, 16, CAST(5000000 AS Decimal(18, 0)), 1)
INSERT [dbo].[cthoadon] ([id_cthoadon], [id_hoadon], [id_dichvu], [dongia], [soluongsudungdichvu]) VALUES (49, 107, 18, CAST(2000000 AS Decimal(18, 0)), 1)
INSERT [dbo].[cthoadon] ([id_cthoadon], [id_hoadon], [id_dichvu], [dongia], [soluongsudungdichvu]) VALUES (50, 108, 18, CAST(2000000 AS Decimal(18, 0)), 1)
INSERT [dbo].[cthoadon] ([id_cthoadon], [id_hoadon], [id_dichvu], [dongia], [soluongsudungdichvu]) VALUES (51, 108, 3, CAST(10000 AS Decimal(18, 0)), 12)
INSERT [dbo].[cthoadon] ([id_cthoadon], [id_hoadon], [id_dichvu], [dongia], [soluongsudungdichvu]) VALUES (52, 109, 6, CAST(300000 AS Decimal(18, 0)), 1)
INSERT [dbo].[cthoadon] ([id_cthoadon], [id_hoadon], [id_dichvu], [dongia], [soluongsudungdichvu]) VALUES (53, 109, 9, CAST(100000 AS Decimal(18, 0)), 1)
INSERT [dbo].[cthoadon] ([id_cthoadon], [id_hoadon], [id_dichvu], [dongia], [soluongsudungdichvu]) VALUES (54, 109, 10, CAST(30000 AS Decimal(18, 0)), 12)
INSERT [dbo].[cthoadon] ([id_cthoadon], [id_hoadon], [id_dichvu], [dongia], [soluongsudungdichvu]) VALUES (58, 111, 8, CAST(30000 AS Decimal(18, 0)), 12)
INSERT [dbo].[cthoadon] ([id_cthoadon], [id_hoadon], [id_dichvu], [dongia], [soluongsudungdichvu]) VALUES (59, 111, 4, CAST(10000 AS Decimal(18, 0)), 9)
INSERT [dbo].[cthoadon] ([id_cthoadon], [id_hoadon], [id_dichvu], [dongia], [soluongsudungdichvu]) VALUES (60, 111, 7, CAST(20000 AS Decimal(18, 0)), 1)
INSERT [dbo].[cthoadon] ([id_cthoadon], [id_hoadon], [id_dichvu], [dongia], [soluongsudungdichvu]) VALUES (61, 112, 5, CAST(2000000 AS Decimal(18, 0)), 1)
INSERT [dbo].[cthoadon] ([id_cthoadon], [id_hoadon], [id_dichvu], [dongia], [soluongsudungdichvu]) VALUES (62, 113, 5, CAST(2000000 AS Decimal(18, 0)), 1)
INSERT [dbo].[cthoadon] ([id_cthoadon], [id_hoadon], [id_dichvu], [dongia], [soluongsudungdichvu]) VALUES (63, 113, 8, CAST(30000 AS Decimal(18, 0)), 1)
SET IDENTITY_INSERT [dbo].[cthoadon] OFF
GO
SET IDENTITY_INSERT [dbo].[customer] ON 

INSERT [dbo].[customer] ([id_customer], [tenkhachhang], [so_cmt], [quoctich], [gioitinh], [sdt]) VALUES (5, N'Võ Quốc Việt', N'0653946123', N'Việt Nam', N'Nam', N'0862587229')
INSERT [dbo].[customer] ([id_customer], [tenkhachhang], [so_cmt], [quoctich], [gioitinh], [sdt]) VALUES (7, N'Phạm Tuấn Vũ', N'0616548651', N'Việt Nam', N'Nam', N'0862587229')
INSERT [dbo].[customer] ([id_customer], [tenkhachhang], [so_cmt], [quoctich], [gioitinh], [sdt]) VALUES (9, N'To Hoang Vu', N'0142356759', N'Viet Nam', N'Nam', N'0862587229')
INSERT [dbo].[customer] ([id_customer], [tenkhachhang], [so_cmt], [quoctich], [gioitinh], [sdt]) VALUES (11, N'Phạm Thu Nguyên', N'010003659', N'Việt Nam', N'Nam', N'0862587229')
INSERT [dbo].[customer] ([id_customer], [tenkhachhang], [so_cmt], [quoctich], [gioitinh], [sdt]) VALUES (12, N'Trần Anh Kiên', N'0132648963', N'Việt Nam', N'Nam', N'0862587229')
INSERT [dbo].[customer] ([id_customer], [tenkhachhang], [so_cmt], [quoctich], [gioitinh], [sdt]) VALUES (14, N'Trần Phạm Anh', N'0123456789', N'United Kingdom', N'Nam', N'0315695648')
INSERT [dbo].[customer] ([id_customer], [tenkhachhang], [so_cmt], [quoctich], [gioitinh], [sdt]) VALUES (15, N'Lê Thiện Nguyên', N'03261594856', N'Việt Nam', N'Nam', N'0862587229')
INSERT [dbo].[customer] ([id_customer], [tenkhachhang], [so_cmt], [quoctich], [gioitinh], [sdt]) VALUES (24, N'Hoàng Văn Hùng', N'0121649953', N'Việt Nam', N'Nam', N'0862587229')
SET IDENTITY_INSERT [dbo].[customer] OFF
GO
SET IDENTITY_INSERT [dbo].[dichvu] ON 

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
INSERT [dbo].[dichvu] ([id_dichvu], [tendichvu], [giadichvu]) VALUES (13, N'Mỳ xào', CAST(30000 AS Decimal(18, 0)))
INSERT [dbo].[dichvu] ([id_dichvu], [tendichvu], [giadichvu]) VALUES (14, N'Bánh đa cua', CAST(30000 AS Decimal(18, 0)))
INSERT [dbo].[dichvu] ([id_dichvu], [tendichvu], [giadichvu]) VALUES (16, N'Sân Golf', CAST(5000000 AS Decimal(18, 0)))
INSERT [dbo].[dichvu] ([id_dichvu], [tendichvu], [giadichvu]) VALUES (17, N'Đưa đón tại Sân Bay', CAST(1000000 AS Decimal(18, 0)))
INSERT [dbo].[dichvu] ([id_dichvu], [tendichvu], [giadichvu]) VALUES (18, N'Quầy bar', CAST(2000000 AS Decimal(18, 0)))
INSERT [dbo].[dichvu] ([id_dichvu], [tendichvu], [giadichvu]) VALUES (19, N'Nhà hàng sang trọng', CAST(12000000 AS Decimal(18, 0)))
INSERT [dbo].[dichvu] ([id_dichvu], [tendichvu], [giadichvu]) VALUES (21, N'Dịch vụ 24/24', CAST(900000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[dichvu] OFF
GO
SET IDENTITY_INSERT [dbo].[hoadon] ON 

INSERT [dbo].[hoadon] ([id_hoadon], [id_customer], [id_staff], [giaphongmotngay], [id_room], [ngaythuephong], [ngaytraphong], [thanhtien]) VALUES (106, 5, 10, CAST(5000000 AS Decimal(18, 0)), 11, CAST(N'2024-09-17' AS Date), CAST(N'2024-11-18' AS Date), CAST(15065000 AS Decimal(18, 0)))
INSERT [dbo].[hoadon] ([id_hoadon], [id_customer], [id_staff], [giaphongmotngay], [id_room], [ngaythuephong], [ngaytraphong], [thanhtien]) VALUES (107, 14, 10, CAST(10000000 AS Decimal(18, 0)), 31, CAST(N'2024-11-10' AS Date), CAST(N'2024-11-18' AS Date), CAST(22060000 AS Decimal(18, 0)))
INSERT [dbo].[hoadon] ([id_hoadon], [id_customer], [id_staff], [giaphongmotngay], [id_room], [ngaythuephong], [ngaytraphong], [thanhtien]) VALUES (108, 24, 10, CAST(5000000 AS Decimal(18, 0)), 12, CAST(N'2024-10-16' AS Date), CAST(N'2024-11-18' AS Date), CAST(12120000 AS Decimal(18, 0)))
INSERT [dbo].[hoadon] ([id_hoadon], [id_customer], [id_staff], [giaphongmotngay], [id_room], [ngaythuephong], [ngaytraphong], [thanhtien]) VALUES (109, 7, 9, CAST(1000000 AS Decimal(18, 0)), 6, CAST(N'2024-09-19' AS Date), CAST(N'2024-11-24' AS Date), CAST(5760000 AS Decimal(18, 0)))
INSERT [dbo].[hoadon] ([id_hoadon], [id_customer], [id_staff], [giaphongmotngay], [id_room], [ngaythuephong], [ngaytraphong], [thanhtien]) VALUES (111, 24, 9, CAST(1000000 AS Decimal(18, 0)), 7, CAST(N'2024-10-19' AS Date), CAST(N'2024-11-20' AS Date), CAST(2470000 AS Decimal(18, 0)))
INSERT [dbo].[hoadon] ([id_hoadon], [id_customer], [id_staff], [giaphongmotngay], [id_room], [ngaythuephong], [ngaytraphong], [thanhtien]) VALUES (112, 24, 9, CAST(5000000 AS Decimal(18, 0)), 14, CAST(N'2024-08-19' AS Date), CAST(N'2024-11-20' AS Date), CAST(12000000 AS Decimal(18, 0)))
INSERT [dbo].[hoadon] ([id_hoadon], [id_customer], [id_staff], [giaphongmotngay], [id_room], [ngaythuephong], [ngaytraphong], [thanhtien]) VALUES (113, 15, 9, CAST(500000 AS Decimal(18, 0)), 2, CAST(N'2024-11-20' AS Date), CAST(N'2024-11-26' AS Date), CAST(5030000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[hoadon] OFF
GO
SET IDENTITY_INSERT [dbo].[loaiphong] ON 

INSERT [dbo].[loaiphong] ([id_loaiphong], [tenloaiphong], [giaphongmotngay], [mota]) VALUES (1, N'1 Người', CAST(500000 AS Decimal(18, 0)), N'Loại phòng 1 giường đầy đủ các tiện nghi như điều hoà, tủ lạnh, bếp, nhà tắm, vệ sinh, ...')
INSERT [dbo].[loaiphong] ([id_loaiphong], [tenloaiphong], [giaphongmotngay], [mota]) VALUES (2, N'2 Người', CAST(1000000 AS Decimal(18, 0)), N'Loại phòng 1 giường đầy đủ các tiện nghi  view biển, ...')
INSERT [dbo].[loaiphong] ([id_loaiphong], [tenloaiphong], [giaphongmotngay], [mota]) VALUES (3, N'Gia đình', CAST(5000000 AS Decimal(18, 0)), N'Bao gồm 2 đầy đủ cho 4 người hoặc hơn chút')
INSERT [dbo].[loaiphong] ([id_loaiphong], [tenloaiphong], [giaphongmotngay], [mota]) VALUES (4, N'Phòng Cao Cấp', CAST(10000000 AS Decimal(18, 0)), N'Bao gồm: phòng khách, phòng ngủ, phòng tắm lớn, tiện nghi bổ sung như máy pha cà phê, ban công hoặc view đẹp, phục vụ cho những trải nghiệm sang trọng và thoải mái')
INSERT [dbo].[loaiphong] ([id_loaiphong], [tenloaiphong], [giaphongmotngay], [mota]) VALUES (7, N'Phòng Đặc Biệt', CAST(899000 AS Decimal(18, 0)), N'Phòng Đặc Biệt')
INSERT [dbo].[loaiphong] ([id_loaiphong], [tenloaiphong], [giaphongmotngay], [mota]) VALUES (8, N'Phòng họp', CAST(1999000 AS Decimal(18, 0)), N'Phòng họp')
SET IDENTITY_INSERT [dbo].[loaiphong] OFF
GO
SET IDENTITY_INSERT [dbo].[phong] ON 

INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (2, N'Room 101', 1, N'Đang thuê')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (3, N'Room 102', 1, N'Trống')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (4, N'Room 103', 1, N'Trống')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (6, N'Room 105', 2, N'Đang thuê')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (7, N'Room 106', 2, N'Đang thuê')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (8, N'Room 107', 2, N'Trống')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (9, N'Room 108', 2, N'Trống')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (10, N'Room 109', 2, N'Trống')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (11, N'Room 110', 3, N'Đang thuê')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (12, N'Room 111', 3, N'Đang thuê')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (14, N'Room 113', 3, N'Đang thuê')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (15, N'Room 114', 3, N'Trống')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (16, N'Room 115', 4, N'Trống')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (17, N'Room 116', 4, N'Trống')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (18, N'Room 117', 4, N'Trống')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (19, N'Room 118', 4, N'Trống')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (20, N'Room 119 ', 4, N'Trống')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (21, N'Room 120', 4, N'Trống')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (22, N'Room 121', 1, N'Trống')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (23, N'Room 122', 1, N'Trống')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (24, N'Room 123', 1, N'Trống')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (25, N'Room 124 ', 2, N'Trống')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (26, N'Room 125', 2, N'Trống')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (27, N'Room 126', 2, N'Trống')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (28, N'Room 127', 3, N'Trống')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (29, N'Room 128', 3, N'Trống')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (30, N'Room 129', 3, N'Trống')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (31, N'Room 130', 4, N'Đang thuê')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (32, N'Room 131', 4, N'Trống')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (36, N'Room 402', 7, N'Trống')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (37, N'Room 401', 7, N'Trống')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (38, N'Room 403', 7, N'Trống')
INSERT [dbo].[phong] ([id_room], [tenphong], [id_loaiphong], [tinhtrang]) VALUES (39, N'Room 404', 7, N'Đang thuê')
SET IDENTITY_INSERT [dbo].[phong] OFF
GO
SET IDENTITY_INSERT [dbo].[staff] ON 

INSERT [dbo].[staff] ([id_staff], [taikhoan], [hoten], [ngaysinh], [gioitinh], [matkhau], [role]) VALUES (2, N'admin', N'Trần Văn Chiến', CAST(N'2003-03-04' AS Date), N'Nam', N'admin', N'admin')
INSERT [dbo].[staff] ([id_staff], [taikhoan], [hoten], [ngaysinh], [gioitinh], [matkhau], [role]) VALUES (7, N'nhanvien5', N'Quỳnh Nga', CAST(N'2024-11-10' AS Date), N'Nữ', N'vanchien2402$$', N'staff')
INSERT [dbo].[staff] ([id_staff], [taikhoan], [hoten], [ngaysinh], [gioitinh], [matkhau], [role]) VALUES (8, N'nhanvien1', N'Võ Quốc Việt', CAST(N'2003-02-24' AS Date), N'Nam', N'vanchien2402$$', N'staff')
INSERT [dbo].[staff] ([id_staff], [taikhoan], [hoten], [ngaysinh], [gioitinh], [matkhau], [role]) VALUES (9, N'nhanvien4', N'Trần Tuấn Anh', CAST(N'2024-11-10' AS Date), N'Nam', N'vanchien2402$$', N'staff')
INSERT [dbo].[staff] ([id_staff], [taikhoan], [hoten], [ngaysinh], [gioitinh], [matkhau], [role]) VALUES (10, N'nhanvien2', N'Phạm Thu Nguyên', CAST(N'2003-02-24' AS Date), N'Nữ', N'vanchien2402$$', N'staff')
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
