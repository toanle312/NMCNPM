USE [master]
GO
/****** Object:  Database [QLKHACHSAN]    Script Date: 12/12/2022 3:43:00 PM ******/
CREATE DATABASE [QLKHACHSAN]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLKHACHSAN', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLKHACHSAN.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLKHACHSAN_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQLDATA\QLKHACHSAN_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QLKHACHSAN] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLKHACHSAN].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLKHACHSAN] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLKHACHSAN] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLKHACHSAN] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLKHACHSAN] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLKHACHSAN] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLKHACHSAN] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLKHACHSAN] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLKHACHSAN] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLKHACHSAN] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLKHACHSAN] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLKHACHSAN] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLKHACHSAN] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLKHACHSAN] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLKHACHSAN] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLKHACHSAN] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLKHACHSAN] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLKHACHSAN] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLKHACHSAN] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLKHACHSAN] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLKHACHSAN] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLKHACHSAN] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLKHACHSAN] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLKHACHSAN] SET RECOVERY FULL 
GO
ALTER DATABASE [QLKHACHSAN] SET  MULTI_USER 
GO
ALTER DATABASE [QLKHACHSAN] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLKHACHSAN] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLKHACHSAN] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLKHACHSAN] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLKHACHSAN] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLKHACHSAN] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLKHACHSAN', N'ON'
GO
ALTER DATABASE [QLKHACHSAN] SET QUERY_STORE = OFF
GO
USE [QLKHACHSAN]
GO
/****** Object:  UserDefinedFunction [dbo].[f_TongTien]    Script Date: 12/12/2022 3:43:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[f_TongTien] (@mahd NCHAR(10))
RETURNS FLOAT
AS
BEGIN
declare @tongtien float
	SELECT @tongtien=h.DonGiaPhong+h.DonGiaDichVu FROM HOADON h WHERE h.MaHD=@mahd
	RETURN @tongtien
END
GO
/****** Object:  Table [dbo].[CHITIETHOADONDICHVU]    Script Date: 12/12/2022 3:43:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETHOADONDICHVU](
	[STT] [char](2) NOT NULL,
	[MaHD] [nchar](10) NOT NULL,
	[ThanhTien] [money] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[TenDV] [nvarchar](20) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHITIETHOADONPHONG]    Script Date: 12/12/2022 3:43:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETHOADONPHONG](
	[STT] [char](2) NOT NULL,
	[MaHD] [nchar](10) NOT NULL,
	[ThanhTien] [money] NOT NULL,
	[MaPhong] [nchar](5) NOT NULL,
	[MaPhieu] [nchar](10) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DICHVU]    Script Date: 12/12/2022 3:43:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DICHVU](
	[TenDV] [nvarchar](20) NOT NULL,
	[HinhMinhHoa] [char](20) NULL,
	[DonGia] [money] NOT NULL,
	[GhiChu] [nvarchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DOANHTHU]    Script Date: 12/12/2022 3:43:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOANHTHU](
	[Thang] [nchar](10) NOT NULL,
	[LoaiPhong] [nchar](5) NOT NULL,
	[DoanhThu] [money] NULL,
	[MaNV] [nchar](10) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 12/12/2022 3:43:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MaHD] [nchar](10) NOT NULL,
	[DonGiaPhong] [money] NOT NULL,
	[DonGiaDichVu] [money] NOT NULL,
	[Ngay] [date] NULL,
	[MaNV] [nchar](10) NOT NULL,
	[CMND] [nchar](10) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 12/12/2022 3:43:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[CMND] [nchar](10) NOT NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [char](11) NOT NULL,
	[QuocTich] [nvarchar](20) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAIPHONG]    Script Date: 12/12/2022 3:43:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIPHONG](
	[LoaiPhong] [nchar](5) NOT NULL,
	[DonGia] [money] NOT NULL,
	[MoTa] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MATDOSUDUNG]    Script Date: 12/12/2022 3:43:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MATDOSUDUNG](
	[MaPhong] [nchar](5) NOT NULL,
	[Thang] [nchar](10) NOT NULL,
	[MatDoSuDung] [int] NULL,
	[MaNV] [nchar](10) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 12/12/2022 3:43:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [nchar](10) NOT NULL,
	[GioiTinh] [nvarchar](10) NOT NULL,
	[CMND/CCCD] [nchar](15) NULL,
	[HoTen] [nvarchar](20) NOT NULL,
	[DiaChi] [nchar](50) NULL,
	[DienThoai] [char](11) NOT NULL,
	[MaTK] [nchar](20) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUTHUEPHONG]    Script Date: 12/12/2022 3:43:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUTHUEPHONG](
	[MaPhieu] [nchar](10) NOT NULL,
	[NgayLap] [date] NOT NULL,
	[CMND] [nchar](10) NOT NULL,
	[MaNV] [nchar](10) NOT NULL,
	[SoNguoi] [int] NULL,
	[NgoaiQuoc] [nvarchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHONG]    Script Date: 12/12/2022 3:43:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONG](
	[MaPhong] [nchar](5) NOT NULL,
	[TrangThai] [nvarchar](20) NOT NULL,
	[LoaiPhong] [nchar](5) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QUANLY]    Script Date: 12/12/2022 3:43:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUANLY](
	[MaQL] [nchar](10) NOT NULL,
	[CMND/CCCD] [nchar](15) NOT NULL,
	[GioiTinh] [nvarchar](10) NOT NULL,
	[HoTen] [nvarchar](20) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[DienThoai] [char](11) NOT NULL,
	[MaTK] [nchar](20) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 12/12/2022 3:43:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[MaTK] [nchar](20) NOT NULL,
	[MatKhau] [nchar](50) NULL,
	[EmailXacNhan] [nchar](30) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[CHITIETHOADONDICHVU] ([STT], [MaHD], [ThanhTien], [SoLuong], [TenDV]) VALUES (N'1 ', N'HD001     ', 20000.0000, 2, N'Sting')
INSERT [dbo].[CHITIETHOADONDICHVU] ([STT], [MaHD], [ThanhTien], [SoLuong], [TenDV]) VALUES (N'2 ', N'HD002     ', 50000.0000, 2, N'Cơm chiên')
INSERT [dbo].[CHITIETHOADONDICHVU] ([STT], [MaHD], [ThanhTien], [SoLuong], [TenDV]) VALUES (N'3 ', N'HD003     ', 20000.0000, 1, N'Mì gói 2 trứng')
INSERT [dbo].[CHITIETHOADONDICHVU] ([STT], [MaHD], [ThanhTien], [SoLuong], [TenDV]) VALUES (N'4 ', N'HD004     ', 20000.0000, 1, N'Cà phê đen')
GO
INSERT [dbo].[CHITIETHOADONPHONG] ([STT], [MaHD], [ThanhTien], [MaPhong], [MaPhieu]) VALUES (N'1 ', N'HD001     ', 150000.0000, N'A-1  ', N'P001      ')
INSERT [dbo].[CHITIETHOADONPHONG] ([STT], [MaHD], [ThanhTien], [MaPhong], [MaPhieu]) VALUES (N'2 ', N'HD002     ', 200000.0000, N'C-1  ', N'P005      ')
INSERT [dbo].[CHITIETHOADONPHONG] ([STT], [MaHD], [ThanhTien], [MaPhong], [MaPhieu]) VALUES (N'3 ', N'HD003     ', 200000.0000, N'C-2  ', N'P004      ')
INSERT [dbo].[CHITIETHOADONPHONG] ([STT], [MaHD], [ThanhTien], [MaPhong], [MaPhieu]) VALUES (N'4 ', N'HD004     ', 170000.0000, N'B-1  ', N'P002      ')
INSERT [dbo].[CHITIETHOADONPHONG] ([STT], [MaHD], [ThanhTien], [MaPhong], [MaPhieu]) VALUES (N'5 ', N'HD005     ', 170000.0000, N'B-2  ', N'P003      ')
INSERT [dbo].[CHITIETHOADONPHONG] ([STT], [MaHD], [ThanhTien], [MaPhong], [MaPhieu]) VALUES (N'6 ', N'HD006     ', 150000.0000, N'A-2  ', N'P006      ')
GO
INSERT [dbo].[DICHVU] ([TenDV], [HinhMinhHoa], [DonGia], [GhiChu]) VALUES (N'Sting', NULL, 10000.0000, NULL)
INSERT [dbo].[DICHVU] ([TenDV], [HinhMinhHoa], [DonGia], [GhiChu]) VALUES (N'Pepsi', NULL, 10000.0000, NULL)
INSERT [dbo].[DICHVU] ([TenDV], [HinhMinhHoa], [DonGia], [GhiChu]) VALUES (N'Cà phê đen', NULL, 20000.0000, NULL)
INSERT [dbo].[DICHVU] ([TenDV], [HinhMinhHoa], [DonGia], [GhiChu]) VALUES (N'Cà phê sữa', NULL, 20000.0000, NULL)
INSERT [dbo].[DICHVU] ([TenDV], [HinhMinhHoa], [DonGia], [GhiChu]) VALUES (N'Mì gói 1 trứng', NULL, 15000.0000, NULL)
INSERT [dbo].[DICHVU] ([TenDV], [HinhMinhHoa], [DonGia], [GhiChu]) VALUES (N'Mì gói 2 trứng', NULL, 20000.0000, NULL)
INSERT [dbo].[DICHVU] ([TenDV], [HinhMinhHoa], [DonGia], [GhiChu]) VALUES (N'Cơm chiên', NULL, 25000.0000, NULL)
GO
INSERT [dbo].[HOADON] ([MaHD], [DonGiaPhong], [DonGiaDichVu], [Ngay], [MaNV], [CMND]) VALUES (N'HD001     ', 150000.0000, 20000.0000, CAST(N'2022-12-12' AS Date), N'NV001     ', N'12345     ')
INSERT [dbo].[HOADON] ([MaHD], [DonGiaPhong], [DonGiaDichVu], [Ngay], [MaNV], [CMND]) VALUES (N'HD002     ', 200000.0000, 50000.0000, CAST(N'2022-12-12' AS Date), N'NV001     ', N'12345     ')
INSERT [dbo].[HOADON] ([MaHD], [DonGiaPhong], [DonGiaDichVu], [Ngay], [MaNV], [CMND]) VALUES (N'HD003     ', 20000.0000, 20000.0000, CAST(N'2022-12-12' AS Date), N'NV001     ', N'12346     ')
INSERT [dbo].[HOADON] ([MaHD], [DonGiaPhong], [DonGiaDichVu], [Ngay], [MaNV], [CMND]) VALUES (N'HD004     ', 170000.0000, 20000.0000, CAST(N'2022-12-13' AS Date), N'NV001     ', N'12347     ')
INSERT [dbo].[HOADON] ([MaHD], [DonGiaPhong], [DonGiaDichVu], [Ngay], [MaNV], [CMND]) VALUES (N'HD005     ', 170000.0000, 0.0000, CAST(N'2022-12-12' AS Date), N'NV001     ', N'12348     ')
INSERT [dbo].[HOADON] ([MaHD], [DonGiaPhong], [DonGiaDichVu], [Ngay], [MaNV], [CMND]) VALUES (N'HD006     ', 150000.0000, 0.0000, CAST(N'2022-12-12' AS Date), N'NV002     ', N'12349     ')
GO
INSERT [dbo].[KHACHHANG] ([CMND], [DiaChi], [DienThoai], [QuocTich], [HoTen]) VALUES (N'12345     ', N'Bình Dương', N'023231321  ', N'VietNam', N'Trần Trung Quân')
INSERT [dbo].[KHACHHANG] ([CMND], [DiaChi], [DienThoai], [QuocTich], [HoTen]) VALUES (N'12346     ', N'TP.HCM', N'023123233  ', N'VietNam', N'Nguyễn Văn Cường')
INSERT [dbo].[KHACHHANG] ([CMND], [DiaChi], [DienThoai], [QuocTich], [HoTen]) VALUES (N'12347     ', N'Bình Phước', N'023132133  ', N'VietNam', N'Nguyễn Quốc Cường')
INSERT [dbo].[KHACHHANG] ([CMND], [DiaChi], [DienThoai], [QuocTich], [HoTen]) VALUES (N'12348     ', N'TP.HCM', N'032123233  ', N'VietNam', N'Nguyễn Hoàng Hải')
INSERT [dbo].[KHACHHANG] ([CMND], [DiaChi], [DienThoai], [QuocTich], [HoTen]) VALUES (N'12349     ', N'TP.HCM', N'023836466  ', N'America', N'Adam Smith')
GO
INSERT [dbo].[LOAIPHONG] ([LoaiPhong], [DonGia], [MoTa]) VALUES (N'A    ', 150000.0000, N'Phòng không có điều hoà')
INSERT [dbo].[LOAIPHONG] ([LoaiPhong], [DonGia], [MoTa]) VALUES (N'B    ', 170000.0000, N'Phòng hạng trung')
INSERT [dbo].[LOAIPHONG] ([LoaiPhong], [DonGia], [MoTa]) VALUES (N'C    ', 200000.0000, N'Phòng vip')
GO
INSERT [dbo].[NHANVIEN] ([MaNV], [GioiTinh], [CMND/CCCD], [HoTen], [DiaChi], [DienThoai], [MaTK]) VALUES (N'NV001     ', N'Nam', N'12345          ', N'Nguyễn Văn A', N'A                                TP.HCM           ', N'01114282761', N'staff001            ')
INSERT [dbo].[NHANVIEN] ([MaNV], [GioiTinh], [CMND/CCCD], [HoTen], [DiaChi], [DienThoai], [MaTK]) VALUES (N'NV002     ', N'Nam', N'12343          ', N'b', N'a                                                 ', N'2          ', N'124                 ')
GO
INSERT [dbo].[PHIEUTHUEPHONG] ([MaPhieu], [NgayLap], [CMND], [MaNV], [SoNguoi], [NgoaiQuoc]) VALUES (N'P001      ', CAST(N'2022-12-12' AS Date), N'12345     ', N'NV001     ', 2, N'Không')
INSERT [dbo].[PHIEUTHUEPHONG] ([MaPhieu], [NgayLap], [CMND], [MaNV], [SoNguoi], [NgoaiQuoc]) VALUES (N'P002      ', CAST(N'2022-12-11' AS Date), N'12346     ', N'NV001     ', 1, N'Không')
INSERT [dbo].[PHIEUTHUEPHONG] ([MaPhieu], [NgayLap], [CMND], [MaNV], [SoNguoi], [NgoaiQuoc]) VALUES (N'P003      ', CAST(N'2022-11-11' AS Date), N'12347     ', N'NV001     ', 3, N'Không')
INSERT [dbo].[PHIEUTHUEPHONG] ([MaPhieu], [NgayLap], [CMND], [MaNV], [SoNguoi], [NgoaiQuoc]) VALUES (N'P004      ', CAST(N'2022-12-10' AS Date), N'12348     ', N'NV001     ', 1, N'Không')
INSERT [dbo].[PHIEUTHUEPHONG] ([MaPhieu], [NgayLap], [CMND], [MaNV], [SoNguoi], [NgoaiQuoc]) VALUES (N'P005      ', CAST(N'2022-12-09' AS Date), N'12349     ', N'NV002     ', 1, N'Có')
INSERT [dbo].[PHIEUTHUEPHONG] ([MaPhieu], [NgayLap], [CMND], [MaNV], [SoNguoi], [NgoaiQuoc]) VALUES (N'P006      ', CAST(N'2022-12-12' AS Date), N'12347     ', N'NV001     ', 1, N'Không')
GO
INSERT [dbo].[PHONG] ([MaPhong], [TrangThai], [LoaiPhong]) VALUES (N'A-1  ', N'Trống', N'A    ')
INSERT [dbo].[PHONG] ([MaPhong], [TrangThai], [LoaiPhong]) VALUES (N'A-2  ', N'Đang sử dụng', N'A    ')
INSERT [dbo].[PHONG] ([MaPhong], [TrangThai], [LoaiPhong]) VALUES (N'A-3  ', N'Trống', N'A    ')
INSERT [dbo].[PHONG] ([MaPhong], [TrangThai], [LoaiPhong]) VALUES (N'B-1  ', N'Trống', N'B    ')
INSERT [dbo].[PHONG] ([MaPhong], [TrangThai], [LoaiPhong]) VALUES (N'B-2  ', N'Trống', N'B    ')
INSERT [dbo].[PHONG] ([MaPhong], [TrangThai], [LoaiPhong]) VALUES (N'B-3  ', N'Sử dụng', N'B    ')
INSERT [dbo].[PHONG] ([MaPhong], [TrangThai], [LoaiPhong]) VALUES (N'C-1  ', N'Sử dụng', N'C    ')
INSERT [dbo].[PHONG] ([MaPhong], [TrangThai], [LoaiPhong]) VALUES (N'C-2  ', N'Sử dụng', N'C    ')
INSERT [dbo].[PHONG] ([MaPhong], [TrangThai], [LoaiPhong]) VALUES (N'C-3  ', N'Bảo trì', N'C    ')
GO
INSERT [dbo].[QUANLY] ([MaQL], [CMND/CCCD], [GioiTinh], [HoTen], [DiaChi], [DienThoai], [MaTK]) VALUES (N'QL001     ', N'1421412        ', N'Nam', N'Nguyễn Văn B', N'TP.HCM', N'0555213815 ', N'admin001            ')
GO
INSERT [dbo].[TAIKHOAN] ([MaTK], [MatKhau], [EmailXacNhan]) VALUES (N'123                 ', N'21232f297a57a5a743894a0e4a801fc3                  ', N'a                             ')
INSERT [dbo].[TAIKHOAN] ([MaTK], [MatKhau], [EmailXacNhan]) VALUES (N'124                 ', N'123                                               ', N'a                             ')
INSERT [dbo].[TAIKHOAN] ([MaTK], [MatKhau], [EmailXacNhan]) VALUES (N'admin001            ', N'21232f297a57a5a743894a0e4a801fc3                  ', N'admin001@gmail.com            ')
INSERT [dbo].[TAIKHOAN] ([MaTK], [MatKhau], [EmailXacNhan]) VALUES (N'staff001            ', N'1253208465b1efa876f982d8a9e73eef                  ', N'staff001@gmail.com            ')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK10]    Script Date: 12/12/2022 3:43:00 PM ******/
ALTER TABLE [dbo].[CHITIETHOADONDICHVU] ADD  CONSTRAINT [PK10] PRIMARY KEY NONCLUSTERED 
(
	[STT] ASC,
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK7]    Script Date: 12/12/2022 3:43:00 PM ******/
ALTER TABLE [dbo].[CHITIETHOADONPHONG] ADD  CONSTRAINT [PK7] PRIMARY KEY NONCLUSTERED 
(
	[STT] ASC,
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK6]    Script Date: 12/12/2022 3:43:00 PM ******/
ALTER TABLE [dbo].[DICHVU] ADD  CONSTRAINT [PK6] PRIMARY KEY NONCLUSTERED 
(
	[TenDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK13]    Script Date: 12/12/2022 3:43:00 PM ******/
ALTER TABLE [dbo].[DOANHTHU] ADD  CONSTRAINT [PK13] PRIMARY KEY NONCLUSTERED 
(
	[Thang] ASC,
	[LoaiPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK5]    Script Date: 12/12/2022 3:43:00 PM ******/
ALTER TABLE [dbo].[HOADON] ADD  CONSTRAINT [PK5] PRIMARY KEY NONCLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK1]    Script Date: 12/12/2022 3:43:00 PM ******/
ALTER TABLE [dbo].[KHACHHANG] ADD  CONSTRAINT [PK1] PRIMARY KEY NONCLUSTERED 
(
	[CMND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK14]    Script Date: 12/12/2022 3:43:00 PM ******/
ALTER TABLE [dbo].[LOAIPHONG] ADD  CONSTRAINT [PK14] PRIMARY KEY NONCLUSTERED 
(
	[LoaiPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK12]    Script Date: 12/12/2022 3:43:00 PM ******/
ALTER TABLE [dbo].[MATDOSUDUNG] ADD  CONSTRAINT [PK12] PRIMARY KEY NONCLUSTERED 
(
	[MaPhong] ASC,
	[Thang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK2]    Script Date: 12/12/2022 3:43:00 PM ******/
ALTER TABLE [dbo].[NHANVIEN] ADD  CONSTRAINT [PK2] PRIMARY KEY NONCLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK3]    Script Date: 12/12/2022 3:43:00 PM ******/
ALTER TABLE [dbo].[PHIEUTHUEPHONG] ADD  CONSTRAINT [PK3] PRIMARY KEY NONCLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK4]    Script Date: 12/12/2022 3:43:00 PM ******/
ALTER TABLE [dbo].[PHONG] ADD  CONSTRAINT [PK4] PRIMARY KEY NONCLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK8]    Script Date: 12/12/2022 3:43:00 PM ******/
ALTER TABLE [dbo].[QUANLY] ADD  CONSTRAINT [PK8] PRIMARY KEY NONCLUSTERED 
(
	[MaQL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK9]    Script Date: 12/12/2022 3:43:00 PM ******/
ALTER TABLE [dbo].[TAIKHOAN] ADD  CONSTRAINT [PK9] PRIMARY KEY NONCLUSTERED 
(
	[MaTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CHITIETHOADONDICHVU]  WITH CHECK ADD  CONSTRAINT [RefDICHVU14] FOREIGN KEY([TenDV])
REFERENCES [dbo].[DICHVU] ([TenDV])
GO
ALTER TABLE [dbo].[CHITIETHOADONDICHVU] CHECK CONSTRAINT [RefDICHVU14]
GO
ALTER TABLE [dbo].[CHITIETHOADONDICHVU]  WITH CHECK ADD  CONSTRAINT [RefHOADON7] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HOADON] ([MaHD])
GO
ALTER TABLE [dbo].[CHITIETHOADONDICHVU] CHECK CONSTRAINT [RefHOADON7]
GO
ALTER TABLE [dbo].[CHITIETHOADONPHONG]  WITH CHECK ADD  CONSTRAINT [RefHOADON6] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HOADON] ([MaHD])
GO
ALTER TABLE [dbo].[CHITIETHOADONPHONG] CHECK CONSTRAINT [RefHOADON6]
GO
ALTER TABLE [dbo].[CHITIETHOADONPHONG]  WITH CHECK ADD  CONSTRAINT [RefPHIEUTHUEPHONG16] FOREIGN KEY([MaPhieu])
REFERENCES [dbo].[PHIEUTHUEPHONG] ([MaPhieu])
GO
ALTER TABLE [dbo].[CHITIETHOADONPHONG] CHECK CONSTRAINT [RefPHIEUTHUEPHONG16]
GO
ALTER TABLE [dbo].[CHITIETHOADONPHONG]  WITH CHECK ADD  CONSTRAINT [RefPHONG9] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[PHONG] ([MaPhong])
GO
ALTER TABLE [dbo].[CHITIETHOADONPHONG] CHECK CONSTRAINT [RefPHONG9]
GO
ALTER TABLE [dbo].[DOANHTHU]  WITH CHECK ADD  CONSTRAINT [RefLOAIPHONG20] FOREIGN KEY([LoaiPhong])
REFERENCES [dbo].[LOAIPHONG] ([LoaiPhong])
GO
ALTER TABLE [dbo].[DOANHTHU] CHECK CONSTRAINT [RefLOAIPHONG20]
GO
ALTER TABLE [dbo].[DOANHTHU]  WITH CHECK ADD  CONSTRAINT [RefNHANVIEN22] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[DOANHTHU] CHECK CONSTRAINT [RefNHANVIEN22]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [RefKHACHHANG11] FOREIGN KEY([CMND])
REFERENCES [dbo].[KHACHHANG] ([CMND])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [RefKHACHHANG11]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [RefNHANVIEN10] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [RefNHANVIEN10]
GO
ALTER TABLE [dbo].[MATDOSUDUNG]  WITH CHECK ADD  CONSTRAINT [RefNHANVIEN21] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[MATDOSUDUNG] CHECK CONSTRAINT [RefNHANVIEN21]
GO
ALTER TABLE [dbo].[MATDOSUDUNG]  WITH CHECK ADD  CONSTRAINT [RefPHONG18] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[PHONG] ([MaPhong])
GO
ALTER TABLE [dbo].[MATDOSUDUNG] CHECK CONSTRAINT [RefPHONG18]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [RefTAIKHOAN4] FOREIGN KEY([MaTK])
REFERENCES [dbo].[TAIKHOAN] ([MaTK])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [RefTAIKHOAN4]
GO
ALTER TABLE [dbo].[PHIEUTHUEPHONG]  WITH CHECK ADD  CONSTRAINT [RefKHACHHANG12] FOREIGN KEY([CMND])
REFERENCES [dbo].[KHACHHANG] ([CMND])
GO
ALTER TABLE [dbo].[PHIEUTHUEPHONG] CHECK CONSTRAINT [RefKHACHHANG12]
GO
ALTER TABLE [dbo].[PHIEUTHUEPHONG]  WITH CHECK ADD  CONSTRAINT [RefNHANVIEN13] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUTHUEPHONG] CHECK CONSTRAINT [RefNHANVIEN13]
GO
ALTER TABLE [dbo].[PHONG]  WITH CHECK ADD  CONSTRAINT [RefLOAIPHONG19] FOREIGN KEY([LoaiPhong])
REFERENCES [dbo].[LOAIPHONG] ([LoaiPhong])
GO
ALTER TABLE [dbo].[PHONG] CHECK CONSTRAINT [RefLOAIPHONG19]
GO
ALTER TABLE [dbo].[QUANLY]  WITH CHECK ADD  CONSTRAINT [RefTAIKHOAN3] FOREIGN KEY([MaTK])
REFERENCES [dbo].[TAIKHOAN] ([MaTK])
GO
ALTER TABLE [dbo].[QUANLY] CHECK CONSTRAINT [RefTAIKHOAN3]
GO
/****** Object:  StoredProcedure [dbo].[sp_ChitietHoaDon]    Script Date: 12/12/2022 3:43:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ChitietHoaDon] @mahd nCHAR(10)
AS
BEGIN
SELECT * FROM CHITIETHOADONPHONG c WHERE c.MaHD=@mahd
END

GO
/****** Object:  StoredProcedure [dbo].[sp_ChiTietHoaDonDichVu]    Script Date: 12/12/2022 3:43:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ChiTietHoaDonDichVu] @mahd nCHAR(10)
AS
BEGIN
	SELECT * FROM CHITIETHOADONDICHVU c WHERE c.MaHD=@mahd
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Ds_HoaDonPhong]    Script Date: 12/12/2022 3:43:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Ds_HoaDonPhong]
as
BEGIN 
SELECT h.MaHD, h.Ngay,k.HoTen,h.CMND FROM HOADON h,KHACHHANG k 
			WHERE k.CMND=h.CMND
END
GO
/****** Object:  StoredProcedure [dbo].[sp_LapHoaDon]    Script Date: 12/12/2022 3:43:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_LapHoaDon] @makh CHAR(10)
AS
BEGIN
	RETURN SELECT c.MaPhong,DATEDIFF(DAY,GETDATE(),P.NgayLap) AS SoNgayThue,c.DonGia,DATEDIFF(DAY,GETDATE(),P.NgayLap)*c.DonGia*P.HeSo AS DonGia FROM HOADON h, CHITIETHOADONPHONG c, PHIEUTHUEPHONG p
	WHERE h.MaHD=c.MaHD AND c.MaPhieu=p.MaPhieu
END
GO
/****** Object:  StoredProcedure [dbo].[sp_LapHoaDonDV]    Script Date: 12/12/2022 3:43:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_LapHoaDonDV] @mahd CHAR(10)
AS
BEGIN
	RETURN SELECT D.TenDV,c.SoLuong,c.DonGia,c.DonGia*c.SoLuong AS ThanhTien FROM CHITIETHOADONDICHVU c, DICHVU d
	WHERE c.MaHD=@mahd AND c.TenDV=d.TenDV
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Xoa_HoaDon]    Script Date: 12/12/2022 3:43:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Xoa_HoaDon] @mahd NCHAR(10)
AS
BEGIN
DELETE FROM CHITIETHOADONPHONG WHERE MaHD=@mahd
DELETE FROM CHITIETHOADONDICHVU WHERE MaHD=@mahd
DELETE FROM HOADON WHERE MaHD=@mahd
END
GO
USE [master]
GO
ALTER DATABASE [QLKHACHSAN] SET  READ_WRITE 
GO


create proc proc_get_account
@user nchar(20)
as
begin
	select * from TAIKHOAN where MaTK = @user
end

go

CREATE proc [dbo].[proc_update_info_admin]
@MaNV nchar(10),
@HoTen nchar(20),
@DiaChi nchar(50),
@CCCD nchar(15),
@DienThoai char(11)
as
begin
	update QUANLY 
	set HoTen = @HoTen,
	DiaChi = @DiaChi,
	[CMND/CCCD] = @CCCD,
	DienThoai = @DienThoai
	where MaQL = @MaNV
end

go

CREATE proc [dbo].[proc_update_info]
@MaNV nchar(10),
@HoTen nchar(20),
@DiaChi nchar(50),
@CCCD nchar(15),
@DienThoai char(11)
as
begin
	update NHANVIEN 
	set HoTen = @HoTen,
	DiaChi = @DiaChi,
	[CMND/CCCD] = @CCCD,
	DienThoai = @DienThoai
	where MaNV = @MaNV
end

go

CREATE proc [dbo].[proc_login]
@user nchar(20),
@pass nchar(50)
as
begin
	select * from TAIKHOAN where MaTK = @user and MatKhau = @pass
end

go

create proc proc_load_info_admin
@MaTK nchar(20)
as
begin
	select * from QUANLY where MaTK = @MaTK
end

go

create proc proc_load_info
@MaTK nchar(20)
as
begin
	select * from NHANVIEN where MaTK = @MaTK
end


CREATE PROCEDURE [dbo].[GetFullCustomer]
AS
BEGIN
	SELECT * FROM dbo.KHACHHANG
END

CREATE PROCEDURE [dbo].[UpdateStaff]
	@MaNV nchar(10), 
	@HoTen nvarchar(20), 
	@CMND nchar(15), 
	@GioiTinh nvarchar(10),
	@DiaChi nchar(50), 
	@DienThoai char(11)
AS
BEGIN 
	UPDATE NHANVIEN
	SET 
		HoTen = @HoTen,
		[CMND/CCCD] = @CMND,
		GioiTinh = @GioiTinh,
		DiaChi = @DiaChi
	WHERE MaNV = @MaNV
END

CREATE PROCEDURE [dbo].[UpdateInforCus] 
	@cmnd nchar(10),
	@HoTen nvarchar(50),
	@QuocTich  nvarchar(20),
	@DiaChi nvarchar(50),
	@DienThoai char(11)
AS
BEGIN
	UPDATE KHACHHANG 
	SET 
		HoTen = @HoTen,
		QuocTich = @QuocTich,
		DiaChi = @DiaChi,
		DienThoai = @DienThoai
	WHERE 
		CMND = @cmnd
	if @@ROWCOUNT > 0 return 1
	else return 0;
END

CREATE PROCEDURE [dbo].[InsertStaff]
	@MaNV nchar(10), 
	@HoTen nvarchar(20), 
	@CMND nchar(15), 
	@GioiTinh nvarchar(10),
	@DiaChi nchar(50), 
	@DienThoai char(11), 
	@MaTK nchar(20)
AS
BEGIN
	INSERT INTO dbo.TAIKHOAN(MaTK, EmailXacNhan) VALUES (@MaTK, @MaTK);
	INSERT INTO dbo.NHANVIEN VALUES (@MaNV, @GioiTinh, @CMND, @HoTen, @DiaChi, @DienThoai, @MaTK);
END

CREATE PROCEDURE [dbo].[InsertCustomer]
	@cmnd nchar(10),
	@HoTen nvarchar(50),
	@QuocTich  nvarchar(20),
	@DiaChi nvarchar(50),
	@DienThoai char(11)
AS
BEGIN
	INSERT INTO KHACHHANG VALUES(@cmnd,@DiaChi,@DienThoai,@QuocTich,@HoTen);
	if (@@ROWCOUNT > 0) return 1;
	else return 0;
END

CREATE PROCEDURE [dbo].[GetInforCusByCMND] @cmnd nCHAR(10)
AS
BEGIN
	SELECT * FROM KHACHHANG KH WHERE KH.CMND = @cmnd
END

CREATE PROCEDURE [dbo].[GetInforByMaNV]
	@MaNV nchar(10)
AS
BEGIN
	SELECT * FROM NHANVIEN WHERE MaNV = @MaNV
END

CREATE PROCEDURE [dbo].[GetFullStaff]
AS
BEGIN
	SELECT * FROM dbo.NHANVIEN
END

CREATE PROCEDURE [dbo].[DeleteStaff]
	@MaNV nchar(10),
	@MaTK nchar(20)
AS
BEGIN
	DELETE FROM NHANVIEN WHERE MaNV = @MaNV
	DELETE FROM TAIKHOAN WHERE MaTK = @MaTK
END

CREATE PROCEDURE [dbo].[DeleteCustomer]
	@cmnd nCHAR(10)
AS
BEGIN
	DELETE FROM KHACHHANG WHERE CMND = @cmnd
END