CREATE TRIGGER TR_Acc_Remove ON Account 
INSTEAD OF DELETE AS
UPDATE Account SET usrActive = 0 WHERE usrID = (SELECT usrID FROM deleted)