--CREATE PROCEDURE SP_Reg_Staff(
--@name nvarchar(50),
--@surname nvarchar(50)) AS
--BEGIN
--INSERT INTO egeturan.dbo.Staff VALUES (@name,@surname)
--END

--EXECUTE SP_Reg_Staff 'TestN','TestS'

--CREATE PROCEDURE SP_Insert_Notlar(
--@not1 smallint,
--@not2 smallint) AS
--BEGIN
--INSERT INTO OKUL_VT.dbo.Notlar VALUES (@not1,@not2)
--END

--CREATE PROCEDURE SP_Update_Notlar(
--@not1 smallint,
--@not2 smallint,
--@index int) AS
--BEGIN
--UPDATE OKUL_VT.dbo.Notlar SET Not1 = @not1, Not2 = @not2 WHERE NotID = @index
--END

--CREATE PROCEDURE SP_Delete_Notlar(
--@index int) AS
--BEGIN
--DELETE FROM OKUL_VT.dbo.Notlar WHERE NotID = @index
--END

--CREATE PROCEDURE SP_Insert_Ogrenciler(
--@ogrenciadi nvarchar(50)) AS
--BEGIN
--INSERT INTO OKUL_VT.dbo.Dersler VALUES (@ogrenciadi)
--END

--CREATE PROCEDURE SP_List_Ogrenci AS
--BEGIN
--	SELECT * FROM Ogrenciler
--END
--EXEC SP_List_Ogrenci

--CREATE PROCEDURE SP_List1_Ogrenci (@ogrenci nvarchar(50) OUTPUT) AS
--BEGIN
--	SET @ogrenci = ( SELECT OgrenciAdi FROM Ogrenciler WHERE OgrenciID=1 )
--END

--DECLARE @ogrenciout nvarchar(50)
--EXEC SP_List1_Ogrenci @ogrenciout OUTPUT
--PRINT @ogrenciout

--SET NOCOUNT ON
--INSERT INTO Dersler Values('Türkçe')

--CREATE FUNCTION FN_Ogretmen_Ad_Getir(@oid int)
--RETURNS nvarchar(50) AS 
--BEGIN
--DECLARE @ogretmenadi nvarchar(50) = (SELECT OgretmenAdi FROM Ogretmenler WHERE OgretmenID=@oid)
--RETURN @ogretmenadi
--END

--SELECT OKUL_VT.dbo.FN_Ogretmen_Ad_Getir(5)

