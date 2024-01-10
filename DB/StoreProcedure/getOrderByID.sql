CREATE PROCEDURE getOrderByID
@ID int
AS
BEGIN
	SELECT *
	FROM orders
	WHERE order_id=@ID;
END;
