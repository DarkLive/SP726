--INSERT INTO egeturan.dbo.Table_1(uID,uName,uPassword,uProfession) Values(26,'Ahmet','Par123','DB Specialist');

--INSERT INTO egeturan.dbo.Table_1 VALUES(34,'Gizem','Rap123!','Banker');

--INSERT INTO egeturan.dbo.Table_1 VALUES(Null,'NotNull','Rap123!','Banker');
--SELECT * FROM egeturan.dbo.Table_1 WHERE uID IS NULL;

--UPDATE egeturan.dbo.Table_1 SET uID = 25 WHERE uID IS NULL;

--UPDATE egeturan.dbo.Table_1 SET uID = 25, uName = 'Sevda' WHERE uID IS NULL;

--DELETE FROM egeturan.dbo.Table_1 WHERE uPassword='HHH' OR uProfession='Banker';

--DELETE FROM egeturan.dbo.Table_1;

--TRUNCATE TABLE egeturan.dbo.Table_1;

--SELECT * FROM egeturan.dbo.Table_1 WHERE uName LIKE '[ag]%';

--SELECT * FROM egeturan.dbo.Table_1 WHERE uName NOT LIKE '[ag]%';

--DROP TABLE egeturan.dbo.Table_1;

--SELECT * FROM egeturan.dbo.Table_1;