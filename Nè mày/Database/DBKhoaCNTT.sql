use master
go
alter database DbKhoaCNTT set SINGLE_USER WITH ROLLBACK IMMEDIATE;
go
drop database DbKhoaCNTT
GO
CREATE DATABASE DbKhoaCNTT
GO
USE DbKhoaCNTT
GO

---1. 

CREATE TABLE Chucvu
(
	Machucvu VARCHAR(50) PRIMARY KEY,
	Tenchucvu NVARCHAR(100),
	Flag BIT
)
GO
 INSERT INTO Chucvu VALUES  ( 'CV1', N'Giáo viên', 1)
 INSERT INTO Chucvu VALUES  ( 'CV2', N'Phó trưởng khoa', 1)
 INSERT INTO Chucvu VALUES  ( 'CV3', N'Trưởng khoa ', 1)
 INSERT INTO Chucvu VALUES  ( 'CV4', N'Trợ lý Khoa học', 1)
 INSERT INTO Chucvu VALUES  ( 'CV5', N'Trợ lý Văn thể mỹ', 1)
 INSERT INTO Chucvu VALUES  ( 'CV6', N'Trợ lý Phòng máy', 1)
 INSERT INTO Chucvu VALUES  ( 'CV7', N'Trợ lý Olymic', 1)
 INSERT INTO Chucvu VALUES  ( 'CV8', N'Trợ lý Văn phòng khoa', 1)

GO

--2.
CREATE TABLE Taikhoan
(	
	Tentaikhoan VARCHAR(100) PRIMARY KEY,
	Machucvu VARCHAR(50),
	Matkhau VARCHAR(1000),
	TGdangki datetime,
	Mail varchar(100),
	Trangthaihd varchar(10), /* ý chỉ trạng thái online */
	Flag BIT,
	FOREIGN KEY (Machucvu) REFERENCES dbo.Chucvu(Machucvu)
)
GO

--Giaovien
 INSERT INTO Taikhoan VALUES( 'IT1','CV1','12345','12-12-2007', 'tanhtsgu@gmail.com','Offline',1)
 INSERT INTO Taikhoan VALUES( 'IT2','CV1','12345','11-2-2012','nguyennhus293@gmail.com','Offline',1)
 --Photruongkhoa
 INSERT INTO Taikhoan VALUES( 'IT5','CV2','12345','2-1-2007','trangtruong166@gmail.com', 'Offline',1)
 INSERT INTO Taikhoan VALUES( 'IT6','CV2','12345','1-12-2012','trangtruong166@gmail.com','Offline',1)
 ---Truongkhoa
 INSERT INTO Taikhoan VALUES( 'IT7','CV3','12345','12-2-2015','nguyennhus293@gmail.com', 'Offline',1)
 INSERT INTO Taikhoan VALUES( 'IT8','CV3','12345','11-13-2013','tanhtsgu@gmail.com', 'Offline',1)
 ---TrolyKhoahoc
 INSERT INTO Taikhoan VALUES( 'IT9','CV4','12345','11-11-2011','tanhtsgu@gmail.com', 'Offline',1)
 INSERT INTO Taikhoan VALUES( 'IT10','CV4','12345','11-20-2005','trangtruong166@gmail.com', 'Offline',1)
 ---TrolyVanthemy
 INSERT INTO Taikhoan VALUES( 'IT11','CV5','12345','11-11-2006','trangtruong166@gmail.com', 'Offline',1)
 INSERT INTO Taikhoan VALUES( 'IT12','CV5','12345','11-11-2003','nguyennhus293@gmail.com', 'Offline',1)
 ---TrolyPhongmay
 INSERT INTO Taikhoan VALUES( 'IT13','CV6','12345','1-1-2008','nguyennhus293@gmail.com','Offline',1)
 INSERT INTO Taikhoan VALUES( 'IT14','CV6','12345','2-2-2005','tanhtsgu@gmail.com','Offline',1)
 ---TrolyOlympic
 INSERT INTO Taikhoan VALUES( 'IT15','CV7','12345','3-2-2000','tanhtsgu@gmail.com', 'Offline',1)
 INSERT INTO Taikhoan VALUES( 'IT16','CV7','12345','5-2-2017','trangtruong166@gmail.com','Offline',1)
 ---TrolyVanphongkhoa 
 INSERT INTO Taikhoan VALUES( 'IT3','CV8','12345','3-22-2005','tanhtsgu@gmail.com','Offline',1)
 INSERT INTO Taikhoan VALUES( 'IT4','CV8','12345','11-5-2002','nguyennhus293@gmail.com', 'Offline',1)
 
GO
--3.
CREATE TABLE Thongtinnguoidung
(
	STT INT IDENTITY PRIMARY KEY,
	Hoten NVARCHAR(100), 
	Namsinh DATE,
	Sodienthoai VARCHAR(15),
	Quequan NVARCHAR(100),
	Tentaikhoan VARCHAR(100),
	Flag BIT,
	FOREIGN KEY (Tentaikhoan) REFERENCES DBO.Taikhoan(Tentaikhoan)
)
GO



INSERT INTO Thongtinnguoidung(Hoten, Namsinh, Sodienthoai, Quequan, Tentaikhoan, Flag) 
	VALUES (N'Nguyễn Văn Long' ,'12-8-1990' ,'0366789741' ,N'TPHCM', 'IT1' ,1)
 
INSERT INTO Thongtinnguoidung(Hoten, Namsinh, Sodienthoai, Quequan, Tentaikhoan, Flag)
	VALUES  (N'Trân Thị Hồng' , '2-5-1979'  ,'0346804211' ,N'TPHCM', 'IT2' ,1)

INSERT INTO Thongtinnguoidung(Hoten, Namsinh, Sodienthoai, Quequan, Tentaikhoan, Flag)  
	VALUES (N'Cao Khánh Duy' ,'3-7-1987' , '0368404212' ,N'TPHCM', 'IT3' ,1)

INSERT INTO Thongtinnguoidung(Hoten, Namsinh, Sodienthoai, Quequan, Tentaikhoan, Flag) 
	VALUES  (N'Nguyễn Thị Hà' ,'1-12-1990' ,'0331246612' ,N'TPHCM', 'IT4' ,1)

INSERT INTO Thongtinnguoidung(Hoten, Namsinh, Sodienthoai, Quequan, Tentaikhoan, Flag) 
	VALUES  (N'Đinh Thị Na' ,'11-15-1990' ,'034680427' ,N'TPHCM', 'IT5' ,1)

INSERT INTO Thongtinnguoidung(Hoten, Namsinh, Sodienthoai, Quequan, Tentaikhoan, Flag)
	VALUES  (N'Trần Cao Thúy' ,'1-7-1989' ,'0356680421' ,N'TPHCM', 'IT6' ,1)

INSERT INTO Thongtinnguoidung(Hoten, Namsinh, Sodienthoai, Quequan, Tentaikhoan, Flag) 
	VALUES (N'Nguyễn Hoàng Long' ,'5-1-1980' ,'091860935' ,N'TPHCM', 'IT7'  ,1)

INSERT INTO Thongtinnguoidung(Hoten, Namsinh, Sodienthoai, Quequan, Tentaikhoan, Flag) 
	VALUES  (N'Bá Văn Đàn' ,'1-10-1970' ,'093692745' ,N'TPHCM', 'IT8' ,1)

INSERT INTO Thongtinnguoidung(Hoten, Namsinh, Sodienthoai, Quequan, Tentaikhoan, Flag) 
	VALUES  (N'Trần Minh Phúc' ,'8-2-1990' ,'099533384' ,N'TPHCM', 'IT9' ,1)

INSERT INTO Thongtinnguoidung(Hoten, Namsinh, Sodienthoai, Quequan, Tentaikhoan, Flag) 
	VALUES  (N'Hoàng Ngọc Long' ,'1-5-1988' ,'0947856578' ,N'TPHCM', 'IT10' ,1)

INSERT INTO Thongtinnguoidung(Hoten, Namsinh, Sodienthoai, Quequan, Tentaikhoan, Flag) 
	VALUES  (N'Thiên Văn Minh' ,'3-6-1970' ,'0987652321' ,N'TPHCM', 'IT11' ,1)

INSERT INTO Thongtinnguoidung(Hoten, Namsinh, Sodienthoai, Quequan, Tentaikhoan, Flag)
	 VALUES  (N'Đinh Hoàn' ,'12-1-1990' ,'0987854322' ,N'TPHCM', 'IT12' ,1)

INSERT INTO Thongtinnguoidung(Hoten, Namsinh, Sodienthoai, Quequan, Tentaikhoan, Flag) 
	VALUES  (N'Trần Bá Xú' ,'2-11-1988' ,'0987657521' ,N'TPHCM', 'IT13' ,1)

INSERT INTO Thongtinnguoidung(Hoten, Namsinh, Sodienthoai, Quequan, Tentaikhoan, Flag) 
	VALUES  (N'Nguyễn Ngọc Hải' ,'2-11-1986' ,'0982254321' ,N'TPHCM', 'IT14' ,1)

INSERT INTO Thongtinnguoidung(Hoten, Namsinh, Sodienthoai, Quequan, Tentaikhoan, Flag) 
	VALUES  (N'Cao Minh Đàn' ,'2-12-1983' ,'0987652221' ,N'TPHCM', 'IT15' ,1)

INSERT INTO Thongtinnguoidung(Hoten, Namsinh, Sodienthoai, Quequan, Tentaikhoan, Flag)
	VALUES  (N'Hoàng Ngọc Tiên' ,'8-1-1985' ,'0982554321' ,N'TPHCM', 'IT16' ,1)

GO

--4.
CREATE TABLE CongtacSV
(
	MaCTSV VARCHAR(50) PRIMARY KEY,
	TenCTSV NVARCHAR(100)
)
GO

INSERT INTO dbo.CongtacSV ( MaCTSV, TenCTSV ) VALUES  ( 'CTSV1', N'Biểu mẫu' )
INSERT INTO dbo.CongtacSV ( MaCTSV, TenCTSV ) VALUES  ( 'CTSV2', N'Quy định' )
INSERT INTO dbo.CongtacSV ( MaCTSV, TenCTSV ) VALUES  ( 'CTSV3', N'Quy trình' )
INSERT INTO dbo.CongtacSV ( MaCTSV, TenCTSV ) VALUES  ( 'CTSV4', N'Danh sách khóa luận tốt nghiệp' )

GO

--5.
CREATE TABLE NDCongtacSV
(
	MaNDCTSV VARCHAR(50) PRIMARY KEY,
	MaCTSV VARCHAR(50),
	Tentaikhoan VARCHAR(100),
	Tieude nvarchar(100),
	NoidungCTSV NVARCHAR(MAX),
	Ngaydang DATETIME,
	flag BIT,
	FOREIGN KEY (MaCTSV) REFERENCES dbo.CongtacSV(MaCTSV),
	FOREIGN KEY (Tentaikhoan) REFERENCES dbo.Taikhoan(Tentaikhoan)
)

GO

INSERT INTO dbo.NDCongtacSV( MaNDCTSV , MaCTSV ,Tentaikhoan ,Tieude ,Ngaydang , flag )
VALUES   ( 'ND1' , 'CTSV1' ,'IT3',  N'Biểu mẫu Chế độ chính sách' , '08-03-2018'  , 1)

INSERT INTO dbo.NDCongtacSV( MaNDCTSV , MaCTSV ,Tentaikhoan ,Tieude ,NoidungCTSV ,Ngaydang , flag )
VALUES ( 'ND2' , 'CTSV1' ,'IT3',  N'Biểu mẫu Khóa luận tốt nghiệp' ,N'Các biểu mẫu dành cho Sinh viên và Giảng viên ', '08-03-2018'  , 1)

INSERT INTO dbo.NDCongtacSV( MaNDCTSV , MaCTSV ,Tentaikhoan ,Tieude  ,Ngaydang , flag )
VALUES( 'ND3' , 'CTSV2','IT4' ,  N'Quy định chuẩn đầu ra ngành Công nghệ Thông tin' , '08-03-2018'  , 1 )

INSERT INTO dbo.NDCongtacSV( MaNDCTSV , MaCTSV ,Tentaikhoan ,Tieude ,Ngaydang , flag )
VALUES ( 'ND4' , 'CTSV2','IT4' ,  N'Tài liệu hướng dẫn, quy định và các biểu mẫu thực tập' , '08-03-2018'  , 1)

INSERT INTO dbo.NDCongtacSV( MaNDCTSV , MaCTSV ,Tentaikhoan ,Tieude ,NoidungCTSV ,Ngaydang , flag )
VALUES  ( 'ND5' , 'CTSV3','IT3' ,  N'Khóa Luận Tốt Nghiệp' , N'Các bước hướng dẫn sinh viên làm khóa luận tốt nghiệp','08-03-2018'  , 1)

INSERT INTO dbo.NDCongtacSV( MaNDCTSV , MaCTSV ,Tentaikhoan ,Tieude ,NoidungCTSV ,Ngaydang , flag )
VALUES ( 'ND6' , 'CTSV3' ,'IT3',  N'Thủ tục xin thôi học',N'Bước 1: Sinh viên điền thông tin vào đơn thôi học, đưa cho phụ huynh kí xác nhận sau đó nộp về khoa để kí xác nhận. Bước 2: Sau khi Khoa xác nhận, sinh viên nộp về Phòng Công tác sinh viên. Bước 3: Phòng Công tác sinh viên làm thủ tục ra quyết định thôi học cho sinh viên. (Lưu ý: đối với sinh viên Sư phạm phải làm thủ tục bồi hoàn kinh phí đào tạo theo qui định). Bước 4: Phòng Công tác sinh viên sẽ thông báo kết quả giải quyết đơn cho Khoa và sinh viên.' , '08-03-2018'  , 1)

INSERT INTO dbo.NDCongtacSV( MaNDCTSV , MaCTSV ,Tentaikhoan ,Tieude  ,Ngaydang , flag )
VALUES ( 'ND7' , 'CTSV4' ,'IT4',  N'Khóa luận Tốt nghiệp' , '08-03-2018'  , 1)

GO


---6.
CREATE TABLE Tag
(
	TagID VARCHAR(50) PRIMARY KEY,
	TenTag NVARCHAR(100),
	Tentaikhoan VARCHAR(100),
	Flag BIT,
	FOREIGN KEY (Tentaikhoan) REFERENCES dbo.Taikhoan(Tentaikhoan)
)

INSERT INTO dbo.Tag VALUES  ( '1', N'Khoa học','IT9', 1)
INSERT INTO dbo.Tag VALUES  ( '2', N'Văn phòng','IT4',1)
INSERT INTO dbo.Tag VALUES  ( '3', N'Văn thể mỹ','IT11', 1)
INSERT INTO dbo.Tag VALUES  ( '4', N'Phòng máy','IT13', 1)
INSERT INTO dbo.Tag VALUES  ( '5', N'Đoàn-hội','IT12', 1)
INSERT INTO dbo.Tag VALUES  ( '6', N'Tuyển dụng','IT3', 1)
INSERT INTO dbo.Tag VALUES  ( '7', N'Tuyển sinh','IT3', 1)
INSERT INTO dbo.Tag VALUES  ( '8', N'Olympic','IT15', 1)


GO
---7.      
CREATE TABLE Loaibaidang
(
	Maloai VARCHAR(50) PRIMARY KEY,
	Tenloai NVARCHAR(100),
	Mota NVARCHAR(100),
	Flag BIT,

)
GO

INSERT INTO dbo.Loaibaidang VALUES  ( 'SK',N'Tin tức - Sự kiện',N'Tin tức và sự kiện liên quan đến khoa và các thông báo khác', 1)

INSERT INTO dbo.Loaibaidang VALUES  ( 'TD',N'Thực tập - Tuyển dụng',N'Những tin tức liên quan đến thực tập tuyển dụng cho sinh viên', 1)

INSERT INTO dbo.Loaibaidang VALUES  ( 'TS',N'Thông tin tuyển sinh',N'Những thông tin liên quan đến tuyển sinh các khóa', 1)

GO

---8.
CREATE TABLE ChitietLoaiBaiDang
(	
	MaCTLoaiBD VARCHAR(50),
	TagID VARCHAR(50),
	Flag BIT,
	PRIMARY KEY (MaCTLoaiBD,TagID),
	FOREIGN KEY (TagID) REFERENCES dbo.Tag(TagID),
	FOREIGN KEY (MaCTLoaiBD) REFERENCES dbo.Loaibaidang(Maloai)
)
GO

INSERT INTO dbo.ChitietLoaiBaiDang  VALUES  ( 'SK', '1', 1)
INSERT INTO dbo.ChitietLoaiBaiDang  VALUES  ( 'SK', '2', 1)
INSERT INTO dbo.ChitietLoaiBaiDang  VALUES  ( 'SK', '3', 1)
INSERT INTO dbo.ChitietLoaiBaiDang  VALUES  ( 'SK', '4', 1)
INSERT INTO dbo.ChitietLoaiBaiDang  VALUES  ( 'SK', '5', 1)
INSERT INTO dbo.ChitietLoaiBaiDang  VALUES  ( 'SK', '8', 1)
INSERT INTO dbo.ChitietLoaiBaiDang  VALUES  ( 'TD', '6', 1)
INSERT INTO dbo.ChitietLoaiBaiDang  VALUES  ( 'TS', '7', 1)

GO

---9.


CREATE TABLE Baidang
(
	Mabaidang VARCHAR(50) PRIMARY KEY,
	TagID VARCHAR(50),
	Tieude NVARCHAR(100),
	Noidung NVARCHAR(MAX),
	Ngaydang DATETIME,
	Thoigianhieuluc DATETIME,
	ĐoituongHT VARCHAR(50),
	Flag BIT,
	FOREIGN KEY (TagID) REFERENCES Tag(TagID)
)
INSERT INTO dbo.Baidang VALUES  ( 'BD1' ,'8'  , N'Thông báo về Olympic sinh viên ' ,N'Thông báo Về việc huấn luyện sinh viên tham dự Olympic Tin học sinh viên Việt Nam và Kỳ thi lập trình sinh viên Quốc tế ACM năm 2018' , '4-02-2018','6-14-2018',N'ALL', 1 )

INSERT INTO dbo.Baidang VALUES  ( 'BD2' ,'6'   , N'Tuyển dụng ở IVC Freshser 2018' ,N'Công ty IVC tuyển dụng Fresher năm 2018, với các ngành nghề: C++; Frontend (HTML, JS); Java. Yêu cầu: nộp CV + bảng điểm. Hạn chót đăng ký: 15/10/2018. Các bạn xem thêm thông tin chi tiết ở file đính kèm' , '9-25-2018','10-15-2018',N'SV', 1 )

INSERT INTO dbo.Baidang VALUES  ( 'BD3' ,'1'   , N'Nghiên cứu' ,N'1. Nguyễn Hòa, Nguyễn Nhựt Đông, Toán rời rạc, NXB Thanh Niên, 2014, 246 trang, ISBN: 978-604-64-1641- 8; 2. Nguyễn Hòa, Cơ sở dữ liệu mờ và xác suất, NXB Đại học Quốc gia TP.HCM, 2016, 179 trang, ISBN:978-604- 73-3941- 9; 3. Huỳnh Minh Trí, Phan Tấn Quốc, Nguyễn Nhựt Đông, Giáo trình Kỹ thuật lập trình, 277 trang, NXBĐHQG TPHCM, ISBN: 978-604- 73-4633- 2, 2016' , '09-09-2018','09-09-2018' ,N'SV', 1 )

INSERT INTO dbo.Baidang VALUES  ( 'BD4' ,'2'   , N'Về việc học bổng đồng hương Bạc Liêu - Cà Mau năm học 2017-2018' ,N'Các bạn sinh viên thường trú tại 02 tỉnh Bạc Liêu, Cà Mau đang học hệ chính quy tại trường, có hoàn cảnh đặc biệt khó khăn, có phẩm chất đạo đức tốt, hộ nghèo hoặc có thành tích đạt điểm trung bình cao, được khen thưởng thành tích khác,....Chi tiết tại file đính kèm' , '10-05-2018','10-05-2018' ,N'ALL', 1 )


GO

--10.
CREATE table Files
(
	IDfile int IDENTITY primary key,
	Mabaidang varchar(50),
	MaNDCTSV varchar(50),
	TenFile nvarchar(10),
	FilePath nvarchar(100),
	Flag bit,
	FOREIGN KEY (Mabaidang) REFERENCES dbo.Baidang (Mabaidang),
	FOREIGN KEY (MaNDCTSV) REFERENCES dbo.NDCongtacSV(MaNDCTSV)
)

GO
INSERT  INTO dbo.Files(  Mabaidang ,TenFile , FilePath , Flag)
VALUES  ('BD1','File1','~/Files/01.pdf',1)

INSERT  INTO dbo.Files(  Mabaidang ,TenFile , FilePath , Flag)
VALUES  ('BD1','File2','~/Files/02.docx',1)

INSERT  INTO dbo.Files( MaNDCTSV ,TenFile , FilePath , Flag)
VALUES ('ND2','File3','~/Files/03.docx',1)

INSERT  INTO dbo.Files(  Mabaidang ,TenFile , FilePath , Flag)
VALUES ('BD3','File4','~/Files/04.xlsx',1)


---11
CREATE TABLE Quyennguoidung
(
	Maquyen VARCHAR(50) PRIMARY KEY,
	Tenquyen nVARCHAR(100),
	Flag BIT
)
GO

INSERT INTO dbo.Quyennguoidung VALUES  ( '1', N'Xem tin tức - bài đăng giáo viên',1)
INSERT INTO dbo.Quyennguoidung VALUES  ( '2', N'Thêm, Xóa, Sửa bài đăng',1)
INSERT INTO dbo.Quyennguoidung VALUES  ( '3', N'Thêm, Xóa, Sửa thông tin khoa',1)
INSERT INTO dbo.Quyennguoidung VALUES  ( '4', N'Báo cáo - thống kê',1)
INSERT INTO dbo.Quyennguoidung VALUES  ( '5', N'Xem lịch sử bài đăng',1)
INSERT INTO dbo.Quyennguoidung VALUES  ( '6', N'Xem lịch sử tin tức khoa',1)
INSERT INTO dbo.Quyennguoidung VALUES  ( '7', N'Nhận thông báo tin tức mới',1)

GO

---12
CREATE TABLE Chitietquyen
(
	Tentaikhoan VARCHAR(100),
	Maquyen VARCHAR(50),
	Flag BIT,
	PRIMARY KEY (Tentaikhoan,Maquyen),
	FOREIGN KEY (Tentaikhoan) REFERENCES dbo.Taikhoan(Tentaikhoan),
	FOREIGN KEY (Maquyen) REFERENCES dbo.Quyennguoidung(Maquyen)
)
GO

INSERT INTO dbo.Chitietquyen  VALUES  ( 'IT1','1',1)
INSERT INTO dbo.Chitietquyen  VALUES  ( 'IT2','1',1)

INSERT INTO dbo.Chitietquyen  VALUES  ( 'IT9','2',1)
INSERT INTO dbo.Chitietquyen  VALUES  ( 'IT10','2',1)
INSERT INTO dbo.Chitietquyen  VALUES  ( 'IT11','2',1)
INSERT INTO dbo.Chitietquyen  VALUES  ( 'IT12','2',1)
INSERT INTO dbo.Chitietquyen  VALUES  ( 'IT13','2',1)
INSERT INTO dbo.Chitietquyen  VALUES  ( 'IT14','2',1)
INSERT INTO dbo.Chitietquyen  VALUES  ( 'IT15','2',1)
INSERT INTO dbo.Chitietquyen  VALUES  ( 'IT16','2',1)
INSERT INTO dbo.Chitietquyen  VALUES  ( 'IT3','2',1)
INSERT INTO dbo.Chitietquyen  VALUES  ( 'IT4','2',1)

INSERT INTO dbo.Chitietquyen  VALUES  ( 'IT3','3',1)
INSERT INTO dbo.Chitietquyen  VALUES  ( 'IT4','3',1)

INSERT INTO dbo.Chitietquyen  VALUES  ( 'IT5','4',1)
INSERT INTO dbo.Chitietquyen  VALUES  ( 'IT6','4',1)
INSERT INTO dbo.Chitietquyen  VALUES  ( 'IT7','4',1)
INSERT INTO dbo.Chitietquyen  VALUES  ( 'IT8','4',1)

INSERT INTO dbo.Chitietquyen  VALUES  ( 'IT9','5',1)
INSERT INTO dbo.Chitietquyen  VALUES  ( 'IT10','5',1)
INSERT INTO dbo.Chitietquyen  VALUES  ( 'IT11','5',1)
INSERT INTO dbo.Chitietquyen  VALUES  ( 'IT12','5',1)
INSERT INTO dbo.Chitietquyen  VALUES  ( 'IT13','5',1)
INSERT INTO dbo.Chitietquyen  VALUES  ( 'IT14','5',1)
INSERT INTO dbo.Chitietquyen  VALUES  ( 'IT15','5',1)
INSERT INTO dbo.Chitietquyen  VALUES  ( 'IT16','5',1)
INSERT INTO dbo.Chitietquyen  VALUES  ( 'IT3','5',1)
INSERT INTO dbo.Chitietquyen  VALUES  ( 'IT4','5',1)

INSERT INTO dbo.Chitietquyen  VALUES  ( 'IT3','6',1)
INSERT INTO dbo.Chitietquyen  VALUES  ( 'IT4','6',1)

INSERT INTO dbo.Chitietquyen  VALUES  ( 'IT5','7',1)
INSERT INTO dbo.Chitietquyen  VALUES  ( 'IT6','7',1)
INSERT INTO dbo.Chitietquyen  VALUES  ( 'IT7','7',1)
INSERT INTO dbo.Chitietquyen  VALUES  ( 'IT8','7',1)

GO



---13
CREATE TABLE LoaiDaotao
(
	MaloaiDT VARCHAR(50) PRIMARY KEY,
	Tenloai NVARCHAR(100),
	Flag BIT,
)
GO

INSERT INTO dbo.LoaiDaotao  VALUES  ( 'DH', N'Trình độ Đại học ',1)

INSERT INTO dbo.LoaiDaotao  VALUES  ( 'TS', N'Trình độ Thạc sĩ ',1)

GO

---14

CREATE TABLE NoidungDT
(
	MaNDDT VARCHAR(50) PRIMARY KEY,
	MaloaiDT VARCHAR(50),
	Tentaikhoan VARCHAR(100),
	Tieude NVARCHAR(100),
	NoidungDT NVARCHAR(MAX),
	Ngaydang DATETIME,
	Flag BIT,
	FOREIGN KEY (MaloaiDT) REFERENCES dbo.LoaiDaotao(MaloaiDT),
	FOREIGN KEY (Tentaikhoan) REFERENCES dbo.Taikhoan (Tentaikhoan)
)
GO

INSERT INTO dbo.NoidungDT	VALUES  ( 'NDDT1' ,'DH' , 'IT3' ,N'Chương trình đào tạo ngành Kỹ Thuật Phần Mềm - Hệ chính quy',N'CTĐT Kỹ thuật phần mềm' ,'07-19-2018' ,1 )

INSERT INTO dbo.NoidungDT 	VALUES  ( 'NDDT2' ,'DH', 'IT3' ,N'Ngành Công nghệ thông tin - Hệ chính quy'  ,N' Đào tạo Kỹ sư ngành Công nghệ thông tin; các kỹ sư ngành Công nghệ thông tin của Trường Đai học Sài Gòn có thể đảm nhiệm tốt một số vai trò trong các công ty phần mềm, các công ty chuyên về Mạng và Hệ thống máy tính, nhân viên phụ trách Công nghệ thông tin ở các cơ quan ban ngành nhà nước và doanh nghiệp. Các kỹ sư ngành Công nghệ thông tin của Trường có thể học lên ở các bậc học cao hơn như cao học, tiến sĩ hoặc tham gia giảng dạy, nghiên cứu ở các Trường Đại học, cao đẳng hoặc cũng có thể tham gia các dự án Công nghệ thông tin với các đối tác Quốc tế.','07-19-2018' ,1 )
	
INSERT INTO dbo.NoidungDT 	VALUES  ( 'NDDT3' ,'DH' , 'IT3',N'Ngành Công nghệ thông tin - Hệ chính quy (chất lượng cao)' ,N' CTĐT Công nghệ Thông tin chất lượng cao.' ,'02-04-2018' ,1 )

INSERT INTO dbo.NoidungDT 	VALUES  ( 'NDDT4' ,'DH' , 'IT3',N'Ngành Công nghệ thông tin - Hệ liên thông' ,N'Hệ liên thông trình độ đại học gồm Liên thông từ Trung cấp lên Đại học và Liên thông từ Cao Đăng lên Đại học ' ,'08-03-2018',1 )
	
INSERT INTO dbo.NoidungDT	VALUES  ( 'NDDT5' ,'TS' , 'IT3' ,N'[Thạc sỹ] Ngành Khoa học máy tính',N'Thông tin chi tiết chương trình đào tạo thạc sĩ KHMT. (Thông tin tuyển sinh chi tiết xem tại website của Phòng đào tạo Sau đại học)','08-03-2018' ,1 )

GO

----15
CREATE TABLE Thongbaochuyentiep
(
	Machuyentiep VARCHAR(50) PRIMARY KEY,
	Taikhoangui VARCHAR(100),
	Tieude NVARCHAR(100),
	Noidung NVARCHAR(MAX),
	Ngaychuyen DATETIME,
	Flag BIT
)
GO

INSERT INTO dbo.Thongbaochuyentiep VALUES  ( 'CT1','IT3'  ,N'Đăng bài', N'Tuyển dụng ở IVC Freshser 2018'  , '09-20-2018' , 1 )

INSERT INTO dbo.Thongbaochuyentiep VALUES  ( 'CT2'  ,'IT9',N'Xóa bài' , N'Xóa bài đăng Nghiên cứu BD3' , '12-25-2018', 1 )

INSERT INTO dbo.Thongbaochuyentiep VALUES  ( 'CT3' ,'IT3',N'Sửa bài' , N'Sửa bài đăng Bộ môn Hệ thống thông tin BD4'  ,  '8-5-2018' , 1 )

INSERT INTO dbo.Thongbaochuyentiep VALUES  ( 'CT4' ,'IT3'  ,N'Xóa bài' , N'Xóa bài đăng Bộ môn Kỹ thuật phần mềm BD5' , '12-5-2018' , 1 )

INSERT INTO dbo.Thongbaochuyentiep VALUES  ( 'CT5' ,'IT4',N'Đăng bài' , N'Quy định về khóa luận Tốt Nghiệp'  , '11-20-2018'  , 1 )

INSERT INTO dbo.Thongbaochuyentiep VALUES  ( 'CT6' ,'IT4',N'Thống kê' , N'Về việc bổ sung hồ sơ nhập học của sinh viên Khóa 18'  , '3-6-2018'  , 1 )

INSERT INTO dbo.Thongbaochuyentiep VALUES  ( 'CT7' ,'IT3' ,N'Xóa bài' , N'Xóa bài đăng Biểu mẫu BD7' , '12-5-2018', 1 )

INSERT INTO dbo.Thongbaochuyentiep VALUES  ( 'CT8','IT12' ,N'Đăng bài' , N'Về việc học bổng đồng hương Bạc Liêu - Cà Mau năm học 2017-2018'  ,'9-9-2018'  , 1 )

GO

---16

CREATE TABLE Chitietchuyentiep
(
	Machuyentiep VARCHAR(50),
	Taikhoannhan VARCHAR(100),
	Trangthaixem NVARCHAR(20),
	Trangthaichuyen NVARCHAR(20),
	Flag BIT,
	PRIMARY KEY (Machuyentiep,Taikhoannhan),
	FOREIGN KEY (Machuyentiep) REFERENCES dbo.Thongbaochuyentiep(Machuyentiep),
	FOREIGN KEY (Taikhoannhan) REFERENCES dbo.Taikhoan(Tentaikhoan)
)

GO

INSERT INTO dbo.Chitietchuyentiep  VALUES  ( 'CT1' ,'IT4', N'Đã xem', N'Đã chuyển',1 )
INSERT INTO dbo.Chitietchuyentiep  VALUES  ( 'CT2' ,'IT10' , N'Đã xem', N'Đã chuyển',1  )
INSERT INTO dbo.Chitietchuyentiep  VALUES  ( 'CT3' ,'IT4' , N'Đã xem', N'Đã chuyển',1  )
INSERT INTO dbo.Chitietchuyentiep  VALUES  ( 'CT4' ,'IT4', N'Đã xem', N'Đã chuyển',1  )
INSERT INTO dbo.Chitietchuyentiep  VALUES  ( 'CT5' ,'IT3', N'Đã xem', N'Đã chuyển',1  )
INSERT INTO dbo.Chitietchuyentiep  VALUES  ( 'CT6' ,'IT3' , N'Đã xem', N'Đã chuyển',1 )
INSERT INTO dbo.Chitietchuyentiep  VALUES  ( 'CT7' ,'IT11' , N'Đã xem', N'Đã chuyển',1  )
INSERT INTO dbo.Chitietchuyentiep  VALUES  ( 'CT8' ,'IT9' , N'Đã xem', N'Đã chuyển',1  )

GO

---17

CREATE TABLE Gioithieu
(
	MaGT VARCHAR(50) PRIMARY KEY,
	TenGT NVARCHAR(100),
	Flag BIT,
	
)

GO

-----Gioithieu
INSERT INTO dbo.Gioithieu  VALUES  ( 'GT1',N'Giới thiệu chung',1)
INSERT INTO dbo.Gioithieu  VALUES  ( 'GT2',N'Cơ sở vật chất',1)
INSERT INTO dbo.Gioithieu  VALUES  ( 'GT3',N'Chi bộ khoa',1)
INSERT INTO dbo.Gioithieu  VALUES  ( 'GT4',N'Ban chủ nhiệm khoa',1) 
INSERT INTO dbo.Gioithieu  VALUES  ( 'GT5',N'Hội đồng khoa học Khoa',1)
INSERT INTO dbo.Gioithieu  VALUES  ( 'GT6',N'Công đoàn khoa',1)
INSERT INTO dbo.Gioithieu  VALUES  ( 'GT7',N'Văn phòng khoa',1)
INSERT INTO dbo.Gioithieu  VALUES  ( 'GT8',N'Công viên chức khoa',1)





GO

---18
CREATE TABLE NoidungGioithieu
(
	MaNDGT VARCHAR(50) PRIMARY KEY,
	MaGT VARCHAR(50),
	Tentaikhoan VARCHAR(100),
	Tieude NVARCHAR(100),
	NoidungGT NVARCHAR(MAX), 
	Ngaydang DATETIME,	
	Flag bit
	FOREIGN KEY (MaGT) REFERENCES dbo.Gioithieu (MaGT), 
	FOREIGN KEY (Tentaikhoan) REFERENCES dbo.Taikhoan (Tentaikhoan)

)
GO

INSERT INTO dbo.NoidungGioithieu 	VALUES  ('NDGT1','GT2' , 'IT3',N'Cơ sở vật chất', N'Khoa Công nghệ thông tin hiện đang được Nhà Trường giao quản lý 08 phòng máy tính; mỗi phòng có 40 máy. Các phòng máy tính này có chức năng phục vụ các giờ học thực hành cho các môn học từ cơ bản đến chuyên ngành của khoa Công nghệ thông tin cũng như các khoa khác. Sau đây là danh sách các phòng máy do khoa quản lý: C.A019, C.A101, C.A102, C.A105, C.A106, C.A109, C.A110, C.A111 (Lầu 1, dãy A, Cơ sở chính). Quản lý phòng máy: CN.Ngô Hữu Thanh, Email: thanhnh@sgu.edu.vn' , '08-03-2018' ,1)
        
INSERT INTO dbo.NoidungGioithieu 	VALUES  ( 'NDGT2','GT3' ,'IT3',N'Công viên chức khoa', N'1. Cô PhanThị Cảnh; 2. Thầy Nguyễn Đăng Quan; 3. Thầy Nguyễn Xuân Mẫu; 4. Thầy Tô Hoài Việt'   ,'08-03-2018' ,1)

INSERT INTO dbo.NoidungGioithieu 	VALUES  ( 'NDGT3','GT4' ,'IT4',N'Văn phòng khoa', N'Chuyên viên văn phòng:1. Tô Thị Ngọc Châu - Email: ngocchau@sgu.edu.vn; 2.  Lê Ngọc Kim Ngân -  Lê Ngọc Kim Ngân * Quản lý phòng máy tính: CN.Ngô Hữu Thanh - Email: thanhnh@sgu.edu.vn * Địa chỉ: Phòng C.A107, Nhà A, Cơ sở chính: Số 273, An Dương Vương, Phường 3, Quận 5, Tp.HCM' , '08-03-2018',1)

INSERT INTO dbo.NoidungGioithieu 	VALUES  ( 'NDGT4','GT5' , 'IT4',N'Công đoàn khoa',N'1. Cô Phùng Thái Thiên Trang – Chủ tịch; 2. Thầy Lê Minh Nhựt Triều - Ủy viên; 3. Cô Tô Thị Ngọc Châu -Ủy viên' , '08-03-2018',1)

INSERT INTO dbo.NoidungGioithieu 	VALUES  ( 'NDGT5','GT6' ,'IT3',N'Hội đồng khoa học Khoa', N'1. TS Huỳnh Minh Trí - Chủ tịch; 2. TS Nguyễn Hòa - P.CT; 3. ThS Nguyễn Nhựt Đông - UV; 4. TS Cao Thái Phương Thanh - UV; 5. ThS Lê Ngọc Kim Khánh - UV; 6. TS Phan Tấn Quốc - UV; 7. ThS Phùng Thái Thiên Trang - Thư ký' , '08-03-2018',1)

INSERT INTO dbo.NoidungGioithieu 	VALUES  ( 'NDGT6','GT7' , 'IT3',N'Ban chủ nhiệm khoa',N'Danh sách các lãnh đạo khoa và danh sách các trợ lý lánh đạo khoa' , '08-03-2018',1)

INSERT INTO dbo.NoidungGioithieu 	VALUES  ( 'NDGT7','GT8' ,'IT4',N'Chi bộ khoa', N'Danh sách đảng viên thuộc Chi bộ Khoa CNTT TT CNTT gồm các đồng chí sau: 1. Đ/c Phan Thị Kim Loan (Đảng ủy viên, Bí thư Chi bộ); 2. Đ/c Nguyễn Thị Uyên Nhi (Thư ký); 3. Đ/c Đinh Thị Thu Hương; 4. Đ/c Kiều My; 5. Đ/c Lê Hùng Thanh Nhựt; 6. Đ/c Phan Tấn Quốc; 7. Đ/c Phùng Thái Thiên Trang; 8. Đ/c Huỳnh Minh Trí' , '08-03-2018',1)

GO

CREATE TABLE Bomon
(
	MaBM VARCHAR(50) PRIMARY KEY,
	TenBM nVARCHAR(100),
	Noidung nvarchar(2000)
)

INSERT INTO dbo.Bomon( MaBM, TenBM ,NoiDung) VALUES ( 'BM1',  N'Hệ thống thông tin',N'Hiểu một các đơn giản, Hệ thống thông tin là ngành học về con người, thiết bị và quy trình thu thập, phân tích, đánh giá và phân phối những thông tin chính xác cho những người soạn thảo các quyết định trong tổ chức - doanh nghiệp.

Nhiều người cho rằng MIS giống với ngành Công nghệ thông tin hay khoa học máy tính, nhưng thực tế không hẳn vậy. MIS tập trung vào thiết kế, quản trị và vận hành các hệ thống thông tin, phân tích dữ liệu, kết nối giữa các bên liên quan trong tổ chức, doanh nghiệp với các chuyên gia công nghệ thông tin, cũng như biết các làm thế nào để doanh nghiệp hoạt động hiệu quả và có lợi thế cạnh tranh hơn.')
INSERT INTO dbo.Bomon( MaBM, TenBM ,NoiDung) VALUES ( 'BM2',  N'Kỹ thuật phần mềm',N'Nhiệm vụ của Bộ môn Kỹ thuật phần mềm là trang bị kiến thức vững chắc và kỹ năng chuyên nghiệp cho các sinh viên tốt nghiệp, nhằm đáp ứng những đòi hỏi hiện tại, tương lai và thách thức về kỹ nghệ phần mềm, để các kỹ sư tương lai có khả năng làm việc trong các môi trường chuyên nghiệp, nhằm phục vụ của xã hội ngày một tốt hơn. Cụ thể như sinh viên nắm vững đầy đủ kiến thức về ngành kỹ thuật phần mềm bao gồm: kiến thức cơ sở khoa học của ngành, kỹ thuật và phương pháp phân tích, thiết kế, triển khai và bảo trì một hệ thống phần mềm an toàn theo chuẩn quốc tế, để đảm bảo áp dụng thành công khi đi làm ở công ty hoặc tiếp tục học lên những bậc học cao hơn, từ đó hình thành các kỹ năng giải quyết vấn đề. Sinh viên được trang bị kỹ năng làm việc chuyên nghiệp thông qua các hoạt động tham gia nhóm thực hành, đồ án, khoá luận và giao lưu với doanh nghiệp qua công tác thực tập. Để sau khi tốt nghiệp, sinh viên vững vàng tham gia các dự án lớn nhỏ, trở thành kỹ sư toàn cầu cũng như khả năng nghiên cứu lên các bậc học Thạc sĩ và Tiến sĩ.')
INSERT INTO dbo.Bomon( MaBM, TenBM ,NoiDung) VALUES ( 'BM3',  N'Khoa học máy tính',N'Khoa học máy tính là ngành nghiên cứu các cơ sở lý thuyết về thông tin và tính toán cùng sự thực hiện và ứng dụng của chúng trong các hệ thống máy tính. Khoa học máy tính là cách tiếp cận khoa học và thực tiễn để tính toán và các ứng dụng của nó và nghiên cứu có hệ thống về tính khả thi, cấu trúc, biểu hiện và cơ giới hóa các thủ tục (hoặc các thuật toán) cơ bản làm cơ sở cho việc thu thập, đại diện, xử lý, lưu trữ, truyền thông và truy cập thông tin. Một định nghĩa thay thế, gọn gàng hơn về khoa học máy tính là nghiên cứu về các quy trình thuật toán tự động hóa mà có thể nhân rộng trên quy mô lớn. Một nhà khoa học máy tính là chuyên gia về lý thuyết tính toán và thiết kế các hệ thống tính toán.')
INSERT INTO dbo.Bomon( MaBM, TenBM ,NoiDung) VALUES ( 'BM4',  N'Mạng và hệ thống máy tính',N'Ngành Truyền thông và Mạng máy tính là một trong các ngành thuộc nhóm ngành Công nghệ thông tin. Truyền thông và Mạng máy tính không chỉ cung cấp cho sinh viên kiến thức nền tảng về Công nghệ thông tin mà còn cung cấp các kiến thức chuyên sâu trong lĩnh vực mạng máy tính và truyền thông. Hiện nay, ngành này có ảnh hưởng lớn và sâu rộng trong mọi lĩnh vực của đời sống con người, chẳng hạn như: Lĩnh vực truyền thông (Internet, mạng xã hội, báo điện tử, …); Lĩnh vực giải trí (âm nhạc trực tuyến, truyền hình, game, …); Lĩnh vực kinh tế (thương mại điện tử, quảng cáo trực tuyến, …); Lĩnh vực giáo dục (đại học điện tử, giải bài toán trên mạng, …); Lĩnh vực hành chính (chính phủ điện tử, văn phòng không giấy, …) và nhiều lĩnh vực khác của cuộc sống.')

--CREATE TABLE Hinhanh
--(
--	MaHA VARCHAR(50) PRIMARY KEY,
--	TenHA VARCHAR(100),
--	link TEXT
--)


CREATE TABLE ThongtinGV
(
	MaGV VARCHAR(50) PRIMARY KEY,
	MaBM VARCHAR(50),
	Machucvu VARCHAR(50),
	TenGV NVARCHAR(100),
	Diachimail VARCHAR(100),
	Flag BIT,
	FOREIGN KEY (MaGV) REFERENCES dbo.ThongtinGV(MaGV),
	FOREIGN KEY (MaBM) REFERENCES dbo.Bomon(MaBM)
)
INSERT INTO dbo.ThongtinGV ( MaGV ,MaBM , Machucvu ,TenGV , Diachimail ,Flag )
VALUES ( 'GV1' , 'BM1' , 'CV1' ,N'Nguyễn Quốc Huy' ,'nqhuy@sgu.edu.vn' , 1 )

INSERT INTO dbo.ThongtinGV ( MaGV ,MaBM , Machucvu ,TenGV , Diachimail ,Flag )
VALUES  ( 'GV2' , 'BM1' , 'CV1' ,N'Đinh Thị Ngọc Loan'  ,'không có' , 1 )

INSERT INTO dbo.ThongtinGV ( MaGV ,MaBM , Machucvu ,TenGV , Diachimail ,Flag )
VALUES ( 'GV3' , 'BM1' , 'CV1' ,N'Nguyễn Thị Uyên Nhi'  ,'ntunhi@sgu.edu.vn' , 1 )

INSERT INTO dbo.ThongtinGV ( MaGV ,MaBM , Machucvu ,TenGV , Diachimail ,Flag )
VALUES ( 'GV4' , 'BM1' , 'CV1' ,N'Lê Nhị Lãm Thúy ' ,'thuylnl@sgu.edu.vn' , 1 )

INSERT INTO dbo.ThongtinGV ( MaGV ,MaBM , Machucvu ,TenGV , Diachimail ,Flag )
VALUES ( 'GV5' , 'BM1' , 'CV1' ,N'Phan Thị Kim Loan' ,' ptkloan@sgu.edu.vn' , 1 )

INSERT INTO dbo.ThongtinGV ( MaGV ,MaBM , Machucvu ,TenGV , Diachimail ,Flag )
VALUES ( 'GV6' , 'BM2' , 'CV1' ,N'Phùng Thái Thiên Trang' ,'thientrang@sgu.edu.vn' , 1 )

INSERT INTO dbo.ThongtinGV ( MaGV ,MaBM , Machucvu ,TenGV , Diachimail ,Flag )
VALUES ( 'GV7' , 'BM2' , 'CV1' ,N'Huỳnh Thắng Được'  ,' duochuynh@sgu.edu.vn' , 1 )

INSERT INTO dbo.ThongtinGV ( MaGV ,MaBM , Machucvu ,TenGV , Diachimail ,Flag )
VALUES  ( 'GV8' , 'BM2' , 'CV1' ,N'Đỗ Ngọc Như Loan'  ,'loandnn@sgu.edu.vn' , 1 )

INSERT INTO dbo.ThongtinGV ( MaGV ,MaBM , Machucvu ,TenGV , Diachimail ,Flag )
VALUES ( 'GV9' , 'BM2' , 'CV1' ,N'Đỗ Đình Trang','dodinhtrang@sgu.edu.vn' , 1 )

INSERT INTO dbo.ThongtinGV ( MaGV ,MaBM , Machucvu ,TenGV , Diachimail ,Flag )
VALUES ( 'GV10' , 'BM2' , 'CV1' ,N'Nguyễn Thanh Sang'  ,'thanhsang@sgu.edu.vn' , 1 )

INSERT INTO dbo.ThongtinGV ( MaGV ,MaBM , Machucvu ,TenGV , Diachimail ,Flag )
VALUES  ( 'GV11' , 'BM2' , 'CV1' ,N'Cao Thái Phương Thanh'  ,' ctpthanh@sgu.edu.vn' , 1 )

INSERT INTO dbo.ThongtinGV ( MaGV ,MaBM , Machucvu ,TenGV , Diachimail ,Flag )
VALUES  ( 'GV12' , 'BM3' , 'CV1' ,N'Lê Minh Nhựt Triều'   ,'trieule@sgu.edu.vn,' , 1 )

INSERT INTO dbo.ThongtinGV ( MaGV ,MaBM , Machucvu ,TenGV , Diachimail ,Flag )
VALUES  ( 'GV13' , 'BM3' , 'CV1' ,N'Huỳnh Minh Trí'  ,'hmtri@sgu.edu.vn' , 1 )

INSERT INTO dbo.ThongtinGV ( MaGV ,MaBM , Machucvu ,TenGV , Diachimail ,Flag )
VALUES  ( 'GV14' , 'BM3' , 'CV2' ,N'Nguyễn Nhựt Đông'  ,'nndong@sgu.edu.vn' , 1 )

INSERT INTO dbo.ThongtinGV ( MaGV ,MaBM , Machucvu ,TenGV , Diachimail ,Flag )
VALUES ( 'GV15' , 'BM3' , 'CV1' ,N'Phan Tấn Quốc' ,' quocpt@sgu.edu.vn' , 1 )

INSERT INTO dbo.ThongtinGV ( MaGV ,MaBM , Machucvu ,TenGV , Diachimail ,Flag )
VALUES ( 'GV16' , 'BM3' , 'CV2' ,N'Nguyễn Hòa' ,'nguyenhoa@sgu.edu.vn' , 1 )

INSERT INTO dbo.ThongtinGV ( MaGV ,MaBM , Machucvu ,TenGV , Diachimail ,Flag )
VALUES ( 'GV17' , 'BM3' , 'CV1' ,N'Đinh Thị Thu Hương'  ,'huongdtt@sgu.edu.vn' , 1 )

INSERT INTO dbo.ThongtinGV ( MaGV ,MaBM , Machucvu ,TenGV , Diachimail ,Flag )
VALUES ( 'GV18' , 'BM3' , 'CV1' ,N'Lê Ngọc Anh'  ,'khong co' , 1 )

INSERT INTO dbo.ThongtinGV ( MaGV ,MaBM , Machucvu ,TenGV , Diachimail ,Flag )
VALUES  ( 'GV19' , 'BM4' , 'CV1' ,N'Lê Ngọc Kim Khánh'   ,' lnkkhanh@sgu.edu.vn' , 1 )

INSERT INTO dbo.ThongtinGV ( MaGV ,MaBM , Machucvu ,TenGV , Diachimail ,Flag )
VALUES ( 'GV20' , 'BM4' , 'CV1' ,N'Nguyễn Minh Thi'  ,'khong co' , 1 )

INSERT INTO dbo.ThongtinGV ( MaGV ,MaBM , Machucvu ,TenGV , Diachimail ,Flag )
VALUES  ( 'GV21' , 'BM4' , 'CV1' ,N'Lương Minh Huấn'   ,'huanlm@sgu.edu.vn' , 1 )

INSERT INTO dbo.ThongtinGV ( MaGV ,MaBM , Machucvu ,TenGV , Diachimail ,Flag )
VALUES  ( 'GV22' , 'BM4' , 'CV1' ,N'Nguyễn Võ Lam Giang' ,'khong co' , 1 )

INSERT INTO dbo.ThongtinGV ( MaGV ,MaBM , Machucvu ,TenGV , Diachimail ,Flag )
VALUES ( 'GV23' , 'BM4' , 'CV1' ,N'Kiều My'  ,'khong co' , 1 )

GO

CREATE TABLE Monhoc 
(
	MaMH VARCHAR(50) PRIMARY KEY,
	MaBM VARCHAR(50),
	TenMH NVARCHAR(100),
	MaGV VARCHAR(50),
	FOREIGN KEY (MaBM) REFERENCES dbo.Bomon(MaBM)
)

INSERT INTO dbo.Monhoc ( MaMH, MaBM, TenMH, MaGV ) VALUES  ( '841109', 'BM1',  N'Cơ sở dữ liệu',  'GV1' )

INSERT INTO dbo.Monhoc ( MaMH, MaBM, TenMH, MaGV ) VALUES  ( '841065', 'BM1',  N'Các hệ quản trị CSDL',  'GV2' )

INSERT INTO dbo.Monhoc ( MaMH, MaBM, TenMH, MaGV ) VALUES  ( '841048', 'BM1',  N'Phân tích thiết kế hệ thống thông tin',  'GV3' )

INSERT INTO dbo.Monhoc ( MaMH, MaBM, TenMH, MaGV ) VALUES  ( '841111', 'BM1',  N'Phân tích thiết kế hướng đối tượng',  'GV4' )

INSERT INTO dbo.Monhoc ( MaMH, MaBM, TenMH, MaGV ) VALUES  ( '841068', 'BM1',  N'Hệ thống thông tin doanh nghiệp',  'GV5' )

INSERT INTO dbo.Monhoc ( MaMH, MaBM, TenMH, MaGV ) VALUES  ( '841120', 'BM1',  N'An toàn và bảo mật dữ liệu trong hệ thống thông tin',  'GV1' )

INSERT INTO dbo.Monhoc ( MaMH, MaBM, TenMH, MaGV ) VALUES  ( '841121', 'BM1',  N'Cơ sở dữ liệu phân tán',  'GV2' )

INSERT INTO dbo.Monhoc ( MaMH, MaBM, TenMH, MaGV ) VALUES  ( '841067', 'BM1',  N'Thương mại điện tử và ứng dụng',  'GV3' )

INSERT INTO dbo.Monhoc ( MaMH, MaBM, TenMH, MaGV ) VALUES  ( '841073', 'BM1',  N'Seminar chuyên đề (hướng Hệ thống thông tin)',  'GV4' )

INSERT INTO dbo.Monhoc ( MaMH, MaBM, TenMH, MaGV ) VALUES  ( '841044', 'BM2',  N'Lập trình hướng đối tượng',  'GV6' )

INSERT INTO dbo.Monhoc ( MaMH, MaBM, TenMH, MaGV ) VALUES  ( '841107', 'BM2',  N'Lập trình Java',  'GV7' )

INSERT INTO dbo.Monhoc ( MaMH, MaBM, TenMH, MaGV ) VALUES  ( '841304', 'BM2',  N'Phát triển ứng dụng web 1',  'GV8' )

INSERT INTO dbo.Monhoc ( MaMH, MaBM, TenMH, MaGV ) VALUES  ( '841046', 'BM2',  N'Phát triển ứng dụng web 2',  'GV9' )

INSERT INTO dbo.Monhoc ( MaMH, MaBM, TenMH, MaGV ) VALUES  ( '841047', 'BM2',  N'Công nghệ phần mềm',  'GV10' )

INSERT INTO dbo.Monhoc ( MaMH, MaBM, TenMH, MaGV ) VALUES  ( '841050', 'BM2',  N'Kiểm thử phần mềm',  'GV11' )

INSERT INTO dbo.Monhoc ( MaMH, MaBM, TenMH, MaGV ) VALUES  ( '841051', 'BM2',  N'Thiết kế giao diện',  'GV6' )

INSERT INTO dbo.Monhoc ( MaMH, MaBM, TenMH, MaGV ) VALUES  ( '841113', 'BM2',  N'Phát triển phần mềm mã nguồn mở',  'GV7' )

INSERT INTO dbo.Monhoc ( MaMH, MaBM, TenMH, MaGV ) VALUES  ( '841052', 'BM2',  N'Xây dựng phần mềm theo mô hình lớp',  'GV8' )

INSERT INTO dbo.Monhoc ( MaMH, MaBM, TenMH, MaGV ) VALUES  ( '841114', 'BM2',  N'Phát triển ứng dụng trên thiết bị di động',  'GV9' )

INSERT INTO dbo.Monhoc ( MaMH, MaBM, TenMH, MaGV ) VALUES  ( '841072', 'BM2',  N'Các công nghệ lập trình hiện đại',  'GV10' )

INSERT INTO dbo.Monhoc ( MaMH, MaBM, TenMH, MaGV ) VALUES  ( '841301', 'BM3',  N'Giải tích (Khoa Toán Ứng dụng GD)',  'GV12' )

INSERT INTO dbo.Monhoc ( MaMH, MaBM, TenMH, MaGV ) VALUES  ( '841302', 'BM3',  N'Đại số (Khoa Toán Ứng dụng GD)',  'GV13' )

INSERT INTO dbo.Monhoc ( MaMH, MaBM, TenMH, MaGV ) VALUES  ( '841101', 'BM3',  N'Tiếng Anh chuyên ngành 1',  'GV14' )

INSERT INTO dbo.Monhoc ( MaMH, MaBM, TenMH, MaGV ) VALUES  ( '841106', 'BM3',  N'Tiếng Anh chuyên ngành 2',  'GV15' )

INSERT INTO dbo.Monhoc ( MaMH, MaBM, TenMH, MaGV ) VALUES  ( '841020', 'BM3',  N'Cơ sở lập trình',  'GV16' )

INSERT INTO dbo.Monhoc ( MaMH, MaBM, TenMH, MaGV ) VALUES  ( '841040', 'BM3',  N'Kỹ thuật lập trình',  'GV17' )

INSERT INTO dbo.Monhoc ( MaMH, MaBM, TenMH, MaGV ) VALUES  ( '841102', 'BM3',  N'Toán rời rạc',  'GV18' )

INSERT INTO dbo.Monhoc ( MaMH, MaBM, TenMH, MaGV ) VALUES  ( '841103', 'BM3',  N'Lý thuyết đồ thị',  'GV12' )

INSERT INTO dbo.Monhoc ( MaMH, MaBM, TenMH, MaGV ) VALUES  ( '841108', 'BM3',  N'Cấu trúc dữ liệu và giải thuật',  'GV13' )

INSERT INTO dbo.Monhoc ( MaMH, MaBM, TenMH, MaGV ) VALUES  ( '841110', 'BM3',  N'Cơ sở trí tuệ nhân tạo',  'GV14' )

INSERT INTO dbo.Monhoc ( MaMH, MaBM, TenMH, MaGV ) VALUES  ( '841308', 'BM3',  N'Khai phá dữ liệu',  'GV16' )

INSERT INTO dbo.Monhoc ( MaMH, MaBM, TenMH, MaGV ) VALUES  ( '841021', 'BM4',  N'Kiến trúc máy tính',  'GV19' )

INSERT INTO dbo.Monhoc ( MaMH, MaBM, TenMH, MaGV ) VALUES  ( '841022', 'BM4',  N'Hệ điều hành',  'GV20' )

INSERT INTO dbo.Monhoc ( MaMH, MaBM, TenMH, MaGV ) VALUES  ( '841058', 'BM4',  N'Hệ điều hành mã nguồn mở',  'GV21' )

INSERT INTO dbo.Monhoc ( MaMH, MaBM, TenMH, MaGV ) VALUES  ( '841104', 'BM4',  N'Mạng máy tính',  'GV22' )

INSERT INTO dbo.Monhoc ( MaMH, MaBM, TenMH, MaGV ) VALUES  ( '841059', 'BM4',  N'Quản trị mạng',  'GV23' )

INSERT INTO dbo.Monhoc ( MaMH, MaBM, TenMH, MaGV ) VALUES  ( '841117', 'BM4',  N'Lập trình ứng dụng mạng',  'GV19' )

INSERT INTO dbo.Monhoc ( MaMH, MaBM, TenMH, MaGV ) VALUES  ( '841118', 'BM4',  N'Lập trình hệ thống mạng',  'GV20' )

INSERT INTO dbo.Monhoc ( MaMH, MaBM, TenMH, MaGV ) VALUES  ( '841061', 'BM4',  N'Mạng máy tính nâng cao',  'GV21' )

INSERT INTO dbo.Monhoc ( MaMH, MaBM, TenMH, MaGV ) VALUES  ( '841119', 'BM4',  N'An ninh mạng máy tính',  'GV22' )

INSERT INTO dbo.Monhoc ( MaMH, MaBM, TenMH, MaGV ) VALUES  ( '841074', 'BM4',  N'Seminar chuyên đề (hướng Mạng và hệ thống máy tính)',  'GV23' )


/*CREATE TABLE DTHienthi
(
	MaDT VARCHAR(50) PRIMARY KEY,
	TenDT nVARCHAR(100)
)
INSERT INTO dbo.DTHienthi( MaDT, TenDT ) VALUES  ( 'DT1',  N'Khách' )
INSERT INTO dbo.DTHienthi( MaDT, TenDT ) VALUES  ( 'DT2',  N'Giáo viên' )
GO

---11.
CREATE TABLE DTHienhi_BaiDang
(
	STT INT IDENTITY PRIMARY KEY,
	MaDT VARCHAR(50) ,
	Mabaidang VARCHAR(50),
	Flag BIT,
	FOREIGN KEY (MaDT) REFERENCES dbo.DTHienthi(MaDT),
	FOREIGN KEY (Mabaidang) REFERENCES dbo.Baidang(Mabaidang)
)
INSERT INTO dbo.DTHienhi_BaiDang ( MaDT, Mabaidang, Flag ) VALUES  ( 'DT1','BD2',1 )
INSERT INTO dbo.DTHienhi_BaiDang ( MaDT, Mabaidang, Flag ) VALUES  ( 'DT1','BD4',1 )
INSERT INTO dbo.DTHienhi_BaiDang ( MaDT, Mabaidang, Flag ) VALUES  ( 'DT1','BD5',1 )
INSERT INTO dbo.DTHienhi_BaiDang ( MaDT, Mabaidang, Flag ) VALUES  ( 'DT1','BD6',1 )
INSERT INTO dbo.DTHienhi_BaiDang ( MaDT, Mabaidang, Flag ) VALUES  ( 'DT1','BD7',1 )
INSERT INTO dbo.DTHienhi_BaiDang ( MaDT, Mabaidang, Flag ) VALUES  ( 'DT1','BD8',1 )
INSERT INTO dbo.DTHienhi_BaiDang ( MaDT, Mabaidang, Flag ) VALUES  ( 'DT1','BD9',1 )
INSERT INTO dbo.DTHienhi_BaiDang ( MaDT, Mabaidang, Flag ) VALUES  ( 'DT1','BD11',1 )
INSERT INTO dbo.DTHienhi_BaiDang ( MaDT, Mabaidang, Flag ) VALUES  ( 'DT2','BD1',1 )
INSERT INTO dbo.DTHienhi_BaiDang ( MaDT, Mabaidang, Flag ) VALUES  ( 'DT2','BD3',1 )
GO*/
/*


GO

GO*/
select * from NDCongTacSV
select * from CongTacSV