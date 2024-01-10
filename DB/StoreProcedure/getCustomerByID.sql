CREATE PROC GetCustomerByID
@customer_id INT
AS
BEGIN
	SELECT * FROM customers
	WHERE customer_id = @customer_id
END;
EXEC GetOrder