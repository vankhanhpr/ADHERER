
-- ----------------------------
-- Table structure for devvn_tinhthanhpho
-- ----------------------------
DROP TABLE IF EXISTS devvn_tinhthanhpho;
CREATE TABLE devvn_tinhthanhpho (
  matp nvarchar(5)  NOT NULL,
  name nvarchar(100)  NOT NULL,
  type nvarchar(30) NOT NULL,
  PRIMARY KEY (matp)
) ;

INSERT INTO devvn_tinhthanhpho VALUES ('01', N'Thành phố Hà Nội' , N'Thành phố Trung ương');
INSERT INTO devvn_tinhthanhpho VALUES ('02' , N'Tỉnh Hà Giang' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('04' , N'Tỉnh Cao Bằng' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('06' , N'Tỉnh Bắc Kạn' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('08' , N'Tỉnh Tuyên Quang' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('10' , N'Tỉnh Lào Cai' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('11' , N'Tỉnh Điện Biên' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('12' , N'Tỉnh Lai Châu' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('14' , N'Tỉnh Sơn La' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('15' , N'Tỉnh Yên Bái' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('17' , N'Tỉnh Hoà Bình' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('19' , N'Tỉnh Thái Nguyên' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('20' , N'Tỉnh Lạng Sơn' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('22' , N'Tỉnh Quảng Ninh' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('24' , N'Tỉnh Bắc Giang' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('25' , N'Tỉnh Phú Thọ' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('26' , N'Tỉnh Vĩnh Phúc' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('27' , N'Tỉnh Bắc Ninh' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('30' , N'Tỉnh Hải Dương' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('31' , N'Thành phố Hải Phòng' , N'Thành phố Trung ương');
INSERT INTO devvn_tinhthanhpho VALUES ('33' , N'Tỉnh Hưng Yên' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('34' , N'Tỉnh Thái Bình' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('35' , N'Tỉnh Hà Nam' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('36' , N'Tỉnh Nam Định' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('37' , N'Tỉnh Ninh Bình' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('38' , N'Tỉnh Thanh Hóa' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('40' , N'Tỉnh Nghệ An' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('42' , N'Tỉnh Hà Tĩnh' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('44' , N'Tỉnh Quảng Bình' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('45' , N'Tỉnh Quảng Trị' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('46' , N'Tỉnh Thừa Thiên Huế' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('48' , N'Thành phố Đà Nẵng' , N'Thành phố Trung ương');
INSERT INTO devvn_tinhthanhpho VALUES ('49' , N'Tỉnh Quảng Nam' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('51' , N'Tỉnh Quảng Ngãi' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('52' , N'Tỉnh Bình Định' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('54' , N'Tỉnh Phú Yên' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('56' , N'Tỉnh Khánh Hòa' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('58' , N'Tỉnh Ninh Thuận' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('60' , N'Tỉnh Bình Thuận' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('62' , N'Tỉnh Kon Tum' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('64' , N'Tỉnh Gia Lai' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('66' , N'Tỉnh Đắk Lắk' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('67' , N'Tỉnh Đắk Nông' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('68' , N'Tỉnh Lâm Đồng' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('70' , N'Tỉnh Bình Phước' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('72' , N'Tỉnh Tây Ninh' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('74' , N'Tỉnh Bình Dương' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('75' , N'Tỉnh Đồng Nai' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('77' , N'Tỉnh Bà Rịa - Vũng Tàu' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('79' , N'Thành phố Hồ Chí Minh' , N'Thành phố Trung ương');
INSERT INTO devvn_tinhthanhpho VALUES ('80' , N'Tỉnh Long An' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('82' , N'Tỉnh Tiền Giang' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('83' , N'Tỉnh Bến Tre' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('84' , N'Tỉnh Trà Vinh' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('86' , N'Tỉnh Vĩnh Long' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('87' , N'Tỉnh Đồng Tháp' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('89' , N'Tỉnh An Giang' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('91' , N'Tỉnh Kiên Giang' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('92' , N'Thành phố Cần Thơ' , N'Thành phố Trung ương');
INSERT INTO devvn_tinhthanhpho VALUES ('93' , N'Tỉnh Hậu Giang' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('94' , N'Tỉnh Sóc Trăng' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('95' , N'Tỉnh Bạc Liêu' , N'Tỉnh');
INSERT INTO devvn_tinhthanhpho VALUES ('96' , N'Tỉnh Cà Mau' , N'Tỉnh');