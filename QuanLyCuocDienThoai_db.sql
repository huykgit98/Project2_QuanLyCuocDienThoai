﻿<!--phone và email dùng để tra cứu thông tin cước phí sử dụng-->
CREATE TABLE CUSTOMER(
	id NVARCHAR(10),
	name_cus NVARCHAR(50),
	identify INT,
	job NVARCHAR(50),
	position NVARCHAR(50),
	address NVARCHAR(200),
	email NVARCHAR(100),
	PRIMARY KEY(id)
)
<!--status: tình trạng sim(0: chưa đăng ký; 1: đã đăng ký )-->
GO
CREATE TABLE SIM(
	id NVARCHAR(10),
	id_cus NVARCHAR(10),
	phone int,
	status BIT
	PRIMARY KEY (id),
	UNIQUE(phone),
	CONSTRAINT FK_SIM_CUSTOMER FOREIGN KEY (id_cus) REFERENCES CUSTOMER(id)
)


<!--fee: phí hòa mạng-->
GO
CREATE TABLE CONTRACT(
	id NVARCHAR(10),
	id_sim NVARCHAR(10),
	date_register DATETIME,
	fee INT,
	status BIT,
	PRIMARY KEY(id),
	UNIQUE (id_sim),
	CONSTRAINT FK_CONTRACT_SIM FOREIGN KEY (id_sim) REFERENCES SIM(id)
)
GO

<!--date_export:ngày xuất hóa đơn; date_cut: ngày cắt sim thực sự khi khách hàng chưa thanh cmn toán hóa đơn sau 30 ngày kể từ ngày xuất hóa đơn (ngày này sau ngày xuất 33 ngày); postage: cước thuê bao hàng tháng; fare:Cước phí hàng tháng; status: tình trạng thanh toán cước phí-->
CREATE TABLE BILL(
	id NVARCHAR(10),
	id_sim NVARCHAR(10),
	date_export DATETIME,
	date_cut DATETIME,
	postage INT,
	fare INT,
	status BIT,
	PRIMARY KEY (id),
	CONSTRAINT FK_BILL_SIM FOREIGN KEY (id_sim) REFERENCES SIM(id)
)

<!--fare: cước phí theo thời gian (7h->23h :200 đ/phút ; 23h->7h :150đ/phút)-->
GO
CREATE TABLE FARE(
	id NVARCHAR(10),
	time_start TIME,
	time_stop TIME,
	fare INT
	PRIMARY KEY (id)
)
<!--Chi Tiết Từng Cuộc Gọi -->
GO
CREATE TABLE DETAIL(
	id INT IDENTITY(1,1),
	id_sim NVARCHAR(10),
	time_start DATETIME,
	time_stop DATETIME,
	minute_7hto23h INT,
	minute_23hto7h INT,
	fare INT
	PRIMARY KEY(id),
	CONSTRAINT FK_DETAIL_SIM FOREIGN KEY (id_sim) REFERENCES SIM(id),
)
GO
INSERT INTO CUSTOMER VALUES ('KH01',N'Lâm Chấn Khang','025664871',N'Sinh Viên',N'Sinh Viên',N'Tầng 6, 123B Trần Đăng Ninh, P. Dịch Vọng, Q. Cầu Giấy, Hà Nội',N'huykg98@gmail.com');
INSERT INTO CUSTOMER VALUES ('KH02',N'Đỗ Nam Trung','024357428',N'Kế Toán',N'Trưởng Kế Toán',N'189A Cống Quỳnh, phường Nguyễn Cư Trinh, Quận 1, TP. Hồ Chí Minh',N'huykg981@gmail.com');
INSERT INTO CUSTOMER VALUES ('KH03',N'Đàm Vĩnh Hưng','02687488',N'Công Nghệ Thông Tin',N'Kỹ Thuật Phần Mềm',N'375- 377 Nguyễn Đình Chiểu, phường 5, Quận 3, TP. Hồ Chí Minh',N'huykg982@gmail.com');
INSERT INTO CUSTOMER VALUES ('KH04',N'Châu Kiệt Luân','024258741',N'Quản Trị Kinh Doanh',N'Phó Phòng',N'58 Nguyễn Trãi, Phường 3, Quận 5, TP. Hồ Chí Minh',N'huykg983@gmail.com');
INSERT INTO CUSTOMER VALUES ('KH05',N'Hari Won','025102485',N'Nội Trợ',N'Nội Trợ',N'478 Cách Mạng Tháng Tám, phường 11, Quận 3, TP. Hồ Chí Minh',N'huykg984@gmail.com');
INSERT INTO CUSTOMER VALUES ('KH06',N'Trấn Thành','023542874',N'Bảo Vệ',N'Bảo Vệ',N'126 Hùng Vương, Quận 5, Quận 5, TP. Hồ Chí Minh',N'huykg985@gmail.com');
INSERT INTO CUSTOMER VALUES ('KH07',N'Thành Long','024759863',N'Kiến Trúc Sư',N'Kiến Trúc Sư',N'286 Võ Văn Ngân, phường Bình Thọ, Quận Thủ Đức, TP. Hồ Chí Minh',N'huykg986@gmail.com');
INSERT INTO CUSTOMER VALUES ('KH08',N'Ưng Đại Vệ','024351242',N'Thiết Kế',N'Thiết Kế',N'530 Lê Văn Sỹ, Phường 14, Quận 3, TP. Hồ Chí Minh',N'huykg987@gmail.com');


INSERT INTO SIM VALUES('S01','KH01','092356874',1);
INSERT INTO SIM VALUES('S02','KH02','092369685',1);
INSERT INTO SIM VALUES('S03','KH03','092435752',1);
INSERT INTO SIM VALUES('S04','KH04','092369633',1);
INSERT INTO SIM VALUES('S05','KH05','092134752',1);
INSERT INTO SIM VALUES('S06','KH06','092475845',1);
INSERT INTO SIM VALUES('S07','KH07','092024205',1);
INSERT INTO SIM VALUES('S08','KH08','092369746',1);
INSERT INTO SIM VALUES('S09',NULL,'092130425',0);
INSERT INTO SIM VALUES('S10',NULL,'092346674',0);
INSERT INTO SIM VALUES('S11',NULL,'092431852',0);
INSERT INTO SIM VALUES('S12',NULL,'092030341',0);
INSERT INTO SIM VALUES('S13',NULL,'093201010',0);
INSERT INTO SIM VALUES('S14',NULL,'092235422',0);
INSERT INTO SIM VALUES('S15',NULL,'092223585',0);
INSERT INTO SIM VALUES('S16',NULL,'092369638',0);
INSERT INTO SIM VALUES('S17',NULL,'092132323',0);
INSERT INTO SIM VALUES('S18',NULL,'092310012',0);
INSERT INTO SIM VALUES('S19',NULL,'092000528',0);
INSERT INTO SIM VALUES('S20',NULL,'092475124',0);

INSERT INTO CONTRACT VALUES ('C01','S01','10/20/2017',50000,1);
INSERT INTO CONTRACT VALUES ('C02','S02','9/21/2017',50000,1);
INSERT INTO CONTRACT VALUES ('C03','S03','3/12/2017',50000,1);
INSERT INTO CONTRACT VALUES ('C04','S04','6/28/2017',50000,1);
INSERT INTO CONTRACT VALUES ('C05','S05','2/2/2017',50000,1);
INSERT INTO CONTRACT VALUES ('C06','S06','3/7/2017',50000,1);
INSERT INTO CONTRACT VALUES ('C07','S07','6/9/2017',50000,1);
INSERT INTO CONTRACT VALUES ('C08','S08','6/6/2017',50000,1);

INSERT INTO BILL VALUES('B01','S01','6/15/2018','7/18/2018',50000,114000,1);
INSERT INTO BILL VALUES('B02','S01','2/2/2018','3/5/2018',50000,90000,0);
INSERT INTO BILL VALUES('B03','S01','1/15/2018','2/18/2018',50000,80000,1);
INSERT INTO BILL VALUES('B04','S01','5/8/2018','6/11/2018',50000,90000,1);
INSERT INTO BILL VALUES('B05','S02','6/3/2018','7/6/2018',50000,76000,0);
INSERT INTO BILL VALUES('B06','S02','10/20/2018','11/23/2018',50000,700000,1);
INSERT INTO BILL VALUES('B07','S02','2/1/2018','3/4/2018',50000,112000,0);
INSERT INTO BILL VALUES('B08','S03','3/27/2018','4/30/2018',50000,80000,0);
INSERT INTO BILL VALUES('B09','S03','9/14/2018','10/17/2018',50000,82000,0);
INSERT INTO BILL VALUES('B10','S03','6/18/2018','7/21/2018',50000,92000,1);
INSERT INTO BILL VALUES('B11','S03','1/1/2018','2/4/2018',50000,82000,1);
INSERT INTO BILL VALUES('B12','S03','4/8/2018','5/11/2018',50000,64000,1);
INSERT INTO BILL VALUES('B13','S04','5/19/2018','6/22/2018',50000,62000,0);
INSERT INTO BILL VALUES('B14','S04','6/13/2018','7/16/2018',50000,64000,0);
INSERT INTO BILL VALUES('B15','S04','4/16/2018','5/19/2018',50000,114000,0);

INSERT INTO FARE VALUES('DAY','7:00','23:00',200);
INSERT INTO FARE VALUES('NIGHT','23:00','7:00',150);

INSERT INTO DETAIL VALUES('S01','6/12/2018 8:23','6/12/2018 9:21',58,0,61000);
Delete from DETAIL
Delete from SIM
Delete from CONTRACT
Delete from BILL

select * from SIM
select * from BILL
select BILL.id,SIM.phone, BILL.date_export, BILL.date_cut, BILL.postage, BILL.fare, BILL.status, CUSTOMER.name_cus, CUSTOMER.email from BILL, SIM, CUSTOMER where SIM.phone ='92356874'