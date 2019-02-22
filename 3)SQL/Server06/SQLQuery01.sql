--DECLARE @Name nvarchar(50)
--SET @Name = 'Mehmet Demir'
--SELECT @NAME = 'Mehmet Demir'
--PRINT @Name

--PRINT @@ERROR

--DECLARE @Number smallint
--SET @Number = (SELECT ID FROM egeturan.dbo.TestStaff WHERE ID=3)
--SELECT CASE @Number
--WHEN 1 THEN 'Try Again'
--WHEN 2 THEN 'Pass'
--WHEN 3 THEN 'Level UP'
--ELSE 'Number out of bounds'
--END

--DECLARE @Operation nvarchar(25), @Name nvarchar(50), @Surname nvarchar(50), @City nvarchar(50)
--SET @Operation = 'Add' SET @Name = 'TestX'SET @Surname = 'TestX'SET @City = 'TestCity'
--IF @Operation='Add'
--	INSERT INTO egeturan.dbo.TestStaff VALUES(@Name,@Surname,@City)
--ELSE IF @Operation='Remove'
--	DELETE FROM egeturan.dbo.TestStaff WHERE @Name=@Name
--ELSE IF @Operation='Update'
--	UPDATE egeturan.dbo.TestStaff SET Name = @Name, Surname = @Surname, City = @City WHERE Name=@Name;

--DECLARE @sayac int
--SELECT @sayac=1
--WHILE @sayac<=100
--BEGIN
--	INSERT INTO egeturan.dbo.TestStaff VALUES('Test','Test2',@sayac)
--	SELECT @sayac = @sayac + 1
--END

--CREATE DATABASE OKUL_VT

--USE OKUL_VT
--CREATE TABLE Ogrenciler(
--	OgrenciID smallint IDENTITY(1,1) PRIMARY KEY,
--	OgrenciAdi nvarchar(50))

--CREATE TABLE Ogretmenler(
--	OgretmenID smallint IDENTITY(1,1) PRIMARY KEY,
--	OgretmenAdi nvarchar(50))

--CREATE TABLE Dersler(
--	DersID smallint IDENTITY(1,1) PRIMARY KEY,
--	DersAdi nvarchar(50))

--CREATE TABLE Notlar(
--	NotID smallint IDENTITY(1,1) PRIMARY KEY,
--	Not1 smallint,
--	Not2 smallint)

--USE OKUL_VT
--INSERT INTO Ogrenciler VALUES('TestOgrenci')
--INSERT INTO Ogretmenler VALUES('TestOgretmen')
--INSERT INTO Dersler VALUES('TestDers')

--DECLARE @sayac int, @ogrencisayisi int, @derssayisi int, @total int
--SET @ogrencisayisi = (SELECT COUNT(*) FROM Ogrenciler) SET @derssayisi = (SELECT COUNT(*) FROM Dersler)
--SET @sayac = 1 SET @total = @ogrencisayisi*@derssayisi
--WHILE @sayac <= @total
--BEGIN 
--DECLARE @Not1 smallint, @Not2 smallint
--SET @Not1 = CONVERT(int,rand()*100) SET @Not2 = CONVERT(int,rand()*100) 
--INSERT INTO Notlar VALUES(@Not1,@Not2)
--SET @sayac += 1
--END

--DECLARE @sayac2 int
--SET @sayac2 = 1
--WHILE @sayac2 <= (SELECT COUNT(*) FROM Notlar)
--BEGIN
--IF (SELECT (Not1+Not2)/2 FROM Notlar WHERE NotID=@sayac2) <= 50
--UPDATE Notlar SET Not1 += 20, Not2 += 20 WHERE NotID = @sayac2
--SET @sayac2 += 1
--END

--UPDATE Notlar SET Not1 += 20, Not2 += 20 WHERE ((Not1+Not2)/2)<=50

--USE OKUL_VT
--BEGIN TRANSACTION
--	UPDATE Ogrenciler SET OgrenciAdi = 'X' WHERE OgrenciID=1

--	--ROLLBACK
--COMMIT
