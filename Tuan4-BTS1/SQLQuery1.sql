Create database SinhVien
On Primary
(
	Name = SV_DATA,
	Filename = 'D:\FW\Storehouse\BT\C#\LTNC\Tuan4-BTS1\SV_DT.mdf',
	Size = 10MB,
	Maxsize = 50MB
)
Log On
(
	Name = SV_Log,
	Filename = 'D:\FW\Storehouse\BT\C#\LTNC\Tuan4-BTS1\SV_LOG.ldf',
	Size = 5MB,
	Maxsize = 25MB
)
--Tạo cấu trúc của database
USE SinhVien
--Tạo bảng Người Dùng
Create table NguoiDung
(
	MSV nvarchar(10) primary key,
	DN nvarchar(50),
	MK nvarchar(50)
)