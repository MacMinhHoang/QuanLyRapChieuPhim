/***** Tạo Database *****/

USE master;
CREATE DATABASE RapChieuPhimDB;
GO
USE RapChieuPhimDB;


/***** Tạo các bảng và khóa chính *****/

CREATE TABLE TaiKhoan (
	TenDangNhap varchar(30) NOT NULL,
	MatKhau varchar(30),
	PhanQuyen char(3),
	PRIMARY KEY (TenDangNhap)
)

CREATE TABLE NguoiDung (
	MaNguoiDung int IDENTITY(11111001, 1),
	TenDangNhap varchar(30),
	HoTen nvarchar(100),
	NgaySinh varchar(11),
	GioiTinh bit,
	DiaChi nvarchar(100),
	SDT char(12),
	PRIMARY KEY (MaNguoiDung)
)

CREATE TABLE NhanVien (
	MaNhanVien int NOT NULL,
	Luong float,
	LichLamViec char(8),
	PRIMARY KEY (MaNhanVien) 
)

CREATE TABLE KhachHang (
	MaKhachHang int NOT NULL,
	DiemTichLuy int,
	PRIMARY KEY (MaKhachHang) 
)

CREATE TABLE VE (
	MaVe int IDENTITY(77777001, 1),
	MaKhachHang int,
	MaSuatChieu int,
	Ghe char(4),
	LoaiVe bit,
	GiaVe float,
	ThanhToan bit,
	TinhTrang bit,
	PRIMARY KEY (MaVe)
)

CREATE TABLE SuatChieu (
	MaSuatChieu int IDENTITY(33333001, 1),
	MaPhongChieu int,
	NgayChieu varchar(11),
	GioChieu varchar(6),
	MaPhim int,
	PRIMARY KEY (MaSuatChieu)
)

CREATE TABLE PhongChieu (
	MaPhongChieu int IDENTITY(55555001, 1),
	TenPhongChieu nvarchar(50),
	SoLuongGhe int,
	TinhTrang bit,
	PRIMARY KEY (MaPhongChieu)
)

CREATE TABLE Phim (
	MaPhim int IDENTITY(99999001, 1),
	Ten nvarchar(100),
	TheLoai nvarchar(100),
	DaoDien nvarchar(100),
	DienVien nvarchar(100),
	GioiHanDoTuoi int, 
	NamSanXuat int,
	Poster varchar(200),
	Trailer varchar(200),
	PRIMARY KEY (MaPhim)
)

CREATE TABLE ThongKe (
	MaHoatDong int IDENTITY(22222001, 1),
	TenHoatDong nvarchar(100),
	ChiPhi float,
	PRIMARY KEY (MaHoatDong)
)


/***** Tạo các khóa ngoại *****/

GO
ALTER TABLE NguoiDung ADD CONSTRAINT FK_NguoiDung_TaiKhoan
FOREIGN KEY (TenDangNhap) REFERENCES TaiKhoan(TenDangNhap)
GO
ALTER TABLE NhanVien ADD CONSTRAINT FK_NhanVien_NguoiDung
FOREIGN KEY (MaNhanVien) REFERENCES NguoiDung(MaNguoiDung)
GO
ALTER TABLE KhachHang ADD CONSTRAINT FK_KhachHang_NguoiDung
FOREIGN KEY (MaKhachHang) REFERENCES NguoiDung(MaNguoiDung)
GO
ALTER TABLE Ve ADD CONSTRAINT FK_Ve_KhachHang
FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang)
GO
ALTER TABLE Ve ADD CONSTRAINT FK_Ve_SuatChieu
FOREIGN KEY (MaSuatChieu) REFERENCES SuatChieu(MaSuatChieu)
GO
ALTER TABLE SuatChieu ADD CONSTRAINT FK_SuatChieu_PhongChieu
FOREIGN KEY (MaPhongChieu) REFERENCES PhongChieu(MaPhongChieu)
GO
ALTER TABLE SuatChieu ADD CONSTRAINT FK_SuatChieu_Phim
FOREIGN KEY (MaPhim) REFERENCES Phim(MaPhim)

GO

/***** Nhập dữ liệu *****/
