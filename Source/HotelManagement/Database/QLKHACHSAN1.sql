USE [master]
GO
/****** Object:  Database [QLKHACHSAN1]    Script Date: 1/9/2023 9:19:53 AM ******/
CREATE DATABASE [QLKHACHSAN1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLKHACHSAN1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QLKHACHSAN1.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLKHACHSAN1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QLKHACHSAN1_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QLKHACHSAN1] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLKHACHSAN1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLKHACHSAN1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLKHACHSAN1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLKHACHSAN1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLKHACHSAN1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLKHACHSAN1] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLKHACHSAN1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLKHACHSAN1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLKHACHSAN1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLKHACHSAN1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLKHACHSAN1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLKHACHSAN1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLKHACHSAN1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLKHACHSAN1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLKHACHSAN1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLKHACHSAN1] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLKHACHSAN1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLKHACHSAN1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLKHACHSAN1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLKHACHSAN1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLKHACHSAN1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLKHACHSAN1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLKHACHSAN1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLKHACHSAN1] SET RECOVERY FULL 
GO
ALTER DATABASE [QLKHACHSAN1] SET  MULTI_USER 
GO
ALTER DATABASE [QLKHACHSAN1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLKHACHSAN1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLKHACHSAN1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLKHACHSAN1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLKHACHSAN1] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLKHACHSAN1] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QLKHACHSAN1] SET QUERY_STORE = OFF
GO
USE [QLKHACHSAN1]
GO
/****** Object:  UserDefinedFunction [dbo].[f_TongTien]    Script Date: 1/9/2023 9:19:53 AM ******/
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
/****** Object:  Table [dbo].[CHITIETHOADONDICHVU]    Script Date: 1/9/2023 9:19:53 AM ******/
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
/****** Object:  Table [dbo].[CHITIETHOADONPHONG]    Script Date: 1/9/2023 9:19:53 AM ******/
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
/****** Object:  Table [dbo].[DICHVU]    Script Date: 1/9/2023 9:19:53 AM ******/
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
/****** Object:  Table [dbo].[DOANHTHU]    Script Date: 1/9/2023 9:19:53 AM ******/
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
/****** Object:  Table [dbo].[HOADON]    Script Date: 1/9/2023 9:19:53 AM ******/
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
	[CMND] [nchar](10) NOT NULL,
	[TONGTIEN] [money] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 1/9/2023 9:19:53 AM ******/
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
/****** Object:  Table [dbo].[LOAIPHONG]    Script Date: 1/9/2023 9:19:53 AM ******/
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
/****** Object:  Table [dbo].[MATDOSUDUNG]    Script Date: 1/9/2023 9:19:53 AM ******/
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
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 1/9/2023 9:19:53 AM ******/
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
/****** Object:  Table [dbo].[PHIEUTHUEPHONG]    Script Date: 1/9/2023 9:19:53 AM ******/
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
/****** Object:  Table [dbo].[PHONG]    Script Date: 1/9/2023 9:19:53 AM ******/
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
/****** Object:  Table [dbo].[QUANLY]    Script Date: 1/9/2023 9:19:53 AM ******/
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
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 1/9/2023 9:19:53 AM ******/
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
INSERT [dbo].[CHITIETHOADONDICHVU] ([STT], [MaHD], [ThanhTien], [SoLuong], [TenDV]) VALUES (N'2 ', N'HD002     ', 50000.0000, 2, N'Cơm chiên')
INSERT [dbo].[CHITIETHOADONDICHVU] ([STT], [MaHD], [ThanhTien], [SoLuong], [TenDV]) VALUES (N'4 ', N'HD004     ', 20000.0000, 1, N'Cà phê đen')
GO
INSERT [dbo].[CHITIETHOADONPHONG] ([STT], [MaHD], [ThanhTien], [MaPhong], [MaPhieu]) VALUES (N'1 ', N'HD001     ', 150000.0000, N'A-1  ', N'P001      ')
INSERT [dbo].[CHITIETHOADONPHONG] ([STT], [MaHD], [ThanhTien], [MaPhong], [MaPhieu]) VALUES (N'2 ', N'HD002     ', 200000.0000, N'C-1  ', N'P005      ')
INSERT [dbo].[CHITIETHOADONPHONG] ([STT], [MaHD], [ThanhTien], [MaPhong], [MaPhieu]) VALUES (N'3 ', N'HD003     ', 200000.0000, N'C-2  ', N'P004      ')
INSERT [dbo].[CHITIETHOADONPHONG] ([STT], [MaHD], [ThanhTien], [MaPhong], [MaPhieu]) VALUES (N'4 ', N'HD004     ', 170000.0000, N'B-1  ', N'P002      ')
INSERT [dbo].[CHITIETHOADONPHONG] ([STT], [MaHD], [ThanhTien], [MaPhong], [MaPhieu]) VALUES (N'5 ', N'HD005     ', 170000.0000, N'B-2  ', N'P003      ')
INSERT [dbo].[CHITIETHOADONPHONG] ([STT], [MaHD], [ThanhTien], [MaPhong], [MaPhieu]) VALUES (N'6 ', N'HD006     ', 150000.0000, N'A-2  ', N'P006      ')
INSERT [dbo].[CHITIETHOADONPHONG] ([STT], [MaHD], [ThanhTien], [MaPhong], [MaPhieu]) VALUES (N'1 ', N'HD019     ', 300000.0000, N'A-1  ', N'P0010     ')
INSERT [dbo].[CHITIETHOADONPHONG] ([STT], [MaHD], [ThanhTien], [MaPhong], [MaPhieu]) VALUES (N'1 ', N'HD020     ', 4800000.0000, N'A-3  ', N'P0012     ')
INSERT [dbo].[CHITIETHOADONPHONG] ([STT], [MaHD], [ThanhTien], [MaPhong], [MaPhieu]) VALUES (N'1 ', N'HD022     ', 4800000.0000, N'B-1  ', N'P0014     ')
INSERT [dbo].[CHITIETHOADONPHONG] ([STT], [MaHD], [ThanhTien], [MaPhong], [MaPhieu]) VALUES (N'2 ', N'HD019     ', 300000.0000, N'B-2  ', N'P0010     ')
INSERT [dbo].[CHITIETHOADONPHONG] ([STT], [MaHD], [ThanhTien], [MaPhong], [MaPhieu]) VALUES (N'1 ', N'HD010     ', 200000.0000, N'A-3  ', N'P0015     ')
INSERT [dbo].[CHITIETHOADONPHONG] ([STT], [MaHD], [ThanhTien], [MaPhong], [MaPhieu]) VALUES (N'1 ', N'HD011     ', 200000.0000, N'A-3  ', N'P0016     ')
GO
INSERT [dbo].[DICHVU] ([TenDV], [HinhMinhHoa], [DonGia], [GhiChu]) VALUES (N'Sting', NULL, 10000.0000, N'LQ')
INSERT [dbo].[DICHVU] ([TenDV], [HinhMinhHoa], [DonGia], [GhiChu]) VALUES (N'Pepsi', NULL, 10000.0000, N'Không calo')
INSERT [dbo].[DICHVU] ([TenDV], [HinhMinhHoa], [DonGia], [GhiChu]) VALUES (N'Cà phê đen', NULL, 20000.0000, NULL)
INSERT [dbo].[DICHVU] ([TenDV], [HinhMinhHoa], [DonGia], [GhiChu]) VALUES (N'Cà phê sữa', NULL, 20000.0000, NULL)
INSERT [dbo].[DICHVU] ([TenDV], [HinhMinhHoa], [DonGia], [GhiChu]) VALUES (N'Mì gói 1 trứng', NULL, 15000.0000, NULL)
INSERT [dbo].[DICHVU] ([TenDV], [HinhMinhHoa], [DonGia], [GhiChu]) VALUES (N'Cơm chiên', NULL, 25000.0000, NULL)
INSERT [dbo].[DICHVU] ([TenDV], [HinhMinhHoa], [DonGia], [GhiChu]) VALUES (N'Coca', NULL, 10000.0000, N'Zero')
INSERT [dbo].[DICHVU] ([TenDV], [HinhMinhHoa], [DonGia], [GhiChu]) VALUES (N'7up', NULL, 10000.0000, N'')
INSERT [dbo].[DICHVU] ([TenDV], [HinhMinhHoa], [DonGia], [GhiChu]) VALUES (N'RedBull', NULL, 10000.0000, N'')
GO
INSERT [dbo].[HOADON] ([MaHD], [DonGiaPhong], [DonGiaDichVu], [Ngay], [MaNV], [CMND], [TONGTIEN]) VALUES (N'HD001     ', 150000.0000, 0.0000, CAST(N'2022-12-12' AS Date), N'NV001     ', N'12345     ', 150000.0000)
INSERT [dbo].[HOADON] ([MaHD], [DonGiaPhong], [DonGiaDichVu], [Ngay], [MaNV], [CMND], [TONGTIEN]) VALUES (N'HD002     ', 200000.0000, 50000.0000, CAST(N'2022-12-12' AS Date), N'NV001     ', N'12345     ', 250000.0000)
INSERT [dbo].[HOADON] ([MaHD], [DonGiaPhong], [DonGiaDichVu], [Ngay], [MaNV], [CMND], [TONGTIEN]) VALUES (N'HD003     ', 200000.0000, 0.0000, CAST(N'2022-12-12' AS Date), N'NV001     ', N'12346     ', 200000.0000)
INSERT [dbo].[HOADON] ([MaHD], [DonGiaPhong], [DonGiaDichVu], [Ngay], [MaNV], [CMND], [TONGTIEN]) VALUES (N'HD004     ', 170000.0000, 20000.0000, CAST(N'2022-12-13' AS Date), N'NV001     ', N'12347     ', 190000.0000)
INSERT [dbo].[HOADON] ([MaHD], [DonGiaPhong], [DonGiaDichVu], [Ngay], [MaNV], [CMND], [TONGTIEN]) VALUES (N'HD005     ', 170000.0000, 0.0000, CAST(N'2022-12-12' AS Date), N'NV001     ', N'12348     ', 170000.0000)
INSERT [dbo].[HOADON] ([MaHD], [DonGiaPhong], [DonGiaDichVu], [Ngay], [MaNV], [CMND], [TONGTIEN]) VALUES (N'HD006     ', 150000.0000, 0.0000, CAST(N'2022-12-12' AS Date), N'NV002     ', N'12349     ', 150000.0000)
INSERT [dbo].[HOADON] ([MaHD], [DonGiaPhong], [DonGiaDichVu], [Ngay], [MaNV], [CMND], [TONGTIEN]) VALUES (N'HD019     ', 600000.0000, 0.0000, CAST(N'2022-12-25' AS Date), N'NV001     ', N'12349     ', 0.0000)
INSERT [dbo].[HOADON] ([MaHD], [DonGiaPhong], [DonGiaDichVu], [Ngay], [MaNV], [CMND], [TONGTIEN]) VALUES (N'HD020     ', 4800000.0000, 0.0000, CAST(N'2023-01-09' AS Date), N'NV001     ', N'12345     ', 0.0000)
INSERT [dbo].[HOADON] ([MaHD], [DonGiaPhong], [DonGiaDichVu], [Ngay], [MaNV], [CMND], [TONGTIEN]) VALUES (N'HD022     ', 4800000.0000, 0.0000, CAST(N'2023-01-09' AS Date), N'NV001     ', N'12345     ', 0.0000)
INSERT [dbo].[HOADON] ([MaHD], [DonGiaPhong], [DonGiaDichVu], [Ngay], [MaNV], [CMND], [TONGTIEN]) VALUES (N'HD010     ', 200000.0000, 0.0000, CAST(N'2023-01-09' AS Date), N'NV001     ', N'112233    ', 0.0000)
INSERT [dbo].[HOADON] ([MaHD], [DonGiaPhong], [DonGiaDichVu], [Ngay], [MaNV], [CMND], [TONGTIEN]) VALUES (N'HD011     ', 200000.0000, 0.0000, CAST(N'2023-01-09' AS Date), N'NV001     ', N'112233    ', 0.0000)
GO
INSERT [dbo].[KHACHHANG] ([CMND], [DiaChi], [DienThoai], [QuocTich], [HoTen]) VALUES (N'12345     ', N'Bình Dương', N'023231321  ', N'VietNam', N'Trần Trung Quân')
INSERT [dbo].[KHACHHANG] ([CMND], [DiaChi], [DienThoai], [QuocTich], [HoTen]) VALUES (N'12346     ', N'TP.HCM', N'023123233  ', N'VietNam', N'Nguyễn Văn Cường')
INSERT [dbo].[KHACHHANG] ([CMND], [DiaChi], [DienThoai], [QuocTich], [HoTen]) VALUES (N'12347     ', N'Bình Phước', N'023132133  ', N'VietNam', N'Nguyễn Quốc Cường')
INSERT [dbo].[KHACHHANG] ([CMND], [DiaChi], [DienThoai], [QuocTich], [HoTen]) VALUES (N'12348     ', N'TP.HCM', N'032123233  ', N'VietNam', N'Nguyễn Hoàng Hải')
INSERT [dbo].[KHACHHANG] ([CMND], [DiaChi], [DienThoai], [QuocTich], [HoTen]) VALUES (N'12349     ', N'TP.HCM', N'023836466  ', N'America', N'Adam Smith')
INSERT [dbo].[KHACHHANG] ([CMND], [DiaChi], [DienThoai], [QuocTich], [HoTen]) VALUES (N'112233    ', N'Phú Nhuận, TP Hồ Chí Minh', N'1123456    ', N'Việt Nam', N'Lê Văn Hưu')
GO
INSERT [dbo].[LOAIPHONG] ([LoaiPhong], [DonGia], [MoTa]) VALUES (N'A    ', 150000.0000, N'Phòng không có điều hoà')
INSERT [dbo].[LOAIPHONG] ([LoaiPhong], [DonGia], [MoTa]) VALUES (N'B    ', 170000.0000, N'Phòng hạng trung')
INSERT [dbo].[LOAIPHONG] ([LoaiPhong], [DonGia], [MoTa]) VALUES (N'C    ', 200000.0000, N'Phòng vip')
GO
INSERT [dbo].[NHANVIEN] ([MaNV], [GioiTinh], [CMND/CCCD], [HoTen], [DiaChi], [DienThoai], [MaTK]) VALUES (N'NV001     ', N'Nam', N'12345          ', N'Nguyễn Văn A', N'A                                TP.HCM           ', N'01114282761', N'staff001            ')
INSERT [dbo].[NHANVIEN] ([MaNV], [GioiTinh], [CMND/CCCD], [HoTen], [DiaChi], [DienThoai], [MaTK]) VALUES (N'NV002     ', N'Nam', N'12343          ', N'b', N'a                                                 ', N'2          ', N'124                 ')
INSERT [dbo].[NHANVIEN] ([MaNV], [GioiTinh], [CMND/CCCD], [HoTen], [DiaChi], [DienThoai], [MaTK]) VALUES (N'NV003     ', N'Nam', N'072211554      ', N'Lê Văn Ba', N'Bình Phước                                        ', N'033479615  ', N'staff003            ')
GO
INSERT [dbo].[PHIEUTHUEPHONG] ([MaPhieu], [NgayLap], [CMND], [MaNV], [SoNguoi], [NgoaiQuoc]) VALUES (N'P001      ', CAST(N'2022-12-12' AS Date), N'12345     ', N'NV001     ', 2, N'Không')
INSERT [dbo].[PHIEUTHUEPHONG] ([MaPhieu], [NgayLap], [CMND], [MaNV], [SoNguoi], [NgoaiQuoc]) VALUES (N'P002      ', CAST(N'2022-12-11' AS Date), N'12346     ', N'NV001     ', 1, N'Không')
INSERT [dbo].[PHIEUTHUEPHONG] ([MaPhieu], [NgayLap], [CMND], [MaNV], [SoNguoi], [NgoaiQuoc]) VALUES (N'P003      ', CAST(N'2022-11-11' AS Date), N'12347     ', N'NV001     ', 3, N'Không')
INSERT [dbo].[PHIEUTHUEPHONG] ([MaPhieu], [NgayLap], [CMND], [MaNV], [SoNguoi], [NgoaiQuoc]) VALUES (N'P004      ', CAST(N'2022-12-10' AS Date), N'12348     ', N'NV001     ', 1, N'Không')
INSERT [dbo].[PHIEUTHUEPHONG] ([MaPhieu], [NgayLap], [CMND], [MaNV], [SoNguoi], [NgoaiQuoc]) VALUES (N'P005      ', CAST(N'2022-12-09' AS Date), N'12349     ', N'NV002     ', 1, N'Có')
INSERT [dbo].[PHIEUTHUEPHONG] ([MaPhieu], [NgayLap], [CMND], [MaNV], [SoNguoi], [NgoaiQuoc]) VALUES (N'P006      ', CAST(N'2022-12-12' AS Date), N'12347     ', N'NV001     ', 1, N'Không')
INSERT [dbo].[PHIEUTHUEPHONG] ([MaPhieu], [NgayLap], [CMND], [MaNV], [SoNguoi], [NgoaiQuoc]) VALUES (N'P00 7     ', CAST(N'2022-12-25' AS Date), N'12345     ', N'NV001     ', 1, N'Có')
INSERT [dbo].[PHIEUTHUEPHONG] ([MaPhieu], [NgayLap], [CMND], [MaNV], [SoNguoi], [NgoaiQuoc]) VALUES (N'P00 8     ', CAST(N'2022-12-25' AS Date), N'12345     ', N'NV001     ', 2, N'Có')
INSERT [dbo].[PHIEUTHUEPHONG] ([MaPhieu], [NgayLap], [CMND], [MaNV], [SoNguoi], [NgoaiQuoc]) VALUES (N'P00 9     ', CAST(N'2022-12-25' AS Date), N'12345     ', N'NV001     ', 2, N'Có')
INSERT [dbo].[PHIEUTHUEPHONG] ([MaPhieu], [NgayLap], [CMND], [MaNV], [SoNguoi], [NgoaiQuoc]) VALUES (N'P0010     ', CAST(N'2022-12-25' AS Date), N'12349     ', N'NV001     ', 2, N'Có')
INSERT [dbo].[PHIEUTHUEPHONG] ([MaPhieu], [NgayLap], [CMND], [MaNV], [SoNguoi], [NgoaiQuoc]) VALUES (N'P0011     ', CAST(N'2022-12-25' AS Date), N'12349     ', N'NV001     ', 2, N'Có')
INSERT [dbo].[PHIEUTHUEPHONG] ([MaPhieu], [NgayLap], [CMND], [MaNV], [SoNguoi], [NgoaiQuoc]) VALUES (N'P0012     ', CAST(N'2022-12-25' AS Date), N'12345     ', N'NV001     ', 2, N'Có')
INSERT [dbo].[PHIEUTHUEPHONG] ([MaPhieu], [NgayLap], [CMND], [MaNV], [SoNguoi], [NgoaiQuoc]) VALUES (N'P0013     ', CAST(N'2022-12-25' AS Date), N'12345     ', N'NV001     ', 2, N'Có')
INSERT [dbo].[PHIEUTHUEPHONG] ([MaPhieu], [NgayLap], [CMND], [MaNV], [SoNguoi], [NgoaiQuoc]) VALUES (N'P0014     ', CAST(N'2022-12-25' AS Date), N'12345     ', N'NV001     ', 1, N'Có')
INSERT [dbo].[PHIEUTHUEPHONG] ([MaPhieu], [NgayLap], [CMND], [MaNV], [SoNguoi], [NgoaiQuoc]) VALUES (N'P0015     ', CAST(N'2023-01-09' AS Date), N'112233    ', N'NV001     ', 2, N'Không')
INSERT [dbo].[PHIEUTHUEPHONG] ([MaPhieu], [NgayLap], [CMND], [MaNV], [SoNguoi], [NgoaiQuoc]) VALUES (N'P0016     ', CAST(N'2023-01-09' AS Date), N'112233    ', N'NV001     ', 1, N'Không')
GO
INSERT [dbo].[PHONG] ([MaPhong], [TrangThai], [LoaiPhong]) VALUES (N'A-1  ', N'Trống', N'A    ')
INSERT [dbo].[PHONG] ([MaPhong], [TrangThai], [LoaiPhong]) VALUES (N'A-2  ', N'Trống', N'A    ')
INSERT [dbo].[PHONG] ([MaPhong], [TrangThai], [LoaiPhong]) VALUES (N'A-3  ', N'Trống', N'A    ')
INSERT [dbo].[PHONG] ([MaPhong], [TrangThai], [LoaiPhong]) VALUES (N'B-1  ', N'Trống', N'B    ')
INSERT [dbo].[PHONG] ([MaPhong], [TrangThai], [LoaiPhong]) VALUES (N'B-2  ', N'Trống', N'B    ')
INSERT [dbo].[PHONG] ([MaPhong], [TrangThai], [LoaiPhong]) VALUES (N'B-3  ', N'Trống', N'B    ')
INSERT [dbo].[PHONG] ([MaPhong], [TrangThai], [LoaiPhong]) VALUES (N'C-1  ', N'Trống', N'C    ')
INSERT [dbo].[PHONG] ([MaPhong], [TrangThai], [LoaiPhong]) VALUES (N'C-2  ', N'Trống', N'C    ')
INSERT [dbo].[PHONG] ([MaPhong], [TrangThai], [LoaiPhong]) VALUES (N'C-3  ', N'Bảo trì', N'C    ')
GO
INSERT [dbo].[QUANLY] ([MaQL], [CMND/CCCD], [GioiTinh], [HoTen], [DiaChi], [DienThoai], [MaTK]) VALUES (N'QL001     ', N'1421412        ', N'Nam', N'Nguyễn Văn B', N'TP.HCM', N'0555213815 ', N'admin001            ')
GO
INSERT [dbo].[TAIKHOAN] ([MaTK], [MatKhau], [EmailXacNhan]) VALUES (N'123                 ', N'21232f297a57a5a743894a0e4a801fc3                  ', N'a                             ')
INSERT [dbo].[TAIKHOAN] ([MaTK], [MatKhau], [EmailXacNhan]) VALUES (N'124                 ', N'123                                               ', N'a                             ')
INSERT [dbo].[TAIKHOAN] ([MaTK], [MatKhau], [EmailXacNhan]) VALUES (N'admin001            ', N'21232f297a57a5a743894a0e4a801fc3                  ', N'admin001@gmail.com            ')
INSERT [dbo].[TAIKHOAN] ([MaTK], [MatKhau], [EmailXacNhan]) VALUES (N'staff001            ', N'1253208465b1efa876f982d8a9e73eef                  ', N'staff001@gmail.com            ')
INSERT [dbo].[TAIKHOAN] ([MaTK], [MatKhau], [EmailXacNhan]) VALUES (N'staff003            ', N'1253208465b1efa876f982d8a9e73eef                  ', N'staff003                      ')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK10]    Script Date: 1/9/2023 9:19:53 AM ******/
ALTER TABLE [dbo].[CHITIETHOADONDICHVU] ADD  CONSTRAINT [PK10] PRIMARY KEY NONCLUSTERED 
(
	[STT] ASC,
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK7]    Script Date: 1/9/2023 9:19:53 AM ******/
ALTER TABLE [dbo].[CHITIETHOADONPHONG] ADD  CONSTRAINT [PK7] PRIMARY KEY NONCLUSTERED 
(
	[STT] ASC,
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK6]    Script Date: 1/9/2023 9:19:53 AM ******/
ALTER TABLE [dbo].[DICHVU] ADD  CONSTRAINT [PK6] PRIMARY KEY NONCLUSTERED 
(
	[TenDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK13]    Script Date: 1/9/2023 9:19:53 AM ******/
ALTER TABLE [dbo].[DOANHTHU] ADD  CONSTRAINT [PK13] PRIMARY KEY NONCLUSTERED 
(
	[Thang] ASC,
	[LoaiPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK5]    Script Date: 1/9/2023 9:19:53 AM ******/
ALTER TABLE [dbo].[HOADON] ADD  CONSTRAINT [PK5] PRIMARY KEY NONCLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK1]    Script Date: 1/9/2023 9:19:53 AM ******/
ALTER TABLE [dbo].[KHACHHANG] ADD  CONSTRAINT [PK1] PRIMARY KEY NONCLUSTERED 
(
	[CMND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK14]    Script Date: 1/9/2023 9:19:53 AM ******/
ALTER TABLE [dbo].[LOAIPHONG] ADD  CONSTRAINT [PK14] PRIMARY KEY NONCLUSTERED 
(
	[LoaiPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK12]    Script Date: 1/9/2023 9:19:53 AM ******/
ALTER TABLE [dbo].[MATDOSUDUNG] ADD  CONSTRAINT [PK12] PRIMARY KEY NONCLUSTERED 
(
	[MaPhong] ASC,
	[Thang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK2]    Script Date: 1/9/2023 9:19:53 AM ******/
ALTER TABLE [dbo].[NHANVIEN] ADD  CONSTRAINT [PK2] PRIMARY KEY NONCLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK3]    Script Date: 1/9/2023 9:19:53 AM ******/
ALTER TABLE [dbo].[PHIEUTHUEPHONG] ADD  CONSTRAINT [PK3] PRIMARY KEY NONCLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK4]    Script Date: 1/9/2023 9:19:53 AM ******/
ALTER TABLE [dbo].[PHONG] ADD  CONSTRAINT [PK4] PRIMARY KEY NONCLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK8]    Script Date: 1/9/2023 9:19:53 AM ******/
ALTER TABLE [dbo].[QUANLY] ADD  CONSTRAINT [PK8] PRIMARY KEY NONCLUSTERED 
(
	[MaQL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK9]    Script Date: 1/9/2023 9:19:53 AM ******/
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
/****** Object:  StoredProcedure [dbo].[DeleteCustomer]    Script Date: 1/9/2023 9:19:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteCustomer]
	@cmnd nCHAR(10)
AS
BEGIN
	DELETE FROM KHACHHANG WHERE CMND = @cmnd
END 
GO
/****** Object:  StoredProcedure [dbo].[DeleteStaff]    Script Date: 1/9/2023 9:19:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DeleteStaff]
	@MaNV nchar(10),
	@MaTK nchar(20)
AS
BEGIN
	DELETE FROM NHANVIEN WHERE MaNV = @MaNV
	DELETE FROM TAIKHOAN WHERE MaTK = @MaTK
END 
GO
/****** Object:  StoredProcedure [dbo].[GetFullCustomer]    Script Date: 1/9/2023 9:19:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetFullCustomer]
AS
BEGIN
	SELECT * FROM dbo.KHACHHANG
END 
GO
/****** Object:  StoredProcedure [dbo].[GetFullStaff]    Script Date: 1/9/2023 9:19:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetFullStaff]
AS
BEGIN
	SELECT * FROM dbo.NHANVIEN
END 
GO
/****** Object:  StoredProcedure [dbo].[GetInforByMaNV]    Script Date: 1/9/2023 9:19:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetInforByMaNV]
	@MaNV nchar(10)
AS
BEGIN
	SELECT * FROM NHANVIEN WHERE MaNV = @MaNV
END
GO
/****** Object:  StoredProcedure [dbo].[GetInforCusByCMND]    Script Date: 1/9/2023 9:19:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetInforCusByCMND] @cmnd nCHAR(10)
AS
BEGIN
	SELECT * FROM KHACHHANG KH WHERE KH.CMND = @cmnd
END 
GO
/****** Object:  StoredProcedure [dbo].[GetRoomType]    Script Date: 1/9/2023 9:19:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetRoomType]
	
AS
BEGIN
	SELECT * FROM LOAIPHONG
END
GO
/****** Object:  StoredProcedure [dbo].[InsertCustomer]    Script Date: 1/9/2023 9:19:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

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
GO
/****** Object:  StoredProcedure [dbo].[InsertStaff]    Script Date: 1/9/2023 9:19:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertStaff]
	@MaNV nchar(10), 
	@HoTen nvarchar(20), 
	@CMND nchar(15), 
	@GioiTinh nvarchar(10),
	@DiaChi nchar(50), 
	@DienThoai char(11), 
	@MaTK nchar(20),
	@MatKhau nchar(50)
AS
BEGIN
	INSERT INTO dbo.TAIKHOAN VALUES (@MaTK, @MatKhau ,@MaTK);
	INSERT INTO dbo.NHANVIEN VALUES (@MaNV, @GioiTinh, @CMND, @HoTen, @DiaChi, @DienThoai, @MaTK);
END
GO
/****** Object:  StoredProcedure [dbo].[lap_phieuthuephong]    Script Date: 1/9/2023 9:19:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[lap_phieuthuephong] @cmnd NCHAR(10),@manv NCHAR(10),@songuoi INT ,@ngoaiquoc NVARCHAR(10)
AS
declare @maphieu NCHAR(10)='P00'

BEGIN
declare @soluong int
	set @soluong = (select count(p.MaPhieu) from PHIEUTHUEPHONG p) + 1
	declare @soluongstr varchar(3) = (SELECT CAST(@soluong AS varchar(3)));
	declare @maphieunew  nchar(10) = concat((SELECT SUBSTRING(@maphieu, 1, 5-LEN(@soluong))), @soluongstr);
	INSERT PHIEUTHUEPHONG VALUES (@maphieunew,GETDATE(),@cmnd,@manv,@songuoi,@ngoaiquoc)
	SELECT * FROM PHIEUTHUEPHONG p WHERE p.MaPhieu=@maphieunew
END
GO
/****** Object:  StoredProcedure [dbo].[proc_get_account]    Script Date: 1/9/2023 9:19:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[proc_get_account]
@user nchar(20)
as
begin
	select * from TAIKHOAN where MaTK = @user
end

GO
/****** Object:  StoredProcedure [dbo].[proc_load_info]    Script Date: 1/9/2023 9:19:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[proc_load_info]
@MaTK nchar(20)
as
begin
	select * from NHANVIEN where MaTK = @MaTK
end

GO
/****** Object:  StoredProcedure [dbo].[proc_load_info_admin]    Script Date: 1/9/2023 9:19:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[proc_load_info_admin]
@MaTK nchar(20)
as
begin
	select * from QUANLY where MaTK = @MaTK
end

GO
/****** Object:  StoredProcedure [dbo].[proc_load_room]    Script Date: 1/9/2023 9:19:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_load_room]
AS
	SELECT * FROM PHONG
GO
/****** Object:  StoredProcedure [dbo].[proc_login]    Script Date: 1/9/2023 9:19:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[proc_login]
@user nchar(20),
@pass nchar(50)
as
begin
	select * from TAIKHOAN where MaTK = @user and MatKhau = @pass
end

GO
/****** Object:  StoredProcedure [dbo].[proc_TinhDoanhThuTheoLoaiPhong]    Script Date: 1/9/2023 9:19:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_TinhDoanhThuTheoLoaiPhong]
@month int,
@year int
as
begin
	WITH BAOCAO (LoaiPhong, DoanhThu, Thang, Nam) as
	(
	select 
		p.LoaiPhong, sum(hd.DonGiaDichVu + hd.DonGiaPhong) as 'DoanhThu', @month, @year
	from 
		HOADON as hd 
	join NHANVIEN as nv on hd.MaNV = nv.MaNV
	join CHITIETHOADONPHONG as cthd on cthd.MaHD = hd.MaHD
	join PHONG as p on p.MaPhong = cthd.MaPhong
	where 
		MONTH(Ngay) = @month and YEAR(Ngay) = @year
	group by 
		p.LoaiPhong
	)
	select LoaiPhong, DoanhThu, CONVERT(VARCHAR, FORMAT(CAST(ROUND(DoanhThu * 100.0 / (select SUM(DoanhThu) from BAOCAO),0) AS REAL), 'g7')) + '%' as 'TiLe', Thang, Nam from BAOCAO
	group by LoaiPhong, DoanhThu, Thang, Nam
end
GO
/****** Object:  StoredProcedure [dbo].[proc_TinhMatDoSuDungPhong]    Script Date: 1/9/2023 9:19:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_TinhMatDoSuDungPhong]
@month int,
@year int
as
begin
WITH BAOCAO(Phong, SoNgayThue, Thang, Nam) as
(
select 
	p.MaPhong, sum(DATEDIFF(day,ptp.NgayLap,hd.Ngay)) as 'SoNgayThue' , @month, @year
from 
	HOADON as hd
join CHITIETHOADONPHONG cthd on hd.MaHD = cthd.MaHD
join PHIEUTHUEPHONG ptp on ptp.MaPhieu = cthd.MaPhieu
join PHONG p on cthd.MaPhong = p.MaPhong
where 
	MONTH(hd.Ngay) = @month and YEAR(hd.Ngay) = @year
group by p.MaPhong
)
select Phong, SoNgayThue, CONVERT(VARCHAR, FORMAT(CAST(ROUND(SoNgayThue * 100.0 / (select SUM(SoNgayThue) from BAOCAO),0) AS REAL), 'g7')) + '%' as 'TiLe', Thang, Nam from BAOCAO
end

GO
/****** Object:  StoredProcedure [dbo].[proc_update_info]    Script Date: 1/9/2023 9:19:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

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

GO
/****** Object:  StoredProcedure [dbo].[proc_update_info_admin]    Script Date: 1/9/2023 9:19:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

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

GO
/****** Object:  StoredProcedure [dbo].[sp_capnhathoadon]    Script Date: 1/9/2023 9:19:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_capnhathoadon] @mahd NCHAR(10)
AS
BEGIN
DECLARE @hoadonphong FLOAT,
		@hoadondv FLOAT,
		@maphong NCHAR(5)
SELECT @hoadondv=SUM(c.ThanhTien) FROM CHITIETHOADONDICHVU c WHERE c.MaHD=@mahd
SELECT @hoadonphong=SUM(c.ThanhTien) FROM CHITIETHOADONPHONG c WHERE c.MaHD=@mahd
SELECT @maphong=c.MaPhong FROM CHITIETHOADONPHONG c WHERE c.MaHD=@mahd
IF(@hoadonphong IS NULL)
UPDATE HOADON SET DonGiaPhong=0 WHERE MaHD=@mahd
ELSE
UPDATE HOADON SET DonGiaPhong=@hoadonphong WHERE MaHD=@mahd
IF(@hoadondv IS NULL)
UPDATE HOADON SET DonGiaDichVu=0 WHERE MaHD=@mahd
ELSE
UPDATE HOADON SET DonGiaDichVu=@hoadondv WHERE MaHD=@mahd
UPDATE PHONG SET TrangThai=N'Trống' WHERE MaPhong=@maphong AND TrangThai=N'Đang sử dụng'
END
GO
/****** Object:  StoredProcedure [dbo].[sp_capnhatthanhtien]    Script Date: 1/9/2023 9:19:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_capnhatthanhtien] @mahd NCHAR(10)
AS
BEGIN
DECLARE @thanhtien FLOAT
DECLARE @phuthu float
SELECT @thanhtien=(DATEDIFF(DAY,P.NgayLap,GETDATE())+1)*L.DonGia FROM CHITIETHOADONPHONG c,LOAIPHONG l,PHIEUTHUEPHONG p,PHONG p1 WHERE c.MaHD=@mahd AND c.MaPhong=p1.MaPhong AND P.MaPhieu=c.MaPhieu
IF EXISTS(SELECT * FROM CHITIETHOADONPHONG c,PHIEUTHUEPHONG p WHERE c.MaHD=@mahd AND c.MaPhieu=P.MaPhieu AND P.SoNguoi>2 AND P.NgoaiQuoc=N'Có')
BEGIN 
SET @phuthu=@thanhtien*0.875
END
ELSE IF EXISTS(SELECT * FROM CHITIETHOADONPHONG c,PHIEUTHUEPHONG p WHERE c.MaHD=@mahd AND c.MaPhieu=P.MaPhieu AND P.SoNguoi<=2 AND P.NgoaiQuoc=N'Có')
BEGIN 
SET @phuthu=@thanhtien*0.5
END
ELSE IF EXISTS(SELECT * FROM CHITIETHOADONPHONG c,PHIEUTHUEPHONG p WHERE c.MaHD=@mahd AND c.MaPhieu=P.MaPhieu AND P.SoNguoi>2 AND P.NgoaiQuoc=N'Không')
BEGIN 
SET @phuthu=@thanhtien*0.25
END
ELSE SET @phuthu=0
UPDATE CHITIETHOADONPHONG SET ThanhTien=@phuthu+@thanhtien WHERE MaHD=@mahd
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ChitietHoaDon]    Script Date: 1/9/2023 9:19:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ChitietHoaDon] @mahd nCHAR(10)
AS
BEGIN
SELECT c.MaPhong,L.DonGia,DATEDIFF(DAY,P.NgayLap,GETDATE()) AS SoNgay, p.SoNguoi,P.NgoaiQuoc FROM CHITIETHOADONPHONG c,LOAIPHONG l,PHIEUTHUEPHONG p,PHONG p1 WHERE c.MaHD=@mahd AND c.MaPhong=p1.MaPhong AND p1.LoaiPhong=l.LoaiPhong AND p.MaPhieu=c.MaPhieu
END

GO
/****** Object:  StoredProcedure [dbo].[sp_ChiTietHoaDonDichVu]    Script Date: 1/9/2023 9:19:53 AM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_danhsachphongtrong]    Script Date: 1/9/2023 9:19:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_danhsachphongtrong]
AS
BEGIN
SELECT MaPhong FROM PHONG WHERE TrangThai=N'Trống'
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Ds_HoaDonPhong]    Script Date: 1/9/2023 9:19:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Ds_HoaDonPhong]
as
BEGIN 
SELECT h.MaHD, h.Ngay,k.HoTen,h.CMND FROM HOADON h,KHACHHANG k 
			WHERE k.CMND=h.CMND AND h.Ngay IS NOT NULL
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ds_hoadonphong_chuathanhtoan]    Script Date: 1/9/2023 9:19:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ds_hoadonphong_chuathanhtoan]
AS
BEGIN 
SELECT h.MaHD, h.Ngay,k.HoTen,h.CMND FROM HOADON h,KHACHHANG k 
			WHERE k.CMND=h.CMND AND h.Ngay IS NULL
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ds_phieutrongngay]    Script Date: 1/9/2023 9:19:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ds_phieutrongngay]
 AS
 begin
 SELECT * FROM PHIEUTHUEPHONG p WHERE DATEDIFF(DAY,P.NgayLap,GETDATE())=0
 end
GO
/****** Object:  StoredProcedure [dbo].[sp_taohoadon]    Script Date: 1/9/2023 9:19:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_taohoadon] @cmnd NCHAR(10),@manv NCHAR(10)
as
declare @madh varchar(5) ='HD00'
BEGIN 
	declare @soluong int
	set @soluong = (select count(MaHD) from HOADON) + 1
	declare @soluongstr varchar(3) = (SELECT CAST(@soluong AS varchar(3)));
	declare @madhnew  nchar(10) = concat((SELECT SUBSTRING(@madh, 1, 5-LEN(@soluong))), @soluongstr);
	INSERT HOADON VALUES (@madhnew,0,0,NULL,@manv,@cmnd,0)
	SELECT * FROM HOADON h WHERE h.MaHD=@madhnew
END

GO
/****** Object:  StoredProcedure [dbo].[sp_thanhtoanphong]    Script Date: 1/9/2023 9:19:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_thanhtoanphong] @cmnd NCHAR(10)
AS
BEGIN
IF NOT EXISTS (SELECT * FROM HOADON h WHERE h.CMND=@cmnd AND h.Ngay IS NULL)
BEGIN
PRINT N'Khách hàng chưa đặt phòng'
RETURN 0;
END
SELECT h.MaHD,k.HoTen,k.CMND,GETDATE() AS Ngay, k.DiaChi,h.DonGiaPhong,h.DonGiaDichVu FROM HOADON h,KHACHHANG k WHERE h.CMND=@cmnd AND h.Ngay IS NULL AND H.CMND=k.CMND
UPDATE HOADON SET Ngay=GETDATE() WHERE CMND=@cmnd AND Ngay IS NULL
return 1
END
GO
/****** Object:  StoredProcedure [dbo].[sp_themchitietphong]    Script Date: 1/9/2023 9:19:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_themchitietphong] @maphong NCHAR(10),@mahd NCHAR(10),@maphieu NCHAR(10)
AS
BEGIN 
IF NOT EXISTS( SELECT * FROM phong WHERE MaPhong=@maphong AND TrangThai=N'Trống')
BEGIN
	PRINT N'Phòng đã có người sử dụng'
	RETURN 1
END
DECLARE @stt int=(SELECT COUNT(c.STT) FROM CHITIETHOADONPHONG c WHERE c.MaHD=@mahd)+1
INSERT CHITIETHOADONPHONG VALUES (CAST(@stt AS CHAR(2)),@mahd,0,@maphong,@maphieu)
UPDATE PHONG SET TrangThai=N'Đang sử dụng' WHERE MaPhong=@maphong
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Xoa_HoaDon]    Script Date: 1/9/2023 9:19:53 AM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_xoahoadon]    Script Date: 1/9/2023 9:19:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_xoahoadon] @mahd NCHAR(10)
as
BEGIN
	DELETE CHITIETHOADONDICHVU WHERE MaHD=@mahd
	DELETE CHITIETHOADONPHONG WHERE MaHD=@mahd
	DELETE HOADON WHERE MaHD=@mahd
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateInforCus]    Script Date: 1/9/2023 9:19:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

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
GO
/****** Object:  StoredProcedure [dbo].[UpdateStaff]    Script Date: 1/9/2023 9:19:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

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
GO
/****** Object:  StoredProcedure [dbo].[USP_AddRoom]    Script Date: 1/9/2023 9:19:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_AddRoom] @MaPhong nchar(5), @TrangThai nvarchar(20), @LoaiPhong nchar(5)
AS
BEGIN TRANSACTION
	--Kiểm tra phòng đã tồn tại hay chưa
	IF EXISTS (SELECT * FROM PHONG WHERE MaPhong = @MaPhong)
	BEGIN
		PRINT N'Mã phòng đã tồn tại'
		ROLLBACK TRAN
		RETURN 
	END
	-- Thực hiện thêm phòng mới
	INSERT INTO PHONG VALUES (@MaPhong, @TrangThai, @LoaiPhong)
COMMIT TRANSACTION
GO
/****** Object:  StoredProcedure [dbo].[USP_TinhDoanhThu]    Script Date: 1/9/2023 9:19:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_TinhDoanhThu] @Thang int, @LoaiPhong nchar(5)
AS
BEGIN
	SELECT SUM(HD.TONGTIEN) AS TONGDOANHTHU 
	FROM DOANHTHU DT, LOAIPHONG LP, PHONG P, CHITIETHOADONPHONG CT, HOADON HD
	WHERE DT.LoaiPhong = LP.LoaiPhong AND LP.LoaiPhong = P.LoaiPhong AND CT.MaPhong = P.MaPhong AND CT.MaHD = HD.MaHD 
	AND LP.LoaiPhong = @LoaiPhong AND DT.Thang = @Thang
END
GO
/****** Object:  StoredProcedure [dbo].[USP_TinhMatDoSuDungPhong]    Script Date: 1/9/2023 9:19:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE 
PROCEDURE [dbo].[USP_TinhMatDoSuDungPhong] @Thang int, @MaPhong nchar(5)
AS
BEGIN 
	SELECT COUNT(HD.MaHD) AS MATDOSUDUNG
	FROM MATDOSUDUNG MD, PHONG P, CHITIETHOADONPHONG CT, HOADON HD
	WHERE MD.MaPhong = P.MaPhong AND P.MaPhong = CT.MaPhong AND CT.MaHD = HD.MaHD 
	AND P.MaPhong = @MaPhong AND MD.Thang = @Thang
END 
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateRoom]    Script Date: 1/9/2023 9:19:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE
--ALTER 
PROCEDURE [dbo].[USP_UpdateRoom] @MaPhong nchar(5), @TrangThai nvarchar(20), @LoaiPhong nchar(5)
AS
BEGIN TRANSACTION
	--Kiểm tra phòng có tồn tại hay chưa
	IF NOT EXISTS (SELECT * FROM PHONG WHERE MaPhong = @MaPhong)
	BEGIN 
		PRINT N'Mã phòng không tồn tại'
		ROLLBACK TRAN
		RETURN
	END
	-- Thực hiện cập nhật phòng 
	UPDATE PHONG SET TrangThai = @TrangThai WHERE MaPhong = @MaPhong AND LoaiPhong = @LoaiPhong
COMMIT TRANSACTION
GO
USE [master]
GO
ALTER DATABASE [QLKHACHSAN1] SET  READ_WRITE 
GO
