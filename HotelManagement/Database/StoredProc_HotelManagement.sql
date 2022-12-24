GO
USE QLKHACHSAN
--Procedure thêm phòng
GO
CREATE PROCEDURE USP_AddRoom @MaPhong nchar(5), @TrangThai nvarchar(20), @LoaiPhong nchar(5)
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
-- Procedure cập nhật phòng 
GO
ALTER
--CREATE 
PROCEDURE USP_UpdateRoom @MaPhong nchar(5), @TrangThai nvarchar(20), @LoaiPhong nchar(5)
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

-- Procedure tính doanh thu theo loại phòng
GO
CREATE PROCEDURE USP_TinhDoanhThu @Thang int, @LoaiPhong nchar(5)
AS
BEGIN
	SELECT SUM(HD.TONGTIEN) AS TONGDOANHTHU 
	FROM DOANHTHU DT, LOAIPHONG LP, PHONG P, CHITIETHOADONPHONG CT, HOADON HD
	WHERE DT.LoaiPhong = LP.LoaiPhong AND LP.LoaiPhong = P.LoaiPhong AND CT.MaPhong = P.MaPhong AND CT.MaHD = HD.MaHD 
	AND LP.LoaiPhong = @LoaiPhong AND DT.Thang = @Thang
END
GO

EXEC USP_TinhDoanhThu '12', 'B'

-- Procedure tính mật độ sử dụng phòng
GO
--ALTER
CREATE 
PROCEDURE USP_TinhMatDoSuDungPhong @Thang int, @MaPhong nchar(5)
AS
BEGIN 
	SELECT COUNT(HD.MaHD) AS MATDOSUDUNG
	FROM MATDOSUDUNG MD, PHONG P, CHITIETHOADONPHONG CT, HOADON HD
	WHERE MD.MaPhong = P.MaPhong AND P.MaPhong = CT.MaPhong AND CT.MaHD = HD.MaHD 
	AND P.MaPhong = @MaPhong AND MD.Thang = @Thang
END 

EXEC USP_TinhMatDoSuDungPhong '12', 'A-1'

SELECT * FROM CHITIETHOADONPHONG

