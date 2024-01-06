USE [BTTH2_LTTQ]
GO
/****** Object:  Table [dbo].[nv]    Script Date: 01/12/2023 15:26:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nv](
	[maphongvien] [nvarchar](50) NOT NULL,
	[hoten] [nvarchar](50) NULL,
	[gioitinh] [bit] NULL,
	[sodienthoai] [varchar](50) NULL,
	[ngayvaolam] [datetime] NULL,
	[phucap] [float] NULL,
	[sogiolamthem] [int] NULL,
 CONSTRAINT [PK_nvbanhang] PRIMARY KEY CLUSTERED 
(
	[maphongvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[thucung]    Script Date: 01/12/2023 15:26:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[thucung](
	[madon] [nvarchar](50) NOT NULL,
	[tenthucung] [nvarchar](50) NULL,
	[chungloai] [nvarchar](50) NULL,
	[cannang] [int] NULL,
	[ngaynhan] [date] NULL,
	[tinhtrang] [nvarchar](50) NULL,
	[chiphithuocdieutri] [float] NULL,
	[songay] [int] NULL,
 CONSTRAINT [PK_thucung] PRIMARY KEY CLUSTERED 
(
	[madon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[nv] ([maphongvien], [hoten], [gioitinh], [sodienthoai], [ngayvaolam], [phucap], [sogiolamthem]) VALUES (N'cc', N'vv', 1, N'0369787811', CAST(N'2023-11-24T10:32:00.000' AS DateTime), NULL, 1200)
INSERT [dbo].[nv] ([maphongvien], [hoten], [gioitinh], [sodienthoai], [ngayvaolam], [phucap], [sogiolamthem]) VALUES (N'gg', N'hh', 1, N'0369787811', CAST(N'2023-11-24T10:32:00.000' AS DateTime), NULL, 3432)
INSERT [dbo].[nv] ([maphongvien], [hoten], [gioitinh], [sodienthoai], [ngayvaolam], [phucap], [sogiolamthem]) VALUES (N'hh', N'bb', 1, N'0369787811', CAST(N'2023-11-24T10:32:00.000' AS DateTime), NULL, 500000)
INSERT [dbo].[nv] ([maphongvien], [hoten], [gioitinh], [sodienthoai], [ngayvaolam], [phucap], [sogiolamthem]) VALUES (N'll', N'gg', 1, N'0369787811', CAST(N'2023-11-24T10:32:00.000' AS DateTime), 55000, NULL)
INSERT [dbo].[nv] ([maphongvien], [hoten], [gioitinh], [sodienthoai], [ngayvaolam], [phucap], [sogiolamthem]) VALUES (N'xx', N'xx', 1, N'0369787811', CAST(N'2023-11-24T10:32:00.000' AS DateTime), NULL, 555555)
GO
INSERT [dbo].[thucung] ([madon], [tenthucung], [chungloai], [cannang], [ngaynhan], [tinhtrang], [chiphithuocdieutri], [songay]) VALUES (N'md1', N'Bug', N'chó', 3, CAST(N'2023-12-01' AS Date), N'sốt', 50000, NULL)
INSERT [dbo].[thucung] ([madon], [tenthucung], [chungloai], [cannang], [ngaynhan], [tinhtrang], [chiphithuocdieutri], [songay]) VALUES (N'md2', N'Hoi', N'mèo', 2, CAST(N'2023-11-30' AS Date), N'suy dinh dưỡng', NULL, 7)
INSERT [dbo].[thucung] ([madon], [tenthucung], [chungloai], [cannang], [ngaynhan], [tinhtrang], [chiphithuocdieutri], [songay]) VALUES (N'md3', N'Rad', N'chuột', 1, CAST(N'2023-11-30' AS Date), N'bệnh', 300000, NULL)
INSERT [dbo].[thucung] ([madon], [tenthucung], [chungloai], [cannang], [ngaynhan], [tinhtrang], [chiphithuocdieutri], [songay]) VALUES (N'md4', N'Mouse', N'heo', 30, CAST(N'2023-11-17' AS Date), N'béo phì', NULL, 5)
GO
