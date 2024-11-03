CREATE DATABASE HeavensDoor;

CREATE TABLE User_Table
(
User_ID INT IDENTITY(1, 1) NOT NULL,
User_Name VARCHAR(150) NOT NULL,
User_Password VARCHAR(150) NOT NULL,
CONSTRAINT User_Table_User_ID_PK Primary Key (User_ID)
);


INSERT INTO User_Table VALUES
('NVK', '1234');
INSERT INTO User_Table VALUES
('OEY', '1234');
INSERT INTO User_Table VALUES
('ANI', '1234');
INSERT INTO User_Table VALUES
('JON', '1234');


CREATE TABLE Guest_Table
(
Guest_ID INT IDENTITY (1, 1) NOT NULL,
Guest_Name VARCHAR (150) NOT NULL,
Guest_Gender VARCHAR (50) NOT NULL,
Guest_Age VARCHAR (50) NOT NULL,
Guest_Phone VARCHAR (15) UNIQUE NOT NULL,
Guest_Address VARCHAR (150) NOT NULL,
CONSTRAINT Client_Table_Client_ID_PK PRIMARY KEY (Guest_ID)
);

INSERT INTO Guest_Table VALUES
('Fernando Yulius', 'Laki-laki', '19', '0875242751', 'Allogio Barat 5'),
('Ongko Filberto', 'Laki-laki', '19', '08412787511', 'Allogio Barat 3'),
('Nelson Frederick', 'Laki-laki', '19', '0852651372', 'Allogio Barat 7')
;

CREATE TABLE Room_Table 
(
	Room_Number INT IDENTITY(1, 1) NOT NULL,
	Room_Type VARCHAR (50) NOT NULL,
	Room_Phone VARCHAR(15) UNIQUE NOT NULL,
	Room_Booked VARCHAR(3) NOT NULL,
	CONSTRAINT Room_Table_Room_Number_PK PRIMARY KEY (Room_Number)
);

DROP TABLE Room_Table
INSERT INTO Room_Table VALUES
('Standard Room', '+101', 'No'),
('Standard Room', '+102', 'No'),
('Standard Room', '+103', 'No'),
('Standard Room', '+104', 'No'),
('Standard Room', '+105', 'No'),
('Superior Room', '+106', 'No'),
('Superior Room', '+107', 'No'),
('Superior Room', '+108', 'No'),
('Superior Room', '+109', 'No'),
('Superior Room', '+110', 'No'),
('Deluxe Room', '+111', 'No'),
('Deluxe Room', '+112', 'No'),
('Deluxe Room', '+113', 'No'),
('Deluxe Room', '+114', 'No'),
('Deluxe Room', '+115', 'No'),
('Suite Room', '+116', 'No'),
('Suite Room', '+117', 'No'),
('Suite Room', '+118', 'No'),
('Suite Room', '+119', 'No'),
('Suite Room', '+120', 'No'),
('Twin Room', '+121', 'No'),
('Twin Room', '+122', 'No'),
('Twin Room', '+123', 'No'),
('Twin Room', '+124', 'No'),
('Twin Room', '+125', 'No'),
('Double Room', '+126', 'No'),
('Double Room', '+127', 'No'),
('Double Room', '+128', 'No'),
('Double Room', '+129', 'No'),
('Double Room', '+130', 'No'),
('Family Room', '+131', 'No'),
('Family Room', '+132', 'No'),
('Family Room', '+133', 'No'),
('Family Room', '+134', 'No'),
('Family Room', '+135', 'No');



CREATE TABLE Reservation_Table
(
Reservation_ID INT IDENTITY (1, 1) NOT NULL,
Reservation_Room_Type VARCHAR (50) NOT NULL,
Reservation_Room_Number VARCHAR (35) NOT NULL,
Reservation_Guest_ID INT UNIQUE NOT NULL,
Reservation_In VARCHAR (32) NOT NULL,
Reservation_Out VARCHAR (32) NOT NULL,
CONSTRAINT Reservation_Table_Reservation_ID_PK PRIMARY KEY (Reservation_ID)
);

CREATE TABLE Report_Table
(
Report_ID INT IDENTITY (1, 1) NOT NULL,
Report_Room_Type VARCHAR (50) NOT NULL,
Report_Guest_Name VARCHAR (150) NOT NULL,
Report_Guest_ID VARCHAR (50) NOT NULL,
Report_Room_Number VARCHAR (50) NOT NULL,
Report_Check_In VARCHAR (32) NOT NULL,
Report_Check_Out VARCHAR (32) NOT NULL,
Report_Price VARCHAR (35) NOT NULL,
CONSTRAINT Report_Table_Report_ID_PK PRIMARY KEY (Report_ID)
);









DROP TABLE Report_Table
DROP TABLE Reservation_Table
SELECT * FROM User_Table

SELECT * FROM Report_Table

SELECT * FROM Guest_Table

SELECT * FROM Room_Table

SELECT * FROM Reservation_Table

DELETE FROM Report_Table
WHERE Report_ID = 5;
