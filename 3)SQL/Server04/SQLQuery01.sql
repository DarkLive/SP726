USE egeturan;

SELECT * FROM Staff;
INSERT INTO Staff VALUES ('TestName','TestSurname',1);

SELECT * FROM EstateTypes;
INSERT INTO EstateTypes VALUES ('Test');

SELECT * FROM Customer;
INSERT INTO Customer VALUES ('Test');

SELECT * FROM Estate;
INSERT INTO Estate (estType,estRoom,estAddress,estPrice,estAngle,estParking,estLivingRoom,estTotalFloor,estCurFloor) 
			VALUES (1,3,'Kadýköy Hasanpaþa', 40000, 'South', 1, 1, 3, 2);

SELECT * FROM Transactions;
INSERT INTO Transactions VALUES (4,4,3,'Sold');