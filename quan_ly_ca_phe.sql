create database QuanLyCaPhe

use QuanLyCaPhe

-- đồ uống
-- danh mục đồ uống 
-- tài khoản
-- hoá đơn 
-- chi tiết hoá đơn

create table HoaDon(
maHoaDon int not null primary key,
maDoUong int not null,
ten nvarchar(100) not null,
soluong int not null,
gia float not null default 0,
thanhtien float
foreign key (maDoUong) references DoUong(ma),
)

create table TaiKhoan(
tenNguoiDung nvarchar(100) not null primary key,
tenHienThi nvarchar(100) not null,
matKhau varchar(1000) default 1,
loaiTaiKhoan int not null default 0
)

drop table TaiKhoan

create table DanhMucDoUong(
ma int primary key,
ten nvarchar(100) not null default N'Chưa đặt tên'
)

insert into DanhMucDoUong
values (1, N'Cà phê'),
	   (2, N'Sinh tố'),
	   (3, N'Trà')
select * from DanhMucDoUong

create table DoUong(
ma int primary key,
tenDoUong nvarchar(100) not null,
maDanhMucDoUong int not null,
giaBan float not null default 0,
foreign key(maDanhMucDoUong) references DanhMucDoUong(ma)
)

insert into DoUong values
(1, N'Cà phê đen', 1, 25000),
(2, N'Cà phê nâu', 1, 25000),
(3, N'Cà phê sữa', 1, 30000),
(4, N'Cà phê cốt dừa', 1, 35000),
(5, N'Cà phê muối biển', 1, 35000),
(6, N'Sinh tố dưa hấu', 2, 40000),
(7, N'Sinh tố xoài', 2, 40000),
(8, N'Sinh tố bơ', 2, 50000),
(9, N'Sinh tố mãng cầu', 2, 50000),
(10, N'Trà xoài hoa nhài', 3, 40000),
(11, N'Trà đào cam sả', 3, 40000),
(12, N'Trà cúc mật ong', 3, 40000),
(13, N'Trà vải oolong', 3, 40000),
(14, N'Trà chanh lô hội', 3, 40000)

select * from DoUong

create table HoaDon(
ma int primary key,
gioVao date not null default getdate(),
gioRa date not null default getdate(),
trangThai int not null default 0 -- 1: da thanh toan, 0: chua thanh toan
)

create table ThongTinHoaDon(
ma int primary key,
maHoaDon int not null,
maDoUong int not null,
count int not null default 0,
foreign key (maHoaDon) references HoaDon(ma),
foreign key (maDoUong) references DoUong(ma)
)

insert into TaiKhoan
values (N'ad', 'admin', '1', 1),
	   (N'Staff', 'staff', '0', 0)

delete from TaiKhoan
select * from TaiKhoan