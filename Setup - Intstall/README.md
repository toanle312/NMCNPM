# PHẦN MỀM QUẢN LÝ KHÁCH SẠN

Ứng dụng quản lý khách sạn sử dụng C#, SQL SERVER

## Hướng dẫn cài đặt

**1. Tải các thành phần liên quan**

* Mở file trong thư mục Source với đường dẫn sau: Source\HotelManagement\QuanLyKhachSan\QuanLyKhachSan.sln chạy trên Visual Studio ( phiên bản 2017 trở lên)
* Nếu file Source có vấn đề thì có thể clone từ link Github sau: https://github.com/toanle312/NMCNPM
* Chạy file Source/HotelManagement/Database/QLKHACHSAN1.SQL vào server tương ứng của máy với tên database là [QLKHACHSAN1] 

**2. Chỉnh sửa connection string**

* Mở file DAO.DataProvider.cs 
* Sửa đổi private string _connectionStr = 
@"Data Source=**.\LAPTOP-M3NT3CHJ\SQLEXPRESS**;Initial Catalog=QLKHACHSAN11;Integrated Security=True";
với tên server tương ứng

**3. Tài khoản đăng nhập hệ thống**
username: admin001
password: admin
$\to$ Đăng nhập với chức năng quản lý

username: staff001
password: staff
$\to$ Đăng nhập với chức năng nhân viên

**4. Các chức năng ứng với vai trò**
* Quản lý: Thống kê, Quản lý phòng, Quản lý nhân viên, Quản lý khách hàng, Thay đổi quy định, Quản lý hóa đơn
* Nhân viên: Tra cứu phòng, Quản lý phòng, Lập phiếu thuê phòng, Quản lý khách hàng, Sử dụng dịch vụ, quản lý dịch vụ, Quản lý hóa đơn, Quản lý phòng, Lập báo cáo


## Môi trường

* [Visual Studio 2017](https://visualstudio.microsoft.com/fr/downloads/?rr=https%3A%2F%2Fwww.google.com.vn%2F)
* [SQL Server 2017](https://www.microsoft.com/en-us/sql-server/sql-server-2017)

## Tài liệu tham khảo

Phần mềm QLKS Github [documentation](https://github.com/ThuctapnhomK51/QLKS).
Phần mềm quản lý quán Cafe (HowKteam) [documentation](https://www.youtube.com/playlist?list=PL33lvabfss1xnPhBJHjM0A8TEBBcGCTsf).

