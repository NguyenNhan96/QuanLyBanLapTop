﻿USE [Quanlybanhanglaptop]
GO
/****** Object:  Table [dbo].[LAPTOP]    Script Date: 17/11/2017 23:43:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LAPTOP](
	[MASP] [nchar](10) NOT NULL,
	[TENSP] [nvarchar](30) NULL,
	[TENHANGSX] [nchar](10) NULL,
	[GIA] [int] NULL,
	[MOTA] [nchar](10) NULL,
	[SOLUONG] [int] NULL,
	[TINHTRANG] [nvarchar](50) NULL,
 CONSTRAINT [PK_LAPTOP] PRIMARY KEY CLUSTERED 
(
	[MASP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 17/11/2017 23:43:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[USERNAME] [char](30) NOT NULL,
	[PASS] [char](30) NULL,
	[HOTEN] [nvarchar](30) NULL,
 CONSTRAINT [PK_TAIKHOAN] PRIMARY KEY CLUSTERED 
(
	[USERNAME] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[TAIKHOAN] ([USERNAME], [PASS], [HOTEN]) VALUES (N'admin                         ', N'admin                         ', N'Nguyen Van Nhan')
INSERT [dbo].[TAIKHOAN] ([USERNAME], [PASS], [HOTEN]) VALUES (N'tram                          ', N'tram                          ', N'Tran Kim Tram')
/****** Object:  StoredProcedure [dbo].[selectOne_TaiKhoan]    Script Date: 17/11/2017 23:43:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[selectOne_TaiKhoan](
		@userName char(30),
		@passWord char (30)
	)
	As
	Begin
		select count(*) from TAIKHOAN where USERNAME= @userName and PASS= @password
	End

GO
