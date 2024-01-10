CREATE PROCEDURE getNewOrderID

AS
BEGIN
	SELECT MAX(order_id)as max_id
	FROM orders;
END;