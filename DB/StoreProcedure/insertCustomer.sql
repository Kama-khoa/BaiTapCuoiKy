CREATE PROCEDURE insertCustomer
@customer_name NVARCHAR(50),
@phone VARCHAR(50),
@address NVARCHAR(100)

AS
BEGIN
	INSERT INTO customers(customer_name,phone,address)
	VALUES(@customer_name,@phone,@address);
END;
drop proc insertCustomer