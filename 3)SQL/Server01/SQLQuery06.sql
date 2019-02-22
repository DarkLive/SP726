USE NORTHWND;

--SELECT * FROM Employees WHERE FirstName LIKE '[rla]%';

--DELETE FROM Employees WHERE FirstName='Andrew' AND EmployeeID=2;

--SELECT SUM(UnitPrice) FROM [Order Details] WHERE ProductID=51;

--SELECT CompanyName AS 'Company Name', ContactName AS 'Person In Charge' FROM Customers WHERE Country IN('Germany','Spain');

--SELECT SUM(Quantity) FROM [Order Details] WHERE UnitPrice BETWEEN 15 AND 30;

--SELECT * FROM Suppliers ORDER BY SupplierID OFFSET 10 ROWS FETCH NEXT 5 ROWS ONLY;

--SELECT * FROM Suppliers ORDER BY SupplierID ASC OFFSET 10 ROWS;

--SELECT * FROM Suppliers ORDER BY SupplierID ASC OFFSET 10 ROWS FETCH NEXT 5 ROWS ONLY;

--SELECT Products.ProductName, Suppliers.CompanyName, Suppliers.ContactName, Suppliers.Phone FROM Products INNER JOIN Suppliers ON Products.SupplierID = Suppliers.SupplierID;
