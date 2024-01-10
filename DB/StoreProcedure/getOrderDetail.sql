CREATE PROC GetOrderDetail
@order_id INT

AS
BEGIN
	SELECT order_id,price,o.quantity
	FROM order_details AS o INNER JOIN laptops AS l
	ON o.laptop_id = l.laptop_id
	WHERE order_id = @order_id 
END;
DROP PROC GetOrderDetail
EXEC GetOrderDetail 1
