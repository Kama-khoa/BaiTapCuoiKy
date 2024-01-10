CREATE PROCEDURE updateCustomer
@customer_id INT,
@customer_name NVARCHAR(100),
@phone VARCHAR(20),
@address NVARCHAR(100)
AS
BEGIN
	UPDATE customers
	SET
		@customer_name=@customer_name,
		phone=@phone,
		address=@address
	WHERE customer_id=@customer_id;
END;