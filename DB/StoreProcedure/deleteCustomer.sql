CREATE PROC deleteCustomer
@customer_id INT
AS 
BEGIN
	DELETE FROM customers 
	WHERE customer_id = @customer_id
END;
EXEC DeleteOrder 1