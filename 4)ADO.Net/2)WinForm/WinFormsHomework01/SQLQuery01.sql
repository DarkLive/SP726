GO
CREATE PROC InsertStudent(
@no int,
@name nvarchar(50),
@prog nvarchar(50),
@facul nvarchar(50))
AS
INSERT INTO Students VALUES (@no,@name,@prog,@facul)
GO

GO
CREATE PROC UpdateStudent(
@index int,
@no int,
@name nvarchar(50),
@prog nvarchar(50),
@facul nvarchar(50))
AS
UPDATE Students SET StuNo = @no, stuName = @name, stuProgram = @prog, stuFaculty = @facul WHERE stuID = @index
GO