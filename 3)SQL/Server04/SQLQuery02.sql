--CREATE DATABASE egeturan;

--DROP DATABASE egeturan;

--BACKUP DATABASE egeturan
--TO DISK = 'C:\xapps\SQLBackup\egeturan.bak';

--BACKUP DATABASE egeturan
--TO DISK = 'C:\xapps\SQLBackup\egeturandif.bak'
--WITH DIFFERENTIAL;

USE egeturan;
SELECT * FROM Persons;

--CREATE TABLE Persons( PersonID int, LastName varchar(50), FirstName varchar(50), Address varchar(250), City varchar(100) );

--DROP TABLE Persons;

--TRUNCATE TABLE Persons;

--ALTER TABLE Persons ADD Phone int;

--ALTER TABLE Persons DROP COLUMN City;

--ALTER TABLE Persons ALTER COLUMN PersonID bigint;

--ALTER TABLE Persons ALTER COLUMN LastName varchar(50) NOT NULL;
--UPDATE Persons SET LastName = 'N/A' WHERE LastName IS NULL;

--CREATE TABLE Persons( PersonID int NOT NULL PRIMARY KEY, LastName varchar(50) NOT NULL UNIQUE, FirstName varchar(50), Address varchar(250), City varchar(100) );

--ALTER TABLE Persons ALTER COLUMN FirstName varchar(50) NOT NULL;
--ALTER TABLE Persons DROP CONSTRAINT PK__Persons__AA2FFB8504CE3F1F;
--ALTER TABLE Persons ADD PRIMARY KEY(FirstName);

--CREATE TABLE Orders( OrderID int NOT NULL, userID int NOT NULL );

--ALTER TABLE Orders ADD FOREIGN KEY (userID) REFERENCES Persons(PersonID);
--ALTER TABLE Orders DROP CONSTRAINT FK__Orders__userID__6CD828CA;

--CREATE TABLE Persons( PersonID int NOT NULL PRIMARY KEY, LastName varchar(50) NOT NULL UNIQUE, FirstName varchar(50), Address varchar(250) DEFAULT GETDATE(), City varchar(100) DEFAULT 'Ýstanbul' );

--ALTER TABLE Persons DROP CONSTRAINT DF__Persons__City__756D6ECB;

--SELECT * INTO DESTTABLE FROM SOURCETABLE;

--CREATE INDEX IX_LastName ON Persons(LastName);

--CREATE TABLE Persons( PersonID int IDENTITY(1,1) PRIMARY KEY, LastName varchar(50) NOT NULL UNIQUE, FirstName varchar(50), Address varchar(250) DEFAULT GETDATE(), City varchar(100) DEFAULT 'Ýstanbul' );

--CREATE TABLE Persons( PersonID int IDENTITY(1,1) PRIMARY KEY, LastName varchar(50) NOT NULL UNIQUE, FirstName varchar(50), Age int, City varchar(100) DEFAULT 'Ýstanbul' CONSTRAINT CHK_Person CHECK (Age>=18 AND City = 'Ýstanbul') );
