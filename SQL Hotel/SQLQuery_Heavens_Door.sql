CREATE DATABASE Hotel_Management_System;

CREATE TABLE User_Table
(
User_ID INT IDENTITY(1, 1) NOT NULL,
User_Name VARCHAR(150) NOT NULL,
User_Password VARCHAR(150) NOT NULL,
CONSTRAINT User_Table_User_ID_PK Primary Key (User_ID)
);

INSERT INTO User_Table VALUES
('NVK', '1234');

SELECT * FROM User_Table