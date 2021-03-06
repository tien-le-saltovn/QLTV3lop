USE [QLTV]
GO
/****** Object:  Table [dbo].[CTPHIEUMUON]    Script Date: 02/12/2015 12:07:44 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPHIEUMUON](
	[mactphieumuon] [int] IDENTITY(1,1) NOT NULL,
	[maphieumuon] [int] NOT NULL,
	[macuonsach] [int] NOT NULL,
	[tencuonsach] [nvarchar](200) NOT NULL,
	[madausach] [int] NOT NULL,
	[ngaytra] [date] NOT NULL,
 CONSTRAINT [PK_CTPHIEUMUON] PRIMARY KEY CLUSTERED 
(
	[mactphieumuon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CTPHIEUTRA]    Script Date: 02/12/2015 12:07:45 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPHIEUTRA](
	[mactphieutra] [int] IDENTITY(1,1) NOT NULL,
	[maphieutra] [int] NOT NULL,
	[macuonsach] [int] NOT NULL,
	[tencuonsach] [nvarchar](200) NOT NULL,
	[matheloai] [int] NOT NULL,
	[ngayquahan] [int] NOT NULL,
 CONSTRAINT [PK_CTPHIEUTRA] PRIMARY KEY CLUSTERED 
(
	[mactphieutra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CUONSACH]    Script Date: 02/12/2015 12:07:45 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CUONSACH](
	[macuonsach] [int] IDENTITY(1,1) NOT NULL,
	[madausach] [int] NOT NULL,
	[tinhtrang] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_CUONSACH] PRIMARY KEY CLUSTERED 
(
	[macuonsach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DAUSACH]    Script Date: 02/12/2015 12:07:45 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DAUSACH](
	[madausach] [int] IDENTITY(1,1) NOT NULL,
	[matheloai] [int] NOT NULL,
	[tendausach] [nvarchar](50) NOT NULL,
	[soluong] [int] NOT NULL,
	[manxb] [int] NOT NULL,
	[tomtat] [nvarchar](200) NOT NULL,
	[lantaiban] [int] NOT NULL,
	[matacgia] [int] NOT NULL,
	[tinhtrang] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_DAUSACH] PRIMARY KEY CLUSTERED 
(
	[madausach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DOCGIA]    Script Date: 02/12/2015 12:07:45 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DOCGIA](
	[madocgia] [int] IDENTITY(1,1) NOT NULL,
	[hoten] [nvarchar](50) NOT NULL,
	[diachi] [nvarchar](200) NOT NULL,
	[gioitinh] [nvarchar](3) NOT NULL,
	[sdt] [nvarchar](50) NULL,
	[nghenghiep] [nvarchar](20) NOT NULL,
	[email] [varchar](50) NULL,
	[namtotnghiep] [varchar](50) NOT NULL,
	[ngaycapthe] [datetime] NOT NULL,
	[ngayhethan] [datetime] NOT NULL,
	[tinhtrang] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_DOCGIA] PRIMARY KEY CLUSTERED 
(
	[madocgia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NXB]    Script Date: 02/12/2015 12:07:45 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NXB](
	[manxb] [int] IDENTITY(1,1) NOT NULL,
	[tennxb] [nvarchar](50) NOT NULL,
	[sdt] [char](11) NOT NULL,
	[diachi] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_NXB] PRIMARY KEY CLUSTERED 
(
	[manxb] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUMUON]    Script Date: 02/12/2015 12:07:45 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUMUON](
	[maphieumuon] [int] IDENTITY(1,1) NOT NULL,
	[madocgia] [int] NOT NULL,
	[ngaylapphieu] [date] NOT NULL,
	[tinhtrang] [nvarchar](50) NOT NULL,
	[sosachmuon] [int] NOT NULL,
 CONSTRAINT [PK_PHIEUMUON_1] PRIMARY KEY CLUSTERED 
(
	[maphieumuon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUTRA]    Script Date: 02/12/2015 12:07:45 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUTRA](
	[maphieutra] [int] IDENTITY(1,1) NOT NULL,
	[maphieumuon] [int] NOT NULL,
	[madocgia] [int] NOT NULL,
	[ngaylapphieu] [date] NOT NULL,
	[sosachtra] [int] NOT NULL,
	[sosachconlai] [int] NOT NULL,
	[sosachmuon] [int] NOT NULL,
	[tinhtrang] [nvarchar](50) NULL,
 CONSTRAINT [PK_PHIEUTRA] PRIMARY KEY CLUSTERED 
(
	[maphieutra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TACGIA]    Script Date: 02/12/2015 12:07:45 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TACGIA](
	[matacgia] [int] IDENTITY(1,1) NOT NULL,
	[hoten] [nvarchar](50) NOT NULL,
	[noicongtac] [nvarchar](200) NULL,
 CONSTRAINT [PK_TACGIA] PRIMARY KEY CLUSTERED 
(
	[matacgia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[THELOAI]    Script Date: 02/12/2015 12:07:45 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THELOAI](
	[matheloai] [int] IDENTITY(1,1) NOT NULL,
	[tentheloai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_THELOAI] PRIMARY KEY CLUSTERED 
(
	[matheloai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[CTPHIEUMUON] ON 

INSERT [dbo].[CTPHIEUMUON] ([mactphieumuon], [maphieumuon], [macuonsach], [tencuonsach], [madausach], [ngaytra]) VALUES (1, 1, 1, N'Dạy con làm giàu - tập 1', 1, CAST(0x763A0B00 AS Date))
INSERT [dbo].[CTPHIEUMUON] ([mactphieumuon], [maphieumuon], [macuonsach], [tencuonsach], [madausach], [ngaytra]) VALUES (2, 2, 1, N'Dạy con làm giàu - tập 1', 1, CAST(0x773A0B00 AS Date))
INSERT [dbo].[CTPHIEUMUON] ([mactphieumuon], [maphieumuon], [macuonsach], [tencuonsach], [madausach], [ngaytra]) VALUES (3, 2, 2, N'Dạy con làm giàu - tập 2', 1, CAST(0x773A0B00 AS Date))
INSERT [dbo].[CTPHIEUMUON] ([mactphieumuon], [maphieumuon], [macuonsach], [tencuonsach], [madausach], [ngaytra]) VALUES (4, 4, 4, N'Hoa Linh Lan', 2, CAST(0x7A3A0B00 AS Date))
INSERT [dbo].[CTPHIEUMUON] ([mactphieumuon], [maphieumuon], [macuonsach], [tencuonsach], [madausach], [ngaytra]) VALUES (5, 4, 3, N'Dạy con làm giàu - tập 3', 1, CAST(0x7A3A0B00 AS Date))
SET IDENTITY_INSERT [dbo].[CTPHIEUMUON] OFF
SET IDENTITY_INSERT [dbo].[CTPHIEUTRA] ON 

INSERT [dbo].[CTPHIEUTRA] ([mactphieutra], [maphieutra], [macuonsach], [tencuonsach], [matheloai], [ngayquahan]) VALUES (1, 2, 1, N'Dạy con làm giàu - tập 1', 1, 0)
INSERT [dbo].[CTPHIEUTRA] ([mactphieutra], [maphieutra], [macuonsach], [tencuonsach], [matheloai], [ngayquahan]) VALUES (2, 2, 2, N'Dạy con làm giàu - tập 2', 1, 0)
INSERT [dbo].[CTPHIEUTRA] ([mactphieutra], [maphieutra], [macuonsach], [tencuonsach], [matheloai], [ngayquahan]) VALUES (3, 1, 1, N'Dạy con làm giàu - tập 1', 1, 0)
INSERT [dbo].[CTPHIEUTRA] ([mactphieutra], [maphieutra], [macuonsach], [tencuonsach], [matheloai], [ngayquahan]) VALUES (4, 4, 4, N'Hoa Linh Lan', 2, 0)
INSERT [dbo].[CTPHIEUTRA] ([mactphieutra], [maphieutra], [macuonsach], [tencuonsach], [matheloai], [ngayquahan]) VALUES (5, 4, 3, N'Dạy con làm giàu - tập 3', 1, 0)
SET IDENTITY_INSERT [dbo].[CTPHIEUTRA] OFF
SET IDENTITY_INSERT [dbo].[CUONSACH] ON 

INSERT [dbo].[CUONSACH] ([macuonsach], [madausach], [tinhtrang]) VALUES (1, 1, N'8')
INSERT [dbo].[CUONSACH] ([macuonsach], [madausach], [tinhtrang]) VALUES (2, 1, N'8')
INSERT [dbo].[CUONSACH] ([macuonsach], [madausach], [tinhtrang]) VALUES (4, 1, N'9')
INSERT [dbo].[CUONSACH] ([macuonsach], [madausach], [tinhtrang]) VALUES (5, 4, N'9')
INSERT [dbo].[CUONSACH] ([macuonsach], [madausach], [tinhtrang]) VALUES (6, 5, N'8')
SET IDENTITY_INSERT [dbo].[CUONSACH] OFF
SET IDENTITY_INSERT [dbo].[DAUSACH] ON 

INSERT [dbo].[DAUSACH] ([madausach], [matheloai], [tendausach], [soluong], [manxb], [tomtat], [lantaiban], [matacgia], [tinhtrang]) VALUES (1, 1, N'Dạy con làm giàu - tập 1', 10, 1, N'Dạy con làm giàu là 1 trong những cuốn sách bán chạy nhất thế giới trong 10 năm qua...', 0, 3, N'5')
INSERT [dbo].[DAUSACH] ([madausach], [matheloai], [tendausach], [soluong], [manxb], [tomtat], [lantaiban], [matacgia], [tinhtrang]) VALUES (3, 1, N'Dạy con làm giàu - tập 2', 10, 1, N'Dạy con làm giàu là 1 trong những cuốn sách bán chạy nhất thế giới trong 10 năm qua...', 0, 3, N'5')
INSERT [dbo].[DAUSACH] ([madausach], [matheloai], [tendausach], [soluong], [manxb], [tomtat], [lantaiban], [matacgia], [tinhtrang]) VALUES (4, 1, N'Dạy con làm giàu - tập 3', 10, 1, N'Dạy con làm giàu là 1 trong những cuốn sách bán chạy nhất thế giới trong 10 năm qua...', 0, 3, N'5')
INSERT [dbo].[DAUSACH] ([madausach], [matheloai], [tendausach], [soluong], [manxb], [tomtat], [lantaiban], [matacgia], [tinhtrang]) VALUES (5, 3, N'Hoa Linh Lan', 10, 2, N'1 trong những cuốn sách viết hay nhất về tình yêu đôi lứa...', 0, 4, N'5')
INSERT [dbo].[DAUSACH] ([madausach], [matheloai], [tendausach], [soluong], [manxb], [tomtat], [lantaiban], [matacgia], [tinhtrang]) VALUES (6, 3, N'Mọi chuyện rồi sẽ ổn thôi', 10, 2, N'Mọi chuyện sẽ qua 1 cách nhẹ nhàng khi ta thưởng thức cuốn sách này', 0, 4, N'5')
SET IDENTITY_INSERT [dbo].[DAUSACH] OFF
SET IDENTITY_INSERT [dbo].[DOCGIA] ON 

INSERT [dbo].[DOCGIA] ([madocgia], [hoten], [diachi], [gioitinh], [sdt], [nghenghiep], [email], [namtotnghiep], [ngaycapthe], [ngayhethan], [tinhtrang]) VALUES (1, N'Lê Ngọc Sơn a', N'Tp Hồ Chí Minh', N'Nữ', N'01652171104', N'Sinh viên', N'leenoson@gmail.com', N'2017', CAST(0x0000A41300000000 AS DateTime), CAST(0x0000A58D00000000 AS DateTime), N'6')
INSERT [dbo].[DOCGIA] ([madocgia], [hoten], [diachi], [gioitinh], [sdt], [nghenghiep], [email], [namtotnghiep], [ngaycapthe], [ngayhethan], [tinhtrang]) VALUES (2, N'Lê Duy Tiến', N'Tp Hồ Chí Minh', N'Nam', N'0123675890 ', N'Sinh viên', N'leduytien@gmail.com', N'2017', CAST(0x0000A41400000000 AS DateTime), CAST(0x0000A58100000000 AS DateTime), N'6')
INSERT [dbo].[DOCGIA] ([madocgia], [hoten], [diachi], [gioitinh], [sdt], [nghenghiep], [email], [namtotnghiep], [ngaycapthe], [ngayhethan], [tinhtrang]) VALUES (3, N'Bùi Đức Thảo', N'Tp Hồ Chí Minh', N'Nam', N'0126089765 ', N'Sinh viên', N'buiducthao@gmail.com', N'2017', CAST(0x0000A41500000000 AS DateTime), CAST(0x0000A58200000000 AS DateTime), N'6')
INSERT [dbo].[DOCGIA] ([madocgia], [hoten], [diachi], [gioitinh], [sdt], [nghenghiep], [email], [namtotnghiep], [ngaycapthe], [ngayhethan], [tinhtrang]) VALUES (4, N'Lý Tiểu Mai', N'Tp Hồ Chí Minh', N'Nữ', N'0188978675 ', N'Sinh viên', N'boolunvodoi@gmail.com', N'2017', CAST(0x0000A41600000000 AS DateTime), CAST(0x0000A58300000000 AS DateTime), N'6')
INSERT [dbo].[DOCGIA] ([madocgia], [hoten], [diachi], [gioitinh], [sdt], [nghenghiep], [email], [namtotnghiep], [ngaycapthe], [ngayhethan], [tinhtrang]) VALUES (6, N'a', N'b', N'Nam', N'1          ', N'sv', N'ssssss@', N'12', CAST(0x0000A42000000000 AS DateTime), CAST(0x0000A59400000000 AS DateTime), N'2')
INSERT [dbo].[DOCGIA] ([madocgia], [hoten], [diachi], [gioitinh], [sdt], [nghenghiep], [email], [namtotnghiep], [ngaycapthe], [ngayhethan], [tinhtrang]) VALUES (7, N'tao', N'củ chi', N'Nam', N'123        ', N'sinh viên', N'lee@d.com', N'2017', CAST(0x0000A55800000000 AS DateTime), CAST(0x0000A56400000000 AS DateTime), N'1')
INSERT [dbo].[DOCGIA] ([madocgia], [hoten], [diachi], [gioitinh], [sdt], [nghenghiep], [email], [namtotnghiep], [ngaycapthe], [ngayhethan], [tinhtrang]) VALUES (8, N'a', N'a', N'Nam', N'1          ', N'Sinh viên', N'a', N'3', CAST(0x0000A55800000000 AS DateTime), CAST(0x0000A55800000000 AS DateTime), N'2')
INSERT [dbo].[DOCGIA] ([madocgia], [hoten], [diachi], [gioitinh], [sdt], [nghenghiep], [email], [namtotnghiep], [ngaycapthe], [ngayhethan], [tinhtrang]) VALUES (9, N'a', N'a', N'Nam', N'1          ', N'Giáo viên', N'a', N'3', CAST(0x0000A55800000000 AS DateTime), CAST(0x0000A55800000000 AS DateTime), N'2')
SET IDENTITY_INSERT [dbo].[DOCGIA] OFF
SET IDENTITY_INSERT [dbo].[NXB] ON 

INSERT [dbo].[NXB] ([manxb], [tennxb], [sdt], [diachi]) VALUES (2, N'Kim Đồng', N'0837951122 ', N'Tp Hồ Chí Minh')
INSERT [dbo].[NXB] ([manxb], [tennxb], [sdt], [diachi]) VALUES (7, N'Bách Việt', N'0837955676 ', N'Tp Hồ Chí Minh')
INSERT [dbo].[NXB] ([manxb], [tennxb], [sdt], [diachi]) VALUES (9, N'Trẻ', N'0837687463 ', N'Tp Hồ Chí Minh')
INSERT [dbo].[NXB] ([manxb], [tennxb], [sdt], [diachi]) VALUES (10, N'Phương Nam', N'0876545756 ', N'Tp Hồ Chí Minh')
INSERT [dbo].[NXB] ([manxb], [tennxb], [sdt], [diachi]) VALUES (11, N'Thái Hà a', N'0837864362 ', N'Tp Hồ Chí Minh')
SET IDENTITY_INSERT [dbo].[NXB] OFF
SET IDENTITY_INSERT [dbo].[PHIEUMUON] ON 

INSERT [dbo].[PHIEUMUON] ([maphieumuon], [madocgia], [ngaylapphieu], [tinhtrang], [sosachmuon]) VALUES (1, 1, CAST(0x753A0B00 AS Date), N'2', 1)
INSERT [dbo].[PHIEUMUON] ([maphieumuon], [madocgia], [ngaylapphieu], [tinhtrang], [sosachmuon]) VALUES (2, 2, CAST(0x763A0B00 AS Date), N'2', 2)
INSERT [dbo].[PHIEUMUON] ([maphieumuon], [madocgia], [ngaylapphieu], [tinhtrang], [sosachmuon]) VALUES (3, 2, CAST(0x783A0B00 AS Date), N'2', 3)
INSERT [dbo].[PHIEUMUON] ([maphieumuon], [madocgia], [ngaylapphieu], [tinhtrang], [sosachmuon]) VALUES (4, 3, CAST(0x793A0B00 AS Date), N'2', 2)
INSERT [dbo].[PHIEUMUON] ([maphieumuon], [madocgia], [ngaylapphieu], [tinhtrang], [sosachmuon]) VALUES (5, 4, CAST(0x7B3A0B00 AS Date), N'2', 1)
SET IDENTITY_INSERT [dbo].[PHIEUMUON] OFF
SET IDENTITY_INSERT [dbo].[PHIEUTRA] ON 

INSERT [dbo].[PHIEUTRA] ([maphieutra], [maphieumuon], [madocgia], [ngaylapphieu], [sosachtra], [sosachconlai], [sosachmuon], [tinhtrang]) VALUES (1, 1, 1, CAST(0x763A0B00 AS Date), 1, 0, 1, NULL)
INSERT [dbo].[PHIEUTRA] ([maphieutra], [maphieumuon], [madocgia], [ngaylapphieu], [sosachtra], [sosachconlai], [sosachmuon], [tinhtrang]) VALUES (2, 2, 2, CAST(0x773A0B00 AS Date), 2, 0, 2, NULL)
INSERT [dbo].[PHIEUTRA] ([maphieutra], [maphieumuon], [madocgia], [ngaylapphieu], [sosachtra], [sosachconlai], [sosachmuon], [tinhtrang]) VALUES (3, 3, 2, CAST(0x793A0B00 AS Date), 3, 0, 3, NULL)
INSERT [dbo].[PHIEUTRA] ([maphieutra], [maphieumuon], [madocgia], [ngaylapphieu], [sosachtra], [sosachconlai], [sosachmuon], [tinhtrang]) VALUES (4, 4, 3, CAST(0x7A3A0B00 AS Date), 2, 0, 2, NULL)
INSERT [dbo].[PHIEUTRA] ([maphieutra], [maphieumuon], [madocgia], [ngaylapphieu], [sosachtra], [sosachconlai], [sosachmuon], [tinhtrang]) VALUES (5, 5, 4, CAST(0x7B3A0B00 AS Date), 1, 0, 1, NULL)
SET IDENTITY_INSERT [dbo].[PHIEUTRA] OFF
SET IDENTITY_INSERT [dbo].[TACGIA] ON 

INSERT [dbo].[TACGIA] ([matacgia], [hoten], [noicongtac]) VALUES (1, N'Nguyễn Nhật Ánh', NULL)
INSERT [dbo].[TACGIA] ([matacgia], [hoten], [noicongtac]) VALUES (2, N'Phong Thiên', NULL)
INSERT [dbo].[TACGIA] ([matacgia], [hoten], [noicongtac]) VALUES (3, N'
Robert Kiyosaki', NULL)
INSERT [dbo].[TACGIA] ([matacgia], [hoten], [noicongtac]) VALUES (4, N'Vũ Phương Thanh', NULL)
INSERT [dbo].[TACGIA] ([matacgia], [hoten], [noicongtac]) VALUES (5, N'Minh Nhật', NULL)
SET IDENTITY_INSERT [dbo].[TACGIA] OFF
SET IDENTITY_INSERT [dbo].[THELOAI] ON 

INSERT [dbo].[THELOAI] ([matheloai], [tentheloai]) VALUES (1, N'Kinh tế')
INSERT [dbo].[THELOAI] ([matheloai], [tentheloai]) VALUES (2, N'Văn học - Tiểu thuyết')
INSERT [dbo].[THELOAI] ([matheloai], [tentheloai]) VALUES (3, N'Kỹ năng sống')
INSERT [dbo].[THELOAI] ([matheloai], [tentheloai]) VALUES (4, N'Nuôi dạy con')
INSERT [dbo].[THELOAI] ([matheloai], [tentheloai]) VALUES (5, N'Khoa học')
INSERT [dbo].[THELOAI] ([matheloai], [tentheloai]) VALUES (12, N'sơn a a b')
SET IDENTITY_INSERT [dbo].[THELOAI] OFF
ALTER TABLE [dbo].[CTPHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_CTPHIEUMUON_PHIEUMUON] FOREIGN KEY([maphieumuon])
REFERENCES [dbo].[PHIEUMUON] ([maphieumuon])
GO
ALTER TABLE [dbo].[CTPHIEUMUON] CHECK CONSTRAINT [FK_CTPHIEUMUON_PHIEUMUON]
GO
ALTER TABLE [dbo].[PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUMUON_DOCGIA] FOREIGN KEY([madocgia])
REFERENCES [dbo].[DOCGIA] ([madocgia])
GO
ALTER TABLE [dbo].[PHIEUMUON] CHECK CONSTRAINT [FK_PHIEUMUON_DOCGIA]
GO
ALTER TABLE [dbo].[PHIEUTRA]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTRA_PHIEUMUON] FOREIGN KEY([maphieumuon])
REFERENCES [dbo].[PHIEUMUON] ([maphieumuon])
GO
ALTER TABLE [dbo].[PHIEUTRA] CHECK CONSTRAINT [FK_PHIEUTRA_PHIEUMUON]
GO
ALTER TABLE [dbo].[PHIEUTRA]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTRA_PHIEUMUON1] FOREIGN KEY([maphieumuon])
REFERENCES [dbo].[PHIEUMUON] ([maphieumuon])
GO
ALTER TABLE [dbo].[PHIEUTRA] CHECK CONSTRAINT [FK_PHIEUTRA_PHIEUMUON1]
GO
