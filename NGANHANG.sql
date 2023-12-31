USE [NGANHANG]
GO
/****** Object:  User [HTKN]    Script Date: 2023-07-13 02:48:43 PM ******/
CREATE USER [HTKN] FOR LOGIN [HTKN] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  DatabaseRole [MSmerge_0E0CE2B0A1664320AC4DDEE6B91FC507]    Script Date: 2023-07-13 02:48:43 PM ******/
CREATE ROLE [MSmerge_0E0CE2B0A1664320AC4DDEE6B91FC507]
GO
/****** Object:  DatabaseRole [MSmerge_777EEE5BDFE94560AB95C4856F84EF36]    Script Date: 2023-07-13 02:48:43 PM ******/
CREATE ROLE [MSmerge_777EEE5BDFE94560AB95C4856F84EF36]
GO
/****** Object:  DatabaseRole [MSmerge_8740BFB5F7A042F3849562BE21F2B917]    Script Date: 2023-07-13 02:48:43 PM ******/
CREATE ROLE [MSmerge_8740BFB5F7A042F3849562BE21F2B917]
GO
/****** Object:  DatabaseRole [MSmerge_PAL_role]    Script Date: 2023-07-13 02:48:43 PM ******/
CREATE ROLE [MSmerge_PAL_role]
GO
ALTER ROLE [db_owner] ADD MEMBER [HTKN]
GO
ALTER ROLE [MSmerge_PAL_role] ADD MEMBER [MSmerge_0E0CE2B0A1664320AC4DDEE6B91FC507]
GO
ALTER ROLE [MSmerge_PAL_role] ADD MEMBER [MSmerge_777EEE5BDFE94560AB95C4856F84EF36]
GO
ALTER ROLE [MSmerge_PAL_role] ADD MEMBER [MSmerge_8740BFB5F7A042F3849562BE21F2B917]
GO
/****** Object:  Schema [MSmerge_PAL_role]    Script Date: 2023-07-13 02:48:43 PM ******/
CREATE SCHEMA [MSmerge_PAL_role]
GO
/****** Object:  Default [Bdate_cons]    Script Date: 2023-07-13 02:48:43 PM ******/
CREATE DEFAULT [dbo].[Bdate_cons] 
AS
GETDATE()

GO
/****** Object:  Default [Hours_cons]    Script Date: 2023-07-13 02:48:43 PM ******/
CREATE DEFAULT [dbo].[Hours_cons] 
AS
0.0

GO
/****** Object:  Default [MgrStartDate_cons]    Script Date: 2023-07-13 02:48:43 PM ******/
CREATE DEFAULT [dbo].[MgrStartDate_cons] 
AS
GETDATE()

GO
/****** Object:  Default [Minit_cons]    Script Date: 2023-07-13 02:48:43 PM ******/
CREATE DEFAULT [dbo].[Minit_cons] 
AS
'A'

GO
/****** Object:  Default [Sex_cons]    Script Date: 2023-07-13 02:48:43 PM ******/
CREATE DEFAULT [dbo].[Sex_cons] 
AS
'M'

GO
/****** Object:  Rule [rule_bdate_chk]    Script Date: 2023-07-13 02:48:43 PM ******/
CREATE RULE [dbo].[rule_bdate_chk] 
AS
@Bdate <= GETDATE()

GO
/****** Object:  Rule [rule_Bdate_Dependent_chk]    Script Date: 2023-07-13 02:48:43 PM ******/
CREATE RULE [dbo].[rule_Bdate_Dependent_chk] 
AS
@Bdate <= GETDATE()

GO
/****** Object:  Rule [rule_Dno_chk]    Script Date: 2023-07-13 02:48:43 PM ******/
CREATE RULE [dbo].[rule_Dno_chk] 
AS
@Dno >= 0

GO
/****** Object:  Rule [rule_Dnum_chk]    Script Date: 2023-07-13 02:48:43 PM ******/
CREATE RULE [dbo].[rule_Dnum_chk] 
AS
@Dnum >= 0

GO
/****** Object:  Rule [rule_Dnumber_Department_chk]    Script Date: 2023-07-13 02:48:43 PM ******/
CREATE RULE [dbo].[rule_Dnumber_Department_chk] 
AS
@Dnumber >= 0

GO
/****** Object:  Rule [rule_Dnumber_Dept_chk]    Script Date: 2023-07-13 02:48:43 PM ******/
CREATE RULE [dbo].[rule_Dnumber_Dept_chk] 
AS
@Dnumber >= 0

GO
/****** Object:  Rule [rule_Hours_chk]    Script Date: 2023-07-13 02:48:43 PM ******/
CREATE RULE [dbo].[rule_Hours_chk] 
AS
@Hours >= 0

GO
/****** Object:  Rule [rule_MgrStartDate_Department_chk]    Script Date: 2023-07-13 02:48:43 PM ******/
CREATE RULE [dbo].[rule_MgrStartDate_Department_chk] 
AS
@Mgr_start_date <= GETDATE()

GO
/****** Object:  Rule [rule_Pno_chk]    Script Date: 2023-07-13 02:48:43 PM ******/
CREATE RULE [dbo].[rule_Pno_chk] 
AS
@Pno >= 0

GO
/****** Object:  Rule [rule_Pnumber_chk]    Script Date: 2023-07-13 02:48:43 PM ******/
CREATE RULE [dbo].[rule_Pnumber_chk] 
AS
@Pnumber >= 0

GO
/****** Object:  Rule [rule_salary_chk]    Script Date: 2023-07-13 02:48:43 PM ******/
CREATE RULE [dbo].[rule_salary_chk] 
AS
@Salary >= 0

GO
/****** Object:  Rule [rule_sex_chk]    Script Date: 2023-07-13 02:48:43 PM ******/
CREATE RULE [dbo].[rule_sex_chk] 
AS
@Sex IN ('F', 'M')

GO
/****** Object:  View [dbo].[Get_Subcribers]    Script Date: 2023-07-13 02:48:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[Get_Subcribers]
AS
	SELECT TENCN=PUBS.description, TENSERVER=subscriber_server
	 FROM sysmergepublications  PUBS, sysmergesubscriptions SUBS
 	WHERE PUBS.pubid = SUBS.pubid AND  publisher <> subscriber_server
	AND subscriber_server <> 'DESKTOP-H0GEECA\SERVER3'

GO
/****** Object:  Table [dbo].[ChiNhanh]    Script Date: 2023-07-13 02:48:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiNhanh](
	[MACN] [nchar](10) NOT NULL,
	[TENCN] [nvarchar](100) NOT NULL,
	[DIACHI] [nvarchar](100) NOT NULL,
	[SoDT] [nvarchar](15) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_ChiNhanh] PRIMARY KEY CLUSTERED 
(
	[MACN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GD_CHUYENTIEN]    Script Date: 2023-07-13 02:48:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GD_CHUYENTIEN](
	[MAGD] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[SOTK_CHUYEN] [nchar](9) NOT NULL,
	[NGAYGD] [datetime] NOT NULL,
	[SOTIEN] [money] NOT NULL,
	[SOTK_NHAN] [nchar](9) NOT NULL,
	[MANV] [nchar](10) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_GD_CHUYENTIEN] PRIMARY KEY CLUSTERED 
(
	[MAGD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GD_GOIRUT]    Script Date: 2023-07-13 02:48:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GD_GOIRUT](
	[MAGD] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[SOTK] [nchar](9) NOT NULL,
	[LOAIGD] [nchar](2) NOT NULL,
	[NGAYGD] [datetime] NOT NULL,
	[SOTIEN] [money] NOT NULL,
	[MANV] [nchar](10) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_GD_GOIRUT] PRIMARY KEY CLUSTERED 
(
	[MAGD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 2023-07-13 02:48:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[CMND] [nchar](10) NOT NULL,
	[HO] [nvarchar](50) NOT NULL,
	[TEN] [nvarchar](10) NOT NULL,
	[DIACHI] [nvarchar](100) NULL,
	[PHAI] [nvarchar](3) NULL,
	[NGAYCAP] [date] NOT NULL,
	[SODT] [nvarchar](15) NOT NULL,
	[MACN] [nchar](10) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[CMND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 2023-07-13 02:48:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MANV] [nchar](10) NOT NULL,
	[HO] [nvarchar](40) NOT NULL,
	[TEN] [nvarchar](10) NOT NULL,
	[CMND] [nchar](10) NOT NULL,
	[DIACHI] [nvarchar](100) NULL,
	[PHAI] [nvarchar](3) NOT NULL,
	[SODT] [nvarchar](15) NOT NULL,
	[MACN] [nchar](10) NULL,
	[TrangThaiXoa] [int] NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 2023-07-13 02:48:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[SOTK] [nchar](9) NOT NULL,
	[CMND] [nchar](10) NOT NULL,
	[SODU] [money] NOT NULL,
	[MACN] [nchar](10) NULL,
	[NGAYMOTK] [datetime] NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[SOTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiNhanh] ([MACN], [TENCN], [DIACHI], [SoDT], [rowguid]) VALUES (N'BENTHANH  ', N'Chi nhánh Bến Thành', N'211 Lê Lợi, Quận 1, TPHCM', N'..', N'db50b7a8-3dda-ed11-a7c1-ec63d7da75c4')
INSERT [dbo].[ChiNhanh] ([MACN], [TENCN], [DIACHI], [SoDT], [rowguid]) VALUES (N'TANDINH   ', N'Chi nhánh Tân Định', N'234 Hai Bà Trưng, phường Đakao, Quận 1, TPHCM', N'...', N'dc50b7a8-3dda-ed11-a7c1-ec63d7da75c4')
GO
SET IDENTITY_INSERT [dbo].[GD_CHUYENTIEN] ON 

INSERT [dbo].[GD_CHUYENTIEN] ([MAGD], [SOTK_CHUYEN], [NGAYGD], [SOTIEN], [SOTK_NHAN], [MANV], [rowguid]) VALUES (3962005, N'100000001', CAST(N'2023-06-18T22:37:28.387' AS DateTime), 100000.0000, N'100000003', N'NV01      ', N'40027a07-ee0d-ee11-a7cf-b4450696c104')
INSERT [dbo].[GD_CHUYENTIEN] ([MAGD], [SOTK_CHUYEN], [NGAYGD], [SOTIEN], [SOTK_NHAN], [MANV], [rowguid]) VALUES (3962006, N'100000001', CAST(N'2023-06-18T22:43:32.680' AS DateTime), 100000.0000, N'100000003', N'NV01      ', N'6cba9ce0-ee0d-ee11-a7cf-b4450696c104')
INSERT [dbo].[GD_CHUYENTIEN] ([MAGD], [SOTK_CHUYEN], [NGAYGD], [SOTIEN], [SOTK_NHAN], [MANV], [rowguid]) VALUES (3962007, N'100000001', CAST(N'2023-06-18T23:25:19.667' AS DateTime), 100000.0000, N'100000011', N'NV01      ', N'f79de4b6-f40d-ee11-a7cf-b4450696c104')
INSERT [dbo].[GD_CHUYENTIEN] ([MAGD], [SOTK_CHUYEN], [NGAYGD], [SOTIEN], [SOTK_NHAN], [MANV], [rowguid]) VALUES (3962008, N'100000011', CAST(N'2023-06-18T23:25:39.700' AS DateTime), 100000.0000, N'100000001', N'NV01      ', N'6b8cd5c2-f40d-ee11-a7cf-b4450696c104')
INSERT [dbo].[GD_CHUYENTIEN] ([MAGD], [SOTK_CHUYEN], [NGAYGD], [SOTIEN], [SOTK_NHAN], [MANV], [rowguid]) VALUES (3962009, N'100000001', CAST(N'2023-06-19T00:16:57.590' AS DateTime), 100000.0000, N'100000009', N'NV01      ', N'e70866ed-fb0d-ee11-a7cf-b4450696c104')
INSERT [dbo].[GD_CHUYENTIEN] ([MAGD], [SOTK_CHUYEN], [NGAYGD], [SOTIEN], [SOTK_NHAN], [MANV], [rowguid]) VALUES (3962010, N'100000006', CAST(N'2023-06-19T00:17:49.343' AS DateTime), 100000.0000, N'100000009', N'NV01      ', N'35f53e0c-fc0d-ee11-a7cf-b4450696c104')
INSERT [dbo].[GD_CHUYENTIEN] ([MAGD], [SOTK_CHUYEN], [NGAYGD], [SOTIEN], [SOTK_NHAN], [MANV], [rowguid]) VALUES (3962011, N'100000001', CAST(N'2023-06-19T07:45:38.073' AS DateTime), 100000.0000, N'100000014', N'NV01      ', N'1cf8429b-3a0e-ee11-a7cf-b4450696c104')
INSERT [dbo].[GD_CHUYENTIEN] ([MAGD], [SOTK_CHUYEN], [NGAYGD], [SOTIEN], [SOTK_NHAN], [MANV], [rowguid]) VALUES (3962012, N'100000001', CAST(N'2023-06-19T07:46:06.427' AS DateTime), 100000.0000, N'100000003', N'NV01      ', N'4c4b29ac-3a0e-ee11-a7cf-b4450696c104')
INSERT [dbo].[GD_CHUYENTIEN] ([MAGD], [SOTK_CHUYEN], [NGAYGD], [SOTIEN], [SOTK_NHAN], [MANV], [rowguid]) VALUES (3962013, N'100000006', CAST(N'2023-06-19T07:46:28.380' AS DateTime), 100000.0000, N'100000003', N'NV01      ', N'dcec3db9-3a0e-ee11-a7cf-b4450696c104')
INSERT [dbo].[GD_CHUYENTIEN] ([MAGD], [SOTK_CHUYEN], [NGAYGD], [SOTIEN], [SOTK_NHAN], [MANV], [rowguid]) VALUES (3962014, N'100000006', CAST(N'2023-06-19T09:44:04.003' AS DateTime), 100000.0000, N'100000001', N'NV01      ', N'78d6b826-4b0e-ee11-a7cf-b4450696c104')
INSERT [dbo].[GD_CHUYENTIEN] ([MAGD], [SOTK_CHUYEN], [NGAYGD], [SOTIEN], [SOTK_NHAN], [MANV], [rowguid]) VALUES (3962015, N'100000001', CAST(N'2023-06-19T11:46:16.997' AS DateTime), 100000.0000, N'100000004', N'NV01      ', N'99fb8639-5c0e-ee11-a7cf-b4450696c104')
INSERT [dbo].[GD_CHUYENTIEN] ([MAGD], [SOTK_CHUYEN], [NGAYGD], [SOTIEN], [SOTK_NHAN], [MANV], [rowguid]) VALUES (3962016, N'100000002', CAST(N'2023-06-19T12:21:54.620' AS DateTime), 500000.0000, N'100000003', N'NV01      ', N'a938a633-610e-ee11-a7cf-b4450696c104')
SET IDENTITY_INSERT [dbo].[GD_CHUYENTIEN] OFF
GO
SET IDENTITY_INSERT [dbo].[GD_GOIRUT] ON 

INSERT [dbo].[GD_GOIRUT] ([MAGD], [SOTK], [LOAIGD], [NGAYGD], [SOTIEN], [MANV], [rowguid]) VALUES (3962014, N'100000001', N'GT', CAST(N'2023-06-18T22:36:32.580' AS DateTime), 100000.0000, N'NV01      ', N'70d736e6-ed0d-ee11-a7cf-b4450696c104')
INSERT [dbo].[GD_GOIRUT] ([MAGD], [SOTK], [LOAIGD], [NGAYGD], [SOTIEN], [MANV], [rowguid]) VALUES (3962015, N'100000010', N'GT', CAST(N'2023-06-18T22:36:53.890' AS DateTime), 1000000.0000, N'NV01      ', N'e66eeaf2-ed0d-ee11-a7cf-b4450696c104')
INSERT [dbo].[GD_GOIRUT] ([MAGD], [SOTK], [LOAIGD], [NGAYGD], [SOTIEN], [MANV], [rowguid]) VALUES (3962016, N'100000002', N'GT', CAST(N'2023-06-18T22:50:45.020' AS DateTime), 1000000.0000, N'NV01      ', N'50814ee2-ef0d-ee11-a7cf-b4450696c104')
INSERT [dbo].[GD_GOIRUT] ([MAGD], [SOTK], [LOAIGD], [NGAYGD], [SOTIEN], [MANV], [rowguid]) VALUES (3962017, N'100000006', N'RT', CAST(N'2023-06-18T22:51:05.403' AS DateTime), 100000.0000, N'NV01      ', N'f91675ee-ef0d-ee11-a7cf-b4450696c104')
INSERT [dbo].[GD_GOIRUT] ([MAGD], [SOTK], [LOAIGD], [NGAYGD], [SOTIEN], [MANV], [rowguid]) VALUES (3962018, N'100000011', N'GT', CAST(N'2023-06-18T22:54:14.480' AS DateTime), 1000000.0000, N'NV01      ', N'6713285f-f00d-ee11-a7cf-b4450696c104')
INSERT [dbo].[GD_GOIRUT] ([MAGD], [SOTK], [LOAIGD], [NGAYGD], [SOTIEN], [MANV], [rowguid]) VALUES (3962019, N'100000011', N'GT', CAST(N'2023-06-18T23:23:08.610' AS DateTime), 100000.0000, N'NV01      ', N'98c8c668-f40d-ee11-a7cf-b4450696c104')
INSERT [dbo].[GD_GOIRUT] ([MAGD], [SOTK], [LOAIGD], [NGAYGD], [SOTIEN], [MANV], [rowguid]) VALUES (3962020, N'100000010', N'RT', CAST(N'2023-06-18T23:23:36.550' AS DateTime), 100000.0000, N'NV01      ', N'05f76d79-f40d-ee11-a7cf-b4450696c104')
INSERT [dbo].[GD_GOIRUT] ([MAGD], [SOTK], [LOAIGD], [NGAYGD], [SOTIEN], [MANV], [rowguid]) VALUES (3962021, N'100000001', N'GT', CAST(N'2023-06-19T00:14:12.447' AS DateTime), 1000000.0000, N'NV01      ', N'fc3bf78a-fb0d-ee11-a7cf-b4450696c104')
INSERT [dbo].[GD_GOIRUT] ([MAGD], [SOTK], [LOAIGD], [NGAYGD], [SOTIEN], [MANV], [rowguid]) VALUES (3962022, N'100000001', N'GT', CAST(N'2023-06-19T00:14:57.277' AS DateTime), 1000000000.0000, N'NV01      ', N'7da9afa5-fb0d-ee11-a7cf-b4450696c104')
INSERT [dbo].[GD_GOIRUT] ([MAGD], [SOTK], [LOAIGD], [NGAYGD], [SOTIEN], [MANV], [rowguid]) VALUES (3962023, N'100000001', N'RT', CAST(N'2023-06-19T00:15:19.743' AS DateTime), 100000.0000, N'NV01      ', N'a4e913b3-fb0d-ee11-a7cf-b4450696c104')
INSERT [dbo].[GD_GOIRUT] ([MAGD], [SOTK], [LOAIGD], [NGAYGD], [SOTIEN], [MANV], [rowguid]) VALUES (3962024, N'100000001', N'RT', CAST(N'2023-06-19T00:15:54.450' AS DateTime), 1000000000.0000, N'NV01      ', N'47c1c3c7-fb0d-ee11-a7cf-b4450696c104')
INSERT [dbo].[GD_GOIRUT] ([MAGD], [SOTK], [LOAIGD], [NGAYGD], [SOTIEN], [MANV], [rowguid]) VALUES (3962025, N'100000013', N'GT', CAST(N'2023-06-19T07:45:09.393' AS DateTime), 1000000.0000, N'NV01      ', N'75e32a8a-3a0e-ee11-a7cf-b4450696c104')
INSERT [dbo].[GD_GOIRUT] ([MAGD], [SOTK], [LOAIGD], [NGAYGD], [SOTIEN], [MANV], [rowguid]) VALUES (3962026, N'100000013', N'RT', CAST(N'2023-06-19T07:45:22.313' AS DateTime), 100000.0000, N'NV01      ', N'147ddd91-3a0e-ee11-a7cf-b4450696c104')
INSERT [dbo].[GD_GOIRUT] ([MAGD], [SOTK], [LOAIGD], [NGAYGD], [SOTIEN], [MANV], [rowguid]) VALUES (3962027, N'100000004', N'GT', CAST(N'2023-06-19T09:41:38.107' AS DateTime), 100000.0000, N'NV01      ', N'33ccc3cf-4a0e-ee11-a7cf-b4450696c104')
INSERT [dbo].[GD_GOIRUT] ([MAGD], [SOTK], [LOAIGD], [NGAYGD], [SOTIEN], [MANV], [rowguid]) VALUES (3962028, N'100000004', N'GT', CAST(N'2023-06-19T09:42:50.667' AS DateTime), 1000000.0000, N'NV01      ', N'ae5203fb-4a0e-ee11-a7cf-b4450696c104')
INSERT [dbo].[GD_GOIRUT] ([MAGD], [SOTK], [LOAIGD], [NGAYGD], [SOTIEN], [MANV], [rowguid]) VALUES (3962029, N'100000001', N'GT', CAST(N'2023-06-19T11:45:41.843' AS DateTime), 1000000.0000, N'NV01      ', N'eb0a9324-5c0e-ee11-a7cf-b4450696c104')
INSERT [dbo].[GD_GOIRUT] ([MAGD], [SOTK], [LOAIGD], [NGAYGD], [SOTIEN], [MANV], [rowguid]) VALUES (3962030, N'100000018', N'GT', CAST(N'2023-06-19T12:01:34.323' AS DateTime), 100000.0000, N'NV01      ', N'e0ad4b5c-5e0e-ee11-a7cf-b4450696c104')
INSERT [dbo].[GD_GOIRUT] ([MAGD], [SOTK], [LOAIGD], [NGAYGD], [SOTIEN], [MANV], [rowguid]) VALUES (3962031, N'100000018', N'RT', CAST(N'2023-06-19T12:01:52.577' AS DateTime), 100000.0000, N'NV01      ', N'1c102d67-5e0e-ee11-a7cf-b4450696c104')
INSERT [dbo].[GD_GOIRUT] ([MAGD], [SOTK], [LOAIGD], [NGAYGD], [SOTIEN], [MANV], [rowguid]) VALUES (3962032, N'100000002', N'RT', CAST(N'2023-06-19T12:20:36.687' AS DateTime), 400000.0000, N'NV01      ', N'67a63205-610e-ee11-a7cf-b4450696c104')
SET IDENTITY_INSERT [dbo].[GD_GOIRUT] OFF
GO
INSERT [dbo].[KhachHang] ([CMND], [HO], [TEN], [DIACHI], [PHAI], [NGAYCAP], [SODT], [MACN], [rowguid]) VALUES (N'1100000001', N'Hồ Thái', N'Đạt', N'Man Thiện', N'Nam', CAST(N'2019-01-01' AS Date), N'0123456789', N'BENTHANH  ', N'dd50b7a8-3dda-ed11-a7c1-ec63d7da75c4')
INSERT [dbo].[KhachHang] ([CMND], [HO], [TEN], [DIACHI], [PHAI], [NGAYCAP], [SODT], [MACN], [rowguid]) VALUES (N'1100000002', N'Huỳnh Gia', N'Hưng', N'Man Thiện', N'Nam', CAST(N'2019-01-01' AS Date), N'0123456789', N'TANDINH   ', N'de50b7a8-3dda-ed11-a7c1-ec63d7da75c4')
INSERT [dbo].[KhachHang] ([CMND], [HO], [TEN], [DIACHI], [PHAI], [NGAYCAP], [SODT], [MACN], [rowguid]) VALUES (N'1100000003', N'Đậu Văn', N'Hoàng', N'Man Thiện', N'Nam', CAST(N'2019-01-01' AS Date), N'0123456789', N'BENTHANH  ', N'df50b7a8-3dda-ed11-a7c1-ec63d7da75c4')
INSERT [dbo].[KhachHang] ([CMND], [HO], [TEN], [DIACHI], [PHAI], [NGAYCAP], [SODT], [MACN], [rowguid]) VALUES (N'1100000004', N'Lê Viết', N'Sỹ', N'Man Thiện', N'Nam', CAST(N'2019-01-01' AS Date), N'0123456789', N'TANDINH   ', N'e050b7a8-3dda-ed11-a7c1-ec63d7da75c4')
INSERT [dbo].[KhachHang] ([CMND], [HO], [TEN], [DIACHI], [PHAI], [NGAYCAP], [SODT], [MACN], [rowguid]) VALUES (N'1100000005', N'Ngô Quốc ', N'Tuấn', N'Man Thiện', N'Nam', CAST(N'2019-01-01' AS Date), N'0123456987', N'BENTHANH  ', N'e150b7a8-3dda-ed11-a7c1-ec63d7da75c4')
INSERT [dbo].[KhachHang] ([CMND], [HO], [TEN], [DIACHI], [PHAI], [NGAYCAP], [SODT], [MACN], [rowguid]) VALUES (N'1100000006', N'Hồ Anh', N'Quốc', N'Man Thiện', N'Nam', CAST(N'2019-01-01' AS Date), N'0123654789', N'TANDINH   ', N'e250b7a8-3dda-ed11-a7c1-ec63d7da75c4')
INSERT [dbo].[KhachHang] ([CMND], [HO], [TEN], [DIACHI], [PHAI], [NGAYCAP], [SODT], [MACN], [rowguid]) VALUES (N'1100000007', N'Van', N'Tin', NULL, N'Nam', CAST(N'2023-05-31' AS Date), N'0123456789', N'BENTHANH  ', N'd2eae54a-5f00-ee11-a7cb-b4450696c104')
INSERT [dbo].[KhachHang] ([CMND], [HO], [TEN], [DIACHI], [PHAI], [NGAYCAP], [SODT], [MACN], [rowguid]) VALUES (N'1100000008', N'c', N'd', NULL, N'Nữ', CAST(N'2023-06-18' AS Date), N'0147896523', N'TANDINH   ', N'4563f15c-5f0d-ee11-a7cf-b4450696c104')
INSERT [dbo].[KhachHang] ([CMND], [HO], [TEN], [DIACHI], [PHAI], [NGAYCAP], [SODT], [MACN], [rowguid]) VALUES (N'1100000009', N'Tran', N'Quynh', NULL, N'Nam', CAST(N'2023-06-04' AS Date), N'0234567891', N'BENTHANH  ', N'6b7b2325-6b08-ee11-a7cb-b4450696c104')
INSERT [dbo].[KhachHang] ([CMND], [HO], [TEN], [DIACHI], [PHAI], [NGAYCAP], [SODT], [MACN], [rowguid]) VALUES (N'1100000010', N'Ho', N'A', NULL, N'Nam', CAST(N'2023-06-19' AS Date), N'09999999999', N'TANDINH   ', N'dfa61a03-560e-ee11-a7cf-b4450696c104')
INSERT [dbo].[KhachHang] ([CMND], [HO], [TEN], [DIACHI], [PHAI], [NGAYCAP], [SODT], [MACN], [rowguid]) VALUES (N'1100000011', N'A', N'Bcd', NULL, N'Nam', CAST(N'2023-06-17' AS Date), N'3214785698', N'BENTHANH  ', N'0f0f74f3-250d-ee11-a7cf-b4450696c104')
INSERT [dbo].[KhachHang] ([CMND], [HO], [TEN], [DIACHI], [PHAI], [NGAYCAP], [SODT], [MACN], [rowguid]) VALUES (N'1100000013', N'c', N'd', NULL, N'Nam', CAST(N'2023-06-18' AS Date), N'0321654987', N'BENTHANH  ', N'a164bd9d-de0d-ee11-a7cf-b4450696c104')
INSERT [dbo].[KhachHang] ([CMND], [HO], [TEN], [DIACHI], [PHAI], [NGAYCAP], [SODT], [MACN], [rowguid]) VALUES (N'1100000015', N'Y', N'Z', NULL, N'Nam', CAST(N'2023-06-19' AS Date), N'0333333333', N'BENTHANH  ', N'88a54643-3a0e-ee11-a7cf-b4450696c104')
INSERT [dbo].[KhachHang] ([CMND], [HO], [TEN], [DIACHI], [PHAI], [NGAYCAP], [SODT], [MACN], [rowguid]) VALUES (N'1100000017', N'Dau', N'Hoang', NULL, N'Nam', CAST(N'2023-06-19' AS Date), N'0888888888', N'BENTHANH  ', N'0b45a24a-560e-ee11-a7cf-b4450696c104')
GO
INSERT [dbo].[NhanVien] ([MANV], [HO], [TEN], [CMND], [DIACHI], [PHAI], [SODT], [MACN], [TrangThaiXoa], [rowguid]) VALUES (N'NV01      ', N'Trần Minh', N'Nguyên', N'1110000001', NULL, N'Nam', N'1111111111', N'BENTHANH  ', 1, N'e350b7a8-3dda-ed11-a7c1-ec63d7da75c4')
INSERT [dbo].[NhanVien] ([MANV], [HO], [TEN], [CMND], [DIACHI], [PHAI], [SODT], [MACN], [TrangThaiXoa], [rowguid]) VALUES (N'NV010     ', N'Trần Minh', N'Nguyên', N'1110000001', NULL, N'Nam', N'1111111111', N'TANDINH   ', 0, N'58cc83c5-620e-ee11-a7cf-b4450696c104')
INSERT [dbo].[NhanVien] ([MANV], [HO], [TEN], [CMND], [DIACHI], [PHAI], [SODT], [MACN], [TrangThaiXoa], [rowguid]) VALUES (N'NV02      ', N'Lê Văn', N'Anh', N'1110000002', NULL, N'Nam', N'2222222222', N'TANDINH   ', 0, N'e450b7a8-3dda-ed11-a7c1-ec63d7da75c4')
INSERT [dbo].[NhanVien] ([MANV], [HO], [TEN], [CMND], [DIACHI], [PHAI], [SODT], [MACN], [TrangThaiXoa], [rowguid]) VALUES (N'NV03      ', N'Lê Thái', N'Bảo', N'1110000003', NULL, N'Nam', N'3333333333', N'BENTHANH  ', 0, N'e550b7a8-3dda-ed11-a7c1-ec63d7da75c4')
INSERT [dbo].[NhanVien] ([MANV], [HO], [TEN], [CMND], [DIACHI], [PHAI], [SODT], [MACN], [TrangThaiXoa], [rowguid]) VALUES (N'NV04      ', N'Phan Văn ', N'Lương', N'1110000004', NULL, N'Nam', N'4444444444', N'TANDINH   ', 0, N'e650b7a8-3dda-ed11-a7c1-ec63d7da75c4')
INSERT [dbo].[NhanVien] ([MANV], [HO], [TEN], [CMND], [DIACHI], [PHAI], [SODT], [MACN], [TrangThaiXoa], [rowguid]) VALUES (N'NV05      ', N'Hồ Viết ', N'Dũng', N'1110000005', NULL, N'Nam', N'5555555555', N'TANDINH   ', 0, N'e750b7a8-3dda-ed11-a7c1-ec63d7da75c4')
INSERT [dbo].[NhanVien] ([MANV], [HO], [TEN], [CMND], [DIACHI], [PHAI], [SODT], [MACN], [TrangThaiXoa], [rowguid]) VALUES (N'NV06      ', N'Đặng Viết', N'Tuấn', N'1110000006', NULL, N'Nam', N'6666666666', N'BENTHANH  ', 0, N'e850b7a8-3dda-ed11-a7c1-ec63d7da75c4')
INSERT [dbo].[NhanVien] ([MANV], [HO], [TEN], [CMND], [DIACHI], [PHAI], [SODT], [MACN], [TrangThaiXoa], [rowguid]) VALUES (N'NV07      ', N'Van Trung', N'Tin', N'1110000007', NULL, N'Nam', N'0123456789', N'BENTHANH  ', 0, N'286edaa3-0afe-ed11-a7cb-b4450696c104')
INSERT [dbo].[NhanVien] ([MANV], [HO], [TEN], [CMND], [DIACHI], [PHAI], [SODT], [MACN], [TrangThaiXoa], [rowguid]) VALUES (N'NV08      ', N'H', N'D', N'1110000008', NULL, N'Nam', N'123465781', N'TANDINH   ', 1, N'd2166e9d-260d-ee11-a7cf-b4450696c104')
INSERT [dbo].[NhanVien] ([MANV], [HO], [TEN], [CMND], [DIACHI], [PHAI], [SODT], [MACN], [TrangThaiXoa], [rowguid]) VALUES (N'NV09      ', N'tran ', N'anh', N'1110000009', NULL, N'Nam', N'0234567891', N'BENTHANH  ', 0, N'3e5672ef-15fe-ed11-a7cb-b4450696c104')
INSERT [dbo].[NhanVien] ([MANV], [HO], [TEN], [CMND], [DIACHI], [PHAI], [SODT], [MACN], [TrangThaiXoa], [rowguid]) VALUES (N'NV100     ', N'C', N'D', N'1110000017', NULL, N'Nam', N'099999999', N'BENTHANH  ', 0, N'40896ebf-c012-ee11-a7d0-ec63d7da75c4')
INSERT [dbo].[NhanVien] ([MANV], [HO], [TEN], [CMND], [DIACHI], [PHAI], [SODT], [MACN], [TrangThaiXoa], [rowguid]) VALUES (N'NV13      ', N'Tran', N'Quynh', N'1110000010', NULL, N'Nam', N'0231234547', N'BENTHANH  ', 0, N'02c08d4a-8600-ee11-a7cb-b4450696c104')
INSERT [dbo].[NhanVien] ([MANV], [HO], [TEN], [CMND], [DIACHI], [PHAI], [SODT], [MACN], [TrangThaiXoa], [rowguid]) VALUES (N'NV15      ', N'A', N'b', N'1110000011', NULL, N'Nam', N'0321457896', N'BENTHANH  ', 0, N'7aae00d8-d30a-ee11-a7cc-b4450696c104')
INSERT [dbo].[NhanVien] ([MANV], [HO], [TEN], [CMND], [DIACHI], [PHAI], [SODT], [MACN], [TrangThaiXoa], [rowguid]) VALUES (N'NV19      ', N'C', N'd', N'1110000012', NULL, N'Nam', N'0125874696', N'BENTHANH  ', 0, N'9e3fc737-d40a-ee11-a7cc-b4450696c104')
INSERT [dbo].[NhanVien] ([MANV], [HO], [TEN], [CMND], [DIACHI], [PHAI], [SODT], [MACN], [TrangThaiXoa], [rowguid]) VALUES (N'NV22      ', N'd', N'g', N'1110000013', NULL, N'Nữ', N'213123123', N'BENTHANH  ', 0, N'3ccbf470-d40a-ee11-a7cc-b4450696c104')
INSERT [dbo].[NhanVien] ([MANV], [HO], [TEN], [CMND], [DIACHI], [PHAI], [SODT], [MACN], [TrangThaiXoa], [rowguid]) VALUES (N'NV23      ', N'H', N'D', N'1110000014', NULL, N'Nữ', N'123465781', N'BENTHANH  ', 0, N'10a40166-d80a-ee11-a7cc-b4450696c104')
INSERT [dbo].[NhanVien] ([MANV], [HO], [TEN], [CMND], [DIACHI], [PHAI], [SODT], [MACN], [TrangThaiXoa], [rowguid]) VALUES (N'NV25      ', N'H', N'g', N'1110000015', NULL, N'Nữ', N'987446515', N'BENTHANH  ', 1, N'4884eb2e-da0a-ee11-a7cc-b4450696c104')
INSERT [dbo].[NhanVien] ([MANV], [HO], [TEN], [CMND], [DIACHI], [PHAI], [SODT], [MACN], [TrangThaiXoa], [rowguid]) VALUES (N'NV40      ', N'A', N'B', N'1110000016', NULL, N'Nam', N'055555555', N'BENTHANH  ', 1, N'9a7ede56-4b0e-ee11-a7cf-b4450696c104')
GO
INSERT [dbo].[TaiKhoan] ([SOTK], [CMND], [SODU], [MACN], [NGAYMOTK], [rowguid]) VALUES (N'100000001', N'1100000001', 2267657.0000, N'BENTHANH  ', CAST(N'2023-04-14T00:00:00.000' AS DateTime), N'9a719c08-5df5-ed11-a7c8-ec63d7da75c4')
INSERT [dbo].[TaiKhoan] ([SOTK], [CMND], [SODU], [MACN], [NGAYMOTK], [rowguid]) VALUES (N'100000002', N'1100000001', 500000.0000, N'BENTHANH  ', CAST(N'2023-04-14T00:00:00.000' AS DateTime), N'9b719c08-5df5-ed11-a7c8-ec63d7da75c4')
INSERT [dbo].[TaiKhoan] ([SOTK], [CMND], [SODU], [MACN], [NGAYMOTK], [rowguid]) VALUES (N'100000003', N'1100000004', 2000000.0000, N'TANDINH   ', CAST(N'2023-04-14T00:00:00.000' AS DateTime), N'9c719c08-5df5-ed11-a7c8-ec63d7da75c4')
INSERT [dbo].[TaiKhoan] ([SOTK], [CMND], [SODU], [MACN], [NGAYMOTK], [rowguid]) VALUES (N'100000004', N'1100000006', 2200000.0000, N'TANDINH   ', CAST(N'2023-04-14T00:00:00.000' AS DateTime), N'9d719c08-5df5-ed11-a7c8-ec63d7da75c4')
INSERT [dbo].[TaiKhoan] ([SOTK], [CMND], [SODU], [MACN], [NGAYMOTK], [rowguid]) VALUES (N'100000005', N'1100000005', 1000000.0000, N'BENTHANH  ', CAST(N'2023-04-14T00:00:00.000' AS DateTime), N'9e719c08-5df5-ed11-a7c8-ec63d7da75c4')
INSERT [dbo].[TaiKhoan] ([SOTK], [CMND], [SODU], [MACN], [NGAYMOTK], [rowguid]) VALUES (N'100000006', N'1100000002', 832343.0000, N'TANDINH   ', CAST(N'2023-04-14T00:00:00.000' AS DateTime), N'9f719c08-5df5-ed11-a7c8-ec63d7da75c4')
INSERT [dbo].[TaiKhoan] ([SOTK], [CMND], [SODU], [MACN], [NGAYMOTK], [rowguid]) VALUES (N'100000007', N'1100000002', 2400000.0000, N'TANDINH   ', CAST(N'2023-04-14T00:00:00.000' AS DateTime), N'a0719c08-5df5-ed11-a7c8-ec63d7da75c4')
INSERT [dbo].[TaiKhoan] ([SOTK], [CMND], [SODU], [MACN], [NGAYMOTK], [rowguid]) VALUES (N'100000008', N'1100000003', 2000000.0000, N'BENTHANH  ', CAST(N'2023-04-14T00:00:00.000' AS DateTime), N'a1719c08-5df5-ed11-a7c8-ec63d7da75c4')
INSERT [dbo].[TaiKhoan] ([SOTK], [CMND], [SODU], [MACN], [NGAYMOTK], [rowguid]) VALUES (N'100000009', N'1100000013', 200000.0000, N'BENTHANH  ', CAST(N'2023-06-18T00:00:00.000' AS DateTime), N'39ddc177-e70d-ee11-a7cf-b4450696c104')
INSERT [dbo].[TaiKhoan] ([SOTK], [CMND], [SODU], [MACN], [NGAYMOTK], [rowguid]) VALUES (N'100000010', N'1100000011', 900000.0000, N'BENTHANH  ', CAST(N'2023-06-18T00:00:00.000' AS DateTime), N'739412b1-e70d-ee11-a7cf-b4450696c104')
INSERT [dbo].[TaiKhoan] ([SOTK], [CMND], [SODU], [MACN], [NGAYMOTK], [rowguid]) VALUES (N'100000011', N'1100000011', 1100000.0000, N'BENTHANH  ', CAST(N'2023-06-18T00:00:00.000' AS DateTime), N'8b9d5fd0-ef0d-ee11-a7cf-b4450696c104')
INSERT [dbo].[TaiKhoan] ([SOTK], [CMND], [SODU], [MACN], [NGAYMOTK], [rowguid]) VALUES (N'100000012', N'1100000013', 0.0000, N'BENTHANH  ', CAST(N'2023-06-19T00:00:00.000' AS DateTime), N'e67c9050-fb0d-ee11-a7cf-b4450696c104')
INSERT [dbo].[TaiKhoan] ([SOTK], [CMND], [SODU], [MACN], [NGAYMOTK], [rowguid]) VALUES (N'100000013', N'1100000015', 900000.0000, N'BENTHANH  ', CAST(N'2023-06-19T00:00:00.000' AS DateTime), N'f59a1969-3a0e-ee11-a7cf-b4450696c104')
INSERT [dbo].[TaiKhoan] ([SOTK], [CMND], [SODU], [MACN], [NGAYMOTK], [rowguid]) VALUES (N'100000014', N'1100000015', 100000.0000, N'BENTHANH  ', CAST(N'2023-06-19T00:00:00.000' AS DateTime), N'4f95077c-3a0e-ee11-a7cf-b4450696c104')
INSERT [dbo].[TaiKhoan] ([SOTK], [CMND], [SODU], [MACN], [NGAYMOTK], [rowguid]) VALUES (N'100000015', N'1100000017', 0.0000, N'BENTHANH  ', CAST(N'2023-06-19T00:00:00.000' AS DateTime), N'c4967b7e-560e-ee11-a7cf-b4450696c104')
INSERT [dbo].[TaiKhoan] ([SOTK], [CMND], [SODU], [MACN], [NGAYMOTK], [rowguid]) VALUES (N'100000016', N'1100000017', 0.0000, N'BENTHANH  ', CAST(N'2023-06-19T00:00:00.000' AS DateTime), N'd0b329ff-5b0e-ee11-a7cf-b4450696c104')
INSERT [dbo].[TaiKhoan] ([SOTK], [CMND], [SODU], [MACN], [NGAYMOTK], [rowguid]) VALUES (N'100000017', N'1100000011', 0.0000, N'BENTHANH  ', CAST(N'2023-06-19T00:00:00.000' AS DateTime), N'8eda04e7-5c0e-ee11-a7cf-b4450696c104')
INSERT [dbo].[TaiKhoan] ([SOTK], [CMND], [SODU], [MACN], [NGAYMOTK], [rowguid]) VALUES (N'100000018', N'1100000001', 0.0000, N'BENTHANH  ', CAST(N'2023-06-19T00:00:00.000' AS DateTime), N'c773b0ff-5c0e-ee11-a7cf-b4450696c104')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_ChiNhanh]    Script Date: 2023-07-13 02:48:43 PM ******/
ALTER TABLE [dbo].[ChiNhanh] ADD  CONSTRAINT [UK_ChiNhanh] UNIQUE NONCLUSTERED 
(
	[TENCN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChiNhanh] ADD  CONSTRAINT [MSmerge_df_rowguid_C937856CC7D349BF9A106FAC1DAA4D46]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[GD_CHUYENTIEN] ADD  CONSTRAINT [DF_GD_CHUYENTIEN_NGAYGD]  DEFAULT (getdate()) FOR [NGAYGD]
GO
ALTER TABLE [dbo].[GD_CHUYENTIEN] ADD  CONSTRAINT [MSmerge_df_rowguid_1D62AC1207E24197B2ACA07E3B1F8CDB]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[GD_GOIRUT] ADD  CONSTRAINT [DF_GD_GOIRUT_NGAYGD]  DEFAULT (getdate()) FOR [NGAYGD]
GO
ALTER TABLE [dbo].[GD_GOIRUT] ADD  CONSTRAINT [DF_GD_GOIRUT_SOTIEN]  DEFAULT ((100000)) FOR [SOTIEN]
GO
ALTER TABLE [dbo].[GD_GOIRUT] ADD  CONSTRAINT [MSmerge_df_rowguid_EB3187E84B46400BB3ACB86482BE078A]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[KhachHang] ADD  CONSTRAINT [MSmerge_df_rowguid_62758FD9AB1047078808B34BC37908BB]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[NhanVien] ADD  CONSTRAINT [DF_NhanVien_PHAI]  DEFAULT (N'Nam') FOR [PHAI]
GO
ALTER TABLE [dbo].[NhanVien] ADD  CONSTRAINT [MSmerge_df_rowguid_B8E9FC859FD4466B9E0137A00C23067E]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[TaiKhoan] ADD  DEFAULT ((0)) FOR [SODU]
GO
ALTER TABLE [dbo].[TaiKhoan] ADD  CONSTRAINT [MSmerge_df_rowguid_3B2340BEC61545DBA619F597BA69AF5C]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[GD_CHUYENTIEN]  WITH CHECK ADD  CONSTRAINT [FK_GD_CHUYENTIEN_NhanVien] FOREIGN KEY([MANV])
REFERENCES [dbo].[NhanVien] ([MANV])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[GD_CHUYENTIEN] CHECK CONSTRAINT [FK_GD_CHUYENTIEN_NhanVien]
GO
ALTER TABLE [dbo].[GD_CHUYENTIEN]  WITH CHECK ADD  CONSTRAINT [FK_GD_CHUYENTIEN_TaiKhoan] FOREIGN KEY([SOTK_CHUYEN])
REFERENCES [dbo].[TaiKhoan] ([SOTK])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[GD_CHUYENTIEN] CHECK CONSTRAINT [FK_GD_CHUYENTIEN_TaiKhoan]
GO
ALTER TABLE [dbo].[GD_CHUYENTIEN]  WITH CHECK ADD  CONSTRAINT [FK_GD_CHUYENTIEN_TaiKhoan1] FOREIGN KEY([SOTK_NHAN])
REFERENCES [dbo].[TaiKhoan] ([SOTK])
GO
ALTER TABLE [dbo].[GD_CHUYENTIEN] CHECK CONSTRAINT [FK_GD_CHUYENTIEN_TaiKhoan1]
GO
ALTER TABLE [dbo].[GD_GOIRUT]  WITH CHECK ADD  CONSTRAINT [FK_GD_GOIRUT_NhanVien] FOREIGN KEY([MANV])
REFERENCES [dbo].[NhanVien] ([MANV])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[GD_GOIRUT] CHECK CONSTRAINT [FK_GD_GOIRUT_NhanVien]
GO
ALTER TABLE [dbo].[GD_GOIRUT]  WITH CHECK ADD  CONSTRAINT [FK_GD_GOIRUT_TaiKhoan] FOREIGN KEY([SOTK])
REFERENCES [dbo].[TaiKhoan] ([SOTK])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[GD_GOIRUT] CHECK CONSTRAINT [FK_GD_GOIRUT_TaiKhoan]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_ChiNhanh] FOREIGN KEY([MACN])
REFERENCES [dbo].[ChiNhanh] ([MACN])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_ChiNhanh]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChiNhanh] FOREIGN KEY([MACN])
REFERENCES [dbo].[ChiNhanh] ([MACN])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ChiNhanh]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_ChiNhanh] FOREIGN KEY([MACN])
REFERENCES [dbo].[ChiNhanh] ([MACN])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_ChiNhanh]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_KhachHang] FOREIGN KEY([CMND])
REFERENCES [dbo].[KhachHang] ([CMND])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_KhachHang]
GO
ALTER TABLE [dbo].[GD_CHUYENTIEN]  WITH CHECK ADD  CONSTRAINT [CK_GD_CHUYENTIEN] CHECK  (([SOTIEN]>(0)))
GO
ALTER TABLE [dbo].[GD_CHUYENTIEN] CHECK CONSTRAINT [CK_GD_CHUYENTIEN]
GO
ALTER TABLE [dbo].[GD_CHUYENTIEN]  WITH NOCHECK ADD  CONSTRAINT [repl_identity_range_31368DF0_573D_4250_B495_974D2FE8AFF7] CHECK NOT FOR REPLICATION (([MAGD]>(3) AND [MAGD]<=(1003) OR [MAGD]>(1003) AND [MAGD]<=(2003)))
GO
ALTER TABLE [dbo].[GD_CHUYENTIEN] CHECK CONSTRAINT [repl_identity_range_31368DF0_573D_4250_B495_974D2FE8AFF7]
GO
ALTER TABLE [dbo].[GD_GOIRUT]  WITH CHECK ADD  CONSTRAINT [CK_LOAIGD] CHECK  (([LOAIGD]='RT' OR [LOAIGD]='GT'))
GO
ALTER TABLE [dbo].[GD_GOIRUT] CHECK CONSTRAINT [CK_LOAIGD]
GO
ALTER TABLE [dbo].[GD_GOIRUT]  WITH CHECK ADD  CONSTRAINT [CK_SOTIEN] CHECK  (([SOTIEN]>=(100000)))
GO
ALTER TABLE [dbo].[GD_GOIRUT] CHECK CONSTRAINT [CK_SOTIEN]
GO
ALTER TABLE [dbo].[GD_GOIRUT]  WITH NOCHECK ADD  CONSTRAINT [repl_identity_range_91EE2171_098D_43DD_AC2D_98E511ACDF35] CHECK NOT FOR REPLICATION (([MAGD]>(6) AND [MAGD]<=(1006) OR [MAGD]>(1006) AND [MAGD]<=(2006)))
GO
ALTER TABLE [dbo].[GD_GOIRUT] CHECK CONSTRAINT [repl_identity_range_91EE2171_098D_43DD_AC2D_98E511ACDF35]
GO
/****** Object:  StoredProcedure [dbo].[SP_CheckCMND]    Script Date: 2023-07-13 02:48:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CheckCMND]
	@cmnd NVARCHAR(10)
AS
BEGIN
DECLARE @check int
	IF EXISTS(SELECT * FROM dbo.KhachHang WHERE dbo.KhachHang.CMND = @cmnd)
		SET @check = 1	--Mã tồn tại ở phân mãnh hiện tại	
	ELSE IF EXISTS(SELECT * FROM LINK1.NGANHANG.dbo.KhachHang AS KH WHERE KH.CMND = @cmnd)
		SET @check = 2	--Mã tồn tại ở phân mãnh khác
	ELSE
		SET @check = 0
SELECT @check	--Không bị trùng được thêm
END




GO
/****** Object:  StoredProcedure [dbo].[SP_CheckMANV]    Script Date: 2023-07-13 02:48:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CheckMANV]
	@maNV NCHAR(10)
AS
BEGIN
DECLARE @check int
	IF EXISTS(SELECT * FROM dbo.NhanVien WHERE dbo.NhanVien.MANV = @maNV)
		SET @check = 1	--Mã tồn tại ở phân mãnh hiện tại	
	ELSE IF EXISTS(SELECT * FROM LINK0.NGANHANG.dbo.NhanVien AS NV WHERE NV.MANV = @maNV)
		SET @check = 2	--Mã tồn tại ở phân mãnh khác
	ELSE
		SET @check = 0
SELECT @check	--Không bị trùng được thêm
END


GO
/****** Object:  StoredProcedure [dbo].[SP_ChuyenCN]    Script Date: 2023-07-13 02:48:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ChuyenCN] @manv nvarchar(10),
	@macngo nvarchar(10)
AS
DECLARE @check int
DECLARE @manvmax nvarchar(10) = (SELECT TOP 1 RIGHT(LTRIM(RTRIM(MANV)), 2) AS manvmax FROM LINK1.NGANHANG.DBO.NhanVien ORDER BY MANV DESC);


IF (@manvmax < 10)
	SET @manvmax = CONCAT('NV','0', @manvmax + 1)
ELSE
	SET @manvmax = CONCAT('NV', @manvmax + 1)
SET XACT_ABORT ON
BEGIN DISTRIBUTED TRANSACTION
BEGIN TRY
	IF EXISTS (SELECT * FROM LINK1.NGANHANG.DBO.NhanVien
				WHERE SODT = (SELECT SODT FROM NhanVien WHERE MANV = @manv))
	BEGIN
		UPDATE NhanVien
			SET TrangThaiXoa = 1
			WHERE MANV = @manv

		UPDATE LINK1.NGANHANG.DBO.NhanVien
			SET TrangThaiXoa = 0
			WHERE SODT = (SELECT SODT FROM NhanVien WHERE MANV = @manv)
	END
	ELSE
	BEGIN
		INSERT INTO LINK1.NGANHANG.DBO.NhanVien(MANV, HO, TEN, CMND, DIACHI, PHAI, SODT, MACN, TrangThaiXoa)
			SELECT @manvmax AS MANV, HO, TEN, CMND, DIACHI, PHAI, SODT, @macngo AS MACN, 0 FROM NhanVien WHERE MANV = @manv

		UPDATE NhanVien
			SET TrangThaiXoa = 1
			WHERE MANV = @manv
	END

	IF (@@TRANCOUNT > 0)
	BEGIN
		COMMIT TRANSACTION
		SET @check = 1
	END
END TRY
BEGIN CATCH
	IF (@@TRANCOUNT > 0)
	BEGIN
		ROLLBACK TRANSACTION
		SET @check = 0
	END
END CATCH
SELECT @check

GO
/****** Object:  StoredProcedure [dbo].[SP_ChuyenTien]    Script Date: 2023-07-13 02:48:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ChuyenTien]
	@sotkchuyen nvarchar(10),
	@sotknhan nvarchar(10),
	@sotien money,
	@manv nvarchar(10)
AS
DECLARE @sodu money = (SELECT SODU FROM TaiKhoan WHERE SOTK = @sotkchuyen)
DECLARE @check int = 1

IF NOT EXISTS(SELECT * FROM dbo.TaiKhoan AS TK WHERE TK.SOTK = @sotkchuyen)
BEGIN
	SET @check = 2
	SELECT @check
	RETURN
END

IF NOT EXISTS(SELECT * FROM dbo.TaiKhoan AS TK WHERE TK.SOTK = @sotknhan)
BEGIN
	SET @check = 3
	SELECT @check
	RETURN
END

IF (@sotien <= @sodu)
BEGIN
	SET XACT_ABORT ON /*lỗi tự động rollback */
	BEGIN TRANSACTION
	BEGIN TRY
		INSERT INTO GD_CHUYENTIEN(SOTK_CHUYEN, NGAYGD, SOTIEN, SOTK_NHAN, MANV)
			VALUES(@sotkchuyen, GETDATE(), @sotien, @sotknhan, @manv)
		UPDATE TaiKhoan 
			SET SODU = SODU - @sotien
			WHERE SOTK = @sotkchuyen
		UPDATE TaiKhoan 
			SET SODU = SODU + @sotien
			WHERE SOTK = @sotknhan			  
							
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SET @check = 0
	END CATCH
END
ELSE
	SET @check = 4

SELECT @check
GO
/****** Object:  StoredProcedure [dbo].[SP_DangNhap]    Script Date: 2023-07-13 02:48:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DangNhap]
	@tenLogin nvarchar(50)
AS
BEGIN
	DECLARE @tenUser nvarchar(50)
	SELECT @tenUser = NAME FROM sys.sysusers WHERE sid = SUSER_SID(@tenLogin)
 
	SELECT USERNAME = @tenUser,
		HOTEN = (SELECT HO + ' ' + TEN FROM NHANVIEN WHERE MANV = @tenUser),
		TENNHOM = NAME
	FROM sys.sysusers 
	WHERE UID = (SELECT GROUPUID
                 FROM SYS.SYSMEMBERS
					WHERE MEMBERUID = (SELECT UID FROM sys.sysusers
										WHERE NAME = @tenUser))
END


GO
/****** Object:  StoredProcedure [dbo].[SP_DangNhapKH]    Script Date: 2023-07-13 02:48:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DangNhapKH]
	@tenLogin nvarchar(50)
AS
BEGIN
	DECLARE @tenUser nvarchar(50)
	SELECT @tenUser = NAME FROM sys.sysusers WHERE sid = SUSER_SID(@tenLogin)
 
	SELECT USERNAME = @tenUser,
		HOTEN = (SELECT HO + ' ' + TEN FROM dbo.KhachHang WHERE CMND = @tenUser),
		TENNHOM = NAME
	FROM sys.sysusers 
	WHERE UID = (SELECT GROUPUID
                 FROM SYS.SYSMEMBERS
					WHERE MEMBERUID = (SELECT UID FROM sys.sysusers
										WHERE NAME = @tenUser))
END


GO
/****** Object:  StoredProcedure [dbo].[SP_GDGoiRut]    Script Date: 2023-07-13 02:48:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GDGoiRut]
	@sotk nvarchar(10),
	@loaigd nvarchar(2),
	@sotien money,
	@manv nvarchar(10)
AS
DECLARE @sodu money = (SELECT SODU FROM TaiKhoan WHERE SOTK = @sotk)
DECLARE @check int = 1

IF NOT EXISTS(SELECT * FROM dbo.TaiKhoan AS TK WHERE TK.SOTK = @sotk)
BEGIN
	SET @check = -1
	SELECT @check
	RETURN
END

IF (@loaigd = 'GT')
BEGIN
	SET XACT_ABORT ON
	BEGIN TRANSACTION
	BEGIN TRY
		INSERT INTO GD_GOIRUT(SOTK, LOAIGD, NGAYGD, SOTIEN, MANV)
			VALUES(@sotk, @loaigd, GETDATE(), @sotien, @manv)
		UPDATE TaiKhoan
			SET SODU = SODU + @sotien
			WHERE SOTK = @sotk
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SET @check = 0
	END CATCH
END
ELSE
BEGIN
	IF (@sotien > @sodu)
		SET @check = 2
	ELSE
	BEGIN
		SET XACT_ABORT ON
		BEGIN TRANSACTION
		BEGIN TRY
			INSERT INTO GD_GOIRUT(SOTK, LOAIGD, NGAYGD, SOTIEN, MANV)
				VALUES(@sotk, @loaigd, GETDATE(), @sotien, @manv)
			UPDATE TaiKhoan
				SET SODU = SODU - @sotien
				WHERE SOTK = @sotk
			COMMIT TRAN
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
			SET @check = 0
		END CATCH
	END
END
SELECT @check


GO
/****** Object:  StoredProcedure [dbo].[SP_GetCNChuyen]    Script Date: 2023-07-13 02:48:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetCNChuyen]
	@macn nvarchar(10)
AS
SELECT MACN, TENCN FROM LINK0.NGANHANG.DBO.ChiNhanh WHERE MACN <> @macn



GO
/****** Object:  StoredProcedure [dbo].[SP_LietKeKhachHang]    Script Date: 2023-07-13 02:48:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_LietKeKhachHang]
AS
SELECT CMND, HOTEN = HO + ' ' + TEN, DIACHI, PHAI, NGAYCAP, SODT
	FROM KhachHang
	ORDER BY TEN, HO


GO
/****** Object:  StoredProcedure [dbo].[SP_LietKeTaiKhoan]    Script Date: 2023-07-13 02:48:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_LietKeTaiKhoan]
	@tungay nvarchar(10),
	@denngay nvarchar(10),
	@all int
AS
SET DATEFORMAT DMY

IF (@all = 0)
SELECT SOTK, NGAYMOTK, TaiKhoan.MACN
	FROM TaiKhoan INNER JOIN ChiNhanh ON TaiKhoan.MACN = ChiNhanh.MACN
	WHERE (NGAYMOTK >= @tungay AND NGAYMOTK < @denngay)
ELSE
SELECT SOTK, NGAYMOTK, TaiKhoan.MACN
	FROM TaiKhoan
	WHERE (NGAYMOTK >= @tungay AND NGAYMOTK < @denngay)

GO
/****** Object:  StoredProcedure [dbo].[SP_MoTaiKhoan]    Script Date: 2023-07-13 02:48:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_MoTaiKhoan] @soTK NCHAR(9), @cmnd NVARCHAR(10),
	@macn NVARCHAR(10), @ngayMoTK DATETIME
AS
BEGIN

INSERT INTO TaiKhoan(SOTK, CMND, SODU, MACN, NGAYMOTK) VALUES (@soTK,@cmnd, 0, @macn, @ngayMoTK);
END
GO
/****** Object:  StoredProcedure [dbo].[SP_SaoKeGD]    Script Date: 2023-07-13 02:48:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_SaoKeGD]
	@tungay nvarchar(10),
	@denngay nvarchar(10),
	@sotk nvarchar(10)
AS
SET DATEFORMAT DMY

DECLARE @sodudau money = (SELECT SODU FROM TaiKhoan WHERE SOTK = @sotk)
DECLARE @ngaygd datetime, @loaigd nvarchar(2), @sotien money, @macn nvarchar(10)

DECLARE cursorGD CURSOR FOR
SELECT NGAYGD, LOAIGD, SOTIEN
	FROM GD_GOIRUT INNER JOIN NhanVien ON GD_GOIRUT.MANV = NhanVien.MANV
	WHERE SOTK = @sotk AND NGAYGD >= @tungay
UNION ALL
SELECT NGAYGD, LOAIGD = 'CT', SOTIEN
	FROM GD_CHUYENTIEN INNER JOIN NhanVien ON GD_CHUYENTIEN.MANV = NhanVien.MANV
	WHERE SOTK_CHUYEN = @sotk AND NGAYGD >= @tungay
UNION ALL
SELECT NGAYGD, LOAIGD, SOTIEN
	FROM LINK0.NGANHANG.DBO.GD_GOIRUT INNER JOIN LINK0.NGANHANG.DBO.NhanVien ON GD_GOIRUT.MANV = NhanVien.MANV
	WHERE SOTK = @sotk AND NGAYGD >= @tungay AND MACN <> (SELECT TOP 1 MACN FROM NhanVien)
UNION ALL
SELECT NGAYGD, LOAIGD = 'CT', SOTIEN
	FROM LINK0.NGANHANG.DBO.GD_CHUYENTIEN INNER JOIN LINK0.NGANHANG.DBO.NhanVien ON GD_CHUYENTIEN.MANV = NhanVien.MANV
	WHERE SOTK_CHUYEN = @sotk AND NGAYGD >= @tungay AND MACN <> (SELECT TOP 1 MACN FROM NhanVien)
--ORDER BY NGAYGD DESC
OPEN cursorGD
FETCH NEXT FROM cursorGD
	INTO @ngaygd, @loaigd, @sotien
WHILE @@FETCH_STATUS = 0
BEGIN
	IF @loaigd = 'GT'
		SET @sodudau -= @sotien
	ELSE
		SET @sodudau += @sotien

	FETCH NEXT FROM cursorGD
		INTO @ngaygd, @loaigd, @sotien
END
CLOSE cursorGD
DEALLOCATE cursorGD

CREATE TABLE #TAM (
	SODUDAU money,
	NGAYGD datetime,
	LOAIGD nvarchar(2),
	SOTIEN money,
	SODUSAU money,
	MACN nvarchar(10)
)

DECLARE cursorSaoKe CURSOR FOR
SELECT NGAYGD, LOAIGD, SOTIEN, MACN
	FROM GD_GOIRUT INNER JOIN NhanVien ON GD_GOIRUT.MANV = NhanVien.MANV
	WHERE SOTK = @sotk AND (NGAYGD >= @tungay AND NGAYGD < @denngay)
UNION ALL
SELECT NGAYGD, LOAIGD = 'CT', SOTIEN, MACN
	FROM GD_CHUYENTIEN INNER JOIN NhanVien ON GD_CHUYENTIEN.MANV = NhanVien.MANV
	WHERE SOTK_CHUYEN = @sotk AND (NGAYGD >= @tungay AND NGAYGD < @denngay)
UNION ALL
SELECT NGAYGD, LOAIGD, SOTIEN, MACN
	FROM LINK0.NGANHANG.DBO.GD_GOIRUT INNER JOIN LINK0.NGANHANG.DBO.NhanVien ON GD_GOIRUT.MANV = NhanVien.MANV
	WHERE SOTK = @sotk AND (NGAYGD >= @tungay AND NGAYGD < @denngay) AND MACN <> (SELECT TOP 1 MACN FROM NhanVien)
UNION ALL
SELECT NGAYGD, LOAIGD = 'CT', SOTIEN, MACN
	FROM LINK0.NGANHANG.DBO.GD_CHUYENTIEN INNER JOIN LINK0.NGANHANG.DBO.NhanVien ON GD_CHUYENTIEN.MANV = NhanVien.MANV
	WHERE SOTK_CHUYEN = @sotk AND (NGAYGD >= @tungay AND NGAYGD < @denngay) AND MACN <> (SELECT TOP 1 MACN FROM NhanVien)
ORDER BY NGAYGD
OPEN cursorSaoKe
FETCH NEXT FROM cursorSaoKe
	INTO @ngaygd, @loaigd, @sotien, @macn
WHILE @@FETCH_STATUS = 0
BEGIN
	IF @loaigd = 'GT'
	BEGIN
		INSERT INTO #TAM
			SELECT @sodudau, @ngaygd, @loaigd, @sotien, @sodudau + @sotien, @macn
		SET @sodudau += @sotien
	END
	ELSE
	BEGIN
		INSERT INTO #TAM
			SELECT @sodudau, @ngaygd, @loaigd, @sotien, @sodudau - @sotien, @macn
		SET @sodudau -= @sotien
	END

	FETCH NEXT FROM cursorSaoKe
		INTO @ngaygd, @loaigd, @sotien, @macn
END
CLOSE cursorSaoKe
DEALLOCATE cursorSaoKe

SELECT * FROM #TAM


GO
/****** Object:  StoredProcedure [dbo].[SP_TaoTaiKhoan]    Script Date: 2023-07-13 02:48:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_TaoTaiKhoan]
	@LGNAME nvarchar(10),
	@PASS nvarchar(20),
	@USERNAME nvarchar(10),
	@ROLE nvarchar(20)
AS
BEGIN
DECLARE @check int = 0
	DECLARE @RET INT

	EXEC @RET = SP_ADDLOGIN @LGNAME, @PASS, 'NGANHANG'                     
	IF (@RET = 1)	--	LOGIN NAME BI TRUNG
	BEGIN
		SET @check = 1
		SELECT @check
		RETURN 1
	END

	EXEC @RET = SP_GRANTDBACCESS @LGNAME, @USERNAME
	IF (@RET = 1)	--	USER NAME BI TRUNG
	BEGIN
		EXEC SP_DROPLOGIN @LGNAME
		SET @check = 2
		SELECT @check
		RETURN 2
	END

	EXEC sp_addrolemember @ROLE, @USERNAME

	EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
SELECT @check
END

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'‘GT’ : gởi tiền vào TK , ‘RT’ : rút tiền khỏi TK' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'GD_GOIRUT', @level2type=N'COLUMN',@level2name=N'LOAIGD'
GO
