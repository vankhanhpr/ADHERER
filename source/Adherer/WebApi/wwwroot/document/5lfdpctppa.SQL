USE [ADHERER]
GO

INSERT INTO [dbo].[Files]
           ([usid]
           ,[donvi]
           ,[ngaythangnamsinh]
           ,[hotendangdung]
           ,[hotenkhaisinh]
           ,[gioitinh]
           ,[dantoc]
           ,[tongiao]
           ,[nghenghiep]
           ,[ngayvaodangdb]
           ,[ngayvaodangct]
           ,[ngayvaodoan]
           ,[trinhdovanhoa]
           ,[chuyenmon]
           ,[quequan]
           ,[noicutru]
           ,[matp]
           ,[maqh]
           ,[xaid]
           ,[solylich]
           ,[createday]
           ,[updateday]
           ,[sdt]
           ,[email]
           ,[avatar]
           ,[cmnd]
           ,[daycmnd]
           ,[noicapcmnd]
           ,[hokhauthuongtru]
           ,[honnhan]
           ,[suckhoe])
     VALUES
           (<usid, int,>
           ,<donvi, int,>
           ,<ngaythangnamsinh, datetime,>
           ,<hotendangdung, nvarchar(200),>
           ,<hotenkhaisinh, nvarchar(200),>
           ,<gioitinh, bit,>
           ,<dantoc, int,>
           ,<tongiao, nvarchar(50),>
           ,<nghenghiep, nvarchar(100),>
           ,<ngayvaodangdb, datetime,>
           ,<ngayvaodangct, datetime,>
           ,<ngayvaodoan, datetime,>
           ,<trinhdovanhoa, nvarchar(2),>
           ,<chuyenmon, nvarchar(100),>
           ,<quequan, nvarchar(500),>
           ,<noicutru, nvarchar(300),>
           ,<matp, varchar(5),>
           ,<maqh, varchar(5),>
           ,<xaid, varchar(5),>
           ,<solylich, nvarchar(20),>
           ,<createday, datetime,>
           ,<updateday, datetime,>
           ,<sdt, nvarchar(10),>
           ,<email, nvarchar(100),>
           ,<avatar, nvarchar(20),>
           ,<cmnd, nvarchar(12),>
           ,<daycmnd, datetime,>
           ,<noicapcmnd, nvarchar(200),>
           ,<hokhauthuongtru, nvarchar(200),>
           ,<honnhan, bit,>
           ,<suckhoe, nvarchar(100),>)
GO


