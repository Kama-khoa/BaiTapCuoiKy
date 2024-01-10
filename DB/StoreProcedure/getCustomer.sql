
CREATE PROCEDURE GetCustomer
AS
BEGIN
	SELECT * FROM [Laptop_Store].[dbo].[customers]
END;
EXEC GetCustomer;
DROP PROC GetCustomer