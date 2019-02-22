--SELECT CustomerID,OrderID FROM dbo.Orders WHERE ShipCity='London';

--SELECT * FROM dbo.Orders WHERE ShipCity='Stuttgart' AND EmployeeID < 5;

--SELECT ShipName FROM dbo.Orders WHERE CustomerID LIKE '%tor%' AND (ShipCountry='Mexico' OR ShipCountry='Italy');

--SELECT * FROM dbo.Orders ORDER BY EmployeeID DESC;
