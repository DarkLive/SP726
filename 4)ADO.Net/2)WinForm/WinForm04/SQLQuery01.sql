CREATE PROC SP_Eleman_Guncelle(
 @index int,
 @name nvarchar(50),
 @surname nvarchar(50),
 @city nvarchar(20)
)
AS
BEGIN
UPDATE Eleman SET Ad = @name, Soyad = @surname, Sehir = @city WHERE ID = @index
END