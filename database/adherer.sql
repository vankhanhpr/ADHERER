Create database ADHERER;
use Adherer;

create table DangBo(
	dbid int not null primary key identity (1,1),
	tendb nvarchar(200),
	active bit
);
create table ChiBo(
	cbid int not null identity(1,1) primary key,
	tencb nvarchar(200),
	dbid int not null,
	active bit,
	foreign key(dbid) references DangBo(dbid)
);
create table Users (
	usid int not null Identity(1,1),
	madv nvarchar(9),
	cbid int not null,
	ngaydenchibo datetime,
	createday datetime,
	password nvarchar(100),
	primary key(usid),
	active bit not null,
	foreign key (cbid) references Chibo(cbid)
);
Create table Files (
	fileid int not null Identity(1,1),
	usid int  not null,
	donvi int,
	ngaythangnamsinh datetime,
	hotendangdung nvarchar(200),
	hotenkhaisinh nvarchar(200),
	gioitinh bit ,
	dantoc int ,
	tongiao int,
	nghenghiep nvarchar(100),
	ngayvaodang datetime ,
	ngayvaodoan datetime ,
	trinhdovanhoa nvarchar(2),
	chuyenmon nvarchar(100),
	quequan nvarchar(500),
	noicutru nvarchar(300),
	solilich nvarchar(20),
	updateday datetime,
	sdt nvarchar(10),
	email nvarchar(100),
	primary key(fileid),
	foreign key (usid) references users(usid)
);
Create table Family(
	fmlid int not null Identity(1,1),
	fileid int not null,
	quanhe nvarchar(20),
	noisinh nvarchar(200),
	quequan nvarchar(200),
	nghenghiep nvarchar(100),
	hoancanhkinhte nvarchar(1000),
	lichsuchinhtri nvarchar(1000),
	updatedate datetime,
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
	updatedate datetime,
	foreign key(fileid) references files(fileid)
);
create table Discipline(
	dsid int not null identity (1,1) primary key,
	fileid int not null,
	noidung nvarchar(500),
	ghichu nvarchar(1000),
	updatedate datetime,
	foreign key (fileid) references files(fileid)
);
create table Forms(
	formid int not null identity (1,1) primary key ,
	nameform nvarchar(100) not null ,
	namefile nvarchar(100) not null,
	updatedate datetime,
	active bit
)
create table Forms(
	formid int not null identity (1,1) primary key ,
	nameform nvarchar(100) not null ,
)