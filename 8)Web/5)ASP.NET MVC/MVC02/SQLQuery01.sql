GO
CREATE TRIGGER TR_Acc_Remove ON Account 
INSTEAD OF DELETE AS
UPDATE Account SET usrActive = 0 WHERE usrID = (SELECT usrID FROM deleted)
GO

GO
CREATE TRIGGER TR_Art_Remove ON Article 
INSTEAD OF DELETE AS
UPDATE Article SET artActive = 0 WHERE artID = (SELECT artID FROM deleted)
GO