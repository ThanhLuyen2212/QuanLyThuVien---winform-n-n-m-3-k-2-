﻿drop database ThuVien
create database ThuVien
use ThuVien

create table DocGia
(
	IDDG int primary key Identity(1,1),
	TenDG nvarchar(50) ,
	DienThoai nvarchar(50) ,
	DiaChi nvarchar(50) ,
	UserName nvarchar(50)  , 
	Password nvarchar(50)  ,
)

create table TrangThai
(
	IDTrangThai int primary key identity(1,1) ,
	TenTrangThai nvarchar(20)
)

create table PhieuMuon
(
	IDPM int primary key identity(1,1),
	IDDG int,
	TenDG nvarchar(50)  ,
	NgayMuon datetime  ,
	NgayTra datetime  ,
	NgayTraThucTe datetime ,
	TienPhat int ,
	GhiChu nvarchar(50) ,
	TrangThai int,
	CONSTRAINT FK_PHIEUMUON_DOCGIA FOREIGN KEY (IDDG) REFERENCES DocGia(IDDG),
	CONSTRAINT FK_PHIEUMUON_TRANGTHAI FOREIGN KEY (TrangThai) REFERENCES TrangThai(IDTrangThai)
)

create table TheLoai
(
	IDCate int primary key Identity(1,1),
	NameCate NVARCHAR(50)  ,
)

insert into TheLoai(NameCate)
values (N'Chính trị')
insert into TheLoai(NameCate)
values (N'Pháp luật')
insert into TheLoai(NameCate)
values (N'Khoa học công nghệ')
insert into TheLoai(NameCate)
values (N'Kinh tế')
insert into TheLoai(NameCate)
values (N'Văn học nghệ thuật')
insert into TheLoai(NameCate)
values (N'Văn hóa xã hội')
insert into TheLoai(NameCate)
values (N'Lịch sử')
insert into TheLoai(NameCate)
values (N'Giáo trình')
insert into TheLoai(NameCate)
values (N'Truyện')
insert into TheLoai(NameCate)
values (N'Tiểu thuyết')
insert into TheLoai(NameCate)
values (N'Tâm lý, tâm linh, tôn giáo')
insert into TheLoai(NameCate)
values (N'Sách thiếu nhi')
insert into TheLoai(NameCate)
values (N'Self help')

SELECT * FROM TheLoai
 
create table Sach
(
	IDSach nvarchar(10) primary key,
	TenSach NVARCHAR(50)  ,
	TheLoai int,
	MoTa NVARCHAR(max)  ,
	TacGia NVARCHAR(50)  ,
	NgayXuatBan datetime  ,
	SoLuong int ,
	HinhAnh NVARCHAR(max) ,
	CONSTRAINT FK_SACH_THELOAI FOREIGN KEY (TheLoai) REFERENCES TheLoai(IDCate)
)

create table TinhTrangSach
(
	IDTinhTrangSach int Identity(1,1) primary key ,
	TenTrangThai nvarchar(50),
)

insert into TinhTrangSach(TenTrangThai)
values(N'Đang còn sự dụng')
insert into TinhTrangSach(TenTrangThai)
values(N'Đang cho mượn')
insert into TinhTrangSach(TenTrangThai)
values(N'Hư hại')

create table ChiTietSach
(
	IDChiTietSach nvarchar(20) primary key,
	IDSach nvarchar(10),
	IDTinhTrangSach int,
	CONSTRAINT FK_ChiTietSach_TinhTrangSach FOREIGN KEY (IDTinhTrangSach) REFERENCES TinhTrangSach(IDTinhTrangSach),
	CONSTRAINT FK_ChiTietSach_Sach FOREIGN KEY (IDSach) REFERENCES SACH(IDSach)
)
go


create table CT_PM
(
	ID int Identity(1,1) primary key ,
	IDPM int ,	
	IDChiTietSach nvarchar(20),	
		
	CONSTRAINT FK_CT_PM_ChiTietSach FOREIGN KEY (IDChiTietSach) REFERENCES ChiTietSach(IDChiTietSach),
	CONSTRAINT FK_CT_PM_PhieuMuon FOREIGN KEY (IDPM) REFERENCES PhieuMuon(IDPM),
)
go

insert into TrangThai(TenTrangThai)
values(N'Đang chờ mượn')
insert into TrangThai(TenTrangThai)
values(N'Đang mượn')
insert into TrangThai(TenTrangThai)
values(N'Đã Trả')

create table Admin
(
	IDAdmin int primary key Identity(1,1),
	TenAdmin nvarchar(50) ,
	DienThoai nvarchar(50) ,
	DiaChi nvarchar(50) ,
	UserName nvarchar(50)  , 
	Password nvarchar(50)  ,
)

insert into Admin(TenAdmin, DienThoai, DiaChi, UserName ,Password)
values('Thanh Luyen','123456789','TPHCM','123','123')

insert into Admin(TenAdmin, DienThoai, DiaChi, UserName ,Password)
values('Thai Tuan','123456789','TPHCM','tuan','123')

select * from Admin


create PROCEDURE ThemTuDongChiTietSach @soluong nvarchar(30), @idSach nvarchar(10)
AS
declare @id int
set @id = @soluong
while (@id > 0) 
begin
	declare @newID nvarchar(20)
	set @newID = @idSach + CAST(@id AS NVARCHAR(10))
	insert into ChiTietSach(IDChiTietSach,IDSach,TinhTrang)
	values(@newID,@idSach,N'Đang dùng');
	set @id = @id -1
end

Create trigger TaoIDSach
on Sach
INSTEAD OF INSERT
as 
begin 
	
	DECLARE @idSach NVARCHAR(10), @tensach nvarchar(50), @theloai nvarchar(50), @MoTa NVARCHAR(50),@TacGia NVARCHAR(50),@NgayXuatBan datetime
	DECLARE @SoLuong int, @HinhAnh NVARCHAR(max)	
	select @tensach = TenSach, @MoTa =MoTa, @TacGia = TacGia, @HinhAnh = HinhAnh from inserted
	select @theloai = TheLoai,@NgayXuatBan = NgayXuatBan, @SoLuong = SoLuong from inserted	
    declare @id int
	set @id = 1
	set @idSach = LEFT(@tensach,3) + LEFT(@theloai,3) + CAST(@id AS NVARCHAR(10))
	while ((select Count(*) from Sach where IDSach = @idSach) != 0 )
	BEGIN    
		SET @id = @id  + 1
		set @idSach = LEFT(@tensach,3) + LEFT(@theloai,3) + CAST(@id AS NVARCHAR(10))		
	END
	
	insert into Sach(IDSach,TenSach,TheLoai,MoTa,TacGia,NgayXuatBan,SoLuong,HinhAnh)
	values(@idSach,@tensach,@theloai,@MoTa,@TacGia,@NgayXuatBan,@SoLuong,@HinhAnh)

	EXEC ThemTuDongChiTietSach @soluong = @SoLuong, @idSach = @idSach
end

select * from CT_PM
select * from PhieuMuon
delete CT_PM 
delete PhieuMuon
select * from DocGia

