/*
 * ER/Studio Data Architect SQL Code Generation
 * Project :      Model1.DM1
 *
 * Date Created : Sunday, November 27, 2022 14:03:03
 * Target DBMS : Microsoft SQL Server 2017
 */

/* 
 * TABLE: CHITIETHOADONDICHVU 
 */

create database QLKS
use QLKS

CREATE TABLE CHITIETHOADONDICHVU(
    STT        char(2)         NOT NULL,
    MaHD       char(10)        NOT NULL,
    DonGia     money           NOT NULL,
    SoLuong    int             NOT NULL,
    TenDV      nvarchar(20)    NOT NULL,
    CONSTRAINT PK10 PRIMARY KEY NONCLUSTERED (STT, MaHD)
)
go



IF OBJECT_ID('CHITIETHOADONDICHVU') IS NOT NULL
    PRINT '<<< CREATED TABLE CHITIETHOADONDICHVU >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE CHITIETHOADONDICHVU >>>'
go

/* 
 * TABLE: CHITIETHOADONPHONG 
 */

CREATE TABLE CHITIETHOADONPHONG(
    STT        char(2)     NOT NULL,
    MaHD       char(10)    NOT NULL,
    DonGia     money       NOT NULL,
    MaPhong    char(5)     NOT NULL,
    MaPhieu    char(10)    NOT NULL,
    CONSTRAINT PK7 PRIMARY KEY NONCLUSTERED (STT, MaHD)
)
go



IF OBJECT_ID('CHITIETHOADONPHONG') IS NOT NULL
    PRINT '<<< CREATED TABLE CHITIETHOADONPHONG >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE CHITIETHOADONPHONG >>>'
go

/* 
 * TABLE: DICHVU 
 */

CREATE TABLE DICHVU(
    TenDV          nvarchar(20)    NOT NULL,
    HinhMinhHoa    char(20)        NULL,
    DonGia         money           NOT NULL,
    GhiChu         nvarchar(20)    NULL,
    CONSTRAINT PK6 PRIMARY KEY NONCLUSTERED (TenDV)
)
go



IF OBJECT_ID('DICHVU') IS NOT NULL
    PRINT '<<< CREATED TABLE DICHVU >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE DICHVU >>>'
go

/* 
 * TABLE: DOANHTHU 
 */

CREATE TABLE DOANHTHU(
    Thang        char(10)    NOT NULL,
    LoaiPhong    char(5)     NOT NULL,
    DoanhThu     money       NULL,
    MaNV         char(10)    NOT NULL,
    CONSTRAINT PK13 PRIMARY KEY NONCLUSTERED (Thang, LoaiPhong)
)
go



IF OBJECT_ID('DOANHTHU') IS NOT NULL
    PRINT '<<< CREATED TABLE DOANHTHU >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE DOANHTHU >>>'
go

/* 
 * TABLE: HoaDon 
 */

CREATE TABLE HoaDon(
    MaHD            char(10)    NOT NULL,
    DonGiaPhong     money       NOT NULL,
    DonGiaDichVu    money       NOT NULL,
    Ngay            datetime    NULL,
    MaNV            char(10)    NOT NULL,
    CMND            char(10)    NOT NULL,
    CONSTRAINT PK5 PRIMARY KEY NONCLUSTERED (MaHD)
)
go



IF OBJECT_ID('HoaDon') IS NOT NULL
    PRINT '<<< CREATED TABLE HoaDon >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE HoaDon >>>'
go

/* 
 * TABLE: KHACHHANG 
 */

CREATE TABLE KHACHHANG(
    CMND         char(10)        NOT NULL,
    DiaChi       nvarchar(50)    NULL,
    DienThoai    char(11)        NOT NULL,
    QuocTich     nchar(20)       NOT NULL,
    HoTen        nvarchar(50)    NOT NULL,
    CONSTRAINT PK1 PRIMARY KEY NONCLUSTERED (CMND)
)
go



IF OBJECT_ID('KHACHHANG') IS NOT NULL
    PRINT '<<< CREATED TABLE KHACHHANG >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE KHACHHANG >>>'
go

/* 
 * TABLE: LOAIPHONG 
 */

CREATE TABLE LOAIPHONG(
    LoaiPhong    char(5)         NOT NULL,
    DonGia       money           NOT NULL,
    MoTa         nvarchar(50)    NOT NULL,
    CONSTRAINT PK14 PRIMARY KEY NONCLUSTERED (LoaiPhong)
)
go



IF OBJECT_ID('LOAIPHONG') IS NOT NULL
    PRINT '<<< CREATED TABLE LOAIPHONG >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE LOAIPHONG >>>'
go

/* 
 * TABLE: MATDOSUDUNG 
 */

CREATE TABLE MATDOSUDUNG(
    MaPhong        char(5)     NOT NULL,
    Thang          char(10)    NOT NULL,
    MatDoSuDung    int         NULL,
    MaNV           char(10)    NOT NULL,
    CONSTRAINT PK12 PRIMARY KEY NONCLUSTERED (MaPhong, Thang)
)
go



IF OBJECT_ID('MATDOSUDUNG') IS NOT NULL
    PRINT '<<< CREATED TABLE MATDOSUDUNG >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE MATDOSUDUNG >>>'
go

/* 
 * TABLE: NHANVIEN 
 */

CREATE TABLE NHANVIEN(
    MaNV         char(10)        NOT NULL,
    GioiTinh     nvarchar(10)    NOT NULL,
    [CMND/CCCD]  char(15)        NULL,
    HoTen        nvarchar(20)    NOT NULL,
    DiaChi       nchar(50)       NULL,
    DienThoai    char(11)        NOT NULL,
    MaTK         char(20)        NOT NULL,
    CONSTRAINT PK2 PRIMARY KEY NONCLUSTERED (MaNV)
)
go



IF OBJECT_ID('NHANVIEN') IS NOT NULL
    PRINT '<<< CREATED TABLE NHANVIEN >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE NHANVIEN >>>'
go

/* 
 * TABLE: PHIEUTHUEPHONG 
 */

CREATE TABLE PHIEUTHUEPHONG(
    MaPhieu    char(10)    NOT NULL,
    NgayLap    date        NOT NULL,
    CMND       char(10)    NOT NULL,
    MaNV       char(10)    NOT NULL,
    CONSTRAINT PK3 PRIMARY KEY NONCLUSTERED (MaPhieu)
)
go



IF OBJECT_ID('PHIEUTHUEPHONG') IS NOT NULL
    PRINT '<<< CREATED TABLE PHIEUTHUEPHONG >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE PHIEUTHUEPHONG >>>'
go

/* 
 * TABLE: PHONG 
 */

CREATE TABLE PHONG(
    MaPhong      char(5)         NOT NULL,
    TrangThai    nvarchar(20)    NOT NULL,
    LoaiPhong    char(5)         NOT NULL,
    CONSTRAINT PK4 PRIMARY KEY NONCLUSTERED (MaPhong)
)
go



IF OBJECT_ID('PHONG') IS NOT NULL
    PRINT '<<< CREATED TABLE PHONG >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE PHONG >>>'
go

/* 
 * TABLE: QUANLY 
 */

CREATE TABLE QUANLY(
    MaQL         char(10)        NOT NULL,
    [CMND/CCCD]  char(15)        NOT NULL,
    GioiTinh     nvarchar(10)    NOT NULL,
    HoTen        nvarchar(20)    NOT NULL,
    DiaChi       nvarchar(50)    NOT NULL,
    DienThoai    char(11)        NOT NULL,
    MaTK         char(20)        NOT NULL,
    CONSTRAINT PK8 PRIMARY KEY NONCLUSTERED (MaQL)
)
go



IF OBJECT_ID('QUANLY') IS NOT NULL
    PRINT '<<< CREATED TABLE QUANLY >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE QUANLY >>>'
go

/* 
 * TABLE: TAIKHOAN 
 */

CREATE TABLE TAIKHOAN(
    MaTK            char(20)    NOT NULL,
    MatKhau         char(20)    NOT NULL,
    EmailXacNhan    char(30)    NOT NULL,
    CONSTRAINT PK9 PRIMARY KEY NONCLUSTERED (MaTK)
)
go



IF OBJECT_ID('TAIKHOAN') IS NOT NULL
    PRINT '<<< CREATED TABLE TAIKHOAN >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE TAIKHOAN >>>'
go

/* 
 * TABLE: CHITIETHOADONDICHVU 
 */

ALTER TABLE CHITIETHOADONDICHVU ADD CONSTRAINT RefHoaDon7 
    FOREIGN KEY (MaHD)
    REFERENCES HoaDon(MaHD)
go

ALTER TABLE CHITIETHOADONDICHVU ADD CONSTRAINT RefDICHVU14 
    FOREIGN KEY (TenDV)
    REFERENCES DICHVU(TenDV)
go


/* 
 * TABLE: CHITIETHOADONPHONG 
 */

ALTER TABLE CHITIETHOADONPHONG ADD CONSTRAINT RefHoaDon6 
    FOREIGN KEY (MaHD)
    REFERENCES HoaDon(MaHD)
go

ALTER TABLE CHITIETHOADONPHONG ADD CONSTRAINT RefPHONG9 
    FOREIGN KEY (MaPhong)
    REFERENCES PHONG(MaPhong)
go

ALTER TABLE CHITIETHOADONPHONG ADD CONSTRAINT RefPHIEUTHUEPHONG16 
    FOREIGN KEY (MaPhieu)
    REFERENCES PHIEUTHUEPHONG(MaPhieu)
go


/* 
 * TABLE: DOANHTHU 
 */

ALTER TABLE DOANHTHU ADD CONSTRAINT RefLOAIPHONG20 
    FOREIGN KEY (LoaiPhong)
    REFERENCES LOAIPHONG(LoaiPhong)
go

ALTER TABLE DOANHTHU ADD CONSTRAINT RefNHANVIEN22 
    FOREIGN KEY (MaNV)
    REFERENCES NHANVIEN(MaNV)
go


/* 
 * TABLE: HoaDon 
 */

ALTER TABLE HoaDon ADD CONSTRAINT RefNHANVIEN10 
    FOREIGN KEY (MaNV)
    REFERENCES NHANVIEN(MaNV)
go

ALTER TABLE HoaDon ADD CONSTRAINT RefKHACHHANG11 
    FOREIGN KEY (CMND)
    REFERENCES KHACHHANG(CMND)
go


/* 
 * TABLE: MATDOSUDUNG 
 */

ALTER TABLE MATDOSUDUNG ADD CONSTRAINT RefPHONG18 
    FOREIGN KEY (MaPhong)
    REFERENCES PHONG(MaPhong)
go

ALTER TABLE MATDOSUDUNG ADD CONSTRAINT RefNHANVIEN21 
    FOREIGN KEY (MaNV)
    REFERENCES NHANVIEN(MaNV)
go


/* 
 * TABLE: NHANVIEN 
 */

ALTER TABLE NHANVIEN ADD CONSTRAINT RefTAIKHOAN4 
    FOREIGN KEY (MaTK)
    REFERENCES TAIKHOAN(MaTK)
go


/* 
 * TABLE: PHIEUTHUEPHONG 
 */

ALTER TABLE PHIEUTHUEPHONG ADD CONSTRAINT RefKHACHHANG12 
    FOREIGN KEY (CMND)
    REFERENCES KHACHHANG(CMND)
go

ALTER TABLE PHIEUTHUEPHONG ADD CONSTRAINT RefNHANVIEN13 
    FOREIGN KEY (MaNV)
    REFERENCES NHANVIEN(MaNV)
go


/* 
 * TABLE: PHONG 
 */

ALTER TABLE PHONG ADD CONSTRAINT RefLOAIPHONG19 
    FOREIGN KEY (LoaiPhong)
    REFERENCES LOAIPHONG(LoaiPhong)
go


/* 
 * TABLE: QUANLY 
 */

ALTER TABLE QUANLY ADD CONSTRAINT RefTAIKHOAN3 
    FOREIGN KEY (MaTK)
    REFERENCES TAIKHOAN(MaTK)
go


