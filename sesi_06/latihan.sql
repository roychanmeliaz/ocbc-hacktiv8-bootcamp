-- A
CREATE database db_staff;

-- B
USE db_staff;
CREATE TABLE tb_staff(
    id INT PRIMARY KEY IDENTITY(1,1),
	nik VARCHAR (10),
    nama VARCHAR(50),
    alamat VARCHAR(200),
    handphone VARCHAR(16)
)

-- C dan D
INSERT INTO tb_staff(nik, nama, alamat, handphone) VALUES('0001','Roy','Batam','0808');
INSERT INTO tb_staff(nik, nama, alamat, handphone) VALUES('0001','Fadhil','Jakarta','0808');
INSERT INTO tb_staff(nik, nama, alamat, handphone) VALUES('0003','Dzaky','Jogja','0808');
INSERT INTO tb_staff(nik, nama, alamat, handphone) VALUES('0004','Nadim','Bandung','0808');
INSERT INTO tb_staff(nik, nama, alamat, handphone) VALUES('0005','Abid','Surabaya','0808');
INSERT INTO tb_staff(nik, nama, alamat, handphone) VALUES('0006','Haekal','Malang','0808');

-- E
ALTER TABLE tb_staff ADD joindate varchar(4);
INSERT INTO tb_staff(nik, nama, alamat, handphone, joindate) VALUES('7','Waqar','Malang','0808', '2021');

-- F
SELECT TOP 2 * FROM tb_staff;

-- G
SELECT TOP 3 * FROM tb_staff;

-- H
CREATE table tb_staff_outsource( 
    id INT PRIMARY KEY IDENTITY(1,1),
	nik VARCHAR (10),
    nama VARCHAR(50),
    alamat VARCHAR(200),
    handphone VARCHAR(16),
	joindate VARCHAR(4)
);

-- I
INSERT INTO tb_staff_outsource(nik, nama, alamat, handphone, joindate) VALUES('0001', 'Faishal', 'Sidoarjo', '8080', '2017');
INSERT INTO tb_staff_outsource(nik, nama, alamat, handphone, joindate) VALUES('0002', 'Uqi', 'Tangerang', '8080', '2015');
INSERT INTO tb_staff_outsource(nik, nama, alamat, handphone, joindate) VALUES('0003', 'Fikar', 'Cilegon', '8080', '2018');
INSERT INTO tb_staff_outsource(nik, nama, alamat, handphone, joindate) VALUES('0004', 'Agung', 'Madiun', '8080', '2016');
INSERT INTO tb_staff_outsource(nik, nama, alamat, handphone, joindate) VALUES('0005', 'Mpu', 'Solo', '8080', '2021');
INSERT INTO tb_staff_outsource(nik, nama, alamat, handphone, joindate) VALUES('0006', 'Grace', 'Bogor', '8080', '2020');
INSERT INTO tb_staff_outsource(nik, nama, alamat, handphone, joindate) VALUES('0007', 'Pujik', 'Bukittinggi', '8080', '2016');
INSERT INTO tb_staff_outsource(nik, nama, alamat, handphone, joindate) VALUES('0008', 'Nia', 'Sidoarjo', '8080', '2020');
INSERT INTO tb_staff_outsource(nik, nama, alamat, handphone, joindate) VALUES('0009', 'Bara', 'Surabaya', '8080', '2021');
INSERT INTO tb_staff_outsource(nik, nama, alamat, handphone, joindate) VALUES('0010', 'Furqan', 'Bandung', '8080', '2012');

-- J
SELECT so.*, s.* FROM tb_staff s JOIN tb_staff_outsource so ON so.joinDate = s.joinDate WHERE so.joinDate = s.joinDate;

-- K
SELECT * FROM tb_staff a 
RIGHT JOIN tb_staff_outsource b 
ON a.joindate = b.joindate;

-- L
SELECT * FROM tb_staff a
LEFT JOIN tb_staff_outsource b 
ON a.joindate = b.joindate;

-- M
SELECT * FROM tb_staff a 
FULL JOIN tb_staff_outsource b 
ON a.joindate = b.joindate;

