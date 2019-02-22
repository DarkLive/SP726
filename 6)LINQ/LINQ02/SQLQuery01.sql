USE Cinema
GO
CREATE VIEW AirOutput AS 
SELECT Movie.movName, Theater.theName, Air.airTime FROM Air
INNER JOIN Movie on Air.airMovID = Movie.movID
INNER JOIN Theater on Air.airTheID = Theater.theID
GO

GO
CREATE PROCEDURE SP_Insert_Movie (
@mname nvarchar(50))
AS
	INSERT Movie (movName) VALUES (@mname)
GO