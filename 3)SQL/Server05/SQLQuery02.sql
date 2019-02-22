USE NORTHWND 

--SELECT COUNT(CustomerID), Country FROM Customers GROUP BY Country HAVING COUNT(CustomerID)>5

--SELECT Shippers.CompanyName, COUNT(Orders.OrderID) AS NumberOfOrders FROM Orders
--LEFT JOIN Shippers ON Orders.ShipVia = Shippers.ShipperID
--GROUP BY CompanyName;

--SELECT * FROM Products
--SELECT * FROM Customers

--SELECT CategoryID, COUNT(ProductID) AS ProductCount FROM Products GROUP BY CategoryID 

--SELECT CategoryID, SUM(UnitsInStock) AS Stock FROM Products GROUP BY CategoryID 

--SELECT Products.CategoryID, SUM(Products.UnitsInStock) AS Stock, Categories.CategoryName FROM Products INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID GROUP BY Products.CategoryID, Categories.CategoryName

--SELECT Country, COUNT(*) AS CustomerCount FROM Customers GROUP BY Country HAVING COUNT(*)>5

--SELECT CategoryID, SUM(UnitPrice*UnitsInStock) AS CategoryStockValue FROM Products GROUP BY CategoryID 

--SELECT ProductName, SUM(UnitPrice*UnitsInStock) AS ProductStockValue FROM Products GROUP BY ProductName 

--CREATE VIEW [Brazil Customers] AS
--SELECT CompanyName, ContactName FROM Customers WHERE Country = 'Brazil'
--SELECT * FROM [Brazil Customers]

--CREATE VIEW [ProductStockValue] AS
--SELECT ProductName, SUM(UnitPrice*UnitsInStock) AS ProductStockValue FROM Products GROUP BY ProductName 
--SELECT * FROM [ProductStockValue]

--CREATE VIEW [CustomerxFreight] AS
--SELECT CustomerID, SUM(Freight) AS TotalFreight FROM Orders GROUP BY CustomerID
--SELECT * FROM [CustomerxFreight]

--CREATE VIEW [SmartOrderDetails] AS
--SELECT [Order Details].ProductID,Orders.CustomerID,[Order Details].Quantity FROM Orders INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID

SELECT * FROM SmartOrderDetails

--UPDATE SmartOrderDetails SET Quantity = 99 WHERE CustomerID='VINET'