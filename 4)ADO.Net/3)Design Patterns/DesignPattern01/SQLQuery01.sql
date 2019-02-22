GO
CREATE PROC InsertStudent(
@no nvarchar(10),
@name nvarchar(50),
@prog nvarchar(50),
@facul nvarchar(50))
AS
INSERT INTO Student VALUES (@no,@name,@prog,@facul)
GO

GO
CREATE PROC UpdateStudent(
@index nvarchar(10),
@no nvarchar(10),
@name nvarchar(50),
@prog nvarchar(50),
@facul nvarchar(50))
AS
UPDATE Student SET stuNo = @no, stuName= @name, stuProgram =  @prog, stuFaculty = @facul WHERE stuNo = @index
GO

GO
CREATE PROC ListStudent AS
SELECT * FROM Student
GO