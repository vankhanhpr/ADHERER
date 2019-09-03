Create database ADHERER;
use Adherer;



create table DangBo(
	dbid int not null primary key identity (1,1),
	tructhuoc int,
	tendb nvarchar(200),
	active bit,
	ngaythanhlap datetime,
	createday datetime
);
create table ChiBo(
	cbid int not null identity(1,1) primary key,
	tencb nvarchar(200),
	dbid int not null,
	active bit,
	ngaythanhlap datetime,
	createday datetime,
	foreign key(dbid) references DangBo(dbid)
);

Create table Title(
	titleid int not null primary key identity (1,1),
	nametitle nvarchar(100),
	active bit
);
Create table Roles(
	roleid int not null primary key identity (1,1),
	rolename nvarchar(100) not null,
	active bit
);

create table Users (
	usid int not null Identity(1,1),
	madv nvarchar(9),
	cbid int not null,
	ngaydenchibo datetime,
	lydoden int,
	lydodi int,
	cbidold int,
	createday datetime,
	password nvarchar(100),
	primary key(usid),
	roleid int,
	titleid int ,
	active bit not null,
	accept bit,
	giaygioithieu nvarchar(20),
	noisinhhoatcu nvarchar(500),
	foreign key (cbid) references Chibo(cbid),
	foreign key (roleid) references Roles(roleid),
	foreign key (titleid) references Title(titleid)
);
Create table UserMove(
	usmoveid int primary key not null Identity(1,1),
	usid int ,
	filereview nvarchar(20),
	tranfer nvarchar(20),
	createday datetime,
	accept bit,
	addresstogo nvarchar(3000),
	foreign key(usid) references Users(usid) 
);
create table Nation(
	nationid int not null primary key identity(1,1),
	name nvarchar(100),
	note nvarchar(200)
);
create table Organization(
	ogid int not null primary key Identity (1,1),
	nameog nvarchar(200),
	active bit,
	createday datetime
);

Create table Files (
	fileid int not null Identity(1,1),
	usid int  not null,

	cmnd nvarchar(12),
	daycmnd datetime,
	noicapcmnd nvarchar(200),
	hokhauthuongtru nvarchar(200),
	honnhan bit,
	suckhoe nvarchar(100),

	donvi int,
	ngaythangnamsinh datetime,
	hotendangdung nvarchar(200),
	hotenkhaisinh nvarchar(200),
	gioitinh bit ,
	dantoc int ,
	tongiao nvarchar(100),
	nghenghiep nvarchar(100),
	ngayvaodangdb datetime ,
	ngayvaodangct datetime,
	ngayvaodoan datetime ,
	trinhdovanhoa nvarchar(2),
	chuyenmon nvarchar(100),
	quequan nvarchar(500),
	noicutru nvarchar(300),
	matp varchar(5),
	maqh varchar(5),
	xaid varchar(5),
	solylich nvarchar(20),
	createday datetime,
	updateday datetime,
	sdt nvarchar(10),
	email nvarchar(100),
	avatar nvarchar(20),
	card nvarchar(20),
	decision nvarchar(20),
	primary key(fileid),
	foreign key (usid) references users(usid),
	foreign key (dantoc) references Nation(nationid),
	foreign key(donvi) references Organization(ogid)
);
Create table FormFile(
	fileid int not null,
	formfileid int not null primary key identity(1,1),
	bantukiemdiem nvarchar(20),
	giaychungnhanboiduong nvarchar(20),
	nhanxetnguoihd nvarchar(20),
	nhanxetchibo nvarchar(20),
	quydinhketnap nvarchar(20),
	foreign key(fileid) references Files(fileid)
);

Create table QTCT(
	qtctid int not null primary key identity(1,1),
	dayfrom datetime,
	dayto datetime,
	address nvarchar(100),
	organization nvarchar(100),
	chucvu nvarchar(100),
	fileid int,
	foreign key (fileid) references files(fileid)
);
Create table Family(
	fmlid int not null Identity(1,1),
	fileid int not null,
	name nvarchar(100),
	quanhe nvarchar(20),
	nghenghiep nvarchar(100),
	hoancanhkinhte nvarchar(1000),
	lichsuchinhtri nvarchar(1000),
	updateday datetime,
	birthday datetime,
	primary key (fmlid),
	foreign key (fileid) references files (fileid)
);

create table Bonus(
	bnid int not null identity (1,1),
	fileid int not null ,
	noidung nvarchar(1000),
	donvi nvarchar(200),
	ghichu nvarchar(1000),
	primary key(bnid),
	updateday datetime,
	daycreate datetime,
	foreign key(fileid) references files(fileid)
);

create table Discipline(
	dsid int not null identity (1,1) primary key,
	fileid int not null,
	donvi nvarchar(100),
	noidung nvarchar(500),
	ghichu nvarchar(1000),
	updateday datetime,
	daycreate datetime,
	active bit,
	approved bit,
	foreign key (fileid) references files(fileid)
);
create table Forms(
	formid int not null identity (1,1) primary key ,
	nameform nvarchar(100) not null ,
	namefile nvarchar(100) not null,
	note nvarchar(1000),
	updateday datetime,
	active bit,
	type int
)	
create table Toabroad (
	brid int not null primary key identity (1,1),
	fileid int not null,
	noiden nvarchar(200),
	lydo nvarchar(200),
	thoigiandi datetime,
	thoigiantrove datetime,
	createday datetime,
	active bit,
	status bit ,
	foreign key (fileid) references Files(fileid)
);
Create table Report (
	rpid int not null primary key identity (1,1),
	title nvarchar(200),
	filename nvarchar(20),
	reportday datetime,
	createday datetime,
	note nvarchar(1000),
	active bit
);

Create table Finance (
	financeid int not null primary key identity(1,1),
	name nvarchar(200),
	createday datetime,
	moneys bigint ,
	status int ,
);