USE [master]
GO
CREATE DATABASE [RapChieuPhim]

USE [RapChieuPhim]
GO
CREATE TABLE [dbo].[Admin](
	[AdminID] [varchar](10) NOT NULL,
	[TenDangNhap] [varchar](100) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[NgaySinh] [nvarchar](50) NOT NULL,
	[GioiTinh] [nvarchar](10) NOT NULL,
	[CMND] [varchar](50) NOT NULL,
	[SoDienThoai] [varchar](20) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Admin_1] PRIMARY KEY CLUSTERED 
(
	[AdminID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 17/11/2017 1:17:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKhachHang] [nvarchar](50) NOT NULL,
	[TenKhachHang] [nvarchar](50) NOT NULL,
	[NgaySinh] [nvarchar](50) NOT NULL,
	[GioiTinh] [nvarchar](10) NOT NULL,
	[CMND] [varchar](25) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[Email][varchar](50) NOT NULL,
	[SoDienThoai] [varchar](20) NOT NULL,
	[TenDangNhap] [varchar](100) NOT NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 17/11/2017 1:17:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [nvarchar](50) NOT NULL,
	[TenNhanVien] [nvarchar](50) NOT NULL,
	[NgaySinh] [nvarchar](50) NOT NULL,
	[GioiTinh] [nvarchar](10) NOT NULL,
	[CMND] [varchar](25) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[SoDienThoai] [varchar](20) NOT NULL,
	[ViTri] [nvarchar](40) NOT NULL,
	[TenDangNhap] [varchar](100) NOT NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Phim]    Script Date: 17/11/2017 1:17:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Phim](
	[MaPhim] [varchar](100) NOT NULL,
	[TenPhim] [nvarchar](100) NOT NULL,
	[TheLoai] [nvarchar](100) NOT NULL,
	[DaoDien] [nvarchar](100) NOT NULL,
	[DienVien] [nvarchar](100) NOT NULL,
	[GioiHanDoTuoi] [nchar](10) NOT NULL,
	[NoiDung] [nvarchar](3000) NOT NULL,
	[NamSanXuat] [int] NOT NULL,
	[Poster] [nvarchar](150) NOT NULL,
	[Trailer] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_Phim] PRIMARY KEY CLUSTERED 
(
	[MaPhim] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhongChieu]    Script Date: 17/11/2017 1:17:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhongChieu](
	[MaPhongChieu] [varchar](50) NOT NULL,
	[SoLuongChoNgoi] [int] NOT NULL,
	[LoaiMayChieu] [nvarchar](25) NOT NULL,
	[LoaiAmThanh] [nvarchar](25) NOT NULL,
	[TinhTrang] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_PhongChieu] PRIMARY KEY CLUSTERED 
(
	[MaPhongChieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[QuanLy]    Script Date: 17/11/2017 1:17:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[QuanLy](
	[MaQuanLy] [varchar](50) NOT NULL,
	[TenDangNhap] [varchar](100) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[NgaySinh] [nvarchar](50) NOT NULL,
	[GioiTinh] [nvarchar](10) NOT NULL,
	[CMND] [varchar](50) NOT NULL,
	[SoDienThoai] [varchar](20) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_QuanLy_1] PRIMARY KEY CLUSTERED 
(
	[MaQuanLy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 17/11/2017 1:17:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TenDangNhap] [varchar](100) NOT NULL,
	[MatKhau] [varchar](100) NOT NULL,
	[ChucNang] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ve]    Script Date: 17/11/2017 1:17:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
/*insert into Ve values('KH00003','VP001',N'Cô Ba Sài Gòn','17/11/2017','13:00','PC02','F06',75000)*/
CREATE TABLE [dbo].[Ve](
	[MaKhachHang] [nvarchar](50) NOT NULL,
	[MaVe] [varchar](50) NOT NULL,
	[TenPhim] [nvarchar](100) NOT NULL,
	[NgayChieu] [nvarchar](50) NOT NULL,
	[SuatChieu] [nvarchar](50) NOT NULL,
	[MaPhongChieu] [varchar](50) NOT NULL,
	[ViTriNgoi] [nvarchar](60) NOT NULL,
	[Gia] [int] NOT NULL,
 CONSTRAINT [PK_Ve] PRIMARY KEY CLUSTERED 
(
	[MaVe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


CREATE TABLE [dbo].[LichChieu]
(
	[TenPhim] [nvarchar](100) NOT NULL,
	[NgayChieu] [nvarchar](50) NOT NULL,
	[SuatChieu] [nvarchar](50) NOT NULL,
	[MaPhongChieu] [varchar](50) NOT NULL,
	PRIMARY KEY ([MaPhongChieu], [NgayChieu], [SuatChieu])
)

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Admin]  WITH CHECK ADD  CONSTRAINT [FK_Admin_TaiKhoan] FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[TaiKhoan] ([TenDangNhap])
GO
ALTER TABLE [dbo].[Admin] CHECK CONSTRAINT [FK_Admin_TaiKhoan]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_TaiKhoan] FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[TaiKhoan] ([TenDangNhap])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_TaiKhoan]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_TaiKhoan] FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[TaiKhoan] ([TenDangNhap])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_TaiKhoan]
GO
ALTER TABLE [dbo].[QuanLy]  WITH CHECK ADD  CONSTRAINT [FK_QuanLy_TaiKhoan] FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[TaiKhoan] ([TenDangNhap])
GO
ALTER TABLE [dbo].[QuanLy] CHECK CONSTRAINT [FK_QuanLy_TaiKhoan]
GO
ALTER TABLE [dbo].[Ve]  WITH CHECK ADD  CONSTRAINT [FK_Ve_KhachHang] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[Ve] CHECK CONSTRAINT [FK_Ve_KhachHang]
GO
ALTER TABLE [dbo].[Ve]  WITH CHECK ADD  CONSTRAINT [FK_Ve_PhongChieu] FOREIGN KEY([MaPhongChieu])
REFERENCES [dbo].[PhongChieu] ([MaPhongChieu])
GO
ALTER TABLE [dbo].[Ve] CHECK CONSTRAINT [FK_Ve_PhongChieu]
GO
USE [master]
GO
ALTER DATABASE [RapChieuPhim] SET  READ_WRITE 
GO

use RapChieuPhim

insert into TaiKhoan values('thanhhung','4411','KH')
insert into TaiKhoan values('anonymous','4444','KH')
insert into TaiKhoan values('catluong','cat999','NV')
insert into TaiKhoan values('huydinh','321654','NV')
insert into TaiKhoan values('huynguyenle','1900','AD')
insert into TaiKhoan values('huynh69','1924','KH')
insert into TaiKhoan values('machoan','999','NV')
insert into TaiKhoan values('machon','8888','AD')
insert into TaiKhoan values('MNG01','quanly123','QL')
insert into TaiKhoan values('MNG02','quanly321','QL')
insert into TaiKhoan values('nntt1301','thaonguyen','KH')
insert into TaiKhoan values('quankun','quan','AD')
insert into TaiKhoan values('trangkute80','gnart','KH')


insert into KhachHang values('KH00000',N'Nguyễn Thanh Hùng','25/12/1997','Nam','024457956',N'113 Nguyễn Văn Cừ','nthung@gmail.com','01697852548','thanhhung')
insert into KhachHang values('KH00001','Anonymous','22/12/1998','Nam','024452346',N'45 Phan Văn Trị','anonymous@gmail.com','01697855448','anonymous')
insert into KhachHang values('KH00002',N'Nguyễn Hoàng Huy','6/9/1995','Nam','025576248',N'53/9/24 Lương Ngọc Quyến P5 Quận Gò Vấp TP.HCM','nhhuy@gmail.com','01635157348','huynh69')
insert into KhachHang values('KH00003',N'Nguyễn Ngọc Thanh Thảo','13/01/1997',N'Nữ','014536742',N'30/18F Bà Điểm, Hóc Môn, TPHCM','nntthao@gmail.com','01652239124','nntt1301')
insert into KhachHang values('KH00004',N'Tô Thị Thùy Trang','13/05/1997',N'Nữ','032678471',N'352 Hồ Thị Nghĩa P1. Q.10 TP.HCM','ttttrang@gmail.com','01635194783','trangkute80')


insert into Admin values ('AD001','huynguyenle','huynguyenle1101@gmail.com',N'Nguyễn Lê Huy','11/01/1997','Nam','02557630','01647661447',N'122/12 Phan Văn Hân P17 Q. Bình Thạnh TP.HCM')
insert into Admin values ('AD003','quankun','quankun69@gmail.com',N'Vũ Minh Quân','23/06/1997','Nam','07402385','01647851234',N'641/1/4, Quang Trung, P11, Q.Gò Vấp')
insert into Admin values ('AD002','machon','machoan123@gmail.com',N'Mạc Minh Hoàng','21/2/1997','Nam','08967631','0903745785',N'12 Nguyễn Thanh Tuyền, P2, Q.Tân Bình')


insert into NhanVien values ('NV0000',N'Nguyễn Minh Mạc','11/11/1997','Nam','01356177',N'602/39/31 Điện Biên Phủ, P22, Q.Bình Thạnh','01647991236',N'Bán vé','machoan','minhmac88@gmail.com')
insert into NhanVien values ('NV0001',N'Nguyễn Cát Lượng','31/05/1997','Nam','01468579',N'175 Man Thiện - P Hiệp Phú - Q9','01647997803',N'Bán thức ăn/nước uống','catluong','catluong543@yahoo.com')
insert into NhanVien values ('NV0002',N'Nguyễn Huy Đinh','11/01//1997',N'Nữ','01356987',N'621/30a tổ 3, KP1, P. Trung Mỹ Tây, Q.12','0963562748', N'Vệ sinh','huydinh','huydinh123@gmail.com')

insert into Phim values ('P000',N'Cô Ba Sài Gòn',N'Tâm lý',N'Trần Bửu Lộc, Kay Nguyễn',N' Ngô Thanh Vân, Ninh Dương Lan Ngọc, Diễm My, Hồng Vân,
 Diễm My 9X, Oanh Kiều và S.T.','PG',N'Cô Ba Sài Gòn là hành trình thú vị của Như Ý – cô chủ hiệu may Thanh Nữ, vô tình xuyên không đến tương lai. Là cô gái thế kỷ 20 mang lý tưởng bảo vệ chiếc áo dài thiêng liêng và truyền thống,
  Như Ý vô cùng bỡ ngỡ khi đứng trước xã hội ở thế kỷ 21 với nhiều thay đổi. Hơn hết, Như Ý phải đối mặt với chính cô của tương lai. Như Ý tìm cách trở về thế giới của mình, bằng cách phải lấy chiếc áo dài cũ từ chính phiên bản Như Ý của tương lai.','2017',
  './Images/CBSG.jpg','https://www.youtube.com/watch?v=YP4TDQVkZO4')

insert into Phim values('P001',N'24 Giờ Hồi Sinh',N'Hành Động','Brian Smrz','Rutger Hauer, Ethan Hawke, Paul Anderson','
18+',N'Sau một cuộc phẫu thuật thử nghiệm, sát thủ Travis Conrad được hồi sinh từ cõi chết và có đúng 24 giờ để sống lại. Anh quyết định hợp 
tác với chính nữ đặc vụ đã giết chết mình nhằm trả thù tổ chức tội phạm đã sát hại vợ và con của anh. Đây cũng chính là cơ hội để Travis chuộc
 lại những lỗi lầm trong quá khứ. Chỉ có 24 giờ để báo thù, liệu Travis có hoàn thành được nhiệm vụ khi từng giây trôi qua, tử thần lại càng
  đến gần hơn?','2017','./Images/24h.jpg','https://www.youtube.com/watch?v=e1Dam6exiYE')

insert into Phim values('P002',N'Liên Minh Công Lý ( Justice League)',N'Hành Động','Zack Snyder','Ben Affleck, Gal Gadot, Henry Cavill, 
Jason Momoa, Ezra Miller','13+',N'Được thôi thúc bằng niềm tin vào loài người vừa tìm lại và sự hy sinh cao cả của Superman, tỷ phú Bruce Wayne 
– Batman quyết định tìm kiếm và tập họp những đồng minh mới cũng như Wonder Woman để chuẩn bị đối mặt với những kẻ thù lớn hơn. 
Phim tiếp tục được giao vào tay đạo diễn Zack Snyder – người gây nhiều tranh cãi khi cầm trịch Batman v Superman: Dawn Of Justice.
 Dàn diễn viên quen thuộc Ben Affleck, Henry Cavill và Gal Gadot tiếp tục góp mặt trong phim. Justice League được xem là siêu phẩm hoành tráng
  nhất của DC Comics.','2017','./Images/Justice-League-banner.jpg','https://www.youtube.com/watch?v=r9-DM9uBtVI')

insert into Phim values('P003',N'Trải Nghiệm Điểm Chết (Flatliners)',N'Kinh Dị','Niels Arden Oplev','Ellen Page, Diego Luna, Nina Dobrev','
16+',N'Năm sinh viên y khoa tham gia vào một thí nghiệm cực kỳ nguy hiểm: Chết lâm sàng để được trải nghiệm cảm giác chu du "thế giới bên kia".
 Đây là trải nghiệm độc đáo có một không hai và nó khiến các chàng trai cô gái trẻ mê mẩn. Phim sở hữu cốt truyện hấp dẫn và đậm tính nhân văn.
  Theo đó, thế giới bên kia không phải nơi để bạn an nghỉ mà chính là “pháp trường” nơi bạn phải đối diện với những tội lỗi mình đã gây ra khi 
  còn sống. Là phần tiếp theo của bộ phim cùng tên do đạo diễn Joel Schumacher thực hiện năm 1990, Flatliners 2017 (tựa tiếng Việt là Trải 
  Nghiệm Điểm Chết) sở hữu dàn diễn viên trẻ trung do Sony tuyển chọn hứa hẹn sẽ phát huy và vượt qua cái bóng của phần cũ, chinh phục khán
   giả. Phim được đạo diễn bởi Niels Arden Oplev (Girl With The Dragon Tattoo bản Thụy Điển). Chúng ta sẽ đi đâu sau khi chết? Thế giới dành 
   cho các linh hồn như thế nào? Đó là đề tài rất hấp dẫn trí tò mò của con người.','2017','./Images/flatliners.jpg','https://www.youtube.com/watch?v=gUDV0CUzG0k')

insert into Phim values ('P004',N'Pháo Hoa, Nên Ngắm Từ Dưới Hay Bên Cạnh',N'Hoạt hình','Akiyuki Shimbo','Suzu Hirose, Masaki Suda, Mamoru Miyano',
'PG',N'Bộ phim truyền tải một thông điệp mạnh mẽ cho những người trẻ ngoài kia hãy sống và yêu khi còn bùng cháy ngọn lửa thanh xuân cùng 
những chân tình tinh khôi. Sẽ có những nước mắt, nụ cười, đau khổ lẫn câm giận nhưng đừng e sợ, vì tình yêu sẽ mang chúng ta trở lại với 
nhau dù đó là thời khắc nào, chiều không gian nào đi nữa.','2017','./Images/firework.jpg','https://www.youtube.com/watch?v=WSfI5XtPEQQ')
insert into Phim values('P005',N'Giao Ước Chết',N'Kinh dị','Sophon Sakdaphisit','Numthip Jongrachatawiboon, Apichaya Thongkham, Panisara Rikulsurakan','18+',
N'Năm 1997, hai cô gái Ib và Boum quyết định cùng nhau tự tử ở Bangkok, nhưng Boum đã không tự tử. Năm 2017, linh hồn thù hằn của Ib trở lại để ám ảnh 
Boum và cô con gái 15 tuổi. Ib và Boum là đôi bạn thân từ nhỏ, hai ông bố của Ib và Boum cũng là bạn làm ăn cùng đầu tư xây dựng một dự án căn hộ cao cấp.
Năm 1997, cuộc khủng hoảng tài chính ở Thái Lan bùng nổ. Từ hai tiểu thư giàu có xa hoa bỗng chốc cả hai không còn gì và phải gánh những
món nợ khổng lồ thay cha. Quẫn trí, họ quyết định cùng nhau tự sát, nhưng Boum không đủ can đảm như Ib nên đã bỏ chạy và ôm nỗi day 
dứt đó tiếp tục sống suốt 20 năm. Thời gian trôi đi, Boum trở thành một doanh nhân thành công và có một cô con gái xinh đẹp là Bell.
Như có một thế lực kì bí dẫn đường Bell vô tình tìm đến địa điểm khi xưa xảy ra biến cố kinh hoàng. Kể từ đó mỗi đêm là mỗi cơn ác
mộng không chỉ với Bell mà còn đối với Boum. Liệu hai mẹ con có thể thoát qua được kiếp nạn này hay cả hai cùng phải trả giá cho 
lời hứa bồng bột năm xưa?','2017','./Images/GiaoUocChet.jpg','https://www.youtube.com/watch?v=RAAltbA7ClY')
insert into Phim values('P006',N'Mẹ Chồng',N'Tâm lý',N'Lý Minh Thắng',N'Diễm My, Ngọc Quyên, Lan Khuê, Midu','16+',N'Cuộc đời người phụ
 nữ Việt Nam dưới thời suy tàn của chế độ phong kiến: từ khi làm dâu cho đến khi lên làm mẹ chồng, tất cả đều là bi kịch vì sự ảnh hưởng
nặng nề của Nho giáo. Mẹ Chồng là câu chuyện xảy ra ở bối cảnh giả định mang tên Đại Điền vào những năm 1945 - 1950, xoay quanh cuộc đời
cô Ba Trân (Thanh Hằng), một người phụ nữ Nam Bộ chịu nhiều ảnh hưởng của nền giáo dục Nho giáo. Từ khi về làm dâu, Ba Trân luôn phải
chịu nhiều bất hạnh với những quy củ hà khắc từ gia đình nhà chồng. Ngỡ tưởng, những bi thương từng nếm trải sẽ khiến Ba Trân trở nên
 vị tha và nhân hậu hơn với con dâu mình. Thế nhưng, do sức ép của việc gìn giữ và duy trì nền nếp dòng họ, cô lại tiếp tục lặp lại con
 đường nhân bản bi kịch của mình lên những người phụ nữ khác khi cô trở thành mẹ chồng... Một bộ phim quy tụ dàn diễn viên nữ hấp dẫn
với Thanh Hằng, Diễm My, Ngọc Quyên, Lan Khuê, Midu...','2017','./Images/MeChong.jpg','https://www.youtube.com/watch?v=VKYdH1WrCQU&t=60s')

insert into Phim values ('P007',N'Star Wars: Jedi Cuối Cùng',N'Khoa học viễn tưởng','Rian Johnson','Mark Hamill, Carrie Fisher, Daisy Ridley, 
John Boyega, Adam Driver, Kelly Marie Tran','PG',N'Star Wars: Jedi Cuối Cùng là phần thứ 8 trong series kinh điển Star Wars, nối tiếp phần 7 
Star Wars: Thần lực thức tỉnh ra mắt vào năm 2015. Phần phim này có thể sẽ giải đáp những câu hỏi lớn ở phần trước đó: Nguồn gốc của Rey,
 tại sao R2-D2 lại có bản đồ dẫn đến chỗ Luke, và Chỉ huy Tối cao Snoke thực chất là ai?','2017','./Images/SW.jpg','https://www.youtube.com/watch?v=Q0CbN8sfihY')

insert into PhongChieu values('PC01','250','BenQ',N'Chuẩn',N'Tốt')
insert into PhongChieu values('PC02','180','Vivitek','DolbyAtmos',N'Cần bảo trì')
insert into PhongChieu values('PC03','60','Optoma',N'Chuẩn',N'Tốt')
insert into PhongChieu values('PC04','120','Vivitek',N'Vòm',N'Tốt')
insert into PhongChieu values('PC05','210','BenQ','DolbyAtmos',N'Cần bảo trì')

insert into LichChieu values(N'Cô Ba Sài Gòn', '16/11/2017', '11:00', 'PC02')
insert into LichChieu values(N'Cô Ba Sài Gòn', '17/11/2017', '13:00', 'PC02')
insert into LichChieu values(N'Cô Ba Sài Gòn', '18/11/2017', '15:00', 'PC02')
insert into LichChieu values(N'Cô Ba Sài Gòn', '19/11/2017', '17:00', 'PC02')

insert into LichChieu values(N'24 Giờ Hồi Sinh','05/01/2018','16:50','PC03')
insert into LichChieu values(N'24 Giờ Hồi Sinh','05/01/2018','19:00','PC03')
insert into LichChieu values(N'24 Giờ Hồi Sinh','06/01/2018','10:15','PC03')
insert into LichChieu values(N'24 Giờ Hồi Sinh','09/01/2018','14:25','PC03')

insert into LichChieu values(N'Trải Nghiệm Điểm Chết (Flatliners)','14/12/2017','23:30','PC04')
insert into LichChieu values(N'Trải Nghiệm Điểm Chết (Flatliners)','15/12/2017','20:45','PC04')
insert into LichChieu values(N'Trải Nghiệm Điểm Chết (Flatliners)','15/12/2017','23:59','PC04')

insert into LichChieu values(N'Liên Minh Công Lý ( Justice League)','24/12/2017','18:30','PC01')
insert into LichChieu values(N'Liên Minh Công Lý ( Justice League)','24/12/2017','21:05','PC01')
insert into LichChieu values(N'Liên Minh Công Lý ( Justice League)','25/12/2017','13:35','PC01')

insert into LichChieu values(N'Pháo Hoa, Nên Ngắm Từ Dưới Hay Bên Cạnh','26/12/2017','09:00','PC05')
insert into LichChieu values(N'Pháo Hoa, Nên Ngắm Từ Dưới Hay Bên Cạnh','26/12/2017','15:25','PC05')

insert into LichChieu values(N'Giao Ước Chết','27/12/2017','20:55','PC01')
insert into LichChieu values(N'Giao Ước Chết','27/12/2017','23:59','PC01')
insert into LichChieu values(N'Giao Ước Chết','28/12/2017','12:05','PC01')

insert into LichChieu values(N'Mẹ Chồng','30/12/2017','17:40','PC03')
insert into LichChieu values(N'Mẹ Chồng','31/12/2017','19:45','PC03')

insert into LichChieu values(N'Star Wars: Jedi Cuối Cùng','02/01/2018','19:00','PC04')
insert into LichChieu values(N'Star Wars: Jedi Cuối Cùng','03/01/2018','20:30','PC04')
insert into LichChieu values(N'Star Wars: Jedi Cuối Cùng','03/01/2018','23:00','PC04')

insert into Ve values('KH00003','V000',N'Cô Ba Sài Gòn','17/11/2017','13:00','PC02','F6',75000)
--insert into Ve values('KH00004','VP002',N'Trải Nghiệm Điểm Chết (Flatliners)','11/9/2017','PC05','G01',45000)
--insert into Ve values('KH00004','VP003',N'Trải Nghiệm Điểm Chết (Flatliners)','11/9/2017','PC05','G02',45000)
--insert into Ve values('KH00004','VP004',N'Trải Nghiệm Điểm Chết (Flatliners)','11/9/2017','PC05','G03',45000)
--insert into Ve values('KH00004','VP005',N'Trải Nghiệm Điểm Chết (Flatliners)','11/9/2017','PC05','G04',45000)
--insert into Ve values('KH00001','VP006',N'Liên Minh Công Lý ( Justice League)','17/11/2017','PC01','O01',155000)

insert into QuanLy values('QL00','MNG01','abc@gmail.com',N'Nguyễn A','23/01/1980','Nam','23467832','0135658645',N'Quận 5')
insert into QuanLy values('QL01','MNG02','adsbc@gmail.com',N'Nguyễn B','22/01/1980','Nam','23367832','0235658645',N'Quận 1')