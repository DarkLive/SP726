--CREATE VIEW LastPart AS
--SELECT CustomerID, SUM(Freight) AS 'Total Weight' FROM Orders GROUP BY CustomerID

--CREATE FUNCTION FN_LastPart_Param(@shipvia int)
--RETURNS TABLE AS 
--RETURN SELECT * FROM Orders WHERE ShipVia = @shipvia

--SELECT * FROM FN_LastPart_Param(2)

--CREATE FUNCTION FN_OrderDetail_Quantity(@quantity smallint)
--RETURNS TABLE AS
--RETURN SELECT * FROM [Order Details] WHERE Quantity < @quantity

SELECT * FROM FN_OrderDetail_Quantity(5)