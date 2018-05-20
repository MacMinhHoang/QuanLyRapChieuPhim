/***** Tạo Database *****/

USE master;
CREATE DATABASE RapChieuPhimDB;
GO
USE RapChieuPhimDB;

/***** Tạo các bảng và khóa chính *****/

CREATE TABLE TaiKhoan (
	TenDangNhap varchar(30) NOT NULL,
	MatKhau varchar(30),
	PhanQuyen char(2),
	PRIMARY KEY (TenDangNhap)
)

CREATE TABLE NguoiDung (
	MaNguoiDung int IDENTITY(11111001, 1),
	TenDangNhap varchar(30),
	HoTen nvarchar(100),
	NgaySinh varchar(11),
	GioiTinh bit,			/* 0 : Nam, 1 : Nữ */
	DiaChi nvarchar(100),
	SDT varchar(12),
	PRIMARY KEY (MaNguoiDung)
)

CREATE TABLE KhachHang (
	MaKhachHang int NOT NULL,
	DiemTichLuy int,
	PRIMARY KEY (MaKhachHang) 
)

CREATE TABLE NhanVien (
	MaNhanVien int NOT NULL,
	Luong float,
	LichLamViec varchar(8),
	PRIMARY KEY (MaNhanVien) 
)

CREATE TABLE Phim (
	MaPhim int IDENTITY(99999001, 1),
	Ten nvarchar(100),
	TheLoai nvarchar(100),
	DaoDien nvarchar(100),
	DienVien nvarchar(100),
	GioiHanDoTuoi int,
	NoiDung nvarchar(3000), 
	NamSanXuat int,
	Poster varchar(200),
	Trailer varchar(200),
	PRIMARY KEY (MaPhim)
)

CREATE TABLE PhongChieu (
	MaPhongChieu int IDENTITY(55555001, 1),
	TenPhongChieu nvarchar(50),
	SoLuongGhe int,
	TinhTrang bit,				/* 0 : KO hoạt động, 1 : Hoạt động */
	PRIMARY KEY (MaPhongChieu)
)

CREATE TABLE SuatChieu (
	MaSuatChieu int IDENTITY(33333001, 1),
	MaPhongChieu int,
	NgayChieu varchar(11),
	GioChieu varchar(6),
	MaPhim int,
	PRIMARY KEY (MaSuatChieu)
)

CREATE TABLE Ve (
	MaVe int IDENTITY(77777001, 1),
	MaKhachHang int,
	MaSuatChieu int,
	Ghe varchar(4),
	LoaiVe bit,					/* 0 : Thường, 1 : VIP */
	GiaVe float,		
	ThanhToan bit,				/* 0 : Trực tiếp, 1 : Online */
	TinhTrang bit,				/* 0 : Chưa sử dụng, 1 : Đã sử dụng */
	PRIMARY KEY (MaVe)
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

/***** TaiKhoan ******/
INSERT INTO TaiKhoan VALUES ('nthung','1234','KH')		/*** Khách Hàng ***/
INSERT INTO TaiKhoan VALUES ('quankun','1234','KH')
INSERT INTO TaiKhoan VALUES ('gaconxauxi','1234','KH')
INSERT INTO TaiKhoan VALUES ('nlhuy','1234','NV')		/*** Nhân Viên Kỹ Thuật ***/
INSERT INTO TaiKhoan VALUES ('dhgcat','1234','KT')		/*** Kế Toán ***/
INSERT INTO TaiKhoan VALUES ('nntt','1234','QL')		/*** Quản Lý Nhân Sự ***/
INSERT INTO TaiKhoan VALUES ('mmhoang','1234','AD')		/*** Admin ***/

/***** NguoiDung *****/
/*** ID bắt đầu từ 11111001 ***/
INSERT INTO NguoiDung VALUES ('nthung', N'Nguyễn Thanh Hùng', '10/03/1997', 0, N'206 Trần Phú, P.7, Q.5, tpHCM', '0908403722')
INSERT INTO NguoiDung VALUES ('quankun', N'Vũ Minh Quân', '23/06/1997', 0, N'304 Lạc Long Quân, P.6, Q.Tân Phú, tpHCM', '01667132791')
INSERT INTO NguoiDung VALUES ('gaconxauxi', N'Nguyễn Thị Lệ Ánh', '08/10/1999', 1, N'123 3/2, P.12, Q.10, tpHCM', '0984646123')
INSERT INTO NguoiDung VALUES ('nlhuy', N'Nguyễn Lê Huy', '13/01/1997', 0, N'352 Hồ Thị Nghĩa P.1, Q.10 tpHCM', '01635194783')
INSERT INTO NguoiDung VALUES ('dhgcat', N'Đỗ Huy Gia Cát', '01/03/1997', 0, N'304 Âu Cơ, P.Phú Trung, Q.Tân Phú, tpHCM', '0937298456')
INSERT INTO NguoiDung VALUES ('nntt', N'Nguyễn Ngọc Thanh Thảo', '10/11/1997', 0, N'203 Nguyễn Chí Thanh, P.1, Q.10, tpHCM', '0904933167')
INSERT INTO NguoiDung VALUES ('mmhoang', N'Mạc Minh Hoàng', '08/05/1997', 0, N'2A/11 Hùng Vương, P.12, Q.5, tpHCM', '01881123321')
INSERT INTO NguoiDung VALUES (NULL, N'Nhân Viên A', '09/05/1997', 0, N'2A/10 Hùng Vương, P.11, Q.5, tpHCM', '01881123333')
INSERT INTO NguoiDung VALUES (NULL, N'Nhân Viên B', '10/05/1997', 0, N'2A/12 Hùng Vương, P.12, Q.4, tpHCM', '01881123444')


/***** KhachHang *****/
INSERT INTO KhachHang VALUES (11111001, 10)
INSERT INTO KhachHang VALUES (11111002, 0)
INSERT INTO KhachHang VALUES (11111003, 20)

/***** NhanVien *****/
INSERT INTO NhanVien VALUES (11111008, 4500000, '2468')
INSERT INTO NhanVien VALUES (11111009, 4000000, '357')

/***** Phim *****/
/*** ID bắt đầu từ 99999001 ***/
INSERT INTO Phim VALUES (N'Cô Ba Sài Gòn',N'Tâm lý',N'Trần Bửu Lộc, Kay Nguyễn',N' Ngô Thanh Vân, Ninh Dương Lan Ngọc, Diễm My, Hồng Vân,
 Diễm My 9X, Oanh Kiều và S.T.',0, N'Cô Ba Sài Gòn là hành trình thú vị của Như Ý – cô chủ hiệu may Thanh Nữ, vô tình xuyên không đến tương lai. Là cô gái thế kỷ 20 mang lý tưởng bảo vệ chiếc áo dài thiêng liêng và truyền thống,
  Như Ý vô cùng bỡ ngỡ khi đứng trước xã hội ở thế kỷ 21 với nhiều thay đổi. Hơn hết, Như Ý phải đối mặt với chính cô của tương lai. Như Ý tìm cách trở về thế giới của mình, bằng cách phải lấy chiếc áo dài cũ từ chính phiên bản Như Ý của tương lai.','2017',
  './Images/CBSG.jpg','https://www.youtube.com/watch?v=YP4TDQVkZO4')

INSERT INTO Phim VALUES(N'24 Giờ Hồi Sinh',N'Hành động','Brian Smrz','Rutger Hauer, Ethan Hawke, Paul Anderson',18,N'Sau một cuộc phẫu thuật thử nghiệm, sát thủ Travis Conrad được hồi sinh từ cõi chết và có đúng 24 giờ để sống lại. Anh quyết định hợp 
tác với chính nữ đặc vụ đã giết chết mình nhằm trả thù tổ chức tội phạm đã sát hại vợ và con của anh. Đây cũng chính là cơ hội để Travis chuộc
 lại những lỗi lầm trong quá khứ. Chỉ có 24 giờ để báo thù, liệu Travis có hoàn thành được nhiệm vụ khi từng giây trôi qua, tử thần lại càng
  đến gần hơn?','2017','./Images/24h.jpg','https://www.youtube.com/watch?v=e1Dam6exiYE')

INSERT INTO Phim VALUES(N'Liên Minh Công Lý ( Justice League)',N'Hành động','Zack Snyder','Ben Affleck, Gal Gadot, Henry Cavill, 
Jason Momoa, Ezra Miller',0,N'Được thôi thúc bằng niềm tin vào loài người vừa tìm lại và sự hy sinh cao cả của Superman, tỷ phú Bruce Wayne 
– Batman quyết định tìm kiếm và tập họp những đồng minh mới cũng như Wonder Woman để chuẩn bị đối mặt với những kẻ thù lớn hơn. 
Phim tiếp tục được giao vào tay đạo diễn Zack Snyder – người gây nhiều tranh cãi khi cầm trịch Batman v Superman: Dawn Of Justice.
 Dàn diễn viên quen thuộc Ben Affleck, Henry Cavill và Gal Gadot tiếp tục góp mặt trong phim. Justice League được xem là siêu phẩm hoành tráng
  nhất của DC Comics.','2017','./Images/Justice-League-banner.jpg','https://www.youtube.com/watch?v=r9-DM9uBtVI')

INSERT INTO Phim VALUES(N'Trải Nghiệm Điểm Chết (Flatliners)',N'Kinh dị','Niels Arden Oplev','Ellen Page, Diego Luna, Nina Dobrev',18,N'Năm sinh viên y khoa tham gia vào một thí nghiệm cực kỳ nguy hiểm: Chết lâm sàng để được trải nghiệm cảm giác chu du "thế giới bên kia".
 Đây là trải nghiệm độc đáo có một không hai và nó khiến các chàng trai cô gái trẻ mê mẩn. Phim sở hữu cốt truyện hấp dẫn và đậm tính nhân văn.
  Theo đó, thế giới bên kia không phải nơi để bạn an nghỉ mà chính là “pháp trường” nơi bạn phải đối diện với những tội lỗi mình đã gây ra khi 
  còn sống. Là phần tiếp theo của bộ phim cùng tên do đạo diễn Joel Schumacher thực hiện năm 1990, Flatliners 2017 (tựa tiếng Việt là Trải 
  Nghiệm Điểm Chết) sở hữu dàn diễn viên trẻ trung do Sony tuyển chọn hứa hẹn sẽ phát huy và vượt qua cái bóng của phần cũ, chinh phục khán
   giả. Phim được đạo diễn bởi Niels Arden Oplev (Girl With The Dragon Tattoo bản Thụy Điển). Chúng ta sẽ đi đâu sau khi chết? Thế giới dành 
   cho các linh hồn như thế nào? Đó là đề tài rất hấp dẫn trí tò mò của con người.','2017','./Images/flatliners.jpg','https://www.youtube.com/watch?v=gUDV0CUzG0k')

INSERT INTO Phim VALUES (N'Pháo Hoa, Nên Ngắm Từ Dưới Hay Bên Cạnh',N'Hoạt hình','Akiyuki Shimbo','Suzu Hirose, Masaki Suda, Mamoru Miyano',
0,N'Bộ phim truyền tải một thông điệp mạnh mẽ cho những người trẻ ngoài kia hãy sống và yêu khi còn bùng cháy ngọn lửa thanh xuân cùng 
những chân tình tinh khôi. Sẽ có những nước mắt, nụ cười, đau khổ lẫn câm giận nhưng đừng e sợ, vì tình yêu sẽ mang chúng ta trở lại với 
nhau dù đó là thời khắc nào, chiều không gian nào đi nữa.','2017','./Images/firework.jpg','https://www.youtube.com/watch?v=WSfI5XtPEQQ')

INSERT INTO Phim VALUES(N'Giao Ước Chết',N'Kinh dị','Sophon Sakdaphisit','Numthip Jongrachatawiboon, Apichaya Thongkham, Panisara Rikulsurakan',18,
N'Năm 1997, hai cô gái Ib và Boum quyết định cùng nhau tự tử ở Bangkok, nhưng Boum đã không tự tử. Năm 2017, linh hồn thù hằn của Ib trở lại để ám ảnh 
Boum và cô con gái 15 tuổi. Ib và Boum là đôi bạn thân từ nhỏ, hai ông bố của Ib và Boum cũng là bạn làm ăn cùng đầu tư xây dựng một dự án căn hộ cao cấp.
Năm 1997, cuộc khủng hoảng tài chính ở Thái Lan bùng nổ. Từ hai tiểu thư giàu có xa hoa bỗng chốc cả hai không còn gì và phải gánh những
món nợ khổng lồ thay cha. Quẫn trí, họ quyết định cùng nhau tự sát, nhưng Boum không đủ can đảm như Ib nên đã bỏ chạy và ôm nỗi day 
dứt đó tiếp tục sống suốt 20 năm. Thời gian trôi đi, Boum trở thành một doanh nhân thành công và có một cô con gái xinh đẹp là Bell.
Như có một thế lực kì bí dẫn đường Bell vô tình tìm đến địa điểm khi xưa xảy ra biến cố kinh hoàng. Kể từ đó mỗi đêm là mỗi cơn ác
mộng không chỉ với Bell mà còn đối với Boum. Liệu hai mẹ con có thể thoát qua được kiếp nạn này hay cả hai cùng phải trả giá cho 
lời hứa bồng bột năm xưa?','2017','./Images/GiaoUocChet.jpg','https://www.youtube.com/watch?v=RAAltbA7ClY')

INSERT INTO Phim VALUES(N'Mẹ Chồng',N'Tâm lý',N'Lý Minh Thắng',N'Diễm My, Ngọc Quyên, Lan Khuê, Midu',14,N'Cuộc đời người phụ
 nữ Việt Nam dưới thời suy tàn của chế độ phong kiến: từ khi làm dâu cho đến khi lên làm mẹ chồng, tất cả đều là bi kịch vì sự ảnh hưởng
nặng nề của Nho giáo. Mẹ Chồng là câu chuyện xảy ra ở bối cảnh giả định mang tên Đại Điền vào những năm 1945 - 1950, xoay quanh cuộc đời
cô Ba Trân (Thanh Hằng), một người phụ nữ Nam Bộ chịu nhiều ảnh hưởng của nền giáo dục Nho giáo. Từ khi về làm dâu, Ba Trân luôn phải
chịu nhiều bất hạnh với những quy củ hà khắc từ gia đình nhà chồng. Ngỡ tưởng, những bi thương từng nếm trải sẽ khiến Ba Trân trở nên
 vị tha và nhân hậu hơn với con dâu mình. Thế nhưng, do sức ép của việc gìn giữ và duy trì nền nếp dòng họ, cô lại tiếp tục lặp lại con
 đường nhân bản bi kịch của mình lên những người phụ nữ khác khi cô trở thành mẹ chồng... Một bộ phim quy tụ dàn diễn viên nữ hấp dẫn
với Thanh Hằng, Diễm My, Ngọc Quyên, Lan Khuê, Midu...','2017','./Images/MeChong.jpg','https://www.youtube.com/watch?v=VKYdH1WrCQU&t=60s')

INSERT INTO Phim VALUES (N'Star Wars: Jedi Cuối Cùng',N'Viễn tưởng','Rian Johnson','Mark Hamill, Carrie Fisher, Daisy Ridley, 
John Boyega, Adam Driver, Kelly Marie Tran',16,N'Star Wars: Jedi Cuối Cùng là phần thứ 8 trong series kinh điển Star Wars, nối tiếp phần 7 
Star Wars: Thần lực thức tỉnh ra mắt vào năm 2015. Phần phim này có thể sẽ giải đáp những câu hỏi lớn ở phần trước đó: Nguồn gốc của Rey,
 tại sao R2-D2 lại có bản đồ dẫn đến chỗ Luke, và Chỉ huy Tối cao Snoke thực chất là ai?','2017','./Images/SW.jpg','https://www.youtube.com/watch?v=Q0CbN8sfihY')

/***** PhongChieu *****/
/*** ID bắt đầu từ 55555001 **/
INSERT INTO PhongChieu VALUES (N'P01', 135, 1)
INSERT INTO PhongChieu VALUES (N'P02', 135, 1)
INSERT INTO PhongChieu VALUES (N'P03', 135, 1)
INSERT INTO PhongChieu VALUES (N'P04', 135, 1)
INSERT INTO PhongChieu VALUES (N'P05', 135, 1)
INSERT INTO PhongChieu VALUES (N'P06', 135, 1)
INSERT INTO PhongChieu VALUES (N'P07', 135, 0)
INSERT INTO PhongChieu VALUES (N'P08', 135, 1)
INSERT INTO PhongChieu VALUES (N'P09', 135, 1)
INSERT INTO PhongChieu VALUES (N'P10', 135, 1)

 /***** SuatChieu *****/
 /*** ID bắt đầu từ 33333001 ***/
INSERT INTO SuatChieu VALUES(55555001, '16/06/2018', '11:00', 99999001)
INSERT INTO SuatChieu VALUES(55555004, '17/06/2018', '13:00', 99999001)
INSERT INTO SuatChieu VALUES(55555005, '18/06/2018', '15:00', 99999001)
INSERT INTO SuatChieu VALUES(55555008, '19/06/2018', '17:00', 99999001)

INSERT INTO SuatChieu VALUES(55555002,'05/07/2018','16:50', 99999002)
INSERT INTO SuatChieu VALUES(55555010,'05/07/2018','19:00', 99999002)
INSERT INTO SuatChieu VALUES(55555004,'06/07/2018','10:15', 99999002)
INSERT INTO SuatChieu VALUES(55555005,'09/07/2018','14:25', 99999002)

INSERT INTO SuatChieu VALUES(55555006,'14/07/2017','23:30', 99999004)
INSERT INTO SuatChieu VALUES(55555008,'15/07/2017','20:45', 99999004)
INSERT INTO SuatChieu VALUES(55555009,'15/07/2017','23:59', 99999004)

INSERT INTO SuatChieu VALUES(55555001,'24/07/2017','18:30', 99999003)
INSERT INTO SuatChieu VALUES(55555002,'24/07/2017','21:05', 99999003)
INSERT INTO SuatChieu VALUES(55555003,'25/07/2017','13:35', 99999003)

INSERT INTO SuatChieu VALUES(55555005, '26/07/2017','09:00', 99999005)
INSERT INTO SuatChieu VALUES(55555006, '26/07/2017','15:25', 99999005)

INSERT INTO SuatChieu VALUES(55555008, '27/06/2017','20:55', 99999006)
INSERT INTO SuatChieu VALUES(55555009, '27/06/2017','23:59', 99999006)
INSERT INTO SuatChieu VALUES(55555010, '28/06/2017','12:05', 99999006)

INSERT INTO SuatChieu VALUES(55555001, '30/07/2017','17:40', 99999007)
INSERT INTO SuatChieu VALUES(55555010, '31/07/2017','19:45', 99999007)

INSERT INTO SuatChieu VALUES(55555005, '02/08/2018','19:00', 99999008)
INSERT INTO SuatChieu VALUES(55555006, '03/08/2018','20:30', 99999008)
INSERT INTO SuatChieu VALUES(55555008, '03/08/2018','23:00', 99999008)

/***** Ve *****/
/*** ID bắt đầu từ 77777001, 0: vé thường, 1: vé vip ***/
INSERT INTO Ve VALUES(11111001, 33333001, 'G8', 0, 50000, 1, 0)
INSERT INTO Ve VALUES(11111001, 33333005, 'H6', 0, 50000, 1, 0)
INSERT INTO Ve VALUES(11111001, 33333005, 'H7', 0, 50000, 1, 0)
INSERT INTO Ve VALUES(11111002, 33333001, 'J7', 1, 80000, 1, 0)
INSERT INTO Ve VALUES(11111002, 33333001, 'J8', 1, 80000, 1, 0)
INSERT INTO Ve VALUES(11111003, 33333012, 'E7', 1, 80000, 1, 0)
INSERT INTO Ve VALUES(11111003, 33333012, 'E8', 1, 80000, 1, 0)
INSERT INTO Ve VALUES(11111003, 33333012, 'E9', 1, 80000, 1, 0)

/***** ThongKe *****/
/*** ID bắt đầu từ 22222001 ***/
INSERT INTO ThongKe VALUES(N'Thay máy chiếu', 15000000)
INSERT INTO ThongKe VALUES(N'Thay đèn phòng chiếu P07', 2000000)