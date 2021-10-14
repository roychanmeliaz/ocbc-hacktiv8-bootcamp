CREATE DATABASE db_bank;

-- TABEL 1
USE db_bank;
CREATE TABLE tb_customers(
	customerNumber INT PRIMARY KEY IDENTITY(1,1),
	customerName VARCHAR(45) NOT NULL,
	contactLastName VARCHAR(45) NOT NULL,
	contactFirstName VARCHAR(45) NOT NULL,
	phone varchar(18) NOT NULL,
	addressLine1 VARCHAR(125) NOT NULL,
	addressLine2 VARCHAR(125) NOT NULL,
	city VARCHAR(40) NOT NULL,
	state VARCHAR(40) NOT NULL,
	postalCode VARCHAR(6) NOT NULL,
	country VARCHAR(40) NOT NULL,
	salesRepEmployeeNumber INT NOT NULL,
	creditLimit INT not null
);

INSERT INTO tb_customers(customerName,contactLastName, contactFirstName,phone,addressLine1,
addressLine2,city,state,postalCode,country,salesRepEmployeeNumber,creditLimit)
VALUES
    ('Roy','Meliaz','Roychan','082391906848','jl. muka kuning no 8','jl. keputih no3','Batam','Kepulauan Riau','29438','Indonesia',1,20000000),
    ('Fadhil','Ihsan','Fadhil','08123456789','jl. ali haji no 21','-','Semarang','Jawa Tengah','11223','Indonesia',1,15000000),
    ('Dzaky','Mulyanto','Dzaky','08080808088','jl. keputih no 3','jl. kasuari no 22','Surabaya','Jawa Timur','60111','Indonesia',2,30000000),
    ('Fuad','Zakiy','Fuad','082659377594','jl. rajawali no 19','-','Bandung','Jawa Barat','74937','Indonesia',2,40000000),
    ('Faisal','Rizal','Faisal','0834775t2333','jl. mulyosari no 1','jl. keputih no 11','Surabaya','Jawa Timur','60111','Indonesia',3,30000000);

SELECT * from tb_customers;

-- TABEL 2
CREATE TABLE tb_products(
	productCode INT PRIMARY KEY IDENTITY(1,1),
	productName VARCHAR(45) NOT NULL,
	productLine INT NOT NULL,
	productScale VARCHAR(45) NOT NULL,
	productVendor varchar(45) NOT NULL,
	productDescription text NOT NULL,
	quantityInStock int NOT NULL,
	buyPrice int NOT NULL,
	MSRP varchar(45) NOT NULL
);

INSERT INTO tb_products(productName,productLine,productScale,productVendor,productDescription,quantityInStock,buyPrice,MSRP)
VALUES 
    ('Huawei Band 6',0,5,'Huawei','Smart band',200,650000,500000),
    ('Seagate HDD 1 TB',0,7,'Seagate','External Hard Disk',300,1100000,1000000),
    ('Hada Labo Face Wash',1,6,'Hada Labo','Face Wash',4000,35000,35000),
    ('Susu Bendera Frision Flag',2,5,'Frision Flag','Susu kental manis',1300,25000,23000),
    ('Susu Dancow',2,10,'Nestle','Susu',500,52000,50000);

SELECT * from tb_products;

-- TABEL 3
CREATE TABLE tb_productlines(
	productLine INT PRIMARY KEY IDENTITY(1,1),
	textDescription TEXT NOT NULL,
	htmlDescription TEXT NOT NULL,
	image varchar(128) NOT NULL
);

INSERT INTO tb_productlines (textDescription,htmlDescription,image)
VALUES
    ('Electronics','electronics.html','electronics.jpg'),
    ('Cosmetics','cosmetics.html','cosmetics.jpg'),
    ('Milk','milk.html','milk.jpg'),
    ('Games','games.html','games.jpg'),
    ('Clothing','clothing.html','clothing.jpg');    ;

SELECT * from tb_productlines;

-- TABEL 4
CREATE TABLE tb_orders(
	orderNumber INT PRIMARY KEY IDENTITY(1,1),
	orderDate DATETIME NOT NULL,
	requiredDate DATETIME NOT NULL,
	shippedDate DATETIME NOT NULL,
	status VARCHAR(45) NOT NULL,
	comments VARCHAR(255) NOT NULL,
	customerNumber INT NOT NULL
);

INSERT INTO tb_orders (orderDate,requiredDate,shippedDate,status,comments,customerNumber)
VALUES
    ('2021-5-10 21:00:00','2021-10-13 00:00:00','2021-10-11 07:00:00','tervalidasi','-',0),
    ('2021-5-12 21:00:00','2021-10-16 00:00:00','2021-10-12 07:00:00','dikirimkan','-',1),
    ('2021-5-14 21:00:00','2021-10-17 00:00:00','2021-10-20 07:00:00','tervalidasi','-',2),
    ('2021-5-16 21:00:00','2021-10-19 00:00:00','2021-10-24 07:00:00','tervalidasi','-',3),
    ('2021-5-18 21:00:00','2021-10-19 00:00:00','2021-10-25 07:00:00','sudah selesai','-',4);

SELECT * from tb_orders;

-- TABEL 5
CREATE TABLE tb_orderdetails(
	orderNumber INT PRIMARY KEY IDENTITY(1,1),
	productCode INT NOT NULL,
	quantityOrdered INT NOT NULL,
	priceEach INT NOT NULL,
	orderLineNumber INT NOT NULL
);

INSERT INTO tb_orderdetails (productCode,quantityOrdered,priceEach,orderLineNumber)
VALUES
    (0,1,650000,0),
    (1,2,1100000,1),
    (2,1,35000,2),
    (3,3,25000,3),
    (4,1,52000,4);

SELECT * from tb_orderdetails;

-- TABEL 6
CREATE TABLE tb_payments(
	customerNumber INT NOT NULL,
	checkNumber INT PRIMARY KEY IDENTITY(1,1),
	PaymentDate DATETIME NOT NULL,
	amount INT NOT NULL,
);

INSERT INTO tb_payments (customerNumber,PaymentDate,amount)
VALUES
    (0,'2021-10-20 15:30:00',650000),
    (1,'2021-10-22 13:30:00',1100000),
    (2,'2021-10-23 12:30:00',35000),
    (3,'2021-10-24 08:30:00',25000),
    (4,'2021-10-25 21:30:00',52000);
   
SELECT * from tb_payments;


-- TABEL 7
CREATE TABLE tb_employees(
	employeeNumber INT PRIMARY KEY IDENTITY(1,1),
	lastName VARCHAR(45) NOT NULL,
	firstName VARCHAR(45) NOT NULL,
	extension VARCHAR(45) NOT NULL,
	email VARCHAR(128) NOT NULL,
	officeCode INT NOT NULL,
	reportsTo INT NOT NULL,
	jobTitle VARCHAR(45) NOT NULL,
);

INSERT INTO tb_employees (lastName,firstName,extension,email,officeCode,reportsTo,jobTitle)
VALUES
    ('angelina','nia','-','nia@mail.com',0,0,'Head Of Everything'),
    ('elva','grace','-','grace@mail.com',1,0,'Head Of Office'),
    ('risa','tanisha','-','tanisha@mail.com',1,1,'Office boy'),
    ('liudvya','may','-','may@mail.com',2,1,'counter'),
    ('hanum','nadila','-','nad@mail.com',2,1,'office staff');

SELECT * from tb_employees;

-- TABEL 8
CREATE TABLE tb_offices(
	officeCode INT PRIMARY KEY IDENTITY(1,1),
	city VARCHAR(40) NOT NULL,
	phone VARCHAR(18) NOT NULL,
	addressLine1 VARCHAR(125) NOT NULL,
	addressLine2 VARCHAR(125) NOT NULL,
	state VARCHAR(40) NOT NULL,
	country VARCHAR(40) NOT NULL,
	postalCode VARCHAR(6) NOT NULL,
	territory varchar(40) not null
);

INSERT INTO tb_offices (city,phone,addressLine1,addressLine2,state,country,postalCode,territory)
VALUES
    ('Jakarta Pusat','021021','jl. satrio','-','DKI Jakarta','Indonesia','73635','-'),
    ('Jakarta Selatan','021666','jl. jalan','-','DKI Jakarta','Indonesia','36254','-'),
    ('Jakarta Utara','021333','jl. baru','-','DKI Jakarta','Indonesia','84635','-'),
    ('Jakarta Timur','021222','jl. lama','-','DKI Jakarta','Indonesia','38274','-'),
    ('Jakarta Barat','021111','jl. sini','-','DKI Jakarta','Indonesia','37294','-');
    
SELECT * from tb_offices;

-- JOINED TABLE
SELECT
    cust.customerNumber, cust.customerName, ord.orderNumber, ods.quantityOrdered, ods.priceEach,
    (quantityOrdered * ods.priceEach) as totalPrice, pro.productName, ord.status, emp.firstName as salesrep
FROM tb_customers cust
JOIN tb_orders ord ON cust.customerNumber = ord.customerNumber
JOIN tb_orderdetails ods ON ord.orderNumber = ods.orderNumber
JOIN tb_products pro ON ods.productCode = pro.productCode
JOIN tb_employees emp ON cust.salesRepEmployeeNumber = emp.employeeNumber;
