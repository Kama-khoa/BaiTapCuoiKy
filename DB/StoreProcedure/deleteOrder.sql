CREATE PROC DeleteOrder
@order_id INT
AS 
BEGIN
	DELETE FROM orders 
	WHERE order_id = @order_id
END;
EXEC DeleteOrder 1
