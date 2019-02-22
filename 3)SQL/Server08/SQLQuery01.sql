--CREATE TRIGGER TR_Ogrenci_Sil
--ON Ogrenciler
--INSTEAD OF DELETE AS
--DECLARE @ogrenciid int = (SELECT OgrenciID FROM deleted)
--UPDATE Ogrenciler SET Mezun = 1 WHERE OgrenciID = @ogrenciid

--UPDATE Ogrenciler SET Mezun = 0 WHERE OgrenciID = 2
--DELETE FROM Ogrenciler WHERE OgrenciID = 2

--CREATE TRIGGER TR_AFTER_INSERT_Listele
--ON Ogrenciler
--AFTER INSERT AS
--DECLARE @ogrenciid int = (SELECT OgrenciID FROM inserted)
--SELECT * FROM Ogrenciler WHERE OgrenciID = @ogrenciid

--INSERT INTO Ogrenciler VALUES ('TestX',0)

--CREATE TRIGGER TR_Instead_Delete_Ogretmen
--ON Ogretmenler INSTEAD OF DELETE AS
--DECLARE @oid int = (SELECT OgretmenID FROM deleted), @oad nvarchar(50) = (SELECT OgretmenAdi FROM deleted)
--UPDATE Ogretmenler SET Aktif = 0 WHERE OgretmenID = @oid
--INSERT INTO EskiOgretmenler VALUES (@oid, @oad)

--SELECT * FROM Ogretmenler
--SELECT * FROM EskiOgretmenler
--DELETE FROM Ogretmenler WHERE OgretmenID = 5

--CREATE TABLE EskiOgretmenler(
--OgretmenID int IDENTITY(1,1) PRIMARY KEY,
--OgretmenAdi nvarchar(50) NOT NULL)

--CREATE TRIGGER TR_Instead_Update_Ogretmen
--ON Ogretmenler INSTEAD OF UPDATE AS
--PRINT 'Bu iþlem için Veri Tabaný Yöneticisi ile iletiþime geçin'

--SELECT * FROM Ogretmenler
--UPDATE Ogretmenler SET OgretmenAdi='X' WHERE OgretmenID=1